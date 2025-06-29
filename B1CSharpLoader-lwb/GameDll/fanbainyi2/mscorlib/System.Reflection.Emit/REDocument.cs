using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit;

internal sealed class REDocument
{
	private int[] m_iOffsets;

	private int[] m_iLines;

	private int[] m_iColumns;

	private int[] m_iEndLines;

	private int[] m_iEndColumns;

	internal ISymbolDocumentWriter m_document;

	private int m_iLineNumberCount;

	private const int InitialSize = 16;

	internal REDocument(ISymbolDocumentWriter document)
	{
		m_iLineNumberCount = 0;
		m_document = document;
	}

	internal void AddLineNumberInfo(ISymbolDocumentWriter document, int iOffset, int iStartLine, int iStartColumn, int iEndLine, int iEndColumn)
	{
		EnsureCapacity();
		m_iOffsets[m_iLineNumberCount] = iOffset;
		m_iLines[m_iLineNumberCount] = iStartLine;
		m_iColumns[m_iLineNumberCount] = iStartColumn;
		m_iEndLines[m_iLineNumberCount] = iEndLine;
		m_iEndColumns[m_iLineNumberCount] = iEndColumn;
		checked
		{
			m_iLineNumberCount++;
		}
	}

	private void EnsureCapacity()
	{
		if (m_iLineNumberCount == 0)
		{
			m_iOffsets = new int[16];
			m_iLines = new int[16];
			m_iColumns = new int[16];
			m_iEndLines = new int[16];
			m_iEndColumns = new int[16];
		}
		else if (m_iLineNumberCount == m_iOffsets.Length)
		{
			int num = checked(m_iLineNumberCount * 2);
			int[] array = new int[num];
			Array.Copy(m_iOffsets, array, m_iLineNumberCount);
			m_iOffsets = array;
			array = new int[num];
			Array.Copy(m_iLines, array, m_iLineNumberCount);
			m_iLines = array;
			array = new int[num];
			Array.Copy(m_iColumns, array, m_iLineNumberCount);
			m_iColumns = array;
			array = new int[num];
			Array.Copy(m_iEndLines, array, m_iLineNumberCount);
			m_iEndLines = array;
			array = new int[num];
			Array.Copy(m_iEndColumns, array, m_iLineNumberCount);
			m_iEndColumns = array;
		}
	}

	internal void EmitLineNumberInfo(ISymbolWriter symWriter)
	{
		if (m_iLineNumberCount != 0)
		{
			int[] array = new int[m_iLineNumberCount];
			Array.Copy(m_iOffsets, array, m_iLineNumberCount);
			int[] array2 = new int[m_iLineNumberCount];
			Array.Copy(m_iLines, array2, m_iLineNumberCount);
			int[] array3 = new int[m_iLineNumberCount];
			Array.Copy(m_iColumns, array3, m_iLineNumberCount);
			int[] array4 = new int[m_iLineNumberCount];
			Array.Copy(m_iEndLines, array4, m_iLineNumberCount);
			int[] array5 = new int[m_iLineNumberCount];
			Array.Copy(m_iEndColumns, array5, m_iLineNumberCount);
			symWriter.DefineSequencePoints(m_document, array, array2, array3, array4, array5);
		}
	}
}
