using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ProceduralMeshComponent;

[UEnum]
[UMetaPath("/Script/ProceduralMeshComponent.EProcMeshSliceCapOption", "ProceduralMeshComponent", UnrealModuleType.EnginePlugin)]
public enum EProcMeshSliceCapOption
{
	NoCap,
	CreateNewSectionForCap,
	UseLastSectionForCap
}
