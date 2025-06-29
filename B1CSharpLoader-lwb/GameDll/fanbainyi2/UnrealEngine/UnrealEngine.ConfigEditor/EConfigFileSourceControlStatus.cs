using UnrealEngine.Runtime;

namespace UnrealEngine.ConfigEditor;

[UEnum]
[UMetaPath("/Script/ConfigEditor.EConfigFileSourceControlStatus", "ConfigEditor", UnrealModuleType.Engine)]
public enum EConfigFileSourceControlStatus
{
	CFSCS_Unknown,
	CFSCS_Writable,
	CFSCS_Locked
}
