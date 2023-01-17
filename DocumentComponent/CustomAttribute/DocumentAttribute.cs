using System;

namespace DocumentComponent.CustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    
    public  class DocumentAttribute : Attribute
    {
        public readonly string Description;
        public string Input;
        public string Output;
        
        public DocumentAttribute(string description)
        {
            Description = description;
            Input = string.Empty;
            Output = string.Empty;
        }
        
    }
    
}