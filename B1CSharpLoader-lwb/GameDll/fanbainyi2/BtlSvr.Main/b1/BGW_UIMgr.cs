using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.GSMUI;
using b1.UI;
using CommB1;
using UnrealEngine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_UIMgr")]
public class BGW_UIMgr : GameInstanceSystemBaseUObj
{
	public const string TickStatName = "GS_BGW_UIMgr.OnTick";

	public const string InputTickStatName = "GS_BGW_UIMgr.OnTick.InputTick";

	public const string InnerTickStatName = "GS_BGW_UIMgr.OnTick.GSInnerTick";

	public const string TickMgrStatName = "GS_BGW_UIMgr.OnTick.TickMgrTick";

	public const string AKBTickStatName = "GS_BGW_UIMgr.OnTick.AKBTick";

	public const string RefreshTextStatName = "GS_BGW_UIMgr.RefreshText";

	public const string InListPureMStatName = "GS_BGW_UIMgr.OnTick.GSInnerTick.InListPureM";

	public const string WidgetInnerTickStatName = "GS_BGW_UIMgr.OnTick.GSInnerTick.WidgetInnerTick";

	public Func<EFocusReason, IFocusWidget, bool> OnAddWidgetToFocus;

	public Func<EFocusReason, IFocusWidget, bool> OnClearWidgetToFocus;

	public Func<IFocusWidget, bool> OnCheckWidgetCanInput;

	public Func<IFocusWidget, bool> OnCheckWidgetCanShow;

	private List<UUserWidget> NeedTickWidgetList = new List<UUserWidget>();

	private List<UUserWidget> AlwayTickWidgetList = new List<UUserWidget>();

	private List<GSMUITickMgr> GSMTickMgrList = new List<GSMUITickMgr>();

	public Action<int> ShowPage;

	public Func<RedPointType, int, bool> IsRedPointExist;

	public Func<int, bool> IsEquipRedPointExist;

	public Func<string, int> PlayUISound;

	public Func<string, int> PlayUISoundNotPersistent;

	public bool ManualUpdatePosRecord;

	private int TickStatID_Tick = -1;

	private int TickStatID_Tick_InnTick_ListPure = -1;

	private int TickStatID_Tick_InnTick_WidgetTick = -1;

	private int TickStatID_Tick_InputTick = -1;

	private int TickStatID_Tick_InnTick = -1;

	private int TickStatID_Tick_TickMgrTick = -1;

	private int TickStatID_Tick_AKBTick = -1;

	private int TickStatID_RefreshText = -1;

	private NativeList<IntPtr> NeedTickWidgetNativeList = new NativeList<IntPtr>(600);

	private NativeList<IntPtr> TargetTickWidgetList = new NativeList<IntPtr>(100);

	private NativeList<IntPtr> AlwayTickWidgetNativeList = new NativeList<IntPtr>(100);

	private BGW_UIEventCollection UIEventCollection;

	private List<UUserWidget> TempWidgetList = new List<UUserWidget>();

	private static uint UniqueReqID_Subtitle;

	private uint CurSubtitleReqID;

	private AActor CurSubtitleSpeaker;

	public MDSBattleMain BattleMainData;

	public UIMgrBlockHelper BlockHelper;

	public override bool bTickEnabled => true;

	public InputAxisPeriod MousePosRecord { get; private set; }

	public FVector2D FocusPos { get; private set; }

	public static BGW_UIMgr Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BGW_UIMgr>(WorldCtx);
	}

	public override void OnInit()
	{
		UIEventCollection = BGW_UIEventCollection.Get(this);
		if (BGW_PreloadAssetMgr.Get(this).ABSPosToUVConfig != null)
		{
			MousePosRecord = new InputAxisPeriod(BGW_PreloadAssetMgr.Get(this).ABSPosToUVConfig.RecordTime);
		}
		InitMDStore();
		TickStatID_Tick = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick");
		TickStatID_Tick_InputTick = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick.InputTick");
		TickStatID_Tick_InnTick = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick.GSInnerTick");
		TickStatID_Tick_TickMgrTick = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick.TickMgrTick");
		TickStatID_Tick_AKBTick = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick.AKBTick");
		TickStatID_RefreshText = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.RefreshText");
		TickStatID_Tick_InnTick_ListPure = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick.GSInnerTick.InListPureM");
		TickStatID_Tick_InnTick_WidgetTick = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_BGW_UIMgr.OnTick.GSInnerTick.WidgetInnerTick");
		NeedTickWidgetNativeList.Clear();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_TriggerViewportResized = (Del_Void_FIntPoint)Delegate.Combine(bGW_EventCollection.Evt_TriggerViewportResized, new Del_Void_FIntPoint(OnTriggerViewportResized));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_TriggerCultureChanged = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_TriggerCultureChanged, new Del_Void(OnTriggerCultureChanged));
		InitBlockHelper();
	}

	private void OnTriggerViewportResized(FIntPoint Size)
	{
		RefeashText();
	}

	private void OnTriggerCultureChanged()
	{
		RefeashText();
	}

	private void RefeashText()
	{
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID_RefreshText);
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		foreach (object @object in UObject.GetObjects<UGSTextBlock>())
		{
			if (@object is UGSTextBlock uGSTextBlock)
			{
				uGSTextBlock.MakeContentDirty();
			}
		}
		foreach (object object2 in UObject.GetObjects<UGSRichTextBlock>())
		{
			if (object2 is UGSRichTextBlock uGSRichTextBlock)
			{
				uGSRichTextBlock.MakeContentDirty();
			}
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
	}

	public override void OnAfterInit()
	{
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		DestoryBlockHelper();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_TriggerViewportResized = (Del_Void_FIntPoint)Delegate.Remove(bGW_EventCollection.Evt_TriggerViewportResized, new Del_Void_FIntPoint(OnTriggerViewportResized));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_TriggerCultureChanged = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_TriggerCultureChanged, new Del_Void(OnTriggerCultureChanged));
		if (SharedRuntimeState.CurrentRuntime == EDotNetRuntime.CoreCLR)
		{
			PlayUISound = null;
			ShowPage = null;
			OnAddWidgetToFocus = null;
			OnClearWidgetToFocus = null;
			OnCheckWidgetCanInput = null;
			BattleMainData = null;
			NeedTickWidgetList = null;
			AlwayTickWidgetList = null;
		}
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		if (DebugConfig.IsDebugUITick)
		{
			for (int i = 0; i < NeedTickWidgetList.Count; i++)
			{
				_ = NeedTickWidgetList[i];
				_ = DebugConfig.IsDebugUITick;
			}
			for (int j = 0; j < NeedTickWidgetNativeList.Length; j++)
			{
				GCHelper.Find<UObject>(NeedTickWidgetNativeList[j]);
				_ = DebugConfig.IsDebugUITick;
			}
			for (int k = 0; k < AlwayTickWidgetList.Count; k++)
			{
				_ = AlwayTickWidgetList[k];
				_ = DebugConfig.IsDebugUITick;
			}
		}
		GSMTickMgrList.Clear();
		NeedTickWidgetList.Clear();
		NeedTickWidgetNativeList.Clear();
		AlwayTickWidgetList.Clear();
		AlwayTickWidgetNativeList.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 256;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (TickGroup != 256)
		{
			return;
		}
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID_Tick);
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		if (!ManualUpdatePosRecord)
		{
			if (DebugConfig.IsOpenStatGSCustom)
			{
				ProfilerFuncLib.BeginSampleWithStatID(TickStatID_Tick_InputTick);
			}
			_ = DebugConfig.UITickProfileLevel;
			_ = 1;
			MousePosRecord.AddInputAxis(DeltaTime, UWidgetLayoutLibrary.GetMousePositionOnPlatform());
			_ = DebugConfig.UITickProfileLevel;
			_ = 1;
			if (DebugConfig.IsOpenStatGSCustom)
			{
				ProfilerFuncLib.EndSample();
			}
		}
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID_Tick_TickMgrTick);
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		DoAllGSMTickMgrTick(DeltaTime);
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID_Tick_InnTick);
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		DoAllGSInnerTick(DeltaTime);
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
	}

	public void UpdatePosRecord(float DelatTime, FVector2D PosRecord)
	{
		if (ManualUpdatePosRecord)
		{
			MousePosRecord.AddInputAxis(DelatTime, PosRecord);
		}
	}

	public void SetFocusPos(FVector2D PosRecord)
	{
		FocusPos = PosRecord;
	}

	public void TempSaveBluprintWidget(UUserWidget temp)
	{
		TempWidgetList.Add(temp);
	}

	public void ActiveTempWidget(bool IsActive)
	{
		foreach (UUserWidget tempWidget in TempWidgetList)
		{
			if (!tempWidget.IsNullOrDestroyed())
			{
				tempWidget.SetVisibility((!IsActive) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
			}
		}
	}

	public static uint RequestNewUniqueID_Subtitle()
	{
		if (UniqueReqID_Subtitle == uint.MaxValue)
		{
			UniqueReqID_Subtitle = 1u;
		}
		else
		{
			UniqueReqID_Subtitle++;
		}
		return UniqueReqID_Subtitle;
	}

	public uint PlaySubtitle(string Name, string Content, float Duration, bool IsSupportSoundDirection = false, AActor SubtitleSpeaker = null, bool IsSupportSkip = false, bool IsInStartPage = false)
	{
		if (UIEventCollection == null)
		{
			return 0u;
		}
		CurSubtitleReqID = RequestNewUniqueID_Subtitle();
		CurSubtitleSpeaker = SubtitleSpeaker;
		if (IsInStartPage)
		{
			UIEventCollection?.Evt_UI_PlayStory_StartPage?.Invoke(Name, Content, Duration, IsSupportSoundDirection, IsSupportSkip);
		}
		else
		{
			UIEventCollection?.Evt_UI_PlayStory?.Invoke(Name, Content, Duration, IsSupportSoundDirection, IsSupportSkip);
		}
		return CurSubtitleReqID;
	}

	public void StopSubtitle(uint SubtitleReqID)
	{
		if (CurSubtitleReqID == SubtitleReqID && !(UIEventCollection == null))
		{
			UIEventCollection?.Evt_UI_SkipStory?.Invoke();
			CurSubtitleSpeaker = null;
		}
	}

	public float GetSubtitleSpeakerDir()
	{
		if (CurSubtitleSpeaker.IsNullOrDestroyed())
		{
			return -2f;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			return -2f;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(CurSubtitleSpeaker);
		FVector2D fVector2D = UWidgetLayoutLibrary.GetViewportSize(this) / UWidgetLayoutLibrary.GetViewportScale(this);
		UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, fVector, out var ScreenPosition, bPlayerViewportRelative: false);
		if (ScreenPosition.X <= 0f || ScreenPosition.Y <= 0f || ScreenPosition.X >= fVector2D.X || ScreenPosition.Y >= fVector2D.Y)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (controlledPawn.IsNullOrDestroyed())
			{
				return -2f;
			}
			APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(this);
			if (localPlayerCameraManager == null)
			{
				return -2f;
			}
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn);
			FVector a = localPlayerCameraManager.GetCameraRotation().GetForwardVector();
			if (fVector2.X == fVector.X && fVector2.Y == fVector.Y)
			{
				return -3f;
			}
			FVector b = fVector - fVector2;
			a.Z = 0f;
			if (a.Size() <= 0f)
			{
				a = localPlayerCameraManager.GetCameraRotation().GetUpVector();
				a.Z = 0f;
			}
			b.Z = 0f;
			a.Normalize();
			b.Normalize();
			float x = FMath.RadiansToDegrees(FMath.Acos(FVector.DotProduct(a, b)));
			x = FMath.Fmod(x, 360f);
			if (x < 0f)
			{
				x += 360f;
			}
			if (a.X * b.Y - a.Y * b.X < 0f)
			{
				x = 360f - x;
			}
			return x;
		}
		return -1f;
	}

	private void InitMDStore()
	{
		BattleMainData = new MDSBattleMain();
	}

	public MDSBattleMain GetMDSBattleMain()
	{
		return BattleMainData;
	}

	public void RegGSMTickMgr(GSMUITickMgr InMTickMgr)
	{
		GSMTickMgrList.Add(InMTickMgr);
	}

	public void UnRegGSMTickMgr(GSMUITickMgr InMTickMgr)
	{
		GSMTickMgrList.Remove(InMTickMgr);
	}

	public void DoAllGSMTickMgrTick(float DeltaTime)
	{
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		for (int i = 0; i < GSMTickMgrList.Count; i++)
		{
			GSMTickMgrList[i].DoGSTicking(DeltaTime);
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		_ = DebugConfig.IsDebugUITick;
	}

	public void RegGSInnerTick(BUI_Widget NeedTickWidget)
	{
		if (NeedTickWidget != null)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			NeedTickWidgetList.Add(NeedTickWidget);
			NeedTickWidgetNativeList.Add(NeedTickWidget.Address);
		}
	}

	public void UnRegGSInnerTick(BUI_Widget NeedTickWidget)
	{
		if (NeedTickWidget != null)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			if (NeedTickWidgetList.Remove(NeedTickWidget))
			{
				NeedTickWidgetNativeList.RemoveKeepOrder(NeedTickWidget.Address);
			}
		}
	}

	public void RegAlwayTick(BUI_Widget NeedTickWidget)
	{
		if (NeedTickWidget != null)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			AlwayTickWidgetList.Add(NeedTickWidget);
			AlwayTickWidgetNativeList.Add(NeedTickWidget.Address);
		}
	}

	public void UnRegAlwayTick(BUI_Widget NeedTickWidget)
	{
		if (NeedTickWidget != null)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			if (AlwayTickWidgetList.Remove(NeedTickWidget))
			{
				AlwayTickWidgetNativeList.RemoveKeepOrder(NeedTickWidget.Address);
			}
		}
	}

	public void DoAllGSInnerTick(float DeltaTime)
	{
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID_Tick_InnTick_ListPure);
		}
		TargetTickWidgetList.Clear();
		_ = DebugConfig.IsDebugUITick;
		UMGQuickFuncLib.IsWidgetVisiableWithParentInListPureM(NeedTickWidgetNativeList.Address, TargetTickWidgetList.Address);
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID_Tick_InnTick_WidgetTick);
		}
		int num = 0;
		for (int i = 0; i < TargetTickWidgetList.Length; i++)
		{
			BUI_Widget bUI_Widget = GCHelper.Find<UObject>(TargetTickWidgetList[i]) as BUI_Widget;
			_ = DebugConfig.IsDebugUITick;
			if (bUI_Widget != null)
			{
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
				bUI_Widget.DoGSInnerTick(DeltaTime);
				num++;
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
			}
		}
		_ = DebugConfig.IsDebugUITick;
		int num2 = 0;
		for (int j = 0; j < AlwayTickWidgetNativeList.Length; j++)
		{
			BUI_Widget bUI_Widget2 = GCHelper.Find<UObject>(AlwayTickWidgetNativeList[j]) as BUI_Widget;
			_ = DebugConfig.IsDebugUITick;
			if (bUI_Widget2 != null)
			{
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
				bUI_Widget2.DoGSInnerTick(DeltaTime);
				num2++;
				_ = DebugConfig.UITickProfileLevel;
				_ = 2;
			}
		}
		_ = DebugConfig.IsDebugUITick;
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
		_ = DebugConfig.UITickProfileLevel;
		_ = 1;
	}

	public void UpdateGrid<T>(List<T> WidgetList, int ColumnNum, int StartColumn = 0, int ColumnSpace = 1) where T : BUI_Widget
	{
		int num = StartColumn;
		int num2 = 0;
		foreach (T Widget in WidgetList)
		{
			if (Widget.Slot is UGridSlot)
			{
				SetRowColumn(Widget.Slot as UGridSlot, num2, num);
			}
			else
			{
				if (!(Widget.Slot is UUniformGridSlot))
				{
					continue;
				}
				SetRowColumn(Widget.Slot as UUniformGridSlot, num2, num);
			}
			num += ColumnSpace;
			if (num >= ColumnNum && ColumnNum != -1)
			{
				num = 0;
				num2++;
			}
		}
	}

	private void SetRowColumn(UGridSlot Slot, int Row, int Column)
	{
		if (Slot != null)
		{
			Slot.SetRow(Row);
			Slot.SetColumn(Column);
		}
	}

	private void SetRowColumn(UUniformGridSlot Slot, int Row, int Column)
	{
		if (Slot != null)
		{
			Slot.SetRow(Row);
			Slot.SetColumn(Column);
		}
	}

	public void InitBlockHelper()
	{
		BlockHelper = new UIMgrBlockHelper();
	}

	public void DestoryBlockHelper()
	{
	}

	public void ResetBlock()
	{
		BlockHelper.Reset();
	}

	public void RegWaitAnimShowPage(int PageId)
	{
		BlockHelper.RegWaitAnimShowPage(PageId);
	}

	public void RemoveWaitAnimShowPage(int PageId)
	{
		BlockHelper.RemoveWaitAnimShowPage(PageId);
	}

	public bool GetIsWaitAnimShow(int PageId)
	{
		return BlockHelper.GetIsWaitAnimShow(PageId);
	}

	public void SetWaitNet(bool InIsWaitNet)
	{
		BlockHelper.SetWaitNet(InIsWaitNet);
	}

	public void SetBlockInput(bool InIsBlockInput)
	{
		BlockHelper.SetBlockInput(InIsBlockInput);
	}

	public void SetUseWhiteList(bool InUseWhiteList, List<GSUIActionEn> WhiteList)
	{
		if (InUseWhiteList)
		{
			BlockHelper.SetInputWhiteList(WhiteList);
		}
		else
		{
			BlockHelper.SetInputWhiteList(null);
		}
		BlockHelper.SetUseWhiteList(InUseWhiteList);
	}

	public bool GetCanInput()
	{
		return BlockHelper.GetCanInput();
	}

	public string GetBlockInputReason()
	{
		return BlockHelper.GetBlockInputReason();
	}

	public bool CheckInputWithWhiteList(GSUIActionEn UIAction)
	{
		return BlockHelper.CheckInputWithWhiteList(UIAction);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_UIMgr");
	}

	static BGW_UIMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_UIMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_UIMgr));
	}
}
