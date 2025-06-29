using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileBornDirStruct")]
public struct ProjectileBornDirStruct
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("生成朝向类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirStruct:BornDirType")]
	public ProjectileBornDirType BornDirType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("Roll和Pitch归0")]
	[DisplayName("基准朝向只取用Yaw信息")]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirStruct:JustUseYawInfo")]
	public bool JustUseYawInfo;

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "BornDirType == ProjectileBornDirType::UsePointSetCached")]
	[DisplayName("缓存的点集ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectileBornDirStruct:PointSetCachedReqID")]
	public int PointSetCachedReqID;

	public FRotator HitPointNormalDir;

	public AActor ExtraRotBaseActor;

	private static int ProjectileBornDirStruct_StructSize;

	private static int ProjectileBornDirStruct_IsValid;

	private static bool BornDirType_IsValid;

	private static int BornDirType_Offset;

	private static FFieldAddress BornDirType_PropertyAddress;

	private static bool JustUseYawInfo_IsValid;

	private static int JustUseYawInfo_Offset;

	private static FFieldAddress JustUseYawInfo_PropertyAddress;

	private static bool PointSetCachedReqID_IsValid;

	private static int PointSetCachedReqID_Offset;

	public ProjectileBornDirStruct Copy()
	{
		return this;
	}

	public static ProjectileBornDirStruct FromNative(IntPtr nativeBuffer)
	{
		return new ProjectileBornDirStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProjectileBornDirStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProjectileBornDirStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProjectileBornDirStruct(IntPtr.Add(nativeBuffer, arrayIndex * ProjectileBornDirStruct_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProjectileBornDirStruct value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProjectileBornDirStruct_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProjectileBornDirStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectileBornDirStruct");
			return;
		}
		EnumMarshaler<ProjectileBornDirType>.ToNative(IntPtr.Add(nativeStruct, BornDirType_Offset), 0, BornDirType_PropertyAddress.Address, BornDirType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, JustUseYawInfo_Offset), 0, JustUseYawInfo_PropertyAddress.Address, JustUseYawInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PointSetCachedReqID_Offset), PointSetCachedReqID);
	}

	public ProjectileBornDirStruct(IntPtr nativeStruct)
	{
		if (ProjectileBornDirStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectileBornDirStruct");
			BornDirType = ProjectileBornDirType.None;
			JustUseYawInfo = false;
			PointSetCachedReqID = 0;
		}
		else
		{
			BornDirType = EnumMarshaler<ProjectileBornDirType>.FromNative(IntPtr.Add(nativeStruct, BornDirType_Offset), 0, BornDirType_PropertyAddress.Address);
			JustUseYawInfo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, JustUseYawInfo_Offset), 0, JustUseYawInfo_PropertyAddress.Address);
			PointSetCachedReqID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PointSetCachedReqID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileBornDirStruct");
		ProjectileBornDirStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BornDirType_PropertyAddress, intPtr, "BornDirType");
		BornDirType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirType");
		BornDirType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref JustUseYawInfo_PropertyAddress, intPtr, "JustUseYawInfo");
		JustUseYawInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "JustUseYawInfo");
		JustUseYawInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JustUseYawInfo", Classes.FBoolProperty);
		PointSetCachedReqID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointSetCachedReqID");
		PointSetCachedReqID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointSetCachedReqID", Classes.FIntProperty);
		ProjectileBornDirStruct_IsValid = ((intPtr != IntPtr.Zero && BornDirType_IsValid && JustUseYawInfo_IsValid && PointSetCachedReqID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProjectileBornDirStruct", (byte)ProjectileBornDirStruct_IsValid != 0);
	}

	static ProjectileBornDirStruct()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProjectileBornDirStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProjectileBornDirStruct));
	}
}
