namespace leavemanagement.wb.Data
{
    public class LeaveTypes : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
