using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_PretwaGUI
{
    class PawnStatus
    {
        [Flags]
        public enum FieldDrawType
        {
            Default = 0,
            Highlighted = 1,
            Selected = 2
        }
    }
}
