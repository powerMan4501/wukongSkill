using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGManagedActors", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGManagedActors : UPCGManagedResource
{
	private static bool GeneratedActors_IsValid;

	private static FFieldAddress GeneratedActors_PropertyAddress;

	private static int GeneratedActors_Offset;

	private TSetReadWriteMarshaler<TSoftObject<AActor>> GeneratedActors_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213125uL)]
	[UMetaPath("/Script/PCG.PCGManagedActors:GeneratedActors")]
	public TSetReadWrite<TSoftObject<AActor>> GeneratedActors
	{
		get
		{
			CheckDestroyed();
			if (!GeneratedActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGManagedActors:GeneratedActors");
				return null;
			}
			if (GeneratedActors_MarshalerCached == null)
			{
				GeneratedActors_MarshalerCached = new TSetReadWriteMarshaler<TSoftObject<AActor>>(1, GeneratedActors_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return GeneratedActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, GeneratedActors_Offset));
		}
	}

	static UPCGManagedActors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGManagedActors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGManagedActors));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGManagedActors");
		NativeReflectionCached.GetPropertyRef(ref GeneratedActors_PropertyAddress, unrealStruct, "GeneratedActors");
		GeneratedActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GeneratedActors");
		GeneratedActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GeneratedActors", Classes.FSetProperty);
	}
}
