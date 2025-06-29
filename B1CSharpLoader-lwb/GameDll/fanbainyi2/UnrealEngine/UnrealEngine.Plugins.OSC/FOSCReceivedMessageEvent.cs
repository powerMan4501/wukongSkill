using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UDelegate]
[UMetaPath("/Script/OSC.OSCReceivedMessageEvent__DelegateSignature")]
public class FOSCReceivedMessageEvent : FMulticastDelegate<FOSCReceivedMessageEvent.Signature>
{
	public delegate void Signature(FOSCMessage Message, string IPAddress, int Port);

	private static bool OSCReceivedMessageEvent__DelegateSignature_IsValid;

	private static IntPtr OSCReceivedMessageEvent__DelegateSignature_FunctionAddress;

	private static int OSCReceivedMessageEvent__DelegateSignature_ParamsSize;

	private static bool OSCReceivedMessageEvent__DelegateSignature_Message_IsValid;

	private static FFieldAddress OSCReceivedMessageEvent__DelegateSignature_Message_PropertyAddress;

	private static int OSCReceivedMessageEvent__DelegateSignature_Message_Offset;

	private static bool OSCReceivedMessageEvent__DelegateSignature_IPAddress_IsValid;

	private static FFieldAddress OSCReceivedMessageEvent__DelegateSignature_IPAddress_PropertyAddress;

	private static int OSCReceivedMessageEvent__DelegateSignature_IPAddress_Offset;

	private static bool OSCReceivedMessageEvent__DelegateSignature_Port_IsValid;

	private static FFieldAddress OSCReceivedMessageEvent__DelegateSignature_Port_PropertyAddress;

	private static int OSCReceivedMessageEvent__DelegateSignature_Port_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOSCReceivedMessageEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OSCReceivedMessageEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OSC.OSCReceivedMessageEvent__DelegateSignature");
		OSCReceivedMessageEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCReceivedMessageEvent__DelegateSignature_Message_PropertyAddress, OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "Message");
		OSCReceivedMessageEvent__DelegateSignature_Message_Offset = NativeReflectionCached.GetPropertyOffset(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "Message");
		OSCReceivedMessageEvent__DelegateSignature_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCReceivedMessageEvent__DelegateSignature_IPAddress_PropertyAddress, OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "IPAddress");
		OSCReceivedMessageEvent__DelegateSignature_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "IPAddress");
		OSCReceivedMessageEvent__DelegateSignature_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "IPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCReceivedMessageEvent__DelegateSignature_Port_PropertyAddress, OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "Port");
		OSCReceivedMessageEvent__DelegateSignature_Port_Offset = NativeReflectionCached.GetPropertyOffset(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "Port");
		OSCReceivedMessageEvent__DelegateSignature_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCReceivedMessageEvent__DelegateSignature_FunctionAddress, "Port", Classes.FIntProperty);
		OSCReceivedMessageEvent__DelegateSignature_IsValid = OSCReceivedMessageEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OSCReceivedMessageEvent__DelegateSignature_Message_IsValid && OSCReceivedMessageEvent__DelegateSignature_IPAddress_IsValid && OSCReceivedMessageEvent__DelegateSignature_Port_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCReceivedMessageEvent__DelegateSignature", OSCReceivedMessageEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FOSCMessage Message, string IPAddress, int Port)
	{
		if (!OSCReceivedMessageEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCReceivedMessageEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OSCReceivedMessageEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCReceivedMessageEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OSCReceivedMessageEvent__DelegateSignature_Message_PropertyAddress.Address, intPtr);
			FOSCMessage.ToNative(IntPtr.Add(intPtr, OSCReceivedMessageEvent__DelegateSignature_Message_Offset), 0, OSCReceivedMessageEvent__DelegateSignature_Message_PropertyAddress.Address, Message);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OSCReceivedMessageEvent__DelegateSignature_IPAddress_Offset), 0, OSCReceivedMessageEvent__DelegateSignature_IPAddress_PropertyAddress.Address, IPAddress);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCReceivedMessageEvent__DelegateSignature_Port_Offset), 0, OSCReceivedMessageEvent__DelegateSignature_Port_PropertyAddress.Address, Port);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OSCReceivedMessageEvent__DelegateSignature_Message_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(OSCReceivedMessageEvent__DelegateSignature_IPAddress_PropertyAddress.Address, intPtr);
		}
	}
}
