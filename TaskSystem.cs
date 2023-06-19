namespace code_signal;

public class TaskSystem
{
    public List<TaskT> Tasks = new List<TaskT>();

    public enum Status
    {
        Pending,
        InProgress,
        Completed
    }

    public class TaskT
    {
        public string Title { get; private set; }
        public Status Status { get; set; }
        public TaskT(string title)
        {
            Title = title;
            Status = Status.Pending;
        }
    }

    public void AddTask(string title)
    {
        var task = new TaskT(title);
        Tasks.Add(task);
        Console.WriteLine("Task added");
    }

    public void UpdateTaskStatus(string title, Status status)
    {
        var task = Tasks.FirstOrDefault(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (task != null)
        {
            task.Status = status;
            Console.WriteLine("Task updated");
        }
    }

    public void ListAllTasks()
    {
        Tasks.ForEach(t =>
        {
            Console.WriteLine($"Task: {t.Title}, {t.Status}");
        });
    }

    public void ListTaskByStatus(Status status)
    {
        Tasks.ForEach(t =>
        {
            if (t.Status == status)
                Console.WriteLine($"Task: {t.Title}, {t.Status}");
        });
    }
}
