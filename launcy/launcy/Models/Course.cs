using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcy.Core.Models
{
    public class Course
    {
        public enum StateEnum
        {
            A_FAIRE,
            FAIT
        }

        public StateEnum State
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }


        public Course(string name, StateEnum state)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            State = state;
        }

        public Course(string name) : this(name, StateEnum.A_FAIRE)
        {

        }
    }
}
