using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDealer.Common
{
    public interface IPlugin
    {
        string Name { get; }
        bool ProcessURL(string url);

        bool ValidURL { get; }

        List<IDeal> Results { get; }
    }
}
