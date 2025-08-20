using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitim301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Toplam lokasyon sayısını görüntüleme
            lblLocationCount.Text= db.Location.Count().ToString();

            //Tüm lokasyonların toplam kapasitesini hesaplama
            lblSumCapacity.Text = db.Location.Sum(x=> x.Capacity).ToString();

            //Rehber (Guide) sayısını listeleme
            lblGuideCount.Text = db.Guide.Count().ToString();

            //Ortalama kapasite
            lblAvgCapacity.Text =db.Location.Average(x=> x.Capacity)?.ToString("0.00");


            //Ortalama tur fiyatını hesaplama
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price)?.ToString("0.00") + "₺";

            //Son eklenen ülke adını bulma
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            //Belirli bir tur (örn. Kapadokya) için kapasite bilgisini alma
            lblCapadociaTourCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            
            //Türkiye’deki turların ortalama kapasitesini gösterme
            lblTurkiyeCapacityAvg.Text =db.Location.Where(x=>x.Country =="Türkiye").Average(y => y.Capacity)?.ToString("0.00");


            
            //Roma turunu yöneten rehberin adını bulma
            var guideId = db.Location.Where(x => x.City == "Romaa").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == guideId).Select(y => y.GuideName +" "+y.GuideSurname).FirstOrDefault().ToString();
            
            //En yüksek kapasiteye sahip turu bulma
            var maxCapacity =db.Location.Max(y => y.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.Capacity == maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            
            //En pahalı turu bulma
            var maxPrice =db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
            
            //Belirli bir rehberin (örn. Tuba Gök) yönettiği tur sayısını hesaplama
            var guideIdByNameTbGk = db.Guide.Where(x => x.GuideName == "Tuba" && x.GuideSurname == "Gök").Select(y => y.GuideId).FirstOrDefault();
            lblTbGkTourCount.Text =db.Location.Where(x=>x.GuideId == guideIdByNameTbGk).Count().ToString();


        }
    }
}
