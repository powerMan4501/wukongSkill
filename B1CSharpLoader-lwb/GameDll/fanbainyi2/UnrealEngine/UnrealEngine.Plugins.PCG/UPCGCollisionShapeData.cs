using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGCollisionShapeData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)9016065141112853uL)]
	[UMetaPath("/Script/PCG.PCGCollisionShapeData:Transform")]
	protected FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCollisionShapeData:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGCollisionShapeData:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	static UPCGCollisionShapeData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGCollisionShapeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGCollisionShapeData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGCollisionShapeData");
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Transform", Classes.FStructProperty);
	}
}
