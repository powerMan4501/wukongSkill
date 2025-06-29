using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGBoundsModifierSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBoundsModifierSettings : UPCGSettings
{
	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	private static bool BoundsMin_IsValid;

	private static int BoundsMin_Offset;

	private static bool BoundsMax_IsValid;

	private static int BoundsMax_Offset;

	private static bool AffectSteepness_IsValid;

	private static FFieldAddress AffectSteepness_PropertyAddress;

	private static int AffectSteepness_Offset;

	private static bool Steepness_IsValid;

	private static int Steepness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBoundsModifierSettings:Mode")]
	public EPCGBoundsModifierMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:Mode");
				return EPCGBoundsModifierMode.Set;
			}
			return EnumMarshaler<EPCGBoundsModifierMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGBoundsModifierMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBoundsModifierSettings:BoundsMin")]
	public FVector BoundsMin
	{
		get
		{
			CheckDestroyed();
			if (!BoundsMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:BoundsMin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, BoundsMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoundsMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:BoundsMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, BoundsMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBoundsModifierSettings:BoundsMax")]
	public FVector BoundsMax
	{
		get
		{
			CheckDestroyed();
			if (!BoundsMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:BoundsMax");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, BoundsMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoundsMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:BoundsMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, BoundsMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBoundsModifierSettings:bAffectSteepness")]
	public bool AffectSteepness
	{
		get
		{
			CheckDestroyed();
			if (!AffectSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:bAffectSteepness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectSteepness_Offset), 0, AffectSteepness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectSteepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:bAffectSteepness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectSteepness_Offset), 0, AffectSteepness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGBoundsModifierSettings:Steepness")]
	public float Steepness
	{
		get
		{
			CheckDestroyed();
			if (!Steepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:Steepness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Steepness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Steepness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBoundsModifierSettings:Steepness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Steepness_Offset), value);
			}
		}
	}

	static UPCGBoundsModifierSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBoundsModifierSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBoundsModifierSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGBoundsModifierSettings");
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
		BoundsMin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoundsMin");
		BoundsMin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoundsMin", Classes.FStructProperty);
		BoundsMax_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoundsMax");
		BoundsMax_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoundsMax", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectSteepness_PropertyAddress, unrealStruct, "bAffectSteepness");
		AffectSteepness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAffectSteepness");
		AffectSteepness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAffectSteepness", Classes.FBoolProperty);
		Steepness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Steepness");
		Steepness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Steepness", Classes.FFloatProperty);
	}
}
