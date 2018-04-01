using Caliburn.Micro;
using System.Windows.Controls;

namespace Azarae.UI.ViewModels
{
    public class ShellViewModel : Conductor<MainViewModel>
    {

        #region Private Fields

        private readonly SimpleContainer container;

        #endregion

        public ShellViewModel(SimpleContainer container)
        {
            this.container = container;
            this.ActiveItem = new MainViewModel();
        }

    }
}
