using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreCategoryInstanceEnumeration : IEnumerator
{
	private IEnumSTORE_CATEGORY_INSTANCE _enum;

	private bool _fValid;

	private STORE_CATEGORY_INSTANCE _current;

	object IEnumerator.Current => GetCurrent();

	public STORE_CATEGORY_INSTANCE Current => GetCurrent();

	public StoreCategoryInstanceEnumeration(IEnumSTORE_CATEGORY_INSTANCE pI)
	{
		_enum = pI;
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	private STORE_CATEGORY_INSTANCE GetCurrent()
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
		STORE_CATEGORY_INSTANCE[] array = new STORE_CATEGORY_INSTANCE[1];
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
