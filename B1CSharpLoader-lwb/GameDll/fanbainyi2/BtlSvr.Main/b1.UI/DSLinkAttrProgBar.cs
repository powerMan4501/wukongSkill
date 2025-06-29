using System.Collections.Generic;
using b1.Localization;
using BtlShare;
using ResB1;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DSLinkAttrProgBar : DSProgBarInfo
{
	protected EBGUAttrFloat AttrFloat;

	protected EBGUAttrFloat AttrFloatMax;

	protected int GroupId;

	public readonly GSBindProp<FText> Name = new GSBindProp<FText>();

	public readonly Dictionary<string, UnitBarInfoBindData> BarInfoDataDic = new Dictionary<string, UnitBarInfoBindData>();

	private bool IsInitFinish;

	public DSLinkAttrProgBar(BUI_Widget BindWidget)
		: base(BindWidget)
	{
	}

	public override void Clear()
	{
		base.Clear();
		foreach (UnitBarInfoBindData value in BarInfoDataDic.Values)
		{
			value.GSOnDestruct();
		}
		BarInfoDataDic.Clear();
	}

	public bool IncludeUnit(string Guid)
	{
		LinkBloodDesc linkBloodDesc = GameDBRuntime.GetLinkBloodDesc(GroupId);
		if (linkBloodDesc != null && linkBloodDesc.Guid.Contains(Guid))
		{
			return true;
		}
		return false;
	}

	public bool NeedHide()
	{
		foreach (UnitBarInfoBindData value in BarInfoDataDic.Values)
		{
			if (value.GetCanShow())
			{
				return false;
			}
		}
		return true;
	}

	public void Init(EBGUAttrFloat InAttrFloat, EBGUAttrFloat InAttrFloatMax, int InGroupId)
	{
		AttrFloat = InAttrFloat;
		AttrFloatMax = InAttrFloatMax;
		GroupId = InGroupId;
		UpdateBindUnit();
		UpdateBlood(EChangeReason.Init);
	}

	private void OnAttrChanged()
	{
		UpdateBlood(EChangeReason.ManualSet);
	}

	public void UpdateBindUnit()
	{
		LinkBloodDesc linkBloodDesc = GameDBRuntime.GetLinkBloodDesc(GroupId);
		if (linkBloodDesc == null)
		{
			return;
		}
		foreach (string item in linkBloodDesc.Guid)
		{
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(GetWorldContext(), item) as BGUCharacterCS;
			if (bGUCharacterCS != null && !BarInfoDataDic.ContainsKey(item))
			{
				BarInfoDataDic.Add(item, new UnitBarInfoBindData(this, item, bGUCharacterCS, OnAttrChanged));
			}
		}
		SetName(linkBloodDesc.GroupName.ToFText());
	}

	public void UpdateBlood(EChangeReason Reason)
	{
		if (!IsInitFinish)
		{
			foreach (UnitBarInfoBindData value in BarInfoDataDic.Values)
			{
				if (!value.GetCanShow())
				{
					SetValue(EChangeReason.Init, 1f);
					SetMaxValue(EChangeReason.Init, 1f);
					return;
				}
			}
			IsInitFinish = true;
		}
		float num = 0f;
		foreach (UnitBarInfoBindData value2 in BarInfoDataDic.Values)
		{
			num += value2.GetValue();
		}
		SetValue(Reason, num);
		float num2 = 0f;
		foreach (UnitBarInfoBindData value3 in BarInfoDataDic.Values)
		{
			num2 += value3.GetMaxValue();
		}
		SetMaxValue(Reason, num2);
	}

	public override void UpdateIsShow()
	{
		bool value = CanShow.Value && !NeedHide();
		IsShow.SetValue(EChangeReason.ManualSet, value);
	}

	public void SetName(FText InName)
	{
		Name.SetValue(EChangeReason.ManualSet, InName);
	}

	protected override void OnDestructImpl()
	{
		Clear();
		base.OnDestructImpl();
	}
}
