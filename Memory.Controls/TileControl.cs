using System.ComponentModel;

namespace Memory.Controls
{
    public partial class TileControl : UserControl
    {
        public TileControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }
    }
}
