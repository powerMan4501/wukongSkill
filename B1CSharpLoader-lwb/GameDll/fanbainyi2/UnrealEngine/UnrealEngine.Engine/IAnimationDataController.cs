using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AnimationDataController", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IAnimationDataControllerImpl))]
public interface IAnimationDataController : IInterface
{
	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:UpdateCurveNamesFromSkeleton")]
	void UpdateCurveNamesFromSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetTransformCurveKeys")]
	bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId, List<FTransform> TransformValues, List<float> TimeKeys, bool bShouldTransact = true);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetTransformCurveKey")]
	bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, FTransform Value, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetPlayLength")]
	void SetPlayLength(float Length, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetModel")]
	void SetModel(UAnimDataModel InModel);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetFrameRate")]
	void SetFrameRate(FFrameRate FrameRate, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveKeys")]
	bool SetCurveKeys(FAnimationCurveIdentifier CurveId, List<FRichCurveKey> CurveKeys, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveKey")]
	bool SetCurveKey(FAnimationCurveIdentifier CurveId, FRichCurveKey Key, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveFlags")]
	bool SetCurveFlags(FAnimationCurveIdentifier CurveId, int Flags, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveFlag")]
	bool SetCurveFlag(FAnimationCurveIdentifier CurveId, EAnimAssetCurveFlags Flag, bool bState = true, bool bShouldTransact = true);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveColor")]
	bool SetCurveColor(FAnimationCurveIdentifier CurveId, FLinearColor Color, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetBoneTrackKeys")]
	bool SetBoneTrackKeys(FName BoneName, List<FVector> PositionalKeys, List<FQuat> RotationalKeys, List<FVector> ScalingKeys, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:ScaleCurve")]
	bool ScaleCurve(FAnimationCurveIdentifier CurveId, float Origin, float Factor, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:ResizePlayLength")]
	void ResizePlayLength(float NewLength, float T0, float T1, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:Resize")]
	void Resize(float Length, float T0, float T1, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RenameCurve")]
	bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveTransformCurveKey")]
	bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveCurveKey")]
	bool RemoveCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveCurve")]
	bool RemoveCurve(FAnimationCurveIdentifier CurveId, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveBoneTrack")]
	bool RemoveBoneTrack(FName BoneName, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAttributeKey")]
	bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier, float Time, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAttribute")]
	bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllCurvesOfType")]
	void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllBoneTracks")]
	void RemoveAllBoneTracks(bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllAttributesForBone")]
	int RemoveAllAttributesForBone(FName BoneName, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllAttributes")]
	int RemoveAllAttributes(bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:OpenBracket")]
	void OpenBracket(FText InTitle, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:InsertBoneTrack")]
	int InsertBoneTrack(FName BoneName, int DesiredIndex, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:GetModel")]
	UAnimDataModel GetModel();

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:FindOrAddCurveNamesOnSkeleton")]
	void FindOrAddCurveNamesOnSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:DuplicateCurve")]
	bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:DuplicateAttribute")]
	bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier, FAnimationAttributeIdentifier NewAttributeIdentifier, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:CloseBracket")]
	void CloseBracket(bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:AddCurve")]
	bool AddCurve(FAnimationCurveIdentifier CurveId, int CurveFlags = 4, bool bShouldTransact = true);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:AddBoneTrack")]
	int AddBoneTrack(FName BoneName, bool bShouldTransact = true);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:AddAttribute")]
	bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true);
}
