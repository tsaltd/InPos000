using System.Collections.Generic;

namespace InPosLib
{
    public class ObjectFinder
    {
        public List<object> searchThisList;
        public object TypeToFind;
        public bool Found { get; set; }

        public ObjectFinder(List<object> thelist, string selector, bool found)
        {
            searchThisList = thelist;
            Found = found;
            SelectObjectType(selector);
        }

        public bool In()
            {
               object result = searchThisList.Find(x => x.GetType() == TypeToFind.GetType());
               if (result != null) return true;
               return false;
            }

        public void SelectObjectType(string selector)
            {
                // ReSharper disable once ObjectCreationAsStatement
                //new object();


                switch (selector)
                {
                    case "1":

                        TypeToFind = new Employee();

                        break;
                    case "2":

                        TypeToFind = new Executive();
                        break;
                    case "3":

                        TypeToFind = new SalesPerson();
                        break;
                }
            }
    }

            
        }