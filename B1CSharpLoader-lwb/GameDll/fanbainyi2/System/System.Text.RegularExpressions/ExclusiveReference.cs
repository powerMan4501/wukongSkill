using System.Threading;

namespace System.Text.RegularExpressions;

internal sealed class ExclusiveReference
{
	private RegexRunner _ref;

	private object _obj;

	private int _locked;

	internal object Get()
	{
		if (Interlocked.Exchange(ref _locked, 1) == 0)
		{
			object obj = _ref;
			if (obj == null)
			{
				_locked = 0;
				return null;
			}
			_obj = obj;
			return obj;
		}
		return null;
	}

	internal void Release(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (_obj == obj)
		{
			_obj = null;
			_locked = 0;
		}
		else if (_obj == null && Interlocked.Exchange(ref _locked, 1) == 0)
		{
			if (_ref == null)
			{
				_ref = (RegexRunner)obj;
			}
			_locked = 0;
		}
	}
}
