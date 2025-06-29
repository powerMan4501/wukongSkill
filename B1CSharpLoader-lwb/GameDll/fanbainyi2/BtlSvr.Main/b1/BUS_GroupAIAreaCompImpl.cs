using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaCompImpl")]
public class BUS_GroupAIAreaCompImpl : UActorCompBaseUObj
{
	private b1.BUC_GroupAIAreaData GroupAIAreaData;

	private static bool OverlapEnd_IsValid;

	private static IntPtr OverlapEnd_FunctionAddress;

	private static int OverlapEnd_ParamsSize;

	private static bool OverlapEnd_OverlappedComponent_IsValid;

	private static int OverlapEnd_OverlappedComponent_Offset;

	private static bool OverlapEnd_OtherActor_IsValid;

	private static int OverlapEnd_OtherActor_Offset;

	private static bool OverlapEnd_OtherComp_IsValid;

	private static int OverlapEnd_OtherComp_Offset;

	private static bool OverlapEnd_OtherBodyIndex_IsValid;

	private static int OverlapEnd_OtherBodyIndex_Offset;

	private static bool OverlapBegin_IsValid;

	private static IntPtr OverlapBegin_FunctionAddress;

	private static int OverlapBegin_ParamsSize;

	private static bool OverlapBegin_OverlappedActor_IsValid;

	private static int OverlapBegin_OverlappedActor_Offset;

	private static bool OverlapBegin_OtherActor_IsValid;

	private static int OverlapBegin_OtherActor_Offset;

	public override void OnAttach()
	{
		GroupAIAreaData = RequireWritableData<b1.BUC_GroupAIAreaData>();
	}

	public override void PreBeginPlay()
	{
		GroupAIAreaData.HasTriggerBegin = false;
	}

	public override void OnBeginPlay()
	{
		BGUGroupAIAreaActorBase bGUGroupAIAreaActorBase = GetOwner() as BGUGroupAIAreaActorBase;
		if (bGUGroupAIAreaActorBase != null && !bGUGroupAIAreaActorBase.IsNullOrDestroyed())
		{
			GroupAIAreaData.OverlapComp = bGUGroupAIAreaActorBase.GetBoxCollisionComponent();
			if (GroupAIAreaData.OverlapComp != null)
			{
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(GroupAIAreaData.OverlapComp, this, B1GlobalFNames.OverlapBegin);
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(GroupAIAreaData.OverlapComp, this, B1GlobalFNames.OverlapEnd);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGUGroupAIAreaActorBase bGUGroupAIAreaActorBase = GetOwner() as BGUGroupAIAreaActorBase;
		if (bGUGroupAIAreaActorBase != null && !bGUGroupAIAreaActorBase.IsNullOrDestroyed())
		{
			GroupAIAreaData.OverlapComp = bGUGroupAIAreaActorBase.GetBoxCollisionComponent();
			if (GroupAIAreaData.OverlapComp != null)
			{
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(GroupAIAreaData.OverlapComp, this, B1GlobalFNames.OverlapBegin);
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(GroupAIAreaData.OverlapComp, this, B1GlobalFNames.OverlapEnd);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForDebug();
		if (GroupAIAreaData.HasTriggerBegin || !(GroupAIAreaData.OverlapComp != null))
		{
			return;
		}
		GroupAIAreaData.OverlapComp.GetOverlappingComponents(out var OutOverlappingComponents);
		foreach (UPrimitiveComponent item in OutOverlappingComponents)
		{
			AActor owner = item.GetOwner();
			if (!(owner == null))
			{
				OverlapBegin(null, owner);
			}
		}
	}

	private void UpdateForDebug()
	{
		AActor owner = GetOwner();
		if (!(owner == null) && GSGameplayCVar.CVar_GroupAIDebugInfoEnableGroupAIAreaDebug.GetValueInGameThread() != 0 && GroupAIAreaData.OverlapComp != null)
		{
			UBoxComponent uBoxComponent = GroupAIAreaData.OverlapComp as UBoxComponent;
			if (uBoxComponent != null)
			{
				USystemLibrary.DrawDebugBox(this, owner.GetActorLocation(), uBoxComponent.GetScaledBoxExtent(), FLinearColor.Yellow, owner.GetActorRotation());
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaCompImpl:OverlapBegin")]
	protected virtual void OverlapBegin(AActor OverlappedActor, AActor OtherActor)
	{
		if (!(OtherActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(bGUCharacterCS);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.IsAI)
			{
				GroupAIAreaData.HasTriggerBegin = true;
				base.BGSEventCollection.Evt_BGS_SetNewConfigDataAsset.Invoke(GetOwner(), GroupAIAreaData.GroupAIMgrConfigDA, GroupAIAreaData.GroupAIBattleHotZoneConfigDA);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_GroupAIAreaCompImpl:OverlapEnd")]
	protected virtual void OverlapEnd(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if (!(OtherActor != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(bGUCharacterCS);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.IsAI)
			{
				GroupAIAreaData.HasTriggerBegin = false;
				base.BGSEventCollection.Evt_BGS_Try2RecoverDefaultConfigDataAsset.Invoke(GetOwner());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_GroupAIAreaCompImpl:OverlapEnd")]
	private static void OverlapEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_GroupAIAreaCompImpl bUS_GroupAIAreaCompImpl = GCHelper.Find<BUS_GroupAIAreaCompImpl>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OverlapEnd_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OverlapEnd_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OverlapEnd_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OverlapEnd_OtherBodyIndex_Offset));
		bUS_GroupAIAreaCompImpl.OverlapEnd(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_GroupAIAreaCompImpl:OverlapBegin")]
	private static void OverlapBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_GroupAIAreaCompImpl bUS_GroupAIAreaCompImpl = GCHelper.Find<BUS_GroupAIAreaCompImpl>(obj);
		AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OverlapBegin_OverlappedActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OverlapBegin_OtherActor_Offset));
		bUS_GroupAIAreaCompImpl.OverlapBegin(overlappedActor, otherActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_GroupAIAreaCompImpl");
		OverlapEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OverlapEnd");
		OverlapEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OverlapEnd_FunctionAddress);
		OverlapEnd_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OverlappedComponent");
		OverlapEnd_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OverlapEnd_OtherActor_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OtherActor");
		OverlapEnd_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OverlapEnd_OtherComp_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OtherComp");
		OverlapEnd_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OverlapEnd_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OverlapEnd_FunctionAddress, "OtherBodyIndex");
		OverlapEnd_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OverlapEnd_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		OverlapEnd_IsValid = OverlapEnd_FunctionAddress != IntPtr.Zero && OverlapEnd_OverlappedComponent_IsValid && OverlapEnd_OtherActor_IsValid && OverlapEnd_OtherComp_IsValid && OverlapEnd_OtherBodyIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_GroupAIAreaCompImpl:OverlapEnd", OverlapEnd_IsValid);
		OverlapBegin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OverlapBegin");
		OverlapBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OverlapBegin_FunctionAddress);
		OverlapBegin_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OverlapBegin_FunctionAddress, "OverlappedActor");
		OverlapBegin_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OverlapBegin_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		OverlapBegin_OtherActor_Offset = NativeReflection.GetPropertyOffset(OverlapBegin_FunctionAddress, "OtherActor");
		OverlapBegin_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OverlapBegin_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OverlapBegin_IsValid = OverlapBegin_FunctionAddress != IntPtr.Zero && OverlapBegin_OverlappedActor_IsValid && OverlapBegin_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_GroupAIAreaCompImpl:OverlapBegin", OverlapBegin_IsValid);
	}

	static BUS_GroupAIAreaCompImpl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GroupAIAreaCompImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GroupAIAreaCompImpl));
	}
}
