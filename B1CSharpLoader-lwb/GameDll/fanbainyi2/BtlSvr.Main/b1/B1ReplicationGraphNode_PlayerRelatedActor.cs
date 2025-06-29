using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_PlayerRelatedActor")]
public class B1ReplicationGraphNode_PlayerRelatedActor : UB1ReplicationGraphNode_CSBase
{
	private static List<AActor> sRelatedActorSwap;

	private static bool GatherActorListsForConnectionCS_IsValid;

	private static IntPtr GatherActorListsForConnectionCS_FunctionAddress;

	private static int GatherActorListsForConnectionCS_ParamsSize;

	private static bool GatherActorListsForConnectionCS_PlayerController_IsValid;

	private static int GatherActorListsForConnectionCS_PlayerController_Offset;

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_PlayerRelatedActor:GatherActorListsForConnectionCS")]
	protected override void GatherActorListsForConnectionCS_Implementation(APlayerController PlayerController)
	{
		base.CachedRepActors.Clear();
		base.CachedUpdateRepFrameActors.Clear();
		APlayerController[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<APlayerController>(PlayerController);
		foreach (APlayerController obj in allActorsOfClass)
		{
			sRelatedActorSwap.Clear();
			BUS_EventCollectionCS.Get(obj.GetControlledPawn())?.Evt_CollectAllRelatedActorForReplicated.Invoke(sRelatedActorSwap);
			foreach (AActor item in sRelatedActorSwap)
			{
				base.CachedRepActors.Add(item);
			}
		}
	}

	static B1ReplicationGraphNode_PlayerRelatedActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1ReplicationGraphNode_PlayerRelatedActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1ReplicationGraphNode_PlayerRelatedActor));
		sRelatedActorSwap = new List<AActor>();
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphNode_PlayerRelatedActor:GatherActorListsForConnectionCS")]
	private static void GatherActorListsForConnectionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphNode_PlayerRelatedActor b1ReplicationGraphNode_PlayerRelatedActor = GCHelper.Find<B1ReplicationGraphNode_PlayerRelatedActor>(obj);
		APlayerController playerController = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, GatherActorListsForConnectionCS_PlayerController_Offset));
		b1ReplicationGraphNode_PlayerRelatedActor.GatherActorListsForConnectionCS_Implementation(playerController);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1ReplicationGraphNode_PlayerRelatedActor");
		GatherActorListsForConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GatherActorListsForConnectionCS");
		GatherActorListsForConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherActorListsForConnectionCS_FunctionAddress);
		GatherActorListsForConnectionCS_PlayerController_Offset = NativeReflection.GetPropertyOffset(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController");
		GatherActorListsForConnectionCS_PlayerController_IsValid = NativeReflection.ValidatePropertyClass(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		GatherActorListsForConnectionCS_IsValid = GatherActorListsForConnectionCS_FunctionAddress != IntPtr.Zero && GatherActorListsForConnectionCS_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphNode_PlayerRelatedActor:GatherActorListsForConnectionCS", GatherActorListsForConnectionCS_IsValid);
	}
}
