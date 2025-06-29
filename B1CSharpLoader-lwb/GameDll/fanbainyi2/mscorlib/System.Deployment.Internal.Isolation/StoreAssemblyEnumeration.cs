using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreAssemblyEnumeration : IEnumerator
{
	private IEnumSTORE_ASSEMBLY _enum;

	private bool _fValid;

	private STORE_ASSEMBLY _current;

	object IEnumerator.Current => GetCurrent();

	public STORE_ASSEMBLY Current => GetCurrent();

	public StoreAssemblyEnumeration(IEnumSTORE_ASSEMBLY pI)
	{
		_enum = pI;
	}

	private STORE_ASSEMBLY GetCurrent()
	{
		if (!_fValid)
		{
			throw new InvalidOperationException();
		}
		return _current;
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	[SecuritySafeCritical]
	public bool MoveNext()
	{
		STORE_ASSEMBLY[] array = new STORE_ASSEMBLY[1];
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
