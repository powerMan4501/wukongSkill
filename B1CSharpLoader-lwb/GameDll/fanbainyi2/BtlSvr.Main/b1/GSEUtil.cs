using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using b1.UI;
using b1.UI.Comm;
using BtlB1;
using BtlShare;
using BtlU3;
using ILRuntime.Runtime.Enviorment;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

public static class GSEUtil
{
	private static FMargin GSafeZonePaddingSize;

	private static bool GIsSafeZonePaddingSizeCached = false;

	private static readonly Dictionary<string, DateTime> StaticEnsureMsgDateTimeDict = new Dictionary<string, DateTime>();

	private static IntPtr ListPtr = IntPtr.Zero;

	private static int ListNum = 0;

	private static Dictionary<EUIPageType, EUIPageID> PageType2PageIdDic = new Dictionary<EUIPageType, EUIPageID>
	{
		{
			EUIPageType.Practice,
			EUIPageID.TalentMain
		},
		{
			EUIPageType.Equip,
			EUIPageID.EquipMain
		},
		{
			EUIPageType.Bag,
			EUIPageID.BagMain
		},
		{
			EUIPageType.Shop,
			EUIPageID.Shop
		},
		{
			EUIPageType.WeaponBuild,
			EUIPageID.WeaponBuild
		},
		{
			EUIPageType.EquipBuild,
			EUIPageID.EquipBuild
		},
		{
			EUIPageType.WineLevel,
			EUIPageID.WineStrength
		},
		{
			EUIPageType.HuluLevel,
			EUIPageID.HuluStrength
		},
		{
			EUIPageType.Farm,
			EUIPageID.Farm
		},
		{
			EUIPageType.SoakingMain,
			EUIPageID.SoakingMain
		},
		{
			EUIPageType.RefiningCommonElixir,
			EUIPageID.MedicineRecipe
		},
		{
			EUIPageType.RefiningElixir,
			EUIPageID.Alchemy
		},
		{
			EUIPageType.EquipShop,
			EUIPageID.EquipShop
		},
		{
			EUIPageType.TravelNotes,
			EUIPageID.TravelNotesMain
		},
		{
			EUIPageType.ChapterAward,
			EUIPageID.ChapterAward
		},
		{
			EUIPageType.LearnLegacyTalent,
			EUIPageID.LearnLegacyTalent
		},
		{
			EUIPageType.SoulSkillCollect,
			EUIPageID.SoulSkillCollect
		},
		{
			EUIPageType.BenchMark,
			EUIPageID.BenchMark
		},
		{
			EUIPageType.Archives,
			EUIPageID.Archives
		},
		{
			EUIPageType.Setting,
			EUIPageID.Setting
		},
		{
			EUIPageType.Story,
			EUIPageID.Story
		},
		{
			EUIPageType.Name,
			EUIPageID.Name
		},
		{
			EUIPageType.SeqMediaPlayer,
			EUIPageID.SeqMediaPlayer
		},
		{
			EUIPageType.LearnTalent,
			EUIPageID.LearnTalent
		},
		{
			EUIPageType.EditionAward,
			EUIPageID.EditionAward
		},
		{
			EUIPageType.TakePhoto,
			EUIPageID.TakePhoto
		},
		{
			EUIPageType.SettingHDR,
			EUIPageID.HDRSetting
		},
		{
			EUIPageType.SettingBrightness,
			EUIPageID.BrightnessSetting
		},
		{
			EUIPageType.SettingKeyBoard,
			EUIPageID.SettingInputKeyBoard
		},
		{
			EUIPageType.SeqLogo,
			EUIPageID.SeqLogo
		},
		{
			EUIPageType.PastMemory,
			EUIPageID.PastMemory
		},
		{
			EUIPageType.SoundtrackV2,
			EUIPageID.SoundtrackV2
		},
		{
			EUIPageType.Map,
			EUIPageID.Map
		},
		{
			EUIPageType.BossRushSettlement,
			EUIPageID.BossRushSettlement
		},
		{
			EUIPageType.BossRushReChallenge,
			EUIPageID.BossReChallengeMain
		},
		{
			EUIPageType.BossRushIterations,
			EUIPageID.BossIterationsMain
		},
		{
			EUIPageType.BossRushIterationsAward,
			EUIPageID.BossIterationsAward
		}
	};

	private static Dictionary<EUIPageID, EUIPageType> PageId2PageTypeDic = PageType2PageIdDic.ToDictionary((KeyValuePair<EUIPageType, EUIPageID> i) => i.Value, (KeyValuePair<EUIPageType, EUIPageID> i) => i.Key);

	public static AActor FindActorByTag(UObject WorldContext, string TagName)
	{
		List<AActor> OutActors = new List<AActor>();
		UGameplayStatics.GetAllActorsWithTag(WorldContext, new FName(TagName), out OutActors);
		if (OutActors.Count > 0)
		{
			return OutActors[0];
		}
		return null;
	}

	public static void Check(bool Condition)
	{
		if (!Condition)
		{
			SentrySubsystemReport($"{new StackTrace()}");
			throw new Exception("Check Failed");
		}
	}

	public static void Check(bool Condition, string Msg, UObject WorldContext = null)
	{
		if (!Condition)
		{
			SentrySubsystemReport($"Msg :{new StackTrace()}");
			throw new Exception(Msg);
		}
	}

	public static void TestScript()
	{
		BGW_LogUtil.LogError("Mimi");
	}

	public static void SentrySubsystemReport(string TraceMsg)
	{
		UObject context = null;
		UObject uObject = GCHelper.FindRef(FGlobals.GWorld)?.Managed;
		if (!uObject.IsNullOrDestroyed())
		{
			context = uObject;
		}
		if (BGW_SentrySdkHelper.IsSentryEnable)
		{
			BGW_SentrySdkHelper.SentryCaptureMessage(context, TraceMsg);
		}
	}

	public static bool Ensure(bool Condition, string Msg = "", bool DebugOpenDialog = true)
	{
		if (!Condition)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrEmpty(Msg))
			{
				stringBuilder.AppendLine("Msg: " + Msg);
			}
			stringBuilder.AppendLine($"Ensure Failed: {new StackTrace()}");
			BGW_LogUtil.LogError(stringBuilder.ToString());
			if (CheckCanReportSentry(stringBuilder.ToString()))
			{
				SentrySubsystemReport($"{stringBuilder}");
			}
		}
		return Condition;
	}

	private static bool CheckCanReportSentry(string Msg)
	{
		if (StaticEnsureMsgDateTimeDict.TryGetValue(Msg, out var value) && (DateTime.Now - value).TotalSeconds < (double)DebugConfig.EnsureReportInterval)
		{
			return false;
		}
		StaticEnsureMsgDateTimeDict[Msg] = DateTime.Now;
		return true;
	}

	public static bool IsDebugEnv()
	{
		return !B1Global.GIsGameReleased;
	}

	public static bool IsBossRushMode()
	{
		return B1Global.GIsBossRushMode;
	}

	public static bool IsInBossRushBattleStage()
	{
		if (IsBossRushMode())
		{
			return !IsInBossRushFinishStage();
		}
		return false;
	}

	public static bool IsInBossRushFinishStage()
	{
		return B1Global.GIsBossRushSettlementMode;
	}

	public static bool IsBossRushLastBoss(UObject WorldContext, IBIC_BossRushData BossRushData)
	{
		if (BossRushData == null)
		{
			BossRushData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(WorldContext);
		}
		if (BossRushData != null)
		{
			BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(BossRushData.BossIterationsGroupId);
			if (bossIterationsDesc != null && BossRushData.BossRushType == EBossRushType.BossIterations && BossRushData.BossIterationsIndex < bossIterationsDesc.BossSuccessiveInfo.Count - 1)
			{
				return false;
			}
		}
		return true;
	}

	public static FMargin GetSafeZonePaddingSize(APlayerController PlayerController)
	{
		if (!GIsSafeZonePaddingSizeCached)
		{
			GSafeZonePaddingSize = UGSE_UMGFuncLib.GetSafeZonePaddingSize(PlayerController);
			GIsSafeZonePaddingSizeCached = true;
		}
		return GSafeZonePaddingSize;
	}

	public static bool ProjectWorldLocationToWidgetPositionInSafeZone(APlayerController PlayerController, FVector WorldPos, out FVector2D ScreenPos)
	{
		GetSafeZonePaddingSize(PlayerController);
		bool result = UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(PlayerController, WorldPos, out ScreenPos, bPlayerViewportRelative: false);
		ScreenPos.X -= GSafeZonePaddingSize.Left;
		ScreenPos.Y -= GSafeZonePaddingSize.Top;
		return result;
	}

	public static bool ProjectWorldLocationToWidgetPositionWithSZ(APlayerController PlayerController, FVector WorldPos, out FVector2D ScreenPos)
	{
		return UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(PlayerController, WorldPos, out ScreenPos, bPlayerViewportRelative: false);
	}

	public static bool GSProjectWorldLocationToWidgetPositionOffset(UObject WorldContextObject, FVector WorldPos, UWidget RefWidget, out FVector2D WidgetPosOffset, out bool IsInFront)
	{
		WidgetPosOffset = FVector2D.ZeroVector;
		IsInFront = true;
		APlayerController playerController = UGameplayStatics.GetPlayerController(WorldContextObject, 0);
		if (playerController == null)
		{
			return false;
		}
		if (!UGSE_UMGFuncLib.GSProjectWorldLocationToWidgetPosition(playerController, WorldPos, out var ViewportPosition, out IsInFront))
		{
			return false;
		}
		UGSE_UMGFuncLib.GetWidgetPositionSizeRefViewPort(RefWidget, out var Position, out var _);
		WidgetPosOffset = ViewportPosition - Position;
		return true;
	}

	public static bool ProjectWorldLocationToWidgetPositionOffset(UObject WorldContextObject, FVector WorldPos, UWidget RefWidget, out FVector2D WidgetPosOffset)
	{
		WidgetPosOffset = FVector2D.ZeroVector;
		APlayerController playerController = UGameplayStatics.GetPlayerController(WorldContextObject, 0);
		if (playerController == null)
		{
			return false;
		}
		if (!UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(playerController, WorldPos, out var ScreenPosition, bPlayerViewportRelative: false))
		{
			return false;
		}
		UGSE_UMGFuncLib.GetWidgetPositionSizeRefViewPort(RefWidget, out var Position, out var _);
		WidgetPosOffset = ScreenPosition - Position;
		return true;
	}

	public static bool ProjectWorldLocationToWidgetPositionWithSZ(UObject WorldContextObject, FVector WorldPos, out FVector2D ScreenPos)
	{
		return UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(UGameplayStatics.GetPlayerController(WorldContextObject, 0), WorldPos, out ScreenPos, bPlayerViewportRelative: false);
	}

	public static UActorComponent FindComponentByClass<T>(AActor TargetActor)
	{
		return TargetActor.GetComponentByClass(UClass.GetClass<T>());
	}

	public static void SequenceActorSetBindingByTag(ALevelSequenceActor SeqActor, FName TagName, AActor NewBindingActor)
	{
		SeqActor.AddBindingByTag(TagName, NewBindingActor);
	}

	public static AActor FindActorByClass<T>(UObject WorldContext)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<T>());
		if (allActorsOfClass.Length != 0)
		{
			return allActorsOfClass[0];
		}
		return null;
	}

	public static int PerfProtoBuff(int iRunTimes)
	{
		TBFUStB2DUnitCommDesc tBFUStB2DUnitCommDesc = new TBFUStB2DUnitCommDesc();
		tBFUStB2DUnitCommDesc.List.Add(new FUStB2DUnitCommDesc
		{
			Id = 1,
			BPPath = "111",
			UnitFilter = 1
		});
		for (int i = 0; i < iRunTimes; i++)
		{
			int id = tBFUStB2DUnitCommDesc.List[0].Id;
			tBFUStB2DUnitCommDesc.List[0].Id = tBFUStB2DUnitCommDesc.List[0].UnitFilter;
			tBFUStB2DUnitCommDesc.List[0].UnitFilter = id + 1;
		}
		tBFUStB2DUnitCommDesc.List[0].UnitFilter = tBFUStB2DUnitCommDesc.List[0].UnitFilter + tBFUStB2DUnitCommDesc.List[0].Id;
		return tBFUStB2DUnitCommDesc.List[0].UnitFilter;
	}

	public static void LockEnter(object Locker)
	{
		Monitor.Enter(Locker);
	}

	public static void LockExit(object Locker)
	{
		Monitor.Exit(Locker);
	}

	public static IntPtr CreateList(int n)
	{
		ListPtr = Marshal.AllocHGlobal(8 * n);
		ListNum = n;
		return ListPtr;
	}

	public unsafe static void ListSet(int idx, long val)
	{
		((long*)(void*)ListPtr)[idx] = val;
	}

	public unsafe static long ListGet(int idx)
	{
		return ((long*)(void*)ListPtr)[idx];
	}

	public static int ListLength()
	{
		return ListNum;
	}

	public static void PerfCompTeat2(int KK, int MM)
	{
		for (int i = 0; i < KK; i++)
		{
			ListSet(i % MM, i * i + ListGet((i + i) % MM));
		}
	}

	public static void PerfCompTest(int[] vv, int k, int m)
	{
		for (int i = 0; i < k; i++)
		{
			vv[i % m] = i * i + vv[(i + i) % m];
		}
	}

	public static bool NeedUseResupdateLogic()
	{
		return false;
	}

	public static bool IsNumeric(this string value)
	{
		return Regex.IsMatch(value, "^[+-]?/d*[.]?/d*$");
	}

	public static bool IsInt(this string value)
	{
		return Regex.IsMatch(value, "^[+-]?/d*$");
	}

	public static bool IsUnsign(this string value)
	{
		return Regex.IsMatch(value, "^/d*[.]?/d*$");
	}

	public static bool CalWidgetIsOverScreen(APlayerController PlayerController, UUserWidget RootWidget, UWidget ChildWidget)
	{
		FGeometry paintSpaceGeometry = RootWidget.GetPaintSpaceGeometry();
		FVector2D widgetAbsolutePosition = UGSE_UMGFuncLib.GetWidgetAbsolutePosition(ChildWidget);
		FVector2D widgetLocalSize = UGSE_UMGFuncLib.GetWidgetLocalSize(ChildWidget);
		GetSafeZonePaddingSize(PlayerController);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(PlayerController);
		PlayerController.GetViewportSize(out var SizeX, out var SizeY);
		FVector2D fVector2D = new FVector2D(SizeX, SizeY) / viewportScale;
		float num = 0f;
		FVector2D fVector2D2 = UGSE_UMGFuncLib.SlateAbsoluteToLocal(paintSpaceGeometry, widgetAbsolutePosition);
		FVector2D fVector2D3 = fVector2D2 + widgetLocalSize;
		if (fVector2D2.X > num && fVector2D2.Y > num && fVector2D3.X < fVector2D.X - num && fVector2D3.Y < fVector2D.Y - num)
		{
			return false;
		}
		return true;
	}

	public static void CalcSurroundBox(FVector2D PointA, FVector2D PointB, FVector2D PointC, FVector2D PointD, out FVector2D RetPointMin, out FVector2D RetPointMax)
	{
		RetPointMin = default(FVector2D);
		RetPointMax = default(FVector2D);
		RetPointMin.X = FMath.Min(PointA.X, PointB.X, PointC.X, PointD.X);
		RetPointMin.Y = FMath.Min(PointA.Y, PointB.Y, PointC.Y, PointD.Y);
		RetPointMax.X = FMath.Max(PointA.X, PointB.X, PointC.X, PointD.X);
		RetPointMax.Y = FMath.Max(PointA.Y, PointB.Y, PointC.Y, PointD.Y);
	}

	public static UWidget OnGSCustomWidgetNavigationWithBtn<T>(List<T> ItemList, T Item, EUINavigation Navigation, bool IsRepeated) where T : BUI_Button
	{
		if (Item == null || ItemList == null)
		{
			return null;
		}
		int num = ItemList.IndexOf(Item);
		int x = num;
		int num2 = 0;
		switch (Navigation)
		{
		case EUINavigation.Left:
		case EUINavigation.Up:
			num2 = -1;
			break;
		case EUINavigation.Right:
		case EUINavigation.Down:
			num2 = 1;
			break;
		}
		for (int i = 0; i < ItemList.Count; i++)
		{
			int num3 = num + num2 * (i + 1);
			if (!IsRepeated)
			{
				if (num3 < 0)
				{
					num3 += ItemList.Count;
				}
				else if (num3 >= ItemList.Count)
				{
					num3 -= ItemList.Count;
				}
			}
			if (num3 < 0 || num3 >= ItemList.Count)
			{
				break;
			}
			if (ItemList[num3].IsCanFocus())
			{
				x = num3;
				break;
			}
		}
		x = FMath.Clamp(x, 0, ItemList.Count - 1);
		return ItemList[x];
	}

	public static int GetDelegateHash<T>(T InAction)
	{
		return DelegateManager.GetDelegateHash(InAction);
	}

	public static string GetDelegateName<T>(T InAction)
	{
		return DelegateManager.GetDelegateName(InAction);
	}

	public static string GetLatestFileTimeInfo(string dir)
	{
		DateTime dateTime = DateTime.MinValue;
		string result = string.Empty;
		FileInfo[] files = new DirectoryInfo(dir).GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo.CreationTime > dateTime)
			{
				dateTime = fileInfo.CreationTime;
				result = fileInfo.FullName;
			}
		}
		return result;
	}

	public static EUIPageType GetPageTypebyPageID(int PageId)
	{
		if (PageId2PageTypeDic.TryGetValue((EUIPageID)PageId, out var value))
		{
			return value;
		}
		return EUIPageType.None;
	}

	public static EUIPageID GetPageIDbyPageType(EUIPageType PageType)
	{
		if (PageType2PageIdDic.TryGetValue(PageType, out var value))
		{
			return value;
		}
		return EUIPageID.MIN;
	}

	public static List<int> GetCanTeleportRebirthPointList(UObject WorldContext)
	{
		List<int> result = new List<int>();
		DS_IBPC_RebirthPointData battleData = B1GSUIActorMgr.Get(WorldContext).GetBattleData<DS_IBPC_RebirthPointData>(B1ActorTag.PlayerController);
		if (battleData == null)
		{
			return result;
		}
		battleData.GetActivedRebirthPoints(out var ActivedRebirthPointIdList);
		battleData.GetBlockedRebirthPoints(out var BlockedRebirthPointIdList);
		result = ActivedRebirthPointIdList.Except(BlockedRebirthPointIdList).Where(delegate(int Id)
		{
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(Id);
			return rebirthPointDesc != null && rebirthPointDesc.CanTeleport == EGSYesNo.Yes;
		}).ToList();
		List<int> Temp = BGU_DeepCopyUtil.Copy(result);
		return result.Where(delegate(int Id)
		{
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(Id);
			if (rebirthPointDesc == null)
			{
				return false;
			}
			return !Temp.Contains(rebirthPointDesc.RelatedRebirthPointIdToHiddenThis);
		}).ToList();
	}

	public static List<int> GetCanTeleportGroupMapList(UObject WorldContext)
	{
		return (from Desc in (from Desc in GetCanTeleportRebirthPointList(WorldContext).Select(GameDBRuntime.GetFUStRebirthPointDesc)
				where Desc != null && Desc.CanTeleport == EGSYesNo.Yes
				select Desc.GroupMapID).Select(GameDBRuntime.GetLevelDesc)
			where Desc != null
			select Desc.Id).Distinct().ToList();
	}
}
