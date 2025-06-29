using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Magic Window")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSMagicWindow")]
internal class BANS_GSMagicWindow : BANS_GSBase
{
	private static bool SkillBlackList_IsValid;

	private static int SkillBlackList_Offset;

	private static FFieldAddress SkillBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillBlackList_Marshaler;

	private static bool SkillWhiteList_IsValid;

	private static int SkillWhiteList_Offset;

	private static FFieldAddress SkillWhiteList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillWhiteList_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[Category("Anim Notify Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSMagicWindow:SkillBlackList")]
	public TArrayReadWrite<int> SkillBlackList
	{
		get
		{
			CheckDestroyed();
			if (!SkillBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMagicWindow:SkillBlackList");
				return null;
			}
			if (SkillBlackList_Marshaler == null)
			{
				SkillBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillBlackList_Offset));
		}
	}

	[Category("Anim Notify Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSMagicWindow:SkillWhiteList")]
	public TArrayReadWrite<int> SkillWhiteList
	{
		get
		{
			CheckDestroyed();
			if (!SkillWhiteList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSMagicWindow:SkillWhiteList");
				return null;
			}
			if (SkillWhiteList_Marshaler == null)
			{
				SkillWhiteList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillWhiteList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillWhiteList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillWhiteList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSMagicWindow:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterMagicWindow, TotalDuration);
			bUS_GSEventCollection?.Evt_SetMagicWindowSkillList.Invoke(SkillBlackList.ToList(), SkillWhiteList.ToList());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSMagicWindow:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSMagicWindow bANS_GSMagicWindow = GCHelper.Find<b1.BANS_GSMagicWindow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSMagicWindow.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSMagicWindow");
		NativeReflection.GetPropertyRef(ref SkillBlackList_PropertyAddress, intPtr, "SkillBlackList");
		SkillBlackList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillBlackList");
		SkillBlackList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillBlackList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SkillWhiteList_PropertyAddress, intPtr, "SkillWhiteList");
		SkillWhiteList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillWhiteList");
		SkillWhiteList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillWhiteList", Classes.FArrayProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSMagicWindow:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSMagicWindow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSMagicWindow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSMagicWindow));
	}
}
