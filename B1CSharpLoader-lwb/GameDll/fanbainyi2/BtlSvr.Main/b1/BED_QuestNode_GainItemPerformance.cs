using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Gain Item Performance")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItemPerformance")]
internal class BED_QuestNode_GainItemPerformance : BED_QuestNode
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

	[EditAnywhere]
	[Category("Settings")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:ItemID")]
	public int ItemID
	{
		get
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:ItemID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:ItemID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemID_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Settings")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:Count")]
	public int Count
	{
		get
		{
			CheckDestroyed();
			if (!Count_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:Count");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Count_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Count_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:Count");
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
		return B1CalliopeDef.QuestNode.GainItemPerformance;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_GainItem
		{
			ItemId = ItemID,
			Count = Count
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"物品ID：{ItemID}\n数量：{Count}";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_GainItemPerformance bED_QuestNode_GainItemPerformance = GCHelper.Find<b1.BED_QuestNode_GainItemPerformance>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_GainItemPerformance.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_GainItemPerformance");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_GainItemPerformance:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_GainItemPerformance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_GainItemPerformance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_GainItemPerformance));
	}
}
