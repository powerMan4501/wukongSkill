using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[BlueprintSpawnableComponent]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp")]
public class BUS_LeavesSkillManageComp : UBaseActorCompTickable
{
	private static FName PN_SkillStageIndex;

	private static FName PN_SKMCenterPosWS;

	private static FName PN_SkillSKM;

	private static FName PN_HitDir;

	private static FName PN_AbStageTime;

	private static FName PN_FlyStageMaxTime;

	private static FName PN_ScatterStageTime;

	private List<UNiagaraComponent> FXComps;

	private USkeletalMeshComponent SKMComp;

	private bool InitOver;

	private float TimeACC;

	private int SkillStageIndex;

	private FHitResult TempHit;

	private FVector SKMBeginPosWS;

	private FVector4 StageDuration4ACC;

	private bool SkillLoopStart;

	private bool SkillLoopEnd;

	private bool HitUnit_Execute;

	private bool HitWorldItem_Execute;

	private bool DeathWithNoHit_Execute;

	private static bool FXTag_IsValid;

	private static int FXTag_Offset;

	private static bool PreStageTime_IsValid;

	private static int PreStageTime_Offset;

	private static bool AbsorbStageTime_IsValid;

	private static int AbsorbStageTime_Offset;

	private static bool FlyStageMaxTime_IsValid;

	private static int FlyStageMaxTime_Offset;

	private static bool ScatterStageTime_IsValid;

	private static int ScatterStageTime_Offset;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "组件初始化时根据此tag查找场景内的特效，向这些特效传递参数")]
	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:FXTag")]
	public FName FXTag
	{
		get
		{
			CheckDestroyed();
			if (!FXTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:FXTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, FXTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FXTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:FXTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, FXTag_Offset), value);
			}
		}
	}

	[Tooltip("子弹创建后，经过 PreStageTime 才开始吸收阶段")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:PreStageTime")]
	public float PreStageTime
	{
		get
		{
			CheckDestroyed();
			if (!PreStageTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:PreStageTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PreStageTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreStageTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:PreStageTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PreStageTime_Offset), value);
			}
		}
	}

	[Tooltip("吸收阶段时间")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:AbsorbStageTime")]
	public float AbsorbStageTime
	{
		get
		{
			CheckDestroyed();
			if (!AbsorbStageTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:AbsorbStageTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AbsorbStageTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AbsorbStageTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:AbsorbStageTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AbsorbStageTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("子弹处于飞行阶段时如果没命中则达到最大飞行时间后进入自然消散阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:FlyStageMaxTime")]
	public float FlyStageMaxTime
	{
		get
		{
			CheckDestroyed();
			if (!FlyStageMaxTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:FlyStageMaxTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlyStageMaxTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlyStageMaxTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:FlyStageMaxTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlyStageMaxTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("爆炸消散或自然消散阶段持续时间")]
	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:ScatterStageTime")]
	public float ScatterStageTime
	{
		get
		{
			CheckDestroyed();
			if (!ScatterStageTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:ScatterStageTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScatterStageTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScatterStageTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_LeavesSkillManageComp:ScatterStageTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScatterStageTime_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		PreStageTime = 0f;
		AbsorbStageTime = 3f;
		FlyStageMaxTime = 999f;
		ScatterStageTime = 1f;
		FXTag = B1GlobalFNames.SheLeavesSkillFX;
	}

	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		Init();
		StageDuration4ACC.X = PreStageTime + AbsorbStageTime;
		StageDuration4ACC.Y = StageDuration4ACC.X + FlyStageMaxTime;
		StageDuration4ACC.Z = StageDuration4ACC.Y + ScatterStageTime;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnProjectileCustomSweepHitNormalUnit += new Del_OnProjectileCustomSweepHitNormalUnit(OnHitNormalUnit);
			bUS_GSEventCollection.Evt_OnProjectileCustomSweepHitWorldItem += new Del_OnProjectileCustomSweepHitWorldItem(OnHitWorldItem);
			bUS_GSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
		}
	}

	private void Init()
	{
		InitOver = false;
		if (!BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.UseWEFM || FXTag == FName.None)
		{
			return;
		}
		TimeACC = 0f;
		SkillStageIndex = -1;
		List<AActor> OutActors = new List<AActor>();
		UGameplayStatics.GetAllActorsWithTag(GetOwner(), FXTag, out OutActors);
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		float num = float.MaxValue;
		AActor aActor = null;
		foreach (AActor item in OutActors)
		{
			float num2 = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(item), v);
			if (num2 < num)
			{
				aActor = item;
				num = num2;
			}
		}
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		List<UActorComponent> componentsByClass = GetOwner().GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
		List<UActorComponent> componentsByClass2 = aActor.GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
		FXComps = new List<UNiagaraComponent>(componentsByClass2.Count + componentsByClass.Count);
		for (int i = 0; i < componentsByClass2.Count; i++)
		{
			FXComps.Add(componentsByClass2[i] as UNiagaraComponent);
		}
		for (int j = 0; j < componentsByClass.Count; j++)
		{
			FXComps.Add(componentsByClass[j] as UNiagaraComponent);
		}
		if (FXComps.Count == 0)
		{
			return;
		}
		List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), FXTag);
		if (componentsByTag.Count != 0)
		{
			SKMComp = componentsByTag[0] as USkeletalMeshComponent;
			for (int k = 0; k < FXComps.Count; k++)
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(FXComps[k], PN_SkillSKM.PlainName, SKMComp);
				FXComps[k].SetFloatParameter(PN_AbStageTime, AbsorbStageTime);
				FXComps[k].SetFloatParameter(PN_FlyStageMaxTime, FlyStageMaxTime);
				FXComps[k].SetFloatParameter(PN_ScatterStageTime, ScatterStageTime);
			}
			SKMBeginPosWS = SKMComp.GetWorldLocation();
			SkillLoopStart = true;
			InitOver = true;
		}
	}

	private int GetSkillStageIndex(EBulletWFEventType EventType)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null)
		{
			return -1;
		}
		FUStBulletWindFieldExpandDesc bulletWindFieldExpandDesc = BGW_GameDB.GetBulletWindFieldExpandDesc(bGUProjectileBaseActor.GetProjectileID());
		if (bulletWindFieldExpandDesc == null)
		{
			return -1;
		}
		EBulletWindFieldActionType actionType = EBulletWindFieldActionType.None;
		switch (EventType)
		{
		case EBulletWFEventType.HitItem:
			actionType = bulletWindFieldExpandDesc.HitItemActionType;
			break;
		case EBulletWFEventType.HitUnit:
			actionType = bulletWindFieldExpandDesc.HitUnitActionType;
			break;
		case EBulletWFEventType.LifeOverDestroy:
			actionType = bulletWindFieldExpandDesc.LifeOverDestroyActionType;
			break;
		case EBulletWFEventType.EffectDestroy:
			actionType = bulletWindFieldExpandDesc.EffectDestroyActionType;
			break;
		}
		return GetSkillStageIndex_ByActionType(actionType);
	}

	private int GetSkillStageIndex_ByActionType(EBulletWindFieldActionType ActionType)
	{
		return ActionType switch
		{
			EBulletWindFieldActionType.Explode => 2, 
			EBulletWindFieldActionType.AutoRelease => 3, 
			_ => -1, 
		};
	}

	private void OnHitNormalUnit(FUStGSHitResult CurGSHitResult)
	{
		if (!InitOver || bAlreadyTriggerFinalStage())
		{
			return;
		}
		int skillStageIndex = GetSkillStageIndex(EBulletWFEventType.HitUnit);
		if (skillStageIndex != -1)
		{
			HitUnit_Execute = true;
			for (int i = 0; i < FXComps.Count; i++)
			{
				FXComps[i].SetIntParameter(PN_SkillStageIndex, skillStageIndex);
				FXComps[i].SetVariableVec3(PN_HitDir, CurGSHitResult.Normal);
			}
		}
	}

	private void OnHitWorldItem(FEffectInstReq EffectInstReq, AActor BeHitActor)
	{
		if (!InitOver || bAlreadyTriggerFinalStage())
		{
			return;
		}
		int skillStageIndex = GetSkillStageIndex(EBulletWFEventType.HitItem);
		if (skillStageIndex != -1)
		{
			HitWorldItem_Execute = true;
			for (int i = 0; i < FXComps.Count; i++)
			{
				FXComps[i].SetIntParameter(PN_SkillStageIndex, skillStageIndex);
				FXComps[i].SetVariableVec3(PN_HitDir, EffectInstReq.HitPointNormalDir.Conv_RotatorToVector());
			}
		}
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		if (!InitOver || bAlreadyTriggerFinalStage())
		{
			return;
		}
		int num = -1;
		switch (Reason)
		{
		case EBGUBulletDestroyReason.TimeOutDestroy:
			num = GetSkillStageIndex(EBulletWFEventType.LifeOverDestroy);
			break;
		case EBGUBulletDestroyReason.EffectDestroy:
			num = GetSkillStageIndex(EBulletWFEventType.EffectDestroy);
			break;
		}
		if (num != -1)
		{
			DeathWithNoHit_Execute = true;
			for (int i = 0; i < FXComps.Count; i++)
			{
				FXComps[i].SetIntParameter(PN_SkillStageIndex, num);
			}
		}
	}

	private bool bAlreadyTriggerFinalStage()
	{
		if (!DeathWithNoHit_Execute && !HitWorldItem_Execute)
		{
			return HitUnit_Execute;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		base.TickComponentInCS_Implementation(DeltaTime);
		if (!InitOver || !SkillLoopStart || SkillLoopEnd)
		{
			return;
		}
		TimeACC += DeltaTime;
		if (HitUnit_Execute || HitWorldItem_Execute)
		{
			SkillStageIndex = 2;
			TimeACC = 0f;
			HitUnit_Execute = false;
			HitWorldItem_Execute = false;
		}
		if (DeathWithNoHit_Execute)
		{
			SkillStageIndex = 3;
			TimeACC = 0f;
			DeathWithNoHit_Execute = false;
		}
		if (SkillStageIndex == 2 || SkillStageIndex == 3)
		{
			if (TimeACC >= ScatterStageTime)
			{
				SkillStageIndex = -1;
				SkillLoopEnd = true;
			}
		}
		else if (TimeACC >= PreStageTime && TimeACC < StageDuration4ACC.X)
		{
			SkillStageIndex = 0;
		}
		else if (TimeACC >= StageDuration4ACC.X && TimeACC < StageDuration4ACC.Y)
		{
			SkillStageIndex = 1;
		}
		else
		{
			SkillStageIndex = -1;
		}
		switch (SkillStageIndex)
		{
		case -1:
		{
			for (int j = 0; j < FXComps.Count; j++)
			{
				FXComps[j].SetIntParameter(PN_SkillStageIndex, -1);
			}
			break;
		}
		case 0:
		{
			_ = (TimeACC - PreStageTime) / AbsorbStageTime;
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
			SKMComp.SetWorldLocation(fVector2, bSweep: true, out TempHit, bTeleport: false);
			for (int k = 0; k < FXComps.Count; k++)
			{
				FXComps[k].SetIntParameter(PN_SkillStageIndex, 0);
				FXComps[k].SetVectorParameter(PN_SKMCenterPosWS, fVector2);
			}
			break;
		}
		case 1:
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
			FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
			SKMComp.SetWorldLocationAndRotation(fVector, newRotation, bSweep: true, out TempHit, bTeleport: false);
			for (int i = 0; i < FXComps.Count; i++)
			{
				FXComps[i].SetIntParameter(PN_SkillStageIndex, 1);
				FXComps[i].SetVectorParameter(PN_SKMCenterPosWS, fVector);
			}
			break;
		}
		case 2:
		case 3:
			break;
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_LeavesSkillManageComp:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		base.EndPlayInCS_Implementation(EndPlayReason);
		if (!InitOver)
		{
			return;
		}
		for (int i = 0; i < FXComps.Count; i++)
		{
			if (!FXComps[i].IsNullOrDestroyed())
			{
				FXComps[i].SetIntParameter(PN_SkillStageIndex, -1);
			}
		}
	}

	static BUS_LeavesSkillManageComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_LeavesSkillManageComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_LeavesSkillManageComp));
		PN_SkillStageIndex = B1GlobalFNames.GS_SkillStage;
		PN_SKMCenterPosWS = B1GlobalFNames.GS_SKMCenterPosWS;
		PN_SkillSKM = B1GlobalFNames.GS_SkillSKM;
		PN_HitDir = B1GlobalFNames.GS_HitDir;
		PN_AbStageTime = B1GlobalFNames.GS_AbStageTime;
		PN_FlyStageMaxTime = B1GlobalFNames.GS_FlyStageMaxTime;
		PN_ScatterStageTime = B1GlobalFNames.GS_ScatterStageTime;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_LeavesSkillManageComp:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_LeavesSkillManageComp bUS_LeavesSkillManageComp = GCHelper.Find<BUS_LeavesSkillManageComp>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		bUS_LeavesSkillManageComp.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_LeavesSkillManageComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_LeavesSkillManageComp bUS_LeavesSkillManageComp = GCHelper.Find<BUS_LeavesSkillManageComp>(obj);
		bUS_LeavesSkillManageComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_LeavesSkillManageComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_LeavesSkillManageComp bUS_LeavesSkillManageComp = GCHelper.Find<BUS_LeavesSkillManageComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bUS_LeavesSkillManageComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_LeavesSkillManageComp");
		FXTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXTag");
		FXTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXTag", Classes.FNameProperty);
		PreStageTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreStageTime");
		PreStageTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreStageTime", Classes.FFloatProperty);
		AbsorbStageTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbsorbStageTime");
		AbsorbStageTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbsorbStageTime", Classes.FFloatProperty);
		FlyStageMaxTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlyStageMaxTime");
		FlyStageMaxTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlyStageMaxTime", Classes.FFloatProperty);
		ScatterStageTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScatterStageTime");
		ScatterStageTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScatterStageTime", Classes.FFloatProperty);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_LeavesSkillManageComp:EndPlayInCS", EndPlayInCS_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_LeavesSkillManageComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_LeavesSkillManageComp:TickComponentInCS", TickComponentInCS_IsValid);
	}
}
