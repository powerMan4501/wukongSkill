using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineFriend")]
public class BGW_OnlineFriend : UBGWOnlineFriend, IGameInstObj
{
	public delegate void Del_OnReadFriendList(bool bWasSuccessful);

	public int _StatId = -1;

	private List<FBGWOnlineFriendInfo> FriendListCS;

	private bool bOPened;

	private EFriendsListsType ListType;

	private Del_OnReadFriendList ReadFriendListCallBack;

	private static bool OnReadFriendListCompleteCS_IsValid;

	private static IntPtr OnReadFriendListCompleteCS_FunctionAddress;

	private static int OnReadFriendListCompleteCS_ParamsSize;

	private static bool OnReadFriendListCompleteCS_bWasSuccessful_IsValid;

	private static int OnReadFriendListCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress;

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

	public bool bTickEnabled => true;

	public void OnAttach()
	{
	}

	public void OnInit()
	{
		Init();
		bOPened = false;
		ListType = EFriendsListsType.Default;
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
		return 1024;
	}

	public void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!bOPened)
		{
			return;
		}
		ReadFriendListCS(ListType, delegate(bool bWasSuccessful)
		{
			if (bWasSuccessful)
			{
				GetFriendListCS(ListType);
			}
		});
	}

	public static BGW_OnlineFriend Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineFriend>(WorldContext);
	}

	public void SetOpenStatus(bool Status)
	{
		bOPened = Status;
	}

	public void ReadFriendListCS(EFriendsListsType ListType, Del_OnReadFriendList CallBack)
	{
		ReadFriendListCallBack = CallBack;
		this.ListType = ListType;
		ReadFriendsList(ListType);
	}

	public bool GetFriendListCS(EFriendsListsType ListType)
	{
		return GetFriendsList(ListType, out FriendListCS);
	}

	public List<FBGWOnlineFriendInfo> GetFriendInfoList()
	{
		return FriendListCS;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineFriend:OnReadFriendListCompleteCS")]
	protected override void OnReadFriendListCompleteCS_Implementation(bool bWasSuccessful)
	{
		ReadFriendListCallBack?.Invoke(bWasSuccessful);
		ReadFriendListCallBack = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineFriend:OnReadFriendListCompleteCS")]
	private static void OnReadFriendListCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineFriend bGW_OnlineFriend = GCHelper.Find<BGW_OnlineFriend>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnReadFriendListCompleteCS_bWasSuccessful_Offset), 0, OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineFriend.OnReadFriendListCompleteCS_Implementation(bWasSuccessful);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineFriend");
		OnReadFriendListCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReadFriendListCompleteCS");
		OnReadFriendListCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReadFriendListCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnReadFriendListCompleteCS_bWasSuccessful_PropertyAddress, OnReadFriendListCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadFriendListCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnReadFriendListCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadFriendListCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnReadFriendListCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnReadFriendListCompleteCS_IsValid = OnReadFriendListCompleteCS_FunctionAddress != IntPtr.Zero && OnReadFriendListCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineFriend:OnReadFriendListCompleteCS", OnReadFriendListCompleteCS_IsValid);
	}

	static BGW_OnlineFriend()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineFriend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineFriend));
	}
}
