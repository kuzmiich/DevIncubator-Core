using DevIncubatorBase.GenerationService;
using DevIncubatorBase.InputService;
using DevIncubatorBase.Models;
using DevIncubatorBase.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevIncubatorBase.Controllers
{
    public class MainController
    {
        public List<ITaskResult> Tasks { get; set; }
        public IInputService InputService { get; init; }
        public IOutputService OutputService { get; init; }
        public Generator Generator { get; init; }

        public MainController(List<ITaskResult> tasks, IInputService inputService, IOutputService outputService)
        {
            InputService = inputService;
            OutputService = outputService;
            Tasks = tasks;
            Generator = new Generator(outputService, inputService);
        }

        public void StartController()
        {
            while (true)
            {
                ShowTaskMenu();
                OutputService.OutputMessage("0 - Exit");
                if (!Generator.GetNumber(out int key, "Input number of your task: "))
                {
                    OutputService.OutputMessage("Error: Invalid task number input");
                    continue;
                }
                if (key == 0)
                {
                    break;
                }
                ITaskResult currentTask = GetTaskByIndex(key - 1);
                if (currentTask is not null)
                {
                    string taskResultString;
                    try
                    {
                        taskResultString = currentTask.GetTaskResult(Generator);
                    }
                    catch (Exception ex)
                    {
                        taskResultString = ex.Message;
                    }
                    OutputService.OutputMessage(taskResultString);
                }
                else
                {
                    OutputService.OutputMessage("Error: Wrong input!");
                }
            }
        }

        private ITaskResult GetTaskByIndex(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                return Tasks[index];
            }
            return null;

        }
        private void ShowTaskMenu()
        {
            var i = 1;
            foreach (var info in Tasks.OfType<ITaskInfo>())
            {
                ShowTaskInfo(info, i++);
            }
        }
        private void ShowTaskInfo(ITaskInfo taskInfo, int index)
        {
            OutputService.OutputMessage($"{index} - {taskInfo.GetInfo()}");
        }
    }
}
