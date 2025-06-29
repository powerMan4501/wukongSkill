using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

public static class UNiagaraFunctionLibrary_CsExtensions
{
	public static UNiagaraComponent SpawnSystemAtLocation(this UWorld WorldContextObject, UNiagaraSystem SystemTemplate, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
	{
		return UNiagaraFunctionLibrary.SpawnSystemAtLocation(WorldContextObject, SystemTemplate, Location, Rotation, Scale, bAutoDestroy, bAutoActivate, PoolingMethod, bPreCullCheck);
	}

	public static void SetComponentNiagaraGPURayTracedCollisionGroup(this UWorld WorldContextObject, UPrimitiveComponent Primitive, int CollisionGroup)
	{
		UNiagaraFunctionLibrary.SetComponentNiagaraGPURayTracedCollisionGroup(WorldContextObject, Primitive, CollisionGroup);
	}

	public static void SetActorNiagaraGPURayTracedCollisionGroup(this UWorld WorldContextObject, AActor Actor, int CollisionGroup)
	{
		UNiagaraFunctionLibrary.SetActorNiagaraGPURayTracedCollisionGroup(WorldContextObject, Actor, CollisionGroup);
	}

	public static void ReleaseNiagaraGPURayTracedCollisionGroup(this UWorld WorldContextObject, int CollisionGroup)
	{
		UNiagaraFunctionLibrary.ReleaseNiagaraGPURayTracedCollisionGroup(WorldContextObject, CollisionGroup);
	}

	public static UNiagaraParameterCollectionInstance GetNiagaraParameterCollection(this UWorld WorldContextObject, UNiagaraParameterCollection Collection)
	{
		return UNiagaraFunctionLibrary.GetNiagaraParameterCollection(WorldContextObject, Collection);
	}

	public static int AcquireNiagaraGPURayTracedCollisionGroup(this UWorld WorldContextObject)
	{
		return UNiagaraFunctionLibrary.AcquireNiagaraGPURayTracedCollisionGroup(WorldContextObject);
	}
}
