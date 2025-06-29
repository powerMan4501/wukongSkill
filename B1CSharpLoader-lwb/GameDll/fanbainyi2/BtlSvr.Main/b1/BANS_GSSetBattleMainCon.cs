using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Set BattleMainCon")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSetBattleMainCon")]
internal class BANS_GSSetBattleMainCon : BANS_GSBase
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

	[BlueprintReadWrite]
	[DisplayName("设置主角战斗UI是否显示")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetBattleMainCon:IsActiveBattleMainUI")]
	public bool IsActiveBattleMainUI
	{
		get
		{
			CheckDestroyed();
			if (!IsActiveBattleMainUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetBattleMainCon:IsActiveBattleMainUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsActiveBattleMainUI_Offset), 0, IsActiveBattleMainUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsActiveBattleMainUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetBattleMainCon:IsActiveBattleMainUI");
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

	[USharpPath("/Script/b1-Managed.BANS_GSSetBattleMainCon:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(NotifyParam.owner);
			bGW_UIEventCollection.Evt_UI_SetPageActiveTemp(EUIPageID.BattleMainCon, IsActiveBattleMainUI);
			bGW_UIEventCollection.Evt_UI_SetPageActiveTemp(EUIPageID.BloodBarList, IsActiveBattleMainUI);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetBattleMainCon:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetBattleMainCon bANS_GSSetBattleMainCon = GCHelper.Find<b1.BANS_GSSetBattleMainCon>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetBattleMainCon.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetBattleMainCon");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetBattleMainCon:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetBattleMainCon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetBattleMainCon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetBattleMainCon));
	}
}
