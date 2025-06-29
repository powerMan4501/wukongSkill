using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSplineSamplerParams", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGSplineSamplerParams
{
	private static bool Dimension_IsValid;

	private static FFieldAddress Dimension_PropertyAddress;

	private static int Dimension_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:Dimension")]
	public EPCGSplineSamplingDimension Dimension;

	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:Mode")]
	public EPCGSplineSamplingMode Mode;

	private static bool Fill_IsValid;

	private static FFieldAddress Fill_PropertyAddress;

	private static int Fill_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:Fill")]
	public EPCGSplineSamplingFill Fill;

	private static bool SubdivisionsPerSegment_IsValid;

	private static int SubdivisionsPerSegment_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:SubdivisionsPerSegment")]
	public int SubdivisionsPerSegment;

	private static bool DistanceIncrement_IsValid;

	private static int DistanceIncrement_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:DistanceIncrement")]
	public float DistanceIncrement;

	private static bool NumPlanarSubdivisions_IsValid;

	private static int NumPlanarSubdivisions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:NumPlanarSubdivisions")]
	public int NumPlanarSubdivisions;

	private static bool NumHeightSubdivisions_IsValid;

	private static int NumHeightSubdivisions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:NumHeightSubdivisions")]
	public int NumHeightSubdivisions;

	private static bool ComputeDirectionDelta_IsValid;

	private static FFieldAddress ComputeDirectionDelta_PropertyAddress;

	private static int ComputeDirectionDelta_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:bComputeDirectionDelta")]
	public bool ComputeDirectionDelta;

	private static bool NextDirectionDeltaAttribute_IsValid;

	private static int NextDirectionDeltaAttribute_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:NextDirectionDeltaAttribute")]
	public FName NextDirectionDeltaAttribute;

	private static bool ComputeCurvature_IsValid;

	private static FFieldAddress ComputeCurvature_PropertyAddress;

	private static int ComputeCurvature_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:bComputeCurvature")]
	public bool ComputeCurvature;

	private static bool CurvatureAttribute_IsValid;

	private static int CurvatureAttribute_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:CurvatureAttribute")]
	public FName CurvatureAttribute;

	private static bool Unbounded_IsValid;

	private static FFieldAddress Unbounded_PropertyAddress;

	private static int Unbounded_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:bUnbounded")]
	public bool Unbounded;

	private static bool InteriorSampleSpacing_IsValid;

	private static int InteriorSampleSpacing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:InteriorSampleSpacing")]
	public float InteriorSampleSpacing;

	private static bool InteriorBorderSampleSpacing_IsValid;

	private static int InteriorBorderSampleSpacing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:InteriorBorderSampleSpacing")]
	public float InteriorBorderSampleSpacing;

	private static bool TreatSplineAsPolyline_IsValid;

	private static FFieldAddress TreatSplineAsPolyline_PropertyAddress;

	private static int TreatSplineAsPolyline_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:bTreatSplineAsPolyline")]
	public bool TreatSplineAsPolyline;

	private static bool InteriorOrientation_IsValid;

	private static FFieldAddress InteriorOrientation_PropertyAddress;

	private static int InteriorOrientation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:InteriorOrientation")]
	public EPCGSplineSamplingInteriorOrientation InteriorOrientation;

	private static bool PointSteepness_IsValid;

	private static int PointSteepness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:PointSteepness")]
	public float PointSteepness;

	private static bool SeedFromLocalPosition_IsValid;

	private static FFieldAddress SeedFromLocalPosition_PropertyAddress;

	private static int SeedFromLocalPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:bSeedFromLocalPosition")]
	public bool SeedFromLocalPosition;

	private static bool SeedFrom2DPosition_IsValid;

	private static FFieldAddress SeedFrom2DPosition_PropertyAddress;

	private static int SeedFrom2DPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerParams:bSeedFrom2DPosition")]
	public bool SeedFrom2DPosition;

	private static bool FPCGSplineSamplerParams_IsValid;

	private static int FPCGSplineSamplerParams_StructSize;

	public FPCGSplineSamplerParams Copy()
	{
		return this;
	}

	public static FPCGSplineSamplerParams FromNative(IntPtr nativeBuffer)
	{
		return new FPCGSplineSamplerParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGSplineSamplerParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGSplineSamplerParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGSplineSamplerParams(nativeBuffer + arrayIndex * FPCGSplineSamplerParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGSplineSamplerParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGSplineSamplerParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGSplineSamplerParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGSplineSamplerParams");
			return;
		}
		EnumMarshaler<EPCGSplineSamplingDimension>.ToNative(IntPtr.Add(nativeStruct, Dimension_Offset), 0, Dimension_PropertyAddress.Address, Dimension);
		EnumMarshaler<EPCGSplineSamplingMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		EnumMarshaler<EPCGSplineSamplingFill>.ToNative(IntPtr.Add(nativeStruct, Fill_Offset), 0, Fill_PropertyAddress.Address, Fill);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SubdivisionsPerSegment_Offset), SubdivisionsPerSegment);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceIncrement_Offset), DistanceIncrement);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumPlanarSubdivisions_Offset), NumPlanarSubdivisions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumHeightSubdivisions_Offset), NumHeightSubdivisions);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ComputeDirectionDelta_Offset), 0, ComputeDirectionDelta_PropertyAddress.Address, ComputeDirectionDelta);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, NextDirectionDeltaAttribute_Offset), NextDirectionDeltaAttribute);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ComputeCurvature_Offset), 0, ComputeCurvature_PropertyAddress.Address, ComputeCurvature);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CurvatureAttribute_Offset), CurvatureAttribute);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Unbounded_Offset), 0, Unbounded_PropertyAddress.Address, Unbounded);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteriorSampleSpacing_Offset), InteriorSampleSpacing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InteriorBorderSampleSpacing_Offset), InteriorBorderSampleSpacing);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TreatSplineAsPolyline_Offset), 0, TreatSplineAsPolyline_PropertyAddress.Address, TreatSplineAsPolyline);
		EnumMarshaler<EPCGSplineSamplingInteriorOrientation>.ToNative(IntPtr.Add(nativeStruct, InteriorOrientation_Offset), 0, InteriorOrientation_PropertyAddress.Address, InteriorOrientation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PointSteepness_Offset), PointSteepness);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SeedFromLocalPosition_Offset), 0, SeedFromLocalPosition_PropertyAddress.Address, SeedFromLocalPosition);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SeedFrom2DPosition_Offset), 0, SeedFrom2DPosition_PropertyAddress.Address, SeedFrom2DPosition);
	}

	public FPCGSplineSamplerParams(IntPtr nativeStruct)
	{
		if (!FPCGSplineSamplerParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGSplineSamplerParams");
			Dimension = EPCGSplineSamplingDimension.OnSpline;
			Mode = EPCGSplineSamplingMode.Subdivision;
			Fill = EPCGSplineSamplingFill.Fill;
			SubdivisionsPerSegment = 0;
			DistanceIncrement = 0f;
			NumPlanarSubdivisions = 0;
			NumHeightSubdivisions = 0;
			ComputeDirectionDelta = false;
			NextDirectionDeltaAttribute = default(FName);
			ComputeCurvature = false;
			CurvatureAttribute = default(FName);
			Unbounded = false;
			InteriorSampleSpacing = 0f;
			InteriorBorderSampleSpacing = 0f;
			TreatSplineAsPolyline = false;
			InteriorOrientation = EPCGSplineSamplingInteriorOrientation.Uniform;
			PointSteepness = 0f;
			SeedFromLocalPosition = false;
			SeedFrom2DPosition = false;
		}
		else
		{
			Dimension = EnumMarshaler<EPCGSplineSamplingDimension>.FromNative(IntPtr.Add(nativeStruct, Dimension_Offset), 0, Dimension_PropertyAddress.Address);
			Mode = EnumMarshaler<EPCGSplineSamplingMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			Fill = EnumMarshaler<EPCGSplineSamplingFill>.FromNative(IntPtr.Add(nativeStruct, Fill_Offset), 0, Fill_PropertyAddress.Address);
			SubdivisionsPerSegment = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SubdivisionsPerSegment_Offset));
			DistanceIncrement = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceIncrement_Offset));
			NumPlanarSubdivisions = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumPlanarSubdivisions_Offset));
			NumHeightSubdivisions = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumHeightSubdivisions_Offset));
			ComputeDirectionDelta = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ComputeDirectionDelta_Offset), 0, ComputeDirectionDelta_PropertyAddress.Address);
			NextDirectionDeltaAttribute = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, NextDirectionDeltaAttribute_Offset));
			ComputeCurvature = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ComputeCurvature_Offset), 0, ComputeCurvature_PropertyAddress.Address);
			CurvatureAttribute = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CurvatureAttribute_Offset));
			Unbounded = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Unbounded_Offset), 0, Unbounded_PropertyAddress.Address);
			InteriorSampleSpacing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteriorSampleSpacing_Offset));
			InteriorBorderSampleSpacing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InteriorBorderSampleSpacing_Offset));
			TreatSplineAsPolyline = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TreatSplineAsPolyline_Offset), 0, TreatSplineAsPolyline_PropertyAddress.Address);
			InteriorOrientation = EnumMarshaler<EPCGSplineSamplingInteriorOrientation>.FromNative(IntPtr.Add(nativeStruct, InteriorOrientation_Offset), 0, InteriorOrientation_PropertyAddress.Address);
			PointSteepness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PointSteepness_Offset));
			SeedFromLocalPosition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SeedFromLocalPosition_Offset), 0, SeedFromLocalPosition_PropertyAddress.Address);
			SeedFrom2DPosition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SeedFrom2DPosition_Offset), 0, SeedFrom2DPosition_PropertyAddress.Address);
		}
	}

	static FPCGSplineSamplerParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGSplineSamplerParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGSplineSamplerParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGSplineSamplerParams");
		FPCGSplineSamplerParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Dimension_PropertyAddress, intPtr, "Dimension");
		Dimension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Dimension");
		Dimension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Dimension", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Fill_PropertyAddress, intPtr, "Fill");
		Fill_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Fill");
		Fill_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Fill", Classes.FEnumProperty);
		SubdivisionsPerSegment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubdivisionsPerSegment");
		SubdivisionsPerSegment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubdivisionsPerSegment", Classes.FIntProperty);
		DistanceIncrement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceIncrement");
		DistanceIncrement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceIncrement", Classes.FFloatProperty);
		NumPlanarSubdivisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumPlanarSubdivisions");
		NumPlanarSubdivisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumPlanarSubdivisions", Classes.FIntProperty);
		NumHeightSubdivisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumHeightSubdivisions");
		NumHeightSubdivisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumHeightSubdivisions", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeDirectionDelta_PropertyAddress, intPtr, "bComputeDirectionDelta");
		ComputeDirectionDelta_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputeDirectionDelta");
		ComputeDirectionDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputeDirectionDelta", Classes.FBoolProperty);
		NextDirectionDeltaAttribute_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NextDirectionDeltaAttribute");
		NextDirectionDeltaAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NextDirectionDeltaAttribute", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeCurvature_PropertyAddress, intPtr, "bComputeCurvature");
		ComputeCurvature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputeCurvature");
		ComputeCurvature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputeCurvature", Classes.FBoolProperty);
		CurvatureAttribute_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurvatureAttribute");
		CurvatureAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurvatureAttribute", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Unbounded_PropertyAddress, intPtr, "bUnbounded");
		Unbounded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUnbounded");
		Unbounded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUnbounded", Classes.FBoolProperty);
		InteriorSampleSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorSampleSpacing");
		InteriorSampleSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorSampleSpacing", Classes.FFloatProperty);
		InteriorBorderSampleSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorBorderSampleSpacing");
		InteriorBorderSampleSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorBorderSampleSpacing", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TreatSplineAsPolyline_PropertyAddress, intPtr, "bTreatSplineAsPolyline");
		TreatSplineAsPolyline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTreatSplineAsPolyline");
		TreatSplineAsPolyline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTreatSplineAsPolyline", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InteriorOrientation_PropertyAddress, intPtr, "InteriorOrientation");
		InteriorOrientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteriorOrientation");
		InteriorOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteriorOrientation", Classes.FEnumProperty);
		PointSteepness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointSteepness");
		PointSteepness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointSteepness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SeedFromLocalPosition_PropertyAddress, intPtr, "bSeedFromLocalPosition");
		SeedFromLocalPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSeedFromLocalPosition");
		SeedFromLocalPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSeedFromLocalPosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SeedFrom2DPosition_PropertyAddress, intPtr, "bSeedFrom2DPosition");
		SeedFrom2DPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSeedFrom2DPosition");
		SeedFrom2DPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSeedFrom2DPosition", Classes.FBoolProperty);
		FPCGSplineSamplerParams_IsValid = intPtr != IntPtr.Zero && Dimension_IsValid && Mode_IsValid && Fill_IsValid && SubdivisionsPerSegment_IsValid && DistanceIncrement_IsValid && NumPlanarSubdivisions_IsValid && NumHeightSubdivisions_IsValid && ComputeDirectionDelta_IsValid && NextDirectionDeltaAttribute_IsValid && ComputeCurvature_IsValid && CurvatureAttribute_IsValid && Unbounded_IsValid && InteriorSampleSpacing_IsValid && InteriorBorderSampleSpacing_IsValid && TreatSplineAsPolyline_IsValid && InteriorOrientation_IsValid && PointSteepness_IsValid && SeedFromLocalPosition_IsValid && SeedFrom2DPosition_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGSplineSamplerParams", FPCGSplineSamplerParams_IsValid);
	}
}
