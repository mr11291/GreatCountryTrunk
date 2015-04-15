using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProd
{
    class LoadDataBase
    {
        public string path;
        public LoadDataBase(string path)
        {
            this.path = path;
        }

        public Dictionary<int,Person> readFromPeople(Dictionary<int,Person> people)
        {
            StreamReader file=new StreamReader(path+"\\people.txt");
            string line = file.ReadLine();

            while(line!=null)
            {
                var div=line.Replace(" ",string.Empty).Split(',');
            
                Person p = new Person(Convert.ToInt32(div[0]), div[1],int.Parse(div[2]), div[3], div[4]);
                people.Add(p.id, p);
                line = file.ReadLine();
            }
            return people;
        }



        public Dictionary<int, Member> readFromMember(Dictionary<int,Person> people, Dictionary<int, Member> members)
        {
            StreamReader file = new StreamReader(path + "\\members.txt");

            string line = file.ReadLine();
            while (line != null)
            {
                var div = line.Replace(" ", string.Empty).Split(',');
                for (int i = 0; i < people.Count; i++)
                {
                    var temp = people[int.Parse(div[0])];
                    if(int.Parse(div[0])==temp.id)
                    {
                        Member m = new Member(temp.id, temp.name, temp.age, temp.userName, temp.password, div[1], int.Parse(div[2]));
                        members.Add(m.id,m);
                        break;
                    }
                }
                line = file.ReadLine();
            }
            return members;
        }

        
    }
}
