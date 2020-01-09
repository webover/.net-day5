using DependencyInversionWorkerAfter.Contracts;

namespace DependencyInversionWorkerAfter
{
    public class Manager
    {
        private readonly IWorker worker;
        public Manager(IWorker worker)
        {
            this.worker = worker;
        }

        public void Manage()
        {
            this.worker.Work();
        }
    }
}
