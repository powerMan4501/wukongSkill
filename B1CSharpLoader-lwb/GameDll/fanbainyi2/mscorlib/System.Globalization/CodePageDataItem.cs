using System.Security;

namespace System.Globalization;

[Serializable]
internal class CodePageDataItem
{
	internal int m_dataIndex;

	internal int m_uiFamilyCodePage;

	internal string m_webName;

	internal string m_headerName;

	internal string m_bodyName;

	internal uint m_flags;

	public unsafe string WebName
	{
		[SecuritySafeCritical]
		get
		{
			if (m_webName == null)
			{
				m_webName = CreateString(EncodingTable.codePageDataPtr[m_dataIndex].Names, 0u);
			}
			return m_webName;
		}
	}

	public virtual int UIFamilyCodePage => m_uiFamilyCodePage;

	public unsafe string HeaderName
	{
		[SecuritySafeCritical]
		get
		{
			if (m_headerName == null)
			{
				m_headerName = CreateString(EncodingTable.codePageDataPtr[m_dataIndex].Names, 1u);
			}
			return m_headerName;
		}
	}

	public unsafe string BodyName
	{
		[SecuritySafeCritical]
		get
		{
			if (m_bodyName == null)
			{
				m_bodyName = CreateString(EncodingTable.codePageDataPtr[m_dataIndex].Names, 2u);
			}
			return m_bodyName;
		}
	}

	public uint Flags => m_flags;

	[SecurityCritical]
	internal unsafe CodePageDataItem(int dataIndex)
	{
		m_dataIndex = dataIndex;
		m_uiFamilyCodePage = EncodingTable.codePageDataPtr[dataIndex].uiFamilyCodePage;
		m_flags = EncodingTable.codePageDataPtr[dataIndex].flags;
	}

	[SecurityCritical]
	internal unsafe static string CreateString(sbyte* pStrings, uint index)
	{
		if (*pStrings == 124)
		{
			int num = 1;
			int num2 = 1;
			while (true)
			{
				sbyte b = pStrings[num2];
				if (b == 124 || b == 0)
				{
					if (index == 0)
					{
						return new string(pStrings, num, num2 - num);
					}
					index--;
					num = num2 + 1;
					if (b == 0)
					{
						break;
					}
				}
				num2++;
			}
			throw new ArgumentException("pStrings");
		}
		return new string(pStrings);
	}
}
