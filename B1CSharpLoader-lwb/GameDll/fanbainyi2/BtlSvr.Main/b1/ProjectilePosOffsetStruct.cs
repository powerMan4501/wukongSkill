using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct")]
public struct ProjectilePosOffsetStruct
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("偏移类型")]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:PosOffsetType")]
	public ProjectilePosOffsetType PosOffsetType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("偏移空间类型")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:OffsetSpace")]
	public ProjectilePosOffsetSpace OffsetSpace;

	[UProperty]
	[UMeta(MDProp.EditCondition, "OffsetSpace == ProjectilePosOffsetSpace::BaseActorLocalSpace || OffsetSpace == ProjectilePosOffsetSpace::SocketLocalSpace")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("偏移基准类型")]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:BaseType")]
	public ProjectileBaseType BaseType;

	[UProperty]
	[UMeta(MDProp.EditCondition, "OffsetSpace == ProjectilePosOffsetSpace::SocketLocalSpace")]
	[EditAnywhere]
	[Tooltip("Yes:使用骨骼或者Socket ； No:使用SceneComp")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:UseSocket")]
	public bool UseSocket;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "OffsetSpace == ProjectilePosOffsetSpace::SocketLocalSpace")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:SocketName")]
	public FName SocketName;

	[Tooltip("当选择随机偏移时：偏移范围为 （-x,-y,-z）到（x, y, z）")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("偏移值")]
	[UMeta(MDProp.EditCondition, "PosOffsetType == ProjectilePosOffsetType::Normal || PosOffsetType == ProjectilePosOffsetType::RandomOffset")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:PosOffset")]
	public FVector PosOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("范围偏移信息")]
	[UMeta(MDProp.EditCondition, "PosOffsetType == ProjectilePosOffsetType::RangeOffset")]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:RangeOffsetInfo")]
	public FRangePointSetRule RangeOffsetInfo;

	[DisplayName("叠加世界空间Z方向抬升")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectilePosOffsetStruct:VerticalOffset_World")]
	public float VerticalOffset_World;

	public TStrongObjectPtr<AActor> BaseActor;

	private static int ProjectilePosOffsetStruct_StructSize;

	private static int ProjectilePosOffsetStruct_IsValid;

	private static bool PosOffsetType_IsValid;

	private static int PosOffsetType_Offset;

	private static FFieldAddress PosOffsetType_PropertyAddress;

	private static bool OffsetSpace_IsValid;

	private static int OffsetSpace_Offset;

	private static FFieldAddress OffsetSpace_PropertyAddress;

	private static bool BaseType_IsValid;

	private static int BaseType_Offset;

	private static FFieldAddress BaseType_PropertyAddress;

	private static bool UseSocket_IsValid;

	private static int UseSocket_Offset;

	private static FFieldAddress UseSocket_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool PosOffset_IsValid;

	private static int PosOffset_Offset;

	private static bool RangeOffsetInfo_IsValid;

	private static int RangeOffsetInfo_Offset;

	private static bool VerticalOffset_World_IsValid;

	private static int VerticalOffset_World_Offset;

	public ProjectilePosOffsetStruct Copy()
	{
		return this;
	}

	public static ProjectilePosOffsetStruct FromNative(IntPtr nativeBuffer)
	{
		return new ProjectilePosOffsetStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProjectilePosOffsetStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProjectilePosOffsetStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProjectilePosOffsetStruct(IntPtr.Add(nativeBuffer, arrayIndex * ProjectilePosOffsetStruct_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProjectilePosOffsetStruct value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProjectilePosOffsetStruct_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProjectilePosOffsetStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectilePosOffsetStruct");
			return;
		}
		EnumMarshaler<ProjectilePosOffsetType>.ToNative(IntPtr.Add(nativeStruct, PosOffsetType_Offset), 0, PosOffsetType_PropertyAddress.Address, PosOffsetType);
		EnumMarshaler<ProjectilePosOffsetSpace>.ToNative(IntPtr.Add(nativeStruct, OffsetSpace_Offset), 0, OffsetSpace_PropertyAddress.Address, OffsetSpace);
		EnumMarshaler<ProjectileBaseType>.ToNative(IntPtr.Add(nativeStruct, BaseType_Offset), 0, BaseType_PropertyAddress.Address, BaseType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSocket_Offset), 0, UseSocket_PropertyAddress.Address, UseSocket);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, PosOffset_Offset), PosOffset);
		FRangePointSetRule.ToNative(IntPtr.Add(nativeStruct, RangeOffsetInfo_Offset), RangeOffsetInfo);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VerticalOffset_World_Offset), VerticalOffset_World);
	}

	public ProjectilePosOffsetStruct(IntPtr nativeStruct)
	{
		if (ProjectilePosOffsetStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectilePosOffsetStruct");
			PosOffsetType = ProjectilePosOffsetType.None;
			OffsetSpace = ProjectilePosOffsetSpace.WorldSpace;
			BaseType = ProjectileBaseType.None;
			UseSocket = false;
			SocketName = default(FName);
			PosOffset = default(FVector);
			RangeOffsetInfo = default(FRangePointSetRule);
			VerticalOffset_World = 0f;
		}
		else
		{
			PosOffsetType = EnumMarshaler<ProjectilePosOffsetType>.FromNative(IntPtr.Add(nativeStruct, PosOffsetType_Offset), 0, PosOffsetType_PropertyAddress.Address);
			OffsetSpace = EnumMarshaler<ProjectilePosOffsetSpace>.FromNative(IntPtr.Add(nativeStruct, OffsetSpace_Offset), 0, OffsetSpace_PropertyAddress.Address);
			BaseType = EnumMarshaler<ProjectileBaseType>.FromNative(IntPtr.Add(nativeStruct, BaseType_Offset), 0, BaseType_PropertyAddress.Address);
			UseSocket = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSocket_Offset), 0, UseSocket_PropertyAddress.Address);
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			PosOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, PosOffset_Offset));
			RangeOffsetInfo = FRangePointSetRule.FromNative(IntPtr.Add(nativeStruct, RangeOffsetInfo_Offset));
			VerticalOffset_World = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VerticalOffset_World_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProjectilePosOffsetStruct");
		ProjectilePosOffsetStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref PosOffsetType_PropertyAddress, intPtr, "PosOffsetType");
		PosOffsetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PosOffsetType");
		PosOffsetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PosOffsetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref OffsetSpace_PropertyAddress, intPtr, "OffsetSpace");
		OffsetSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetSpace");
		OffsetSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetSpace", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BaseType_PropertyAddress, intPtr, "BaseType");
		BaseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseType");
		BaseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UseSocket_PropertyAddress, intPtr, "UseSocket");
		UseSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSocket");
		UseSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSocket", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		PosOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "PosOffset");
		PosOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PosOffset", Classes.FStructProperty);
		RangeOffsetInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeOffsetInfo");
		RangeOffsetInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeOffsetInfo", Classes.FStructProperty);
		VerticalOffset_World_Offset = NativeReflection.GetPropertyOffset(intPtr, "VerticalOffset_World");
		VerticalOffset_World_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VerticalOffset_World", Classes.FFloatProperty);
		ProjectilePosOffsetStruct_IsValid = ((intPtr != IntPtr.Zero && PosOffsetType_IsValid && OffsetSpace_IsValid && BaseType_IsValid && UseSocket_IsValid && SocketName_IsValid && PosOffset_IsValid && RangeOffsetInfo_IsValid && VerticalOffset_World_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProjectilePosOffsetStruct", (byte)ProjectilePosOffsetStruct_IsValid != 0);
	}

	static ProjectilePosOffsetStruct()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProjectilePosOffsetStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProjectilePosOffsetStruct));
	}
}
