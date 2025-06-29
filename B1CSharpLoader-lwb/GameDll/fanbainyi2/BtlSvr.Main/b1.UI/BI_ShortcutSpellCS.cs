using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using BtlB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutSpellCS")]
public class BI_ShortcutSpellCS : BI_ShortcutCommCS
{
	public List<BI_ShortcutBaseCS> KeyboardSpellList = new List<BI_ShortcutBaseCS>();

	public List<BI_ShortcutBaseCS> GamepadSpellList = new List<BI_ShortcutBaseCS>();

	private bool IsNeedShow;

	private int BindIdx;

	private static bool IsInTrans_IsValid;

	private static int IsInTrans_Offset;

	private static FFieldAddress IsInTrans_PropertyAddress;

	[BlueprintReadWrite]
	[Category("GSProperty")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("自身是否为变身UI子UI")]
	[USharpPath("/Script/b1-Managed.BI_ShortcutSpellCS:IsInTrans")]
	public bool IsInTrans
	{
		get
		{
			CheckDestroyed();
			if (!IsInTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutSpellCS:IsInTrans");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInTrans_Offset), 0, IsInTrans_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutSpellCS:IsInTrans");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInTrans_Offset), 0, IsInTrans_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		for (int i = 0; (float)i < MaxShortcutNum; i++)
		{
			BI_ShortcutBaseCS bI_ShortcutBaseCS = FindChildWidget($"Skill{i + 1}_KB") as BI_ShortcutBaseCS;
			KeyboardSpellList.Add(bI_ShortcutBaseCS);
			bI_ShortcutBaseCS.SyncImgList.Add(FindChildWidget($"IAIcon{i + 1}_KB") as UImage);
			BI_ShortcutBaseCS bI_ShortcutBaseCS2 = FindChildWidget($"Skill{i + 1}_GP") as BI_ShortcutBaseCS;
			GamepadSpellList.Add(bI_ShortcutBaseCS2);
			bI_ShortcutBaseCS2.SyncImgList.Add(FindChildWidget($"IAIcon{i + 1}_GP") as UImage);
			TxtNameDic.Add(bI_ShortcutBaseCS2.CurPosIdx, FindChildWidget($"TxtName{i + 1}_GP") as UTextBlock);
		}
		if (IsInTrans)
		{
			DS_IBUC_PlayerSpellConfData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor);
			if (battleData != null)
			{
				BindIdx = battleData.BindCurrentTransFormIDChange(OnBindCurrentTransFormIDChange);
			}
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
		foreach (FUStMagicConfInfo item in battleData.MagicConfInfo)
		{
			int num = shortcutSpellList.FindIndex((SpellType r) => r == item.Type);
			if (num != -1)
			{
				UpdateShortcutContent(num, item.SpellID);
			}
		}
		UpdateVisibility();
	}

	public void OnShowState(bool IsShow)
	{
		if (IsInTrans)
		{
			if (IsShow)
			{
				UpdateSpellList();
			}
		}
		else if (IsShow)
		{
			foreach (BI_ShortcutBaseCS item in GetAllShortcutBySpellType(SpellType.BianShen))
			{
				item.ForceUpdateEnergy();
			}
			UpdateVisibility();
		}
		else
		{
			IsNeedShow = false;
			SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public void UpdateVisibility()
	{
		if ((!BattleMainData.IsTrans || !IsInTrans) && (BattleMainData.IsTrans || IsInTrans))
		{
			return;
		}
		IsNeedShow = false;
		foreach (BI_ShortcutBaseCS keyboardSpell in KeyboardSpellList)
		{
			if (keyboardSpell.GetBaseID() != 0)
			{
				IsNeedShow = true;
				break;
			}
		}
		SetVisibility((!IsNeedShow) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public void ForceVisibility(bool IsShow)
	{
		SetVisibility((!IsShow) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public void UpdateShortcutContent(int PosIdx, int NewValue)
	{
		foreach (BI_ShortcutBaseCS keyboardSpell in KeyboardSpellList)
		{
			if (keyboardSpell.CurPosIdx == PosIdx)
			{
				keyboardSpell.UpdateNormal(NewValue);
			}
		}
		foreach (BI_ShortcutBaseCS gamepadSpell in GamepadSpellList)
		{
			if (gamepadSpell.CurPosIdx == PosIdx)
			{
				gamepadSpell.UpdateNormal(NewValue);
			}
		}
		UpdateVisibility();
		UpdateDesc(PosIdx, NewValue);
	}

	public BI_ShortcutBaseCS GetShortcutBySpellType(SpellType TargeType)
	{
		int num = BattleMainData.ShortcutSpellList.FindIndex((SpellType r) => r == TargeType);
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
		{
			foreach (BI_ShortcutBaseCS gamepadSpell in GamepadSpellList)
			{
				if (gamepadSpell.CurPosIdx == num)
				{
					return gamepadSpell;
				}
			}
		}
		else if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
		{
			foreach (BI_ShortcutBaseCS keyboardSpell in KeyboardSpellList)
			{
				if (keyboardSpell.CurPosIdx == num)
				{
					return keyboardSpell;
				}
			}
		}
		return null;
	}

	public List<BI_ShortcutBaseCS> GetAllShortcutBySpellType(SpellType TargeType)
	{
		List<BI_ShortcutBaseCS> list = new List<BI_ShortcutBaseCS>();
		int num = BattleMainData.ShortcutSpellList.FindIndex((SpellType r) => r == TargeType);
		foreach (BI_ShortcutBaseCS gamepadSpell in GamepadSpellList)
		{
			if (gamepadSpell.CurPosIdx == num)
			{
				list.Add(gamepadSpell);
				break;
			}
		}
		foreach (BI_ShortcutBaseCS keyboardSpell in KeyboardSpellList)
		{
			if (keyboardSpell.CurPosIdx == num)
			{
				list.Add(keyboardSpell);
				break;
			}
		}
		return list;
	}

	public void OnChangeShortcutType(EnShortcutType ShortcutType)
	{
		foreach (BI_ShortcutBaseCS gamepadSpell in GamepadSpellList)
		{
			gamepadSpell.OnChangeShortcutType(ShortcutType);
		}
		foreach (BI_ShortcutBaseCS keyboardSpell in KeyboardSpellList)
		{
			keyboardSpell.OnChangeShortcutType(ShortcutType);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		if (IsInTrans)
		{
			B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PlayerSpellConfData>(B1ActorTag.CurPlayerActor)?.UnBindCurrentTransFormIDChange(BindIdx, OnBindCurrentTransFormIDChange);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutSpellCS");
		NativeReflection.GetPropertyRef(ref IsInTrans_PropertyAddress, unrealStruct, "IsInTrans");
		IsInTrans_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsInTrans");
		IsInTrans_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsInTrans", Classes.FBoolProperty);
	}

	static BI_ShortcutSpellCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutSpellCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutSpellCS));
	}
}
