
namespace Dashboard
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
            this.uname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pbCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();

           


            this.uname.Depth = 0;
            this.uname.Hint = "";
            this.uname.Location = new System.Drawing.Point(353, 315);
            this.uname.MouseState = MaterialSkin.MouseState.HOVER;
            this.uname.Name = "uname";
            this.uname.PasswordChar = '\0';
            this.uname.SelectedText = "";
            this.uname.SelectionLength = 0;
            this.uname.SelectionStart = 0;
            this.uname.Size = new System.Drawing.Size(493, 32);
            this.uname.TabIndex = 0;
            this.uname.UseSystemPasswordChar = false;
            // 
            // pwd
            // 
            this.pwd.Depth = 0;
            this.pwd.Hint = "";
            this.pwd.Location = new System.Drawing.Point(353, 398);
            this.pwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '\0';
            this.pwd.SelectedText = "";
            this.pwd.SelectionLength = 0;
            this.pwd.SelectionStart = 0;
            this.pwd.Size = new System.Drawing.Size(493, 32);
            this.pwd.TabIndex = 1;
            this.pwd.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialRaisedButton1.Location = new System.Drawing.Point(353, 482);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(278, 70);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Prijava";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;

            materialLabel1


            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(57, 315);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(175, 27);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Uporabniško ime";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(57, 403);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 27);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Geslo";

            materialLabel3


            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(425, 146);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 27);
            this.materialLabel3.TabIndex = 5;

            pbCover


            this.pbCover.Location = new System.Drawing.Point(353, 116);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(493, 164);
            this.pbCover.TabIndex = 6;
            this.pbCover.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 664);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField uname;
        private MaterialSkin.Controls.MaterialSingleLineTextField pwd;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pbCover;
    }
}

