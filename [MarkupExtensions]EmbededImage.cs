//How to use it:
//Put it in Project/PCL/MarkupExtensions
//Add xmlns:local="clr-namespace:HelloWorld;assembly=HelloWorld"
//Usage:<Image Source="local:EmbededImage imageId" /> 

using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace HelloWorld
{
    [ContentProperty("ResourceId")]
    public class EmbededImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;
            return ImageSource.FromResource(ResourceId);
        }
    }
}
