using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Raise Award Probability")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability")]
public class BED_QuestNode_RaiseAwardProbability : BED_QuestNode
{
	private static bool EventId_IsValid;

	private static int EventId_Offset;

	private static bool RaiseType_IsValid;

	private static int RaiseType_Offset;

	private static FFieldAddress RaiseType_PropertyAddress;

	private static bool Probability_IsValid;

	private static int Probability_Offset;

	private static bool CanReduce_IsValid;

	private static int CanReduce_Offset;

	private static FFieldAddress CanReduce_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:EventId")]
	public int EventId
	{
		get
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:EventId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:EventId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:RaiseType")]
	public EAwardProbabilityRaiseType RaiseType
	{
		get
		{
			CheckDestroyed();
			if (!RaiseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:RaiseType");
				return EAwardProbabilityRaiseType.None;
			}
			return EnumMarshaler<EAwardProbabilityRaiseType>.FromNative(IntPtr.Add(base.Address, RaiseType_Offset), 0, RaiseType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RaiseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:RaiseType");
			}
			else
			{
				EnumMarshaler<EAwardProbabilityRaiseType>.ToNative(IntPtr.Add(base.Address, RaiseType_Offset), 0, RaiseType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:Probability")]
	public int Probability
	{
		get
		{
			CheckDestroyed();
			if (!Probability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:Probability");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Probability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Probability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:Probability");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Probability_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:CanReduce")]
	public bool CanReduce
	{
		get
		{
			CheckDestroyed();
			if (!CanReduce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:CanReduce");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanReduce_Offset), 0, CanReduce_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanReduce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:CanReduce");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanReduce_Offset), 0, CanReduce_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Notifies");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.RaiseAwardProbability;
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_RaiseAwardProbability
		{
			EventId = EventId,
			RaiseType = (int)RaiseType,
			Probability = Probability,
			CanReduce = CanReduce
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_RaiseAwardProbability bED_QuestNode_RaiseAwardProbability = GCHelper.Find<BED_QuestNode_RaiseAwardProbability>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_RaiseAwardProbability.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability");
		EventId_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventId");
		EventId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref RaiseType_PropertyAddress, intPtr, "RaiseType");
		RaiseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RaiseType");
		RaiseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RaiseType", Classes.FEnumProperty);
		Probability_Offset = NativeReflection.GetPropertyOffset(intPtr, "Probability");
		Probability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Probability", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CanReduce_PropertyAddress, intPtr, "CanReduce");
		CanReduce_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanReduce");
		CanReduce_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanReduce", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_RaiseAwardProbability:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_RaiseAwardProbability()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_RaiseAwardProbability)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_RaiseAwardProbability));
	}
}
