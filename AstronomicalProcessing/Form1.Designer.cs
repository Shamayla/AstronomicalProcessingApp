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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstronomicalProcessingForm));
            this.GB_SearchData = new System.Windows.Forms.GroupBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TB_InputSearchValue = new System.Windows.Forms.TextBox();
            this.BTN_Sort = new System.Windows.Forms.Button();
            this.LB_EnterValue = new System.Windows.Forms.Label();
            this.LBx_NeutrinoData = new System.Windows.Forms.ListBox();
            this.LBL_NeutrinoData = new System.Windows.Forms.Label();
            this.GB_EditData = new System.Windows.Forms.GroupBox();
            this.BTN_SaveData = new System.Windows.Forms.Button();
            this.TB_EditData = new System.Windows.Forms.TextBox();
            this.LB_EditData = new System.Windows.Forms.Label();
            this.PICBOX_Neutrinos = new System.Windows.Forms.PictureBox();
            this.LB_Image = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BTN_LoadData = new System.Windows.Forms.Button();
            this.BTN_EditData = new System.Windows.Forms.Button();
            this.TB_SaveData = new System.Windows.Forms.TextBox();
            this.GB_SearchData.SuspendLayout();
            this.GB_EditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Neutrinos)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_SearchData
            // 
            this.GB_SearchData.BackColor = System.Drawing.Color.MidnightBlue;
            this.GB_SearchData.Controls.Add(this.BTN_LoadData);
            this.GB_SearchData.Controls.Add(this.BTN_Search);
            this.GB_SearchData.Controls.Add(this.TB_InputSearchValue);
            this.GB_SearchData.Controls.Add(this.BTN_Sort);
            this.GB_SearchData.Controls.Add(this.LB_EnterValue);
            this.GB_SearchData.Controls.Add(this.LBx_NeutrinoData);
            this.GB_SearchData.Controls.Add(this.LBL_NeutrinoData);
            this.GB_SearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_SearchData.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_SearchData.Location = new System.Drawing.Point(12, 21);
            this.GB_SearchData.Name = "GB_SearchData";
            this.GB_SearchData.Size = new System.Drawing.Size(558, 418);
            this.GB_SearchData.TabIndex = 0;
            this.GB_SearchData.TabStop = false;
            this.GB_SearchData.Text = "Search Data";
            // 
            // BTN_Search
            // 
            this.BTN_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_Search.Location = new System.Drawing.Point(348, 316);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(163, 54);
            this.BTN_Search.TabIndex = 5;
            this.BTN_Search.Text = "Perform Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TB_InputSearchValue
            // 
            this.TB_InputSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_InputSearchValue.Location = new System.Drawing.Point(363, 270);
            this.TB_InputSearchValue.Name = "TB_InputSearchValue";
            this.TB_InputSearchValue.Size = new System.Drawing.Size(148, 30);
            this.TB_InputSearchValue.TabIndex = 4;
            // 
            // BTN_Sort
            // 
            this.BTN_Sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Sort.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_Sort.Location = new System.Drawing.Point(348, 139);
            this.BTN_Sort.Name = "BTN_Sort";
            this.BTN_Sort.Size = new System.Drawing.Size(154, 51);
            this.BTN_Sort.TabIndex = 3;
            this.BTN_Sort.Text = "Sort";
            this.BTN_Sort.UseVisualStyleBackColor = true;
            this.BTN_Sort.Click += new System.EventHandler(this.BTN_Sort_Click);
            // 
            // LB_EnterValue
            // 
            this.LB_EnterValue.AutoSize = true;
            this.LB_EnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterValue.Location = new System.Drawing.Point(324, 236);
            this.LB_EnterValue.Name = "LB_EnterValue";
            this.LB_EnterValue.Size = new System.Drawing.Size(223, 23);
            this.LB_EnterValue.TabIndex = 2;
            this.LB_EnterValue.Text = "Enter value to search: ";
            this.LB_EnterValue.Click += new System.EventHandler(this.LB_EnterValue_Click);
            // 
            // LBx_NeutrinoData
            // 
            this.LBx_NeutrinoData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBx_NeutrinoData.FormattingEnabled = true;
            this.LBx_NeutrinoData.ItemHeight = 20;
            this.LBx_NeutrinoData.Location = new System.Drawing.Point(41, 75);
            this.LBx_NeutrinoData.Name = "LBx_NeutrinoData";
            this.LBx_NeutrinoData.Size = new System.Drawing.Size(267, 304);
            this.LBx_NeutrinoData.TabIndex = 1;
            // 
            // LBL_NeutrinoData
            // 
            this.LBL_NeutrinoData.AutoSize = true;
            this.LBL_NeutrinoData.Location = new System.Drawing.Point(37, 43);
            this.LBL_NeutrinoData.Name = "LBL_NeutrinoData";
            this.LBL_NeutrinoData.Size = new System.Drawing.Size(132, 20);
            this.LBL_NeutrinoData.TabIndex = 0;
            this.LBL_NeutrinoData.Text = "Neutrino Data:";
            // 
            // GB_EditData
            // 
            this.GB_EditData.Controls.Add(this.TB_SaveData);
            this.GB_EditData.Controls.Add(this.BTN_EditData);
            this.GB_EditData.Controls.Add(this.BTN_SaveData);
            this.GB_EditData.Controls.Add(this.TB_EditData);
            this.GB_EditData.Controls.Add(this.LB_EditData);
            this.GB_EditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_EditData.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_EditData.Location = new System.Drawing.Point(12, 461);
            this.GB_EditData.Name = "GB_EditData";
            this.GB_EditData.Size = new System.Drawing.Size(558, 221);
            this.GB_EditData.TabIndex = 1;
            this.GB_EditData.TabStop = false;
            this.GB_EditData.Text = "Edit Data";
            // 
            // BTN_SaveData
            // 
            this.BTN_SaveData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_SaveData.Location = new System.Drawing.Point(253, 153);
            this.BTN_SaveData.Name = "BTN_SaveData";
            this.BTN_SaveData.Size = new System.Drawing.Size(171, 45);
            this.BTN_SaveData.TabIndex = 2;
            this.BTN_SaveData.Text = "Save Data";
            this.BTN_SaveData.UseVisualStyleBackColor = true;
            this.BTN_SaveData.Click += new System.EventHandler(this.BTN_SaveData_Click);
            // 
            // TB_EditData
            // 
            this.TB_EditData.Enabled = false;
            this.TB_EditData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_EditData.Location = new System.Drawing.Point(236, 43);
            this.TB_EditData.Name = "TB_EditData";
            this.TB_EditData.ReadOnly = true;
            this.TB_EditData.Size = new System.Drawing.Size(188, 30);
            this.TB_EditData.TabIndex = 1;
            // 
            // LB_EditData
            // 
            this.LB_EditData.AutoSize = true;
            this.LB_EditData.Location = new System.Drawing.Point(37, 107);
            this.LB_EditData.Name = "LB_EditData";
            this.LB_EditData.Size = new System.Drawing.Size(190, 20);
            this.LB_EditData.TabIndex = 0;
            this.LB_EditData.Text = "Enter data to change:";
            // 
            // PICBOX_Neutrinos
            // 
            this.PICBOX_Neutrinos.Image = ((System.Drawing.Image)(resources.GetObject("PICBOX_Neutrinos.Image")));
            this.PICBOX_Neutrinos.Location = new System.Drawing.Point(576, 21);
            this.PICBOX_Neutrinos.Name = "PICBOX_Neutrinos";
            this.PICBOX_Neutrinos.Size = new System.Drawing.Size(476, 620);
            this.PICBOX_Neutrinos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PICBOX_Neutrinos.TabIndex = 6;
            this.PICBOX_Neutrinos.TabStop = false;
            // 
            // LB_Image
            // 
            this.LB_Image.AutoSize = true;
            this.LB_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Image.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_Image.Location = new System.Drawing.Point(658, 615);
            this.LB_Image.Name = "LB_Image";
            this.LB_Image.Size = new System.Drawing.Size(325, 44);
            this.LB_Image.TabIndex = 7;
            this.LB_Image.Text = "Blazar: an active galaxy emits neutrinos\r\nSource: edition.cnn.com";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BTN_LoadData
            // 
            this.BTN_LoadData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_LoadData.Location = new System.Drawing.Point(348, 75);
            this.BTN_LoadData.Name = "BTN_LoadData";
            this.BTN_LoadData.Size = new System.Drawing.Size(154, 48);
            this.BTN_LoadData.TabIndex = 6;
            this.BTN_LoadData.Text = "Load Data";
            this.BTN_LoadData.UseVisualStyleBackColor = true;
            this.BTN_LoadData.Click += new System.EventHandler(this.BTN_LoadData_Click);
            // 
            // BTN_EditData
            // 
            this.BTN_EditData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_EditData.Location = new System.Drawing.Point(41, 38);
            this.BTN_EditData.Name = "BTN_EditData";
            this.BTN_EditData.Size = new System.Drawing.Size(176, 44);
            this.BTN_EditData.TabIndex = 3;
            this.BTN_EditData.Text = "Select Data";
            this.BTN_EditData.UseVisualStyleBackColor = true;
            this.BTN_EditData.Click += new System.EventHandler(this.BTN_EditData_Click);
            // 
            // TB_SaveData
            // 
            this.TB_SaveData.Location = new System.Drawing.Point(236, 103);
            this.TB_SaveData.Name = "TB_SaveData";
            this.TB_SaveData.Size = new System.Drawing.Size(188, 27);
            this.TB_SaveData.TabIndex = 4;
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1081, 715);
            this.Controls.Add(this.LB_Image);
            this.Controls.Add(this.GB_EditData);
            this.Controls.Add(this.GB_SearchData);
            this.Controls.Add(this.PICBOX_Neutrinos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AstronomicalProcessingForm";
            this.Text = "Astronomical Processing";
            this.GB_SearchData.ResumeLayout(false);
            this.GB_SearchData.PerformLayout();
            this.GB_EditData.ResumeLayout(false);
            this.GB_EditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Neutrinos)).EndInit();
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
        private System.Windows.Forms.PictureBox PICBOX_Neutrinos;
        private System.Windows.Forms.Label LB_Image;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BTN_LoadData;
        private System.Windows.Forms.Button BTN_EditData;
        private System.Windows.Forms.TextBox TB_SaveData;
    }
}

