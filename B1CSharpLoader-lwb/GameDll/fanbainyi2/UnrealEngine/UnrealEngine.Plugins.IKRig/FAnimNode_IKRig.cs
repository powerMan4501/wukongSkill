using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/IKRig.AnimNode_IKRig", "IKRig", UnrealModuleType.EnginePlugin)]
public struct FAnimNode_IKRig
{
	private static bool Goals_IsValid;

	private static FFieldAddress Goals_PropertyAddress;

	private static int Goals_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:Goals")]
	public List<FIKRigGoal> Goals;

	private static bool AlphaInputType_IsValid;

	private static FFieldAddress AlphaInputType_PropertyAddress;

	private static int AlphaInputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:AlphaInputType")]
	public EAnimAlphaInputType AlphaInputType;

	private static bool AlphaBoolEnabled_IsValid;

	private static FFieldAddress AlphaBoolEnabled_PropertyAddress;

	private static int AlphaBoolEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:bAlphaBoolEnabled")]
	public bool AlphaBoolEnabled;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:Alpha")]
	public float Alpha;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool AlphaBoolBlend_IsValid;

	private static int AlphaBoolBlend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:AlphaBoolBlend")]
	public FInputAlphaBoolBlend AlphaBoolBlend;

	private static bool AlphaCurveName_IsValid;

	private static int AlphaCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:AlphaCurveName")]
	public FName AlphaCurveName;

	private static bool AlphaScaleBiasClamp_IsValid;

	private static int AlphaScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/IKRig.AnimNode_IKRig:AlphaScaleBiasClamp")]
	public FInputScaleBiasClamp AlphaScaleBiasClamp;

	private static bool FAnimNode_IKRig_IsValid;

	private static int FAnimNode_IKRig_StructSize;

	public FAnimNode_IKRig Copy()
	{
		FAnimNode_IKRig result = this;
		if (Goals != null)
		{
			result.Goals = new List<FIKRigGoal>(Goals);
		}
		return result;
	}

	public static FAnimNode_IKRig FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_IKRig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_IKRig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_IKRig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_IKRig(nativeBuffer + arrayIndex * FAnimNode_IKRig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_IKRig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_IKRig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_IKRig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.AnimNode_IKRig");
			return;
		}
		new TArrayCopyMarshaler<FIKRigGoal>(1, Goals_PropertyAddress, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.FromNative, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.ToNative).ToNative(IntPtr.Add(nativeStruct, Goals_Offset), Goals);
		EnumMarshaler<EAnimAlphaInputType>.ToNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address, AlphaInputType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address, AlphaBoolEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		FInputAlphaBoolBlend.ToNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset), AlphaBoolBlend);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset), AlphaCurveName);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset), AlphaScaleBiasClamp);
	}

	public FAnimNode_IKRig(IntPtr nativeStruct)
	{
		if (!FAnimNode_IKRig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/IKRig.AnimNode_IKRig");
			Goals = null;
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
			Goals = new TArrayCopyMarshaler<FIKRigGoal>(1, Goals_PropertyAddress, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.FromNative, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.ToNative).FromNative(IntPtr.Add(nativeStruct, Goals_Offset));
			AlphaInputType = EnumMarshaler<EAnimAlphaInputType>.FromNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address);
			AlphaBoolEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address);
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			AlphaBoolBlend = FInputAlphaBoolBlend.FromNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset));
			AlphaCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset));
			AlphaScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset));
		}
	}

	static FAnimNode_IKRig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_IKRig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_IKRig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/IKRig.AnimNode_IKRig");
		FAnimNode_IKRig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Goals_PropertyAddress, intPtr, "Goals");
		Goals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Goals");
		Goals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Goals", Classes.FArrayProperty);
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
		FAnimNode_IKRig_IsValid = intPtr != IntPtr.Zero && Goals_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/IKRig.AnimNode_IKRig", FAnimNode_IKRig_IsValid);
	}
}
