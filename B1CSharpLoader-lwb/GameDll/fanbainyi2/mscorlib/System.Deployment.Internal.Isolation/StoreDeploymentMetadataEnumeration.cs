using System.Collections;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreDeploymentMetadataEnumeration : IEnumerator
{
	private IEnumSTORE_DEPLOYMENT_METADATA _enum;

	private bool _fValid;

	private IDefinitionAppId _current;

	object IEnumerator.Current => GetCurrent();

	public IDefinitionAppId Current => GetCurrent();

	public StoreDeploymentMetadataEnumeration(IEnumSTORE_DEPLOYMENT_METADATA pI)
	{
		_enum = pI;
	}

	private IDefinitionAppId GetCurrent()
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
		IDefinitionAppId[] array = new IDefinitionAppId[1];
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
