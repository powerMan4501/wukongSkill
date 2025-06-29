using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PriorityActionQueInfo")]
public struct FPriorityActionQueInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("执行者数量")]
	[USharpPath("/Script/b1-Managed.PriorityActionQueInfo:ExecutorNum")]
	public int ExecutorNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("执行者资源ID")]
	[USharpPath("/Script/b1-Managed.PriorityActionQueInfo:ResID")]
	public int ResID;

	[DisplayName("选择单位方式")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PriorityActionQueInfo:SelectUnitTypeInfo")]
	public FPAQI_SelectUnitTypeInfo SelectUnitTypeInfo;

	[DisplayName("单位类型")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PriorityActionQueInfo:UnitType")]
	public EPriorityActionUnitType UnitType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("优先任务列表")]
	[USharpPath("/Script/b1-Managed.PriorityActionQueInfo:Actions")]
	public List<FOnePriorityActionInfo> Actions;

	private static int PriorityActionQueInfo_StructSize;

	private static int PriorityActionQueInfo_IsValid;

	private static bool ExecutorNum_IsValid;

	private static int ExecutorNum_Offset;

	private static bool ResID_IsValid;

	private static int ResID_Offset;

	private static bool SelectUnitTypeInfo_IsValid;

	private static int SelectUnitTypeInfo_Offset;

	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool Actions_IsValid;

	private static int Actions_Offset;

	private static FFieldAddress Actions_PropertyAddress;

	public FPriorityActionQueInfo Copy()
	{
		FPriorityActionQueInfo result = this;
		if (Actions != null)
		{
			result.Actions = new List<FOnePriorityActionInfo>(Actions);
		}
		return result;
	}

	public static FPriorityActionQueInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPriorityActionQueInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPriorityActionQueInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPriorityActionQueInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPriorityActionQueInfo(IntPtr.Add(nativeBuffer, arrayIndex * PriorityActionQueInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPriorityActionQueInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PriorityActionQueInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PriorityActionQueInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PriorityActionQueInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExecutorNum_Offset), ExecutorNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResID_Offset), ResID);
		FPAQI_SelectUnitTypeInfo.ToNative(IntPtr.Add(nativeStruct, SelectUnitTypeInfo_Offset), SelectUnitTypeInfo);
		EnumMarshaler<EPriorityActionUnitType>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address, UnitType);
		new TArrayCopyMarshaler<FOnePriorityActionInfo>(1, Actions_PropertyAddress, CachedMarshalingDelegates<FOnePriorityActionInfo, FOnePriorityActionInfo>.FromNative, CachedMarshalingDelegates<FOnePriorityActionInfo, FOnePriorityActionInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, Actions_Offset), Actions);
	}

	public FPriorityActionQueInfo(IntPtr nativeStruct)
	{
		if (PriorityActionQueInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PriorityActionQueInfo");
			ExecutorNum = 0;
			ResID = 0;
			SelectUnitTypeInfo = default(FPAQI_SelectUnitTypeInfo);
			UnitType = EPriorityActionUnitType.ActivatingGroupAIUnit;
			Actions = null;
		}
		else
		{
			ExecutorNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExecutorNum_Offset));
			ResID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResID_Offset));
			SelectUnitTypeInfo = FPAQI_SelectUnitTypeInfo.FromNative(IntPtr.Add(nativeStruct, SelectUnitTypeInfo_Offset));
			UnitType = EnumMarshaler<EPriorityActionUnitType>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
			Actions = new TArrayCopyMarshaler<FOnePriorityActionInfo>(1, Actions_PropertyAddress, CachedMarshalingDelegates<FOnePriorityActionInfo, FOnePriorityActionInfo>.FromNative, CachedMarshalingDelegates<FOnePriorityActionInfo, FOnePriorityActionInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, Actions_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PriorityActionQueInfo");
		PriorityActionQueInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ExecutorNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExecutorNum");
		ExecutorNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExecutorNum", Classes.FIntProperty);
		ResID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResID", Classes.FIntProperty);
		SelectUnitTypeInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelectUnitTypeInfo");
		SelectUnitTypeInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelectUnitTypeInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Actions_PropertyAddress, intPtr, "Actions");
		Actions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Actions");
		Actions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Actions", Classes.FArrayProperty);
		PriorityActionQueInfo_IsValid = ((intPtr != IntPtr.Zero && ExecutorNum_IsValid && ResID_IsValid && SelectUnitTypeInfo_IsValid && UnitType_IsValid && Actions_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PriorityActionQueInfo", (byte)PriorityActionQueInfo_IsValid != 0);
	}

	static FPriorityActionQueInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPriorityActionQueInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPriorityActionQueInfo));
	}
}
