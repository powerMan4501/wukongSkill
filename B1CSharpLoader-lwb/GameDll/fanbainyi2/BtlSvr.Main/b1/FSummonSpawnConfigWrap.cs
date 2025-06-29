using System;
using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap")]
public struct FSummonSpawnConfigWrap
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SummonAliveTime")]
	public float SummonAliveTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornDelayTime")]
	public float BornDelayTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornEffDisplayTime")]
	public float BornEffDisplayTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BeforeBornTime")]
	public float BeforeBornTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:TamerTemplate")]
	public UClass TamerTemplate;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SearchTargetType")]
	public EServantSearchTargetType SearchTargetType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SummonUnitRotationType")]
	public ESummonUnitRotationType SummonUnitRotationType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SummonUnitLocationType")]
	public ESummonUnitLocationType SummonUnitLocationType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SummonPointDA")]
	public BGWMonkeySummonDataAsset SummonPointDA;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:EQSTemplate")]
	public UEnvQuery EQSTemplate;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:PointSetCachedReqID")]
	public int PointSetCachedReqID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SpawnSocketName")]
	public FName SpawnSocketName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SelectPointsRandom")]
	public bool SelectPointsRandom;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SpawnScaleRange")]
	public FFloatRange SpawnScaleRange;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:UseBornSkill")]
	public bool UseBornSkill;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornSkillIDs")]
	public List<int> BornSkillIDs;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornMontages")]
	public List<UAnimMontage> BornMontages;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:CopyAttrConfigID")]
	public int CopyAttrConfigID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:IsCopyEquip")]
	public bool IsCopyEquip;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SyncBattleSC")]
	public bool SyncBattleSC;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:IsSummonerAsMaster")]
	public bool IsSummonerAsMaster;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:IsDestroyWhenSummonerDead")]
	public bool IsDestroyWhenSummonerDead;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:InitSpeed")]
	public float InitSpeed;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SpawnBirthBuff")]
	public List<int> SpawnBirthBuff;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornParticle")]
	public UParticleSystem BornParticle;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornNiagara")]
	public UNiagaraSystem BornNiagara;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:BornDBC")]
	public BGWDataAsset_B1DBC BornDBC;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:DisappearMontagePathList")]
	public List<string> DisappearMontagePathList;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:DestroyDelayTime")]
	public float DestroyDelayTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:SafeClampToLand")]
	public bool SafeClampToLand;

	[UProperty]
	[USharpPath("/Script/b1-Managed.SummonSpawnConfigWrap:EnsureBornPosCanNavToPlayer")]
	public bool EnsureBornPosCanNavToPlayer;

	private static int SummonSpawnConfigWrap_StructSize;

	private static int SummonSpawnConfigWrap_IsValid;

	private static bool SummonAliveTime_IsValid;

	private static int SummonAliveTime_Offset;

	private static bool BornDelayTime_IsValid;

	private static int BornDelayTime_Offset;

	private static bool BornEffDisplayTime_IsValid;

	private static int BornEffDisplayTime_Offset;

	private static bool BeforeBornTime_IsValid;

	private static int BeforeBornTime_Offset;

	private static bool TamerTemplate_IsValid;

	private static int TamerTemplate_Offset;

	private static bool SearchTargetType_IsValid;

	private static int SearchTargetType_Offset;

	private static FFieldAddress SearchTargetType_PropertyAddress;

	private static bool SummonUnitRotationType_IsValid;

	private static int SummonUnitRotationType_Offset;

	private static FFieldAddress SummonUnitRotationType_PropertyAddress;

	private static bool SummonUnitLocationType_IsValid;

	private static int SummonUnitLocationType_Offset;

	private static FFieldAddress SummonUnitLocationType_PropertyAddress;

	private static bool SummonPointDA_IsValid;

	private static int SummonPointDA_Offset;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool PointSetCachedReqID_IsValid;

	private static int PointSetCachedReqID_Offset;

	private static bool SpawnSocketName_IsValid;

	private static int SpawnSocketName_Offset;

	private static bool SelectPointsRandom_IsValid;

	private static int SelectPointsRandom_Offset;

	private static FFieldAddress SelectPointsRandom_PropertyAddress;

	private static bool SpawnScaleRange_IsValid;

	private static int SpawnScaleRange_Offset;

	private static bool UseBornSkill_IsValid;

	private static int UseBornSkill_Offset;

	private static FFieldAddress UseBornSkill_PropertyAddress;

	private static bool BornSkillIDs_IsValid;

	private static int BornSkillIDs_Offset;

	private static FFieldAddress BornSkillIDs_PropertyAddress;

	private static bool BornMontages_IsValid;

	private static int BornMontages_Offset;

	private static FFieldAddress BornMontages_PropertyAddress;

	private static bool CopyAttrConfigID_IsValid;

	private static int CopyAttrConfigID_Offset;

	private static bool IsCopyEquip_IsValid;

	private static int IsCopyEquip_Offset;

	private static FFieldAddress IsCopyEquip_PropertyAddress;

	private static bool SyncBattleSC_IsValid;

	private static int SyncBattleSC_Offset;

	private static FFieldAddress SyncBattleSC_PropertyAddress;

	private static bool IsSummonerAsMaster_IsValid;

	private static int IsSummonerAsMaster_Offset;

	private static FFieldAddress IsSummonerAsMaster_PropertyAddress;

	private static bool IsDestroyWhenSummonerDead_IsValid;

	private static int IsDestroyWhenSummonerDead_Offset;

	private static FFieldAddress IsDestroyWhenSummonerDead_PropertyAddress;

	private static bool InitSpeed_IsValid;

	private static int InitSpeed_Offset;

	private static bool SpawnBirthBuff_IsValid;

	private static int SpawnBirthBuff_Offset;

	private static FFieldAddress SpawnBirthBuff_PropertyAddress;

	private static bool BornParticle_IsValid;

	private static int BornParticle_Offset;

	private static bool BornNiagara_IsValid;

	private static int BornNiagara_Offset;

	private static bool BornDBC_IsValid;

	private static int BornDBC_Offset;

	private static bool DisappearMontagePathList_IsValid;

	private static int DisappearMontagePathList_Offset;

	private static FFieldAddress DisappearMontagePathList_PropertyAddress;

	private static bool DestroyDelayTime_IsValid;

	private static int DestroyDelayTime_Offset;

	private static bool SafeClampToLand_IsValid;

	private static int SafeClampToLand_Offset;

	private static FFieldAddress SafeClampToLand_PropertyAddress;

	private static bool EnsureBornPosCanNavToPlayer_IsValid;

	private static int EnsureBornPosCanNavToPlayer_Offset;

	private static FFieldAddress EnsureBornPosCanNavToPlayer_PropertyAddress;

	public static FSummonSpawnConfigWrap WrapSpawnConfig_BySummonCommDesc(int SummonID, AActor Summoner)
	{
		FUStSummonCommDesc summonCommDesc = BGW_GameDB.GetSummonCommDesc(SummonID, Summoner);
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Summoner);
		FSummonSpawnConfigWrap result = new FSummonSpawnConfigWrap
		{
			TamerTemplate = bGW_PreloadAssetMgr.TryGetCachedResourceObj<UClass>(summonCommDesc.SummonTamerTemplatePath, ELoadResourceType.SyncLoadAndCache),
			SummonAliveTime = summonCommDesc.SummonAliveTime,
			BornDelayTime = summonCommDesc.BornDelayTime,
			BornEffDisplayTime = summonCommDesc.BornEffDisplayTime,
			BeforeBornTime = summonCommDesc.BeforeBornTime,
			SelectPointsRandom = (summonCommDesc.SelectPointRandom == EGSYesNo.Yes)
		};
		switch (summonCommDesc.SummonTargetMethod)
		{
		case ESummonTargetMethod.SyncFromMaster:
			result.SearchTargetType = EServantSearchTargetType.SyncMaster;
			break;
		case ESummonTargetMethod.AcquireFromPerception:
			result.SearchTargetType = EServantSearchTargetType.ByPerception;
			break;
		}
		result.SummonUnitRotationType = summonCommDesc.SummonUnitRotationType;
		result.SummonUnitLocationType = summonCommDesc.SummonUnitLocationType;
		result.PointSetCachedReqID = summonCommDesc.PointSetCachedReqID;
		switch (result.SummonUnitLocationType)
		{
		case ESummonUnitLocationType.UseManualSpawnPoint:
			result.SummonPointDA = bGW_PreloadAssetMgr.TryGetCachedResourceObj<BGWMonkeySummonDataAsset>(summonCommDesc.SummonDataAssetsPath, ELoadResourceType.SyncLoadAndCache);
			break;
		case ESummonUnitLocationType.UseEqsdata:
			result.EQSTemplate = bGW_PreloadAssetMgr.TryGetCachedResourceObj<UEnvQuery>(summonCommDesc.SummonSpawnEQSPath, ELoadResourceType.SyncLoadAndCache);
			break;
		}
		result.UseBornSkill = summonCommDesc.UseBornSkill == EGSYesNo.Yes;
		if (result.UseBornSkill)
		{
			result.BornSkillIDs = new List<int>();
			foreach (int bornSkill in summonCommDesc.BornSkillList)
			{
				result.BornSkillIDs.Add(bornSkill);
			}
		}
		else
		{
			result.BornMontages = new List<UAnimMontage>();
			foreach (string bornMontagePath in summonCommDesc.BornMontagePathList)
			{
				UAnimMontage item = bGW_PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(bornMontagePath, ELoadResourceType.SyncLoadAndCache);
				result.BornMontages.Add(item);
			}
		}
		result.CopyAttrConfigID = summonCommDesc.CopyAttrConfigID;
		result.IsCopyEquip = summonCommDesc.IsCopyEquip == EGSYesNo.Yes;
		result.SyncBattleSC = summonCommDesc.SyncBattleSC == EGSYesNo.Yes;
		result.IsSummonerAsMaster = summonCommDesc.IsSummonerAsMaster == EGSYesNo.Yes;
		result.InitSpeed = summonCommDesc.InitSpeed;
		result.IsDestroyWhenSummonerDead = summonCommDesc.IsDestroyWhenSummonerDead == EGSYesNo.Yes;
		result.SpawnBirthBuff = new List<int>();
		foreach (int buff in summonCommDesc.BuffList)
		{
			result.SpawnBirthBuff.Add(buff);
		}
		result.DisappearMontagePathList = new List<string>();
		result.DestroyDelayTime = summonCommDesc.DestroyDelayTime;
		foreach (string disappearMontagePath in summonCommDesc.DisappearMontagePathList)
		{
			if (!disappearMontagePath.Equals(string.Empty))
			{
				result.DisappearMontagePathList.Add(disappearMontagePath);
			}
		}
		if (!string.IsNullOrEmpty(summonCommDesc.BornEffectPath))
		{
			UObject uObject = bGW_PreloadAssetMgr.TryGetCachedResourceObj<UObject>(summonCommDesc.BornEffectPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
			if (uObject != null)
			{
				result.BornDBC = uObject as BGWDataAsset_B1DBC;
				if (result.BornDBC == null)
				{
					result.BornNiagara = uObject as UNiagaraSystem;
					if (result.BornNiagara == null)
					{
						result.BornParticle = uObject as UParticleSystem;
					}
				}
			}
		}
		return result;
	}

	public static FSummonSpawnConfigWrap WrapSpawnConfig_ByHatchConfig(FHatchConfigInfo HatchConfigInfo)
	{
		FSummonSpawnConfigWrap result = new FSummonSpawnConfigWrap
		{
			SummonAliveTime = -1f,
			TamerTemplate = HatchConfigInfo.TamerClass.Value,
			BornDBC = HatchConfigInfo.SpawnDBC,
			BornMontages = new List<UAnimMontage>()
		};
		if (HatchConfigInfo.SpawnAMList != null && HatchConfigInfo.SpawnAMList.Count > 0)
		{
			result.BornMontages.AddRange(HatchConfigInfo.SpawnAMList);
		}
		result.SummonUnitRotationType = (HatchConfigInfo.bFaceToTarget ? ESummonUnitRotationType.FacingCurTarget : ESummonUnitRotationType.None);
		result.SummonUnitLocationType = ESummonUnitLocationType.UseCasterPos;
		result.SpawnSocketName = HatchConfigInfo.SpawnSocketName;
		result.BornDBC = HatchConfigInfo.SpawnDBC;
		if (HatchConfigInfo.bSyncCurTarget)
		{
			result.SearchTargetType = EServantSearchTargetType.SyncSummoner;
		}
		else
		{
			result.SearchTargetType = EServantSearchTargetType.ByPerception;
		}
		if (HatchConfigInfo.BirthBuffIDList != null && HatchConfigInfo.BirthBuffIDList.Count > 0)
		{
			result.SpawnBirthBuff.AddRange(HatchConfigInfo.BirthBuffIDList);
		}
		return result;
	}

	public static FSummonSpawnConfigWrap WrapSpawnConfig_BySpawnMonster(FHatchConfigInfo HatchConfigInfo)
	{
		FSummonSpawnConfigWrap result = new FSummonSpawnConfigWrap
		{
			SummonAliveTime = -1f,
			TamerTemplate = HatchConfigInfo.TamerClass.Value,
			BornDBC = HatchConfigInfo.SpawnDBC,
			BornMontages = new List<UAnimMontage>()
		};
		if (HatchConfigInfo.SpawnAMList != null && HatchConfigInfo.SpawnAMList.Count > 0)
		{
			result.BornMontages.AddRange(HatchConfigInfo.SpawnAMList);
		}
		result.SummonUnitRotationType = (HatchConfigInfo.bFaceToTarget ? ESummonUnitRotationType.FacingCurTarget : ESummonUnitRotationType.None);
		result.SummonUnitLocationType = ESummonUnitLocationType.UseCasterPos;
		result.SpawnSocketName = HatchConfigInfo.SpawnSocketName;
		result.BornDBC = HatchConfigInfo.SpawnDBC;
		if (HatchConfigInfo.bSyncCurTarget)
		{
			result.SearchTargetType = EServantSearchTargetType.SyncSummoner;
		}
		else
		{
			result.SearchTargetType = EServantSearchTargetType.ByPerception;
		}
		if (HatchConfigInfo.BirthBuffIDList != null && HatchConfigInfo.BirthBuffIDList.Count > 0)
		{
			result.SpawnBirthBuff.AddRange(HatchConfigInfo.BirthBuffIDList);
		}
		return result;
	}

	public FSummonSpawnConfigWrap Copy()
	{
		FSummonSpawnConfigWrap result = this;
		if (BornSkillIDs != null)
		{
			result.BornSkillIDs = new List<int>(BornSkillIDs);
		}
		if (BornMontages != null)
		{
			result.BornMontages = new List<UAnimMontage>(BornMontages);
		}
		if (SpawnBirthBuff != null)
		{
			result.SpawnBirthBuff = new List<int>(SpawnBirthBuff);
		}
		if (DisappearMontagePathList != null)
		{
			result.DisappearMontagePathList = new List<string>(DisappearMontagePathList);
		}
		return result;
	}

	public static FSummonSpawnConfigWrap FromNative(IntPtr nativeBuffer)
	{
		return new FSummonSpawnConfigWrap(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSummonSpawnConfigWrap value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSummonSpawnConfigWrap FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSummonSpawnConfigWrap(IntPtr.Add(nativeBuffer, arrayIndex * SummonSpawnConfigWrap_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSummonSpawnConfigWrap value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SummonSpawnConfigWrap_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SummonSpawnConfigWrap_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonSpawnConfigWrap");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SummonAliveTime_Offset), SummonAliveTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BornDelayTime_Offset), BornDelayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BornEffDisplayTime_Offset), BornEffDisplayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeforeBornTime_Offset), BeforeBornTime);
		UObjectMarshaler<UClass>.ToNative(IntPtr.Add(nativeStruct, TamerTemplate_Offset), TamerTemplate);
		EnumMarshaler<EServantSearchTargetType>.ToNative(IntPtr.Add(nativeStruct, SearchTargetType_Offset), 0, SearchTargetType_PropertyAddress.Address, SearchTargetType);
		EnumMarshaler<ESummonUnitRotationType>.ToNative(IntPtr.Add(nativeStruct, SummonUnitRotationType_Offset), 0, SummonUnitRotationType_PropertyAddress.Address, SummonUnitRotationType);
		EnumMarshaler<ESummonUnitLocationType>.ToNative(IntPtr.Add(nativeStruct, SummonUnitLocationType_Offset), 0, SummonUnitLocationType_PropertyAddress.Address, SummonUnitLocationType);
		UObjectMarshaler<BGWMonkeySummonDataAsset>.ToNative(IntPtr.Add(nativeStruct, SummonPointDA_Offset), SummonPointDA);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset), EQSTemplate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PointSetCachedReqID_Offset), PointSetCachedReqID);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SpawnSocketName_Offset), SpawnSocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SelectPointsRandom_Offset), 0, SelectPointsRandom_PropertyAddress.Address, SelectPointsRandom);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, SpawnScaleRange_Offset), SpawnScaleRange);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseBornSkill_Offset), 0, UseBornSkill_PropertyAddress.Address, UseBornSkill);
		new TArrayCopyMarshaler<int>(1, BornSkillIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BornSkillIDs_Offset), BornSkillIDs);
		new TArrayCopyMarshaler<UAnimMontage>(1, BornMontages_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BornMontages_Offset), BornMontages);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CopyAttrConfigID_Offset), CopyAttrConfigID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsCopyEquip_Offset), 0, IsCopyEquip_PropertyAddress.Address, IsCopyEquip);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SyncBattleSC_Offset), 0, SyncBattleSC_PropertyAddress.Address, SyncBattleSC);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSummonerAsMaster_Offset), 0, IsSummonerAsMaster_PropertyAddress.Address, IsSummonerAsMaster);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDestroyWhenSummonerDead_Offset), 0, IsDestroyWhenSummonerDead_PropertyAddress.Address, IsDestroyWhenSummonerDead);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InitSpeed_Offset), InitSpeed);
		new TArrayCopyMarshaler<int>(1, SpawnBirthBuff_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnBirthBuff_Offset), SpawnBirthBuff);
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(nativeStruct, BornParticle_Offset), BornParticle);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, BornNiagara_Offset), BornNiagara);
		UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(nativeStruct, BornDBC_Offset), BornDBC);
		new TArrayCopyMarshaler<string>(1, DisappearMontagePathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, DisappearMontagePathList_Offset), DisappearMontagePathList);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DestroyDelayTime_Offset), DestroyDelayTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SafeClampToLand_Offset), 0, SafeClampToLand_PropertyAddress.Address, SafeClampToLand);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnsureBornPosCanNavToPlayer_Offset), 0, EnsureBornPosCanNavToPlayer_PropertyAddress.Address, EnsureBornPosCanNavToPlayer);
	}

	public FSummonSpawnConfigWrap(IntPtr nativeStruct)
	{
		if (SummonSpawnConfigWrap_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SummonSpawnConfigWrap");
			SummonAliveTime = 0f;
			BornDelayTime = 0f;
			BornEffDisplayTime = 0f;
			BeforeBornTime = 0f;
			TamerTemplate = null;
			SearchTargetType = EServantSearchTargetType.None;
			SummonUnitRotationType = ESummonUnitRotationType.None;
			SummonUnitLocationType = ESummonUnitLocationType.UsePointSetCached;
			SummonPointDA = null;
			EQSTemplate = null;
			PointSetCachedReqID = 0;
			SpawnSocketName = default(FName);
			SelectPointsRandom = false;
			SpawnScaleRange = default(FFloatRange);
			UseBornSkill = false;
			BornSkillIDs = null;
			BornMontages = null;
			CopyAttrConfigID = 0;
			IsCopyEquip = false;
			SyncBattleSC = false;
			IsSummonerAsMaster = false;
			IsDestroyWhenSummonerDead = false;
			InitSpeed = 0f;
			SpawnBirthBuff = null;
			BornParticle = null;
			BornNiagara = null;
			BornDBC = null;
			DisappearMontagePathList = null;
			DestroyDelayTime = 0f;
			SafeClampToLand = false;
			EnsureBornPosCanNavToPlayer = false;
		}
		else
		{
			SummonAliveTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SummonAliveTime_Offset));
			BornDelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BornDelayTime_Offset));
			BornEffDisplayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BornEffDisplayTime_Offset));
			BeforeBornTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeforeBornTime_Offset));
			TamerTemplate = UObjectMarshaler<UClass>.FromNative(IntPtr.Add(nativeStruct, TamerTemplate_Offset));
			SearchTargetType = EnumMarshaler<EServantSearchTargetType>.FromNative(IntPtr.Add(nativeStruct, SearchTargetType_Offset), 0, SearchTargetType_PropertyAddress.Address);
			SummonUnitRotationType = EnumMarshaler<ESummonUnitRotationType>.FromNative(IntPtr.Add(nativeStruct, SummonUnitRotationType_Offset), 0, SummonUnitRotationType_PropertyAddress.Address);
			SummonUnitLocationType = EnumMarshaler<ESummonUnitLocationType>.FromNative(IntPtr.Add(nativeStruct, SummonUnitLocationType_Offset), 0, SummonUnitLocationType_PropertyAddress.Address);
			SummonPointDA = UObjectMarshaler<BGWMonkeySummonDataAsset>.FromNative(IntPtr.Add(nativeStruct, SummonPointDA_Offset));
			EQSTemplate = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset));
			PointSetCachedReqID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PointSetCachedReqID_Offset));
			SpawnSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SpawnSocketName_Offset));
			SelectPointsRandom = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SelectPointsRandom_Offset), 0, SelectPointsRandom_PropertyAddress.Address);
			SpawnScaleRange = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, SpawnScaleRange_Offset));
			UseBornSkill = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseBornSkill_Offset), 0, UseBornSkill_PropertyAddress.Address);
			BornSkillIDs = new TArrayCopyMarshaler<int>(1, BornSkillIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BornSkillIDs_Offset));
			BornMontages = new TArrayCopyMarshaler<UAnimMontage>(1, BornMontages_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BornMontages_Offset));
			CopyAttrConfigID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CopyAttrConfigID_Offset));
			IsCopyEquip = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsCopyEquip_Offset), 0, IsCopyEquip_PropertyAddress.Address);
			SyncBattleSC = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SyncBattleSC_Offset), 0, SyncBattleSC_PropertyAddress.Address);
			IsSummonerAsMaster = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSummonerAsMaster_Offset), 0, IsSummonerAsMaster_PropertyAddress.Address);
			IsDestroyWhenSummonerDead = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDestroyWhenSummonerDead_Offset), 0, IsDestroyWhenSummonerDead_PropertyAddress.Address);
			InitSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InitSpeed_Offset));
			SpawnBirthBuff = new TArrayCopyMarshaler<int>(1, SpawnBirthBuff_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnBirthBuff_Offset));
			BornParticle = UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(nativeStruct, BornParticle_Offset));
			BornNiagara = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, BornNiagara_Offset));
			BornDBC = UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(nativeStruct, BornDBC_Offset));
			DisappearMontagePathList = new TArrayCopyMarshaler<string>(1, DisappearMontagePathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, DisappearMontagePathList_Offset));
			DestroyDelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DestroyDelayTime_Offset));
			SafeClampToLand = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SafeClampToLand_Offset), 0, SafeClampToLand_PropertyAddress.Address);
			EnsureBornPosCanNavToPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnsureBornPosCanNavToPlayer_Offset), 0, EnsureBornPosCanNavToPlayer_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SummonSpawnConfigWrap");
		SummonSpawnConfigWrap_StructSize = NativeReflection.GetStructSize(intPtr);
		SummonAliveTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonAliveTime");
		SummonAliveTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonAliveTime", Classes.FFloatProperty);
		BornDelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDelayTime");
		BornDelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDelayTime", Classes.FFloatProperty);
		BornEffDisplayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornEffDisplayTime");
		BornEffDisplayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornEffDisplayTime", Classes.FFloatProperty);
		BeforeBornTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeforeBornTime");
		BeforeBornTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeforeBornTime", Classes.FFloatProperty);
		TamerTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerTemplate");
		TamerTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SearchTargetType_PropertyAddress, intPtr, "SearchTargetType");
		SearchTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SearchTargetType");
		SearchTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SearchTargetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SummonUnitRotationType_PropertyAddress, intPtr, "SummonUnitRotationType");
		SummonUnitRotationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonUnitRotationType");
		SummonUnitRotationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonUnitRotationType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SummonUnitLocationType_PropertyAddress, intPtr, "SummonUnitLocationType");
		SummonUnitLocationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonUnitLocationType");
		SummonUnitLocationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonUnitLocationType", Classes.FEnumProperty);
		SummonPointDA_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonPointDA");
		SummonPointDA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonPointDA", Classes.FObjectProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSTemplate", Classes.FObjectProperty);
		PointSetCachedReqID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointSetCachedReqID");
		PointSetCachedReqID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointSetCachedReqID", Classes.FIntProperty);
		SpawnSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnSocketName");
		SpawnSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnSocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SelectPointsRandom_PropertyAddress, intPtr, "SelectPointsRandom");
		SelectPointsRandom_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelectPointsRandom");
		SelectPointsRandom_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelectPointsRandom", Classes.FBoolProperty);
		SpawnScaleRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnScaleRange");
		SpawnScaleRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnScaleRange", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseBornSkill_PropertyAddress, intPtr, "UseBornSkill");
		UseBornSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseBornSkill");
		UseBornSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseBornSkill", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BornSkillIDs_PropertyAddress, intPtr, "BornSkillIDs");
		BornSkillIDs_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornSkillIDs");
		BornSkillIDs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornSkillIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BornMontages_PropertyAddress, intPtr, "BornMontages");
		BornMontages_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornMontages");
		BornMontages_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornMontages", Classes.FArrayProperty);
		CopyAttrConfigID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CopyAttrConfigID");
		CopyAttrConfigID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CopyAttrConfigID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsCopyEquip_PropertyAddress, intPtr, "IsCopyEquip");
		IsCopyEquip_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsCopyEquip");
		IsCopyEquip_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsCopyEquip", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SyncBattleSC_PropertyAddress, intPtr, "SyncBattleSC");
		SyncBattleSC_Offset = NativeReflection.GetPropertyOffset(intPtr, "SyncBattleSC");
		SyncBattleSC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SyncBattleSC", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsSummonerAsMaster_PropertyAddress, intPtr, "IsSummonerAsMaster");
		IsSummonerAsMaster_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsSummonerAsMaster");
		IsSummonerAsMaster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsSummonerAsMaster", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDestroyWhenSummonerDead_PropertyAddress, intPtr, "IsDestroyWhenSummonerDead");
		IsDestroyWhenSummonerDead_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsDestroyWhenSummonerDead");
		IsDestroyWhenSummonerDead_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsDestroyWhenSummonerDead", Classes.FBoolProperty);
		InitSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "InitSpeed");
		InitSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InitSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpawnBirthBuff_PropertyAddress, intPtr, "SpawnBirthBuff");
		SpawnBirthBuff_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnBirthBuff");
		SpawnBirthBuff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnBirthBuff", Classes.FArrayProperty);
		BornParticle_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornParticle");
		BornParticle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornParticle", Classes.FObjectProperty);
		BornNiagara_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornNiagara");
		BornNiagara_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornNiagara", Classes.FObjectProperty);
		BornDBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDBC");
		BornDBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDBC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DisappearMontagePathList_PropertyAddress, intPtr, "DisappearMontagePathList");
		DisappearMontagePathList_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisappearMontagePathList");
		DisappearMontagePathList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisappearMontagePathList", Classes.FArrayProperty);
		DestroyDelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyDelayTime");
		DestroyDelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyDelayTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SafeClampToLand_PropertyAddress, intPtr, "SafeClampToLand");
		SafeClampToLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "SafeClampToLand");
		SafeClampToLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SafeClampToLand", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnsureBornPosCanNavToPlayer_PropertyAddress, intPtr, "EnsureBornPosCanNavToPlayer");
		EnsureBornPosCanNavToPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnsureBornPosCanNavToPlayer");
		EnsureBornPosCanNavToPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnsureBornPosCanNavToPlayer", Classes.FBoolProperty);
		SummonSpawnConfigWrap_IsValid = ((intPtr != IntPtr.Zero && SummonAliveTime_IsValid && BornDelayTime_IsValid && BornEffDisplayTime_IsValid && BeforeBornTime_IsValid && TamerTemplate_IsValid && SearchTargetType_IsValid && SummonUnitRotationType_IsValid && SummonUnitLocationType_IsValid && SummonPointDA_IsValid && EQSTemplate_IsValid && PointSetCachedReqID_IsValid && SpawnSocketName_IsValid && SelectPointsRandom_IsValid && SpawnScaleRange_IsValid && UseBornSkill_IsValid && BornSkillIDs_IsValid && BornMontages_IsValid && CopyAttrConfigID_IsValid && IsCopyEquip_IsValid && SyncBattleSC_IsValid && IsSummonerAsMaster_IsValid && IsDestroyWhenSummonerDead_IsValid && InitSpeed_IsValid && SpawnBirthBuff_IsValid && BornParticle_IsValid && BornNiagara_IsValid && BornDBC_IsValid && DisappearMontagePathList_IsValid && DestroyDelayTime_IsValid && SafeClampToLand_IsValid && EnsureBornPosCanNavToPlayer_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SummonSpawnConfigWrap", (byte)SummonSpawnConfigWrap_IsValid != 0);
	}

	static FSummonSpawnConfigWrap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSummonSpawnConfigWrap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSummonSpawnConfigWrap));
	}
}
