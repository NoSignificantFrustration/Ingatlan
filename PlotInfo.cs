using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlan
{
    public class PlotInfo
    {
        public int id;
        public int parcelNumber;
        public int plotType;
        public int zipCode;
        public string city;
        public ulong size;
        public ulong value;

        public PlotInfo(int id, int parcelNumber, int plotType, int zipCode,  string city, ulong size, ulong value)
        {
            this.id = id;
            this.parcelNumber = parcelNumber;
            this.plotType = plotType;
            this.zipCode = zipCode;
            this.city = city;
            this.size = size;
            this.value = value;
        }


        public PlotInfo(PlotInfo other)
        {
            this.id = other.id;
            this.parcelNumber = other.parcelNumber;
            this.plotType = other.plotType;
            this.zipCode = other.zipCode;
            this.city = other.city;
            this.size = other.size;
            this.value = other.value;
        }

    }
}
