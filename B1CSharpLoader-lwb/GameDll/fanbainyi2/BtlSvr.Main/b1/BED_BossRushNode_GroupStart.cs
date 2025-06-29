using System;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Reset Group Start")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BossRushNode_GroupStart")]
public class BED_BossRushNode_GroupStart : BED_BossRushNode
{
	private static bool GroupName_IsValid;

	private static int GroupName_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushNode_GroupStart:GroupName")]
	public FName GroupName
	{
		get
		{
			CheckDestroyed();
			if (!GroupName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_GroupStart:GroupName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GroupName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushNode_GroupStart:GroupName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GroupName_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "高级";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BossRushNode.GroupStart;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushNode_GroupStart:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return GroupName.ToString();
	}

	public override byte[] GetCustomData()
	{
		return Encoding.UTF8.GetBytes(GroupName.PlainName);
	}

	public void RefreshTemplateNodeState()
	{
		BED_BossRushAsset bED_BossRushAsset = GetCalliopeAsset() as BED_BossRushAsset;
		if (bED_BossRushAsset != null && bED_BossRushAsset.TryGetGroupNode(GroupName.PlainName, out var OutGroupNode))
		{
			FCalliopeConnectedPin connection = GetConnection(BGW_FlowUtils.PinName.Out);
			TMapReadWrite<FCalliopeGuid, UCalliopeNode> nodes = bED_BossRushAsset.Nodes;
			if (nodes != null && nodes.TryGetValue(connection.NodeGuid, out var value) && value is BED_BossRushNode_TemplateBase bED_BossRushNode_TemplateBase)
			{
				bED_BossRushNode_TemplateBase.RefreshSceneObjPoliceConfig(OutGroupNode);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushNode_GroupStart:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushNode_GroupStart bED_BossRushNode_GroupStart = GCHelper.Find<BED_BossRushNode_GroupStart>(obj);
		string nodeDescriptionInCS_Implementation = bED_BossRushNode_GroupStart.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushNode_GroupStart");
		GroupName_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupName");
		GroupName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupName", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushNode_GroupStart:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BossRushNode_GroupStart()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushNode_GroupStart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushNode_GroupStart));
	}
}
