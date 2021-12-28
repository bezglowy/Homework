using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domowe_1
{
    public class Worker
    {
        private string name;
        private string surname;
        private byte age;
        private char sex;
        private ulong pesel;
        private ulong workerNumber;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname { get => surname; set => surname = value; }
        public byte Age
        {
            get => age;
            set
            {
                if ((value > 1) && (value < 150))
                {
                    age = value;
                }
            }
        }
        public char Sex
        {
            get => sex;
            set
            {
                if ((value == 'm') | (value == 'k'))
                {
                    sex = value;
                }
            }

        }

        public ulong Pesel { get => pesel;
            set
            { 
                if (value > 0)
                    pesel = value;
            }
 }

        public ulong WorkerNumber { get => workerNumber; set => workerNumber = value; }
    }
}

