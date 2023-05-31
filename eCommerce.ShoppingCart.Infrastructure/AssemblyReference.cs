using System.Reflection;

namespace eCommerce.ShoppingCart.Infrastructure;

public static class AssemblyReference
{
    public static Assembly Assembly => Assembly.GetExecutingAssembly();
}
