using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina.Controllers;
using GereCantina.Models;

namespace Cantina
{
    public partial class ReservasForm : Form
    {
        public ReservasForm()
        {
            InitializeComponent();
            
        }

        private void LBox_PratosReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CarregarListBoxs()
        {
            //Carregar a listbox com os menus
            MenuController menuController = new MenuController();
            List<GereCantina.Models.Menu> menus = menuController.ListarMenus();
            
        }
    }
}
