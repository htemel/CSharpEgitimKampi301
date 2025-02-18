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
    public partial class Form1: Form
    {
        EgitimKampiEFTravelDbEntities1 db = new EgitimKampiEFTravelDbEntities1();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            var values = db.TblGuide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblGuide guide = new TblGuide();
            guide.GuideName = txtRehberName.Text;
            guide.GuideSurname = txtRehberSurname.Text;
            db.TblGuide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRehberId.Text);
            var removeValue = db.TblGuide.Find(id);
            db.TblGuide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi.");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRehberId.Text);
            var updateValue = db.TblGuide.Find(id);
            updateValue.GuideName = txtRehberName.Text;
            updateValue.GuideSurname = txtRehberSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtRehberId.Text);
            var values = db.TblGuide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
