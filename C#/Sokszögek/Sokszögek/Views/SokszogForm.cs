using Sokszögek.Presenters;
using Sokszögek.ViewsInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokszögek.Views
{
    public partial class SokszogForm : Form, ISokszogView
    {
        SokszogPresenter presenter;
        public SokszogForm()
        {
            InitializeComponent();
            presenter = new SokszogPresenter(this);
        }

        public string Kerulet { set => KeruletTextBox.Text = value; }
        public string Terulet { set => TeruletTextBox.Text = value; }
        public List<string> SokszogList { set => comboBox1.DataSource = value; }

        public string oldalA => OldalATextBox.Text;

        public string errorOldalA { 
            get => errorPOldalA.GetError(OldalATextBox);
            set => errorPOldalA.SetError(OldalATextBox, value); }

        public string oldalB => oldalBTextBox.Text;

        public string errorOldalB { 
            get => errorPOldalB.GetError(oldalBTextBox);
            set => errorPOldalB.SetError(oldalBTextBox, value); }

        private void SokszogForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
            OldalALable.Hide();
            oldalBTextBox.Hide();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            presenter.GetSokszogType(comboBox1.SelectedIndex);
            if (presenter.oldalBLetezik)
            {
                OladlBLable.Show();
                oldalBTextBox.Show();
            }
            else
            {
                OladlBLable.Hide();
                oldalBTextBox.Hide();
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            presenter.Calculate();
        }
    }
}
