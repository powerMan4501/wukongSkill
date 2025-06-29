using System.Collections.Generic;
using UnrealEngine.AnimGraph;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

public static class UAnimationLibrary_CsExtensions
{
	public static void GetNodesOfClass(this UAnimBlueprint AnimationBlueprint, TSubclassOf<UAnimGraphNode_Base> NodeClass, out List<UAnimGraphNode_Base> GraphNodes, bool bIncludeChildClasses = true)
	{
		UAnimationLibrary.GetNodesOfClass(AnimationBlueprint, NodeClass, out GraphNodes, bIncludeChildClasses);
	}

	public static void GetAnimationGraphs(this UAnimBlueprint AnimationBlueprint, out List<UAnimationGraph> AnimationGraphs)
	{
		UAnimationLibrary.GetAnimationGraphs(AnimationBlueprint, out AnimationGraphs);
	}
}
