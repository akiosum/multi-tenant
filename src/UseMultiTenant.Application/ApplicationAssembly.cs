using System.Reflection;

namespace UseMultiTenant.Application;

public class ApplicationAssembly
{
    public static Assembly Assembly => typeof(ApplicationAssembly).Assembly;
}