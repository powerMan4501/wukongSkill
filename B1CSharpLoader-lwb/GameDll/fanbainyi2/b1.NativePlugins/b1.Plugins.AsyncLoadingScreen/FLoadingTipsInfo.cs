using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.LoadingTipsInfo", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public struct FLoadingTipsInfo
{
	private static bool TipsId_IsValid;

	private static int TipsId_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingTipsInfo:TipsId")]
	public int TipsId;

	private static bool DurTime_IsValid;

	private static int DurTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingTipsInfo:DurTime")]
	public float DurTime;

	private static bool Title_IsValid;

	private static int Title_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingTipsInfo:Title")]
	public FText Title;

	private static bool Tips_IsValid;

	private static int Tips_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingTipsInfo:Tips")]
	public FText Tips;

	private static bool ImageObj_IsValid;

	private static int ImageObj_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingTipsInfo:ImageObj")]
	public UTexture2D ImageObj;

	private static bool FLoadingTipsInfo_IsValid;

	private static int FLoadingTipsInfo_StructSize;

	public FLoadingTipsInfo Copy()
	{
		return this;
	}

	public static FLoadingTipsInfo FromNative(IntPtr nativeBuffer)
	{
		return new FLoadingTipsInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLoadingTipsInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLoadingTipsInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLoadingTipsInfo(nativeBuffer + arrayIndex * FLoadingTipsInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLoadingTipsInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLoadingTipsInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLoadingTipsInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.LoadingTipsInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TipsId_Offset), TipsId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DurTime_Offset), DurTime);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Title_Offset), Title);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Tips_Offset), Tips);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, ImageObj_Offset), ImageObj);
	}

	public FLoadingTipsInfo(IntPtr nativeStruct)
	{
		if (!FLoadingTipsInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.LoadingTipsInfo");
			TipsId = 0;
			DurTime = 0f;
			Title = null;
			Tips = null;
			ImageObj = null;
		}
		else
		{
			TipsId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TipsId_Offset));
			DurTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DurTime_Offset));
			Title = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Title_Offset));
			Tips = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Tips_Offset));
			ImageObj = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, ImageObj_Offset));
		}
	}

	static FLoadingTipsInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLoadingTipsInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLoadingTipsInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AsyncLoadingScreen.LoadingTipsInfo");
		FLoadingTipsInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TipsId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TipsId");
		TipsId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TipsId", Classes.FIntProperty);
		DurTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DurTime");
		DurTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DurTime", Classes.FFloatProperty);
		Title_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Title");
		Title_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Title", Classes.FTextProperty);
		Tips_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tips");
		Tips_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tips", Classes.FTextProperty);
		ImageObj_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImageObj");
		ImageObj_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImageObj", Classes.FObjectProperty);
		FLoadingTipsInfo_IsValid = intPtr != IntPtr.Zero && TipsId_IsValid && DurTime_IsValid && Title_IsValid && Tips_IsValid && ImageObj_IsValid;
		NativeReflection.LogStructIsValid("/Script/AsyncLoadingScreen.LoadingTipsInfo", FLoadingTipsInfo_IsValid);
	}
}
