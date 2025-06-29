using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Security.Principal;

[ComVisible(false)]
internal class IdentityReferenceEnumerator : IEnumerator<IdentityReference>, IDisposable, IEnumerator
{
	private int _Current;

	private readonly IdentityReferenceCollection _Collection;

	object IEnumerator.Current => _Collection.Identities[_Current];

	public IdentityReference Current => ((IEnumerator)this).Current as IdentityReference;

	internal IdentityReferenceEnumerator(IdentityReferenceCollection collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		_Collection = collection;
		_Current = -1;
	}

	public bool MoveNext()
	{
		_Current++;
		return _Current < _Collection.Count;
	}

	public void Reset()
	{
		_Current = -1;
	}

	public void Dispose()
	{
	}
}
