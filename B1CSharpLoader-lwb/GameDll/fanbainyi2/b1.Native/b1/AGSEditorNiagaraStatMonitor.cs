using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Blutility;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSEditorNiagaraStatMonitor : AEditorUtilityActor
{
	private static bool TriggerFetchingStat_IsValid;

	private static FFieldAddress TriggerFetchingStat_PropertyAddress;

	private static int TriggerFetchingStat_Offset;

	private static bool FetchingPersistingFrames_IsValid;

	private static int FetchingPersistingFrames_Offset;

	private static bool FetchingTargetStatName_IsValid;

	private static int FetchingTargetStatName_Offset;

	private static bool MonitorSwitch_IsValid;

	private static FFieldAddress MonitorSwitch_PropertyAddress;

	private static int MonitorSwitch_Offset;

	private static bool CaptureDuration_IsValid;

	private static int CaptureDuration_Offset;

	private static bool CaptureDurationAfterRemoved_IsValid;

	private static int CaptureDurationAfterRemoved_Offset;

	private static bool MaxIncrementProportion_IsValid;

	private static int MaxIncrementProportion_Offset;

	private static bool NiagaraQueuePath_IsValid;

	private static int NiagaraQueuePath_Offset;

	private static bool NiagaraSysProcessionQueue_IsValid;

	private static FFieldAddress NiagaraSysProcessionQueue_PropertyAddress;

	private static int NiagaraSysProcessionQueue_Offset;

	private TArrayReadWriteMarshaler<UNiagaraSystem> NiagaraSysProcessionQueue_MarshalerCached;

	private static bool AutoMoving_IsValid;

	private static FFieldAddress AutoMoving_PropertyAddress;

	private static int AutoMoving_Offset;

	private static bool AutoMovingRange_IsValid;

	private static int AutoMovingRange_Offset;

	private static bool AutoMovingSpeed_IsValid;

	private static int AutoMovingSpeed_Offset;

	private static bool OutputReportDir_IsValid;

	private static int OutputReportDir_Offset;

	private static bool OutputReportFileName_IsValid;

	private static int OutputReportFileName_Offset;

	private static bool StopPlayingNiagaraSequence_IsValid;

	private static IntPtr StopPlayingNiagaraSequence_FunctionAddress;

	private static int StopPlayingNiagaraSequence_ParamsSize;

	private static bool StartPlayingNiagaraSequence_IsValid;

	private static IntPtr StartPlayingNiagaraSequence_FunctionAddress;

	private static int StartPlayingNiagaraSequence_ParamsSize;

	private static bool SetOutputFolderPath_IsValid;

	private static IntPtr SetOutputFolderPath_FunctionAddress;

	private static int SetOutputFolderPath_ParamsSize;

	private static bool SetFXFolderPath_IsValid;

	private static IntPtr SetFXFolderPath_FunctionAddress;

	private static int SetFXFolderPath_ParamsSize;

	private static bool ListAllStatNames_IsValid;

	private static IntPtr ListAllStatNames_FunctionAddress;

	private static int ListAllStatNames_ParamsSize;

	private static bool InspectStatValue_IsValid;

	private static IntPtr InspectStatValue_FunctionAddress;

	private static int InspectStatValue_ParamsSize;

	private static bool InspectStatValue_InStatName_IsValid;

	private static FFieldAddress InspectStatValue_InStatName_PropertyAddress;

	private static int InspectStatValue_InStatName_Offset;

	private static bool GenMonitorReport_IsValid;

	private static IntPtr GenMonitorReport_FunctionAddress;

	private static int GenMonitorReport_ParamsSize;

	private static bool FetchGSNiagaraInfo_IsValid;

	private static IntPtr FetchGSNiagaraInfo_FunctionAddress;

	private static int FetchGSNiagaraInfo_ParamsSize;

	private static bool FetchGSNiagaraInfo_bLogInfo_IsValid;

	private static FFieldAddress FetchGSNiagaraInfo_bLogInfo_PropertyAddress;

	private static int FetchGSNiagaraInfo_bLogInfo_Offset;

	private static bool AddEssentialStat_IsValid;

	private static IntPtr AddEssentialStat_FunctionAddress;

	private static int AddEssentialStat_ParamsSize;

	private static bool AddEssentialStat_InStatName_IsValid;

	private static FFieldAddress AddEssentialStat_InStatName_PropertyAddress;

	private static int AddEssentialStat_InStatName_Offset;

	private static bool AddEssentialStat_InThreshold_IsValid;

	private static FFieldAddress AddEssentialStat_InThreshold_PropertyAddress;

	private static int AddEssentialStat_InThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bTriggerFetchingStat")]
	public bool TriggerFetchingStat
	{
		get
		{
			CheckDestroyed();
			if (!TriggerFetchingStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bTriggerFetchingStat");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerFetchingStat_Offset), 0, TriggerFetchingStat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerFetchingStat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bTriggerFetchingStat");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerFetchingStat_Offset), 0, TriggerFetchingStat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchingPersistingFrames")]
	public int FetchingPersistingFrames
	{
		get
		{
			CheckDestroyed();
			if (!FetchingPersistingFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchingPersistingFrames");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FetchingPersistingFrames_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FetchingPersistingFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchingPersistingFrames");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FetchingPersistingFrames_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchingTargetStatName")]
	public string FetchingTargetStatName
	{
		get
		{
			CheckDestroyed();
			if (!FetchingTargetStatName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchingTargetStatName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FetchingTargetStatName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FetchingTargetStatName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchingTargetStatName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FetchingTargetStatName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bMonitorSwitch")]
	public bool MonitorSwitch
	{
		get
		{
			CheckDestroyed();
			if (!MonitorSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bMonitorSwitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MonitorSwitch_Offset), 0, MonitorSwitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MonitorSwitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bMonitorSwitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MonitorSwitch_Offset), 0, MonitorSwitch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:CaptureDuration")]
	public int CaptureDuration
	{
		get
		{
			CheckDestroyed();
			if (!CaptureDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:CaptureDuration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CaptureDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:CaptureDuration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CaptureDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:CaptureDurationAfterRemoved")]
	public int CaptureDurationAfterRemoved
	{
		get
		{
			CheckDestroyed();
			if (!CaptureDurationAfterRemoved_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:CaptureDurationAfterRemoved");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CaptureDurationAfterRemoved_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureDurationAfterRemoved_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:CaptureDurationAfterRemoved");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CaptureDurationAfterRemoved_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:MaxIncrementProportion")]
	public float MaxIncrementProportion
	{
		get
		{
			CheckDestroyed();
			if (!MaxIncrementProportion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:MaxIncrementProportion");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxIncrementProportion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxIncrementProportion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:MaxIncrementProportion");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxIncrementProportion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:NiagaraQueuePath")]
	public string NiagaraQueuePath
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraQueuePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:NiagaraQueuePath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, NiagaraQueuePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraQueuePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:NiagaraQueuePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, NiagaraQueuePath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:NiagaraSysProcessionQueue")]
	public TArrayReadWrite<UNiagaraSystem> NiagaraSysProcessionQueue
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraSysProcessionQueue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:NiagaraSysProcessionQueue");
				return null;
			}
			if (NiagaraSysProcessionQueue_MarshalerCached == null)
			{
				NiagaraSysProcessionQueue_MarshalerCached = new TArrayReadWriteMarshaler<UNiagaraSystem>(1, NiagaraSysProcessionQueue_PropertyAddress, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.FromNative, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.ToNative);
			}
			return NiagaraSysProcessionQueue_MarshalerCached.FromNative(IntPtr.Add(base.Address, NiagaraSysProcessionQueue_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bAutoMoving")]
	public bool AutoMoving
	{
		get
		{
			CheckDestroyed();
			if (!AutoMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bAutoMoving");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoMoving_Offset), 0, AutoMoving_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoMoving_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:bAutoMoving");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoMoving_Offset), 0, AutoMoving_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AutoMovingRange")]
	public float AutoMovingRange
	{
		get
		{
			CheckDestroyed();
			if (!AutoMovingRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AutoMovingRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoMovingRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoMovingRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AutoMovingRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoMovingRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AutoMovingSpeed")]
	public float AutoMovingSpeed
	{
		get
		{
			CheckDestroyed();
			if (!AutoMovingSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AutoMovingSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoMovingSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoMovingSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AutoMovingSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoMovingSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:OutputReportDir")]
	public string OutputReportDir
	{
		get
		{
			CheckDestroyed();
			if (!OutputReportDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:OutputReportDir");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, OutputReportDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputReportDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:OutputReportDir");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, OutputReportDir_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:OutputReportFileName")]
	public string OutputReportFileName
	{
		get
		{
			CheckDestroyed();
			if (!OutputReportFileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:OutputReportFileName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, OutputReportFileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputReportFileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:OutputReportFileName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, OutputReportFileName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:StopPlayingNiagaraSequence")]
	public unsafe void StopPlayingNiagaraSequence()
	{
		CheckDestroyed();
		if (!StopPlayingNiagaraSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:StopPlayingNiagaraSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopPlayingNiagaraSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopPlayingNiagaraSequence_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopPlayingNiagaraSequence_FunctionAddress, argsSize: StopPlayingNiagaraSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:StartPlayingNiagaraSequence")]
	public unsafe void StartPlayingNiagaraSequence()
	{
		CheckDestroyed();
		if (!StartPlayingNiagaraSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:StartPlayingNiagaraSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPlayingNiagaraSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPlayingNiagaraSequence_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPlayingNiagaraSequence_FunctionAddress, argsSize: StartPlayingNiagaraSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:SetOutputFolderPath")]
	public unsafe void SetOutputFolderPath()
	{
		CheckDestroyed();
		if (!SetOutputFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:SetOutputFolderPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOutputFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOutputFolderPath_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetOutputFolderPath_FunctionAddress, argsSize: SetOutputFolderPath_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:SetFXFolderPath")]
	public unsafe void SetFXFolderPath()
	{
		CheckDestroyed();
		if (!SetFXFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:SetFXFolderPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFXFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFXFolderPath_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetFXFolderPath_FunctionAddress, argsSize: SetFXFolderPath_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:ListAllStatNames")]
	public unsafe void ListAllStatNames()
	{
		CheckDestroyed();
		if (!ListAllStatNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:ListAllStatNames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ListAllStatNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ListAllStatNames_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ListAllStatNames_FunctionAddress, argsSize: ListAllStatNames_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:InspectStatValue")]
	public unsafe void InspectStatValue(string InStatName)
	{
		CheckDestroyed();
		if (!InspectStatValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:InspectStatValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InspectStatValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InspectStatValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InspectStatValue_InStatName_Offset), 0, InspectStatValue_InStatName_PropertyAddress.Address, InStatName);
		NativeReflection.InvokeFunctionOptimized(base.Address, InspectStatValue_FunctionAddress, intPtr, InspectStatValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InspectStatValue_InStatName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:GenMonitorReport")]
	public unsafe void GenMonitorReport()
	{
		CheckDestroyed();
		if (!GenMonitorReport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:GenMonitorReport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenMonitorReport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenMonitorReport_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GenMonitorReport_FunctionAddress, argsSize: GenMonitorReport_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchGSNiagaraInfo")]
	public unsafe void FetchGSNiagaraInfo(bool bLogInfo = false)
	{
		CheckDestroyed();
		if (!FetchGSNiagaraInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchGSNiagaraInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FetchGSNiagaraInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FetchGSNiagaraInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FetchGSNiagaraInfo_bLogInfo_Offset), 0, FetchGSNiagaraInfo_bLogInfo_PropertyAddress.Address, bLogInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, FetchGSNiagaraInfo_FunctionAddress, intPtr, FetchGSNiagaraInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AddEssentialStat")]
	public unsafe void AddEssentialStat(string InStatName, float InThreshold)
	{
		CheckDestroyed();
		if (!AddEssentialStat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AddEssentialStat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEssentialStat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEssentialStat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddEssentialStat_InStatName_Offset), 0, AddEssentialStat_InStatName_PropertyAddress.Address, InStatName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddEssentialStat_InThreshold_Offset), 0, AddEssentialStat_InThreshold_PropertyAddress.Address, InThreshold);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddEssentialStat_FunctionAddress, intPtr, AddEssentialStat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddEssentialStat_InStatName_PropertyAddress.Address, intPtr);
	}

	static AGSEditorNiagaraStatMonitor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSEditorNiagaraStatMonitor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSEditorNiagaraStatMonitor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor");
		NativeReflectionCached.GetPropertyRef(ref TriggerFetchingStat_PropertyAddress, intPtr, "bTriggerFetchingStat");
		TriggerFetchingStat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTriggerFetchingStat");
		TriggerFetchingStat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTriggerFetchingStat", Classes.FBoolProperty);
		FetchingPersistingFrames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FetchingPersistingFrames");
		FetchingPersistingFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FetchingPersistingFrames", Classes.FIntProperty);
		FetchingTargetStatName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FetchingTargetStatName");
		FetchingTargetStatName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FetchingTargetStatName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MonitorSwitch_PropertyAddress, intPtr, "bMonitorSwitch");
		MonitorSwitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMonitorSwitch");
		MonitorSwitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMonitorSwitch", Classes.FBoolProperty);
		CaptureDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureDuration");
		CaptureDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureDuration", Classes.FIntProperty);
		CaptureDurationAfterRemoved_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureDurationAfterRemoved");
		CaptureDurationAfterRemoved_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureDurationAfterRemoved", Classes.FIntProperty);
		MaxIncrementProportion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxIncrementProportion");
		MaxIncrementProportion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxIncrementProportion", Classes.FFloatProperty);
		NiagaraQueuePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NiagaraQueuePath");
		NiagaraQueuePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NiagaraQueuePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NiagaraSysProcessionQueue_PropertyAddress, intPtr, "NiagaraSysProcessionQueue");
		NiagaraSysProcessionQueue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NiagaraSysProcessionQueue");
		NiagaraSysProcessionQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NiagaraSysProcessionQueue", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoMoving_PropertyAddress, intPtr, "bAutoMoving");
		AutoMoving_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoMoving");
		AutoMoving_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoMoving", Classes.FBoolProperty);
		AutoMovingRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoMovingRange");
		AutoMovingRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoMovingRange", Classes.FFloatProperty);
		AutoMovingSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoMovingSpeed");
		AutoMovingSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoMovingSpeed", Classes.FFloatProperty);
		OutputReportDir_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputReportDir");
		OutputReportDir_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputReportDir", Classes.FStrProperty);
		OutputReportFileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputReportFileName");
		OutputReportFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputReportFileName", Classes.FStrProperty);
		StopPlayingNiagaraSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopPlayingNiagaraSequence");
		StopPlayingNiagaraSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(StopPlayingNiagaraSequence_FunctionAddress);
		StopPlayingNiagaraSequence_IsValid = StopPlayingNiagaraSequence_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:StopPlayingNiagaraSequence", StopPlayingNiagaraSequence_IsValid);
		StartPlayingNiagaraSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartPlayingNiagaraSequence");
		StartPlayingNiagaraSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPlayingNiagaraSequence_FunctionAddress);
		StartPlayingNiagaraSequence_IsValid = StartPlayingNiagaraSequence_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:StartPlayingNiagaraSequence", StartPlayingNiagaraSequence_IsValid);
		SetOutputFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOutputFolderPath");
		SetOutputFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputFolderPath_FunctionAddress);
		SetOutputFolderPath_IsValid = SetOutputFolderPath_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:SetOutputFolderPath", SetOutputFolderPath_IsValid);
		SetFXFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFXFolderPath");
		SetFXFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFXFolderPath_FunctionAddress);
		SetFXFolderPath_IsValid = SetFXFolderPath_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:SetFXFolderPath", SetFXFolderPath_IsValid);
		ListAllStatNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ListAllStatNames");
		ListAllStatNames_ParamsSize = NativeReflection.GetFunctionParamsSize(ListAllStatNames_FunctionAddress);
		ListAllStatNames_IsValid = ListAllStatNames_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:ListAllStatNames", ListAllStatNames_IsValid);
		InspectStatValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InspectStatValue");
		InspectStatValue_ParamsSize = NativeReflection.GetFunctionParamsSize(InspectStatValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InspectStatValue_InStatName_PropertyAddress, InspectStatValue_FunctionAddress, "InStatName");
		InspectStatValue_InStatName_Offset = NativeReflectionCached.GetPropertyOffset(InspectStatValue_FunctionAddress, "InStatName");
		InspectStatValue_InStatName_IsValid = NativeReflectionCached.ValidatePropertyClass(InspectStatValue_FunctionAddress, "InStatName", Classes.FStrProperty);
		InspectStatValue_IsValid = InspectStatValue_FunctionAddress != IntPtr.Zero && InspectStatValue_InStatName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:InspectStatValue", InspectStatValue_IsValid);
		GenMonitorReport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenMonitorReport");
		GenMonitorReport_ParamsSize = NativeReflection.GetFunctionParamsSize(GenMonitorReport_FunctionAddress);
		GenMonitorReport_IsValid = GenMonitorReport_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:GenMonitorReport", GenMonitorReport_IsValid);
		FetchGSNiagaraInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FetchGSNiagaraInfo");
		FetchGSNiagaraInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(FetchGSNiagaraInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FetchGSNiagaraInfo_bLogInfo_PropertyAddress, FetchGSNiagaraInfo_FunctionAddress, "bLogInfo");
		FetchGSNiagaraInfo_bLogInfo_Offset = NativeReflectionCached.GetPropertyOffset(FetchGSNiagaraInfo_FunctionAddress, "bLogInfo");
		FetchGSNiagaraInfo_bLogInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(FetchGSNiagaraInfo_FunctionAddress, "bLogInfo", Classes.FBoolProperty);
		FetchGSNiagaraInfo_IsValid = FetchGSNiagaraInfo_FunctionAddress != IntPtr.Zero && FetchGSNiagaraInfo_bLogInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:FetchGSNiagaraInfo", FetchGSNiagaraInfo_IsValid);
		AddEssentialStat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddEssentialStat");
		AddEssentialStat_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEssentialStat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEssentialStat_InStatName_PropertyAddress, AddEssentialStat_FunctionAddress, "InStatName");
		AddEssentialStat_InStatName_Offset = NativeReflectionCached.GetPropertyOffset(AddEssentialStat_FunctionAddress, "InStatName");
		AddEssentialStat_InStatName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEssentialStat_FunctionAddress, "InStatName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEssentialStat_InThreshold_PropertyAddress, AddEssentialStat_FunctionAddress, "InThreshold");
		AddEssentialStat_InThreshold_Offset = NativeReflectionCached.GetPropertyOffset(AddEssentialStat_FunctionAddress, "InThreshold");
		AddEssentialStat_InThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEssentialStat_FunctionAddress, "InThreshold", Classes.FFloatProperty);
		AddEssentialStat_IsValid = AddEssentialStat_FunctionAddress != IntPtr.Zero && AddEssentialStat_InStatName_IsValid && AddEssentialStat_InThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraStatMonitor:AddEssentialStat", AddEssentialStat_IsValid);
	}
}
