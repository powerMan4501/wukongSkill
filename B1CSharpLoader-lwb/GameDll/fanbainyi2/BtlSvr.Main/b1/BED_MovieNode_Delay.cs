using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("延时")]
[UClass]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_MovieNode_Delay")]
internal class BED_MovieNode_Delay : BED_MovieNode
{
	private static bool DelayTime_IsValid;

	private static int DelayTime_Offset;

	private static bool TimeDilationCurve_IsValid;

	private static int TimeDilationCurve_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Delay")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, 0f)]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Delay:DelayTime")]
	protected float DelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Delay:DelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Delay:DelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTime_Offset), value);
			}
		}
	}

	[Category("Delay")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_Delay:TimeDilationCurve")]
	protected UCurveFloat TimeDilationCurve
	{
		get
		{
			CheckDestroyed();
			if (!TimeDilationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Delay:TimeDilationCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, TimeDilationCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeDilationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_Delay:TimeDilationCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, TimeDilationCurve_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
		DelayTime = 0.5f;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_Delay:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"DelayTime : {DelayTime:F3}");
		if (TimeDilationCurve != null)
		{
			stringBuilder.Append("\nTime Dilation : " + TimeDilationCurve.GetPathName());
		}
		return stringBuilder.ToString();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.Delay;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_Delay
		{
			DelayTime = DelayTime,
			TimeDilationCurve = TimeDilationCurve.GetPathName()
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_Delay:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_Delay bED_MovieNode_Delay = GCHelper.Find<b1.BED_MovieNode_Delay>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_Delay.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_Delay");
		DelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTime");
		DelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTime", Classes.FFloatProperty);
		TimeDilationCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeDilationCurve");
		TimeDilationCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeDilationCurve", Classes.FObjectProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_Delay:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_Delay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_Delay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_Delay));
	}
}
