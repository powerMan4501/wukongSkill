using System;
using System.Collections.Generic;
using b1.ECS;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PlatformEventExecMgr")]
public class BGW_PlatformEventExecMgr : GameInstanceSystemBaseUObj
{
	private BGW_PlatformEventWorker _Worker;

	public override bool bTickEnabled => true;

	public override void OnInit()
	{
		_Worker = new BGW_PlatformEventWorker(this);
	}

	public static BGW_PlatformEventExecMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_PlatformEventExecMgr>(Context);
	}

	public static BGW_PlatformEventExecMgr Get(Entity Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_PlatformEventExecMgr>(Context);
	}

	public override int GetTickGroupMask()
	{
		return 2048;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickGroup == 2048)
		{
			_Worker.Tick(DeltaTime);
		}
	}

	private List<PlatformEvent> CreatePlatformActivityEventByAction(PlatformEventAction PlatformEventAction, int ActivityOrTaskId)
	{
		List<PlatformEvent> list = new List<PlatformEvent>();
		if (PlatformEventAction == PlatformEventAction.StartActivity)
		{
			if (BGW_OnlineActivity.Get(this).IsDoingActivity)
			{
				list.Add(SetActivityAvailabilityEvent.CreateSetActivityAvailabilityEvent(BGW_OnlineActivity.Get(this).CurActivityId, Available: false, this));
			}
			list.Add(SetActivityAvailabilityEvent.CreateSetActivityAvailabilityEvent(ActivityOrTaskId, Available: true, this));
			list.Add(StartActivityEvent.CreateStartActivityEvent(ActivityOrTaskId, this));
		}
		if (PlatformEventAction == PlatformEventAction.CompleteTask)
		{
			list.Add(SetActivityAvailabilityEvent.CreateSetActivityAvailabilityEvent(ActivityOrTaskId, Available: true, this));
			list.Add(EndActivityEvent.CreateEndActivityEvent(ActivityOrTaskId, this));
			list.Add(SetActivityAvailabilityEvent.CreateSetActivityAvailabilityEvent(ActivityOrTaskId, Available: false, this));
		}
		if (PlatformEventAction == PlatformEventAction.CompleteActivity)
		{
			list.Add(EndActivityEvent.CreateEndActivityEvent(ActivityOrTaskId, this));
			list.Add(SetActivityAvailabilityEvent.CreateSetActivityAvailabilityEvent(ActivityOrTaskId, Available: false, this));
		}
		if (PlatformEventAction == PlatformEventAction.ResetActivity)
		{
			list.Add(ResetAllActiveActivitiesEvent.CreateResetAllActiveActivitiesEvent(this));
		}
		if (PlatformEventAction == PlatformEventAction.HideAllActivity)
		{
			list.Add(ResetAllActiveActivitiesEvent.CreateResetAllActiveActivitiesEvent(this));
			foreach (PS5ActivityDesc item in GameDBRuntime.GetTBPS5ActivityDesc().List)
			{
				list.Add(SetActivityAvailabilityEvent.CreateSetActivityAvailabilityEvent(item.Id, Available: false, this));
			}
		}
		return list;
	}

	private bool NeedSendToPlatform(int AchievementId, double Progress, UObject WorldContext)
	{
		AchievementDesc achievementDesc = GameDBRuntime.GetAchievementDesc(AchievementId);
		if (achievementDesc == null)
		{
			BGW_LogUtil.LogError($"GetAchievementDesc Failed AchievementId:{AchievementId}");
			return false;
		}
		if (!BGW_OnlineAchievement.Get(this).IsCurPlatformAchievemnt(AchievementId))
		{
			return false;
		}
		double cachedAchievementProgress = BGW_OnlineAchievement.Get(WorldContext).GetCachedAchievementProgress(AchievementId.ToString());
		if (Progress > cachedAchievementProgress && (achievementDesc.IsProgress == YesNoType.Yes || Progress == 100.0))
		{
			return true;
		}
		return false;
	}

	private List<PlatformEvent> CreatePlatformAchievementEventByAction(EBGWSubsystemType SubsystemType, int AchievementId, int StatValue, double Progress)
	{
		List<PlatformEvent> list = new List<PlatformEvent>();
		if (SubsystemType == EBGWSubsystemType.Unknown || SubsystemType == EBGWSubsystemType.Null)
		{
			return list;
		}
		if (!NeedSendToPlatform(AchievementId, Progress, this))
		{
			return list;
		}
		if (SubsystemType == EBGWSubsystemType.Epic)
		{
			list.Add(EpicAchievementEvent.CreateEpicAchievementEvent(AchievementId, StatValue, Progress, this));
		}
		if (SubsystemType == EBGWSubsystemType.Steam)
		{
			list.Add(SteamAchievementEvent.CreateSteamAchievementEvent(AchievementId, StatValue, Progress, this));
		}
		if (SubsystemType == EBGWSubsystemType.Tencent)
		{
			list.Add(WeGameAchievementEvent.CreateWeGameAchievementEvent(AchievementId, StatValue, Progress, this));
		}
		if (SubsystemType == EBGWSubsystemType.PS5)
		{
			list.Add(PS5AchievementEvent.CreatePS5AchievementEvent(AchievementId, StatValue, Progress, this));
		}
		return list;
	}

	public void FirePlatformActivityEvent(PlatformEventAction PlatformEventAction, int ActivityOrTaskId, string ExtraMessage = "")
	{
		if (!GSEUtil.IsBossRushMode())
		{
			List<PlatformEvent> todoEventTasks = CreatePlatformActivityEventByAction(PlatformEventAction, ActivityOrTaskId);
			_Worker.EnqueueRequest(todoEventTasks);
		}
	}

	public void FirePlatformAchievementEvent(EBGWSubsystemType SubsystemType, int AchievementId, int StatValue, double Progress, string ExtraMessage = "")
	{
		if (!GSEUtil.IsBossRushMode())
		{
			List<PlatformEvent> todoEventTasks = CreatePlatformAchievementEventByAction(SubsystemType, AchievementId, StatValue, Progress);
			_Worker.EnqueueRequest(todoEventTasks);
		}
	}

	public void MarkTaskCompleted()
	{
		_Worker.MarkTaskCompleted();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PlatformEventExecMgr");
	}

	static BGW_PlatformEventExecMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PlatformEventExecMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PlatformEventExecMgr));
	}
}
