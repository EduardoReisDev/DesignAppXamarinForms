using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignAppXamarinForms.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio1 : MasterDetailPage
    {
        public Inicio1()
        {
            InitializeComponent();
        }

        private void GoPaginaPerfil1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
        }

        private void GoPaginaXamarin(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}