using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXSimulationSettings", "TressFX", UnrealModuleType.GamePlugin)]
public struct FTressFXSimulationSettings
{
	private static bool Damping_IsValid;

	private static int Damping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:Damping")]
	public float Damping;

	private static bool GravityMagnitude_IsValid;

	private static int GravityMagnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:GravityMagnitude")]
	public float GravityMagnitude;

	private static bool EnableLengthConstraint_IsValid;

	private static FFieldAddress EnableLengthConstraint_PropertyAddress;

	private static int EnableLengthConstraint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:EnableLengthConstraint")]
	public bool EnableLengthConstraint;

	private static bool LengthConstraintsIterations_IsValid;

	private static int LengthConstraintsIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:LengthConstraintsIterations")]
	public int LengthConstraintsIterations;

	private static bool EnableGlobalShapeConstraint_IsValid;

	private static FFieldAddress EnableGlobalShapeConstraint_PropertyAddress;

	private static int EnableGlobalShapeConstraint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:EnableGlobalShapeConstraint")]
	public bool EnableGlobalShapeConstraint;

	private static bool GlobalConstraintStiffness_IsValid;

	private static int GlobalConstraintStiffness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:GlobalConstraintStiffness")]
	public float GlobalConstraintStiffness;

	private static bool GlobalShapeRange_IsValid;

	private static int GlobalShapeRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:GlobalShapeRange")]
	public float GlobalShapeRange;

	private static bool EnableLocalShapeConstraint_IsValid;

	private static FFieldAddress EnableLocalShapeConstraint_PropertyAddress;

	private static int EnableLocalShapeConstraint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:EnableLocalShapeConstraint")]
	public bool EnableLocalShapeConstraint;

	private static bool LocalShapeStiffness_IsValid;

	private static int LocalShapeStiffness_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:LocalShapeStiffness")]
	public FRuntimeFloatCurve LocalShapeStiffness;

	private static bool LocalConstraintsIterations_IsValid;

	private static int LocalConstraintsIterations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:LocalConstraintsIterations")]
	public int LocalConstraintsIterations;

	private static bool EnableVelocityShockPropagation_IsValid;

	private static FFieldAddress EnableVelocityShockPropagation_PropertyAddress;

	private static int EnableVelocityShockPropagation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:EnableVelocityShockPropagation")]
	public bool EnableVelocityShockPropagation;

	private static bool VSPStiffness_IsValid;

	private static int VSPStiffness_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:VSPStiffness")]
	public FRuntimeFloatCurve VSPStiffness;

	private static bool VSPAccelThresholdMax_IsValid;

	private static int VSPAccelThresholdMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:VSPAccelThresholdMax")]
	public float VSPAccelThresholdMax;

	private static bool TipSeparationMultipier_IsValid;

	private static int TipSeparationMultipier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:TipSeparationMultipier")]
	public float TipSeparationMultipier;

	private static bool RootSeparationMultipier_IsValid;

	private static int RootSeparationMultipier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:RootSeparationMultipier")]
	public float RootSeparationMultipier;

	private static bool WindMagnitude_IsValid;

	private static int WindMagnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:WindMagnitude")]
	public float WindMagnitude;

	private static bool WindDirection_IsValid;

	private static int WindDirection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:WindDirection")]
	public FVector3f WindDirection;

	private static bool SimulationQuality_IsValid;

	private static FFieldAddress SimulationQuality_PropertyAddress;

	private static int SimulationQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXSimulationSettings:SimulationQuality")]
	public ETressFXSimulationQuality SimulationQuality;

	private static bool FTressFXSimulationSettings_IsValid;

	private static int FTressFXSimulationSettings_StructSize;

	public FTressFXSimulationSettings Copy()
	{
		return this;
	}

	public static FTressFXSimulationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FTressFXSimulationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTressFXSimulationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTressFXSimulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTressFXSimulationSettings(nativeBuffer + arrayIndex * FTressFXSimulationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTressFXSimulationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTressFXSimulationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTressFXSimulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.TressFXSimulationSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Damping_Offset), Damping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GravityMagnitude_Offset), GravityMagnitude);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableLengthConstraint_Offset), 0, EnableLengthConstraint_PropertyAddress.Address, EnableLengthConstraint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LengthConstraintsIterations_Offset), LengthConstraintsIterations);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableGlobalShapeConstraint_Offset), 0, EnableGlobalShapeConstraint_PropertyAddress.Address, EnableGlobalShapeConstraint);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GlobalConstraintStiffness_Offset), GlobalConstraintStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GlobalShapeRange_Offset), GlobalShapeRange);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableLocalShapeConstraint_Offset), 0, EnableLocalShapeConstraint_PropertyAddress.Address, EnableLocalShapeConstraint);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, LocalShapeStiffness_Offset), LocalShapeStiffness);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LocalConstraintsIterations_Offset), LocalConstraintsIterations);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableVelocityShockPropagation_Offset), 0, EnableVelocityShockPropagation_PropertyAddress.Address, EnableVelocityShockPropagation);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, VSPStiffness_Offset), VSPStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VSPAccelThresholdMax_Offset), VSPAccelThresholdMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TipSeparationMultipier_Offset), TipSeparationMultipier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RootSeparationMultipier_Offset), RootSeparationMultipier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindMagnitude_Offset), WindMagnitude);
		FVector3f.ToNative(IntPtr.Add(nativeStruct, WindDirection_Offset), WindDirection);
		EnumMarshaler<ETressFXSimulationQuality>.ToNative(IntPtr.Add(nativeStruct, SimulationQuality_Offset), 0, SimulationQuality_PropertyAddress.Address, SimulationQuality);
	}

	public FTressFXSimulationSettings(IntPtr nativeStruct)
	{
		if (!FTressFXSimulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.TressFXSimulationSettings");
			Damping = 0f;
			GravityMagnitude = 0f;
			EnableLengthConstraint = false;
			LengthConstraintsIterations = 0;
			EnableGlobalShapeConstraint = false;
			GlobalConstraintStiffness = 0f;
			GlobalShapeRange = 0f;
			EnableLocalShapeConstraint = false;
			LocalShapeStiffness = default(FRuntimeFloatCurve);
			LocalConstraintsIterations = 0;
			EnableVelocityShockPropagation = false;
			VSPStiffness = default(FRuntimeFloatCurve);
			VSPAccelThresholdMax = 0f;
			TipSeparationMultipier = 0f;
			RootSeparationMultipier = 0f;
			WindMagnitude = 0f;
			WindDirection = default(FVector3f);
			SimulationQuality = ETressFXSimulationQuality.TFXSim_Disable;
		}
		else
		{
			Damping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Damping_Offset));
			GravityMagnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GravityMagnitude_Offset));
			EnableLengthConstraint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableLengthConstraint_Offset), 0, EnableLengthConstraint_PropertyAddress.Address);
			LengthConstraintsIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LengthConstraintsIterations_Offset));
			EnableGlobalShapeConstraint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableGlobalShapeConstraint_Offset), 0, EnableGlobalShapeConstraint_PropertyAddress.Address);
			GlobalConstraintStiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GlobalConstraintStiffness_Offset));
			GlobalShapeRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GlobalShapeRange_Offset));
			EnableLocalShapeConstraint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableLocalShapeConstraint_Offset), 0, EnableLocalShapeConstraint_PropertyAddress.Address);
			LocalShapeStiffness = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, LocalShapeStiffness_Offset));
			LocalConstraintsIterations = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LocalConstraintsIterations_Offset));
			EnableVelocityShockPropagation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableVelocityShockPropagation_Offset), 0, EnableVelocityShockPropagation_PropertyAddress.Address);
			VSPStiffness = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, VSPStiffness_Offset));
			VSPAccelThresholdMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VSPAccelThresholdMax_Offset));
			TipSeparationMultipier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TipSeparationMultipier_Offset));
			RootSeparationMultipier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RootSeparationMultipier_Offset));
			WindMagnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindMagnitude_Offset));
			WindDirection = FVector3f.FromNative(IntPtr.Add(nativeStruct, WindDirection_Offset));
			SimulationQuality = EnumMarshaler<ETressFXSimulationQuality>.FromNative(IntPtr.Add(nativeStruct, SimulationQuality_Offset), 0, SimulationQuality_PropertyAddress.Address);
		}
	}

	static FTressFXSimulationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTressFXSimulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTressFXSimulationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TressFX.TressFXSimulationSettings");
		FTressFXSimulationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Damping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Damping");
		Damping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Damping", Classes.FFloatProperty);
		GravityMagnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GravityMagnitude");
		GravityMagnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GravityMagnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableLengthConstraint_PropertyAddress, intPtr, "EnableLengthConstraint");
		EnableLengthConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableLengthConstraint");
		EnableLengthConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableLengthConstraint", Classes.FBoolProperty);
		LengthConstraintsIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LengthConstraintsIterations");
		LengthConstraintsIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LengthConstraintsIterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGlobalShapeConstraint_PropertyAddress, intPtr, "EnableGlobalShapeConstraint");
		EnableGlobalShapeConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableGlobalShapeConstraint");
		EnableGlobalShapeConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableGlobalShapeConstraint", Classes.FBoolProperty);
		GlobalConstraintStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlobalConstraintStiffness");
		GlobalConstraintStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlobalConstraintStiffness", Classes.FFloatProperty);
		GlobalShapeRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlobalShapeRange");
		GlobalShapeRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlobalShapeRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableLocalShapeConstraint_PropertyAddress, intPtr, "EnableLocalShapeConstraint");
		EnableLocalShapeConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableLocalShapeConstraint");
		EnableLocalShapeConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableLocalShapeConstraint", Classes.FBoolProperty);
		LocalShapeStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalShapeStiffness");
		LocalShapeStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalShapeStiffness", Classes.FStructProperty);
		LocalConstraintsIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalConstraintsIterations");
		LocalConstraintsIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalConstraintsIterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableVelocityShockPropagation_PropertyAddress, intPtr, "EnableVelocityShockPropagation");
		EnableVelocityShockPropagation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableVelocityShockPropagation");
		EnableVelocityShockPropagation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableVelocityShockPropagation", Classes.FBoolProperty);
		VSPStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VSPStiffness");
		VSPStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VSPStiffness", Classes.FStructProperty);
		VSPAccelThresholdMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VSPAccelThresholdMax");
		VSPAccelThresholdMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VSPAccelThresholdMax", Classes.FFloatProperty);
		TipSeparationMultipier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TipSeparationMultipier");
		TipSeparationMultipier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TipSeparationMultipier", Classes.FFloatProperty);
		RootSeparationMultipier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RootSeparationMultipier");
		RootSeparationMultipier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RootSeparationMultipier", Classes.FFloatProperty);
		WindMagnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindMagnitude");
		WindMagnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindMagnitude", Classes.FFloatProperty);
		WindDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindDirection");
		WindDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SimulationQuality_PropertyAddress, intPtr, "SimulationQuality");
		SimulationQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulationQuality");
		SimulationQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulationQuality", Classes.FEnumProperty);
		FTressFXSimulationSettings_IsValid = intPtr != IntPtr.Zero && Damping_IsValid && GravityMagnitude_IsValid && EnableLengthConstraint_IsValid && LengthConstraintsIterations_IsValid && EnableGlobalShapeConstraint_IsValid && GlobalConstraintStiffness_IsValid && GlobalShapeRange_IsValid && EnableLocalShapeConstraint_IsValid && LocalShapeStiffness_IsValid && LocalConstraintsIterations_IsValid && EnableVelocityShockPropagation_IsValid && VSPStiffness_IsValid && VSPAccelThresholdMax_IsValid && TipSeparationMultipier_IsValid && RootSeparationMultipier_IsValid && WindMagnitude_IsValid && WindDirection_IsValid && SimulationQuality_IsValid;
		NativeReflection.LogStructIsValid("/Script/TressFX.TressFXSimulationSettings", FTressFXSimulationSettings_IsValid);
	}
}
