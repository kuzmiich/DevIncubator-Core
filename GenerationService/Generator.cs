using System;
using System.Collections.Generic;
using DevIncubatorBase.InputService;
using DevIncubatorBase.Views;

namespace DevIncubatorBase.GenerationService
{
    public class Generator
    {
        private readonly Random _random;
        private readonly IOutputService _outputService;
        private readonly IInputService _inputService;

        public Generator(IOutputService outputService, IInputService inputService)
        {
            _outputService = outputService;
            _inputService = inputService;
            _random = new Random();
        }

        public bool GetNumber(out int number, string message)
        {
            _outputService.OutputMessage(message);
            return int.TryParse(_inputService.GetString(), out number);
        }
        public IEnumerable<double> GetRandomDoubleIEnumerable(int count)
        {
            var resArr = new double[count];
            const int MAX = 10, MIN = -10;
            for (var i = 0; i < count; i++)
            {
                resArr[i] = Math.Round(_random.NextDouble() * (MAX - MIN) + MIN, 2);
            }
            return resArr;
        }
        
    }
}
