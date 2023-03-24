using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StajDemo1
{
    public partial class Form1 : Form
    {
        class masa
        {
            public int MasaTipi { get; set; }
            public int BahisAraligi { get; set; }
            public bool Hizli { get; set; }
            public bool TekeTek { get; set; }
            public bool Rovans { get; set; }
            
        }
        List<masa> _masaListesi = new List<masa>();
        //Karşılatırma için radioButtonlardan gelen değerleri tutacaklar.
        public bool _hızlı;
        public bool _tekeTek;
        public bool _rovans;
        public Form1()
        {
            InitializeComponent();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SelectedPay.Text = hScrollBar1.Value.ToString() + "$";
            foreach (var masa in _masaListesi) //Her seferinde seçilen değeri güncellemesi için böyle bir işlem yaptım.
            {
                masa.BahisAraligi = hScrollBar1.Value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 200;
            hScrollBar1.Maximum = 5000;
            hScrollBar1.Value = 200;
            hScrollBar1.LargeChange = 600;

            ListeyiDoldur(); //Program çalıştığında Liste elemanları doldurulacak.

            // başlangıç değerlerini hayır olarak seçtim.
            HızlıHayır.Checked = true;
            TekeTekHayır.Checked = true;
            RovansHayır.Checked = true;
        }

        private void ListeyiDoldur()
        {
            //Oluşabilecek bütün ihtimalleri listeye eleman olarak ekledim, bahis aralığını da kullanıcının scroll bar üzerinden seçtiği değer olarak aldım.
            _masaListesi.Add(new masa {
                MasaTipi=1,
                BahisAraligi = hScrollBar1.Value,
                Hizli = true,
                TekeTek = true,
                Rovans = true,

            });
            _masaListesi.Add(new masa
            {
                MasaTipi=2,
                BahisAraligi = hScrollBar1.Value,
                Hizli = true,
                TekeTek = true,
                Rovans = false,

            });
            _masaListesi.Add(new masa
            {
                MasaTipi = 3,
                BahisAraligi = hScrollBar1.Value,
                Hizli = true,
                TekeTek = false,
                Rovans = true,

            }); _masaListesi.Add(new masa
            {
                MasaTipi = 4,
                BahisAraligi = hScrollBar1.Value,
                Hizli = true,
                TekeTek = false,
                Rovans = false,

            }); _masaListesi.Add(new masa
            {
                MasaTipi = 5,
                BahisAraligi = hScrollBar1.Value,
                Hizli = false,
                TekeTek = true,
                Rovans = true,

            }); _masaListesi.Add(new masa
            {
                MasaTipi = 6,
                BahisAraligi = hScrollBar1.Value,
                Hizli = false,
                TekeTek = true,
                Rovans = false,

            }); _masaListesi.Add(new masa
            {
                MasaTipi = 7,
                BahisAraligi = hScrollBar1.Value,
                Hizli = false,
                TekeTek = false,
                Rovans = true,

            }); _masaListesi.Add(new masa
            {
                MasaTipi = 8,
                BahisAraligi = hScrollBar1.Value,
                Hizli = false,
                TekeTek = false,
                Rovans = false,

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gelen değerleri al ve Lİste elemanları ile karşılaştır. Ve Uygun masayı göster.        
            if (HızlıEvet.Checked)
            {
                _hızlı = true;
            }
            else
            {
                _hızlı = false;
            }
            if (TekeTekEvet.Checked)
            {
                _tekeTek = true;
            }
            else
            {
                _tekeTek = false;
            }
            if (RovansEvet.Checked)
            {
                _rovans = true;
            }
            else
            {
                _rovans = false;
            }
            MasaBul();
        }

        private void MasaBul()
        {
            foreach (var masalar in _masaListesi)
            {
                var masaHizli = masalar.GetType().GetProperty("Hizli").GetValue(masalar);
                var masaTekeTek = masalar.GetType().GetProperty("TekeTek").GetValue(masalar);
                var masaRovans = masalar.GetType().GetProperty("Rovans").GetValue(masalar);
                if ((bool)masaHizli == _hızlı && (bool)masaTekeTek == _tekeTek && (bool)masaRovans == _rovans)
                {
                    var masaTipi = masalar.GetType().GetProperty("MasaTipi").GetValue(masalar);
                    MessageBox.Show("Uygun Masa Tipi : "+ masaTipi.ToString());
                }
            }

        }
    }
}
