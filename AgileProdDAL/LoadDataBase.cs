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
        private static string path=Settings.Default.DataPath;

        //loadToDataPerosatory collects all of the dictionaries to one place
        internal static DataRepository LoadToDataRepository()
        { 
            bool praimeries = checkPrimeriesStatus();           //holds a bool varaiable to determine if Praimeries are on
            Dictionary<int,Admin> admin = readFromAdmin();      //<id, admin instance>
            Dictionary<string,int> parties = readFromParties(); //<party name, amount of votes>
            Dictionary<int,Person> p = readFromPeople();        //<id, peson instance>
            Dictionary<int,Member> mem = readFromMember(p);     //<id, party member instance>
            Dictionary<int,Head> head = readFromHead(p);        //<id, committee member instance>
            Dictionary<int,Bank> acc = readFromBank();          //<id, bank account instance>
            Dictionary<int, Message> mes = readFromMessage();   //<id, message inbox instance>

            DataRepository dataR = new DataRepository(p, mem, parties, praimeries, head, admin, acc, mes);  //creates data reposatory

            return dataR;           //returns a data reposatory of all of the dictionaries
        }//LoadToDataReposatory()

        //readFromPeople creates a dictionary from people database
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

        //readFromBank creates a dictionary from bank accounts database
        private static Dictionary<int, Bank> readFromBank()
        {
            Dictionary<int, Bank> bankAccounts = new Dictionary<int, Bank>();
            StreamReader file = new StreamReader(path + "\\bankAccounts.txt");

            string line = file.ReadLine();                                      //get first line

            while (line != null)                                                //loop trough the whole file
            {
                var div = line.Split(',').ToList();                             //split and convert to list

                for (int i = 0; i < div.Count - 1; i++)                         //loop trough string list
                {
                    if (i != 1)                                                 //if it's not the name
                    {
                        div[i].Replace(" ", string.Empty);                      //delete any white spaces
                    }
                }//for i
                                                                                //create bank account instance
                Bank account = new Bank(Convert.ToInt32(div[2].Trim()), Convert.ToInt32(div[0]), div[1].Trim());
                bankAccounts.Add(account.Id, account);                          //add instance to bank account dictionary
                line = file.ReadLine();                                         //get next line
            }
            return bankAccounts;                                                //return bank accounts dictionary
        }//readFromPeople()

        //readFromMessage creates a dictionary from messages database
        private static Dictionary<int, Message> readFromMessage()
        {
            Dictionary<int, Message> messages = new Dictionary<int, Message>();
            StreamReader file = new StreamReader(path + "\\messageInbox.txt");

            string line = file.ReadLine();                                      //get first line

            while (line != null)                                                //loop trough the whole file
            {
                var div = line.Split(',').ToList();                             //split a line from database and convert to list
                int inboxOwner = Convert.ToInt32(div[0].Trim());                //initialize id and convert it to int

                if (div.Count == 1)                                             //if there are no messages:
                {
                    messages.Add(Convert.ToInt32(div[0]), null);                //add an empty message box
                }
                else
                {
                    
                    for (int i = 1; i < div.Count; i=i+3)                       //iterate trough line of database
                    {
                        int senderId = Convert.ToInt32(div[i].Trim());          //initialize sender's id 
                        string text = div[i+1].Trim();                          //initialize sent text 
                        int bribeAmount = Convert.ToInt32(div[i+2].Trim());     //initialize amount of money that was sent
                        if (i == 1)                                             //if i == 1, it means that we are on the reciver's id and it's the first message he got
                        {                                                       //create a new message inbox
                            messages[inboxOwner] = new Message(senderId, text, bribeAmount);
                        }
                        else                                                    //if i != 1, it means that there are allready messages in this person's inbox
                        {                                                       //add new message to inbox
                            messages[inboxOwner].addMessage(senderId, text, bribeAmount);
                        }
                    }
                }
                line = file.ReadLine();                                         //get next line
            }
            return messages;                                                    //return message dictionary
        }//readFromMessage()

        //readFromMember creates a dictionary from party member database
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

        //readFromHead creates a dictionary from committee database
        private static Dictionary<int, Head> readFromHead(Dictionary<int, Person> people)
        {
            Dictionary<int, Head> committee = new Dictionary<int, Head>();      //initialize a new empty dictionarty
            StreamReader file = new StreamReader(path + "\\committee.txt");     //initialize file reader

            string line = file.ReadLine();                                      //get first line
            while (line != null)                                                //loop through the whole file
            {
                var div = Convert.ToInt32(line);                                //convert (string)id to int
                for (int i = 0; i < people.Count; i++)                          //go trough people dictionary
                {
                    var temp = people[div];                                     //get peson using id of committee members
                    if (div == temp.Id)                                         //check if ids match
                    {
                                                                                //create a new committee member
                        Head h = new Head(div, temp.Name, temp.Age, temp.UserName, temp.Password, false);
                        committee.Add(h.Id, h);                                 //add new committee member to dictionary
                        break;
                    }
                }
                line = file.ReadLine();                                         //get next line
            }
            return committee;                                                   //return dictionary
        }//readFromHead(Dictionary<int, Person>)

        //readFromAdmin creates a dictionary from admin database
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

        //checkPraimeriesStatus returns true if there are on going praimeries, other wise it returns false;
        private static bool checkPrimeriesStatus()
        {
            StreamReader file = new StreamReader(path + "\\praimerise.txt"); //initialize file reader
            string line = file.ReadLine();                                   //get line
            return Convert.ToBoolean(int.Parse(line));                       //conver and return 0 or 1 as boolean value
        }//checkPrimeriesStatus()

        //readFromAdmin creates a dictionary from admin database
        private static Dictionary<int, Admin> readFromAdmin()
        {
            Dictionary<int, Admin> admin = new Dictionary<int, Admin>();    //inititalize new empty dictionary
            StreamReader file = new StreamReader(path + "\\admin.txt");     //initialize file reader

            string line = file.ReadLine();                                  //get first line
            while (line != null)                                            //if there is a line
            {
                var div = line.Split(',');                                  //parse line user ',' as a delimeter

                int id = Convert.ToInt32(div[0].Trim());                    //convert (string)id to int and trim edges
                string name = div[1].Trim();                                //initialize name 
                string username = div[2].Trim();                            //initialize username
                string password = div[3].Trim();                            //initialize password

                Admin newAdmin = new Admin(id, name, username, password);   //create nea admin instance
                admin.Add(id, newAdmin);                                    //add party to dictionary

                line = file.ReadLine();                                     //get next line
            }  
            return admin;                                                   //return parties dictionary
        }//readFromAdmin()
    }
}
