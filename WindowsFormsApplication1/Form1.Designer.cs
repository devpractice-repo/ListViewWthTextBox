namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvTable = new System.Windows.Forms.ListView();
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvTable
            // 
            this.lvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAddress,
            this.chValue});
            this.lvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTable.FullRowSelect = true;
            this.lvTable.GridLines = true;
            this.lvTable.Location = new System.Drawing.Point(0, 0);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(407, 273);
            this.lvTable.TabIndex = 0;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            this.lvTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTable_MouseDoubleClick);
            // 
            // chAddress
            // 
            this.chAddress.Text = "Address";
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 63;
            // 
            // tbCell
            // 
            this.tbCell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCell.Location = new System.Drawing.Point(276, 28);
            this.tbCell.Name = "tbCell";
            this.tbCell.Size = new System.Drawing.Size(100, 13);
            this.tbCell.TabIndex = 1;
            this.tbCell.Visible = false;
            this.tbCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCell_KeyPress);
            this.tbCell.Leave += new System.EventHandler(this.tbCell_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 273);
            this.Controls.Add(this.tbCell);
            this.Controls.Add(this.lvTable);
            this.Name = "Form1";
            this.Text = "Simple App: in-place editing  of ListView subitems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.TextBox tbCell;
    }
}

