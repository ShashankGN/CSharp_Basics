using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_Props
{
    public class Student
    {
        private int ID;
        private string name;
        private int passmark = 35;

        //public int Getpassmark()
        //{
        //    return passmark;
        //}
        //public void SetID(int id)
        //{
        //    if (id <= 0)
        //    {
        //        throw new Exception("Student id must be greater than zero");
        //    }
        //    ID = id;
        //}

        //public void Setname(string Name)
        //{
        //    name = Name;
        //}

        //public string Getname()
        //{
        //    return name;
        //}

        //public int GetID()
        //{
        //    return ID;
        //}


        public int Passmark
        {
            get
            {
                return passmark;
            }
        }
        public int Id
        { 
            get 
            { 
                return ID; 
            }
            set
            {

                ID = value;
            }
        }
      
          //i can create methods by typing prop and hitting enter


        //if a class is static all the methods and members inside it should be static
        //its possible to have a static method and static member inside a non static class

    }



}
