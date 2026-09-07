using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Task4__seeder
{
    public class CourseAssessmentMark
    {
        //fields
        private Course course;
        private List<int> assessmentMarks;
        
        //constructor
        public CourseAssessmentMark(Course course, List<int> assessmentMarks)
        {
            this.course = course;
            this.assessmentMarks = assessmentMarks;
            
        }
        //encapsulation {but still use field}
        public Course Course { get => course; set => course = value; }
        public List<int> AssessmentMarks { get => assessmentMarks; set => assessmentMarks = value; }
        public List<int> GetAllMarks()
        {
            return assessmentMarks;
        }
        public List<string> GetAllGrades()
        {
            return assessmentMarks;
        }
        public List<int> GetHighestMarks()
        {
            return assessmentMarks;
        }
        public List<int> GetLowestMarks ()
        {
            return assessmentMarks;
        }
        public List<int> GetFailMarks()
        {
            return assessmentMarks;
        }
        public List<string> GetAverageMark ()
        {

        }
        public string GetAverageGrade()
        {
            if (GetAverageMark() <= 50)
                return 
        }
        public string GetGrade(int markrange)
        {
            string grade;
            switch(markrange)
            {
                case >= 90 and <= 100:
                    grade = "A+";

                    break;

                case >= 85 and <= 89:
                    grade = "A";
                    break;

                case >= 80 and <= 84:
                    grade = "A-";
                    break;
                case >= 75 and <= 79:
                    grade = "B+";
                    break;
                case >= 70 and <= 74:
                    grade = "B";
                    break;

                case >= 65 and <= 69:
                    grade = "B-";
                    break;
                case >= 60 and <= 64:
                    grade = "C+";
                    break;
                case >= 55 and <= 59:
                    grade = "C";
                    break;
                case >= 50 and <=54:
                    grade = "C-";
                    break;
                case >= 40 and <= 49:
                    grade ="D";
                    break;
                case >= 0 and <= 39:
                    grade = "E";
                    break;
                default:
                    grade = "";
                    break;
            }
           
            return grade;
        }




    }
            
           
}
