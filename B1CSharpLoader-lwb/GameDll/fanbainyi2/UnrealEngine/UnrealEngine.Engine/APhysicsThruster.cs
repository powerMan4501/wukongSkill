using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PhysicsThruster", "Engine", UnrealModuleType.Engine)]
public class APhysicsThruster : ARigidBodyBase
{
	private static bool ThrusterComponent_IsValid;

	private static int ThrusterComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.PhysicsThruster:ThrusterComponent")]
	public UPhysicsThrusterComponent ThrusterComponent
	{
		get
		{
			CheckDestroyed();
			if (!ThrusterComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsThruster:ThrusterComponent");
				return null;
			}
			return UObjectMarshaler<UPhysicsThrusterComponent>.FromNative(IntPtr.Add(base.Address, ThrusterComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ThrusterComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsThruster:ThrusterComponent");
			}
			else
			{
				UObjectMarshaler<UPhysicsThrusterComponent>.ToNative(IntPtr.Add(base.Address, ThrusterComponent_Offset), value);
			}
		}
	}

	static APhysicsThruster()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APhysicsThruster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APhysicsThruster));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PhysicsThruster");
		ThrusterComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ThrusterComponent");
		ThrusterComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ThrusterComponent", Classes.FObjectProperty);
	}
}
