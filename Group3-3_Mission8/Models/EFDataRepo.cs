
namespace Group3_3_Mission8.Models
{
    public class EFDataRepo : IDataRepo
    {
        private TaskDbContext _context;
        public EFDataRepo(TaskDbContext temp) 
        { 
            _context = temp;
        }
        public List<TaskModel> Tasks => _context.Tasks.ToList();
    }
}
