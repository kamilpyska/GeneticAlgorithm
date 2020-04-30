namespace GeneticAlgorithm
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
            this.listBoxTST = new System.Windows.Forms.ListBox();
            this.listBoxTSTVal = new System.Windows.Forms.ListBox();
            this.labelTST = new System.Windows.Forms.Label();
            this.labelTSTVal = new System.Windows.Forms.Label();
            this.btnReadTestSystem = new System.Windows.Forms.Button();
            this.btnReadTrainingSystem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadValidationSystem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.cBoxK = new System.Windows.Forms.ComboBox();
            this.labelCBoxK = new System.Windows.Forms.Label();
            this.labelCBoxMetryka = new System.Windows.Forms.Label();
            this.cBoxMetryka = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTST
            // 
            this.listBoxTST.FormattingEnabled = true;
            this.listBoxTST.Location = new System.Drawing.Point(27, 47);
            this.listBoxTST.Name = "listBoxTST";
            this.listBoxTST.Size = new System.Drawing.Size(120, 329);
            this.listBoxTST.TabIndex = 0;
            // 
            // listBoxTSTVal
            // 
            this.listBoxTSTVal.FormattingEnabled = true;
            this.listBoxTSTVal.Location = new System.Drawing.Point(195, 47);
            this.listBoxTSTVal.Name = "listBoxTSTVal";
            this.listBoxTSTVal.Size = new System.Drawing.Size(120, 329);
            this.listBoxTSTVal.TabIndex = 1;
            // 
            // labelTST
            // 
            this.labelTST.AutoSize = true;
            this.labelTST.Location = new System.Drawing.Point(24, 31);
            this.labelTST.Name = "labelTST";
            this.labelTST.Size = new System.Drawing.Size(31, 13);
            this.labelTST.TabIndex = 2;
            this.labelTST.Text = "TST:";
            // 
            // labelTSTVal
            // 
            this.labelTSTVal.AutoSize = true;
            this.labelTSTVal.Location = new System.Drawing.Point(192, 31);
            this.labelTSTVal.Name = "labelTSTVal";
            this.labelTSTVal.Size = new System.Drawing.Size(49, 13);
            this.labelTSTVal.TabIndex = 3;
            this.labelTSTVal.Text = "TST Val:";
            // 
            // btnReadTestSystem
            // 
            this.btnReadTestSystem.Location = new System.Drawing.Point(10, 28);
            this.btnReadTestSystem.Name = "btnReadTestSystem";
            this.btnReadTestSystem.Size = new System.Drawing.Size(190, 36);
            this.btnReadTestSystem.TabIndex = 4;
            this.btnReadTestSystem.Text = "Wczytaj system testowy";
            this.btnReadTestSystem.UseVisualStyleBackColor = true;
            this.btnReadTestSystem.Click += new System.EventHandler(this.btnReadTestSystem_Click);
            // 
            // btnReadTrainingSystem
            // 
            this.btnReadTrainingSystem.Location = new System.Drawing.Point(11, 70);
            this.btnReadTrainingSystem.Name = "btnReadTrainingSystem";
            this.btnReadTrainingSystem.Size = new System.Drawing.Size(190, 36);
            this.btnReadTrainingSystem.TabIndex = 5;
            this.btnReadTrainingSystem.Text = "Wczytaj system treningowy";
            this.btnReadTrainingSystem.UseVisualStyleBackColor = true;
            this.btnReadTrainingSystem.Click += new System.EventHandler(this.btnReadTrainingSystem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadTestSystem);
            this.groupBox1.Controls.Add(this.btnReadValidationSystem);
            this.groupBox1.Controls.Add(this.btnReadTrainingSystem);
            this.groupBox1.Location = new System.Drawing.Point(423, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // btnReadValidationSystem
            // 
            this.btnReadValidationSystem.Location = new System.Drawing.Point(11, 112);
            this.btnReadValidationSystem.Name = "btnReadValidationSystem";
            this.btnReadValidationSystem.Size = new System.Drawing.Size(190, 36);
            this.btnReadValidationSystem.TabIndex = 6;
            this.btnReadValidationSystem.Text = "Wczytaj system walidacyjny";
            this.btnReadValidationSystem.UseVisualStyleBackColor = true;
            this.btnReadValidationSystem.Click += new System.EventHandler(this.btnReadValidationSystem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeneruj);
            this.groupBox2.Controls.Add(this.cBoxK);
            this.groupBox2.Controls.Add(this.labelCBoxK);
            this.groupBox2.Controls.Add(this.labelCBoxMetryka);
            this.groupBox2.Controls.Add(this.cBoxMetryka);
            this.groupBox2.Location = new System.Drawing.Point(423, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 206);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(11, 134);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(190, 36);
            this.btnGeneruj.TabIndex = 4;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            // 
            // cBoxK
            // 
            this.cBoxK.FormattingEnabled = true;
            this.cBoxK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxK.Location = new System.Drawing.Point(11, 98);
            this.cBoxK.Name = "cBoxK";
            this.cBoxK.Size = new System.Drawing.Size(55, 21);
            this.cBoxK.TabIndex = 3;
            // 
            // labelCBoxK
            // 
            this.labelCBoxK.AutoSize = true;
            this.labelCBoxK.Location = new System.Drawing.Point(8, 82);
            this.labelCBoxK.Name = "labelCBoxK";
            this.labelCBoxK.Size = new System.Drawing.Size(58, 13);
            this.labelCBoxK.TabIndex = 2;
            this.labelCBoxK.Text = "Wybierz K:";
            // 
            // labelCBoxMetryka
            // 
            this.labelCBoxMetryka.AutoSize = true;
            this.labelCBoxMetryka.Location = new System.Drawing.Point(8, 25);
            this.labelCBoxMetryka.Name = "labelCBoxMetryka";
            this.labelCBoxMetryka.Size = new System.Drawing.Size(88, 13);
            this.labelCBoxMetryka.TabIndex = 1;
            this.labelCBoxMetryka.Text = "Wybierz metrykę:";
            // 
            // cBoxMetryka
            // 
            this.cBoxMetryka.FormattingEnabled = true;
            this.cBoxMetryka.Items.AddRange(new object[] {
            "Euklidesa",
            "Canberra",
            "Czebyszewa",
            "Manhattan",
            "Współczynnik Pearsona"});
            this.cBoxMetryka.Location = new System.Drawing.Point(11, 41);
            this.cBoxMetryka.Name = "cBoxMetryka";
            this.cBoxMetryka.Size = new System.Drawing.Size(189, 21);
            this.cBoxMetryka.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTSTVal);
            this.Controls.Add(this.labelTST);
            this.Controls.Add(this.listBoxTSTVal);
            this.Controls.Add(this.listBoxTST);
            this.Name = "Form1";
            this.Text = "Algorytm genetyczny";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTST;
        private System.Windows.Forms.ListBox listBoxTSTVal;
        private System.Windows.Forms.Label labelTST;
        private System.Windows.Forms.Label labelTSTVal;
        private System.Windows.Forms.Button btnReadTestSystem;
        private System.Windows.Forms.Button btnReadTrainingSystem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.ComboBox cBoxK;
        private System.Windows.Forms.Label labelCBoxK;
        private System.Windows.Forms.Label labelCBoxMetryka;
        private System.Windows.Forms.ComboBox cBoxMetryka;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnReadValidationSystem;
    }
}

