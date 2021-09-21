
namespace Dash
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uname = new MaterialSkin.Controls.MaterialTextBox();
            this.pwd = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btLogin = new MaterialSkin.Controls.MaterialButton();
            this.pbCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uname.Depth = 0;
            this.uname.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.uname.LeadingIcon = null;
            this.uname.Location = new System.Drawing.Point(468, 318);
            this.uname.MaxLength = 50;
            this.uname.MouseState = MaterialSkin.MouseState.OUT;
            this.uname.Multiline = false;
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(507, 50);
            this.uname.TabIndex = 0;
            this.uname.Text = "";
            this.uname.TrailingIcon = null;
            // 
            // pwd
            // 
            this.pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwd.Depth = 0;
            this.pwd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pwd.LeadingIcon = null;
            this.pwd.Location = new System.Drawing.Point(468, 428);
            this.pwd.MaxLength = 50;
            this.pwd.MouseState = MaterialSkin.MouseState.OUT;
            this.pwd.Multiline = false;
            this.pwd.Name = "pwd";
            this.pwd.Password = true;
            this.pwd.Size = new System.Drawing.Size(507, 50);
            this.pwd.TabIndex = 1;
            this.pwd.Text = "";
            this.pwd.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(228, 318);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 20);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Uporabniško ime";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(228, 428);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(41, 20);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Geslo";
            // 
            // btLogin
            // 
            this.btLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btLogin.Depth = 0;
            this.btLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btLogin.HighEmphasis = true;
            this.btLogin.Icon = null;
            this.btLogin.Location = new System.Drawing.Point(468, 539);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(81, 36);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Prijava";
            this.btLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btLogin.UseAccentColor = false;
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(468, 124);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(501, 132);
            this.pbCover.TabIndex = 5;
            this.pbCover.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 448);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox uname;
        private MaterialSkin.Controls.MaterialTextBox pwd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btLogin;
        private System.Windows.Forms.PictureBox pbCover;
    }
}

