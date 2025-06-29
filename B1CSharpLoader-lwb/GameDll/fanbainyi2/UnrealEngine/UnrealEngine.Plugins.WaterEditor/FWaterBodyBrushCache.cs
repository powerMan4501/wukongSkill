using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/WaterEditor.WaterBodyBrushCache", "WaterEditor", UnrealModuleType.EnginePlugin)]
public struct FWaterBodyBrushCache
{
	private static bool CacheRenderTarget_IsValid;

	private static int CacheRenderTarget_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBodyBrushCache:CacheRenderTarget")]
	public UTextureRenderTarget2D CacheRenderTarget;

	private static bool CacheIsValid_IsValid;

	private static FFieldAddress CacheIsValid_PropertyAddress;

	private static int CacheIsValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/WaterEditor.WaterBodyBrushCache:CacheIsValid")]
	public bool CacheIsValid;

	private static bool FWaterBodyBrushCache_IsValid;

	private static int FWaterBodyBrushCache_StructSize;

	public FWaterBodyBrushCache Copy()
	{
		return this;
	}

	public static FWaterBodyBrushCache FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBodyBrushCache(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBodyBrushCache value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBodyBrushCache FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBodyBrushCache(nativeBuffer + arrayIndex * FWaterBodyBrushCache_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBodyBrushCache value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBodyBrushCache_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBodyBrushCache_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WaterEditor.WaterBodyBrushCache");
			return;
		}
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(nativeStruct, CacheRenderTarget_Offset), CacheRenderTarget);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CacheIsValid_Offset), 0, CacheIsValid_PropertyAddress.Address, CacheIsValid);
	}

	public FWaterBodyBrushCache(IntPtr nativeStruct)
	{
		if (!FWaterBodyBrushCache_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WaterEditor.WaterBodyBrushCache");
			CacheRenderTarget = null;
			CacheIsValid = false;
		}
		else
		{
			CacheRenderTarget = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(nativeStruct, CacheRenderTarget_Offset));
			CacheIsValid = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CacheIsValid_Offset), 0, CacheIsValid_PropertyAddress.Address);
		}
	}

	static FWaterBodyBrushCache()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBodyBrushCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBodyBrushCache));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/WaterEditor.WaterBodyBrushCache");
		FWaterBodyBrushCache_StructSize = NativeReflection.GetStructSize(intPtr);
		CacheRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CacheRenderTarget");
		CacheRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CacheRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CacheIsValid_PropertyAddress, intPtr, "CacheIsValid");
		CacheIsValid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CacheIsValid");
		CacheIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CacheIsValid", Classes.FBoolProperty);
		FWaterBodyBrushCache_IsValid = intPtr != IntPtr.Zero && CacheRenderTarget_IsValid && CacheIsValid_IsValid;
		NativeReflection.LogStructIsValid("/Script/WaterEditor.WaterBodyBrushCache", FWaterBodyBrushCache_IsValid);
	}
}
