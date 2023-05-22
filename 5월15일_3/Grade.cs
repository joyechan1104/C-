using _5월15일_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5월15일_3
{
    //프로젝트 양식추가 클래스
    internal class Grade
    {
        private int math;
        private int science;
        private int english;

        //average(math, science, english);

        public Grade(int math, int science, int english)
        {
            this.math = math;
            this.science = science;
            this.english = english;
        }

        public double average()
        {
            return (math + science + english) / 3.0;
        }
    }
}
