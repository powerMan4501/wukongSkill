using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_SimAbnormalStateAccBoxCS")]
public class BI_SimAbnormalStateAccBoxCS : BUI_Widget
{
	protected DS_IBUC_AbnormalStateData AbnormalStateData;

	protected Dictionary<EAbnormalStateType, BI_AbnormalStateItemCS> StateItemDic = new Dictionary<EAbnormalStateType, BI_AbnormalStateItemCS>();

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		foreach (EAbnormalStateType value in Enum.GetValues(typeof(EAbnormalStateType)))
		{
			BI_AbnormalStateItemCS bI_AbnormalStateItemCS = FindChildWidget($"State_{value}") as BI_AbnormalStateItemCS;
			if (bI_AbnormalStateItemCS != null)
			{
				bI_AbnormalStateItemCS.SetAbnormalStateType(value);
				StateItemDic.Add(value, bI_AbnormalStateItemCS);
			}
		}
	}

	public void UpdateUnitInfo(BGUCharacterCS CharacterActor)
	{
		AbnormalStateData = B1GSUIActorMgr.Get(this).GetBattleDataByActor<DS_IBUC_AbnormalStateData>(CharacterActor);
		foreach (KeyValuePair<EAbnormalStateType, BI_AbnormalStateItemCS> item in StateItemDic)
		{
			item.Value.UpdateUnitInfo(CharacterActor);
		}
		BindStateEvent();
	}

	private void BindStateEvent()
	{
		ReleaseBindAction();
		if (AbnormalStateData != null)
		{
			GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> abnormalStateUIInfoDic = AbnormalStateData.AbnormalStateUIInfoDic;
			BindDicToOnAdd(abnormalStateUIInfoDic, OnAbnormalStateDicAdd);
			BindDicToOnRemove(abnormalStateUIInfoDic, OnAbnormalStateDicRemove);
			return;
		}
		foreach (BI_AbnormalStateItemCS value in StateItemDic.Values)
		{
			value.ReleaseBindAction();
			value.ShowOut();
			value.SetGSTickTypeFromPageUI(EGSTickType.NeverGSTick);
		}
	}

	private void OnAbnormalStateDicAdd(EAbnormalStateType Key, FAbnormalStateUIInfo Value)
	{
		if (StateItemDic.TryGetValue(Key, out var value))
		{
			value.BindDataStore(Value);
			value.ShowIn();
			value.SetGSTickTypeFromPageUI(EGSTickType.AutoGSTick);
		}
	}

	private void OnAbnormalStateDicRemove(EAbnormalStateType Key, FAbnormalStateUIInfo Value)
	{
		if (StateItemDic.TryGetValue(Key, out var value))
		{
			value.ReleaseBindAction();
			value.ShowOut();
			value.SetGSTickTypeFromPageUI(EGSTickType.NeverGSTick);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_SimAbnormalStateAccBoxCS");
	}

	static BI_SimAbnormalStateAccBoxCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_SimAbnormalStateAccBoxCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_SimAbnormalStateAccBoxCS));
	}
}
