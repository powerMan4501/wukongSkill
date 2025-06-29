using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.WaterSplashResourceMap_WithSurfaceType")]
public struct FWaterSplashResourceMap_WithSurfaceType
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WaterSplashResourceMap_WithSurfaceType:FXMap")]
	public Dictionary<ESceneItemSurfaceType, FWaterSplashResource> FXMap;

	private static int WaterSplashResourceMap_WithSurfaceType_StructSize;

	private static int WaterSplashResourceMap_WithSurfaceType_IsValid;

	private static bool FXMap_IsValid;

	private static int FXMap_Offset;

	private static FFieldAddress FXMap_PropertyAddress;

	public FWaterSplashResourceMap_WithSurfaceType Copy()
	{
		FWaterSplashResourceMap_WithSurfaceType result = this;
		if (FXMap != null)
		{
			result.FXMap = new Dictionary<ESceneItemSurfaceType, FWaterSplashResource>(FXMap);
		}
		return result;
	}

	public static FWaterSplashResourceMap_WithSurfaceType FromNative(IntPtr nativeBuffer)
	{
		return new FWaterSplashResourceMap_WithSurfaceType(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterSplashResourceMap_WithSurfaceType value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterSplashResourceMap_WithSurfaceType FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterSplashResourceMap_WithSurfaceType(IntPtr.Add(nativeBuffer, arrayIndex * WaterSplashResourceMap_WithSurfaceType_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterSplashResourceMap_WithSurfaceType value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * WaterSplashResourceMap_WithSurfaceType_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (WaterSplashResourceMap_WithSurfaceType_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.WaterSplashResourceMap_WithSurfaceType");
		}
		else
		{
			new TMapCopyMarshaler<ESceneItemSurfaceType, FWaterSplashResource>(1, FXMap_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<FWaterSplashResource, FWaterSplashResource>.FromNative, CachedMarshalingDelegates<FWaterSplashResource, FWaterSplashResource>.ToNative).ToNative(IntPtr.Add(nativeStruct, FXMap_Offset), FXMap);
		}
	}

	public FWaterSplashResourceMap_WithSurfaceType(IntPtr nativeStruct)
	{
		if (WaterSplashResourceMap_WithSurfaceType_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.WaterSplashResourceMap_WithSurfaceType");
			FXMap = null;
		}
		else
		{
			FXMap = new TMapCopyMarshaler<ESceneItemSurfaceType, FWaterSplashResource>(1, FXMap_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<FWaterSplashResource, FWaterSplashResource>.FromNative, CachedMarshalingDelegates<FWaterSplashResource, FWaterSplashResource>.ToNative).FromNative(IntPtr.Add(nativeStruct, FXMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.WaterSplashResourceMap_WithSurfaceType");
		WaterSplashResourceMap_WithSurfaceType_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref FXMap_PropertyAddress, intPtr, "FXMap");
		FXMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXMap");
		FXMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXMap", Classes.FMapProperty);
		WaterSplashResourceMap_WithSurfaceType_IsValid = ((intPtr != IntPtr.Zero && FXMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.WaterSplashResourceMap_WithSurfaceType", (byte)WaterSplashResourceMap_WithSurfaceType_IsValid != 0);
	}

	static FWaterSplashResourceMap_WithSurfaceType()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FWaterSplashResourceMap_WithSurfaceType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterSplashResourceMap_WithSurfaceType));
	}
}
