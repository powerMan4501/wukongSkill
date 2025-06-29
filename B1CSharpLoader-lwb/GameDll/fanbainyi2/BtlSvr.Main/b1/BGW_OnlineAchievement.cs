using System;
using System.Collections.Generic;
using System.Linq;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineAchievement")]
public class BGW_OnlineAchievement : UBGWOnlineAchievement, IGameInstObj
{
	public class AchievementCS
	{
		public string Id;

		public double Progress;
	}

	private enum ECacheAchievementStatus
	{
		None,
		Doing,
		Done
	}

	public delegate void Del_OnQueryAchievements(bool bWasSuccessful);

	public delegate void Del_OnAchievementsWritten(bool bWasSuccessful);

	public delegate void Del_OnStatUpdated(bool bWasSuccessful);

	public int _StatId = -1;

	private List<AchievementCS> CachedPlatformAchievementList;

	private ECacheAchievementStatus CacheAchievementStatus;

	private Del_OnQueryAchievements QueryAchievementsCallBack;

	private Del_OnAchievementsWritten WriteAchievementCallBack;

	private Del_OnStatUpdated StatUpdatedCallBack;

	private static bool OnStatUpdatedCompleteCS_IsValid;

	private static IntPtr OnStatUpdatedCompleteCS_FunctionAddress;

	private static int OnStatUpdatedCompleteCS_ParamsSize;

	private static bool OnStatUpdatedCompleteCS_bWasSuccessful_IsValid;

	private static int OnStatUpdatedCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnQueryAchievementsCompleteCS_IsValid;

	private static IntPtr OnQueryAchievementsCompleteCS_FunctionAddress;

	private static int OnQueryAchievementsCompleteCS_ParamsSize;

	private static bool OnQueryAchievementsCompleteCS_bWasSuccessful_IsValid;

	private static int OnQueryAchievementsCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnAchievementsWrittenCompleteCS_IsValid;

	private static IntPtr OnAchievementsWrittenCompleteCS_FunctionAddress;

	private static int OnAchievementsWrittenCompleteCS_ParamsSize;

	private static bool OnAchievementsWrittenCompleteCS_bWasSuccessful_IsValid;

	private static int OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress;

	public int StatId
	{
		get
		{
			if (_StatId < 0)
			{
				_StatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":Tick");
			}
			return _StatId;
		}
	}

	public bool bTickEnabled => false;

	private AchievementCS FindOrInsertCachedPlatformAchievement(string AchievementId)
	{
		foreach (AchievementCS cachedPlatformAchievement in CachedPlatformAchievementList)
		{
			if (cachedPlatformAchievement.Id == AchievementId)
			{
				return cachedPlatformAchievement;
			}
		}
		CachedPlatformAchievementList.Add(new AchievementCS
		{
			Id = AchievementId,
			Progress = 0.0
		});
		return CachedPlatformAchievementList.Last();
	}

	public double GetCachedAchievementProgress(string AchievementId)
	{
		return FindOrInsertCachedPlatformAchievement(AchievementId).Progress;
	}

	private void CheckPlatinumAchievemnt()
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.PS5 || BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Epic)
		{
			return;
		}
		List<int> uncompletedPlatformAchievements = GetUncompletedPlatformAchievements();
		if (uncompletedPlatformAchievements.Count == 1 && GameDBRuntime.IsPlatinumAchievemnt(BGW_OnlineSubsystem.OnlineSubsystemType, uncompletedPlatformAchievements[0]))
		{
			AchievementDesc achievementDesc = GameDBRuntime.GetAchievementDesc(uncompletedPlatformAchievements[0]);
			if (achievementDesc != null)
			{
				int statValue = GameDBRuntime.CalRequirementCount(achievementDesc);
				BGW_PlatformEventExecMgr.Get(this).FirePlatformAchievementEvent(BGW_OnlineSubsystem.OnlineSubsystemType, uncompletedPlatformAchievements[0], statValue, 100.0, "SyncPlatinumAchievementToPlatform");
			}
		}
	}

	public void UpdateCachedAchievementProgress(string AchievementId, double Progress)
	{
		AchievementCS achievementCS = FindOrInsertCachedPlatformAchievement(AchievementId);
		double progress = achievementCS.Progress;
		if (Progress > achievementCS.Progress)
		{
			achievementCS.Progress = Progress;
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"UpdateCachedAchievementProgress AchievementId:{AchievementId} Progress:{progress}->{Progress}");
			if (int.TryParse(AchievementId, out var result) && !GameDBRuntime.IsPlatinumAchievemnt(BGW_OnlineSubsystem.OnlineSubsystemType, result))
			{
				CheckPlatinumAchievemnt();
			}
		}
		else
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"Progress Not Change AchievementId : {AchievementId} Current Porgress:{progress}");
		}
	}

	public bool IsCurPlatformAchievemnt(int AchievementId)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Steam || BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Tencent)
		{
			return GameDBRuntime.GetPlatformAchievementDesc(AchievementId) != null;
		}
		if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Epic || BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.PS5)
		{
			return GameDBRuntime.GetPlatformAchievementLiteDesc(AchievementId) != null;
		}
		return false;
	}

	public List<int> GetUncompletedPlatformAchievements()
	{
		List<int> list = new List<int>();
		foreach (AchievementCS cachedPlatformAchievement in CachedPlatformAchievementList)
		{
			if (int.TryParse(cachedPlatformAchievement.Id, out var result) && IsCurPlatformAchievemnt(result) && cachedPlatformAchievement.Progress != 100.0)
			{
				list.Add(result);
			}
		}
		return list;
	}

	public void OnAttach()
	{
	}

	public void OnInit()
	{
		Init();
		CachedPlatformAchievementList = new List<AchievementCS>();
		CacheAchievementStatus = ECacheAchievementStatus.None;
	}

	private void SetCacheAchievementStatus(ECacheAchievementStatus Status)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"SetCacheAchievementStatus {CacheAchievementStatus} To {Status}");
		CacheAchievementStatus = Status;
	}

	public void CachePlatformAchievements()
	{
		if (CacheAchievementStatus == ECacheAchievementStatus.Doing || CacheAchievementStatus == ECacheAchievementStatus.Done)
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"Try CachePlatformAchievements But Now Status Is {CacheAchievementStatus}");
			return;
		}
		ReadAchievements(delegate(bool bSuccessful)
		{
			if (bSuccessful)
			{
				if (GetAllAchievements(out var outAchievements))
				{
					foreach (FBGWOnlineAchievementTag item in outAchievements)
					{
						CachedPlatformAchievementList.Add(new AchievementCS
						{
							Id = item.Id,
							Progress = item.Progress
						});
					}
					SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("GetCachedAchievement Success");
				}
				for (int i = 0; i < CachedPlatformAchievementList.Count; i++)
				{
					if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Epic)
					{
						CachedPlatformAchievementList[i].Progress *= 100.0;
					}
				}
			}
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"ReadAchievements bSuccessful: {bSuccessful}");
			CheckPlatinumAchievemnt();
			SetCacheAchievementStatus(ECacheAchievementStatus.Done);
		});
		SetCacheAchievementStatus(ECacheAchievementStatus.Doing);
	}

	public void OnAfterInit()
	{
		CachePlatformAchievements();
	}

	public bool CanTick()
	{
		return false;
	}

	public void OnShutdown()
	{
		Destroy();
	}

	public void OnPostLoadMap()
	{
	}

	public int GetTickGroupMask()
	{
		return 0;
	}

	public void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public static BGW_OnlineAchievement Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineAchievement>(WorldContext);
	}

	public void ReadAchievements(Del_OnQueryAchievements CallBack)
	{
		QueryAchievementsCallBack = CallBack;
		ReadAchievements();
	}

	public void WriteAchievement(string writeObjKey, double writeObjValue, Del_OnAchievementsWritten CallBack)
	{
		WriteAchievementCallBack = CallBack;
		WriteAchievement(writeObjKey, writeObjValue);
	}

	public void UpdateStat(string statName, int statValue, Del_OnStatUpdated Callback)
	{
		StatUpdatedCallBack = Callback;
		UpdateStat(statName, statValue);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineAchievement:OnQueryAchievementsCompleteCS")]
	protected override void OnQueryAchievementsCompleteCS_Implementation(bool bWasSuccessful)
	{
		QueryAchievementsCallBack?.Invoke(bWasSuccessful);
		QueryAchievementsCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineAchievement:OnAchievementsWrittenCompleteCS")]
	protected override void OnAchievementsWrittenCompleteCS_Implementation(bool bWasSuccessful)
	{
		WriteAchievementCallBack?.Invoke(bWasSuccessful);
		WriteAchievementCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineAchievement:OnStatUpdatedCompleteCS")]
	protected override void OnStatUpdatedCompleteCS_Implementation(bool bWasSuccessful)
	{
		StatUpdatedCallBack?.Invoke(bWasSuccessful);
		StatUpdatedCallBack = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineAchievement:OnStatUpdatedCompleteCS")]
	private static void OnStatUpdatedCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineAchievement bGW_OnlineAchievement = GCHelper.Find<BGW_OnlineAchievement>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnStatUpdatedCompleteCS_bWasSuccessful_Offset), 0, OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineAchievement.OnStatUpdatedCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineAchievement:OnQueryAchievementsCompleteCS")]
	private static void OnQueryAchievementsCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineAchievement bGW_OnlineAchievement = GCHelper.Find<BGW_OnlineAchievement>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnQueryAchievementsCompleteCS_bWasSuccessful_Offset), 0, OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineAchievement.OnQueryAchievementsCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineAchievement:OnAchievementsWrittenCompleteCS")]
	private static void OnAchievementsWrittenCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineAchievement bGW_OnlineAchievement = GCHelper.Find<BGW_OnlineAchievement>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset), 0, OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineAchievement.OnAchievementsWrittenCompleteCS_Implementation(bWasSuccessful);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineAchievement");
		OnStatUpdatedCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStatUpdatedCompleteCS");
		OnStatUpdatedCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStatUpdatedCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnStatUpdatedCompleteCS_bWasSuccessful_PropertyAddress, OnStatUpdatedCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStatUpdatedCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnStatUpdatedCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStatUpdatedCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnStatUpdatedCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnStatUpdatedCompleteCS_IsValid = OnStatUpdatedCompleteCS_FunctionAddress != IntPtr.Zero && OnStatUpdatedCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineAchievement:OnStatUpdatedCompleteCS", OnStatUpdatedCompleteCS_IsValid);
		OnQueryAchievementsCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnQueryAchievementsCompleteCS");
		OnQueryAchievementsCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQueryAchievementsCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnQueryAchievementsCompleteCS_bWasSuccessful_PropertyAddress, OnQueryAchievementsCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryAchievementsCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnQueryAchievementsCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryAchievementsCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnQueryAchievementsCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnQueryAchievementsCompleteCS_IsValid = OnQueryAchievementsCompleteCS_FunctionAddress != IntPtr.Zero && OnQueryAchievementsCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineAchievement:OnQueryAchievementsCompleteCS", OnQueryAchievementsCompleteCS_IsValid);
		OnAchievementsWrittenCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAchievementsWrittenCompleteCS");
		OnAchievementsWrittenCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAchievementsWrittenCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAchievementsWrittenCompleteCS_bWasSuccessful_PropertyAddress, OnAchievementsWrittenCompleteCS_FunctionAddress, "bWasSuccessful");
		OnAchievementsWrittenCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnAchievementsWrittenCompleteCS_FunctionAddress, "bWasSuccessful");
		OnAchievementsWrittenCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnAchievementsWrittenCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnAchievementsWrittenCompleteCS_IsValid = OnAchievementsWrittenCompleteCS_FunctionAddress != IntPtr.Zero && OnAchievementsWrittenCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineAchievement:OnAchievementsWrittenCompleteCS", OnAchievementsWrittenCompleteCS_IsValid);
	}

	static BGW_OnlineAchievement()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineAchievement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineAchievement));
	}
}
