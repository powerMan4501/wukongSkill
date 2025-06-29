using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("推进任务阶段状态")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState")]
internal class BED_TaskNode_PushTaskStageState : BED_TaskNode
{
	private static bool PushTaskStage_IsValid;

	private static int PushTaskStage_Offset;

	private static bool IsPushToEnd_IsValid;

	private static int IsPushToEnd_Offset;

	private static FFieldAddress IsPushToEnd_PropertyAddress;

	private static bool IsTriggerSaveArchive_IsValid;

	private static int IsTriggerSaveArchive_Offset;

	private static FFieldAddress IsTriggerSaveArchive_PropertyAddress;

	private static bool ArchiveLabelParam_IsValid;

	private static int ArchiveLabelParam_Offset;

	private static bool PushTaskStageID_IsValid;

	private static int PushTaskStageID_Offset;

	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[DisplayName("推进任务阶段ID")]
	[EditDefaultsOnly]
	[Category("Push Task Stage State")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:PushTaskStage")]
	public FGsSmartParam PushTaskStage
	{
		get
		{
			CheckDestroyed();
			if (!PushTaskStage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:PushTaskStage");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, PushTaskStage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PushTaskStage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:PushTaskStage");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, PushTaskStage_Offset), value);
			}
		}
	}

	[DisplayName("是否直接推进到完成")]
	[UProperty]
	[EditDefaultsOnly]
	[Category("Push Task Stage State")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:IsPushToEnd")]
	public bool IsPushToEnd
	{
		get
		{
			CheckDestroyed();
			if (!IsPushToEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:IsPushToEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPushToEnd_Offset), 0, IsPushToEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPushToEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:IsPushToEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPushToEnd_Offset), 0, IsPushToEnd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("是否触发存档")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:IsTriggerSaveArchive")]
	public bool IsTriggerSaveArchive
	{
		get
		{
			CheckDestroyed();
			if (!IsTriggerSaveArchive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:IsTriggerSaveArchive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTriggerSaveArchive_Offset), 0, IsTriggerSaveArchive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTriggerSaveArchive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:IsTriggerSaveArchive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTriggerSaveArchive_Offset), 0, IsTriggerSaveArchive_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("存档标记")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "IsTriggerSaveArchive")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:ArchiveLabelParam")]
	public FGsSmartParam ArchiveLabelParam
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveLabelParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:ArchiveLabelParam");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, ArchiveLabelParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveLabelParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:ArchiveLabelParam");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, ArchiveLabelParam_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:PushTaskStageID")]
	public int PushTaskStageID
	{
		get
		{
			CheckDestroyed();
			if (!PushTaskStageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:PushTaskStageID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PushTaskStageID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PushTaskStageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:PushTaskStageID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PushTaskStageID_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:ArchiveLabel")]
	public FName ArchiveLabel
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:ArchiveLabel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ArchiveLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:ArchiveLabel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ArchiveLabel_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Gameplay");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.PushTaskStageState;
	}

	public override byte[] GetCustomData()
	{
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return new byte[1];
		}
		return new TaskCustom_PushTaskStageState
		{
			TaskStageId = assetInCS.GetTaskStageIDBySmartParam(PushTaskStage),
			IsPushToEnd = IsPushToEnd,
			IsTriggerSaveArchive = IsTriggerSaveArchive,
			ArchiveLabel = assetInCS.GetArchiveLabelBySmartParam(ArchiveLabelParam)
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"要推进的任务阶段ID：{GetAssetInCS()?.GetTaskStageIDBySmartParam(PushTaskStage)}\n是否直接推进到完成：{IsPushToEnd}";
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		int taskStageIDBySmartParam = GetAssetInCS().GetTaskStageIDBySmartParam(PushTaskStage);
		if (BGW_GameDB.GetTaskStageDesc(taskStageIDBySmartParam) == null)
		{
			OutErrorMessage = $"任务阶段{taskStageIDBySmartParam}不存在";
			return false;
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_TaskNode_PushTaskStageState bED_TaskNode_PushTaskStageState = GCHelper.Find<b1.BED_TaskNode_PushTaskStageState>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_PushTaskStageState.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_PushTaskStageState");
		PushTaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "PushTaskStage");
		PushTaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PushTaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsPushToEnd_PropertyAddress, intPtr, "IsPushToEnd");
		IsPushToEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsPushToEnd");
		IsPushToEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsPushToEnd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsTriggerSaveArchive_PropertyAddress, intPtr, "IsTriggerSaveArchive");
		IsTriggerSaveArchive_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsTriggerSaveArchive");
		IsTriggerSaveArchive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsTriggerSaveArchive", Classes.FBoolProperty);
		ArchiveLabelParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabelParam");
		ArchiveLabelParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabelParam", Classes.FStructProperty);
		PushTaskStageID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PushTaskStageID");
		PushTaskStageID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PushTaskStageID", Classes.FIntProperty);
		ArchiveLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_PushTaskStageState:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_TaskNode_PushTaskStageState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_TaskNode_PushTaskStageState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_TaskNode_PushTaskStageState));
	}
}
