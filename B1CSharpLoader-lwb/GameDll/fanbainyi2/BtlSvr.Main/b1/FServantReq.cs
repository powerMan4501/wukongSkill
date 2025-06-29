using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ServantReq")]
public struct FServantReq
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:SummonID")]
	public int SummonID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:SummonInstanceID")]
	public FCalliopeGuid SummonInstanceID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:ServantTamerGuid")]
	public string ServantTamerGuid;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:Summoner")]
	public AActor Summoner;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:CatchTarget")]
	public AActor CatchTarget;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:ServantType")]
	public EServantType ServantType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:CBI")]
	public FContinueBehaviorInfo CBI;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:AnimationSyncHostGuid")]
	public string AnimationSyncHostGuid;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:SearchTargetType")]
	public EServantSearchTargetType SearchTargetType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:CooperativeSCGuid")]
	public string CooperativeSCGuid;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:DelayBornTime")]
	public float DelayBornTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BornMontage")]
	public UAnimMontage BornMontage;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BornSkill")]
	public int BornSkill;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:DelayEffectTime")]
	public float DelayEffectTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:DelaySummonTime")]
	public float DelaySummonTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BornTransform")]
	public FTransform BornTransform;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:AliveTime")]
	public float AliveTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:TamerTemplate")]
	public UClass TamerTemplate;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:MasterActor")]
	public AActor MasterActor;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:DummyServantActor")]
	public AActor DummyServantActor;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:MapEquip")]
	public Dictionary<EquipPosition, int> MapEquip;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:AttrSnapShot")]
	public List<float> AttrSnapShot;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:AttrCopyConfigDesc")]
	public List<byte> AttrCopyConfigDesc;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:bFaceToPlayer")]
	public bool bFaceToPlayer;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:InitSpeed")]
	public float InitSpeed;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BornParticle")]
	public UParticleSystem BornParticle;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BornNiagara")]
	public UNiagaraSystem BornNiagara;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BornDBC")]
	public BGWDataAsset_B1DBC BornDBC;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:BirthBuffIDs")]
	public List<int> BirthBuffIDs;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:DisappearMontagePathList")]
	public List<string> DisappearMontagePathList;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:DestroyDelayTime")]
	public float DestroyDelayTime;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ServantReq:SafeClampToLand")]
	public bool SafeClampToLand;

	private static int ServantReq_StructSize;

	private static int ServantReq_IsValid;

	private static bool SummonID_IsValid;

	private static int SummonID_Offset;

	private static bool SummonInstanceID_IsValid;

	private static int SummonInstanceID_Offset;

	private static bool ServantTamerGuid_IsValid;

	private static int ServantTamerGuid_Offset;

	private static bool Summoner_IsValid;

	private static int Summoner_Offset;

	private static bool CatchTarget_IsValid;

	private static int CatchTarget_Offset;

	private static bool ServantType_IsValid;

	private static int ServantType_Offset;

	private static FFieldAddress ServantType_PropertyAddress;

	private static bool CBI_IsValid;

	private static int CBI_Offset;

	private static bool AnimationSyncHostGuid_IsValid;

	private static int AnimationSyncHostGuid_Offset;

	private static bool SearchTargetType_IsValid;

	private static int SearchTargetType_Offset;

	private static FFieldAddress SearchTargetType_PropertyAddress;

	private static bool CooperativeSCGuid_IsValid;

	private static int CooperativeSCGuid_Offset;

	private static bool DelayBornTime_IsValid;

	private static int DelayBornTime_Offset;

	private static bool BornMontage_IsValid;

	private static int BornMontage_Offset;

	private static bool BornSkill_IsValid;

	private static int BornSkill_Offset;

	private static bool DelayEffectTime_IsValid;

	private static int DelayEffectTime_Offset;

	private static bool DelaySummonTime_IsValid;

	private static int DelaySummonTime_Offset;

	private static bool BornTransform_IsValid;

	private static int BornTransform_Offset;

	private static bool AliveTime_IsValid;

	private static int AliveTime_Offset;

	private static bool TamerTemplate_IsValid;

	private static int TamerTemplate_Offset;

	private static bool MasterActor_IsValid;

	private static int MasterActor_Offset;

	private static bool DummyServantActor_IsValid;

	private static int DummyServantActor_Offset;

	private static bool MapEquip_IsValid;

	private static int MapEquip_Offset;

	private static FFieldAddress MapEquip_PropertyAddress;

	private static bool AttrSnapShot_IsValid;

	private static int AttrSnapShot_Offset;

	private static FFieldAddress AttrSnapShot_PropertyAddress;

	private static bool AttrCopyConfigDesc_IsValid;

	private static int AttrCopyConfigDesc_Offset;

	private static FFieldAddress AttrCopyConfigDesc_PropertyAddress;

	private static bool bFaceToPlayer_IsValid;

	private static int bFaceToPlayer_Offset;

	private static FFieldAddress bFaceToPlayer_PropertyAddress;

	private static bool InitSpeed_IsValid;

	private static int InitSpeed_Offset;

	private static bool BornParticle_IsValid;

	private static int BornParticle_Offset;

	private static bool BornNiagara_IsValid;

	private static int BornNiagara_Offset;

	private static bool BornDBC_IsValid;

	private static int BornDBC_Offset;

	private static bool BirthBuffIDs_IsValid;

	private static int BirthBuffIDs_Offset;

	private static FFieldAddress BirthBuffIDs_PropertyAddress;

	private static bool DisappearMontagePathList_IsValid;

	private static int DisappearMontagePathList_Offset;

	private static FFieldAddress DisappearMontagePathList_PropertyAddress;

	private static bool DestroyDelayTime_IsValid;

	private static int DestroyDelayTime_Offset;

	private static bool SafeClampToLand_IsValid;

	private static int SafeClampToLand_Offset;

	private static FFieldAddress SafeClampToLand_PropertyAddress;

	public FServantReq Copy()
	{
		FServantReq result = this;
		if (MapEquip != null)
		{
			result.MapEquip = new Dictionary<EquipPosition, int>(MapEquip);
		}
		if (AttrSnapShot != null)
		{
			result.AttrSnapShot = new List<float>(AttrSnapShot);
		}
		if (AttrCopyConfigDesc != null)
		{
			result.AttrCopyConfigDesc = new List<byte>(AttrCopyConfigDesc);
		}
		if (BirthBuffIDs != null)
		{
			result.BirthBuffIDs = new List<int>(BirthBuffIDs);
		}
		if (DisappearMontagePathList != null)
		{
			result.DisappearMontagePathList = new List<string>(DisappearMontagePathList);
		}
		return result;
	}

	public static FServantReq FromNative(IntPtr nativeBuffer)
	{
		return new FServantReq(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FServantReq value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FServantReq FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FServantReq(IntPtr.Add(nativeBuffer, arrayIndex * ServantReq_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FServantReq value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ServantReq_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ServantReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ServantReq");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SummonID_Offset), SummonID);
		FCalliopeGuid.ToNative(IntPtr.Add(nativeStruct, SummonInstanceID_Offset), SummonInstanceID);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ServantTamerGuid_Offset), ServantTamerGuid);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Summoner_Offset), Summoner);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, CatchTarget_Offset), CatchTarget);
		EnumMarshaler<EServantType>.ToNative(IntPtr.Add(nativeStruct, ServantType_Offset), 0, ServantType_PropertyAddress.Address, ServantType);
		FContinueBehaviorInfo.ToNative(IntPtr.Add(nativeStruct, CBI_Offset), CBI);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AnimationSyncHostGuid_Offset), AnimationSyncHostGuid);
		EnumMarshaler<EServantSearchTargetType>.ToNative(IntPtr.Add(nativeStruct, SearchTargetType_Offset), 0, SearchTargetType_PropertyAddress.Address, SearchTargetType);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CooperativeSCGuid_Offset), CooperativeSCGuid);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayBornTime_Offset), DelayBornTime);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BornMontage_Offset), BornMontage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BornSkill_Offset), BornSkill);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayEffectTime_Offset), DelayEffectTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelaySummonTime_Offset), DelaySummonTime);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, BornTransform_Offset), BornTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AliveTime_Offset), AliveTime);
		UObjectMarshaler<UClass>.ToNative(IntPtr.Add(nativeStruct, TamerTemplate_Offset), TamerTemplate);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, MasterActor_Offset), MasterActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, DummyServantActor_Offset), DummyServantActor);
		new TMapCopyMarshaler<EquipPosition, int>(1, MapEquip_PropertyAddress, CachedMarshalingDelegates<EquipPosition, EnumMarshaler<EquipPosition>>.FromNative, CachedMarshalingDelegates<EquipPosition, EnumMarshaler<EquipPosition>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MapEquip_Offset), MapEquip);
		new TArrayCopyMarshaler<float>(1, AttrSnapShot_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AttrSnapShot_Offset), AttrSnapShot);
		new TArrayCopyMarshaler<byte>(1, AttrCopyConfigDesc_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AttrCopyConfigDesc_Offset), AttrCopyConfigDesc);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFaceToPlayer_Offset), 0, bFaceToPlayer_PropertyAddress.Address, bFaceToPlayer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InitSpeed_Offset), InitSpeed);
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(nativeStruct, BornParticle_Offset), BornParticle);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, BornNiagara_Offset), BornNiagara);
		UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(nativeStruct, BornDBC_Offset), BornDBC);
		new TArrayCopyMarshaler<int>(1, BirthBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BirthBuffIDs_Offset), BirthBuffIDs);
		new TArrayCopyMarshaler<string>(1, DisappearMontagePathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, DisappearMontagePathList_Offset), DisappearMontagePathList);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DestroyDelayTime_Offset), DestroyDelayTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SafeClampToLand_Offset), 0, SafeClampToLand_PropertyAddress.Address, SafeClampToLand);
	}

	public FServantReq(IntPtr nativeStruct)
	{
		if (ServantReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ServantReq");
			SummonID = 0;
			SummonInstanceID = default(FCalliopeGuid);
			ServantTamerGuid = null;
			Summoner = null;
			CatchTarget = null;
			ServantType = EServantType.None;
			CBI = default(FContinueBehaviorInfo);
			AnimationSyncHostGuid = null;
			SearchTargetType = EServantSearchTargetType.None;
			CooperativeSCGuid = null;
			DelayBornTime = 0f;
			BornMontage = null;
			BornSkill = 0;
			DelayEffectTime = 0f;
			DelaySummonTime = 0f;
			BornTransform = default(FTransform);
			AliveTime = 0f;
			TamerTemplate = null;
			MasterActor = null;
			DummyServantActor = null;
			MapEquip = null;
			AttrSnapShot = null;
			AttrCopyConfigDesc = null;
			bFaceToPlayer = false;
			InitSpeed = 0f;
			BornParticle = null;
			BornNiagara = null;
			BornDBC = null;
			BirthBuffIDs = null;
			DisappearMontagePathList = null;
			DestroyDelayTime = 0f;
			SafeClampToLand = false;
		}
		else
		{
			SummonID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SummonID_Offset));
			SummonInstanceID = FCalliopeGuid.FromNative(IntPtr.Add(nativeStruct, SummonInstanceID_Offset));
			ServantTamerGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ServantTamerGuid_Offset));
			Summoner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Summoner_Offset));
			CatchTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, CatchTarget_Offset));
			ServantType = EnumMarshaler<EServantType>.FromNative(IntPtr.Add(nativeStruct, ServantType_Offset), 0, ServantType_PropertyAddress.Address);
			CBI = FContinueBehaviorInfo.FromNative(IntPtr.Add(nativeStruct, CBI_Offset));
			AnimationSyncHostGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AnimationSyncHostGuid_Offset));
			SearchTargetType = EnumMarshaler<EServantSearchTargetType>.FromNative(IntPtr.Add(nativeStruct, SearchTargetType_Offset), 0, SearchTargetType_PropertyAddress.Address);
			CooperativeSCGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CooperativeSCGuid_Offset));
			DelayBornTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayBornTime_Offset));
			BornMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BornMontage_Offset));
			BornSkill = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BornSkill_Offset));
			DelayEffectTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayEffectTime_Offset));
			DelaySummonTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelaySummonTime_Offset));
			BornTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, BornTransform_Offset));
			AliveTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AliveTime_Offset));
			TamerTemplate = UObjectMarshaler<UClass>.FromNative(IntPtr.Add(nativeStruct, TamerTemplate_Offset));
			MasterActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, MasterActor_Offset));
			DummyServantActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, DummyServantActor_Offset));
			MapEquip = new TMapCopyMarshaler<EquipPosition, int>(1, MapEquip_PropertyAddress, CachedMarshalingDelegates<EquipPosition, EnumMarshaler<EquipPosition>>.FromNative, CachedMarshalingDelegates<EquipPosition, EnumMarshaler<EquipPosition>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MapEquip_Offset));
			AttrSnapShot = new TArrayCopyMarshaler<float>(1, AttrSnapShot_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AttrSnapShot_Offset));
			AttrCopyConfigDesc = new TArrayCopyMarshaler<byte>(1, AttrCopyConfigDesc_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AttrCopyConfigDesc_Offset));
			bFaceToPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFaceToPlayer_Offset), 0, bFaceToPlayer_PropertyAddress.Address);
			InitSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InitSpeed_Offset));
			BornParticle = UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(nativeStruct, BornParticle_Offset));
			BornNiagara = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, BornNiagara_Offset));
			BornDBC = UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(nativeStruct, BornDBC_Offset));
			BirthBuffIDs = new TArrayCopyMarshaler<int>(1, BirthBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BirthBuffIDs_Offset));
			DisappearMontagePathList = new TArrayCopyMarshaler<string>(1, DisappearMontagePathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, DisappearMontagePathList_Offset));
			DestroyDelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DestroyDelayTime_Offset));
			SafeClampToLand = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SafeClampToLand_Offset), 0, SafeClampToLand_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ServantReq");
		ServantReq_StructSize = NativeReflection.GetStructSize(intPtr);
		SummonID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonID");
		SummonID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonID", Classes.FIntProperty);
		SummonInstanceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonInstanceID");
		SummonInstanceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonInstanceID", Classes.FStructProperty);
		ServantTamerGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ServantTamerGuid");
		ServantTamerGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ServantTamerGuid", Classes.FStrProperty);
		Summoner_Offset = NativeReflection.GetPropertyOffset(intPtr, "Summoner");
		Summoner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Summoner", Classes.FObjectProperty);
		CatchTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "CatchTarget");
		CatchTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CatchTarget", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ServantType_PropertyAddress, intPtr, "ServantType");
		ServantType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ServantType");
		ServantType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ServantType", Classes.FEnumProperty);
		CBI_Offset = NativeReflection.GetPropertyOffset(intPtr, "CBI");
		CBI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CBI", Classes.FStructProperty);
		AnimationSyncHostGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationSyncHostGuid");
		AnimationSyncHostGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationSyncHostGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref SearchTargetType_PropertyAddress, intPtr, "SearchTargetType");
		SearchTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SearchTargetType");
		SearchTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SearchTargetType", Classes.FEnumProperty);
		CooperativeSCGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "CooperativeSCGuid");
		CooperativeSCGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CooperativeSCGuid", Classes.FStrProperty);
		DelayBornTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayBornTime");
		DelayBornTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayBornTime", Classes.FFloatProperty);
		BornMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornMontage");
		BornMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornMontage", Classes.FObjectProperty);
		BornSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornSkill");
		BornSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornSkill", Classes.FIntProperty);
		DelayEffectTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayEffectTime");
		DelayEffectTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayEffectTime", Classes.FFloatProperty);
		DelaySummonTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelaySummonTime");
		DelaySummonTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelaySummonTime", Classes.FFloatProperty);
		BornTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornTransform");
		BornTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornTransform", Classes.FStructProperty);
		AliveTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliveTime");
		AliveTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliveTime", Classes.FFloatProperty);
		TamerTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerTemplate");
		TamerTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerTemplate", Classes.FObjectProperty);
		MasterActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "MasterActor");
		MasterActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MasterActor", Classes.FObjectProperty);
		DummyServantActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "DummyServantActor");
		DummyServantActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DummyServantActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MapEquip_PropertyAddress, intPtr, "MapEquip");
		MapEquip_Offset = NativeReflection.GetPropertyOffset(intPtr, "MapEquip");
		MapEquip_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MapEquip", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref AttrSnapShot_PropertyAddress, intPtr, "AttrSnapShot");
		AttrSnapShot_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrSnapShot");
		AttrSnapShot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrSnapShot", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttrCopyConfigDesc_PropertyAddress, intPtr, "AttrCopyConfigDesc");
		AttrCopyConfigDesc_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrCopyConfigDesc");
		AttrCopyConfigDesc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrCopyConfigDesc", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bFaceToPlayer_PropertyAddress, intPtr, "bFaceToPlayer");
		bFaceToPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFaceToPlayer");
		bFaceToPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFaceToPlayer", Classes.FBoolProperty);
		InitSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "InitSpeed");
		InitSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InitSpeed", Classes.FFloatProperty);
		BornParticle_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornParticle");
		BornParticle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornParticle", Classes.FObjectProperty);
		BornNiagara_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornNiagara");
		BornNiagara_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornNiagara", Classes.FObjectProperty);
		BornDBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDBC");
		BornDBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDBC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BirthBuffIDs_PropertyAddress, intPtr, "BirthBuffIDs");
		BirthBuffIDs_Offset = NativeReflection.GetPropertyOffset(intPtr, "BirthBuffIDs");
		BirthBuffIDs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BirthBuffIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DisappearMontagePathList_PropertyAddress, intPtr, "DisappearMontagePathList");
		DisappearMontagePathList_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisappearMontagePathList");
		DisappearMontagePathList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisappearMontagePathList", Classes.FArrayProperty);
		DestroyDelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyDelayTime");
		DestroyDelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyDelayTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SafeClampToLand_PropertyAddress, intPtr, "SafeClampToLand");
		SafeClampToLand_Offset = NativeReflection.GetPropertyOffset(intPtr, "SafeClampToLand");
		SafeClampToLand_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SafeClampToLand", Classes.FBoolProperty);
		ServantReq_IsValid = ((intPtr != IntPtr.Zero && SummonID_IsValid && SummonInstanceID_IsValid && ServantTamerGuid_IsValid && Summoner_IsValid && CatchTarget_IsValid && ServantType_IsValid && CBI_IsValid && AnimationSyncHostGuid_IsValid && SearchTargetType_IsValid && CooperativeSCGuid_IsValid && DelayBornTime_IsValid && BornMontage_IsValid && BornSkill_IsValid && DelayEffectTime_IsValid && DelaySummonTime_IsValid && BornTransform_IsValid && AliveTime_IsValid && TamerTemplate_IsValid && MasterActor_IsValid && DummyServantActor_IsValid && MapEquip_IsValid && AttrSnapShot_IsValid && AttrCopyConfigDesc_IsValid && bFaceToPlayer_IsValid && InitSpeed_IsValid && BornParticle_IsValid && BornNiagara_IsValid && BornDBC_IsValid && BirthBuffIDs_IsValid && DisappearMontagePathList_IsValid && DestroyDelayTime_IsValid && SafeClampToLand_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ServantReq", (byte)ServantReq_IsValid != 0);
	}

	static FServantReq()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FServantReq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FServantReq));
	}
}
