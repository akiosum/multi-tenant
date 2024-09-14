using UseMultiTenant.Domain.Abstractions;

namespace UseMultiTenant.Domain.Entities.Financeiro;

public class Despesa() : AudityEntity
{
    #region Properties

    public DateTime DataLancamento { get; private set; }
    public DateTime DataVencimento { get; private set; }
    public decimal Valor { get; private set; }
    public string Documento { get; private set; } = string.Empty;

    #endregion Properties

    #region Constructors

    public Despesa(
        DateTime dataLancamento, 
        DateTime dataVencimento, 
        decimal valor,
        string documento) : this()
    {
        DataLancamento = dataLancamento;
        DataVencimento = dataVencimento;
        Valor = valor;
        Documento = documento;
    }

    #endregion Constructors
}