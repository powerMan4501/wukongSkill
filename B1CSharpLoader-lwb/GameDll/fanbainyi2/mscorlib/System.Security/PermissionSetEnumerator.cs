using System.Collections;

namespace System.Security;

internal class PermissionSetEnumerator : IEnumerator
{
	private PermissionSetEnumeratorInternal enm;

	public object Current => enm.Current;

	public bool MoveNext()
	{
		return enm.MoveNext();
	}

	public void Reset()
	{
		enm.Reset();
	}

	internal PermissionSetEnumerator(PermissionSet permSet)
	{
		enm = new PermissionSetEnumeratorInternal(permSet);
	}
}
