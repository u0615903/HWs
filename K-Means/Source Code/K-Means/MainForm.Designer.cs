namespace K_Means
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Go = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgp2 = new System.Windows.Forms.Label();
            this.dgp1 = new System.Windows.Forms.Label();
            this.GroupPoint2 = new System.Windows.Forms.Label();
            this.GroupPoint1 = new System.Windows.Forms.Label();
            this.ManualSteps = new System.Windows.Forms.CheckBox();
            this.Next = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InitGroupPoint = new System.Windows.Forms.Label();
            this.OffSetP2Y = new System.Windows.Forms.TextBox();
            this.OffSetP2X = new System.Windows.Forms.TextBox();
            this.OffSetP1Y = new System.Windows.Forms.TextBox();
            this.OffSetP1X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PointData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AlgStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Go.Location = new System.Drawing.Point(447, 45);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 0;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AlgStep);
            this.splitContainer1.Panel2.Controls.Add(this.dgp2);
            this.splitContainer1.Panel2.Controls.Add(this.dgp1);
            this.splitContainer1.Panel2.Controls.Add(this.GroupPoint2);
            this.splitContainer1.Panel2.Controls.Add(this.GroupPoint1);
            this.splitContainer1.Panel2.Controls.Add(this.ManualSteps);
            this.splitContainer1.Panel2.Controls.Add(this.Next);
            this.splitContainer1.Panel2.Controls.Add(this.Go);
            this.splitContainer1.Size = new System.Drawing.Size(534, 526);
            this.splitContainer1.SplitterDistance = 447;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox1.Size = new System.Drawing.Size(534, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgp2
            // 
            this.dgp2.Location = new System.Drawing.Point(259, 28);
            this.dgp2.Name = "dgp2";
            this.dgp2.Size = new System.Drawing.Size(264, 12);
            this.dgp2.TabIndex = 7;
            this.dgp2.Text = "第二群中心幾何距離總和：";
            // 
            // dgp1
            // 
            this.dgp1.Location = new System.Drawing.Point(259, 8);
            this.dgp1.Name = "dgp1";
            this.dgp1.Size = new System.Drawing.Size(264, 12);
            this.dgp1.TabIndex = 6;
            this.dgp1.Text = "第一群中心幾何距離總和：";
            // 
            // GroupPoint2
            // 
            this.GroupPoint2.Location = new System.Drawing.Point(11, 28);
            this.GroupPoint2.Name = "GroupPoint2";
            this.GroupPoint2.Size = new System.Drawing.Size(240, 12);
            this.GroupPoint2.TabIndex = 2;
            this.GroupPoint2.Text = "第二群中心座標：";
            // 
            // GroupPoint1
            // 
            this.GroupPoint1.Location = new System.Drawing.Point(11, 8);
            this.GroupPoint1.Name = "GroupPoint1";
            this.GroupPoint1.Size = new System.Drawing.Size(240, 12);
            this.GroupPoint1.TabIndex = 1;
            this.GroupPoint1.Text = "第一群中心座標：";
            // 
            // ManualSteps
            // 
            this.ManualSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualSteps.AutoSize = true;
            this.ManualSteps.Location = new System.Drawing.Point(371, 48);
            this.ManualSteps.Name = "ManualSteps";
            this.ManualSteps.Size = new System.Drawing.Size(72, 16);
            this.ManualSteps.TabIndex = 4;
            this.ManualSteps.Text = "單步前進";
            this.ManualSteps.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.Location = new System.Drawing.Point(448, 45);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InitGroupPoint);
            this.panel1.Controls.Add(this.OffSetP2Y);
            this.panel1.Controls.Add(this.OffSetP2X);
            this.panel1.Controls.Add(this.OffSetP1Y);
            this.panel1.Controls.Add(this.OffSetP1X);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 129);
            this.panel1.TabIndex = 0;
            // 
            // InitGroupPoint
            // 
            this.InitGroupPoint.Location = new System.Drawing.Point(9, 109);
            this.InitGroupPoint.Name = "InitGroupPoint";
            this.InitGroupPoint.Size = new System.Drawing.Size(232, 12);
            this.InitGroupPoint.TabIndex = 8;
            this.InitGroupPoint.Text = "初始中心點 ：";
            // 
            // OffSetP2Y
            // 
            this.OffSetP2Y.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffSetP2Y.Location = new System.Drawing.Point(141, 80);
            this.OffSetP2Y.Name = "OffSetP2Y";
            this.OffSetP2Y.Size = new System.Drawing.Size(100, 21);
            this.OffSetP2Y.TabIndex = 7;
            this.OffSetP2Y.Text = "0.5";
            this.OffSetP2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OffSetP2X
            // 
            this.OffSetP2X.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffSetP2X.Location = new System.Drawing.Point(141, 55);
            this.OffSetP2X.Name = "OffSetP2X";
            this.OffSetP2X.Size = new System.Drawing.Size(100, 21);
            this.OffSetP2X.TabIndex = 6;
            this.OffSetP2X.Text = "0.5";
            this.OffSetP2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OffSetP1Y
            // 
            this.OffSetP1Y.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffSetP1Y.Location = new System.Drawing.Point(141, 30);
            this.OffSetP1Y.Name = "OffSetP1Y";
            this.OffSetP1Y.Size = new System.Drawing.Size(100, 21);
            this.OffSetP1Y.TabIndex = 5;
            this.OffSetP1Y.Text = "-0.5";
            this.OffSetP1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OffSetP1X
            // 
            this.OffSetP1X.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffSetP1X.Location = new System.Drawing.Point(141, 5);
            this.OffSetP1X.Name = "OffSetP1X";
            this.OffSetP1X.Size = new System.Drawing.Size(100, 21);
            this.OffSetP1X.TabIndex = 4;
            this.OffSetP1X.Text = "-0.5";
            this.OffSetP1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "中心點 二，Y 偏移量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "中心點 二，X 偏移量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "中心點 一，Y 偏移量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "中心點 一，X 偏移量：";
            // 
            // PointData
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PointData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PointData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PointData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PointData.DefaultCellStyle = dataGridViewCellStyle4;
            this.PointData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointData.Location = new System.Drawing.Point(0, 129);
            this.PointData.Name = "PointData";
            this.PointData.RowTemplate.Height = 24;
            this.PointData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PointData.Size = new System.Drawing.Size(483, 397);
            this.PointData.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PointData);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(534, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 526);
            this.panel2.TabIndex = 2;
            // 
            // AlgStep
            // 
            this.AlgStep.Location = new System.Drawing.Point(11, 50);
            this.AlgStep.Name = "AlgStep";
            this.AlgStep.Size = new System.Drawing.Size(240, 12);
            this.AlgStep.TabIndex = 8;
            this.AlgStep.Text = "演算步驟： Step X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "K-Means";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView PointData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OffSetP2Y;
        private System.Windows.Forms.TextBox OffSetP2X;
        private System.Windows.Forms.TextBox OffSetP1Y;
        private System.Windows.Forms.TextBox OffSetP1X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.CheckBox ManualSteps;
        private System.Windows.Forms.Label GroupPoint2;
        private System.Windows.Forms.Label GroupPoint1;
        private System.Windows.Forms.Label InitGroupPoint;
        private System.Windows.Forms.Label dgp2;
        private System.Windows.Forms.Label dgp1;
        private System.Windows.Forms.Label AlgStep;
    }
}

