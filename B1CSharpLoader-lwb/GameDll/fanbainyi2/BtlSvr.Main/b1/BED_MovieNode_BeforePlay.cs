using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("播放开始前")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_BeforePlay")]
internal class BED_MovieNode_BeforePlay : b1.BED_MovieNode_Event
{
	private static bool DelayTime_IsValid;

	private static int DelayTime_Offset;

	private static bool TimeDilationCurve_IsValid;

	private static int TimeDilationCurve_Offset;

	private static bool bUseAsyncTransBack_IsValid;

	private static int bUseAsyncTransBack_Offset;

	private static FFieldAddress bUseAsyncTransBack_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UMeta(MDProp.ClampMin, 0f)]
	[UProperty]
	[EditAnywhere]
	[Category("BeforePlay")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_BeforePlay:DelayTime")]
	protected float DelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_BeforePlay:DelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_BeforePlay:DelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("BeforePlay")]
	[UMeta(MDProp.EditCondition, "DelayTime > 0")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_BeforePlay:TimeDilationCurve")]
	protected UCurveFloat TimeDilationCurve
	{
		get
		{
			CheckDestroyed();
			if (!TimeDilationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_BeforePlay:TimeDilationCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, TimeDilationCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeDilationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_BeforePlay:TimeDilationCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, TimeDilationCurve_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0f)]
	[DisplayName("是否异步姿态回归")]
	[Category("BeforePlay")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_BeforePlay:bUseAsyncTransBack")]
	protected bool bUseAsyncTransBack
	{
		get
		{
			CheckDestroyed();
			if (!bUseAsyncTransBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_BeforePlay:bUseAsyncTransBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseAsyncTransBack_Offset), 0, bUseAsyncTransBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseAsyncTransBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_BeforePlay:bUseAsyncTransBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseAsyncTransBack_Offset), 0, bUseAsyncTransBack_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DelayTime = 0f;
		TimeDilationCurve = null;
		bUseAsyncTransBack = false;
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_BeforePlay movieCustom_BeforePlay = new MovieCustom_BeforePlay
		{
			DelayTime = DelayTime,
			UseAsyncTransback = bUseAsyncTransBack
		};
		if (TimeDilationCurve != null)
		{
			movieCustom_BeforePlay.TimeDilationCurve = TimeDilationCurve.GetPathName();
		}
		return movieCustom_BeforePlay.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_BeforePlay:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"DelayTime : {DelayTime:F3}");
		if (bUseAsyncTransBack)
		{
			stringBuilder.Append("\t 使用异步姿态回归");
		}
		if (TimeDilationCurve != null)
		{
			stringBuilder.Append("\nTime Dilation : " + TimeDilationCurve.GetPathName());
		}
		return stringBuilder.ToString();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.BeforePlay;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_BeforePlay:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_BeforePlay bED_MovieNode_BeforePlay = GCHelper.Find<b1.BED_MovieNode_BeforePlay>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_BeforePlay.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_BeforePlay");
		DelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTime");
		DelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTime", Classes.FFloatProperty);
		TimeDilationCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeDilationCurve");
		TimeDilationCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeDilationCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bUseAsyncTransBack_PropertyAddress, intPtr, "bUseAsyncTransBack");
		bUseAsyncTransBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseAsyncTransBack");
		bUseAsyncTransBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseAsyncTransBack", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_BeforePlay:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_BeforePlay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_BeforePlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_BeforePlay));
	}
}
