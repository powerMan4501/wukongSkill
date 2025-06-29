using System.Collections.Generic;

namespace b1;

public static class FFrameInfoPool
{
	private static readonly Stack<FFrameInfo> _available = new Stack<FFrameInfo>();

	public static FFrameInfo New()
	{
		if (_available.Count > 0)
		{
			return _available.Pop();
		}
		return FFrameInfo.CreateByPool();
	}

	public static void Return(FFrameInfo FrameInfo)
	{
		FrameInfo.Clean();
		_available.Push(FrameInfo);
	}
}
