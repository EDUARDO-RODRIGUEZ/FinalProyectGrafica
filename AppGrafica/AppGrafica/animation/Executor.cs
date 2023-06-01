using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppGrafica.animation
{
    public abstract class Executor
    {
        protected long start;
        protected long interval;
        protected long duracion;
        protected Timer timer;
        protected long finalized;

        public Executor(long interval, long start, long duracion)
        {
            this.start = start;
            this.interval = interval;
            this.duracion = duracion;
            finalized = 0;
        }

        public void execute()
        {
            timer = new Timer(method, null, start, interval);
        }

        public void method(object state)
        {
            handle(state);
            finalized += interval;
            if (finalized >= duracion)
            {
                timer.Dispose();
            }
        }

        public abstract void handle(object state);

    }
}
