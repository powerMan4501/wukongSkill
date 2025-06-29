using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp")]
internal class BUS_FixCameraTriggerConfigComp : UActorEditCompBase
{
	private static bool CanRetriggerCount_IsValid;

	private static int CanRetriggerCount_Offset;

	private static bool TargetCamera_IsValid;

	private static int TargetCamera_Offset;

	private static bool TargetCameraOffset_IsValid;

	private static int TargetCameraOffset_Offset;

	private static bool BlendCameraDuration_IsValid;

	private static int BlendCameraDuration_Offset;

	private static bool BlendFunction_IsValid;

	private static int BlendFunction_Offset;

	private static FFieldAddress BlendFunction_PropertyAddress;

	private static bool BlendExp_IsValid;

	private static int BlendExp_Offset;

	[UProperty]
	[Category("FixCameraTrigger Config")]
	[BlueprintReadWrite]
	[Tooltip("可以反复触发的次数")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:CanRetriggerCount")]
	public int CanRetriggerCount
	{
		get
		{
			CheckDestroyed();
			if (!CanRetriggerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:CanRetriggerCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CanRetriggerCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CanRetriggerCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:CanRetriggerCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CanRetriggerCount_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("FixCameraTrigger Config")]
	[UProperty]
	[Tooltip("目标相机")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:TargetCamera")]
	public ACameraActor TargetCamera
	{
		get
		{
			CheckDestroyed();
			if (!TargetCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:TargetCamera");
				return null;
			}
			return UObjectMarshaler<ACameraActor>.FromNative(IntPtr.Add(base.Address, TargetCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:TargetCamera");
			}
			else
			{
				UObjectMarshaler<ACameraActor>.ToNative(IntPtr.Add(base.Address, TargetCamera_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("FixCameraTrigger Config")]
	[Tooltip("相机位置偏差值")]
	[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:TargetCameraOffset")]
	public FVector TargetCameraOffset
	{
		get
		{
			CheckDestroyed();
			if (!TargetCameraOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:TargetCameraOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, TargetCameraOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetCameraOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:TargetCameraOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, TargetCameraOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("FixCameraTrigger Config")]
	[EditAnywhere]
	[Tooltip("混合时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendCameraDuration")]
	public float BlendCameraDuration
	{
		get
		{
			CheckDestroyed();
			if (!BlendCameraDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendCameraDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendCameraDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendCameraDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendCameraDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendCameraDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("混合方式")]
	[Category("FixCameraTrigger Config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendFunction")]
	public EViewTargetBlendFunction BlendFunction
	{
		get
		{
			CheckDestroyed();
			if (!BlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendFunction");
				return EViewTargetBlendFunction.VTBlend_Linear;
			}
			return EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(base.Address, BlendFunction_Offset), 0, BlendFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendFunction");
			}
			else
			{
				EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(base.Address, BlendFunction_Offset), 0, BlendFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("FixCameraTrigger Config")]
	[USharpPath("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendExp")]
	public float BlendExp
	{
		get
		{
			CheckDestroyed();
			if (!BlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp:BlendExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendExp_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_FixCameraTriggerConfigData bUC_FixCameraTriggerConfigData = RequireWritableData<b1.BUC_FixCameraTriggerConfigData>();
		bUC_FixCameraTriggerConfigData.CanRetriggerCount = CanRetriggerCount;
		bUC_FixCameraTriggerConfigData.TargetCamera = TargetCamera;
		bUC_FixCameraTriggerConfigData.TargetCameraOffset = TargetCameraOffset;
		bUC_FixCameraTriggerConfigData.BlendCameraDuration = BlendCameraDuration;
		bUC_FixCameraTriggerConfigData.BlendFunction = BlendFunction;
		bUC_FixCameraTriggerConfigData.BlendExp = BlendExp;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_FixCameraTriggerConfigComp");
		CanRetriggerCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanRetriggerCount");
		CanRetriggerCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanRetriggerCount", Classes.FIntProperty);
		TargetCamera_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetCamera");
		TargetCamera_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetCamera", Classes.FObjectProperty);
		TargetCameraOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetCameraOffset");
		TargetCameraOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetCameraOffset", Classes.FStructProperty);
		BlendCameraDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendCameraDuration");
		BlendCameraDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendCameraDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendFunction_PropertyAddress, unrealStruct, "BlendFunction");
		BlendFunction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendFunction");
		BlendFunction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendFunction", Classes.FEnumProperty);
		BlendExp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlendExp");
		BlendExp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlendExp", Classes.FFloatProperty);
	}

	static BUS_FixCameraTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_FixCameraTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_FixCameraTriggerConfigComp));
	}
}
