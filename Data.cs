using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11_DAL
{
    public class Data
    {
        IEnumerable<Person> GetData(string code, KeyValuePair<string, object> parameters)
        {
            List<Person> allList = new List<Person>();
            List<Person> needList = new List<Person>();

            
            

            if(code == "GetPersons")
            {
                switch (parameters.Key)
                {
                    case "Id":

                        foreach (Person p in allList)
                        {
                            if(p.Id.Equals(parameters.Value) )
                            {
                                needList.Add(p);
                            }
                        }

                        break;


                    case "Name":
                        foreach (Person p in allList)
                        {
                            if (p.Name.Equals(parameters.Value))
                            {
                                needList.Add(p);
                            }
                        }

                        break;


                    case "Age":
                        foreach (Person p in allList)
                        {
                            if (p.Age.Equals(parameters.Value))
                            {
                                needList.Add(p);
                            }
                        }

                        break;

                }
                
            }
           
            return needList;
        }
    }

   
}
