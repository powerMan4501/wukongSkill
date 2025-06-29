using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/OSC.OSCServer", "OSC", UnrealModuleType.EnginePlugin)]
public class UOSCServer : UObject
{
	private static bool OnOscMessageReceived_IsValid;

	private static int OnOscMessageReceived_Offset;

	private FOSCReceivedMessageEvent OnOscMessageReceived_DelegateCached;

	private static bool OnOscBundleReceived_IsValid;

	private static int OnOscBundleReceived_Offset;

	private FOSCReceivedBundleEvent OnOscBundleReceived_DelegateCached;

	private static bool UnbindEventFromOnOSCAddressPatternMatchesPath_IsValid;

	private static IntPtr UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress;

	private static int UnbindEventFromOnOSCAddressPatternMatchesPath_ParamsSize;

	private static bool UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid;

	private static FFieldAddress UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress;

	private static int UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset;

	private static bool UnbindEventFromOnOSCAddressPatternMatchesPath_Event_IsValid;

	private static FFieldAddress UnbindEventFromOnOSCAddressPatternMatchesPath_Event_PropertyAddress;

	private static int UnbindEventFromOnOSCAddressPatternMatchesPath_Event_Offset;

	private static bool UnbindAllEventsFromOnOSCAddressPatternMatching_IsValid;

	private static IntPtr UnbindAllEventsFromOnOSCAddressPatternMatching_FunctionAddress;

	private static int UnbindAllEventsFromOnOSCAddressPatternMatching_ParamsSize;

	private static bool UnbindAllEventsFromOnOSCAddressPatternMatchesPath_IsValid;

	private static IntPtr UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress;

	private static int UnbindAllEventsFromOnOSCAddressPatternMatchesPath_ParamsSize;

	private static bool UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid;

	private static FFieldAddress UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress;

	private static int UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetTickInEditor_IsValid;

	private static IntPtr SetTickInEditor_FunctionAddress;

	private static int SetTickInEditor_ParamsSize;

	private static bool SetTickInEditor_bInTickInEditor_IsValid;

	private static FFieldAddress SetTickInEditor_bInTickInEditor_PropertyAddress;

	private static int SetTickInEditor_bInTickInEditor_Offset;

	private static bool SetMulticastLoopback_IsValid;

	private static IntPtr SetMulticastLoopback_FunctionAddress;

	private static int SetMulticastLoopback_ParamsSize;

	private static bool SetMulticastLoopback_bMulticastLoopback_IsValid;

	private static FFieldAddress SetMulticastLoopback_bMulticastLoopback_PropertyAddress;

	private static int SetMulticastLoopback_bMulticastLoopback_Offset;

	private static bool SetAllowlistClientsEnabled_IsValid;

	private static IntPtr SetAllowlistClientsEnabled_FunctionAddress;

	private static int SetAllowlistClientsEnabled_ParamsSize;

	private static bool SetAllowlistClientsEnabled_bEnabled_IsValid;

	private static FFieldAddress SetAllowlistClientsEnabled_bEnabled_PropertyAddress;

	private static int SetAllowlistClientsEnabled_bEnabled_Offset;

	private static bool SetAddress_IsValid;

	private static IntPtr SetAddress_FunctionAddress;

	private static int SetAddress_ParamsSize;

	private static bool SetAddress_ReceiveIPAddress_IsValid;

	private static FFieldAddress SetAddress_ReceiveIPAddress_PropertyAddress;

	private static int SetAddress_ReceiveIPAddress_Offset;

	private static bool SetAddress_Port_IsValid;

	private static FFieldAddress SetAddress_Port_PropertyAddress;

	private static int SetAddress_Port_Offset;

	private static bool SetAddress_ReturnValue_IsValid;

	private static FFieldAddress SetAddress_ReturnValue_PropertyAddress;

	private static int SetAddress_ReturnValue_Offset;

	private static bool RemoveAllowlistedClient_IsValid;

	private static IntPtr RemoveAllowlistedClient_FunctionAddress;

	private static int RemoveAllowlistedClient_ParamsSize;

	private static bool RemoveAllowlistedClient_IPAddress_IsValid;

	private static FFieldAddress RemoveAllowlistedClient_IPAddress_PropertyAddress;

	private static int RemoveAllowlistedClient_IPAddress_Offset;

	private static bool Listen_IsValid;

	private static IntPtr Listen_FunctionAddress;

	private static int Listen_ParamsSize;

	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

	private static bool GetPort_IsValid;

	private static IntPtr GetPort_FunctionAddress;

	private static int GetPort_ParamsSize;

	private static bool GetPort_ReturnValue_IsValid;

	private static FFieldAddress GetPort_ReturnValue_PropertyAddress;

	private static int GetPort_ReturnValue_Offset;

	private static bool GetMulticastLoopback_IsValid;

	private static IntPtr GetMulticastLoopback_FunctionAddress;

	private static int GetMulticastLoopback_ParamsSize;

	private static bool GetMulticastLoopback_ReturnValue_IsValid;

	private static FFieldAddress GetMulticastLoopback_ReturnValue_PropertyAddress;

	private static int GetMulticastLoopback_ReturnValue_Offset;

	private static bool GetIpAddress_IsValid;

	private static IntPtr GetIpAddress_FunctionAddress;

	private static int GetIpAddress_ParamsSize;

	private static bool GetIpAddress_bIncludePort_IsValid;

	private static FFieldAddress GetIpAddress_bIncludePort_PropertyAddress;

	private static int GetIpAddress_bIncludePort_Offset;

	private static bool GetIpAddress_ReturnValue_IsValid;

	private static FFieldAddress GetIpAddress_ReturnValue_PropertyAddress;

	private static int GetIpAddress_ReturnValue_Offset;

	private static bool GetBoundOSCAddressPatterns_IsValid;

	private static IntPtr GetBoundOSCAddressPatterns_FunctionAddress;

	private static int GetBoundOSCAddressPatterns_ParamsSize;

	private static bool GetBoundOSCAddressPatterns_ReturnValue_IsValid;

	private static FFieldAddress GetBoundOSCAddressPatterns_ReturnValue_PropertyAddress;

	private static int GetBoundOSCAddressPatterns_ReturnValue_Offset;

	private static bool GetAllowlistedClients_IsValid;

	private static IntPtr GetAllowlistedClients_FunctionAddress;

	private static int GetAllowlistedClients_ParamsSize;

	private static bool GetAllowlistedClients_ReturnValue_IsValid;

	private static FFieldAddress GetAllowlistedClients_ReturnValue_PropertyAddress;

	private static int GetAllowlistedClients_ReturnValue_Offset;

	private static bool ClearAllowlistedClients_IsValid;

	private static IntPtr ClearAllowlistedClients_FunctionAddress;

	private static int ClearAllowlistedClients_ParamsSize;

	private static bool BindEventToOnOSCAddressPatternMatchesPath_IsValid;

	private static IntPtr BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress;

	private static int BindEventToOnOSCAddressPatternMatchesPath_ParamsSize;

	private static bool BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid;

	private static FFieldAddress BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress;

	private static int BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset;

	private static bool BindEventToOnOSCAddressPatternMatchesPath_Event_IsValid;

	private static FFieldAddress BindEventToOnOSCAddressPatternMatchesPath_Event_PropertyAddress;

	private static int BindEventToOnOSCAddressPatternMatchesPath_Event_Offset;

	private static bool AddAllowlistedClient_IsValid;

	private static IntPtr AddAllowlistedClient_FunctionAddress;

	private static int AddAllowlistedClient_ParamsSize;

	private static bool AddAllowlistedClient_IPAddress_IsValid;

	private static FFieldAddress AddAllowlistedClient_IPAddress_PropertyAddress;

	private static int AddAllowlistedClient_IPAddress_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/OSC.OSCServer:OnOscMessageReceived")]
	public FOSCReceivedMessageEvent OnOscMessageReceived
	{
		get
		{
			CheckDestroyed();
			if (!OnOscMessageReceived_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OSC.OSCServer:OnOscMessageReceived");
				return new FOSCReceivedMessageEvent();
			}
			if (OnOscMessageReceived_DelegateCached == null)
			{
				OnOscMessageReceived_DelegateCached = new FOSCReceivedMessageEvent();
				OnOscMessageReceived_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnOscMessageReceived_Offset));
			}
			return OnOscMessageReceived_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/OSC.OSCServer:OnOscBundleReceived")]
	public FOSCReceivedBundleEvent OnOscBundleReceived
	{
		get
		{
			CheckDestroyed();
			if (!OnOscBundleReceived_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OSC.OSCServer:OnOscBundleReceived");
				return new FOSCReceivedBundleEvent();
			}
			if (OnOscBundleReceived_DelegateCached == null)
			{
				OnOscBundleReceived_DelegateCached = new FOSCReceivedBundleEvent();
				OnOscBundleReceived_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnOscBundleReceived_Offset));
			}
			return OnOscBundleReceived_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OSC.OSCServer:UnbindEventFromOnOSCAddressPatternMatchesPath")]
	public unsafe void UnbindEventFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern, FOSCDispatchMessageEventBP Event)
	{
		CheckDestroyed();
		if (!UnbindEventFromOnOSCAddressPatternMatchesPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:UnbindEventFromOnOSCAddressPatternMatchesPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindEventFromOnOSCAddressPatternMatchesPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindEventFromOnOSCAddressPatternMatchesPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset), 0, UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, OSCAddressPattern);
		FDelegateMarshaler<FOSCDispatchMessageEventBP>.ToNative(IntPtr.Add(intPtr, UnbindEventFromOnOSCAddressPatternMatchesPath_Event_Offset), 0, UnbindEventFromOnOSCAddressPatternMatchesPath_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, intPtr, UnbindEventFromOnOSCAddressPatternMatchesPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:UnbindAllEventsFromOnOSCAddressPatternMatching")]
	public unsafe void UnbindAllEventsFromOnOSCAddressPatternMatching()
	{
		CheckDestroyed();
		if (!UnbindAllEventsFromOnOSCAddressPatternMatching_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:UnbindAllEventsFromOnOSCAddressPatternMatching");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindAllEventsFromOnOSCAddressPatternMatching_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindAllEventsFromOnOSCAddressPatternMatching_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UnbindAllEventsFromOnOSCAddressPatternMatching_FunctionAddress, argsSize: UnbindAllEventsFromOnOSCAddressPatternMatching_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OSC.OSCServer:UnbindAllEventsFromOnOSCAddressPatternMatchesPath")]
	public unsafe void UnbindAllEventsFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern)
	{
		CheckDestroyed();
		if (!UnbindAllEventsFromOnOSCAddressPatternMatchesPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:UnbindAllEventsFromOnOSCAddressPatternMatchesPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindAllEventsFromOnOSCAddressPatternMatchesPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindAllEventsFromOnOSCAddressPatternMatchesPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset), 0, UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, OSCAddressPattern);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress, intPtr, UnbindAllEventsFromOnOSCAddressPatternMatchesPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/OSC.OSCServer:SetTickInEditor")]
	public unsafe void SetTickInEditor(bool bInTickInEditor)
	{
		CheckDestroyed();
		if (!SetTickInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:SetTickInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTickInEditor_bInTickInEditor_Offset), 0, SetTickInEditor_bInTickInEditor_PropertyAddress.Address, bInTickInEditor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickInEditor_FunctionAddress, intPtr, SetTickInEditor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:SetMulticastLoopback")]
	public unsafe void SetMulticastLoopback(bool bMulticastLoopback)
	{
		CheckDestroyed();
		if (!SetMulticastLoopback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:SetMulticastLoopback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMulticastLoopback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMulticastLoopback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMulticastLoopback_bMulticastLoopback_Offset), 0, SetMulticastLoopback_bMulticastLoopback_PropertyAddress.Address, bMulticastLoopback);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMulticastLoopback_FunctionAddress, intPtr, SetMulticastLoopback_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:SetAllowlistClientsEnabled")]
	public unsafe void SetAllowlistClientsEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetAllowlistClientsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:SetAllowlistClientsEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowlistClientsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowlistClientsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowlistClientsEnabled_bEnabled_Offset), 0, SetAllowlistClientsEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowlistClientsEnabled_FunctionAddress, intPtr, SetAllowlistClientsEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:SetAddress")]
	public unsafe bool SetAddress(string ReceiveIPAddress, int Port)
	{
		CheckDestroyed();
		if (!SetAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:SetAddress");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAddress_ReceiveIPAddress_Offset), 0, SetAddress_ReceiveIPAddress_PropertyAddress.Address, ReceiveIPAddress);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAddress_Port_Offset), 0, SetAddress_Port_PropertyAddress.Address, Port);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAddress_FunctionAddress, intPtr, SetAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAddress_ReceiveIPAddress_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAddress_ReturnValue_Offset), 0, SetAddress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:RemoveAllowlistedClient")]
	public unsafe void RemoveAllowlistedClient(string IPAddress)
	{
		CheckDestroyed();
		if (!RemoveAllowlistedClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:RemoveAllowlistedClient");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllowlistedClient_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllowlistedClient_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllowlistedClient_IPAddress_Offset), 0, RemoveAllowlistedClient_IPAddress_PropertyAddress.Address, IPAddress);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllowlistedClient_FunctionAddress, intPtr, RemoveAllowlistedClient_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveAllowlistedClient_IPAddress_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:Listen")]
	public unsafe void Listen()
	{
		CheckDestroyed();
		if (!Listen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:Listen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Listen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Listen_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Listen_FunctionAddress, argsSize: Listen_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/OSC.OSCServer:IsActive")]
	public unsafe bool IsActive()
	{
		CheckDestroyed();
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/OSC.OSCServer:GetPort")]
	public unsafe int GetPort()
	{
		CheckDestroyed();
		if (!GetPort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:GetPort");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPort_FunctionAddress, intPtr, GetPort_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPort_ReturnValue_Offset), 0, GetPort_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/OSC.OSCServer:GetMulticastLoopback")]
	public unsafe bool GetMulticastLoopback()
	{
		CheckDestroyed();
		if (!GetMulticastLoopback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:GetMulticastLoopback");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMulticastLoopback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMulticastLoopback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMulticastLoopback_FunctionAddress, intPtr, GetMulticastLoopback_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMulticastLoopback_ReturnValue_Offset), 0, GetMulticastLoopback_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/OSC.OSCServer:GetIpAddress")]
	public unsafe string GetIpAddress(bool bIncludePort)
	{
		CheckDestroyed();
		if (!GetIpAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:GetIpAddress");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIpAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIpAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetIpAddress_bIncludePort_Offset), 0, GetIpAddress_bIncludePort_PropertyAddress.Address, bIncludePort);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIpAddress_FunctionAddress, intPtr, GetIpAddress_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetIpAddress_ReturnValue_Offset), 0, GetIpAddress_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetIpAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/OSC.OSCServer:GetBoundOSCAddressPatterns")]
	public unsafe List<FOSCAddress> GetBoundOSCAddressPatterns()
	{
		CheckDestroyed();
		if (!GetBoundOSCAddressPatterns_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:GetBoundOSCAddressPatterns");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundOSCAddressPatterns_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundOSCAddressPatterns_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundOSCAddressPatterns_FunctionAddress, intPtr, GetBoundOSCAddressPatterns_ParamsSize);
		List<FOSCAddress> result = new TArrayCopyMarshaler<FOSCAddress>(1, GetBoundOSCAddressPatterns_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FOSCAddress, FOSCAddress>.FromNative, CachedMarshalingDelegates<FOSCAddress, FOSCAddress>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoundOSCAddressPatterns_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoundOSCAddressPatterns_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/OSC.OSCServer:GetAllowlistedClients")]
	public unsafe HashSet<string> GetAllowlistedClients()
	{
		CheckDestroyed();
		if (!GetAllowlistedClients_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:GetAllowlistedClients");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllowlistedClients_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllowlistedClients_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllowlistedClients_FunctionAddress, intPtr, GetAllowlistedClients_ParamsSize);
		HashSet<string> result = new TSetCopyMarshaler<string>(1, GetAllowlistedClients_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllowlistedClients_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllowlistedClients_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:ClearAllowlistedClients")]
	public unsafe void ClearAllowlistedClients()
	{
		CheckDestroyed();
		if (!ClearAllowlistedClients_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:ClearAllowlistedClients");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllowlistedClients_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllowlistedClients_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAllowlistedClients_FunctionAddress, argsSize: ClearAllowlistedClients_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OSC.OSCServer:BindEventToOnOSCAddressPatternMatchesPath")]
	public unsafe void BindEventToOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern, FOSCDispatchMessageEventBP Event)
	{
		CheckDestroyed();
		if (!BindEventToOnOSCAddressPatternMatchesPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:BindEventToOnOSCAddressPatternMatchesPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindEventToOnOSCAddressPatternMatchesPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindEventToOnOSCAddressPatternMatchesPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset), 0, BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, OSCAddressPattern);
		FDelegateMarshaler<FOSCDispatchMessageEventBP>.ToNative(IntPtr.Add(intPtr, BindEventToOnOSCAddressPatternMatchesPath_Event_Offset), 0, BindEventToOnOSCAddressPatternMatchesPath_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, intPtr, BindEventToOnOSCAddressPatternMatchesPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OSC.OSCServer:AddAllowlistedClient")]
	public unsafe void AddAllowlistedClient(string IPAddress)
	{
		CheckDestroyed();
		if (!AddAllowlistedClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCServer:AddAllowlistedClient");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAllowlistedClient_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAllowlistedClient_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddAllowlistedClient_IPAddress_Offset), 0, AddAllowlistedClient_IPAddress_PropertyAddress.Address, IPAddress);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAllowlistedClient_FunctionAddress, intPtr, AddAllowlistedClient_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAllowlistedClient_IPAddress_PropertyAddress.Address, intPtr);
	}

	static UOSCServer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOSCServer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOSCServer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/OSC.OSCServer");
		OnOscMessageReceived_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnOscMessageReceived");
		OnOscMessageReceived_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnOscMessageReceived", Classes.FMulticastDelegateProperty);
		OnOscBundleReceived_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnOscBundleReceived");
		OnOscBundleReceived_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnOscBundleReceived", Classes.FMulticastDelegateProperty);
		UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindEventFromOnOSCAddressPatternMatchesPath");
		UnbindEventFromOnOSCAddressPatternMatchesPath_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress, UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern");
		UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset = NativeReflectionCached.GetPropertyOffset(UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern");
		UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UnbindEventFromOnOSCAddressPatternMatchesPath_Event_PropertyAddress, UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, "Event");
		UnbindEventFromOnOSCAddressPatternMatchesPath_Event_Offset = NativeReflectionCached.GetPropertyOffset(UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, "Event");
		UnbindEventFromOnOSCAddressPatternMatchesPath_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress, "Event", Classes.FDelegateProperty);
		UnbindEventFromOnOSCAddressPatternMatchesPath_IsValid = UnbindEventFromOnOSCAddressPatternMatchesPath_FunctionAddress != IntPtr.Zero && UnbindEventFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid && UnbindEventFromOnOSCAddressPatternMatchesPath_Event_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:UnbindEventFromOnOSCAddressPatternMatchesPath", UnbindEventFromOnOSCAddressPatternMatchesPath_IsValid);
		UnbindAllEventsFromOnOSCAddressPatternMatching_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindAllEventsFromOnOSCAddressPatternMatching");
		UnbindAllEventsFromOnOSCAddressPatternMatching_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindAllEventsFromOnOSCAddressPatternMatching_FunctionAddress);
		UnbindAllEventsFromOnOSCAddressPatternMatching_IsValid = UnbindAllEventsFromOnOSCAddressPatternMatching_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:UnbindAllEventsFromOnOSCAddressPatternMatching", UnbindAllEventsFromOnOSCAddressPatternMatching_IsValid);
		UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindAllEventsFromOnOSCAddressPatternMatchesPath");
		UnbindAllEventsFromOnOSCAddressPatternMatchesPath_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress, UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern");
		UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset = NativeReflectionCached.GetPropertyOffset(UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern");
		UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern", Classes.FStructProperty);
		UnbindAllEventsFromOnOSCAddressPatternMatchesPath_IsValid = UnbindAllEventsFromOnOSCAddressPatternMatchesPath_FunctionAddress != IntPtr.Zero && UnbindAllEventsFromOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:UnbindAllEventsFromOnOSCAddressPatternMatchesPath", UnbindAllEventsFromOnOSCAddressPatternMatchesPath_IsValid);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:Stop", Stop_IsValid);
		SetTickInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTickInEditor");
		SetTickInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickInEditor_bInTickInEditor_PropertyAddress, SetTickInEditor_FunctionAddress, "bInTickInEditor");
		SetTickInEditor_bInTickInEditor_Offset = NativeReflectionCached.GetPropertyOffset(SetTickInEditor_FunctionAddress, "bInTickInEditor");
		SetTickInEditor_bInTickInEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickInEditor_FunctionAddress, "bInTickInEditor", Classes.FBoolProperty);
		SetTickInEditor_IsValid = SetTickInEditor_FunctionAddress != IntPtr.Zero && SetTickInEditor_bInTickInEditor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:SetTickInEditor", SetTickInEditor_IsValid);
		SetMulticastLoopback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMulticastLoopback");
		SetMulticastLoopback_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMulticastLoopback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMulticastLoopback_bMulticastLoopback_PropertyAddress, SetMulticastLoopback_FunctionAddress, "bMulticastLoopback");
		SetMulticastLoopback_bMulticastLoopback_Offset = NativeReflectionCached.GetPropertyOffset(SetMulticastLoopback_FunctionAddress, "bMulticastLoopback");
		SetMulticastLoopback_bMulticastLoopback_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMulticastLoopback_FunctionAddress, "bMulticastLoopback", Classes.FBoolProperty);
		SetMulticastLoopback_IsValid = SetMulticastLoopback_FunctionAddress != IntPtr.Zero && SetMulticastLoopback_bMulticastLoopback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:SetMulticastLoopback", SetMulticastLoopback_IsValid);
		SetAllowlistClientsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllowlistClientsEnabled");
		SetAllowlistClientsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowlistClientsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowlistClientsEnabled_bEnabled_PropertyAddress, SetAllowlistClientsEnabled_FunctionAddress, "bEnabled");
		SetAllowlistClientsEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowlistClientsEnabled_FunctionAddress, "bEnabled");
		SetAllowlistClientsEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowlistClientsEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetAllowlistClientsEnabled_IsValid = SetAllowlistClientsEnabled_FunctionAddress != IntPtr.Zero && SetAllowlistClientsEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:SetAllowlistClientsEnabled", SetAllowlistClientsEnabled_IsValid);
		SetAddress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAddress");
		SetAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAddress_ReceiveIPAddress_PropertyAddress, SetAddress_FunctionAddress, "ReceiveIPAddress");
		SetAddress_ReceiveIPAddress_Offset = NativeReflectionCached.GetPropertyOffset(SetAddress_FunctionAddress, "ReceiveIPAddress");
		SetAddress_ReceiveIPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAddress_FunctionAddress, "ReceiveIPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAddress_Port_PropertyAddress, SetAddress_FunctionAddress, "Port");
		SetAddress_Port_Offset = NativeReflectionCached.GetPropertyOffset(SetAddress_FunctionAddress, "Port");
		SetAddress_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAddress_FunctionAddress, "Port", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAddress_ReturnValue_PropertyAddress, SetAddress_FunctionAddress, "ReturnValue");
		SetAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAddress_FunctionAddress, "ReturnValue");
		SetAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAddress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAddress_IsValid = SetAddress_FunctionAddress != IntPtr.Zero && SetAddress_ReceiveIPAddress_IsValid && SetAddress_Port_IsValid && SetAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:SetAddress", SetAddress_IsValid);
		RemoveAllowlistedClient_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveAllowlistedClient");
		RemoveAllowlistedClient_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllowlistedClient_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllowlistedClient_IPAddress_PropertyAddress, RemoveAllowlistedClient_FunctionAddress, "IPAddress");
		RemoveAllowlistedClient_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllowlistedClient_FunctionAddress, "IPAddress");
		RemoveAllowlistedClient_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllowlistedClient_FunctionAddress, "IPAddress", Classes.FStrProperty);
		RemoveAllowlistedClient_IsValid = RemoveAllowlistedClient_FunctionAddress != IntPtr.Zero && RemoveAllowlistedClient_IPAddress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:RemoveAllowlistedClient", RemoveAllowlistedClient_IsValid);
		Listen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Listen");
		Listen_ParamsSize = NativeReflection.GetFunctionParamsSize(Listen_FunctionAddress);
		Listen_IsValid = Listen_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:Listen", Listen_IsValid);
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:IsActive", IsActive_IsValid);
		GetPort_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPort");
		GetPort_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPort_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPort_ReturnValue_PropertyAddress, GetPort_FunctionAddress, "ReturnValue");
		GetPort_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPort_FunctionAddress, "ReturnValue");
		GetPort_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPort_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPort_IsValid = GetPort_FunctionAddress != IntPtr.Zero && GetPort_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:GetPort", GetPort_IsValid);
		GetMulticastLoopback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMulticastLoopback");
		GetMulticastLoopback_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMulticastLoopback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMulticastLoopback_ReturnValue_PropertyAddress, GetMulticastLoopback_FunctionAddress, "ReturnValue");
		GetMulticastLoopback_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMulticastLoopback_FunctionAddress, "ReturnValue");
		GetMulticastLoopback_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMulticastLoopback_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetMulticastLoopback_IsValid = GetMulticastLoopback_FunctionAddress != IntPtr.Zero && GetMulticastLoopback_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:GetMulticastLoopback", GetMulticastLoopback_IsValid);
		GetIpAddress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIpAddress");
		GetIpAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIpAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIpAddress_bIncludePort_PropertyAddress, GetIpAddress_FunctionAddress, "bIncludePort");
		GetIpAddress_bIncludePort_Offset = NativeReflectionCached.GetPropertyOffset(GetIpAddress_FunctionAddress, "bIncludePort");
		GetIpAddress_bIncludePort_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIpAddress_FunctionAddress, "bIncludePort", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIpAddress_ReturnValue_PropertyAddress, GetIpAddress_FunctionAddress, "ReturnValue");
		GetIpAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIpAddress_FunctionAddress, "ReturnValue");
		GetIpAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIpAddress_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetIpAddress_IsValid = GetIpAddress_FunctionAddress != IntPtr.Zero && GetIpAddress_bIncludePort_IsValid && GetIpAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:GetIpAddress", GetIpAddress_IsValid);
		GetBoundOSCAddressPatterns_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoundOSCAddressPatterns");
		GetBoundOSCAddressPatterns_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundOSCAddressPatterns_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundOSCAddressPatterns_ReturnValue_PropertyAddress, GetBoundOSCAddressPatterns_FunctionAddress, "ReturnValue");
		GetBoundOSCAddressPatterns_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundOSCAddressPatterns_FunctionAddress, "ReturnValue");
		GetBoundOSCAddressPatterns_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundOSCAddressPatterns_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoundOSCAddressPatterns_IsValid = GetBoundOSCAddressPatterns_FunctionAddress != IntPtr.Zero && GetBoundOSCAddressPatterns_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:GetBoundOSCAddressPatterns", GetBoundOSCAddressPatterns_IsValid);
		GetAllowlistedClients_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllowlistedClients");
		GetAllowlistedClients_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllowlistedClients_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllowlistedClients_ReturnValue_PropertyAddress, GetAllowlistedClients_FunctionAddress, "ReturnValue");
		GetAllowlistedClients_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllowlistedClients_FunctionAddress, "ReturnValue");
		GetAllowlistedClients_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllowlistedClients_FunctionAddress, "ReturnValue", Classes.FSetProperty);
		GetAllowlistedClients_IsValid = GetAllowlistedClients_FunctionAddress != IntPtr.Zero && GetAllowlistedClients_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:GetAllowlistedClients", GetAllowlistedClients_IsValid);
		ClearAllowlistedClients_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAllowlistedClients");
		ClearAllowlistedClients_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllowlistedClients_FunctionAddress);
		ClearAllowlistedClients_IsValid = ClearAllowlistedClients_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:ClearAllowlistedClients", ClearAllowlistedClients_IsValid);
		BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BindEventToOnOSCAddressPatternMatchesPath");
		BindEventToOnOSCAddressPatternMatchesPath_ParamsSize = NativeReflection.GetFunctionParamsSize(BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_PropertyAddress, BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern");
		BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_Offset = NativeReflectionCached.GetPropertyOffset(BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern");
		BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, "OSCAddressPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BindEventToOnOSCAddressPatternMatchesPath_Event_PropertyAddress, BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, "Event");
		BindEventToOnOSCAddressPatternMatchesPath_Event_Offset = NativeReflectionCached.GetPropertyOffset(BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, "Event");
		BindEventToOnOSCAddressPatternMatchesPath_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress, "Event", Classes.FDelegateProperty);
		BindEventToOnOSCAddressPatternMatchesPath_IsValid = BindEventToOnOSCAddressPatternMatchesPath_FunctionAddress != IntPtr.Zero && BindEventToOnOSCAddressPatternMatchesPath_OSCAddressPattern_IsValid && BindEventToOnOSCAddressPatternMatchesPath_Event_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:BindEventToOnOSCAddressPatternMatchesPath", BindEventToOnOSCAddressPatternMatchesPath_IsValid);
		AddAllowlistedClient_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddAllowlistedClient");
		AddAllowlistedClient_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAllowlistedClient_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAllowlistedClient_IPAddress_PropertyAddress, AddAllowlistedClient_FunctionAddress, "IPAddress");
		AddAllowlistedClient_IPAddress_Offset = NativeReflectionCached.GetPropertyOffset(AddAllowlistedClient_FunctionAddress, "IPAddress");
		AddAllowlistedClient_IPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAllowlistedClient_FunctionAddress, "IPAddress", Classes.FStrProperty);
		AddAllowlistedClient_IsValid = AddAllowlistedClient_FunctionAddress != IntPtr.Zero && AddAllowlistedClient_IPAddress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCServer:AddAllowlistedClient", AddAllowlistedClient_IsValid);
	}
}
