using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset")]
public class BGWBeAtkPhysAnimDataAsset : BGWBasePhysAnimDataAsset
{
	private static bool PhysWeightCurve_IsValid;

	private static int PhysWeightCurve_Offset;

	private static bool MotorStrengthCurve_IsValid;

	private static int MotorStrengthCurve_Offset;

	private static bool HitImpulse_IsValid;

	private static int HitImpulse_Offset;

	private static bool bPartPhysics_IsValid;

	private static int bPartPhysics_Offset;

	private static FFieldAddress bPartPhysics_PropertyAddress;

	private static bool bHitOnPelvis_IsValid;

	private static int bHitOnPelvis_Offset;

	private static FFieldAddress bHitOnPelvis_PropertyAddress;

	private static bool bScaledByTotalMass_IsValid;

	private static int bScaledByTotalMass_Offset;

	private static FFieldAddress bScaledByTotalMass_PropertyAddress;

	private static bool bCanHitSpine_IsValid;

	private static int bCanHitSpine_Offset;

	private static FFieldAddress bCanHitSpine_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:PhysWeightCurve")]
	public UCurveFloat PhysWeightCurve
	{
		get
		{
			CheckDestroyed();
			if (!PhysWeightCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:PhysWeightCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, PhysWeightCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysWeightCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:PhysWeightCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, PhysWeightCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:MotorStrengthCurve")]
	public UCurveFloat MotorStrengthCurve
	{
		get
		{
			CheckDestroyed();
			if (!MotorStrengthCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:MotorStrengthCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, MotorStrengthCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MotorStrengthCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:MotorStrengthCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, MotorStrengthCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:HitImpulse")]
	public float HitImpulse
	{
		get
		{
			CheckDestroyed();
			if (!HitImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:HitImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:HitImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitImpulse_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bPartPhysics")]
	public bool bPartPhysics
	{
		get
		{
			CheckDestroyed();
			if (!bPartPhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bPartPhysics");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPartPhysics_Offset), 0, bPartPhysics_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPartPhysics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bPartPhysics");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPartPhysics_Offset), 0, bPartPhysics_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bHitOnPelvis")]
	public bool bHitOnPelvis
	{
		get
		{
			CheckDestroyed();
			if (!bHitOnPelvis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bHitOnPelvis");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHitOnPelvis_Offset), 0, bHitOnPelvis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHitOnPelvis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bHitOnPelvis");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHitOnPelvis_Offset), 0, bHitOnPelvis_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bScaledByTotalMass")]
	public bool bScaledByTotalMass
	{
		get
		{
			CheckDestroyed();
			if (!bScaledByTotalMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bScaledByTotalMass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bScaledByTotalMass_Offset), 0, bScaledByTotalMass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bScaledByTotalMass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bScaledByTotalMass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bScaledByTotalMass_Offset), 0, bScaledByTotalMass_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bCanHitSpine")]
	public bool bCanHitSpine
	{
		get
		{
			CheckDestroyed();
			if (!bCanHitSpine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bCanHitSpine");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanHitSpine_Offset), 0, bCanHitSpine_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanHitSpine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset:bCanHitSpine");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanHitSpine_Offset), 0, bCanHitSpine_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWBeAtkPhysAnimDataAsset");
		PhysWeightCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhysWeightCurve");
		PhysWeightCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhysWeightCurve", Classes.FObjectProperty);
		MotorStrengthCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MotorStrengthCurve");
		MotorStrengthCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MotorStrengthCurve", Classes.FObjectProperty);
		HitImpulse_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitImpulse");
		HitImpulse_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitImpulse", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bPartPhysics_PropertyAddress, unrealStruct, "bPartPhysics");
		bPartPhysics_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bPartPhysics");
		bPartPhysics_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bPartPhysics", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHitOnPelvis_PropertyAddress, unrealStruct, "bHitOnPelvis");
		bHitOnPelvis_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHitOnPelvis");
		bHitOnPelvis_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHitOnPelvis", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bScaledByTotalMass_PropertyAddress, unrealStruct, "bScaledByTotalMass");
		bScaledByTotalMass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bScaledByTotalMass");
		bScaledByTotalMass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bScaledByTotalMass", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCanHitSpine_PropertyAddress, unrealStruct, "bCanHitSpine");
		bCanHitSpine_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanHitSpine");
		bCanHitSpine_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanHitSpine", Classes.FBoolProperty);
	}

	static BGWBeAtkPhysAnimDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWBeAtkPhysAnimDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWBeAtkPhysAnimDataAsset));
	}
}
