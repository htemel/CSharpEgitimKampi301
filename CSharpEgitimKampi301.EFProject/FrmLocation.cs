using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation: Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities1 db = new EgitimKampiEFTravelDbEntities1();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.LocationCapacity = byte.Parse(nuDCapacity.Value.ToString());
            location.LocationCity = txtLocationCity.Text;
            location.LocationCountry = txtLocationCountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.LocationDayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Gerçekleşti.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var deleteValue = db.TblLocation.Find(id);
            db.TblLocation.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtLocationId.Text);
            var updateValue = db.TblLocation.Find(id);
            updateValue.LocationDayNight = txtDayNight.Text;
            updateValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updateValue.LocationCapacity = byte.Parse(nuDCapacity.Value.ToString());
            updateValue.LocationCity = txtLocationCity.Text;
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");

        }
    }
}
