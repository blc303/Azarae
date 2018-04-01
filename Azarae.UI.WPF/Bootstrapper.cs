using Azarae.UI.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Azarae.UI
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container = new SimpleContainer();

            container.Instance(container);

            container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            container
                .PerRequest<ShellViewModel>()
                .PerRequest<MainViewModel>();

        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        #region Ioc Setup
        
        /// <summary>
        /// Requests an instance of a given type
        /// </summary>
        /// <param name="service">The service required</param>
        /// <param name="key">The key</param>
        /// <returns>An instance of the service from the IoC.</returns>
        protected override object GetInstance(Type service, string key)
        {   
            return container.GetInstance(service, key);
        }

        /// <summary>
        /// Requests all instances of a given type
        /// </summary>
        /// <param name="service">The service required</param>
        /// <returns>An <see cref="IEnumerable{T}"/> for all services matching the request.</returns>
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        /// <summary>
        /// Pushes dependencies into an existing instance based on interface properties with setters.
        /// </summary>
        /// <param name="instance">The instance</param>
        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        #endregion Ioc Setup

        #region Unhandled Exception Handling

        /// <summary>
        /// Will be called whenever an unhandled exeption occurs in the application.
        /// </summary>
        /// <param name="sender">The object that raised the error.</param>
        /// <param name="e">The <see cref="DispatcherUnhandledExceptionEventArgs"/> for the event</param>
        protected override void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            
            MessageBox.Show(e.Exception.Message, "A error occured", MessageBoxButton.OK);
        }

        #endregion Unhandled Exception Handling
    }
}
