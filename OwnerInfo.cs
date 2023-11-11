using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlan
{
    class OwnerInfo
    {
        public int PropertyID;
        public long ownerID;
        public DateTime ownerSince;
        public int ownerPercentage;

        public OwnerInfo(int propertyID, long ownerID, DateTime ownerSince, int ownerPercentage)
        {
            PropertyID = propertyID;
            this.ownerID = ownerID;
            this.ownerSince = ownerSince;
            this.ownerPercentage = ownerPercentage;
        }
    }
}
