using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Error003AddonManager
{
    public class AddonManager<T>
    {
        ///<summary>
        ///<para> Searches for all DLLs with the provided type and returns them as a list </para>
        ///<para> Can optionally pass in a folder name for the addons </para>
        ///</summary>
        public static List<T> ReadAddons(string addonLocations = "addons")
        {
            var addonList = new List<T>();
            // Read all DLLs from Addons folder
            var files = Directory.GetFiles(addonLocations, "*.dll");

            // Read assembly from files
            foreach (var file in files)
            {
                var assembly = Assembly.LoadFile(Path.Combine(Directory.GetCurrentDirectory(), file));

                // Extract all types that use T interface
                var addonTypes = assembly.GetTypes().Where(t => typeof(T).IsAssignableFrom(t) && !t.IsInterface).ToArray();

                foreach (var addonType in addonTypes)
                {
                    // Create instance from extracted type
                    var addonInstance = (T)Activator.CreateInstance(addonType);
                    addonList.Add(addonInstance);
                }
            }

            if (addonList.Count == 0)
            {
                throw new NoAddonsFoundException("No Addons Found");
            }

            return addonList;
        }
    }

    public class NoAddonsFoundException : Exception
    {
        public NoAddonsFoundException()
        {
        }

        public NoAddonsFoundException(string message)
            : base(message)
        {
        }

    }
}
