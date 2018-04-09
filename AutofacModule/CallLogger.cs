using System.Diagnostics;
using Castle.DynamicProxy;

namespace AutofacModule
{
    public class CallLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine($"> {invocation.Method.Name}");

            invocation.Proceed();

            Debug.WriteLine($"< {invocation.Method.Name}");
        }
    }
}