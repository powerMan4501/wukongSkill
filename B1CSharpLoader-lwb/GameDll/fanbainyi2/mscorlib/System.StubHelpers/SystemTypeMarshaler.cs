using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class SystemTypeMarshaler
{
	[SecurityCritical]
	internal unsafe static void ConvertToNative(Type managedType, TypeNameNative* pNativeType)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		string text2;
		if (managedType != null)
		{
			if (managedType.GetType() != typeof(RuntimeType))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_WinRTSystemRuntimeType", managedType.GetType().ToString()));
			}
			bool isPrimitive;
			string text = WinRTTypeNameConverter.ConvertToWinRTTypeName(managedType, out isPrimitive);
			if (text != null)
			{
				text2 = text;
				if (isPrimitive)
				{
					pNativeType->typeKind = TypeKind.Primitive;
				}
				else
				{
					pNativeType->typeKind = TypeKind.Metadata;
				}
			}
			else
			{
				text2 = managedType.AssemblyQualifiedName;
				pNativeType->typeKind = TypeKind.Projection;
			}
		}
		else
		{
			text2 = "";
			pNativeType->typeKind = TypeKind.Projection;
		}
		int errorCode = UnsafeNativeMethods.WindowsCreateString(text2, text2.Length, &pNativeType->typeName);
		Marshal.ThrowExceptionForHR(errorCode, new IntPtr(-1));
	}

	[SecurityCritical]
	internal unsafe static void ConvertToManaged(TypeNameNative* pNativeType, ref Type managedType)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		string text = WindowsRuntimeMarshal.HStringToString(pNativeType->typeName);
		if (string.IsNullOrEmpty(text))
		{
			managedType = null;
			return;
		}
		if (pNativeType->typeKind == TypeKind.Projection)
		{
			managedType = Type.GetType(text, throwOnError: true);
			return;
		}
		managedType = WinRTTypeNameConverter.GetTypeFromWinRTTypeName(text, out var isPrimitive);
		if (isPrimitive == (pNativeType->typeKind == TypeKind.Primitive))
		{
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_Unexpected_TypeSource"));
	}

	[SecurityCritical]
	internal unsafe static void ClearNative(TypeNameNative* pNativeType)
	{
		_ = *pNativeType;
		UnsafeNativeMethods.WindowsDeleteString(pNativeType->typeName);
	}
}
