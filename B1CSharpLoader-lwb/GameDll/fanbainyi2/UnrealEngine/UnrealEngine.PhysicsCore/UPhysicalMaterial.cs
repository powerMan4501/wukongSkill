using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UClass(Flags = (ClassFlags)810557600uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PhysicsCore.PhysicalMaterial", "PhysicsCore", UnrealModuleType.Engine)]
public class UPhysicalMaterial : UObject
{
	private static bool Friction_IsValid;

	private static int Friction_Offset;

	private static bool StaticFriction_IsValid;

	private static int StaticFriction_Offset;

	private static bool FrictionCombineMode_IsValid;

	private static FFieldAddress FrictionCombineMode_PropertyAddress;

	private static int FrictionCombineMode_Offset;

	private static bool OverrideFrictionCombineMode_IsValid;

	private static FFieldAddress OverrideFrictionCombineMode_PropertyAddress;

	private static int OverrideFrictionCombineMode_Offset;

	private static bool Restitution_IsValid;

	private static int Restitution_Offset;

	private static bool RestitutionCombineMode_IsValid;

	private static FFieldAddress RestitutionCombineMode_PropertyAddress;

	private static int RestitutionCombineMode_Offset;

	private static bool OverrideRestitutionCombineMode_IsValid;

	private static FFieldAddress OverrideRestitutionCombineMode_PropertyAddress;

	private static int OverrideRestitutionCombineMode_Offset;

	private static bool Density_IsValid;

	private static int Density_Offset;

	private static bool SleepLinearVelocityThreshold_IsValid;

	private static int SleepLinearVelocityThreshold_Offset;

	private static bool SleepAngularVelocityThreshold_IsValid;

	private static int SleepAngularVelocityThreshold_Offset;

	private static bool SleepCounterThreshold_IsValid;

	private static int SleepCounterThreshold_Offset;

	private static bool RaiseMassToPower_IsValid;

	private static int RaiseMassToPower_Offset;

	private static bool DestructibleDamageThresholdScale_IsValid;

	private static int DestructibleDamageThresholdScale_Offset;

	private static bool SurfaceType_IsValid;

	private static FFieldAddress SurfaceType_PropertyAddress;

	private static int SurfaceType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:Friction")]
	public float Friction
	{
		get
		{
			CheckDestroyed();
			if (!Friction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:Friction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Friction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Friction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:Friction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Friction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:StaticFriction")]
	public float StaticFriction
	{
		get
		{
			CheckDestroyed();
			if (!StaticFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:StaticFriction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StaticFriction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:StaticFriction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StaticFriction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:FrictionCombineMode")]
	public EFrictionCombineMode FrictionCombineMode
	{
		get
		{
			CheckDestroyed();
			if (!FrictionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:FrictionCombineMode");
				return EFrictionCombineMode.Average;
			}
			return EnumMarshaler<EFrictionCombineMode>.FromNative(IntPtr.Add(base.Address, FrictionCombineMode_Offset), 0, FrictionCombineMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FrictionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:FrictionCombineMode");
			}
			else
			{
				EnumMarshaler<EFrictionCombineMode>.ToNative(IntPtr.Add(base.Address, FrictionCombineMode_Offset), 0, FrictionCombineMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:bOverrideFrictionCombineMode")]
	public bool OverrideFrictionCombineMode
	{
		get
		{
			CheckDestroyed();
			if (!OverrideFrictionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:bOverrideFrictionCombineMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideFrictionCombineMode_Offset), 0, OverrideFrictionCombineMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideFrictionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:bOverrideFrictionCombineMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideFrictionCombineMode_Offset), 0, OverrideFrictionCombineMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:Restitution")]
	public float Restitution
	{
		get
		{
			CheckDestroyed();
			if (!Restitution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:Restitution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Restitution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Restitution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:Restitution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Restitution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:RestitutionCombineMode")]
	public EFrictionCombineMode RestitutionCombineMode
	{
		get
		{
			CheckDestroyed();
			if (!RestitutionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:RestitutionCombineMode");
				return EFrictionCombineMode.Average;
			}
			return EnumMarshaler<EFrictionCombineMode>.FromNative(IntPtr.Add(base.Address, RestitutionCombineMode_Offset), 0, RestitutionCombineMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RestitutionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:RestitutionCombineMode");
			}
			else
			{
				EnumMarshaler<EFrictionCombineMode>.ToNative(IntPtr.Add(base.Address, RestitutionCombineMode_Offset), 0, RestitutionCombineMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:bOverrideRestitutionCombineMode")]
	public bool OverrideRestitutionCombineMode
	{
		get
		{
			CheckDestroyed();
			if (!OverrideRestitutionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:bOverrideRestitutionCombineMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideRestitutionCombineMode_Offset), 0, OverrideRestitutionCombineMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideRestitutionCombineMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:bOverrideRestitutionCombineMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideRestitutionCombineMode_Offset), 0, OverrideRestitutionCombineMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:Density")]
	public float Density
	{
		get
		{
			CheckDestroyed();
			if (!Density_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:Density");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Density_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Density_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:Density");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Density_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:SleepLinearVelocityThreshold")]
	public float SleepLinearVelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!SleepLinearVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SleepLinearVelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SleepLinearVelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SleepLinearVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SleepLinearVelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SleepLinearVelocityThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:SleepAngularVelocityThreshold")]
	public float SleepAngularVelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!SleepAngularVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SleepAngularVelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SleepAngularVelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SleepAngularVelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SleepAngularVelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SleepAngularVelocityThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:SleepCounterThreshold")]
	public int SleepCounterThreshold
	{
		get
		{
			CheckDestroyed();
			if (!SleepCounterThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SleepCounterThreshold");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SleepCounterThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SleepCounterThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SleepCounterThreshold");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SleepCounterThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:RaiseMassToPower")]
	public float RaiseMassToPower
	{
		get
		{
			CheckDestroyed();
			if (!RaiseMassToPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:RaiseMassToPower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RaiseMassToPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RaiseMassToPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:RaiseMassToPower");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RaiseMassToPower_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:DestructibleDamageThresholdScale")]
	public float DestructibleDamageThresholdScale
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleDamageThresholdScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:DestructibleDamageThresholdScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestructibleDamageThresholdScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleDamageThresholdScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:DestructibleDamageThresholdScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestructibleDamageThresholdScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/PhysicsCore.PhysicalMaterial:SurfaceType")]
	public EPhysicalSurface SurfaceType
	{
		get
		{
			CheckDestroyed();
			if (!SurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SurfaceType");
				return EPhysicalSurface.SurfaceType_Default;
			}
			return EnumMarshaler<EPhysicalSurface>.FromNative(IntPtr.Add(base.Address, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PhysicsCore.PhysicalMaterial:SurfaceType");
			}
			else
			{
				EnumMarshaler<EPhysicalSurface>.ToNative(IntPtr.Add(base.Address, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address, value);
			}
		}
	}

	static UPhysicalMaterial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicalMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicalMaterial));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PhysicsCore.PhysicalMaterial");
		Friction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Friction");
		Friction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Friction", Classes.FFloatProperty);
		StaticFriction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticFriction");
		StaticFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticFriction", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FrictionCombineMode_PropertyAddress, unrealStruct, "FrictionCombineMode");
		FrictionCombineMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrictionCombineMode");
		FrictionCombineMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrictionCombineMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideFrictionCombineMode_PropertyAddress, unrealStruct, "bOverrideFrictionCombineMode");
		OverrideFrictionCombineMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideFrictionCombineMode");
		OverrideFrictionCombineMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideFrictionCombineMode", Classes.FBoolProperty);
		Restitution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Restitution");
		Restitution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Restitution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RestitutionCombineMode_PropertyAddress, unrealStruct, "RestitutionCombineMode");
		RestitutionCombineMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RestitutionCombineMode");
		RestitutionCombineMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RestitutionCombineMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideRestitutionCombineMode_PropertyAddress, unrealStruct, "bOverrideRestitutionCombineMode");
		OverrideRestitutionCombineMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideRestitutionCombineMode");
		OverrideRestitutionCombineMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideRestitutionCombineMode", Classes.FBoolProperty);
		Density_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Density");
		Density_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Density", Classes.FFloatProperty);
		SleepLinearVelocityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SleepLinearVelocityThreshold");
		SleepLinearVelocityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SleepLinearVelocityThreshold", Classes.FFloatProperty);
		SleepAngularVelocityThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SleepAngularVelocityThreshold");
		SleepAngularVelocityThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SleepAngularVelocityThreshold", Classes.FFloatProperty);
		SleepCounterThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SleepCounterThreshold");
		SleepCounterThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SleepCounterThreshold", Classes.FIntProperty);
		RaiseMassToPower_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RaiseMassToPower");
		RaiseMassToPower_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RaiseMassToPower", Classes.FFloatProperty);
		DestructibleDamageThresholdScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestructibleDamageThresholdScale");
		DestructibleDamageThresholdScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestructibleDamageThresholdScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SurfaceType_PropertyAddress, unrealStruct, "SurfaceType");
		SurfaceType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SurfaceType");
		SurfaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SurfaceType", Classes.FByteProperty);
	}
}
