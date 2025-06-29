using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(false)]
[DisplayName("Gain Item")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItem")]
internal class BED_QuestNode_GainItem : BED_QuestNode
{
	private static bool ItemID_IsValid;

	private static int ItemID_Offset;

	private static bool Count_IsValid;

	private static int Count_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Settings")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItem:ItemID")]
	public int ItemID
	{
		get
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItem:ItemID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItem:ItemID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemID_Offset), value);
			}
		}
	}

	[Category("Settings")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItem:Count")]
	public int Count
	{
		get
		{
			CheckDestroyed();
			if (!Count_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItem:Count");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Count_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Count_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItem:Count");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Count_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ItemID = -1;
		Count = 0;
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.GainItem;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_GainItem
		{
			ItemId = ItemID,
			Count = Count
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItem:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"物品ID：{ItemID}\n数量：{Count}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_GainItem:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_GainItem bED_QuestNode_GainItem = GCHelper.Find<b1.BED_QuestNode_GainItem>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_GainItem.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_GainItem");
		ItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemID");
		ItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemID", Classes.FIntProperty);
		Count_Offset = NativeReflection.GetPropertyOffset(intPtr, "Count");
		Count_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Count", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_GainItem:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_GainItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_GainItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_GainItem));
	}
}
