namespace Tyuiu.GulahmedovTE.Sprint7.Task0.V5
{
    partial class FormWarn
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
            label1 = new Label();
            buttonYes_GTE = new Button();
            buttonNo_GTE = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(90, 47);
            label1.Name = "label1";
            label1.Size = new Size(301, 42);
            label1.TabIndex = 0;
            label1.Text = "Точно ли вы хотите все уничтожить?\r\n              Назад пути не будет...\r\n";
            // 
            // buttonYes_GTE
            // 
            buttonYes_GTE.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonYes_GTE.Location = new Point(90, 37);
            buttonYes_GTE.Name = "buttonYes_GTE";
            buttonYes_GTE.Size = new Size(107, 52);
            buttonYes_GTE.TabIndex = 1;
            buttonYes_GTE.Text = "ДА";
            buttonYes_GTE.UseVisualStyleBackColor = true;
            buttonYes_GTE.Click += buttonYes_GTE_Click;
            buttonYes_GTE.MouseEnter += buttonYes_GTE_MouseEnter;
            buttonYes_GTE.MouseLeave += buttonYes_GTE_MouseLeave;
            // 
            // buttonNo_GTE
            // 
            buttonNo_GTE.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNo_GTE.Location = new Point(284, 37);
            buttonNo_GTE.Name = "buttonNo_GTE";
            buttonNo_GTE.Size = new Size(107, 52);
            buttonNo_GTE.TabIndex = 2;
            buttonNo_GTE.Text = "НЕТ";
            buttonNo_GTE.UseVisualStyleBackColor = true;
            buttonNo_GTE.Click += buttonNo_GTE_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 135);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonYes_GTE);
            groupBox2.Controls.Add(buttonNo_GTE);
            groupBox2.Location = new Point(12, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 113);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // FormWarn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 275);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormWarn";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Предупреждение";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonYes_GTE;
        private Button buttonNo_GTE;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}