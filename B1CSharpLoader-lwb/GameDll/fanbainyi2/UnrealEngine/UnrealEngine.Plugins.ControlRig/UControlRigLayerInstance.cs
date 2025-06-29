using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigLayerInstance", "ControlRig", UnrealModuleType.EnginePlugin)]
public class UControlRigLayerInstance : UAnimInstance, ISequencerAnimationSupport, IInterface
{
}
