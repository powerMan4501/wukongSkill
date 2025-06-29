using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibBeAttackedAndUnitDeathDispCS
{
	private static USceneComponent GetRotBaseComp(AActor Owner, string SceneCompName)
	{
		USceneComponent result = Owner.GetRootComponent();
		if (!string.IsNullOrEmpty(SceneCompName))
		{
			result = BGUFunctionLibraryCS.TryGetComponentByFName(Owner, new FName(SceneCompName)) as USceneComponent;
		}
		return result;
	}

	public static void RotateToTargetActor(AActor Attacker, AActor Victim, EAttackerArea AttackerArea, float RotateToTargetOffset, EHitOrientationType HitOrientationType, string RotBaseCompName, in FEffectInstReq EffectInstReq)
	{
		if (Attacker == null)
		{
			return;
		}
		FRotator newRotation = default(FRotator);
		switch (HitOrientationType)
		{
		case EHitOrientationType.None:
		{
			FVector fVector3 = GetRotBaseComp(Attacker, RotBaseCompName).GetWorldLocation();
			if (EffectInstReq.bFromBullet)
			{
				fVector3 = EffectInstReq.SweepCheckBegin;
			}
			newRotation = UMathLibrary.MakeRotFromX(fVector3 - BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim));
			switch (AttackerArea)
			{
			case EAttackerArea.Backward:
				newRotation = UMathLibrary.MakeRotFromX(BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim) - fVector3);
				break;
			case EAttackerArea.LeftSide:
			case EAttackerArea.RightSide:
				if (AttackerArea == EAttackerArea.LeftSide)
				{
					newRotation.Yaw += 90f;
				}
				else
				{
					newRotation.Yaw -= 90f;
				}
				break;
			}
			break;
		}
		case EHitOrientationType.TowardAttacker:
		{
			FVector fVector = GetRotBaseComp(Attacker, RotBaseCompName).GetWorldLocation();
			if (EffectInstReq.bFromBullet)
			{
				fVector = EffectInstReq.SweepCheckBegin;
			}
			newRotation = UMathLibrary.MakeRotFromX(fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim));
			break;
		}
		case EHitOrientationType.TowardAttackDirection:
			newRotation = UMathLibrary.MakeRotFromX(GetRotBaseComp(Attacker, RotBaseCompName).GetWorldTransform().TransformDirection(new FVector(-1.0, 0.0, 0.0)));
			break;
		case EHitOrientationType.BackToAttacker:
		{
			FVector fVector2 = GetRotBaseComp(Attacker, RotBaseCompName).GetWorldLocation();
			if (EffectInstReq.bFromBullet)
			{
				fVector2 = EffectInstReq.SweepCheckBegin;
			}
			newRotation = UMathLibrary.MakeRotFromX(BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim) - fVector2);
			break;
		}
		case EHitOrientationType.BackToAttackDirection:
			newRotation = UMathLibrary.MakeRotFromX(GetRotBaseComp(Attacker, RotBaseCompName).GetWorldTransform().TransformDirection(new FVector(1.0, 0.0, 0.0)));
			break;
		case EHitOrientationType.BackToCaster:
		{
			AActor masterActor2 = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Attacker).GetMasterActor();
			if (masterActor2 != null)
			{
				FVector worldLocation = GetRotBaseComp(masterActor2, RotBaseCompName).GetWorldLocation();
				newRotation = UMathLibrary.MakeRotFromX(BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim) - worldLocation);
			}
			break;
		}
		case EHitOrientationType.TowardCaster:
		{
			AActor masterActor = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Attacker).GetMasterActor();
			if (masterActor != null)
			{
				newRotation = UMathLibrary.MakeRotFromX(GetRotBaseComp(masterActor, RotBaseCompName).GetWorldLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim));
			}
			break;
		}
		case EHitOrientationType.LaserType:
			newRotation = EffectInstReq.LaserStiffDir;
			break;
		case EHitOrientationType.SameWithAttacker:
			newRotation = GetRotBaseComp(Attacker, RotBaseCompName).GetWorldRotation();
			break;
		}
		newRotation.Pitch = 0f;
		newRotation.Roll = 0f;
		newRotation.Yaw += RotateToTargetOffset;
		bool bImmediateUpdate = !UGSE_EngineFuncLib.IsStandAlone(Attacker.World);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(Victim, newRotation, bTeleportPhysics: false, bImmediateUpdate);
	}

	public static EAbnormalStateType CheckElemType(AActor Attacker, int AbnormalElemAccEffectID)
	{
		if (AbnormalElemAccEffectID == -1)
		{
			return EAbnormalStateType.None;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(AbnormalElemAccEffectID, Attacker);
		if (skillEffectDesc == null)
		{
			return EAbnormalStateType.None;
		}
		if (skillEffectDesc.EffectParamsInt.Count <= 1)
		{
			return EAbnormalStateType.None;
		}
		return (EAbnormalStateType)skillEffectDesc.EffectParamsInt[0];
	}

	public static string GetBeAttackedActionDirStr(EHitActionDir HitActionDir, EAttackerArea AttackerArea)
	{
		string result = "";
		switch (HitActionDir)
		{
		case EHitActionDir.Default:
			result = GetBeAttackedActionDirStr((EHitActionDir)UB1Util.GetRandomNumberInt(1, 6), AttackerArea);
			break;
		case EHitActionDir.Front:
			switch (AttackerArea)
			{
			case EAttackerArea.Forward:
				result = "f";
				break;
			case EAttackerArea.Backward:
				result = "b";
				break;
			case EAttackerArea.LeftSide:
				result = "l";
				break;
			case EAttackerArea.RightSide:
				result = "r";
				break;
			}
			break;
		case EHitActionDir.Back:
			switch (AttackerArea)
			{
			case EAttackerArea.Forward:
				result = "b";
				break;
			case EAttackerArea.Backward:
				result = "f";
				break;
			case EAttackerArea.LeftSide:
				result = "r";
				break;
			case EAttackerArea.RightSide:
				result = "l";
				break;
			}
			break;
		case EHitActionDir.Left:
			switch (AttackerArea)
			{
			case EAttackerArea.Forward:
				result = "l";
				break;
			case EAttackerArea.Backward:
				result = "r";
				break;
			case EAttackerArea.LeftSide:
				result = "b";
				break;
			case EAttackerArea.RightSide:
				result = "f";
				break;
			}
			break;
		case EHitActionDir.Right:
			switch (AttackerArea)
			{
			case EAttackerArea.Forward:
				result = "r";
				break;
			case EAttackerArea.Backward:
				result = "l";
				break;
			case EAttackerArea.LeftSide:
				result = "f";
				break;
			case EAttackerArea.RightSide:
				result = "b";
				break;
			}
			break;
		case EHitActionDir.Up:
			result = "d";
			break;
		case EHitActionDir.Down:
			result = "u";
			break;
		}
		return result;
	}

	public static string GetBeAttackedAttackerAreaStr(EAttackerArea AttackerArea)
	{
		string result = "";
		switch (AttackerArea)
		{
		case EAttackerArea.Forward:
			result = "f";
			break;
		case EAttackerArea.LeftSide:
			result = "l";
			break;
		case EAttackerArea.RightSide:
			result = "r";
			break;
		case EAttackerArea.Backward:
			result = "b";
			break;
		}
		return result;
	}

	public static EAttackerArea GetAttackerAreaByUBAConfig(int StiffLevel, BGWDataAsset_UnitBeAttackedConfig NowUseUBAConfig, FVector VictimForwardDir, FVector VictimToAttackerDir)
	{
		if (NowUseUBAConfig == null)
		{
			return EAttackerArea.Forward;
		}
		if (NowUseUBAConfig.NormalStiffInfoList == null)
		{
			return EAttackerArea.Forward;
		}
		GetActualStiffLevelInfo(StiffLevel, NowUseUBAConfig, out var IsValid, out var NormalStiffInfo);
		if (IsValid)
		{
			float num = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(VictimForwardDir.GetSafeNormal2D(), VictimToAttackerDir.GetSafeNormal2D());
			float normalStiffRotateForwardLeft_FNB = NormalStiffInfo.NormalStiffRotateForwardLeft_FNB;
			float normalStiffRotateForwardRight_FNB = NormalStiffInfo.NormalStiffRotateForwardRight_FNB;
			float normalStiffRotateForwardLeft_FourDir = NormalStiffInfo.NormalStiffRotateForwardLeft_FourDir;
			float normalStiffRotateForwardRight_FourDir = NormalStiffInfo.NormalStiffRotateForwardRight_FourDir;
			float normalStiffRotateBackwardLeft_FourDir = NormalStiffInfo.NormalStiffRotateBackwardLeft_FourDir;
			float normalStiffRotateBackwardRight_FourDir = NormalStiffInfo.NormalStiffRotateBackwardRight_FourDir;
			switch (NormalStiffInfo.SectorsType)
			{
			case ENormalStiffSectorsType.AllForward:
				return EAttackerArea.Forward;
			case ENormalStiffSectorsType.ForwardAndBackward:
				if (num >= normalStiffRotateForwardLeft_FNB && num < normalStiffRotateForwardRight_FNB)
				{
					return EAttackerArea.Forward;
				}
				return EAttackerArea.Backward;
			case ENormalStiffSectorsType.FourDir:
				if (num >= normalStiffRotateForwardLeft_FourDir && num < normalStiffRotateForwardRight_FourDir)
				{
					return EAttackerArea.Forward;
				}
				if (num >= normalStiffRotateBackwardLeft_FourDir && num <= normalStiffRotateForwardLeft_FourDir)
				{
					return EAttackerArea.LeftSide;
				}
				if (num <= normalStiffRotateBackwardRight_FourDir && num >= normalStiffRotateForwardRight_FourDir)
				{
					return EAttackerArea.RightSide;
				}
				return EAttackerArea.Backward;
			}
		}
		return EAttackerArea.Forward;
	}

	public static EAttackerArea GetAttackerAreaByUDDConfig(int StiffLevel, BGWDataAsset_UnitDeathDispConfig NowUseUDDConfig, FVector VictimForwardDir, FVector VictimToAttackerDir)
	{
		if (NowUseUDDConfig == null)
		{
			return EAttackerArea.Forward;
		}
		GetActualStiffLevelInfo(StiffLevel, NowUseUDDConfig, out var IsValid, out var NormalDeadAMInfo);
		if (IsValid)
		{
			float num = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(VictimForwardDir.GetSafeNormal2D(), VictimToAttackerDir.GetSafeNormal2D());
			float normalStiffRotateForwardLeft_FNB = NormalDeadAMInfo.NormalStiffRotateForwardLeft_FNB;
			float normalStiffRotateForwardRight_FNB = NormalDeadAMInfo.NormalStiffRotateForwardRight_FNB;
			float normalStiffRotateForwardLeft_FourDir = NormalDeadAMInfo.NormalStiffRotateForwardLeft_FourDir;
			float normalStiffRotateForwardRight_FourDir = NormalDeadAMInfo.NormalStiffRotateForwardRight_FourDir;
			float normalStiffRotateBackwardLeft_FourDir = NormalDeadAMInfo.NormalStiffRotateBackwardLeft_FourDir;
			float normalStiffRotateBackwardRight_FourDir = NormalDeadAMInfo.NormalStiffRotateBackwardRight_FourDir;
			switch (NormalDeadAMInfo.SectorsType)
			{
			case ENormalStiffSectorsType.AllForward:
				return EAttackerArea.Forward;
			case ENormalStiffSectorsType.ForwardAndBackward:
				if (num >= normalStiffRotateForwardLeft_FNB && num < normalStiffRotateForwardRight_FNB)
				{
					return EAttackerArea.Forward;
				}
				return EAttackerArea.Backward;
			case ENormalStiffSectorsType.FourDir:
				if (num >= normalStiffRotateForwardLeft_FourDir && num < normalStiffRotateForwardRight_FourDir)
				{
					return EAttackerArea.Forward;
				}
				if (num >= normalStiffRotateBackwardLeft_FourDir && num <= normalStiffRotateForwardLeft_FourDir)
				{
					return EAttackerArea.LeftSide;
				}
				if (num <= normalStiffRotateBackwardRight_FourDir && num >= normalStiffRotateForwardRight_FourDir)
				{
					return EAttackerArea.RightSide;
				}
				return EAttackerArea.Backward;
			}
		}
		return EAttackerArea.Forward;
	}

	public static void GetActualStiffLevelInfo(int StiffLevel, BGWDataAsset_UnitBeAttackedConfig NowUseUBAConfig, out bool IsValid, out FNormalStiffInfo NormalStiffInfo)
	{
		NormalStiffInfo = default(FNormalStiffInfo);
		IsValid = false;
		if (NowUseUBAConfig == null || NowUseUBAConfig.NormalStiffInfoList == null || NowUseUBAConfig.NormalStiffInfoList.Count == 0)
		{
			return;
		}
		List<FNormalStiffInfo> list = NowUseUBAConfig.NormalStiffInfoList.ToList();
		foreach (FNormalStiffInfo item in list)
		{
			if (item.StiffLevelID != StiffLevel)
			{
				continue;
			}
			if (item.IsEnableReuse)
			{
				foreach (FNormalStiffInfo item2 in list)
				{
					if (item2.StiffLevelID == item.StiffLevelReuseID)
					{
						IsValid = true;
						NormalStiffInfo = item2;
						return;
					}
				}
			}
			IsValid = true;
			NormalStiffInfo = item;
			break;
		}
	}

	public static void GetActualStiffLevelInfo(int StiffLevel, BGWDataAsset_UnitDeathDispConfig NowUseUDDConfig, out bool IsValid, out FNormalDeadAMInfo NormalDeadAMInfo)
	{
		NormalDeadAMInfo = default(FNormalDeadAMInfo);
		IsValid = false;
		if (NowUseUDDConfig == null || NowUseUDDConfig.NormalDeadAMInfoList == null || NowUseUDDConfig.NormalDeadAMInfoList.Count == 0)
		{
			return;
		}
		List<FNormalDeadAMInfo> list = NowUseUDDConfig.NormalDeadAMInfoList.ToList();
		foreach (FNormalDeadAMInfo item in list)
		{
			if (item.StiffLevelID != StiffLevel)
			{
				continue;
			}
			if (item.IsEnableReuse)
			{
				foreach (FNormalDeadAMInfo item2 in list)
				{
					if (item2.StiffLevelID == item.StiffLevelReuseID)
					{
						IsValid = true;
						NormalDeadAMInfo = item2;
						return;
					}
				}
			}
			IsValid = true;
			NormalDeadAMInfo = item;
			break;
		}
	}

	public static EHitItemFXType GetPartItemFXType(int PartID, int ResID, int CurrentBeAttackedInfoID, in IBUC_PartMgrData PartMgrData)
	{
		EHitItemFXType result = EHitItemFXType.NormalBody;
		PartInfoData PartInfoOut;
		if (PartID == -1)
		{
			Dictionary<int, List<FUStBeAttackedDispInfoDesc>> beAttackedDispInfoDescDictByResID = BGW_GameDB.GetBeAttackedDispInfoDescDictByResID(ResID);
			if (beAttackedDispInfoDescDictByResID != null)
			{
				if (!beAttackedDispInfoDescDictByResID.TryGetValue(CurrentBeAttackedInfoID, out var value))
				{
					beAttackedDispInfoDescDictByResID.TryGetValue(0, out value);
				}
				if (value != null && value.Count > 0)
				{
					foreach (FUStBeAttackedDispInfoDesc item in value)
					{
						if (item != null && item.PartRuleID == 0)
						{
							result = item.HitItemFXType;
							break;
						}
					}
				}
			}
		}
		else if (PartMgrData != null && PartMgrData.GetPartInfo(PartID, out PartInfoOut))
		{
			result = PartInfoOut.PartItemFXType;
		}
		return result;
	}

	public static EHitItemAudioType GetPartItemAudioType(int PartID, int ResID, int CurrentBeAttackedInfoID, in IBUC_PartMgrData PartMgrData)
	{
		EHitItemAudioType result = EHitItemAudioType.NormalBody;
		PartInfoData PartInfoOut;
		if (PartID == -1)
		{
			Dictionary<int, List<FUStBeAttackedDispInfoDesc>> beAttackedDispInfoDescDictByResID = BGW_GameDB.GetBeAttackedDispInfoDescDictByResID(ResID);
			if (beAttackedDispInfoDescDictByResID != null)
			{
				if (!beAttackedDispInfoDescDictByResID.TryGetValue(CurrentBeAttackedInfoID, out var value))
				{
					beAttackedDispInfoDescDictByResID.TryGetValue(0, out value);
				}
				if (value != null && value.Count > 0)
				{
					foreach (FUStBeAttackedDispInfoDesc item in value)
					{
						if (item != null && item.PartRuleID == 0)
						{
							result = item.HitItemAudioType;
							break;
						}
					}
				}
			}
		}
		else if (PartMgrData != null && PartMgrData.GetPartInfo(PartID, out PartInfoOut))
		{
			result = PartInfoOut.PartItemAudioType;
		}
		return result;
	}

	public static int GetHitPartID(BGUCharacterCS VictimChr, in IBUC_PartMgrData VictimPartMgrData, AActor Attacker, FName BoneName)
	{
		int result = -1;
		int num = -1;
		if (VictimChr == null || Attacker == null)
		{
			return result;
		}
		if (!VictimPartMgrData.GetAllPartInfo(out var PartInfoDataDic))
		{
			return result;
		}
		if (PartInfoDataDic.Count <= 0)
		{
			return result;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(VictimChr);
		FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker) - BGUFuncLibActorTransformCS.BGUGetActorLocation(VictimChr);
		float num2 = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(fVector.GetSafeNormal2D(), fVector2.GetSafeNormal2D());
		foreach (KeyValuePair<int, PartInfoData> item in PartInfoDataDic)
		{
			if (!item.Value.IsActive || item.Value.IsBreak)
			{
				continue;
			}
			if (item.Value.HitPartRuleType == EHitPartRuleType.ByDir)
			{
				if (!item.Value.BeHitDirectionRootName.Equals(""))
				{
					foreach (UActorComponent item2 in VictimChr.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
					{
						if (item2.GetName().Equals(item.Value.BeHitDirectionRootName))
						{
							num2 = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(item2.Cast<UPrimitiveComponent>().GetForwardVector().GetSafeNormal2D(), fVector2.GetSafeNormal2D());
							break;
						}
					}
				}
				if (num2 >= item.Value.LeftAngle && num2 <= item.Value.RightAngle)
				{
					return item.Key;
				}
			}
			else if (item.Value.HitPartRuleType == EHitPartRuleType.ByExclude && num == -1)
			{
				num = item.Key;
			}
		}
		BoneName = new FName(StringParseHelper.SafeToLower(BoneName.ToString()));
		result = GetPartIDByBoneName(VictimChr, in VictimPartMgrData, BoneName);
		if (VictimPartMgrData.GetPartInfo(result, out var PartInfoOut) && (!PartInfoOut.IsActive || PartInfoOut.IsBreak))
		{
			result = -1;
		}
		if (result == -1)
		{
			result = num;
		}
		return result;
	}

	private static int GetPartIDByBoneName(BGUCharacterCS VictimChr, in IBUC_PartMgrData VictimPartMgrData, FName BoneName)
	{
		int num = -1;
		if (VictimChr == null)
		{
			return num;
		}
		USkeletalMeshComponent mesh = VictimChr.Mesh;
		if (mesh == null)
		{
			return num;
		}
		if (mesh.GetBoneIndex(BoneName) == -1)
		{
			return num;
		}
		while (BoneName != FName.None)
		{
			num = GetBoneMatchPartID(in VictimPartMgrData, BoneName.ToString());
			if (num != -1)
			{
				break;
			}
			BoneName = mesh.GetParentBone(BoneName);
		}
		return num;
	}

	private static int GetBoneMatchPartID(in IBUC_PartMgrData VictimPartMgrData, string BoneName)
	{
		if (!VictimPartMgrData.GetAllPartInfo(out var PartInfoDataDic))
		{
			return -1;
		}
		foreach (KeyValuePair<int, PartInfoData> item in PartInfoDataDic)
		{
			foreach (string item2 in item.Value.RootBoneName)
			{
				if (item2.Equals(BoneName))
				{
					return item.Key;
				}
			}
		}
		return -1;
	}

	public static FVector GetHitActionDirVector(EHitActionDir HitActionDir)
	{
		FVector zeroVector = FVector.ZeroVector;
		switch (HitActionDir)
		{
		case EHitActionDir.Default:
			switch (UB1Util.GetRandomNumberInt(1, 6))
			{
			case 1:
				zeroVector.X = 1f;
				break;
			case 2:
				zeroVector.X = -1f;
				break;
			case 3:
				zeroVector.Y = 1f;
				break;
			case 4:
				zeroVector.Y = -1f;
				break;
			case 5:
				zeroVector.Z = 1f;
				break;
			case 6:
				zeroVector.Z = -1f;
				break;
			}
			break;
		case EHitActionDir.Front:
			zeroVector.X = 1f;
			break;
		case EHitActionDir.Back:
			zeroVector.X = -1f;
			break;
		case EHitActionDir.Left:
			zeroVector.Y = 1f;
			break;
		case EHitActionDir.Right:
			zeroVector.Y = -1f;
			break;
		case EHitActionDir.Up:
			zeroVector.Z = 1f;
			break;
		case EHitActionDir.Down:
			zeroVector.Z = -1f;
			break;
		}
		return zeroVector;
	}

	public static float GetBestSwitchPhysicsPosInDeadMontage(UAnimMontage InMontage, float Thresholds, FName BoneName)
	{
		float num = 0f;
		float num2 = float.MinValue;
		float num3 = 0f;
		float num4 = float.MaxValue;
		float playLength = InMontage.GetPlayLength();
		for (float num5 = 0f; num5 < playLength; num5 += 0.05f)
		{
			FTransform fTransform = UGSE_AnimFuncLib.Montage_GetBoneTransformCS(InMontage, num5, BoneName, FName.None, bExtractRootMotion: true);
			float z = fTransform.GetLocation().Z;
			if (z <= num4)
			{
				num4 = fTransform.GetLocation().Z;
				num3 = num5;
			}
			if (z >= num2)
			{
				num2 = fTransform.GetLocation().Z;
				num = num5;
				num4 = fTransform.GetLocation().Z;
				num3 = num5;
			}
		}
		if (num3 < num)
		{
			num3 = num;
		}
		num = MathLib.Clamp(num, 0f, playLength);
		return (num3 - num) * Thresholds + num;
	}
}
