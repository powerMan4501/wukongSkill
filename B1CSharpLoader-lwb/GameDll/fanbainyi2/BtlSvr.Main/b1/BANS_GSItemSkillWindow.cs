using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS ItemSkill Window")]
[USharpPath("/Script/b1-Managed.BANS_GSItemSkillWindow")]
internal class BANS_GSItemSkillWindow : BANS_GSBase
{
	private static bool ItemSkillWhiteList_IsValid;

	private static int ItemSkillWhiteList_Offset;

	private static FFieldAddress ItemSkillWhiteList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ItemSkillWhiteList_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[UProperty]
	[Category("Config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSItemSkillWindow:ItemSkillWhiteList")]
	public TArrayReadWrite<int> ItemSkillWhiteList
	{
		get
		{
			CheckDestroyed();
			if (!ItemSkillWhiteList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSItemSkillWindow:ItemSkillWhiteList");
				return null;
			}
			if (ItemSkillWhiteList_Marshaler == null)
			{
				ItemSkillWhiteList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ItemSkillWhiteList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ItemSkillWhiteList_Marshaler.FromNative(IntPtr.Add(base.Address, ItemSkillWhiteList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSItemSkillWindow:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetItemSkillWhiteList.Invoke(ItemSkillWhiteList.ToList());
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterItemSkillWindow, TotalDuration);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSItemSkillWindow:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSItemSkillWindow bANS_GSItemSkillWindow = GCHelper.Find<b1.BANS_GSItemSkillWindow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSItemSkillWindow.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSItemSkillWindow");
		NativeReflection.GetPropertyRef(ref ItemSkillWhiteList_PropertyAddress, intPtr, "ItemSkillWhiteList");
		ItemSkillWhiteList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemSkillWhiteList");
		ItemSkillWhiteList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemSkillWhiteList", Classes.FArrayProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSItemSkillWindow:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSItemSkillWindow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSItemSkillWindow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSItemSkillWindow));
	}
}
