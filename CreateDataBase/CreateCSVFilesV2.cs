using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace AgileProd
{
    class CreateCSVFilesV2
    {
        //Varaiables
        private string GenPath = @"Z:\Studies\Software Maintenance\Database"; //defualt path to databases
        public List<string> listOfNames;                                      //list of all the names from the database
        public const int committeeLen = 5;                                    //the defualt size of the elections commitee
        public const bool isVoting = false;                                   //isVoting determines if this person has registed as a voter
        public const string defaultPass = "pass";                             //defualt password
        public string personPath;                                             //path to person database file
        public string memberPath;                                             //path to party member database file
        public string CommiteePath;                                           //path to comittee database file
        public string messagePath;
        public string bankPath;                                               //path to bank database file
        public int numberOfPeople;                                            //path to person database file

        //Methods of CreateCSVfilesV2 class
        

        /* 
         * Constructor of CreateCsvFiles class.
         * This constructor takes given paths of the databases and assignes them to
         * it's inner varaiables.
         * Also takes the number of people we would like to create as an integer parameter.
         */
        public CreateCSVFilesV2(string personPath, string memberPath, string committeePath, string bankPath, string messagePath)
        {
            this.personPath = personPath;
            this.memberPath = memberPath;
            this.CommiteePath = committeePath;
            this.bankPath = bankPath;
            this.messagePath = messagePath;
            this.listOfNames = getNamelist();               //gets the list of names we will be using in the program
            this.numberOfPeople = this.listOfNames.Count;   //uses the size of the list to initialize the varaiable "numberOfPeople"

        }//CreateCsvFiles(string, string, string, int)

        /* 
         * GetNameList uses a given database of names to create a list of names
         */
        public List<string> getNamelist()
        {
            List<string> tempList = new List<string>();                     //create temporary list
            StreamReader file = new StreamReader(GenPath + "\\nameDB.txt"); //read from file named "nameDB"
            string line = file.ReadLine();                                  //initialize a seperated line varaiable using a name from name database

            while (line != null)            //stop when you reach the end of the file
            {
                tempList.Add(line);         //add the name to the temporary list
                line = file.ReadLine();     //get next name
            }
            return tempList;                //when finished copying all the names, return the list
        }//GetNameList()

        /*
         * generateAge generates a random age
         * between a given minimum and a maximum age
         */
        public int generateAge(int minAge, int maxAge)
        {
            Thread.Sleep(5);
            Random rand = new Random();             //initialize new sudo random 
            int age = rand.Next(minAge, maxAge);    //generate a random number

            return age;                             //return the age
        }//generateAge(int, int)

        /*
         * generateBalance generates a random balance
         * using a minimux amount and a maximum amount
         */
        public int generateBalance(int minAmount, int maxAmount)
        {
            Thread.Sleep(5);
            Random rnd = new Random();                      //initialize new sudo random
            int amount = rnd.Next(minAmount, maxAmount);    //generate a random number

            return amount;                                  //return the amount
        }//generateBalance(int, int)

        /*
         * generateID generates a random ID
         * using a starting value and an ending value
         */
        public List<int> generateID(int startRand, int endRand)
        {
            Random rand = new Random();                         //initialize new sudo random
            List<int> idList = new List<int>();                 //initialize new empty list
            for (int i = 0; i < listOfNames.Count; i++)       //loop through the size of people name database
            {
                int curValue = rand.Next(startRand, endRand);   //generate a random value
                while (idList.Contains(curValue))               //check if value already exists in the list
                {
                    curValue = rand.Next(startRand, endRand);
                }
                idList.Add(curValue);                           //if value does not exists add it to the list 
            }
            return idList;                                      //return list of IDs
        }//generateID(int, int)

        /*
         * generateUserName generates a random username
         * using  a given length
         */
        public string generateUserName(List<string> container, int minLength, int maxLength)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";                            //usable characters for creating a username
            Random rndLength = new Random();                                        //initialize new sudo random
            Random rndLetter = new Random();                                        //initialize new sudo random
            List<char> name = new List<char>();                                     //initialize new empty name list 

            do                                                                      //do while user name exists in the list 
            {
                name.Clear();
                for (int i = 0; i < rndLength.Next(minLength, maxLength); i++)
                {
                    name.Add(chars[rndLetter.Next(0, chars.Length - 1)]);
                }
            } while (container.Contains(string.Join("", name.ToArray())));

            container.Add(string.Join("", name.ToArray()));
            return string.Join("", name.ToArray());
        }

        /*
         * writeToPerson collects information and writes it to person file
         */
        public List<int> writeToPerson(StreamWriter file)
        {
            List<int> IDlist = new List<int>();                     //create a new empty ID list
            List<string> containerUserName = new List<string>();    //create a new empty usename list
            IDlist = generateID(100000000, 999999999);              //generate and initialize ID list 

            for (int i = 0; i < listOfNames.Count; i++)             //loop trough all the names
            {   //write to file:   ID                Full Name                  Age                                  User Name                                Default Password            default voter status
                file.WriteLine(IDlist[i] + ", " + listOfNames[i] + ", " + generateAge(18, 120) + " ," + generateUserName(containerUserName, 5, 5) + " ," + defaultPass + IDlist[i] + " ," + isVoting);
            }
            return IDlist;                                          //return id list
        }//writeToPerson(StreamWriter)

        public void writeToBank(StreamWriter file, List<int> ID)
        {
            for (int i = 0; i < listOfNames.Count; i++)
            {
                file.WriteLine(ID[i] + ", " + listOfNames[i] + ", " + generateBalance(0, 100000));
            }
        }

        public void writeToMessage(StreamWriter file, List<int> ID)
        {
            for (int i = 0; i < listOfNames.Count; i++)
            {
                file.WriteLine(ID[i]);
            }
        }

        /*
         * writeToPartyMember gathers information and writes member database
         */
        public void writeToPartyMember(StreamWriter file, List<int> ID, int numMem)
        {
            List<string> party = new List<string>() { "Unification", "All Of Us", "The Zionistic Camp", "The Jewish House", "There is a Future", "Energy" }; //party list
            int locationInParty = 1;                                       //defualt place in party
            List<int> container = new List<int>();                         //new empty list 
            Random rnd = new Random();                                     //new sudo random
            int chooseFromList;
            int j = 0;
            int index = 0;

            for (int i = 0; i < party.Count*5; i++)
            {
                chooseFromList = rnd.Next(1, ID.Count - 1);
                j++;
                if (j > 5) { index++; j = 1; locationInParty = 0; }
                while (container.Contains(chooseFromList))
                {
                    chooseFromList = rnd.Next(1, ID.Count - 1);
                }

                file.WriteLine(ID[chooseFromList] + " , " + party[index] + " , " + locationInParty);
                container.Add(chooseFromList);
            }
        }//writeToPartyMember(StreamWriter, List<int>, int)

        /*
         * writeToCommittee writes committee database
         */
        public void writeToCommittee(StreamWriter outputfile, StreamReader inputfile)
        {
            List<Tuple<int, int>> listOfCommittee = new List<Tuple<int, int>>();

            string line = inputfile.ReadLine();
            int count = 0;
            int lowestAge = 0;
            while (line != null)                         //stop when you reach the end of the file
            {
                var linelist = line.Split(',');
                Tuple<int, int> temp = new Tuple<int, int>(Convert.ToInt32(linelist[0]), Convert.ToInt32(linelist[2].Trim()));

                if (count < 5)
                {
                    if (count == 0)
                    {
                        lowestAge = temp.Item2;
                    }
                    else if (temp.Item2 < lowestAge)
                    {
                        lowestAge = temp.Item2;
                    }
                    listOfCommittee.Add(temp);
                    count++;
                }
                else
                {
                    if (temp.Item2 > lowestAge)
                    {
                        for (int i = 0; i < listOfCommittee.Count; i++)
                        {
                            if (listOfCommittee[i].Item2 < temp.Item2)
                            {
                                lowestAge = listOfCommittee[i].Item2;
                                listOfCommittee[i] = temp;
                                break;
                            }
                        }
                    }
                }
                line = inputfile.ReadLine();
            }

            for (int i = 0; i < listOfCommittee.Count; i++)
            {
                outputfile.WriteLine(listOfCommittee[i].Item1 + ", " + listOfCommittee[i].Item2);
            }
            outputfile.Close();
            inputfile.Close();
        }//writeToCommittiee;

        /*
         * 
         */
        public void writeFiles()
        {
            List<int> ID = new List<int>();                            //initialize new empty ID list 
                                                                       //Initialize paths:
            StreamWriter personfile = new StreamWriter(personPath);      //person path
            StreamReader personfilereader = new StreamReader(personPath);
            StreamWriter bankfile = new StreamWriter(bankPath);      //person path
            StreamWriter memberfile = new StreamWriter(memberPath);      //party member path
            StreamWriter committeefile = new StreamWriter(CommiteePath); //coommittee member path
            StreamWriter messagefile = new StreamWriter(messagePath); //coommittee member path

            ID = writeToPerson(personfile);                            //write people database
            personfile.Close();
            writeToBank(bankfile, ID);                                 //write bank file
            bankfile.Close();
            writeToPartyMember(memberfile, ID, 15);                    //write party member database
            memberfile.Close();
            writeToCommittee(committeefile, personfilereader);         //write committee member database
            personfilereader.Close();
            committeefile.Close();
            writeToMessage(messagefile, ID);                           //write message file
            messagefile.Close();

            
            
            
            
        }//writeFiles()

    }
}
