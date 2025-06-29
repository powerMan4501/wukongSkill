using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.AsyncLoadingScreen;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AsyncLoadingScreen.LoadingProgressInfo", "AsyncLoadingScreen", UnrealModuleType.GamePlugin)]
public struct FLoadingProgressInfo
{
	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingProgressInfo:Duration")]
	public float Duration;

	private static bool ProgressSprite_IsValid;

	private static int ProgressSprite_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingProgressInfo:ProgressSprite")]
	public FSoftObjectPath ProgressSprite;

	private static bool DetailSprites_IsValid;

	private static FFieldAddress DetailSprites_PropertyAddress;

	private static int DetailSprites_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AsyncLoadingScreen.LoadingProgressInfo:DetailSprites")]
	public List<FSoftObjectPath> DetailSprites;

	private static bool FLoadingProgressInfo_IsValid;

	private static int FLoadingProgressInfo_StructSize;

	public FLoadingProgressInfo Copy()
	{
		FLoadingProgressInfo result = this;
		if (DetailSprites != null)
		{
			result.DetailSprites = new List<FSoftObjectPath>(DetailSprites);
		}
		return result;
	}

	public static FLoadingProgressInfo FromNative(IntPtr nativeBuffer)
	{
		return new FLoadingProgressInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLoadingProgressInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLoadingProgressInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLoadingProgressInfo(nativeBuffer + arrayIndex * FLoadingProgressInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLoadingProgressInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLoadingProgressInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLoadingProgressInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.LoadingProgressInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, ProgressSprite_Offset), ProgressSprite);
		new TArrayCopyMarshaler<FSoftObjectPath>(1, DetailSprites_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(nativeStruct, DetailSprites_Offset), DetailSprites);
	}

	public FLoadingProgressInfo(IntPtr nativeStruct)
	{
		if (!FLoadingProgressInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AsyncLoadingScreen.LoadingProgressInfo");
			Duration = 0f;
			ProgressSprite = default(FSoftObjectPath);
			DetailSprites = null;
		}
		else
		{
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			ProgressSprite = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, ProgressSprite_Offset));
			DetailSprites = new TArrayCopyMarshaler<FSoftObjectPath>(1, DetailSprites_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(nativeStruct, DetailSprites_Offset));
		}
	}

	static FLoadingProgressInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLoadingProgressInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLoadingProgressInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AsyncLoadingScreen.LoadingProgressInfo");
		FLoadingProgressInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		ProgressSprite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProgressSprite");
		ProgressSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProgressSprite", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetailSprites_PropertyAddress, intPtr, "DetailSprites");
		DetailSprites_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DetailSprites");
		DetailSprites_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DetailSprites", Classes.FArrayProperty);
		FLoadingProgressInfo_IsValid = intPtr != IntPtr.Zero && Duration_IsValid && ProgressSprite_IsValid && DetailSprites_IsValid;
		NativeReflection.LogStructIsValid("/Script/AsyncLoadingScreen.LoadingProgressInfo", FLoadingProgressInfo_IsValid);
	}
}
