using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("一段时间后")]
[USharpPath("/Script/b1-Managed.PerformerCondition_Time")]
public class PerformerCondition_Time : PerformerConditionBase
{
	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerCondition_Time:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_Time:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_Time:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	public float RemainTime { get; set; }

	protected override bool IsSuccess()
	{
		if (RemainTime <= 1E-08f)
		{
			return true;
		}
		return false;
	}

	protected override void OnBegin()
	{
		RemainTime = Time;
	}

	protected override void OnTick(float InDeltaTime)
	{
		RemainTime -= InDeltaTime;
	}

	protected override void OnEnd()
	{
		RemainTime = -1f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerCondition_Time");
		Time_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time", Classes.FFloatProperty);
	}

	static PerformerCondition_Time()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PerformerCondition_Time)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PerformerCondition_Time));
	}
}
