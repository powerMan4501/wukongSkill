using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU")]
public class BUS_ItemInteractAreaSystem_CPU : UActorCompBaseUObj
{
	private bool FixCheck;

	private static bool LocalPlayer_IsValid;

	private static int LocalPlayer_Offset;

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

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:LocalPlayer")]
	private AActor LocalPlayer
	{
		get
		{
			CheckDestroyed();
			if (!LocalPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:LocalPlayer");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, LocalPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocalPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:LocalPlayer");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, LocalPlayer_Offset), value);
			}
		}
	}

	public override void OnAttach()
	{
		BGUItemInteractArea_CPU bGUItemInteractArea_CPU = GetOwner() as BGUItemInteractArea_CPU;
		if (bGUItemInteractArea_CPU != null)
		{
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUItemInteractArea_CPU.AreaBox, this, B1GlobalFNames.OnActorEnter);
			UBGUFunctionLibraryForCS.BGUBindOnComponentEndOverlapEvent(bGUItemInteractArea_CPU.AreaBox, this, B1GlobalFNames.OnActorLeave);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!FixCheck)
		{
			BGUItemInteractArea_CPU bGUItemInteractArea_CPU = GetOwner() as BGUItemInteractArea_CPU;
			if (bGUItemInteractArea_CPU != null)
			{
				List<AActor> OverlappingActors = new List<AActor>();
				bGUItemInteractArea_CPU.AreaBox.GetOverlappingActors(out OverlappingActors, null);
				foreach (AActor item in OverlappingActors)
				{
					OnActorEnter(bGUItemInteractArea_CPU, item);
				}
			}
			FixCheck = true;
		}
		VisibleMgr();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:OnActorEnter")]
	private void OnActorEnter(AActor OverlappedActor, AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			_ = bGUCharacterCS != UGSE_EngineFuncLib.GetFirstLocalPlayerController(bGUCharacterCS).GetControlledPawn();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:OnActorLeave")]
	private void OnActorLeave(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		UWorld world = bGUCharacterCS.World;
		if (world.IsNullOrDestroyed())
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(world);
		if (!firstLocalPlayerController.IsNullOrDestroyed())
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (!controlledPawn.IsNullOrDestroyed())
			{
				_ = bGUCharacterCS != controlledPawn;
			}
		}
	}

	private void VisibleMgr()
	{
		BGUItemInteractArea_CPU bGUItemInteractArea_CPU = Owner as BGUItemInteractArea_CPU;
		if (bGUItemInteractArea_CPU.IsNullOrDestroyed())
		{
			return;
		}
		if (LocalPlayer == null)
		{
			LocalPlayer = UGSE_EngineFuncLib.GetFirstLocalPlayerController(bGUItemInteractArea_CPU.World).GetControlledPawn();
		}
		if (LocalPlayer == null)
		{
			return;
		}
		foreach (AActor item in bGUItemInteractArea_CPU.ItemList)
		{
			BGUSpiderWebActorBase bGUSpiderWebActorBase = item as BGUSpiderWebActorBase;
			if (!bGUSpiderWebActorBase.IsNullOrDestroyed())
			{
				float num = FVector.Distance(item.GetActorLocation(), LocalPlayer.GetActorLocation());
				if (bGUSpiderWebActorBase.IsActive && num > (float)bGUSpiderWebActorBase.VisibleDistance)
				{
					bGUSpiderWebActorBase.WebComp.SetVisibility(bNewVisibility: false);
					bGUSpiderWebActorBase.IsActive = false;
				}
				else if (!bGUSpiderWebActorBase.IsActive && num < (float)bGUSpiderWebActorBase.VisibleDistance)
				{
					bGUSpiderWebActorBase.WebComp.SetVisibility(bNewVisibility: true);
					bGUSpiderWebActorBase.IsActive = true;
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:OnActorEnter")]
	private static void OnActorEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ItemInteractAreaSystem_CPU bUS_ItemInteractAreaSystem_CPU = GCHelper.Find<BUS_ItemInteractAreaSystem_CPU>(obj);
		AActor overlappedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OverlappedActor_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorEnter_OtherActor_Offset));
		bUS_ItemInteractAreaSystem_CPU.OnActorEnter(overlappedActor, otherActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:OnActorLeave")]
	private static void OnActorLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ItemInteractAreaSystem_CPU bUS_ItemInteractAreaSystem_CPU = GCHelper.Find<BUS_ItemInteractAreaSystem_CPU>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnActorLeave_OtherBodyIndex_Offset));
		bUS_ItemInteractAreaSystem_CPU.OnActorLeave(overlappedComponent, otherActor, otherComp, otherBodyIndex);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU");
		LocalPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocalPlayer");
		LocalPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocalPlayer", Classes.FObjectProperty);
		OnActorEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnActorEnter");
		OnActorEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorEnter_FunctionAddress);
		OnActorEnter_OverlappedActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OverlappedActor");
		OnActorEnter_OverlappedActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		OnActorEnter_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnActorEnter_FunctionAddress, "OtherActor");
		OnActorEnter_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnActorEnter_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnActorEnter_IsValid = OnActorEnter_FunctionAddress != IntPtr.Zero && OnActorEnter_OverlappedActor_IsValid && OnActorEnter_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:OnActorEnter", OnActorEnter_IsValid);
		OnActorLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnActorLeave");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ItemInteractAreaSystem_CPU:OnActorLeave", OnActorLeave_IsValid);
	}

	static BUS_ItemInteractAreaSystem_CPU()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ItemInteractAreaSystem_CPU)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ItemInteractAreaSystem_CPU));
	}
}
