using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover.Input
{
    public interface IInputProcessor
    {
        string ReadInput();
        void WriteOutput(string output);
    }
}
