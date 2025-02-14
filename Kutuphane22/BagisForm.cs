﻿using Kutuphane22.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane22
{
    public partial class BagisForm : Form
    {
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public BagisForm(KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            foreach (var item in Enum.GetValues(typeof(KitapTur)))
            {
                cmbKitapTur.Items.Add(item);
            }
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Ad = txtKitapAdi.Text.Trim();
            kitap.BasimTarihi = dtpBasimTarihi.Value;
            kitap.KitapTur = (KitapTur)cmbKitapTur.SelectedItem;
            kitap.YazarAd = txtYazarAd.Text.Trim();
            kitap.SayfaSayisi = (int)nudSayfaSayisi.Value;
            kitap.Aciklama = txtAciklama.Text;
            int adet = (int)nudAdet.Value;

            kutuphaneYoneticisi.KitapBagis(kitap, adet);
            Close();
        }
    }
}
