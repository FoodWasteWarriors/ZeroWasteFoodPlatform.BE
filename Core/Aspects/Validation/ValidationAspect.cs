using Castle.DynamicProxy;
using Core.Utils.Interceptors;
using Core.Utils.Validation.FluentValidation;
using FluentValidation;

namespace Core.Aspects.Validation;

public class ValidationAspect : MethodInterception
{
    private readonly Type _validatorType;

    public ValidationAspect(Type validatorType)
    {
        _validatorType = validatorType;
    }

    protected override void OnBefore(IInvocation invocation)
    {
        var validator = (IValidator)Activator.CreateInstance(_validatorType)!;
        var entityType = _validatorType.BaseType!.GetGenericArguments()[0];
        var entities = invocation.Arguments.Where(t => t.GetType() == entityType);

        foreach (var entity in entities)
            ValidationTool.Validate(validator, entity);
    }
}