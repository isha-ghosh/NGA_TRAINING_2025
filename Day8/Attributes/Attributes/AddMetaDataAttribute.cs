using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    //Custom defined Attribute
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    
    internal class AddMetaDataAttribute: Attribute
    {
        public string Message { get; set; }
        public AddMetaDataAttribute(string msg)
        { this.Message = msg; }

    }
}
