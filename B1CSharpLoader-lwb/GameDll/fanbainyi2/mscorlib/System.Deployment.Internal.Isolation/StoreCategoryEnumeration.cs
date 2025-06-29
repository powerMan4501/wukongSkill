using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreCategoryEnumeration : IEnumerator
{
	private IEnumSTORE_CATEGORY _enum;

	private bool _fValid;

	private STORE_CATEGORY _current;

	object IEnumerator.Current => GetCurrent();

	public STORE_CATEGORY Current => GetCurrent();

	public StoreCategoryEnumeration(IEnumSTORE_CATEGORY pI)
	{
		_enum = pI;
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	private STORE_CATEGORY GetCurrent()
	{
		if (!_fValid)
		{
			throw new InvalidOperationException();
		}
		return _current;
	}

	[SecuritySafeCritical]
	public bool MoveNext()
	{
		STORE_CATEGORY[] array = new STORE_CATEGORY[1];
		uint num = _enum.Next(1u, array);
		if (num == 1)
		{
			_current = array[0];
		}
		return _fValid = num == 1;
	}

	[SecuritySafeCritical]
	public void Reset()
	{
		_fValid = false;
		_enum.Reset();
	}
}
