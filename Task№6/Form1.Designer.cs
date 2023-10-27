namespace Task_6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnApp = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbRenameBuck = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AnimationInterface = new System.Windows.Forms.CheckBox();
            this.Internet = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbChangedTheme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список функций";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(728, 483);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(118, 38);
            this.btnApp.TabIndex = 1;
            this.btnApp.Text = "Применить";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(174, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Переименовывание корзины";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbRenameBuck
            // 
            this.tbRenameBuck.Location = new System.Drawing.Point(13, 73);
            this.tbRenameBuck.Name = "tbRenameBuck";
            this.tbRenameBuck.Size = new System.Drawing.Size(173, 20);
            this.tbRenameBuck.TabIndex = 3;
            this.tbRenameBuck.TextChanged += new System.EventHandler(this.tbRenameBuck_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(413, 317);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AnimationInterface
            // 
            this.AnimationInterface.AutoSize = true;
            this.AnimationInterface.Location = new System.Drawing.Point(235, 49);
            this.AnimationInterface.Name = "AnimationInterface";
            this.AnimationInterface.Size = new System.Drawing.Size(198, 17);
            this.AnimationInterface.TabIndex = 5;
            this.AnimationInterface.Text = "Отключить аниамции интерфейса";
            this.AnimationInterface.UseVisualStyleBackColor = true;
            this.AnimationInterface.CheckedChanged += new System.EventHandler(this.AnimationInterface_CheckedChanged);
            // 
            // Internet
            // 
            this.Internet.AutoSize = true;
            this.Internet.Location = new System.Drawing.Point(457, 49);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(143, 17);
            this.Internet.TabIndex = 6;
            this.Internet.Text = "Отключение интернета";
            this.Internet.UseVisualStyleBackColor = true;
            this.Internet.CheckedChanged += new System.EventHandler(this.Internet_CheckedChanged);
            // 
            // cbChangedTheme
            // 
            this.cbChangedTheme.AutoSize = true;
            this.cbChangedTheme.Location = new System.Drawing.Point(235, 76);
            this.cbChangedTheme.Name = "cbChangedTheme";
            this.cbChangedTheme.Size = new System.Drawing.Size(211, 17);
            this.cbChangedTheme.TabIndex = 7;
            this.cbChangedTheme.Text = "Смена темы на темную или светлую";
            this.cbChangedTheme.UseVisualStyleBackColor = true;
            this.cbChangedTheme.CheckedChanged += new System.EventHandler(this.cbChangedTheme_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.Internet);
            this.Controls.Add(this.AnimationInterface);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbRenameBuck);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChangedTheme);
            this.Name = "Form1";
            this.Text = "r";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbRenameBuck;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox AnimationInterface;
        private System.Windows.Forms.CheckBox Internet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbChangedTheme;
    }
}

