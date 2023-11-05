using System;

namespace Ingatlan
{
    public class UserInfo
    {
        public Int64 adojel;
        public string passHash;
        public string name;
        public string address;
        public Int64 mobileNumber;
        public DateTime dateOfBirth;
        public string mothersName;
        public int priviligeLevel;

        public UserInfo(long adojel, string passHash, string name, string address, long cellNumber, DateTime dateOfBirth, string mothersName, int priviligeLevel)
        {
            this.adojel = adojel;
            this.passHash = passHash;
            this.name = name;
            this.address = address;
            this.mobileNumber = cellNumber;
            this.dateOfBirth = dateOfBirth;
            this.mothersName = mothersName;
            this.priviligeLevel = priviligeLevel;
        }
    }
}
