namespace Lab19
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистити всі ресурси, що використовуються.
        /// </summary>
        /// <param name="disposing">істинно, якщо керований ресурс має бути утилізований; інакше хибно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, створений Конструктором Windows Form Designer

        /// <summary>
        /// Метод, необхідний для підтримки конструктора - не змінюйте
        /// зміст цього методу за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnProcess = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(13, 13);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(268, 23);
            txtInput.TabIndex = 0;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(287, 13);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(163, 23);
            btnProcess.TabIndex = 1;
            btnProcess.Text = "Видалити зайві пропуски";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(13, 50);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 166);
            Controls.Add(lblResult);
            Controls.Add(btnProcess);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Видалення зайвих пропусків";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblResult;
    }
}
