using DevIncubatorBase.GenerationService;

namespace DevIncubatorBase.Models
{
    public interface ITaskResult
    {
       public string GetTaskResult(Generator extractor);
    }
}