using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_TerrainEffectConfig")]
public class BGW_TerrainEffectConfig : UBGWDataAsset
{
	private static bool TerrainList_IsValid;

	private static int TerrainList_Offset;

	private static FFieldAddress TerrainList_PropertyAddress;

	private TMapReadWriteMarshaler<ESceneItemSurfaceType, TerrainEffectInfo> TerrainList_Marshaler;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_TerrainEffectConfig:TerrainList")]
	public TMapReadWrite<ESceneItemSurfaceType, TerrainEffectInfo> TerrainList
	{
		get
		{
			CheckDestroyed();
			if (!TerrainList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_TerrainEffectConfig:TerrainList");
				return null;
			}
			if (TerrainList_Marshaler == null)
			{
				TerrainList_Marshaler = new TMapReadWriteMarshaler<ESceneItemSurfaceType, TerrainEffectInfo>(1, TerrainList_PropertyAddress, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.FromNative, CachedMarshalingDelegates<ESceneItemSurfaceType, EnumMarshaler<ESceneItemSurfaceType>>.ToNative, CachedMarshalingDelegates<TerrainEffectInfo, BlittableTypeMarshaler<TerrainEffectInfo>>.FromNative, CachedMarshalingDelegates<TerrainEffectInfo, BlittableTypeMarshaler<TerrainEffectInfo>>.ToNative);
			}
			return TerrainList_Marshaler.FromNative(IntPtr.Add(base.Address, TerrainList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_TerrainEffectConfig");
		NativeReflection.GetPropertyRef(ref TerrainList_PropertyAddress, unrealStruct, "TerrainList");
		TerrainList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TerrainList");
		TerrainList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TerrainList", Classes.FMapProperty);
	}

	static BGW_TerrainEffectConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_TerrainEffectConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_TerrainEffectConfig));
	}
}
