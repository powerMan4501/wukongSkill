using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("QueryGameState")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_QueryGameState")]
public class BED_QuestNode_QueryGameState : BED_QuestNode
{
	private static bool QueryCondition_IsValid;

	private static int QueryCondition_Offset;

	private static FFieldAddress QueryCondition_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Query")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_QueryGameState:QueryCondition")]
	public EQueryGameStateCondition QueryCondition
	{
		get
		{
			CheckDestroyed();
			if (!QueryCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_QueryGameState:QueryCondition");
				return EQueryGameStateCondition.None;
			}
			return EnumMarshaler<EQueryGameStateCondition>.FromNative(IntPtr.Add(base.Address, QueryCondition_Offset), 0, QueryCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!QueryCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_QueryGameState:QueryCondition");
			}
			else
			{
				EnumMarshaler<EQueryGameStateCondition>.ToNative(IntPtr.Add(base.Address, QueryCondition_Offset), 0, QueryCondition_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Notifies");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.OutputPins.Clear();
		AddOutputPin("Success");
		AddOutputPin("Failed");
		AddOutputPin("Other");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.QueryGameState;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_QueryGameState
		{
			QueryCondition = (int)QueryCondition
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_QueryGameState");
		NativeReflection.GetPropertyRef(ref QueryCondition_PropertyAddress, unrealStruct, "QueryCondition");
		QueryCondition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "QueryCondition");
		QueryCondition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "QueryCondition", Classes.FEnumProperty);
	}

	static BED_QuestNode_QueryGameState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_QueryGameState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_QueryGameState));
	}
}
