using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineFriend", "b1", UnrealModuleType.Game)]
public class UBGWOnlineFriend : UBGWOnlineInterface
{
	private static bool ReadFriendsList_IsValid;

	private static IntPtr ReadFriendsList_FunctionAddress;

	private static int ReadFriendsList_ParamsSize;

	private static bool ReadFriendsList_ListType_IsValid;

	private static FFieldAddress ReadFriendsList_ListType_PropertyAddress;

	private static int ReadFriendsList_ListType_Offset;

	private static bool OnReadFriendListCompleteCS_IsValid;

	private IntPtr OnReadFriendListCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnReadFriendListCompleteCS_FunctionAddress;

	private static int OnReadFriendListCompleteCS_ParamsSize;

	private static bool OnReadFriendListCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnReadFriendListCompleteCS_bWasSuccessful_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool GetFriendsList_IsValid;

	private static IntPtr GetFriendsList_FunctionAddress;

	private static int GetFriendsList_ParamsSize;

	private static bool GetFriendsList_ListType_IsValid;

	private static FFieldAddress GetFriendsList_ListType_PropertyAddress;

	private static int GetFriendsList_ListType_Offset;

	private static bool GetFriendsList_OutFriends_IsValid;

	private static FFieldAddress GetFriendsList_OutFriends_PropertyAddress;

	private static int GetFriendsList_OutFriends_Offset;

	private static bool GetFriendsList_ReturnValue_IsValid;

	private static FFieldAddress GetFriendsList_ReturnValue_PropertyAddress;

	private static int GetFriendsList_ReturnValue_Offset;

	private static bool GetFriend_IsValid;

	private static IntPtr GetFriend_FunctionAddress;

	private static int GetFriend_ParamsSize;

	private static bool GetFriend_ListName_IsValid;

	private static FFieldAddress GetFriend_ListName_PropertyAddress;

	private static int GetFriend_ListName_Offset;

	private static bool GetFriend_ReturnValue_IsValid;

	private static FFieldAddress GetFriend_ReturnValue_PropertyAddress;

	private static int GetFriend_ReturnValue_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineFriend:ReadFriendsList")]
	public unsafe void ReadFriendsList(EFriendsListsType ListType)
	{
		CheckDestroyed();
		if (!ReadFriendsList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:ReadFriendsList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadFriendsList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadFriendsList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFriendsListsType>.ToNative(IntPtr.Add(intPtr, ReadFriendsList_ListType_Offset), 0, ReadFriendsList_ListType_PropertyAddress.Address, ListType);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReadFriendsList_FunctionAddress, intPtr, ReadFriendsList_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineFriend:OnReadFriendListCompleteCS")]
	protected unsafe void OnReadFriendListCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnReadFriendListCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:OnReadFriendListCompleteCS");
			return;
		}
		if (OnReadFriendListCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReadFriendListCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReadFriendListCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReadFriendListCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReadFriendListCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnReadFriendListCompleteCS_bWasSuccessful_Offset), 0, OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReadFriendListCompleteCS_InstanceFunctionAddress, intPtr, OnReadFriendListCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnReadFriendListCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnReadFriendListCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:OnReadFriendListCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReadFriendListCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReadFriendListCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnReadFriendListCompleteCS_bWasSuccessful_Offset), 0, OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReadFriendListCompleteCS_FunctionAddress, intPtr, OnReadFriendListCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineFriend:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:Init");
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

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BGWOnlineFriend:GetFriendsList")]
	public unsafe bool GetFriendsList(EFriendsListsType ListType, out List<FBGWOnlineFriendInfo> OutFriends)
	{
		CheckDestroyed();
		if (!GetFriendsList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:GetFriendsList");
			OutFriends = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFriendsList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFriendsList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFriendsListsType>.ToNative(IntPtr.Add(intPtr, GetFriendsList_ListType_Offset), 0, GetFriendsList_ListType_PropertyAddress.Address, ListType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFriendsList_FunctionAddress, intPtr, GetFriendsList_ParamsSize);
		OutFriends = new TArrayCopyMarshaler<FBGWOnlineFriendInfo>(1, GetFriendsList_OutFriends_PropertyAddress, CachedMarshalingDelegates<FBGWOnlineFriendInfo, FBGWOnlineFriendInfo>.FromNative, CachedMarshalingDelegates<FBGWOnlineFriendInfo, FBGWOnlineFriendInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetFriendsList_OutFriends_Offset));
		NativeReflection.DestroyValue_InContainer(GetFriendsList_OutFriends_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFriendsList_ReturnValue_Offset), 0, GetFriendsList_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineFriend:GetFriend")]
	public unsafe bool GetFriend(string ListName)
	{
		CheckDestroyed();
		if (!GetFriend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:GetFriend");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFriend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFriend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFriend_ListName_Offset), 0, GetFriend_ListName_PropertyAddress.Address, ListName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFriend_FunctionAddress, intPtr, GetFriend_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFriend_ListName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFriend_ReturnValue_Offset), 0, GetFriend_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineFriend:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineFriend:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	static UBGWOnlineFriend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineFriend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineFriend));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWOnlineFriend");
		ReadFriendsList_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReadFriendsList");
		ReadFriendsList_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadFriendsList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadFriendsList_ListType_PropertyAddress, ReadFriendsList_FunctionAddress, "ListType");
		ReadFriendsList_ListType_Offset = NativeReflectionCached.GetPropertyOffset(ReadFriendsList_FunctionAddress, "ListType");
		ReadFriendsList_ListType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFriendsList_FunctionAddress, "ListType", Classes.FByteProperty);
		ReadFriendsList_IsValid = ReadFriendsList_FunctionAddress != IntPtr.Zero && ReadFriendsList_ListType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineFriend:ReadFriendsList", ReadFriendsList_IsValid);
		OnReadFriendListCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReadFriendListCompleteCS");
		OnReadFriendListCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReadFriendListCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress, OnReadFriendListCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadFriendListCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnReadFriendListCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadFriendListCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReadFriendListCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnReadFriendListCompleteCS_IsValid = OnReadFriendListCompleteCS_FunctionAddress != IntPtr.Zero && OnReadFriendListCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineFriend:OnReadFriendListCompleteCS", OnReadFriendListCompleteCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineFriend:Init", Init_IsValid);
		GetFriendsList_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFriendsList");
		GetFriendsList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFriendsList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFriendsList_ListType_PropertyAddress, GetFriendsList_FunctionAddress, "ListType");
		GetFriendsList_ListType_Offset = NativeReflectionCached.GetPropertyOffset(GetFriendsList_FunctionAddress, "ListType");
		GetFriendsList_ListType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFriendsList_FunctionAddress, "ListType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFriendsList_OutFriends_PropertyAddress, GetFriendsList_FunctionAddress, "OutFriends");
		GetFriendsList_OutFriends_Offset = NativeReflectionCached.GetPropertyOffset(GetFriendsList_FunctionAddress, "OutFriends");
		GetFriendsList_OutFriends_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFriendsList_FunctionAddress, "OutFriends", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFriendsList_ReturnValue_PropertyAddress, GetFriendsList_FunctionAddress, "ReturnValue");
		GetFriendsList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFriendsList_FunctionAddress, "ReturnValue");
		GetFriendsList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFriendsList_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetFriendsList_IsValid = GetFriendsList_FunctionAddress != IntPtr.Zero && GetFriendsList_ListType_IsValid && GetFriendsList_OutFriends_IsValid && GetFriendsList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineFriend:GetFriendsList", GetFriendsList_IsValid);
		GetFriend_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFriend");
		GetFriend_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFriend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFriend_ListName_PropertyAddress, GetFriend_FunctionAddress, "ListName");
		GetFriend_ListName_Offset = NativeReflectionCached.GetPropertyOffset(GetFriend_FunctionAddress, "ListName");
		GetFriend_ListName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFriend_FunctionAddress, "ListName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFriend_ReturnValue_PropertyAddress, GetFriend_FunctionAddress, "ReturnValue");
		GetFriend_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFriend_FunctionAddress, "ReturnValue");
		GetFriend_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFriend_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetFriend_IsValid = GetFriend_FunctionAddress != IntPtr.Zero && GetFriend_ListName_IsValid && GetFriend_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineFriend:GetFriend", GetFriend_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineFriend:Destroy", Destroy_IsValid);
	}
}
