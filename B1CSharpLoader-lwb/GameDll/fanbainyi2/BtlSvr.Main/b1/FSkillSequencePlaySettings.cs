using System;
using System.Collections.Generic;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings")]
public struct FSkillSequencePlaySettings
{
	[DisplayName("镜头列表")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:SequenceList")]
	public List<ULevelSequence> SequenceList;

	[DisplayName("镜头初始位置列表")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:SequenceCameraTransforms")]
	public List<FTransform> SequenceCameraTransforms;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("镜头旋转参考类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:RotationType")]
	public ESkillCameraRotationType RotationType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头附加到Unit上")]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:bAttachToUnit")]
	public bool bAttachToUnit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头附加到的IBM插槽名")]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:DummyMeshAttachSocketName")]
	public FName DummyMeshAttachSocketName;

	[BlueprintReadWrite]
	[DisplayName("附加镜头绑定Sequence Tag")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:ExtraCameraForSeqBindTag")]
	public FName ExtraCameraForSeqBindTag;

	[DisplayName("附加镜头FOV")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:AttachedCameraFOV")]
	public float AttachedCameraFOV;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("镜头瞬切阈值(角度）")]
	[UProperty]
	[Tooltip("如果选择的最近的镜头Blend过去旋转的角度超过这个值，就会瞬切镜头")]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:TeleportAngleDeg")]
	public float TeleportAngleDeg;

	[UProperty]
	[EditAnywhere]
	[DisplayName("Blend In时间")]
	[Tooltip("与上面的勾选互斥")]
	[UMeta(MDProp.EditCondition, "!bInCameraBlendTimeUseNotifyStateLength")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:InCameraBlendTime")]
	public float InCameraBlendTime;

	[BlueprintReadWrite]
	[DisplayName("Blend In加速系数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:InCameraBlendFactor")]
	public float InCameraBlendFactor;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否自动Blend Out相机")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:bEnableCameraAutoBlendOut")]
	public bool bEnableCameraAutoBlendOut;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("动画被打断时是否停止Sequence")]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:bStopWhenMontageInterrupted")]
	public bool bStopWhenMontageInterrupted;

	[BlueprintReadWrite]
	[DisplayName("Blend Out时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:OutCameraBlendTime")]
	public float OutCameraBlendTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Blend Out加速系数")]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:OutCameraBlendFactor")]
	public float OutCameraBlendFactor;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("总时长（NotifyState）")]
	[USharpPath("/Script/b1-Managed.SkillSequencePlaySettings:TotalDuration")]
	public float TotalDuration;

	private static int SkillSequencePlaySettings_StructSize;

	private static int SkillSequencePlaySettings_IsValid;

	private static bool SequenceList_IsValid;

	private static int SequenceList_Offset;

	private static FFieldAddress SequenceList_PropertyAddress;

	private static bool SequenceCameraTransforms_IsValid;

	private static int SequenceCameraTransforms_Offset;

	private static FFieldAddress SequenceCameraTransforms_PropertyAddress;

	private static bool RotationType_IsValid;

	private static int RotationType_Offset;

	private static FFieldAddress RotationType_PropertyAddress;

	private static bool bAttachToUnit_IsValid;

	private static int bAttachToUnit_Offset;

	private static FFieldAddress bAttachToUnit_PropertyAddress;

	private static bool DummyMeshAttachSocketName_IsValid;

	private static int DummyMeshAttachSocketName_Offset;

	private static bool ExtraCameraForSeqBindTag_IsValid;

	private static int ExtraCameraForSeqBindTag_Offset;

	private static bool AttachedCameraFOV_IsValid;

	private static int AttachedCameraFOV_Offset;

	private static bool TeleportAngleDeg_IsValid;

	private static int TeleportAngleDeg_Offset;

	private static bool InCameraBlendTime_IsValid;

	private static int InCameraBlendTime_Offset;

	private static bool InCameraBlendFactor_IsValid;

	private static int InCameraBlendFactor_Offset;

	private static bool bEnableCameraAutoBlendOut_IsValid;

	private static int bEnableCameraAutoBlendOut_Offset;

	private static FFieldAddress bEnableCameraAutoBlendOut_PropertyAddress;

	private static bool bStopWhenMontageInterrupted_IsValid;

	private static int bStopWhenMontageInterrupted_Offset;

	private static FFieldAddress bStopWhenMontageInterrupted_PropertyAddress;

	private static bool OutCameraBlendTime_IsValid;

	private static int OutCameraBlendTime_Offset;

	private static bool OutCameraBlendFactor_IsValid;

	private static int OutCameraBlendFactor_Offset;

	private static bool TotalDuration_IsValid;

	private static int TotalDuration_Offset;

	public FSkillSequencePlaySettings Copy()
	{
		FSkillSequencePlaySettings result = this;
		if (SequenceList != null)
		{
			result.SequenceList = new List<ULevelSequence>(SequenceList);
		}
		if (SequenceCameraTransforms != null)
		{
			result.SequenceCameraTransforms = new List<FTransform>(SequenceCameraTransforms);
		}
		return result;
	}

	public static FSkillSequencePlaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FSkillSequencePlaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkillSequencePlaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkillSequencePlaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkillSequencePlaySettings(IntPtr.Add(nativeBuffer, arrayIndex * SkillSequencePlaySettings_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkillSequencePlaySettings value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SkillSequencePlaySettings_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SkillSequencePlaySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillSequencePlaySettings");
			return;
		}
		new TArrayCopyMarshaler<ULevelSequence>(1, SequenceList_PropertyAddress, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.FromNative, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SequenceList_Offset), SequenceList);
		new TArrayCopyMarshaler<FTransform>(1, SequenceCameraTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SequenceCameraTransforms_Offset), SequenceCameraTransforms);
		EnumMarshaler<ESkillCameraRotationType>.ToNative(IntPtr.Add(nativeStruct, RotationType_Offset), 0, RotationType_PropertyAddress.Address, RotationType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bAttachToUnit_Offset), 0, bAttachToUnit_PropertyAddress.Address, bAttachToUnit);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, DummyMeshAttachSocketName_Offset), DummyMeshAttachSocketName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ExtraCameraForSeqBindTag_Offset), ExtraCameraForSeqBindTag);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttachedCameraFOV_Offset), AttachedCameraFOV);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TeleportAngleDeg_Offset), TeleportAngleDeg);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendTime_Offset), InCameraBlendTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendFactor_Offset), InCameraBlendFactor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableCameraAutoBlendOut_Offset), 0, bEnableCameraAutoBlendOut_PropertyAddress.Address, bEnableCameraAutoBlendOut);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bStopWhenMontageInterrupted_Offset), 0, bStopWhenMontageInterrupted_PropertyAddress.Address, bStopWhenMontageInterrupted);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutCameraBlendTime_Offset), OutCameraBlendTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutCameraBlendFactor_Offset), OutCameraBlendFactor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TotalDuration_Offset), TotalDuration);
	}

	public FSkillSequencePlaySettings(IntPtr nativeStruct)
	{
		if (SkillSequencePlaySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SkillSequencePlaySettings");
			SequenceList = null;
			SequenceCameraTransforms = null;
			RotationType = ESkillCameraRotationType.UseUnitRotation;
			bAttachToUnit = false;
			DummyMeshAttachSocketName = default(FName);
			ExtraCameraForSeqBindTag = default(FName);
			AttachedCameraFOV = 0f;
			TeleportAngleDeg = 0f;
			InCameraBlendTime = 0f;
			InCameraBlendFactor = 0f;
			bEnableCameraAutoBlendOut = false;
			bStopWhenMontageInterrupted = false;
			OutCameraBlendTime = 0f;
			OutCameraBlendFactor = 0f;
			TotalDuration = 0f;
		}
		else
		{
			SequenceList = new TArrayCopyMarshaler<ULevelSequence>(1, SequenceList_PropertyAddress, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.FromNative, CachedMarshalingDelegates<ULevelSequence, UObjectMarshaler<ULevelSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SequenceList_Offset));
			SequenceCameraTransforms = new TArrayCopyMarshaler<FTransform>(1, SequenceCameraTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SequenceCameraTransforms_Offset));
			RotationType = EnumMarshaler<ESkillCameraRotationType>.FromNative(IntPtr.Add(nativeStruct, RotationType_Offset), 0, RotationType_PropertyAddress.Address);
			bAttachToUnit = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bAttachToUnit_Offset), 0, bAttachToUnit_PropertyAddress.Address);
			DummyMeshAttachSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, DummyMeshAttachSocketName_Offset));
			ExtraCameraForSeqBindTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ExtraCameraForSeqBindTag_Offset));
			AttachedCameraFOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttachedCameraFOV_Offset));
			TeleportAngleDeg = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TeleportAngleDeg_Offset));
			InCameraBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendTime_Offset));
			InCameraBlendFactor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendFactor_Offset));
			bEnableCameraAutoBlendOut = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableCameraAutoBlendOut_Offset), 0, bEnableCameraAutoBlendOut_PropertyAddress.Address);
			bStopWhenMontageInterrupted = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bStopWhenMontageInterrupted_Offset), 0, bStopWhenMontageInterrupted_PropertyAddress.Address);
			OutCameraBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutCameraBlendTime_Offset));
			OutCameraBlendFactor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutCameraBlendFactor_Offset));
			TotalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TotalDuration_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SkillSequencePlaySettings");
		SkillSequencePlaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SequenceList_PropertyAddress, intPtr, "SequenceList");
		SequenceList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceList");
		SequenceList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SequenceCameraTransforms_PropertyAddress, intPtr, "SequenceCameraTransforms");
		SequenceCameraTransforms_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceCameraTransforms");
		SequenceCameraTransforms_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceCameraTransforms", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RotationType_PropertyAddress, intPtr, "RotationType");
		RotationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationType");
		RotationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bAttachToUnit_PropertyAddress, intPtr, "bAttachToUnit");
		bAttachToUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAttachToUnit");
		bAttachToUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAttachToUnit", Classes.FBoolProperty);
		DummyMeshAttachSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DummyMeshAttachSocketName");
		DummyMeshAttachSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DummyMeshAttachSocketName", Classes.FNameProperty);
		ExtraCameraForSeqBindTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraCameraForSeqBindTag");
		ExtraCameraForSeqBindTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraCameraForSeqBindTag", Classes.FNameProperty);
		AttachedCameraFOV_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedCameraFOV");
		AttachedCameraFOV_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedCameraFOV", Classes.FFloatProperty);
		TeleportAngleDeg_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportAngleDeg");
		TeleportAngleDeg_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportAngleDeg", Classes.FFloatProperty);
		InCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendTime");
		InCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendTime", Classes.FFloatProperty);
		InCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InCameraBlendFactor");
		InCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InCameraBlendFactor", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableCameraAutoBlendOut_PropertyAddress, intPtr, "bEnableCameraAutoBlendOut");
		bEnableCameraAutoBlendOut_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableCameraAutoBlendOut");
		bEnableCameraAutoBlendOut_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableCameraAutoBlendOut", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bStopWhenMontageInterrupted_PropertyAddress, intPtr, "bStopWhenMontageInterrupted");
		bStopWhenMontageInterrupted_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStopWhenMontageInterrupted");
		bStopWhenMontageInterrupted_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStopWhenMontageInterrupted", Classes.FBoolProperty);
		OutCameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OutCameraBlendTime");
		OutCameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OutCameraBlendTime", Classes.FFloatProperty);
		OutCameraBlendFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "OutCameraBlendFactor");
		OutCameraBlendFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OutCameraBlendFactor", Classes.FFloatProperty);
		TotalDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "TotalDuration");
		TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TotalDuration", Classes.FFloatProperty);
		SkillSequencePlaySettings_IsValid = ((intPtr != IntPtr.Zero && SequenceList_IsValid && SequenceCameraTransforms_IsValid && RotationType_IsValid && bAttachToUnit_IsValid && DummyMeshAttachSocketName_IsValid && ExtraCameraForSeqBindTag_IsValid && AttachedCameraFOV_IsValid && TeleportAngleDeg_IsValid && InCameraBlendTime_IsValid && InCameraBlendFactor_IsValid && bEnableCameraAutoBlendOut_IsValid && bStopWhenMontageInterrupted_IsValid && OutCameraBlendTime_IsValid && OutCameraBlendFactor_IsValid && TotalDuration_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SkillSequencePlaySettings", (byte)SkillSequencePlaySettings_IsValid != 0);
	}

	static FSkillSequencePlaySettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSkillSequencePlaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkillSequencePlaySettings));
	}
}
