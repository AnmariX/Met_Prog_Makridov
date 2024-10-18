using System.Drawing;
using System.Windows.Forms;


namespace task4
{
    partial class frmMuseum:Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalendarLeft = new System.Windows.Forms.MonthCalendar();
            this.CalendarRigth = new System.Windows.Forms.MonthCalendar();
            this.cmbDate2 = new System.Windows.Forms.ComboBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.cmbListMuseums = new System.Windows.Forms.ComboBox();
            this.lblTextInfo1 = new System.Windows.Forms.Label();
            this.lblTextInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalendarLeft
            // 
            this.CalendarLeft.BackColor = System.Drawing.Color.LightGray;
            this.CalendarLeft.Location = new System.Drawing.Point(30, 33);
            this.CalendarLeft.Name = "CalendarLeft";
            this.CalendarLeft.TabIndex = 0;
            // 
            // CalendarRigth
            // 
            this.CalendarRigth.Location = new System.Drawing.Point(870, 33);
            this.CalendarRigth.Name = "CalendarRigth";
            this.CalendarRigth.TabIndex = 1;
            // 
            // cmbDate2
            // 
            this.cmbDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate2.FormattingEnabled = true;
            this.cmbDate2.Location = new System.Drawing.Point(621, 67);
            this.cmbDate2.Name = "cmbDate2";
            this.cmbDate2.Size = new System.Drawing.Size(139, 24);
            this.cmbDate2.TabIndex = 2;
            this.cmbDate2.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(422, 340);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(0, 16);
            this.helpLabel.TabIndex = 3;
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbListMuseums
            // 
            this.cmbListMuseums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListMuseums.FormattingEnabled = true;
            this.cmbListMuseums.Items.AddRange(new object[] {
            "Музей транспорта Москвы",
            "Центральный музей МВД России",
            "Центральный музей Вооружённых Сил РФ"});
            this.cmbListMuseums.Location = new System.Drawing.Point(276, 67);
            this.cmbListMuseums.Name = "cmbListMuseums";
            this.cmbListMuseums.Size = new System.Drawing.Size(225, 24);
            this.cmbListMuseums.TabIndex = 4;
            this.cmbListMuseums.SelectedIndexChanged += new System.EventHandler(this.cmbListMuseums_SelectedIndexChanged);
            // 
            // lblTextInfo1
            // 
            this.lblTextInfo1.AutoSize = true;
            this.lblTextInfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTextInfo1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInfo1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTextInfo1.Location = new System.Drawing.Point(588, 33);
            this.lblTextInfo1.Name = "lblTextInfo1";
            this.lblTextInfo1.Size = new System.Drawing.Size(196, 19);
            this.lblTextInfo1.TabIndex = 5;
            this.lblTextInfo1.Text = "Выберите дату из файла";
            // 
            // lblTextInfo2
            // 
            this.lblTextInfo2.AutoSize = true;
            this.lblTextInfo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTextInfo2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInfo2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTextInfo2.Location = new System.Drawing.Point(319, 33);
            this.lblTextInfo2.Name = "lblTextInfo2";
            this.lblTextInfo2.Size = new System.Drawing.Size(135, 19);
            this.lblTextInfo2.TabIndex = 6;
            this.lblTextInfo2.Text = "Выберите музей";
            // 
            // frmMuseum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 303);
            this.Controls.Add(this.lblTextInfo2);
            this.Controls.Add(this.lblTextInfo1);
            this.Controls.Add(this.cmbListMuseums);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.cmbDate2);
            this.Controls.Add(this.CalendarRigth);
            this.Controls.Add(this.CalendarLeft);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmMuseum";
            this.RightToLeftLayout = true;
            this.Text = "Задание №4. Выполнили: КИ-341 Токарев В. А. и Макридов А.М. Номер варианта: 18. Д" +
    "ата выполненеия 28/06/24";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MuseumForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarLeft;
        private System.Windows.Forms.MonthCalendar CalendarRigth;
        private System.Windows.Forms.ComboBox cmbDate2;
        private System.Windows.Forms.Label helpLabel;
        private ComboBox cmbListMuseums;
        private Label lblTextInfo1;
        private Label lblTextInfo2;

       
    }
}

