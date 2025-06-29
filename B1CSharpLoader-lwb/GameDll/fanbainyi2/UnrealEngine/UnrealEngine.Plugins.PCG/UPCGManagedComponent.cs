using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGManagedComponent", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGManagedComponent : UPCGManagedResource
{
	private static bool GeneratedComponent_IsValid;

	private static int GeneratedComponent_Offset;

	[UProperty(Flags = (PropFlags)7881299348422669uL)]
	[UMetaPath("/Script/PCG.PCGManagedComponent:GeneratedComponent")]
	public TSoftObject<UActorComponent> GeneratedComponent
	{
		get
		{
			CheckDestroyed();
			if (!GeneratedComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGManagedComponent:GeneratedComponent");
				return default(TSoftObject<UActorComponent>);
			}
			return TSoftObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(base.Address, GeneratedComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeneratedComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGManagedComponent:GeneratedComponent");
			}
			else
			{
				TSoftObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(base.Address, GeneratedComponent_Offset), value);
			}
		}
	}

	static UPCGManagedComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGManagedComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGManagedComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGManagedComponent");
		GeneratedComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GeneratedComponent");
		GeneratedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GeneratedComponent", Classes.FSoftObjectProperty);
	}
}
