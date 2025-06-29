using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MotionMatchingAnimGraph", "MM", UnrealModuleType.GamePlugin)]
public struct FMotionMatchingAnimGraph
{
	private static bool BlendWeight_IsValid;

	private static int BlendWeight_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase:BlendWeight")]
	public float BlendWeight;

	private static bool InternalTimeAccumulator_IsValid;

	private static int InternalTimeAccumulator_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase:InternalTimeAccumulator")]
	public float InternalTimeAccumulator;

	private static bool DefaultMotionJointData_IsValid;

	private static int DefaultMotionJointData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:DefaultMotionJointData")]
	public FDefaultMotionJointData DefaultMotionJointData;

	private static bool DefaultVelocity_IsValid;

	private static int DefaultVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:DefaultVelocity")]
	public FVector DefaultVelocity;

	private static bool AnimationAnalyzer_IsValid;

	private static int AnimationAnalyzer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:AnimationAnalyzer")]
	public UAnimationAnalyzer AnimationAnalyzer;

	private static bool AnimationPose_IsValid;

	private static int AnimationPose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:AnimationPose")]
	public FPoseLink AnimationPose;

	private static bool InputDesiredTransform_IsValid;

	private static int InputDesiredTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:InputDesiredTransform")]
	public FTransform InputDesiredTransform;

	private static bool InputRootTransform_IsValid;

	private static int InputRootTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:InputRootTransform")]
	public FTransform InputRootTransform;

	private static bool InputStrength_IsValid;

	private static int InputStrength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:InputStrength")]
	public float InputStrength;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:PlayRate")]
	public float PlayRate;

	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:BlendTime")]
	public float BlendTime;

	private static bool TimeBetweenBlends_IsValid;

	private static int TimeBetweenBlends_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:TimeBetweenBlends")]
	public float TimeBetweenBlends;

	private static bool RecordAnimData_IsValid;

	private static FFieldAddress RecordAnimData_PropertyAddress;

	private static int RecordAnimData_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:bRecordAnimData")]
	public bool RecordAnimData;

	private static bool DisableMMRootMotion_IsValid;

	private static FFieldAddress DisableMMRootMotion_PropertyAddress;

	private static int DisableMMRootMotion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MotionMatchingAnimGraph:bDisableMMRootMotion")]
	public bool DisableMMRootMotion;

	private static bool FMotionMatchingAnimGraph_IsValid;

	private static int FMotionMatchingAnimGraph_StructSize;

	public FMotionMatchingAnimGraph Copy()
	{
		return this;
	}

	public static FMotionMatchingAnimGraph FromNative(IntPtr nativeBuffer)
	{
		return new FMotionMatchingAnimGraph(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMotionMatchingAnimGraph value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMotionMatchingAnimGraph FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMotionMatchingAnimGraph(nativeBuffer + arrayIndex * FMotionMatchingAnimGraph_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMotionMatchingAnimGraph value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMotionMatchingAnimGraph_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMotionMatchingAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingAnimGraph");
			return;
		}
		FDefaultMotionJointData.ToNative(IntPtr.Add(nativeStruct, DefaultMotionJointData_Offset), DefaultMotionJointData);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, DefaultVelocity_Offset), DefaultVelocity);
		UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(nativeStruct, AnimationAnalyzer_Offset), AnimationAnalyzer);
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, AnimationPose_Offset), AnimationPose);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, InputDesiredTransform_Offset), InputDesiredTransform);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, InputRootTransform_Offset), InputRootTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InputStrength_Offset), InputStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayRate_Offset), PlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendTime_Offset), BlendTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TimeBetweenBlends_Offset), TimeBetweenBlends);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecordAnimData_Offset), 0, RecordAnimData_PropertyAddress.Address, RecordAnimData);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableMMRootMotion_Offset), 0, DisableMMRootMotion_PropertyAddress.Address, DisableMMRootMotion);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FMotionMatchingAnimGraph(IntPtr nativeStruct)
	{
		if (!FMotionMatchingAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MotionMatchingAnimGraph");
			DefaultMotionJointData = default(FDefaultMotionJointData);
			DefaultVelocity = default(FVector);
			AnimationAnalyzer = null;
			AnimationPose = default(FPoseLink);
			InputDesiredTransform = default(FTransform);
			InputRootTransform = default(FTransform);
			InputStrength = 0f;
			PlayRate = 0f;
			BlendTime = 0f;
			TimeBetweenBlends = 0f;
			RecordAnimData = false;
			DisableMMRootMotion = false;
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			DefaultMotionJointData = FDefaultMotionJointData.FromNative(IntPtr.Add(nativeStruct, DefaultMotionJointData_Offset));
			DefaultVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, DefaultVelocity_Offset));
			AnimationAnalyzer = UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(nativeStruct, AnimationAnalyzer_Offset));
			AnimationPose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, AnimationPose_Offset));
			InputDesiredTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, InputDesiredTransform_Offset));
			InputRootTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, InputRootTransform_Offset));
			InputStrength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InputStrength_Offset));
			PlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayRate_Offset));
			BlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendTime_Offset));
			TimeBetweenBlends = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TimeBetweenBlends_Offset));
			RecordAnimData = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecordAnimData_Offset), 0, RecordAnimData_PropertyAddress.Address);
			DisableMMRootMotion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableMMRootMotion_Offset), 0, DisableMMRootMotion_PropertyAddress.Address);
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FMotionMatchingAnimGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionMatchingAnimGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionMatchingAnimGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MotionMatchingAnimGraph");
		FMotionMatchingAnimGraph_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		DefaultMotionJointData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultMotionJointData");
		DefaultMotionJointData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultMotionJointData", Classes.FStructProperty);
		DefaultVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultVelocity");
		DefaultVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultVelocity", Classes.FStructProperty);
		AnimationAnalyzer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationAnalyzer");
		AnimationAnalyzer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationAnalyzer", Classes.FObjectProperty);
		AnimationPose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationPose");
		AnimationPose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationPose", Classes.FStructProperty);
		InputDesiredTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputDesiredTransform");
		InputDesiredTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputDesiredTransform", Classes.FStructProperty);
		InputRootTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputRootTransform");
		InputRootTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputRootTransform", Classes.FStructProperty);
		InputStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputStrength");
		InputStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputStrength", Classes.FFloatProperty);
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendTime");
		BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendTime", Classes.FFloatProperty);
		TimeBetweenBlends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeBetweenBlends");
		TimeBetweenBlends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeBetweenBlends", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordAnimData_PropertyAddress, intPtr, "bRecordAnimData");
		RecordAnimData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecordAnimData");
		RecordAnimData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecordAnimData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableMMRootMotion_PropertyAddress, intPtr, "bDisableMMRootMotion");
		DisableMMRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableMMRootMotion");
		DisableMMRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableMMRootMotion", Classes.FBoolProperty);
		FMotionMatchingAnimGraph_IsValid = intPtr != IntPtr.Zero && DefaultMotionJointData_IsValid && DefaultVelocity_IsValid && AnimationAnalyzer_IsValid && AnimationPose_IsValid && InputDesiredTransform_IsValid && InputRootTransform_IsValid && InputStrength_IsValid && PlayRate_IsValid && BlendTime_IsValid && TimeBetweenBlends_IsValid && RecordAnimData_IsValid && DisableMMRootMotion_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MotionMatchingAnimGraph", FMotionMatchingAnimGraph_IsValid);
	}
}
