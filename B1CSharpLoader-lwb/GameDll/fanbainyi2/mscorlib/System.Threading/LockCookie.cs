using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(true)]
public struct LockCookie
{
	private int _dwFlags;

	private int _dwWriterSeqNum;

	private int _wReaderAndWriterLevel;

	private int _dwThreadID;

	public override int GetHashCode()
	{
		return _dwFlags + _dwWriterSeqNum + _wReaderAndWriterLevel + _dwThreadID;
	}

	public override bool Equals(object obj)
	{
		if (obj is LockCookie)
		{
			return Equals((LockCookie)obj);
		}
		return false;
	}

	public bool Equals(LockCookie obj)
	{
		if (obj._dwFlags == _dwFlags && obj._dwWriterSeqNum == _dwWriterSeqNum && obj._wReaderAndWriterLevel == _wReaderAndWriterLevel)
		{
			return obj._dwThreadID == _dwThreadID;
		}
		return false;
	}

	public static bool operator ==(LockCookie a, LockCookie b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(LockCookie a, LockCookie b)
	{
		return !(a == b);
	}
}
