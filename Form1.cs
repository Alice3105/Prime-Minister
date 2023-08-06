using PrimeMinisters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms.VisualStyles;

namespace PrimeMinsters
{
    public partial class frmPrimeMinisters : Form
    {
        private Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>();
        public frmPrimeMinisters()
        {
            InitializeComponent();
        }

        private void frmPrimeMinisters_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("PrimeMinisters.json");
            primeMinisters = JsonSerializer.Deserialize<Dictionary<string, PrimeMinister>>(reader.ReadToEnd());
            reader.Close();
            lstPrimeMinisters.DataSource = primeMinisters.Keys.ToList<string>();
        }

     

        private void lstPrimeMinisters_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedPMKey = lstPrimeMinisters.SelectedValue.ToString();

            PrimeMinister primeMinister = primeMinisters[selectedPMKey];

            lblName.Text = primeMinister.FirstName + " " + primeMinister.LastName;
            lblTerm.Text = "Term: " + primeMinister.Term;
            lblParty.Text = "Party: " + primeMinister.Party;
            string filename = primeMinister.LastName + ".jpg";
            picPhoto.ImageLocation = filename;

        }
    }
}
