using System.Security;

namespace System.Reflection;

[Serializable]
internal struct ConstArray
{
	internal int m_length;

	internal IntPtr m_constArray;

	public IntPtr Signature => m_constArray;

	public int Length => m_length;

	public unsafe byte this[int index]
	{
		[SecuritySafeCritical]
		get
		{
			if (index < 0 || index >= m_length)
			{
				throw new IndexOutOfRangeException();
			}
			return ((byte*)m_constArray.ToPointer())[index];
		}
	}
}
