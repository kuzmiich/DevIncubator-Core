using DevIncubatorBase.Controllers;
using DevIncubatorBase.Models;
using DevIncubatorBase.Models.Module.Task;
using DevIncubatorBase.Views;
using System.Collections.Generic;
using DevIncubatorBase.InputServices;
using DevIncubatorBase.Views.ConsoleOutput;
using DevIncubatorBase.InputServices.ConsoleInput;

namespace DevIncubatorBase
{
    public static class Program
    {
        private static readonly IInputService _inputService = InputService.GetInstance();
        private static readonly IOutputService _outputService = OutputService.GetInstance();
        private static MainController MainController { get; set; }

        public static void Main()
        {
            List<ITaskResult> tasks = new()
            {
                new TaskDa(),
            };
            MainController = new MainController
            (
                tasks,
                _inputService,
                _outputService
            );
            MainController.StartController();
        }
    }
}