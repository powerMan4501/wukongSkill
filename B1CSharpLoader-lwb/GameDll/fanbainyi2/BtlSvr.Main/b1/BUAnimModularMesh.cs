using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimModularMesh")]
internal class BUAnimModularMesh : UAnimInstance
{
	private static bool LoopAnimation_IsValid;

	private static int LoopAnimation_Offset;

	private static bool bStopCopyPose_IsValid;

	private static int bStopCopyPose_Offset;

	private static FFieldAddress bStopCopyPose_PropertyAddress;

	private static bool MappedSpeed_IsValid;

	private static int MappedSpeed_Offset;

	private static bool FakeInertia_IsValid;

	private static int FakeInertia_Offset;

	private static bool SpeedToInertiaScale_IsValid;

	private static int SpeedToInertiaScale_Offset;

	private static bool MinInertiaFactor_IsValid;

	private static int MinInertiaFactor_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_IsValid;

	private static IntPtr BlueprintThreadSafeUpdateAnimation_FunctionAddress;

	private static int BlueprintThreadSafeUpdateAnimation_ParamsSize;

	private static bool BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid;

	private static int BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:LoopAnimation")]
	public UAnimSequence LoopAnimation
	{
		get
		{
			CheckDestroyed();
			if (!LoopAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:LoopAnimation");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, LoopAnimation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:LoopAnimation");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, LoopAnimation_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:bStopCopyPose")]
	public bool bStopCopyPose
	{
		get
		{
			CheckDestroyed();
			if (!bStopCopyPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:bStopCopyPose");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopCopyPose_Offset), 0, bStopCopyPose_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopCopyPose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:bStopCopyPose");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopCopyPose_Offset), 0, bStopCopyPose_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:MappedSpeed")]
	public float MappedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:MappedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MappedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:MappedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MappedSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:FakeInertia")]
	public FVector FakeInertia
	{
		get
		{
			CheckDestroyed();
			if (!FakeInertia_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:FakeInertia");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, FakeInertia_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FakeInertia_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:FakeInertia");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, FakeInertia_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("CloudPhysics")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:SpeedToInertiaScale")]
	public float SpeedToInertiaScale
	{
		get
		{
			CheckDestroyed();
			if (!SpeedToInertiaScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:SpeedToInertiaScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedToInertiaScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedToInertiaScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:SpeedToInertiaScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedToInertiaScale_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[Category("CloudPhysics")]
	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:MinInertiaFactor")]
	public float MinInertiaFactor
	{
		get
		{
			CheckDestroyed();
			if (!MinInertiaFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:MinInertiaFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinInertiaFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinInertiaFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimModularMesh:MinInertiaFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinInertiaFactor_Offset), value);
			}
		}
	}

	private IBUC_ABPBasicData BasicData { get; set; }

	private IBUC_CloudMoveData CloudMoveData { get; set; }

	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		base.BlueprintInitializeAnimation_Implementation();
		base.SkipBlueprintUpdateAnimation = 1;
	}

	[USharpPath("/Script/b1-Managed.BUAnimModularMesh:BlueprintThreadSafeUpdateAnimation")]
	protected override void BlueprintThreadSafeUpdateAnimation_Implementation(float DeltaTime)
	{
		base.BlueprintThreadSafeUpdateAnimation_Implementation(DeltaTime);
		if (BasicData == null)
		{
			BasicData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(GetOwningActor());
		}
		if (BasicData != null)
		{
			MappedSpeed = BasicData.GetMappedSpeed();
		}
		if (CloudMoveData == null)
		{
			CloudMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(GetOwningActor());
		}
		float num = 0f;
		if (CloudMoveData != null)
		{
			num = (CloudMoveData.IsCloudMoveEnabled ? 1 : 0);
		}
		FVector velocity = GetOwningActor().GetVelocity();
		FakeInertia = -velocity * num * SpeedToInertiaScale * MathLib.RandomFloatInRange(MinInertiaFactor, 1f);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimModularMesh:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimModularMesh bUAnimModularMesh = GCHelper.Find<b1.BUAnimModularMesh>(obj);
		bUAnimModularMesh.BlueprintInitializeAnimation_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimModularMesh:BlueprintThreadSafeUpdateAnimation")]
	private static void BlueprintThreadSafeUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimModularMesh bUAnimModularMesh = GCHelper.Find<b1.BUAnimModularMesh>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset));
		bUAnimModularMesh.BlueprintThreadSafeUpdateAnimation_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimModularMesh");
		LoopAnimation_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopAnimation");
		LoopAnimation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopAnimation", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bStopCopyPose_PropertyAddress, intPtr, "bStopCopyPose");
		bStopCopyPose_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStopCopyPose");
		bStopCopyPose_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStopCopyPose", Classes.FBoolProperty);
		MappedSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "MappedSpeed");
		MappedSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MappedSpeed", Classes.FFloatProperty);
		FakeInertia_Offset = NativeReflection.GetPropertyOffset(intPtr, "FakeInertia");
		FakeInertia_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FakeInertia", Classes.FStructProperty);
		SpeedToInertiaScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedToInertiaScale");
		SpeedToInertiaScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedToInertiaScale", Classes.FFloatProperty);
		MinInertiaFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinInertiaFactor");
		MinInertiaFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinInertiaFactor", Classes.FFloatProperty);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimModularMesh:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
		BlueprintThreadSafeUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintThreadSafeUpdateAnimation");
		BlueprintThreadSafeUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintThreadSafeUpdateAnimation_FunctionAddress);
		BlueprintThreadSafeUpdateAnimation_DeltaTime_Offset = NativeReflection.GetPropertyOffset(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTime");
		BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(BlueprintThreadSafeUpdateAnimation_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		BlueprintThreadSafeUpdateAnimation_IsValid = BlueprintThreadSafeUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintThreadSafeUpdateAnimation_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimModularMesh:BlueprintThreadSafeUpdateAnimation", BlueprintThreadSafeUpdateAnimation_IsValid);
	}

	static BUAnimModularMesh()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUAnimModularMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUAnimModularMesh));
	}
}
