using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS SlowTime_LifeSaving")]
[USharpPath("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving")]
internal class BANS_GSSlowTime_LifeSaving : BANS_GSBase
{
	private static bool TimeScaleSetting_IsValid;

	private static int TimeScaleSetting_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("救命毫毛假死状态下才启用")]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving:TimeScaleSetting")]
	public FGSTimeScaleSetting TimeScaleSetting
	{
		get
		{
			CheckDestroyed();
			if (!TimeScaleSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving:TimeScaleSetting");
				return default(FGSTimeScaleSetting);
			}
			return FGSTimeScaleSetting.FromNative(IntPtr.Add(base.Address, TimeScaleSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeScaleSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving:TimeScaleSetting");
			}
			else
			{
				FGSTimeScaleSetting.ToNative(IntPtr.Add(base.Address, TimeScaleSetting_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.SlowTime;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitState(NotifyParam.owner, EBGUUnitState.LifeSavingHair_FakeDead) && TimeScaleSetting.TimeScale > 0f)
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TriggerScaleTime.Invoke(TimeScaleSetting, TotalDuration);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSlowTime_LifeSaving bANS_GSSlowTime_LifeSaving = GCHelper.Find<b1.BANS_GSSlowTime_LifeSaving>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSlowTime_LifeSaving.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving");
		TimeScaleSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeScaleSetting");
		TimeScaleSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeScaleSetting", Classes.FStructProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSlowTime_LifeSaving:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSlowTime_LifeSaving()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSlowTime_LifeSaving)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSlowTime_LifeSaving));
	}
}
