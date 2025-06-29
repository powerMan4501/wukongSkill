using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor")]
public struct BUC_DispLibDBC_SpawnSimpleActor
{
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("延迟时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:Delay")]
	public float Delay;

	[DisplayName("Template")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:Template")]
	public TSubclassOf<AActor> Template;

	[DisplayName("结束模式")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:Duration")]
	public float Duration;

	[UMeta(MD.ToolTip, "表现逻辑层通知特效应该结束时要额外延后多长时间销毁特效，小于等于0会立即销毁，否则会设置特效参数 GS_EfxStop = true; EndMode 是 AutoRelease 时无效")]
	[DisplayName("结束表现时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("依附目标挂点")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedTarget")]
	public bool AttachedTarget;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("依附目标插槽")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName;

	[UProperty]
	[EditAnywhere]
	[DisplayName("相对目标插槽偏移")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedTargetLocationOffset")]
	public FVector AttachedTargetLocationOffset;

	[DisplayName("相对目标插槽旋转")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedTargetRotationOffset")]
	public FRotator AttachedTargetRotationOffset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("监听发射者挂点")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedEmitter")]
	public bool AttachedEmitter;

	[BlueprintReadWrite]
	[UMeta(MDFunc.AdvancedDisplay)]
	[UProperty]
	[DisplayName("监听发射者插槽")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedEmitterSocketName")]
	public FName AttachedEmitterSocketName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("监听发射者插槽偏移")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedEmitterLocationOffset")]
	public FVector AttachedEmitterLocationOffset;

	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("监听发射者插槽旋转")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:AttachedEmitterRotationOffset")]
	public FRotator AttachedEmitterRotationOffset;

	[DisplayName("结束表现阶段与挂点分离")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "AttachedTarget == true")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:DetachOnEndDispStageBegin")]
	public bool DetachOnEndDispStageBegin;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:PausePriority")]
	public int PausePriority;

	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[DisplayName("结束表现阶段优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor:EndStagePriority")]
	public int EndStagePriority;

	private static int BUC_DispLibDBC_SpawnSimpleActor_StructSize;

	private static int BUC_DispLibDBC_SpawnSimpleActor_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool AttachedTarget_IsValid;

	private static int AttachedTarget_Offset;

	private static FFieldAddress AttachedTarget_PropertyAddress;

	private static bool AttachedTargetSocketName_IsValid;

	private static int AttachedTargetSocketName_Offset;

	private static bool AttachedTargetLocationOffset_IsValid;

	private static int AttachedTargetLocationOffset_Offset;

	private static bool AttachedTargetRotationOffset_IsValid;

	private static int AttachedTargetRotationOffset_Offset;

	private static bool AttachedEmitter_IsValid;

	private static int AttachedEmitter_Offset;

	private static FFieldAddress AttachedEmitter_PropertyAddress;

	private static bool AttachedEmitterSocketName_IsValid;

	private static int AttachedEmitterSocketName_Offset;

	private static bool AttachedEmitterLocationOffset_IsValid;

	private static int AttachedEmitterLocationOffset_Offset;

	private static bool AttachedEmitterRotationOffset_IsValid;

	private static int AttachedEmitterRotationOffset_Offset;

	private static bool DetachOnEndDispStageBegin_IsValid;

	private static int DetachOnEndDispStageBegin_Offset;

	private static FFieldAddress DetachOnEndDispStageBegin_PropertyAddress;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	public BUC_DispLibDBC_SpawnSimpleActor Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_SpawnSimpleActor FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_SpawnSimpleActor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_SpawnSimpleActor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_SpawnSimpleActor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_SpawnSimpleActor(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_SpawnSimpleActor_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_SpawnSimpleActor value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_SpawnSimpleActor_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_SpawnSimpleActor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Template_Offset), Template);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, AttachedTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset), AttachedTargetSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetLocationOffset_Offset), AttachedTargetLocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetRotationOffset_Offset), AttachedTargetRotationOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedEmitter_Offset), 0, AttachedEmitter_PropertyAddress.Address, AttachedEmitter);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedEmitterSocketName_Offset), AttachedEmitterSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AttachedEmitterLocationOffset_Offset), AttachedEmitterLocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, AttachedEmitterRotationOffset_Offset), AttachedEmitterRotationOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address, DetachOnEndDispStageBegin);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
	}

	public BUC_DispLibDBC_SpawnSimpleActor(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_SpawnSimpleActor_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor");
			Delay = 0f;
			Template = default(TSubclassOf<AActor>);
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			AttachedTarget = false;
			AttachedTargetSocketName = default(FName);
			AttachedTargetLocationOffset = default(FVector);
			AttachedTargetRotationOffset = default(FRotator);
			AttachedEmitter = false;
			AttachedEmitterSocketName = default(FName);
			AttachedEmitterLocationOffset = default(FVector);
			AttachedEmitterRotationOffset = default(FRotator);
			DetachOnEndDispStageBegin = false;
			PausePriority = 0;
			EndStagePriority = 0;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			Template = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Template_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			AttachedTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
			AttachedTargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset));
			AttachedTargetLocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetLocationOffset_Offset));
			AttachedTargetRotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetRotationOffset_Offset));
			AttachedEmitter = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedEmitter_Offset), 0, AttachedEmitter_PropertyAddress.Address);
			AttachedEmitterSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedEmitterSocketName_Offset));
			AttachedEmitterLocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AttachedEmitterLocationOffset_Offset));
			AttachedEmitterRotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, AttachedEmitterRotationOffset_Offset));
			DetachOnEndDispStageBegin = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address);
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor");
		BUC_DispLibDBC_SpawnSimpleActor_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AttachedTarget_PropertyAddress, intPtr, "AttachedTarget");
		AttachedTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTarget");
		AttachedTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTarget", Classes.FBoolProperty);
		AttachedTargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetSocketName");
		AttachedTargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetSocketName", Classes.FNameProperty);
		AttachedTargetLocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetLocationOffset");
		AttachedTargetLocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetLocationOffset", Classes.FStructProperty);
		AttachedTargetRotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetRotationOffset");
		AttachedTargetRotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetRotationOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AttachedEmitter_PropertyAddress, intPtr, "AttachedEmitter");
		AttachedEmitter_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitter");
		AttachedEmitter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitter", Classes.FBoolProperty);
		AttachedEmitterSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitterSocketName");
		AttachedEmitterSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitterSocketName", Classes.FNameProperty);
		AttachedEmitterLocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitterLocationOffset");
		AttachedEmitterLocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitterLocationOffset", Classes.FStructProperty);
		AttachedEmitterRotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitterRotationOffset");
		AttachedEmitterRotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitterRotationOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref DetachOnEndDispStageBegin_PropertyAddress, intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachOnEndDispStageBegin", Classes.FBoolProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		BUC_DispLibDBC_SpawnSimpleActor_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && Template_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && AttachedTarget_IsValid && AttachedTargetSocketName_IsValid && AttachedTargetLocationOffset_IsValid && AttachedTargetRotationOffset_IsValid && AttachedEmitter_IsValid && AttachedEmitterSocketName_IsValid && AttachedEmitterLocationOffset_IsValid && AttachedEmitterRotationOffset_IsValid && DetachOnEndDispStageBegin_IsValid && PausePriority_IsValid && EndStagePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_SpawnSimpleActor", (byte)BUC_DispLibDBC_SpawnSimpleActor_IsValid != 0);
	}

	static BUC_DispLibDBC_SpawnSimpleActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_SpawnSimpleActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_SpawnSimpleActor));
	}
}
