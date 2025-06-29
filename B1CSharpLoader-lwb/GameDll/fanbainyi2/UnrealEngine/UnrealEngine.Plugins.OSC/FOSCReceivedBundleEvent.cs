using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UDelegate]
[UMetaPath("/Script/OSC.OSCReceivedBundleEvent__DelegateSignature")]
public class FOSCReceivedBundleEvent : FMulticastDelegate<FOSCReceivedBundleEvent.Signature>
{
	public delegate void Signature(FOSCBundle Bundle, string IPAddress, int Port);

	private static bool OSCReceivedBundleEvent__DelegateSignature_IsValid;

	private static IntPtr OSCReceivedBundleEvent__DelegateSignature_FunctionAddress;

	private static int OSCReceivedBundleEvent__DelegateSignature_ParamsSize;

	private static bool OSCReceivedBundleEvent__DelegateSignature_Bundle_IsValid;

	private static FFieldAddress OSCReceivedBundleEvent__DelegateSignature_Bundle_PropertyAddress;

	private static int OSCReceivedBundleEvent__DelegateSignature_Bundle_Offset;

	private static bool OSCReceivedBundleEvent__DelegateSignature_IPAddress_IsValid;

	private static FFieldAddress OSCReceivedBundleEvent__DelegateSignature_IPAddress_PropertyAddress;

	private static int OSCReceivedBundleEvent__DelegateSignature_IPAddress_Offset;

	private static bool OSCReceivedBundleEvent__DelegateSignature_Port_IsValid;

	private static FFieldAddress OSCReceivedBundleEvent__DelegateSignature_Port_PropertyAddress;

	private static int OSCReceivedBundleEvent__DelegateSignature_Port_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOSCReceivedBundleEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OSCReceivedBundleEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OSC.OSCReceivedBundleEvent__DelegateSignature");
		OSCReceivedBundleEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCReceivedBundleEvent__DelegateSignature_Bundle_PropertyAddress, OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "Bundle");
		OSCReceivedBundleEvent__DelegateSignature_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "Bundle");
		OSCReceivedBundleEvent__DelegateSignature_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "Bundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCReceivedBundleEvent__DelegateSignature_IPAddress_PropertyAddress, OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "IPAddress");
		OSCReceivedBundleEvent__DelegateSignature_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "IPAddress");
		OSCReceivedBundleEvent__DelegateSignature_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "IPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCReceivedBundleEvent__DelegateSignature_Port_PropertyAddress, OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "Port");
		OSCReceivedBundleEvent__DelegateSignature_Port_Offset = NativeReflectionCached.GetPropertyOffset(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "Port");
		OSCReceivedBundleEvent__DelegateSignature_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCReceivedBundleEvent__DelegateSignature_FunctionAddress, "Port", Classes.FIntProperty);
		OSCReceivedBundleEvent__DelegateSignature_IsValid = OSCReceivedBundleEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OSCReceivedBundleEvent__DelegateSignature_Bundle_IsValid && OSCReceivedBundleEvent__DelegateSignature_IPAddress_IsValid && OSCReceivedBundleEvent__DelegateSignature_Port_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCReceivedBundleEvent__DelegateSignature", OSCReceivedBundleEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FOSCBundle Bundle, string IPAddress, int Port)
	{
		if (!OSCReceivedBundleEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCReceivedBundleEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OSCReceivedBundleEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCReceivedBundleEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OSCReceivedBundleEvent__DelegateSignature_Bundle_PropertyAddress.Address, intPtr);
			FOSCBundle.ToNative(IntPtr.Add(intPtr, OSCReceivedBundleEvent__DelegateSignature_Bundle_Offset), 0, OSCReceivedBundleEvent__DelegateSignature_Bundle_PropertyAddress.Address, Bundle);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OSCReceivedBundleEvent__DelegateSignature_IPAddress_Offset), 0, OSCReceivedBundleEvent__DelegateSignature_IPAddress_PropertyAddress.Address, IPAddress);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCReceivedBundleEvent__DelegateSignature_Port_Offset), 0, OSCReceivedBundleEvent__DelegateSignature_Port_PropertyAddress.Address, Port);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OSCReceivedBundleEvent__DelegateSignature_Bundle_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OSCReceivedBundleEvent__DelegateSignature_IPAddress_PropertyAddress.Address, intPtr);
		}
	}
}
