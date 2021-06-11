
namespace MiniBank.Views
{
    partial class CreateTransaction
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
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_amt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_remarks = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_remarks.Location = new System.Drawing.Point(4, 49);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(77, 174);
            this.lbl_remarks.TabIndex = 5;
            this.lbl_remarks.Text = "Remarks";
            this.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_amount
            // 
            this.txt_amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_amount.Location = new System.Drawing.Point(88, 4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(355, 20);
            this.txt_amount.TabIndex = 0;
            // 
            // txt_type
            // 
            this.txt_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_type.Location = new System.Drawing.Point(88, 29);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(355, 20);
            this.txt_type.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.77637F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.22363F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_remarks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_type, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_amount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_remarks, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_type, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_amt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.06383F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.93617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 267);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbl_type
            // 
            this.lbl_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_type.Location = new System.Drawing.Point(4, 26);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(77, 22);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "Type";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_amt
            // 
            this.lbl_amt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_amt.Location = new System.Drawing.Point(4, 1);
            this.lbl_amt.Name = "lbl_amt";
            this.lbl_amt.Size = new System.Drawing.Size(77, 24);
            this.lbl_amt.TabIndex = 3;
            this.lbl_amt.Text = "Amount";
            this.lbl_amt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 36);
            this.panel1.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(302, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(383, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_remarks.Location = new System.Drawing.Point(88, 52);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(355, 168);
            this.txt_remarks.TabIndex = 2;
            this.txt_remarks.Text = "";
            // 
            // CreateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 267);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Transaction";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_remarks;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.RichTextBox txt_remarks;
        private System.Windows.Forms.Label lbl_amt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}