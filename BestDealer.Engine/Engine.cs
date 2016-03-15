using BestDealer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDealer.Engine
{
    class Engine
    {
        private static Lazy<Engine> Lazy = new Lazy<Engine>(() => new Engine());

        private Engine()
        {

        }

        public static Engine Instance
        {
            get
            {
                return Lazy.Value;
            }
        }

        public List<IDeal> ProcessDealsUrl(string url)
        {
            foreach (var plugin in PluginManager.Instance.Plugins)
            {
                if (plugin.ProcessURL(url) && plugin.ValidURL)
                {
                    return plugin.Results;
                }
            }

            return new List<IDeal>();
        }
    }
}
