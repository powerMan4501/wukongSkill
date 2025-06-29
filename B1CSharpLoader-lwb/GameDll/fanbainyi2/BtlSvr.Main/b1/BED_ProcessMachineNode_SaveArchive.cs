using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("存档 (SaveArchive)")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive")]
public class BED_ProcessMachineNode_SaveArchive : BED_ProcessMachineNode_TemplateBase
{
	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	private static bool ArchiveLabelParam_IsValid;

	private static int ArchiveLabelParam_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Archive")]
	[DisplayName("存档标记")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:ArchiveLabel")]
	public FName ArchiveLabel
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:ArchiveLabel");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ArchiveLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:ArchiveLabel");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ArchiveLabel_Offset), value);
			}
		}
	}

	[DisplayName("存档标记")]
	[Category("Archive")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:ArchiveLabelParam")]
	public FGsSmartParam ArchiveLabelParam
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveLabelParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:ArchiveLabelParam");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, ArchiveLabelParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveLabelParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:ArchiveLabelParam");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, ArchiveLabelParam_Offset), value);
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
		return B1CalliopeDef.ProcessMachineNode.SaveArchive;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return ArchiveLabel.PlainName;
	}

	public override byte[] GetCustomData()
	{
		ProcessCustom_SaveArchive processCustom_SaveArchive = new ProcessCustom_SaveArchive();
		processCustom_SaveArchive.ArchiveLabel = ArchiveLabelParam.ConfigGuid.ToString();
		processCustom_SaveArchive.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		processCustom_SaveArchive.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		processCustom_SaveArchive.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		processCustom_SaveArchive.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		processCustom_SaveArchive.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		return processCustom_SaveArchive.ToByteArray();
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		List<UCalliopeNode> list = (GetCalliopeAsset() as BED_ProcessAsset)?.GetValidNodes();
		if (list == null || !list.Contains(this))
		{
			return true;
		}
		foreach (FGsManagedArchiveLabel item in GetCalliopeAsset().CalliopeParameters.ArchiveLabelCollection)
		{
			if (item.ConfigGuid == ArchiveLabelParam.ConfigGuid)
			{
				return true;
			}
		}
		OutErrorMessage = "存档标记不能为空";
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_SaveArchive bED_ProcessMachineNode_SaveArchive = GCHelper.Find<BED_ProcessMachineNode_SaveArchive>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessMachineNode_SaveArchive.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive");
		ArchiveLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		ArchiveLabelParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "ArchiveLabelParam");
		ArchiveLabelParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ArchiveLabelParam", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_SaveArchive:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessMachineNode_SaveArchive()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_SaveArchive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_SaveArchive));
	}
}
