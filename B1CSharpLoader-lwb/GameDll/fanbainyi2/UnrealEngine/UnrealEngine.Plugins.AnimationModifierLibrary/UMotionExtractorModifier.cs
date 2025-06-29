using System;
using UnrealEngine.AnimationModifiers;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationModifierLibrary;

[UClass(Flags = (ClassFlags)809500838uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier", "AnimationModifierLibrary", UnrealModuleType.EnginePlugin)]
public class UMotionExtractorModifier : UAnimationModifier
{
	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	private static bool MotionType_IsValid;

	private static FFieldAddress MotionType_PropertyAddress;

	private static int MotionType_Offset;

	private static bool Axis_IsValid;

	private static FFieldAddress Axis_PropertyAddress;

	private static int Axis_Offset;

	private static bool ComponentSpace_IsValid;

	private static FFieldAddress ComponentSpace_PropertyAddress;

	private static int ComponentSpace_Offset;

	private static bool AbsoluteValue_IsValid;

	private static FFieldAddress AbsoluteValue_PropertyAddress;

	private static int AbsoluteValue_Offset;

	private static bool MathOperation_IsValid;

	private static FFieldAddress MathOperation_PropertyAddress;

	private static int MathOperation_Offset;

	private static bool Modifier_IsValid;

	private static int Modifier_Offset;

	private static bool UseCustomCurveName_IsValid;

	private static FFieldAddress UseCustomCurveName_PropertyAddress;

	private static int UseCustomCurveName_Offset;

	private static bool CustomCurveName_IsValid;

	private static int CustomCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:BoneName")]
	public FName BoneName
	{
		get
		{
			CheckDestroyed();
			if (!BoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:BoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:BoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BoneName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:MotionType")]
	public EMotionExtractor_MotionType MotionType
	{
		get
		{
			CheckDestroyed();
			if (!MotionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:MotionType");
				return EMotionExtractor_MotionType.Translation;
			}
			return EnumMarshaler<EMotionExtractor_MotionType>.FromNative(IntPtr.Add(base.Address, MotionType_Offset), 0, MotionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:MotionType");
			}
			else
			{
				EnumMarshaler<EMotionExtractor_MotionType>.ToNative(IntPtr.Add(base.Address, MotionType_Offset), 0, MotionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:Axis")]
	public EMotionExtractor_Axis Axis
	{
		get
		{
			CheckDestroyed();
			if (!Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:Axis");
				return EMotionExtractor_Axis.X;
			}
			return EnumMarshaler<EMotionExtractor_Axis>.FromNative(IntPtr.Add(base.Address, Axis_Offset), 0, Axis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:Axis");
			}
			else
			{
				EnumMarshaler<EMotionExtractor_Axis>.ToNative(IntPtr.Add(base.Address, Axis_Offset), 0, Axis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:bComponentSpace")]
	public bool ComponentSpace
	{
		get
		{
			CheckDestroyed();
			if (!ComponentSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:bComponentSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ComponentSpace_Offset), 0, ComponentSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComponentSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:bComponentSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ComponentSpace_Offset), 0, ComponentSpace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:bAbsoluteValue")]
	public bool AbsoluteValue
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:bAbsoluteValue");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteValue_Offset), 0, AbsoluteValue_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:bAbsoluteValue");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteValue_Offset), 0, AbsoluteValue_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:MathOperation")]
	public EMotionExtractor_MathOperation MathOperation
	{
		get
		{
			CheckDestroyed();
			if (!MathOperation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:MathOperation");
				return EMotionExtractor_MathOperation.None;
			}
			return EnumMarshaler<EMotionExtractor_MathOperation>.FromNative(IntPtr.Add(base.Address, MathOperation_Offset), 0, MathOperation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MathOperation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:MathOperation");
			}
			else
			{
				EnumMarshaler<EMotionExtractor_MathOperation>.ToNative(IntPtr.Add(base.Address, MathOperation_Offset), 0, MathOperation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:Modifier")]
	public float Modifier
	{
		get
		{
			CheckDestroyed();
			if (!Modifier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:Modifier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Modifier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Modifier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:Modifier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Modifier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:bUseCustomCurveName")]
	public bool UseCustomCurveName
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomCurveName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:bUseCustomCurveName");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomCurveName_Offset), 0, UseCustomCurveName_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomCurveName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:bUseCustomCurveName");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomCurveName_Offset), 0, UseCustomCurveName_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationModifierLibrary.MotionExtractorModifier:CustomCurveName")]
	public FName CustomCurveName
	{
		get
		{
			CheckDestroyed();
			if (!CustomCurveName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:CustomCurveName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CustomCurveName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomCurveName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationModifierLibrary.MotionExtractorModifier:CustomCurveName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CustomCurveName_Offset), value);
			}
		}
	}

	static UMotionExtractorModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMotionExtractorModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMotionExtractorModifier));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AnimationModifierLibrary.MotionExtractorModifier");
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MotionType_PropertyAddress, unrealStruct, "MotionType");
		MotionType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MotionType");
		MotionType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MotionType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Axis_PropertyAddress, unrealStruct, "Axis");
		Axis_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Axis");
		Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Axis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentSpace_PropertyAddress, unrealStruct, "bComponentSpace");
		ComponentSpace_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bComponentSpace");
		ComponentSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bComponentSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteValue_PropertyAddress, unrealStruct, "bAbsoluteValue");
		AbsoluteValue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAbsoluteValue");
		AbsoluteValue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAbsoluteValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MathOperation_PropertyAddress, unrealStruct, "MathOperation");
		MathOperation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MathOperation");
		MathOperation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MathOperation", Classes.FEnumProperty);
		Modifier_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Modifier");
		Modifier_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Modifier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomCurveName_PropertyAddress, unrealStruct, "bUseCustomCurveName");
		UseCustomCurveName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseCustomCurveName");
		UseCustomCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseCustomCurveName", Classes.FBoolProperty);
		CustomCurveName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomCurveName");
		CustomCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomCurveName", Classes.FNameProperty);
	}
}
