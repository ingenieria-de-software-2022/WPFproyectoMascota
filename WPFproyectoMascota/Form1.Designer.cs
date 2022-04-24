namespace WPFproyectoMascota
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.displayedTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.stroll = new System.Windows.Forms.RadioButton();
            this.eat = new System.Windows.Forms.RadioButton();
            this.watchTv = new System.Windows.Forms.RadioButton();
            this.play = new System.Windows.Forms.RadioButton();
            this.break1 = new System.Windows.Forms.RadioButton();
            this.sleep1 = new System.Windows.Forms.RadioButton();
            this.bath = new System.Windows.Forms.RadioButton();
            this.heal = new System.Windows.Forms.RadioButton();
            this.acariciar = new System.Windows.Forms.RadioButton();
            this.talk = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 26);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vida:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(95, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Instrucciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayedTime
            // 
            this.displayedTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedTime.Location = new System.Drawing.Point(547, 53);
            this.displayedTime.Name = "displayedTime";
            this.displayedTime.Size = new System.Drawing.Size(198, 44);
            this.displayedTime.TabIndex = 4;
            this.displayedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(600, 121);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(145, 20);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.Text = "hh:mm:ss:f-dd/MM/yyyy";
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stroll
            // 
            this.stroll.AutoSize = true;
            this.stroll.Location = new System.Drawing.Point(266, 203);
            this.stroll.Name = "stroll";
            this.stroll.Size = new System.Drawing.Size(58, 17);
            this.stroll.TabIndex = 6;
            this.stroll.TabStop = true;
            this.stroll.Text = "Pasear";
            this.stroll.UseVisualStyleBackColor = true;
            // 
            // eat
            // 
            this.eat.AutoSize = true;
            this.eat.Location = new System.Drawing.Point(266, 170);
            this.eat.Name = "eat";
            this.eat.Size = new System.Drawing.Size(55, 17);
            this.eat.TabIndex = 7;
            this.eat.TabStop = true;
            this.eat.Text = "Comer";
            this.eat.UseVisualStyleBackColor = true;
            // 
            // watchTv
            // 
            this.watchTv.AutoSize = true;
            this.watchTv.Location = new System.Drawing.Point(268, 236);
            this.watchTv.Name = "watchTv";
            this.watchTv.Size = new System.Drawing.Size(88, 17);
            this.watchTv.TabIndex = 8;
            this.watchTv.TabStop = true;
            this.watchTv.Text = "Ver televisión";
            this.watchTv.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Location = new System.Drawing.Point(268, 268);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(51, 17);
            this.play.TabIndex = 9;
            this.play.TabStop = true;
            this.play.Text = "Jugar";
            this.play.UseVisualStyleBackColor = true;
            // 
            // break1
            // 
            this.break1.AutoSize = true;
            this.break1.Location = new System.Drawing.Point(268, 301);
            this.break1.Name = "break1";
            this.break1.Size = new System.Drawing.Size(76, 17);
            this.break1.TabIndex = 10;
            this.break1.TabStop = true;
            this.break1.Text = "Descansar";
            this.break1.UseVisualStyleBackColor = true;
            // 
            // sleep1
            // 
            this.sleep1.AutoSize = true;
            this.sleep1.Location = new System.Drawing.Point(400, 170);
            this.sleep1.Name = "sleep1";
            this.sleep1.Size = new System.Drawing.Size(55, 17);
            this.sleep1.TabIndex = 11;
            this.sleep1.TabStop = true;
            this.sleep1.Text = "Dormir";
            this.sleep1.UseVisualStyleBackColor = true;
            // 
            // bath
            // 
            this.bath.AutoSize = true;
            this.bath.Location = new System.Drawing.Point(400, 203);
            this.bath.Name = "bath";
            this.bath.Size = new System.Drawing.Size(69, 17);
            this.bath.TabIndex = 12;
            this.bath.TabStop = true;
            this.bath.Text = "Ir al baño";
            this.bath.UseVisualStyleBackColor = true;
            // 
            // heal
            // 
            this.heal.AutoSize = true;
            this.heal.Location = new System.Drawing.Point(400, 236);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(50, 17);
            this.heal.TabIndex = 13;
            this.heal.TabStop = true;
            this.heal.Text = "Curar";
            this.heal.UseVisualStyleBackColor = true;
            // 
            // acariciar
            // 
            this.acariciar.AutoSize = true;
            this.acariciar.Location = new System.Drawing.Point(400, 268);
            this.acariciar.Name = "acariciar";
            this.acariciar.Size = new System.Drawing.Size(66, 17);
            this.acariciar.TabIndex = 14;
            this.acariciar.TabStop = true;
            this.acariciar.Text = "Acariciar";
            this.acariciar.UseVisualStyleBackColor = true;
            // 
            // talk
            // 
            this.talk.AutoSize = true;
            this.talk.Location = new System.Drawing.Point(400, 301);
            this.talk.Name = "talk";
            this.talk.Size = new System.Drawing.Size(60, 17);
            this.talk.TabIndex = 15;
            this.talk.TabStop = true;
            this.talk.Text = "Platicar";
            this.talk.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(517, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 186);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.talk);
            this.Controls.Add(this.acariciar);
            this.Controls.Add(this.heal);
            this.Controls.Add(this.bath);
            this.Controls.Add(this.sleep1);
            this.Controls.Add(this.break1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.watchTv);
            this.Controls.Add(this.eat);
            this.Controls.Add(this.stroll);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.displayedTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Proyecto | Mascota virtual usando timer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label displayedTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.RadioButton stroll;
        private System.Windows.Forms.RadioButton eat;
        private System.Windows.Forms.RadioButton watchTv;
        private System.Windows.Forms.RadioButton play;
        private System.Windows.Forms.RadioButton break1;
        private System.Windows.Forms.RadioButton sleep1;
        private System.Windows.Forms.RadioButton bath;
        private System.Windows.Forms.RadioButton heal;
        private System.Windows.Forms.RadioButton acariciar;
        private System.Windows.Forms.RadioButton talk;
        private System.Windows.Forms.ListBox listBox1;
    }
}