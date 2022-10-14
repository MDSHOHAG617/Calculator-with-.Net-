namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secNum = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(72, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(47, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstNum
            // 
            this.firstNum.BackColor = System.Drawing.SystemColors.Info;
            this.firstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNum.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.firstNum.Location = new System.Drawing.Point(225, 175);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(177, 29);
            this.firstNum.TabIndex = 2;
            this.firstNum.TextChanged += new System.EventHandler(this.firstNum_TextChanged);
            // 
            // secNum
            // 
            this.secNum.BackColor = System.Drawing.SystemColors.Info;
            this.secNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secNum.Location = new System.Drawing.Point(225, 216);
            this.secNum.MaximumSize = new System.Drawing.Size(177, 40);
            this.secNum.MinimumSize = new System.Drawing.Size(177, 35);
            this.secNum.Name = "secNum";
            this.secNum.Size = new System.Drawing.Size(177, 29);
            this.secNum.TabIndex = 3;
            this.secNum.TextChanged += new System.EventHandler(this.secNum_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddBtn.Location = new System.Drawing.Point(44, 381);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 29);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Addition";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.subBtn.Location = new System.Drawing.Point(125, 381);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(75, 29);
            this.subBtn.TabIndex = 5;
            this.subBtn.Text = "Subtraction";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.divBtn.Location = new System.Drawing.Point(294, 381);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 29);
            this.divBtn.TabIndex = 6;
            this.divBtn.Text = "Division";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(206, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Multiplication";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // modBtn
            // 
            this.modBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.modBtn.Location = new System.Drawing.Point(375, 381);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(75, 29);
            this.modBtn.TabIndex = 8;
            this.modBtn.Text = "Mod";
            this.modBtn.UseVisualStyleBackColor = false;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.Info;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(225, 263);
            this.resultBox.MaximumSize = new System.Drawing.Size(177, 40);
            this.resultBox.MinimumSize = new System.Drawing.Size(145, 35);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(177, 29);
            this.resultBox.TabIndex = 9;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Gray;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Result.Location = new System.Drawing.Point(119, 273);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(75, 16);
            this.Result.TabIndex = 10;
            this.Result.Text = "RESULT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(135, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "CALCU MAMA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.secNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 5000);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secNum;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label3;
    }
}

