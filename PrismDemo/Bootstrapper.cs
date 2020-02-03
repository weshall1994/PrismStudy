using Microsoft.Office.Interop.Excel;
using Prism.Modularity;
using Prism.Unity;
using prismDemo.FirstModule;
using System;
using System.Windows;
using Window = System.Windows.Window;

namespace prismDemo
{
    [Obsolete]
    public class Bootstrapper : UnityBootstrapper
    {
        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(FirstModuleClass));
            return catalog;
        }

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
            

        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }
    }
}
