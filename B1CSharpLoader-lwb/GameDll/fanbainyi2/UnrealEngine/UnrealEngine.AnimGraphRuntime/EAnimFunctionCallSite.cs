using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EAnimFunctionCallSite", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EAnimFunctionCallSite
{
	OnInitialize,
	OnUpdate,
	OnBecomeRelevant,
	OnEvaluate,
	OnInitializePostRecursion,
	OnUpdatePostRecursion,
	OnBecomeRelevantPostRecursion,
	OnEvaluatePostRecursion,
	OnStartedBlendingOut,
	OnStartedBlendingIn,
	OnFinishedBlendingOut,
	OnFinishedBlendingIn
}
