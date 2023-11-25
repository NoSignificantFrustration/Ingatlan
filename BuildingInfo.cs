using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlan
{
    class BuildingInfo
    {
        public int id;
        public int plotId;
        public int buildingType;
        public int yearBuilt;
        public string publicSpace;
        public string houseNumber;
        public ulong value;

        public BuildingInfo(int id, int plotId, int buildingType, int yearBuilt, string publicSpace, string houseNumber, ulong value)
        {
            this.id = id;
            this.plotId = plotId;
            this.buildingType = buildingType;
            this.yearBuilt = yearBuilt;
            this.publicSpace = publicSpace;
            this.houseNumber = houseNumber;
            this.value = value;
        }
    }
}
