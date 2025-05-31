using ToDo;

TaskManager manager = new TaskManager();

manager.AddTask(new ToDo.Task("Task A", 1, "Eat", new DateTime(2025, 6, 3)));
manager.AddTask(new ToDo.Task("Task B", 2, "Sleep", new DateTime(2025, 6, 1)));
manager.AddTask(new ToDo.Task("Task C", 3, "Study", new DateTime(2025, 6, 5)));

manager.ShowAllLists();

manager.ChangeStatusToInProgress(2);
manager.ShowAllLists();

manager.ChangeStatusToCompleted();
manager.ShowAllLists();
