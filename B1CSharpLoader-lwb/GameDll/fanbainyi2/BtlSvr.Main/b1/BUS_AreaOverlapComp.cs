using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AreaOverlapComp")]
public class BUS_AreaOverlapComp : UActorCompBaseUObj
{
	private IBUC_GuidData GuidData;

	private BUC_AreaBasicData AreaBasicData;

	private static bool OnActorEnterActor_IsValid;

	private static IntPtr OnActorEnterActor_FunctionAddress;

	private static int OnActorEnterActor_ParamsSize;

	private static bool OnActorEnterActor_OverlappedActor_IsValid;

	private static int OnActorEnterActor_OverlappedActor_Offset;

	private static bool OnActorEnterActor_OtherActor_IsValid;

	private static int OnActorEnterActor_OtherActor_Offset;

	private static bool OnActorLeaveActor_IsValid;

	private static IntPtr OnActorLeaveActor_FunctionAddress;

	private static int OnActorLeaveActor_ParamsSize;

	private static bool OnActorLeaveActor_OverlappedActor_IsValid;

	private static int OnActorLeaveActor_OverlappedActor_Offset;

	private static bool OnActorLeaveActor_OtherActor_IsValid;

	private static int OnActorLeaveActor_OtherActor_Offset;

	private static bool OnActorEnter_EnterArea_IsValid;

	private static IntPtr OnActorEnter_EnterArea_FunctionAddress;

	private static int OnActorEnter_EnterArea_ParamsSize;

	private static bool OnActorEnter_EnterArea_OverlappedComponent_IsValid;

	private static int OnActorEnter_EnterArea_OverlappedComponent_Offset;

	private static bool OnActorEnter_EnterArea_OtherActor_IsValid;

	private static int OnActorEnter_EnterArea_OtherActor_Offset;

	private static bool OnActorEnter_EnterArea_OtherComp_IsValid;

	private static int OnActorEnter_EnterArea_OtherComp_Offset;

	private static bool OnActorEnter_EnterArea_OtherBodyIndex_IsValid;

	private static int OnActorEnter_EnterArea_OtherBodyIndex_Offset;

	private static bool OnActorEnter_EnterArea_bFromSweep_IsValid;

	private static int OnActorEnter_EnterArea_bFromSweep_Offset;

	private static FFieldAddress OnActorEnter_EnterArea_bFromSweep_PropertyAddress;

	private static bool OnActorEnter_EnterArea_SweepResult_IsValid;

	private static int OnActorEnter_EnterArea_SweepResult_Offset;

	private static FFieldAddress OnActorEnter_EnterArea_SweepResult_PropertyAddress;

	private static bool OnActorLeave_EnterArea_IsValid;

	private static IntPtr OnActorLeave_EnterArea_FunctionAddress;

	private static int OnActorLeave_EnterArea_ParamsSize;

	private static bool OnActorLeave_EnterArea_OverlappedComponent_IsValid;

	private static int OnActorLeave_EnterArea_OverlappedComponent_Offset;

	private static bool OnActorLeave_EnterArea_OtherActor_IsValid;

	private static int OnActorLeave_EnterArea_OtherActor_Offset;

	private static bool OnActorLeave_EnterArea_OtherComp_IsValid;

	private static int OnActorLeave_EnterArea_OtherComp_Offset;

	private static bool OnActorLeave_EnterArea_OtherBodyIndex_IsValid;

	private static int OnActorLeave_EnterArea_OtherBodyIndex_Offset;

	public override void OnAttach()
	{
		AreaBasicData = RequireWritableData<BUC_AreaBasicData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_EnableAreaOverlap += new Del_Void(EnableOverlap);
		base.BUSEventCollection.Evt_DisableAreaOverlap += new Del_Void(DisableOverlap);
		base.BUSEventCollection.Evt_NotifyGraph += new Del_Void_BoolActor(NotifyGraph);
		BindEnterEvent();
		BindExitEvent();
		if (AreaBasicData.IngnorePlayerTrans)
		{
			base.BGSEventCollection.Evt_NotifyPossessEntityChanged += new Del_Void_EntityEntity(OnPossessEntityChanged);
		}
	}

	public override void PreBeginPlay()
	{
		base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(GuidData.GetFinalGuid());
		if (AreaBasicData.bAutoEnableOverlap)
		{
			EnableOverlap();
		}
		else
		{
			DisableOverlap();
		}
	}

	private void BindEnterEvent()
	{
		BGUAreaBase bGUAreaBase = Owner as BGUAreaBase;
		EAreaType areaType = AreaBasicData.AreaType;
		_ = 1;
		foreach (UPrimitiveComponent allEnterPrimitiveComp in bGUAreaBase.GetAllEnterPrimitiveComps())
		{
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(allEnterPrimitiveComp, this, B1GlobalFNames.OnActorEnter_EnterArea);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(allEnterPrimitiveComp, this, B1GlobalFNames.OnActorLeave_EnterArea);
		}
	}

	private void BindExitEvent()
	{
		if (AreaBasicData.AreaType != EAreaType.SimpleTrigger)
		{
			_ = 1;
			UBGUFunctionLibraryForCS.BGUBindOnActorBeginOverlapEvent(Owner, this, B1GlobalFNames.OnActorEnterActor);
			UBGUFunctionLibraryForCS.BGUBindOnActorEndOverlapEvent(Owner, this, B1GlobalFNames.OnActorLeaveActor);
		}
	}

	private void EnableOverlap()
	{
		BGUAreaBase bGUAreaBase = Owner as BGUAreaBase;
		if (!(bGUAreaBase != null))
		{
			return;
		}
		List<UPrimitiveComponent> allAreaComp = bGUAreaBase.GetAllAreaComp();
		if (allAreaComp == null)
		{
			return;
		}
		foreach (UPrimitiveComponent item in allAreaComp)
		{
			item.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
			item.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
		}
	}

	private void DisableOverlap()
	{
		BGUAreaBase bGUAreaBase = Owner as BGUAreaBase;
		if (!(bGUAreaBase != null))
		{
			return;
		}
		List<UPrimitiveComponent> allAreaComp = bGUAreaBase.GetAllAreaComp();
		if (allAreaComp == null)
		{
			return;
		}
		foreach (UPrimitiveComponent item in allAreaComp)
		{
			item.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorEnter_EnterArea")]
	private void OnActorEnter_EnterArea(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (OtherActor.IsNullOrDestroyed() || !CanTriggerOverlap(OtherActor))
		{
			return;
		}
		Entity entity_Enter = ECSExtension.ToEntity(OtherActor);
		if (AreaBasicData.EntityEnter_EnterArea(entity_Enter))
		{
			WriteLog("OnCollisionBeginOverlap");
			if (AreaBasicData.bNotifyGraph)
			{
				NotifyGraph(bIsEnter: true, OtherActor);
			}
			base.BUSEventCollection.Evt_OnActorEnterArea.Invoke(OtherActor);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorLeave_EnterArea")]
	private void OnActorLeave_EnterArea(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!OtherActor.IsNullOrDestroyed() && CanTriggerOverlap(OtherActor))
		{
			Entity entity_Exit = ECSExtension.ToEntity(OtherActor);
			AreaBasicData.EntityExit_EnterArea(entity_Exit);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorEnterActor")]
	private void OnActorEnterActor(AActor OverlappedActor, AActor OtherActor)
	{
		if (!OtherActor.IsNullOrDestroyed() && CanTriggerOverlap(OtherActor))
		{
			Entity entity_Enter = ECSExtension.ToEntity(OtherActor);
			AreaBasicData.EntityEnter_Actor(entity_Enter);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorLeaveActor")]
	private void OnActorLeaveActor(AActor OverlappedActor, AActor OtherActor)
	{
		if (OtherActor.IsNullOrDestroyed() || !CanTriggerOverlap(OtherActor))
		{
			return;
		}
		Entity entity_Exit = ECSExtension.ToEntity(OtherActor);
		if (AreaBasicData.EntityExit_Actor(entity_Exit))
		{
			WriteLog("OnCollisionEndOverlap");
			if (AreaBasicData.bNotifyGraph)
			{
				NotifyGraph(bIsEnter: false, OtherActor);
			}
			base.BUSEventCollection.Evt_OnActorLeaveArea.Invoke(OtherActor);
		}
	}

	private bool CanTriggerOverlap(AActor OtherActor)
	{
		switch (AreaBasicData.UnitFilter.UnitFilterType)
		{
		case EAreaUnitFilterType.All:
			return true;
		case EAreaUnitFilterType.Player:
			if (BGU_DataUtil.GetActorType(OtherActor) == BGU_ActorType.CharacterPlayer)
			{
				return true;
			}
			break;
		case EAreaUnitFilterType.LocalPlayer:
		{
			ACharacter character = OtherActor as ACharacter;
			return AreaBasicData.IsLocalPlayer(character);
		}
		case EAreaUnitFilterType.WukongOnly:
			if (BGU_DataUtil.GetActorResID(OtherActor) == 10)
			{
				return true;
			}
			break;
		case EAreaUnitFilterType.SpecifiedResID:
		{
			int actorResID = BGU_DataUtil.GetActorResID(OtherActor);
			if (AreaBasicData.UnitFilter.SpecifiedResIDList.Contains(actorResID))
			{
				return true;
			}
			break;
		}
		case EAreaUnitFilterType.WukongTeam:
			if (BGU_DataUtil.GetActorTeamID(OtherActor) == 1)
			{
				return true;
			}
			break;
		}
		return false;
	}

	private void OnPossessEntityChanged(Entity OldEntity, Entity NewEntity)
	{
		AreaBasicData.OnPossessEntityChanged(OldEntity, NewEntity);
	}

	protected void NotifyGraph(bool bIsEnter, AActor OtherActor)
	{
		FGameplayTag fGameplayTag = (bIsEnter ? BGW_FlowUtils.CommonTag.OverlapBegin : BGW_FlowUtils.CommonTag.OverlapEnd);
		string finalGuid = GuidData.GetFinalGuid();
		if (IsOnline())
		{
			base.BUSEventCollection.Evt_NotifyGraphClient.Invoke(finalGuid, fGameplayTag);
		}
		else
		{
			base.BGSEventCollection?.Evt_BGS_NotifyGraph.Invoke(finalGuid, fGameplayTag);
			base.BGWEventCollection?.Evt_TaskGraphNotifyGraph(finalGuid, fGameplayTag);
		}
		if (OtherActor is BGUPlayerCharacterCS)
		{
			if (bIsEnter)
			{
				base.BGWEventCollection.Evt_BGS_PlayerEnterOverlap(GuidData.GetFinalGuid());
			}
			else
			{
				base.BGWEventCollection.Evt_BGS_PlayerLeaveOverlap(GuidData.GetFinalGuid());
			}
		}
	}

	protected void WriteLog(string Log)
	{
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (AreaBasicData.IngnorePlayerTrans)
		{
			base.BGSEventCollection.Evt_NotifyPossessEntityChanged -= new Del_Void_EntityEntity(OnPossessEntityChanged);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorEnterActor")]
	private static void OnActorEnterActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_AreaOverlapComp bUS_AreaOverlapComp = GCHelper.Find<BUS_AreaOverlapComp>(obj);
		AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnterActor_OverlappedActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnterActor_OtherActor_Offset));
		bUS_AreaOverlapComp.OnActorEnterActor(overlappedActor, otherActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorLeaveActor")]
	private static void OnActorLeaveActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_AreaOverlapComp bUS_AreaOverlapComp = GCHelper.Find<BUS_AreaOverlapComp>(obj);
		AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeaveActor_OverlappedActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeaveActor_OtherActor_Offset));
		bUS_AreaOverlapComp.OnActorLeaveActor(overlappedActor, otherActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorEnter_EnterArea")]
	private static void OnActorEnter_EnterArea__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_AreaOverlapComp bUS_AreaOverlapComp = GCHelper.Find<BUS_AreaOverlapComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorEnter_EnterArea_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_EnterArea_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorEnter_EnterArea_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnActorEnter_EnterArea_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnActorEnter_EnterArea_bFromSweep_Offset), 0, OnActorEnter_EnterArea_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnActorEnter_EnterArea_SweepResult_Offset));
		bUS_AreaOverlapComp.OnActorEnter_EnterArea(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorLeave_EnterArea")]
	private static void OnActorLeave_EnterArea__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_AreaOverlapComp bUS_AreaOverlapComp = GCHelper.Find<BUS_AreaOverlapComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_EnterArea_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_EnterArea_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_EnterArea_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnActorLeave_EnterArea_OtherBodyIndex_Offset));
		bUS_AreaOverlapComp.OnActorLeave_EnterArea(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_AreaOverlapComp");
		OnActorEnterActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnterActor");
		OnActorEnterActor_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnterActor_FunctionAddress);
		OnActorEnterActor_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnterActor_FunctionAddress, "OverlappedActor");
		OnActorEnterActor_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnterActor_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		OnActorEnterActor_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnterActor_FunctionAddress, "OtherActor");
		OnActorEnterActor_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnterActor_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorEnterActor_IsValid = OnActorEnterActor_FunctionAddress != IntPtr.Zero && OnActorEnterActor_OverlappedActor_IsValid && OnActorEnterActor_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorEnterActor", OnActorEnterActor_IsValid);
		OnActorLeaveActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeaveActor");
		OnActorLeaveActor_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeaveActor_FunctionAddress);
		OnActorLeaveActor_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeaveActor_FunctionAddress, "OverlappedActor");
		OnActorLeaveActor_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeaveActor_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		OnActorLeaveActor_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeaveActor_FunctionAddress, "OtherActor");
		OnActorLeaveActor_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeaveActor_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorLeaveActor_IsValid = OnActorLeaveActor_FunctionAddress != IntPtr.Zero && OnActorLeaveActor_OverlappedActor_IsValid && OnActorLeaveActor_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorLeaveActor", OnActorLeaveActor_IsValid);
		OnActorEnter_EnterArea_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter_EnterArea");
		OnActorEnter_EnterArea_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_EnterArea_FunctionAddress);
		OnActorEnter_EnterArea_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_EnterArea_FunctionAddress, "OverlappedComponent");
		OnActorEnter_EnterArea_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_EnterArea_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnActorEnter_EnterArea_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_EnterArea_FunctionAddress, "OtherActor");
		OnActorEnter_EnterArea_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_EnterArea_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorEnter_EnterArea_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_EnterArea_FunctionAddress, "OtherComp");
		OnActorEnter_EnterArea_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_EnterArea_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnActorEnter_EnterArea_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_EnterArea_FunctionAddress, "OtherBodyIndex");
		OnActorEnter_EnterArea_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_EnterArea_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnActorEnter_EnterArea_bFromSweep_PropertyAddress, OnActorEnter_EnterArea_FunctionAddress, "bFromSweep");
		OnActorEnter_EnterArea_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_EnterArea_FunctionAddress, "bFromSweep");
		OnActorEnter_EnterArea_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_EnterArea_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnActorEnter_EnterArea_SweepResult_PropertyAddress, OnActorEnter_EnterArea_FunctionAddress, "SweepResult");
		OnActorEnter_EnterArea_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_EnterArea_FunctionAddress, "SweepResult");
		OnActorEnter_EnterArea_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_EnterArea_FunctionAddress, "SweepResult", Classes.FStructProperty);
		OnActorEnter_EnterArea_IsValid = OnActorEnter_EnterArea_FunctionAddress != IntPtr.Zero && OnActorEnter_EnterArea_OverlappedComponent_IsValid && OnActorEnter_EnterArea_OtherActor_IsValid && OnActorEnter_EnterArea_OtherComp_IsValid && OnActorEnter_EnterArea_OtherBodyIndex_IsValid && OnActorEnter_EnterArea_bFromSweep_IsValid && OnActorEnter_EnterArea_SweepResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorEnter_EnterArea", OnActorEnter_EnterArea_IsValid);
		OnActorLeave_EnterArea_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave_EnterArea");
		OnActorLeave_EnterArea_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_EnterArea_FunctionAddress);
		OnActorLeave_EnterArea_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_EnterArea_FunctionAddress, "OverlappedComponent");
		OnActorLeave_EnterArea_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_EnterArea_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnActorLeave_EnterArea_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_EnterArea_FunctionAddress, "OtherActor");
		OnActorLeave_EnterArea_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_EnterArea_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorLeave_EnterArea_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_EnterArea_FunctionAddress, "OtherComp");
		OnActorLeave_EnterArea_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_EnterArea_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnActorLeave_EnterArea_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_EnterArea_FunctionAddress, "OtherBodyIndex");
		OnActorLeave_EnterArea_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_EnterArea_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		OnActorLeave_EnterArea_IsValid = OnActorLeave_EnterArea_FunctionAddress != IntPtr.Zero && OnActorLeave_EnterArea_OverlappedComponent_IsValid && OnActorLeave_EnterArea_OtherActor_IsValid && OnActorLeave_EnterArea_OtherComp_IsValid && OnActorLeave_EnterArea_OtherBodyIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AreaOverlapComp:OnActorLeave_EnterArea", OnActorLeave_EnterArea_IsValid);
	}

	static BUS_AreaOverlapComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AreaOverlapComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AreaOverlapComp));
	}
}
