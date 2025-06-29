using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster")]
public class B1ReplicationGraphNode_TamerMonster : UB1ReplicationGraphNode_CSBase
{
	private static List<AActor> sRelatedActorSwap;

	private List<ABGUCharacter> CharactersSwitchedRole = new List<ABGUCharacter>();

	private static bool PostServerReplicateActorCS_IsValid;

	private static IntPtr PostServerReplicateActorCS_FunctionAddress;

	private static int PostServerReplicateActorCS_ParamsSize;

	private static bool GatherActorListsForConnectionCS_IsValid;

	private static IntPtr GatherActorListsForConnectionCS_FunctionAddress;

	private static int GatherActorListsForConnectionCS_ParamsSize;

	private static bool GatherActorListsForConnectionCS_PlayerController_IsValid;

	private static int GatherActorListsForConnectionCS_PlayerController_Offset;

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster:GatherActorListsForConnectionCS")]
	protected override void GatherActorListsForConnectionCS_Implementation(APlayerController PlayerController)
	{
		CharactersSwitchedRole.Clear();
		base.CachedRepActors.Clear();
		base.CachedUpdateRepFrameActors.Clear();
		BGC_ServerTamerAuthData gameModeReadonlyData = BGU_DataUtil.GetGameModeReadonlyData<BGC_ServerTamerAuthData>(PlayerController);
		if (gameModeReadonlyData == null)
		{
			return;
		}
		foreach (FTamerRef item in gameModeReadonlyData.GetOrAllocActiveTamersInServer(PlayerController.GetName()))
		{
			if (!item.MonsterInstancePtr.IsValid())
			{
				BGW_LogUtil.LogError("GatherActorListsForConnectionCS_Implementation TamerRef InValid");
				continue;
			}
			long objNetGuid = UGSE_OnlineFuncLib.GetObjNetGuid(item.MonsterInstancePtr.Get());
			gameModeReadonlyData.ActiveTamerAuthInfoNetGuidMap.TryGetValue(objNetGuid, out var value);
			sRelatedActorSwap.Clear();
			BUS_EventCollectionCS.Get(item.MonsterInstancePtr.Get())?.Evt_CollectAllRelatedActorForReplicated.Invoke(sRelatedActorSwap);
			foreach (AActor item2 in sRelatedActorSwap)
			{
				base.CachedRepActors.Add(item2);
			}
			if (value == null)
			{
				base.CachedRepActors.Add(item.MonsterInstancePtr.Get());
			}
			else if (value.AuthPlayer == PlayerController)
			{
				switch (value.AuthState)
				{
				case EServerTamerAuthState.ClientAuthWaitingNewChannelReady:
				case EServerTamerAuthState.ClientAuthConfirmed:
					base.CachedUpdateRepFrameActors.Add(item.MonsterInstancePtr.Get());
					break;
				case EServerTamerAuthState.ClientFirstAuth:
				case EServerTamerAuthState.AuthSwitchWaitingOldAuthChannelCleanUp:
					base.CachedRepActors.Add(item.MonsterInstancePtr.Get());
					break;
				default:
					BGW_LogUtil.LogError($"B1Replication UnExpected AuthState:{value.AuthState} TamerGuid:{item.TamerGuid}");
					break;
				case EServerTamerAuthState.AuthSwitchWaitingOldSimulateChannelCleanUp:
					break;
				}
			}
			else
			{
				if (!item.MonsterInstancePtr.IsValid())
				{
					continue;
				}
				if (item.Phase != ETamerPhase.Spawned)
				{
					base.CachedUpdateRepFrameActors.Add(item.MonsterInstancePtr.Get());
					continue;
				}
				if (!BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(item.MonsterInstancePtr.Get()))
				{
					item.MonsterInstancePtr.Get().SwitchNetRoleOnly(HasAuthority: true);
					CharactersSwitchedRole.Add(item.MonsterInstancePtr.Get());
				}
				base.CachedRepActors.Add(item.MonsterInstancePtr.Get());
			}
		}
	}

	[USharpPath("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster:PostServerReplicateActorCS")]
	protected override void PostServerReplicateActorCS_Implementation()
	{
		foreach (ABGUCharacter item in CharactersSwitchedRole)
		{
			if (!item.IsNullOrDestroyed())
			{
				item.SwitchNetRoleOnly(HasAuthority: false);
			}
		}
		CharactersSwitchedRole.Clear();
	}

	static B1ReplicationGraphNode_TamerMonster()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1ReplicationGraphNode_TamerMonster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1ReplicationGraphNode_TamerMonster));
		sRelatedActorSwap = new List<AActor>();
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster:PostServerReplicateActorCS")]
	private static void PostServerReplicateActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphNode_TamerMonster b1ReplicationGraphNode_TamerMonster = GCHelper.Find<B1ReplicationGraphNode_TamerMonster>(obj);
		b1ReplicationGraphNode_TamerMonster.PostServerReplicateActorCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster:GatherActorListsForConnectionCS")]
	private static void GatherActorListsForConnectionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1ReplicationGraphNode_TamerMonster b1ReplicationGraphNode_TamerMonster = GCHelper.Find<B1ReplicationGraphNode_TamerMonster>(obj);
		APlayerController playerController = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, GatherActorListsForConnectionCS_PlayerController_Offset));
		b1ReplicationGraphNode_TamerMonster.GatherActorListsForConnectionCS_Implementation(playerController);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster");
		PostServerReplicateActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostServerReplicateActorCS");
		PostServerReplicateActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostServerReplicateActorCS_FunctionAddress);
		PostServerReplicateActorCS_IsValid = PostServerReplicateActorCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster:PostServerReplicateActorCS", PostServerReplicateActorCS_IsValid);
		GatherActorListsForConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GatherActorListsForConnectionCS");
		GatherActorListsForConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherActorListsForConnectionCS_FunctionAddress);
		GatherActorListsForConnectionCS_PlayerController_Offset = NativeReflection.GetPropertyOffset(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController");
		GatherActorListsForConnectionCS_PlayerController_IsValid = NativeReflection.ValidatePropertyClass(GatherActorListsForConnectionCS_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		GatherActorListsForConnectionCS_IsValid = GatherActorListsForConnectionCS_FunctionAddress != IntPtr.Zero && GatherActorListsForConnectionCS_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1ReplicationGraphNode_TamerMonster:GatherActorListsForConnectionCS", GatherActorListsForConnectionCS_IsValid);
	}
}
