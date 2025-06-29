using System.Collections;

namespace System.IO.IsolatedStorage;

internal sealed class TwoLevelFileEnumerator : IEnumerator
{
	private string m_Root;

	private TwoPaths m_Current;

	private bool m_fReset;

	private string[] m_RootDir;

	private int m_nRootDir;

	private string[] m_SubDir;

	private int m_nSubDir;

	public object Current
	{
		get
		{
			if (m_fReset)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
			}
			if (m_nRootDir >= m_RootDir.Length)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
			}
			return m_Current;
		}
	}

	public TwoLevelFileEnumerator(string root)
	{
		m_Root = root;
		Reset();
	}

	public bool MoveNext()
	{
		lock (this)
		{
			if (m_fReset)
			{
				m_fReset = false;
				return AdvanceRootDir();
			}
			if (m_RootDir.Length == 0)
			{
				return false;
			}
			m_nSubDir++;
			if (m_nSubDir >= m_SubDir.Length)
			{
				m_nSubDir = m_SubDir.Length;
				return AdvanceRootDir();
			}
			UpdateCurrent();
		}
		return true;
	}

	private bool AdvanceRootDir()
	{
		m_nRootDir++;
		if (m_nRootDir >= m_RootDir.Length)
		{
			m_nRootDir = m_RootDir.Length;
			return false;
		}
		m_SubDir = Directory.GetDirectories(m_RootDir[m_nRootDir]);
		if (m_SubDir.Length == 0)
		{
			return AdvanceRootDir();
		}
		m_nSubDir = 0;
		UpdateCurrent();
		return true;
	}

	private void UpdateCurrent()
	{
		m_Current.Path1 = Path.GetFileName(m_RootDir[m_nRootDir]);
		m_Current.Path2 = Path.GetFileName(m_SubDir[m_nSubDir]);
	}

	public void Reset()
	{
		m_RootDir = null;
		m_nRootDir = -1;
		m_SubDir = null;
		m_nSubDir = -1;
		m_Current = new TwoPaths();
		m_fReset = true;
		m_RootDir = Directory.GetDirectories(m_Root);
	}
}
