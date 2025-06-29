using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniInputObjectType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniInputObjectType
{
	Invalid,
	Object,
	StaticMesh,
	SkeletalMesh,
	SceneComponent,
	StaticMeshComponent,
	InstancedStaticMeshComponent,
	SplineComponent,
	HoudiniSplineComponent,
	HoudiniAssetComponent,
	Actor,
	Landscape,
	Brush,
	CameraComponent,
	DataTable,
	HoudiniAssetActor,
	FoliageType_InstancedStaticMesh,
	GeometryCollection,
	GeometryCollectionComponent,
	GeometryCollectionActor
}
