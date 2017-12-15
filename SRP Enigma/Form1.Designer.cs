namespace SRP_Enigma
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
			this.rotorVenstreStatus = new System.Windows.Forms.TextBox();
			this.rotorMidtStatus = new System.Windows.Forms.TextBox();
			this.rotorHoejreStatus = new System.Windows.Forms.TextBox();
			this.krypteretResultat = new System.Windows.Forms.TextBox();
			this.tekstTilKryptering = new System.Windows.Forms.TextBox();
			this.rotorPlaceringVenstre = new System.Windows.Forms.TextBox();
			this.rotorPlaceringMidt = new System.Windows.Forms.TextBox();
			this.rotorPlaceringHoejre = new System.Windows.Forms.TextBox();
			this.rotor3Valg = new System.Windows.Forms.GroupBox();
			this.rotor3RotorV = new System.Windows.Forms.RadioButton();
			this.rotor3RotorIV = new System.Windows.Forms.RadioButton();
			this.rotor3RotorIII = new System.Windows.Forms.RadioButton();
			this.rotor3RotorII = new System.Windows.Forms.RadioButton();
			this.rotor3RotorI = new System.Windows.Forms.RadioButton();
			this.rotor2Valg = new System.Windows.Forms.GroupBox();
			this.rotor2RotorV = new System.Windows.Forms.RadioButton();
			this.rotor2RotorIV = new System.Windows.Forms.RadioButton();
			this.rotor2RotorIII = new System.Windows.Forms.RadioButton();
			this.rotor2RotorII = new System.Windows.Forms.RadioButton();
			this.rotor2RotorI = new System.Windows.Forms.RadioButton();
			this.rotor1Valg = new System.Windows.Forms.GroupBox();
			this.rotor1RotorV = new System.Windows.Forms.RadioButton();
			this.rotor1RotorIV = new System.Windows.Forms.RadioButton();
			this.rotor1RotorIII = new System.Windows.Forms.RadioButton();
			this.rotor1RotorII = new System.Windows.Forms.RadioButton();
			this.rotor1RotorI = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.rotor3Valg.SuspendLayout();
			this.rotor2Valg.SuspendLayout();
			this.rotor1Valg.SuspendLayout();
			this.SuspendLayout();
			// 
			// rotorVenstreStatus
			// 
			this.rotorVenstreStatus.Location = new System.Drawing.Point(233, 128);
			this.rotorVenstreStatus.Name = "rotorVenstreStatus";
			this.rotorVenstreStatus.Size = new System.Drawing.Size(62, 20);
			this.rotorVenstreStatus.TabIndex = 41;
			this.rotorVenstreStatus.Text = "0";
			// 
			// rotorMidtStatus
			// 
			this.rotorMidtStatus.Location = new System.Drawing.Point(335, 128);
			this.rotorMidtStatus.Name = "rotorMidtStatus";
			this.rotorMidtStatus.Size = new System.Drawing.Size(62, 20);
			this.rotorMidtStatus.TabIndex = 42;
			this.rotorMidtStatus.Text = "0";
			// 
			// rotorHoejreStatus
			// 
			this.rotorHoejreStatus.Location = new System.Drawing.Point(439, 128);
			this.rotorHoejreStatus.Name = "rotorHoejreStatus";
			this.rotorHoejreStatus.Size = new System.Drawing.Size(62, 20);
			this.rotorHoejreStatus.TabIndex = 43;
			this.rotorHoejreStatus.Text = "0";
			// 
			// krypteretResultat
			// 
			this.krypteretResultat.Location = new System.Drawing.Point(430, 311);
			this.krypteretResultat.Multiline = true;
			this.krypteretResultat.Name = "krypteretResultat";
			this.krypteretResultat.Size = new System.Drawing.Size(525, 239);
			this.krypteretResultat.TabIndex = 44;
			// 
			// tekstTilKryptering
			// 
			this.tekstTilKryptering.Location = new System.Drawing.Point(224, 311);
			this.tekstTilKryptering.Multiline = true;
			this.tekstTilKryptering.Name = "tekstTilKryptering";
			this.tekstTilKryptering.Size = new System.Drawing.Size(182, 239);
			this.tekstTilKryptering.TabIndex = 47;
			this.tekstTilKryptering.TextChanged += new System.EventHandler(this.tekstTilKryptering_TextChanged);
			// 
			// rotorPlaceringVenstre
			// 
			this.rotorPlaceringVenstre.Location = new System.Drawing.Point(233, 102);
			this.rotorPlaceringVenstre.Name = "rotorPlaceringVenstre";
			this.rotorPlaceringVenstre.Size = new System.Drawing.Size(62, 20);
			this.rotorPlaceringVenstre.TabIndex = 49;
			this.rotorPlaceringVenstre.Text = "A";
			// 
			// rotorPlaceringMidt
			// 
			this.rotorPlaceringMidt.Location = new System.Drawing.Point(335, 102);
			this.rotorPlaceringMidt.Name = "rotorPlaceringMidt";
			this.rotorPlaceringMidt.Size = new System.Drawing.Size(62, 20);
			this.rotorPlaceringMidt.TabIndex = 50;
			this.rotorPlaceringMidt.Text = "A";
			// 
			// rotorPlaceringHoejre
			// 
			this.rotorPlaceringHoejre.Location = new System.Drawing.Point(439, 102);
			this.rotorPlaceringHoejre.Name = "rotorPlaceringHoejre";
			this.rotorPlaceringHoejre.Size = new System.Drawing.Size(62, 20);
			this.rotorPlaceringHoejre.TabIndex = 51;
			this.rotorPlaceringHoejre.Text = "A";
			// 
			// rotor3Valg
			// 
			this.rotor3Valg.Controls.Add(this.rotor3RotorV);
			this.rotor3Valg.Controls.Add(this.rotor3RotorIV);
			this.rotor3Valg.Controls.Add(this.rotor3RotorIII);
			this.rotor3Valg.Controls.Add(this.rotor3RotorII);
			this.rotor3Valg.Controls.Add(this.rotor3RotorI);
			this.rotor3Valg.Location = new System.Drawing.Point(224, 154);
			this.rotor3Valg.Name = "rotor3Valg";
			this.rotor3Valg.Size = new System.Drawing.Size(96, 133);
			this.rotor3Valg.TabIndex = 57;
			this.rotor3Valg.TabStop = false;
			this.rotor3Valg.Text = "Rotor 3";
			// 
			// rotor3RotorV
			// 
			this.rotor3RotorV.AutoSize = true;
			this.rotor3RotorV.Location = new System.Drawing.Point(7, 112);
			this.rotor3RotorV.Name = "rotor3RotorV";
			this.rotor3RotorV.Size = new System.Drawing.Size(61, 17);
			this.rotor3RotorV.TabIndex = 4;
			this.rotor3RotorV.TabStop = true;
			this.rotor3RotorV.Text = "Rotor V";
			this.rotor3RotorV.UseVisualStyleBackColor = true;
			// 
			// rotor3RotorIV
			// 
			this.rotor3RotorIV.AutoSize = true;
			this.rotor3RotorIV.Location = new System.Drawing.Point(7, 89);
			this.rotor3RotorIV.Name = "rotor3RotorIV";
			this.rotor3RotorIV.Size = new System.Drawing.Size(64, 17);
			this.rotor3RotorIV.TabIndex = 3;
			this.rotor3RotorIV.TabStop = true;
			this.rotor3RotorIV.Text = "Rotor IV";
			this.rotor3RotorIV.UseVisualStyleBackColor = true;
			// 
			// rotor3RotorIII
			// 
			this.rotor3RotorIII.AutoSize = true;
			this.rotor3RotorIII.Location = new System.Drawing.Point(7, 66);
			this.rotor3RotorIII.Name = "rotor3RotorIII";
			this.rotor3RotorIII.Size = new System.Drawing.Size(63, 17);
			this.rotor3RotorIII.TabIndex = 2;
			this.rotor3RotorIII.TabStop = true;
			this.rotor3RotorIII.Text = "Rotor III";
			this.rotor3RotorIII.UseVisualStyleBackColor = true;
			// 
			// rotor3RotorII
			// 
			this.rotor3RotorII.AutoSize = true;
			this.rotor3RotorII.Location = new System.Drawing.Point(7, 43);
			this.rotor3RotorII.Name = "rotor3RotorII";
			this.rotor3RotorII.Size = new System.Drawing.Size(60, 17);
			this.rotor3RotorII.TabIndex = 1;
			this.rotor3RotorII.TabStop = true;
			this.rotor3RotorII.Text = "Rotor II";
			this.rotor3RotorII.UseVisualStyleBackColor = true;
			// 
			// rotor3RotorI
			// 
			this.rotor3RotorI.AutoSize = true;
			this.rotor3RotorI.Location = new System.Drawing.Point(7, 20);
			this.rotor3RotorI.Name = "rotor3RotorI";
			this.rotor3RotorI.Size = new System.Drawing.Size(57, 17);
			this.rotor3RotorI.TabIndex = 0;
			this.rotor3RotorI.TabStop = true;
			this.rotor3RotorI.Text = "Rotor I";
			this.rotor3RotorI.UseVisualStyleBackColor = true;
			// 
			// rotor2Valg
			// 
			this.rotor2Valg.Controls.Add(this.rotor2RotorV);
			this.rotor2Valg.Controls.Add(this.rotor2RotorIV);
			this.rotor2Valg.Controls.Add(this.rotor2RotorIII);
			this.rotor2Valg.Controls.Add(this.rotor2RotorII);
			this.rotor2Valg.Controls.Add(this.rotor2RotorI);
			this.rotor2Valg.Location = new System.Drawing.Point(326, 154);
			this.rotor2Valg.Name = "rotor2Valg";
			this.rotor2Valg.Size = new System.Drawing.Size(96, 133);
			this.rotor2Valg.TabIndex = 58;
			this.rotor2Valg.TabStop = false;
			this.rotor2Valg.Text = "Rotor 2";
			// 
			// rotor2RotorV
			// 
			this.rotor2RotorV.AutoSize = true;
			this.rotor2RotorV.Location = new System.Drawing.Point(7, 112);
			this.rotor2RotorV.Name = "rotor2RotorV";
			this.rotor2RotorV.Size = new System.Drawing.Size(61, 17);
			this.rotor2RotorV.TabIndex = 4;
			this.rotor2RotorV.TabStop = true;
			this.rotor2RotorV.Text = "Rotor V";
			this.rotor2RotorV.UseVisualStyleBackColor = true;
			// 
			// rotor2RotorIV
			// 
			this.rotor2RotorIV.AutoSize = true;
			this.rotor2RotorIV.Location = new System.Drawing.Point(7, 89);
			this.rotor2RotorIV.Name = "rotor2RotorIV";
			this.rotor2RotorIV.Size = new System.Drawing.Size(64, 17);
			this.rotor2RotorIV.TabIndex = 3;
			this.rotor2RotorIV.TabStop = true;
			this.rotor2RotorIV.Text = "Rotor IV";
			this.rotor2RotorIV.UseVisualStyleBackColor = true;
			// 
			// rotor2RotorIII
			// 
			this.rotor2RotorIII.AutoSize = true;
			this.rotor2RotorIII.Location = new System.Drawing.Point(7, 66);
			this.rotor2RotorIII.Name = "rotor2RotorIII";
			this.rotor2RotorIII.Size = new System.Drawing.Size(63, 17);
			this.rotor2RotorIII.TabIndex = 2;
			this.rotor2RotorIII.TabStop = true;
			this.rotor2RotorIII.Text = "Rotor III";
			this.rotor2RotorIII.UseVisualStyleBackColor = true;
			// 
			// rotor2RotorII
			// 
			this.rotor2RotorII.AutoSize = true;
			this.rotor2RotorII.Location = new System.Drawing.Point(7, 43);
			this.rotor2RotorII.Name = "rotor2RotorII";
			this.rotor2RotorII.Size = new System.Drawing.Size(60, 17);
			this.rotor2RotorII.TabIndex = 1;
			this.rotor2RotorII.TabStop = true;
			this.rotor2RotorII.Text = "Rotor II";
			this.rotor2RotorII.UseVisualStyleBackColor = true;
			// 
			// rotor2RotorI
			// 
			this.rotor2RotorI.AutoSize = true;
			this.rotor2RotorI.Location = new System.Drawing.Point(7, 20);
			this.rotor2RotorI.Name = "rotor2RotorI";
			this.rotor2RotorI.Size = new System.Drawing.Size(57, 17);
			this.rotor2RotorI.TabIndex = 0;
			this.rotor2RotorI.TabStop = true;
			this.rotor2RotorI.Text = "Rotor I";
			this.rotor2RotorI.UseVisualStyleBackColor = true;
			// 
			// rotor1Valg
			// 
			this.rotor1Valg.Controls.Add(this.rotor1RotorV);
			this.rotor1Valg.Controls.Add(this.rotor1RotorIV);
			this.rotor1Valg.Controls.Add(this.rotor1RotorIII);
			this.rotor1Valg.Controls.Add(this.rotor1RotorII);
			this.rotor1Valg.Controls.Add(this.rotor1RotorI);
			this.rotor1Valg.Location = new System.Drawing.Point(430, 154);
			this.rotor1Valg.Name = "rotor1Valg";
			this.rotor1Valg.Size = new System.Drawing.Size(96, 133);
			this.rotor1Valg.TabIndex = 58;
			this.rotor1Valg.TabStop = false;
			this.rotor1Valg.Text = "Rotor 1";
			// 
			// rotor1RotorV
			// 
			this.rotor1RotorV.AutoSize = true;
			this.rotor1RotorV.Location = new System.Drawing.Point(7, 112);
			this.rotor1RotorV.Name = "rotor1RotorV";
			this.rotor1RotorV.Size = new System.Drawing.Size(61, 17);
			this.rotor1RotorV.TabIndex = 4;
			this.rotor1RotorV.TabStop = true;
			this.rotor1RotorV.Text = "Rotor V";
			this.rotor1RotorV.UseVisualStyleBackColor = true;
			this.rotor1RotorV.CheckedChanged += new System.EventHandler(this.rotor_CheckedChanged);
			// 
			// rotor1RotorIV
			// 
			this.rotor1RotorIV.AutoSize = true;
			this.rotor1RotorIV.Location = new System.Drawing.Point(7, 89);
			this.rotor1RotorIV.Name = "rotor1RotorIV";
			this.rotor1RotorIV.Size = new System.Drawing.Size(64, 17);
			this.rotor1RotorIV.TabIndex = 3;
			this.rotor1RotorIV.TabStop = true;
			this.rotor1RotorIV.Text = "Rotor IV";
			this.rotor1RotorIV.UseVisualStyleBackColor = true;
			this.rotor1RotorIV.CheckedChanged += new System.EventHandler(this.rotor_CheckedChanged);
			// 
			// rotor1RotorIII
			// 
			this.rotor1RotorIII.AutoSize = true;
			this.rotor1RotorIII.Location = new System.Drawing.Point(7, 66);
			this.rotor1RotorIII.Name = "rotor1RotorIII";
			this.rotor1RotorIII.Size = new System.Drawing.Size(63, 17);
			this.rotor1RotorIII.TabIndex = 2;
			this.rotor1RotorIII.TabStop = true;
			this.rotor1RotorIII.Text = "Rotor III";
			this.rotor1RotorIII.UseVisualStyleBackColor = true;
			this.rotor1RotorIII.CheckedChanged += new System.EventHandler(this.rotor_CheckedChanged);
			// 
			// rotor1RotorII
			// 
			this.rotor1RotorII.AutoSize = true;
			this.rotor1RotorII.Location = new System.Drawing.Point(7, 43);
			this.rotor1RotorII.Name = "rotor1RotorII";
			this.rotor1RotorII.Size = new System.Drawing.Size(60, 17);
			this.rotor1RotorII.TabIndex = 1;
			this.rotor1RotorII.TabStop = true;
			this.rotor1RotorII.Text = "Rotor II";
			this.rotor1RotorII.UseVisualStyleBackColor = true;
			this.rotor1RotorII.CheckedChanged += new System.EventHandler(this.rotor_CheckedChanged);
			// 
			// rotor1RotorI
			// 
			this.rotor1RotorI.AutoSize = true;
			this.rotor1RotorI.Location = new System.Drawing.Point(6, 19);
			this.rotor1RotorI.Name = "rotor1RotorI";
			this.rotor1RotorI.Size = new System.Drawing.Size(57, 17);
			this.rotor1RotorI.TabIndex = 0;
			this.rotor1RotorI.TabStop = true;
			this.rotor1RotorI.Text = "Rotor I";
			this.rotor1RotorI.UseVisualStyleBackColor = true;
			this.rotor1RotorI.CheckedChanged += new System.EventHandler(this.rotor_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(532, 158);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 63;
			this.label1.Text = "ETW Reflektor ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1105, 599);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rotor1Valg);
			this.Controls.Add(this.rotor2Valg);
			this.Controls.Add(this.rotor3Valg);
			this.Controls.Add(this.rotorPlaceringHoejre);
			this.Controls.Add(this.rotorPlaceringMidt);
			this.Controls.Add(this.rotorPlaceringVenstre);
			this.Controls.Add(this.tekstTilKryptering);
			this.Controls.Add(this.krypteretResultat);
			this.Controls.Add(this.rotorHoejreStatus);
			this.Controls.Add(this.rotorMidtStatus);
			this.Controls.Add(this.rotorVenstreStatus);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.rotor3Valg.ResumeLayout(false);
			this.rotor3Valg.PerformLayout();
			this.rotor2Valg.ResumeLayout(false);
			this.rotor2Valg.PerformLayout();
			this.rotor1Valg.ResumeLayout(false);
			this.rotor1Valg.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rotorVenstreStatus;
        private System.Windows.Forms.TextBox rotorMidtStatus;
        private System.Windows.Forms.TextBox rotorHoejreStatus;
        private System.Windows.Forms.TextBox krypteretResultat;
        private System.Windows.Forms.TextBox tekstTilKryptering;
        private System.Windows.Forms.TextBox rotorPlaceringVenstre;
        private System.Windows.Forms.TextBox rotorPlaceringMidt;
        private System.Windows.Forms.TextBox rotorPlaceringHoejre;
		private System.Windows.Forms.GroupBox rotor3Valg;
		private System.Windows.Forms.RadioButton rotor3RotorV;
		private System.Windows.Forms.RadioButton rotor3RotorIV;
		private System.Windows.Forms.RadioButton rotor3RotorIII;
		private System.Windows.Forms.RadioButton rotor3RotorII;
		private System.Windows.Forms.RadioButton rotor3RotorI;
		private System.Windows.Forms.GroupBox rotor2Valg;
		private System.Windows.Forms.RadioButton rotor2RotorV;
		private System.Windows.Forms.RadioButton rotor2RotorIV;
		private System.Windows.Forms.RadioButton rotor2RotorIII;
		private System.Windows.Forms.RadioButton rotor2RotorII;
		private System.Windows.Forms.RadioButton rotor2RotorI;
		private System.Windows.Forms.GroupBox rotor1Valg;
		private System.Windows.Forms.RadioButton rotor1RotorV;
		private System.Windows.Forms.RadioButton rotor1RotorIV;
		private System.Windows.Forms.RadioButton rotor1RotorIII;
		private System.Windows.Forms.RadioButton rotor1RotorII;
		private System.Windows.Forms.RadioButton rotor1RotorI;
		private System.Windows.Forms.Label label1;
	}
}

