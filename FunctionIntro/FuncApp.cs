using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionIntro;
internal class FuncApp
{
    public void Run()
    {
        string input = Console.ReadLine();
        int number = SafelyConvertToInt(input);
        int a = int.Parse(input);
        int b = Convert.ToInt32(input);
    }

    public int SafelyConvertToInt(string x)
    {
        if (int.TryParse(x, out int resoult))
        {
            return resoult;
        }
        else
        {
            return 0;
        }
    }
}

