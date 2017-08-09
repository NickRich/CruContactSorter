using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;
using System.Resources;
using ContactSorter.Properties;

namespace ContactSorter
{
    class Sorter
    {
        #region ---Global Variables---
        private int numTargetAreas;

        #region ---Lists---
        private List<string> targetAreaFiles;
        private List<List<Contact>> targetAreaLists;
        private List<Contact> caryE = new List<Contact>();
        private List<Contact> caryNE = new List<Contact>();
        private List<Contact> caryNW = new List<Contact>();
        private List<Contact> carySE = new List<Contact>();
        private List<Contact> carySW = new List<Contact>();
        private List<Contact> caryW = new List<Contact>();
        private List<Contact> earhartM = new List<Contact>();
        private List<Contact> earhartW = new List<Contact>();
        private List<Contact> firstStreetCentralM = new List<Contact>();
        private List<Contact> firstStreetCentralW = new List<Contact>();
        private List<Contact> firstStreetEastM = new List<Contact>();
        private List<Contact> firstStreetEastW = new List<Contact>();
        private List<Contact> firstStreetWestM = new List<Contact>();
        private List<Contact> firstStreetWestW = new List<Contact>();
        private List<Contact> harrisonM = new List<Contact>();
        private List<Contact> harrisonW = new List<Contact>();
        private List<Contact> hawkinsM = new List<Contact>();
        private List<Contact> hawkinsW = new List<Contact>();
        private List<Contact> hillenbrandM = new List<Contact>();
        private List<Contact> hillenbrandW = new List<Contact>();
        private List<Contact> hilltopM = new List<Contact>();
        private List<Contact> hilltopW = new List<Contact>();
        private List<Contact> honorsNorthM = new List<Contact>();
        private List<Contact> honorsNorthW = new List<Contact>();
        private List<Contact> honorsSouthM = new List<Contact>();
        private List<Contact> honorsSouthW = new List<Contact>();
        private List<Contact> mcCutcheonM = new List<Contact>();
        private List<Contact> mcCutcheonW = new List<Contact>();
        private List<Contact> meredithNE = new List<Contact>();
        private List<Contact> meredithNW = new List<Contact>();
        private List<Contact> meredithSE = new List<Contact>();
        private List<Contact> meredithSW = new List<Contact>();
        private List<Contact> owenM = new List<Contact>();
        private List<Contact> owenW = new List<Contact>();
        private List<Contact> shreveM = new List<Contact>();
        private List<Contact> shreveW = new List<Contact>();
        private List<Contact> tark = new List<Contact>();
        private List<Contact> thirdStreetM = new List<Contact>();
        private List<Contact> thirdStreetW = new List<Contact>();
        private List<Contact> wileyM = new List<Contact>();
        private List<Contact> wileyW = new List<Contact>();
        private List<Contact> windsorDuhme = new List<Contact>();
        private List<Contact> windsorShealy = new List<Contact>();
        private List<Contact> windsorVawter = new List<Contact>();
        private List<Contact> windsorWalter = new List<Contact>();
        private List<Contact> windsorWood = new List<Contact>();
        #endregion

        #endregion

        public Sorter()
        {
            List<Contact>[] areas = {caryE, caryNE, caryNW, carySE, carySW, caryW, earhartM, earhartW, firstStreetCentralM, firstStreetCentralW,
                firstStreetEastM, firstStreetEastW, firstStreetWestM, firstStreetWestW, harrisonM, harrisonW, hawkinsM, hawkinsW, hillenbrandM, hillenbrandW, hilltopM, hilltopW,
                honorsNorthM, honorsNorthW, honorsSouthM, honorsSouthW, mcCutcheonM, mcCutcheonW, meredithNE, meredithNW, meredithSE, meredithSW, owenM, owenW, shreveM, shreveW,
                tark, thirdStreetM, thirdStreetW, wileyM, wileyW, windsorDuhme, windsorShealy, windsorVawter, windsorWalter, windsorWood};
            targetAreaLists = new List<List<Contact>>(areas);
            numTargetAreas = targetAreaLists.Count;

            string[] files = { Resources.Cary_East, Resources.Cary_NorthEast, Resources.Cary_NorthWest, Resources.Cary_SouthEast, Resources.Cary_SouthWest,
                Resources.Cary_West, Resources.Earhart_Men, Resources.Earhart_Women, Resources.FirstStreetCentral_Men, Resources.FirstStreetCentral_Women,
                Resources.FirstStreetEast_Men, Resources.FirstStreetEast_Women, Resources.FirstStreetWest_Men, Resources.FirstStreetWest_Women, Resources.Harrison_Men,
                Resources.Harrison_Women, Resources.Hawkins_Men, Resources.Hawkins_Women, Resources.Hillenbrand_Men, Resources.Hillenbrand_Women, Resources.Hilltop_Men,
                Resources.Hilltop_Women, Resources.HonorsNorth_Men, Resources.HonorsNorth_Women, Resources.HonorsSouth_Men, Resources.HonorsSouth_Women, Resources.McCutcheon_Men,
                Resources.McCutcheon_Women, Resources.Meredith_NorthEast, Resources.Meredith_NorthWest, Resources.Meredith_SouthEast, Resources.Meredith_SouthWest, Resources.Owen_Men,
                Resources.Owen_Women, Resources.Shreve_Men, Resources.Shreve_Women, Resources.Tarkington, Resources.ThirdStreet_Men, Resources.ThirdStreet_Women, Resources.Wiley_Men,
                Resources.Wiley_Women, Resources.Windsor_Duhme, Resources.Windsor_Shealy, Resources.Windsor_Vawter, Resources.Windsor_Walter, Resources.Windsor_Wood};
            targetAreaFiles = new List<string>(files);

            if (numTargetAreas != targetAreaFiles.Count)
            {
                Console.WriteLine("Number of Lists and Number of Files do not match");
            }
        }

        public void Run()
        {
            parseExistingContacts();
        }

        private void parseExistingContacts()
        {
            for (int i = 0; i < numTargetAreas; i++)
            {
                string[] targetAreaContacts = targetAreaFiles[i].Split('\n');
                foreach (string cntc in targetAreaContacts)
                {
                    if (cntc != "") { 
                        string[] cntcInfo = cntc.Split('\t');
                        Contact newContact = new Contact(cntcInfo[0], cntcInfo[1], cntcInfo[2], cntcInfo[3], cntcInfo[4], cntcInfo[5], cntcInfo[6], cntcInfo[7], cntcInfo[8]);
                        if (!targetAreaLists[i].Contains(newContact))
                        {
                            targetAreaLists[i].Add(newContact);
                        }
                    }
                }
            }
        }
    }
}
