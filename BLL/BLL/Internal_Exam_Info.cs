using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
  public class Internal_Exam_Info
    {
        #region Public Property

        public string examid { set; get; }
        public string nameoftheexamination { set; get; }
        public string monthYear { set; get; }
        
        public string Description { set; get; }
        
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public string ExamType { set; get; }
        public string Programme { set; get; }
        public string Course { set; get; }
        public string CourseYearSem { set; get; }
        public string Regulation { set; get; }
       

        public string Creation_Company { set; get; }
        public string Created_By { set; get; }
        public DateTime Created_Date { set; get; }
        public string Modified_By { set; get; }
        public DateTime Modified_Date { set; get; }
        public int Parameter { set; get; }

       

        #endregion
    }
}
