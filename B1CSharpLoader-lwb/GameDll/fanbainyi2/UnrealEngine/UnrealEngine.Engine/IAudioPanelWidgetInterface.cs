using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[Blueprintable]
[UMetaPath("/Script/Engine.AudioPanelWidgetInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IAudioPanelWidgetInterfaceImpl))]
public interface IAudioPanelWidgetInterface : IInterface
{
	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.AudioPanelWidgetInterface:GetIconBrushName")]
	FName GetIconBrushName();

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.AudioPanelWidgetInterface:GetEditorName")]
	string GetEditorName();
}
