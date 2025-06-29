using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1NetReplicationGraphConnectionCS")]
public class B1NetReplicationGraphConnectionCS : UB1NetReplicationGraphConnection
{
	private static bool NotifyActorChannelAddedCS_IsValid;

	private static IntPtr NotifyActorChannelAddedCS_FunctionAddress;

	private static int NotifyActorChannelAddedCS_ParamsSize;

	private static bool NotifyActorChannelAddedCS_Actor_IsValid;

	private static int NotifyActorChannelAddedCS_Actor_Offset;

	private static bool NotifyActorChannelAddedCS_Channel_IsValid;

	private static int NotifyActorChannelAddedCS_Channel_Offset;

	private static bool NotifyActorChannelRemovedCS_IsValid;

	private static IntPtr NotifyActorChannelRemovedCS_FunctionAddress;

	private static int NotifyActorChannelRemovedCS_ParamsSize;

	private static bool NotifyActorChannelRemovedCS_Actor_IsValid;

	private static int NotifyActorChannelRemovedCS_Actor_Offset;

	private static bool NotifyActorChannelCleanedUpCS_IsValid;

	private static IntPtr NotifyActorChannelCleanedUpCS_FunctionAddress;

	private static int NotifyActorChannelCleanedUpCS_ParamsSize;

	private static bool NotifyActorChannelCleanedUpCS_Channel_IsValid;

	private static int NotifyActorChannelCleanedUpCS_Channel_Offset;

	private static bool NotifyActorChannelCleanedUpCS_CloseReason_IsValid;

	private static int NotifyActorChannelCleanedUpCS_CloseReason_Offset;

	[USharpPath("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelAddedCS")]
	protected override void NotifyActorChannelAddedCS_Implementation(AActor Actor, UActorChannel Channel)
	{
		base.NotifyActorChannelAddedCS_Implementation(Actor, Channel);
		BGS_EventCollectionCS.Get(this)?.Evt_BGS_ActorChannelOpen.Invoke(Actor, GetPlayerControllerCS());
	}

	[USharpPath("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelCleanedUpCS")]
	protected override void NotifyActorChannelCleanedUpCS_Implementation(UActorChannel Channel, int CloseReason)
	{
		base.NotifyActorChannelCleanedUpCS_Implementation(Channel, CloseReason);
		BGS_EventCollectionCS.Get(this)?.Evt_BGS_ActorChannelCleanUp.Invoke(UGSE_OnlineFuncLib.GetObjNetGuidByChannel(Channel), GetPlayerControllerCS(), (EChannelCloseReason)CloseReason);
	}

	[USharpPath("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelRemovedCS")]
	protected override void NotifyActorChannelRemovedCS_Implementation(AActor Actor)
	{
		base.NotifyActorChannelRemovedCS_Implementation(Actor);
		BGS_EventCollectionCS.Get(this)?.Evt_BGS_ActorChannelClose.Invoke(Actor, GetPlayerControllerCS());
	}

	[UFunctionInvoker("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelAddedCS")]
	private static void NotifyActorChannelAddedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1NetReplicationGraphConnectionCS b1NetReplicationGraphConnectionCS = GCHelper.Find<B1NetReplicationGraphConnectionCS>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, NotifyActorChannelAddedCS_Actor_Offset));
		UActorChannel channel = UObjectMarshaler<UActorChannel>.FromNative(IntPtr.Add(buffer, NotifyActorChannelAddedCS_Channel_Offset));
		b1NetReplicationGraphConnectionCS.NotifyActorChannelAddedCS_Implementation(actor, channel);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelRemovedCS")]
	private static void NotifyActorChannelRemovedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1NetReplicationGraphConnectionCS b1NetReplicationGraphConnectionCS = GCHelper.Find<B1NetReplicationGraphConnectionCS>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, NotifyActorChannelRemovedCS_Actor_Offset));
		b1NetReplicationGraphConnectionCS.NotifyActorChannelRemovedCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelCleanedUpCS")]
	private static void NotifyActorChannelCleanedUpCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1NetReplicationGraphConnectionCS b1NetReplicationGraphConnectionCS = GCHelper.Find<B1NetReplicationGraphConnectionCS>(obj);
		UActorChannel channel = UObjectMarshaler<UActorChannel>.FromNative(IntPtr.Add(buffer, NotifyActorChannelCleanedUpCS_Channel_Offset));
		int closeReason = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, NotifyActorChannelCleanedUpCS_CloseReason_Offset));
		b1NetReplicationGraphConnectionCS.NotifyActorChannelCleanedUpCS_Implementation(channel, closeReason);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1NetReplicationGraphConnectionCS");
		NotifyActorChannelAddedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyActorChannelAddedCS");
		NotifyActorChannelAddedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyActorChannelAddedCS_FunctionAddress);
		NotifyActorChannelAddedCS_Actor_Offset = NativeReflection.GetPropertyOffset(NotifyActorChannelAddedCS_FunctionAddress, "Actor");
		NotifyActorChannelAddedCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(NotifyActorChannelAddedCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NotifyActorChannelAddedCS_Channel_Offset = NativeReflection.GetPropertyOffset(NotifyActorChannelAddedCS_FunctionAddress, "Channel");
		NotifyActorChannelAddedCS_Channel_IsValid = NativeReflection.ValidatePropertyClass(NotifyActorChannelAddedCS_FunctionAddress, "Channel", Classes.FObjectProperty);
		NotifyActorChannelAddedCS_IsValid = NotifyActorChannelAddedCS_FunctionAddress != IntPtr.Zero && NotifyActorChannelAddedCS_Actor_IsValid && NotifyActorChannelAddedCS_Channel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelAddedCS", NotifyActorChannelAddedCS_IsValid);
		NotifyActorChannelRemovedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyActorChannelRemovedCS");
		NotifyActorChannelRemovedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyActorChannelRemovedCS_FunctionAddress);
		NotifyActorChannelRemovedCS_Actor_Offset = NativeReflection.GetPropertyOffset(NotifyActorChannelRemovedCS_FunctionAddress, "Actor");
		NotifyActorChannelRemovedCS_Actor_IsValid = NativeReflection.ValidatePropertyClass(NotifyActorChannelRemovedCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		NotifyActorChannelRemovedCS_IsValid = NotifyActorChannelRemovedCS_FunctionAddress != IntPtr.Zero && NotifyActorChannelRemovedCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelRemovedCS", NotifyActorChannelRemovedCS_IsValid);
		NotifyActorChannelCleanedUpCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyActorChannelCleanedUpCS");
		NotifyActorChannelCleanedUpCS_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyActorChannelCleanedUpCS_FunctionAddress);
		NotifyActorChannelCleanedUpCS_Channel_Offset = NativeReflection.GetPropertyOffset(NotifyActorChannelCleanedUpCS_FunctionAddress, "Channel");
		NotifyActorChannelCleanedUpCS_Channel_IsValid = NativeReflection.ValidatePropertyClass(NotifyActorChannelCleanedUpCS_FunctionAddress, "Channel", Classes.FObjectProperty);
		NotifyActorChannelCleanedUpCS_CloseReason_Offset = NativeReflection.GetPropertyOffset(NotifyActorChannelCleanedUpCS_FunctionAddress, "CloseReason");
		NotifyActorChannelCleanedUpCS_CloseReason_IsValid = NativeReflection.ValidatePropertyClass(NotifyActorChannelCleanedUpCS_FunctionAddress, "CloseReason", Classes.FIntProperty);
		NotifyActorChannelCleanedUpCS_IsValid = NotifyActorChannelCleanedUpCS_FunctionAddress != IntPtr.Zero && NotifyActorChannelCleanedUpCS_Channel_IsValid && NotifyActorChannelCleanedUpCS_CloseReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1NetReplicationGraphConnectionCS:NotifyActorChannelCleanedUpCS", NotifyActorChannelCleanedUpCS_IsValid);
	}

	static B1NetReplicationGraphConnectionCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1NetReplicationGraphConnectionCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1NetReplicationGraphConnectionCS));
	}
}
