using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class InterfaceMarshaler<T> where T : class, IInterface
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int csharp_delegate(IntPtr cpp_ptr, int size, IntPtr context);

	private static IntPtr interfaceClassAddress;

	internal static void UpdateInterfaceClassAddress()
	{
		interfaceClassAddress = UClass.GetInterfaceClassAddress<T>();
	}

	public static T FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public static void ToNative(IntPtr nativeBuffer, T value)
	{
		ToNative(nativeBuffer, 0, IntPtr.Zero, value);
	}

	public static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		UObject uObject = GCHelper.Find<UObject>(BlittableTypeMarshaler<FScriptInterface>.FromNative(nativeBuffer, arrayIndex, prop).ObjectPointer);
		if (uObject != null)
		{
			return uObject.GetInterface<T>();
		}
		return null;
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		IntPtr address = value.GetAddress();
		IntPtr intPtr = IntPtr.Zero;
		if (address != IntPtr.Zero)
		{
			UpdateInterfaceClassAddress();
			if (interfaceClassAddress != IntPtr.Zero)
			{
				intPtr = Native_UObjectBaseUtility.GetInterfaceAddress(address, interfaceClassAddress);
			}
		}
		if (address != IntPtr.Zero && intPtr != IntPtr.Zero)
		{
			BlittableTypeMarshaler<FScriptInterface>.ToNative(nativeBuffer, arrayIndex, new FScriptInterface(address, intPtr));
		}
		else
		{
			BlittableTypeMarshaler<FScriptInterface>.ToNative(nativeBuffer, arrayIndex, default(FScriptInterface));
		}
	}
}
