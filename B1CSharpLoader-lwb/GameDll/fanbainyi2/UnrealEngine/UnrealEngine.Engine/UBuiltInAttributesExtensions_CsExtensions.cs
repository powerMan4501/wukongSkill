using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UBuiltInAttributesExtensions_CsExtensions
{
	public static bool AddTransformAttribute(this UAnimSequenceBase AnimSequenceBase, FName AttributeName, FName BoneName, List<float> Keys, List<FTransform> Values)
	{
		return UBuiltInAttributesExtensions.AddTransformAttribute(AnimSequenceBase, AttributeName, BoneName, Keys, Values);
	}
}
