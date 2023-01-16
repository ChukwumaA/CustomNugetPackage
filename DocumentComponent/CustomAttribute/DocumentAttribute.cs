using System;

namespace DocumentComponent.CustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    
    public class DocumentAttribute : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        
        public DocumentAttribute(string description)
        {
            Description = description;
        }
        
        
    }
    
}