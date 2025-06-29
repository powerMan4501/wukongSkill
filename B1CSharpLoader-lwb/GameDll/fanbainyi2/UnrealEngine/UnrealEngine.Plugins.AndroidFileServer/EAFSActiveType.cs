using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AndroidFileServer;

[UEnum]
[UMetaPath("/Script/AndroidFileServer.EAFSActiveType", "AndroidFileServer", UnrealModuleType.EnginePlugin)]
public enum EAFSActiveType
{
	None,
	USBOnly,
	NetworkOnly,
	Combined
}
