using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UClass(Flags = (ClassFlags)810557600uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial", "PhysicsCore", UnrealModuleType.Engine)]
public class UChaosPhysicalMaterial : UObject
{
	private static bool Friction_IsValid;

	private static int Friction_Offset;

	private static bool StaticFriction_IsValid;

	private static int StaticFriction_Offset;

	private static bool Restitution_IsValid;

	private static int Restitution_Offset;

	private static bool LinearEtherDrag_IsValid;

	private static int LinearEtherDrag_Offset;

	private static bool AngularEtherDrag_IsValid;

	private static int AngularEtherDrag_Offset;

	private static bool SleepingLinearVelocityThreshold_IsValid;

	private static int SleepingLinearVelocityThreshold_Offset;

	private static bool SleepingAngularVelocityThreshold_IsValid;

	private static int SleepingAngularVelocityThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:Friction")]
	public float Friction
	{
		get
		{
			CheckDestroyed();
			if (!Friction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:Friction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Friction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Friction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:Friction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Friction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:StaticFriction")]
	public float StaticFriction
	{
		get
		{
			CheckDestroyed();
			if (!StaticFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:StaticFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaticFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:StaticFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaticFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:Restitution")]
	public float Restitution
	{
		get
		{
			CheckDestroyed();
			if (!Restitution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:Restitution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Restitution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Restitution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:Restitution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Restitution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:LinearEtherDrag")]
	public float LinearEtherDrag
	{
		get
		{
			CheckDestroyed();
			if (!LinearEtherDrag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:LinearEtherDrag");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LinearEtherDrag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinearEtherDrag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:LinearEtherDrag");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LinearEtherDrag_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:AngularEtherDrag")]
	public float AngularEtherDrag
	{
		get
		{
			CheckDestroyed();
			if (!AngularEtherDrag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:AngularEtherDrag");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngularEtherDrag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngularEtherDrag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:AngularEtherDrag");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngularEtherDrag_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:SleepingLinearVelocityThreshold")]
	public float SleepingLinearVelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!SleepingLinearVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:SleepingLinearVelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SleepingLinearVelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SleepingLinearVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:SleepingLinearVelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SleepingLinearVelocityThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.ChaosPhysicalMaterial:SleepingAngularVelocityThreshold")]
	public float SleepingAngularVelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!SleepingAngularVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:SleepingAngularVelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SleepingAngularVelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SleepingAngularVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.ChaosPhysicalMaterial:SleepingAngularVelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SleepingAngularVelocityThreshold_Offset), value);
			}
		}
	}

	static UChaosPhysicalMaterial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UChaosPhysicalMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UChaosPhysicalMaterial));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PhysicsCore.ChaosPhysicalMaterial");
		Friction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Friction");
		Friction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Friction", Classes.FFloatProperty);
		StaticFriction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticFriction");
		StaticFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticFriction", Classes.FFloatProperty);
		Restitution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Restitution");
		Restitution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Restitution", Classes.FFloatProperty);
		LinearEtherDrag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LinearEtherDrag");
		LinearEtherDrag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LinearEtherDrag", Classes.FFloatProperty);
		AngularEtherDrag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AngularEtherDrag");
		AngularEtherDrag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AngularEtherDrag", Classes.FFloatProperty);
		SleepingLinearVelocityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SleepingLinearVelocityThreshold");
		SleepingLinearVelocityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SleepingLinearVelocityThreshold", Classes.FFloatProperty);
		SleepingAngularVelocityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SleepingAngularVelocityThreshold");
		SleepingAngularVelocityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SleepingAngularVelocityThreshold", Classes.FFloatProperty);
	}
}
