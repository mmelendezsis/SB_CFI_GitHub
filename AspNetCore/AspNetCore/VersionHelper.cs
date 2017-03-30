using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AspNetCore
{

    public static class VersionHelper
    {

        /// <summary>
            /// Return the Current Version from the AssemblyInfo.cs file.
            /// </summary>
        public static string CurrentVersion()
        {
            try
            {
                return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            }
            catch (Exception)
            {
                return "?.?.?";
            }
        }
    }
}
