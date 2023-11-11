using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlan
{
    public class PlotInfo
    {
        public int parcelNumber;
        public int plotType;
        public int zipCode;
        public string publicSpace;
        public string city;
        public ulong size;
        public ulong value;

        public PlotInfo(int parcelNumber, int plotType, int zipCode, string publicSpace, string city, ulong size, ulong value)
        {
            this.parcelNumber = parcelNumber;
            this.plotType = plotType;
            this.zipCode = zipCode;
            this.publicSpace = publicSpace;
            this.city = city;
            this.size = size;
            this.value = value;
        }
    }
}
