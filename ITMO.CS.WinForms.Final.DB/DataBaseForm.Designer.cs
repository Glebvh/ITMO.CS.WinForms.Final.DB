namespace ITMO.CS.WinForms.Final.DB
{
    partial class DataBaseForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAdd_Item = new System.Windows.Forms.TextBox();
            this.textBoxAdd_Color = new System.Windows.Forms.TextBox();
            this.textBoxAdd_Qty = new System.Windows.Forms.TextBox();
            this.textBoxDel_ID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(567, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 253);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBoxAdd_Item
            // 
            this.textBoxAdd_Item.Location = new System.Drawing.Point(13, 287);
            this.textBoxAdd_Item.Name = "textBoxAdd_Item";
            this.textBoxAdd_Item.Size = new System.Drawing.Size(285, 22);
            this.textBoxAdd_Item.TabIndex = 6;
            this.textBoxAdd_Item.Enter += new System.EventHandler(this.textBoxAdd_Item_Enter);
            // 
            // textBoxAdd_Color
            // 
            this.textBoxAdd_Color.Location = new System.Drawing.Point(13, 325);
            this.textBoxAdd_Color.Name = "textBoxAdd_Color";
            this.textBoxAdd_Color.Size = new System.Drawing.Size(285, 22);
            this.textBoxAdd_Color.TabIndex = 7;
            this.textBoxAdd_Color.Enter += new System.EventHandler(this.textBoxAdd_Color_Enter);
            // 
            // textBoxAdd_Qty
            // 
            this.textBoxAdd_Qty.Location = new System.Drawing.Point(13, 367);
            this.textBoxAdd_Qty.Name = "textBoxAdd_Qty";
            this.textBoxAdd_Qty.Size = new System.Drawing.Size(285, 22);
            this.textBoxAdd_Qty.TabIndex = 8;
            this.textBoxAdd_Qty.Enter += new System.EventHandler(this.textBoxAdd_Qty_Enter);
            // 
            // textBoxDel_ID
            // 
            this.textBoxDel_ID.Location = new System.Drawing.Point(340, 287);
            this.textBoxDel_ID.Name = "textBoxDel_ID";
            this.textBoxDel_ID.Size = new System.Drawing.Size(285, 22);
            this.textBoxDel_ID.TabIndex = 9;
            this.textBoxDel_ID.Enter += new System.EventHandler(this.textBoxDel_ID_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(13, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 27);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseMnemonic = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(340, 323);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(285, 27);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(637, 444);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxDel_ID);
            this.Controls.Add(this.textBoxAdd_Qty);
            this.Controls.Add(this.textBoxAdd_Color);
            this.Controls.Add(this.textBoxAdd_Item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBaseForm";
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAdd_Item;
        private System.Windows.Forms.TextBox textBoxAdd_Color;
        private System.Windows.Forms.TextBox textBoxAdd_Qty;
        private System.Windows.Forms.TextBox textBoxDel_ID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
    }
}