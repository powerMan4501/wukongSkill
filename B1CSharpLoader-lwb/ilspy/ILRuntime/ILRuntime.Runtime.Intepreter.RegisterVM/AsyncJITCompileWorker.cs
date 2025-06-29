using System;
using System.Collections.Generic;
using System.Threading;
using ILRuntime.CLR.Method;

namespace ILRuntime.Runtime.Intepreter.RegisterVM;

internal class AsyncJITCompileWorker
{
	private AutoResetEvent evt = new AutoResetEvent(initialState: false);

	private Queue<ILMethod> jobs = new Queue<ILMethod>();

	private bool exit;

	private Thread thread;

	public AsyncJITCompileWorker()
	{
		thread = new Thread(DoJob);
		thread.Name = "ILRuntime JIT Worker";
		thread.Start();
	}

	public void QueueCompileJob(ILMethod method)
	{
		if (exit)
		{
			throw new NotSupportedException("Already disposed");
		}
		lock (jobs)
		{
			jobs.Enqueue(method);
		}
		evt.Set();
	}

	public void Dispose()
	{
		exit = true;
		evt.Set();
	}

	private void DoJob()
	{
		while (!exit)
		{
			evt.WaitOne();
			while (jobs.Count > 0)
			{
				ILMethod iLMethod;
				lock (jobs)
				{
					iLMethod = jobs.Dequeue();
				}
				try
				{
					iLMethod.InitCodeBody(register: true);
				}
				catch (Exception arg)
				{
					Console.WriteLine($"Compile {iLMethod} failed\r\n{arg}");
				}
			}
		}
	}
}
