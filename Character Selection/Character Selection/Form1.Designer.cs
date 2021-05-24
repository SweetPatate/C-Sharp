namespace Character_Selection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarDexterity = new System.Windows.Forms.TrackBar();
            this.trackBarIntelligence = new System.Windows.Forms.TrackBar();
            this.trackBarStrength = new System.Windows.Forms.TrackBar();
            this.trackBarVitality = new System.Windows.Forms.TrackBar();
            this.Validate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNBdext = new System.Windows.Forms.Label();
            this.labelNBint = new System.Windows.Forms.Label();
            this.labelNBstrength = new System.Windows.Forms.Label();
            this.labelNBvitality = new System.Windows.Forms.Label();
            this.previousPicture = new System.Windows.Forms.Button();
            this.nextPicture = new System.Windows.Forms.Button();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVitality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intelligence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vitality";
            // 
            // trackBarDexterity
            // 
            this.trackBarDexterity.Location = new System.Drawing.Point(414, 67);
            this.trackBarDexterity.Name = "trackBarDexterity";
            this.trackBarDexterity.Size = new System.Drawing.Size(104, 45);
            this.trackBarDexterity.TabIndex = 5;
            this.trackBarDexterity.Scroll += new System.EventHandler(this.trackBarDexterity_Scroll);
            // 
            // trackBarIntelligence
            // 
            this.trackBarIntelligence.Location = new System.Drawing.Point(414, 128);
            this.trackBarIntelligence.Name = "trackBarIntelligence";
            this.trackBarIntelligence.Size = new System.Drawing.Size(104, 45);
            this.trackBarIntelligence.TabIndex = 6;
            this.trackBarIntelligence.Scroll += new System.EventHandler(this.trackBarIntelligence_Scroll);
            // 
            // trackBarStrength
            // 
            this.trackBarStrength.Location = new System.Drawing.Point(414, 192);
            this.trackBarStrength.Name = "trackBarStrength";
            this.trackBarStrength.Size = new System.Drawing.Size(104, 45);
            this.trackBarStrength.TabIndex = 7;
            this.trackBarStrength.Scroll += new System.EventHandler(this.trackBarStrength_Scroll);
            // 
            // trackBarVitality
            // 
            this.trackBarVitality.Location = new System.Drawing.Point(414, 256);
            this.trackBarVitality.Name = "trackBarVitality";
            this.trackBarVitality.Size = new System.Drawing.Size(104, 45);
            this.trackBarVitality.TabIndex = 8;
            this.trackBarVitality.Scroll += new System.EventHandler(this.trackBarVitality_Scroll);
            // 
            // Validate
            // 
            this.Validate.Location = new System.Drawing.Point(443, 360);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(75, 23);
            this.Validate.TabIndex = 9;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(154, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // labelNBdext
            // 
            this.labelNBdext.AutoSize = true;
            this.labelNBdext.Location = new System.Drawing.Point(524, 67);
            this.labelNBdext.Name = "labelNBdext";
            this.labelNBdext.Size = new System.Drawing.Size(13, 13);
            this.labelNBdext.TabIndex = 11;
            this.labelNBdext.Text = "0";
            // 
            // labelNBint
            // 
            this.labelNBint.AutoSize = true;
            this.labelNBint.Location = new System.Drawing.Point(524, 128);
            this.labelNBint.Name = "labelNBint";
            this.labelNBint.Size = new System.Drawing.Size(13, 13);
            this.labelNBint.TabIndex = 12;
            this.labelNBint.Text = "0";
            // 
            // labelNBstrength
            // 
            this.labelNBstrength.AutoSize = true;
            this.labelNBstrength.Location = new System.Drawing.Point(524, 192);
            this.labelNBstrength.Name = "labelNBstrength";
            this.labelNBstrength.Size = new System.Drawing.Size(13, 13);
            this.labelNBstrength.TabIndex = 13;
            this.labelNBstrength.Text = "0";
            // 
            // labelNBvitality
            // 
            this.labelNBvitality.AutoSize = true;
            this.labelNBvitality.Location = new System.Drawing.Point(524, 256);
            this.labelNBvitality.Name = "labelNBvitality";
            this.labelNBvitality.Size = new System.Drawing.Size(13, 13);
            this.labelNBvitality.TabIndex = 14;
            this.labelNBvitality.Text = "0";
            // 
            // previousPicture
            // 
            this.previousPicture.Location = new System.Drawing.Point(13, 181);
            this.previousPicture.Name = "previousPicture";
            this.previousPicture.Size = new System.Drawing.Size(35, 25);
            this.previousPicture.TabIndex = 15;
            this.previousPicture.Text = "<";
            this.previousPicture.UseVisualStyleBackColor = true;
            this.previousPicture.Click += new System.EventHandler(this.previousPicture_Click);
            // 
            // nextPicture
            // 
            this.nextPicture.Location = new System.Drawing.Point(322, 181);
            this.nextPicture.Name = "nextPicture";
            this.nextPicture.Size = new System.Drawing.Size(35, 25);
            this.nextPicture.TabIndex = 16;
            this.nextPicture.Text = ">";
            this.nextPicture.UseVisualStyleBackColor = true;
            this.nextPicture.Click += new System.EventHandler(this.nextPicture_Click);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(98, 112);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(206, 189);
            this.pictureBoxPlayer.TabIndex = 17;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.nextPicture);
            this.Controls.Add(this.previousPicture);
            this.Controls.Add(this.labelNBvitality);
            this.Controls.Add(this.labelNBstrength);
            this.Controls.Add(this.labelNBint);
            this.Controls.Add(this.labelNBdext);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.trackBarVitality);
            this.Controls.Add(this.trackBarStrength);
            this.Controls.Add(this.trackBarIntelligence);
            this.Controls.Add(this.trackBarDexterity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVitality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarDexterity;
        private System.Windows.Forms.TrackBar trackBarIntelligence;
        private System.Windows.Forms.TrackBar trackBarStrength;
        private System.Windows.Forms.TrackBar trackBarVitality;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNBdext;
        private System.Windows.Forms.Label labelNBint;
        private System.Windows.Forms.Label labelNBstrength;
        private System.Windows.Forms.Label labelNBvitality;
        private System.Windows.Forms.Button previousPicture;
        private System.Windows.Forms.Button nextPicture;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
    }
}

