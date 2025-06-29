using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_ModifyCurve
{
	private static bool SourcePose_IsValid;

	private static int SourcePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847301uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve:SourcePose")]
	public FPoseLink SourcePose;

	private static bool CurveMap_IsValid;

	private static FFieldAddress CurveMap_PropertyAddress;

	private static int CurveMap_Offset;

	[UProperty(Flags = (PropFlags)4503599627370565uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve:CurveMap")]
	public Dictionary<FName, float> CurveMap;

	private static bool CurveValues_IsValid;

	private static FFieldAddress CurveValues_PropertyAddress;

	private static int CurveValues_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve:CurveValues")]
	public List<float> CurveValues;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve:Alpha")]
	public float Alpha;

	private static bool ApplyMode_IsValid;

	private static FFieldAddress ApplyMode_PropertyAddress;

	private static int ApplyMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve:ApplyMode")]
	public EModifyCurveApplyMode ApplyMode;

	private static bool FAnimNode_ModifyCurve_IsValid;

	private static int FAnimNode_ModifyCurve_StructSize;

	public FAnimNode_ModifyCurve Copy()
	{
		FAnimNode_ModifyCurve result = this;
		if (CurveMap != null)
		{
			result.CurveMap = new Dictionary<FName, float>(CurveMap);
		}
		if (CurveValues != null)
		{
			result.CurveValues = new List<float>(CurveValues);
		}
		return result;
	}

	public static FAnimNode_ModifyCurve FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_ModifyCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_ModifyCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_ModifyCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_ModifyCurve(nativeBuffer + arrayIndex * FAnimNode_ModifyCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_ModifyCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_ModifyCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_ModifyCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_ModifyCurve");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, SourcePose_Offset), SourcePose);
		new TMapCopyMarshaler<FName, float>(1, CurveMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CurveMap_Offset), CurveMap);
		new TArrayCopyMarshaler<float>(1, CurveValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CurveValues_Offset), CurveValues);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		EnumMarshaler<EModifyCurveApplyMode>.ToNative(IntPtr.Add(nativeStruct, ApplyMode_Offset), 0, ApplyMode_PropertyAddress.Address, ApplyMode);
	}

	public FAnimNode_ModifyCurve(IntPtr nativeStruct)
	{
		if (!FAnimNode_ModifyCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_ModifyCurve");
			SourcePose = default(FPoseLink);
			CurveMap = null;
			CurveValues = null;
			Alpha = 0f;
			ApplyMode = EModifyCurveApplyMode.Add;
		}
		else
		{
			SourcePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, SourcePose_Offset));
			CurveMap = new TMapCopyMarshaler<FName, float>(1, CurveMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CurveMap_Offset));
			CurveValues = new TArrayCopyMarshaler<float>(1, CurveValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CurveValues_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			ApplyMode = EnumMarshaler<EModifyCurveApplyMode>.FromNative(IntPtr.Add(nativeStruct, ApplyMode_Offset), 0, ApplyMode_PropertyAddress.Address);
		}
	}

	static FAnimNode_ModifyCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_ModifyCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_ModifyCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_ModifyCurve");
		FAnimNode_ModifyCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		SourcePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourcePose");
		SourcePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourcePose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveMap_PropertyAddress, intPtr, "CurveMap");
		CurveMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveMap");
		CurveMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveValues_PropertyAddress, intPtr, "CurveValues");
		CurveValues_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveValues");
		CurveValues_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveValues", Classes.FArrayProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMode_PropertyAddress, intPtr, "ApplyMode");
		ApplyMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ApplyMode");
		ApplyMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ApplyMode", Classes.FEnumProperty);
		FAnimNode_ModifyCurve_IsValid = intPtr != IntPtr.Zero && SourcePose_IsValid && CurveMap_IsValid && CurveValues_IsValid && Alpha_IsValid && ApplyMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_ModifyCurve", FAnimNode_ModifyCurve_IsValid);
	}
}
