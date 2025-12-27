namespace ClassificationApp
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
            lblIncome = new Label();
            lblScore = new Label();
            lblJob = new Label();
            lblResult = new Label();
            txtJob = new TextBox();
            txtScore = new TextBox();
            txtIncome = new TextBox();
            btnTrain = new Button();
            btnPradict = new Button();
            SuspendLayout();
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIncome.Location = new Point(12, 19);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(58, 25);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Gelir:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblScore.Location = new Point(12, 73);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(116, 25);
            lblScore.TabIndex = 1;
            lblScore.Text = "Kredi Skoru:";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblJob.Location = new Point(12, 135);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(133, 25);
            lblJob.TabIndex = 2;
            lblJob.Text = "İş Var Mı(1/0):";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResult.Location = new Point(12, 313);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(162, 31);
            lblResult.TabIndex = 3;
            lblResult.Text = "Sonuç Burada";
            // 
            // txtJob
            // 
            txtJob.BackColor = Color.White;
            txtJob.Location = new Point(151, 128);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(125, 27);
            txtJob.TabIndex = 4;
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.White;
            txtScore.Location = new Point(151, 70);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 5;
            // 
            // txtIncome
            // 
            txtIncome.BackColor = Color.White;
            txtIncome.Location = new Point(151, 19);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(125, 27);
            txtIncome.TabIndex = 6;
            // 
            // btnTrain
            // 
            btnTrain.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTrain.Location = new Point(12, 204);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(141, 32);
            btnTrain.TabIndex = 7;
            btnTrain.Text = "Modeli Eğit";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += btnTrain_Click;
            // 
            // btnPradict
            // 
            btnPradict.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPradict.Location = new Point(12, 254);
            btnPradict.Name = "btnPradict";
            btnPradict.Size = new Size(141, 29);
            btnPradict.TabIndex = 8;
            btnPradict.Text = "Tahmin Et";
            btnPradict.UseVisualStyleBackColor = true;
            btnPradict.Click += btnPradict_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPradict);
            Controls.Add(btnTrain);
            Controls.Add(txtIncome);
            Controls.Add(txtScore);
            Controls.Add(txtJob);
            Controls.Add(lblResult);
            Controls.Add(lblJob);
            Controls.Add(lblScore);
            Controls.Add(lblIncome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIncome;
        private Label lblScore;
        private Label lblJob;
        private Label lblResult;
        private TextBox txtJob;
        private TextBox txtScore;
        private TextBox txtIncome;
        private Button btnTrain;
        private Button btnPradict;
    }
}
