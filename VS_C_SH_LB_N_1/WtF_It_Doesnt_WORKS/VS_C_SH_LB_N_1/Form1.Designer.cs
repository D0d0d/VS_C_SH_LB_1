namespace VS_C_SH_LB_N_1
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
            this.components = new System.ComponentModel.Container();
            this.lbx = new System.Windows.Forms.ListBox();
            this.lbx_prop = new System.Windows.Forms.ListBox();
            this.btn_discover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.ItemHeight = 16;
            this.lbx.Location = new System.Drawing.Point(12, 12);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(168, 340);
            this.lbx.TabIndex = 0;
            this.lbx.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbx_prop
            // 
            this.lbx_prop.FormattingEnabled = true;
            this.lbx_prop.ItemHeight = 16;
            this.lbx_prop.Location = new System.Drawing.Point(186, 12);
            this.lbx_prop.Name = "lbx_prop";
            this.lbx_prop.Size = new System.Drawing.Size(602, 340);
            this.lbx_prop.TabIndex = 1;
            // 
            // btn_discover
            // 
            this.btn_discover.Location = new System.Drawing.Point(12, 370);
            this.btn_discover.Name = "btn_discover";
            this.btn_discover.Size = new System.Drawing.Size(168, 33);
            this.btn_discover.TabIndex = 2;
            this.btn_discover.Text = "Искать устройства";
            this.btn_discover.UseVisualStyleBackColor = true;
            this.btn_discover.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Внутр. информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_discover);
            this.Controls.Add(this.lbx_prop);
            this.Controls.Add(this.lbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.ListBox lbx_prop;
        private System.Windows.Forms.Button btn_discover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

