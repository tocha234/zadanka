using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis
{
    public partial class AddCar : Form
    {
        public AddCar(string marka, string model, /* pozostałe dane */)
        {
            InitializeComponent();

            // Przypisz dane do kontrolek w formularzu
            textBoxMarka.Text = marka;
            textBoxModel.Text = model;
            // Przypisz pozostałe dane do odpowiednich kontrolek
        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSelectImages_Click(object sender, EventArgs e)
        {
            private void buttonWybierzZdjecia_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] sciezkiDoZdjec = openFileDialog.FileNames;

                    // Przypisz wybrane zdjęcia do PictureBox-ów
                    for (int i = 0; i < sciezkiDoZdjec.Length && i < 6; i++)
                    {
                        // Utwórz obiekt Image na podstawie ścieżki do pliku
                        Image obraz = new Bitmap(sciezkiDoZdjec[i]);

                        // Przypisz obraz do odpowiedniego PictureBox-a
                        if (i == 0) pictureBox1.Image = obraz;
                        else if (i == 1) pictureBox2.Image = obraz;
                        else if (i == 2) pictureBox3.Image = obraz;
                        else if (i == 3) pictureBox4.Image = obraz;
                        else if (i == 4) pictureBox5.Image = obraz;
                        else if (i == 5) pictureBox6.Image = obraz;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nowaMarka = textBoxMarka.Text;
            string nowyModel = textBoxModel.Text;
            // Pobierz pozostałe nowe dane

            if (nowaMarka != oryginalnaMarka || nowyModel != oryginalnyModel || /* porównaj pozostałe pola */)
            {
                // Wykryto zmiany w danych, więc wykonaj aktualizację
                UpdateCarInDatabase(nowaMarka, nowyModel, /* pozostałe nowe dane */);

                MessageBox.Show("Zaktualizowano dane samochodu.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Brak zmian w danych samochodu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
