using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimPropertyAccessCallSite", "Engine", UnrealModuleType.Engine)]
public enum EAnimPropertyAccessCallSite
{
	WorkerThread_Unbatched,
	WorkerThread_Batched_PreEventGraph,
	WorkerThread_Batched_PostEventGraph,
	GameThread_Batched_PreEventGraph,
	GameThread_Batched_PostEventGraph
}
