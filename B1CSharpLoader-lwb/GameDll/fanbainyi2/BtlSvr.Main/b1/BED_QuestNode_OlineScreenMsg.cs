using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Oline Screen Msg")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg")]
public class BED_QuestNode_OlineScreenMsg : BED_QuestNode
{
	private static bool EventId_IsValid;

	private static int EventId_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("OlineScreenMsg")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("公屏事件")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg:EventId")]
	public int EventId
	{
		get
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg:EventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg:EventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventId_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.TriggerOlineScreenMsg;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_OlineScreenMsg
		{
			EventId = EventId
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_OlineScreenMsg bED_QuestNode_OlineScreenMsg = GCHelper.Find<BED_QuestNode_OlineScreenMsg>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_OlineScreenMsg.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg");
		EventId_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventId");
		EventId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventId", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_OlineScreenMsg:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_OlineScreenMsg()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_OlineScreenMsg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_OlineScreenMsg));
	}
}
