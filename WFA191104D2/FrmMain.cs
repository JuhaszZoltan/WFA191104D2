using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191104D2
{
    public partial class FrmMain : Form
    {
        static List<Alkalmazott> szabaduszok;
        public FrmMain()
        {
            InitializeComponent();
            Beolvas();
            CbFeltolt();
        }

        private void CbFeltolt()
        {
            foreach (var a in szabaduszok)
            {
                if (!cbOrszag.Items.Contains(a.Orszag)) cbOrszag.Items.Add(a.Orszag);
            }
            cbOrszag.SelectedIndex = 0;
        }

        private static void Beolvas()
        {
            szabaduszok = new List<Alkalmazott>();
            var sr = new StreamReader("adatok.csv");
            while (!sr.EndOfStream)
            {
                szabaduszok.Add(new Alkalmazott(sr.ReadLine()));
            }
            sr.Close();
        }

        private void tbKeres_TextChanged(object sender, EventArgs e)
        {
            int db = 0;
            int index = -1;

            for (int i = 0; i < szabaduszok.Count; i++)
            {
                if (szabaduszok[i].Nev.StartsWith(tbKeres.Text))
                {
                    db++;
                    index = i;
                }
            }

            lblDbTalalat.Text = db + "";

            lblNev.Text = (db == 1) ? szabaduszok[index].Nev : "---";
            lblOrszag.Text = (db == 1) ? szabaduszok[index].Orszag : "---";
            lblSzul.Text = (db == 1) ? szabaduszok[index].Szul.ToString("yyyy.MM.dd") : "---";
            lblOs.Text = (db == 1) ? szabaduszok[index].OS : "---";
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            //nev
            int i = 0;
            while (i < szabaduszok.Count && szabaduszok[i].Nev != tbNev.Text) i++;

            if (i < szabaduszok.Count &&
                !string.IsNullOrEmpty(tbNev.Text) //fak
                ) MessageBox.Show("vannmárilyennév");

            //dtp
            else if (dtpSzul.Value > new DateTime(2005, 12, 31) ||
                dtpSzul.Value < new DateTime(1960, 01, 01))
            {
                MessageBox.Show("nemjódátum");
            }
            //rb => autores
            // cb => ui sol
            else
            {
                string ostext;
                if (rbAnd.Checked) ostext = "Android";
                else if (rbIos.Checked) ostext = "IOS";
                else ostext = "Windows";

                var sw = new StreamWriter("adatok.csv", true, Encoding.UTF8);

                sw.WriteLine("{0};{1};{2};{3}",
                    tbNev.Text,
                    ostext,
                    dtpSzul.Value.ToString("yyyy-MM-dd"), 
                    cbOrszag.SelectedItem.ToString());
                sw.Close();

                MessageBox.Show("namegvanakettesbazdmeg");
            }
        }
    }
}
