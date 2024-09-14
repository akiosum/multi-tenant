using System.Reflection;

namespace UseMultiTenant.Domain;

public class DomainAssembly
{
    public static Assembly Assembly => typeof(DomainAssembly).Assembly;
}