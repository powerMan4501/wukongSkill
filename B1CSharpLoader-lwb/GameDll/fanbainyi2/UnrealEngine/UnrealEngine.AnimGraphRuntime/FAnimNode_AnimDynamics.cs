using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_AnimDynamics
{
	private static bool ComponentPose_IsValid;

	private static int ComponentPose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:ComponentPose")]
	public FComponentSpacePoseLink ComponentPose;

	private static bool LODThreshold_IsValid;

	private static int LODThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:LODThreshold")]
	public int LODThreshold;

	private static bool AlphaInputType_IsValid;

	private static FFieldAddress AlphaInputType_PropertyAddress;

	private static int AlphaInputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaInputType")]
	public EAnimAlphaInputType AlphaInputType;

	private static bool AlphaBoolEnabled_IsValid;

	private static FFieldAddress AlphaBoolEnabled_PropertyAddress;

	private static int AlphaBoolEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:bAlphaBoolEnabled")]
	public bool AlphaBoolEnabled;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:Alpha")]
	public float Alpha;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool AlphaBoolBlend_IsValid;

	private static int AlphaBoolBlend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaBoolBlend")]
	public FInputAlphaBoolBlend AlphaBoolBlend;

	private static bool AlphaCurveName_IsValid;

	private static int AlphaCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaCurveName")]
	public FName AlphaCurveName;

	private static bool AlphaScaleBiasClamp_IsValid;

	private static int AlphaScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaScaleBiasClamp")]
	public FInputScaleBiasClamp AlphaScaleBiasClamp;

	private static bool LinearDampingOverride_IsValid;

	private static int LinearDampingOverride_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:LinearDampingOverride")]
	public float LinearDampingOverride;

	private static bool AngularDampingOverride_IsValid;

	private static int AngularDampingOverride_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:AngularDampingOverride")]
	public float AngularDampingOverride;

	private static bool GravityScale_IsValid;

	private static int GravityScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:GravityScale")]
	public float GravityScale;

	private static bool GravityOverride_IsValid;

	private static int GravityOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:GravityOverride")]
	public FVector GravityOverride;

	private static bool LinearSpringConstant_IsValid;

	private static int LinearSpringConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:LinearSpringConstant")]
	public float LinearSpringConstant;

	private static bool AngularSpringConstant_IsValid;

	private static int AngularSpringConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:AngularSpringConstant")]
	public float AngularSpringConstant;

	private static bool AngularBiasOverride_IsValid;

	private static int AngularBiasOverride_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:AngularBiasOverride")]
	public float AngularBiasOverride;

	private static bool SimulationSpace_IsValid;

	private static FFieldAddress SimulationSpace_PropertyAddress;

	private static int SimulationSpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:SimulationSpace")]
	public EAnimPhysSimSpaceType SimulationSpace;

	private static bool UseGravityOverride_IsValid;

	private static FFieldAddress UseGravityOverride_PropertyAddress;

	private static int UseGravityOverride_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AnimDynamics:bUseGravityOverride")]
	public bool UseGravityOverride;

	private static bool FAnimNode_AnimDynamics_IsValid;

	private static int FAnimNode_AnimDynamics_StructSize;

	public FAnimNode_AnimDynamics Copy()
	{
		return this;
	}

	public static FAnimNode_AnimDynamics FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_AnimDynamics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_AnimDynamics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_AnimDynamics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_AnimDynamics(nativeBuffer + arrayIndex * FAnimNode_AnimDynamics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_AnimDynamics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_AnimDynamics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_AnimDynamics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_AnimDynamics");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinearDampingOverride_Offset), LinearDampingOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngularDampingOverride_Offset), AngularDampingOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GravityScale_Offset), GravityScale);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, GravityOverride_Offset), GravityOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinearSpringConstant_Offset), LinearSpringConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngularSpringConstant_Offset), AngularSpringConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngularBiasOverride_Offset), AngularBiasOverride);
		EnumMarshaler<EAnimPhysSimSpaceType>.ToNative(IntPtr.Add(nativeStruct, SimulationSpace_Offset), 0, SimulationSpace_PropertyAddress.Address, SimulationSpace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGravityOverride_Offset), 0, UseGravityOverride_PropertyAddress.Address, UseGravityOverride);
		FComponentSpacePoseLink.ToNative(IntPtr.Add(nativeStruct, ComponentPose_Offset), ComponentPose);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODThreshold_Offset), LODThreshold);
		EnumMarshaler<EAnimAlphaInputType>.ToNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address, AlphaInputType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address, AlphaBoolEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		FInputAlphaBoolBlend.ToNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset), AlphaBoolBlend);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset), AlphaCurveName);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset), AlphaScaleBiasClamp);
	}

	public FAnimNode_AnimDynamics(IntPtr nativeStruct)
	{
		if (!FAnimNode_AnimDynamics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_AnimDynamics");
			LinearDampingOverride = 0f;
			AngularDampingOverride = 0f;
			GravityScale = 0f;
			GravityOverride = default(FVector);
			LinearSpringConstant = 0f;
			AngularSpringConstant = 0f;
			AngularBiasOverride = 0f;
			SimulationSpace = EAnimPhysSimSpaceType.Component;
			UseGravityOverride = false;
			ComponentPose = default(FComponentSpacePoseLink);
			LODThreshold = 0;
			AlphaInputType = EAnimAlphaInputType.Float;
			AlphaBoolEnabled = false;
			Alpha = 0f;
			AlphaScaleBias = default(FInputScaleBias);
			AlphaBoolBlend = default(FInputAlphaBoolBlend);
			AlphaCurveName = default(FName);
			AlphaScaleBiasClamp = default(FInputScaleBiasClamp);
		}
		else
		{
			LinearDampingOverride = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinearDampingOverride_Offset));
			AngularDampingOverride = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngularDampingOverride_Offset));
			GravityScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GravityScale_Offset));
			GravityOverride = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, GravityOverride_Offset));
			LinearSpringConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinearSpringConstant_Offset));
			AngularSpringConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngularSpringConstant_Offset));
			AngularBiasOverride = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngularBiasOverride_Offset));
			SimulationSpace = EnumMarshaler<EAnimPhysSimSpaceType>.FromNative(IntPtr.Add(nativeStruct, SimulationSpace_Offset), 0, SimulationSpace_PropertyAddress.Address);
			UseGravityOverride = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGravityOverride_Offset), 0, UseGravityOverride_PropertyAddress.Address);
			ComponentPose = FComponentSpacePoseLink.FromNative(IntPtr.Add(nativeStruct, ComponentPose_Offset));
			LODThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODThreshold_Offset));
			AlphaInputType = EnumMarshaler<EAnimAlphaInputType>.FromNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address);
			AlphaBoolEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address);
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			AlphaBoolBlend = FInputAlphaBoolBlend.FromNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset));
			AlphaCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset));
			AlphaScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset));
		}
	}

	static FAnimNode_AnimDynamics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_AnimDynamics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_AnimDynamics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_AnimDynamics");
		FAnimNode_AnimDynamics_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentPose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentPose");
		ComponentPose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentPose", Classes.FStructProperty);
		LODThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODThreshold");
		LODThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODThreshold", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaInputType_PropertyAddress, intPtr, "AlphaInputType");
		AlphaInputType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaInputType");
		AlphaInputType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaInputType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaBoolEnabled_PropertyAddress, intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlphaBoolEnabled", Classes.FBoolProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		AlphaScaleBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBias");
		AlphaScaleBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBias", Classes.FStructProperty);
		AlphaBoolBlend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaBoolBlend");
		AlphaBoolBlend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaBoolBlend", Classes.FStructProperty);
		AlphaCurveName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaCurveName");
		AlphaCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaCurveName", Classes.FNameProperty);
		AlphaScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBiasClamp");
		AlphaScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBiasClamp", Classes.FStructProperty);
		LinearDampingOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearDampingOverride");
		LinearDampingOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearDampingOverride", Classes.FFloatProperty);
		AngularDampingOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularDampingOverride");
		AngularDampingOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularDampingOverride", Classes.FFloatProperty);
		GravityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GravityScale");
		GravityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GravityScale", Classes.FFloatProperty);
		GravityOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GravityOverride");
		GravityOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GravityOverride", Classes.FStructProperty);
		LinearSpringConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearSpringConstant");
		LinearSpringConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearSpringConstant", Classes.FFloatProperty);
		AngularSpringConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularSpringConstant");
		AngularSpringConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularSpringConstant", Classes.FFloatProperty);
		AngularBiasOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularBiasOverride");
		AngularBiasOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularBiasOverride", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SimulationSpace_PropertyAddress, intPtr, "SimulationSpace");
		SimulationSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimulationSpace");
		SimulationSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimulationSpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGravityOverride_PropertyAddress, intPtr, "bUseGravityOverride");
		UseGravityOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseGravityOverride");
		UseGravityOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseGravityOverride", Classes.FBoolProperty);
		FAnimNode_AnimDynamics_IsValid = intPtr != IntPtr.Zero && LinearDampingOverride_IsValid && AngularDampingOverride_IsValid && GravityScale_IsValid && GravityOverride_IsValid && LinearSpringConstant_IsValid && AngularSpringConstant_IsValid && AngularBiasOverride_IsValid && SimulationSpace_IsValid && UseGravityOverride_IsValid && ComponentPose_IsValid && LODThreshold_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_AnimDynamics", FAnimNode_AnimDynamics_IsValid);
	}
}
