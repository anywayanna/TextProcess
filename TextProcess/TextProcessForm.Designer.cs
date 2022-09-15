namespace TextProcess
{
    partial class TextProcessForm
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
            this.DictionaryMenu = new System.Windows.Forms.MenuStrip();
            this.DictionaryTool = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertText = new System.Windows.Forms.RichTextBox();
            this.DictionaryBox = new System.Windows.Forms.ListBox();
            this.DictionaryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictionaryMenu
            // 
            this.DictionaryMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DictionaryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DictionaryTool});
            this.DictionaryMenu.Location = new System.Drawing.Point(0, 0);
            this.DictionaryMenu.Name = "DictionaryMenu";
            this.DictionaryMenu.Size = new System.Drawing.Size(568, 28);
            this.DictionaryMenu.TabIndex = 1;
            this.DictionaryMenu.Text = "DictionaryMenu";
            // 
            // DictionaryTool
            // 
            this.DictionaryTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьСловарьToolStripMenuItem,
            this.обновитьСловарьToolStripMenuItem,
            this.очиститьСловарьToolStripMenuItem});
            this.DictionaryTool.Name = "DictionaryTool";
            this.DictionaryTool.Size = new System.Drawing.Size(82, 24);
            this.DictionaryTool.Text = "Словарь";
            // 
            // создатьСловарьToolStripMenuItem
            // 
            this.создатьСловарьToolStripMenuItem.Name = "создатьСловарьToolStripMenuItem";
            this.создатьСловарьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьСловарьToolStripMenuItem.Text = "Создать словарь";
            // 
            // обновитьСловарьToolStripMenuItem
            // 
            this.обновитьСловарьToolStripMenuItem.Name = "обновитьСловарьToolStripMenuItem";
            this.обновитьСловарьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.обновитьСловарьToolStripMenuItem.Text = "Обновить словарь";
            // 
            // очиститьСловарьToolStripMenuItem
            // 
            this.очиститьСловарьToolStripMenuItem.Name = "очиститьСловарьToolStripMenuItem";
            this.очиститьСловарьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.очиститьСловарьToolStripMenuItem.Text = "Очистить словарь";
            // 
            // InsertText
            // 
            this.InsertText.Location = new System.Drawing.Point(12, 31);
            this.InsertText.Name = "InsertText";
            this.InsertText.Size = new System.Drawing.Size(543, 290);
            this.InsertText.TabIndex = 3;
            this.InsertText.Text = "";
            this.InsertText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // DictionaryBox
            // 
            this.DictionaryBox.FormattingEnabled = true;
            this.DictionaryBox.ItemHeight = 16;
            this.DictionaryBox.Location = new System.Drawing.Point(24, 59);
            this.DictionaryBox.Name = "DictionaryBox";
            this.DictionaryBox.Size = new System.Drawing.Size(120, 84);
            this.DictionaryBox.TabIndex = 4;
            this.DictionaryBox.Visible = false;
            // 
            // TextProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 335);
            this.Controls.Add(this.DictionaryBox);
            this.Controls.Add(this.InsertText);
            this.Controls.Add(this.DictionaryMenu);
            this.Name = "TextProcessForm";
            this.Text = "Тектсовый процессор";
            this.DictionaryMenu.ResumeLayout(false);
            this.DictionaryMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip DictionaryMenu;
        private System.Windows.Forms.ToolStripMenuItem DictionaryTool;
        private System.Windows.Forms.ToolStripMenuItem создатьСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСловарьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox InsertText;
        private System.Windows.Forms.ListBox DictionaryBox;
    }
}

