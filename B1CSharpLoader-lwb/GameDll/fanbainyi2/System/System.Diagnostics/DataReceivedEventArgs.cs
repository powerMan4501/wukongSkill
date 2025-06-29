namespace System.Diagnostics;

public class DataReceivedEventArgs : EventArgs
{
	internal string _data;

	public string Data => _data;

	internal DataReceivedEventArgs(string data)
	{
		_data = data;
	}
}
