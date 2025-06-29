using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent")]
public class BUS_SpringArmComponent : UBGUSpringArmComponent
{
	private static bool IsXSmoothFixed_IsValid;

	private static int IsXSmoothFixed_Offset;

	private static FFieldAddress IsXSmoothFixed_PropertyAddress;

	private static bool IsYSmoothFixed_IsValid;

	private static int IsYSmoothFixed_Offset;

	private static FFieldAddress IsYSmoothFixed_PropertyAddress;

	private static bool IsZSmoothFixed_IsValid;

	private static int IsZSmoothFixed_Offset;

	private static FFieldAddress IsZSmoothFixed_PropertyAddress;

	private static bool DefaultCameraLagSpeed_IsValid;

	private static int DefaultCameraLagSpeed_Offset;

	private static bool BlendLocationsInCS_IsValid;

	private static IntPtr BlendLocationsInCS_FunctionAddress;

	private static int BlendLocationsInCS_ParamsSize;

	private static bool BlendLocationsInCS_OriginArmLocation_IsValid;

	private static int BlendLocationsInCS_OriginArmLocation_Offset;

	private static FFieldAddress BlendLocationsInCS_OriginArmLocation_PropertyAddress;

	private static bool BlendLocationsInCS_DesiredArmLocation_IsValid;

	private static int BlendLocationsInCS_DesiredArmLocation_Offset;

	private static FFieldAddress BlendLocationsInCS_DesiredArmLocation_PropertyAddress;

	private static bool BlendLocationsInCS_HitResult_IsValid;

	private static int BlendLocationsInCS_HitResult_Offset;

	private static FFieldAddress BlendLocationsInCS_HitResult_PropertyAddress;

	private static bool BlendLocationsInCS_DeltaTime_IsValid;

	private static int BlendLocationsInCS_DeltaTime_Offset;

	private static bool BlendLocationsInCS_ReturnValue_IsValid;

	private static int BlendLocationsInCS_ReturnValue_Offset;

	private static FFieldAddress BlendLocationsInCS_ReturnValue_PropertyAddress;

	private static bool CalcSmoothLocation_IsValid;

	private static IntPtr CalcSmoothLocation_FunctionAddress;

	private static int CalcSmoothLocation_ParamsSize;

	private static bool CalcSmoothLocation_Current_IsValid;

	private static int CalcSmoothLocation_Current_Offset;

	private static FFieldAddress CalcSmoothLocation_Current_PropertyAddress;

	private static bool CalcSmoothLocation_Target_IsValid;

	private static int CalcSmoothLocation_Target_Offset;

	private static FFieldAddress CalcSmoothLocation_Target_PropertyAddress;

	private static bool CalcSmoothLocation_DeltaTime_IsValid;

	private static int CalcSmoothLocation_DeltaTime_Offset;

	private static bool CalcSmoothLocation_SmoothSpeed_IsValid;

	private static int CalcSmoothLocation_SmoothSpeed_Offset;

	private static FFieldAddress CalcSmoothLocation_SmoothSpeed_PropertyAddress;

	private static bool CalcSmoothLocation_ReturnValue_IsValid;

	private static int CalcSmoothLocation_ReturnValue_Offset;

	private static FFieldAddress CalcSmoothLocation_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[Category("CameraSettings")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent:IsXSmoothFixed")]
	public bool IsXSmoothFixed
	{
		get
		{
			CheckDestroyed();
			if (!IsXSmoothFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:IsXSmoothFixed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsXSmoothFixed_Offset), 0, IsXSmoothFixed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsXSmoothFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:IsXSmoothFixed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsXSmoothFixed_Offset), 0, IsXSmoothFixed_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("CameraSettings")]
	[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent:IsYSmoothFixed")]
	public bool IsYSmoothFixed
	{
		get
		{
			CheckDestroyed();
			if (!IsYSmoothFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:IsYSmoothFixed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsYSmoothFixed_Offset), 0, IsYSmoothFixed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsYSmoothFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:IsYSmoothFixed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsYSmoothFixed_Offset), 0, IsYSmoothFixed_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("CameraSettings")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent:IsZSmoothFixed")]
	public bool IsZSmoothFixed
	{
		get
		{
			CheckDestroyed();
			if (!IsZSmoothFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:IsZSmoothFixed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsZSmoothFixed_Offset), 0, IsZSmoothFixed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsZSmoothFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:IsZSmoothFixed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsZSmoothFixed_Offset), 0, IsZSmoothFixed_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("CameraSettings")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent:DefaultCameraLagSpeed")]
	public float DefaultCameraLagSpeed
	{
		get
		{
			CheckDestroyed();
			if (!DefaultCameraLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:DefaultCameraLagSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultCameraLagSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultCameraLagSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpringArmComponent:DefaultCameraLagSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultCameraLagSpeed_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent:BlendLocationsInCS")]
	protected override FVector BlendLocationsInCS_Implementation(FVector OriginArmLocation, FVector DesiredArmLocation, FHitResult HitResult, float DeltaTime)
	{
		UGameplayStatics.BreakHitResult(HitResult, out var bBlockingHit, out var _, out var _, out var _, out var Location, out var ImpactPoint, out var _, out var _, out var _, out var _, out var _, out var _, out var _, out var _, out var _, out var _, out var _, out var _);
		if (bBlockingHit)
		{
			FVector fVector = DesiredArmLocation - OriginArmLocation;
			FVector b = ImpactPoint - OriginArmLocation;
			float num = fVector.CosineAngle2D(b);
			FVector fVector2 = Location - DesiredArmLocation;
			return DesiredArmLocation + fVector2 * num;
		}
		return DesiredArmLocation;
	}

	[USharpPath("/Script/b1-Managed.BUS_SpringArmComponent:CalcSmoothLocation")]
	protected override FVector CalcSmoothLocation_Implementation(FVector Current, FVector Target, float DeltaTime, FVector SmoothSpeed)
	{
		FVector result = Target;
		result.X = FMath.FInterpTo(Current.X, Target.X, DeltaTime, IsXSmoothFixed ? DefaultCameraLagSpeed : SmoothSpeed.X);
		result.Y = FMath.FInterpTo(Current.Y, Target.Y, DeltaTime, IsYSmoothFixed ? DefaultCameraLagSpeed : SmoothSpeed.Y);
		result.Z = FMath.FInterpTo(Current.Z, Target.Z, DeltaTime, IsZSmoothFixed ? DefaultCameraLagSpeed : SmoothSpeed.Z);
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SpringArmComponent:BlendLocationsInCS")]
	private static void BlendLocationsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SpringArmComponent bUS_SpringArmComponent = GCHelper.Find<BUS_SpringArmComponent>(obj);
		FVector originArmLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BlendLocationsInCS_OriginArmLocation_Offset));
		FVector desiredArmLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BlendLocationsInCS_DesiredArmLocation_Offset));
		FHitResult hitResult = FHitResult.FromNative(IntPtr.Add(buffer, BlendLocationsInCS_HitResult_Offset));
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlendLocationsInCS_DeltaTime_Offset));
		FVector value = bUS_SpringArmComponent.BlendLocationsInCS_Implementation(originArmLocation, desiredArmLocation, hitResult, deltaTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, BlendLocationsInCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SpringArmComponent:CalcSmoothLocation")]
	private static void CalcSmoothLocation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SpringArmComponent bUS_SpringArmComponent = GCHelper.Find<BUS_SpringArmComponent>(obj);
		FVector current = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, CalcSmoothLocation_Current_Offset));
		FVector target = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, CalcSmoothLocation_Target_Offset));
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CalcSmoothLocation_DeltaTime_Offset));
		FVector smoothSpeed = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, CalcSmoothLocation_SmoothSpeed_Offset));
		FVector value = bUS_SpringArmComponent.CalcSmoothLocation_Implementation(current, target, deltaTime, smoothSpeed);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, CalcSmoothLocation_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpringArmComponent");
		NativeReflection.GetPropertyRef(ref IsXSmoothFixed_PropertyAddress, intPtr, "IsXSmoothFixed");
		IsXSmoothFixed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsXSmoothFixed");
		IsXSmoothFixed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsXSmoothFixed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsYSmoothFixed_PropertyAddress, intPtr, "IsYSmoothFixed");
		IsYSmoothFixed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsYSmoothFixed");
		IsYSmoothFixed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsYSmoothFixed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsZSmoothFixed_PropertyAddress, intPtr, "IsZSmoothFixed");
		IsZSmoothFixed_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsZSmoothFixed");
		IsZSmoothFixed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsZSmoothFixed", Classes.FBoolProperty);
		DefaultCameraLagSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultCameraLagSpeed");
		DefaultCameraLagSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultCameraLagSpeed", Classes.FFloatProperty);
		BlendLocationsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlendLocationsInCS");
		BlendLocationsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BlendLocationsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BlendLocationsInCS_OriginArmLocation_PropertyAddress, BlendLocationsInCS_FunctionAddress, "OriginArmLocation");
		BlendLocationsInCS_OriginArmLocation_Offset = NativeReflection.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "OriginArmLocation");
		BlendLocationsInCS_OriginArmLocation_IsValid = NativeReflection.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "OriginArmLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BlendLocationsInCS_DesiredArmLocation_PropertyAddress, BlendLocationsInCS_FunctionAddress, "DesiredArmLocation");
		BlendLocationsInCS_DesiredArmLocation_Offset = NativeReflection.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "DesiredArmLocation");
		BlendLocationsInCS_DesiredArmLocation_IsValid = NativeReflection.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "DesiredArmLocation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BlendLocationsInCS_HitResult_PropertyAddress, BlendLocationsInCS_FunctionAddress, "HitResult");
		BlendLocationsInCS_HitResult_Offset = NativeReflection.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "HitResult");
		BlendLocationsInCS_HitResult_IsValid = NativeReflection.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "HitResult", Classes.FStructProperty);
		BlendLocationsInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "DeltaTime");
		BlendLocationsInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendLocationsInCS_ReturnValue_PropertyAddress, BlendLocationsInCS_FunctionAddress, "ReturnValue");
		BlendLocationsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BlendLocationsInCS_FunctionAddress, "ReturnValue");
		BlendLocationsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BlendLocationsInCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BlendLocationsInCS_IsValid = BlendLocationsInCS_FunctionAddress != IntPtr.Zero && BlendLocationsInCS_OriginArmLocation_IsValid && BlendLocationsInCS_DesiredArmLocation_IsValid && BlendLocationsInCS_HitResult_IsValid && BlendLocationsInCS_DeltaTime_IsValid && BlendLocationsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SpringArmComponent:BlendLocationsInCS", BlendLocationsInCS_IsValid);
		CalcSmoothLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CalcSmoothLocation");
		CalcSmoothLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcSmoothLocation_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CalcSmoothLocation_Current_PropertyAddress, CalcSmoothLocation_FunctionAddress, "Current");
		CalcSmoothLocation_Current_Offset = NativeReflection.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "Current");
		CalcSmoothLocation_Current_IsValid = NativeReflection.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "Current", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalcSmoothLocation_Target_PropertyAddress, CalcSmoothLocation_FunctionAddress, "Target");
		CalcSmoothLocation_Target_Offset = NativeReflection.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "Target");
		CalcSmoothLocation_Target_IsValid = NativeReflection.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "Target", Classes.FStructProperty);
		CalcSmoothLocation_DeltaTime_Offset = NativeReflection.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "DeltaTime");
		CalcSmoothLocation_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CalcSmoothLocation_SmoothSpeed_PropertyAddress, CalcSmoothLocation_FunctionAddress, "SmoothSpeed");
		CalcSmoothLocation_SmoothSpeed_Offset = NativeReflection.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "SmoothSpeed");
		CalcSmoothLocation_SmoothSpeed_IsValid = NativeReflection.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "SmoothSpeed", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalcSmoothLocation_ReturnValue_PropertyAddress, CalcSmoothLocation_FunctionAddress, "ReturnValue");
		CalcSmoothLocation_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CalcSmoothLocation_FunctionAddress, "ReturnValue");
		CalcSmoothLocation_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CalcSmoothLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CalcSmoothLocation_IsValid = CalcSmoothLocation_FunctionAddress != IntPtr.Zero && CalcSmoothLocation_Current_IsValid && CalcSmoothLocation_Target_IsValid && CalcSmoothLocation_DeltaTime_IsValid && CalcSmoothLocation_SmoothSpeed_IsValid && CalcSmoothLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SpringArmComponent:CalcSmoothLocation", CalcSmoothLocation_IsValid);
	}

	static BUS_SpringArmComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpringArmComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpringArmComponent));
	}
}
