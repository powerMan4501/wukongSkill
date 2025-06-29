using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UInterface(Flags = 809517217u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BUAnimLocomotionEx", "b1", UnrealModuleType.Game, InterfaceImpl = typeof(IBUAnimLocomotionExImpl))]
public interface IBUAnimLocomotionEx : IInterface
{
	[UFunction(Flags = 205655040u)]
	[UMetaPath("/Script/b1.BUAnimLocomotionEx:SetLocoExSettings")]
	void SetLocoExSettings(FBUAnimSettingsLocomotionEx Settings);

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/b1.BUAnimLocomotionEx:SetLocoExEnable")]
	void SetLocoExEnable(bool bEnable);
}
