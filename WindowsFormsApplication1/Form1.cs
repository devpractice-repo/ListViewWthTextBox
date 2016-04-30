using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool CancelEdit = false;
        private ListViewItem.ListViewSubItem CurrentSubItem = default(ListViewItem.ListViewSubItem);
        private ListViewItem CurrentItem = default(ListViewItem);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Table filler
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                lvi.SubItems.Add(rnd.Next(0, 100).ToString());
                lvTable.Items.Add(lvi);
            }
        }

        private void lvTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Get current item of ListView
            CurrentItem = lvTable.GetItemAt(e.X, e.Y);
            if (CurrentItem == null)
                return;

            // Get sub item of current item
            CurrentSubItem = CurrentItem.GetSubItemAt(e.X, e.Y);

            int SubItembIndex = CurrentItem.SubItems.IndexOf(CurrentSubItem);

            // Check that we try edit column "Value"
            switch (SubItembIndex)
            {
                case 1:
                    break;
                default:
                    return;
            }
            
            // Set params for TextBox, show it and set focus
            int lLeft = CurrentSubItem.Bounds.Left + 2;
            int lWidth = CurrentSubItem.Bounds.Width - 2;
            tbCell.SetBounds(lLeft + lvTable.Left, CurrentSubItem.Bounds.Top + lvTable.Top, lWidth, CurrentSubItem.Bounds.Height);
            tbCell.Text = CurrentSubItem.Text;
            tbCell.Show();
            tbCell.Focus();
        }

        private void tbCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                // If you press Enter than copy data from TextBox to ListView cell
                case (char)Keys.Return:
                    CancelEdit = false;
                    e.Handled = true;
                    tbCell.Hide();
                    break;

                // If you press Escape than data in ListView cell stay without changes
                case (char)Keys.Escape:
                    CancelEdit = true;
                    e.Handled = true;
                    tbCell.Hide();
                    break;
            }
        }

        private void tbCell_Leave(object sender, EventArgs e)
        {
            tbCell.Hide();

            if (CancelEdit == false)
            {               
                CurrentSubItem.Text = tbCell.Text;
            }
            else
            {
                CancelEdit = false;
            }

            lvTable.Focus();
        }
    }
}

