using System.Threading.Tasks;
using JobCore.Entity;

namespace JobCore.Contract
{
    internal interface IJobStageRunnerService
    {
        Task<JobStageResult> RunJobStage(JobStageConfig config);
    }
}