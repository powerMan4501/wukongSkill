using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct")]
public struct ProjectileBornDirOffsetStruct
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:UseExtraAimPoint")]
	public bool UseExtraAimPoint;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseExtraAimPoint")]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:ExtraAimPointUseSocket")]
	public bool ExtraAimPointUseSocket;

	[UMeta(MDProp.EditCondition, "UseExtraAimPoint")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:ExtraAimPointName")]
	public FName ExtraAimPointName;

	[UMeta(MDProp.ClampMax, 180)]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "UseExtraAimPoint")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:MaxDiffAngle")]
	public float MaxDiffAngle;

	[BlueprintReadWrite]
	[Tooltip("轴向约束,非0值表示 锁定绕该轴向上的旋转，填0值则可打开对应的偏移旋转")]
	[DisplayName("轴向约束")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:AimConstraintAxis")]
	public FVector AimConstraintAxis;

	[DisplayName("绕X轴旋转角度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:BornDirOffsetX")]
	public FSpawnBulletMinMaxValue BornDirOffsetX;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("绕Y轴旋转角度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:BornDirOffsetY")]
	public FSpawnBulletMinMaxValue BornDirOffsetY;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("绕Z轴旋转角度")]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirOffsetStruct:BornDirOffsetZ")]
	public FSpawnBulletMinMaxValue BornDirOffsetZ;

	private static int ProjectileBornDirOffsetStruct_StructSize;

	private static int ProjectileBornDirOffsetStruct_IsValid;

	private static bool UseExtraAimPoint_IsValid;

	private static int UseExtraAimPoint_Offset;

	private static FFieldAddress UseExtraAimPoint_PropertyAddress;

	private static bool ExtraAimPointUseSocket_IsValid;

	private static int ExtraAimPointUseSocket_Offset;

	private static FFieldAddress ExtraAimPointUseSocket_PropertyAddress;

	private static bool ExtraAimPointName_IsValid;

	private static int ExtraAimPointName_Offset;

	private static bool MaxDiffAngle_IsValid;

	private static int MaxDiffAngle_Offset;

	private static bool AimConstraintAxis_IsValid;

	private static int AimConstraintAxis_Offset;

	private static bool BornDirOffsetX_IsValid;

	private static int BornDirOffsetX_Offset;

	private static bool BornDirOffsetY_IsValid;

	private static int BornDirOffsetY_Offset;

	private static bool BornDirOffsetZ_IsValid;

	private static int BornDirOffsetZ_Offset;

	public ProjectileBornDirOffsetStruct Copy()
	{
		return this;
	}

	public static ProjectileBornDirOffsetStruct FromNative(IntPtr nativeBuffer)
	{
		return new ProjectileBornDirOffsetStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProjectileBornDirOffsetStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProjectileBornDirOffsetStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProjectileBornDirOffsetStruct(IntPtr.Add(nativeBuffer, arrayIndex * ProjectileBornDirOffsetStruct_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProjectileBornDirOffsetStruct value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProjectileBornDirOffsetStruct_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProjectileBornDirOffsetStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectileBornDirOffsetStruct");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseExtraAimPoint_Offset), 0, UseExtraAimPoint_PropertyAddress.Address, UseExtraAimPoint);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ExtraAimPointUseSocket_Offset), 0, ExtraAimPointUseSocket_PropertyAddress.Address, ExtraAimPointUseSocket);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ExtraAimPointName_Offset), ExtraAimPointName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDiffAngle_Offset), MaxDiffAngle);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AimConstraintAxis_Offset), AimConstraintAxis);
		FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(nativeStruct, BornDirOffsetX_Offset), BornDirOffsetX);
		FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(nativeStruct, BornDirOffsetY_Offset), BornDirOffsetY);
		FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(nativeStruct, BornDirOffsetZ_Offset), BornDirOffsetZ);
	}

	public ProjectileBornDirOffsetStruct(IntPtr nativeStruct)
	{
		if (ProjectileBornDirOffsetStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectileBornDirOffsetStruct");
			UseExtraAimPoint = false;
			ExtraAimPointUseSocket = false;
			ExtraAimPointName = default(FName);
			MaxDiffAngle = 0f;
			AimConstraintAxis = default(FVector);
			BornDirOffsetX = default(FSpawnBulletMinMaxValue);
			BornDirOffsetY = default(FSpawnBulletMinMaxValue);
			BornDirOffsetZ = default(FSpawnBulletMinMaxValue);
		}
		else
		{
			UseExtraAimPoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseExtraAimPoint_Offset), 0, UseExtraAimPoint_PropertyAddress.Address);
			ExtraAimPointUseSocket = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ExtraAimPointUseSocket_Offset), 0, ExtraAimPointUseSocket_PropertyAddress.Address);
			ExtraAimPointName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ExtraAimPointName_Offset));
			MaxDiffAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDiffAngle_Offset));
			AimConstraintAxis = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AimConstraintAxis_Offset));
			BornDirOffsetX = FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(nativeStruct, BornDirOffsetX_Offset));
			BornDirOffsetY = FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(nativeStruct, BornDirOffsetY_Offset));
			BornDirOffsetZ = FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(nativeStruct, BornDirOffsetZ_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileBornDirOffsetStruct");
		ProjectileBornDirOffsetStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UseExtraAimPoint_PropertyAddress, intPtr, "UseExtraAimPoint");
		UseExtraAimPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseExtraAimPoint");
		UseExtraAimPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseExtraAimPoint", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ExtraAimPointUseSocket_PropertyAddress, intPtr, "ExtraAimPointUseSocket");
		ExtraAimPointUseSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraAimPointUseSocket");
		ExtraAimPointUseSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraAimPointUseSocket", Classes.FBoolProperty);
		ExtraAimPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraAimPointName");
		ExtraAimPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraAimPointName", Classes.FNameProperty);
		MaxDiffAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDiffAngle");
		MaxDiffAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDiffAngle", Classes.FFloatProperty);
		AimConstraintAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimConstraintAxis");
		AimConstraintAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimConstraintAxis", Classes.FStructProperty);
		BornDirOffsetX_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffsetX");
		BornDirOffsetX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffsetX", Classes.FStructProperty);
		BornDirOffsetY_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffsetY");
		BornDirOffsetY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffsetY", Classes.FStructProperty);
		BornDirOffsetZ_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffsetZ");
		BornDirOffsetZ_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffsetZ", Classes.FStructProperty);
		ProjectileBornDirOffsetStruct_IsValid = ((intPtr != IntPtr.Zero && UseExtraAimPoint_IsValid && ExtraAimPointUseSocket_IsValid && ExtraAimPointName_IsValid && MaxDiffAngle_IsValid && AimConstraintAxis_IsValid && BornDirOffsetX_IsValid && BornDirOffsetY_IsValid && BornDirOffsetZ_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProjectileBornDirOffsetStruct", (byte)ProjectileBornDirOffsetStruct_IsValid != 0);
	}

	static ProjectileBornDirOffsetStruct()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProjectileBornDirOffsetStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProjectileBornDirOffsetStruct));
	}
}
