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
        EgitimKampiEFTravelDbEntities db=new EgitimKampiEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.TblLocation.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId

            }).ToList();
            cmbRehber.DisplayMember = "FullName" ;
            cmbRehber.ValueMember = "GuideId";
            cmbRehber.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.LocationCapacity=byte.Parse(nudKapasite.Value.ToString());
            location.LocationCity=txtSehir.Text;    
            location.LocationCountry = txtUlke.Text;
            location.LocationPrice = decimal.Parse(txtFiyat.Text);
            location.DayNight = txtGunGece.Text;
            location.GuideId = int.Parse(cmbRehber.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var deleteValue=db.TblLocation.Find(id);
            db.TblLocation.Remove(deleteValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.TblLocation.Find(id);
            updateValue.DayNight=txtGunGece.Text;
            updateValue.LocationPrice=decimal.Parse(txtFiyat.Text);
            updateValue.LocationCapacity=byte.Parse(nudKapasite.Value.ToString());
            updateValue.LocationCity=txtSehir.Text;
            updateValue.LocationCountry=txtUlke.Text;
            updateValue.GuideId=int.Parse(cmbRehber.SelectedValue.ToString()) ;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı.");
        }
    }

   
}
