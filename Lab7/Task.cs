using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Task
    {
        protected string description;
        public Task()
        {
            this.setdescription("Default Task");
        }
        public Task (string description)
        {
            this.setDescription(description);
        }
        public string getDescription()
        {
            return this.description;
        }
        public void displayTask()
        {

        }
    }
}
