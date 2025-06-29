using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit;

internal sealed class LineNumberInfo
{
	private int m_DocumentCount;

	private REDocument[] m_Documents;

	private const int InitialSize = 16;

	private int m_iLastFound;

	internal LineNumberInfo()
	{
		m_DocumentCount = 0;
		m_iLastFound = 0;
	}

	internal void AddLineNumberInfo(ISymbolDocumentWriter document, int iOffset, int iStartLine, int iStartColumn, int iEndLine, int iEndColumn)
	{
		int num = FindDocument(document);
		m_Documents[num].AddLineNumberInfo(document, iOffset, iStartLine, iStartColumn, iEndLine, iEndColumn);
	}

	private int FindDocument(ISymbolDocumentWriter document)
	{
		if (m_iLastFound < m_DocumentCount && m_Documents[m_iLastFound].m_document == document)
		{
			return m_iLastFound;
		}
		for (int i = 0; i < m_DocumentCount; i++)
		{
			if (m_Documents[i].m_document == document)
			{
				m_iLastFound = i;
				return m_iLastFound;
			}
		}
		EnsureCapacity();
		m_iLastFound = m_DocumentCount;
		m_Documents[m_iLastFound] = new REDocument(document);
		checked
		{
			m_DocumentCount++;
			return m_iLastFound;
		}
	}

	private void EnsureCapacity()
	{
		if (m_DocumentCount == 0)
		{
			m_Documents = new REDocument[16];
		}
		else if (m_DocumentCount == m_Documents.Length)
		{
			REDocument[] array = new REDocument[m_DocumentCount * 2];
			Array.Copy(m_Documents, array, m_DocumentCount);
			m_Documents = array;
		}
	}

	internal void EmitLineNumberInfo(ISymbolWriter symWriter)
	{
		for (int i = 0; i < m_DocumentCount; i++)
		{
			m_Documents[i].EmitLineNumberInfo(symWriter);
		}
	}
}
