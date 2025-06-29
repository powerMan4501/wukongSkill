using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public struct FBossRushInfo
{
	private static bool LoadingType_IsValid;

	private static FFieldAddress LoadingType_PropertyAddress;

	private static int LoadingType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:LoadingType")]
	public EBossRushLoadingType LoadingType;

	private static bool BossName_IsValid;

	private static int BossName_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:BossName")]
	public FText BossName;

	private static bool DifficultyTitle_IsValid;

	private static int DifficultyTitle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:DifficultyTitle")]
	public FText DifficultyTitle;

	private static bool DifficultyDesc_IsValid;

	private static int DifficultyDesc_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:DifficultyDesc")]
	public FText DifficultyDesc;

	private static bool DifficultyText_IsValid;

	private static int DifficultyText_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:DifficultyText")]
	public FText DifficultyText;

	private static bool DifficultyLevel_IsValid;

	private static int DifficultyLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:DifficultyLevel")]
	public int DifficultyLevel;

	private static bool GroupText_IsValid;

	private static int GroupText_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:GroupText")]
	public FText GroupText;

	private static bool IterationsChallengeCurrentIndex_IsValid;

	private static int IterationsChallengeCurrentIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:IterationsChallengeCurrentIndex")]
	public int IterationsChallengeCurrentIndex;

	private static bool IterationsChallengeCount_IsValid;

	private static int IterationsChallengeCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:IterationsChallengeCount")]
	public int IterationsChallengeCount;

	private static bool DebuffList_IsValid;

	private static FFieldAddress DebuffList_PropertyAddress;

	private static int DebuffList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:DebuffList")]
	public List<int> DebuffList;

	private static bool BossImage_IsValid;

	private static int BossImage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:BossImage")]
	public UTexture2D BossImage;

	private static bool IsNeedHide_IsValid;

	private static FFieldAddress IsNeedHide_PropertyAddress;

	private static int IsNeedHide_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:IsNeedHide")]
	public bool IsNeedHide;

	private static bool Masks_IsValid;

	private static FFieldAddress Masks_PropertyAddress;

	private static int Masks_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.BossRushInfo:Masks")]
	public Dictionary<FName, UTexture2D> Masks;

	private static bool FBossRushInfo_IsValid;

	private static int FBossRushInfo_StructSize;

	public FBossRushInfo Copy()
	{
		FBossRushInfo result = this;
		if (DebuffList != null)
		{
			result.DebuffList = new List<int>(DebuffList);
		}
		if (Masks != null)
		{
			result.Masks = new Dictionary<FName, UTexture2D>(Masks);
		}
		return result;
	}

	public static FBossRushInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBossRushInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBossRushInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBossRushInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBossRushInfo(nativeBuffer + arrayIndex * FBossRushInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBossRushInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBossRushInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBossRushInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.BossRushInfo");
			return;
		}
		EnumMarshaler<EBossRushLoadingType>.ToNative(IntPtr.Add(nativeStruct, LoadingType_Offset), 0, LoadingType_PropertyAddress.Address, LoadingType);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, BossName_Offset), BossName);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DifficultyTitle_Offset), DifficultyTitle);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DifficultyDesc_Offset), DifficultyDesc);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DifficultyText_Offset), DifficultyText);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DifficultyLevel_Offset), DifficultyLevel);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, GroupText_Offset), GroupText);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IterationsChallengeCurrentIndex_Offset), IterationsChallengeCurrentIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IterationsChallengeCount_Offset), IterationsChallengeCount);
		new TArrayCopyMarshaler<int>(1, DebuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, DebuffList_Offset), DebuffList);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, BossImage_Offset), BossImage);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsNeedHide_Offset), 0, IsNeedHide_PropertyAddress.Address, IsNeedHide);
		new TMapCopyMarshaler<FName, UTexture2D>(1, Masks_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.FromNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Masks_Offset), Masks);
	}

	public FBossRushInfo(IntPtr nativeStruct)
	{
		if (!FBossRushInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.BossRushInfo");
			LoadingType = EBossRushLoadingType.ReChallengeBoss;
			BossName = null;
			DifficultyTitle = null;
			DifficultyDesc = null;
			DifficultyText = null;
			DifficultyLevel = 0;
			GroupText = null;
			IterationsChallengeCurrentIndex = 0;
			IterationsChallengeCount = 0;
			DebuffList = null;
			BossImage = null;
			IsNeedHide = false;
			Masks = null;
		}
		else
		{
			LoadingType = EnumMarshaler<EBossRushLoadingType>.FromNative(IntPtr.Add(nativeStruct, LoadingType_Offset), 0, LoadingType_PropertyAddress.Address);
			BossName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, BossName_Offset));
			DifficultyTitle = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DifficultyTitle_Offset));
			DifficultyDesc = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DifficultyDesc_Offset));
			DifficultyText = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DifficultyText_Offset));
			DifficultyLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DifficultyLevel_Offset));
			GroupText = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, GroupText_Offset));
			IterationsChallengeCurrentIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IterationsChallengeCurrentIndex_Offset));
			IterationsChallengeCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IterationsChallengeCount_Offset));
			DebuffList = new TArrayCopyMarshaler<int>(1, DebuffList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, DebuffList_Offset));
			BossImage = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, BossImage_Offset));
			IsNeedHide = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsNeedHide_Offset), 0, IsNeedHide_PropertyAddress.Address);
			Masks = new TMapCopyMarshaler<FName, UTexture2D>(1, Masks_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.FromNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Masks_Offset));
		}
	}

	static FBossRushInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBossRushInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBossRushInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AsyncLoadingScreen.BossRushInfo");
		FBossRushInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref LoadingType_PropertyAddress, intPtr, "LoadingType");
		LoadingType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoadingType");
		LoadingType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoadingType", Classes.FEnumProperty);
		BossName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BossName");
		BossName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BossName", Classes.FTextProperty);
		DifficultyTitle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DifficultyTitle");
		DifficultyTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DifficultyTitle", Classes.FTextProperty);
		DifficultyDesc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DifficultyDesc");
		DifficultyDesc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DifficultyDesc", Classes.FTextProperty);
		DifficultyText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DifficultyText");
		DifficultyText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DifficultyText", Classes.FTextProperty);
		DifficultyLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DifficultyLevel");
		DifficultyLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DifficultyLevel", Classes.FIntProperty);
		GroupText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupText");
		GroupText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupText", Classes.FTextProperty);
		IterationsChallengeCurrentIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IterationsChallengeCurrentIndex");
		IterationsChallengeCurrentIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IterationsChallengeCurrentIndex", Classes.FIntProperty);
		IterationsChallengeCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IterationsChallengeCount");
		IterationsChallengeCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IterationsChallengeCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DebuffList_PropertyAddress, intPtr, "DebuffList");
		DebuffList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebuffList");
		DebuffList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebuffList", Classes.FArrayProperty);
		BossImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BossImage");
		BossImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BossImage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNeedHide_PropertyAddress, intPtr, "IsNeedHide");
		IsNeedHide_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsNeedHide");
		IsNeedHide_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsNeedHide", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Masks_PropertyAddress, intPtr, "Masks");
		Masks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Masks");
		Masks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Masks", Classes.FMapProperty);
		FBossRushInfo_IsValid = intPtr != IntPtr.Zero && LoadingType_IsValid && BossName_IsValid && DifficultyTitle_IsValid && DifficultyDesc_IsValid && DifficultyText_IsValid && DifficultyLevel_IsValid && GroupText_IsValid && IterationsChallengeCurrentIndex_IsValid && IterationsChallengeCount_IsValid && DebuffList_IsValid && BossImage_IsValid && IsNeedHide_IsValid && Masks_IsValid;
		NativeReflection.LogStructIsValid("/Script/AsyncLoadingScreen.BossRushInfo", FBossRushInfo_IsValid);
	}
}
