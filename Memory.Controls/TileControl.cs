using System.ComponentModel;

namespace Memory.Controls
{
    public partial class TileControl : UserControl
    {
        public TileControl()
        {
            InitializeComponent();
        }
        
        private void InnerControl_Click(object sender, EventArgs e)
        {
            this.OnClick(e); // wywołuje Click TileControl
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] // Atrybut
        public Image Image
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }
    }
}
