using System;

namespace DocumentComponent.CustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    
    public sealed class DocumentAttribute : Attribute
    {
        public readonly string Description;
        public string Input;
        public string Output;
        
        public DocumentAttribute(string description)
        {
            Description = description;
            Input = "";
            Output = "";
        }
        
        public string Describe => Description;

        public string In
        {
            get => Input;
            set => Input = value;
        }

        public string Out
        {
            get => Output;
            set => Output = value;
        }
    }
    
}