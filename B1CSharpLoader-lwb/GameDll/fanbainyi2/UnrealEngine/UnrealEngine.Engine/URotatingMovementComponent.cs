using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.RotatingMovementComponent", "Engine", UnrealModuleType.Engine)]
public class URotatingMovementComponent : UMovementComponent
{
	private static bool RotationRate_IsValid;

	private static int RotationRate_Offset;

	private static bool PivotTranslation_IsValid;

	private static int PivotTranslation_Offset;

	private static bool RotationInLocalSpace_IsValid;

	private static FFieldAddress RotationInLocalSpace_PropertyAddress;

	private static int RotationInLocalSpace_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/Engine.RotatingMovementComponent:RotationRate")]
	public FRotator RotationRate
	{
		get
		{
			CheckDestroyed();
			if (!RotationRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RotatingMovementComponent:RotationRate");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RotatingMovementComponent:RotationRate");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RotatingMovementComponent:PivotTranslation")]
	public FVector PivotTranslation
	{
		get
		{
			CheckDestroyed();
			if (!PivotTranslation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RotatingMovementComponent:PivotTranslation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PivotTranslation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PivotTranslation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RotatingMovementComponent:PivotTranslation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PivotTranslation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.RotatingMovementComponent:bRotationInLocalSpace")]
	public bool RotationInLocalSpace
	{
		get
		{
			CheckDestroyed();
			if (!RotationInLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RotatingMovementComponent:bRotationInLocalSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RotationInLocalSpace_Offset), 0, RotationInLocalSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationInLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RotatingMovementComponent:bRotationInLocalSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RotationInLocalSpace_Offset), 0, RotationInLocalSpace_PropertyAddress.Address, value);
			}
		}
	}

	static URotatingMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URotatingMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URotatingMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.RotatingMovementComponent");
		RotationRate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RotationRate");
		RotationRate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RotationRate", Classes.FStructProperty);
		PivotTranslation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PivotTranslation");
		PivotTranslation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PivotTranslation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RotationInLocalSpace_PropertyAddress, unrealStruct, "bRotationInLocalSpace");
		RotationInLocalSpace_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRotationInLocalSpace");
		RotationInLocalSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRotationInLocalSpace", Classes.FBoolProperty);
	}
}
