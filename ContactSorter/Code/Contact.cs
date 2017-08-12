using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactSorter
{
    class Contact
    {
        #region ---Global Variables---
        private string name;
        private string grade;
        private string building;
        private string room;
        private string gender;
        private string religion;
        private string relationInterest;
        private string cruInfo;
        private string convoInterest;
        private string race;
        private bool talkedWith;
        #endregion

        public Contact(string name, string gender, string race, string grade, string building, string room, string religion,
            string relationInterest, string cruInfo, string convoInterest)
        {
            this.name = name;
            this.grade = grade;
            this.building = building;
            this.room = room;
            this.gender = gender;
            this.race = race;
            this.religion = religion;
            this.relationInterest = relationInterest;
            this.cruInfo = cruInfo;
            this.convoInterest = convoInterest;
            this.talkedWith = false;
        }

        #region ---Encapsulation---
        public string Name { get => name; set => name = value; }
        public string Building { get => building; set => building = value; }
        public string Room { get => room; set => room = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Religion { get => religion; set => religion = value; }
        public string RelationInterest { get => relationInterest; set => relationInterest = value; }
        public string CruInfo { get => cruInfo; set => cruInfo = value; }
        public string ConvoInterest { get => convoInterest; set => convoInterest = value; }
        public string Race { get => race; set => race = value; }
        public bool TalkedWith { get => talkedWith; set => talkedWith = value; }
        public string Grade { get => grade; set => grade = value; }
        #endregion

        /// <summary>
        /// Compares 2 Contacts based on Name, Building, and Room since if these 3 match they are probably the same person
        /// </summary>
        /// <param name="cntc">Contact to compare to</param>
        /// <returns></returns>
        public bool equals(Contact cntc)
        {
            if (this.name == cntc.Name && this.building == cntc.Building && this.room == cntc.Room)
                return true;
            return false;
        }
    }
}
