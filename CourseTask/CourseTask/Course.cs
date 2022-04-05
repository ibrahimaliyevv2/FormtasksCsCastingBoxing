using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTask
{
    class Course
    {
        private Group[] _groups = new Group[0];
        public Group[] Groups { get; set; }
        public void AddGroup(Group group)
        {
            Array.Resize(ref _groups, _groups.Length+1);
            _groups[_groups.Length - 1] = group;
        }

        public Group[] GetAllGroupsByType(string type)
        {
            Group[] FilteredGroup = new Group[0];
            foreach (var item in _groups)
            {
                if (item.Type==type)
                {
                    Array.Resize(ref FilteredGroup, FilteredGroup.Length+1);
                    FilteredGroup[FilteredGroup.Length - 1] = item;
                }
            }
            return FilteredGroup;
        }
    }
}
