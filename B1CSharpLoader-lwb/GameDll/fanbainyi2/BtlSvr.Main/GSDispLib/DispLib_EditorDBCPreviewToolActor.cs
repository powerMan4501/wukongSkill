using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor")]
public class DispLib_EditorDBCPreviewToolActor : ABGUPlacedEditorUtilityBase
{
	public delegate void Del_Editor_OnTick(float DeltaSeconds);

	public Del_Editor_OnTick Evt_EditorTick;

	private List<DispLib_OneMeshCompEditorDBCPreviewData> TArray_AllPreviewData = new List<DispLib_OneMeshCompEditorDBCPreviewData>();

	private BWC_DispLibDispWorldDBCQueueData interior_EditorSimulateECSData_DLDWorld_DBCQueue;

	private BUC_DispLibDBCBaseData interior_EditorSimulateECSData_DLDWorld_DBCBaseData;

	private BWC_DispLibCameraData interior_EditorSimulate_DispLibCameraData;

	private BWC_DispLibDispWorldGlobalData interior_EditorSimulate_GlobalData;

	private BWS_DispLibDBCManageComp interior_RuntimeCompUseAsEditor_DLDWorld_DBCManageComp;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool OnWorldCleanup_IsValid;

	private static IntPtr OnWorldCleanup_FunctionAddress;

	private static int OnWorldCleanup_ParamsSize;

	private static bool OnWorldCleanup_world_IsValid;

	private static int OnWorldCleanup_world_Offset;

	private static bool OnWorldCleanup_sessionEnded_IsValid;

	private static int OnWorldCleanup_sessionEnded_Offset;

	private static FFieldAddress OnWorldCleanup_sessionEnded_PropertyAddress;

	private static bool OnWorldCleanup_cleanupResources_IsValid;

	private static int OnWorldCleanup_cleanupResources_Offset;

	private static FFieldAddress OnWorldCleanup_cleanupResources_PropertyAddress;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	private BWC_DispLibDispWorldDBCQueueData EditorSimulateECSData_DLDWorld_DBCQueue
	{
		get
		{
			if (interior_EditorSimulateECSData_DLDWorld_DBCQueue == null)
			{
				interior_EditorSimulateECSData_DLDWorld_DBCQueue = new BWC_DispLibDispWorldDBCQueueData();
				interior_EditorSimulateECSData_DLDWorld_DBCQueue.Init(this);
			}
			return interior_EditorSimulateECSData_DLDWorld_DBCQueue;
		}
		set
		{
			interior_EditorSimulateECSData_DLDWorld_DBCQueue = value;
		}
	}

	private BUC_DispLibDBCBaseData EditorSimulateECSData_DLDWorld_DBCBaseData
	{
		get
		{
			if (interior_EditorSimulateECSData_DLDWorld_DBCBaseData == null)
			{
				interior_EditorSimulateECSData_DLDWorld_DBCBaseData = new BUC_DispLibDBCBaseData();
				interior_EditorSimulateECSData_DLDWorld_DBCBaseData.Init(GetRootComponent(), DispLibDBCActorGroup.DLDWorld, this);
			}
			return interior_EditorSimulateECSData_DLDWorld_DBCBaseData;
		}
		set
		{
			interior_EditorSimulateECSData_DLDWorld_DBCBaseData = value;
		}
	}

	private BWC_DispLibCameraData EditorSimulate_DispLibCameraData
	{
		get
		{
			if (interior_EditorSimulate_DispLibCameraData == null)
			{
				interior_EditorSimulate_DispLibCameraData = new BWC_DispLibCameraData();
				interior_EditorSimulate_DispLibCameraData.Init(GetRootComponent());
			}
			return interior_EditorSimulate_DispLibCameraData;
		}
		set
		{
			interior_EditorSimulate_DispLibCameraData = value;
		}
	}

	private BWC_DispLibDispWorldGlobalData EditorSimulate_GlobalData
	{
		get
		{
			if (interior_EditorSimulate_GlobalData == null)
			{
				interior_EditorSimulate_GlobalData = new BWC_DispLibDispWorldGlobalData();
				interior_EditorSimulate_GlobalData.Init(GetRootComponent(), 0);
			}
			return interior_EditorSimulate_GlobalData;
		}
		set
		{
			interior_EditorSimulate_GlobalData = value;
		}
	}

	public BWS_DispLibDBCManageComp RuntimeCompUseAsEditor_DLDWorld_DBCManageComp
	{
		get
		{
			return interior_RuntimeCompUseAsEditor_DLDWorld_DBCManageComp;
		}
		private set
		{
			interior_RuntimeCompUseAsEditor_DLDWorld_DBCManageComp = value;
		}
	}

	public void Init()
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:OnWorldCleanup")]
	protected override void OnWorldCleanup_Implementation(UWorld world, bool sessionEnded, bool cleanupResources)
	{
	}

	private void DestroyAllPreviewActorInfo()
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
	}

	private void InitCSharpObject()
	{
	}

	private void InsureFieldsValid()
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
	}

	public static bool Editor_Request_End_ModMat_ByDBCID(uint DBCID, USkeletalMeshComponent MeshComp)
	{
		return false;
	}

	public static bool Editor_Request_End_ModMat_ByAnimNotifyUniqueID(USkeletalMeshComponent MeshComp, uint AnimNotifyUniqueID, int EndStagePriority, bool ForceDestroyComponent)
	{
		return false;
	}

	public static bool Editor_Rquest_End_Niagara_ByAnimNotifyUniqueID(USkeletalMeshComponent MeshComp, uint AnimNotifyUniqueID, int EndStagePriority, bool ForceDestroyComponent)
	{
		return false;
	}

	public static bool Editor_Rquest_End_Niagara_ByDBCID(USkeletalMeshComponent MeshComp, uint DBCID, int EndStagePriority, bool ForceDestroyComponent)
	{
		return false;
	}

	public static bool Editor_RquestEndNiagaraByTag(USkeletalMeshComponent MeshComp, FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1)
	{
		return false;
	}

	public static uint Editor_RquestPlayOneDBCCommonNiagara(DispLibRefParam DBCRefParam, USceneComponent MeshComp, BUC_DispLibDBC_PlayNiagara SpawnData, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		DBCRefParam.Clean();
		return 0u;
	}

	public static uint Editor_RequestApplyModMat(USkeletalMeshComponent MeshComp, BUC_DispLibDBC_ModifyMaterial D, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		return 0u;
	}

	public static void Editor_RequestPauseDBCEffect(USkeletalMeshComponent MeshComp, uint IdentityID, bool Pause, int PausePriority, string PauseReason)
	{
	}

	public static void Editor_RequestOneCustomUAFByCustomDataAsset(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, USkeletalMeshComponent MeshComp, BUC_DispLibUnitArtFresnelDataAsset CustomDataAsset, int Priority, DispLibRefParam RefParam, float OverrideTime, float OverrideOnePeriodTime, int FOverrideLoop, int OverrideSimpleProgrammedCurve, float OverrideFadeInTime, float OverrideCommonTime, float OverrideFadeOutTime, float OverrideProgrammedPowerMax)
	{
	}

	public static DispLib_OneMeshCompEditorDBCPreviewData GetEditorDBCPreviewData(USceneComponent MeshComp)
	{
		return null;
	}

	public static BUS_DispLibEventCollection GetDBCPreviewActorEditorEventCollection(USceneComponent MeshComp)
	{
		return null;
	}

	private static DispLib_EditorDBCPreviewToolActor GetDBCPreviewToolActor(USceneComponent DispOwnerComp)
	{
		return null;
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorDBCPreviewToolActor dispLib_EditorDBCPreviewToolActor = GCHelper.Find<DispLib_EditorDBCPreviewToolActor>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		dispLib_EditorDBCPreviewToolActor.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:OnWorldCleanup")]
	private static void OnWorldCleanup__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorDBCPreviewToolActor dispLib_EditorDBCPreviewToolActor = GCHelper.Find<DispLib_EditorDBCPreviewToolActor>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnWorldCleanup_world_Offset));
		bool sessionEnded = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnWorldCleanup_sessionEnded_Offset), 0, OnWorldCleanup_sessionEnded_PropertyAddress.Address);
		bool cleanupResources = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnWorldCleanup_cleanupResources_Offset), 0, OnWorldCleanup_cleanupResources_PropertyAddress.Address);
		dispLib_EditorDBCPreviewToolActor.OnWorldCleanup_Implementation(world, sessionEnded, cleanupResources);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorDBCPreviewToolActor dispLib_EditorDBCPreviewToolActor = GCHelper.Find<DispLib_EditorDBCPreviewToolActor>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		dispLib_EditorDBCPreviewToolActor.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_EditorDBCPreviewToolActor dispLib_EditorDBCPreviewToolActor = GCHelper.Find<DispLib_EditorDBCPreviewToolActor>(obj);
		dispLib_EditorDBCPreviewToolActor.ReceiveDestroyed_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor");
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveTick", ReceiveTick_IsValid);
		OnWorldCleanup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldCleanup");
		OnWorldCleanup_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldCleanup_FunctionAddress);
		OnWorldCleanup_world_Offset = NativeReflection.GetPropertyOffset(OnWorldCleanup_FunctionAddress, "world");
		OnWorldCleanup_world_IsValid = NativeReflection.ValidatePropertyClass(OnWorldCleanup_FunctionAddress, "world", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnWorldCleanup_sessionEnded_PropertyAddress, OnWorldCleanup_FunctionAddress, "sessionEnded");
		OnWorldCleanup_sessionEnded_Offset = NativeReflection.GetPropertyOffset(OnWorldCleanup_FunctionAddress, "sessionEnded");
		OnWorldCleanup_sessionEnded_IsValid = NativeReflection.ValidatePropertyClass(OnWorldCleanup_FunctionAddress, "sessionEnded", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnWorldCleanup_cleanupResources_PropertyAddress, OnWorldCleanup_FunctionAddress, "cleanupResources");
		OnWorldCleanup_cleanupResources_Offset = NativeReflection.GetPropertyOffset(OnWorldCleanup_FunctionAddress, "cleanupResources");
		OnWorldCleanup_cleanupResources_IsValid = NativeReflection.ValidatePropertyClass(OnWorldCleanup_FunctionAddress, "cleanupResources", Classes.FBoolProperty);
		OnWorldCleanup_IsValid = OnWorldCleanup_FunctionAddress != IntPtr.Zero && OnWorldCleanup_world_IsValid && OnWorldCleanup_sessionEnded_IsValid && OnWorldCleanup_cleanupResources_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:OnWorldCleanup", OnWorldCleanup_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_EditorDBCPreviewToolActor:ReceiveDestroyed", ReceiveDestroyed_IsValid);
	}

	static DispLib_EditorDBCPreviewToolActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_EditorDBCPreviewToolActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_EditorDBCPreviewToolActor));
	}
}
