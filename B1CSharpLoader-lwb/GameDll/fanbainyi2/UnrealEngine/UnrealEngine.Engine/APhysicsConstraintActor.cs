using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PhysicsConstraintActor", "Engine", UnrealModuleType.Engine)]
public class APhysicsConstraintActor : ARigidBodyBase
{
	private static bool ConstraintComp_IsValid;

	private static int ConstraintComp_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.PhysicsConstraintActor:ConstraintComp")]
	public UPhysicsConstraintComponent ConstraintComp
	{
		get
		{
			CheckDestroyed();
			if (!ConstraintComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsConstraintActor:ConstraintComp");
				return null;
			}
			return UObjectMarshaler<UPhysicsConstraintComponent>.FromNative(IntPtr.Add(base.Address, ConstraintComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConstraintComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsConstraintActor:ConstraintComp");
			}
			else
			{
				UObjectMarshaler<UPhysicsConstraintComponent>.ToNative(IntPtr.Add(base.Address, ConstraintComp_Offset), value);
			}
		}
	}

	static APhysicsConstraintActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APhysicsConstraintActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APhysicsConstraintActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PhysicsConstraintActor");
		ConstraintComp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConstraintComp");
		ConstraintComp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConstraintComp", Classes.FObjectProperty);
	}
}
