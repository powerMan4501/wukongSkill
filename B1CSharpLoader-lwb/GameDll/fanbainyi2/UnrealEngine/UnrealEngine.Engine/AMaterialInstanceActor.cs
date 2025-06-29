using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.MaterialInstanceActor", "Engine", UnrealModuleType.Engine)]
public class AMaterialInstanceActor : AActor
{
	private static bool TargetActors_IsValid;

	private static FFieldAddress TargetActors_PropertyAddress;

	private static int TargetActors_Offset;

	private TArrayReadWriteMarshaler<AActor> TargetActors_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.MaterialInstanceActor:TargetActors")]
	public TArrayReadWrite<AActor> TargetActors
	{
		get
		{
			CheckDestroyed();
			if (!TargetActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInstanceActor:TargetActors");
				return null;
			}
			if (TargetActors_MarshalerCached == null)
			{
				TargetActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, TargetActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return TargetActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, TargetActors_Offset));
		}
	}

	static AMaterialInstanceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AMaterialInstanceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AMaterialInstanceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialInstanceActor");
		NativeReflectionCached.GetPropertyRef(ref TargetActors_PropertyAddress, unrealStruct, "TargetActors");
		TargetActors_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetActors");
		TargetActors_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetActors", Classes.FArrayProperty);
	}
}
