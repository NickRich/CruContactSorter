using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactSorter
{
    class Sorter
    {
        #region ---Global Variables---
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

        public Sorter()
        {
            List<Contact>[] areas = {caryE, caryNE, caryNW, carySE, carySW, caryW, earhartM, earhartW, firstStreetCentralM, firstStreetCentralW,
            firstStreetEastM, firstStreetEastW, firstStreetWestM, firstStreetWestW, harrisonM, harrisonW, hawkinsM, hawkinsW, hillenbrandM, hillenbrandW, hilltopM, hilltopW,
            honorsNorthM, honorsNorthW, honorsSouthM, honorsSouthW, mcCutcheonM, mcCutcheonW, meredithNE, meredithNW, meredithSE, meredithSW, owenM, owenW, shreveM, shreveW,
            tark, thirdStreetM, thirdStreetW, wileyM, wileyW, windsorDuhme, windsorShealy, windsorVawter, windsorWalter, windsorWood};
            targetAreaLists = new List<List<Contact>>(areas);
        }

        public void Run()
        {
            parseExistingContacts();
        }

        private void parseExistingContacts()
        {
            //int numTargetAreas = 44;
            //for (int i = 0; i < numTargetAreas; i++)
            //{
            //    string[] contacts;
            //    List<Contact> currentList;
            //    switch (i)
            //    {
            //        case 0:
            //            contacts = Properties.Resources.Cary_East.Split('\n');
            //            currentList = caryE;
            //            break;
            //        case 1:
            //            contacts = Properties.Resources.Cary_NorthEast.Split('\n');
            //            currentList = caryNE;
            //            break;
            //        case 2:
            //            contacts = Properties.Resources.Cary_NorthWest.Split('\n');
            //            currentList = caryNW;
            //            break;
            //        case 3:
            //            contacts = Properties.Resources.Cary_SouthEast.Split('\n');
            //            currentList = carySE;
            //            break;
            //        case 4:
            //            contacts = Properties.Resources.Cary_SouthWest.Split('\n');
            //            currentList = carySW;
            //            break;
            //        case 5:
            //    }
            //}
        }
    }
}
