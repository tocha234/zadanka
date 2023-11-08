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
    public partial class CarListing : Form
    {
        public CarListing()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void BtnEditCar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczony samochód
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pobierz dane samochodu z wybranej linii
                string marka = selectedRow.Cells["Marka"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                // ... pozostałe dane ...

                // Przekaz dane do formularza edycji
                AddCar formEdycji = new AddCar(marka, model, /* ... pozostałe dane ... */);
                formEdycji.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego samochodu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
