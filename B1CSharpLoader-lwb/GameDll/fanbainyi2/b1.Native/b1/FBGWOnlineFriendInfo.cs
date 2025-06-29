using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineFriendInfo", "b1", UnrealModuleType.Game)]
public struct FBGWOnlineFriendInfo
{
	private static bool SessionId_IsValid;

	private static int SessionId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:SessionId")]
	public string SessionId;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:DisplayName")]
	public string DisplayName;

	private static bool RealName_IsValid;

	private static int RealName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:RealName")]
	public string RealName;

	private static bool IsOnline_IsValid;

	private static FFieldAddress IsOnline_PropertyAddress;

	private static int IsOnline_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:bIsOnline")]
	public bool IsOnline;

	private static bool IsPlaying_IsValid;

	private static FFieldAddress IsPlaying_PropertyAddress;

	private static int IsPlaying_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:bIsPlaying")]
	public bool IsPlaying;

	private static bool IsPlayingThisGame_IsValid;

	private static FFieldAddress IsPlayingThisGame_PropertyAddress;

	private static int IsPlayingThisGame_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:bIsPlayingThisGame")]
	public bool IsPlayingThisGame;

	private static bool IsJoinable_IsValid;

	private static FFieldAddress IsJoinable_PropertyAddress;

	private static int IsJoinable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:bIsJoinable")]
	public bool IsJoinable;

	private static bool HasVoiceSupport_IsValid;

	private static FFieldAddress HasVoiceSupport_PropertyAddress;

	private static int HasVoiceSupport_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:bHasVoiceSupport")]
	public bool HasVoiceSupport;

	private static bool Status_IsValid;

	private static FFieldAddress Status_PropertyAddress;

	private static int Status_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineFriendInfo:Status")]
	public EFriendsStateType Status;

	private static bool FBGWOnlineFriendInfo_IsValid;

	private static int FBGWOnlineFriendInfo_StructSize;

	public FBGWOnlineFriendInfo Copy()
	{
		return this;
	}

	public static FBGWOnlineFriendInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBGWOnlineFriendInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGWOnlineFriendInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGWOnlineFriendInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGWOnlineFriendInfo(nativeBuffer + arrayIndex * FBGWOnlineFriendInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGWOnlineFriendInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGWOnlineFriendInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGWOnlineFriendInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineFriendInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SessionId_Offset), SessionId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, RealName_Offset), RealName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsOnline_Offset), 0, IsOnline_PropertyAddress.Address, IsOnline);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address, IsPlaying);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPlayingThisGame_Offset), 0, IsPlayingThisGame_PropertyAddress.Address, IsPlayingThisGame);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsJoinable_Offset), 0, IsJoinable_PropertyAddress.Address, IsJoinable);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasVoiceSupport_Offset), 0, HasVoiceSupport_PropertyAddress.Address, HasVoiceSupport);
		EnumMarshaler<EFriendsStateType>.ToNative(IntPtr.Add(nativeStruct, Status_Offset), 0, Status_PropertyAddress.Address, Status);
	}

	public FBGWOnlineFriendInfo(IntPtr nativeStruct)
	{
		if (!FBGWOnlineFriendInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineFriendInfo");
			SessionId = FStringMarshaler.DefaultString;
			DisplayName = FStringMarshaler.DefaultString;
			RealName = FStringMarshaler.DefaultString;
			IsOnline = false;
			IsPlaying = false;
			IsPlayingThisGame = false;
			IsJoinable = false;
			HasVoiceSupport = false;
			Status = EFriendsStateType.Online;
		}
		else
		{
			SessionId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SessionId_Offset));
			DisplayName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			RealName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, RealName_Offset));
			IsOnline = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsOnline_Offset), 0, IsOnline_PropertyAddress.Address);
			IsPlaying = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address);
			IsPlayingThisGame = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPlayingThisGame_Offset), 0, IsPlayingThisGame_PropertyAddress.Address);
			IsJoinable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsJoinable_Offset), 0, IsJoinable_PropertyAddress.Address);
			HasVoiceSupport = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasVoiceSupport_Offset), 0, HasVoiceSupport_PropertyAddress.Address);
			Status = EnumMarshaler<EFriendsStateType>.FromNative(IntPtr.Add(nativeStruct, Status_Offset), 0, Status_PropertyAddress.Address);
		}
	}

	static FBGWOnlineFriendInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGWOnlineFriendInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGWOnlineFriendInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BGWOnlineFriendInfo");
		FBGWOnlineFriendInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SessionId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SessionId");
		SessionId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SessionId", Classes.FStrProperty);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FStrProperty);
		RealName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RealName");
		RealName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RealName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOnline_PropertyAddress, intPtr, "bIsOnline");
		IsOnline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsOnline");
		IsOnline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsOnline", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_PropertyAddress, intPtr, "bIsPlaying");
		IsPlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPlaying");
		IsPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPlaying", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingThisGame_PropertyAddress, intPtr, "bIsPlayingThisGame");
		IsPlayingThisGame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsPlayingThisGame");
		IsPlayingThisGame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsPlayingThisGame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsJoinable_PropertyAddress, intPtr, "bIsJoinable");
		IsJoinable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsJoinable");
		IsJoinable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsJoinable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasVoiceSupport_PropertyAddress, intPtr, "bHasVoiceSupport");
		HasVoiceSupport_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasVoiceSupport");
		HasVoiceSupport_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasVoiceSupport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Status_PropertyAddress, intPtr, "Status");
		Status_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Status");
		Status_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Status", Classes.FEnumProperty);
		FBGWOnlineFriendInfo_IsValid = intPtr != IntPtr.Zero && SessionId_IsValid && DisplayName_IsValid && RealName_IsValid && IsOnline_IsValid && IsPlaying_IsValid && IsPlayingThisGame_IsValid && IsJoinable_IsValid && HasVoiceSupport_IsValid && Status_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BGWOnlineFriendInfo", FBGWOnlineFriendInfo_IsValid);
	}
}
