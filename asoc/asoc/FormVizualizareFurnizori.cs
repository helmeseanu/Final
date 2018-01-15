using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace asoc
{
    public partial class FormVizualizareFurnizori : Form
    {
        public FormVizualizareFurnizori()
        {
            try
            {
                InitializeComponent();

                using (var context = new Asociatie_ProprietariEntities())
                {
                    var results = (from c in context.Furnizori
                                   select new
                                   {
                                       c.CUI,
                                       c.Nume,
                                       c.Email,
                                       c.Serviciu,
                                       c.Data_semnare_contract,
                                       c.Data_expirare_contract
                                   });

                    dataGridView1.DataSource = results.ToList();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("errors.txt", "Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace + "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                string New = Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine;
                File.AppendAllText("errors.txt", New);
                MessageBox.Show("Contacteaza dezvoltatorul!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
