using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

	namespace SRP_Enigma
	{
		public partial class Form1 : Form
		{
			char[] ETW = new char[26]
				{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

			char[] rotorI = new char[26] //Stort startsbogstav for at passe med teksten i brugergrænseflade
				{'E','K','M','F','L','G','D','Q','V','Z','N','T','O','W','Y','H','X','U','S','P','A','I','B','R','C','J'};

			char[] rotorII = new char[26]
				{'A','J','D','K','S','I','R','U','X','B','L','H','W','T','M','C','Q','G','Z','N','P','Y','F','V','O','E'};

			char[] rotorIII = new char[26]
				{'B','D','F','H','J','L','C','P','R','T','X','V','Z','N','Y','E','I','W','G','A','K','M','U','S','Q','O'};

			char[] rotorIV = new char[26]
				{'E','S','O','V','P','Z','J','A','Y','Q','U','I','R','H','X','L','N','F','T','G','K','D','C','M','W','B'};

			char[] rotorV = new char[26]
				{'V','Z','B','R','G','I','T','Y','U','P','S','D','N','H','L','X','A','W','M','J','Q','O','F','E','C','K'};

			char[] reflektorIndgang = new char[26]
				{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

			char[] reflektorBUdgang = new char[26]
				{'Y','R','U','H','Q','S','L','D','P','X','N','G','O','K','M','I','E','B','F','Z','C','W','V','J','A','T'};

			char[] reflektorCUdgang = new char[26]
				{'F','V','P','J','I','A','O','Y','E','D','R','Z','X','W','G','C','T','K','U','Q','S','B','N','M','H','L'};

			int rotorHoejreStatusInt = 0;
			int rotorMidtStatusInt = 0;
			int rotorVenstreStatusInt = 0;

			int taeller = 0;
			int taellerFindBogstav = 0;
		
			char bogstav;

			string rotor1Valgt(GroupBox rotor1Valg)
			{ return rotor1Valg.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked == true).Text; }
			//{ return rotor1Valg.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked == true).Text.Replace(" ", string.Empty); }

			string rotor2Valgt(GroupBox rotor2Valg)
			{ return rotor2Valg.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked == true).Text; }

			string rotor3Valgt(GroupBox rotor3Valg)
			{ return rotor3Valg.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked == true).Text; }

			public Form1()
			{
				InitializeComponent();
			}

			private void Form1_Load(object sender, EventArgs e)
			{
				tekstTilKryptering.Select();

				opdaterTekst();
			}

			private void tekstTilKryptering_TextChanged(object sender, EventArgs e)
			{
				krypteringAlgoritme();
			}

			void krypteringAlgoritme()
			{
				tekstTilKryptering.Select(tekstTilKryptering.Text.Length, 0);
				tekstTilKryptering.CharacterCasing = CharacterCasing.Upper;

				char[] tekstTilKrypteringChar = tekstTilKryptering.Text.ToCharArray();

				while (taeller < tekstTilKrypteringChar.Length)
				{
					krypterChar();
					taeller++;
				}

				void krypterChar()
				{
					bogstav = tekstTilKrypteringChar[taeller];

					while (bogstav.Equals(ETW[taellerFindBogstav]) == false)
					{
						if
						(
						Convert.ToString(bogstav) == " " ||
						Convert.ToString(bogstav) == "." ||
						Convert.ToString(bogstav) == "," ||
						Convert.ToString(bogstav) == "?" ||
						Convert.ToString(bogstav) == "Æ" ||
						Convert.ToString(bogstav) == "Ø" ||
						Convert.ToString(bogstav) == "Å"
						)
							goto undtagelsen;

						else taellerFindBogstav++;
					}

					krypterTrinIndgag();
					krypterTrinReflektor();
					krypterTrinUdgang();


					undtagelsen:
					krypteretResultat.Text += Convert.ToString(bogstav);
					taellerFindBogstav = 0;
				}

				void checkRotorStatusAfslut()
				{
					switch (rotor1Valgt(rotor1Valg))
					{
						case "Rotor I":
							if (rotorHoejreStatusInt == 17) rotorMidtStatusInt++;
							break;
						case "Rotor II":
							if (rotorHoejreStatusInt == 25) rotorMidtStatusInt++;
							break;
						case "Rotor III":
							if (rotorHoejreStatusInt == 11) rotorMidtStatusInt++;
							break;
						case "Rotor IV":
							if (rotorHoejreStatusInt == 6) rotorMidtStatusInt++;
							break;
						case "Rotor V":
							if (rotorHoejreStatusInt == 1) rotorMidtStatusInt++;
							break;
					}
					switch (rotor2Valgt(rotor2Valg))
					{
						case "Rotor I":
							if (rotorMidtStatusInt == 17) rotorVenstreStatusInt++;
							break;
						case "Rotor II":
							if (rotorMidtStatusInt == 25) rotorVenstreStatusInt++;
							break;
						case "Rotor III":
							if (rotorMidtStatusInt == 11) rotorVenstreStatusInt++;
							break;
						case "Rotor IV":
							if (rotorMidtStatusInt == 6) rotorVenstreStatusInt++;
							break;
						case "Rotor V":
							if (rotorMidtStatusInt == 1) rotorVenstreStatusInt++;
							break;
					}
					switch (rotor3Valgt(rotor3Valg))
					{
						case "Rotor I":
							if (rotorVenstreStatusInt == 17) rotorMidtStatusInt++;
							break;
						case "Rotor II":
							if (rotorVenstreStatusInt == 25) rotorMidtStatusInt++;
							break;
						case "Rotor III":
							if (rotorVenstreStatusInt == 11) rotorMidtStatusInt++;
							break;
						case "Rotor IV":
							if (rotorVenstreStatusInt == 6) rotorMidtStatusInt++;
							break;
						case "Rotor V":
							if (rotorVenstreStatusInt == 1) rotorMidtStatusInt++;
							break;
					}
					if (rotorHoejreStatusInt == 26) rotorHoejreStatusInt = 0;
					if (rotorMidtStatusInt == 26) rotorMidtStatusInt = 0;
					if (rotorVenstreStatusInt == 26) rotorVenstreStatusInt = 0;
				}		

				void rotorOffsetTilpas()
				{
					if ((taellerFindBogstav + rotorHoejreStatusInt) > 25) taellerFindBogstav = 0;
					if ((taellerFindBogstav + rotorMidtStatusInt) > 25) taellerFindBogstav = 0;
					if ((taellerFindBogstav + rotorVenstreStatusInt) > 25) taellerFindBogstav = 0;
				}

				void krypterTrinIndgag()
				{
					if (rotorHoejreStatusInt < 26) rotorHoejreStatusInt++;
					rotorOffsetTilpas();
					checkRotorStatusAfslut();
					krypterCharRotorHoejre();

					taellerFindBogstav = taellerFindBogstav + rotorHoejreStatusInt;
					rotorOffsetTilpas();
					krypterCharRotorMidt();


					taellerFindBogstav = taellerFindBogstav + rotorMidtStatusInt;
					rotorOffsetTilpas();
					krypterCharRotorVenstre();
				}

				void krypterTrinReflektor()
				{
					taellerFindBogstav = taellerFindBogstav + rotorVenstreStatusInt;
					bogstav = reflektorBUdgang[taellerFindBogstav];
				}

				void krypterTrinUdgang()
				{

					rotorOffsetTilpas();
					krypterCharRotorVenstre();

					taellerFindBogstav = taellerFindBogstav + rotorMidtStatusInt;
					rotorOffsetTilpas();
					krypterCharRotorMidt();

					taellerFindBogstav = taellerFindBogstav + rotorHoejreStatusInt;
					rotorOffsetTilpas();
					krypterCharRotorHoejre();
				}

				void krypterCharRotorHoejre()
				{
					switch (rotor1Valgt(rotor1Valg))
					{
						case "Rotor I":
							bogstav = rotorI[(taellerFindBogstav + rotorHoejreStatusInt)];
							rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt); //Gider ikke at virke med .ToString(); ... .ToString() virker ikke med "null" værdier 
							rotorPlaceringHoejre.Text = Convert.ToString(rotorI[rotorHoejreStatusInt]);
							break;

						case "Rotor II":
							bogstav = rotorII[(taellerFindBogstav + rotorHoejreStatusInt)];
							rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
							rotorPlaceringHoejre.Text = Convert.ToString(rotorII[rotorHoejreStatusInt]);
							break;

						case "Rotor III":
							bogstav = rotorIII[(taellerFindBogstav + rotorHoejreStatusInt)];
							rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
							rotorPlaceringHoejre.Text = Convert.ToString(rotorIII[rotorHoejreStatusInt]);
							break;

						case "Rotor IV":
							bogstav = rotorIV[(taellerFindBogstav + rotorHoejreStatusInt)];
							rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
							rotorPlaceringHoejre.Text = Convert.ToString(rotorIV[rotorHoejreStatusInt]);
							break;

						case "Rotor V":
							bogstav = rotorV[(taellerFindBogstav + rotorHoejreStatusInt)];
							rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
							rotorPlaceringHoejre.Text = Convert.ToString(rotorV[rotorHoejreStatusInt]);
							break;
					}
				}

				void krypterCharRotorMidt()
				{
					switch (rotor2Valgt(rotor2Valg))
					{
						case "Rotor I":
							bogstav = rotorI[(taellerFindBogstav + rotorMidtStatusInt)];
							rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
							rotorPlaceringMidt.Text = Convert.ToString(rotorI[rotorMidtStatusInt]);
							break;

						case "Rotor II":
							bogstav = rotorII[(taellerFindBogstav + rotorMidtStatusInt)];
							rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
							rotorPlaceringMidt.Text = Convert.ToString(rotorII[rotorMidtStatusInt]);
							break;

						case "Rotor III":
							bogstav = rotorIII[(taellerFindBogstav + rotorMidtStatusInt)];
							rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
							rotorPlaceringMidt.Text = Convert.ToString(rotorIII[rotorMidtStatusInt]);
							break;

						case "Rotor IV":
							bogstav = rotorIV[(taellerFindBogstav + rotorMidtStatusInt)];
							rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
							rotorPlaceringMidt.Text = Convert.ToString(rotorIV[rotorMidtStatusInt]);
							break;

						case "Rotor V":
							bogstav = rotorV[(taellerFindBogstav + rotorMidtStatusInt)];
							rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
							rotorPlaceringMidt.Text = Convert.ToString(rotorV[rotorMidtStatusInt]);
							break;
					}
				}

				void krypterCharRotorVenstre()
				{
					switch (rotor3Valgt(rotor3Valg))
					{
						case "Rotor I":
							bogstav = rotorI[(taellerFindBogstav + rotorVenstreStatusInt)];
							rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
							rotorPlaceringVenstre.Text = Convert.ToString(rotorI[rotorVenstreStatusInt]);
							break;

						case "Rotor II":
							bogstav = rotorII[(taellerFindBogstav + rotorVenstreStatusInt)];
							rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
							rotorPlaceringVenstre.Text = Convert.ToString(rotorII[rotorVenstreStatusInt]);
							break;

						case "Rotor III":
							bogstav = rotorIII[(taellerFindBogstav + rotorVenstreStatusInt)];
							rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
							rotorPlaceringVenstre.Text = Convert.ToString(rotorIII[rotorVenstreStatusInt]);
							break;

						case "Rotor IV":
							bogstav = rotorIV[(taellerFindBogstav + rotorVenstreStatusInt)];
							rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
							rotorPlaceringVenstre.Text = Convert.ToString(rotorIV[rotorVenstreStatusInt]);
							break;

						case "Rotor V":
							bogstav = rotorV[(taellerFindBogstav + rotorVenstreStatusInt)];
							rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
							rotorPlaceringVenstre.Text = Convert.ToString(rotorV[rotorVenstreStatusInt]);
							break;
					}
				}
			}

			void opdaterTekst()
			{
				switch (rotor1Valgt(rotor1Valg))
				{
					case "Rotor I":
						rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
						rotorPlaceringHoejre.Text = Convert.ToString(rotorI[rotorHoejreStatusInt]);
						break;

					case "Rotor II":
						rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
						rotorPlaceringHoejre.Text = Convert.ToString(rotorII[rotorHoejreStatusInt]);
						break;

					case "Rotor III":
						rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
						rotorPlaceringHoejre.Text = Convert.ToString(rotorIII[rotorHoejreStatusInt]);
						break;

					case "Rotor IV":
						rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
						rotorPlaceringHoejre.Text = Convert.ToString(rotorIV[rotorHoejreStatusInt]);
						break;

					case "Rotor V":
						rotorHoejreStatus.Text = Convert.ToString(rotorHoejreStatusInt);
						rotorPlaceringHoejre.Text = Convert.ToString(rotorV[rotorHoejreStatusInt]);
						break;
				}

				switch (rotor2Valgt(rotor2Valg))
				{
					case "Rotor I":
						rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
						rotorPlaceringMidt.Text = Convert.ToString(rotorI[rotorMidtStatusInt]);
						break;

					case "Rotor II":
						rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
						rotorPlaceringMidt.Text = Convert.ToString(rotorII[rotorMidtStatusInt]);
						break;

					case "Rotor III":
						rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
						rotorPlaceringMidt.Text = Convert.ToString(rotorIII[rotorMidtStatusInt]);
						break;

					case "Rotor IV":
						rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
						rotorPlaceringMidt.Text = Convert.ToString(rotorIV[rotorMidtStatusInt]);
						break;

					case "Rotor V":
						rotorMidtStatus.Text = Convert.ToString(rotorMidtStatusInt);
						rotorPlaceringMidt.Text = Convert.ToString(rotorV[rotorMidtStatusInt]);
						break;
				}

				switch (rotor3Valgt(rotor3Valg))
				{
					case "Rotor I":
						rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
						rotorPlaceringVenstre.Text = Convert.ToString(rotorI[rotorVenstreStatusInt]);
						break;

					case "Rotor II":
						rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
						rotorPlaceringVenstre.Text = Convert.ToString(rotorII[rotorVenstreStatusInt]);
						break;

					case "Rotor III":
						rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
						rotorPlaceringVenstre.Text = Convert.ToString(rotorIII[rotorVenstreStatusInt]);
						break;

					case "Rotor IV":
						rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
						rotorPlaceringVenstre.Text = Convert.ToString(rotorIV[rotorVenstreStatusInt]);
						break;

					case "Rotor V":
						rotorVenstreStatus.Text = Convert.ToString(rotorVenstreStatusInt);
						rotorPlaceringVenstre.Text = Convert.ToString(rotorV[rotorVenstreStatusInt]);
						break;
				}
			}

			private void rotor_CheckedChanged(object sender, EventArgs e)
			{
				opdaterTekst();
			}
		}
	}
