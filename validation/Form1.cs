using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testactive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "andoy.kommune.no"))
            {
                bool isValid = pc.ValidateCredentials(username.Text, password.Text);
                label1.Text = isValid.ToString();
            }

            /*using (var context = new PrincipalContext(ContextType.Domain))
            {
                var usr = UserPrincipal.FindByIdentity(context, "andoy.kommune.no");
                

            }*/

        }
    }
}
