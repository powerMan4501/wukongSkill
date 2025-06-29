using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Set DmgNumCanEnable")]
[USharpPath("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable")]
internal class BANS_GSSetDmgNumCanEnable : BANS_GSBase
{
	private static bool IsActiveBattleMainUI_IsValid;

	private static int IsActiveBattleMainUI_Offset;

	private static FFieldAddress IsActiveBattleMainUI_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("设置伤害数字是否显示")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable:IsActiveBattleMainUI")]
	public bool IsActiveBattleMainUI
	{
		get
		{
			CheckDestroyed();
			if (!IsActiveBattleMainUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable:IsActiveBattleMainUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsActiveBattleMainUI_Offset), 0, IsActiveBattleMainUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsActiveBattleMainUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable:IsActiveBattleMainUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsActiveBattleMainUI_Offset), 0, IsActiveBattleMainUI_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		IsActiveBattleMainUI = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGW_UIEventCollection.Get(NotifyParam.owner).Evt_UI_SetDamageNumCanEnabled(IsActiveBattleMainUI);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetDmgNumCanEnable bANS_GSSetDmgNumCanEnable = GCHelper.Find<b1.BANS_GSSetDmgNumCanEnable>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetDmgNumCanEnable.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable");
		NativeReflection.GetPropertyRef(ref IsActiveBattleMainUI_PropertyAddress, intPtr, "IsActiveBattleMainUI");
		IsActiveBattleMainUI_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsActiveBattleMainUI");
		IsActiveBattleMainUI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsActiveBattleMainUI", Classes.FBoolProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetDmgNumCanEnable:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetDmgNumCanEnable()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetDmgNumCanEnable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetDmgNumCanEnable));
	}
}
