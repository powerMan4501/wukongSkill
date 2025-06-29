using System;
using System.Collections.Generic;
using System.Threading;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FThreading
{
	private class AsyncCallback : IDisposable
	{
		private FSimpleDelegate callback;

		private bool disposed;

		private AutoResetEvent waitHandle = new AutoResetEvent(initialState: false);

		public EAsyncThreadType ThreadType { get; private set; }

		public bool IsCoreThread
		{
			get
			{
				EAsyncThreadType threadType = ThreadType;
				if ((uint)threadType <= 2u || threadType == EAsyncThreadType.GameThreadUnloadIgnore)
				{
					return true;
				}
				return false;
			}
		}

		public AsyncCallback(FSimpleDelegate callback, EAsyncThreadType threadType)
		{
			this.callback = callback;
			ThreadType = threadType;
		}

		public void Run()
		{
			if (!HotReload.IsUnloading)
			{
				callback();
			}
			if (!disposed)
			{
				try
				{
					waitHandle.Set();
				}
				catch
				{
				}
			}
			lock (callbacks)
			{
				callbacks.Remove(this);
			}
		}

		public void WaitForComplete()
		{
			WaitForComplete(-1);
		}

		public void WaitForComplete(int timeout)
		{
			if (!disposed)
			{
				try
				{
					waitHandle.WaitOne(timeout);
				}
				catch
				{
				}
				Dispose();
			}
		}

		public void Dispose()
		{
			if (!disposed)
			{
				disposed = true;
				try
				{
					waitHandle.Dispose();
				}
				catch
				{
				}
			}
		}
	}

	private static List<AsyncCallback> callbacks = new List<AsyncCallback>();

	public static bool IsInGameThread()
	{
		return Native_FThreading.IsInGameThread();
	}

	public static bool IsInSlateThread()
	{
		return Native_FThreading.IsInSlateThread();
	}

	public static bool IsInRenderingThread()
	{
		return Native_FThreading.IsInRenderingThread();
	}

	public static bool IsInParallelRenderingThread()
	{
		return Native_FThreading.IsInParallelRenderingThread();
	}

	public static bool IsInActualRenderingThread()
	{
		return Native_FThreading.IsInActualRenderingThread();
	}

	public static bool IsInAsyncLoadingThread()
	{
		return Native_FThreading.IsInAsyncLoadingThread();
	}

	public static bool IsInRHIThread()
	{
		return Native_FThreading.IsInRHIThread();
	}

	public static bool IsRenderingThreadGameThread()
	{
		return Native_FThreading.IsRenderingThreadGameThread();
	}

	public static void RunOnGameThread(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.GameThread, waitForComplete: true);
	}

	public static void RunOnGameThreadAsync(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.GameThread, waitForComplete: false);
	}

	public static void RunOnRHIThread(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.RHIThread, waitForComplete: true);
	}

	public static void RunOnRHIThreadAsync(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.RHIThread, waitForComplete: false);
	}

	public static void RunOnRenderingThread(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.RenderingThread, waitForComplete: true);
	}

	public static void RunOnRenderingThreadAsync(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.RenderingThread, waitForComplete: false);
	}

	internal static void RunOnAnyThread(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.AnyThread, waitForComplete: true);
	}

	internal static void RunOnAnyThreadAsync(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.AnyThread, waitForComplete: false);
	}

	internal static void RunUnloader(FSimpleDelegate func)
	{
		Run(func, EAsyncThreadType.GameThreadUnloadIgnore, waitForComplete: true);
	}

	private static void Run(FSimpleDelegate func, EAsyncThreadType threadType, bool waitForComplete)
	{
		switch (threadType)
		{
		case EAsyncThreadType.GameThread:
		case EAsyncThreadType.GameThreadUnloadIgnore:
			if (IsInGameThread())
			{
				func();
				return;
			}
			break;
		case EAsyncThreadType.RHIThread:
			if (IsInRHIThread())
			{
				func();
				return;
			}
			break;
		case EAsyncThreadType.RenderingThread:
			if (IsInRenderingThread())
			{
				func();
				return;
			}
			break;
		}
		if (!HotReload.IsUnloading)
		{
			AsyncCallback asyncCallback = new AsyncCallback(func, threadType);
			lock (callbacks)
			{
				callbacks.Add(asyncCallback);
			}
			Native_FAsync.AsyncTask(asyncCallback.Run, threadType);
			if (waitForComplete)
			{
				asyncCallback.WaitForComplete();
			}
			else
			{
				asyncCallback.Dispose();
			}
		}
	}

	public static void OnUnload()
	{
		lock (callbacks)
		{
			foreach (AsyncCallback callback in callbacks)
			{
				if (callback.ThreadType != EAsyncThreadType.GameThreadUnloadIgnore)
				{
					if (callback.IsCoreThread)
					{
						callback.WaitForComplete();
					}
					else
					{
						callback.Dispose();
					}
				}
			}
			callbacks.Clear();
		}
	}
}
