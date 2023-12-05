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
            this.AnimationInterface = new System.Windows.Forms.CheckBox();
            this.Internet = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbChangedTheme = new System.Windows.Forms.CheckBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbOpacity = new System.Windows.Forms.CheckBox();
            this.Bng = new System.Windows.Forms.CheckBox();
            this.NumLck = new System.Windows.Forms.CheckBox();
            this.dir = new System.Windows.Forms.CheckBox();
            this.cbChangeFonts = new System.Windows.Forms.CheckBox();
            this.tbFonts = new System.Windows.Forms.TextBox();
            this.defrag = new System.Windows.Forms.CheckBox();
            this.cmdshka = new System.Windows.Forms.CheckBox();
            this.PushNotifications = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Location = new System.Drawing.Point(457, 75);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(232, 17);
            this.cbTime.TabIndex = 8;
            this.cbTime.Text = "Включение и отключение секунд в часах";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // cbOpacity
            // 
            this.cbOpacity.AutoSize = true;
            this.cbOpacity.Location = new System.Drawing.Point(235, 100);
            this.cbOpacity.Name = "cbOpacity";
            this.cbOpacity.Size = new System.Drawing.Size(203, 17);
            this.cbOpacity.TabIndex = 9;
            this.cbOpacity.Text = "Смена прозрачности панели задач";
            this.cbOpacity.UseVisualStyleBackColor = true;
            this.cbOpacity.CheckedChanged += new System.EventHandler(this.cbOpacity_CheckedChanged);
            // 
            // Bng
            // 
            this.Bng.AutoSize = true;
            this.Bng.Location = new System.Drawing.Point(457, 100);
            this.Bng.Name = "Bng";
            this.Bng.Size = new System.Drawing.Size(179, 17);
            this.Bng.TabIndex = 10;
            this.Bng.Text = "Отключение и включение Bing";
            this.Bng.UseVisualStyleBackColor = true;
            this.Bng.CheckedChanged += new System.EventHandler(this.Bng_CheckedChanged);
            // 
            // NumLck
            // 
            this.NumLck.AutoSize = true;
            this.NumLck.Location = new System.Drawing.Point(235, 124);
            this.NumLck.Name = "NumLck";
            this.NumLck.Size = new System.Drawing.Size(214, 17);
            this.NumLck.TabIndex = 11;
            this.NumLck.Text = "Автозапуск NumLock при запуске пк";
            this.NumLck.UseVisualStyleBackColor = true;
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Location = new System.Drawing.Point(457, 124);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(334, 30);
            this.dir.TabIndex = 12;
            this.dir.Text = "Включение и отключение функции «Копировать в папку…» и \n«Переместить в папку…» в " +
    "контекстном меню";
            this.dir.UseVisualStyleBackColor = true;
            // 
            // cbChangeFonts
            // 
            this.cbChangeFonts.AutoSize = true;
            this.cbChangeFonts.Location = new System.Drawing.Point(12, 100);
            this.cbChangeFonts.Name = "cbChangeFonts";
            this.cbChangeFonts.Size = new System.Drawing.Size(126, 17);
            this.cbChangeFonts.TabIndex = 13;
            this.cbChangeFonts.Text = "Изменение шрифта";
            this.cbChangeFonts.UseVisualStyleBackColor = true;
            this.cbChangeFonts.CheckedChanged += new System.EventHandler(this.cbChangeFonts_CheckedChanged);
            // 
            // tbFonts
            // 
            this.tbFonts.Location = new System.Drawing.Point(12, 121);
            this.tbFonts.Name = "tbFonts";
            this.tbFonts.Size = new System.Drawing.Size(174, 20);
            this.tbFonts.TabIndex = 14;
            this.tbFonts.Text = "sdas";
            this.tbFonts.TextChanged += new System.EventHandler(this.tbFonts_TextChanged);
            // 
            // defrag
            // 
            this.defrag.AutoSize = true;
            this.defrag.Checked = true;
            this.defrag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defrag.Location = new System.Drawing.Point(235, 147);
            this.defrag.Name = "defrag";
            this.defrag.Size = new System.Drawing.Size(165, 17);
            this.defrag.TabIndex = 15;
            this.defrag.Text = "Включение дефрагметации";
            this.defrag.UseVisualStyleBackColor = true;
            this.defrag.CheckedChanged += new System.EventHandler(this.defrag_CheckedChanged);
            // 
            // cmdshka
            // 
            this.cmdshka.AutoSize = true;
            this.cmdshka.Checked = true;
            this.cmdshka.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmdshka.Location = new System.Drawing.Point(457, 160);
            this.cmdshka.Name = "cmdshka";
            this.cmdshka.Size = new System.Drawing.Size(170, 17);
            this.cmdshka.TabIndex = 16;
            this.cmdshka.Text = "Включение/отключение cmd";
            this.cmdshka.UseVisualStyleBackColor = true;
            this.cmdshka.CheckedChanged += new System.EventHandler(this.cmdshka_CheckedChanged);
            // 
            // PushNotifications
            // 
            this.PushNotifications.AutoSize = true;
            this.PushNotifications.Location = new System.Drawing.Point(235, 170);
            this.PushNotifications.Name = "PushNotifications";
            this.PushNotifications.Size = new System.Drawing.Size(217, 17);
            this.PushNotifications.TabIndex = 17;
            this.PushNotifications.Text = "Включение/отключение уведомлений";
            this.PushNotifications.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 65);
            this.label3.TabIndex = 19;
            this.label3.Text = "Примеры шрифтов:\r\nArial\r\nMS Serif\r\nTahoma\r\nTimes New Roman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PushNotifications);
            this.Controls.Add(this.cmdshka);
            this.Controls.Add(this.defrag);
            this.Controls.Add(this.tbFonts);
            this.Controls.Add(this.cbChangeFonts);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.NumLck);
            this.Controls.Add(this.Bng);
            this.Controls.Add(this.cbOpacity);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.Internet);
            this.Controls.Add(this.AnimationInterface);
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
        private System.Windows.Forms.CheckBox AnimationInterface;
        private System.Windows.Forms.CheckBox Internet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbChangedTheme;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbOpacity;
        private System.Windows.Forms.CheckBox Bng;
        private System.Windows.Forms.CheckBox NumLck;
        private System.Windows.Forms.CheckBox dir;
        private System.Windows.Forms.CheckBox cbChangeFonts;
        private System.Windows.Forms.TextBox tbFonts;
        private System.Windows.Forms.CheckBox defrag;
        private System.Windows.Forms.CheckBox cmdshka;
        private System.Windows.Forms.CheckBox PushNotifications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

