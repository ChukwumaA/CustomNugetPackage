using System;

namespace DocumentComponent.CustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    
    public  class DocumentAttribute : Attribute
    {
        public readonly string Description;
        public string Input;
        public string Output;
        
        public DocumentAttribute(string description, string input ="", string output ="") 
        {
            Description = description;
            Input = input;
            Output = output;
        }
        
        
    }
    
}