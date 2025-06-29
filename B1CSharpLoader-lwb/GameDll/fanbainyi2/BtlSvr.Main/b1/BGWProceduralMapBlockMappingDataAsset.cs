using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWProceduralMapBlockMappingDataAsset")]
public class BGWProceduralMapBlockMappingDataAsset : UBGWDataAsset
{
	private static bool MapBlockMapping_IsValid;

	private static int MapBlockMapping_Offset;

	private static FFieldAddress MapBlockMapping_PropertyAddress;

	private TMapReadWriteMarshaler<MapCatFlag, FSoftObjectPath> MapBlockMapping_Marshaler;

	[DisplayName("期望地图地块映射")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Map Setting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapBlockMappingDataAsset:MapBlockMapping")]
	public TMapReadWrite<MapCatFlag, FSoftObjectPath> MapBlockMapping
	{
		get
		{
			CheckDestroyed();
			if (!MapBlockMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapBlockMappingDataAsset:MapBlockMapping");
				return null;
			}
			if (MapBlockMapping_Marshaler == null)
			{
				MapBlockMapping_Marshaler = new TMapReadWriteMarshaler<MapCatFlag, FSoftObjectPath>(1, MapBlockMapping_PropertyAddress, CachedMarshalingDelegates<MapCatFlag, EnumMarshaler<MapCatFlag>>.FromNative, CachedMarshalingDelegates<MapCatFlag, EnumMarshaler<MapCatFlag>>.ToNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
			}
			return MapBlockMapping_Marshaler.FromNative(IntPtr.Add(base.Address, MapBlockMapping_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWProceduralMapBlockMappingDataAsset");
		NativeReflection.GetPropertyRef(ref MapBlockMapping_PropertyAddress, unrealStruct, "MapBlockMapping");
		MapBlockMapping_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapBlockMapping");
		MapBlockMapping_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapBlockMapping", Classes.FMapProperty);
	}

	static BGWProceduralMapBlockMappingDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWProceduralMapBlockMappingDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWProceduralMapBlockMappingDataAsset));
	}
}
