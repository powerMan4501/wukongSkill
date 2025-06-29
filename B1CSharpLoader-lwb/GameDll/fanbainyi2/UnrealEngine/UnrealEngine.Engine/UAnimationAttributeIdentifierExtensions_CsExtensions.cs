using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UAnimationAttributeIdentifierExtensions_CsExtensions
{
	public static bool IsValid(this ref FAnimationAttributeIdentifier Identifier)
	{
		return UAnimationAttributeIdentifierExtensions.IsValid(ref Identifier);
	}

	public static FAnimationAttributeIdentifier CreateAttributeIdentifier(this UAnimationAsset AnimationAsset, FName AttributeName, FName BoneName, UScriptStruct AttributeType, bool bValidateExistsOnAsset = false)
	{
		return UAnimationAttributeIdentifierExtensions.CreateAttributeIdentifier(AnimationAsset, AttributeName, BoneName, AttributeType, bValidateExistsOnAsset);
	}
}
