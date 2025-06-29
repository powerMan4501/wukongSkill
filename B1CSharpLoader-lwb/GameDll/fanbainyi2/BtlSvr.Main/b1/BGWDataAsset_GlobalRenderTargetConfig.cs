using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_GlobalRenderTargetConfig")]
public class BGWDataAsset_GlobalRenderTargetConfig : UBGWDataAsset
{
	public static readonly string Path;

	private static bool CanvasPainterMap_IsValid;

	private static int CanvasPainterMap_Offset;

	private static FFieldAddress CanvasPainterMap_PropertyAddress;

	private TMapReadWriteMarshaler<ESceneItemSurfaceType, CanvasPainterData> CanvasPainterMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GlobalRenderTargetConfig:CanvasPainterMap")]
	public TMapReadWrite<ESceneItemSurfaceType, CanvasPainterData> CanvasPainterMap
	{
		get
		{
			CheckDestroyed();
			if (!CanvasPainterMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GlobalRenderTargetConfig:CanvasPainterMap");
				return null;
			}
			if (CanvasPainterMap_Marshaler == null)
			{
				CanvasPainterMap_Marshaler = new TMapReadWriteMarshaler<ESceneItemSurfaceType, CanvasPainterData>(1, CanvasPainterMap_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<CanvasPainterData, CanvasPainterData>.FromNative, CachedMarshalingDelegates<CanvasPainterData, CanvasPainterData>.ToNative);
			}
			return CanvasPainterMap_Marshaler.FromNative(IntPtr.Add(base.Address, CanvasPainterMap_Offset));
		}
	}

	static BGWDataAsset_GlobalRenderTargetConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_GlobalRenderTargetConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_GlobalRenderTargetConfig));
		Path = "BGWDataAsset_GlobalRenderTargetConfig'/Game/00Main/Design/Config/DA_GRTC.DA_GRTC'";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_GlobalRenderTargetConfig");
		NativeReflection.GetPropertyRef(ref CanvasPainterMap_PropertyAddress, unrealStruct, "CanvasPainterMap");
		CanvasPainterMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanvasPainterMap");
		CanvasPainterMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanvasPainterMap", Classes.FMapProperty);
	}
}
