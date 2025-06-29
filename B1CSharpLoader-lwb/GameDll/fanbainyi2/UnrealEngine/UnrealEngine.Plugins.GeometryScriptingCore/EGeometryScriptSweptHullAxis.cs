using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptSweptHullAxis", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptSweptHullAxis : byte
{
	X,
	Y,
	Z,
	SmallestBoxDimension,
	SmallestVolume
}
