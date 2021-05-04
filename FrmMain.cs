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

namespace HAL_Impromptu_Utility
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOfdExport_Click(object sender, EventArgs e)
        {
            if (opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                lblGoogleExport.Text = opnFileDlg.FileName;
            }
        }

        private void btnOfdExtract_Click(object sender, EventArgs e)
        {
            if (opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                lblHalExtract.Text = opnFileDlg.FileName;
            }
        }

        private void btnReconcile_Click(object sender, EventArgs e)
        {
            string[] gglExport = ParseGoogleExport(File.ReadAllLines(lblGoogleExport.Text));
            string[] halExtract = ParseHalExtract(File.ReadAllLines(lblHalExtract.Text));
            List<string> googleOrphans = FindGoogleOrphans(gglExport.ToList(), halExtract.ToList());
            List<string> halOrphans =FindHalOrphans(gglExport.ToList(), halExtract.ToList());
            lstGoogleOrphans.DataSource = googleOrphans;
            lstHalOrphans.DataSource = halOrphans;
        }

        private List<string> FindHalOrphans(List<string> gglExport, List<string> halExtract)
        {
            List<string> result = new List<string>();
            foreach (string member in halExtract)
            {
                if (gglExport.Contains(member) == false)
                {
                    result.Add(member);
                }
            }
            return result;
        }

        private List<string> FindGoogleOrphans(List<string> gglExport, List<string> halExtract)
        {
            List<string> result = new List<string>();
            foreach (string member in gglExport)
            {
                if (halExtract.Contains(member) == false)
                {
                    result.Add(member);
                }
            }
            return result;
        }

        private string[] ParseHalExtract(string[] extract)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < extract.Length; i++)
            {
                string[] parts = extract[i].Split(',');
                result.Add(parts[0].ToLower());
            }
            return result.ToArray();
        }

        private string[] ParseGoogleExport(string[] export)
        {
            List<string> result = new List<string>();
            for (int i = 2; i < export.Length; i++)
            {
                string[] parts = export[i].Split(',');
                result.Add(parts[0].ToLower());
            }
            return result.ToArray();
        }
    }
}
