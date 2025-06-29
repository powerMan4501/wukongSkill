using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AnimGraph.AnimGraphNode_TransitionPoseEvaluator", "AnimGraph", UnrealModuleType.Engine)]
public class UAnimGraphNode_TransitionPoseEvaluator : UAnimGraphNode_Base
{
	private static bool Node_IsValid;

	private static int Node_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_TransitionPoseEvaluator:Node")]
	public FAnimNode_TransitionPoseEvaluator Node
	{
		get
		{
			CheckDestroyed();
			if (!Node_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimGraph.AnimGraphNode_TransitionPoseEvaluator:Node");
				return default(FAnimNode_TransitionPoseEvaluator);
			}
			return FAnimNode_TransitionPoseEvaluator.FromNative(IntPtr.Add(base.Address, Node_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Node_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimGraph.AnimGraphNode_TransitionPoseEvaluator:Node");
			}
			else
			{
				FAnimNode_TransitionPoseEvaluator.ToNative(IntPtr.Add(base.Address, Node_Offset), value);
			}
		}
	}

	static UAnimGraphNode_TransitionPoseEvaluator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimGraphNode_TransitionPoseEvaluator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimGraphNode_TransitionPoseEvaluator));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AnimGraph.AnimGraphNode_TransitionPoseEvaluator");
		Node_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Node");
		Node_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Node", Classes.FStructProperty);
	}
}
