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

        public string oldalA => OldalALable.Text;

        public string errorOldalA { 
            get => errorPOldalA.GetError(OldalATextBox);
            set => errorPOldalA.SetError(OldalATextBox, value); }

        private void SokszogForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
    }
}
