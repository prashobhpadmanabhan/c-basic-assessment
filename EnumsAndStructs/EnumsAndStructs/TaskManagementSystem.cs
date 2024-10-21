namespace EnumsAndStructs
{
    public class TaskManagementSystem
    {
        public enum TaskPriority
        {
            Low,
            Medium,
            High
        }

        public enum TaskStatus
        {
            New,
            InProgress,
            Complete
        }

        public struct TaskDuration
        {
            public int minutes;
            public int hours;
        }

    }
}