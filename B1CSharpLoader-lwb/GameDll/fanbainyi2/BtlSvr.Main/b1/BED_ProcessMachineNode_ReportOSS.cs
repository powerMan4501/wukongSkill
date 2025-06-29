using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("上报OSS (ReportOSS)")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS")]
public class BED_ProcessMachineNode_ReportOSS : BED_ProcessMachineNode_TemplateBase
{
	private static bool TaskLine_IsValid;

	private static int TaskLine_Offset;

	private static bool StageNote_IsValid;

	private static int StageNote_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("任务线ID")]
	[Category("OSS")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:TaskLine")]
	public FGsSmartParam TaskLine
	{
		get
		{
			CheckDestroyed();
			if (!TaskLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:TaskLine");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, TaskLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:TaskLine");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, TaskLine_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("OSS")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("任务阶段备注")]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:StageNote")]
	public FName StageNote
	{
		get
		{
			CheckDestroyed();
			if (!StageNote_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:StageNote");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StageNote_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StageNote_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:StageNote");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StageNote_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.SupportsContextPins = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.ReportOSS;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return StageNote.PlainName;
	}

	public override byte[] GetCustomData()
	{
		ProcessCustom_ReportOSS processCustom_ReportOSS = new ProcessCustom_ReportOSS();
		processCustom_ReportOSS.TaskLine = TaskLine.ConfigGuid.ToString();
		processCustom_ReportOSS.StageNote = StageNote.ToString();
		processCustom_ReportOSS.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		processCustom_ReportOSS.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		processCustom_ReportOSS.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		processCustom_ReportOSS.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		processCustom_ReportOSS.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		return processCustom_ReportOSS.ToByteArray();
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		List<UCalliopeNode> list = (GetCalliopeAsset() as BED_ProcessAsset)?.GetValidNodes();
		if (list == null || !list.Contains(this))
		{
			return true;
		}
		if (StageNote != FName.None)
		{
			return true;
		}
		OutErrorMessage = "任务阶段备注不能为空";
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_ReportOSS bED_ProcessMachineNode_ReportOSS = GCHelper.Find<BED_ProcessMachineNode_ReportOSS>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessMachineNode_ReportOSS.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS");
		TaskLine_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskLine");
		TaskLine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskLine", Classes.FStructProperty);
		StageNote_Offset = NativeReflection.GetPropertyOffset(intPtr, "StageNote");
		StageNote_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StageNote", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_ReportOSS:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessMachineNode_ReportOSS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_ReportOSS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_ReportOSS));
	}
}
