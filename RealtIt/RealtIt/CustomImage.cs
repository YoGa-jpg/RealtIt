using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RealtIt
{
    public class CustomImage
    {
        public ImageSource imageSource { get; set; }

        public CustomImage(string imageSource)
        {
            this.imageSource = new ImageSourceConverter().ConvertFromString(new FileInfo(imageSource).FullName) as ImageSource;
        }
    }
}
