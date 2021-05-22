namespace Minuteur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxHeure = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSeconde = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Heures_label = new System.Windows.Forms.Label();
            this.Minutes_label = new System.Windows.Forms.Label();
            this.Secondes_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.reapeat_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "heures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "secondes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxHeure
            // 
            this.textBoxHeure.Location = new System.Drawing.Point(50, 65);
            this.textBoxHeure.MaxLength = 3;
            this.textBoxHeure.Name = "textBoxHeure";
            this.textBoxHeure.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeure.TabIndex = 10;
            this.textBoxHeure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verif_int);
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(165, 65);
            this.textBoxMinute.MaxLength = 3;
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinute.TabIndex = 11;
            this.textBoxMinute.TextChanged += new System.EventHandler(this.textBoxMinute_TextChanged);
            this.textBoxMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verif_int);
            // 
            // textBoxSeconde
            // 
            this.textBoxSeconde.Location = new System.Drawing.Point(280, 65);
            this.textBoxSeconde.MaxLength = 3;
            this.textBoxSeconde.Name = "textBoxSeconde";
            this.textBoxSeconde.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeconde.TabIndex = 12;
            this.textBoxSeconde.TextChanged += new System.EventHandler(this.textBoxSeconde_TextChanged);
            this.textBoxSeconde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verif_int);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_tick);
            // 
            // Heures_label
            // 
            this.Heures_label.AutoSize = true;
            this.Heures_label.Location = new System.Drawing.Point(70, 150);
            this.Heures_label.Name = "Heures_label";
            this.Heures_label.Size = new System.Drawing.Size(13, 13);
            this.Heures_label.TabIndex = 13;
            this.Heures_label.Text = "0";
            // 
            // Minutes_label
            // 
            this.Minutes_label.AutoSize = true;
            this.Minutes_label.Location = new System.Drawing.Point(190, 150);
            this.Minutes_label.Name = "Minutes_label";
            this.Minutes_label.Size = new System.Drawing.Size(13, 13);
            this.Minutes_label.TabIndex = 14;
            this.Minutes_label.Text = "0";
            // 
            // Secondes_label
            // 
            this.Secondes_label.AutoSize = true;
            this.Secondes_label.Location = new System.Drawing.Point(310, 150);
            this.Secondes_label.Name = "Secondes_label";
            this.Secondes_label.Size = new System.Drawing.Size(13, 13);
            this.Secondes_label.TabIndex = 15;
            this.Secondes_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = ":";
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPause.Image")));
            this.pictureBoxPause.Location = new System.Drawing.Point(495, 53);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(53, 50);
            this.pictureBoxPause.TabIndex = 18;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.pictureBoxPause_Click);
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(400, 95);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(61, 17);
            this.repeatCheckBox.TabIndex = 19;
            this.repeatCheckBox.Text = "Repeat";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            this.repeatCheckBox.CheckedChanged += new System.EventHandler(this.repeatCheckBox_CheckedChanged);
            // 
            // reapeat_label
            // 
            this.reapeat_label.AutoSize = true;
            this.reapeat_label.Location = new System.Drawing.Point(397, 115);
            this.reapeat_label.Name = "reapeat_label";
            this.reapeat_label.Size = new System.Drawing.Size(0, 13);
            this.reapeat_label.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.reapeat_label);
            this.Controls.Add(this.repeatCheckBox);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Secondes_label);
            this.Controls.Add(this.Minutes_label);
            this.Controls.Add(this.Heures_label);
            this.Controls.Add(this.textBoxSeconde);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHeure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandglass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxHeure;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSeconde;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Heures_label;
        private System.Windows.Forms.Label Minutes_label;
        private System.Windows.Forms.Label Secondes_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.Label reapeat_label;
    }
}

