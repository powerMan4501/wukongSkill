using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
[SecurityCritical]
internal struct AsAnyMarshaler
{
	private enum BackPropAction
	{
		None,
		Array,
		Layout,
		StringBuilderAnsi,
		StringBuilderUnicode
	}

	private const ushort VTHACK_ANSICHAR = 253;

	private const ushort VTHACK_WINBOOL = 254;

	private IntPtr pvArrayMarshaler;

	private BackPropAction backPropAction;

	private Type layoutType;

	private CleanupWorkList cleanupWorkList;

	private static bool IsIn(int dwFlags)
	{
		return (dwFlags & 0x10000000) != 0;
	}

	private static bool IsOut(int dwFlags)
	{
		return (dwFlags & 0x20000000) != 0;
	}

	private static bool IsAnsi(int dwFlags)
	{
		return (dwFlags & 0xFF0000) != 0;
	}

	private static bool IsThrowOn(int dwFlags)
	{
		return (dwFlags & 0xFF00) != 0;
	}

	private static bool IsBestFit(int dwFlags)
	{
		return (dwFlags & 0xFF) != 0;
	}

	internal AsAnyMarshaler(IntPtr pvArrayMarshaler)
	{
		this.pvArrayMarshaler = pvArrayMarshaler;
		backPropAction = BackPropAction.None;
		layoutType = null;
		cleanupWorkList = null;
	}

	[SecurityCritical]
	private unsafe IntPtr ConvertArrayToNative(object pManagedHome, int dwFlags)
	{
		Type elementType = pManagedHome.GetType().GetElementType();
		VarEnum varEnum = VarEnum.VT_EMPTY;
		switch (Type.GetTypeCode(elementType))
		{
		case TypeCode.SByte:
			varEnum = VarEnum.VT_I1;
			break;
		case TypeCode.Byte:
			varEnum = VarEnum.VT_UI1;
			break;
		case TypeCode.Int16:
			varEnum = VarEnum.VT_I2;
			break;
		case TypeCode.UInt16:
			varEnum = VarEnum.VT_UI2;
			break;
		case TypeCode.Int32:
			varEnum = VarEnum.VT_I4;
			break;
		case TypeCode.UInt32:
			varEnum = VarEnum.VT_UI4;
			break;
		case TypeCode.Int64:
			varEnum = VarEnum.VT_I8;
			break;
		case TypeCode.UInt64:
			varEnum = VarEnum.VT_UI8;
			break;
		case TypeCode.Single:
			varEnum = VarEnum.VT_R4;
			break;
		case TypeCode.Double:
			varEnum = VarEnum.VT_R8;
			break;
		case TypeCode.Char:
			varEnum = (IsAnsi(dwFlags) ? ((VarEnum)253) : VarEnum.VT_UI2);
			break;
		case TypeCode.Boolean:
			varEnum = (VarEnum)254;
			break;
		case TypeCode.Object:
			if (elementType == typeof(IntPtr))
			{
				varEnum = ((IntPtr.Size == 4) ? VarEnum.VT_I4 : VarEnum.VT_I8);
				break;
			}
			if (elementType == typeof(UIntPtr))
			{
				varEnum = ((IntPtr.Size == 4) ? VarEnum.VT_UI4 : VarEnum.VT_UI8);
				break;
			}
			goto default;
		default:
			throw new ArgumentException(Environment.GetResourceString("Arg_NDirectBadObject"));
		}
		int num = (int)varEnum;
		if (IsBestFit(dwFlags))
		{
			num |= 0x10000;
		}
		if (IsThrowOn(dwFlags))
		{
			num |= 0x1000000;
		}
		MngdNativeArrayMarshaler.CreateMarshaler(pvArrayMarshaler, IntPtr.Zero, num);
		IntPtr result = default(IntPtr);
		IntPtr pNativeHome = new IntPtr(&result);
		MngdNativeArrayMarshaler.ConvertSpaceToNative(pvArrayMarshaler, ref pManagedHome, pNativeHome);
		if (IsIn(dwFlags))
		{
			MngdNativeArrayMarshaler.ConvertContentsToNative(pvArrayMarshaler, ref pManagedHome, pNativeHome);
		}
		if (IsOut(dwFlags))
		{
			backPropAction = BackPropAction.Array;
		}
		return result;
	}

	[SecurityCritical]
	private static IntPtr ConvertStringToNative(string pManagedHome, int dwFlags)
	{
		IntPtr intPtr;
		if (IsAnsi(dwFlags))
		{
			intPtr = CSTRMarshaler.ConvertToNative(dwFlags & 0xFFFF, pManagedHome, IntPtr.Zero);
		}
		else
		{
			StubHelpers.CheckStringLength(pManagedHome.Length);
			int num = (pManagedHome.Length + 1) * 2;
			intPtr = Marshal.AllocCoTaskMem(num);
			string.InternalCopy(pManagedHome, intPtr, num);
		}
		return intPtr;
	}

	[SecurityCritical]
	private unsafe IntPtr ConvertStringBuilderToNative(StringBuilder pManagedHome, int dwFlags)
	{
		IntPtr intPtr;
		if (IsAnsi(dwFlags))
		{
			StubHelpers.CheckStringLength(pManagedHome.Capacity);
			int num = pManagedHome.Capacity * Marshal.SystemMaxDBCSCharSize + 4;
			intPtr = Marshal.AllocCoTaskMem(num);
			byte* ptr = (byte*)(void*)intPtr;
			*(ptr + num - 3) = 0;
			*(ptr + num - 2) = 0;
			*(ptr + num - 1) = 0;
			if (IsIn(dwFlags))
			{
				int cbLength;
				byte[] src = AnsiCharMarshaler.DoAnsiConversion(pManagedHome.ToString(), IsBestFit(dwFlags), IsThrowOn(dwFlags), out cbLength);
				Buffer.Memcpy(ptr, 0, src, 0, cbLength);
				ptr[cbLength] = 0;
			}
			if (IsOut(dwFlags))
			{
				backPropAction = BackPropAction.StringBuilderAnsi;
			}
		}
		else
		{
			int num2 = pManagedHome.Capacity * 2 + 4;
			intPtr = Marshal.AllocCoTaskMem(num2);
			byte* ptr2 = (byte*)(void*)intPtr;
			*(ptr2 + num2 - 1) = 0;
			*(ptr2 + num2 - 2) = 0;
			if (IsIn(dwFlags))
			{
				int num3 = pManagedHome.Length * 2;
				pManagedHome.InternalCopy(intPtr, num3);
				ptr2[num3] = 0;
				(ptr2 + num3)[1] = 0;
			}
			if (IsOut(dwFlags))
			{
				backPropAction = BackPropAction.StringBuilderUnicode;
			}
		}
		return intPtr;
	}

	[SecurityCritical]
	private unsafe IntPtr ConvertLayoutToNative(object pManagedHome, int dwFlags)
	{
		int cb = Marshal.SizeOfHelper(pManagedHome.GetType(), throwIfNotMarshalable: false);
		IntPtr result = Marshal.AllocCoTaskMem(cb);
		if (IsIn(dwFlags))
		{
			StubHelpers.FmtClassUpdateNativeInternal(pManagedHome, (byte*)result.ToPointer(), ref cleanupWorkList);
		}
		if (IsOut(dwFlags))
		{
			backPropAction = BackPropAction.Layout;
		}
		layoutType = pManagedHome.GetType();
		return result;
	}

	[SecurityCritical]
	internal IntPtr ConvertToNative(object pManagedHome, int dwFlags)
	{
		if (pManagedHome == null)
		{
			return IntPtr.Zero;
		}
		if (pManagedHome is ArrayWithOffset)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MarshalAsAnyRestriction"));
		}
		if (pManagedHome.GetType().IsArray)
		{
			return ConvertArrayToNative(pManagedHome, dwFlags);
		}
		if (pManagedHome is string pManagedHome2)
		{
			return ConvertStringToNative(pManagedHome2, dwFlags);
		}
		if (pManagedHome is StringBuilder pManagedHome3)
		{
			return ConvertStringBuilderToNative(pManagedHome3, dwFlags);
		}
		if (pManagedHome.GetType().IsLayoutSequential || pManagedHome.GetType().IsExplicitLayout)
		{
			return ConvertLayoutToNative(pManagedHome, dwFlags);
		}
		throw new ArgumentException(Environment.GetResourceString("Arg_NDirectBadObject"));
	}

	[SecurityCritical]
	internal unsafe void ConvertToManaged(object pManagedHome, IntPtr pNativeHome)
	{
		switch (backPropAction)
		{
		case BackPropAction.Array:
			MngdNativeArrayMarshaler.ConvertContentsToManaged(pvArrayMarshaler, ref pManagedHome, new IntPtr(&pNativeHome));
			break;
		case BackPropAction.Layout:
			StubHelpers.FmtClassUpdateCLRInternal(pManagedHome, (byte*)pNativeHome.ToPointer());
			break;
		case BackPropAction.StringBuilderAnsi:
		{
			sbyte* newBuffer2 = (sbyte*)pNativeHome.ToPointer();
			((StringBuilder)pManagedHome).ReplaceBufferAnsiInternal(newBuffer2, Win32Native.lstrlenA(pNativeHome));
			break;
		}
		case BackPropAction.StringBuilderUnicode:
		{
			char* newBuffer = (char*)pNativeHome.ToPointer();
			((StringBuilder)pManagedHome).ReplaceBufferInternal(newBuffer, Win32Native.lstrlenW(pNativeHome));
			break;
		}
		}
	}

	[SecurityCritical]
	internal void ClearNative(IntPtr pNativeHome)
	{
		if (pNativeHome != IntPtr.Zero)
		{
			if (layoutType != null)
			{
				Marshal.DestroyStructure(pNativeHome, layoutType);
			}
			Win32Native.CoTaskMemFree(pNativeHome);
		}
		StubHelpers.DestroyCleanupList(ref cleanupWorkList);
	}
}
