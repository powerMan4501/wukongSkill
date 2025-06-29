using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

public sealed class X500DistinguishedName : AsnEncodedData
{
	private string m_distinguishedName;

	public string Name
	{
		get
		{
			if (m_distinguishedName == null)
			{
				m_distinguishedName = Decode(X500DistinguishedNameFlags.Reversed);
			}
			return m_distinguishedName;
		}
	}

	internal X500DistinguishedName(CAPIBase.CRYPTOAPI_BLOB encodedDistinguishedNameBlob)
		: base(new Oid(), encodedDistinguishedNameBlob)
	{
	}

	public X500DistinguishedName(byte[] encodedDistinguishedName)
		: base(new Oid(), encodedDistinguishedName)
	{
	}

	public X500DistinguishedName(AsnEncodedData encodedDistinguishedName)
		: base(encodedDistinguishedName)
	{
	}

	public X500DistinguishedName(X500DistinguishedName distinguishedName)
		: base(distinguishedName)
	{
		m_distinguishedName = distinguishedName.Name;
	}

	public X500DistinguishedName(string distinguishedName)
		: this(distinguishedName, X500DistinguishedNameFlags.Reversed)
	{
	}

	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag)
		: base(new Oid(), Encode(distinguishedName, flag))
	{
		m_distinguishedName = distinguishedName;
	}

	public unsafe string Decode(X500DistinguishedNameFlags flag)
	{
		uint dwStrType = 3 | MapNameToStrFlag(flag);
		byte[] rawData = m_rawData;
		fixed (byte* value = rawData)
		{
			CAPIBase.CRYPTOAPI_BLOB cRYPTOAPI_BLOB = default(CAPIBase.CRYPTOAPI_BLOB);
			IntPtr pName = new IntPtr(&cRYPTOAPI_BLOB);
			cRYPTOAPI_BLOB.cbData = (uint)rawData.Length;
			cRYPTOAPI_BLOB.pbData = new IntPtr(value);
			uint num = CAPISafe.CertNameToStrW(65537u, pName, dwStrType, SafeLocalAllocHandle.InvalidHandle, 0u);
			if (num == 0)
			{
				throw new CryptographicException(-2146762476);
			}
			using SafeLocalAllocHandle safeLocalAllocHandle = CAPI.LocalAlloc(64u, new IntPtr(2 * num));
			if (CAPISafe.CertNameToStrW(65537u, pName, dwStrType, safeLocalAllocHandle, num) == 0)
			{
				throw new CryptographicException(-2146762476);
			}
			return Marshal.PtrToStringUni(safeLocalAllocHandle.DangerousGetHandle());
		}
	}

	public override string Format(bool multiLine)
	{
		if (m_rawData == null || m_rawData.Length == 0)
		{
			return string.Empty;
		}
		return CAPI.CryptFormatObject(1u, multiLine ? 1u : 0u, new IntPtr(7L), m_rawData);
	}

	private unsafe static byte[] Encode(string distinguishedName, X500DistinguishedNameFlags flag)
	{
		if (distinguishedName == null)
		{
			throw new ArgumentNullException("distinguishedName");
		}
		uint pcbEncoded = 0u;
		uint dwStrType = 3 | MapNameToStrFlag(flag);
		if (!CAPISafe.CertStrToNameW(65537u, distinguishedName, dwStrType, IntPtr.Zero, IntPtr.Zero, ref pcbEncoded, IntPtr.Zero))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		byte[] array = new byte[pcbEncoded];
		fixed (byte* value = array)
		{
			if (!CAPISafe.CertStrToNameW(65537u, distinguishedName, dwStrType, IntPtr.Zero, new IntPtr(value), ref pcbEncoded, IntPtr.Zero))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		return array;
	}

	private static uint MapNameToStrFlag(X500DistinguishedNameFlags flag)
	{
		uint num = 29169u;
		if (((uint)flag & ~num) != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("Arg_EnumIllegalVal"), new object[1] { "flag" }));
		}
		uint num2 = 0u;
		if (flag != X500DistinguishedNameFlags.None)
		{
			if ((flag & X500DistinguishedNameFlags.Reversed) == X500DistinguishedNameFlags.Reversed)
			{
				num2 |= 0x2000000;
			}
			if ((flag & X500DistinguishedNameFlags.UseSemicolons) == X500DistinguishedNameFlags.UseSemicolons)
			{
				num2 |= 0x40000000;
			}
			else if ((flag & X500DistinguishedNameFlags.UseCommas) == X500DistinguishedNameFlags.UseCommas)
			{
				num2 |= 0x4000000;
			}
			else if ((flag & X500DistinguishedNameFlags.UseNewLines) == X500DistinguishedNameFlags.UseNewLines)
			{
				num2 |= 0x8000000;
			}
			if ((flag & X500DistinguishedNameFlags.DoNotUsePlusSign) == X500DistinguishedNameFlags.DoNotUsePlusSign)
			{
				num2 |= 0x20000000;
			}
			if ((flag & X500DistinguishedNameFlags.DoNotUseQuotes) == X500DistinguishedNameFlags.DoNotUseQuotes)
			{
				num2 |= 0x10000000;
			}
			if ((flag & X500DistinguishedNameFlags.ForceUTF8Encoding) == X500DistinguishedNameFlags.ForceUTF8Encoding)
			{
				num2 |= 0x80000;
			}
			if ((flag & X500DistinguishedNameFlags.UseUTF8Encoding) == X500DistinguishedNameFlags.UseUTF8Encoding)
			{
				num2 |= 0x40000;
			}
			else if ((flag & X500DistinguishedNameFlags.UseT61Encoding) == X500DistinguishedNameFlags.UseT61Encoding)
			{
				num2 |= 0x20000;
			}
		}
		return num2;
	}
}
