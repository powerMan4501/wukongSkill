using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Vigor Window")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSVigorWindow")]
internal class BANS_GSVigorWindow : BANS_GSBase
{
	private static bool VigorSkillWhiteList_IsValid;

	private static int VigorSkillWhiteList_Offset;

	private static FFieldAddress VigorSkillWhiteList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> VigorSkillWhiteList_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[Category("Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSVigorWindow:VigorSkillWhiteList")]
	public TArrayReadWrite<int> VigorSkillWhiteList
	{
		get
		{
			CheckDestroyed();
			if (!VigorSkillWhiteList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSVigorWindow:VigorSkillWhiteList");
				return null;
			}
			if (VigorSkillWhiteList_Marshaler == null)
			{
				VigorSkillWhiteList_Marshaler = new TArrayReadWriteMarshaler<int>(1, VigorSkillWhiteList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return VigorSkillWhiteList_Marshaler.FromNative(IntPtr.Add(base.Address, VigorSkillWhiteList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSVigorWindow:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterVigorWindow, TotalDuration);
				bUS_GSEventCollection.Evt_SetVigorSkillWhiteList.Invoke(VigorSkillWhiteList.ToList());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSVigorWindow:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSVigorWindow bANS_GSVigorWindow = GCHelper.Find<b1.BANS_GSVigorWindow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSVigorWindow.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSVigorWindow");
		NativeReflection.GetPropertyRef(ref VigorSkillWhiteList_PropertyAddress, intPtr, "VigorSkillWhiteList");
		VigorSkillWhiteList_Offset = NativeReflection.GetPropertyOffset(intPtr, "VigorSkillWhiteList");
		VigorSkillWhiteList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VigorSkillWhiteList", Classes.FArrayProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSVigorWindow:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSVigorWindow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSVigorWindow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSVigorWindow));
	}
}
