using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Blend Physic For Death")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysicForDeath")]
internal class BANS_GSBlendPhysicForDeath : BANS_GSBase
{
	private static bool EnableWeaponAutoSwitchPhysic_IsValid;

	private static int EnableWeaponAutoSwitchPhysic_Offset;

	private static FFieldAddress EnableWeaponAutoSwitchPhysic_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[DisplayName("是否只解绑武器")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysicForDeath:EnableWeaponAutoSwitchPhysic")]
	public bool EnableWeaponAutoSwitchPhysic
	{
		get
		{
			CheckDestroyed();
			if (!EnableWeaponAutoSwitchPhysic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSBlendPhysicForDeath:EnableWeaponAutoSwitchPhysic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableWeaponAutoSwitchPhysic_Offset), 0, EnableWeaponAutoSwitchPhysic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableWeaponAutoSwitchPhysic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSBlendPhysicForDeath:EnableWeaponAutoSwitchPhysic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableWeaponAutoSwitchPhysic_Offset), 0, EnableWeaponAutoSwitchPhysic_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysicForDeath:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter != null)
		{
			if (EnableWeaponAutoSwitchPhysic)
			{
				BUS_EventCollectionCS.Get(aCharacter)?.Evt_TriggerDeadBlendPhysic.Invoke(P1: false, P2: true);
			}
			else
			{
				BUS_EventCollectionCS.Get(aCharacter)?.Evt_TriggerDeadBlendPhysic.Invoke(P1: true, P2: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBlendPhysicForDeath:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSBlendPhysicForDeath bANS_GSBlendPhysicForDeath = GCHelper.Find<b1.BANS_GSBlendPhysicForDeath>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSBlendPhysicForDeath.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSBlendPhysicForDeath");
		NativeReflection.GetPropertyRef(ref EnableWeaponAutoSwitchPhysic_PropertyAddress, intPtr, "EnableWeaponAutoSwitchPhysic");
		EnableWeaponAutoSwitchPhysic_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableWeaponAutoSwitchPhysic");
		EnableWeaponAutoSwitchPhysic_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableWeaponAutoSwitchPhysic", Classes.FBoolProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBlendPhysicForDeath:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSBlendPhysicForDeath()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSBlendPhysicForDeath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSBlendPhysicForDeath));
	}
}
