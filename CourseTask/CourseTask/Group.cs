using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTask
{
    class Group
    {
        public Group()
        {
            _no++;
            No = _no;
        }

    private static int _no;
    public int No { get; set; }
    public string Type { get; set; }
    }
}
