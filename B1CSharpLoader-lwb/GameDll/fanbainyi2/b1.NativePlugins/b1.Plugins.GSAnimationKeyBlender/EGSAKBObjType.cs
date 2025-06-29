using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.EGSAKBObjType", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public enum EGSAKBObjType : byte
{
	GSA_OBJ_TYPE_MIN,
	GSA_OBJ_TYPE_ACTOR,
	GSA_OBJ_TYPE_WIDGET,
	GSA_OBJ_TYPE_MPC_INST
}
