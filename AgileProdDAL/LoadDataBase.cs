using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AgileProdObjectModel;
using AgileProdDAL.Properties;

namespace AgileProdDAL
{
    internal static class LoadDataBase
    {
        // private static string path = @"..\..\..\AgileProdDAL\Database";

        private static string path=Settings.Default.DataPath; //Should be changed accordingly to where you're data bases are
        

        internal static DataRepository LoadToDataRepository()
        {
           
            bool praimeries = checkPrimeriesStatus();
            Dictionary<string,string> admin = readFromAdmin();
            Dictionary<string,int> parties = readFromParties();
            Dictionary<int,Person> p = readFromPeople();
            Dictionary<int,Member> mem = readFromMember(p);
            Dictionary<int,Head> head = readFromHead(p);
            Dictionary<int,Bank> acc = readFromBank();
            Dictionary<int, Message> mes = readFromMessage();

            DataRepository dataR = new DataRepository(p, mem, parties, praimeries, head, admin, acc, mes);

            return dataR;
        }//LoadToDataReposatory()

        /*
         * readFromPeople creates a dictionary from people database
         */
        private static Dictionary<int, Person> readFromPeople()
        {
            Dictionary<int, Person> people = new Dictionary<int, Person>();     //initialize new empty dictionary
            StreamReader file = new StreamReader(path + "\\people.txt");        //initialize text reader

            string line = file.ReadLine();                                      //get first line

            while (line != null)                                                //go into "while" loop, while there are more lines
            {
                //var div = line.Replace(" ", string.Empty).Split(',');
                var div = line.Split(',').ToList();                             //parse line using ',' - comma as a delemiter

                for (int i = 0; i < div.Count - 1; i++)                         //loop trough string array
                {
                    if (i != 1)                                                 //if it's not the name
                    {
                        div[i].Replace(" ", string.Empty);                      //delete any white spaces
                    }
                }//for i
                       //create new prson using parsed data:   ID      Full Name            Age                 User Name        Password         BankAccount       Voter Status
                Person newPerson = new Person(Convert.ToInt32(div[0]), div[1].Trim(), Convert.ToInt32(div[2]), div[3].Trim(), div[4].Trim(), Convert.ToBoolean(div[5]));
                //Person newPerson = new Person()
                people.Add(newPerson.Id, newPerson);                            //link new person to his/hers ID
                line = file.ReadLine();                                         //get next line
            }
            return people;                                                      //return people dictionary
        }//readFromPeople()

        private static Dictionary<int, Bank> readFromBank()
        {
            Dictionary<int, Bank> bankAccounts = new Dictionary<int, Bank>();
            StreamReader file = new StreamReader(path + "\\bankAccounts.txt");

            string line = file.ReadLine();                                      //get first line

            while (line != null)
            {
                var div = line.Split(',').ToList();

                for (int i = 0; i < div.Count - 1; i++)                         //loop trough string array
                {
                    if (i != 1)                                                 //if it's not the name
                    {
                        div[i].Replace(" ", string.Empty);                      //delete any white spaces
                    }
                }//for i

                Bank account = new Bank(Convert.ToInt32(div[2].Trim()), Convert.ToInt32(div[0]), div[1].Trim());
                bankAccounts.Add(account.Id, account);
                line = file.ReadLine();
            }
            return bankAccounts;
        }

        private static Dictionary<int, Message> readFromMessage()
        {
            Dictionary<int, Message> messages = new Dictionary<int, Message>();
            StreamReader file = new StreamReader(path + "\\messageInbox.txt");

            string line = file.ReadLine();                                  //get first line

            while (line != null)
            {
                var div = line.Split(',').ToList();
                int inboxOwner = Convert.ToInt32(div[0].Trim());

                if (div.Count == 1)
                {
                    messages.Add(Convert.ToInt32(div[0]), null);
                }
                else
                {
                    
                    for (int i = 1; i < div.Count; i=i+3)
                    {
                        int senderId = Convert.ToInt32(div[i].Trim());
                        string text = div[i+1].Trim();
                        int bribeAmount = Convert.ToInt32(div[i+2].Trim());
                        if (i == 1)
                        {
                            messages[inboxOwner] = new Message(senderId, text, bribeAmount);
                        }
                        else
                        {
                            messages[inboxOwner].addMessage(senderId, text, bribeAmount);
                        }
                    }
                }
                line = file.ReadLine();
            }

            return messages;
        }

        /*
         * readFromMember creates a dictionary from party member database
         */
        private static Dictionary<int, Member> readFromMember(Dictionary<int, Person> people)
        {
            Dictionary<int, Member> members=new Dictionary<int,Member>();      //initialize new empty dictionary
            StreamReader file = new StreamReader(path + "\\members.txt");       //initialize text reader

            string line = file.ReadLine();                                      //get first line

            while (line != null)                                                //go into "while" loop, while there are more line 
            {
                var div = line.Replace(" ", string.Empty).Split(',');           //parse and the line

                for (int i = 0; i < people.Count; i++)                          //loop through people dictionary
                {
                    var temp = people[int.Parse(div[0])];
                    if (int.Parse(div[0]) == temp.Id)                           //check if dictionary returned a valid value
                    {
                        //create a new party member
                        Member partyMember = new Member(temp.Id, temp.Name, temp.Age, temp.UserName, temp.Password, false, div[1], int.Parse(div[2]));
                        members.Add(partyMember.Id, partyMember);               //add party member to party dictionary 
                        break;
                    }//if
                }//for i
                line = file.ReadLine(); 
            }//while
            return members;                                                     //return dictionary
        }//readFromMember(Dictionary<int, Person>)

        /*
         * readFromHead creates a dictionary from committee database
         */
        private static Dictionary<int, Head> readFromHead(Dictionary<int, Person> people)
        {
            Dictionary<int, Head> heads = new Dictionary<int, Head>();          //initialize a new empty dictionarty
            StreamReader file = new StreamReader(path + "\\committee.txt");     //initialize file reader

            string line = file.ReadLine();                           //get first line
            while (line != null)                                     //while ReadLine returnes a line
            {
                var div = Convert.ToInt32(line);                     //convert line to int
                for (int i = 0; i < people.Count; i++)               //go trough people dictionary
                {
                    var temp = people[div];
                    if (div == temp.Id)                              //if person exists
                    {
                        //create a new committee member
                        Head h = new Head(div, temp.Name, temp.Age, temp.UserName, temp.Password, false);
                        heads.Add(h.Id, h);                         //add new committee member to dictionary
                        break;
                    }
                }
                line = file.ReadLine();
            }
            return heads;                                           //return dictionary
        }//readFromHead(Dictionary<int, Person>)

        /*
         * readFromAdmin creates a dictionary from admin database
         */
        private static Dictionary<string, int> readFromParties()
        {
            Dictionary<string, int> parties = new Dictionary<string, int>();    //inititalize new empty dictionary
            StreamReader file = new StreamReader(path + "\\parties.txt");       //initialize file reader

            string line = file.ReadLine();                                      //get first line
            while (line != null)                                                //if file reader return a readable value
            {
                var div = line.Split(',');                                      //parse text
                div[0].Trim();
                parties.Add(div[0], int.Parse(div[1]));                         //add party to dictionary
                line = file.ReadLine();                                         //get next line
            }
            return parties;                                                     //return parties dictionary
        }//readFromParties();

        /*
         * checkPraimeriesStatus returns true if there are on going praimeries,
         * other wise it returns false;
         */
        private static bool checkPrimeriesStatus()
        {
            StreamReader file = new StreamReader(path + "\\praimerise.txt"); //initialize file reader
            string line = file.ReadLine();                                   //get line
            return Convert.ToBoolean(int.Parse(line));                       //conver and return 0 or 1 as boolean value
        }//checkPrimeriesStatus()

        /*
         * readFromAdmin creates a dictionary from admin database
         */
        private static Dictionary<string, string> readFromAdmin()
        {
            Dictionary<string, string> admin = new Dictionary<string, string>();    //inititalize new empty dictionary
            StreamReader file = new StreamReader(path + "\\admin.txt");       //initialize file reader

            string line = file.ReadLine();                                    //get first line
            while (line != null)                                              //if file reader return a readable value
            {
                var div = line.Replace(" ", string.Empty).Split(',');         //parse text
                admin.Add(div[2], div[3]);                                    //add party to dictionary
                line = file.ReadLine();                                       //get next line
            }
            return admin;                                                     //return parties dictionary
        }//readFromAdmin()
    }
}
