using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_TransitionPoseEvaluator", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_TransitionPoseEvaluator
{
	private static bool FramesToCachePose_IsValid;

	private static int FramesToCachePose_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_TransitionPoseEvaluator:FramesToCachePose")]
	public int FramesToCachePose;

	private static bool DataSource_IsValid;

	private static FFieldAddress DataSource_PropertyAddress;

	private static int DataSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_TransitionPoseEvaluator:DataSource")]
	public EEvaluatorDataSource DataSource;

	private static bool EvaluatorMode_IsValid;

	private static FFieldAddress EvaluatorMode_PropertyAddress;

	private static int EvaluatorMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_TransitionPoseEvaluator:EvaluatorMode")]
	public EEvaluatorMode EvaluatorMode;

	private static bool FAnimNode_TransitionPoseEvaluator_IsValid;

	private static int FAnimNode_TransitionPoseEvaluator_StructSize;

	public FAnimNode_TransitionPoseEvaluator Copy()
	{
		return this;
	}

	public static FAnimNode_TransitionPoseEvaluator FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_TransitionPoseEvaluator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_TransitionPoseEvaluator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_TransitionPoseEvaluator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_TransitionPoseEvaluator(nativeBuffer + arrayIndex * FAnimNode_TransitionPoseEvaluator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_TransitionPoseEvaluator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_TransitionPoseEvaluator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_TransitionPoseEvaluator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_TransitionPoseEvaluator");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FramesToCachePose_Offset), FramesToCachePose);
		EnumMarshaler<EEvaluatorDataSource>.ToNative(IntPtr.Add(nativeStruct, DataSource_Offset), 0, DataSource_PropertyAddress.Address, DataSource);
		EnumMarshaler<EEvaluatorMode>.ToNative(IntPtr.Add(nativeStruct, EvaluatorMode_Offset), 0, EvaluatorMode_PropertyAddress.Address, EvaluatorMode);
	}

	public FAnimNode_TransitionPoseEvaluator(IntPtr nativeStruct)
	{
		if (!FAnimNode_TransitionPoseEvaluator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_TransitionPoseEvaluator");
			FramesToCachePose = 0;
			DataSource = EEvaluatorDataSource.EDS_SourcePose;
			EvaluatorMode = EEvaluatorMode.EM_Standard;
		}
		else
		{
			FramesToCachePose = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FramesToCachePose_Offset));
			DataSource = EnumMarshaler<EEvaluatorDataSource>.FromNative(IntPtr.Add(nativeStruct, DataSource_Offset), 0, DataSource_PropertyAddress.Address);
			EvaluatorMode = EnumMarshaler<EEvaluatorMode>.FromNative(IntPtr.Add(nativeStruct, EvaluatorMode_Offset), 0, EvaluatorMode_PropertyAddress.Address);
		}
	}

	static FAnimNode_TransitionPoseEvaluator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_TransitionPoseEvaluator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_TransitionPoseEvaluator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_TransitionPoseEvaluator");
		FAnimNode_TransitionPoseEvaluator_StructSize = NativeReflection.GetStructSize(intPtr);
		FramesToCachePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FramesToCachePose");
		FramesToCachePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FramesToCachePose", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DataSource_PropertyAddress, intPtr, "DataSource");
		DataSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataSource");
		DataSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataSource", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluatorMode_PropertyAddress, intPtr, "EvaluatorMode");
		EvaluatorMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EvaluatorMode");
		EvaluatorMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EvaluatorMode", Classes.FByteProperty);
		FAnimNode_TransitionPoseEvaluator_IsValid = intPtr != IntPtr.Zero && FramesToCachePose_IsValid && DataSource_IsValid && EvaluatorMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_TransitionPoseEvaluator", FAnimNode_TransitionPoseEvaluator_IsValid);
	}
}
