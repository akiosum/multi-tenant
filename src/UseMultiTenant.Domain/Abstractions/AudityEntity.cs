namespace UseMultiTenant.Domain.Abstractions;

public abstract class AudityEntity : Entity
{
    public DateTime DataCriacao { get; private set; } = DateTime.Now;
}