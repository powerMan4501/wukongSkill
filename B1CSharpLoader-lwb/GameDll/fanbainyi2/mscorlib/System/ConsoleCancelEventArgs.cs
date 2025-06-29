namespace System;

[Serializable]
public sealed class ConsoleCancelEventArgs : EventArgs
{
	private ConsoleSpecialKey _type;

	private bool _cancel;

	public bool Cancel
	{
		get
		{
			return _cancel;
		}
		set
		{
			_cancel = value;
		}
	}

	public ConsoleSpecialKey SpecialKey => _type;

	internal ConsoleCancelEventArgs(ConsoleSpecialKey type)
	{
		_type = type;
		_cancel = false;
	}
}
