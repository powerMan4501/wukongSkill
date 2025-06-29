namespace System.Timers;

public class ElapsedEventArgs : EventArgs
{
	private DateTime signalTime;

	public DateTime SignalTime => signalTime;

	internal ElapsedEventArgs(int low, int high)
	{
		long fileTime = ((long)high << 32) | (low & 0xFFFFFFFFu);
		signalTime = DateTime.FromFileTime(fileTime);
	}
}
