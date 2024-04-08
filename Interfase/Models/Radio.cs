using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase.Models
{
    public class Radio
    {
        bool IsWorck {  get; set; } = false;

        public void TurnOn(bool state)
        {
            IsWorck = state;
        }
    }
}
