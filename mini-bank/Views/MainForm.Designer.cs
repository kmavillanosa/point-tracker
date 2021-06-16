
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.grp_account_balance = new System.Windows.Forms.GroupBox();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_witdraw = new System.Windows.Forms.Button();
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.ToggleActive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ManagePanel = new System.Windows.Forms.SplitContainer();
            this.layoutpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_account_balance.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.layoutpanel.Controls.Add(this.panel1, 0, 1);
            this.layoutpanel.Controls.Add(this.panel2, 0, 2);
            this.layoutpanel.Controls.Add(this.transactionsGrid, 0, 3);
            this.layoutpanel.Controls.Add(this.panel3, 0, 0);
            this.layoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutpanel.Location = new System.Drawing.Point(0, 0);
            this.layoutpanel.Name = "layoutpanel";
            this.layoutpanel.RowCount = 4;
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.03226F));
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.96774F));
            this.layoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.layoutpanel.Size = new System.Drawing.Size(943, 569);
            this.layoutpanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.grp_account_balance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 79);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(935, 102);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.26087F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_summary, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_code, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 82);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbl_summary
            // 
            this.lbl_summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_summary.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_summary.Location = new System.Drawing.Point(167, 42);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(581, 39);
            this.lbl_summary.TabIndex = 5;
            this.lbl_summary.Text = "CLICK_TO_SELECT";
            this.lbl_summary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_summary.Click += new System.EventHandler(this.lbl_summary_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Summary:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_code
            // 
            this.lbl_code.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_code.Font = new System.Drawing.Font("Consolas", 21.75F);
            this.lbl_code.Location = new System.Drawing.Point(167, 1);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(581, 40);
            this.lbl_code.TabIndex = 3;
            this.lbl_code.Text = "NO_CODE_SPECIFIED";
            this.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_account_balance
            // 
            this.grp_account_balance.Controls.Add(this.lbl_balance);
            this.grp_account_balance.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_account_balance.Location = new System.Drawing.Point(762, 10);
            this.grp_account_balance.Margin = new System.Windows.Forms.Padding(10);
            this.grp_account_balance.Name = "grp_account_balance";
            this.grp_account_balance.Size = new System.Drawing.Size(163, 82);
            this.grp_account_balance.TabIndex = 5;
            this.grp_account_balance.TabStop = false;
            this.grp_account_balance.Text = "Current Points:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_balance.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(3, 16);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(157, 63);
            this.lbl_balance.TabIndex = 1;
            this.lbl_balance.Text = "0";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_deposit);
            this.panel2.Controls.Add(this.btn_witdraw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 42);
            this.panel2.TabIndex = 2;
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(853, 11);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(69, 23);
            this.btn_deposit.TabIndex = 2;
            this.btn_deposit.Text = "Demerit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_witdraw
            // 
            this.btn_witdraw.Location = new System.Drawing.Point(778, 11);
            this.btn_witdraw.Name = "btn_witdraw";
            this.btn_witdraw.Size = new System.Drawing.Size(69, 23);
            this.btn_witdraw.TabIndex = 3;
            this.btn_witdraw.Text = "Merit";
            this.btn_witdraw.UseVisualStyleBackColor = true;
            this.btn_witdraw.Click += new System.EventHandler(this.btn_witdraw_Click);
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToAddRows = false;
            this.transactionsGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transactionsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.transactionsGrid.BackgroundColor = System.Drawing.Color.White;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToggleActive});
            this.transactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGrid.Location = new System.Drawing.Point(4, 237);
            this.transactionsGrid.MultiSelect = false;
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.RowTemplate.Height = 30;
            this.transactionsGrid.RowTemplate.ReadOnly = true;
            this.transactionsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsGrid.Size = new System.Drawing.Size(935, 328);
            this.transactionsGrid.TabIndex = 3;
            this.transactionsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionsGrid_CellClick);
            this.transactionsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.transactionsGrid_CellFormatting);
            // 
            // ToggleActive
            // 
            this.ToggleActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ToggleActive.Frozen = true;
            this.ToggleActive.HeaderText = "State";
            this.ToggleActive.Name = "ToggleActive";
            this.ToggleActive.ReadOnly = true;
            this.ToggleActive.Width = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 68);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(838, 68);
            this.label2.TabIndex = 7;
            this.label2.Text = "Point-tracker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::point_tracker.Properties.Resources.hand_gesture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.ManagePanel.Size = new System.Drawing.Size(943, 569);
            this.ManagePanel.SplitterDistance = 25;
            this.ManagePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(943, 569);
            this.Controls.Add(this.ManagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-tracker";
            this.layoutpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grp_account_balance.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ManagePanel.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagePanel)).EndInit();
            this.ManagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Button btn_witdraw;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer ManagePanel;
        private System.Windows.Forms.GroupBox grp_account_balance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn ToggleActive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_summary;
    }
}

