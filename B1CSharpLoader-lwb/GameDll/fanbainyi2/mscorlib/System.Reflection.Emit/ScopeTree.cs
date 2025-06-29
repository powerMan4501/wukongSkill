using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit;

internal sealed class ScopeTree
{
	internal int[] m_iOffsets;

	internal ScopeAction[] m_ScopeActions;

	internal int m_iCount;

	internal int m_iOpenScopeCount;

	internal const int InitialSize = 16;

	internal LocalSymInfo[] m_localSymInfos;

	internal ScopeTree()
	{
		m_iOpenScopeCount = 0;
		m_iCount = 0;
	}

	internal int GetCurrentActiveScopeIndex()
	{
		int num = 0;
		int num2 = m_iCount - 1;
		if (m_iCount == 0)
		{
			return -1;
		}
		while (num > 0 || m_ScopeActions[num2] == ScopeAction.Close)
		{
			num = ((m_ScopeActions[num2] != ScopeAction.Open) ? (num + 1) : (num - 1));
			num2--;
		}
		return num2;
	}

	internal void AddLocalSymInfoToCurrentScope(string strName, byte[] signature, int slot, int startOffset, int endOffset)
	{
		int currentActiveScopeIndex = GetCurrentActiveScopeIndex();
		if (m_localSymInfos[currentActiveScopeIndex] == null)
		{
			m_localSymInfos[currentActiveScopeIndex] = new LocalSymInfo();
		}
		m_localSymInfos[currentActiveScopeIndex].AddLocalSymInfo(strName, signature, slot, startOffset, endOffset);
	}

	internal void AddUsingNamespaceToCurrentScope(string strNamespace)
	{
		int currentActiveScopeIndex = GetCurrentActiveScopeIndex();
		if (m_localSymInfos[currentActiveScopeIndex] == null)
		{
			m_localSymInfos[currentActiveScopeIndex] = new LocalSymInfo();
		}
		m_localSymInfos[currentActiveScopeIndex].AddUsingNamespace(strNamespace);
	}

	internal void AddScopeInfo(ScopeAction sa, int iOffset)
	{
		if (sa == ScopeAction.Close && m_iOpenScopeCount <= 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_UnmatchingSymScope"));
		}
		EnsureCapacity();
		m_ScopeActions[m_iCount] = sa;
		m_iOffsets[m_iCount] = iOffset;
		m_localSymInfos[m_iCount] = null;
		checked
		{
			m_iCount++;
		}
		if (sa == ScopeAction.Open)
		{
			m_iOpenScopeCount++;
		}
		else
		{
			m_iOpenScopeCount--;
		}
	}

	internal void EnsureCapacity()
	{
		if (m_iCount == 0)
		{
			m_iOffsets = new int[16];
			m_ScopeActions = new ScopeAction[16];
			m_localSymInfos = new LocalSymInfo[16];
		}
		else if (m_iCount == m_iOffsets.Length)
		{
			int num = checked(m_iCount * 2);
			int[] array = new int[num];
			Array.Copy(m_iOffsets, array, m_iCount);
			m_iOffsets = array;
			ScopeAction[] array2 = new ScopeAction[num];
			Array.Copy(m_ScopeActions, array2, m_iCount);
			m_ScopeActions = array2;
			LocalSymInfo[] array3 = new LocalSymInfo[num];
			Array.Copy(m_localSymInfos, array3, m_iCount);
			m_localSymInfos = array3;
		}
	}

	internal void EmitScopeTree(ISymbolWriter symWriter)
	{
		for (int i = 0; i < m_iCount; i++)
		{
			if (m_ScopeActions[i] == ScopeAction.Open)
			{
				symWriter.OpenScope(m_iOffsets[i]);
			}
			else
			{
				symWriter.CloseScope(m_iOffsets[i]);
			}
			if (m_localSymInfos[i] != null)
			{
				m_localSymInfos[i].EmitLocalSymInfo(symWriter);
			}
		}
	}
}
