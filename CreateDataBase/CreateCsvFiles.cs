using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace CreateDataBase
{
    class CreateCsvFiles
    {
        public const int committeeLen = 5;
        public const bool isVoting=false;
        public string personPath;
        public string memberPath;
        public string HeadPath;
        public int numberPeople;

        

        public CreateCsvFiles(string personPath,string memberPath,string HeadPath,int numberPeople)
        {
            this.personPath=personPath;
            this.memberPath=memberPath;
            this.HeadPath=HeadPath;
            this.numberPeople = numberPeople;
            
        }

        public void WriteFiles()
        {
            List<int> ID = new List<int>();
            StreamWriter personfile = new StreamWriter(personPath);
            StreamWriter memberfile = new StreamWriter(memberPath);
            StreamWriter headfile = new StreamWriter(HeadPath);
            ID=WriteToPerson(personfile);
            WriteToMember(memberfile,ID,15);
            WriteToCommittee(headfile,ID);
            personfile.Close();
            memberfile.Close();
            headfile.Close();
        }


        public List<int> WriteToPerson(StreamWriter file)
        {
            List<int> people=new List<int>();
            people = generateID(numberPeople,10000,99999);
            List<string> containerUserName=new List<string>();

            for (int i = 0; i < numberPeople; i++)
            {
                file.WriteLine(people[i] + "  ,  " + generateName(3, 8) + "  ,  " + generateAge(18, 75) + " , "+ generateUserName(containerUserName,3,8)+" , "+ generatePass()+" , "+generateBalance()+" , "+isVoting);

            }
            return people;
        }

        public void WriteToMember(StreamWriter file, List<int> ID, int numMem)
        {
            List<string> party = new List<string>() { "Cartoons", "Heros", "Darkness" };
            int locInGroup = 1;
            List<int> container = new List<int>();
            Random rnd = new Random();
            int chooseFromList;
            int j = 0;
            int index = 0;

            for (int i = 0; i < numMem; i++)
            {
                chooseFromList = rnd.Next(1, ID.Count - 1);
                j++;
                if (j > 5) { index++; j = 1; locInGroup = 1; }
                while (container.Contains(chooseFromList))
                {
                    chooseFromList = rnd.Next(1, ID.Count - 1);
                }

                file.WriteLine(ID[chooseFromList] + " , " + party[index] + " , " + locInGroup);
                container.Add(chooseFromList);
                locInGroup++;
            }

        }

        public void WriteToCommittee(StreamWriter file, List<int> ID)
        {
            Random rnd =new Random();
            for (int i = 0; i < committeeLen; i++)
            {
                int headID = rnd.Next(1, ID.Count-1);
                file.WriteLine(ID[headID]);  
            }

        }


        public List<int> generateID(int countOfPerson, int startRand, int endRand)
        {
            Random rand = new Random();
            //List<int> res = new List<int>();
            List<int> idList = new List<int>();
            for (int i = 0; i < countOfPerson; i++)
            {
                int curValue = rand.Next(startRand, endRand);
                while (idList.Contains(curValue))
                {
                    curValue = rand.Next(startRand, endRand);
                }
                //res.Add(curValue);
                idList.Add(curValue);
            }
            return idList;
        }

        public string generateName(int minLength, int maxLength)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rndLength = new Random();
            Random rndLetter = new Random();
            List<char> name = new List<char>();

            for (int i = 0; i < rndLength.Next(minLength, maxLength); i++)
            {
                name.Add(chars[rndLetter.Next(0, chars.Length - 1)]);
            }

            return string.Join("", name.ToArray());
        }

        public int generateAge(int minAge, int maxAge)
        {
            Random rand = new Random();
            int age = rand.Next(minAge, maxAge);

            return age;
        }

        public string generateUserName(List<string> container,int minLength,int maxLength)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            Random rndLength = new Random();
            Random rndLetter = new Random();
            List<char> name = new List<char>();
            

            do
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

        public int generatePass()
        {
            Random rnd = new Random();
            rnd.Next(1,1000000);
            Thread.Sleep(20);
            return rnd.Next(1, 1000000);
        }

        public int generateBalance()
        {
            Random rnd = new Random();
            rnd.Next(0, 10000);
            Thread.Sleep(20);
            return rnd.Next(1, 10000);
        }

        

    }
}
