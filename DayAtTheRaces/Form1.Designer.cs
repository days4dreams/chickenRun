namespace DayAtTheRaces
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
            this.pictureBoxTrack = new System.Windows.Forms.PictureBox();
            this.animalOne = new System.Windows.Forms.PictureBox();
            this.animalTwo = new System.Windows.Forms.PictureBox();
            this.animalThree = new System.Windows.Forms.PictureBox();
            this.animalFour = new System.Windows.Forms.PictureBox();
            this.betArea = new System.Windows.Forms.GroupBox();
            this.chickInput = new System.Windows.Forms.NumericUpDown();
            this.amountInput = new System.Windows.Forms.NumericUpDown();
            this.introLabel = new System.Windows.Forms.Label();
            this.alStatusLabel = new System.Windows.Forms.Label();
            this.bobStatusLabel = new System.Windows.Forms.Label();
            this.joeStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placeBetLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.whichChickLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalFour)).BeginInit();
            this.betArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chickInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrack
            // 
            this.pictureBoxTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxTrack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrack.Image")));
            this.pictureBoxTrack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrack.InitialImage")));
            this.pictureBoxTrack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTrack.Name = "pictureBoxTrack";
            this.pictureBoxTrack.Size = new System.Drawing.Size(866, 260);
            this.pictureBoxTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTrack.TabIndex = 0;
            this.pictureBoxTrack.TabStop = false;
            // 
            // animalOne
            // 
            this.animalOne.BackColor = System.Drawing.SystemColors.Window;
            this.animalOne.Image = ((System.Drawing.Image)(resources.GetObject("animalOne.Image")));
            this.animalOne.Location = new System.Drawing.Point(18, 11);
            this.animalOne.Name = "animalOne";
            this.animalOne.Size = new System.Drawing.Size(49, 70);
            this.animalOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.animalOne.TabIndex = 1;
            this.animalOne.TabStop = false;
            // 
            // animalTwo
            // 
            this.animalTwo.BackColor = System.Drawing.SystemColors.Window;
            this.animalTwo.Image = ((System.Drawing.Image)(resources.GetObject("animalTwo.Image")));
            this.animalTwo.Location = new System.Drawing.Point(18, 77);
            this.animalTwo.Name = "animalTwo";
            this.animalTwo.Size = new System.Drawing.Size(49, 70);
            this.animalTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.animalTwo.TabIndex = 2;
            this.animalTwo.TabStop = false;
            // 
            // animalThree
            // 
            this.animalThree.BackColor = System.Drawing.SystemColors.Window;
            this.animalThree.Image = ((System.Drawing.Image)(resources.GetObject("animalThree.Image")));
            this.animalThree.Location = new System.Drawing.Point(18, 143);
            this.animalThree.Name = "animalThree";
            this.animalThree.Size = new System.Drawing.Size(49, 70);
            this.animalThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.animalThree.TabIndex = 3;
            this.animalThree.TabStop = false;
            // 
            // animalFour
            // 
            this.animalFour.BackColor = System.Drawing.SystemColors.Window;
            this.animalFour.Image = ((System.Drawing.Image)(resources.GetObject("animalFour.Image")));
            this.animalFour.Location = new System.Drawing.Point(18, 202);
            this.animalFour.Name = "animalFour";
            this.animalFour.Size = new System.Drawing.Size(49, 70);
            this.animalFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.animalFour.TabIndex = 4;
            this.animalFour.TabStop = false;
            // 
            // betArea
            // 
            this.betArea.Controls.Add(this.chickInput);
            this.betArea.Controls.Add(this.amountInput);
            this.betArea.Controls.Add(this.introLabel);
            this.betArea.Controls.Add(this.alStatusLabel);
            this.betArea.Controls.Add(this.bobStatusLabel);
            this.betArea.Controls.Add(this.joeStatusLabel);
            this.betArea.Controls.Add(this.label2);
            this.betArea.Controls.Add(this.placeBetLabel);
            this.betArea.Controls.Add(this.betButton);
            this.betArea.Controls.Add(this.whichChickLabel);
            this.betArea.Controls.Add(this.amountLabel);
            this.betArea.Controls.Add(this.nameLabel);
            this.betArea.Controls.Add(this.raceButton);
            this.betArea.Controls.Add(this.AlRadioButton);
            this.betArea.Controls.Add(this.bobRadioButton);
            this.betArea.Controls.Add(this.joeRadioButton);
            this.betArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betArea.Location = new System.Drawing.Point(12, 280);
            this.betArea.Name = "betArea";
            this.betArea.Size = new System.Drawing.Size(865, 121);
            this.betArea.TabIndex = 5;
            this.betArea.TabStop = false;
            this.betArea.Text = "Place Your Bets!";
            // 
            // chickInput
            // 
            this.chickInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickInput.Location = new System.Drawing.Point(316, 92);
            this.chickInput.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.chickInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chickInput.Name = "chickInput";
            this.chickInput.Size = new System.Drawing.Size(91, 22);
            this.chickInput.TabIndex = 18;
            this.chickInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountInput
            // 
            this.amountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInput.Location = new System.Drawing.Point(316, 39);
            this.amountInput.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(91, 22);
            this.amountInput.TabIndex = 17;
            this.amountInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // introLabel
            // 
            this.introLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(6, 34);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(142, 84);
            this.introLabel.TabIndex = 16;
            this.introLabel.Text = "Select your bettor\r\nChoose the amount\r\nChoose your Chick\r\nPlace your Bet\r\nStart t" +
    "he race!";
            // 
            // alStatusLabel
            // 
            this.alStatusLabel.AutoSize = true;
            this.alStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alStatusLabel.Location = new System.Drawing.Point(602, 95);
            this.alStatusLabel.Name = "alStatusLabel";
            this.alStatusLabel.Size = new System.Drawing.Size(89, 16);
            this.alStatusLabel.TabIndex = 15;
            this.alStatusLabel.Text = "Al isn\'t betting";
            // 
            // bobStatusLabel
            // 
            this.bobStatusLabel.AutoSize = true;
            this.bobStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobStatusLabel.Location = new System.Drawing.Point(602, 70);
            this.bobStatusLabel.Name = "bobStatusLabel";
            this.bobStatusLabel.Size = new System.Drawing.Size(102, 16);
            this.bobStatusLabel.TabIndex = 14;
            this.bobStatusLabel.Text = "Bob isn\'t betting";
            // 
            // joeStatusLabel
            // 
            this.joeStatusLabel.AutoSize = true;
            this.joeStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeStatusLabel.Location = new System.Drawing.Point(602, 44);
            this.joeStatusLabel.Name = "joeStatusLabel";
            this.joeStatusLabel.Size = new System.Drawing.Size(100, 16);
            this.joeStatusLabel.TabIndex = 13;
            this.joeStatusLabel.Text = "Joe isn\'t betting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Live Bets:";
            // 
            // placeBetLabel
            // 
            this.placeBetLabel.AutoSize = true;
            this.placeBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBetLabel.Location = new System.Drawing.Point(449, 17);
            this.placeBetLabel.Name = "placeBetLabel";
            this.placeBetLabel.Size = new System.Drawing.Size(114, 16);
            this.placeBetLabel.TabIndex = 11;
            this.placeBetLabel.Text = "Confirm choice:";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(452, 40);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(105, 43);
            this.betButton.TabIndex = 10;
            this.betButton.Text = "Place Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // whichChickLabel
            // 
            this.whichChickLabel.AutoSize = true;
            this.whichChickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichChickLabel.Location = new System.Drawing.Point(313, 69);
            this.whichChickLabel.Name = "whichChickLabel";
            this.whichChickLabel.Size = new System.Drawing.Size(94, 16);
            this.whichChickLabel.TabIndex = 7;
            this.whichChickLabel.Text = "Which chick:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(313, 17);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(82, 16);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "How much:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(170, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Who\'s betting:";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(764, 23);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(89, 87);
            this.raceButton.TabIndex = 4;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlRadioButton.Location = new System.Drawing.Point(170, 93);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(87, 20);
            this.AlRadioButton.TabIndex = 3;
            this.AlRadioButton.Text = "Al has £45";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobRadioButton.Location = new System.Drawing.Point(170, 67);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(100, 20);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "Bob has £75";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeRadioButton.Location = new System.Drawing.Point(170, 41);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 20);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe has £50";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 410);
            this.Controls.Add(this.betArea);
            this.Controls.Add(this.animalFour);
            this.Controls.Add(this.animalThree);
            this.Controls.Add(this.animalTwo);
            this.Controls.Add(this.animalOne);
            this.Controls.Add(this.pictureBoxTrack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalFour)).EndInit();
            this.betArea.ResumeLayout(false);
            this.betArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chickInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrack;
        private System.Windows.Forms.PictureBox animalOne;
        private System.Windows.Forms.PictureBox animalTwo;
        private System.Windows.Forms.PictureBox animalThree;
        private System.Windows.Forms.PictureBox animalFour;
        private System.Windows.Forms.GroupBox betArea;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label placeBetLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label whichChickLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label alStatusLabel;
        private System.Windows.Forms.Label bobStatusLabel;
        private System.Windows.Forms.Label joeStatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown chickInput;
        private System.Windows.Forms.NumericUpDown amountInput;
    }
}

