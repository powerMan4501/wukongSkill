using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.HttpResposeListener", "UnrealExtent", UnrealModuleType.Game)]
public class UHttpResposeListener : UObject
{
	private static bool OnRequestProgress_IsValid;

	private IntPtr OnRequestProgress_InstanceFunctionAddress;

	private static IntPtr OnRequestProgress_FunctionAddress;

	private static int OnRequestProgress_ParamsSize;

	private static bool OnRequestProgress_sentBytes_IsValid;

	private static FFieldAddress OnRequestProgress_sentBytes_PropertyAddress;

	private static int OnRequestProgress_sentBytes_Offset;

	private static bool OnRequestProgress_lReceivedBytes_IsValid;

	private static FFieldAddress OnRequestProgress_lReceivedBytes_PropertyAddress;

	private static int OnRequestProgress_lReceivedBytes_Offset;

	private static bool OnRequestProgress_lTotalBytes_IsValid;

	private static FFieldAddress OnRequestProgress_lTotalBytes_PropertyAddress;

	private static int OnRequestProgress_lTotalBytes_Offset;

	private static bool OnReponseComplete_IsValid;

	private IntPtr OnReponseComplete_InstanceFunctionAddress;

	private static IntPtr OnReponseComplete_FunctionAddress;

	private static int OnReponseComplete_ParamsSize;

	private static bool OnReponseComplete_bSuccess_IsValid;

	private static FFieldAddress OnReponseComplete_bSuccess_PropertyAddress;

	private static int OnReponseComplete_bSuccess_Offset;

	private static bool OnReponseComplete_HttpCode_IsValid;

	private static FFieldAddress OnReponseComplete_HttpCode_PropertyAddress;

	private static int OnReponseComplete_HttpCode_Offset;

	private static bool OnReponseComplete_content_IsValid;

	private static FFieldAddress OnReponseComplete_content_PropertyAddress;

	private static int OnReponseComplete_content_Offset;

	private static bool IsNeedProgress_IsValid;

	private IntPtr IsNeedProgress_InstanceFunctionAddress;

	private static IntPtr IsNeedProgress_FunctionAddress;

	private static int IsNeedProgress_ParamsSize;

	private static bool IsNeedProgress_ReturnValue_IsValid;

	private static FFieldAddress IsNeedProgress_ReturnValue_PropertyAddress;

	private static int IsNeedProgress_ReturnValue_Offset;

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/UnrealExtent.HttpResposeListener:OnRequestProgress")]
	public unsafe void OnRequestProgress(int sentBytes, int lReceivedBytes, int lTotalBytes)
	{
		CheckDestroyed();
		if (!OnRequestProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HttpResposeListener:OnRequestProgress");
			return;
		}
		if (OnRequestProgress_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRequestProgress_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRequestProgress");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRequestProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRequestProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestProgress_sentBytes_Offset), 0, OnRequestProgress_sentBytes_PropertyAddress.Address, sentBytes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestProgress_lReceivedBytes_Offset), 0, OnRequestProgress_lReceivedBytes_PropertyAddress.Address, lReceivedBytes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestProgress_lTotalBytes_Offset), 0, OnRequestProgress_lTotalBytes_PropertyAddress.Address, lTotalBytes);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRequestProgress_InstanceFunctionAddress, intPtr, OnRequestProgress_ParamsSize);
	}

	protected unsafe virtual void OnRequestProgress_Implementation(int sentBytes, int lReceivedBytes, int lTotalBytes)
	{
		CheckDestroyed();
		if (!OnRequestProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HttpResposeListener:OnRequestProgress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRequestProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRequestProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestProgress_sentBytes_Offset), 0, OnRequestProgress_sentBytes_PropertyAddress.Address, sentBytes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestProgress_lReceivedBytes_Offset), 0, OnRequestProgress_lReceivedBytes_PropertyAddress.Address, lReceivedBytes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestProgress_lTotalBytes_Offset), 0, OnRequestProgress_lTotalBytes_PropertyAddress.Address, lTotalBytes);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRequestProgress_FunctionAddress, intPtr, OnRequestProgress_ParamsSize);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/UnrealExtent.HttpResposeListener:OnReponseComplete")]
	public unsafe void OnReponseComplete(bool bSuccess, int HttpCode, List<byte> content)
	{
		CheckDestroyed();
		if (!OnReponseComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HttpResposeListener:OnReponseComplete");
			return;
		}
		if (OnReponseComplete_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReponseComplete_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReponseComplete");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReponseComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReponseComplete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnReponseComplete_bSuccess_Offset), 0, OnReponseComplete_bSuccess_PropertyAddress.Address, bSuccess);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnReponseComplete_HttpCode_Offset), 0, OnReponseComplete_HttpCode_PropertyAddress.Address, HttpCode);
		new TArrayCopyMarshaler<byte>(1, OnReponseComplete_content_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, OnReponseComplete_content_Offset), content);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReponseComplete_InstanceFunctionAddress, intPtr, OnReponseComplete_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnReponseComplete_content_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnReponseComplete_Implementation(bool bSuccess, int HttpCode, List<byte> content)
	{
		CheckDestroyed();
		if (!OnReponseComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HttpResposeListener:OnReponseComplete");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReponseComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReponseComplete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnReponseComplete_bSuccess_Offset), 0, OnReponseComplete_bSuccess_PropertyAddress.Address, bSuccess);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnReponseComplete_HttpCode_Offset), 0, OnReponseComplete_HttpCode_PropertyAddress.Address, HttpCode);
		new TArrayCopyMarshaler<byte>(1, OnReponseComplete_content_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, OnReponseComplete_content_Offset), content);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReponseComplete_FunctionAddress, intPtr, OnReponseComplete_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnReponseComplete_content_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/UnrealExtent.HttpResposeListener:IsNeedProgress")]
	public unsafe bool IsNeedProgress()
	{
		CheckDestroyed();
		if (!IsNeedProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HttpResposeListener:IsNeedProgress");
			return false;
		}
		if (IsNeedProgress_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsNeedProgress_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsNeedProgress");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNeedProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNeedProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsNeedProgress_InstanceFunctionAddress, intPtr, IsNeedProgress_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNeedProgress_ReturnValue_Offset), 0, IsNeedProgress_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsNeedProgress_Implementation()
	{
		CheckDestroyed();
		if (!IsNeedProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.HttpResposeListener:IsNeedProgress");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNeedProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNeedProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsNeedProgress_FunctionAddress, intPtr, IsNeedProgress_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNeedProgress_ReturnValue_Offset), 0, IsNeedProgress_ReturnValue_PropertyAddress.Address);
	}

	static UHttpResposeListener()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHttpResposeListener)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHttpResposeListener));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.HttpResposeListener");
		OnRequestProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRequestProgress");
		OnRequestProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRequestProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRequestProgress_sentBytes_PropertyAddress, OnRequestProgress_FunctionAddress, "sentBytes");
		OnRequestProgress_sentBytes_Offset = NativeReflectionCached.GetPropertyOffset(OnRequestProgress_FunctionAddress, "sentBytes");
		OnRequestProgress_sentBytes_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRequestProgress_FunctionAddress, "sentBytes", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnRequestProgress_lReceivedBytes_PropertyAddress, OnRequestProgress_FunctionAddress, "lReceivedBytes");
		OnRequestProgress_lReceivedBytes_Offset = NativeReflectionCached.GetPropertyOffset(OnRequestProgress_FunctionAddress, "lReceivedBytes");
		OnRequestProgress_lReceivedBytes_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRequestProgress_FunctionAddress, "lReceivedBytes", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnRequestProgress_lTotalBytes_PropertyAddress, OnRequestProgress_FunctionAddress, "lTotalBytes");
		OnRequestProgress_lTotalBytes_Offset = NativeReflectionCached.GetPropertyOffset(OnRequestProgress_FunctionAddress, "lTotalBytes");
		OnRequestProgress_lTotalBytes_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRequestProgress_FunctionAddress, "lTotalBytes", Classes.FIntProperty);
		OnRequestProgress_IsValid = OnRequestProgress_FunctionAddress != IntPtr.Zero && OnRequestProgress_sentBytes_IsValid && OnRequestProgress_lReceivedBytes_IsValid && OnRequestProgress_lTotalBytes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.HttpResposeListener:OnRequestProgress", OnRequestProgress_IsValid);
		OnReponseComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReponseComplete");
		OnReponseComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReponseComplete_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReponseComplete_bSuccess_PropertyAddress, OnReponseComplete_FunctionAddress, "bSuccess");
		OnReponseComplete_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnReponseComplete_FunctionAddress, "bSuccess");
		OnReponseComplete_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReponseComplete_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnReponseComplete_HttpCode_PropertyAddress, OnReponseComplete_FunctionAddress, "HttpCode");
		OnReponseComplete_HttpCode_Offset = NativeReflectionCached.GetPropertyOffset(OnReponseComplete_FunctionAddress, "HttpCode");
		OnReponseComplete_HttpCode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReponseComplete_FunctionAddress, "HttpCode", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnReponseComplete_content_PropertyAddress, OnReponseComplete_FunctionAddress, "content");
		OnReponseComplete_content_Offset = NativeReflectionCached.GetPropertyOffset(OnReponseComplete_FunctionAddress, "content");
		OnReponseComplete_content_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReponseComplete_FunctionAddress, "content", Classes.FArrayProperty);
		OnReponseComplete_IsValid = OnReponseComplete_FunctionAddress != IntPtr.Zero && OnReponseComplete_bSuccess_IsValid && OnReponseComplete_HttpCode_IsValid && OnReponseComplete_content_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.HttpResposeListener:OnReponseComplete", OnReponseComplete_IsValid);
		IsNeedProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsNeedProgress");
		IsNeedProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNeedProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNeedProgress_ReturnValue_PropertyAddress, IsNeedProgress_FunctionAddress, "ReturnValue");
		IsNeedProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNeedProgress_FunctionAddress, "ReturnValue");
		IsNeedProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNeedProgress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNeedProgress_IsValid = IsNeedProgress_FunctionAddress != IntPtr.Zero && IsNeedProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.HttpResposeListener:IsNeedProgress", IsNeedProgress_IsValid);
	}
}
