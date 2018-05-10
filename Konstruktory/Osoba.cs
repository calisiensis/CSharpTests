using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Osoba
    {
        int id;
        string firstName;
        string lastName;
        string address;
        int age;
        string gender;

        public Osoba() // jak nie daliśmy wartości domyślnych, to będzie automatycznie 0, null lub false
        {
            id = 1;
            firstName = "Emhyr";
            lastName = "var Emreis";
            age = 55;
        }

        public Osoba(int id, string firstName, string lastName, string address, int age, string gender)
        {
            this.id = id; // this - to id tyczy się naszej klasy/obiektu
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Osoba(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            // można też dać dodatkowo konstruktory z domyślnymi wartościami
            address = "Biały Sad";
            age = 21;
        }

        public Osoba(int id, string firstName)
        {
            this.id = id;
            this.firstName = firstName;
        }
    }


}
