using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PhysicsCollisionHandler", "Engine", UnrealModuleType.Engine)]
public class UPhysicsCollisionHandler : UObject
{
	private static bool ImpactThreshold_IsValid;

	private static int ImpactThreshold_Offset;

	private static bool ImpactReFireDelay_IsValid;

	private static int ImpactReFireDelay_Offset;

	private static bool DefaultImpactSound_IsValid;

	private static int DefaultImpactSound_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsCollisionHandler:ImpactThreshold")]
	public float ImpactThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ImpactThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsCollisionHandler:ImpactThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImpactThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImpactThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsCollisionHandler:ImpactThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImpactThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsCollisionHandler:ImpactReFireDelay")]
	public float ImpactReFireDelay
	{
		get
		{
			CheckDestroyed();
			if (!ImpactReFireDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsCollisionHandler:ImpactReFireDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImpactReFireDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImpactReFireDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsCollisionHandler:ImpactReFireDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImpactReFireDelay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.PhysicsCollisionHandler:DefaultImpactSound")]
	public USoundBase DefaultImpactSound
	{
		get
		{
			CheckDestroyed();
			if (!DefaultImpactSound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsCollisionHandler:DefaultImpactSound");
				return null;
			}
			return UObjectMarshaler<USoundBase>.FromNative(IntPtr.Add(base.Address, DefaultImpactSound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultImpactSound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsCollisionHandler:DefaultImpactSound");
			}
			else
			{
				UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(base.Address, DefaultImpactSound_Offset), value);
			}
		}
	}

	static UPhysicsCollisionHandler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicsCollisionHandler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicsCollisionHandler));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PhysicsCollisionHandler");
		ImpactThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImpactThreshold");
		ImpactThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImpactThreshold", Classes.FFloatProperty);
		ImpactReFireDelay_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImpactReFireDelay");
		ImpactReFireDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImpactReFireDelay", Classes.FFloatProperty);
		DefaultImpactSound_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultImpactSound");
		DefaultImpactSound_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultImpactSound", Classes.FObjectProperty);
	}
}
