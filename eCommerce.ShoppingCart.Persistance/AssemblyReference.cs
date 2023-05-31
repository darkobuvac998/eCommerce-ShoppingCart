using System.Reflection;

namespace eCommerce.ShoppingCart.Persistance;

public static class AssemblyReference
{
    public static Assembly Assembly => Assembly.GetExecutingAssembly();
}
