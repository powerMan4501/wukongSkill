using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class UnmanagedMarshal
{
	internal UnmanagedType m_unmanagedType;

	internal Guid m_guid;

	internal int m_numElem;

	internal UnmanagedType m_baseType;

	public UnmanagedType GetUnmanagedType => m_unmanagedType;

	public Guid IIDGuid
	{
		get
		{
			if (m_unmanagedType == UnmanagedType.CustomMarshaler)
			{
				return m_guid;
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_NotACustomMarshaler"));
		}
	}

	public int ElementCount
	{
		get
		{
			if (m_unmanagedType != UnmanagedType.ByValArray && m_unmanagedType != UnmanagedType.ByValTStr)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_NoUnmanagedElementCount"));
			}
			return m_numElem;
		}
	}

	public UnmanagedType BaseType
	{
		get
		{
			if (m_unmanagedType != UnmanagedType.LPArray && m_unmanagedType != UnmanagedType.SafeArray)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_NoNestedMarshal"));
			}
			return m_baseType;
		}
	}

	public static UnmanagedMarshal DefineUnmanagedMarshal(UnmanagedType unmanagedType)
	{
		if (unmanagedType == UnmanagedType.ByValTStr || unmanagedType == UnmanagedType.SafeArray || unmanagedType == UnmanagedType.CustomMarshaler || unmanagedType == UnmanagedType.ByValArray || unmanagedType == UnmanagedType.LPArray)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotASimpleNativeType"));
		}
		return new UnmanagedMarshal(unmanagedType, Guid.Empty, 0, (UnmanagedType)0);
	}

	public static UnmanagedMarshal DefineByValTStr(int elemCount)
	{
		return new UnmanagedMarshal(UnmanagedType.ByValTStr, Guid.Empty, elemCount, (UnmanagedType)0);
	}

	public static UnmanagedMarshal DefineSafeArray(UnmanagedType elemType)
	{
		return new UnmanagedMarshal(UnmanagedType.SafeArray, Guid.Empty, 0, elemType);
	}

	public static UnmanagedMarshal DefineByValArray(int elemCount)
	{
		return new UnmanagedMarshal(UnmanagedType.ByValArray, Guid.Empty, elemCount, (UnmanagedType)0);
	}

	public static UnmanagedMarshal DefineLPArray(UnmanagedType elemType)
	{
		return new UnmanagedMarshal(UnmanagedType.LPArray, Guid.Empty, 0, elemType);
	}

	private UnmanagedMarshal(UnmanagedType unmanagedType, Guid guid, int numElem, UnmanagedType type)
	{
		m_unmanagedType = unmanagedType;
		m_guid = guid;
		m_numElem = numElem;
		m_baseType = type;
	}

	internal byte[] InternalGetBytes()
	{
		if (m_unmanagedType == UnmanagedType.SafeArray || m_unmanagedType == UnmanagedType.LPArray)
		{
			int num = 2;
			byte[] array = new byte[num];
			array[0] = (byte)m_unmanagedType;
			array[1] = (byte)m_baseType;
			return array;
		}
		if (m_unmanagedType == UnmanagedType.ByValArray || m_unmanagedType == UnmanagedType.ByValTStr)
		{
			int num2 = 0;
			int num3 = ((m_numElem <= 127) ? 1 : ((m_numElem > 16383) ? 4 : 2));
			num3++;
			byte[] array = new byte[num3];
			array[num2++] = (byte)m_unmanagedType;
			if (m_numElem <= 127)
			{
				array[num2++] = (byte)(m_numElem & 0xFF);
			}
			else if (m_numElem <= 16383)
			{
				array[num2++] = (byte)((m_numElem >> 8) | 0x80);
				array[num2++] = (byte)(m_numElem & 0xFF);
			}
			else if (m_numElem <= 536870911)
			{
				array[num2++] = (byte)((m_numElem >> 24) | 0xC0);
				array[num2++] = (byte)((m_numElem >> 16) & 0xFF);
				array[num2++] = (byte)((m_numElem >> 8) & 0xFF);
				array[num2++] = (byte)(m_numElem & 0xFF);
			}
			return array;
		}
		return new byte[1] { (byte)m_unmanagedType };
	}
}
