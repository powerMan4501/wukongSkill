using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsThrusterComponent", "Engine", UnrealModuleType.Engine)]
public class UPhysicsThrusterComponent : USceneComponent
{
	private static bool ThrustStrength_IsValid;

	private static int ThrustStrength_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.PhysicsThrusterComponent:ThrustStrength")]
	public float ThrustStrength
	{
		get
		{
			CheckDestroyed();
			if (!ThrustStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsThrusterComponent:ThrustStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ThrustStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ThrustStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsThrusterComponent:ThrustStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ThrustStrength_Offset), value);
			}
		}
	}

	static UPhysicsThrusterComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicsThrusterComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicsThrusterComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PhysicsThrusterComponent");
		ThrustStrength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ThrustStrength");
		ThrustStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ThrustStrength", Classes.FFloatProperty);
	}
}
