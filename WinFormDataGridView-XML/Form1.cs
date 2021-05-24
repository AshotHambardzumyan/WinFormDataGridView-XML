using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WinFormDataGridView_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetXml_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"D:\folder\users.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnWriteXml_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromDGV(dataGridView1);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite(@"D:\folder\users.xml"));
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

        private void ClearXml_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"D:\folder\users.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode firstNode = xRoot.FirstChild;
            xRoot.RemoveChild(firstNode);
            xDoc.Save(@"D:\folder\users.xml");

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"D:\folder\users.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
