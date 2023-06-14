using CWMM2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWMM2.MVVM.ViewModel
{
    internal class ModsViewModel
    {
        public IEnumerable<ModIndex> AllModsList => ModIndex.Fetch(true).OrderBy(mi => mi.name.ToLower()[0]);
    }
}
