using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDISkelMesh_GpuUniformSamplingFormat", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDISkelMesh_GpuUniformSamplingFormat
{
	Full,
	Limited_24_8,
	Limited_23_9
}
