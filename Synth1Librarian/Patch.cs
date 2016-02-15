using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Synth1Librarian
{
    public class Patch
    {
        String Name
        {
            get; set;
        }
        String Color
        {
            get; set;
        }
        int Version
        {
            get; set;
        }

        List<Param> Params
        {
            get; set;
        }
    }
}
