using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Custom Input")]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BED_QuestNode_CustomInput")]
public class BED_QuestNode_CustomInput : BED_QuestNode
{
	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_CustomInput:EventName")]
	public FName EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_CustomInput:EventName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_CustomInput:EventName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_CustomInput:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return EventName.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_CustomInput
		{
			EventName = EventName.PlainName
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.CustomInput;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_CustomInput:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_CustomInput bED_QuestNode_CustomInput = GCHelper.Find<BED_QuestNode_CustomInput>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_CustomInput.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_CustomInput");
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_CustomInput:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_CustomInput()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_CustomInput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_CustomInput));
	}
}
