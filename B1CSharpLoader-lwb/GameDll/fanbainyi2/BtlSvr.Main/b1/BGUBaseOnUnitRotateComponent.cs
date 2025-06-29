using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[ClassGroup("Camera")]
[UClass]
[USharpPath("/Script/b1-Managed.BGUBaseOnUnitRotateComponent")]
public class BGUBaseOnUnitRotateComponent : USceneComponentTickable
{
	private static bool BaseOnUnitRotation_IsValid;

	private static int BaseOnUnitRotation_Offset;

	private static bool OffsetLocation_IsValid;

	private static int OffsetLocation_Offset;

	private static bool BGUSetBaseOnUnitRotation_IsValid;

	private static IntPtr BGUSetBaseOnUnitRotation_FunctionAddress;

	private static int BGUSetBaseOnUnitRotation_ParamsSize;

	private static bool BGUSetBaseOnUnitRotation_BaseUnit_IsValid;

	private static int BGUSetBaseOnUnitRotation_BaseUnit_Offset;

	private static bool BGUSetBaseOnUnitRotation_TargteRotation_IsValid;

	private static int BGUSetBaseOnUnitRotation_TargteRotation_Offset;

	private static FFieldAddress BGUSetBaseOnUnitRotation_TargteRotation_PropertyAddress;

	private static bool BGUSetBaseOnUnitRotation_OffsetVector_IsValid;

	private static int BGUSetBaseOnUnitRotation_OffsetVector_Offset;

	private static FFieldAddress BGUSetBaseOnUnitRotation_OffsetVector_PropertyAddress;

	private static bool BeginPlayGS_IsValid;

	private static IntPtr BeginPlayGS_FunctionAddress;

	private static int BeginPlayGS_ParamsSize;

	private static bool TickComponentGS_IsValid;

	private static IntPtr TickComponentGS_FunctionAddress;

	private static int TickComponentGS_ParamsSize;

	private static bool TickComponentGS_DeltaSeconds_IsValid;

	private static int TickComponentGS_DeltaSeconds_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BaseOnUnitRotation")]
	public FRotator BaseOnUnitRotation
	{
		get
		{
			CheckDestroyed();
			if (!BaseOnUnitRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BaseOnUnitRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, BaseOnUnitRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseOnUnitRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BaseOnUnitRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, BaseOnUnitRotation_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:OffsetLocation")]
	public FVector OffsetLocation
	{
		get
		{
			CheckDestroyed();
			if (!OffsetLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:OffsetLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, OffsetLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:OffsetLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, OffsetLocation_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BeginPlayGS")]
	protected override void BeginPlayGS_Implementation()
	{
		BaseOnUnitRotation = FRotator.ZeroRotator;
		OffsetLocation = FVector.ZeroVector;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BGUSetBaseOnUnitRotation")]
	public void BGUSetBaseOnUnitRotation(AActor BaseUnit, FRotator TargteRotation, FVector OffsetVector)
	{
		if (!(BaseOnUnitRotation == TargteRotation))
		{
			OffsetLocation = OffsetVector;
			FVector worldLocation = GetAttachParent().GetWorldLocation();
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(BaseUnit);
			FVector other = worldLocation - fVector;
			float num = other.Size();
			other.Normalize();
			FVector fVector2 = other.RotateAngleAxis(TargteRotation.Pitch, FVector.RightVector).RotateAngleAxis(TargteRotation.Roll, FVector.ForwardVector).RotateAngleAxis(TargteRotation.Yaw, FVector.UpVector);
			fVector2.Normalize();
			if (fVector2.Equals(other))
			{
				SetRelativeLocation(OffsetLocation, bSweep: false, out var _, bTeleport: false);
			}
			else
			{
				FVector location = fVector + fVector2 * num;
				FVector fVector3 = GetAttachParent().GetWorldTransform().InverseTransformLocation(location) + OffsetLocation;
				FVector start = GetAttachParent().GetWorldTransform().TransformLocation(fVector3);
				FRotator rotation = MathLib.FindLookAtRotation(start, fVector);
				FRotator newRotation = GetAttachParent().GetWorldTransform().InverseTransformRotation(rotation);
				SetRelativeLocationAndRotation(fVector3, newRotation, bSweep: false, out var _, bTeleport: false);
			}
			BaseOnUnitRotation = TargteRotation;
		}
	}

	[USharpPath("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:TickComponentGS")]
	protected override void TickComponentGS_Implementation(float DeltaSeconds)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BGUSetBaseOnUnitRotation")]
	private static void BGUSetBaseOnUnitRotation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBaseOnUnitRotateComponent bGUBaseOnUnitRotateComponent = GCHelper.Find<BGUBaseOnUnitRotateComponent>(obj);
		AActor baseUnit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetBaseOnUnitRotation_BaseUnit_Offset));
		FRotator targteRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(buffer, BGUSetBaseOnUnitRotation_TargteRotation_Offset));
		FVector offsetVector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUSetBaseOnUnitRotation_OffsetVector_Offset));
		bGUBaseOnUnitRotateComponent.BGUSetBaseOnUnitRotation(baseUnit, targteRotation, offsetVector);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BeginPlayGS")]
	private static void BeginPlayGS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBaseOnUnitRotateComponent bGUBaseOnUnitRotateComponent = GCHelper.Find<BGUBaseOnUnitRotateComponent>(obj);
		bGUBaseOnUnitRotateComponent.BeginPlayGS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:TickComponentGS")]
	private static void TickComponentGS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBaseOnUnitRotateComponent bGUBaseOnUnitRotateComponent = GCHelper.Find<BGUBaseOnUnitRotateComponent>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentGS_DeltaSeconds_Offset));
		bGUBaseOnUnitRotateComponent.TickComponentGS_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUBaseOnUnitRotateComponent");
		BaseOnUnitRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseOnUnitRotation");
		BaseOnUnitRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseOnUnitRotation", Classes.FStructProperty);
		OffsetLocation_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetLocation");
		OffsetLocation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetLocation", Classes.FStructProperty);
		BGUSetBaseOnUnitRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BGUSetBaseOnUnitRotation");
		BGUSetBaseOnUnitRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetBaseOnUnitRotation_FunctionAddress);
		BGUSetBaseOnUnitRotation_BaseUnit_Offset = NativeReflection.GetPropertyOffset(BGUSetBaseOnUnitRotation_FunctionAddress, "BaseUnit");
		BGUSetBaseOnUnitRotation_BaseUnit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetBaseOnUnitRotation_FunctionAddress, "BaseUnit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetBaseOnUnitRotation_TargteRotation_PropertyAddress, BGUSetBaseOnUnitRotation_FunctionAddress, "TargteRotation");
		BGUSetBaseOnUnitRotation_TargteRotation_Offset = NativeReflection.GetPropertyOffset(BGUSetBaseOnUnitRotation_FunctionAddress, "TargteRotation");
		BGUSetBaseOnUnitRotation_TargteRotation_IsValid = NativeReflection.ValidatePropertyClass(BGUSetBaseOnUnitRotation_FunctionAddress, "TargteRotation", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGUSetBaseOnUnitRotation_OffsetVector_PropertyAddress, BGUSetBaseOnUnitRotation_FunctionAddress, "OffsetVector");
		BGUSetBaseOnUnitRotation_OffsetVector_Offset = NativeReflection.GetPropertyOffset(BGUSetBaseOnUnitRotation_FunctionAddress, "OffsetVector");
		BGUSetBaseOnUnitRotation_OffsetVector_IsValid = NativeReflection.ValidatePropertyClass(BGUSetBaseOnUnitRotation_FunctionAddress, "OffsetVector", Classes.FStructProperty);
		BGUSetBaseOnUnitRotation_IsValid = BGUSetBaseOnUnitRotation_FunctionAddress != IntPtr.Zero && BGUSetBaseOnUnitRotation_BaseUnit_IsValid && BGUSetBaseOnUnitRotation_TargteRotation_IsValid && BGUSetBaseOnUnitRotation_OffsetVector_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BGUSetBaseOnUnitRotation", BGUSetBaseOnUnitRotation_IsValid);
		BeginPlayGS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayGS");
		BeginPlayGS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayGS_FunctionAddress);
		BeginPlayGS_IsValid = BeginPlayGS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:BeginPlayGS", BeginPlayGS_IsValid);
		TickComponentGS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentGS");
		TickComponentGS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentGS_FunctionAddress);
		TickComponentGS_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(TickComponentGS_FunctionAddress, "DeltaSeconds");
		TickComponentGS_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(TickComponentGS_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		TickComponentGS_IsValid = TickComponentGS_FunctionAddress != IntPtr.Zero && TickComponentGS_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBaseOnUnitRotateComponent:TickComponentGS", TickComponentGS_IsValid);
	}

	static BGUBaseOnUnitRotateComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBaseOnUnitRotateComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBaseOnUnitRotateComponent));
	}
}
