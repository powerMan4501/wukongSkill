using System.Collections.Generic;

namespace b1;

public static class GSLocationPool
{
	private static readonly Stack<GSLocation> _available = new Stack<GSLocation>();

	public static GSLocation New()
	{
		if (_available.Count > 0)
		{
			return _available.Pop();
		}
		return GSLocation.CreateByPool();
	}

	public static void Return(GSLocation Location)
	{
		Location.SetValue(0f, 0f, 0f);
		_available.Push(Location);
	}
}
