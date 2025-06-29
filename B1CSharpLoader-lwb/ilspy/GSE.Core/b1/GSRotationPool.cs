using System.Collections.Generic;

namespace b1;

public static class GSRotationPool
{
	private static readonly Stack<GSRotation> _available = new Stack<GSRotation>();

	public static GSRotation New()
	{
		if (_available.Count > 0)
		{
			return _available.Pop();
		}
		return GSRotation.CreateByPool();
	}

	public static void Return(GSRotation Rotation)
	{
		Rotation.SetValue(0f, 0f, 0f);
		_available.Push(Rotation);
	}
}
