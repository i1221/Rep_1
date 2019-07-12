namespace rsh
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SetWebhook = new System.Windows.Forms.Button();
            this.txtb_webhookUrl = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_GetAccountInfo = new System.Windows.Forms.Button();
            this.btn_Clear_richTxtB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_SetWebhookViberBot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 224);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(218, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebHook";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.txtb_webhookUrl);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Установить";
            // 
            // btn_SetWebhook
            // 
            this.btn_SetWebhook.Location = new System.Drawing.Point(6, 19);
            this.btn_SetWebhook.Name = "btn_SetWebhook";
            this.btn_SetWebhook.Size = new System.Drawing.Size(75, 23);
            this.btn_SetWebhook.TabIndex = 2;
            this.btn_SetWebhook.Text = "Установить";
            this.btn_SetWebhook.UseVisualStyleBackColor = true;
            this.btn_SetWebhook.Click += new System.EventHandler(this.btn_SetWebhook_Click);
            // 
            // txtb_webhookUrl
            // 
            this.txtb_webhookUrl.Location = new System.Drawing.Point(10, 19);
            this.txtb_webhookUrl.Name = "txtb_webhookUrl";
            this.txtb_webhookUrl.Size = new System.Drawing.Size(187, 20);
            this.txtb_webhookUrl.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_GetAccountInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Аккаунт";
            // 
            // btn_GetAccountInfo
            // 
            this.btn_GetAccountInfo.Location = new System.Drawing.Point(6, 19);
            this.btn_GetAccountInfo.Name = "btn_GetAccountInfo";
            this.btn_GetAccountInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_GetAccountInfo.TabIndex = 3;
            this.btn_GetAccountInfo.Text = "Получить";
            this.btn_GetAccountInfo.UseVisualStyleBackColor = true;
            this.btn_GetAccountInfo.Click += new System.EventHandler(this.btn_GetAccountInfo_Click);
            // 
            // btn_Clear_richTxtB
            // 
            this.btn_Clear_richTxtB.Location = new System.Drawing.Point(713, 254);
            this.btn_Clear_richTxtB.Name = "btn_Clear_richTxtB";
            this.btn_Clear_richTxtB.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_richTxtB.TabIndex = 4;
            this.btn_Clear_richTxtB.Text = "Очистить";
            this.btn_Clear_richTxtB.UseVisualStyleBackColor = true;
            this.btn_Clear_richTxtB.Click += new System.EventHandler(this.btn_Clear_richTxtB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_SetWebhook);
            this.groupBox4.Location = new System.Drawing.Point(10, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(88, 57);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ViberApi";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_SetWebhookViberBot);
            this.groupBox5.Location = new System.Drawing.Point(135, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(89, 56);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "viber.bot";
            // 
            // btn_SetWebhookViberBot
            // 
            this.btn_SetWebhookViberBot.Location = new System.Drawing.Point(6, 19);
            this.btn_SetWebhookViberBot.Name = "btn_SetWebhookViberBot";
            this.btn_SetWebhookViberBot.Size = new System.Drawing.Size(75, 23);
            this.btn_SetWebhookViberBot.TabIndex = 7;
            this.btn_SetWebhookViberBot.Text = "Установить";
            this.btn_SetWebhookViberBot.UseVisualStyleBackColor = true;
            this.btn_SetWebhookViberBot.Click += new System.EventHandler(this.btn_SetWebhookViberBot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btn_Clear_richTxtB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtb_webhookUrl;
        private System.Windows.Forms.Button btn_SetWebhook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_GetAccountInfo;
        private System.Windows.Forms.Button btn_Clear_richTxtB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_SetWebhookViberBot;
    }
}

