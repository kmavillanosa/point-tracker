
namespace mini_bank
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_lbl_code_change = new System.Windows.Forms.LinkLabel();
            this.lbl_code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_account_balance = new System.Windows.Forms.GroupBox();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_witdraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.ManagePanel = new System.Windows.Forms.SplitContainer();
            this.layoutpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_account_balance.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagePanel)).BeginInit();
            this.ManagePanel.Panel1.SuspendLayout();
            this.ManagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutpanel
            // 
            this.layoutpanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.layoutpanel.ColumnCount = 1;
            this.layoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutpanel.Controls.Add(this.panel1, 0, 0);
            this.layoutpanel.Controls.Add(this.panel2, 0, 1);
            this.layoutpanel.Controls.Add(this.transactionsGrid, 0, 2);
            this.layoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutpanel.Location = new System.Drawing.Point(0, 0);
            this.layoutpanel.Name = "layoutpanel";
            this.layoutpanel.RowCount = 3;
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 428F));
            this.layoutpanel.Size = new System.Drawing.Size(605, 585);
            this.layoutpanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.link_lbl_code_change);
            this.panel1.Controls.Add(this.lbl_code);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grp_account_balance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(597, 92);
            this.panel1.TabIndex = 1;
            // 
            // link_lbl_code_change
            // 
            this.link_lbl_code_change.AutoSize = true;
            this.link_lbl_code_change.Location = new System.Drawing.Point(108, 10);
            this.link_lbl_code_change.Name = "link_lbl_code_change";
            this.link_lbl_code_change.Size = new System.Drawing.Size(43, 13);
            this.link_lbl_code_change.TabIndex = 4;
            this.link_lbl_code_change.TabStop = true;
            this.link_lbl_code_change.Text = "change";
            this.link_lbl_code_change.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_code_change_LinkClicked);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(21, 29);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(108, 36);
            this.lbl_code.TabIndex = 3;
            this.lbl_code.Text = "C-O-D-E";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Code:";
            // 
            // grp_account_balance
            // 
            this.grp_account_balance.Controls.Add(this.lbl_balance);
            this.grp_account_balance.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_account_balance.Location = new System.Drawing.Point(424, 10);
            this.grp_account_balance.Margin = new System.Windows.Forms.Padding(10);
            this.grp_account_balance.Name = "grp_account_balance";
            this.grp_account_balance.Size = new System.Drawing.Size(163, 72);
            this.grp_account_balance.TabIndex = 5;
            this.grp_account_balance.TabStop = false;
            this.grp_account_balance.Text = "Current Account Balance:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_balance.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(3, 16);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(157, 53);
            this.lbl_balance.TabIndex = 1;
            this.lbl_balance.Text = "₱ 0.00";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_deposit);
            this.panel2.Controls.Add(this.btn_witdraw);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 48);
            this.panel2.TabIndex = 2;
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(509, 11);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(69, 23);
            this.btn_deposit.TabIndex = 2;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_witdraw
            // 
            this.btn_witdraw.Location = new System.Drawing.Point(434, 11);
            this.btn_witdraw.Name = "btn_witdraw";
            this.btn_witdraw.Size = new System.Drawing.Size(69, 23);
            this.btn_witdraw.TabIndex = 3;
            this.btn_witdraw.Text = "Witdraw";
            this.btn_witdraw.UseVisualStyleBackColor = true;
            this.btn_witdraw.Click += new System.EventHandler(this.btn_witdraw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Transaction Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToAddRows = false;
            this.transactionsGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transactionsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.BackgroundColor = System.Drawing.Color.White;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGrid.Location = new System.Drawing.Point(4, 158);
            this.transactionsGrid.MultiSelect = false;
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsGrid.Size = new System.Drawing.Size(597, 423);
            this.transactionsGrid.TabIndex = 3;
            // 
            // ManagePanel
            // 
            this.ManagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagePanel.Location = new System.Drawing.Point(0, 0);
            this.ManagePanel.Name = "ManagePanel";
            // 
            // ManagePanel.Panel1
            // 
            this.ManagePanel.Panel1.Controls.Add(this.layoutpanel);
            this.ManagePanel.Panel2Collapsed = true;
            this.ManagePanel.Panel2MinSize = 100;
            this.ManagePanel.Size = new System.Drawing.Size(605, 585);
            this.ManagePanel.SplitterDistance = 25;
            this.ManagePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(605, 585);
            this.Controls.Add(this.ManagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini-Bank";
            this.layoutpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_account_balance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.ManagePanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagePanel)).EndInit();
            this.ManagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_witdraw;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.LinkLabel link_lbl_code_change;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer ManagePanel;
        private System.Windows.Forms.GroupBox grp_account_balance;
    }
}

