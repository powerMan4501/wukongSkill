using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig")]
public class BGWDataAsset_ABSPosToUVConfig : UBGWDataAsset
{
	private static bool RecordTime_IsValid;

	private static int RecordTime_Offset;

	private static bool RecordMinValue_IsValid;

	private static int RecordMinValue_Offset;

	private static bool DelayTime_IsValid;

	private static int DelayTime_Offset;

	private static bool SpeedClamp_IsValid;

	private static int SpeedClamp_Offset;

	[DisplayName("记录最长时间(s)")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:RecordTime")]
	public float RecordTime
	{
		get
		{
			CheckDestroyed();
			if (!RecordTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:RecordTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RecordTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RecordTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:RecordTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RecordTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("记录最小值(像素)")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:RecordMinValue")]
	public float RecordMinValue
	{
		get
		{
			CheckDestroyed();
			if (!RecordMinValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:RecordMinValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RecordMinValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RecordMinValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:RecordMinValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RecordMinValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("输入延迟时间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:DelayTime")]
	public float DelayTime
	{
		get
		{
			CheckDestroyed();
			if (!DelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:DelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:DelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("速度范围")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:SpeedClamp")]
	public FVector2D SpeedClamp
	{
		get
		{
			CheckDestroyed();
			if (!SpeedClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:SpeedClamp");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, SpeedClamp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedClamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig:SpeedClamp");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, SpeedClamp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RecordTime = 1f;
		RecordMinValue = 10f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ABSPosToUVConfig");
		RecordTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RecordTime");
		RecordTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RecordTime", Classes.FFloatProperty);
		RecordMinValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RecordMinValue");
		RecordMinValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RecordMinValue", Classes.FFloatProperty);
		DelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DelayTime");
		DelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DelayTime", Classes.FFloatProperty);
		SpeedClamp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedClamp");
		SpeedClamp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedClamp", Classes.FStructProperty);
	}

	static BGWDataAsset_ABSPosToUVConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ABSPosToUVConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ABSPosToUVConfig));
	}
}
