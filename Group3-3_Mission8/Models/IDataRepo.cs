
namespace Group3_3_Mission8.Models
{
    public interface IDataRepo
    {
        List<TaskModel> Tasks { get; }

        public void AddTask(TaskModel task);
        public void RemoveTask(TaskModel task);

    }
}
