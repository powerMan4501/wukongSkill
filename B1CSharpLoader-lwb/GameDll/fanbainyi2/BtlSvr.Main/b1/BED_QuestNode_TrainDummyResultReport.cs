using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Train Dummy Result Report")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport")]
internal class BED_QuestNode_TrainDummyResultReport : BED_QuestNode
{
	private static bool TrainDummyMgrActor_IsValid;

	private static int TrainDummyMgrActor_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[Category("Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport:TrainDummyMgrActor")]
	public FGsActorGuidReference TrainDummyMgrActor
	{
		get
		{
			CheckDestroyed();
			if (!TrainDummyMgrActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport:TrainDummyMgrActor");
				return default(FGsActorGuidReference);
			}
			return FGsActorGuidReference.FromNative(IntPtr.Add(base.Address, TrainDummyMgrActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrainDummyMgrActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport:TrainDummyMgrActor");
			}
			else
			{
				FGsActorGuidReference.ToNative(IntPtr.Add(base.Address, TrainDummyMgrActor_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Auto Test");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.TrainDummyResultReport;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_TrainDummyResultReport
		{
			TrainDummyMgrActorGuid = TrainDummyMgrActor.ActorGuid
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string identityPath = null;
		if (TrainDummyMgrActor.ActorRef.IsValid)
		{
			string assetName = TrainDummyMgrActor.ActorRef.AssetName;
			string extension = FPaths.GetExtension(TrainDummyMgrActor.ActorRef.SubPathString);
			identityPath = assetName + ":" + extension;
		}
		return "Actor: " + GetIdentityDescription(identityPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_TrainDummyResultReport bED_QuestNode_TrainDummyResultReport = GCHelper.Find<b1.BED_QuestNode_TrainDummyResultReport>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_TrainDummyResultReport.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport");
		TrainDummyMgrActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TrainDummyMgrActor");
		TrainDummyMgrActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TrainDummyMgrActor", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_TrainDummyResultReport:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_TrainDummyResultReport()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_TrainDummyResultReport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_TrainDummyResultReport));
	}
}
