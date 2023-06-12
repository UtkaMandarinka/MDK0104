namespace Блокнот
{
    partial class GoToForm
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
            this.labGo = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butGo = new System.Windows.Forms.Button();
            this.tbLineNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // labGo
            // 
            this.labGo.AutoSize = true;
            this.labGo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labGo.Location = new System.Drawing.Point(26, 9);
            this.labGo.Name = "labGo";
            this.labGo.Size = new System.Drawing.Size(169, 20);
            this.labGo.TabIndex = 0;
            this.labGo.Text = "Введите номер строки:";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(120, 61);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butGo
            // 
            this.butGo.Location = new System.Drawing.Point(30, 61);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(75, 23);
            this.butGo.TabIndex = 2;
            this.butGo.Text = "Перейти";
            this.butGo.UseVisualStyleBackColor = true;
            this.butGo.Click += new System.EventHandler(this.butGo_Click);
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(30, 32);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(165, 23);
            this.tbLineNum.TabIndex = 3;
            // 
            // GoToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 96);
            this.Controls.Add(this.tbLineNum);
            this.Controls.Add(this.butGo);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.labGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowIcon = false;
            this.Text = "Перейти";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GoToForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labGo;
        private Button butCancel;
        private Button butGo;
        public NumericUpDown tbLineNum;
    }
}