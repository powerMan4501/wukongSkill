using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using BtlShare;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BUC_AttrContainer : IBUC_AttrContainer, IPersistentECSData
{
	private class FDelayTickAttrInfo
	{
		public EBGUAttrFloat AttrId;

		public float Value;

		public float DelayTick;

		public void Tick()
		{
			DelayTick -= 1f;
		}

		public bool IsFinish()
		{
			return DelayTick == 0f;
		}
	}

	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public AttrContainer[] _RepData = new AttrContainer[64];

	private BindListWNRFloat __FloatAttrs_Raw;

	public AActor Owner;

	private float HPFixedDM;

	private readonly List<FDelayTickAttrInfo> _delayTickAttrInfos = new List<FDelayTickAttrInfo>();

	[NeedToUI]
	[GSReplicated]
	[GSGameDataSnapShot]
	public BindListWNRFloat FloatAttrs
	{
		get
		{
			return __FloatAttrs_Raw;
		}
		set
		{
			BindListWNRFloat _FloatAttrs_Raw = __FloatAttrs_Raw;
			__FloatAttrs_Raw = value;
			OnFloatAttrsChg_Invoke(_FloatAttrs_Raw, value);
		}
	}

	public event Action<BindListWNRFloat, BindListWNRFloat> OnFloatAttrsChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			FloatAttrs?.RegGetDeltaDataFunc(AllocRepDataForFloatAttrs);
		}
		else
		{
			FloatAttrs?.RegGetDeltaDataFunc(null);
		}
		FloatAttrs?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListWNRDeltaMsgFloat> AllocRepDataForFloatAttrs()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().FloatAttrs;
		}
		return null;
	}

	public AttrContainer GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		AttrContainer attrContainer = _RepData[__LocalRepVersion % 64];
		if (attrContainer == null)
		{
			attrContainer = new AttrContainer();
			FloatAttrs?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = attrContainer;
		}
		else if (flag)
		{
			attrContainer.FloatAttrs.Clear();
			FloatAttrs?.ClearDeltaData();
		}
		return attrContainer;
	}

	public AttrContainer GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			FloatAttrs?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		AttrContainer attrContainer = new AttrContainer();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"AttrContainer Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (FloatAttrs == null)
			{
				attrContainer.FloatAttrs.Add(new ListWNRDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				FloatAttrs.DumpFull(attrContainer.FloatAttrs);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					AttrContainer other = _RepData[i % 64];
					attrContainer.MergeFrom(other);
				}
			}
		}
		return attrContainer;
	}

	private void OnFloatAttrsChg_Invoke(BindListWNRFloat OldValue, BindListWNRFloat NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			AttrContainer orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.FloatAttrs.Clear();
			if (NewValue == null)
			{
				orAllocRepData.FloatAttrs.Add(new ListWNRDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.FloatAttrs);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForFloatAttrs);
		this.OnFloatAttrsChg?.Invoke(OldValue, NewValue);
	}

	static BUC_AttrContainer()
	{
		AttrMgr<EBGUAttrFloat, float> instance = AttrMgr<EBGUAttrFloat, float>.getInstance();
		instance.InitCalcGroup(EBGUAttrFloat.HpMax, EBGUAttrFloat.HpMaxMul, EBGUAttrFloat.HpMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.MpMax, EBGUAttrFloat.MpMaxMul, EBGUAttrFloat.MpMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.Atk, EBGUAttrFloat.AtkMul, EBGUAttrFloat.AtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.Def, EBGUAttrFloat.DefMul, EBGUAttrFloat.DefBase);
		instance.InitCalcGroup(EBGUAttrFloat.StaminaMax, EBGUAttrFloat.StaminaMaxMul, EBGUAttrFloat.StaminaMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.StaminaRecover, EBGUAttrFloat.StaminaRecoverMul, EBGUAttrFloat.StaminaRecoverBase);
		instance.InitCalcGroup(EBGUAttrFloat.StaminaDepletedLimit, EBGUAttrFloat.StaminaDepletedLimitMul, EBGUAttrFloat.StaminaDepletedLimitBase);
		instance.InitCalcGroup(EBGUAttrFloat.StaminaCostMultiper, EBGUAttrFloat.StaminaCostMultiperMul, EBGUAttrFloat.StaminaCostMultiperBase);
		instance.InitCalcGroup(EBGUAttrFloat.CritRate, EBGUAttrFloat.None, EBGUAttrFloat.CritRateBase);
		instance.InitCalcGroup(EBGUAttrFloat.CritMultiplier, EBGUAttrFloat.None, EBGUAttrFloat.CritMultiplierBase);
		instance.InitCalcGroup(EBGUAttrFloat.KptturnSpeed, EBGUAttrFloat.KptturnSpeedMul, EBGUAttrFloat.KptturnSpeedBase);
		instance.InitCalcGroup(EBGUAttrFloat.EarPlug, EBGUAttrFloat.None, EBGUAttrFloat.EarPlugBase);
		instance.InitCalcGroup(EBGUAttrFloat.CritRateDef, EBGUAttrFloat.None, EBGUAttrFloat.CritRateDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.CritDmgMulDef, EBGUAttrFloat.None, EBGUAttrFloat.CritDmgMulDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.DmgAddition, EBGUAttrFloat.None, EBGUAttrFloat.DmgAdditionBase);
		instance.InitCalcGroup(EBGUAttrFloat.DmgDef, EBGUAttrFloat.None, EBGUAttrFloat.DmgDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.Tenacity, EBGUAttrFloat.None, EBGUAttrFloat.TenacityBase);
		instance.InitCalcGroup(EBGUAttrFloat.DingshenDefAddition, EBGUAttrFloat.None, EBGUAttrFloat.DingshenDefAdditionBase);
		instance.InitCalcGroup(EBGUAttrFloat.FreezeAbnormalAccMax, EBGUAttrFloat.FreezeAbnormalAccMaxMul, EBGUAttrFloat.FreezeAbnormalAccMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.BurnAbnormalAccMax, EBGUAttrFloat.BurnAbnormalAccMaxMul, EBGUAttrFloat.BurnAbnormalAccMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.PoisonAbnormalAccMax, EBGUAttrFloat.PoisonAbnormalAccMaxMul, EBGUAttrFloat.PoisonAbnormalAccMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.ThunderAbnormalAccMax, EBGUAttrFloat.ThunderAbnormalAccMaxMul, EBGUAttrFloat.ThunderAbnormalAccMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.YinAbnormalAccMax, EBGUAttrFloat.YinAbnormalAccMaxMul, EBGUAttrFloat.YinAbnormalAccMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.YangAbnormalAccMax, EBGUAttrFloat.YangAbnormalAccMaxMul, EBGUAttrFloat.YangAbnormalAccMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.FreezeAtk, EBGUAttrFloat.None, EBGUAttrFloat.FreezeAtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.BurnAtk, EBGUAttrFloat.None, EBGUAttrFloat.BurnAtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.PoisonAtk, EBGUAttrFloat.None, EBGUAttrFloat.PoisonAtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.ThunderAtk, EBGUAttrFloat.None, EBGUAttrFloat.ThunderAtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.YinAtk, EBGUAttrFloat.None, EBGUAttrFloat.YinAtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.YangAtk, EBGUAttrFloat.None, EBGUAttrFloat.YangAtkBase);
		instance.InitCalcGroup(EBGUAttrFloat.FreezeDef, EBGUAttrFloat.None, EBGUAttrFloat.FreezeDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.BurnDef, EBGUAttrFloat.None, EBGUAttrFloat.BurnDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.PoisonDef, EBGUAttrFloat.None, EBGUAttrFloat.PoisonDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.ThunderDef, EBGUAttrFloat.None, EBGUAttrFloat.ThunderDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.YinDef, EBGUAttrFloat.None, EBGUAttrFloat.YinDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.YangDef, EBGUAttrFloat.None, EBGUAttrFloat.YangDefBase);
		instance.InitCalcGroup(EBGUAttrFloat.BloodBottomNumMax, EBGUAttrFloat.None, EBGUAttrFloat.BloodBottomNumMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.PelevelMax, EBGUAttrFloat.None, EBGUAttrFloat.PelevelMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.ShieldMax, EBGUAttrFloat.None, EBGUAttrFloat.ShieldMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.PevalueMax, EBGUAttrFloat.None, EBGUAttrFloat.PevalueMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.TransEnergyMax, EBGUAttrFloat.TransEnergyMaxMul, EBGUAttrFloat.TransEnergyMaxBase);
		instance.InitCalcGroup(EBGUAttrFloat.EnergyMinConsume, EBGUAttrFloat.EnergyMinConsumeMul, EBGUAttrFloat.EnergyMinConsumeBase);
		instance.InitCalcGroup(EBGUAttrFloat.EnergyConsumeSpeed, EBGUAttrFloat.EnergyConsumeSpeedMul, EBGUAttrFloat.EnergyConsumeSpeedBase);
		instance.InitCalcGroup(EBGUAttrFloat.EnergyIncreaseSpeed, EBGUAttrFloat.EnergyIncreaseSpeedMul, EBGUAttrFloat.EnergyIncreaseSpeedBase);
		instance.InitMinmaxGroup(EBGUAttrFloat.Hp, EBGUAttrFloat.HpMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.Mp, EBGUAttrFloat.MpMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.Stamina, EBGUAttrFloat.StaminaMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.SkillSuperArmor, EBGUAttrFloat.SkillSuperArmorMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.FreezeAbnormalAcc, EBGUAttrFloat.FreezeAbnormalAccMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.BurnAbnormalAcc, EBGUAttrFloat.BurnAbnormalAccMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.PoisonAbnormalAcc, EBGUAttrFloat.PoisonAbnormalAccMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.ThunderAbnormalAcc, EBGUAttrFloat.ThunderAbnormalAccMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.YinAbnormalAcc, EBGUAttrFloat.YinAbnormalAccMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.YangAbnormalAcc, EBGUAttrFloat.YangAbnormalAccMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.BlockCollapseArmor, EBGUAttrFloat.BlockCollapseArmorMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.BloodBottomNum, EBGUAttrFloat.BloodBottomNumMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.Pelevel, EBGUAttrFloat.PelevelMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.CurEnergy, EBGUAttrFloat.TransEnergyMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.SpecialEnergy, EBGUAttrFloat.SpecialEnergyMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.Shield, EBGUAttrFloat.ShieldMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.Pevalue, EBGUAttrFloat.PevalueMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.FabaoEnergy, EBGUAttrFloat.FabaoEnergyMax, 0f);
		instance.InitMinmaxGroup(EBGUAttrFloat.VigorEnergy, EBGUAttrFloat.VigorEnergyMax, 0f);
	}

	public void Init()
	{
		EGSBindRepType[] array = new EGSBindRepType[255];
		for (int i = 0; i < 255; i++)
		{
			array[i] = EGSBindRepType.ServerAuthority;
		}
		FloatAttrs = new BindListWNRFloat(array);
	}

	public void SetHPFixedDM(int BattleInfoExtendID)
	{
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BattleInfoExtendID);
		if (unitBattleInfoExtendDesc != null)
		{
			bool flag = unitBattleInfoExtendDesc.GameCountNotUpdateAttr == EGSYesNo.No;
			int num = BGW_GamePlayCountUtil.GetCurGamePlayCount(Owner);
			if (num > 1 && flag)
			{
				if (num >= 6)
				{
					num = 6;
				}
				float num2 = (float)GameDBRuntime.GetCommLogicCfgValue(CommCfgType.GameplayCountHpFixCoefficient) * 0.0001f;
				if (num2 > 0f)
				{
					HPFixedDM = (10000f * (num2 * (float)num - 1f) + (float)unitBattleInfoExtendDesc.HPFixedDM) / (num2 * (float)num) * 0.0001f;
				}
			}
			else
			{
				HPFixedDM = (float)unitBattleInfoExtendDesc.HPFixedDM * 0.0001f;
			}
		}
		else
		{
			BGW_LogUtil.LogError($"UnitBattleInfoExtendDesc == null !!! BattleInfoExtendID = {BattleInfoExtendID}");
		}
	}

	public float SetFloatValue(EBGUAttrFloat AttrID, float AttrValue)
	{
		float result = AttrValue;
		bool IsVaild = false;
		AttrMinMaxGroup<EBGUAttrFloat, float> minMax = AttrMgr<EBGUAttrFloat, float>.getInstance().GetMinMax(AttrID, out IsVaild);
		if (IsVaild)
		{
			float minVal = minMax.minVal;
			if (AttrID == minMax.maxVal)
			{
				FloatAttrs[(int)minMax.maxVal] = AttrValue;
			}
			float num = FloatAttrs[(int)minMax.maxVal];
			float num2 = FloatAttrs[(int)minMax.finalVal];
			if (AttrID == minMax.finalVal)
			{
				num2 = AttrValue;
			}
			num2 = ((num2 < minVal) ? minVal : num2);
			num2 = ((num2 > num) ? num : num2);
			FloatAttrs[(int)minMax.finalVal] = num2;
			result = num2;
		}
		else
		{
			FloatAttrs[(int)AttrID] = AttrValue;
		}
		bool IsVaild2 = false;
		AttrCalcGroup<EBGUAttrFloat> calc = AttrMgr<EBGUAttrFloat, float>.getInstance().GetCalc(AttrID, out IsVaild2);
		if (IsVaild2)
		{
			float num3 = FloatAttrs[(int)calc.baseVal];
			float num4 = FloatAttrs[(int)calc.mulVal];
			float num5 = num3 * ((10000f + num4) * 0.0001f);
			if (calc.finalVal == EBGUAttrFloat.HpMax && HPFixedDM > 0f)
			{
				num5 = num3 * ((10000f + num4) * 0.0001f) * HPFixedDM;
			}
			FloatAttrs[(int)calc.finalVal] = num5;
			result = num5;
		}
		EBGUAttrFloat eBGUAttrFloat = AttrID;
		if (IsVaild2)
		{
			eBGUAttrFloat = calc.finalVal;
		}
		if (GetFloatAttrBeClamped_ByMaxAttr(eBGUAttrFloat, out var AttrBeClamped))
		{
			float floatValue = GetFloatValue(eBGUAttrFloat);
			if (GetFloatValue(AttrBeClamped) > floatValue)
			{
				SetFloatValue(AttrBeClamped, floatValue);
			}
		}
		return result;
	}

	public float GetFloatValue(EBGUAttrFloat AttrID)
	{
		return GetValue<EBGUAttrFloat, float>(FloatAttrs, AttrID);
	}

	public bool GetFloatAttrBeClamped_ByMaxAttr(EBGUAttrFloat MaxAttrID, out EBGUAttrFloat AttrBeClamped)
	{
		if (AttrMgr<EBGUAttrFloat, float>.getInstance()._minMaxGrps.TryGetValue(MaxAttrID, out var value))
		{
			AttrBeClamped = value.finalVal;
			return true;
		}
		AttrBeClamped = EBGUAttrFloat.None;
		return false;
	}

	public float GetFloatValMin(EBGUAttrFloat AttrID)
	{
		bool IsVaild = false;
		AttrMinMaxGroup<EBGUAttrFloat, float> minMax = AttrMgr<EBGUAttrFloat, float>.getInstance().GetMinMax(AttrID, out IsVaild);
		if (!IsVaild)
		{
			return minMax.minVal;
		}
		return 0f;
	}

	public float GetFloatValMax(EBGUAttrFloat AttrID)
	{
		return GetValMax<int, float>(FloatAttrs, AttrID);
	}

	private ValueType GetValue<EBGUAttrType, ValueType>(GSBindListWithNetRole<ValueType> TargetAttr, EBGUAttrFloat AttrID)
	{
		return TargetAttr[(int)AttrID];
	}

	private ValueType GetValMax<EBGUAttrType, ValueType>(GSBindListWithNetRole<ValueType> TargetAttr, EBGUAttrFloat AttrID)
	{
		bool IsVaild = false;
		AttrMinMaxGroup<EBGUAttrFloat, ValueType> minMax = AttrMgr<EBGUAttrFloat, ValueType>.getInstance().GetMinMax(AttrID, out IsVaild);
		if (IsVaild)
		{
			return TargetAttr[(int)minMax.maxVal];
		}
		return TargetAttr[(int)AttrID];
	}

	public void BindOneValueChanged(Action<int, float, float> ActionChange)
	{
		FloatAttrs.BindOnSetIdxValue(ActionChange);
	}

	public bool GetAttrSnapShot(out FAttrSnapShot OutAttrSnapShot)
	{
		OutAttrSnapShot = new FAttrSnapShot(FloatAttrs);
		if (OutAttrSnapShot.FloatAttrs == null)
		{
			return false;
		}
		return true;
	}

	public void SetFloatValueDelayTick(EBGUAttrFloat AttrID, float NewValue, int DelayTick)
	{
		_delayTickAttrInfos.Add(new FDelayTickAttrInfo
		{
			AttrId = AttrID,
			Value = NewValue,
			DelayTick = DelayTick
		});
	}

	public void OnTick()
	{
		if (!_delayTickAttrInfos.Any())
		{
			return;
		}
		foreach (FDelayTickAttrInfo delayTickAttrInfo in _delayTickAttrInfos)
		{
			delayTickAttrInfo.Tick();
			if (delayTickAttrInfo.IsFinish())
			{
				SetFloatValue(delayTickAttrInfo.AttrId, GetFloatValue(delayTickAttrInfo.AttrId) + delayTickAttrInfo.Value);
			}
		}
		_delayTickAttrInfos.RemoveAll((FDelayTickAttrInfo Info) => Info.IsFinish());
	}
}
