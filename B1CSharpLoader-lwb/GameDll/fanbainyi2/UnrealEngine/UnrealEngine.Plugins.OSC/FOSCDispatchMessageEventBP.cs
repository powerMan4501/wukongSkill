using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UDelegate]
[UMetaPath("/Script/OSC.OSCDispatchMessageEventBP__DelegateSignature")]
public class FOSCDispatchMessageEventBP : FDelegate<FOSCDispatchMessageEventBP.Signature>
{
	public delegate void Signature(FOSCAddress AddressPattern, FOSCMessage Message, string IPAddress, int Port);

	private static bool OSCDispatchMessageEventBP__DelegateSignature_IsValid;

	private static IntPtr OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress;

	private static int OSCDispatchMessageEventBP__DelegateSignature_ParamsSize;

	private static bool OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_IsValid;

	private static FFieldAddress OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_PropertyAddress;

	private static int OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_Offset;

	private static bool OSCDispatchMessageEventBP__DelegateSignature_Message_IsValid;

	private static FFieldAddress OSCDispatchMessageEventBP__DelegateSignature_Message_PropertyAddress;

	private static int OSCDispatchMessageEventBP__DelegateSignature_Message_Offset;

	private static bool OSCDispatchMessageEventBP__DelegateSignature_IPAddress_IsValid;

	private static FFieldAddress OSCDispatchMessageEventBP__DelegateSignature_IPAddress_PropertyAddress;

	private static int OSCDispatchMessageEventBP__DelegateSignature_IPAddress_Offset;

	private static bool OSCDispatchMessageEventBP__DelegateSignature_Port_IsValid;

	private static FFieldAddress OSCDispatchMessageEventBP__DelegateSignature_Port_PropertyAddress;

	private static int OSCDispatchMessageEventBP__DelegateSignature_Port_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOSCDispatchMessageEventBP()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OSC.OSCDispatchMessageEventBP__DelegateSignature");
		OSCDispatchMessageEventBP__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_PropertyAddress, OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "AddressPattern");
		OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "AddressPattern");
		OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "AddressPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEventBP__DelegateSignature_Message_PropertyAddress, OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "Message");
		OSCDispatchMessageEventBP__DelegateSignature_Message_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "Message");
		OSCDispatchMessageEventBP__DelegateSignature_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEventBP__DelegateSignature_IPAddress_PropertyAddress, OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "IPAddress");
		OSCDispatchMessageEventBP__DelegateSignature_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "IPAddress");
		OSCDispatchMessageEventBP__DelegateSignature_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "IPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEventBP__DelegateSignature_Port_PropertyAddress, OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "Port");
		OSCDispatchMessageEventBP__DelegateSignature_Port_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "Port");
		OSCDispatchMessageEventBP__DelegateSignature_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress, "Port", Classes.FIntProperty);
		OSCDispatchMessageEventBP__DelegateSignature_IsValid = OSCDispatchMessageEventBP__DelegateSignature_FunctionAddress != IntPtr.Zero && OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_IsValid && OSCDispatchMessageEventBP__DelegateSignature_Message_IsValid && OSCDispatchMessageEventBP__DelegateSignature_IPAddress_IsValid && OSCDispatchMessageEventBP__DelegateSignature_Port_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCDispatchMessageEventBP__DelegateSignature", OSCDispatchMessageEventBP__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FOSCAddress AddressPattern, FOSCMessage Message, string IPAddress, int Port)
	{
		if (!OSCDispatchMessageEventBP__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCDispatchMessageEventBP__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OSCDispatchMessageEventBP__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCDispatchMessageEventBP__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_PropertyAddress.Address, intPtr);
			FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_Offset), 0, OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_PropertyAddress.Address, AddressPattern);
			NativeReflection.InitializeValue_InContainer(OSCDispatchMessageEventBP__DelegateSignature_Message_PropertyAddress.Address, intPtr);
			FOSCMessage.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEventBP__DelegateSignature_Message_Offset), 0, OSCDispatchMessageEventBP__DelegateSignature_Message_PropertyAddress.Address, Message);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEventBP__DelegateSignature_IPAddress_Offset), 0, OSCDispatchMessageEventBP__DelegateSignature_IPAddress_PropertyAddress.Address, IPAddress);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEventBP__DelegateSignature_Port_Offset), 0, OSCDispatchMessageEventBP__DelegateSignature_Port_PropertyAddress.Address, Port);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OSCDispatchMessageEventBP__DelegateSignature_AddressPattern_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OSCDispatchMessageEventBP__DelegateSignature_Message_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OSCDispatchMessageEventBP__DelegateSignature_IPAddress_PropertyAddress.Address, intPtr);
		}
	}
}
