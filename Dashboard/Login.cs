using Dashboard.HelperClasses;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dashboard
{
    public partial class Login : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Login()
        {

            InitializeComponent();


            this.Text = "In.SIST Analitika";
            UpdateTextPosition();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }



        private void UpdateTextPosition()
        {
            var basePath = Assembly.AssemblyDirectory;
            pbCover.ImageLocation = basePath + "\\Images\\Analytics.jpg";
            pbCover.SizeMode = PictureBoxSizeMode.CenterImage;
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 3) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }

       
    }
}
