using System;
using System.Collections.Generic;
using b1.CppExport;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FlowOverlapComponent : BUS_QuestCompBase
{
	[UClass]
	[USharpPath("/Script/b1-Managed.FlowOverlapCompFunctionBinder")]
	private class UFlowOverlapCompFunctionBinder : UObject
	{
		private BUS_FlowOverlapComponent OwnerComp;

		private static bool OnCollisionEndOverlap_IsValid;

		private static IntPtr OnCollisionEndOverlap_FunctionAddress;

		private static int OnCollisionEndOverlap_ParamsSize;

		private static bool OnCollisionEndOverlap_OverlappedComponent_IsValid;

		private static int OnCollisionEndOverlap_OverlappedComponent_Offset;

		private static bool OnCollisionEndOverlap_OtherActor_IsValid;

		private static int OnCollisionEndOverlap_OtherActor_Offset;

		private static bool OnCollisionEndOverlap_OtherComp_IsValid;

		private static int OnCollisionEndOverlap_OtherComp_Offset;

		private static bool OnCollisionEndOverlap_OtherBodyIndex_IsValid;

		private static int OnCollisionEndOverlap_OtherBodyIndex_Offset;

		private static bool OnCollisionBeginOverlap_IsValid;

		private static IntPtr OnCollisionBeginOverlap_FunctionAddress;

		private static int OnCollisionBeginOverlap_ParamsSize;

		private static bool OnCollisionBeginOverlap_OverlappedComponent_IsValid;

		private static int OnCollisionBeginOverlap_OverlappedComponent_Offset;

		private static bool OnCollisionBeginOverlap_OtherActor_IsValid;

		private static int OnCollisionBeginOverlap_OtherActor_Offset;

		private static bool OnCollisionBeginOverlap_OtherComp_IsValid;

		private static int OnCollisionBeginOverlap_OtherComp_Offset;

		private static bool OnCollisionBeginOverlap_OtherBodyIndex_IsValid;

		private static int OnCollisionBeginOverlap_OtherBodyIndex_Offset;

		private static bool OnCollisionBeginOverlap_bFromSweep_IsValid;

		private static int OnCollisionBeginOverlap_bFromSweep_Offset;

		private static FFieldAddress OnCollisionBeginOverlap_bFromSweep_PropertyAddress;

		private static bool OnCollisionBeginOverlap_SweepResult_IsValid;

		private static int OnCollisionBeginOverlap_SweepResult_Offset;

		private static FFieldAddress OnCollisionBeginOverlap_SweepResult_PropertyAddress;

		public void Init(BUS_FlowOverlapComponent Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.FlowOverlapCompFunctionBinder:OnCollisionBeginOverlap")]
		private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionBeginOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
			}
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.FlowOverlapCompFunctionBinder:OnCollisionEndOverlap")]
		private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnCollisionEndOverlap(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.FlowOverlapCompFunctionBinder:OnCollisionEndOverlap")]
		private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UFlowOverlapCompFunctionBinder uFlowOverlapCompFunctionBinder = GCHelper.Find<UFlowOverlapCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
			uFlowOverlapCompFunctionBinder.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
		}

		[UFunctionInvoker("/Script/b1-Managed.FlowOverlapCompFunctionBinder:OnCollisionBeginOverlap")]
		private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
		{
			UFlowOverlapCompFunctionBinder uFlowOverlapCompFunctionBinder = GCHelper.Find<UFlowOverlapCompFunctionBinder>(obj);
			UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
			AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
			UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
			int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
			bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
			FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
			uFlowOverlapCompFunctionBinder.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FlowOverlapCompFunctionBinder");
			OnCollisionEndOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionEndOverlap");
			OnCollisionEndOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionEndOverlap_FunctionAddress);
			OnCollisionEndOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent");
			OnCollisionEndOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
			OnCollisionEndOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherActor");
			OnCollisionEndOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnCollisionEndOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherComp");
			OnCollisionEndOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
			OnCollisionEndOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex");
			OnCollisionEndOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionEndOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
			OnCollisionEndOverlap_IsValid = OnCollisionEndOverlap_FunctionAddress != IntPtr.Zero && OnCollisionEndOverlap_OverlappedComponent_IsValid && OnCollisionEndOverlap_OtherActor_IsValid && OnCollisionEndOverlap_OtherComp_IsValid && OnCollisionEndOverlap_OtherBodyIndex_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FlowOverlapCompFunctionBinder:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
			OnCollisionBeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCollisionBeginOverlap");
			OnCollisionBeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCollisionBeginOverlap_FunctionAddress);
			OnCollisionBeginOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent");
			OnCollisionBeginOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
			OnCollisionBeginOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherActor");
			OnCollisionBeginOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
			OnCollisionBeginOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherComp");
			OnCollisionBeginOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
			OnCollisionBeginOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex");
			OnCollisionBeginOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_bFromSweep_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
			OnCollisionBeginOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep");
			OnCollisionBeginOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
			NativeReflection.GetPropertyRef(ref OnCollisionBeginOverlap_SweepResult_PropertyAddress, OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
			OnCollisionBeginOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(OnCollisionBeginOverlap_FunctionAddress, "SweepResult");
			OnCollisionBeginOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(OnCollisionBeginOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
			OnCollisionBeginOverlap_IsValid = OnCollisionBeginOverlap_FunctionAddress != IntPtr.Zero && OnCollisionBeginOverlap_OverlappedComponent_IsValid && OnCollisionBeginOverlap_OtherActor_IsValid && OnCollisionBeginOverlap_OtherComp_IsValid && OnCollisionBeginOverlap_OtherBodyIndex_IsValid && OnCollisionBeginOverlap_bFromSweep_IsValid && OnCollisionBeginOverlap_SweepResult_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FlowOverlapCompFunctionBinder:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
		}

		static UFlowOverlapCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UFlowOverlapCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UFlowOverlapCompFunctionBinder));
		}
	}

	private TStrongObjectPtr<UFlowOverlapCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<UFlowOverlapCompFunctionBinder>();

	private BUC_FlowOverlapData OverlapData { get; set; }

	private List<TWeakObject<UPrimitiveComponent>> CollisionComponents { get; } = new List<TWeakObject<UPrimitiveComponent>>();

	private UFlowOverlapCompFunctionBinder FunctionBinder
	{
		get
		{
			return mFunctionBinder.Get();
		}
		set
		{
			mFunctionBinder.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		OverlapData = RequireWritableData<BUC_FlowOverlapData>();
		FunctionBinder = UObject.NewObject<UFlowOverlapCompFunctionBinder>(GetOwner());
		FunctionBinder.Init(this);
	}

	protected override void NotifyFromGraph(GameplayTagContainerRef NotifyTags)
	{
		base.NotifyFromGraph(NotifyTags);
		if (NotifyTags.HasTag(BGW_FlowUtils.CommonTag.Enable) || NotifyTags.HasTag(BGW_FlowUtils.OverlapTag.Event_Enable))
		{
			EnableOverlap();
		}
		else if (NotifyTags.HasTag(BGW_FlowUtils.CommonTag.Disable) || NotifyTags.HasTag(BGW_FlowUtils.OverlapTag.Event_Disable))
		{
			DisableOverlap();
		}
	}

	private void EnableOverlap()
	{
		if (OverlapData.bOverlapEnabled)
		{
			return;
		}
		OverlapData.bOverlapEnabled = true;
		foreach (UActorComponent item in base.Owner.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (!(uBoxComponent == null) && uBoxComponent.GetGenerateOverlapEvents())
			{
				CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(uBoxComponent));
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uBoxComponent, FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uBoxComponent, FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
				WriteLog("Enable Overlap");
			}
		}
	}

	private void DisableOverlap()
	{
		if (!OverlapData.bOverlapEnabled)
		{
			return;
		}
		OverlapData.bOverlapEnabled = false;
		foreach (TWeakObject<UPrimitiveComponent> collisionComponent in CollisionComponents)
		{
			if (collisionComponent.IsValid())
			{
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentBeginOverlapEvent(collisionComponent.Get(), FunctionBinder, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUUnBindOnComponentEndOverlapEvent(collisionComponent.Get(), FunctionBinder, B1GlobalFNames.OnCollisionEndOverlap);
				WriteLog("Disable Overlap");
			}
		}
	}

	private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		WriteLog("OnCollisionBeginOverlap");
		if (!(OtherActor == null))
		{
			BUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
			if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
			{
				NotifyGraph(BGW_FlowUtils.CommonTag.OverlapBegin);
			}
		}
	}

	private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		WriteLog("OnCollisionEndOverlap");
		NotifyGraph(BGW_FlowUtils.CommonTag.OverlapEnd);
	}
}
