using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimWheel")]
internal class BUAnimWheel : BUAnimInstanceBase
{
	private static bool ASIdle_IsValid;

	private static int ASIdle_Offset;

	private static bool ASSpeedUp_IsValid;

	private static int ASSpeedUp_Offset;

	private static bool ASSpeedDown_IsValid;

	private static int ASSpeedDown_Offset;

	private static bool ASMoveLoop_IsValid;

	private static int ASMoveLoop_Offset;

	private static bool MovePlayRate_IsValid;

	private static int MovePlayRate_Offset;

	private static bool BSRotationAdditive_IsValid;

	private static int BSRotationAdditive_Offset;

	private static bool BSRotationAdditiveX_IsValid;

	private static int BSRotationAdditiveX_Offset;

	private static bool bIdleToSpeedUp_IsValid;

	private static int bIdleToSpeedUp_Offset;

	private static FFieldAddress bIdleToSpeedUp_PropertyAddress;

	private static bool bLoopToIdle_IsValid;

	private static int bLoopToIdle_Offset;

	private static FFieldAddress bLoopToIdle_PropertyAddress;

	private static bool bIdleToLoop_IsValid;

	private static int bIdleToLoop_Offset;

	private static FFieldAddress bIdleToLoop_PropertyAddress;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	[Category("Wheel Move")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:ASIdle")]
	public UAnimSequence ASIdle
	{
		get
		{
			CheckDestroyed();
			if (!ASIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASIdle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Wheel Move")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:ASSpeedUp")]
	public UAnimSequence ASSpeedUp
	{
		get
		{
			CheckDestroyed();
			if (!ASSpeedUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASSpeedUp");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSpeedUp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSpeedUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASSpeedUp");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSpeedUp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Wheel Move")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:ASSpeedDown")]
	public UAnimSequence ASSpeedDown
	{
		get
		{
			CheckDestroyed();
			if (!ASSpeedDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASSpeedDown");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASSpeedDown_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASSpeedDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASSpeedDown");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASSpeedDown_Offset), value);
			}
		}
	}

	[Category("Wheel Move")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:ASMoveLoop")]
	public UAnimSequence ASMoveLoop
	{
		get
		{
			CheckDestroyed();
			if (!ASMoveLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASMoveLoop");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, ASMoveLoop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ASMoveLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:ASMoveLoop");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, ASMoveLoop_Offset), value);
			}
		}
	}

	[Category("Wheel Move")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:MovePlayRate")]
	public float MovePlayRate
	{
		get
		{
			CheckDestroyed();
			if (!MovePlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:MovePlayRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MovePlayRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovePlayRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:MovePlayRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MovePlayRate_Offset), value);
			}
		}
	}

	[Category("Wheel Move")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:BSRotationAdditive")]
	public UBlendSpace BSRotationAdditive
	{
		get
		{
			CheckDestroyed();
			if (!BSRotationAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:BSRotationAdditive");
				return null;
			}
			return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(base.Address, BSRotationAdditive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRotationAdditive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:BSRotationAdditive");
			}
			else
			{
				UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(base.Address, BSRotationAdditive_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[Category("Wheel Move")]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:BSRotationAdditiveX")]
	public float BSRotationAdditiveX
	{
		get
		{
			CheckDestroyed();
			if (!BSRotationAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:BSRotationAdditiveX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BSRotationAdditiveX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BSRotationAdditiveX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:BSRotationAdditiveX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BSRotationAdditiveX_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:bIdleToSpeedUp")]
	public bool bIdleToSpeedUp
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToSpeedUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:bIdleToSpeedUp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToSpeedUp_Offset), 0, bIdleToSpeedUp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToSpeedUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:bIdleToSpeedUp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToSpeedUp_Offset), 0, bIdleToSpeedUp_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[Category("Trans")]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:bLoopToIdle")]
	public bool bLoopToIdle
	{
		get
		{
			CheckDestroyed();
			if (!bLoopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:bLoopToIdle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoopToIdle_Offset), 0, bLoopToIdle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoopToIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:bLoopToIdle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoopToIdle_Offset), 0, bLoopToIdle_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[Category("Trans")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimWheel:bIdleToLoop")]
	public bool bIdleToLoop
	{
		get
		{
			CheckDestroyed();
			if (!bIdleToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:bIdleToLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIdleToLoop_Offset), 0, bIdleToLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIdleToLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimWheel:bIdleToLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIdleToLoop_Offset), 0, bIdleToLoop_PropertyAddress.Address, value);
			}
		}
	}

	protected override void BlueprintInitializeAnimationImpl()
	{
		base.BlueprintInitializeAnimationImpl();
		if (base.ABPSettingData != null)
		{
			ASIdle = base.ABPSettingData.WheelMoveSetting.ASIdle;
		}
	}

	protected override void OnInitABPSetting()
	{
		base.OnInitABPSetting();
		if (base.ABPSettingData != null)
		{
			ASIdle = base.ABPSettingData.WheelMoveSetting.ASIdle;
			ASSpeedUp = base.ABPSettingData.WheelMoveSetting.ASSpeedUp;
			ASSpeedDown = base.ABPSettingData.WheelMoveSetting.ASSpeedDown;
			ASMoveLoop = base.ABPSettingData.WheelMoveSetting.ASMoveLoop;
			BSRotationAdditive = base.ABPSettingData.WheelMoveSetting.BSRotationAdditive;
			InitData();
		}
	}

	public void InitData()
	{
	}

	[USharpPath("/Script/b1-Managed.BUAnimWheel:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		AActor owningActor = GetOwningActor();
		b1.IBUC_ABPWheelMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_ABPWheelMoveData, BUC_ABPWheelMoveData>(owningActor);
		IBUC_ABPBasicData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(owningActor);
		if (unPersistentReadOnlyData != null)
		{
			MovePlayRate = unPersistentReadOnlyData.MovePlayRate;
			BSRotationAdditiveX = unPersistentReadOnlyData.BSRotationAdditiveX;
		}
		if (unPersistentReadOnlyData2 != null)
		{
			bIdleToSpeedUp = unPersistentReadOnlyData2.Speed > 100f;
			bLoopToIdle = unPersistentReadOnlyData2.AccelerationVec.Size() < 0.1f && unPersistentReadOnlyData2.Speed < 100f && !IsAnyMontagePlaying();
			bIdleToLoop = unPersistentReadOnlyData2.Speed > 100f && IsAnyMontagePlaying();
		}
		base.BlueprintUpdateAnimation_Implementation(DeltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimWheel:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnimWheel bUAnimWheel = GCHelper.Find<b1.BGU.BUAnim.BUAnimWheel>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnimWheel.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimWheel");
		ASIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASIdle");
		ASIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASIdle", Classes.FObjectProperty);
		ASSpeedUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSpeedUp");
		ASSpeedUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSpeedUp", Classes.FObjectProperty);
		ASSpeedDown_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSpeedDown");
		ASSpeedDown_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSpeedDown", Classes.FObjectProperty);
		ASMoveLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASMoveLoop");
		ASMoveLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASMoveLoop", Classes.FObjectProperty);
		MovePlayRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MovePlayRate");
		MovePlayRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MovePlayRate", Classes.FFloatProperty);
		BSRotationAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRotationAdditive");
		BSRotationAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRotationAdditive", Classes.FObjectProperty);
		BSRotationAdditiveX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRotationAdditiveX");
		BSRotationAdditiveX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRotationAdditiveX", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bIdleToSpeedUp_PropertyAddress, intPtr, "bIdleToSpeedUp");
		bIdleToSpeedUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIdleToSpeedUp");
		bIdleToSpeedUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIdleToSpeedUp", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bLoopToIdle_PropertyAddress, intPtr, "bLoopToIdle");
		bLoopToIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoopToIdle");
		bLoopToIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoopToIdle", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIdleToLoop_PropertyAddress, intPtr, "bIdleToLoop");
		bIdleToLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIdleToLoop");
		bIdleToLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIdleToLoop", Classes.FBoolProperty);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimWheel:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
	}

	static BUAnimWheel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BUAnimWheel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BUAnimWheel));
	}
}
