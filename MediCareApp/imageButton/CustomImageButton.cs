using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageButton
{
    public partial class CustomImageButton: PictureBox
    {
        public CustomImageButton()
        {
            InitializeComponent();
        }

        private Image defaultImage;
        private Image hoverImage;

        public Image ImageDefault
        {
            get { 
                return defaultImage; 
            }
            set {
                defaultImage = value;
            }
        }

        public Image ImageHover
        {
            get
            {
                return hoverImage;
            }
            set
            {
                hoverImage = value;
            }
        }

        private void CustomImageButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = hoverImage;
        }

        private void CustomImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = defaultImage;
        }
    }
}
