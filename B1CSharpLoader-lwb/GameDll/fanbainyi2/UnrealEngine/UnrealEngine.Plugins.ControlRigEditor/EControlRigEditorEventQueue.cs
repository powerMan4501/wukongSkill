using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UEnum]
[UMetaPath("/Script/ControlRigEditor.EControlRigEditorEventQueue", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public enum EControlRigEditorEventQueue
{
	Setup,
	Update,
	Inverse,
	InverseAndUpdate,
	Max
}
