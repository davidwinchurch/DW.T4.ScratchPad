using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DW.T4.Model
{
    public class T4Helper
    {
        private const string AssemblyName = "DW.T4.Model";

        public static IEnumerable<string> GetModelTypeNames()
        {
            var modelAssembly = Assembly.Load(AssemblyName);
            var types = modelAssembly.GetTypes();//.Where(t => t.Namespace != null && t.Namespace.Contains(".Model."));
            return types.Select(c => c.Name);
        }

        public static IEnumerable<string> GetPropertyNames(string modelClassName)
        {
            var modelAssembly = Assembly.Load(AssemblyName);
            var type = modelAssembly.GetType(modelClassName);
            var propertyInfos = type.GetProperties();
            return propertyInfos.Select(c => c.Name);
        }
    }
}
