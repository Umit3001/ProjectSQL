
using Logic;
using Model;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;
using Timer = System.Windows.Forms.Timer;

namespace UI
{
    public partial class NoSQL : Form
    {
        private Databases databases;

        public NoSQL()
        {

            InitializeComponent();
            databases = new Databases();


        }

        private void NoSQL_Load(object sender, EventArgs e)
        {
            var dbList = databases.Get_All_Databases();

            foreach (var db in dbList)
            {
                listBox1.Items.Add(db.name);
            }
        }
    }
}

