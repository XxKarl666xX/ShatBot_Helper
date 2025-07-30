namespace Shatbot_Helper
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuestionField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendQuestionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TrainButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnswerField = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TrainingOutputField = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionField
            // 
            this.QuestionField.Location = new System.Drawing.Point(18, 39);
            this.QuestionField.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.QuestionField.Multiline = true;
            this.QuestionField.Name = "QuestionField";
            this.QuestionField.Size = new System.Drawing.Size(195, 68);
            this.QuestionField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // SendQuestionButton
            // 
            this.SendQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendQuestionButton.Location = new System.Drawing.Point(215, 81);
            this.SendQuestionButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SendQuestionButton.Name = "SendQuestionButton";
            this.SendQuestionButton.Size = new System.Drawing.Size(73, 26);
            this.SendQuestionButton.TabIndex = 2;
            this.SendQuestionButton.Text = "Submit";
            this.SendQuestionButton.UseVisualStyleBackColor = true;
            this.SendQuestionButton.Click += new System.EventHandler(this.SendQuestionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(168, 39);
            this.TrainButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(91, 34);
            this.TrainButton.TabIndex = 5;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 523);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.QuestionField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AnswerField);
            this.tabPage1.Controls.Add(this.SendQuestionButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(877, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ShatBot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Shatbot_Helper.Properties.Resources.shatbot_head;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(340, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AnswerField
            // 
            this.AnswerField.Location = new System.Drawing.Point(480, 39);
            this.AnswerField.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AnswerField.Multiline = true;
            this.AnswerField.Name = "AnswerField";
            this.AnswerField.Size = new System.Drawing.Size(376, 145);
            this.AnswerField.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.TrainingOutputField);
            this.tabPage2.Controls.Add(this.TrainButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(877, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ShatTrainer";
            // 
            // TrainingOutputField
            // 
            this.TrainingOutputField.Location = new System.Drawing.Point(395, 15);
            this.TrainingOutputField.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TrainingOutputField.Multiline = true;
            this.TrainingOutputField.Name = "TrainingOutputField";
            this.TrainingOutputField.Size = new System.Drawing.Size(457, 402);
            this.TrainingOutputField.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 527);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "ShatBot_Helper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendQuestionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox AnswerField;
        private System.Windows.Forms.TextBox TrainingOutputField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

