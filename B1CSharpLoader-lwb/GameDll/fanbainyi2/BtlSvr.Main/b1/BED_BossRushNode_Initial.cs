using System;
using b1.Plugins.Calliope;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("Initial State")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BossRushNode_Initial")]
public class BED_BossRushNode_Initial : BED_BossRushNode
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.BossRushNode.Initial;
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
		BED_BossRushAsset bED_BossRushAsset = GetCalliopeAsset() as BED_BossRushAsset;
		if (bED_BossRushAsset == null)
		{
			return base.GetCustomData();
		}
		return bED_BossRushAsset.GetInitialNodeData().ToByteArray();
	}

	public override uint GetCustomDataVersion()
	{
		return 2u;
	}

	public void RefreshTemplateNodeState()
	{
		FCalliopeConnectedPin connection = GetConnection(BGW_FlowUtils.PinName.Out);
		TMapReadWrite<FCalliopeGuid, UCalliopeNode> tMapReadWrite = GetCalliopeAsset()?.Nodes;
		if (tMapReadWrite != null && tMapReadWrite.TryGetValue(connection.NodeGuid, out var value) && value is BED_BossRushNode_TemplateBase bED_BossRushNode_TemplateBase)
		{
			bED_BossRushNode_TemplateBase.RefreshSceneObjPoliceConfig(null);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushNode_Initial");
	}

	static BED_BossRushNode_Initial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushNode_Initial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushNode_Initial));
	}
}
