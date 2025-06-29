using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810090656uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.DamageType", "Engine", UnrealModuleType.Engine)]
public class UDamageType : UObject
{
	private static bool CausedByWorld_IsValid;

	private static FFieldAddress CausedByWorld_PropertyAddress;

	private static int CausedByWorld_Offset;

	private static bool ScaleMomentumByMass_IsValid;

	private static FFieldAddress ScaleMomentumByMass_PropertyAddress;

	private static int ScaleMomentumByMass_Offset;

	private static bool RadialDamageVelChange_IsValid;

	private static FFieldAddress RadialDamageVelChange_PropertyAddress;

	private static int RadialDamageVelChange_Offset;

	private static bool DamageImpulse_IsValid;

	private static int DamageImpulse_Offset;

	private static bool DestructibleImpulse_IsValid;

	private static int DestructibleImpulse_Offset;

	private static bool DestructibleDamageSpreadScale_IsValid;

	private static int DestructibleDamageSpreadScale_Offset;

	private static bool DamageFalloff_IsValid;

	private static int DamageFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DamageType:bCausedByWorld")]
	public bool CausedByWorld
	{
		get
		{
			CheckDestroyed();
			if (!CausedByWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:bCausedByWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CausedByWorld_Offset), 0, CausedByWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CausedByWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:bCausedByWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CausedByWorld_Offset), 0, CausedByWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DamageType:bScaleMomentumByMass")]
	public bool ScaleMomentumByMass
	{
		get
		{
			CheckDestroyed();
			if (!ScaleMomentumByMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:bScaleMomentumByMass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ScaleMomentumByMass_Offset), 0, ScaleMomentumByMass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ScaleMomentumByMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:bScaleMomentumByMass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ScaleMomentumByMass_Offset), 0, ScaleMomentumByMass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DamageType:bRadialDamageVelChange")]
	public bool RadialDamageVelChange
	{
		get
		{
			CheckDestroyed();
			if (!RadialDamageVelChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:bRadialDamageVelChange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RadialDamageVelChange_Offset), 0, RadialDamageVelChange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RadialDamageVelChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:bRadialDamageVelChange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RadialDamageVelChange_Offset), 0, RadialDamageVelChange_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DamageType:DamageImpulse")]
	public float DamageImpulse
	{
		get
		{
			CheckDestroyed();
			if (!DamageImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DamageImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DamageImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamageImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DamageImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DamageImpulse_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DamageType:DestructibleImpulse")]
	public float DestructibleImpulse
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DestructibleImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestructibleImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DestructibleImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestructibleImpulse_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DamageType:DestructibleDamageSpreadScale")]
	public float DestructibleDamageSpreadScale
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleDamageSpreadScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DestructibleDamageSpreadScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestructibleDamageSpreadScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleDamageSpreadScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DestructibleDamageSpreadScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestructibleDamageSpreadScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DamageType:DamageFalloff")]
	public float DamageFalloff
	{
		get
		{
			CheckDestroyed();
			if (!DamageFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DamageFalloff");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DamageFalloff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamageFalloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DamageType:DamageFalloff");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DamageFalloff_Offset), value);
			}
		}
	}

	static UDamageType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDamageType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDamageType));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.DamageType");
		NativeReflectionCached.GetPropertyRef(ref CausedByWorld_PropertyAddress, unrealStruct, "bCausedByWorld");
		CausedByWorld_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCausedByWorld");
		CausedByWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCausedByWorld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMomentumByMass_PropertyAddress, unrealStruct, "bScaleMomentumByMass");
		ScaleMomentumByMass_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bScaleMomentumByMass");
		ScaleMomentumByMass_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bScaleMomentumByMass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RadialDamageVelChange_PropertyAddress, unrealStruct, "bRadialDamageVelChange");
		RadialDamageVelChange_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRadialDamageVelChange");
		RadialDamageVelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRadialDamageVelChange", Classes.FBoolProperty);
		DamageImpulse_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DamageImpulse");
		DamageImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DamageImpulse", Classes.FFloatProperty);
		DestructibleImpulse_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestructibleImpulse");
		DestructibleImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestructibleImpulse", Classes.FFloatProperty);
		DestructibleDamageSpreadScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DestructibleDamageSpreadScale");
		DestructibleDamageSpreadScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DestructibleDamageSpreadScale", Classes.FFloatProperty);
		DamageFalloff_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DamageFalloff");
		DamageFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DamageFalloff", Classes.FFloatProperty);
	}
}
