using database_test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application.Ahmed_yosury
{
    public partial class AddPatient : Form
    {
        ClinicDB clinicDB = new ClinicDB();
        Patient patient = new Patient();
        Appointment appoint = new Appointment();
        
        public void Getdata()
        {
            appoint.AppointmenDate = DateTime.Now;
            clinicDB.SaveChanges();
            var pathiontdata = clinicDB.Patients.Select(e => new
            { id = e.PatientId,
                name = e.PatientName,
                phone = e.PatientPhone,
                address = e.PatientAddress,
                age = e.PatientAge,
                MaritalStatus = e.PatientMaritalStatus,
                Gender=e.PatientGender,
                Appointment=e.appointments

            
            }).ToList();
            dataGridView1.DataSource = pathiontdata;

        }
        public void Clear()
        {
            NameValue.Text = "";
            PhoneValue.Text = "";
            AddressValue.Text = "";
            GenderValue.Text = "";
            MaritalStatusValue.Text = "";
            AgeValue.Text = "";
            AddAppointmentValue.Text = "";
        }
        public void Getappointment()
        {
            var app = clinicDB.Appointments.Select(a => a.AppointmenDate).ToList();

            foreach (var item in app)
            {
                AddAppointmentValue.Items.Add(app);
            }
        }

        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            Getappointment();
            Getdata();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            patient.PatientName = NameValue.Text;
            patient.PatientAge = int.Parse(AgeValue.Text);
            patient.PatientMaritalStatus = MaritalStatusValue.Text;
            patient.PatientPhone = PhoneValue.Text;
            patient.PatientAddress = AddressValue.Text;
            patient.done = false;
               
           // patient.appointments = (DateTime)AddAppointmentValue.SelectedItem;
            patient.PatientGender=GenderValue.Text;
            clinicDB.Patients.Add(patient);
            clinicDB.SaveChanges();
            Getdata();
            Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            patient.PatientName = NameValue.Text;
            patient.PatientAge = (int)AgeValue.Value;
            patient.PatientMaritalStatus = MaritalStatusValue.Text;
            patient.PatientPhone = PhoneValue.Text;
            patient.PatientAddress = AddressValue.Text;
            patient.done = false;
            //patient.appointments = (DateTime)AddAppointmentValue.SelectedItem;
            patient.PatientGender = GenderValue.Text;
            clinicDB.Entry(patient).State = EntityState.Modified;
            clinicDB.SaveChanges();
            Getdata();
            Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data = clinicDB.Entry(patient);
            if (data.State == EntityState.Detached)
            {
                clinicDB.Patients.Attach(patient);
            }
            clinicDB.Patients.Remove(patient);
            clinicDB.SaveChanges();
            Getdata();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Show();
            this.Hide();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                patient.PatientId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                patient = clinicDB.Patients.Where(a => a.PatientId == patient.PatientId).FirstOrDefault();
                NameValue.Text = patient.PatientName;
                PhoneValue.Text = patient.PatientPhone;
                AddressValue.Text = patient.PatientAddress;
                MaritalStatusValue.Text = patient.PatientMaritalStatus;
                AgeValue.Value = patient.PatientAge;
                AddAppointmentValue.Text = patient.appointments.ToString();
                GenderValue.Text = patient.PatientGender;
            }
        }
    }
}
