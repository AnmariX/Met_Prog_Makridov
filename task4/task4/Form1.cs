using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Task4;

namespace task4
{
    public partial class frmMuseum : Form
    {
        private FrmHelp HelpForm;
        public bool isclosing = false;

        public frmMuseum()
        {
            InitializeComponent();
            InitializeControls();


            this.KeyDown += new KeyEventHandler(Frm_KeyDown);
            this.KeyPreview = true;
        }

        private void InitializeControls()
        {
            CalendarRigth.MaxSelectionCount = 1; // можно выбрать только одну дату

            Controls.Add(CalendarLeft);
            Controls.Add(CalendarRigth);
            Controls.Add(cmbDate2);
            Controls.Add(cmbListMuseums);

            cmbDate2.SelectedIndexChanged += dateComboBox_SelectedIndexChanged;
            cmbListMuseums.SelectedIndexChanged += cmbListMuseums_SelectedIndexChanged;
        }

        private void LoadDates(string museumName, string fileName)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, fileName);

            List<DateTime> dates = new List<DateTime>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding(1251)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        DateTime date = Convert.ToDateTime(line);
                        dates.Add(date);
                    }
                }

                dates.Sort();
                CalendarLeft.RemoveAllBoldedDates(); // Очищаем все выделенные даты перед добавлением новых
                cmbDate2.Items.Clear(); // Очищаем все даты в ComboBox перед добавлением новых
                foreach (DateTime date in dates)
                {
                    CalendarLeft.AddBoldedDate(date); // Добавляем выделенную дату на правый календарь
                    cmbDate2.Items.Add(date.ToShortDateString());
                }
                CalendarLeft.UpdateBoldedDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
            }
        }

        private void OnDateSelected(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(cmbDate2.SelectedItem);
            CalendarRigth.SelectionStart = selectedDate;
            CalendarRigth.SelectionEnd = selectedDate;
            CalendarRigth.SetDate(selectedDate);
        }

        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.H)
            {
                FrmHelp frh = new FrmHelp();
                frh.Show();
                Hide();
            }
        }

       

        private void cmbListMuseums_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbListMuseums.SelectedIndex)
            {
                case 0:
                    LoadDates("Музей транспорта Москвы", "dates.txt");
                    CalendarRigth.SelectionStart = DateTime.Today;
                    CalendarRigth.SelectionEnd = DateTime.Today;
                    break;
                case 1:
                    CalendarRigth.SelectionStart = DateTime.Today;
                    CalendarRigth.SelectionEnd = DateTime.Today;
                    LoadDates("Центральный музей МВД России", "dates2.txt");
                    break;
                case 2:
                    CalendarRigth.SelectionStart = DateTime.Today;
                    CalendarRigth.SelectionEnd = DateTime.Today;
                    LoadDates("Центральный музей Вооружённых Сил РФ", "dates3.txt");
                    break;
            }
        }

        private void MuseumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isclosing = true;
            
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cmbDate2.SelectedItem.ToString();
            if (DateTime.TryParse(s, out DateTime d))
            {
                CalendarRigth.SelectionStart = d;
                CalendarRigth.SelectionEnd = d;
            }
        }
    }
}
