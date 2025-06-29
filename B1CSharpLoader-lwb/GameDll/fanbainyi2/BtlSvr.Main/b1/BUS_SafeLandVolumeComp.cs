using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SafeLandVolumeComp")]
public class BUS_SafeLandVolumeComp : UActorCompBaseUObj
{
	private bool FixCheck;

	private static bool OnActorEnter_IsValid;

	private static IntPtr OnActorEnter_FunctionAddress;

	private static int OnActorEnter_ParamsSize;

	private static bool OnActorEnter_OverlappedActor_IsValid;

	private static int OnActorEnter_OverlappedActor_Offset;

	private static bool OnActorEnter_OtherActor_IsValid;

	private static int OnActorEnter_OtherActor_Offset;

	private static bool OnActorLeave_IsValid;

	private static IntPtr OnActorLeave_FunctionAddress;

	private static int OnActorLeave_ParamsSize;

	private static bool OnActorLeave_OverlappedComponent_IsValid;

	private static int OnActorLeave_OverlappedComponent_Offset;

	private static bool OnActorLeave_OtherActor_IsValid;

	private static int OnActorLeave_OtherActor_Offset;

	private static bool OnActorLeave_OtherComp_IsValid;

	private static int OnActorLeave_OtherComp_Offset;

	private static bool OnActorLeave_OtherBodyIndex_IsValid;

	private static int OnActorLeave_OtherBodyIndex_Offset;

	public override void OnAttach()
	{
		b1.BGUSafeLandVolume bGUSafeLandVolume = GetOwner() as b1.BGUSafeLandVolume;
		if (bGUSafeLandVolume != null)
		{
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUSafeLandVolume.SafeLandBox, this, B1GlobalFNames.OnActorEnter);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(bGUSafeLandVolume.SafeLandBox, this, B1GlobalFNames.OnActorLeave);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (FixCheck)
		{
			return;
		}
		b1.BGUDispInteractAreaVolume bGUDispInteractAreaVolume = GetOwner() as b1.BGUDispInteractAreaVolume;
		if (bGUDispInteractAreaVolume != null)
		{
			List<AActor> OverlappingActors = new List<AActor>();
			bGUDispInteractAreaVolume.DispInteractAreaVolume.GetOverlappingActors(out OverlappingActors, null);
			foreach (AActor item in OverlappingActors)
			{
				OnActorEnter(bGUDispInteractAreaVolume, item);
			}
		}
		FixCheck = true;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SafeLandVolumeComp:OnActorEnter")]
	private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UpdateSafeLandFlag.Invoke(P1: true);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SafeLandVolumeComp:OnActorLeave")]
	private void OnActorLeave(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UpdateSafeLandFlag.Invoke(P1: false);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SafeLandVolumeComp:OnActorEnter")]
	private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SafeLandVolumeComp bUS_SafeLandVolumeComp = GCHelper.Find<BUS_SafeLandVolumeComp>(obj);
		AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
		bUS_SafeLandVolumeComp.OnActorEnter(overlappedActor, otherActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SafeLandVolumeComp:OnActorLeave")]
	private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SafeLandVolumeComp bUS_SafeLandVolumeComp = GCHelper.Find<BUS_SafeLandVolumeComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherBodyIndex_Offset));
		bUS_SafeLandVolumeComp.OnActorLeave(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_SafeLandVolumeComp");
		OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
		OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
		OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
		OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
		OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SafeLandVolumeComp:OnActorEnter", OnActorEnter_IsValid);
		OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorLeave");
		OnActorLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLeave_FunctionAddress);
		OnActorLeave_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OverlappedComponent");
		OnActorLeave_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		OnActorLeave_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherActor");
		OnActorLeave_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorLeave_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherComp");
		OnActorLeave_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		OnActorLeave_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(OnActorLeave_FunctionAddress, "OtherBodyIndex");
		OnActorLeave_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(OnActorLeave_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		OnActorLeave_IsValid = OnActorLeave_FunctionAddress != IntPtr.Zero && OnActorLeave_OverlappedComponent_IsValid && OnActorLeave_OtherActor_IsValid && OnActorLeave_OtherComp_IsValid && OnActorLeave_OtherBodyIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SafeLandVolumeComp:OnActorLeave", OnActorLeave_IsValid);
	}

	static BUS_SafeLandVolumeComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SafeLandVolumeComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SafeLandVolumeComp));
	}
}
