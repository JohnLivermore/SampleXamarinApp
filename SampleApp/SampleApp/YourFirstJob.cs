using Shiny.Jobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp
{
    public class YourFirstJob : IJob
    {
        public YourFirstJob()
        {
        }

        public async Task<bool> Run(JobInfo jobInfo, CancellationToken cancelToken)
        {
            //await this.dependency.SomeAsyncMethod(id);

            return true; // this is for iOS - try not to lie about this - return true when you actually do receive new data from the remote method
        }
    }
}
