using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DW.T4
{
    public class ModelT4Helper
    {
        private static readonly Regex CapitalsRegex = new Regex("[A-Z]");

        public static IEnumerable<Type> GetModelDtoTypes(string assemblyName)
        {
            var modelAssembly = Assembly.Load(assemblyName);
            var types = modelAssembly.GetTypes().Where(t => t.IsClass);
            return types;
        }

        public static string GetRelativeNamespace(Type modelType)
        {
            var assemblyName = modelType.Assembly.FullName;
            if (assemblyName.Contains(","))
            {
                assemblyName = assemblyName.Substring(0, assemblyName.IndexOf(",", StringComparison.Ordinal));
            }
            var relativeNamespace = string.Empty;
            if (modelType.Namespace != null)
            {
                relativeNamespace = modelType.Namespace.Replace(assemblyName, "");
            }
            return relativeNamespace;
        }

        public static OrderedDictionary GetPropertyAbbreviations(Type modelType)
        {
            var propertyInfos = modelType.GetProperties();
            var propertyAbbreviations = new OrderedDictionary(propertyInfos.Length);
            foreach (var propertyInfo in propertyInfos)
            {
                var propertyName = propertyInfo.Name;
                var matches = CapitalsRegex.Matches(propertyName).Cast<Match>();
                var abbreviation = string.Join("", matches.Select(m => m.Value)).ToLower();
                propertyAbbreviations[propertyName] = abbreviation;
            }
            return propertyAbbreviations;
        }
    }
}
