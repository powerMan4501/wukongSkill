using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUI.GSWidget;
using BtlShare;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_GourdCS")]
public class BI_GourdCS : BUI_Widget
{
	private readonly int GourdSlotMaxNum = 4;

	private BGW_UIMgr UIMgr;

	private DS_IBUC_AttrContainer AttrContainer;

	private IProcBar HealGourdBar;

	private UCanvasPanel GourdSlotCon;

	private List<BI_GourdSlotCS> GourdSlotList = new List<BI_GourdSlotCS>();

	private UWidgetAnimation HealGourdWaveAnim;

	private int NumBindIdx;

	private bool NeedWineTips = true;

	private bool IsShowDDBInput;

	private float ShowDDBInputPre;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ShowDDBInputPre = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.DBBInputHPPre;
		UIMgr = BGW_UIMgr.Get(this);
		B1ActorTag actorTag = B1ActorTag.CurPlayerActor;
		AttrContainer = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(actorTag);
		UCanvasPanel uCanvasPanel = FindChildWidget("HealGourdBarCon") as UCanvasPanel;
		if (uCanvasPanel != null)
		{
			HealGourdBar = FindAndConstructIProcBar(uCanvasPanel, "HealGourdBar");
			if (AttrContainer != null)
			{
				NumBindIdx = AttrContainer.BindFloatAttrsOnSetIdxValue(OnBindOnSetIdxValueChange);
			}
			HealGourdWaveAnim = FindWidgetAnimation("HealGourdWave");
			GSAnimKeyToState("AKBHealingWarn", "Hide", IsForce: true);
			HeroBloodBottomChange(IsImmediately: true);
		}
		GourdSlotCon = FindChildWidget("GourdSlotCon") as UCanvasPanel;
		GourdSlotCon.SetVisibility(ESlateVisibility.Collapsed);
		GourdSlotList.Clear();
		for (int i = 0; i < GourdSlotMaxNum; i++)
		{
			GourdSlotList.Add(FindChildWidget($"GourdSlot_{i}") as BI_GourdSlotCS);
		}
	}

	public void OnChangeGourdSlotCount(int NewValue, bool IsForce = false)
	{
		switch (NewValue)
		{
		case 0:
			GSAnimKeyToState("AKBGourdSlotCount", "Empty", IsForce);
			break;
		case 1:
			GSAnimKeyToState("AKBGourdSlotCount", "One", IsForce);
			break;
		case 2:
			GSAnimKeyToState("AKBGourdSlotCount", "Two", IsForce);
			break;
		case 3:
			GSAnimKeyToState("AKBGourdSlotCount", "Three", IsForce);
			break;
		case 4:
			GSAnimKeyToState("AKBGourdSlotCount", "Four", IsForce);
			break;
		}
	}

	public void UpdateGourdConVisibility(ESlateVisibility SlateVisibility)
	{
		GourdSlotCon.SetVisibility(SlateVisibility);
	}

	public void UpdateGourdSlot(List<int> ItemIDs)
	{
		int count = ItemIDs.Count;
		for (int i = 0; i < count; i++)
		{
			if (i < GourdSlotList.Count)
			{
				GourdSlotList[i].UpdateItemID(ItemIDs[i]);
			}
		}
		OnChangeGourdSlotCount(count);
	}

	private void OnHeroBloodBottomChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		HeroBloodBottomChange();
	}

	private void HeroBloodBottomChange(bool IsImmediately = false)
	{
		if (AttrContainer == null)
		{
			return;
		}
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.BloodBottomNum);
		float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.BloodBottomNumMax);
		if (floatValue2 <= 0f)
		{
			return;
		}
		float num = FMath.Clamp(floatValue / floatValue2, 0f, 1f);
		if (!NeedWineTips && num > 0.2f)
		{
			NeedWineTips = true;
		}
		if (!IsImmediately)
		{
			UIMgr.GetMDSBattleMain().TriggerShowState(EnMainShowState.SHOW);
		}
		HealGourdBar.SetValue(num, IsImmediately);
		if (!IsImmediately)
		{
			PlayAnimation(HealGourdWaveAnim);
		}
		foreach (BI_GourdSlotCS gourdSlot in GourdSlotList)
		{
			if (gourdSlot.GetItemID() != 0)
			{
				gourdSlot.PlayAnimCost();
			}
		}
		float floatValue3 = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
		OnHeroHpChange(floatValue3, floatValue3, IsImmediately);
	}

	private void OnHeroHpChange(float OldValue, float NewValue, bool IsImmediately = false)
	{
		if (AttrContainer != null && !UIMgr.GetMDSBattleMain().IsTrans)
		{
			float floatValMax = AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp);
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.BloodBottomNum);
			bool flag = NewValue / floatValMax <= ShowDDBInputPre && floatValue > 0f;
			if (!IsShowDDBInput && flag)
			{
				GSAnimKeyToState("AKBHealingWarn", "Show", IsImmediately);
				IsShowDDBInput = true;
			}
			if (IsShowDDBInput && !flag)
			{
				GSAnimKeyToState("AKBHealingWarn", "Hide", IsImmediately);
				IsShowDDBInput = false;
			}
		}
	}

	private void OnBindOnSetIdxValueChange(int AttrId, float OldValue, float NewValue)
	{
		if (186 == AttrId)
		{
			OnHeroBloodBottomChange(EBGUAttrFloat.BloodBottomNum, OldValue, NewValue);
		}
		else if (36 == AttrId)
		{
			OnHeroBloodBottomChange(EBGUAttrFloat.BloodBottomNumMax, OldValue, NewValue);
		}
		else if (151 == AttrId)
		{
			OnHeroHpChange(OldValue, NewValue);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		if (AttrContainer != null)
		{
			AttrContainer.UnBindFloatAttrsOnSetIdxValue(NumBindIdx, OnBindOnSetIdxValueChange);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_GourdCS");
	}

	static BI_GourdCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_GourdCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_GourdCS));
	}
}
