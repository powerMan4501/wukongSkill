using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMetadataPartitionSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMetadataPartitionSettings : UPCGSettings
{
	private static bool PartitionAttribute_IsValid;

	private static int PartitionAttribute_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMetadataPartitionSettings:PartitionAttribute")]
	public FName PartitionAttribute
	{
		get
		{
			CheckDestroyed();
			if (!PartitionAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataPartitionSettings:PartitionAttribute");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, PartitionAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PartitionAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMetadataPartitionSettings:PartitionAttribute");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, PartitionAttribute_Offset), value);
			}
		}
	}

	static UPCGMetadataPartitionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMetadataPartitionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMetadataPartitionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMetadataPartitionSettings");
		PartitionAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PartitionAttribute");
		PartitionAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PartitionAttribute", Classes.FNameProperty);
	}
}
