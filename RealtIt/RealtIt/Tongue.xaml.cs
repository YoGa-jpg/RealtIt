using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RealtIt
{
    /// <summary>
    /// Interaction logic for Tongue.xaml
    /// </summary>
    public partial class Tongue : UserControl
    {
        public ImageSource imageSource
        {
            set => ger.Source = value;
            get => ger.Source;
        }
        public void SetArrowState(ArrowState state)
        {
            if (state.Equals(ArrowState.Down))
                ArrowImage.RenderTransform = new RotateTransform(180);
            else if (state.Equals(ArrowState.None))
                ArrowImage.Source = null;
        }
        public string StrokeDashSet
        {
            set
            {
                RectPart.StrokeDashArray = (new DoubleCollectionConverter().ConvertFromString(value) as DoubleCollection);
                TrianglePart.StrokeDashArray = (new DoubleCollectionConverter().ConvertFromString(value) as DoubleCollection);
            }
        }
        public Tongue()
        {
            InitializeComponent();
        }
    }
    public enum ArrowState
    {
        Up,
        Down,
        None
    }
}
