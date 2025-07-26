using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using b1.EventDelDefine;
using b1.GSMUI.GSWidget;
using b1.UI;
using b1.UI.Comm;
using B1UI.GSUI;
using BtlShare;
using CSharpModBase;
using CSharpModBase.Input;
using GSE.GSICore;
using GSE.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace TestMod;

public class BVBModTest : ICSharpMod
{
	private enum TeamType
	{
		Team1 = 1,
		Team2
	}

	private TeamType _CurTeam = TeamType.Team1;

	private List<VIMiniGMPanel> _TeamPanelList = new List<VIMiniGMPanel>();

	private Dictionary<TeamType, Dictionary<int, VIMiniGMCmdBtn>> _CacheCMDBtn = new Dictionary<TeamType, Dictionary<int, VIMiniGMCmdBtn>>();

	private UEditableTextBox _GMCmd;

	private UIMiniGM _MiniGmPage;

	private Task _TickTask;

	private static List<BUTamerActor> _BossList1 = new List<BUTamerActor>();

	private static List<BUTamerActor> _BossList2 = new List<BUTamerActor>();

	private static List<BUTamerActor> _AllBossList = new List<BUTamerActor>();

	private bool _isInFree = false;

	private static BUS_SpringArmComponent s_CameraBoom = null;

	private static UCameraComponent s_CameraComponent = null;

	private static float s_Fov = 100f;

	private static int _CurBossVision = -1;

	private static string _CurBossVisionGUID = "";

	private static bool _isStartTask = false;

	string ICSharpMod.Name => "BVBModTest";

	string ICSharpMod.Version => "1.0.0";

	void ICSharpMod.DeInit()
	{
	}

	async void ICSharpMod.Init()
	{
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)70, (Action)OpenBVBMenu);
		BossConfigData.Instance.LoadData();
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)68, (Action)BossCamera);
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)187, (Action)SubFov);
		Utils.RegisterKeyBind((ModifierKeys)2, (Key)189, (Action)AddFov);
		UWorld world = Helper.GetWorld();
		_ = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world) is ABGPPlayerController;
		if (_TickTask != null)
		{
			_TickTask.Dispose();
		}
		_isInFree = false;
		_TickTask = StartTickTask(TimeSpan.FromSeconds(0.5));
		await _TickTask;
	}

	private static async Task StartTickTask(TimeSpan interval)
	{
		while (true)
		{
			Tick();
			await Task.Delay(interval);
		}
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		if (!(_CurBossVisionGUID == InUnitGuid))
		{
			return;
		}
		UWorld world = Helper.GetWorld();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world);
		ABGPPlayerController val = (ABGPPlayerController)(object)((firstLocalPlayerController is ABGPPlayerController) ? firstLocalPlayerController : null);
		APawn controlledPawn = Helper.GetControlledPawn();
		BGUPlayerCharacterCS val2 = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		_CurBossVisionGUID = "";
		s_CameraComponent.FieldOfView = 60f;
		BUS_EventCollectionCS.Get((AActor)(object)val2).Evt_EnableCustomFOV.Invoke(false);
		((USceneComponent)(object)s_CameraBoom).DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, bCallModify: true);
		((USceneComponent)(object)s_CameraBoom).AttachToComponent(((AActor)(object)val2).GetRootComponent(), new FName("CAMERA_LOCK"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
		((APlayerController)(object)val).SetViewTargetWithBlend((AActor)(object)val2, 0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f, bLockOutgoing: false);
		((AActor)(object)val2).SetActorHiddenInGame(bNewHidden: false);
		_CurBossVision = -1;
		string text = default(string);
		for (int i = 0; i < _AllBossList.Count; i++)
		{
			((ABGUTamerBase)_AllBossList[i]).GetActorGuid(ref text);
			if (text == _CurBossVisionGUID)
			{
				_AllBossList.RemoveAt(i);
				break;
			}
		}
	}

	private static void Tick()
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		if (_BossList1 == null || _BossList1.Count <= 0 || _BossList2 == null || _BossList2.Count <= 0)
		{
			return;
		}
		BGUCharacterCS val = null;
		BGUCharacterCS val2 = null;
		foreach (BUTamerActor item in _BossList1)
		{
			if (!((UObject)(object)item != null) || !((UObject)(object)(val = item.GetMonster()) != null))
			{
				continue;
			}
			float num = 9999999f;
			ABGUCharacter val3 = null;
			foreach (BUTamerActor item2 in _BossList2)
			{
				if ((UObject)(object)item2 != null && (UObject)(object)(val2 = item2.GetMonster()) != null)
				{
					FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation((AActor)(object)val);
					FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation((AActor)(object)val2);
					float num2 = FVector.Dist(v, v2);
					if (num2 < num)
					{
						val3 = (ABGUCharacter)(object)val2;
					}
				}
			}
			if ((UObject)(object)val3 != null)
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(false, (AActor)(object)val, new UnitLockTargetInfo((AActor)(object)val3, (ETargetSourceType)5, (ELockTargetWayType)1, "", ""));
			}
		}
		BGUCharacterCS val4 = null;
		BGUCharacterCS val5 = null;
		foreach (BUTamerActor item3 in _BossList2)
		{
			if (!((UObject)(object)item3 != null) || !((UObject)(object)(val4 = item3.GetMonster()) != null))
			{
				continue;
			}
			float num3 = 9999999f;
			ABGUCharacter val6 = null;
			foreach (BUTamerActor item4 in _BossList1)
			{
				if ((UObject)(object)item4 != null && (UObject)(object)(val2 = item4.GetMonster()) != null)
				{
					FVector v3 = BGUFuncLibActorTransformCS.BGUGetActorLocation((AActor)(object)val);
					FVector v4 = BGUFuncLibActorTransformCS.BGUGetActorLocation((AActor)(object)val2);
					float num4 = FVector.Dist(v3, v4);
					if (num4 < num3)
					{
						val6 = (ABGUCharacter)(object)val2;
					}
				}
			}
			if ((UObject)(object)val6 != null)
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(false, (AActor)(object)val, new UnitLockTargetInfo((AActor)(object)val6, (ETargetSourceType)5, (ELockTargetWayType)1, "", ""));
			}
		}
	}

	private void AddFov()
	{
		if (_CurBossVision != _AllBossList.Count && !((UObject)(object)s_CameraBoom == null))
		{
			s_Fov += 5f;
			if (s_Fov > 120f)
			{
				s_Fov = 120f;
			}
			s_CameraComponent.FieldOfView = s_Fov;
		}
	}

	private void SubFov()
	{
		if (_CurBossVision != _AllBossList.Count && !((UObject)(object)s_CameraBoom == null))
		{
			s_Fov -= 5f;
			if (s_Fov < 60f)
			{
				s_Fov = 60f;
			}
			s_CameraComponent.FieldOfView = s_Fov;
		}
	}

	private void BossCamera()
	{
		UWorld world = Helper.GetWorld();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world);
		ABGPPlayerController val = (ABGPPlayerController)(object)((firstLocalPlayerController is ABGPPlayerController) ? firstLocalPlayerController : null);
		APawn controlledPawn = Helper.GetControlledPawn();
		BGUPlayerCharacterCS val2 = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		if ((UObject)(object)s_CameraBoom == null)
		{
			s_CameraBoom = val2.CameraBoom1;
		}
		if (s_CameraComponent == null)
		{
			s_CameraComponent = val2.FollowCamera;
		}
		_CurBossVision++;
		if (_CurBossVision == _AllBossList.Count || (UObject)(object)s_CameraBoom == null)
		{
			_CurBossVisionGUID = "";
			s_CameraComponent.FieldOfView = 60f;
			BUS_EventCollectionCS.Get((AActor)(object)val2).Evt_EnableCustomFOV.Invoke(false);
			((USceneComponent)(object)s_CameraBoom).DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, bCallModify: true);
			((USceneComponent)(object)s_CameraBoom).AttachToComponent(((AActor)(object)val2).GetRootComponent(), new FName("CAMERA_LOCK"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
			((APlayerController)(object)val).SetViewTargetWithBlend((AActor)(object)val2, 0.5f, EViewTargetBlendFunction.VTBlend_Linear, 0f, bLockOutgoing: false);
			((AActor)(object)val2).SetActorHiddenInGame(bNewHidden: false);
			_CurBossVision = -1;
			return;
		}
		if (_CurBossVision > _AllBossList.Count)
		{
			_CurBossVision = 0;
		}
		if (_AllBossList == null || _AllBossList.Count <= 0)
		{
			return;
		}
		BUTamerActor val3 = _AllBossList[_CurBossVision];
		if ((UObject)(object)val3 != null)
		{
			BGUCharacterCS monster = val3.GetMonster();
			if ((UObject)(object)monster != null)
			{
				s_CameraComponent.FieldOfView = s_Fov;
				BUS_EventCollectionCS.Get((AActor)(object)val2).Evt_EnableCustomFOV.Invoke(true);
				((USceneComponent)(object)s_CameraBoom).DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, bCallModify: true);
				((USceneComponent)(object)s_CameraBoom).AttachToComponent((USceneComponent)((ACharacter)(object)monster).Mesh, new FName("CAMERA_LOCK"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
				((ABGUCharacter)monster).GetActorGuid(ref _CurBossVisionGUID);
				((AActor)(object)val2).SetActorHiddenInGame(bNewHidden: true);
			}
		}
	}

	private void BuffCharacter()
	{
		UWorld world = Helper.GetWorld();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world);
		ABGPPlayerController val = (ABGPPlayerController)(object)((firstLocalPlayerController is ABGPPlayerController) ? firstLocalPlayerController : null);
		APawn controlledPawn = Helper.GetControlledPawn();
		BGUPlayerCharacterCS val2 = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		BGUFunctionLibraryCS.BGUAddBuff((AActor)(object)val2, (AActor)(object)val2, 690, (EBuffSourceType)0, -1f);
	}

	private void OnCmdTextSubmit(FText Text, ETextCommit CommitMethod)
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		if (CommitMethod != ETextCommit.OnEnter || !(Text.ToString() != ""))
		{
			return;
		}
		string text = Text.ToString();
		int num = text.IndexOf("-1");
		int num2 = text.IndexOf("-2");
		if (num < 0 || num2 < 0)
		{
			return;
		}
		UWorld world = Helper.GetWorld();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world);
		ABGPPlayerController val = (ABGPPlayerController)(object)((firstLocalPlayerController is ABGPPlayerController) ? firstLocalPlayerController : null);
		APawn controlledPawn = Helper.GetControlledPawn();
		BGUPlayerCharacterCS val2 = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		try
		{
			string text2 = text.Substring(num + 3, num2 - num - 4);
			string[] array = text2.Split(' ');
			_AllBossList.Clear();
			string[] array2 = array;
			BUTamerActor boss = default(BUTamerActor);
			foreach (string id in array2)
			{
				string assetPathByID = BossConfigData.Instance.GetAssetPathByID(id);
				if (string.IsNullOrEmpty(assetPathByID))
				{
					continue;
				}
				UClass uClass = BGW_PreloadAssetMgr.Get((UObject)world).TryGetCachedResourceObj<UClass>(assetPathByID, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
				FVector fVector = ((AActor)(object)val2).GetActorLocation() + ((AActor)(object)val2).GetActorForwardVector() * 1500.0;
				ref BUTamerActor reference = ref boss;
				AActor aActor = BGUFunctionLibraryCS.BGUSpawnActor(world, (TSubclassOf<AActor>)uClass, fVector, ((AActor)(object)val2).GetActorRotation());
				reference = (BUTamerActor)(object)((aActor is BUTamerActor) ? aActor : null);
				boss.CurrentRef.AddSpawnRuleFlag((ETamerSpawnRule)4);
				FTamerRef currentRef = boss.CurrentRef;
				FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
				field.SetValue(currentRef, (object)(ETamerPhase)2);
				currentRef.OverrideResetType = (EBGUResetType)3;
				currentRef.GroupOverrideResetType = (EBGUResetType)3;
				currentRef.TamerTransform = ((AActor)(object)val2).GetActorTransform();
				((AActor)(object)boss).Teleport(fVector, ((AActor)(object)val2).GetActorRotation());
				((ABGUTamerBase)boss).TamerType = (ETamerType)2;
				_BossList1.Add(boss);
				Task.Run(async delegate
				{
					await Task.Delay(1000);
					BUTamerActor tamer = default(BUTamerActor);
					int num4;
					if (boss != null)
					{
						tamer = boss;
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					if (num4 != 0)
					{
						BGUCharacterCS monster = tamer.GetMonster();
						BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)monster, (EBGUSimpleState)30, false);
						monster.SetTeamIDInCS(19);
					}
				});
			}
			string text3 = text.Substring(num2 + 3);
			string[] array3 = text3.Split(' ');
			string[] array4 = array3;
			BUTamerActor boss2 = default(BUTamerActor);
			foreach (string id2 in array4)
			{
				string assetPathByID2 = BossConfigData.Instance.GetAssetPathByID(id2);
				if (string.IsNullOrEmpty(assetPathByID2))
				{
					continue;
				}
				TSubclassOf<AActor> tSubclassOf = UObject.LoadClass(UClass.GetClass<AActor>(), null, assetPathByID2);
				FVector fVector2 = ((AActor)(object)val2).GetActorLocation() + ((AActor)(object)val2).GetActorForwardVector() * 1500.0;
				ref BUTamerActor reference2 = ref boss2;
				AActor aActor2 = BGUFunctionLibraryCS.BGUSpawnActor(world, tSubclassOf, fVector2, ((AActor)(object)val2).GetActorRotation());
				reference2 = (BUTamerActor)(object)((aActor2 is BUTamerActor) ? aActor2 : null);
				boss2.CurrentRef.AddSpawnRuleFlag((ETamerSpawnRule)4);
				FTamerRef currentRef2 = boss2.CurrentRef;
				FieldInfo field2 = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
				field2.SetValue(currentRef2, (object)(ETamerPhase)2);
				currentRef2.OverrideResetType = (EBGUResetType)3;
				currentRef2.GroupOverrideResetType = (EBGUResetType)3;
				currentRef2.TamerTransform = ((AActor)(object)val2).GetActorTransform();
				((AActor)(object)boss2).Teleport(fVector2, ((AActor)(object)val2).GetActorRotation());
				((ABGUTamerBase)boss2).TamerType = (ETamerType)2;
				_BossList2.Add(boss2);
				Task.Run(async delegate
				{
					await Task.Delay(1000);
					BUTamerActor tamer = default(BUTamerActor);
					int num4;
					if (boss2 != null)
					{
						tamer = boss2;
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					if (num4 != 0)
					{
						BGUCharacterCS monster = tamer.GetMonster();
						BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)monster, (EBGUSimpleState)30, false);
						monster.SetTeamIDInCS(21);
					}
				});
			}
			_AllBossList.AddRange(_BossList1);
			_AllBossList.AddRange(_BossList2);
			GenAGPage.FadeOutPage(87, "OnClickCloseBtn", (ChangeReason)null);
			if (BGS_EventCollectionCS.Get((UObject)world).Evt_BGS_UnitDead != null)
			{
				BGS_GSEventCollection obj = BGS_EventCollectionCS.Get((UObject)world);
				obj.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
				BGS_GSEventCollection obj2 = BGS_EventCollectionCS.Get((UObject)world);
				obj2.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
			}
		}
		catch (Exception ex)
		{
			GSB1UIUtil.ShowConfirm(FText.FromString("报错"), FText.FromString("报错了,先检查指令是否正确！\n如果确认没问题，就把这个截图给作者B站ID：禽兽-云轩\n" + ex.ToString()), FText.FromString("知道了"), (FText)null, false, (Func<DSConfirm, bool>)null, (Func<DSConfirm, bool>)null, 0, -1f, false);
		}
	}

	private static void OnClickChangeTab(int PreValue, int newValue)
	{
		GenAMiniGMPage.ChangeTab((EnGMTab)newValue, "OnClickChangeTab", (ChangeReason)null);
	}

	private string CmdProcess(string curCmd, string bossID, TeamType team)
	{
		string text = curCmd;
		if (string.IsNullOrEmpty(text) || (!string.IsNullOrEmpty(text) && !text.StartsWith("bvb")))
		{
			text = "bvb -1 -2";
		}
		switch (team)
		{
		case TeamType.Team1:
			text = text.Replace("-1", "-1 " + bossID);
			break;
		case TeamType.Team2:
			text = text.Replace("-2", "-2 " + bossID);
			break;
		}
		return text;
	}

	private void OnRunBtnClick(int gsid)
	{
		if (_GMCmd != null)
		{
			string text = _GMCmd.GetText().ToString();
			if (!string.IsNullOrEmpty(text))
			{
				OnCmdTextSubmit(FText.FromString(text), ETextCommit.OnEnter);
			}
		}
	}

	private void OpenBVBMenu()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		UWorld world = Helper.GetWorld();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)world);
		ABGPPlayerController val = (ABGPPlayerController)(object)((firstLocalPlayerController is ABGPPlayerController) ? firstLocalPlayerController : null);
		APawn controlledPawn = Helper.GetControlledPawn();
		BGUPlayerCharacterCS val2 = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		BGUFunctionLibraryManaged.BGUSwitchPage((UObject)world, (EUIPageID)87);
		ref UIMiniGM miniGmPage = ref _MiniGmPage;
		GSUIPage obj = GSUI.UIMgr.FindUIPage((UObject)(object)val2, 87);
		miniGmPage = (UIMiniGM)(object)((obj is UIMiniGM) ? obj : null);
		GSButton val3 = GSUIUtil.FindAndConstructGSButton(((GSUIView)_MiniGmPage).GetOwnerPage(), ((GSUIView)_MiniGmPage).GetRootUserWidget(), "BtnRunCmd");
		if ((UObject)(object)val3 != null)
		{
			val3.OnGSButtonClicked -= new DelButtonClicked(OnRunBtnClick);
			val3.OnGSButtonClicked += new DelButtonClicked(OnRunBtnClick);
		}
		List<GSUIView> childViewListInfo = ((GSUIView)_MiniGmPage).GetChildViewListInfo();
		foreach (GSUIView item in childViewListInfo)
		{
			VIMiniGMTab val4 = (VIMiniGMTab)(object)((item is VIMiniGMTab) ? item : null);
			if (val4 != null)
			{
				val4.SetVisable(false);
				continue;
			}
			IMiniGMPanel val5 = (IMiniGMPanel)(object)((item is IMiniGMPanel) ? item : null);
			if (val5 != null)
			{
				val5.ShowOut();
			}
		}
		UUserWidget uUserWidget = ((GSUIView)_MiniGmPage).FindChildGadgetMultiWidgetRef("BI_MiniGM_Tab_Btn");
		UUserWidget uUserWidget2 = ((GSUIView)_MiniGmPage).FindChildGadgetMultiWidgetRef("BI_MiniGM_Panel");
		_GMCmd = ((GSUIView)_MiniGmPage).FindChildWidget("CmdInput") as UEditableTextBox;
		if (_GMCmd != null)
		{
			_GMCmd.OnTextCommitted.Clear();
			_GMCmd.OnTextCommitted.Bind(OnCmdTextSubmit);
		}
		DSMiniGMPanel test2 = new DSMiniGMPanel((EnGMTab)7, "队伍2");
		BossConfigData.Instance.BossConfigs.ForEach(delegate(BossConfig config)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			DSMiniGMBtn val9 = new DSMiniGMBtn((EnGMTab)7, config.BossName ?? "", config.BossUUID ?? "", false, false);
			test2.BtnDataList.Add(ChangeReason.UiInit, val9);
		});
		uUserWidget = ((GSUIView)_MiniGmPage).FindChildGadgetMultiWidgetRef("BI_MiniGM_Tab_Btn");
		GSBUIButtonGroup val6 = new GSBUIButtonGroup((GSUIView)(object)_MiniGmPage, new VoidIntInt(OnClickChangeTab), true, true, false, -2020040799, false, true);
		val6.BindSwitchPreKey((GSUIActionEn)7, true, (BoolInt)null);
		val6.BindSwitchNextKey((GSUIActionEn)8, true, (BoolInt)null);
		_TeamPanelList.Clear();
		_CacheCMDBtn.Clear();
		for (int i = 0; i < 2; i++)
		{
			DSMiniGMPanel test3 = new DSMiniGMPanel((EnGMTab)6, $"队伍{i + 1}");
			BossConfigData.Instance.BossConfigs.ForEach(delegate(BossConfig config)
			{
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				DSMiniGMBtn val9 = new DSMiniGMBtn((EnGMTab)i, config.BossName ?? "", config.BossUUID ?? "", false, false);
				test3.BtnDataList.Add(ChangeReason.UiInit, val9);
			});
			VIMiniGMTab val7 = new VIMiniGMTab(uUserWidget, (GSUIView)(object)_MiniGmPage, test3);
			VIMiniGMPanel newPanel = new VIMiniGMPanel(uUserWidget2, (GSUIView)(object)_MiniGmPage);
			newPanel.InitDataStore(test3);
			UUserWidget uUserWidget3 = ((GSUIView)newPanel).FindChildUserWidget("BI_TileView");
			GSTileView val8 = (GSTileView)(object)((uUserWidget3 is GSTileView) ? uUserWidget3 : null);
			int teamIndex = i;
			val8.TileViewPanel.Evt_OnEntryInitializedEvent += delegate(UObject arg1, UUserWidget arg2)
			{
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Expected O, but got Unknown
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Expected O, but got Unknown
				try
				{
					FieldInfo field = typeof(VIMiniGMPanel).GetField("ItemEntryDic", BindingFlags.Instance | BindingFlags.NonPublic);
					if (field.GetValue(newPanel) is Dictionary<int, VIMiniGMCmdBtn> { Count: >0 } dictionary && dictionary.TryGetValue(arg2.GetHashCode(), out var value))
					{
						UUserWidget rootUserWidget = ((GSUIView)value).GetRootUserWidget();
						BUI_Button val9 = (BUI_Button)(object)((rootUserWidget is BUI_Button) ? rootUserWidget : null);
						val9.OnGSButtonActived -= new DelButtonClicked(OnCmdBtnClick);
						val9.OnGSButtonActived += new DelButtonClicked(OnCmdBtnClick);
						if (!_CacheCMDBtn.ContainsKey((TeamType)(teamIndex + 1)))
						{
							_CacheCMDBtn.Add((TeamType)(teamIndex + 1), new Dictionary<int, VIMiniGMCmdBtn>());
						}
						if (!_CacheCMDBtn[(TeamType)(teamIndex + 1)].ContainsKey(((BUI_Widget)val9).GetGSID()))
						{
							_CacheCMDBtn[(TeamType)(teamIndex + 1)].Add(((BUI_Widget)val9).GetGSID(), value);
						}
					}
				}
				catch (Exception value2)
				{
					Console.WriteLine(value2);
					throw;
				}
			};
			_TeamPanelList.Add(newPanel);
			BUI_Button bUIButton = val7.GetBUIButton();
			int index = i;
			bUIButton.OnGSButtonActived += (DelButtonClicked)delegate
			{
				foreach (VIMiniGMPanel teamPanel in _TeamPanelList)
				{
					teamPanel.ShowOut();
				}
				newPanel.ShowIn(false);
				_CurTeam = (TeamType)(index + 1);
			};
		}
		if (_TeamPanelList != null && _TeamPanelList.Count > 0)
		{
			_TeamPanelList[0].ShowIn(false);
			_CurTeam = TeamType.Team1;
		}
	}

	private void OnCmdBtnClick(int gsid)
	{
		if (_CacheCMDBtn.TryGetValue(_CurTeam, out var value) && value != null && value.TryGetValue(gsid, out var value2))
		{
			string text = _GMCmd.GetText();
			string str = CmdProcess(text, value2.GetDataStore().GMCmd, _CurTeam);
			_GMCmd.SetText(FText.FromString(str));
		}
	}
}
