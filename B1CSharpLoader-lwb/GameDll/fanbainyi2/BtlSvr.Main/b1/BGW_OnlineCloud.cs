using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineCloud")]
public class BGW_OnlineCloud : UBGWOnlineCloud, IGameInstObj
{
	public delegate void Del_OnEnumerateUserFiles(bool bWasSuccessful);

	public delegate void Del_OnWriteUserCloudFile(string filename, bool bWasSuccessful);

	public delegate void Del_OnReadUserFiles(string filename, bool bWasSuccessful);

	public delegate void Del_OnDeleteUserFiles(string filename, bool bWasSuccessful);

	public int _StatId = -1;

	private Del_OnEnumerateUserFiles EnumerateCallBack;

	private Del_OnWriteUserCloudFile WriteCallBack;

	private Del_OnReadUserFiles ReadCallBack;

	private Del_OnDeleteUserFiles DeleteCallBack;

	private static bool OnReadUserFilesCompleteCS_IsValid;

	private static IntPtr OnReadUserFilesCompleteCS_FunctionAddress;

	private static int OnReadUserFilesCompleteCS_ParamsSize;

	private static bool OnReadUserFilesCompleteCS_filename_IsValid;

	private static int OnReadUserFilesCompleteCS_filename_Offset;

	private static FFieldAddress OnReadUserFilesCompleteCS_filename_PropertyAddress;

	private static bool OnReadUserFilesCompleteCS_bWasSuccessful_IsValid;

	private static int OnReadUserFilesCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnDeleteUserFilesCompleteCS_IsValid;

	private static IntPtr OnDeleteUserFilesCompleteCS_FunctionAddress;

	private static int OnDeleteUserFilesCompleteCS_ParamsSize;

	private static bool OnDeleteUserFilesCompleteCS_filename_IsValid;

	private static int OnDeleteUserFilesCompleteCS_filename_Offset;

	private static FFieldAddress OnDeleteUserFilesCompleteCS_filename_PropertyAddress;

	private static bool OnDeleteUserFilesCompleteCS_bWasSuccessful_IsValid;

	private static int OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnEnumerateUserFilesCompleteCS_IsValid;

	private static IntPtr OnEnumerateUserFilesCompleteCS_FunctionAddress;

	private static int OnEnumerateUserFilesCompleteCS_ParamsSize;

	private static bool OnEnumerateUserFilesCompleteCS_bWasSuccessful_IsValid;

	private static int OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnWriteUserCloudFileCompleteCS_IsValid;

	private static IntPtr OnWriteUserCloudFileCompleteCS_FunctionAddress;

	private static int OnWriteUserCloudFileCompleteCS_ParamsSize;

	private static bool OnWriteUserCloudFileCompleteCS_filename_IsValid;

	private static int OnWriteUserCloudFileCompleteCS_filename_Offset;

	private static FFieldAddress OnWriteUserCloudFileCompleteCS_filename_PropertyAddress;

	private static bool OnWriteUserCloudFileCompleteCS_bWasSuccessful_IsValid;

	private static int OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress;

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

	public static BGW_OnlineCloud Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineCloud>(WorldContext);
	}

	public void EnumerateUserFiles(Del_OnEnumerateUserFiles CallBack)
	{
		EnumerateCallBack = CallBack;
		EnumerateUserFiles();
	}

	public void WriteUserFile(string filename, List<byte> userData, Del_OnWriteUserCloudFile CallBack)
	{
		WriteCallBack = CallBack;
		WriteUserFile(filename, userData);
	}

	public bool ReadAllUserFiles(Del_OnReadUserFiles CallBack)
	{
		ReadCallBack = CallBack;
		return ReadAllUserFiles();
	}

	public bool ReadUserFile(string filename, Del_OnReadUserFiles CallBack)
	{
		ReadCallBack = CallBack;
		return ReadUserFile(filename);
	}

	public void DeleteUserFile(string filename, bool bCloudDelete, bool bLocalDelete, Del_OnDeleteUserFiles CallBack)
	{
		DeleteCallBack = CallBack;
		DeleteUserFile(filename, bCloudDelete, bLocalDelete);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineCloud:OnEnumerateUserFilesCompleteCS")]
	protected override void OnEnumerateUserFilesCompleteCS_Implementation(bool bWasSuccessful)
	{
		EnumerateCallBack?.Invoke(bWasSuccessful);
		EnumerateCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineCloud:OnWriteUserCloudFileCompleteCS")]
	protected override void OnWriteUserCloudFileCompleteCS_Implementation(string filename, bool bWasSuccessful)
	{
		WriteCallBack?.Invoke(filename, bWasSuccessful);
		WriteCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineCloud:OnReadUserFilesCompleteCS")]
	protected override void OnReadUserFilesCompleteCS_Implementation(string filename, bool bWasSuccessful)
	{
		ReadCallBack?.Invoke(filename, bWasSuccessful);
		ReadCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineCloud:OnDeleteUserFilesCompleteCS")]
	protected override void OnDeleteUserFilesCompleteCS_Implementation(string filename, bool bWasSuccessful)
	{
		DeleteCallBack?.Invoke(filename, bWasSuccessful);
		DeleteCallBack = null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineCloud:OnReadUserFilesCompleteCS")]
	private static void OnReadUserFilesCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineCloud bGW_OnlineCloud = GCHelper.Find<BGW_OnlineCloud>(obj);
		string filename = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnReadUserFilesCompleteCS_filename_Offset));
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnReadUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineCloud.OnReadUserFilesCompleteCS_Implementation(filename, bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineCloud:OnDeleteUserFilesCompleteCS")]
	private static void OnDeleteUserFilesCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineCloud bGW_OnlineCloud = GCHelper.Find<BGW_OnlineCloud>(obj);
		string filename = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnDeleteUserFilesCompleteCS_filename_Offset));
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineCloud.OnDeleteUserFilesCompleteCS_Implementation(filename, bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineCloud:OnEnumerateUserFilesCompleteCS")]
	private static void OnEnumerateUserFilesCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineCloud bGW_OnlineCloud = GCHelper.Find<BGW_OnlineCloud>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset), 0, OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineCloud.OnEnumerateUserFilesCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineCloud:OnWriteUserCloudFileCompleteCS")]
	private static void OnWriteUserCloudFileCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineCloud bGW_OnlineCloud = GCHelper.Find<BGW_OnlineCloud>(obj);
		string filename = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnWriteUserCloudFileCompleteCS_filename_Offset));
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset), 0, OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineCloud.OnWriteUserCloudFileCompleteCS_Implementation(filename, bWasSuccessful);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineCloud");
		OnReadUserFilesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReadUserFilesCompleteCS");
		OnReadUserFilesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReadUserFilesCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnReadUserFilesCompleteCS_filename_PropertyAddress, OnReadUserFilesCompleteCS_FunctionAddress, "filename");
		OnReadUserFilesCompleteCS_filename_Offset = NativeReflection.GetPropertyOffset(OnReadUserFilesCompleteCS_FunctionAddress, "filename");
		OnReadUserFilesCompleteCS_filename_IsValid = NativeReflection.ValidatePropertyClass(OnReadUserFilesCompleteCS_FunctionAddress, "filename", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnReadUserFilesCompleteCS_bWasSuccessful_PropertyAddress, OnReadUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadUserFilesCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnReadUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnReadUserFilesCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnReadUserFilesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnReadUserFilesCompleteCS_IsValid = OnReadUserFilesCompleteCS_FunctionAddress != IntPtr.Zero && OnReadUserFilesCompleteCS_filename_IsValid && OnReadUserFilesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineCloud:OnReadUserFilesCompleteCS", OnReadUserFilesCompleteCS_IsValid);
		OnDeleteUserFilesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDeleteUserFilesCompleteCS");
		OnDeleteUserFilesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDeleteUserFilesCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDeleteUserFilesCompleteCS_filename_PropertyAddress, OnDeleteUserFilesCompleteCS_FunctionAddress, "filename");
		OnDeleteUserFilesCompleteCS_filename_Offset = NativeReflection.GetPropertyOffset(OnDeleteUserFilesCompleteCS_FunctionAddress, "filename");
		OnDeleteUserFilesCompleteCS_filename_IsValid = NativeReflection.ValidatePropertyClass(OnDeleteUserFilesCompleteCS_FunctionAddress, "filename", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnDeleteUserFilesCompleteCS_bWasSuccessful_PropertyAddress, OnDeleteUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnDeleteUserFilesCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnDeleteUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnDeleteUserFilesCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnDeleteUserFilesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnDeleteUserFilesCompleteCS_IsValid = OnDeleteUserFilesCompleteCS_FunctionAddress != IntPtr.Zero && OnDeleteUserFilesCompleteCS_filename_IsValid && OnDeleteUserFilesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineCloud:OnDeleteUserFilesCompleteCS", OnDeleteUserFilesCompleteCS_IsValid);
		OnEnumerateUserFilesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEnumerateUserFilesCompleteCS");
		OnEnumerateUserFilesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnumerateUserFilesCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnEnumerateUserFilesCompleteCS_bWasSuccessful_PropertyAddress, OnEnumerateUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEnumerateUserFilesCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnEnumerateUserFilesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEnumerateUserFilesCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnEnumerateUserFilesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnEnumerateUserFilesCompleteCS_IsValid = OnEnumerateUserFilesCompleteCS_FunctionAddress != IntPtr.Zero && OnEnumerateUserFilesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineCloud:OnEnumerateUserFilesCompleteCS", OnEnumerateUserFilesCompleteCS_IsValid);
		OnWriteUserCloudFileCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWriteUserCloudFileCompleteCS");
		OnWriteUserCloudFileCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWriteUserCloudFileCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnWriteUserCloudFileCompleteCS_filename_PropertyAddress, OnWriteUserCloudFileCompleteCS_FunctionAddress, "filename");
		OnWriteUserCloudFileCompleteCS_filename_Offset = NativeReflection.GetPropertyOffset(OnWriteUserCloudFileCompleteCS_FunctionAddress, "filename");
		OnWriteUserCloudFileCompleteCS_filename_IsValid = NativeReflection.ValidatePropertyClass(OnWriteUserCloudFileCompleteCS_FunctionAddress, "filename", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnWriteUserCloudFileCompleteCS_bWasSuccessful_PropertyAddress, OnWriteUserCloudFileCompleteCS_FunctionAddress, "bWasSuccessful");
		OnWriteUserCloudFileCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnWriteUserCloudFileCompleteCS_FunctionAddress, "bWasSuccessful");
		OnWriteUserCloudFileCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnWriteUserCloudFileCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnWriteUserCloudFileCompleteCS_IsValid = OnWriteUserCloudFileCompleteCS_FunctionAddress != IntPtr.Zero && OnWriteUserCloudFileCompleteCS_filename_IsValid && OnWriteUserCloudFileCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineCloud:OnWriteUserCloudFileCompleteCS", OnWriteUserCloudFileCompleteCS_IsValid);
	}

	static BGW_OnlineCloud()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineCloud)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineCloud));
	}
}
