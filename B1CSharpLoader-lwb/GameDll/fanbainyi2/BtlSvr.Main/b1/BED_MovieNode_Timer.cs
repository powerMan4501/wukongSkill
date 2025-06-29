using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("计时器")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_Timer")]
internal class BED_MovieNode_Timer : BED_MovieNode
{
	private static bool CompletionTime_IsValid;

	private static int CompletionTime_Offset;

	private static bool StepTime_IsValid;

	private static int StepTime_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[Category("Timer")]
	[UMeta(MDProp.ClampMin, 0f)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Timer:CompletionTime")]
	protected float CompletionTime
	{
		get
		{
			CheckDestroyed();
			if (!CompletionTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Timer:CompletionTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CompletionTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompletionTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Timer:CompletionTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CompletionTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0f)]
	[UProperty]
	[EditAnywhere]
	[Category("Timer")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Timer:StepTime")]
	protected float StepTime
	{
		get
		{
			CheckDestroyed();
			if (!StepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Timer:StepTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StepTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StepTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Timer:StepTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StepTime_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Completed
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.Step
		});
		CompletionTime = 1f;
		StepTime = 0f;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_Timer:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (CompletionTime > 0f)
		{
			if (StepTime > 0f)
			{
				return $"{CompletionTime:F2}, step by {StepTime:F2}";
			}
			return CompletionTime.ToString("F2");
		}
		return "Invalid settings";
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_Timer
		{
			CompletionTime = CompletionTime,
			StepTime = StepTime
		}.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.Timer;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_Timer:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_Timer bED_MovieNode_Timer = GCHelper.Find<b1.BED_MovieNode_Timer>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_Timer.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_Timer");
		CompletionTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompletionTime");
		CompletionTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompletionTime", Classes.FFloatProperty);
		StepTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "StepTime");
		StepTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StepTime", Classes.FFloatProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_Timer:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_Timer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_Timer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_Timer));
	}
}
