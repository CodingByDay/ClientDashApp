using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    public partial class Dashboard : MaterialForm
    {
        private Login login;

        public Dashboard()
        {
            ConfigureTheLook();
            InitializeComponent();

            Login();

            logout.Click += Logout_Click;

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ConfigureTheLook()
        {
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

        private void Login()
        {
            int count = 3;
            login = new Login();


            while (count > 0)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    MaterialTextBox uname = (MaterialTextBox)login.Controls["uname"];
                    MaterialTextBox pwd = (MaterialTextBox)login.Controls["pwd"];


                    if (CanLogin(uname, pwd))
                    {
                        count = -1;
                        this.Text = "Welcome" + " " + uname.Text;

                    }
                    else
                    {
                        count--;
                        MessageBox.Show($"Failed login attempt, you have {count} more attempt");
                    }
                }

            }

            login.Dispose();


            if (count == 0)
            {
                System.Environment.Exit(0);
            }
        }
        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private bool CanLogin(MaterialTextBox uname, MaterialTextBox pwd)
        {
            string Uname = uname.Text;
            string Pwd = Hash(pwd.Text);
            var ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            using (SqlCommand StrQuer = new SqlCommand("SELECT * FROM Users WHERE uname=@userid AND Pwd=@password", conn))
            {
                StrQuer.Parameters.AddWithValue("@userid", Uname);
                StrQuer.Parameters.AddWithValue("@password", Pwd);
                SqlDataReader dr = StrQuer.ExecuteReader();

                if (dr.HasRows)
                {
                    conn.Close();

                    return true;
                }
                else
                {
                    conn.Close();

                    return false;
                }
            }

        }

    }
}
