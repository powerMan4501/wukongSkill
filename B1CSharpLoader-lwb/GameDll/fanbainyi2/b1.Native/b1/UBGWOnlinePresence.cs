using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlinePresence", "b1", UnrealModuleType.Game)]
public class UBGWOnlinePresence : UBGWOnlineInterface
{
	private static bool SetRichPresence_IsValid;

	private static IntPtr SetRichPresence_FunctionAddress;

	private static int SetRichPresence_ParamsSize;

	private static bool SetRichPresence_PresenceId_IsValid;

	private static FFieldAddress SetRichPresence_PresenceId_PropertyAddress;

	private static int SetRichPresence_PresenceId_Offset;

	private static bool SetRichPresence_StatusStr_IsValid;

	private static FFieldAddress SetRichPresence_StatusStr_PropertyAddress;

	private static int SetRichPresence_StatusStr_Offset;

	private static bool SetRichPresence_Properties_IsValid;

	private static FFieldAddress SetRichPresence_Properties_PropertyAddress;

	private static int SetRichPresence_Properties_Offset;

	private static bool OnSetPresenceCompleteCS_IsValid;

	private IntPtr OnSetPresenceCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnSetPresenceCompleteCS_FunctionAddress;

	private static int OnSetPresenceCompleteCS_ParamsSize;

	private static bool OnSetPresenceCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnSetPresenceCompleteCS_bWasSuccessful_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlinePresence:SetRichPresence")]
	public unsafe void SetRichPresence(string PresenceId, string StatusStr, Dictionary<string, string> Properties)
	{
		CheckDestroyed();
		if (!SetRichPresence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlinePresence:SetRichPresence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRichPresence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRichPresence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetRichPresence_PresenceId_Offset), 0, SetRichPresence_PresenceId_PropertyAddress.Address, PresenceId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetRichPresence_StatusStr_Offset), 0, SetRichPresence_StatusStr_PropertyAddress.Address, StatusStr);
		NativeReflection.InitializeValue_InContainer(SetRichPresence_Properties_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, SetRichPresence_Properties_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetRichPresence_Properties_Offset), Properties);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRichPresence_FunctionAddress, intPtr, SetRichPresence_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRichPresence_PresenceId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetRichPresence_StatusStr_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetRichPresence_Properties_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlinePresence:OnSetPresenceCompleteCS")]
	protected unsafe void OnSetPresenceCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnSetPresenceCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlinePresence:OnSetPresenceCompleteCS");
			return;
		}
		if (OnSetPresenceCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSetPresenceCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSetPresenceCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetPresenceCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetPresenceCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetPresenceCompleteCS_bWasSuccessful_Offset), 0, OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetPresenceCompleteCS_InstanceFunctionAddress, intPtr, OnSetPresenceCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnSetPresenceCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnSetPresenceCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlinePresence:OnSetPresenceCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetPresenceCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetPresenceCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetPresenceCompleteCS_bWasSuccessful_Offset), 0, OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetPresenceCompleteCS_FunctionAddress, intPtr, OnSetPresenceCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlinePresence:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlinePresence:Init");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Init_ReturnValue_Offset), 0, Init_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlinePresence:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlinePresence:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	static UBGWOnlinePresence()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlinePresence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlinePresence));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWOnlinePresence");
		SetRichPresence_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRichPresence");
		SetRichPresence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRichPresence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRichPresence_PresenceId_PropertyAddress, SetRichPresence_FunctionAddress, "PresenceId");
		SetRichPresence_PresenceId_Offset = NativeReflectionCached.GetPropertyOffset(SetRichPresence_FunctionAddress, "PresenceId");
		SetRichPresence_PresenceId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRichPresence_FunctionAddress, "PresenceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRichPresence_StatusStr_PropertyAddress, SetRichPresence_FunctionAddress, "StatusStr");
		SetRichPresence_StatusStr_Offset = NativeReflectionCached.GetPropertyOffset(SetRichPresence_FunctionAddress, "StatusStr");
		SetRichPresence_StatusStr_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRichPresence_FunctionAddress, "StatusStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRichPresence_Properties_PropertyAddress, SetRichPresence_FunctionAddress, "Properties");
		SetRichPresence_Properties_Offset = NativeReflectionCached.GetPropertyOffset(SetRichPresence_FunctionAddress, "Properties");
		SetRichPresence_Properties_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRichPresence_FunctionAddress, "Properties", Classes.FMapProperty);
		SetRichPresence_IsValid = SetRichPresence_FunctionAddress != IntPtr.Zero && SetRichPresence_PresenceId_IsValid && SetRichPresence_StatusStr_IsValid && SetRichPresence_Properties_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlinePresence:SetRichPresence", SetRichPresence_IsValid);
		OnSetPresenceCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetPresenceCompleteCS");
		OnSetPresenceCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetPresenceCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress, OnSetPresenceCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetPresenceCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnSetPresenceCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetPresenceCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetPresenceCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnSetPresenceCompleteCS_IsValid = OnSetPresenceCompleteCS_FunctionAddress != IntPtr.Zero && OnSetPresenceCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlinePresence:OnSetPresenceCompleteCS", OnSetPresenceCompleteCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlinePresence:Init", Init_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlinePresence:Destroy", Destroy_IsValid);
	}
}
