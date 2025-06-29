using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade")]
public struct BUC_DispLibDBC_PlayCascade
{
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("延迟时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:Delay")]
	public float Delay;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:EndMode")]
	public DispLibDBCEndMode EndMode;

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[DisplayName("持续时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:Duration")]
	public float Duration;

	[EditAnywhere]
	[DisplayName("Template")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:Template")]
	public UParticleSystem Template;

	[DisplayName("依附目标挂点")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:AttachedTarget")]
	public bool AttachedTarget;

	[DisplayName("目标挂点名")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "如果配置了一个有效的挂点但是不勾选【依附目标挂点】，特效会创建在挂点位置但是不依附于挂点")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:LocationOffset")]
	public FVector LocationOffset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:RotationOffset")]
	public FRotator RotationOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:Scale")]
	public FVector Scale;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("透明排序优先级")]
	[UMeta(MD.ToolTip, "数值越大的排序时更靠近摄像机")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade:TranslucentSortPriority")]
	public int TranslucentSortPriority;

	private static int BUC_DispLibDBC_PlayCascade_StructSize;

	private static int BUC_DispLibDBC_PlayCascade_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool AttachedTarget_IsValid;

	private static int AttachedTarget_Offset;

	private static FFieldAddress AttachedTarget_PropertyAddress;

	private static bool AttachedTargetSocketName_IsValid;

	private static int AttachedTargetSocketName_Offset;

	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool TranslucentSortPriority_IsValid;

	private static int TranslucentSortPriority_Offset;

	public BUC_DispLibDBC_PlayCascade Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_PlayCascade FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayCascade(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayCascade value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayCascade FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayCascade(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayCascade_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayCascade value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayCascade_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayCascade_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(nativeStruct, Template_Offset), Template);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, AttachedTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset), AttachedTargetSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocationOffset_Offset), LocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, RotationOffset_Offset), RotationOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TranslucentSortPriority_Offset), TranslucentSortPriority);
	}

	public BUC_DispLibDBC_PlayCascade(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayCascade_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade");
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			Template = null;
			AttachedTarget = false;
			AttachedTargetSocketName = default(FName);
			LocationOffset = default(FVector);
			RotationOffset = default(FRotator);
			Scale = default(FVector);
			TranslucentSortPriority = 0;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			Template = UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(nativeStruct, Template_Offset));
			AttachedTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
			AttachedTargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset));
			LocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocationOffset_Offset));
			RotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, RotationOffset_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			TranslucentSortPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TranslucentSortPriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade");
		BUC_DispLibDBC_PlayCascade_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AttachedTarget_PropertyAddress, intPtr, "AttachedTarget");
		AttachedTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTarget");
		AttachedTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTarget", Classes.FBoolProperty);
		AttachedTargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetSocketName");
		AttachedTargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetSocketName", Classes.FNameProperty);
		LocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationOffset");
		LocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationOffset");
		RotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationOffset", Classes.FStructProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		TranslucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "TranslucentSortPriority");
		TranslucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TranslucentSortPriority", Classes.FIntProperty);
		BUC_DispLibDBC_PlayCascade_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && EndMode_IsValid && Duration_IsValid && Template_IsValid && AttachedTarget_IsValid && AttachedTargetSocketName_IsValid && LocationOffset_IsValid && RotationOffset_IsValid && Scale_IsValid && TranslucentSortPriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayCascade", (byte)BUC_DispLibDBC_PlayCascade_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayCascade()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayCascade)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayCascade));
	}
}
