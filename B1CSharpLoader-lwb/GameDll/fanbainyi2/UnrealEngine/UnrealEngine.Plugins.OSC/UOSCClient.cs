using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/OSC.OSCClient", "OSC", UnrealModuleType.EnginePlugin)]
public class UOSCClient : UObject
{
	private static bool SetSendIPAddress_IsValid;

	private static IntPtr SetSendIPAddress_FunctionAddress;

	private static int SetSendIPAddress_ParamsSize;

	private static bool SetSendIPAddress_IPAddress_IsValid;

	private static FFieldAddress SetSendIPAddress_IPAddress_PropertyAddress;

	private static int SetSendIPAddress_IPAddress_Offset;

	private static bool SetSendIPAddress_Port_IsValid;

	private static FFieldAddress SetSendIPAddress_Port_PropertyAddress;

	private static int SetSendIPAddress_Port_Offset;

	private static bool SetSendIPAddress_ReturnValue_IsValid;

	private static FFieldAddress SetSendIPAddress_ReturnValue_PropertyAddress;

	private static int SetSendIPAddress_ReturnValue_Offset;

	private static bool SendOSCMessage_IsValid;

	private static IntPtr SendOSCMessage_FunctionAddress;

	private static int SendOSCMessage_ParamsSize;

	private static bool SendOSCMessage_Message_IsValid;

	private static FFieldAddress SendOSCMessage_Message_PropertyAddress;

	private static int SendOSCMessage_Message_Offset;

	private static bool SendOSCBundle_IsValid;

	private static IntPtr SendOSCBundle_FunctionAddress;

	private static int SendOSCBundle_ParamsSize;

	private static bool SendOSCBundle_Bundle_IsValid;

	private static FFieldAddress SendOSCBundle_Bundle_PropertyAddress;

	private static int SendOSCBundle_Bundle_Offset;

	private static bool GetSendIPAddress_IsValid;

	private static IntPtr GetSendIPAddress_FunctionAddress;

	private static int GetSendIPAddress_ParamsSize;

	private static bool GetSendIPAddress_IPAddress_IsValid;

	private static FFieldAddress GetSendIPAddress_IPAddress_PropertyAddress;

	private static int GetSendIPAddress_IPAddress_Offset;

	private static bool GetSendIPAddress_Port_IsValid;

	private static FFieldAddress GetSendIPAddress_Port_PropertyAddress;

	private static int GetSendIPAddress_Port_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCClient:SetSendIPAddress")]
	public unsafe bool SetSendIPAddress(string IPAddress, int Port)
	{
		CheckDestroyed();
		if (!SetSendIPAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCClient:SetSendIPAddress");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSendIPAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSendIPAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSendIPAddress_IPAddress_Offset), 0, SetSendIPAddress_IPAddress_PropertyAddress.Address, IPAddress);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSendIPAddress_Port_Offset), 0, SetSendIPAddress_Port_PropertyAddress.Address, Port);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSendIPAddress_FunctionAddress, intPtr, SetSendIPAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSendIPAddress_IPAddress_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSendIPAddress_ReturnValue_Offset), 0, SetSendIPAddress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OSC.OSCClient:SendOSCMessage")]
	public unsafe void SendOSCMessage(ref FOSCMessage Message)
	{
		CheckDestroyed();
		if (!SendOSCMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCClient:SendOSCMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendOSCMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendOSCMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SendOSCMessage_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, SendOSCMessage_Message_Offset), 0, SendOSCMessage_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, SendOSCMessage_FunctionAddress, intPtr, SendOSCMessage_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, SendOSCMessage_Message_Offset), 0, SendOSCMessage_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SendOSCMessage_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OSC.OSCClient:SendOSCBundle")]
	public unsafe void SendOSCBundle(ref FOSCBundle Bundle)
	{
		CheckDestroyed();
		if (!SendOSCBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCClient:SendOSCBundle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendOSCBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendOSCBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SendOSCBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, SendOSCBundle_Bundle_Offset), 0, SendOSCBundle_Bundle_PropertyAddress.Address, Bundle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SendOSCBundle_FunctionAddress, intPtr, SendOSCBundle_ParamsSize);
		Bundle = FOSCBundle.FromNative(IntPtr.Add(intPtr, SendOSCBundle_Bundle_Offset), 0, SendOSCBundle_Bundle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SendOSCBundle_Bundle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OSC.OSCClient:GetSendIPAddress")]
	public unsafe void GetSendIPAddress(ref string IPAddress, ref int Port)
	{
		CheckDestroyed();
		if (!GetSendIPAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCClient:GetSendIPAddress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSendIPAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSendIPAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSendIPAddress_IPAddress_Offset), 0, GetSendIPAddress_IPAddress_PropertyAddress.Address, IPAddress);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSendIPAddress_Port_Offset), 0, GetSendIPAddress_Port_PropertyAddress.Address, Port);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSendIPAddress_FunctionAddress, intPtr, GetSendIPAddress_ParamsSize);
		IPAddress = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSendIPAddress_IPAddress_Offset), 0, GetSendIPAddress_IPAddress_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSendIPAddress_IPAddress_PropertyAddress.Address, intPtr);
		Port = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSendIPAddress_Port_Offset), 0, GetSendIPAddress_Port_PropertyAddress.Address);
	}

	static UOSCClient()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOSCClient)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOSCClient));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/OSC.OSCClient");
		SetSendIPAddress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSendIPAddress");
		SetSendIPAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSendIPAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSendIPAddress_IPAddress_PropertyAddress, SetSendIPAddress_FunctionAddress, "IPAddress");
		SetSendIPAddress_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(SetSendIPAddress_FunctionAddress, "IPAddress");
		SetSendIPAddress_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSendIPAddress_FunctionAddress, "IPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSendIPAddress_Port_PropertyAddress, SetSendIPAddress_FunctionAddress, "Port");
		SetSendIPAddress_Port_Offset = NativeReflectionCached.GetPropertyOffset(SetSendIPAddress_FunctionAddress, "Port");
		SetSendIPAddress_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSendIPAddress_FunctionAddress, "Port", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSendIPAddress_ReturnValue_PropertyAddress, SetSendIPAddress_FunctionAddress, "ReturnValue");
		SetSendIPAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSendIPAddress_FunctionAddress, "ReturnValue");
		SetSendIPAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSendIPAddress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSendIPAddress_IsValid = SetSendIPAddress_FunctionAddress != IntPtr.Zero && SetSendIPAddress_IPAddress_IsValid && SetSendIPAddress_Port_IsValid && SetSendIPAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCClient:SetSendIPAddress", SetSendIPAddress_IsValid);
		SendOSCMessage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SendOSCMessage");
		SendOSCMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SendOSCMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendOSCMessage_Message_PropertyAddress, SendOSCMessage_FunctionAddress, "Message");
		SendOSCMessage_Message_Offset = NativeReflectionCached.GetPropertyOffset(SendOSCMessage_FunctionAddress, "Message");
		SendOSCMessage_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(SendOSCMessage_FunctionAddress, "Message", Classes.FStructProperty);
		SendOSCMessage_IsValid = SendOSCMessage_FunctionAddress != IntPtr.Zero && SendOSCMessage_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCClient:SendOSCMessage", SendOSCMessage_IsValid);
		SendOSCBundle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SendOSCBundle");
		SendOSCBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(SendOSCBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendOSCBundle_Bundle_PropertyAddress, SendOSCBundle_FunctionAddress, "Bundle");
		SendOSCBundle_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(SendOSCBundle_FunctionAddress, "Bundle");
		SendOSCBundle_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(SendOSCBundle_FunctionAddress, "Bundle", Classes.FStructProperty);
		SendOSCBundle_IsValid = SendOSCBundle_FunctionAddress != IntPtr.Zero && SendOSCBundle_Bundle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCClient:SendOSCBundle", SendOSCBundle_IsValid);
		GetSendIPAddress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSendIPAddress");
		GetSendIPAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSendIPAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSendIPAddress_IPAddress_PropertyAddress, GetSendIPAddress_FunctionAddress, "IPAddress");
		GetSendIPAddress_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(GetSendIPAddress_FunctionAddress, "IPAddress");
		GetSendIPAddress_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSendIPAddress_FunctionAddress, "IPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSendIPAddress_Port_PropertyAddress, GetSendIPAddress_FunctionAddress, "Port");
		GetSendIPAddress_Port_Offset = NativeReflectionCached.GetPropertyOffset(GetSendIPAddress_FunctionAddress, "Port");
		GetSendIPAddress_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSendIPAddress_FunctionAddress, "Port", Classes.FIntProperty);
		GetSendIPAddress_IsValid = GetSendIPAddress_FunctionAddress != IntPtr.Zero && GetSendIPAddress_IPAddress_IsValid && GetSendIPAddress_Port_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCClient:GetSendIPAddress", GetSendIPAddress_IsValid);
	}
}
