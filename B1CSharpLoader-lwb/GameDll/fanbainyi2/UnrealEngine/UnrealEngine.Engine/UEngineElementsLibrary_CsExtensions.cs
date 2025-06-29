using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.Engine;

public static class UEngineElementsLibrary_CsExtensions
{
	public static FScriptTypedElementHandle AcquireEditorSMInstanceElementHandle(this UInstancedStaticMeshComponent ISMComponent, int InstanceIndex, bool bAllowCreate = true)
	{
		return UEngineElementsLibrary.AcquireEditorSMInstanceElementHandle(ISMComponent, InstanceIndex, bAllowCreate);
	}

	public static FScriptTypedElementHandle AcquireEditorObjectElementHandle(this UObject Object, bool bAllowCreate = true)
	{
		return UEngineElementsLibrary.AcquireEditorObjectElementHandle(Object, bAllowCreate);
	}

	public static FScriptTypedElementHandle AcquireEditorComponentElementHandle(this UActorComponent Component, bool bAllowCreate = true)
	{
		return UEngineElementsLibrary.AcquireEditorComponentElementHandle(Component, bAllowCreate);
	}

	public static FScriptTypedElementHandle AcquireEditorActorElementHandle(this AActor Actor, bool bAllowCreate = true)
	{
		return UEngineElementsLibrary.AcquireEditorActorElementHandle(Actor, bAllowCreate);
	}
}
