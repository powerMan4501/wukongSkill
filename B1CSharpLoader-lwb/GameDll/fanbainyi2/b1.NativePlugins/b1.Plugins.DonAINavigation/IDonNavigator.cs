using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DonAINavigation.DonNavigator", "DonAINavigation", UnrealModuleType.GamePlugin, InterfaceImpl = typeof(IDonNavigatorImpl))]
public interface IDonNavigator : IInterface
{
	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnNextSegment")]
	void OnNextSegment(FVector NextPoint);

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnLocomotionEnd")]
	void OnLocomotionEnd(bool bLocomotionSuccess);

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnLocomotionBegin")]
	void OnLocomotionBegin();

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnLocomotionAbort")]
	void OnLocomotionAbort();

	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:AddMovementInputCustom")]
	void AddMovementInputCustom(FVector WorldDirection, float ScaleValue);
}
