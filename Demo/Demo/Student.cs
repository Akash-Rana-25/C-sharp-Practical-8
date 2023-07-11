using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    sealed class  Student
    {
        private int _id;
        public required  string _name { get; init; }

        public int Id { get { return _id; } }

        [SetsRequiredMembers]
        public Student(string name , int id)
        {
            _id = id;
            _name=name;
        }

        public override string ToString() {
            return $"id={_id},name = {_name}";
        }
    }
}
