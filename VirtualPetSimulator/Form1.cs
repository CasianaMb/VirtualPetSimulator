using System;
using System.Windows.Forms;
using VirtualPetSimulator.Models;
using VirtualPetSimulator.Behaviors;
using VirtualPetSimulator.Observers;

namespace VirtualPetSimulator
{
    public partial class Form1 : Form
    {
        private Pet myPet;

        public Form1()
        {
            InitializeComponent();

            // Inițializare animal de companie
            myPet = null; // Nu avem un animal selectat la început

            // Ascunde imaginea la pornire
            pictureBox1.Image = null;


            // Adăugăm opțiunile pentru ComboBox
            comboBoxPlayMode.Items.Add("Gentle");
            comboBoxPlayMode.Items.Add("Intense");
            comboBoxPlayMode.SelectedIndex = 0; // Setează valoarea implicită la "Gentle"

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();


            // Adaugă observer
           // myPet.AddObserver(new ConsolePetObserver());

            // Afișează starea inițială
            UpdatePetStatus();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myPet == null)
                return;

            myPet.ChangeHappiness(-1); // Scade fericirea cu 1
            UpdatePetStatus(); // Actualizează interfața
        }



        private void UpdatePetStatus()
        {
            if (myPet == null)
            {
                // Ascunde sau resetează controalele relevante
                lblHunger.Text = "Hunger: -";
                lblEnergy.Text = "Energy: -";
                lblHappiness.Text = "Happiness: -";

                progressBarHunger.Value = 0;
                progressBarEnergy.Value = 0;
                progressBarHappiness.Value = 0;

                pictureBox1.Image = null;
                return;
            }

            // Actualizează etichetele cu starea animalului
            lblHunger.Text = $"Hunger: {myPet.Hunger}";
            lblEnergy.Text = $"Energy: {myPet.Energy}";
            lblHappiness.Text = $"Happiness: {myPet.Happiness}";

            // Actualizează ProgressBar-urile
            progressBarHunger.Value = myPet.Hunger;
            progressBarEnergy.Value = myPet.Energy;
            progressBarHappiness.Value = myPet.Happiness;

            // Schimbă imaginea în funcție de starea animalului
            if (myPet is Dog)
            {
                if (myPet.Happiness < 25)
                    pictureBox1.Image = Properties.Resources.sadDogImage;
                else if (myPet.Happiness < 50 && myPet.Happiness >= 25)
                    pictureBox1.Image = Properties.Resources.worriedDogImage;
                else if (myPet.Happiness < 75 && myPet.Happiness >= 50)
                    pictureBox1.Image = Properties.Resources.dogImage;
                else
                    pictureBox1.Image = Properties.Resources.happyDogImage;
            }
            else if (myPet is Cat)
            {
                if (myPet.Happiness < 25)
                    pictureBox1.Image = Properties.Resources.sadCatImage;
                else if (myPet.Happiness < 50 && myPet.Happiness >= 25)
                    pictureBox1.Image = Properties.Resources.worriedCatImage;
                else if (myPet.Happiness < 75 && myPet.Happiness >= 50)
                    pictureBox1.Image = Properties.Resources.catImage;
                else
                    pictureBox1.Image = Properties.Resources.happyCatImage;
            }
        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            myPet.PerformPlay();
            UpdatePetStatus();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            myPet.Feed();
            UpdatePetStatus();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            myPet.Sleep();
            UpdatePetStatus();
        }

        // Funcție pentru schimbarea animalului în funcție de selecția radio button
        private void rbtnDog_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDog.Checked)
            {
                myPet = new Dog("Rex");
                myPet.PlayBehavior = new PlayGentle();
                myPet.AddObserver(new ConsolePetObserver()); // AICI trebuie adăugat
                pictureBox1.Image = Properties.Resources.dogImage;
                UpdatePetStatus();
            }
        }

        private void rbtnCat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCat.Checked)
            {
                myPet = new Cat("Whiskers");
                myPet.PlayBehavior = new PlayGentle();
                myPet.AddObserver(new ConsolePetObserver()); // AICI trebuie adăugat
                pictureBox1.Image = Properties.Resources.catImage;
                UpdatePetStatus();
            }
        }





        private void comboBoxPlayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myPet == null)
                return;

            if (comboBoxPlayMode.SelectedItem.ToString() == "Gentle")
            {
                myPet.PlayBehavior = new PlayGentle();
            }
            else if (comboBoxPlayMode.SelectedItem.ToString() == "Intense")
            {
                myPet.PlayBehavior = new PlayIntense();
            }

            UpdatePetStatus();
        }


    }
}
