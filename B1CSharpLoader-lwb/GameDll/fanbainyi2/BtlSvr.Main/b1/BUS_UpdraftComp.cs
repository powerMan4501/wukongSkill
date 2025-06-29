using System;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UpdraftComp")]
public class BUS_UpdraftComp : UActorCompBaseUObj
{
	private BUC_UpdraftVolumeData UpdraftVolumeData;

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
		UpdraftVolumeData = RequireWritableData<BUC_UpdraftVolumeData>();
		b1.BGUUpdraftActor bGUUpdraftActor = GetOwner() as b1.BGUUpdraftActor;
		if (bGUUpdraftActor != null)
		{
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUUpdraftActor.UpdraftVolume, this, B1GlobalFNames.OnActorEnter);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(bGUUpdraftActor.UpdraftVolume, this, B1GlobalFNames.OnActorLeave);
		}
		_ = BUS_EventCollectionCS.Get(this) != null;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickCDMap(DeltaTime);
		TickCheck();
	}

	public void TickCDMap(float DeltaTime)
	{
		if (UpdraftVolumeData.CDTimerMap.Count < 1)
		{
			return;
		}
		int[] array = UpdraftVolumeData.CDTimerMap.Keys.ToArray();
		foreach (int key in array)
		{
			if (UpdraftVolumeData.CDTimerMap[key] > 0f)
			{
				UpdraftVolumeData.CDTimerMap[key] -= DeltaTime;
			}
			else
			{
				UpdraftVolumeData.CDTimerMap.Remove(key);
			}
		}
	}

	public void TickCheck()
	{
		if (UpdraftVolumeData.ActorList.Count < 1)
		{
			return;
		}
		for (int i = 0; i < UpdraftVolumeData.ActorList.Count; i++)
		{
			BGUCharacterCS bGUCharacterCS = UpdraftVolumeData.ActorList[i].Get() as BGUCharacterCS;
			if (bGUCharacterCS.IsNullOrDestroyed())
			{
				UpdraftVolumeData.ActorList.RemoveAt(i);
				i--;
			}
			else if (bGUCharacterCS.CharacterMovement.IsFalling() && !UpdraftVolumeData.CDTimerMap.ContainsKey(AActorStatics.GetEntityHash(bGUCharacterCS)))
			{
				PocessUpLogic(bGUCharacterCS);
				UpdraftVolumeData.ActorList.RemoveAt(i);
				i--;
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_UpdraftComp:OnActorEnter")]
	private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(OtherActor, EBGUSimpleState.InUpdraft, IsRemove: false);
			if (bGUCharacterCS.CharacterMovement.IsFalling() && !UpdraftVolumeData.CDTimerMap.ContainsKey(AActorStatics.GetEntityHash(bGUCharacterCS)))
			{
				PocessUpLogic(bGUCharacterCS);
				return;
			}
			TStrongObjectPtr<AActor> tStrongObjectPtr = new TStrongObjectPtr<AActor>();
			tStrongObjectPtr.Set(OtherActor);
			UpdraftVolumeData.ActorList.Add(tStrongObjectPtr);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_UpdraftComp:OnActorLeave")]
	private void OnActorLeave(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		if ((OtherActor as BGUCharacterCS).IsNullOrDestroyed())
		{
			return;
		}
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			TStrongObjectPtr<AActor> tStrongObjectPtr = new TStrongObjectPtr<AActor>();
			tStrongObjectPtr.Set(OtherActor);
			if (UpdraftVolumeData.ActorList.Contains(tStrongObjectPtr))
			{
				UpdraftVolumeData.ActorList.Remove(tStrongObjectPtr);
			}
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(OtherActor, EBGUSimpleState.InUpdraft, IsRemove: true);
		}
	}

	private void PocessUpLogic(AActor Target)
	{
		b1.BGUUpdraftActor bGUUpdraftActor = Owner as b1.BGUUpdraftActor;
		if (bGUUpdraftActor.IsNullOrDestroyed() || bGUUpdraftActor.UpVelocity <= 0f)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_JumpBreak.Invoke();
			}
			FVector fVector = bGUUpdraftActor.UpVelocity * Owner.GetActorUpVector();
			bGUCharacterCS.LaunchCharacter(fVector, bXYOverride: false, bZOverride: false);
			FVector actorLocation = bGUCharacterCS.GetActorLocation();
			FVector lineEnd = bGUCharacterCS.GetActorLocation() + fVector;
			UBGUFunctionLibraryForCS.BGUDrawLineArrow(bGUCharacterCS.World, actorLocation, lineEnd, 100f);
			if (bGUUpdraftActor.CD > 0f)
			{
				UpdraftVolumeData.CDTimerMap.Add(AActorStatics.GetEntityHash(bGUCharacterCS), bGUUpdraftActor.CD);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_UpdraftComp:OnActorEnter")]
	private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_UpdraftComp bUS_UpdraftComp = GCHelper.Find<BUS_UpdraftComp>(obj);
		AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
		bUS_UpdraftComp.OnActorEnter(overlappedActor, otherActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_UpdraftComp:OnActorLeave")]
	private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_UpdraftComp bUS_UpdraftComp = GCHelper.Find<BUS_UpdraftComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherBodyIndex_Offset));
		bUS_UpdraftComp.OnActorLeave(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_UpdraftComp");
		OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnActorEnter");
		OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
		OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
		OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
		OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_UpdraftComp:OnActorEnter", OnActorEnter_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_UpdraftComp:OnActorLeave", OnActorLeave_IsValid);
	}

	static BUS_UpdraftComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_UpdraftComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_UpdraftComp));
	}
}
