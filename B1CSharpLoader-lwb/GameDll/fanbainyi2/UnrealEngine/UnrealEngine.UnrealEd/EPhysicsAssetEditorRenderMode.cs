using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPhysicsAssetEditorRenderMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EPhysicsAssetEditorRenderMode
{
	Solid,
	Wireframe,
	None
}
