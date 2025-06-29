using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AndroidFileServerEditor;

[UEnum]
[UMetaPath("/Script/AndroidFileServerEditor.EAFSConnectionType", "AndroidFileServerEditor", UnrealModuleType.EnginePlugin)]
public enum EAFSConnectionType
{
	USBOnly,
	NetworkOnly,
	Combined
}
