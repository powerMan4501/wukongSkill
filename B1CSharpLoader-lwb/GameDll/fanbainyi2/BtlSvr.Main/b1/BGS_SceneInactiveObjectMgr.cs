using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_SceneInactiveObjectMgr : GameStateSystemBase
{
	private static List<float> CurCharactersDistance = new List<float>();

	private static List<float> LastCharactersDistance = new List<float>();

	private static int NumTickedCharacter = 0;

	private BGC_SceneInactiveObjectMgrData InactiveMgrData { get; set; }

	public override void OnAttach()
	{
		InactiveMgrData = RequireWritableData<BGC_SceneInactiveObjectMgrData>();
		base.BGSEventCollection.Evt_BGS_RegisterSceneInactiveActor += new Del_BGS_RegisterSceneInactiveActor(RegisterSceneInactiveActor);
		base.BGSEventCollection.Evt_BGS_ReleaseSceneInactiveActor += new Del_BGS_ReleaseSceneInactiveActor(ReleaseSceneInactiveActor);
		base.BGSEventCollection.Evt_BGS_SetSceneInactiveActorForceActivateTicks += new Del_BGS_SetSceneInactiveActorForceActivateTicks(SetSceneInactiveActorForceActivateTicks);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (InactiveMgrData.SceneInactiveObjectInfos.Count == 0)
		{
			return;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn();
		if (!(aPawn != null))
		{
			return;
		}
		FVector playerLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn);
		bool bDrawDebug = GSGameplayCVar.CVar_TROCounterCullDebug.GetValueInGameThread() == 1;
		if (InactiveMgrData.Index < 0 || InactiveMgrData.Index >= InactiveMgrData.SceneInactiveObjectInfos.Count)
		{
			InactiveMgrData.Index = InactiveMgrData.SceneInactiveObjectInfos.Count - 1;
		}
		int num = InactiveMgrData.Index - (int)((float)InactiveMgrData.SceneInactiveObjectInfos.Count * DeltaTime) - 1;
		while (InactiveMgrData.Index >= 0 && InactiveMgrData.Index >= num)
		{
			if (InactiveMgrData.SceneInactiveObjectInfos[InactiveMgrData.Index].ForceActivateTicks < 0)
			{
				UpdateSceneInactiveObjectInfo(InactiveMgrData.Index, playerLocation, bDrawDebug);
			}
			InactiveMgrData.Index--;
		}
		for (int num2 = InactiveMgrData.SceneInactiveObjectInfos.Count - 1; num2 >= 0; num2--)
		{
			FSceneInactiveObjectInfo fSceneInactiveObjectInfo = InactiveMgrData.SceneInactiveObjectInfos[num2];
			if (fSceneInactiveObjectInfo.ForceActivateTicks >= 0)
			{
				UpdateSceneInactiveObjectInfo(num2, playerLocation, bDrawDebug);
				fSceneInactiveObjectInfo.ForceActivateTicks--;
			}
		}
	}

	private void UpdateSceneInactiveObjectInfo(int ObjectIndex, FVector PlayerLocation, bool bDrawDebug)
	{
		FSceneInactiveObjectInfo fSceneInactiveObjectInfo = InactiveMgrData.SceneInactiveObjectInfos[ObjectIndex];
		AActor actor = fSceneInactiveObjectInfo.Actor;
		if (actor == null)
		{
			ReleaseSceneInactiveActor(ObjectIndex);
			return;
		}
		float num = (PlayerLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(actor)).Size();
		RecordDistanceAndCounter(num, ObjectIndex == 0);
		foreach (FSceneActorActivationInfo activationInfo in fSceneInactiveObjectInfo.ActivationInfos)
		{
			if (activationInfo.SceneActorActivationType == EGSSceneActorActivationType.TickEnable)
			{
				bool flag = ShouldOptimize(num, fSceneInactiveObjectInfo, activationInfo);
				if (bDrawDebug)
				{
					USystemLibrary.DrawDebugString(actor, actor.GetActorLocation(), flag.ToString(), null, FLinearColor.White, 1f);
				}
				if (flag)
				{
					activationInfo.DeactivateComponents(actor);
					continue;
				}
				NumTickedCharacter++;
				activationInfo.ActivateComponents(actor);
			}
			else if (num < activationInfo.ActivateDistance)
			{
				activationInfo.ActivateComponents(actor);
			}
			else
			{
				activationInfo.DeactivateComponents(actor);
			}
		}
	}

	private void RecordDistanceAndCounter(float Distance, bool bIsNewFrame)
	{
		Owner.World.GetTimeSeconds();
		if (bIsNewFrame)
		{
			NumTickedCharacter = 0;
			LastCharactersDistance.Clear();
			LastCharactersDistance.AddRange(CurCharactersDistance);
			LastCharactersDistance.Sort();
			CurCharactersDistance.Clear();
		}
		CurCharactersDistance.Add(Distance);
	}

	private bool ShouldOptimize(float Distance, FSceneInactiveObjectInfo ObjectInfo, FSceneActorActivationInfo ActivationInfo)
	{
		if (ObjectInfo.ForceActivateTicks > 0)
		{
			return false;
		}
		if (GSGameplayCVar.CVar_TROSceneCounterCullEnable.GetValueInGameThread() != 1)
		{
			return false;
		}
		int num = GSGameplayCVar.CVar_TROSceneCounterCullMaxCount.GetValueInGameThread();
		if (num <= 0)
		{
			num = 10;
		}
		if (LastCharactersDistance.Count < num)
		{
			return Distance > ActivationInfo.ActivateDistance;
		}
		return Distance > LastCharactersDistance[num - 1];
	}

	public void RegisterSceneInactiveActor(AActor Actor, List<FSceneActorActivationInfo> SceneInactiveInfo, BUS_SceneInactiveActorComp RegisterComp)
	{
		RegisterComp.SetComponentTickEnabled(bEnabled: false);
		if (InactiveMgrData.SceneInactiveObjectInfos.FindIndex((FSceneInactiveObjectInfo r) => r.Actor == Actor) >= 0)
		{
			return;
		}
		InactiveMgrData.SceneInactiveObjectInfos.Add(new FSceneInactiveObjectInfo(Actor, SceneInactiveInfo));
		foreach (FSceneActorActivationInfo item in SceneInactiveInfo)
		{
			item.DeactivateComponents(Actor);
		}
	}

	public void ReleaseSceneInactiveActor(AActor Actor)
	{
		int index = InactiveMgrData.SceneInactiveObjectInfos.FindIndex((FSceneInactiveObjectInfo r) => r.Actor == Actor);
		ReleaseSceneInactiveActor(index);
	}

	private void ReleaseSceneInactiveActor(int Index)
	{
		if (Index >= 0 && Index < InactiveMgrData.SceneInactiveObjectInfos.Count)
		{
			InactiveMgrData.SceneInactiveObjectInfos.RemoveAt(Index);
		}
	}

	private void SetSceneInactiveActorForceActivateTicks(AActor Actor, int ForceActivateTicks)
	{
		FSceneInactiveObjectInfo fSceneInactiveObjectInfo = InactiveMgrData.SceneInactiveObjectInfos.Find((FSceneInactiveObjectInfo r) => r.Actor == Actor);
		if (fSceneInactiveObjectInfo != null)
		{
			fSceneInactiveObjectInfo.ForceActivateTicks = ForceActivateTicks;
		}
	}
}
