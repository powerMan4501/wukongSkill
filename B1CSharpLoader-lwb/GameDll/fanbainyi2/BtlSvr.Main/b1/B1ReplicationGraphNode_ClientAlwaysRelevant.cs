using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant")]
public class B1ReplicationGraphNode_ClientAlwaysRelevant : UB1ReplicationGraphNode_CSBase
{
	private List<AActor> ClientAuthActors = new List<AActor>();

	private static bool NotifyAddNetworkActorCS_IsValid;

	private static IntPtr NotifyAddNetworkActorCS_FunctionAddress;

	private static int NotifyAddNetworkActorCS_ParamsSize;

	private static bool NotifyAddNetworkActorCS_Actor_IsValid;

	private static int NotifyAddNetworkActorCS_Actor_Offset;

	private static bool NotifyRemoveNetworkActorCS_IsValid;

	private static IntPtr NotifyRemoveNetworkActorCS_FunctionAddress;

	private static int NotifyRemoveNetworkActorCS_ParamsSize;

	private static bool NotifyRemoveNetworkActorCS_Actor_IsValid;

	private static int NotifyRemoveNetworkActorCS_Actor_Offset;

	private static bool NotifyRemoveNetworkActorCS_bWarnIfNotFound_IsValid;

	private static int NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset;

	private static FFieldAddress NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress;

	private static bool NotifyRemoveNetworkActorCS_ReturnValue_IsValid;

	private static int NotifyRemoveNetworkActorCS_ReturnValue_Offset;

	private static FFieldAddress NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress;

	private static bool GatherActorListsForConnectionCS_IsValid;

	private static IntPtr GatherActorListsForConnectionCS_FunctionAddress;

	private static int GatherActorListsForConnectionCS_ParamsSize;

	private static bool GatherActorListsForConnectionCS_PlayerController_IsValid;

	private static int GatherActorListsForConnectionCS_PlayerController_Offset;

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:NotifyAddNetworkActorCS")]
	protected override void NotifyAddNetworkActorCS_Implementation(AActor Actor)
	{
		ClientAuthActors.Add(Actor);
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:NotifyRemoveNetworkActorCS")]
	protected override bool NotifyRemoveNetworkActorCS_Implementation(AActor Actor, bool bWarnIfNotFound)
	{
		return ClientAuthActors.Remove(Actor);
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:GatherActorListsForConnectionCS")]
	protected override void GatherActorListsForConnectionCS_Implementation(APlayerController PlayerController)
	{
		base.CachedRepActors.Clear();
		base.CachedUpdateRepFrameActors.Clear();
		foreach (AActor clientAuthActor in ClientAuthActors)
		{
			if (!clientAuthActor.IsNullOrDestroyed() && UGSE_OnlineFuncLib.IsActorChannelReadyForClient(clientAuthActor))
			{
				base.CachedRepActors.Add(clientAuthActor);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:NotifyAddNetworkActorCS")]
	private static void NotifyAddNetworkActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphNode_ClientAlwaysRelevant b1ReplicationGraphNode_ClientAlwaysRelevant = GCHelper.Find<B1ReplicationGraphNode_ClientAlwaysRelevant>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, NotifyAddNetworkActorCS_Actor_Offset));
		b1ReplicationGraphNode_ClientAlwaysRelevant.NotifyAddNetworkActorCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:NotifyRemoveNetworkActorCS")]
	private static void NotifyRemoveNetworkActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphNode_ClientAlwaysRelevant b1ReplicationGraphNode_ClientAlwaysRelevant = GCHelper.Find<B1ReplicationGraphNode_ClientAlwaysRelevant>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, NotifyRemoveNetworkActorCS_Actor_Offset));
		bool bWarnIfNotFound = BoolMarshaler.FromNative(IntPtr.Add(buffer, NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset), 0, NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress.Address);
		bool value = b1ReplicationGraphNode_ClientAlwaysRelevant.NotifyRemoveNetworkActorCS_Implementation(actor, bWarnIfNotFound);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, NotifyRemoveNetworkActorCS_ReturnValue_Offset), 0, NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:GatherActorListsForConnectionCS")]
	private static void GatherActorListsForConnectionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphNode_ClientAlwaysRelevant b1ReplicationGraphNode_ClientAlwaysRelevant = GCHelper.Find<B1ReplicationGraphNode_ClientAlwaysRelevant>(obj);
		APlayerController playerController = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, GatherActorListsForConnectionCS_PlayerController_Offset));
		b1ReplicationGraphNode_ClientAlwaysRelevant.GatherActorListsForConnectionCS_Implementation(playerController);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant");
		NotifyAddNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyAddNetworkActorCS");
		NotifyAddNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyAddNetworkActorCS_FunctionAddress);
		NotifyAddNetworkActorCS_Actor_Offset = NativeReflection.GetPropertyOffset(NotifyAddNetworkActorCS_FunctionAddress, "Actor");
		NotifyAddNetworkActorCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(NotifyAddNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NotifyAddNetworkActorCS_IsValid = NotifyAddNetworkActorCS_FunctionAddress != IntPtr.Zero && NotifyAddNetworkActorCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:NotifyAddNetworkActorCS", NotifyAddNetworkActorCS_IsValid);
		NotifyRemoveNetworkActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyRemoveNetworkActorCS");
		NotifyRemoveNetworkActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyRemoveNetworkActorCS_FunctionAddress);
		NotifyRemoveNetworkActorCS_Actor_Offset = NativeReflection.GetPropertyOffset(NotifyRemoveNetworkActorCS_FunctionAddress, "Actor");
		NotifyRemoveNetworkActorCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(NotifyRemoveNetworkActorCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref NotifyRemoveNetworkActorCS_bWarnIfNotFound_PropertyAddress, NotifyRemoveNetworkActorCS_FunctionAddress, "bWarnIfNotFound");
		NotifyRemoveNetworkActorCS_bWarnIfNotFound_Offset = NativeReflection.GetPropertyOffset(NotifyRemoveNetworkActorCS_FunctionAddress, "bWarnIfNotFound");
		NotifyRemoveNetworkActorCS_bWarnIfNotFound_IsValid = NativeReflection.ValidatePropertyClass(NotifyRemoveNetworkActorCS_FunctionAddress, "bWarnIfNotFound", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NotifyRemoveNetworkActorCS_ReturnValue_PropertyAddress, NotifyRemoveNetworkActorCS_FunctionAddress, "ReturnValue");
		NotifyRemoveNetworkActorCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(NotifyRemoveNetworkActorCS_FunctionAddress, "ReturnValue");
		NotifyRemoveNetworkActorCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(NotifyRemoveNetworkActorCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotifyRemoveNetworkActorCS_IsValid = NotifyRemoveNetworkActorCS_FunctionAddress != IntPtr.Zero && NotifyRemoveNetworkActorCS_Actor_IsValid && NotifyRemoveNetworkActorCS_bWarnIfNotFound_IsValid && NotifyRemoveNetworkActorCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:NotifyRemoveNetworkActorCS", NotifyRemoveNetworkActorCS_IsValid);
		GatherActorListsForConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GatherActorListsForConnectionCS");
		GatherActorListsForConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherActorListsForConnectionCS_FunctionAddress);
		GatherActorListsForConnectionCS_PlayerController_Offset = NativeReflection.GetPropertyOffset(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController");
		GatherActorListsForConnectionCS_PlayerController_IsValid = NativeReflection.ValidatePropertyClass(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		GatherActorListsForConnectionCS_IsValid = GatherActorListsForConnectionCS_FunctionAddress != IntPtr.Zero && GatherActorListsForConnectionCS_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphNode_ClientAlwaysRelevant:GatherActorListsForConnectionCS", GatherActorListsForConnectionCS_IsValid);
	}

	static B1ReplicationGraphNode_ClientAlwaysRelevant()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1ReplicationGraphNode_ClientAlwaysRelevant)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1ReplicationGraphNode_ClientAlwaysRelevant));
	}
}
