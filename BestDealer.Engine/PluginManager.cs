using BestDealer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDealer.Engine
{
    public class PluginManager
    {
        private static Lazy<PluginManager> lazy = new Lazy<PluginManager>(() => new PluginManager());
        private List<IPlugin> _plugins;
        private PluginManager()
        {
            this.LoadPlugins();
        }

        private void LoadPlugins()
        {
            this._plugins = new List<IPlugin>();

            
        }

        public static PluginManager Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
