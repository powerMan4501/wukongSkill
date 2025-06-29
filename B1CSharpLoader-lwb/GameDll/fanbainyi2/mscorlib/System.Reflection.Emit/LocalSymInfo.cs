using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit;

internal class LocalSymInfo
{
	internal string[] m_strName;

	internal byte[][] m_ubSignature;

	internal int[] m_iLocalSlot;

	internal int[] m_iStartOffset;

	internal int[] m_iEndOffset;

	internal int m_iLocalSymCount;

	internal string[] m_namespace;

	internal int m_iNameSpaceCount;

	internal const int InitialSize = 16;

	internal LocalSymInfo()
	{
		m_iLocalSymCount = 0;
		m_iNameSpaceCount = 0;
	}

	private void EnsureCapacityNamespace()
	{
		if (m_iNameSpaceCount == 0)
		{
			m_namespace = new string[16];
		}
		else if (m_iNameSpaceCount == m_namespace.Length)
		{
			string[] array = new string[checked(m_iNameSpaceCount * 2)];
			Array.Copy(m_namespace, array, m_iNameSpaceCount);
			m_namespace = array;
		}
	}

	private void EnsureCapacity()
	{
		if (m_iLocalSymCount == 0)
		{
			m_strName = new string[16];
			m_ubSignature = new byte[16][];
			m_iLocalSlot = new int[16];
			m_iStartOffset = new int[16];
			m_iEndOffset = new int[16];
		}
		else if (m_iLocalSymCount == m_strName.Length)
		{
			int num = checked(m_iLocalSymCount * 2);
			int[] array = new int[num];
			Array.Copy(m_iLocalSlot, array, m_iLocalSymCount);
			m_iLocalSlot = array;
			array = new int[num];
			Array.Copy(m_iStartOffset, array, m_iLocalSymCount);
			m_iStartOffset = array;
			array = new int[num];
			Array.Copy(m_iEndOffset, array, m_iLocalSymCount);
			m_iEndOffset = array;
			string[] array2 = new string[num];
			Array.Copy(m_strName, array2, m_iLocalSymCount);
			m_strName = array2;
			byte[][] array3 = new byte[num][];
			Array.Copy(m_ubSignature, array3, m_iLocalSymCount);
			m_ubSignature = array3;
		}
	}

	internal void AddLocalSymInfo(string strName, byte[] signature, int slot, int startOffset, int endOffset)
	{
		EnsureCapacity();
		m_iStartOffset[m_iLocalSymCount] = startOffset;
		m_iEndOffset[m_iLocalSymCount] = endOffset;
		m_iLocalSlot[m_iLocalSymCount] = slot;
		m_strName[m_iLocalSymCount] = strName;
		m_ubSignature[m_iLocalSymCount] = signature;
		checked
		{
			m_iLocalSymCount++;
		}
	}

	internal void AddUsingNamespace(string strNamespace)
	{
		EnsureCapacityNamespace();
		m_namespace[m_iNameSpaceCount] = strNamespace;
		checked
		{
			m_iNameSpaceCount++;
		}
	}

	internal virtual void EmitLocalSymInfo(ISymbolWriter symWriter)
	{
		for (int i = 0; i < m_iLocalSymCount; i++)
		{
			symWriter.DefineLocalVariable(m_strName[i], FieldAttributes.PrivateScope, m_ubSignature[i], SymAddressKind.ILOffset, m_iLocalSlot[i], 0, 0, m_iStartOffset[i], m_iEndOffset[i]);
		}
		for (int i = 0; i < m_iNameSpaceCount; i++)
		{
			symWriter.UsingNamespace(m_namespace[i]);
		}
	}
}
