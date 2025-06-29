using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ECastToControlRigBlueprintCases", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public enum ECastToControlRigBlueprintCases : byte
{
	CastSucceeded,
	CastFailed
}
