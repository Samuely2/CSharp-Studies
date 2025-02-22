using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06_Delegate;

public static class ListExtension
{
    public static int RetornarInteiros(this List<int> list)
    {
        return list.Where(x => x % 2 != 0).Sum();
    }
}
