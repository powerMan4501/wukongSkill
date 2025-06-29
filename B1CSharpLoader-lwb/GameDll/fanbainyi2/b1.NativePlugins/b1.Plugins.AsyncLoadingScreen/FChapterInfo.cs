using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.ChapterInfo", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public struct FChapterInfo
{
	private static bool IsNeedShow_IsValid;

	private static FFieldAddress IsNeedShow_PropertyAddress;

	private static int IsNeedShow_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.ChapterInfo:IsNeedShow")]
	public bool IsNeedShow;

	private static bool ChapterPreName_IsValid;

	private static int ChapterPreName_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.ChapterInfo:ChapterPreName")]
	public FText ChapterPreName;

	private static bool ChapterName_IsValid;

	private static int ChapterName_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.ChapterInfo:ChapterName")]
	public FText ChapterName;

	private static bool ImageObj_IsValid;

	private static int ImageObj_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.ChapterInfo:ImageObj")]
	public UTexture2D ImageObj;

	private static bool FChapterInfo_IsValid;

	private static int FChapterInfo_StructSize;

	public FChapterInfo Copy()
	{
		return this;
	}

	public static FChapterInfo FromNative(IntPtr nativeBuffer)
	{
		return new FChapterInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChapterInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChapterInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChapterInfo(nativeBuffer + arrayIndex * FChapterInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChapterInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChapterInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChapterInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.ChapterInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsNeedShow_Offset), 0, IsNeedShow_PropertyAddress.Address, IsNeedShow);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, ChapterPreName_Offset), ChapterPreName);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, ChapterName_Offset), ChapterName);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, ImageObj_Offset), ImageObj);
	}

	public FChapterInfo(IntPtr nativeStruct)
	{
		if (!FChapterInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.ChapterInfo");
			IsNeedShow = false;
			ChapterPreName = null;
			ChapterName = null;
			ImageObj = null;
		}
		else
		{
			IsNeedShow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsNeedShow_Offset), 0, IsNeedShow_PropertyAddress.Address);
			ChapterPreName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, ChapterPreName_Offset));
			ChapterName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, ChapterName_Offset));
			ImageObj = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, ImageObj_Offset));
		}
	}

	static FChapterInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChapterInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChapterInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AsyncLoadingScreen.ChapterInfo");
		FChapterInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsNeedShow_PropertyAddress, intPtr, "IsNeedShow");
		IsNeedShow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsNeedShow");
		IsNeedShow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsNeedShow", Classes.FBoolProperty);
		ChapterPreName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChapterPreName");
		ChapterPreName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChapterPreName", Classes.FTextProperty);
		ChapterName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChapterName");
		ChapterName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChapterName", Classes.FTextProperty);
		ImageObj_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImageObj");
		ImageObj_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImageObj", Classes.FObjectProperty);
		FChapterInfo_IsValid = intPtr != IntPtr.Zero && IsNeedShow_IsValid && ChapterPreName_IsValid && ChapterName_IsValid && ImageObj_IsValid;
		NativeReflection.LogStructIsValid("/Script/AsyncLoadingScreen.ChapterInfo", FChapterInfo_IsValid);
	}
}
