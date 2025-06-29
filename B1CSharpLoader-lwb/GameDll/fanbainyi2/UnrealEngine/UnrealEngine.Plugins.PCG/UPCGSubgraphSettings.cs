using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSubgraphSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSubgraphSettings : UPCGBaseSubgraphSettings
{
	private static bool SubgraphInstance_IsValid;

	private static int SubgraphInstance_Offset;

	private static bool SubgraphOverride_IsValid;

	private static int SubgraphOverride_Offset;

	[UProperty(Flags = (PropFlags)8444319095194141uL)]
	[UMetaPath("/Script/PCG.PCGSubgraphSettings:SubgraphInstance")]
	public UPCGGraphInstance SubgraphInstance
	{
		get
		{
			CheckDestroyed();
			if (!SubgraphInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSubgraphSettings:SubgraphInstance");
				return null;
			}
			return UObjectMarshaler<UPCGGraphInstance>.FromNative(IntPtr.Add(base.Address, SubgraphInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubgraphInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSubgraphSettings:SubgraphInstance");
			}
			else
			{
				UObjectMarshaler<UPCGGraphInstance>.ToNative(IntPtr.Add(base.Address, SubgraphInstance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/PCG.PCGSubgraphSettings:SubgraphOverride")]
	public UPCGGraphInterface SubgraphOverride
	{
		get
		{
			CheckDestroyed();
			if (!SubgraphOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSubgraphSettings:SubgraphOverride");
				return null;
			}
			return UObjectMarshaler<UPCGGraphInterface>.FromNative(IntPtr.Add(base.Address, SubgraphOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubgraphOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSubgraphSettings:SubgraphOverride");
			}
			else
			{
				UObjectMarshaler<UPCGGraphInterface>.ToNative(IntPtr.Add(base.Address, SubgraphOverride_Offset), value);
			}
		}
	}

	static UPCGSubgraphSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSubgraphSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSubgraphSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSubgraphSettings");
		SubgraphInstance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubgraphInstance");
		SubgraphInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubgraphInstance", Classes.FObjectProperty);
		SubgraphOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubgraphOverride");
		SubgraphOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubgraphOverride", Classes.FObjectProperty);
	}
}
