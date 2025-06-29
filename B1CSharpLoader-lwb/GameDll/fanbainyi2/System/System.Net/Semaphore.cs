using System.Threading;

namespace System.Net;

internal sealed class Semaphore : WaitHandle
{
	internal Semaphore(int initialCount, int maxCount)
	{
		lock (this)
		{
			Handle = UnsafeNclNativeMethods.CreateSemaphore(IntPtr.Zero, initialCount, maxCount, IntPtr.Zero);
		}
	}

	internal bool ReleaseSemaphore()
	{
		return UnsafeNclNativeMethods.ReleaseSemaphore(Handle, 1, IntPtr.Zero);
	}
}
