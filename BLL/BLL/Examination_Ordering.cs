using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class Examination_Ordering
    {
        #region Public Property


        public string Order_Id { set; get; }
        public string Regulation { set; get; }

        public string Programme { set; get; }

        public string Course { set; get; }
        public string Course_Yr_Sem { set; get; }
        public string Subject_Name { set; get; }
        public string Display_Order { set; get; }
        public string Parts { set; get; }
       
        public string Credit_Points { set; get; }
        public string CIA_Total_Marks { set; get; }
        public string CIA_Pass_Marks { set; get; }
        public string ESE_Total_Marks { set; get; }

        public string ESE_Pass_Marks { set; get; }
        public string Total_Marks { set; get; }
        public string Pass_Marks { set; get; }


        public int examSyncID { set; get; }
        public int section_id { set; get; }
        
              public string student_admission_number{ set; get; }
        public string student_hall_ticket_number { set; get; }
        public string student_marks_info { set; get; }
        public string student_admission_id { set; get; }
        public string student_pass_result { set; get; }

        public string Creation_Company { set; get; }
        public string Created_By { set; get; }
        public DateTime Created_Date { set; get; }
        public string Modified_By { set; get; }
        public DateTime Modified_Date { set; get; }
        public int Parameter { set; get; }

       


        #endregion
    }
}
