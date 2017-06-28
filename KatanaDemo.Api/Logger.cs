using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatanaDemo.Api
{
    public class Logger
    {
        private Func<IDictionary<string, object>, Task> _next;

        public Task Invoke(IDictionary<string, object> environment)
        {
            return null;
        }

        public Logger(Func<IDictionary<string, object>, Task> next)
        {
            _next = next;
        }
    }
}