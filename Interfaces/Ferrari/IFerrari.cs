using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface IFerrari
    {
        string Driver { get; }
        string Model { get; }

        string Brakes();
        string Gas();
    }
}
