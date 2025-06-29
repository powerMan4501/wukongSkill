using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Player Use Item")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerUseItem")]
internal class BED_QuestNode_PlayerUseItem : BED_QuestNode
{
	private static bool ItemID_IsValid;

	private static int ItemID_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerUseItem:ItemID")]
	public int ItemID
	{
		get
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerUseItem:ItemID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerUseItem:ItemID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Auto Test");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Failed
		});
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PlayerUseItem;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_PlayerUseItem
		{
			ItemId = ItemID
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerUseItem:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"ItemID: {ItemID}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerUseItem:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerUseItem bED_QuestNode_PlayerUseItem = GCHelper.Find<b1.BED_QuestNode_PlayerUseItem>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayerUseItem.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayerUseItem");
		ItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemID");
		ItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemID", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerUseItem:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayerUseItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_PlayerUseItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_PlayerUseItem));
	}
}
