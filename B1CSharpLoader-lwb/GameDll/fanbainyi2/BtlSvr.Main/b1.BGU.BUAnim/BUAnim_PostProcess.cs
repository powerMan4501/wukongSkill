using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUAnim;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnim_PostProcess")]
internal class BUAnim_PostProcess : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	private static bool AttackOffset_Alpha_IsValid;

	private static int AttackOffset_Alpha_Offset;

	private static bool AttackOffset_AttackOffsetType_IsValid;

	private static int AttackOffset_AttackOffsetType_Offset;

	private static FFieldAddress AttackOffset_AttackOffsetType_PropertyAddress;

	private static bool AttackOffset_WorldRotOffset_IsValid;

	private static int AttackOffset_WorldRotOffset_Offset;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[Category("AttackOffset")]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_Alpha")]
	public float AttackOffset_Alpha
	{
		get
		{
			CheckDestroyed();
			if (!AttackOffset_Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_Alpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackOffset_Alpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackOffset_Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_Alpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackOffset_Alpha_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Category("AttackOffset")]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_AttackOffsetType")]
	public EAttackOffsetType AttackOffset_AttackOffsetType
	{
		get
		{
			CheckDestroyed();
			if (!AttackOffset_AttackOffsetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_AttackOffsetType");
				return EAttackOffsetType.AttackOffset_None;
			}
			return EnumMarshaler<EAttackOffsetType>.FromNative(IntPtr.Add(base.Address, AttackOffset_AttackOffsetType_Offset), 0, AttackOffset_AttackOffsetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttackOffset_AttackOffsetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_AttackOffsetType");
			}
			else
			{
				EnumMarshaler<EAttackOffsetType>.ToNative(IntPtr.Add(base.Address, AttackOffset_AttackOffsetType_Offset), 0, AttackOffset_AttackOffsetType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AttackOffset")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_WorldRotOffset")]
	public FQuat AttackOffset_WorldRotOffset
	{
		get
		{
			CheckDestroyed();
			if (!AttackOffset_WorldRotOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_WorldRotOffset");
				return default(FQuat);
			}
			return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(base.Address, AttackOffset_WorldRotOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackOffset_WorldRotOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnim_PostProcess:AttackOffset_WorldRotOffset");
			}
			else
			{
				BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(base.Address, AttackOffset_WorldRotOffset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		base.BlueprintInitializeAnimation_Implementation();
	}

	public void InitData()
	{
	}

	[USharpPath("/Script/b1-Managed.BUAnim_PostProcess:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		base.BlueprintUpdateAnimation_Implementation(DeltaTimeX);
		AActor owningActor = GetOwningActor();
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owningActor))
		{
			IBUC_ABPAttackOffsetData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPAttackOffsetData, BUC_ABPAttackOffsetData>(owningActor);
			if (unPersistentReadOnlyData != null)
			{
				AttackOffset_Alpha = unPersistentReadOnlyData.Alpha;
				AttackOffset_AttackOffsetType = unPersistentReadOnlyData.AttackOffset_AttackOffsetType;
				AttackOffset_WorldRotOffset = unPersistentReadOnlyData.AttackOffset_WorldRotOffset;
			}
		}
	}

	public void OnEntityInitFinish()
	{
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnim_PostProcess:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnim_PostProcess bUAnim_PostProcess = GCHelper.Find<b1.BGU.BUAnim.BUAnim_PostProcess>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnim_PostProcess.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnim_PostProcess:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGU.BUAnim.BUAnim_PostProcess bUAnim_PostProcess = GCHelper.Find<b1.BGU.BUAnim.BUAnim_PostProcess>(obj);
		bUAnim_PostProcess.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnim_PostProcess");
		AttackOffset_Alpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackOffset_Alpha");
		AttackOffset_Alpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackOffset_Alpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AttackOffset_AttackOffsetType_PropertyAddress, intPtr, "AttackOffset_AttackOffsetType");
		AttackOffset_AttackOffsetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackOffset_AttackOffsetType");
		AttackOffset_AttackOffsetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackOffset_AttackOffsetType", Classes.FEnumProperty);
		AttackOffset_WorldRotOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackOffset_WorldRotOffset");
		AttackOffset_WorldRotOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackOffset_WorldRotOffset", Classes.FStructProperty);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnim_PostProcess:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnim_PostProcess:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnim_PostProcess()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.BUAnim.BUAnim_PostProcess)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.BUAnim.BUAnim_PostProcess));
	}
}
