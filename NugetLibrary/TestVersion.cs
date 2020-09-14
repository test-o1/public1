using System;

namespace NugetLibrary
{
    public class TestVersion
    {
        public string GetAssemblyVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
