
namespace Exam
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFIleMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstVar = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondVar = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueX = new System.Windows.Forms.TextBox();
            this.ValueY = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFIleMenuStrip,
            this.ExitFileMenuStrip});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(48, 20);
            this.FileMenuStrip.Text = "Файл";
            // 
            // OpenFIleMenuStrip
            // 
            this.OpenFIleMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstVar,
            this.SecondVar});
            this.OpenFIleMenuStrip.Name = "OpenFIleMenuStrip";
            this.OpenFIleMenuStrip.Size = new System.Drawing.Size(121, 22);
            this.OpenFIleMenuStrip.Text = "Открыть";
            // 
            // FirstVar
            // 
            this.FirstVar.Name = "FirstVar";
            this.FirstVar.Size = new System.Drawing.Size(128, 22);
            this.FirstVar.Text = "Вариант 1";
            this.FirstVar.Click += new System.EventHandler(this.FirstVar_Click);
            // 
            // SecondVar
            // 
            this.SecondVar.Name = "SecondVar";
            this.SecondVar.Size = new System.Drawing.Size(128, 22);
            this.SecondVar.Text = "Вариант 2";
            this.SecondVar.Click += new System.EventHandler(this.SecondVar_Click);
            // 
            // ExitFileMenuStrip
            // 
            this.ExitFileMenuStrip.Name = "ExitFileMenuStrip";
            this.ExitFileMenuStrip.Size = new System.Drawing.Size(121, 22);
            this.ExitFileMenuStrip.Text = "Выход";
            // 
            // InfoMenuStrip
            // 
            this.InfoMenuStrip.Name = "InfoMenuStrip";
            this.InfoMenuStrip.Size = new System.Drawing.Size(94, 20);
            this.InfoMenuStrip.Text = "О программе";
            this.InfoMenuStrip.Click += new System.EventHandler(this.InfoMenuStrip_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.InfoMenuStrip});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(279, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите координату x";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите координату y";
            this.label2.Visible = false;
            // 
            // ValueX
            // 
            this.ValueX.Location = new System.Drawing.Point(94, 66);
            this.ValueX.Name = "ValueX";
            this.ValueX.Size = new System.Drawing.Size(100, 20);
            this.ValueX.TabIndex = 8;
            this.ValueX.Visible = false;
            // 
            // ValueY
            // 
            this.ValueY.Location = new System.Drawing.Point(93, 128);
            this.ValueY.Name = "ValueY";
            this.ValueY.Size = new System.Drawing.Size(100, 20);
            this.ValueY.TabIndex = 9;
            this.ValueY.Visible = false;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(106, 163);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 10;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Visible = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(279, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(89, 17);
            this.StatusStrip.Text = "Статус расчёта";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 222);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ValueY);
            this.Controls.Add(this.ValueX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Принадлежность точки";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenFIleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FirstVar;
        private System.Windows.Forms.ToolStripMenuItem SecondVar;
        private System.Windows.Forms.ToolStripMenuItem ExitFileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValueX;
        private System.Windows.Forms.TextBox ValueY;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip;
    }
}

