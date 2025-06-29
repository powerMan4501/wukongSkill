using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.MMForLMAnimGraph", "MM", UnrealModuleType.GamePlugin)]
public struct FMMForLMAnimGraph
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
	[UMetaPath("/Script/MM.MMForLMAnimGraph:DefaultMotionJointData")]
	public FDefaultMotionJointData DefaultMotionJointData;

	private static bool DefaultVelocity_IsValid;

	private static int DefaultVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:DefaultVelocity")]
	public FVector DefaultVelocity;

	private static bool AnimationAnalyzer_IsValid;

	private static int AnimationAnalyzer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:AnimationAnalyzer")]
	public UAnimationAnalyzer AnimationAnalyzer;

	private static bool AnimationPose_IsValid;

	private static int AnimationPose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:AnimationPose")]
	public FPoseLink AnimationPose;

	private static bool InputDesiredTransform_IsValid;

	private static int InputDesiredTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:InputDesiredTransform")]
	public FTransform InputDesiredTransform;

	private static bool InputRootTransform_IsValid;

	private static int InputRootTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:InputRootTransform")]
	public FTransform InputRootTransform;

	private static bool InputStrength_IsValid;

	private static int InputStrength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:InputStrength")]
	public float InputStrength;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:PlayRate")]
	public float PlayRate;

	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:BlendTime")]
	public float BlendTime;

	private static bool TimeBetweenBlends_IsValid;

	private static int TimeBetweenBlends_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:TimeBetweenBlends")]
	public float TimeBetweenBlends;

	private static bool RecordAnimData_IsValid;

	private static FFieldAddress RecordAnimData_PropertyAddress;

	private static int RecordAnimData_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:bRecordAnimData")]
	public bool RecordAnimData;

	private static bool KeepInputUnchanged_IsValid;

	private static FFieldAddress KeepInputUnchanged_PropertyAddress;

	private static int KeepInputUnchanged_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.MMForLMAnimGraph:bKeepInputUnchanged")]
	public bool KeepInputUnchanged;

	private static bool FMMForLMAnimGraph_IsValid;

	private static int FMMForLMAnimGraph_StructSize;

	public FMMForLMAnimGraph Copy()
	{
		return this;
	}

	public static FMMForLMAnimGraph FromNative(IntPtr nativeBuffer)
	{
		return new FMMForLMAnimGraph(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMMForLMAnimGraph value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMMForLMAnimGraph FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMMForLMAnimGraph(nativeBuffer + arrayIndex * FMMForLMAnimGraph_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMMForLMAnimGraph value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMMForLMAnimGraph_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMMForLMAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MMForLMAnimGraph");
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
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, KeepInputUnchanged_Offset), 0, KeepInputUnchanged_PropertyAddress.Address, KeepInputUnchanged);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FMMForLMAnimGraph(IntPtr nativeStruct)
	{
		if (!FMMForLMAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.MMForLMAnimGraph");
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
			KeepInputUnchanged = false;
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
			KeepInputUnchanged = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, KeepInputUnchanged_Offset), 0, KeepInputUnchanged_PropertyAddress.Address);
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FMMForLMAnimGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMMForLMAnimGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMMForLMAnimGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.MMForLMAnimGraph");
		FMMForLMAnimGraph_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref KeepInputUnchanged_PropertyAddress, intPtr, "bKeepInputUnchanged");
		KeepInputUnchanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bKeepInputUnchanged");
		KeepInputUnchanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bKeepInputUnchanged", Classes.FBoolProperty);
		FMMForLMAnimGraph_IsValid = intPtr != IntPtr.Zero && DefaultMotionJointData_IsValid && DefaultVelocity_IsValid && AnimationAnalyzer_IsValid && AnimationPose_IsValid && InputDesiredTransform_IsValid && InputRootTransform_IsValid && InputStrength_IsValid && PlayRate_IsValid && BlendTime_IsValid && TimeBetweenBlends_IsValid && RecordAnimData_IsValid && KeepInputUnchanged_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.MMForLMAnimGraph", FMMForLMAnimGraph_IsValid);
	}
}
