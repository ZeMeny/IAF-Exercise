using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public interface IBda
    {
        CameraTypes CameraType { get; set; }
        string PreformBda();
    }
}