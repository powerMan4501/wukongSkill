using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class KeySizes
{
	private int m_minSize;

	private int m_maxSize;

	private int m_skipSize;

	public int MinSize => m_minSize;

	public int MaxSize => m_maxSize;

	public int SkipSize => m_skipSize;

	public KeySizes(int minSize, int maxSize, int skipSize)
	{
		m_minSize = minSize;
		m_maxSize = maxSize;
		m_skipSize = skipSize;
	}
}
