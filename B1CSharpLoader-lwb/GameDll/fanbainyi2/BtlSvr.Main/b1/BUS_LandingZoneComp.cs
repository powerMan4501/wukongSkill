using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_LandingZoneComp")]
public class BUS_LandingZoneComp : UActorCompBaseUObj
{
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

	private BUC_LandingZoneData LandingZoneData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		LandingZoneData = RequireWritableData<BUC_LandingZoneData>();
		BGULandingZoneActor bGULandingZoneActor = GetOwner() as BGULandingZoneActor;
		if (bGULandingZoneActor != null)
		{
			LandingZoneData.LandingPoints.AddRange(bGULandingZoneActor.EQSPoints.ToList());
			LandingZoneData.LandingPoints.AddRange(bGULandingZoneActor.CustomPoints.ToList());
			LandingZoneData.bEnableDebug = bGULandingZoneActor.bEnableDebug;
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>()))
		{
			UPrimitiveComponent uPrimitiveComponent = item as UPrimitiveComponent;
			if (uPrimitiveComponent == null)
			{
				continue;
			}
			uPrimitiveComponent.GetOverlappingActors(out var OverlappingActors, null);
			if (OverlappingActors != null)
			{
				foreach (AActor item2 in OverlappingActors)
				{
					OnCollisionBeginOverlap(uPrimitiveComponent, item2, null, 0, bFromSweep: false, default(FHitResult));
				}
			}
			if (uPrimitiveComponent.GetGenerateOverlapEvents())
			{
				UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(uPrimitiveComponent, this, B1GlobalFNames.OnCollisionBeginOverlap);
				UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(uPrimitiveComponent, this, B1GlobalFNames.OnCollisionEndOverlap);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_LandingZoneComp:OnCollisionBeginOverlap")]
	private void OnCollisionBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (!(OtherActor == null))
		{
			List<FVector> landingPoints = LandingZoneData.LandingPoints;
			if (landingPoints == null || landingPoints.Count != 0)
			{
				BUS_EventCollectionCS.Get(OtherActor)?.Evt_OnAddAvailableLandingPoints.Invoke(LandingZoneData.LandingPoints);
				_ = LandingZoneData.bEnableDebug;
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_LandingZoneComp:OnCollisionEndOverlap")]
	private void OnCollisionEndOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		List<FVector> landingPoints = LandingZoneData.LandingPoints;
		if (landingPoints == null || landingPoints.Count != 0)
		{
			BUS_EventCollectionCS.Get(OtherActor)?.Evt_OnRemoveAvailableLandingPoints.Invoke(LandingZoneData.LandingPoints);
			_ = LandingZoneData.bEnableDebug;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_LandingZoneComp:OnCollisionEndOverlap")]
	private static void OnCollisionEndOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_LandingZoneComp bUS_LandingZoneComp = GCHelper.Find<BUS_LandingZoneComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionEndOverlap_OtherBodyIndex_Offset));
		bUS_LandingZoneComp.OnCollisionEndOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_LandingZoneComp:OnCollisionBeginOverlap")]
	private static void OnCollisionBeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_LandingZoneComp bUS_LandingZoneComp = GCHelper.Find<BUS_LandingZoneComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_bFromSweep_Offset), 0, OnCollisionBeginOverlap_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, OnCollisionBeginOverlap_SweepResult_Offset));
		bUS_LandingZoneComp.OnCollisionBeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_LandingZoneComp");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_LandingZoneComp:OnCollisionEndOverlap", OnCollisionEndOverlap_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_LandingZoneComp:OnCollisionBeginOverlap", OnCollisionBeginOverlap_IsValid);
	}

	static BUS_LandingZoneComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_LandingZoneComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_LandingZoneComp));
	}
}
