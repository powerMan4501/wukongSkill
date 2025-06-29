using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TaskStageConditionInfo")]
public struct FTaskStageConditionInfo
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("阶段ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TaskStageConditionInfo:TaskStageID")]
	public int TaskStageID;

	[DisplayName("阶段状态")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TaskStageConditionInfo:TaskStageConditionType")]
	public ETaskStageConditionType TaskStageConditionType;

	[DisplayName("自定义条件名称")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TaskStageConditionInfo:CustomConditionDisplayName")]
	public FName CustomConditionDisplayName;

	private static int TaskStageConditionInfo_StructSize;

	private static int TaskStageConditionInfo_IsValid;

	private static bool TaskStageID_IsValid;

	private static int TaskStageID_Offset;

	private static bool TaskStageConditionType_IsValid;

	private static int TaskStageConditionType_Offset;

	private static FFieldAddress TaskStageConditionType_PropertyAddress;

	private static bool CustomConditionDisplayName_IsValid;

	private static int CustomConditionDisplayName_Offset;

	public FTaskStageConditionInfo Copy()
	{
		return this;
	}

	public static FTaskStageConditionInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTaskStageConditionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTaskStageConditionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTaskStageConditionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTaskStageConditionInfo(IntPtr.Add(nativeBuffer, arrayIndex * TaskStageConditionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTaskStageConditionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TaskStageConditionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TaskStageConditionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TaskStageConditionInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TaskStageID_Offset), TaskStageID);
		EnumMarshaler<ETaskStageConditionType>.ToNative(IntPtr.Add(nativeStruct, TaskStageConditionType_Offset), 0, TaskStageConditionType_PropertyAddress.Address, TaskStageConditionType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, CustomConditionDisplayName_Offset), CustomConditionDisplayName);
	}

	public FTaskStageConditionInfo(IntPtr nativeStruct)
	{
		if (TaskStageConditionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TaskStageConditionInfo");
			TaskStageID = 0;
			TaskStageConditionType = ETaskStageConditionType.Actived;
			CustomConditionDisplayName = default(FName);
		}
		else
		{
			TaskStageID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TaskStageID_Offset));
			TaskStageConditionType = EnumMarshaler<ETaskStageConditionType>.FromNative(IntPtr.Add(nativeStruct, TaskStageConditionType_Offset), 0, TaskStageConditionType_PropertyAddress.Address);
			CustomConditionDisplayName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, CustomConditionDisplayName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TaskStageConditionInfo");
		TaskStageConditionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TaskStageID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageID");
		TaskStageID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TaskStageConditionType_PropertyAddress, intPtr, "TaskStageConditionType");
		TaskStageConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageConditionType");
		TaskStageConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageConditionType", Classes.FEnumProperty);
		CustomConditionDisplayName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomConditionDisplayName");
		CustomConditionDisplayName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomConditionDisplayName", Classes.FNameProperty);
		TaskStageConditionInfo_IsValid = ((intPtr != IntPtr.Zero && TaskStageID_IsValid && TaskStageConditionType_IsValid && CustomConditionDisplayName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TaskStageConditionInfo", (byte)TaskStageConditionInfo_IsValid != 0);
	}

	static FTaskStageConditionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTaskStageConditionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTaskStageConditionInfo));
	}
}
