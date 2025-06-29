using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlayerApproachedNotifyComp")]
public class BUS_PlayerApproachedNotifyComp : UActorCompBaseUObj
{
	private static bool PlayerApproached_BeginOverlap_IsValid;

	private static IntPtr PlayerApproached_BeginOverlap_FunctionAddress;

	private static int PlayerApproached_BeginOverlap_ParamsSize;

	private static bool PlayerApproached_BeginOverlap_OverlappedComponent_IsValid;

	private static int PlayerApproached_BeginOverlap_OverlappedComponent_Offset;

	private static bool PlayerApproached_BeginOverlap_OtherActor_IsValid;

	private static int PlayerApproached_BeginOverlap_OtherActor_Offset;

	private static bool PlayerApproached_BeginOverlap_OtherComp_IsValid;

	private static int PlayerApproached_BeginOverlap_OtherComp_Offset;

	private static bool PlayerApproached_BeginOverlap_OtherBodyIndex_IsValid;

	private static int PlayerApproached_BeginOverlap_OtherBodyIndex_Offset;

	private static bool PlayerApproached_BeginOverlap_bFromSweep_IsValid;

	private static int PlayerApproached_BeginOverlap_bFromSweep_Offset;

	private static FFieldAddress PlayerApproached_BeginOverlap_bFromSweep_PropertyAddress;

	private static bool PlayerApproached_BeginOverlap_SweepResult_IsValid;

	private static int PlayerApproached_BeginOverlap_SweepResult_Offset;

	private static FFieldAddress PlayerApproached_BeginOverlap_SweepResult_PropertyAddress;

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(IntoBattle);
	}

	public override void OnBeginPlay()
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
		if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
		{
			bGUPlayerCharacterCS.ApproachNotifyComp.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
			UBGUFunctionLibraryForCS.BGUBindOnComponentBeginOverlapEvent(bGUPlayerCharacterCS.ApproachNotifyComp, this, B1GlobalFNames.PlayerApproached_BeginOverlap);
		}
	}

	private void IntoBattle(bool IsFight)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
		if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
		{
			if (IsFight)
			{
				bGUPlayerCharacterCS.ApproachNotifyComp.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			}
			else
			{
				bGUPlayerCharacterCS.ApproachNotifyComp.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_PlayerApproachedNotifyComp:PlayerApproached_BeginOverlap")]
	private void PlayerApproached_BeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		if (!BGUFunctionLibraryCS.BGUIsUnitInBattle(OtherActor))
		{
			BUS_EventCollectionCS.Get(OtherActor)?.Evt_OnPlayerApproached.Invoke(Owner);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_PlayerApproachedNotifyComp:PlayerApproached_BeginOverlap")]
	private static void PlayerApproached_BeginOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_PlayerApproachedNotifyComp bUS_PlayerApproachedNotifyComp = GCHelper.Find<BUS_PlayerApproachedNotifyComp>(obj);
		UPrimitiveComponent overlappedComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, PlayerApproached_BeginOverlap_OverlappedComponent_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, PlayerApproached_BeginOverlap_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, PlayerApproached_BeginOverlap_OtherComp_Offset));
		int otherBodyIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, PlayerApproached_BeginOverlap_OtherBodyIndex_Offset));
		bool bFromSweep = BoolMarshaler.FromNative(IntPtr.Add(buffer, PlayerApproached_BeginOverlap_bFromSweep_Offset), 0, PlayerApproached_BeginOverlap_bFromSweep_PropertyAddress.Address);
		FHitResult sweepResult = FHitResult.FromNative(IntPtr.Add(buffer, PlayerApproached_BeginOverlap_SweepResult_Offset));
		bUS_PlayerApproachedNotifyComp.PlayerApproached_BeginOverlap(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlayerApproachedNotifyComp");
		PlayerApproached_BeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayerApproached_BeginOverlap");
		PlayerApproached_BeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayerApproached_BeginOverlap_FunctionAddress);
		PlayerApproached_BeginOverlap_OverlappedComponent_Offset = NativeReflection.GetPropertyOffset(PlayerApproached_BeginOverlap_FunctionAddress, "OverlappedComponent");
		PlayerApproached_BeginOverlap_OverlappedComponent_IsValid = NativeReflection.ValidatePropertyClass(PlayerApproached_BeginOverlap_FunctionAddress, "OverlappedComponent", Classes.FObjectProperty);
		PlayerApproached_BeginOverlap_OtherActor_Offset = NativeReflection.GetPropertyOffset(PlayerApproached_BeginOverlap_FunctionAddress, "OtherActor");
		PlayerApproached_BeginOverlap_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(PlayerApproached_BeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		PlayerApproached_BeginOverlap_OtherComp_Offset = NativeReflection.GetPropertyOffset(PlayerApproached_BeginOverlap_FunctionAddress, "OtherComp");
		PlayerApproached_BeginOverlap_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(PlayerApproached_BeginOverlap_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		PlayerApproached_BeginOverlap_OtherBodyIndex_Offset = NativeReflection.GetPropertyOffset(PlayerApproached_BeginOverlap_FunctionAddress, "OtherBodyIndex");
		PlayerApproached_BeginOverlap_OtherBodyIndex_IsValid = NativeReflection.ValidatePropertyClass(PlayerApproached_BeginOverlap_FunctionAddress, "OtherBodyIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref PlayerApproached_BeginOverlap_bFromSweep_PropertyAddress, PlayerApproached_BeginOverlap_FunctionAddress, "bFromSweep");
		PlayerApproached_BeginOverlap_bFromSweep_Offset = NativeReflection.GetPropertyOffset(PlayerApproached_BeginOverlap_FunctionAddress, "bFromSweep");
		PlayerApproached_BeginOverlap_bFromSweep_IsValid = NativeReflection.ValidatePropertyClass(PlayerApproached_BeginOverlap_FunctionAddress, "bFromSweep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PlayerApproached_BeginOverlap_SweepResult_PropertyAddress, PlayerApproached_BeginOverlap_FunctionAddress, "SweepResult");
		PlayerApproached_BeginOverlap_SweepResult_Offset = NativeReflection.GetPropertyOffset(PlayerApproached_BeginOverlap_FunctionAddress, "SweepResult");
		PlayerApproached_BeginOverlap_SweepResult_IsValid = NativeReflection.ValidatePropertyClass(PlayerApproached_BeginOverlap_FunctionAddress, "SweepResult", Classes.FStructProperty);
		PlayerApproached_BeginOverlap_IsValid = PlayerApproached_BeginOverlap_FunctionAddress != IntPtr.Zero && PlayerApproached_BeginOverlap_OverlappedComponent_IsValid && PlayerApproached_BeginOverlap_OtherActor_IsValid && PlayerApproached_BeginOverlap_OtherComp_IsValid && PlayerApproached_BeginOverlap_OtherBodyIndex_IsValid && PlayerApproached_BeginOverlap_bFromSweep_IsValid && PlayerApproached_BeginOverlap_SweepResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_PlayerApproachedNotifyComp:PlayerApproached_BeginOverlap", PlayerApproached_BeginOverlap_IsValid);
	}

	static BUS_PlayerApproachedNotifyComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PlayerApproachedNotifyComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PlayerApproachedNotifyComp));
	}
}
