using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Player Move To Train Dummy Target")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget")]
internal class BED_QuestNode_PlayerMoveToTrainDummyTarget : BED_QuestNode
{
	private static bool MoveFinishDistance_IsValid;

	private static int MoveFinishDistance_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget:MoveFinishDistance")]
	public float MoveFinishDistance
	{
		get
		{
			CheckDestroyed();
			if (!MoveFinishDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget:MoveFinishDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveFinishDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveFinishDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget:MoveFinishDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveFinishDistance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Auto Test");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PlayerMoveToTrainDummyTarget;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_PlayerMoveToTrainDummyTarget
		{
			MoveFinishDistance = MoveFinishDistance
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"MoveFinishDistance: {MoveFinishDistance}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerMoveToTrainDummyTarget bED_QuestNode_PlayerMoveToTrainDummyTarget = GCHelper.Find<b1.BED_QuestNode_PlayerMoveToTrainDummyTarget>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayerMoveToTrainDummyTarget.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget");
		MoveFinishDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveFinishDistance");
		MoveFinishDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveFinishDistance", Classes.FFloatProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerMoveToTrainDummyTarget:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayerMoveToTrainDummyTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_PlayerMoveToTrainDummyTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_PlayerMoveToTrainDummyTarget));
	}
}
