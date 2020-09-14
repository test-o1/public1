using System;

namespace NugetLibrary
{
    public class TestVersion
    {
        public string GetAssemblyVersion()
        {
            return $"v{GetType().Assembly.GetName().Version.ToString()}";
        }
    }
}
