using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreSubcategoryEnumeration : IEnumerator
{
	private IEnumSTORE_CATEGORY_SUBCATEGORY _enum;

	private bool _fValid;

	private STORE_CATEGORY_SUBCATEGORY _current;

	object IEnumerator.Current => GetCurrent();

	public STORE_CATEGORY_SUBCATEGORY Current => GetCurrent();

	public StoreSubcategoryEnumeration(IEnumSTORE_CATEGORY_SUBCATEGORY pI)
	{
		_enum = pI;
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	private STORE_CATEGORY_SUBCATEGORY GetCurrent()
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
		STORE_CATEGORY_SUBCATEGORY[] array = new STORE_CATEGORY_SUBCATEGORY[1];
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
