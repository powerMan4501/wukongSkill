using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EProjectedHullAxis", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EProjectedHullAxis
{
	X,
	Y,
	Z,
	SmallestBoxDimension,
	SmallestVolume
}
