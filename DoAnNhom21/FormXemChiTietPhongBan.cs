using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom21
{
    public partial class FormXemChiTietPhongBan : Form
    {
        public FormXemChiTietPhongBan()
        {
            InitializeComponent();
        }
        public void PopulateListView(ListView listView, DataTable dataTable)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            // Add columns to ListView
            foreach (DataColumn column in dataTable.Columns)
            {
                listView.Columns.Add(column.ColumnName);
            }


            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }

            // Adjust column widths
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -2;
            }
        }

    }
}
