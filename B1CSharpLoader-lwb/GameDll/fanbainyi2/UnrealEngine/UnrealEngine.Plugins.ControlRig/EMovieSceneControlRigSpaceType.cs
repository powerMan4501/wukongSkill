using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.EMovieSceneControlRigSpaceType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EMovieSceneControlRigSpaceType : byte
{
	Parent,
	World,
	ControlRig
}
