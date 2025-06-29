using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UDelegate]
[UMetaPath("/Script/OSC.OSCDispatchMessageEvent__DelegateSignature")]
public class FOSCDispatchMessageEvent : FMulticastDelegate<FOSCDispatchMessageEvent.Signature>
{
	public delegate void Signature(FOSCAddress AddressPattern, FOSCMessage Message, string IPAddress, int Port);

	private static bool OSCDispatchMessageEvent__DelegateSignature_IsValid;

	private static IntPtr OSCDispatchMessageEvent__DelegateSignature_FunctionAddress;

	private static int OSCDispatchMessageEvent__DelegateSignature_ParamsSize;

	private static bool OSCDispatchMessageEvent__DelegateSignature_AddressPattern_IsValid;

	private static FFieldAddress OSCDispatchMessageEvent__DelegateSignature_AddressPattern_PropertyAddress;

	private static int OSCDispatchMessageEvent__DelegateSignature_AddressPattern_Offset;

	private static bool OSCDispatchMessageEvent__DelegateSignature_Message_IsValid;

	private static FFieldAddress OSCDispatchMessageEvent__DelegateSignature_Message_PropertyAddress;

	private static int OSCDispatchMessageEvent__DelegateSignature_Message_Offset;

	private static bool OSCDispatchMessageEvent__DelegateSignature_IPAddress_IsValid;

	private static FFieldAddress OSCDispatchMessageEvent__DelegateSignature_IPAddress_PropertyAddress;

	private static int OSCDispatchMessageEvent__DelegateSignature_IPAddress_Offset;

	private static bool OSCDispatchMessageEvent__DelegateSignature_Port_IsValid;

	private static FFieldAddress OSCDispatchMessageEvent__DelegateSignature_Port_PropertyAddress;

	private static int OSCDispatchMessageEvent__DelegateSignature_Port_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOSCDispatchMessageEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OSCDispatchMessageEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OSC.OSCDispatchMessageEvent__DelegateSignature");
		OSCDispatchMessageEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEvent__DelegateSignature_AddressPattern_PropertyAddress, OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "AddressPattern");
		OSCDispatchMessageEvent__DelegateSignature_AddressPattern_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "AddressPattern");
		OSCDispatchMessageEvent__DelegateSignature_AddressPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "AddressPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEvent__DelegateSignature_Message_PropertyAddress, OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "Message");
		OSCDispatchMessageEvent__DelegateSignature_Message_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "Message");
		OSCDispatchMessageEvent__DelegateSignature_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEvent__DelegateSignature_IPAddress_PropertyAddress, OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "IPAddress");
		OSCDispatchMessageEvent__DelegateSignature_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "IPAddress");
		OSCDispatchMessageEvent__DelegateSignature_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "IPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCDispatchMessageEvent__DelegateSignature_Port_PropertyAddress, OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "Port");
		OSCDispatchMessageEvent__DelegateSignature_Port_Offset = NativeReflectionCached.GetPropertyOffset(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "Port");
		OSCDispatchMessageEvent__DelegateSignature_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCDispatchMessageEvent__DelegateSignature_FunctionAddress, "Port", Classes.FIntProperty);
		OSCDispatchMessageEvent__DelegateSignature_IsValid = OSCDispatchMessageEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OSCDispatchMessageEvent__DelegateSignature_AddressPattern_IsValid && OSCDispatchMessageEvent__DelegateSignature_Message_IsValid && OSCDispatchMessageEvent__DelegateSignature_IPAddress_IsValid && OSCDispatchMessageEvent__DelegateSignature_Port_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCDispatchMessageEvent__DelegateSignature", OSCDispatchMessageEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FOSCAddress AddressPattern, FOSCMessage Message, string IPAddress, int Port)
	{
		if (!OSCDispatchMessageEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCDispatchMessageEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OSCDispatchMessageEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCDispatchMessageEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OSCDispatchMessageEvent__DelegateSignature_AddressPattern_PropertyAddress.Address, intPtr);
			FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEvent__DelegateSignature_AddressPattern_Offset), 0, OSCDispatchMessageEvent__DelegateSignature_AddressPattern_PropertyAddress.Address, AddressPattern);
			NativeReflection.InitializeValue_InContainer(OSCDispatchMessageEvent__DelegateSignature_Message_PropertyAddress.Address, intPtr);
			FOSCMessage.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEvent__DelegateSignature_Message_Offset), 0, OSCDispatchMessageEvent__DelegateSignature_Message_PropertyAddress.Address, Message);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEvent__DelegateSignature_IPAddress_Offset), 0, OSCDispatchMessageEvent__DelegateSignature_IPAddress_PropertyAddress.Address, IPAddress);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCDispatchMessageEvent__DelegateSignature_Port_Offset), 0, OSCDispatchMessageEvent__DelegateSignature_Port_PropertyAddress.Address, Port);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OSCDispatchMessageEvent__DelegateSignature_AddressPattern_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OSCDispatchMessageEvent__DelegateSignature_Message_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OSCDispatchMessageEvent__DelegateSignature_IPAddress_PropertyAddress.Address, intPtr);
		}
	}
}
