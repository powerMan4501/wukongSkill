using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlinePresence")]
public class BGW_OnlinePresence : UBGWOnlinePresence, IGameInstObj
{
	public delegate void Del_OnSetPresenceComplete(bool bWasSuccessful);

	public int _StatId = -1;

	private Del_OnSetPresenceComplete SetPresenceComplete;

	private static bool OnSetPresenceCompleteCS_IsValid;

	private static IntPtr OnSetPresenceCompleteCS_FunctionAddress;

	private static int OnSetPresenceCompleteCS_ParamsSize;

	private static bool OnSetPresenceCompleteCS_bWasSuccessful_IsValid;

	private static int OnSetPresenceCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress;

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

	public void OnInit()
	{
		Init();
	}

	public void OnAfterInit()
	{
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

	public static BGW_OnlinePresence Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlinePresence>(WorldContext);
	}

	public void SetPresence(string PresenceId, string StatusStr, Dictionary<string, string> Properties, Del_OnSetPresenceComplete CallBack = null)
	{
		SetPresenceComplete = CallBack;
		SetRichPresence(PresenceId, StatusStr, Properties);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlinePresence:OnSetPresenceCompleteCS")]
	protected override void OnSetPresenceCompleteCS_Implementation(bool bWasSuccessful)
	{
		SetPresenceComplete?.Invoke(bWasSuccessful);
		SetPresenceComplete = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlinePresence:OnSetPresenceCompleteCS")]
	private static void OnSetPresenceCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlinePresence bGW_OnlinePresence = GCHelper.Find<BGW_OnlinePresence>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSetPresenceCompleteCS_bWasSuccessful_Offset), 0, OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlinePresence.OnSetPresenceCompleteCS_Implementation(bWasSuccessful);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlinePresence");
		OnSetPresenceCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetPresenceCompleteCS");
		OnSetPresenceCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetPresenceCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSetPresenceCompleteCS_bWasSuccessful_PropertyAddress, OnSetPresenceCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetPresenceCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnSetPresenceCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetPresenceCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnSetPresenceCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnSetPresenceCompleteCS_IsValid = OnSetPresenceCompleteCS_FunctionAddress != IntPtr.Zero && OnSetPresenceCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlinePresence:OnSetPresenceCompleteCS", OnSetPresenceCompleteCS_IsValid);
	}

	static BGW_OnlinePresence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlinePresence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlinePresence));
	}
}
