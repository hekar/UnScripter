using System.Collections.Generic;
using System.ComponentModel;

namespace UnScripterPlugin.Plugin.Job
{
    public class JobQueuer
    {
        private readonly Queue<Job> workers;

        public JobQueuer()
        {
            workers = new Queue<Job>();
        }

        public void Queue(Job worker)
        {
            workers.Enqueue(worker);
        }

        public BackgroundWorker RunNext()
        {
            return workers.Dequeue();
        }
    }
}
