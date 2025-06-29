using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Foliage.InteractiveFoliageActor", "Foliage", UnrealModuleType.Engine)]
public class AInteractiveFoliageActor : AStaticMeshActor
{
	private static bool FoliageDamageImpulseScale_IsValid;

	private static int FoliageDamageImpulseScale_Offset;

	private static bool FoliageTouchImpulseScale_IsValid;

	private static int FoliageTouchImpulseScale_Offset;

	private static bool FoliageStiffness_IsValid;

	private static int FoliageStiffness_Offset;

	private static bool FoliageStiffnessQuadratic_IsValid;

	private static int FoliageStiffnessQuadratic_Offset;

	private static bool FoliageDamping_IsValid;

	private static int FoliageDamping_Offset;

	private static bool MaxDamageImpulse_IsValid;

	private static int MaxDamageImpulse_Offset;

	private static bool MaxTouchImpulse_IsValid;

	private static int MaxTouchImpulse_Offset;

	private static bool MaxForce_IsValid;

	private static int MaxForce_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:FoliageDamageImpulseScale")]
	public float FoliageDamageImpulseScale
	{
		get
		{
			CheckDestroyed();
			if (!FoliageDamageImpulseScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageDamageImpulseScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FoliageDamageImpulseScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoliageDamageImpulseScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageDamageImpulseScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FoliageDamageImpulseScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:FoliageTouchImpulseScale")]
	public float FoliageTouchImpulseScale
	{
		get
		{
			CheckDestroyed();
			if (!FoliageTouchImpulseScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageTouchImpulseScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FoliageTouchImpulseScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoliageTouchImpulseScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageTouchImpulseScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FoliageTouchImpulseScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:FoliageStiffness")]
	public float FoliageStiffness
	{
		get
		{
			CheckDestroyed();
			if (!FoliageStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageStiffness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FoliageStiffness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoliageStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageStiffness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FoliageStiffness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:FoliageStiffnessQuadratic")]
	public float FoliageStiffnessQuadratic
	{
		get
		{
			CheckDestroyed();
			if (!FoliageStiffnessQuadratic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageStiffnessQuadratic");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FoliageStiffnessQuadratic_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoliageStiffnessQuadratic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageStiffnessQuadratic");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FoliageStiffnessQuadratic_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:FoliageDamping")]
	public float FoliageDamping
	{
		get
		{
			CheckDestroyed();
			if (!FoliageDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageDamping");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FoliageDamping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FoliageDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:FoliageDamping");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FoliageDamping_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:MaxDamageImpulse")]
	public float MaxDamageImpulse
	{
		get
		{
			CheckDestroyed();
			if (!MaxDamageImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:MaxDamageImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDamageImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDamageImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:MaxDamageImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDamageImpulse_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:MaxTouchImpulse")]
	public float MaxTouchImpulse
	{
		get
		{
			CheckDestroyed();
			if (!MaxTouchImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:MaxTouchImpulse");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxTouchImpulse_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxTouchImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:MaxTouchImpulse");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxTouchImpulse_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Foliage.InteractiveFoliageActor:MaxForce")]
	public float MaxForce
	{
		get
		{
			CheckDestroyed();
			if (!MaxForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:MaxForce");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxForce_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.InteractiveFoliageActor:MaxForce");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxForce_Offset), value);
			}
		}
	}

	static AInteractiveFoliageActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AInteractiveFoliageActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AInteractiveFoliageActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Foliage.InteractiveFoliageActor");
		FoliageDamageImpulseScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageDamageImpulseScale");
		FoliageDamageImpulseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageDamageImpulseScale", Classes.FFloatProperty);
		FoliageTouchImpulseScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageTouchImpulseScale");
		FoliageTouchImpulseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageTouchImpulseScale", Classes.FFloatProperty);
		FoliageStiffness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageStiffness");
		FoliageStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageStiffness", Classes.FFloatProperty);
		FoliageStiffnessQuadratic_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageStiffnessQuadratic");
		FoliageStiffnessQuadratic_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageStiffnessQuadratic", Classes.FFloatProperty);
		FoliageDamping_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FoliageDamping");
		FoliageDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FoliageDamping", Classes.FFloatProperty);
		MaxDamageImpulse_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxDamageImpulse");
		MaxDamageImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxDamageImpulse", Classes.FFloatProperty);
		MaxTouchImpulse_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxTouchImpulse");
		MaxTouchImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxTouchImpulse", Classes.FFloatProperty);
		MaxForce_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxForce");
		MaxForce_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxForce", Classes.FFloatProperty);
	}
}
