using System;
using System.Security.Principal;

namespace ActiveDirectory
{
    class Program
    {
        public static class UserIdentity

        {
            public static string GetUser()
            {
                IntPtr accountToken = WindowsIdentity.GetCurrent().Token;
                WindowsIdentity windowsIdentity = new WindowsIdentity(accountToken);
                Console.WriteLine(windowsIdentity.Name);
                return windowsIdentity.Name;
            }
        }


    }
}
