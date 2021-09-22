using DevIncubatorCore.InterfacesAbstractClasses.Component;

namespace DevIncubatorCore.InterfacesAbstractClasses
{
    internal class PrinterExecuter : ITask
    {
        public void RunTask()
        {
            Printer inkjetPrinter = new InkjetPrinter("Samsung", true);
            Printer laserPrinter = new LaserPrinter("Canon", false);

            inkjetPrinter.Start("Let`s print this text");
            laserPrinter.Start("Let`s print text with colors");
        }
    }
}