namespace AstronomicalProcessing
{
    partial class AstronomicalProcessingForm
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
            this.components = new System.ComponentModel.Container();
            this.GB_SearchData = new System.Windows.Forms.GroupBox();
            this.BTN_LoadData = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TB_InputSearchValue = new System.Windows.Forms.TextBox();
            this.BTN_Sort = new System.Windows.Forms.Button();
            this.LB_EnterValue = new System.Windows.Forms.Label();
            this.LBx_NeutrinoData = new System.Windows.Forms.ListBox();
            this.LBL_NeutrinoData = new System.Windows.Forms.Label();
            this.GB_EditData = new System.Windows.Forms.GroupBox();
            this.TB_SaveData = new System.Windows.Forms.TextBox();
            this.BTN_EditData = new System.Windows.Forms.Button();
            this.BTN_SaveData = new System.Windows.Forms.Button();
            this.TB_EditData = new System.Windows.Forms.TextBox();
            this.LB_EditData = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LBL_Welcome = new System.Windows.Forms.Label();
            this.LBL_ProjectDescription = new System.Windows.Forms.Label();
            this.GB_SearchData.SuspendLayout();
            this.GB_EditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_SearchData
            // 
            this.GB_SearchData.BackColor = System.Drawing.Color.LightSlateGray;
            this.GB_SearchData.Controls.Add(this.BTN_LoadData);
            this.GB_SearchData.Controls.Add(this.BTN_Search);
            this.GB_SearchData.Controls.Add(this.TB_InputSearchValue);
            this.GB_SearchData.Controls.Add(this.BTN_Sort);
            this.GB_SearchData.Controls.Add(this.LB_EnterValue);
            this.GB_SearchData.Controls.Add(this.LBx_NeutrinoData);
            this.GB_SearchData.Controls.Add(this.LBL_NeutrinoData);
            this.GB_SearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_SearchData.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_SearchData.Location = new System.Drawing.Point(11, 197);
            this.GB_SearchData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_SearchData.Name = "GB_SearchData";
            this.GB_SearchData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_SearchData.Size = new System.Drawing.Size(418, 340);
            this.GB_SearchData.TabIndex = 0;
            this.GB_SearchData.TabStop = false;
            this.GB_SearchData.Text = "Search Data";
            // 
            // BTN_LoadData
            // 
            this.BTN_LoadData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_LoadData.Location = new System.Drawing.Point(261, 61);
            this.BTN_LoadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_LoadData.Name = "BTN_LoadData";
            this.BTN_LoadData.Size = new System.Drawing.Size(116, 39);
            this.BTN_LoadData.TabIndex = 6;
            this.BTN_LoadData.Text = "Load Data";
            this.BTN_LoadData.UseVisualStyleBackColor = true;
            this.BTN_LoadData.Click += new System.EventHandler(this.BTN_LoadData_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_Search.Location = new System.Drawing.Point(261, 257);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(122, 44);
            this.BTN_Search.TabIndex = 5;
            this.BTN_Search.Text = "Perform Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TB_InputSearchValue
            // 
            this.TB_InputSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_InputSearchValue.Location = new System.Drawing.Point(272, 219);
            this.TB_InputSearchValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_InputSearchValue.Name = "TB_InputSearchValue";
            this.TB_InputSearchValue.Size = new System.Drawing.Size(112, 26);
            this.TB_InputSearchValue.TabIndex = 4;
            // 
            // BTN_Sort
            // 
            this.BTN_Sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Sort.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_Sort.Location = new System.Drawing.Point(261, 113);
            this.BTN_Sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Sort.Name = "BTN_Sort";
            this.BTN_Sort.Size = new System.Drawing.Size(116, 41);
            this.BTN_Sort.TabIndex = 3;
            this.BTN_Sort.Text = "Sort";
            this.BTN_Sort.UseVisualStyleBackColor = true;
            this.BTN_Sort.Click += new System.EventHandler(this.BTN_Sort_Click);
            // 
            // LB_EnterValue
            // 
            this.LB_EnterValue.AutoSize = true;
            this.LB_EnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterValue.Location = new System.Drawing.Point(243, 192);
            this.LB_EnterValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_EnterValue.Name = "LB_EnterValue";
            this.LB_EnterValue.Size = new System.Drawing.Size(150, 15);
            this.LB_EnterValue.TabIndex = 2;
            this.LB_EnterValue.Text = "Enter value to search: ";
            this.LB_EnterValue.Click += new System.EventHandler(this.LB_EnterValue_Click);
            // 
            // LBx_NeutrinoData
            // 
            this.LBx_NeutrinoData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBx_NeutrinoData.FormattingEnabled = true;
            this.LBx_NeutrinoData.ItemHeight = 17;
            this.LBx_NeutrinoData.Location = new System.Drawing.Point(31, 61);
            this.LBx_NeutrinoData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LBx_NeutrinoData.Name = "LBx_NeutrinoData";
            this.LBx_NeutrinoData.Size = new System.Drawing.Size(201, 242);
            this.LBx_NeutrinoData.TabIndex = 1;
            // 
            // LBL_NeutrinoData
            // 
            this.LBL_NeutrinoData.AutoSize = true;
            this.LBL_NeutrinoData.Location = new System.Drawing.Point(28, 35);
            this.LBL_NeutrinoData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_NeutrinoData.Name = "LBL_NeutrinoData";
            this.LBL_NeutrinoData.Size = new System.Drawing.Size(114, 17);
            this.LBL_NeutrinoData.TabIndex = 0;
            this.LBL_NeutrinoData.Text = "Neutrino Data:";
            // 
            // GB_EditData
            // 
            this.GB_EditData.BackColor = System.Drawing.Color.LightSlateGray;
            this.GB_EditData.Controls.Add(this.TB_SaveData);
            this.GB_EditData.Controls.Add(this.BTN_EditData);
            this.GB_EditData.Controls.Add(this.BTN_SaveData);
            this.GB_EditData.Controls.Add(this.TB_EditData);
            this.GB_EditData.Controls.Add(this.LB_EditData);
            this.GB_EditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_EditData.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_EditData.Location = new System.Drawing.Point(11, 551);
            this.GB_EditData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_EditData.Name = "GB_EditData";
            this.GB_EditData.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_EditData.Size = new System.Drawing.Size(418, 180);
            this.GB_EditData.TabIndex = 1;
            this.GB_EditData.TabStop = false;
            this.GB_EditData.Text = "Edit Data";
            // 
            // TB_SaveData
            // 
            this.TB_SaveData.Location = new System.Drawing.Point(177, 84);
            this.TB_SaveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_SaveData.Name = "TB_SaveData";
            this.TB_SaveData.Size = new System.Drawing.Size(142, 23);
            this.TB_SaveData.TabIndex = 4;
            // 
            // BTN_EditData
            // 
            this.BTN_EditData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_EditData.Location = new System.Drawing.Point(31, 31);
            this.BTN_EditData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_EditData.Name = "BTN_EditData";
            this.BTN_EditData.Size = new System.Drawing.Size(132, 36);
            this.BTN_EditData.TabIndex = 3;
            this.BTN_EditData.Text = "Select Data";
            this.BTN_EditData.UseVisualStyleBackColor = true;
            this.BTN_EditData.Click += new System.EventHandler(this.BTN_EditData_Click);
            // 
            // BTN_SaveData
            // 
            this.BTN_SaveData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_SaveData.Location = new System.Drawing.Point(190, 124);
            this.BTN_SaveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_SaveData.Name = "BTN_SaveData";
            this.BTN_SaveData.Size = new System.Drawing.Size(128, 37);
            this.BTN_SaveData.TabIndex = 2;
            this.BTN_SaveData.Text = "Save Data";
            this.BTN_SaveData.UseVisualStyleBackColor = true;
            this.BTN_SaveData.Click += new System.EventHandler(this.BTN_SaveData_Click);
            // 
            // TB_EditData
            // 
            this.TB_EditData.Enabled = false;
            this.TB_EditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_EditData.Location = new System.Drawing.Point(177, 35);
            this.TB_EditData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_EditData.Name = "TB_EditData";
            this.TB_EditData.ReadOnly = true;
            this.TB_EditData.Size = new System.Drawing.Size(142, 26);
            this.TB_EditData.TabIndex = 1;
            // 
            // LB_EditData
            // 
            this.LB_EditData.AutoSize = true;
            this.LB_EditData.Location = new System.Drawing.Point(28, 87);
            this.LB_EditData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_EditData.Name = "LB_EditData";
            this.LB_EditData.Size = new System.Drawing.Size(166, 17);
            this.LB_EditData.TabIndex = 0;
            this.LB_EditData.Text = "Enter data to change:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LBL_Welcome
            // 
            this.LBL_Welcome.AutoSize = true;
            this.LBL_Welcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Welcome.ForeColor = System.Drawing.Color.IndianRed;
            this.LBL_Welcome.Location = new System.Drawing.Point(261, 14);
            this.LBL_Welcome.Name = "LBL_Welcome";
            this.LBL_Welcome.Size = new System.Drawing.Size(495, 26);
            this.LBL_Welcome.TabIndex = 2;
            this.LBL_Welcome.Text = "Welcome to Astronomical Processing App!";
            // 
            // LBL_ProjectDescription
            // 
            this.LBL_ProjectDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ProjectDescription.Location = new System.Drawing.Point(28, 68);
            this.LBL_ProjectDescription.Name = "LBL_ProjectDescription";
            this.LBL_ProjectDescription.Size = new System.Drawing.Size(387, 70);
            this.LBL_ProjectDescription.TabIndex = 3;
            this.LBL_ProjectDescription.Text = "Process the astronomical data streamed from a local observatory. Utilize the simu" +
    "lated data to perform mathematical calculations, search and edit operations on d" +
    "ata.\r\n";
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1009, 810);
            this.Controls.Add(this.LBL_ProjectDescription);
            this.Controls.Add(this.LBL_Welcome);
            this.Controls.Add(this.GB_EditData);
            this.Controls.Add(this.GB_SearchData);
            this.Name = "AstronomicalProcessingForm";
            this.Text = "Astronomical Processing";
            this.GB_SearchData.ResumeLayout(false);
            this.GB_SearchData.PerformLayout();
            this.GB_EditData.ResumeLayout(false);
            this.GB_EditData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_SearchData;
        private System.Windows.Forms.Label LBL_NeutrinoData;
        private System.Windows.Forms.GroupBox GB_EditData;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.TextBox TB_InputSearchValue;
        private System.Windows.Forms.Button BTN_Sort;
        private System.Windows.Forms.Label LB_EnterValue;
        private System.Windows.Forms.ListBox LBx_NeutrinoData;
        private System.Windows.Forms.TextBox TB_EditData;
        private System.Windows.Forms.Label LB_EditData;
        private System.Windows.Forms.Button BTN_SaveData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BTN_LoadData;
        private System.Windows.Forms.Button BTN_EditData;
        private System.Windows.Forms.TextBox TB_SaveData;
        private System.Windows.Forms.Label LBL_Welcome;
        private System.Windows.Forms.Label LBL_ProjectDescription;
    }
}

