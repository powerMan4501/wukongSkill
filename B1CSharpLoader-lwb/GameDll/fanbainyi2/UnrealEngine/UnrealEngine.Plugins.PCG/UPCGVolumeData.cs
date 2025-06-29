using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGVolumeData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGVolumeData : UPCGSpatialDataWithPointCache
{
	private static bool VoxelSize_IsValid;

	private static int VoxelSize_Offset;

	private static bool Volume_IsValid;

	private static int Volume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGVolumeData:VoxelSize")]
	public FVector VoxelSize
	{
		get
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeData:VoxelSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, VoxelSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeData:VoxelSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, VoxelSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/PCG.PCGVolumeData:Volume")]
	protected TWeakObject<AVolume> Volume
	{
		get
		{
			CheckDestroyed();
			if (!Volume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeData:Volume");
				return default(TWeakObject<AVolume>);
			}
			return TWeakObjectMarshaler<AVolume>.FromNative(IntPtr.Add(base.Address, Volume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Volume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeData:Volume");
			}
			else
			{
				TWeakObjectMarshaler<AVolume>.ToNative(IntPtr.Add(base.Address, Volume_Offset), value);
			}
		}
	}

	static UPCGVolumeData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGVolumeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGVolumeData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGVolumeData");
		VoxelSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VoxelSize");
		VoxelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VoxelSize", Classes.FStructProperty);
		Volume_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Volume");
		Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Volume", Classes.FWeakObjectProperty);
	}
}
