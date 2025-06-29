using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2")]
public struct FInputMappingContextConfigV2
{
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("按键映射")]
	[Category("基础信息")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:InputMappingContext")]
	public UInputMappingContext InputMappingContext;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("优先级")]
	[Category("基础信息")]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:Priority")]
	public int Priority;

	[Category("基础信息")]
	[DisplayName("触发优先级")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:TriggerPriority")]
	public int TriggerPriority;

	[EditAnywhere]
	[Category("基础信息")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("相关Context触发时修改优先级")]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:TriggerContextTags")]
	public List<EInputMappingContextTagV2> TriggerContextTags;

	[UProperty]
	[Category("注册信息")]
	[DisplayName("生效的输入模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:InputMode")]
	public EInputMappingContextMode InputMode;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("游戏开始时自动初始化")]
	[Category("注册信息")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:IsInitLoading")]
	public bool IsInitLoading;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("忽略Block请求")]
	[Category("注册信息")]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:IsIgnoreBlockRequest")]
	public bool IsIgnoreBlockRequest;

	[Category("注册信息")]
	[UProperty]
	[DisplayName("关卡信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:LevelInfo")]
	public FInputMappingContextLevelInfo LevelInfo;

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否常驻，不会被Override")]
	[ShortTooltip("如果没勾，那么按键映射的自定义类型为默认的自定义按键类型；如果勾了，那么没有自定义类型，永远会考虑注册")]
	[Category("按键自定义信息")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:IsPermanent")]
	public bool IsPermanent;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("按键自定义Override配置")]
	[Category("按键自定义信息")]
	[USharpPath("/Script/b1-Managed.InputMappingContextConfigV2:CustomizedInputOverrideConfigs")]
	public Dictionary<ECustomizedInputType, FCustomizedInputOverrideConfig> CustomizedInputOverrideConfigs;

	private static int InputMappingContextConfigV2_StructSize;

	private static int InputMappingContextConfigV2_IsValid;

	private static bool InputMappingContext_IsValid;

	private static int InputMappingContext_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool TriggerPriority_IsValid;

	private static int TriggerPriority_Offset;

	private static bool TriggerContextTags_IsValid;

	private static int TriggerContextTags_Offset;

	private static FFieldAddress TriggerContextTags_PropertyAddress;

	private static bool InputMode_IsValid;

	private static int InputMode_Offset;

	private static FFieldAddress InputMode_PropertyAddress;

	private static bool IsInitLoading_IsValid;

	private static int IsInitLoading_Offset;

	private static FFieldAddress IsInitLoading_PropertyAddress;

	private static bool IsIgnoreBlockRequest_IsValid;

	private static int IsIgnoreBlockRequest_Offset;

	private static FFieldAddress IsIgnoreBlockRequest_PropertyAddress;

	private static bool LevelInfo_IsValid;

	private static int LevelInfo_Offset;

	private static bool IsPermanent_IsValid;

	private static int IsPermanent_Offset;

	private static FFieldAddress IsPermanent_PropertyAddress;

	private static bool CustomizedInputOverrideConfigs_IsValid;

	private static int CustomizedInputOverrideConfigs_Offset;

	private static FFieldAddress CustomizedInputOverrideConfigs_PropertyAddress;

	public FInputMappingContextConfigV2 Copy()
	{
		FInputMappingContextConfigV2 result = this;
		if (TriggerContextTags != null)
		{
			result.TriggerContextTags = new List<EInputMappingContextTagV2>(TriggerContextTags);
		}
		if (CustomizedInputOverrideConfigs != null)
		{
			result.CustomizedInputOverrideConfigs = new Dictionary<ECustomizedInputType, FCustomizedInputOverrideConfig>(CustomizedInputOverrideConfigs);
		}
		return result;
	}

	public static FInputMappingContextConfigV2 FromNative(IntPtr nativeBuffer)
	{
		return new FInputMappingContextConfigV2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputMappingContextConfigV2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputMappingContextConfigV2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputMappingContextConfigV2(IntPtr.Add(nativeBuffer, arrayIndex * InputMappingContextConfigV2_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputMappingContextConfigV2 value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputMappingContextConfigV2_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputMappingContextConfigV2_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputMappingContextConfigV2");
			return;
		}
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(nativeStruct, InputMappingContext_Offset), InputMappingContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerPriority_Offset), TriggerPriority);
		new TArrayCopyMarshaler<EInputMappingContextTagV2>(1, TriggerContextTags_PropertyAddress, CachedMarshalingDelegates<EInputMappingContextTagV2, EnumMarshaler<EInputMappingContextTagV2>>.FromNative, CachedMarshalingDelegates<EInputMappingContextTagV2, EnumMarshaler<EInputMappingContextTagV2>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerContextTags_Offset), TriggerContextTags);
		EnumMarshaler<EInputMappingContextMode>.ToNative(IntPtr.Add(nativeStruct, InputMode_Offset), 0, InputMode_PropertyAddress.Address, InputMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsInitLoading_Offset), 0, IsInitLoading_PropertyAddress.Address, IsInitLoading);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsIgnoreBlockRequest_Offset), 0, IsIgnoreBlockRequest_PropertyAddress.Address, IsIgnoreBlockRequest);
		FInputMappingContextLevelInfo.ToNative(IntPtr.Add(nativeStruct, LevelInfo_Offset), LevelInfo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsPermanent_Offset), 0, IsPermanent_PropertyAddress.Address, IsPermanent);
		new TMapCopyMarshaler<ECustomizedInputType, FCustomizedInputOverrideConfig>(1, CustomizedInputOverrideConfigs_PropertyAddress, CachedMarshalingDelegates<ECustomizedInputType, EnumMarshaler<ECustomizedInputType>>.FromNative, CachedMarshalingDelegates<ECustomizedInputType, EnumMarshaler<ECustomizedInputType>>.ToNative, CachedMarshalingDelegates<FCustomizedInputOverrideConfig, FCustomizedInputOverrideConfig>.FromNative, CachedMarshalingDelegates<FCustomizedInputOverrideConfig, FCustomizedInputOverrideConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, CustomizedInputOverrideConfigs_Offset), CustomizedInputOverrideConfigs);
	}

	public FInputMappingContextConfigV2(IntPtr nativeStruct)
	{
		if (InputMappingContextConfigV2_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputMappingContextConfigV2");
			InputMappingContext = null;
			Priority = 0;
			TriggerPriority = 0;
			TriggerContextTags = null;
			InputMode = EInputMappingContextMode.UIOnly;
			IsInitLoading = false;
			IsIgnoreBlockRequest = false;
			LevelInfo = default(FInputMappingContextLevelInfo);
			IsPermanent = false;
			CustomizedInputOverrideConfigs = null;
		}
		else
		{
			InputMappingContext = UObjectMarshaler<UInputMappingContext>.FromNative(IntPtr.Add(nativeStruct, InputMappingContext_Offset));
			Priority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
			TriggerPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerPriority_Offset));
			TriggerContextTags = new TArrayCopyMarshaler<EInputMappingContextTagV2>(1, TriggerContextTags_PropertyAddress, CachedMarshalingDelegates<EInputMappingContextTagV2, EnumMarshaler<EInputMappingContextTagV2>>.FromNative, CachedMarshalingDelegates<EInputMappingContextTagV2, EnumMarshaler<EInputMappingContextTagV2>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerContextTags_Offset));
			InputMode = EnumMarshaler<EInputMappingContextMode>.FromNative(IntPtr.Add(nativeStruct, InputMode_Offset), 0, InputMode_PropertyAddress.Address);
			IsInitLoading = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsInitLoading_Offset), 0, IsInitLoading_PropertyAddress.Address);
			IsIgnoreBlockRequest = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsIgnoreBlockRequest_Offset), 0, IsIgnoreBlockRequest_PropertyAddress.Address);
			LevelInfo = FInputMappingContextLevelInfo.FromNative(IntPtr.Add(nativeStruct, LevelInfo_Offset));
			IsPermanent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsPermanent_Offset), 0, IsPermanent_PropertyAddress.Address);
			CustomizedInputOverrideConfigs = new TMapCopyMarshaler<ECustomizedInputType, FCustomizedInputOverrideConfig>(1, CustomizedInputOverrideConfigs_PropertyAddress, CachedMarshalingDelegates<ECustomizedInputType, EnumMarshaler<ECustomizedInputType>>.FromNative, CachedMarshalingDelegates<ECustomizedInputType, EnumMarshaler<ECustomizedInputType>>.ToNative, CachedMarshalingDelegates<FCustomizedInputOverrideConfig, FCustomizedInputOverrideConfig>.FromNative, CachedMarshalingDelegates<FCustomizedInputOverrideConfig, FCustomizedInputOverrideConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, CustomizedInputOverrideConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputMappingContextConfigV2");
		InputMappingContextConfigV2_StructSize = NativeReflection.GetStructSize(intPtr);
		InputMappingContext_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputMappingContext");
		InputMappingContext_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputMappingContext", Classes.FObjectProperty);
		Priority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		TriggerPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerPriority");
		TriggerPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerPriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TriggerContextTags_PropertyAddress, intPtr, "TriggerContextTags");
		TriggerContextTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerContextTags");
		TriggerContextTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerContextTags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref InputMode_PropertyAddress, intPtr, "InputMode");
		InputMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputMode");
		InputMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsInitLoading_PropertyAddress, intPtr, "IsInitLoading");
		IsInitLoading_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsInitLoading");
		IsInitLoading_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsInitLoading", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsIgnoreBlockRequest_PropertyAddress, intPtr, "IsIgnoreBlockRequest");
		IsIgnoreBlockRequest_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsIgnoreBlockRequest");
		IsIgnoreBlockRequest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsIgnoreBlockRequest", Classes.FBoolProperty);
		LevelInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelInfo");
		LevelInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsPermanent_PropertyAddress, intPtr, "IsPermanent");
		IsPermanent_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsPermanent");
		IsPermanent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsPermanent", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CustomizedInputOverrideConfigs_PropertyAddress, intPtr, "CustomizedInputOverrideConfigs");
		CustomizedInputOverrideConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomizedInputOverrideConfigs");
		CustomizedInputOverrideConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomizedInputOverrideConfigs", Classes.FMapProperty);
		InputMappingContextConfigV2_IsValid = ((intPtr != IntPtr.Zero && InputMappingContext_IsValid && Priority_IsValid && TriggerPriority_IsValid && TriggerContextTags_IsValid && InputMode_IsValid && IsInitLoading_IsValid && IsIgnoreBlockRequest_IsValid && LevelInfo_IsValid && IsPermanent_IsValid && CustomizedInputOverrideConfigs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputMappingContextConfigV2", (byte)InputMappingContextConfigV2_IsValid != 0);
	}

	static FInputMappingContextConfigV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputMappingContextConfigV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputMappingContextConfigV2));
	}
}
