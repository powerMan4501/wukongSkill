using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreDeploymentMetadataPropertyEnumeration : IEnumerator
{
	private IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY _enum;

	private bool _fValid;

	private StoreOperationMetadataProperty _current;

	object IEnumerator.Current => GetCurrent();

	public StoreOperationMetadataProperty Current => GetCurrent();

	public StoreDeploymentMetadataPropertyEnumeration(IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY pI)
	{
		_enum = pI;
	}

	private StoreOperationMetadataProperty GetCurrent()
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
		StoreOperationMetadataProperty[] array = new StoreOperationMetadataProperty[1];
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
