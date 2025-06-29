using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("ShowUI")]
[USharpPath("/Script/b1-Managed.BSN_ShowUI")]
public class BSN_ShowUI : UMovieSceneCalliopeNotifySection
{
	private static bool UIPageList_IsValid;

	private static int UIPageList_Offset;

	private static FFieldAddress UIPageList_PropertyAddress;

	private TArrayReadWriteMarshaler<EUIPageID> UIPageList_Marshaler;

	private static bool OnNotify_IsValid;

	private static IntPtr OnNotify_FunctionAddress;

	private static int OnNotify_ParamsSize;

	private static bool OnNotify_InPlayer_IsValid;

	private static int OnNotify_InPlayer_Offset;

	private static bool OnNotify_InStatus_IsValid;

	private static int OnNotify_InStatus_Offset;

	private static bool OnNotify_bInBackwards_IsValid;

	private static int OnNotify_bInBackwards_Offset;

	private static FFieldAddress OnNotify_bInBackwards_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSN_ShowUI:UIPageList")]
	public TArrayReadWrite<EUIPageID> UIPageList
	{
		get
		{
			CheckDestroyed();
			if (!UIPageList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ShowUI:UIPageList");
				return null;
			}
			if (UIPageList_Marshaler == null)
			{
				UIPageList_Marshaler = new TArrayReadWriteMarshaler<EUIPageID>(1, UIPageList_PropertyAddress, CachedMarshalingDelegates<EUIPageID, EnumMarshaler<EUIPageID>>.FromNative, CachedMarshalingDelegates<EUIPageID, EnumMarshaler<EUIPageID>>.ToNative);
			}
			return UIPageList_Marshaler.FromNative(IntPtr.Add(base.Address, UIPageList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_ShowUI:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		if (UIPageList.Count == 0)
		{
			return;
		}
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(playbackContext);
		if (bGW_UIEventCollection == null)
		{
			return;
		}
		foreach (EUIPageID uIPage in UIPageList)
		{
			bGW_UIEventCollection.Evt_UI_SetPageActiveTemp(uIPage, IsActive: true);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_ShowUI:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_ShowUI bSN_ShowUI = GCHelper.Find<BSN_ShowUI>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_ShowUI.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_ShowUI");
		NativeReflection.GetPropertyRef(ref UIPageList_PropertyAddress, intPtr, "UIPageList");
		UIPageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIPageList");
		UIPageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIPageList", Classes.FArrayProperty);
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InPlayer");
		OnNotify_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_InPlayer_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_ShowUI:OnNotify", OnNotify_IsValid);
	}

	static BSN_ShowUI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_ShowUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_ShowUI));
	}
}
