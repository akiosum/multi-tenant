using System.Reflection;

namespace UseMultiTenant.Infra;

public class InfrastructureAssembly
{
    public static Assembly Assembly => typeof(InfrastructureAssembly).Assembly;
}