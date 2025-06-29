using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGVolumeSamplerSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGVolumeSamplerSettings : UPCGSettings
{
	private static bool VoxelSize_IsValid;

	private static int VoxelSize_Offset;

	private static bool Unbounded_IsValid;

	private static FFieldAddress Unbounded_PropertyAddress;

	private static int Unbounded_Offset;

	private static bool PointSteepness_IsValid;

	private static int PointSteepness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGVolumeSamplerSettings:VoxelSize")]
	public FVector VoxelSize
	{
		get
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeSamplerSettings:VoxelSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, VoxelSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeSamplerSettings:VoxelSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, VoxelSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGVolumeSamplerSettings:bUnbounded")]
	public bool Unbounded
	{
		get
		{
			CheckDestroyed();
			if (!Unbounded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeSamplerSettings:bUnbounded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Unbounded_Offset), 0, Unbounded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Unbounded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeSamplerSettings:bUnbounded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Unbounded_Offset), 0, Unbounded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGVolumeSamplerSettings:PointSteepness")]
	public float PointSteepness
	{
		get
		{
			CheckDestroyed();
			if (!PointSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeSamplerSettings:PointSteepness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PointSteepness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGVolumeSamplerSettings:PointSteepness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PointSteepness_Offset), value);
			}
		}
	}

	static UPCGVolumeSamplerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGVolumeSamplerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGVolumeSamplerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGVolumeSamplerSettings");
		VoxelSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VoxelSize");
		VoxelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VoxelSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Unbounded_PropertyAddress, unrealStruct, "bUnbounded");
		Unbounded_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUnbounded");
		Unbounded_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUnbounded", Classes.FBoolProperty);
		PointSteepness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointSteepness");
		PointSteepness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointSteepness", Classes.FFloatProperty);
	}
}
