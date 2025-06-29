using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Initial State")]
[UClass]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Initial")]
public class BED_ProcessMachineNode_Initial : BED_ProcessMachineNode
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Initial;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Machine Nodes";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
	}

	public override byte[] GetCustomData()
	{
		BED_ProcessAsset bED_ProcessAsset = GetCalliopeAsset() as BED_ProcessAsset;
		if (bED_ProcessAsset == null)
		{
			return base.GetCustomData();
		}
		ProcessCustom_Initial processCustom_Initial = new ProcessCustom_Initial();
		processCustom_Initial.AssetParams.AddRange(bED_ProcessAsset.GetAssetParams());
		return processCustom_Initial.ToByteArray();
	}

	public override uint GetCustomDataVersion()
	{
		return 1u;
	}

	public void RefreshTemplateNodeState()
	{
		FCalliopeConnectedPin connection = GetConnection(BGW_FlowUtils.PinName.Out);
		TMapReadWrite<FCalliopeGuid, UCalliopeNode> tMapReadWrite = GetCalliopeAsset()?.Nodes;
		if (tMapReadWrite != null && tMapReadWrite.TryGetValue(connection.NodeGuid, out var value) && value is BED_ProcessMachineNode_TemplateBase bED_ProcessMachineNode_TemplateBase)
		{
			bED_ProcessMachineNode_TemplateBase.RefreshSceneObjPoliceConfig(null);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Initial");
	}

	static BED_ProcessMachineNode_Initial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Initial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Initial));
	}
}
