using System;
using System.Collections.Generic;
using b1.Plugins.GSReplaySystem;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS")]
public class UGSReplayCSharpFuncLibCS : UGSReplayCSharpFuncLib
{
	private List<string> ProcessGameSpecificDataList = new List<string>();

	private static bool OnPostDemoPlay_IsValid;

	private static IntPtr OnPostDemoPlay_FunctionAddress;

	private static int OnPostDemoPlay_ParamsSize;

	private static bool OnReplayStarted_IsValid;

	private static IntPtr OnReplayStarted_FunctionAddress;

	private static int OnReplayStarted_ParamsSize;

	private static bool OnReplayStarted_World_IsValid;

	private static int OnReplayStarted_World_Offset;

	private static bool GSNetworkRemapPathCS_IsValid;

	private static IntPtr GSNetworkRemapPathCS_FunctionAddress;

	private static int GSNetworkRemapPathCS_ParamsSize;

	private static bool GSNetworkRemapPathCS_Outer_IsValid;

	private static int GSNetworkRemapPathCS_Outer_Offset;

	private static bool GSNetworkRemapPathCS_OriginName_IsValid;

	private static int GSNetworkRemapPathCS_OriginName_Offset;

	private static FFieldAddress GSNetworkRemapPathCS_OriginName_PropertyAddress;

	private static bool GSNetworkRemapPathCS_Name_IsValid;

	private static int GSNetworkRemapPathCS_Name_Offset;

	private static FFieldAddress GSNetworkRemapPathCS_Name_PropertyAddress;

	private static bool OnReplayScrubComplete_IsValid;

	private static IntPtr OnReplayScrubComplete_FunctionAddress;

	private static int OnReplayScrubComplete_ParamsSize;

	private static bool OnReplayScrubComplete_World_IsValid;

	private static int OnReplayScrubComplete_World_Offset;

	private static bool OnReplaySeverConnectionInit_IsValid;

	private static IntPtr OnReplaySeverConnectionInit_FunctionAddress;

	private static int OnReplaySeverConnectionInit_ParamsSize;

	private static bool OnReplaySeverConnectionInit_World_IsValid;

	private static int OnReplaySeverConnectionInit_World_Offset;

	private static bool OnReplaySeverConnectionInit_SeverConnection_IsValid;

	private static int OnReplaySeverConnectionInit_SeverConnection_Offset;

	private static bool WriteGameSpecificDemoHeaderCS_IsValid;

	private static IntPtr WriteGameSpecificDemoHeaderCS_FunctionAddress;

	private static int WriteGameSpecificDemoHeaderCS_ParamsSize;

	private static bool WriteGameSpecificDemoHeaderCS_GameSpecificData_IsValid;

	private static int WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset;

	private static FFieldAddress WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress;

	private static bool ProcessGameSpecificDemoHeaderCS_IsValid;

	private static IntPtr ProcessGameSpecificDemoHeaderCS_FunctionAddress;

	private static int ProcessGameSpecificDemoHeaderCS_ParamsSize;

	private static bool ProcessGameSpecificDemoHeaderCS_GameSpecificData_IsValid;

	private static int ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset;

	private static FFieldAddress ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress;

	private static bool ProcessGameSpecificDemoHeaderCS_Error_IsValid;

	private static int ProcessGameSpecificDemoHeaderCS_Error_Offset;

	private static FFieldAddress ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress;

	private static bool PreProcessGameSpecificDemoHeaderCS_IsValid;

	private static IntPtr PreProcessGameSpecificDemoHeaderCS_FunctionAddress;

	private static int PreProcessGameSpecificDemoHeaderCS_ParamsSize;

	private static bool PostProcessGameSpecificDemoHeaderCS_IsValid;

	private static IntPtr PostProcessGameSpecificDemoHeaderCS_FunctionAddress;

	private static int PostProcessGameSpecificDemoHeaderCS_ParamsSize;

	private BGW_ReplaySystemMgr ReplaySystemMgr => BGW_ReplaySystemMgr.Get(this);

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnPostDemoPlay")]
	protected override void OnPostDemoPlay_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:WriteGameSpecificDemoHeaderCS")]
	protected override void WriteGameSpecificDemoHeaderCS_Implementation(out List<string> GameSpecificData)
	{
		GameSpecificData = ProcessGameSpecificDataList;
		ReplaySystemMgr.WriteGameSpecificDataToHeader(GameSpecificData);
		GameSpecificData.Add("Shepherd Test");
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:PreProcessGameSpecificDemoHeaderCS")]
	protected override void PreProcessGameSpecificDemoHeaderCS_Implementation()
	{
		ProcessGameSpecificDataList.Clear();
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:ProcessGameSpecificDemoHeaderCS")]
	protected override void ProcessGameSpecificDemoHeaderCS_Implementation(string GameSpecificData, out string Error)
	{
		Error = string.Empty;
		ProcessGameSpecificDataList.Add(GameSpecificData);
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:PostProcessGameSpecificDemoHeaderCS")]
	protected override void PostProcessGameSpecificDemoHeaderCS_Implementation()
	{
	}

	public List<string> GetGameSpecificDataList()
	{
		return ProcessGameSpecificDataList;
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplayScrubComplete")]
	protected override void OnReplayScrubComplete_Implementation(UWorld World)
	{
		ReplaySystemMgr.OnReplayScrubComplete(World);
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:GSNetworkRemapPathCS")]
	protected override void GSNetworkRemapPathCS_Implementation(UObject Outer, string OriginName, out string Name)
	{
		if (ReplaySystemMgr.IsPlayingReplay && OriginName.Contains("@"))
		{
			string[] array = OriginName.Split('@');
			TamerCharacterNameAllocator orAllocTamerCharacterNameAllocator = BGU_DataUtil.GetOrAllocTamerCharacterNameAllocator(this, array[0]);
			if (orAllocTamerCharacterNameAllocator != null)
			{
				Name = orAllocTamerCharacterNameAllocator.GetCurrentName();
				if (DebugConfig.DebugGSRepRole)
				{
					BGW_LogUtil.LogError("[UGSReplayCSharpFuncLibCS] GSNetworkRemapPathCS_Implementation 0 PathName:" + Name);
				}
			}
			else
			{
				Name = array[0] + "@_0";
			}
			string tamerGuid = array[0];
			UActorChannel uActorChannel = Outer as UActorChannel;
			if (uActorChannel != null)
			{
				BGW_EventCollection.Get(this).Evt_RemapTamer(tamerGuid, UGSE_OnlineFuncLib.GetObjNetGuidByChannel(uActorChannel));
			}
			else
			{
				BGW_EventCollection.Get(this).Evt_RemapTamer(tamerGuid, 0L);
			}
		}
		else
		{
			Name = OriginName;
		}
		if (DebugConfig.DebugGSRepRole)
		{
			BGW_LogUtil.LogError("[UGSReplayCSharpFuncLibCS] GSNetworkRemapPathCS_Implementation 2 PathName:" + Name);
		}
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplayStarted")]
	protected override void OnReplayStarted_Implementation(UWorld World)
	{
		base.OnReplayStarted_Implementation(World);
		USystemLibrary.ExecuteConsoleCommand(World, "p.ClothReCreateTaskEnable 0", null);
	}

	[USharpPath("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplaySeverConnectionInit")]
	protected override void OnReplaySeverConnectionInit_Implementation(UWorld World, UNetConnection SeverConnection)
	{
		base.OnReplaySeverConnectionInit_Implementation(World, SeverConnection);
		if (!(World == null))
		{
			UGSReplayFuncLib.RegisterNetworkRemapPath(this);
			BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(World);
			foreach (BUTamerActor bUTamerActor in allActorsOfClass)
			{
				BGW_EventCollection.Get(this)?.Evt_ReplayRegisterTamer(bUTamerActor.CurrentRef);
				BGW_LogUtil.LogError("[UGSReplayCSharpFuncLibCS] OnReplaySeverConnectionInit Tamer:" + bUTamerActor.CurrentRef.TamerGuid);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnPostDemoPlay")]
	private static void OnPostDemoPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		uGSReplayCSharpFuncLibCS.OnPostDemoPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplayStarted")]
	private static void OnReplayStarted__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnReplayStarted_World_Offset));
		uGSReplayCSharpFuncLibCS.OnReplayStarted_Implementation(world);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:GSNetworkRemapPathCS")]
	private static void GSNetworkRemapPathCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		UObject outer = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, GSNetworkRemapPathCS_Outer_Offset));
		string originName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GSNetworkRemapPathCS_OriginName_Offset));
		uGSReplayCSharpFuncLibCS.GSNetworkRemapPathCS_Implementation(outer, originName, out var Name);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GSNetworkRemapPathCS_Name_Offset), Name);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplayScrubComplete")]
	private static void OnReplayScrubComplete__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnReplayScrubComplete_World_Offset));
		uGSReplayCSharpFuncLibCS.OnReplayScrubComplete_Implementation(world);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplaySeverConnectionInit")]
	private static void OnReplaySeverConnectionInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnReplaySeverConnectionInit_World_Offset));
		UNetConnection severConnection = UObjectMarshaler<UNetConnection>.FromNative(IntPtr.Add(buffer, OnReplaySeverConnectionInit_SeverConnection_Offset));
		uGSReplayCSharpFuncLibCS.OnReplaySeverConnectionInit_Implementation(world, severConnection);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:WriteGameSpecificDemoHeaderCS")]
	private static void WriteGameSpecificDemoHeaderCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> GameSpecificData = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset));
		uGSReplayCSharpFuncLibCS.WriteGameSpecificDemoHeaderCS_Implementation(out GameSpecificData);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset), GameSpecificData);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:ProcessGameSpecificDemoHeaderCS")]
	private static void ProcessGameSpecificDemoHeaderCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		string gameSpecificData = FStringMarshaler.FromNative(IntPtr.Add(buffer, ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset));
		uGSReplayCSharpFuncLibCS.ProcessGameSpecificDemoHeaderCS_Implementation(gameSpecificData, out var Error);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ProcessGameSpecificDemoHeaderCS_Error_Offset), Error);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:PreProcessGameSpecificDemoHeaderCS")]
	private static void PreProcessGameSpecificDemoHeaderCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		uGSReplayCSharpFuncLibCS.PreProcessGameSpecificDemoHeaderCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:PostProcessGameSpecificDemoHeaderCS")]
	private static void PostProcessGameSpecificDemoHeaderCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSReplayCSharpFuncLibCS uGSReplayCSharpFuncLibCS = GCHelper.Find<UGSReplayCSharpFuncLibCS>(obj);
		uGSReplayCSharpFuncLibCS.PostProcessGameSpecificDemoHeaderCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UGSReplayCSharpFuncLibCS");
		OnPostDemoPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPostDemoPlay");
		OnPostDemoPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostDemoPlay_FunctionAddress);
		OnPostDemoPlay_IsValid = OnPostDemoPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnPostDemoPlay", OnPostDemoPlay_IsValid);
		OnReplayStarted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplayStarted");
		OnReplayStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplayStarted_FunctionAddress);
		OnReplayStarted_World_Offset = NativeReflection.GetPropertyOffset(OnReplayStarted_FunctionAddress, "World");
		OnReplayStarted_World_IsValid = NativeReflection.ValidatePropertyClass(OnReplayStarted_FunctionAddress, "World", Classes.FObjectProperty);
		OnReplayStarted_IsValid = OnReplayStarted_FunctionAddress != IntPtr.Zero && OnReplayStarted_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplayStarted", OnReplayStarted_IsValid);
		GSNetworkRemapPathCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNetworkRemapPathCS");
		GSNetworkRemapPathCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNetworkRemapPathCS_FunctionAddress);
		GSNetworkRemapPathCS_Outer_Offset = NativeReflection.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Outer");
		GSNetworkRemapPathCS_Outer_IsValid = NativeReflection.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GSNetworkRemapPathCS_OriginName_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_Offset = NativeReflection.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "OriginName");
		GSNetworkRemapPathCS_OriginName_IsValid = NativeReflection.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "OriginName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GSNetworkRemapPathCS_Name_PropertyAddress, GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_Offset = NativeReflection.GetPropertyOffset(GSNetworkRemapPathCS_FunctionAddress, "Name");
		GSNetworkRemapPathCS_Name_IsValid = NativeReflection.ValidatePropertyClass(GSNetworkRemapPathCS_FunctionAddress, "Name", Classes.FStrProperty);
		GSNetworkRemapPathCS_IsValid = GSNetworkRemapPathCS_FunctionAddress != IntPtr.Zero && GSNetworkRemapPathCS_Outer_IsValid && GSNetworkRemapPathCS_OriginName_IsValid && GSNetworkRemapPathCS_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:GSNetworkRemapPathCS", GSNetworkRemapPathCS_IsValid);
		OnReplayScrubComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplayScrubComplete");
		OnReplayScrubComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplayScrubComplete_FunctionAddress);
		OnReplayScrubComplete_World_Offset = NativeReflection.GetPropertyOffset(OnReplayScrubComplete_FunctionAddress, "World");
		OnReplayScrubComplete_World_IsValid = NativeReflection.ValidatePropertyClass(OnReplayScrubComplete_FunctionAddress, "World", Classes.FObjectProperty);
		OnReplayScrubComplete_IsValid = OnReplayScrubComplete_FunctionAddress != IntPtr.Zero && OnReplayScrubComplete_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplayScrubComplete", OnReplayScrubComplete_IsValid);
		OnReplaySeverConnectionInit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplaySeverConnectionInit");
		OnReplaySeverConnectionInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplaySeverConnectionInit_FunctionAddress);
		OnReplaySeverConnectionInit_World_Offset = NativeReflection.GetPropertyOffset(OnReplaySeverConnectionInit_FunctionAddress, "World");
		OnReplaySeverConnectionInit_World_IsValid = NativeReflection.ValidatePropertyClass(OnReplaySeverConnectionInit_FunctionAddress, "World", Classes.FObjectProperty);
		OnReplaySeverConnectionInit_SeverConnection_Offset = NativeReflection.GetPropertyOffset(OnReplaySeverConnectionInit_FunctionAddress, "SeverConnection");
		OnReplaySeverConnectionInit_SeverConnection_IsValid = NativeReflection.ValidatePropertyClass(OnReplaySeverConnectionInit_FunctionAddress, "SeverConnection", Classes.FObjectProperty);
		OnReplaySeverConnectionInit_IsValid = OnReplaySeverConnectionInit_FunctionAddress != IntPtr.Zero && OnReplaySeverConnectionInit_World_IsValid && OnReplaySeverConnectionInit_SeverConnection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:OnReplaySeverConnectionInit", OnReplaySeverConnectionInit_IsValid);
		WriteGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WriteGameSpecificDemoHeaderCS");
		WriteGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteGameSpecificDemoHeaderCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref WriteGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, WriteGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		WriteGameSpecificDemoHeaderCS_GameSpecificData_Offset = NativeReflection.GetPropertyOffset(WriteGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		WriteGameSpecificDemoHeaderCS_GameSpecificData_IsValid = NativeReflection.ValidatePropertyClass(WriteGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData", Classes.FArrayProperty);
		WriteGameSpecificDemoHeaderCS_IsValid = WriteGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero && WriteGameSpecificDemoHeaderCS_GameSpecificData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:WriteGameSpecificDemoHeaderCS", WriteGameSpecificDemoHeaderCS_IsValid);
		ProcessGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessGameSpecificDemoHeaderCS");
		ProcessGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessGameSpecificDemoHeaderCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ProcessGameSpecificDemoHeaderCS_GameSpecificData_PropertyAddress, ProcessGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		ProcessGameSpecificDemoHeaderCS_GameSpecificData_Offset = NativeReflection.GetPropertyOffset(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData");
		ProcessGameSpecificDemoHeaderCS_GameSpecificData_IsValid = NativeReflection.ValidatePropertyClass(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "GameSpecificData", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ProcessGameSpecificDemoHeaderCS_Error_PropertyAddress, ProcessGameSpecificDemoHeaderCS_FunctionAddress, "Error");
		ProcessGameSpecificDemoHeaderCS_Error_Offset = NativeReflection.GetPropertyOffset(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "Error");
		ProcessGameSpecificDemoHeaderCS_Error_IsValid = NativeReflection.ValidatePropertyClass(ProcessGameSpecificDemoHeaderCS_FunctionAddress, "Error", Classes.FStrProperty);
		ProcessGameSpecificDemoHeaderCS_IsValid = ProcessGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero && ProcessGameSpecificDemoHeaderCS_GameSpecificData_IsValid && ProcessGameSpecificDemoHeaderCS_Error_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:ProcessGameSpecificDemoHeaderCS", ProcessGameSpecificDemoHeaderCS_IsValid);
		PreProcessGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreProcessGameSpecificDemoHeaderCS");
		PreProcessGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreProcessGameSpecificDemoHeaderCS_FunctionAddress);
		PreProcessGameSpecificDemoHeaderCS_IsValid = PreProcessGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:PreProcessGameSpecificDemoHeaderCS", PreProcessGameSpecificDemoHeaderCS_IsValid);
		PostProcessGameSpecificDemoHeaderCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostProcessGameSpecificDemoHeaderCS");
		PostProcessGameSpecificDemoHeaderCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostProcessGameSpecificDemoHeaderCS_FunctionAddress);
		PostProcessGameSpecificDemoHeaderCS_IsValid = PostProcessGameSpecificDemoHeaderCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSReplayCSharpFuncLibCS:PostProcessGameSpecificDemoHeaderCS", PostProcessGameSpecificDemoHeaderCS_IsValid);
	}

	static UGSReplayCSharpFuncLibCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSReplayCSharpFuncLibCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSReplayCSharpFuncLibCS));
	}
}
