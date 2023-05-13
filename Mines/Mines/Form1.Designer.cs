namespace Mines
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            canvasGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            button_result = new Button();
            imageList1 = new ImageList(components);
            button_restart = new Button();
            label_timer = new Label();
            radio_level1 = new RadioButton();
            radio_level2 = new RadioButton();
            radio_level3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)canvasGrid).BeginInit();
            SuspendLayout();
            // 
            // canvasGrid
            // 
            canvasGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            canvasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            canvasGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20 });
            canvasGrid.Location = new Point(12, 26);
            canvasGrid.MultiSelect = false;
            canvasGrid.Name = "canvasGrid";
            canvasGrid.RowHeadersVisible = false;
            canvasGrid.RowHeadersWidth = 51;
            canvasGrid.RowTemplate.Height = 29;
            canvasGrid.Size = new Size(948, 915);
            canvasGrid.TabIndex = 0;
            canvasGrid.CellClick += canvasGrid_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 47;
            // 
            // Column2
            // 
            Column2.HeaderText = "2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 45;
            // 
            // Column3
            // 
            Column3.HeaderText = "3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 48;
            // 
            // Column4
            // 
            Column4.HeaderText = "4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 47;
            // 
            // Column5
            // 
            Column5.HeaderText = "5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 48;
            // 
            // Column6
            // 
            Column6.HeaderText = "6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 47;
            // 
            // Column7
            // 
            Column7.HeaderText = "7";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 48;
            // 
            // Column8
            // 
            Column8.HeaderText = "8";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 45;
            // 
            // Column9
            // 
            Column9.HeaderText = "9";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 46;
            // 
            // Column10
            // 
            Column10.HeaderText = "10";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 47;
            // 
            // Column11
            // 
            Column11.HeaderText = "11";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 48;
            // 
            // Column12
            // 
            Column12.HeaderText = "12";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 47;
            // 
            // Column13
            // 
            Column13.HeaderText = "13";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 47;
            // 
            // Column14
            // 
            Column14.HeaderText = "14";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 49;
            // 
            // Column15
            // 
            Column15.HeaderText = "15";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.Width = 48;
            // 
            // Column16
            // 
            Column16.HeaderText = "16";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.Width = 48;
            // 
            // Column17
            // 
            Column17.HeaderText = "17";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.Width = 46;
            // 
            // Column18
            // 
            Column18.HeaderText = "18";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.Width = 47;
            // 
            // Column19
            // 
            Column19.HeaderText = "19";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.Width = 47;
            // 
            // Column20
            // 
            Column20.HeaderText = "20";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.Width = 48;
            // 
            // button_result
            // 
            button_result.BackgroundImageLayout = ImageLayout.Stretch;
            button_result.Enabled = false;
            button_result.FlatStyle = FlatStyle.Flat;
            button_result.ImageIndex = 0;
            button_result.ImageList = imageList1;
            button_result.Location = new Point(1016, 39);
            button_result.Name = "button_result";
            button_result.Size = new Size(134, 126);
            button_result.TabIndex = 2;
            button_result.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "sad.png");
            imageList1.Images.SetKeyName(1, "smile.png");
            // 
            // button_restart
            // 
            button_restart.Location = new Point(1016, 213);
            button_restart.Name = "button_restart";
            button_restart.Size = new Size(134, 57);
            button_restart.TabIndex = 3;
            button_restart.Text = "重新开始";
            button_restart.UseVisualStyleBackColor = true;
            button_restart.Click += button_restart_Click;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Font = new Font("微软雅黑", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_timer.Location = new Point(1016, 310);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(146, 31);
            label_timer.TabIndex = 4;
            label_timer.Text = "计时 00：00";
            // 
            // radio_level1
            // 
            radio_level1.AutoSize = true;
            radio_level1.Checked = true;
            radio_level1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_level1.Location = new Point(1016, 390);
            radio_level1.Name = "radio_level1";
            radio_level1.Size = new Size(157, 31);
            radio_level1.TabIndex = 5;
            radio_level1.TabStop = true;
            radio_level1.Text = "初级（10阶）";
            radio_level1.UseVisualStyleBackColor = true;
            radio_level1.Click += radio_level1_CheckedChanged;
            // 
            // radio_level2
            // 
            radio_level2.AutoSize = true;
            radio_level2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_level2.Location = new Point(1016, 463);
            radio_level2.Name = "radio_level2";
            radio_level2.Size = new Size(157, 31);
            radio_level2.TabIndex = 6;
            radio_level2.Text = "中级（15阶）";
            radio_level2.UseVisualStyleBackColor = true;
            radio_level2.Click += radio_level2_CheckedChanged;
            // 
            // radio_level3
            // 
            radio_level3.AutoSize = true;
            radio_level3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radio_level3.Location = new Point(1016, 538);
            radio_level3.Name = "radio_level3";
            radio_level3.Size = new Size(157, 31);
            radio_level3.TabIndex = 7;
            radio_level3.Text = "高级（20阶）";
            radio_level3.UseVisualStyleBackColor = true;
            radio_level3.Click += radio_level3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 964);
            Controls.Add(radio_level3);
            Controls.Add(radio_level2);
            Controls.Add(radio_level1);
            Controls.Add(label_timer);
            Controls.Add(button_restart);
            Controls.Add(button_result);
            Controls.Add(canvasGrid);
            Name = "Form1";
            Text = "扫雷";
            ((System.ComponentModel.ISupportInitialize)canvasGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView canvasGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private Button button_result;
        private Button button_restart;
        private Label label_timer;
        private RadioButton radio_level1;
        private RadioButton radio_level2;
        private RadioButton radio_level3;
        private ImageList imageList1;
    }
}