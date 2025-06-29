using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Counter")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_Counter")]
public class BED_QuestNode_Counter : BED_QuestNode
{
	private static bool Goal_IsValid;

	private static int Goal_Offset;

	private static bool CurrentSum_IsValid;

	private static int CurrentSum_Offset;

	private static bool GetStatusStringInCS_IsValid;

	private static IntPtr GetStatusStringInCS_FunctionAddress;

	private static int GetStatusStringInCS_ParamsSize;

	private static bool GetStatusStringInCS_ReturnValue_IsValid;

	private static int GetStatusStringInCS_ReturnValue_Offset;

	private static FFieldAddress GetStatusStringInCS_ReturnValue_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[Category("Counter")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Counter:Goal")]
	public int Goal
	{
		get
		{
			CheckDestroyed();
			if (!Goal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Counter:Goal");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Goal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Goal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Counter:Goal");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Goal_Offset), value);
			}
		}
	}

	[Category("Counter")]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_Counter:CurrentSum")]
	private int CurrentSum
	{
		get
		{
			CheckDestroyed();
			if (!CurrentSum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Counter:CurrentSum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurrentSum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentSum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_Counter:CurrentSum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurrentSum_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Increment
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Decrement
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Skip
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Zero
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Step
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Goal
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Skipped
		});
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_Counter:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return Goal.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_Counter:GetStatusStringInCS")]
	protected override string GetStatusStringInCS_Implementation()
	{
		return CurrentSum.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new QuestCustom_Counter
		{
			Goal = Goal
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Counter;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_Counter:GetStatusStringInCS")]
	private static void GetStatusStringInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_Counter bED_QuestNode_Counter = GCHelper.Find<BED_QuestNode_Counter>(obj);
		string statusStringInCS_Implementation = bED_QuestNode_Counter.GetStatusStringInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetStatusStringInCS_ReturnValue_Offset), statusStringInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_Counter:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_Counter bED_QuestNode_Counter = GCHelper.Find<BED_QuestNode_Counter>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_Counter.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_Counter");
		Goal_Offset = NativeReflection.GetPropertyOffset(intPtr, "Goal");
		Goal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Goal", Classes.FIntProperty);
		CurrentSum_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentSum");
		CurrentSum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentSum", Classes.FIntProperty);
		GetStatusStringInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusStringInCS");
		GetStatusStringInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusStringInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetStatusStringInCS_ReturnValue_PropertyAddress, GetStatusStringInCS_FunctionAddress, "ReturnValue");
		GetStatusStringInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStatusStringInCS_FunctionAddress, "ReturnValue");
		GetStatusStringInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStatusStringInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStatusStringInCS_IsValid = GetStatusStringInCS_FunctionAddress != IntPtr.Zero && GetStatusStringInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_Counter:GetStatusStringInCS", GetStatusStringInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_Counter:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_Counter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_Counter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_Counter));
	}
}
