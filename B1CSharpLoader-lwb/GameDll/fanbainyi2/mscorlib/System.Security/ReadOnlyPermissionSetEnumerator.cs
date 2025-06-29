using System.Collections;

namespace System.Security;

internal sealed class ReadOnlyPermissionSetEnumerator : IEnumerator
{
	private IEnumerator m_permissionSetEnumerator;

	public object Current
	{
		get
		{
			if (!(m_permissionSetEnumerator.Current is IPermission permission))
			{
				return null;
			}
			return permission.Copy();
		}
	}

	internal ReadOnlyPermissionSetEnumerator(IEnumerator permissionSetEnumerator)
	{
		m_permissionSetEnumerator = permissionSetEnumerator;
	}

	public bool MoveNext()
	{
		return m_permissionSetEnumerator.MoveNext();
	}

	public void Reset()
	{
		m_permissionSetEnumerator.Reset();
	}
}
