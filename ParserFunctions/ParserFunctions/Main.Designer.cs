namespace ParserFunctions
{
    partial class Main
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
            this.YTb = new System.Windows.Forms.TextBox();
            this.YB = new System.Windows.Forms.Button();
            this.XTb = new System.Windows.Forms.TextBox();
            this.GraphicsPb = new System.Windows.Forms.PictureBox();
            this.XLb = new System.Windows.Forms.Label();
            this.YLb = new System.Windows.Forms.Label();
            this.XB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsPb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YTb
            // 
            this.YTb.Location = new System.Drawing.Point(11, 67);
            this.YTb.Name = "YTb";
            this.YTb.Size = new System.Drawing.Size(127, 20);
            this.YTb.TabIndex = 0;
            // 
            // YB
            // 
            this.YB.Location = new System.Drawing.Point(63, 101);
            this.YB.Name = "YB";
            this.YB.Size = new System.Drawing.Size(75, 23);
            this.YB.TabIndex = 1;
            this.YB.Text = "Построить";
            this.YB.UseVisualStyleBackColor = true;
            this.YB.Click += new System.EventHandler(this.YB_Click);
            // 
            // XTb
            // 
            this.XTb.Location = new System.Drawing.Point(99, 157);
            this.XTb.Name = "XTb";
            this.XTb.Size = new System.Drawing.Size(39, 20);
            this.XTb.TabIndex = 2;
            // 
            // GraphicsPb
            // 
            this.GraphicsPb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicsPb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GraphicsPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GraphicsPb.Location = new System.Drawing.Point(151, 39);
            this.GraphicsPb.Name = "GraphicsPb";
            this.GraphicsPb.Size = new System.Drawing.Size(582, 381);
            this.GraphicsPb.TabIndex = 3;
            this.GraphicsPb.TabStop = false;
            // 
            // XLb
            // 
            this.XLb.AutoSize = true;
            this.XLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XLb.Location = new System.Drawing.Point(8, 158);
            this.XLb.Name = "XLb";
            this.XLb.Size = new System.Drawing.Size(85, 16);
            this.XLb.TabIndex = 4;
            this.XLb.Text = "Значение x:";
            // 
            // YLb
            // 
            this.YLb.AutoSize = true;
            this.YLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YLb.Location = new System.Drawing.Point(8, 39);
            this.YLb.Name = "YLb";
            this.YLb.Size = new System.Drawing.Size(92, 16);
            this.YLb.TabIndex = 5;
            this.YLb.Text = "Фунция y(x) =";
            // 
            // XB
            // 
            this.XB.Location = new System.Drawing.Point(63, 202);
            this.XB.Name = "XB";
            this.XB.Size = new System.Drawing.Size(75, 23);
            this.XB.TabIndex = 6;
            this.XB.Text = "Вычислить";
            this.XB.UseVisualStyleBackColor = true;
            this.XB.Click += new System.EventHandler(this.XB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сброситьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сброситьToolStripMenuItem
            // 
            this.сброситьToolStripMenuItem.Name = "сброситьToolStripMenuItem";
            this.сброситьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сброситьToolStripMenuItem.Text = "Сбросить";
            this.сброситьToolStripMenuItem.Click += new System.EventHandler(this.сброситьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(745, 436);
            this.Controls.Add(this.XB);
            this.Controls.Add(this.YLb);
            this.Controls.Add(this.XLb);
            this.Controls.Add(this.GraphicsPb);
            this.Controls.Add(this.XTb);
            this.Controls.Add(this.YB);
            this.Controls.Add(this.YTb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParserFunction";
            ((System.ComponentModel.ISupportInitialize)(this.GraphicsPb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YTb;
        private System.Windows.Forms.Button YB;
        private System.Windows.Forms.TextBox XTb;
        private System.Windows.Forms.PictureBox GraphicsPb;
        private System.Windows.Forms.Label XLb;
        private System.Windows.Forms.Label YLb;
        private System.Windows.Forms.Button XB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

