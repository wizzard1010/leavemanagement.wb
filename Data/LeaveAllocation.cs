using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace leavemanagement.wb.Data
{
    public class LeaveAllocation:BaseEntity
    { 
        public int NumberOfDay { get; set; }

        [ForeignKey("LeaveTypeID")]
        public LeaveTypes LeaveType { get; set; }
        public int LeaveTypeID { get; set; }

        public string EmployeeId { get; set; }
    }
}
