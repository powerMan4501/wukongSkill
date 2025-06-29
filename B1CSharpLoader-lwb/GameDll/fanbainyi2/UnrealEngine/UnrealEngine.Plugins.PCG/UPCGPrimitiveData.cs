using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPrimitiveData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPrimitiveData : UPCGSpatialDataWithPointCache
{
	private static bool VoxelSize_IsValid;

	private static int VoxelSize_Offset;

	private static bool Primitive_IsValid;

	private static int Primitive_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPrimitiveData:VoxelSize")]
	public FVector VoxelSize
	{
		get
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPrimitiveData:VoxelSize");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, VoxelSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPrimitiveData:VoxelSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, VoxelSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862165533uL)]
	[UMetaPath("/Script/PCG.PCGPrimitiveData:Primitive")]
	protected TWeakObject<UPrimitiveComponent> Primitive
	{
		get
		{
			CheckDestroyed();
			if (!Primitive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPrimitiveData:Primitive");
				return default(TWeakObject<UPrimitiveComponent>);
			}
			return TWeakObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(base.Address, Primitive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Primitive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPrimitiveData:Primitive");
			}
			else
			{
				TWeakObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(base.Address, Primitive_Offset), value);
			}
		}
	}

	static UPCGPrimitiveData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPrimitiveData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPrimitiveData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGPrimitiveData");
		VoxelSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VoxelSize");
		VoxelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VoxelSize", Classes.FStructProperty);
		Primitive_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Primitive");
		Primitive_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Primitive", Classes.FWeakObjectProperty);
	}
}
