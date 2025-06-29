using System;
using System.Collections.Generic;
using b1;
using b1.UI;
using BtlShare;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace B1UI.GSUI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_UnitBarListCS")]
public class BI_UnitBarListCS : BUI_Widget
{
	private FName MatParamProgCount = B1GlobalFNames.ProgCount;

	private BGW_UIMgr UIMgr;

	private UImage ProgBar;

	private List<BI_UnitBarCS> EliteBloodList;

	private List<BI_UnitBarCS> BossBloodList;

	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	private int BarListLimit = 3;

	private Dictionary<string, DSProgBarInfo> ProgBarInfoDic = new Dictionary<string, DSProgBarInfo>();

	private List<DSLinkAttrProgBar> LinkBloodDSList = new List<DSLinkAttrProgBar>();

	private UWidgetAnimation AnimBossHide;

	private UWidgetAnimation AnimBossShow;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		ProgBar = FindChildWidget("ProgBar_BossHp") as UImage;
		AnimBossShow = FindWidgetAnimation("AnimBossShow");
		AnimBossHide = FindWidgetAnimation("AnimBossHide");
		ProgBar.SetVisibility(ESlateVisibility.Hidden);
		EliteBloodList = new List<BI_UnitBarCS>();
		BossBloodList = new List<BI_UnitBarCS>();
		for (int i = 0; i < BarListLimit; i++)
		{
			BI_UnitBarCS item = FindChildWidget($"BI_EliteBar_{i + 1}") as BI_UnitBarCS;
			EliteBloodList.Add(item);
			BI_UnitBarCS item2 = FindChildWidget($"BI_BossBar_{i + 1}") as BI_UnitBarCS;
			BossBloodList.Add(item2);
		}
		BindUnitBarInfoData(this);
		bool isVisibility = BGW_SettingFuncUtil.GetSettingIntValueByType(this, UISettingConfigType.BossBar) == 1;
		UpdateVisibility(isVisibility);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_SettingValueChanged = (BGW_UIEventCollection.Del_UI_SettingValue)Delegate.Combine(bGW_UIEventCollection.Evt_SettingValueChanged, new BGW_UIEventCollection.Del_UI_SettingValue(SettingValueChange));
		}
	}

	public void BindUnitBarInfoData(UObject WorldContext)
	{
		BattleMainInfoData = B1GSUIActorMgr.Get(WorldContext).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		if (BattleMainInfoData != null)
		{
			BattleMainInfoData.BossBarInfo.OnAdd += BossBarAdd;
			BattleMainInfoData.BossBarInfo.OnRemove += BossRemove;
			GSBindList<UnitBarInfo> bossBarInfo = BattleMainInfoData.BossBarInfo;
			bossBarInfo.OnClear = (Action)Delegate.Combine(bossBarInfo.OnClear, new Action(BossBarClear));
			BattleMainInfoData.EliteBarInfo.OnAdd += EliteBarAdd;
			BattleMainInfoData.EliteBarInfo.OnRemove += EliteBarRemove;
			GSBindList<UnitBarInfo> eliteBarInfo = BattleMainInfoData.EliteBarInfo;
			eliteBarInfo.OnClear = (Action)Delegate.Combine(eliteBarInfo.OnClear, new Action(EliteBarClear));
		}
	}

	public void UnBindUnitBarInfoData(UObject WorldContext)
	{
		BattleMainInfoData = B1GSUIActorMgr.Get(WorldContext).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		if (BattleMainInfoData != null)
		{
			BattleMainInfoData.BossBarInfo.OnAdd -= BossBarAdd;
			BattleMainInfoData.BossBarInfo.OnRemove -= BossRemove;
			GSBindList<UnitBarInfo> bossBarInfo = BattleMainInfoData.BossBarInfo;
			bossBarInfo.OnClear = (Action)Delegate.Remove(bossBarInfo.OnClear, new Action(BossBarClear));
			BattleMainInfoData.EliteBarInfo.OnAdd -= EliteBarAdd;
			BattleMainInfoData.EliteBarInfo.OnRemove -= EliteBarRemove;
			GSBindList<UnitBarInfo> eliteBarInfo = BattleMainInfoData.EliteBarInfo;
			eliteBarInfo.OnClear = (Action)Delegate.Remove(eliteBarInfo.OnClear, new Action(EliteBarClear));
		}
	}

	private void EliteBarAdd(UnitBarInfo BarInfo)
	{
		UpdataUnitBarInfo(BattleMainInfoData.EliteBarInfo, EliteBloodList);
	}

	private void EliteBarRemove(int Index, UnitBarInfo BarInfo)
	{
		RemoveBar(BarInfo.UnitGuid);
		UpdateProgCount(BattleMainInfoData.EliteBarInfo);
	}

	private void EliteBarClear()
	{
		ClearBar();
		UpdateProgCount(new GSBindList<UnitBarInfo>());
	}

	private void BossBarAdd(UnitBarInfo BarInfo)
	{
		ProgBar.SetVisibility(ESlateVisibility.Visible);
		if (BattleMainInfoData.BossBarInfo.Count <= 1)
		{
			PlayWidgetAnimation(AnimBossShow);
		}
		UpdataUnitBarInfo(BattleMainInfoData.BossBarInfo, BossBloodList);
	}

	private void BossRemove(int Index, UnitBarInfo BarInfo)
	{
		if (BattleMainInfoData.BossBarInfo.Count == 0)
		{
			PlayWidgetAnimation(AnimBossHide);
		}
		RemoveBar(BarInfo.UnitGuid);
		UpdataUnitBarInfo(BattleMainInfoData.BossBarInfo, BossBloodList);
		UpdateProgCount(BattleMainInfoData.BossBarInfo);
	}

	private void BossBarClear()
	{
		ClearBar();
		UpdateProgCount(new GSBindList<UnitBarInfo>());
	}

	private void RemoveBar(string Guid)
	{
		if (ProgBarInfoDic.TryGetValue(Guid, out var value))
		{
			value.Clear();
			value.Stop();
			ProgBarInfoDic.Remove(Guid);
		}
		for (int num = LinkBloodDSList.Count - 1; num >= 0; num--)
		{
			DSLinkAttrProgBar dSLinkAttrProgBar = LinkBloodDSList[num];
			if (dSLinkAttrProgBar.NeedHide())
			{
				dSLinkAttrProgBar.Clear();
				dSLinkAttrProgBar.Stop();
				LinkBloodDSList.RemoveAt(num);
			}
			else
			{
				dSLinkAttrProgBar.UpdateBindUnit();
				dSLinkAttrProgBar.UpdateBlood(EChangeReason.ManualSet);
			}
		}
	}

	private void ClearBar()
	{
		foreach (DSProgBarInfo value in ProgBarInfoDic.Values)
		{
			value.Clear();
			value.Stop();
		}
		ProgBarInfoDic.Clear();
		foreach (DSLinkAttrProgBar linkBloodDS in LinkBloodDSList)
		{
			linkBloodDS.Clear();
			linkBloodDS.Stop();
		}
		LinkBloodDSList.Clear();
	}

	private bool HasShowLinkBlood(string Guid, out DSLinkAttrProgBar LinkBloodDS)
	{
		LinkBloodDS = null;
		foreach (DSLinkAttrProgBar linkBloodDS in LinkBloodDSList)
		{
			if (linkBloodDS.IncludeUnit(Guid))
			{
				LinkBloodDS = linkBloodDS;
				return true;
			}
		}
		return false;
	}

	private void UpdataUnitBarInfo(GSBindList<UnitBarInfo> BarInfoBind, List<BI_UnitBarCS> BloodList)
	{
		int num = BarListLimit - 1;
		List<DSProgBarInfo> list = new List<DSProgBarInfo>();
		foreach (UnitBarInfo item in BarInfoBind)
		{
			if (num >= 0)
			{
				LinkBloodDesc linkBloodDesc = GameDBRuntime.GetLinkBloodDesc(item.UnitGuid);
				if (linkBloodDesc != null)
				{
					if (HasShowLinkBlood(item.UnitGuid, out var LinkBloodDS))
					{
						LinkBloodDS.UpdateBindUnit();
						LinkBloodDS.UpdateBlood(EChangeReason.Init);
						if (!list.Contains(LinkBloodDS))
						{
							list.Add(LinkBloodDS);
						}
						continue;
					}
					DSLinkAttrProgBar dSLinkAttrProgBar = new DSLinkAttrProgBar(this);
					dSLinkAttrProgBar.Init(EBGUAttrFloat.Hp, EBGUAttrFloat.HpMax, linkBloodDesc.Id);
					LinkBloodDSList.Add(dSLinkAttrProgBar);
					list.Add(dSLinkAttrProgBar);
				}
				else
				{
					bool flag = ProgBarInfoDic.ContainsKey(item.UnitGuid);
					DSHpProgBar dSHpProgBar = new DSHpProgBar(this);
					BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(this, item.UnitGuid) as BGUCharacterCS;
					if (bGUCharacterCS != null)
					{
						dSHpProgBar.Init(bGUCharacterCS);
						if (!flag)
						{
							dSHpProgBar.SetCanShow(InCanShow: false);
						}
					}
					ProgBarInfoDic[item.UnitGuid] = dSHpProgBar;
					list.Add(dSHpProgBar);
				}
			}
			num--;
		}
		for (int num2 = BloodList.Count - 1; num2 >= 0; num2--)
		{
			int num3 = BarListLimit - 1 - num2;
			if (num3 >= 0 && num3 < list.Count)
			{
				BloodList[num2].InitDataStore(list[num3]);
				list[num3].Play();
			}
			else
			{
				BloodList[num2].InitDataStore(null);
			}
		}
		UIMgr.UpdateGrid(BloodList, 1);
		UpdateProgCount(BarInfoBind);
	}

	private void UpdateProgCount(GSBindList<UnitBarInfo> BarInfoBind)
	{
		HashSet<DSProgBarInfo> hashSet = new HashSet<DSProgBarInfo>();
		foreach (UnitBarInfo item in BarInfoBind)
		{
			if (ProgBarInfoDic.TryGetValue(item.UnitGuid, out var value))
			{
				hashSet.Add(value);
				continue;
			}
			foreach (DSLinkAttrProgBar linkBloodDS in LinkBloodDSList)
			{
				if (linkBloodDS.IncludeUnit(item.UnitGuid) && !hashSet.Contains(linkBloodDS))
				{
					hashSet.Add(linkBloodDS);
				}
			}
		}
		ProgBar?.GetDynamicMaterial()?.SetScalarParameterValue(MatParamProgCount, hashSet.Count);
	}

	private void SettingValueChange(int OldValue, int NewValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.BossBar)
		{
			UpdateVisibility(NewValue == 1);
		}
	}

	private void UpdateVisibility(bool IsVisibility)
	{
		SetVisibility((!IsVisibility) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		UnBindUnitBarInfoData(this);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_SettingValueChanged = (BGW_UIEventCollection.Del_UI_SettingValue)Delegate.Remove(bGW_UIEventCollection.Evt_SettingValueChanged, new BGW_UIEventCollection.Del_UI_SettingValue(SettingValueChange));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_UnitBarListCS");
	}

	static BI_UnitBarListCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_UnitBarListCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_UnitBarListCS));
	}
}
