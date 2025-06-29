using System;
using UnrealEngine.AnimationModifiers;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationLocomotionLibraryEditor;

[UClass(Flags = (ClassFlags)809500838uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier", "AnimationLocomotionLibraryEditor", UnrealModuleType.EnginePlugin)]
public class UDistanceCurveModifier : UAnimationModifier
{
	private static bool CurveName_IsValid;

	private static int CurveName_Offset;

	private static bool StopSpeedThreshold_IsValid;

	private static int StopSpeedThreshold_Offset;

	private static bool Axis_IsValid;

	private static FFieldAddress Axis_PropertyAddress;

	private static int Axis_Offset;

	private static bool StopAtEnd_IsValid;

	private static FFieldAddress StopAtEnd_PropertyAddress;

	private static int StopAtEnd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:CurveName")]
	public FName CurveName
	{
		get
		{
			CheckDestroyed();
			if (!CurveName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:CurveName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CurveName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurveName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:CurveName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CurveName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:StopSpeedThreshold")]
	public float StopSpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!StopSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:StopSpeedThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StopSpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:StopSpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StopSpeedThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:Axis")]
	public EDistanceCurve_Axis Axis
	{
		get
		{
			CheckDestroyed();
			if (!Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:Axis");
				return EDistanceCurve_Axis.X;
			}
			return EnumMarshaler<EDistanceCurve_Axis>.FromNative(IntPtr.Add(base.Address, Axis_Offset), 0, Axis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Axis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:Axis");
			}
			else
			{
				EnumMarshaler<EDistanceCurve_Axis>.ToNative(IntPtr.Add(base.Address, Axis_Offset), 0, Axis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:bStopAtEnd")]
	public bool StopAtEnd
	{
		get
		{
			CheckDestroyed();
			if (!StopAtEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:bStopAtEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StopAtEnd_Offset), 0, StopAtEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StopAtEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier:bStopAtEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StopAtEnd_Offset), 0, StopAtEnd_PropertyAddress.Address, value);
			}
		}
	}

	static UDistanceCurveModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDistanceCurveModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDistanceCurveModifier));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AnimationLocomotionLibraryEditor.DistanceCurveModifier");
		CurveName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CurveName");
		CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CurveName", Classes.FNameProperty);
		StopSpeedThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StopSpeedThreshold");
		StopSpeedThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StopSpeedThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Axis_PropertyAddress, unrealStruct, "Axis");
		Axis_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Axis");
		Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Axis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAtEnd_PropertyAddress, unrealStruct, "bStopAtEnd");
		StopAtEnd_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bStopAtEnd");
		StopAtEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bStopAtEnd", Classes.FBoolProperty);
	}
}
