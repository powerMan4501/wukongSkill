using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

internal sealed class SafeCertSelectCritera : SafeHandleZeroOrMinusOneIsInvalid
{
	private const string szOID_PKIX_KP_CLIENT_AUTH = "1.3.6.1.5.5.7.3.2";

	private const int CERT_SELECT_BY_ENHKEY_USAGE = 1;

	private const int CERT_SELECT_BY_KEY_USAGE = 2;

	private const byte CERT_DIGITAL_SIGNATURE_KEY_USAGE = 128;

	private const int criteriaCount = 2;

	private List<IntPtr> unmanagedMemoryList;

	internal int Count => 2;

	private IntPtr AllocBuffer(int size)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(size);
		unmanagedMemoryList.Add(intPtr);
		return intPtr;
	}

	private IntPtr AllocString(string str)
	{
		IntPtr intPtr = Marshal.StringToHGlobalAnsi(str);
		unmanagedMemoryList.Add(intPtr);
		return intPtr;
	}

	internal SafeCertSelectCritera()
		: base(ownsHandle: true)
	{
		UnsafeNclNativeMethods.NativePKI.CERT_SELECT_CRITERIA cERT_SELECT_CRITERIA = default(UnsafeNclNativeMethods.NativePKI.CERT_SELECT_CRITERIA);
		unmanagedMemoryList = new List<IntPtr>();
		IntPtr intPtr = AllocBuffer(2 * Marshal.SizeOf((object)cERT_SELECT_CRITERIA));
		SetHandle(intPtr);
		cERT_SELECT_CRITERIA.dwType = 1u;
		cERT_SELECT_CRITERIA.cPara = 1u;
		IntPtr intPtr2 = AllocString("1.3.6.1.5.5.7.3.2");
		IntPtr intPtr3 = AllocBuffer(Marshal.SizeOf((object)(nint)intPtr2));
		Marshal.WriteIntPtr(intPtr3, intPtr2);
		cERT_SELECT_CRITERIA.ppPara = intPtr3;
		Marshal.StructureToPtr((object)cERT_SELECT_CRITERIA, intPtr, fDeleteOld: false);
		cERT_SELECT_CRITERIA = new UnsafeNclNativeMethods.NativePKI.CERT_SELECT_CRITERIA
		{
			dwType = 2u,
			cPara = 1u
		};
		UnsafeNclNativeMethods.NativePKI.CERT_EXTENSION cERT_EXTENSION = new UnsafeNclNativeMethods.NativePKI.CERT_EXTENSION
		{
			pszObjId = IntPtr.Zero,
			fCritical = 0u,
			Value = 
			{
				cbData = 1u
			}
		};
		IntPtr intPtr4 = AllocBuffer(Marshal.SizeOf((object)(byte)128));
		Marshal.WriteByte(intPtr4, 128);
		cERT_EXTENSION.Value.pbData = intPtr4;
		IntPtr intPtr5 = AllocBuffer(Marshal.SizeOf((object)cERT_EXTENSION));
		Marshal.StructureToPtr((object)cERT_EXTENSION, intPtr5, fDeleteOld: false);
		intPtr3 = AllocBuffer(Marshal.SizeOf((object)(nint)intPtr5));
		Marshal.WriteIntPtr(intPtr3, intPtr5);
		cERT_SELECT_CRITERIA.ppPara = intPtr3;
		Marshal.StructureToPtr((object)cERT_SELECT_CRITERIA, intPtr + Marshal.SizeOf((object)cERT_SELECT_CRITERIA), fDeleteOld: false);
	}

	public override string ToString()
	{
		return "0x" + DangerousGetHandle().ToString("x");
	}

	protected override bool ReleaseHandle()
	{
		try
		{
			foreach (IntPtr unmanagedMemory in unmanagedMemoryList)
			{
				Marshal.FreeHGlobal(unmanagedMemory);
			}
		}
		catch
		{
			return false;
		}
		return true;
	}
}
