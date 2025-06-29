using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileBaseStruct")]
public struct ProjectileBaseStruct
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("基准类型")]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:BaseType")]
	public ProjectileBaseType BaseType;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "BaseType != ProjectileBaseType::UsePointSetCached")]
	[UProperty]
	[Tooltip("Yes:使用骨骼或者Socket ； No:使用SceneComp")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:UseSocket")]
	public bool UseSocket;

	[UMeta(MDProp.EditCondition, "BaseType != ProjectileBaseType::UsePointSetCached")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:SocketName")]
	public FName SocketName;

	[UMeta(MDProp.EditCondition, "BaseType == ProjectileBaseType::UsePointSetCached")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("缓存的点集ID")]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:PointSetCachedReqID")]
	public int PointSetCachedReqID;

	[BlueprintReadWrite]
	[DisplayName("EQS模板")]
	[UMeta(MDProp.EditCondition, "BaseType == ProjectileBaseType::UseEQSPoint")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:EQSTemplate")]
	public UEnvQuery EQSTemplate;

	[DisplayName("每一波子弹不需要更新基准位置")]
	[BlueprintReadWrite]
	[Tooltip("不勾选时，每波子弹生成得时候都会更新基准位置，勾选时，仅在Spawn起始时更新一次基准位置，后续不再更新")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:DontUpdatePosPerWave")]
	public bool DontUpdatePosPerWave;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("子弹序号用于点阵列筛选，false:每波子弹生成序号从头开始计算，如每波生成5颗子弹，第3波生成的第3颗子弹序号为3，true:子弹生成序号于每波逐渐累积，如每波生成5颗子弹，第3波生成的第3颗子弹序号为5*2+3=13")]
	[DisplayName("每一波子弹序号逐渐累加")]
	[USharpPath("/Script/b1-Managed.ProjectileBaseStruct:DontUpdateBornIndexPerWave")]
	public bool DontUpdateBornIndexPerWave;

	public TStrongObjectPtr<AActor> BaseActor;

	public FEffectInstReq EffectInstReq;

	public List<FVector> BasePoints;

	public USceneComponent SocketOwnerComp;

	private static int ProjectileBaseStruct_StructSize;

	private static int ProjectileBaseStruct_IsValid;

	private static bool BaseType_IsValid;

	private static int BaseType_Offset;

	private static FFieldAddress BaseType_PropertyAddress;

	private static bool UseSocket_IsValid;

	private static int UseSocket_Offset;

	private static FFieldAddress UseSocket_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool PointSetCachedReqID_IsValid;

	private static int PointSetCachedReqID_Offset;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool DontUpdatePosPerWave_IsValid;

	private static int DontUpdatePosPerWave_Offset;

	private static FFieldAddress DontUpdatePosPerWave_PropertyAddress;

	private static bool DontUpdateBornIndexPerWave_IsValid;

	private static int DontUpdateBornIndexPerWave_Offset;

	private static FFieldAddress DontUpdateBornIndexPerWave_PropertyAddress;

	public ProjectileBaseStruct Copy()
	{
		return this;
	}

	public static ProjectileBaseStruct FromNative(IntPtr nativeBuffer)
	{
		return new ProjectileBaseStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProjectileBaseStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProjectileBaseStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProjectileBaseStruct(IntPtr.Add(nativeBuffer, arrayIndex * ProjectileBaseStruct_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProjectileBaseStruct value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProjectileBaseStruct_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProjectileBaseStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectileBaseStruct");
			return;
		}
		EnumMarshaler<ProjectileBaseType>.ToNative(IntPtr.Add(nativeStruct, BaseType_Offset), 0, BaseType_PropertyAddress.Address, BaseType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSocket_Offset), 0, UseSocket_PropertyAddress.Address, UseSocket);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PointSetCachedReqID_Offset), PointSetCachedReqID);
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset), EQSTemplate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DontUpdatePosPerWave_Offset), 0, DontUpdatePosPerWave_PropertyAddress.Address, DontUpdatePosPerWave);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DontUpdateBornIndexPerWave_Offset), 0, DontUpdateBornIndexPerWave_PropertyAddress.Address, DontUpdateBornIndexPerWave);
	}

	public ProjectileBaseStruct(IntPtr nativeStruct)
	{
		if (ProjectileBaseStruct_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProjectileBaseStruct");
			BaseType = ProjectileBaseType.None;
			UseSocket = false;
			SocketName = default(FName);
			PointSetCachedReqID = 0;
			EQSTemplate = null;
			DontUpdatePosPerWave = false;
			DontUpdateBornIndexPerWave = false;
		}
		else
		{
			BaseType = EnumMarshaler<ProjectileBaseType>.FromNative(IntPtr.Add(nativeStruct, BaseType_Offset), 0, BaseType_PropertyAddress.Address);
			UseSocket = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSocket_Offset), 0, UseSocket_PropertyAddress.Address);
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			PointSetCachedReqID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PointSetCachedReqID_Offset));
			EQSTemplate = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, EQSTemplate_Offset));
			DontUpdatePosPerWave = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DontUpdatePosPerWave_Offset), 0, DontUpdatePosPerWave_PropertyAddress.Address);
			DontUpdateBornIndexPerWave = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DontUpdateBornIndexPerWave_Offset), 0, DontUpdateBornIndexPerWave_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileBaseStruct");
		ProjectileBaseStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BaseType_PropertyAddress, intPtr, "BaseType");
		BaseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseType");
		BaseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UseSocket_PropertyAddress, intPtr, "UseSocket");
		UseSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSocket");
		UseSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSocket", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		PointSetCachedReqID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointSetCachedReqID");
		PointSetCachedReqID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointSetCachedReqID", Classes.FIntProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DontUpdatePosPerWave_PropertyAddress, intPtr, "DontUpdatePosPerWave");
		DontUpdatePosPerWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "DontUpdatePosPerWave");
		DontUpdatePosPerWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DontUpdatePosPerWave", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DontUpdateBornIndexPerWave_PropertyAddress, intPtr, "DontUpdateBornIndexPerWave");
		DontUpdateBornIndexPerWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "DontUpdateBornIndexPerWave");
		DontUpdateBornIndexPerWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DontUpdateBornIndexPerWave", Classes.FBoolProperty);
		ProjectileBaseStruct_IsValid = ((intPtr != IntPtr.Zero && BaseType_IsValid && UseSocket_IsValid && SocketName_IsValid && PointSetCachedReqID_IsValid && EQSTemplate_IsValid && DontUpdatePosPerWave_IsValid && DontUpdateBornIndexPerWave_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProjectileBaseStruct", (byte)ProjectileBaseStruct_IsValid != 0);
	}

	static ProjectileBaseStruct()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProjectileBaseStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProjectileBaseStruct));
	}
}
