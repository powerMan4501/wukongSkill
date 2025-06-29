using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.RBFParams", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FRBFParams
{
	private static bool SolverType_IsValid;

	private static FFieldAddress SolverType_PropertyAddress;

	private static int SolverType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:SolverType")]
	public ERBFSolverType SolverType;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:Radius")]
	public float Radius;

	private static bool AutomaticRadius_IsValid;

	private static FFieldAddress AutomaticRadius_PropertyAddress;

	private static int AutomaticRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:bAutomaticRadius")]
	public bool AutomaticRadius;

	private static bool Function_IsValid;

	private static FFieldAddress Function_PropertyAddress;

	private static int Function_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:Function")]
	public ERBFFunctionType Function;

	private static bool DistanceMethod_IsValid;

	private static FFieldAddress DistanceMethod_PropertyAddress;

	private static int DistanceMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:DistanceMethod")]
	public ERBFDistanceMethod DistanceMethod;

	private static bool TwistAxis_IsValid;

	private static FFieldAddress TwistAxis_PropertyAddress;

	private static int TwistAxis_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:TwistAxis")]
	public EBoneAxis TwistAxis;

	private static bool WeightThreshold_IsValid;

	private static int WeightThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:WeightThreshold")]
	public float WeightThreshold;

	private static bool NormalizeMethod_IsValid;

	private static FFieldAddress NormalizeMethod_PropertyAddress;

	private static int NormalizeMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:NormalizeMethod")]
	public ERBFNormalizeMethod NormalizeMethod;

	private static bool MedianReference_IsValid;

	private static int MedianReference_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:MedianReference")]
	public FVector MedianReference;

	private static bool MedianMin_IsValid;

	private static int MedianMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:MedianMin")]
	public float MedianMin;

	private static bool MedianMax_IsValid;

	private static int MedianMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.RBFParams:MedianMax")]
	public float MedianMax;

	private static bool FRBFParams_IsValid;

	private static int FRBFParams_StructSize;

	public FRBFParams Copy()
	{
		return this;
	}

	public static FRBFParams FromNative(IntPtr nativeBuffer)
	{
		return new FRBFParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRBFParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRBFParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRBFParams(nativeBuffer + arrayIndex * FRBFParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRBFParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRBFParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRBFParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.RBFParams");
			return;
		}
		EnumMarshaler<ERBFSolverType>.ToNative(IntPtr.Add(nativeStruct, SolverType_Offset), 0, SolverType_PropertyAddress.Address, SolverType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutomaticRadius_Offset), 0, AutomaticRadius_PropertyAddress.Address, AutomaticRadius);
		EnumMarshaler<ERBFFunctionType>.ToNative(IntPtr.Add(nativeStruct, Function_Offset), 0, Function_PropertyAddress.Address, Function);
		EnumMarshaler<ERBFDistanceMethod>.ToNative(IntPtr.Add(nativeStruct, DistanceMethod_Offset), 0, DistanceMethod_PropertyAddress.Address, DistanceMethod);
		EnumMarshaler<EBoneAxis>.ToNative(IntPtr.Add(nativeStruct, TwistAxis_Offset), 0, TwistAxis_PropertyAddress.Address, TwistAxis);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WeightThreshold_Offset), WeightThreshold);
		EnumMarshaler<ERBFNormalizeMethod>.ToNative(IntPtr.Add(nativeStruct, NormalizeMethod_Offset), 0, NormalizeMethod_PropertyAddress.Address, NormalizeMethod);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, MedianReference_Offset), MedianReference);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MedianMin_Offset), MedianMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MedianMax_Offset), MedianMax);
	}

	public FRBFParams(IntPtr nativeStruct)
	{
		if (!FRBFParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.RBFParams");
			SolverType = ERBFSolverType.Additive;
			Radius = 0f;
			AutomaticRadius = false;
			Function = ERBFFunctionType.Gaussian;
			DistanceMethod = ERBFDistanceMethod.Euclidean;
			TwistAxis = EBoneAxis.BA_X;
			WeightThreshold = 0f;
			NormalizeMethod = ERBFNormalizeMethod.OnlyNormalizeAboveOne;
			MedianReference = default(FVector);
			MedianMin = 0f;
			MedianMax = 0f;
		}
		else
		{
			SolverType = EnumMarshaler<ERBFSolverType>.FromNative(IntPtr.Add(nativeStruct, SolverType_Offset), 0, SolverType_PropertyAddress.Address);
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			AutomaticRadius = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutomaticRadius_Offset), 0, AutomaticRadius_PropertyAddress.Address);
			Function = EnumMarshaler<ERBFFunctionType>.FromNative(IntPtr.Add(nativeStruct, Function_Offset), 0, Function_PropertyAddress.Address);
			DistanceMethod = EnumMarshaler<ERBFDistanceMethod>.FromNative(IntPtr.Add(nativeStruct, DistanceMethod_Offset), 0, DistanceMethod_PropertyAddress.Address);
			TwistAxis = EnumMarshaler<EBoneAxis>.FromNative(IntPtr.Add(nativeStruct, TwistAxis_Offset), 0, TwistAxis_PropertyAddress.Address);
			WeightThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WeightThreshold_Offset));
			NormalizeMethod = EnumMarshaler<ERBFNormalizeMethod>.FromNative(IntPtr.Add(nativeStruct, NormalizeMethod_Offset), 0, NormalizeMethod_PropertyAddress.Address);
			MedianReference = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, MedianReference_Offset));
			MedianMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MedianMin_Offset));
			MedianMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MedianMax_Offset));
		}
	}

	static FRBFParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRBFParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRBFParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.RBFParams");
		FRBFParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SolverType_PropertyAddress, intPtr, "SolverType");
		SolverType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SolverType");
		SolverType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SolverType", Classes.FEnumProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AutomaticRadius_PropertyAddress, intPtr, "bAutomaticRadius");
		AutomaticRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutomaticRadius");
		AutomaticRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutomaticRadius", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Function_PropertyAddress, intPtr, "Function");
		Function_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Function");
		Function_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Function", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceMethod_PropertyAddress, intPtr, "DistanceMethod");
		DistanceMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceMethod");
		DistanceMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TwistAxis_PropertyAddress, intPtr, "TwistAxis");
		TwistAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TwistAxis");
		TwistAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TwistAxis", Classes.FByteProperty);
		WeightThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightThreshold");
		WeightThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalizeMethod_PropertyAddress, intPtr, "NormalizeMethod");
		NormalizeMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalizeMethod");
		NormalizeMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalizeMethod", Classes.FEnumProperty);
		MedianReference_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MedianReference");
		MedianReference_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MedianReference", Classes.FStructProperty);
		MedianMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MedianMin");
		MedianMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MedianMin", Classes.FFloatProperty);
		MedianMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MedianMax");
		MedianMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MedianMax", Classes.FFloatProperty);
		FRBFParams_IsValid = intPtr != IntPtr.Zero && SolverType_IsValid && Radius_IsValid && AutomaticRadius_IsValid && Function_IsValid && DistanceMethod_IsValid && TwistAxis_IsValid && WeightThreshold_IsValid && NormalizeMethod_IsValid && MedianReference_IsValid && MedianMin_IsValid && MedianMax_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.RBFParams", FRBFParams_IsValid);
	}
}
