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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db=new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.TblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                fullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            });
           cmbGuide.DisplayMember = "fullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation location= new TblLocation();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity=txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocataionPrice = decimal.Parse(txtPrice.Text);
            location.LocationDayNight = txtDayNight.Text;
            location.FKGuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var deleteValue = db.TblLocation.Find(id);
            db.TblLocation.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.TblLocation.Find(id);
            updateValue.LocationDayNight = txtDayNight.Text;
            updateValue.LocataionPrice = decimal.Parse(txtPrice.Text);
            updateValue.LocationCountry = txtCountry.Text;
            updateValue.LocationCity = txtCity.Text;
            updateValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.FKGuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }
}
