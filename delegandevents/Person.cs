using System;
using System.Collections.Generic;
using System.Text;

namespace delegandevents
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;
        public string Name { get; set; }
        public void TakeTime(int n)
        {
            if (n <= 8)
            {
                GoToSleep.Invoke();
            }
            else
            {
               
                
                DoWork.Invoke(this,null);
            }
        }
    }
}
