using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TransShortcutSpellCS")]
public class BI_TransShortcutSpellCS : BI_ShortcutCommCS
{
	private BI_ShortcutBaseCS ShortcutA;

	private BI_ShortcutBaseCS ShortcutB;

	private BI_ShortcutBaseCS ShortcutC;

	private BI_ShortcutBaseCS ShortcutD;

	private BI_ShortcutBaseCS ShortcutTop;

	private BI_ShortcutBaseCS ShortcutRight;

	private BI_ShortcutBaseCS ShortcutDown;

	private BI_ShortcutBaseCS ShortcutLeft;

	private List<BI_ShortcutBaseCS> ShortcutList = new List<BI_ShortcutBaseCS>();

	private int BindIdx;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ShortcutA = FindChildWidget("SkillA_KB") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutA);
		ShortcutB = FindChildWidget("SkillB_KB") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutB);
		ShortcutC = FindChildWidget("SkillC_KB") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutC);
		ShortcutD = FindChildWidget("SkillD_KB") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutD);
		ShortcutTop = FindChildWidget("SkillTopGP") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutTop);
		ShortcutRight = FindChildWidget("SkillRightGP") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutRight);
		ShortcutDown = FindChildWidget("SkillDownGP") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutDown);
		ShortcutLeft = FindChildWidget("SkillLeftGP") as BI_ShortcutBaseCS;
		ShortcutList.Add(ShortcutLeft);
		TxtNameDic.Add(ShortcutTop.CurPosIdx, FindChildWidget("TxtNameTop") as UTextBlock);
		TxtNameDic.Add(ShortcutRight.CurPosIdx, FindChildWidget("TxtNameRight") as UTextBlock);
		TxtNameDic.Add(ShortcutDown.CurPosIdx, FindChildWidget("TxtNameDown") as UTextBlock);
		TxtNameDic.Add(ShortcutLeft.CurPosIdx, FindChildWidget("TxtNameLeft") as UTextBlock);
		DS_IBUC_PlayerSpellConfData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor);
		if (battleData != null)
		{
			BindIdx = battleData.BindCurrentTransFormIDChange(OnBindCurrentTransFormIDChange);
		}
	}

	private void OnBindCurrentTransFormIDChange(int OldValue, int NewValue)
	{
		UpdateSpellList();
	}

	private void UpdateSpellList()
	{
		List<SpellType> shortcutSpellList = BattleMainData.ShortcutSpellList;
		DS_IBUC_PlayerSpellConfData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor);
		if (battleData == null)
		{
			return;
		}
		bool flag = true;
		foreach (FUStMagicConfInfo item in battleData.MagicConfInfo)
		{
			switch (shortcutSpellList.FindIndex((SpellType r) => r == item.Type))
			{
			case 0:
				OnChangeShortcut1(item.SpellID);
				break;
			case 1:
				OnChangeShortcut2(item.SpellID);
				break;
			case 2:
				OnChangeShortcut3(item.SpellID);
				break;
			case 3:
				OnChangeShortcut4(item.SpellID);
				break;
			case -1:
				continue;
			}
			if (flag)
			{
				flag = item.SpellID == 0;
			}
		}
		if (flag)
		{
			SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow)
		{
			UpdateSpellList();
		}
	}

	private void OnChangeShortcut1(int NewValue)
	{
		int num = 0;
		foreach (BI_ShortcutBaseCS shortcut in ShortcutList)
		{
			if (shortcut.CurPosIdx == num)
			{
				shortcut.UpdateNormal(NewValue);
			}
		}
		UpdateDesc(num, NewValue);
	}

	private void OnChangeShortcut2(int NewValue)
	{
		int num = 1;
		foreach (BI_ShortcutBaseCS shortcut in ShortcutList)
		{
			if (shortcut.CurPosIdx == num)
			{
				shortcut.UpdateNormal(NewValue);
			}
		}
		UpdateDesc(num, NewValue);
	}

	private void OnChangeShortcut3(int NewValue)
	{
		int num = 2;
		foreach (BI_ShortcutBaseCS shortcut in ShortcutList)
		{
			if (shortcut.CurPosIdx == num)
			{
				shortcut.UpdateNormal(NewValue);
			}
		}
		UpdateDesc(num, NewValue);
	}

	private void OnChangeShortcut4(int NewValue)
	{
		int num = 3;
		foreach (BI_ShortcutBaseCS shortcut in ShortcutList)
		{
			if (shortcut.CurPosIdx == num)
			{
				shortcut.UpdateNormal(NewValue);
			}
		}
		UpdateDesc(num, NewValue);
	}

	private int GetSpellIDByType(SpellType TargetType)
	{
		DS_IBUC_PlayerSpellConfData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor);
		if (battleData == null)
		{
			return 0;
		}
		foreach (FUStMagicConfInfo item in battleData.MagicConfInfo)
		{
			if (item.Type == TargetType)
			{
				return item.SpellID;
			}
		}
		return 0;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor)?.UnBindCurrentTransFormIDChange(BindIdx, OnBindCurrentTransFormIDChange);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TransShortcutSpellCS");
	}

	static BI_TransShortcutSpellCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TransShortcutSpellCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TransShortcutSpellCS));
	}
}
