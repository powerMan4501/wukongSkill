using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.AkMeshType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkMeshType
{
	StaticMesh,
	CollisionMesh
}
