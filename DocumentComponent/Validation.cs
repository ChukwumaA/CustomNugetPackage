using System.Reflection;
using System;
using DocumentComponent.CustomAttribute;

namespace DocumentComponent
{
    public class Validation
    {
        public void GetDocs()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                var members = type.GetMembers();
                foreach (var member in members)
                {
                    if (!(member.GetCustomAttribute(typeof(DocumentAttribute)) is DocumentAttribute attribute))
                        continue;
                    Console.WriteLine("Member: " + member.Name);
                    Console.WriteLine("Description: " + attribute.Description);
                    Console.WriteLine("Input: " + attribute.Input);
                    Console.WriteLine("Output: " + attribute.Output);
                }
            }

        }
    }
}