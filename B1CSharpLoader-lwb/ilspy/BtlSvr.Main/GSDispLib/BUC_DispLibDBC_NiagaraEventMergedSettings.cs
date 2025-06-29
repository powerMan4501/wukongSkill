using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings")]
public struct BUC_DispLibDBC_NiagaraEventMergedSettings
{
	[DisplayName("Enable")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:Enable")]
	public bool Enable;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("预估数量")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[UMeta(MD.ToolTip, "此特效最多可能的同屏数量，提供比较合理的预估数量可以减少GC。即使不配置此参数也不会影响实际画面表现")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:PerCreateCount")]
	public int PerCreateCount;

	[UMeta(MD.ToolTip, "如果子弹或法术场是没有旋转变化的，可以不勾选此项，能减少每帧与MgrSystem通信和刷新渲染状态的消耗")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[DisplayName("发送旋转信息")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:SendRotationInfo")]
	public bool SendRotationInfo;

	[DisplayName("创建时发送缩放信息")]
	[UMeta(MD.ToolTip, "默认缩放是1，绝大多数情况下可以不勾选此项，能减少每帧与MgrSystem通信和刷新渲染状态的消耗")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:SendScaleInfo")]
	public bool SendScaleInfo;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("每帧发送缩放信息")]
	[UMeta(MDProp.EditCondition, "Enable && SendScaleInfo")]
	[UMeta(MD.ToolTip, "绝大多数情况下可以不勾选此项，除非确定特效Attach的目标Comp的缩放真的会每帧变化，这种情况极少")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:SendScaleEveryTick")]
	public bool SendScaleEveryTick;

	[UMeta(MD.ToolTip, "不勾选此项，任何SetCustomVectorData请求不会传递给Mgr")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("需接收CustomVector")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:HasCustomVectorParam")]
	public bool HasCustomVectorParam;

	[UMeta(MDProp.EditCondition, "Enable && HasCustomVectorParam")]
	[DisplayName("CustomVector参数名映射")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.ToolTip, "不勾选此项，任何SetCustomVectorData请求不会传递给Mgr")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:CustomVectorParamNameMap")]
	public Dictionary<FName, FName> CustomVectorParamNameMap;

	[UMeta(MDProp.EditCondition, "Enable")]
	[BlueprintReadWrite]
	[DisplayName("合并为")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings:MergeMangerSystem")]
	public UNiagaraSystem MergeMangerSystem;

	private static int BUC_DispLibDBC_NiagaraEventMergedSettings_StructSize;

	private static int BUC_DispLibDBC_NiagaraEventMergedSettings_IsValid;

	private static bool Enable_IsValid;

	private static int Enable_Offset;

	private static FFieldAddress Enable_PropertyAddress;

	private static bool PerCreateCount_IsValid;

	private static int PerCreateCount_Offset;

	private static bool SendRotationInfo_IsValid;

	private static int SendRotationInfo_Offset;

	private static FFieldAddress SendRotationInfo_PropertyAddress;

	private static bool SendScaleInfo_IsValid;

	private static int SendScaleInfo_Offset;

	private static FFieldAddress SendScaleInfo_PropertyAddress;

	private static bool SendScaleEveryTick_IsValid;

	private static int SendScaleEveryTick_Offset;

	private static FFieldAddress SendScaleEveryTick_PropertyAddress;

	private static bool HasCustomVectorParam_IsValid;

	private static int HasCustomVectorParam_Offset;

	private static FFieldAddress HasCustomVectorParam_PropertyAddress;

	private static bool CustomVectorParamNameMap_IsValid;

	private static int CustomVectorParamNameMap_Offset;

	private static FFieldAddress CustomVectorParamNameMap_PropertyAddress;

	private static bool MergeMangerSystem_IsValid;

	private static int MergeMangerSystem_Offset;

	public BUC_DispLibDBC_NiagaraEventMergedSettings Copy()
	{
		BUC_DispLibDBC_NiagaraEventMergedSettings result = this;
		if (CustomVectorParamNameMap != null)
		{
			result.CustomVectorParamNameMap = new Dictionary<FName, FName>(CustomVectorParamNameMap);
		}
		return result;
	}

	public static BUC_DispLibDBC_NiagaraEventMergedSettings FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_NiagaraEventMergedSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_NiagaraEventMergedSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_NiagaraEventMergedSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_NiagaraEventMergedSettings(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_NiagaraEventMergedSettings_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_NiagaraEventMergedSettings value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_NiagaraEventMergedSettings_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_NiagaraEventMergedSettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address, Enable);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PerCreateCount_Offset), PerCreateCount);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SendRotationInfo_Offset), 0, SendRotationInfo_PropertyAddress.Address, SendRotationInfo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SendScaleInfo_Offset), 0, SendScaleInfo_PropertyAddress.Address, SendScaleInfo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SendScaleEveryTick_Offset), 0, SendScaleEveryTick_PropertyAddress.Address, SendScaleEveryTick);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasCustomVectorParam_Offset), 0, HasCustomVectorParam_PropertyAddress.Address, HasCustomVectorParam);
		new TMapCopyMarshaler<FName, FName>(1, CustomVectorParamNameMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CustomVectorParamNameMap_Offset), CustomVectorParamNameMap);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, MergeMangerSystem_Offset), MergeMangerSystem);
	}

	public BUC_DispLibDBC_NiagaraEventMergedSettings(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_NiagaraEventMergedSettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings");
			Enable = false;
			PerCreateCount = 0;
			SendRotationInfo = false;
			SendScaleInfo = false;
			SendScaleEveryTick = false;
			HasCustomVectorParam = false;
			CustomVectorParamNameMap = null;
			MergeMangerSystem = null;
		}
		else
		{
			Enable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address);
			PerCreateCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PerCreateCount_Offset));
			SendRotationInfo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SendRotationInfo_Offset), 0, SendRotationInfo_PropertyAddress.Address);
			SendScaleInfo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SendScaleInfo_Offset), 0, SendScaleInfo_PropertyAddress.Address);
			SendScaleEveryTick = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SendScaleEveryTick_Offset), 0, SendScaleEveryTick_PropertyAddress.Address);
			HasCustomVectorParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasCustomVectorParam_Offset), 0, HasCustomVectorParam_PropertyAddress.Address);
			CustomVectorParamNameMap = new TMapCopyMarshaler<FName, FName>(1, CustomVectorParamNameMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CustomVectorParamNameMap_Offset));
			MergeMangerSystem = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, MergeMangerSystem_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings");
		BUC_DispLibDBC_NiagaraEventMergedSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "Enable");
		Enable_Offset = NativeReflection.GetPropertyOffset(intPtr, "Enable");
		Enable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Enable", Classes.FBoolProperty);
		PerCreateCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "PerCreateCount");
		PerCreateCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PerCreateCount", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SendRotationInfo_PropertyAddress, intPtr, "SendRotationInfo");
		SendRotationInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "SendRotationInfo");
		SendRotationInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SendRotationInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SendScaleInfo_PropertyAddress, intPtr, "SendScaleInfo");
		SendScaleInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "SendScaleInfo");
		SendScaleInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SendScaleInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SendScaleEveryTick_PropertyAddress, intPtr, "SendScaleEveryTick");
		SendScaleEveryTick_Offset = NativeReflection.GetPropertyOffset(intPtr, "SendScaleEveryTick");
		SendScaleEveryTick_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SendScaleEveryTick", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HasCustomVectorParam_PropertyAddress, intPtr, "HasCustomVectorParam");
		HasCustomVectorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "HasCustomVectorParam");
		HasCustomVectorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HasCustomVectorParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CustomVectorParamNameMap_PropertyAddress, intPtr, "CustomVectorParamNameMap");
		CustomVectorParamNameMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomVectorParamNameMap");
		CustomVectorParamNameMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomVectorParamNameMap", Classes.FMapProperty);
		MergeMangerSystem_Offset = NativeReflection.GetPropertyOffset(intPtr, "MergeMangerSystem");
		MergeMangerSystem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MergeMangerSystem", Classes.FObjectProperty);
		BUC_DispLibDBC_NiagaraEventMergedSettings_IsValid = ((intPtr != IntPtr.Zero && Enable_IsValid && PerCreateCount_IsValid && SendRotationInfo_IsValid && SendScaleInfo_IsValid && SendScaleEveryTick_IsValid && HasCustomVectorParam_IsValid && CustomVectorParamNameMap_IsValid && MergeMangerSystem_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventMergedSettings", (byte)BUC_DispLibDBC_NiagaraEventMergedSettings_IsValid != 0);
	}

	static BUC_DispLibDBC_NiagaraEventMergedSettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_NiagaraEventMergedSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_NiagaraEventMergedSettings));
	}
}
