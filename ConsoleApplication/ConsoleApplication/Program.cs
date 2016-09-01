using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        // Debug me, but first follow the steps in the README.
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        { 
            Debugger.Break();

            // I can step into this method just fine.
            GitLinkTestLib.Test.SynchronousMethod();

            // Hmmm, can't step into this method. :(
            var task1 = GitLinkTestLib.Test.AsynchronousMethod();

            await task1;

            // This one I can step into just fine.
            var task2 = GitLinkTestLib.Test.TaskReturningSynchronousMethod();

            await task2;
        }
    }
}
