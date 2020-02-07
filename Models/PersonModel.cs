using LAB0_0.Helpers;

namespace LAB0_0.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }

        public bool Save()
        {
            try
            {
                Storage.Instance.personList.Add(this);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*public void BubbleSort()
        {
            try
            {
                int CountElement = Storage.Instance.personList.Count;
                string[] ArrayList = new string[CountElement];
              //  ArrayList = Storage.Instance.personList.ToArray(this);

                string tmp;
                for (int i = 0; i < CountElement - 1; i++)
                {
                    for (int j = i + 1; j < CountElement; j++)
                    {
                       if(string.Compare(ArrayList[i], ArrayList[j])==1)
                        {
                            tmp = ArrayList[i];
                            ArrayList[i] = ArrayList[j];
                            ArrayList[j] = tmp;
                        }
                    }
                }
            }
            catch 
            {
                
            }
          
         }*/

    }
}