using System;
using System.Collections.Generic;
using b1.Localization;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineSubsystem")]
public class BGW_OnlineSubsystem : UBGWOnlineSubsystem, IGameInstObj
{
	public delegate void Del_OnQueryAdditionComplete(bool bWasSuccessful);

	public delegate void Del_OnShowStoreUIComplete(bool bPurchased);

	public int _StatId = -1;

	private List<EAdditionContentType> CacheEntitlementList = new List<EAdditionContentType>();

	public static EBGWSubsystemType OnlineSubsystemType;

	private Del_OnQueryAdditionComplete OnQueryAdditionComplete;

	private Del_OnShowStoreUIComplete OnShowStoreUIComplete;

	private bool IsShowingStoreUI;

	private static bool OnShowStoreUIClosedCS_IsValid;

	private static IntPtr OnShowStoreUIClosedCS_FunctionAddress;

	private static int OnShowStoreUIClosedCS_ParamsSize;

	private static bool OnShowStoreUIClosedCS_bPurchased_IsValid;

	private static int OnShowStoreUIClosedCS_bPurchased_Offset;

	private static FFieldAddress OnShowStoreUIClosedCS_bPurchased_PropertyAddress;

	private static bool OnQueryIsOwnAdditionContentCompleteCS_IsValid;

	private static IntPtr OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress;

	private static int OnQueryIsOwnAdditionContentCompleteCS_ParamsSize;

	private static bool OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_IsValid;

	private static int OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset;

	private static FFieldAddress OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress;

	private static bool OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_IsValid;

	private static int OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress;

	public int StatId
	{
		get
		{
			if (_StatId < 0)
			{
				_StatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":Tick");
			}
			return _StatId;
		}
	}

	public bool bTickEnabled => false;

	public void OnAttach()
	{
	}

	static BGW_OnlineSubsystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineSubsystem));
		OnlineSubsystemType = UBGWOnlineSubsystem.GetSubsystemType();
	}

	public void OnInit()
	{
		Init();
		QueryUserNATType();
	}

	public void OnAfterInit()
	{
		AfterInit();
	}

	public bool CanTick()
	{
		return false;
	}

	public void OnShutdown()
	{
		Destroy();
	}

	public void OnPostLoadMap()
	{
	}

	public int GetTickGroupMask()
	{
		return 0;
	}

	public void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public static BGW_OnlineSubsystem Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineSubsystem>(WorldContext);
	}

	public bool IsOnlineSubsystemNull()
	{
		if (UBGWOnlineSubsystem.GetSubsystemType() == EBGWSubsystemType.Null)
		{
			return true;
		}
		return false;
	}

	public bool UseSessionSearch()
	{
		if (IsOnlineSubsystemNull())
		{
			return true;
		}
		return false;
	}

	public bool UsePlatformSession()
	{
		if (UBGWOnlineSubsystem.GetSubsystemType() == EBGWSubsystemType.GDK || UBGWOnlineSubsystem.GetSubsystemType() == EBGWSubsystemType.PS5)
		{
			return true;
		}
		return false;
	}

	public bool IsPlatformNetConnected()
	{
		return true;
	}

	public bool IsPlatformMultiplayerGameEnable()
	{
		return true;
	}

	public static string GetAdditionalContentId(EBGWSubsystemType SubsystemType, EAdditionContentType AdditionContentType)
	{
		if (SubsystemType == EBGWSubsystemType.PS5 || SubsystemType == EBGWSubsystemType.Steam || SubsystemType == EBGWSubsystemType.Epic || SubsystemType == EBGWSubsystemType.Tencent)
		{
			return AdditionContentType switch
			{
				EAdditionContentType.B1DeluxeVersionAddOn => DebugConfig.B1DeluxeAddOnId, 
				EAdditionContentType.B1PrePurchaseVersionAddOn => DebugConfig.B1PrePurchaseAddOnId, 
				_ => string.Empty, 
			};
		}
		return string.Empty;
	}

	public void QueryIsOwnAdditionContentByType(EAdditionContentType AdditionContentType, Del_OnQueryAdditionComplete Callback)
	{
		string additionalContentId = GetAdditionalContentId(UBGWOnlineSubsystem.GetSubsystemType(), AdditionContentType);
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo(string.Format("{0}.QueryIsOwnAdditionContentByType:{1} EntitlementId:{2}", "BGW_OnlineSubsystem", AdditionContentType, additionalContentId));
		if (additionalContentId == string.Empty)
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogError(string.Format("{0}.GetAdditionalContentId{1} Return string.Empty", "BGW_OnlineSubsystem", AdditionContentType));
			Callback?.Invoke(bWasSuccessful: false);
		}
		else
		{
			OnQueryAdditionComplete = Callback;
			QueryIsOwnAdditionContent(additionalContentId);
		}
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS")]
	protected override void OnQueryIsOwnAdditionContentCompleteCS_Implementation(string EntitlementId, bool bWasSuccessful)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo(string.Format("{0}.OnQueryIsOwnAdditionContentCompleteCS EntitlementId:{1}, WasSuccess:{2}", "BGW_OnlineSubsystem", EntitlementId, bWasSuccessful));
		OnQueryAdditionComplete?.Invoke(bWasSuccessful);
		OnQueryAdditionComplete = null;
	}

	public static bool IsOverseaChannel()
	{
		if (DebugConfig.DebugOverSeaType > 0)
		{
			return DebugConfig.DebugOverSeaType > 1;
		}
		EBGWSubsystemType subsystemType = UBGWOnlineSubsystem.GetSubsystemType();
		if (subsystemType == EBGWSubsystemType.Null || subsystemType == EBGWSubsystemType.Unknown)
		{
			return DebugConfig.IsOverSeaChannel;
		}
		return !UGSE_SDKFuncLib.IsCleanVersion();
	}

	public static bool IsJpVersion()
	{
		if (OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			return false;
		}
		string pS5UserAccountRegionCode = UGSE_SDKFuncLib.GetPS5UserAccountRegionCode();
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("Result:" + pS5UserAccountRegionCode);
		if (pS5UserAccountRegionCode == "jp")
		{
			return true;
		}
		if (pS5UserAccountRegionCode != "Failed")
		{
			return false;
		}
		string defaultLanguage = UGSE_GSGameSettingsFuncLib.GetDefaultLanguage();
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("PS5SystemLanguage:" + defaultLanguage);
		string currentCulture = GSLocalization.GetCurrentCulture();
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("UserLanguageSetting:" + currentCulture);
		if (!(defaultLanguage == "ja"))
		{
			return currentCulture == GSLocalization.Culture_ja;
		}
		return true;
	}

	public bool ShowStoreUI(string ProductId, bool AddToCart, Del_OnShowStoreUIComplete Delegate)
	{
		if (IsShowingStoreUI)
		{
			Delegate?.Invoke(bPurchased: false);
			return false;
		}
		OnShowStoreUIComplete = Delegate;
		IsShowingStoreUI = ShowStoreUI(ProductId, AddToCart);
		return IsShowingStoreUI;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSubsystem:OnShowStoreUIClosedCS")]
	protected override void OnShowStoreUIClosedCS_Implementation(bool bPurchased)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo(string.Format("{0}.OnShowStoreUIClosedCS_Implementation bPurchased:{1}", "BGW_OnlineSubsystem", bPurchased));
		OnShowStoreUIComplete?.Invoke(bPurchased);
		OnShowStoreUIComplete = null;
		IsShowingStoreUI = false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSubsystem:OnShowStoreUIClosedCS")]
	private static void OnShowStoreUIClosedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSubsystem bGW_OnlineSubsystem = GCHelper.Find<BGW_OnlineSubsystem>(obj);
		bool bPurchased = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnShowStoreUIClosedCS_bPurchased_Offset), 0, OnShowStoreUIClosedCS_bPurchased_PropertyAddress.Address);
		bGW_OnlineSubsystem.OnShowStoreUIClosedCS_Implementation(bPurchased);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS")]
	private static void OnQueryIsOwnAdditionContentCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSubsystem bGW_OnlineSubsystem = GCHelper.Find<BGW_OnlineSubsystem>(obj);
		string entitlementId = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset));
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset), 0, OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineSubsystem.OnQueryIsOwnAdditionContentCompleteCS_Implementation(entitlementId, bWasSuccessful);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineSubsystem");
		OnShowStoreUIClosedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnShowStoreUIClosedCS");
		OnShowStoreUIClosedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnShowStoreUIClosedCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnShowStoreUIClosedCS_bPurchased_PropertyAddress, OnShowStoreUIClosedCS_FunctionAddress, "bPurchased");
		OnShowStoreUIClosedCS_bPurchased_Offset = NativeReflection.GetPropertyOffset(OnShowStoreUIClosedCS_FunctionAddress, "bPurchased");
		OnShowStoreUIClosedCS_bPurchased_IsValid = NativeReflection.ValidatePropertyClass(OnShowStoreUIClosedCS_FunctionAddress, "bPurchased", Classes.FBoolProperty);
		OnShowStoreUIClosedCS_IsValid = OnShowStoreUIClosedCS_FunctionAddress != IntPtr.Zero && OnShowStoreUIClosedCS_bPurchased_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSubsystem:OnShowStoreUIClosedCS", OnShowStoreUIClosedCS_IsValid);
		OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnQueryIsOwnAdditionContentCompleteCS");
		OnQueryIsOwnAdditionContentCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress, OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "EntitlementId");
		OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset = NativeReflection.GetPropertyOffset(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "EntitlementId");
		OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_IsValid = NativeReflection.ValidatePropertyClass(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "EntitlementId", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress, OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnQueryIsOwnAdditionContentCompleteCS_IsValid = OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress != IntPtr.Zero && OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_IsValid && OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS", OnQueryIsOwnAdditionContentCompleteCS_IsValid);
	}
}
