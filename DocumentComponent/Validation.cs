using System;
using System.Linq;
using System.Reflection;
using DocumentComponent.CustomAttribute;

namespace DocumentComponent
{
    public static class Validation
    {
        public static void GetDocs(Type type)
        {
            GetClass(type);
            GetMethods(type);
            GetProperties(type);
        }

        private static void GetClass(ICustomAttributeProvider type)
        {
            Console.WriteLine($"Assembly: {Assembly.GetExecutingAssembly()}");
            var classInfo = type.GetCustomAttributes(true);
            foreach (var attribute in classInfo)
            {
                if (attribute is DocumentAttribute attributeDescriptionAndInput)
                {
                    Console.WriteLine($"{attributeDescriptionAndInput.Description} " +
                                      $"{attributeDescriptionAndInput.Input}\n");
                }
            }
        }
        
        private static void GetMethods(Type type)
        {
            var getMethods = type.GetMethods();
            for (var i = 0; i < getMethods.GetLength(0); i++)
            {
                var methodInfo = getMethods[i].GetCustomAttributes(true);

                foreach (var documents in methodInfo.Cast<Attribute>())
                {
                    if (documents is DocumentAttribute attribute)
                    {
                        Console.WriteLine(attribute.Description+"\n");
                    }
                }
            }
        }

        private static void GetProperties(Type type)
        {
            var propertyInfos = type.GetProperties();
            foreach (var t in propertyInfos)
            {
                var properties = t.GetCustomAttributes(true);
                foreach (var myProperties in properties.Cast<Attribute>())
                {
                    if (myProperties is DocumentAttribute attribute)
                    {
                        Console.WriteLine($"{attribute.Description}\n");
                    }
                }
            }
        }
        
        
       
    }
}