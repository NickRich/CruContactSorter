using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;
using System.Resources;
using ContactSorter.Properties;
using System.Reflection;

using Excel = Microsoft.Office.Interop.Excel;


namespace ContactSorter
{
    class Sorter
    {
        #region ---Global Variables---
        private int numTargetAreas;

        #region ---Lists---
        private List<string> targetAreaFiles;
        private List<List<Contact>> targetAreaLists;
        private List<string> targetAreaNames;

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


            string[] names = {"Cary_East", "Cary_NorthEast", "Cary_NorthWest", "Cary_SouthEast", "Cary_SouthWest", "Cary_West", "Earhart_Men", "Earhart_Women", "FirstStreetCentral_Men", "FirstStreetCentral_Women",
                "FirstStreetEast_Men", "FirstStreetEast_Women", "FirstStreetWest_Men", "FirstStreetWest_Women", "Harrison_Men", "Harrison_Women", "Hawkins_Men", "Hawkins_Women", "Hillenbrand_Men",
                "Hillenbrand_Women", "Hilltop_Men", "Hilltop_Women", "HonorsNorth_Men", "HonorsNorth_Women", "HonorsSouth_Men", "HonorsSouth_Women", "McCutcheon_Men", "McCutcheon_Women", "Meredith_NorthEast",
                "Meredith_NorthWest", "Meredith_SouthEast", "Meredith_SouthWest", "Owen_Men", "Owen_Women", "Shreve_Men", "Shreve_Women", "Tarkington", "ThirdStreet_Men", "ThirdStreet_Women", "Wiley_Men", "Wiley_Women", "Windsor_Duhme",
                "Windsor_Shealy", "Windsor_Vawter", "Windsor_Walter", "Windsor_Wood"};
            targetAreaNames = new List<string>(names);

            if (numTargetAreas != targetAreaFiles.Count && numTargetAreas != targetAreaNames.Count)
            {
                Console.WriteLine("Number of Lists and Number of Files do not match");
            }
        }

        public void Run()
        {
            parseExistingContacts();
            parseNewContacts();
            sortLists();
            writeContacts();
        }

        #region ---Parsing Contacts---

        private void parseExistingContacts()
        {
            for (int i = 0; i < numTargetAreas; i++)
            {
                string[] targetAreaContacts = targetAreaFiles[i].Split('\n');
                foreach (string cntc in targetAreaContacts)
                {
                    //Check if Valid Contact
                    if (cntc == "")
                        continue;

                    string[] cntcInfo = cntc.Split('\t');
                    if (cntcInfo[0] == "Name")
                        continue;
                    Contact newContact = new Contact(cntcInfo[0], cntcInfo[1], cntcInfo[2], cntcInfo[3], cntcInfo[4], cntcInfo[5],
                        cntcInfo[6], cntcInfo[7], cntcInfo[8], cntcInfo[9], cntcInfo[10]);
                    if (!targetAreaLists[i].Contains(newContact))
                    {
                        targetAreaLists[i].Add(newContact);
                    }
                }
            }
        }

        private void parseNewContacts()
        {
            string[] newContacts = Resources.New_Contacts.Split('\n');
            foreach (string newCntct in newContacts)
            {
                //Check if Valid Contact
                if (newCntct == "")
                    continue;

                string[] newContactInfo = newCntct.Split('\t');
                Contact newContact = new Contact(newContactInfo[0], newContactInfo[1], newContactInfo[2], newContactInfo[3], newContactInfo[4],
                    newContactInfo[5], newContactInfo[6], newContactInfo[7], newContactInfo[8], newContactInfo[9]);

                List<Contact> currentArea = DetermineTargetArea(newContact);

                if (!currentArea.Contains(newContact))
                {
                    currentArea.Add(newContact);
                }
                else
                {
                    //TODO: Update Existing Contact
                    //Current Thought: Get Index of where existing contact is found and update
                }
            }
        }

        private List<Contact> DetermineTargetArea(Contact contact)
        {
            switch (contact.Building)
            {
                case "Cary - East":
                    return caryE;
                case "Cary - NorthEast":
                    return caryNE;
                case "Cary - NorthWest":
                    return caryNW;
                case "Cary - SouthEast":
                    return carySE;
                case "Cary - SouthWest":
                    return carySW;
                case "Cary - West":
                    return caryW;
                case "Earhart":
                    return (contact.Gender == "Male") ? earhartM : earhartW;
                case "First Street Towers - Central":
                    return (contact.Gender == "Male") ? firstStreetCentralM : firstStreetCentralW;
                case "First Street Towers - East":
                    return (contact.Gender == "Male") ? firstStreetEastM : firstStreetEastW;
                case "First Street Towers - West":
                    return (contact.Gender == "Male") ? firstStreetWestM : firstStreetWestW;
                case "Harrison":
                    return (contact.Gender == "Male") ? harrisonM : harrisonW;
                case "Hawkins":
                    return (contact.Gender == "Male") ? hawkinsM : hawkinsW;
                case "Hillenbrand":
                    return (contact.Gender == "Male") ? hillenbrandM : hillenbrandW;
                case "Hilltop Apartments":
                    return (contact.Gender == "Male") ? hilltopM : hilltopW;
                case "Honors College Residences - North":
                    return (contact.Gender == "Male") ? honorsNorthM : honorsNorthW;
                case "Honors College Residences - South":
                    return (contact.Gender == "Male") ? honorsSouthM : honorsSouthW;
                case "McCutcheon":
                    return (contact.Gender == "Male") ? mcCutcheonM : mcCutcheonW;
                case "Meredith - NE":
                    return meredithNE;
                case "Meredith - NW":
                    return meredithNW;
                case "Meredith - SE":
                    return meredithSE;
                case "Meredith - SW":
                    return meredithSW;
                case "Owen":
                    return (contact.Gender == "Male") ? owenM : owenW;
                case "Shreve":
                    return (contact.Gender == "Male") ? shreveM : shreveW;
                case "Tarkington":
                    return tark;
                case "Third Street Suites":
                    return (contact.Gender == "Male") ? thirdStreetM : thirdStreetW;
                case "Wiley":
                    return (contact.Gender == "Male") ? wileyM : wileyW;
                case "Windsor - Duhme":
                    return windsorDuhme;
                case "Windsor - Shealy":
                    return windsorShealy;
                case "Windsor - Vawter":
                    return windsorVawter;
                case "Windsor - Walter":
                    return windsorWalter;
                case "Windsor - Wood":
                    return windsorWood;
            }
            return null;
        }
        #endregion

        private void sortLists()
        {
            foreach (List<Contact> cntctList in targetAreaLists)
            {
                cntctList.Sort(delegate (Contact c1, Contact c2) { return c1.Room.CompareTo(c2.Room); });
            }
        }

        private void writeContacts()
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                Console.WriteLine("Excel Could Not be started");
                return;
            }

            int i = 0;
            string[] headerString = { "Name\tGender\tRace\tGrade\tBuilding\tRoom\tReligion\tRelationship Interest\tInterested in Cru Info\tInterested in Conversation\tTalked To" };
            foreach (List<Contact> list in targetAreaLists)
            {
                System.IO.File.WriteAllLines(string.Format("../../Resources/{0}.txt", targetAreaNames[i]), headerString);
                Excel.Workbook wb = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
                ws.Cells[1, "A"] = "Name";
                ws.Cells[1, "B"] = "Gender";
                ws.Cells[1, "C"] = "Race";
                ws.Cells[1, "D"] = "Grade";
                ws.Cells[1, "E"] = "Building";
                ws.Cells[1, "F"] = "Room";
                ws.Cells[1, "G"] = "Religion";
                ws.Cells[1, "H"] = "Relationship With God Interest";
                ws.Cells[1, "I"] = "Interested in Cru Info";
                ws.Cells[1, "J"] = "Interested in Conversation";
                ws.Cells[1, "K"] = "Talked With";

                int j = 2;                
                foreach (Contact cntct in list)
                {
                    
                    ws.Cells[j, "A"] = cntct.Name;
                    ws.Cells[j, "B"] = cntct.Gender;
                    ws.Cells[j, "C"] = cntct.Race;
                    ws.Cells[j, "D"] = cntct.Grade;
                    ws.Cells[j, "E"] = cntct.Building;
                    ws.Cells[j, "F"] = cntct.Room;
                    ws.Cells[j, "G"] = cntct.Religion;
                    ws.Cells[j, "H"] = cntct.RelationInterest;
                    ws.Cells[j, "I"] = cntct.CruInfo;
                    ws.Cells[j, "J"] = cntct.ConvoInterest;
                    ws.Cells[j, "K"] = cntct.TalkedWith;
                    
                    WriteToTxtFile(i, cntct);
                    j++;
                }
                ws.Columns.AutoFit();
                wb.SaveAs(string.Format(@"D:\Cru Contacts\{0}.xlsx", targetAreaNames[i]), Excel.XlFileFormat.xlOpenXMLWorkbook, null, null,
                    false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
                i++;
            }
        }

        private void WriteToTxtFile(int targetAreaNum, Contact cntct)
        {
            string contactInfo = cntct.ToString();
            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter(string.Format("../../Resources/{0}.txt", targetAreaNames[targetAreaNum]), true))
            {
                file.WriteLine(cntct.ToString());
            }
        }
    }
}
