using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

public class PartInfoData
{
	public float MPConvertRatio;

	public float StaminaConvertRatio;

	public bool CanReduceUnitHP;

	public float ReduceHPAdditionRatio;

	public int CurrentDamagedStage;

	public int TotalDamagedStage;

	public int PartDamagedStiffLevel;

	public List<string> RootBoneName;

	public EHitPartRuleType HitPartRuleType;

	public float LeftAngle;

	public float RightAngle;

	public string BeHitDirectionRootName;

	public List<FUStPartDamagedInfo> PartDamagedInfoList;

	public List<int> RandomOrderAvailableStages;

	public EHitItemAudioType PartItemAudioType;

	public EHitItemFXType PartItemFXType;

	public List<int> BuffIDList;

	public List<int> CanInterruptPartIDList;

	public FPartHitExpandInfo PartHitExpandInfo;

	private static float INV10000 = 0.0001f;

	[GSGameDataSnapShot]
	public int DescID { get; set; }

	[GSGameDataSnapShot]
	public string PartName { get; set; }

	[GSGameDataSnapShot]
	public float CurrentPartDamagedValue { get; set; }

	[GSGameDataSnapShot]
	public float PartDamagedBaseValue { get; set; }

	[GSGameDataSnapShot]
	public float MaxPartDamagedValue { get; set; }

	[GSGameDataSnapShot]
	public bool IsBreak { get; set; }

	public bool IsActive { get; set; }

	public bool ImmueAbnormalStateAcc { get; set; }

	public bool IsPartHPLocked { get; set; }

	public bool NeedShowUI { get; set; }

	public EHitPartReduceAttrType ReduceAttrType { get; set; }

	public PartInfoData()
	{
	}

	public PartInfoData(int ResID, int BeAttackedInfoID, float PartDamageValue, FUStPartRuleInfoDesc PartRuleInfoDesc, FUStPartHitExpandDesc PartHitExpandDesc)
	{
		RootBoneName = new List<string>();
		PartDamagedInfoList = new List<FUStPartDamagedInfo>();
		IsBreak = false;
		DescID = PartRuleInfoDesc.ID;
		PartName = PartRuleInfoDesc.PartName;
		PartDamagedBaseValue = PartDamageValue;
		IsActive = PartRuleInfoDesc.IsActive == EGSYesNo.Yes;
		ImmueAbnormalStateAcc = PartRuleInfoDesc.ImmueAbnormalStateAcc == EGSYesNo.Yes;
		NeedShowUI = PartRuleInfoDesc.NeedShowUI == EGSYesNo.Yes;
		IsPartHPLocked = false;
		CanReduceUnitHP = false;
		ReduceHPAdditionRatio = 0f;
		MPConvertRatio = 0f;
		StaminaConvertRatio = 0f;
		ReduceAttrType = PartRuleInfoDesc.HitPartReduceAttrType;
		switch (PartRuleInfoDesc.HitPartReduceAttrType)
		{
		case EHitPartReduceAttrType.Hp:
			CanReduceUnitHP = PartRuleInfoDesc.ReduceParams.Count > 0 && PartRuleInfoDesc.ReduceParams[0] != 0f;
			ReduceHPAdditionRatio = ((PartRuleInfoDesc.ReduceParams.Count > 1) ? PartRuleInfoDesc.ReduceParams[1] : 0f);
			break;
		case EHitPartReduceAttrType.Mp:
			MPConvertRatio = ((PartRuleInfoDesc.ReduceParams.Count > 0) ? PartRuleInfoDesc.ReduceParams[0] : 0f);
			break;
		case EHitPartReduceAttrType.Stamina:
			StaminaConvertRatio = ((PartRuleInfoDesc.ReduceParams.Count > 0) ? PartRuleInfoDesc.ReduceParams[0] : 0f);
			break;
		}
		HitPartRuleType = PartRuleInfoDesc.HitPartRuleType;
		PartDamagedStiffLevel = PartRuleInfoDesc.PartDamagedStiffLevel;
		PartItemAudioType = EHitItemAudioType.NormalBody;
		PartItemFXType = EHitItemFXType.NormalBody;
		Dictionary<int, List<FUStBeAttackedDispInfoDesc>> beAttackedDispInfoDescDictByResID = BGW_GameDB.GetBeAttackedDispInfoDescDictByResID(ResID);
		if (beAttackedDispInfoDescDictByResID != null && beAttackedDispInfoDescDictByResID.Count > 0)
		{
			beAttackedDispInfoDescDictByResID.TryGetValue(BeAttackedInfoID, out var value);
			if (beAttackedDispInfoDescDictByResID.TryGetValue(0, out var value2))
			{
				if (value == null)
				{
					value = new List<FUStBeAttackedDispInfoDesc>();
				}
				value.AddRange(value2);
			}
			if (value != null && value.Count > 0)
			{
				foreach (FUStBeAttackedDispInfoDesc item in value)
				{
					if (item != null && item.PartRuleID == 0)
					{
						PartItemAudioType = item.HitItemAudioType;
						PartItemFXType = item.HitItemFXType;
						break;
					}
				}
				foreach (FUStBeAttackedDispInfoDesc item2 in value)
				{
					if (item2 != null && item2.PartRuleID == PartRuleInfoDesc.PartRuleID && item2.PartID == PartRuleInfoDesc.PartID)
					{
						PartItemAudioType = item2.HitItemAudioType;
						PartItemFXType = item2.HitItemFXType;
						break;
					}
				}
			}
		}
		LeftAngle = 0f;
		RightAngle = 0f;
		CurrentPartDamagedValue = PartDamagedBaseValue;
		TotalDamagedStage = 1;
		CurrentDamagedStage = TotalDamagedStage;
		BuffIDList = new List<int>();
		if (PartRuleInfoDesc.PartDamagedInfoList.Count > 0)
		{
			foreach (FUStPartDamagedInfo partDamagedInfo in PartRuleInfoDesc.PartDamagedInfoList)
			{
				PartDamagedInfoList.Add(partDamagedInfo);
			}
			TotalDamagedStage = PartRuleInfoDesc.PartDamagedInfoList.Count;
			CurrentPartDamagedValue = PartRuleInfoDesc.PartDamagedInfoList[0].DamagedValueRatio * INV10000 * PartDamagedBaseValue;
		}
		MaxPartDamagedValue = CurrentPartDamagedValue;
		if (HitPartRuleType == EHitPartRuleType.ByPa)
		{
			foreach (string item3 in PartRuleInfoDesc.HitPartRuleParam)
			{
				RootBoneName.Add(item3);
			}
		}
		else if (HitPartRuleType == EHitPartRuleType.ByDir)
		{
			LeftAngle = 0f;
			RightAngle = 0f;
			if (PartRuleInfoDesc.HitPartRuleParam.Count >= 2)
			{
				if (StringParseHelper.SafeTryFloatParse(PartRuleInfoDesc.HitPartRuleParam[0], out var Ret))
				{
					LeftAngle = Ret;
				}
				if (StringParseHelper.SafeTryFloatParse(PartRuleInfoDesc.HitPartRuleParam[1], out var Ret2))
				{
					RightAngle = Ret2;
				}
			}
			if (PartRuleInfoDesc.HitPartRuleParam.Count > 2)
			{
				BeHitDirectionRootName = PartRuleInfoDesc.HitPartRuleParam[2];
			}
			else
			{
				BeHitDirectionRootName = "";
			}
		}
		RandomOrderAvailableStages = new List<int>();
		for (int i = 0; i < TotalDamagedStage; i++)
		{
			RandomOrderAvailableStages.Add(i);
		}
		foreach (int item4 in PartRuleInfoDesc.BuffWithPartActive)
		{
			BuffIDList.Add(item4);
		}
		CanInterruptPartIDList = new List<int>();
		string[] array = PartRuleInfoDesc.CanInterruptPartIDs.Split(new char[2] { '，', ',' }, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < array.Length; j++)
		{
			if (int.TryParse(array[j], out var result))
			{
				CanInterruptPartIDList.Add(result);
			}
		}
		PartHitExpandInfo = new FPartHitExpandInfo(PartHitExpandDesc);
	}
}
