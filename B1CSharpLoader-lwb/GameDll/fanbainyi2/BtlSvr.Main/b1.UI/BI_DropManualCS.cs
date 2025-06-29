using System;
using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using CommB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropManualCS")]
public class BI_DropManualCS : BI_DropAdvanceCS
{
	private BGW_UIMgr UIMgr;

	private BI_DropMiddleItemCS DropMiddleItem;

	private UTextBlock TxtName;

	private UTextBlock TxtSubName;

	private TravelNotesOne CurShowData;

	private List<TravelNotesOne> TravelNotesList = new List<TravelNotesOne>();

	public Action<ETravelNotesTabType, int> Evt_JumpCollection;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ShowType = DropAdvanceType.Manual;
		UIMgr = BGW_UIMgr.Get(this);
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		ShowTime = uIConfigDataAsset.DropManualShowTime;
		MinShowTime = uIConfigDataAsset.DropManualShowTime;
		ShowTimeCheck = ShowTime;
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		TxtSubName = FindChildWidget("TxtSubDecs") as UTextBlock;
	}

	public void SetDropAdvanceItem(BI_DropMiddleItemCS Item)
	{
		DropMiddleItem = Item;
	}

	public override void CheckData()
	{
		if (TravelNotesList.Count == 0)
		{
			return;
		}
		for (int num = TravelNotesList.Count - 1; num >= 0; num--)
		{
			TravelNotesOne travelNotesOne = TravelNotesList[num];
			RedPointType arg = RedPointType.MonsterCollection;
			switch (travelNotesOne.Type)
			{
			case ETravelNotesTabType.MonsterCollection:
				arg = RedPointType.MonsterCollection;
				break;
			case ETravelNotesTabType.Meditation:
				arg = RedPointType.Meditation;
				break;
			}
			if (UIMgr.IsRedPointExist != null && !UIMgr.IsRedPointExist(arg, travelNotesOne.ID))
			{
				TravelNotesList.RemoveAt(num);
			}
		}
	}

	public override int GetDataCount()
	{
		return TravelNotesList.Count;
	}

	public void AddTravelNotes(TravelNotesOne OneData)
	{
		DS_IBPC_PlayerInteractData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_PlayerInteractData>(B1ActorTag.LocalPlayerState);
		if ((battleData == null || (battleData.InteractActionDesc != null && battleData.InteractActionDesc.InteractAction == EInteractAction.Echo) || !battleData.IsInInteraction()) && !TravelNotesList.Contains(OneData))
		{
			if (TravelNotesList.Count == 0 && ShowState != EnShowState.Show)
			{
				ShowTimeCheck = FirstShowDelayTime;
			}
			TravelNotesList.Add(OneData);
		}
	}

	protected override void DoRefresh()
	{
		if (DropMiddleItem != null && DropMiddleItem.GetDataCount() > 0)
		{
			DoShowOut();
		}
		else
		{
			base.DoRefresh();
		}
	}

	protected override void UpdateContent()
	{
		if (TravelNotesList.Count != 0)
		{
			UIMgr.PlayUISound("EVT_ui_hud_hint_travelnote_drop");
			CurShowData = TravelNotesList[0];
			TxtName.SetText(CurShowData.TextName);
			TxtSubName.SetText(CurShowData.TextSubName);
			TravelNotesList.RemoveAt(0);
			ShowTimeCheck = ShowTime;
		}
	}

	public void CloseManual()
	{
		StopAllAnimations();
		TravelNotesList.Clear();
		DoShowOut();
	}

	protected override void OnJump()
	{
		base.OnJump();
		Evt_JumpCollection?.Invoke(CurShowData.Type, CurShowData.ID);
	}

	protected override bool CanShow()
	{
		if (!base.CanShow())
		{
			return false;
		}
		if (DropMiddleItem != null)
		{
			if (DropMiddleItem.GetDataCount() > 0)
			{
				return false;
			}
			return !DropMiddleItem.GetIsShow();
		}
		return false;
	}

	public override void Reset()
	{
		base.Reset();
		TravelNotesList.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropManualCS");
	}

	static BI_DropManualCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropManualCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropManualCS));
	}
}
