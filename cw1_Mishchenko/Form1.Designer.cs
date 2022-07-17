
namespace cw1_Mishchenko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic_ruchka = new System.Windows.Forms.PictureBox();
            this.label_txt_last_result = new System.Windows.Forms.Label();
            this.label_txt_result = new System.Windows.Forms.Label();
            this.label_stat = new System.Windows.Forms.Label();
            this.label_txt_dve = new System.Windows.Forms.Label();
            this.label_txt_tri = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ruchka)).BeginInit();
            this.SuspendLayout();
            // 
            // pic3
            // 
            this.pic3.Image = global::cw1_Mishchenko.Properties.Resources.suit1;
            this.pic3.Location = new System.Drawing.Point(295, 40);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(71, 96);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic3.TabIndex = 3;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::cw1_Mishchenko.Properties.Resources.suit1;
            this.pic2.Location = new System.Drawing.Point(165, 40);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(71, 96);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::cw1_Mishchenko.Properties.Resources.suit1;
            this.pic1.Location = new System.Drawing.Point(40, 40);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(71, 96);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // pic_ruchka
            // 
            this.pic_ruchka.ErrorImage = null;
            this.pic_ruchka.Image = global::cw1_Mishchenko.Properties.Resources.handleUp;
            this.pic_ruchka.InitialImage = null;
            this.pic_ruchka.Location = new System.Drawing.Point(435, 12);
            this.pic_ruchka.Name = "pic_ruchka";
            this.pic_ruchka.Size = new System.Drawing.Size(71, 211);
            this.pic_ruchka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_ruchka.TabIndex = 0;
            this.pic_ruchka.TabStop = false;
            this.pic_ruchka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_ruchka_MouseDown);
            this.pic_ruchka.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_ruchka_MouseUp);
            // 
            // label_txt_last_result
            // 
            this.label_txt_last_result.AutoSize = true;
            this.label_txt_last_result.Location = new System.Drawing.Point(37, 167);
            this.label_txt_last_result.Name = "label_txt_last_result";
            this.label_txt_last_result.Size = new System.Drawing.Size(168, 17);
            this.label_txt_last_result.TabIndex = 4;
            this.label_txt_last_result.Text = "Последний результат: 0";
            // 
            // label_txt_result
            // 
            this.label_txt_result.AutoSize = true;
            this.label_txt_result.Location = new System.Drawing.Point(37, 184);
            this.label_txt_result.Name = "label_txt_result";
            this.label_txt_result.Size = new System.Drawing.Size(124, 17);
            this.label_txt_result.TabIndex = 6;
            this.label_txt_result.Text = "Набрано очков: 0";
            // 
            // label_stat
            // 
            this.label_stat.AutoSize = true;
            this.label_stat.Location = new System.Drawing.Point(40, 205);
            this.label_stat.Name = "label_stat";
            this.label_stat.Size = new System.Drawing.Size(88, 17);
            this.label_stat.TabIndex = 8;
            this.label_stat.Text = "Статистика:";
            // 
            // label_txt_dve
            // 
            this.label_txt_dve.AutoSize = true;
            this.label_txt_dve.Location = new System.Drawing.Point(67, 226);
            this.label_txt_dve.Name = "label_txt_dve";
            this.label_txt_dve.Size = new System.Drawing.Size(261, 17);
            this.label_txt_dve.TabIndex = 9;
            this.label_txt_dve.Text = "2 одинаковые картинки выпало 0 раз ";
            // 
            // label_txt_tri
            // 
            this.label_txt_tri.AutoSize = true;
            this.label_txt_tri.Location = new System.Drawing.Point(67, 247);
            this.label_txt_tri.Name = "label_txt_tri";
            this.label_txt_tri.Size = new System.Drawing.Size(257, 17);
            this.label_txt_tri.TabIndex = 12;
            this.label_txt_tri.Text = "3 одинаковые картинки выпало 0 раз";
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 299);
            this.Controls.Add(this.label_txt_tri);
            this.Controls.Add(this.label_txt_dve);
            this.Controls.Add(this.label_stat);
            this.Controls.Add(this.label_txt_result);
            this.Controls.Add(this.label_txt_last_result);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic_ruchka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Однорукий бандит";
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ruchka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ruchka;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label label_txt_last_result;
        private System.Windows.Forms.Label label_txt_result;
        private System.Windows.Forms.Label label_stat;
        private System.Windows.Forms.Label label_txt_dve;
        private System.Windows.Forms.Label label_txt_tri;
        private System.Windows.Forms.Timer timer;
    }
}

