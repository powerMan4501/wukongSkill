using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[Abstract]
[UInterface(Flags = 809517217u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.RTXSettings", "CustomLightSystem", UnrealModuleType.GamePlugin, InterfaceImpl = typeof(IRTXSettingsImpl))]
public interface IRTXSettings : IInterface
{
	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:SetRTXQuality")]
	void SetRTXQuality(byte Quality);

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:SetRTXEnabled")]
	void SetRTXEnabled(bool bInEnable);

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:SetDlssRREnable")]
	void SetDlssRREnable(bool bEnable);

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:IsRTXEnabled")]
	bool IsRTXEnabled();

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:IsDLSSRREnabled")]
	bool IsDLSSRREnabled();

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:GetRTXQuality")]
	byte GetRTXQuality();
}
