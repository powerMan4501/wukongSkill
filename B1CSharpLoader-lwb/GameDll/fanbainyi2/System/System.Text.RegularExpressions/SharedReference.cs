using System.Threading;

namespace System.Text.RegularExpressions;

internal sealed class SharedReference
{
	private WeakReference _ref = new WeakReference(null);

	private int _locked;

	internal object Get()
	{
		if (Interlocked.Exchange(ref _locked, 1) == 0)
		{
			object target = _ref.Target;
			_locked = 0;
			return target;
		}
		return null;
	}

	internal void Cache(object obj)
	{
		if (Interlocked.Exchange(ref _locked, 1) == 0)
		{
			_ref.Target = obj;
			_locked = 0;
		}
	}
}
