using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGGraphInstance", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGGraphInstance : UPCGGraphInterface
{
	private static bool Graph_IsValid;

	private static int Graph_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/PCG.PCGGraphInstance:Graph")]
	public UPCGGraphInterface Graph
	{
		get
		{
			CheckDestroyed();
			if (!Graph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraphInstance:Graph");
				return null;
			}
			return UObjectMarshaler<UPCGGraphInterface>.FromNative(IntPtr.Add(base.Address, Graph_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Graph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGGraphInstance:Graph");
			}
			else
			{
				UObjectMarshaler<UPCGGraphInterface>.ToNative(IntPtr.Add(base.Address, Graph_Offset), value);
			}
		}
	}

	static UPCGGraphInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGGraphInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGGraphInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGGraphInstance");
		Graph_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Graph");
		Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Graph", Classes.FObjectProperty);
	}
}
