using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset")]
public class BGW_DispLibCameraBlockDataAsset : UBGWDataAsset
{
	private static bool InRange_IsValid;

	private static int InRange_Offset;

	private static bool OutRange_IsValid;

	private static int OutRange_Offset;

	private static bool TriggerAngle_IsValid;

	private static int TriggerAngle_Offset;

	private static bool HeightDelta_IsValid;

	private static int HeightDelta_Offset;

	private static bool AlphaRate_IsValid;

	private static int AlphaRate_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("隐藏触发距离")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:InRange")]
	public float InRange
	{
		get
		{
			CheckDestroyed();
			if (!InRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:InRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:InRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InRange_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("显现触发距离")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:OutRange")]
	public float OutRange
	{
		get
		{
			CheckDestroyed();
			if (!OutRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:OutRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:OutRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutRange_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发角度")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:TriggerAngle")]
	public float TriggerAngle
	{
		get
		{
			CheckDestroyed();
			if (!TriggerAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:TriggerAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:TriggerAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerAngle_Offset), value);
			}
		}
	}

	[DisplayName("触发高度差")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:HeightDelta")]
	public float HeightDelta
	{
		get
		{
			CheckDestroyed();
			if (!HeightDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:HeightDelta");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeightDelta_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:HeightDelta");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeightDelta_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("消失速度")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:AlphaRate")]
	public float AlphaRate
	{
		get
		{
			CheckDestroyed();
			if (!AlphaRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:AlphaRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AlphaRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlphaRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset:AlphaRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AlphaRate_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibCameraBlockDataAsset");
		InRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InRange");
		InRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InRange", Classes.FFloatProperty);
		OutRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OutRange");
		OutRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OutRange", Classes.FFloatProperty);
		TriggerAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerAngle");
		TriggerAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerAngle", Classes.FFloatProperty);
		HeightDelta_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeightDelta");
		HeightDelta_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeightDelta", Classes.FFloatProperty);
		AlphaRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AlphaRate");
		AlphaRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AlphaRate", Classes.FFloatProperty);
	}

	static BGW_DispLibCameraBlockDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibCameraBlockDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibCameraBlockDataAsset));
	}
}
