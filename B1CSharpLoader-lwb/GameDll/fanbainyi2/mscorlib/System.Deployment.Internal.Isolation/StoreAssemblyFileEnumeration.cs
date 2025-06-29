using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreAssemblyFileEnumeration : IEnumerator
{
	private IEnumSTORE_ASSEMBLY_FILE _enum;

	private bool _fValid;

	private STORE_ASSEMBLY_FILE _current;

	object IEnumerator.Current => GetCurrent();

	public STORE_ASSEMBLY_FILE Current => GetCurrent();

	public StoreAssemblyFileEnumeration(IEnumSTORE_ASSEMBLY_FILE pI)
	{
		_enum = pI;
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	private STORE_ASSEMBLY_FILE GetCurrent()
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
		STORE_ASSEMBLY_FILE[] array = new STORE_ASSEMBLY_FILE[1];
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
