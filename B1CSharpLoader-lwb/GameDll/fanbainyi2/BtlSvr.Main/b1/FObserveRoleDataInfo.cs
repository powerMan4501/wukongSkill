using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo")]
public struct FObserveRoleDataInfo
{
	[DisplayName("观察类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:ObserveType")]
	public ERoleDataType ObserveType;

	[EditDefaultsOnly]
	[UProperty]
	[DisplayName("观察任务阶段ID")]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:TaskStage")]
	public FGsSmartParam TaskStage;

	[UProperty]
	[EditDefaultsOnly]
	[DisplayName("观察任务阶段状态")]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:ObserveTaskStageState")]
	public ETaskStageState ObserveTaskStageState;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("交互行为")]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:InteractorGroupID")]
	public FGsSmartParam InteractorGroupID;

	[UProperty]
	[EditAnywhere]
	[DisplayName("交互步骤")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:InteractionStep")]
	public int InteractionStep;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("拥有物品ID")]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:OwningItemID")]
	public int OwningItemID;

	[UMeta(MDProp.ClampMin, "0")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("拥有物品数量")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:OwningNum")]
	public int OwningNum;

	[EditAnywhere]
	[DisplayName("消耗物品ID")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:ConsumeItemID")]
	public int ConsumeItemID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("消耗物品数量")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:ConsumptionQuantity")]
	public int ConsumptionQuantity;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("注释")]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:Comment")]
	public string Comment;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:NeedObserveTaskStageID")]
	public int NeedObserveTaskStageID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ObserveRoleDataInfo:InteractionGroupID")]
	public int InteractionGroupID;

	private static int ObserveRoleDataInfo_StructSize;

	private static int ObserveRoleDataInfo_IsValid;

	private static bool ObserveType_IsValid;

	private static int ObserveType_Offset;

	private static FFieldAddress ObserveType_PropertyAddress;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	private static bool ObserveTaskStageState_IsValid;

	private static int ObserveTaskStageState_Offset;

	private static FFieldAddress ObserveTaskStageState_PropertyAddress;

	private static bool InteractorGroupID_IsValid;

	private static int InteractorGroupID_Offset;

	private static bool InteractionStep_IsValid;

	private static int InteractionStep_Offset;

	private static bool OwningItemID_IsValid;

	private static int OwningItemID_Offset;

	private static bool OwningNum_IsValid;

	private static int OwningNum_Offset;

	private static bool ConsumeItemID_IsValid;

	private static int ConsumeItemID_Offset;

	private static bool ConsumptionQuantity_IsValid;

	private static int ConsumptionQuantity_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	private static bool NeedObserveTaskStageID_IsValid;

	private static int NeedObserveTaskStageID_Offset;

	private static bool InteractionGroupID_IsValid;

	private static int InteractionGroupID_Offset;

	public FObserveRoleDataInfo Copy()
	{
		return this;
	}

	public static FObserveRoleDataInfo FromNative(IntPtr nativeBuffer)
	{
		return new FObserveRoleDataInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FObserveRoleDataInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FObserveRoleDataInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FObserveRoleDataInfo(IntPtr.Add(nativeBuffer, arrayIndex * ObserveRoleDataInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FObserveRoleDataInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ObserveRoleDataInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ObserveRoleDataInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ObserveRoleDataInfo");
			return;
		}
		EnumMarshaler<ERoleDataType>.ToNative(IntPtr.Add(nativeStruct, ObserveType_Offset), 0, ObserveType_PropertyAddress.Address, ObserveType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<ETaskStageState>.ToNative(IntPtr.Add(nativeStruct, ObserveTaskStageState_Offset), 0, ObserveTaskStageState_PropertyAddress.Address, ObserveTaskStageState);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, InteractorGroupID_Offset), InteractorGroupID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionStep_Offset), InteractionStep);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningItemID_Offset), OwningItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningNum_Offset), OwningNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConsumeItemID_Offset), ConsumeItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConsumptionQuantity_Offset), ConsumptionQuantity);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NeedObserveTaskStageID_Offset), NeedObserveTaskStageID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionGroupID_Offset), InteractionGroupID);
	}

	public FObserveRoleDataInfo(IntPtr nativeStruct)
	{
		if (ObserveRoleDataInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ObserveRoleDataInfo");
			ObserveType = ERoleDataType.None;
			TaskStage = default(FGsSmartParam);
			ObserveTaskStageState = ETaskStageState.Default;
			InteractorGroupID = default(FGsSmartParam);
			InteractionStep = 0;
			OwningItemID = 0;
			OwningNum = 0;
			ConsumeItemID = 0;
			ConsumptionQuantity = 0;
			Comment = null;
			NeedObserveTaskStageID = 0;
			InteractionGroupID = 0;
		}
		else
		{
			ObserveType = EnumMarshaler<ERoleDataType>.FromNative(IntPtr.Add(nativeStruct, ObserveType_Offset), 0, ObserveType_PropertyAddress.Address);
			TaskStage = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			ObserveTaskStageState = EnumMarshaler<ETaskStageState>.FromNative(IntPtr.Add(nativeStruct, ObserveTaskStageState_Offset), 0, ObserveTaskStageState_PropertyAddress.Address);
			InteractorGroupID = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, InteractorGroupID_Offset));
			InteractionStep = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionStep_Offset));
			OwningItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningItemID_Offset));
			OwningNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningNum_Offset));
			ConsumeItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ConsumeItemID_Offset));
			ConsumptionQuantity = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ConsumptionQuantity_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
			NeedObserveTaskStageID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NeedObserveTaskStageID_Offset));
			InteractionGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionGroupID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ObserveRoleDataInfo");
		ObserveRoleDataInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ObserveType_PropertyAddress, intPtr, "ObserveType");
		ObserveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveType");
		ObserveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveType", Classes.FEnumProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ObserveTaskStageState_PropertyAddress, intPtr, "ObserveTaskStageState");
		ObserveTaskStageState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveTaskStageState");
		ObserveTaskStageState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveTaskStageState", Classes.FEnumProperty);
		InteractorGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractorGroupID");
		InteractorGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractorGroupID", Classes.FStructProperty);
		InteractionStep_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionStep");
		InteractionStep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionStep", Classes.FIntProperty);
		OwningItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningItemID");
		OwningItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningItemID", Classes.FIntProperty);
		OwningNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningNum");
		OwningNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningNum", Classes.FIntProperty);
		ConsumeItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConsumeItemID");
		ConsumeItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConsumeItemID", Classes.FIntProperty);
		ConsumptionQuantity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConsumptionQuantity");
		ConsumptionQuantity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConsumptionQuantity", Classes.FIntProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		NeedObserveTaskStageID_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedObserveTaskStageID");
		NeedObserveTaskStageID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedObserveTaskStageID", Classes.FIntProperty);
		InteractionGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionGroupID");
		InteractionGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionGroupID", Classes.FIntProperty);
		ObserveRoleDataInfo_IsValid = ((intPtr != IntPtr.Zero && ObserveType_IsValid && TaskStage_IsValid && ObserveTaskStageState_IsValid && InteractorGroupID_IsValid && InteractionStep_IsValid && OwningItemID_IsValid && OwningNum_IsValid && ConsumeItemID_IsValid && ConsumptionQuantity_IsValid && Comment_IsValid && NeedObserveTaskStageID_IsValid && InteractionGroupID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ObserveRoleDataInfo", (byte)ObserveRoleDataInfo_IsValid != 0);
	}

	static FObserveRoleDataInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FObserveRoleDataInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FObserveRoleDataInfo));
	}
}
