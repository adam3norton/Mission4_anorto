using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_anorto.Models
{
    public class GradeCalculator
    {
        [Range(0, 100, ErrorMessage = "Assignments must be between 0 and 100")]
        public int AssignmentsPercent { get; set; }

        [Range(0, 100, ErrorMessage = "Group must be between 0 and 100")]
        public int GroupPercent { get; set; }

        [Range(0, 100, ErrorMessage = "Quizzes must be between 0 and 100")]
        public int QuizPercent { get; set; }

        [Range(0, 100, ErrorMessage = "Midterm must be between 0 and 100")]
        public int MidtermPercent { get; set; }

        [Range(0, 100, ErrorMessage = "Final must be between 0 and 100")]
        public int FinalPercent { get; set; }

        [Range(0, 100, ErrorMessage = "Intex must be between 0 and 100")]

        public int IntexPercent { get; set; }
    }
}
