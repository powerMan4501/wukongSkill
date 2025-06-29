using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkFitToGeometryMode", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkFitToGeometryMode
{
	OrientedBox,
	AlignedBox,
	ConvexPolyhedron
}
