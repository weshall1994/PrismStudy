using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using prismDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace prismDemo.FirstModule
{
    public class FirstModuleClass : IModule
    {
        private RegionManager _regionManager;
        private IUnityContainer _container;

        public FirstModuleClass(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

            _regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion,typeof(ToolbarView));
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ContentView));

        }
    }
}
