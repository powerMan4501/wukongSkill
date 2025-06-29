using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_StickLevelCS")]
public class BI_StickLevelCS : BUI_Widget
{
	private BI_StickLevelProgCS StickProg;

	private List<BI_StickLevelDotCS> LevelDotList = new List<BI_StickLevelDotCS>();

	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private DS_IBUC_AttrContainer AttrContainer;

	private DS_IBUC_PotentialEnergyData PotentialEnergyData;

	private UWidgetAnimation AnimStA;

	private UWidgetAnimation AnimStB;

	private UWidgetAnimation AnimStC;

	private UWidgetAnimation AnimStD;

	private UWidgetAnimation AnimStE;

	private UWidgetAnimation AnimReset;

	private int CurPelevel;

	private int CurDotPelevel;

	private EDaShengStage DSState;

	private int BindIdx;

	private int BindIdx2;

	private float ProgPercentSplite = 0.6f;

	private readonly int NormalMaxLevel = 4;

	private readonly int CanInDaShengMaxLevel = 5;

	private static bool ShowType_IsValid;

	private static int ShowType_Offset;

	private static FFieldAddress ShowType_PropertyAddress;

	[UProperty]
	[DisplayName("显示类型")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BI_StickLevelCS:ShowType")]
	public EStickLevelShowType ShowType
	{
		get
		{
			CheckDestroyed();
			if (!ShowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_StickLevelCS:ShowType");
				return EStickLevelShowType.Normal;
			}
			return EnumMarshaler<EStickLevelShowType>.FromNative(IntPtr.Add(base.Address, ShowType_Offset), 0, ShowType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_StickLevelCS:ShowType");
			}
			else
			{
				EnumMarshaler<EStickLevelShowType>.ToNative(IntPtr.Add(base.Address, ShowType_Offset), 0, ShowType_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr.GetMDSBattleMain();
		ProgPercentSplite = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ProgPercentSplite;
		for (int i = 0; i < 4; i++)
		{
			LevelDotList.Add(FindChildWidget($"BI_Dot_{i + 1}") as BI_StickLevelDotCS);
		}
		StickProg = FindChildWidget("BI_StickLevelProg") as BI_StickLevelProgCS;
		AnimStA = FindWidgetAnimation("StAnimA");
		AnimStB = FindWidgetAnimation("StAnimB");
		AnimStC = FindWidgetAnimation("StAnimC");
		AnimStD = FindWidgetAnimation("StAnimD");
		AnimStE = FindWidgetAnimation("StAnimE");
		AnimReset = FindWidgetAnimation("AnimReset");
		PotentialEnergyData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_PotentialEnergyData>(B1ActorTag.CurPlayerActor);
		if (PotentialEnergyData != null)
		{
			OnPELimitNormalChange(PotentialEnergyData.PELimit_Normal, PotentialEnergyData.PELimit_Normal);
			BindIdx2 = PotentialEnergyData.BindPELimit_NormalChange(OnPELimitNormalChange);
		}
		AttrContainer = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor);
		if (AttrContainer != null)
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
			OnPevalueChange(floatValue, floatValue, IsInit: true);
			BindIdx = AttrContainer.BindFloatAttrsOnSetIdxValue(OnBindPevalueChange);
		}
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_OnPEConfigChange = (Del_Void)Delegate.Combine(actorEvt.Evt_OnPEConfigChange, new Del_Void(OnPEConfigChange));
		}
	}

	private int GetPelevelByPevale(float Pevalue)
	{
		int num = 0;
		if (PotentialEnergyData == null)
		{
			return num;
		}
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (item.Key > num && Pevalue >= item.Value.LevelValue)
			{
				num = item.Key;
			}
		}
		return num;
	}

	private int GetPelevelActiveByPevale(float Pevalue)
	{
		int num = 0;
		if (PotentialEnergyData == null || Pevalue == 0f)
		{
			return num + 1;
		}
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (item.Key > num && Pevalue > item.Value.LevelValue)
			{
				num = item.Key;
			}
		}
		if (num + 1 < PotentialEnergyData.LevelMap.Count)
		{
			num++;
		}
		return num;
	}

	private int GetPelevel2ActiveByPevale(float Pevalue)
	{
		int num = 0;
		if (PotentialEnergyData == null || Pevalue == 0f)
		{
			return num + 1;
		}
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (item.Key > num && Pevalue >= item.Value.LevelValue)
			{
				num = item.Key;
			}
		}
		if (num + 1 < PotentialEnergyData.LevelMap.Count)
		{
			num++;
		}
		return num;
	}

	private float GetPelevelProgByPevale(float Pevalue, out float ProgMaxValue)
	{
		float result = 0f;
		ProgMaxValue = 100f;
		if (PotentialEnergyData == null)
		{
			return result;
		}
		float num = 0f;
		float num2 = float.MaxValue;
		int pelevel2ActiveByPevale = GetPelevel2ActiveByPevale(Pevalue);
		int num3 = 0;
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (item.Key > num3)
			{
				num3 = item.Key;
			}
		}
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item2 in PotentialEnergyData.LevelMap)
		{
			if (Pevalue >= item2.Value.LevelValue && num < item2.Value.LevelValue && item2.Key != num3)
			{
				num = item2.Value.LevelValue;
			}
			if (Pevalue <= item2.Value.LevelValue && num2 > item2.Value.LevelValue && item2.Value.LevelValue > num)
			{
				num2 = item2.Value.LevelValue;
			}
		}
		ProgMaxValue = num2 - num;
		result = (Pevalue - num) / ProgMaxValue;
		if (DSState == EDaShengStage.PreStage && (pelevel2ActiveByPevale == NormalMaxLevel || pelevel2ActiveByPevale == CanInDaShengMaxLevel))
		{
			if (PotentialEnergyData.LevelMap.TryGetValue(NormalMaxLevel - 1, out var value))
			{
				num = value.LevelValue;
			}
			if (PotentialEnergyData.LevelMap.TryGetValue(CanInDaShengMaxLevel, out var value2))
			{
				num2 = value2.LevelValue;
			}
			ProgMaxValue = num2 - num;
			float num4 = 0f;
			if (PotentialEnergyData.LevelMap.TryGetValue(NormalMaxLevel, out var value3))
			{
				num4 = value3.LevelValue;
			}
			result = ((pelevel2ActiveByPevale != NormalMaxLevel) ? (ProgPercentSplite + (Pevalue - num4) / (num2 - num4) * (1f - ProgPercentSplite)) : ((Pevalue - num) / (num4 - num) * ProgPercentSplite));
		}
		return result;
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow && AttrContainer != null)
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
			OnPevalueChange(floatValue, floatValue, IsInit: true);
		}
	}

	public void OnPELimitNormalChange(float OldValue, float NewValue)
	{
		if (PotentialEnergyData == null)
		{
			return;
		}
		foreach (BI_StickLevelDotCS levelDot in LevelDotList)
		{
			levelDot.UpdateLockState(GetPelevelActiveByPevale(NewValue));
		}
		float pevalue = FMath.Max(PotentialEnergyData.PELimit_ByChargeSkill, NewValue);
		int pelevelActiveByPevale = GetPelevelActiveByPevale(pevalue);
		pelevelActiveByPevale = FMath.Clamp(pelevelActiveByPevale, 1, NormalMaxLevel);
		GSAnimKeyToState("AKBDotCount", $"Dot{pelevelActiveByPevale}");
	}

	private void OnBindPevalueChange(int AttrId, float OldValue, float NewValue)
	{
		if (191 == AttrId)
		{
			OnPevalueChange(EBGUAttrFloat.Pevalue, OldValue, NewValue);
		}
	}

	private void OnPevalueChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (IsNeedUpdate())
		{
			BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			OnPevalueChange(OldValue, NewValue, IsInit: false);
		}
	}

	private void OnPevalueChange(float OldValue, float NewValue, bool IsInit)
	{
		UpdateProg(OldValue, NewValue, IsInit);
		UpdateState(NewValue, IsInit);
	}

	private bool IsNeedUpdate()
	{
		if (GetVisibility() == ESlateVisibility.Collapsed)
		{
			return false;
		}
		if ((BattleMainData.IsTrans && ShowType != EStickLevelShowType.Trans) || (!BattleMainData.IsTrans && ShowType == EStickLevelShowType.Trans))
		{
			return false;
		}
		return true;
	}

	private void UpdateProg(float OldPevalue, float Pevalue, bool IsInit = false)
	{
		if (AttrContainer == null || PotentialEnergyData == null)
		{
			return;
		}
		float ProgMaxValue = 100f;
		float num = GetPelevelProgByPevale(Pevalue, out ProgMaxValue);
		StickProg.UpdateMaxValue(ProgMaxValue, IsInit);
		bool isIncreace = Pevalue - OldPevalue >= 0f;
		int pelevelByPevale = GetPelevelByPevale(Pevalue);
		if (PotentialEnergyData.PELimit_Normal >= PotentialEnergyData.PELimit_ByChargeSkill)
		{
			if (Pevalue != PotentialEnergyData.PELimit_Normal && num >= 1f)
			{
				num = 0f;
			}
		}
		else if (Pevalue != PotentialEnergyData.PELimit_Normal && Pevalue != PotentialEnergyData.PELimit_ByChargeSkill && num >= 1f)
		{
			num = 0f;
		}
		StickProg.SetPercent(num, pelevelByPevale, isIncreace);
		if (num == 1f && CurDotPelevel > 0 && CurDotPelevel <= LevelDotList.Count)
		{
			LevelDotList[CurDotPelevel - 1].OnUpdateActive(IsActive: false);
		}
	}

	private void UpdateState(float Pevalue, bool IsInit = false)
	{
		int pelevel2ActiveByPevale = GetPelevel2ActiveByPevale(Pevalue);
		StickProg.UpdateProgBaseTexSize(pelevel2ActiveByPevale, IsInit, DSState == EDaShengStage.PreStage);
		int pelevelActiveByPevale = GetPelevelActiveByPevale(Pevalue);
		if (CurDotPelevel != pelevelActiveByPevale)
		{
			if (pelevelActiveByPevale > 0 && pelevelActiveByPevale <= LevelDotList.Count)
			{
				LevelDotList[pelevelActiveByPevale - 1].OnUpdateActive(IsActive: true);
			}
			if (CurDotPelevel > 0 && CurDotPelevel <= LevelDotList.Count)
			{
				LevelDotList[CurDotPelevel - 1].OnUpdateActive(IsActive: false);
			}
			CurDotPelevel = pelevelActiveByPevale;
		}
		int pelevelByPevale = GetPelevelByPevale(Pevalue);
		if (CurPelevel == pelevelByPevale)
		{
			return;
		}
		if (pelevelByPevale > CurPelevel)
		{
			for (int i = 0; i < LevelDotList.Count; i++)
			{
				LevelDotList[i].OnUpdateFull(CurPelevel, pelevelByPevale, IsInit, ShowType == EStickLevelShowType.Normal);
			}
		}
		else
		{
			for (int num = LevelDotList.Count - 1; num >= 0; num--)
			{
				LevelDotList[num].OnUpdateFull(CurPelevel, pelevelByPevale, IsInit, ShowType == EStickLevelShowType.Normal);
			}
		}
		CurPelevel = pelevelByPevale;
		switch (pelevelByPevale)
		{
		case 0:
			GSAnimKeyToState("AKBState", "StDefault");
			PlayWidgetAnimation(AnimReset);
			break;
		case 1:
			PlayWidgetAnimation(AnimStA);
			GSAnimKeyToState("AKBState", "StA");
			break;
		case 2:
			PlayWidgetAnimation(AnimStB);
			GSAnimKeyToState("AKBState", "StB");
			break;
		case 3:
			PlayWidgetAnimation(AnimStC);
			GSAnimKeyToState("AKBState", "StC");
			break;
		case 4:
			PlayWidgetAnimation(AnimStD);
			GSAnimKeyToState("AKBState", "StD");
			break;
		case 5:
			PlayWidgetAnimation(AnimStE);
			GSAnimKeyToState("AKBState", "StE");
			break;
		}
	}

	public bool IsOpenMax()
	{
		if (PotentialEnergyData == null)
		{
			return false;
		}
		return PotentialEnergyData.PELimit_Normal > PotentialEnergyData.PELimit_ByChargeSkill;
	}

	public BI_StickLevelDotCS GetPoseDot()
	{
		if (LevelDotList.Count < NormalMaxLevel)
		{
			return null;
		}
		return LevelDotList[NormalMaxLevel - 1];
	}

	private void OnPEConfigChange()
	{
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
		OnPevalueChange(EBGUAttrFloat.Pevalue, floatValue, floatValue);
	}

	public void OnDSStateChange(EDaShengStage OldValue, EDaShengStage NewValue, bool IsInit = false)
	{
		if (DSState != NewValue || IsInit)
		{
			DSState = NewValue;
			if (AttrContainer != null)
			{
				float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
				OnPevalueChange(floatValue, floatValue, IsInit: true);
			}
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_AttrContainer>(B1ActorTag.CurPlayerActor)?.UnBindFloatAttrsOnSetIdxValue(BindIdx, OnBindPevalueChange);
		if (PotentialEnergyData != null)
		{
			PotentialEnergyData.UnBindPELimit_NormalChange(BindIdx2, OnPELimitNormalChange);
		}
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_OnPEConfigChange = (Del_Void)Delegate.Remove(actorEvt.Evt_OnPEConfigChange, new Del_Void(OnPEConfigChange));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_StickLevelCS");
		NativeReflection.GetPropertyRef(ref ShowType_PropertyAddress, unrealStruct, "ShowType");
		ShowType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowType");
		ShowType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowType", Classes.FEnumProperty);
	}

	static BI_StickLevelCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_StickLevelCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_StickLevelCS));
	}
}
