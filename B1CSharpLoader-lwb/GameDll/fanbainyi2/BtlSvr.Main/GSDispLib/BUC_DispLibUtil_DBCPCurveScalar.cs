using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar")]
public struct BUC_DispLibUtil_DBCPCurveScalar
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("控制点列表")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar:PointsList")]
	public List<OnePCurveScalarPoint> PointsList;

	[UMeta(MD.ToolTip, "true = 按所有控制点累加的总时长循环采样曲线；false = 按所有控制点累加时长采样一遍曲线，之后一直为最后一个点的值")]
	[DisplayName("循环")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar:Loop")]
	public bool Loop;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("总时间")]
	[UMeta(MD.ToolTip, "<=0 程序通知何时进入收尾阶段；>0 超过【总时间】后进入收尾阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar:Duration")]
	public float Duration;

	[DisplayName("收尾目标点")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar:EndToPoint")]
	public OnePCurveScalarPoint EndToPoint;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "在什么时机释放参数控制权，释放参数控制权后，如果没有其他事件在操作此参数，参数将自动重置为原始值，原始值一般是角色出生时该参数的值；")]
	[DisplayName("释放参数控制权时机")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar:ReleaseParameterControlMode")]
	public DispLibDBCAdvProcessReleaseParameterControlMode ReleaseParameterControlMode;

	private static int BUC_DispLibUtil_DBCPCurveScalar_StructSize;

	private static int BUC_DispLibUtil_DBCPCurveScalar_IsValid;

	private static bool PointsList_IsValid;

	private static int PointsList_Offset;

	private static FFieldAddress PointsList_PropertyAddress;

	private static bool Loop_IsValid;

	private static int Loop_Offset;

	private static FFieldAddress Loop_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool EndToPoint_IsValid;

	private static int EndToPoint_Offset;

	private static bool ReleaseParameterControlMode_IsValid;

	private static int ReleaseParameterControlMode_Offset;

	private static FFieldAddress ReleaseParameterControlMode_PropertyAddress;

	public bool IsValid()
	{
		if (PointsList.Count > 0)
		{
			return true;
		}
		return false;
	}

	public BUC_DispLibUtil_DBCPCurveScalar SetCustomData(List<OnePCurveScalarPoint> _PointsList, bool _Loop, float _Duration, OnePCurveScalarPoint _EndToPoint, DispLibDBCAdvProcessReleaseParameterControlMode _ReleaseParameterControlMode)
	{
		PointsList = _PointsList;
		Loop = _Loop;
		Duration = _Duration;
		EndToPoint = _EndToPoint;
		ReleaseParameterControlMode = _ReleaseParameterControlMode;
		return this;
	}

	public BUC_DispLibUtil_DBCPCurveScalar Copy()
	{
		BUC_DispLibUtil_DBCPCurveScalar result = this;
		if (PointsList != null)
		{
			result.PointsList = new List<OnePCurveScalarPoint>(PointsList);
		}
		return result;
	}

	public static BUC_DispLibUtil_DBCPCurveScalar FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCPCurveScalar(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCPCurveScalar value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCPCurveScalar FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCPCurveScalar(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCPCurveScalar_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCPCurveScalar value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCPCurveScalar_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCPCurveScalar_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar");
			return;
		}
		new TArrayCopyMarshaler<OnePCurveScalarPoint>(1, PointsList_PropertyAddress, CachedMarshalingDelegates<OnePCurveScalarPoint, OnePCurveScalarPoint>.FromNative, CachedMarshalingDelegates<OnePCurveScalarPoint, OnePCurveScalarPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, PointsList_Offset), PointsList);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address, Loop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		OnePCurveScalarPoint.ToNative(IntPtr.Add(nativeStruct, EndToPoint_Offset), EndToPoint);
		EnumMarshaler<DispLibDBCAdvProcessReleaseParameterControlMode>.ToNative(IntPtr.Add(nativeStruct, ReleaseParameterControlMode_Offset), 0, ReleaseParameterControlMode_PropertyAddress.Address, ReleaseParameterControlMode);
	}

	public BUC_DispLibUtil_DBCPCurveScalar(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCPCurveScalar_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar");
			PointsList = null;
			Loop = false;
			Duration = 0f;
			EndToPoint = default(OnePCurveScalarPoint);
			ReleaseParameterControlMode = DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd;
		}
		else
		{
			PointsList = new TArrayCopyMarshaler<OnePCurveScalarPoint>(1, PointsList_PropertyAddress, CachedMarshalingDelegates<OnePCurveScalarPoint, OnePCurveScalarPoint>.FromNative, CachedMarshalingDelegates<OnePCurveScalarPoint, OnePCurveScalarPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, PointsList_Offset));
			Loop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Loop_Offset), 0, Loop_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			EndToPoint = OnePCurveScalarPoint.FromNative(IntPtr.Add(nativeStruct, EndToPoint_Offset));
			ReleaseParameterControlMode = EnumMarshaler<DispLibDBCAdvProcessReleaseParameterControlMode>.FromNative(IntPtr.Add(nativeStruct, ReleaseParameterControlMode_Offset), 0, ReleaseParameterControlMode_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar");
		BUC_DispLibUtil_DBCPCurveScalar_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref PointsList_PropertyAddress, intPtr, "PointsList");
		PointsList_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointsList");
		PointsList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointsList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Loop_PropertyAddress, intPtr, "Loop");
		Loop_Offset = NativeReflection.GetPropertyOffset(intPtr, "Loop");
		Loop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Loop", Classes.FBoolProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		EndToPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndToPoint");
		EndToPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndToPoint", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ReleaseParameterControlMode_PropertyAddress, intPtr, "ReleaseParameterControlMode");
		ReleaseParameterControlMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReleaseParameterControlMode");
		ReleaseParameterControlMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReleaseParameterControlMode", Classes.FEnumProperty);
		BUC_DispLibUtil_DBCPCurveScalar_IsValid = ((intPtr != IntPtr.Zero && PointsList_IsValid && Loop_IsValid && Duration_IsValid && EndToPoint_IsValid && ReleaseParameterControlMode_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCPCurveScalar", (byte)BUC_DispLibUtil_DBCPCurveScalar_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCPCurveScalar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCPCurveScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCPCurveScalar));
	}
}
