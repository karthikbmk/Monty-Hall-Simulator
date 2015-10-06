namespace WindowsFormsApplication2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtNoOfTrials = new System.Windows.Forms.TextBox();
            this.chartMontyHall = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinningProbability = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvgProbability = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMontyHall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(78, 258);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(75, 23);
            this.btnSimulate.TabIndex = 0;
            this.btnSimulate.Text = "Simulate !";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 218);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "No Of Trials:";
            // 
            // txtNoOfTrials
            // 
            this.txtNoOfTrials.Location = new System.Drawing.Point(78, 215);
            this.txtNoOfTrials.Name = "txtNoOfTrials";
            this.txtNoOfTrials.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfTrials.TabIndex = 3;
            // 
            // chartMontyHall
            // 
            chartArea12.Name = "ChartArea1";
            this.chartMontyHall.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartMontyHall.Legends.Add(legend12);
            this.chartMontyHall.Location = new System.Drawing.Point(184, 12);
            this.chartMontyHall.Name = "chartMontyHall";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "MontyHall Simulation";
            this.chartMontyHall.Series.Add(series12);
            this.chartMontyHall.Size = new System.Drawing.Size(954, 480);
            this.chartMontyHall.TabIndex = 4;
            this.chartMontyHall.Text = "chartMontyHall";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "No Of Trials -->";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWinningProbability
            // 
            this.lblWinningProbability.AutoSize = true;
            this.lblWinningProbability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWinningProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinningProbability.Location = new System.Drawing.Point(190, 314);
            this.lblWinningProbability.Name = "lblWinningProbability";
            this.lblWinningProbability.Size = new System.Drawing.Size(69, 13);
            this.lblWinningProbability.TabIndex = 6;
            this.lblWinningProbability.Text = "P(Winning)";
            this.lblWinningProbability.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(985, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "karthikEuler.blogspot.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(934, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Average Winning Probability When Switching:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(934, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblAvgProbability
            // 
            this.lblAvgProbability.AutoSize = true;
            this.lblAvgProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgProbability.Location = new System.Drawing.Point(994, 184);
            this.lblAvgProbability.Name = "lblAvgProbability";
            this.lblAvgProbability.Size = new System.Drawing.Size(74, 13);
            this.lblAvgProbability.TabIndex = 8;
            this.lblAvgProbability.Text = "Computing..";
            this.lblAvgProbability.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(62, 84);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Wiki Link";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MontyHall - Wikipedia";
            this.label4.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(27, 337);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(151, 62);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "This is to simulate that for sufficiently large no of trials,     P(winning car) " +
    "= 2/3 or approx 66.67%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 513);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAvgProbability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblWinningProbability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartMontyHall);
            this.Controls.Add(this.txtNoOfTrials);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnSimulate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartMontyHall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtNoOfTrials;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMontyHall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinningProbability;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvgProbability;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

