using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineAchievementDesc", "b1", UnrealModuleType.Game)]
public struct FBGWOnlineAchievementDesc
{
	private static bool Title_IsValid;

	private static int Title_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementDesc:Title")]
	public FText Title;

	private static bool LockedDesc_IsValid;

	private static int LockedDesc_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementDesc:LockedDesc")]
	public FText LockedDesc;

	private static bool UnlockedDesc_IsValid;

	private static int UnlockedDesc_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementDesc:UnlockedDesc")]
	public FText UnlockedDesc;

	private static bool IsHidden_IsValid;

	private static FFieldAddress IsHidden_PropertyAddress;

	private static int IsHidden_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementDesc:bIsHidden")]
	public bool IsHidden;

	private static bool UnlockTime_IsValid;

	private static int UnlockTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532996uL)]
	[UMetaPath("/Script/b1.BGWOnlineAchievementDesc:UnlockTime")]
	public FDateTime UnlockTime;

	private static bool FBGWOnlineAchievementDesc_IsValid;

	private static int FBGWOnlineAchievementDesc_StructSize;

	public FBGWOnlineAchievementDesc Copy()
	{
		return this;
	}

	public static FBGWOnlineAchievementDesc FromNative(IntPtr nativeBuffer)
	{
		return new FBGWOnlineAchievementDesc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGWOnlineAchievementDesc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGWOnlineAchievementDesc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGWOnlineAchievementDesc(nativeBuffer + arrayIndex * FBGWOnlineAchievementDesc_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGWOnlineAchievementDesc value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGWOnlineAchievementDesc_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGWOnlineAchievementDesc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineAchievementDesc");
			return;
		}
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Title_Offset), Title);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, LockedDesc_Offset), LockedDesc);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, UnlockedDesc_Offset), UnlockedDesc);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsHidden_Offset), 0, IsHidden_PropertyAddress.Address, IsHidden);
		FDateTime.ToNative(IntPtr.Add(nativeStruct, UnlockTime_Offset), UnlockTime);
	}

	public FBGWOnlineAchievementDesc(IntPtr nativeStruct)
	{
		if (!FBGWOnlineAchievementDesc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGWOnlineAchievementDesc");
			Title = null;
			LockedDesc = null;
			UnlockedDesc = null;
			IsHidden = false;
			UnlockTime = default(FDateTime);
		}
		else
		{
			Title = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Title_Offset));
			LockedDesc = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, LockedDesc_Offset));
			UnlockedDesc = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, UnlockedDesc_Offset));
			IsHidden = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsHidden_Offset), 0, IsHidden_PropertyAddress.Address);
			UnlockTime = FDateTime.FromNative(IntPtr.Add(nativeStruct, UnlockTime_Offset));
		}
	}

	static FBGWOnlineAchievementDesc()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGWOnlineAchievementDesc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGWOnlineAchievementDesc));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BGWOnlineAchievementDesc");
		FBGWOnlineAchievementDesc_StructSize = NativeReflection.GetStructSize(intPtr);
		Title_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Title");
		Title_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Title", Classes.FTextProperty);
		LockedDesc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LockedDesc");
		LockedDesc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LockedDesc", Classes.FTextProperty);
		UnlockedDesc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnlockedDesc");
		UnlockedDesc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnlockedDesc", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref IsHidden_PropertyAddress, intPtr, "bIsHidden");
		IsHidden_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsHidden");
		IsHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsHidden", Classes.FBoolProperty);
		UnlockTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnlockTime");
		UnlockTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnlockTime", Classes.FStructProperty);
		FBGWOnlineAchievementDesc_IsValid = intPtr != IntPtr.Zero && Title_IsValid && LockedDesc_IsValid && UnlockedDesc_IsValid && IsHidden_IsValid && UnlockTime_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BGWOnlineAchievementDesc", FBGWOnlineAchievementDesc_IsValid);
	}
}
