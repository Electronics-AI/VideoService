namespace VideoService.Core.Interfaces.Infrastructure.Validators
{
    public interface IValidator<in T>
    {
        ValidationResult Validate(T model);
    }
}