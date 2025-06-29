using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataValidation;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataValidation.EditorValidatorBase", "DataValidation", UnrealModuleType.EnginePlugin)]
public class UEditorValidatorBase : UObject
{
	private static bool ValidateLoadedAsset_IsValid;

	private IntPtr ValidateLoadedAsset_InstanceFunctionAddress;

	private static IntPtr ValidateLoadedAsset_FunctionAddress;

	private static int ValidateLoadedAsset_ParamsSize;

	private static bool ValidateLoadedAsset_InAsset_IsValid;

	private static FFieldAddress ValidateLoadedAsset_InAsset_PropertyAddress;

	private static int ValidateLoadedAsset_InAsset_Offset;

	private static bool ValidateLoadedAsset_ValidationErrors_IsValid;

	private static FFieldAddress ValidateLoadedAsset_ValidationErrors_PropertyAddress;

	private static int ValidateLoadedAsset_ValidationErrors_Offset;

	private static bool ValidateLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress ValidateLoadedAsset_ReturnValue_PropertyAddress;

	private static int ValidateLoadedAsset_ReturnValue_Offset;

	private static bool GetValidationResult_IsValid;

	private static IntPtr GetValidationResult_FunctionAddress;

	private static int GetValidationResult_ParamsSize;

	private static bool GetValidationResult_ReturnValue_IsValid;

	private static FFieldAddress GetValidationResult_ReturnValue_PropertyAddress;

	private static int GetValidationResult_ReturnValue_Offset;

	private static bool CanValidateAsset_IsValid;

	private IntPtr CanValidateAsset_InstanceFunctionAddress;

	private static IntPtr CanValidateAsset_FunctionAddress;

	private static int CanValidateAsset_ParamsSize;

	private static bool CanValidateAsset_InAsset_IsValid;

	private static FFieldAddress CanValidateAsset_InAsset_PropertyAddress;

	private static int CanValidateAsset_InAsset_Offset;

	private static bool CanValidateAsset_ReturnValue_IsValid;

	private static FFieldAddress CanValidateAsset_ReturnValue_PropertyAddress;

	private static int CanValidateAsset_ReturnValue_Offset;

	private static bool CanValidate_IsValid;

	private IntPtr CanValidate_InstanceFunctionAddress;

	private static IntPtr CanValidate_FunctionAddress;

	private static int CanValidate_ParamsSize;

	private static bool CanValidate_InUsecase_IsValid;

	private static FFieldAddress CanValidate_InUsecase_PropertyAddress;

	private static int CanValidate_InUsecase_Offset;

	private static bool CanValidate_ReturnValue_IsValid;

	private static FFieldAddress CanValidate_ReturnValue_PropertyAddress;

	private static int CanValidate_ReturnValue_Offset;

	private static bool AssetWarning_IsValid;

	private static IntPtr AssetWarning_FunctionAddress;

	private static int AssetWarning_ParamsSize;

	private static bool AssetWarning_InAsset_IsValid;

	private static FFieldAddress AssetWarning_InAsset_PropertyAddress;

	private static int AssetWarning_InAsset_Offset;

	private static bool AssetWarning_InMessage_IsValid;

	private static FFieldAddress AssetWarning_InMessage_PropertyAddress;

	private static int AssetWarning_InMessage_Offset;

	private static bool AssetPasses_IsValid;

	private static IntPtr AssetPasses_FunctionAddress;

	private static int AssetPasses_ParamsSize;

	private static bool AssetPasses_InAsset_IsValid;

	private static FFieldAddress AssetPasses_InAsset_PropertyAddress;

	private static int AssetPasses_InAsset_Offset;

	private static bool AssetFails_IsValid;

	private static IntPtr AssetFails_FunctionAddress;

	private static int AssetFails_ParamsSize;

	private static bool AssetFails_InAsset_IsValid;

	private static FFieldAddress AssetFails_InAsset_PropertyAddress;

	private static int AssetFails_InAsset_Offset;

	private static bool AssetFails_InMessage_IsValid;

	private static FFieldAddress AssetFails_InMessage_PropertyAddress;

	private static int AssetFails_InMessage_Offset;

	private static bool AssetFails_ValidationErrors_IsValid;

	private static FFieldAddress AssetFails_ValidationErrors_PropertyAddress;

	private static int AssetFails_ValidationErrors_Offset;

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:ValidateLoadedAsset")]
	public unsafe EDataValidationResult ValidateLoadedAsset(UObject InAsset, ref List<FText> ValidationErrors)
	{
		CheckDestroyed();
		if (!ValidateLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:ValidateLoadedAsset");
			return EDataValidationResult.Invalid;
		}
		if (ValidateLoadedAsset_InstanceFunctionAddress == IntPtr.Zero)
		{
			ValidateLoadedAsset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ValidateLoadedAsset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidateLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidateLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ValidateLoadedAsset_InAsset_Offset), 0, ValidateLoadedAsset_InAsset_PropertyAddress.Address, InAsset);
		TArrayCopyMarshaler<FText> tArrayCopyMarshaler = new TArrayCopyMarshaler<FText>(1, ValidateLoadedAsset_ValidationErrors_PropertyAddress, CachedMarshalingDelegates<FText, FTextMarshaler>.FromNative, CachedMarshalingDelegates<FText, FTextMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, ValidateLoadedAsset_ValidationErrors_Offset), ValidationErrors);
		NativeReflection.InvokeFunctionOptimized(base.Address, ValidateLoadedAsset_InstanceFunctionAddress, intPtr, ValidateLoadedAsset_ParamsSize);
		ValidationErrors = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, ValidateLoadedAsset_ValidationErrors_Offset));
		NativeReflection.DestroyValue_InContainer(ValidateLoadedAsset_ValidationErrors_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EDataValidationResult>.FromNative(IntPtr.Add(intPtr, ValidateLoadedAsset_ReturnValue_Offset), 0, ValidateLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual EDataValidationResult ValidateLoadedAsset_Implementation(UObject InAsset, ref List<FText> ValidationErrors)
	{
		CheckDestroyed();
		if (!ValidateLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:ValidateLoadedAsset");
			return EDataValidationResult.Invalid;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidateLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidateLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ValidateLoadedAsset_InAsset_Offset), 0, ValidateLoadedAsset_InAsset_PropertyAddress.Address, InAsset);
		TArrayCopyMarshaler<FText> tArrayCopyMarshaler = new TArrayCopyMarshaler<FText>(1, ValidateLoadedAsset_ValidationErrors_PropertyAddress, CachedMarshalingDelegates<FText, FTextMarshaler>.FromNative, CachedMarshalingDelegates<FText, FTextMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, ValidateLoadedAsset_ValidationErrors_Offset), ValidationErrors);
		NativeReflection.InvokeFunctionOptimized(base.Address, ValidateLoadedAsset_FunctionAddress, intPtr, ValidateLoadedAsset_ParamsSize);
		ValidationErrors = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, ValidateLoadedAsset_ValidationErrors_Offset));
		NativeReflection.DestroyValue_InContainer(ValidateLoadedAsset_ValidationErrors_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EDataValidationResult>.FromNative(IntPtr.Add(intPtr, ValidateLoadedAsset_ReturnValue_Offset), 0, ValidateLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:GetValidationResult")]
	public unsafe EDataValidationResult GetValidationResult()
	{
		CheckDestroyed();
		if (!GetValidationResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:GetValidationResult");
			return EDataValidationResult.Invalid;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValidationResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValidationResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValidationResult_FunctionAddress, intPtr, GetValidationResult_ParamsSize);
		return EnumMarshaler<EDataValidationResult>.FromNative(IntPtr.Add(intPtr, GetValidationResult_ReturnValue_Offset), 0, GetValidationResult_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:CanValidateAsset")]
	public unsafe bool CanValidateAsset(UObject InAsset)
	{
		CheckDestroyed();
		if (!CanValidateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:CanValidateAsset");
			return false;
		}
		if (CanValidateAsset_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanValidateAsset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanValidateAsset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanValidateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanValidateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CanValidateAsset_InAsset_Offset), 0, CanValidateAsset_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanValidateAsset_InstanceFunctionAddress, intPtr, CanValidateAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanValidateAsset_ReturnValue_Offset), 0, CanValidateAsset_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanValidateAsset_Implementation(UObject InAsset)
	{
		CheckDestroyed();
		if (!CanValidateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:CanValidateAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanValidateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanValidateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CanValidateAsset_InAsset_Offset), 0, CanValidateAsset_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanValidateAsset_FunctionAddress, intPtr, CanValidateAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanValidateAsset_ReturnValue_Offset), 0, CanValidateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:CanValidate")]
	public unsafe bool CanValidate(EDataValidationUsecase InUsecase)
	{
		CheckDestroyed();
		if (!CanValidate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:CanValidate");
			return false;
		}
		if (CanValidate_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanValidate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanValidate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanValidate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanValidate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDataValidationUsecase>.ToNative(IntPtr.Add(intPtr, CanValidate_InUsecase_Offset), 0, CanValidate_InUsecase_PropertyAddress.Address, InUsecase);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanValidate_InstanceFunctionAddress, intPtr, CanValidate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanValidate_ReturnValue_Offset), 0, CanValidate_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanValidate_Implementation(EDataValidationUsecase InUsecase)
	{
		CheckDestroyed();
		if (!CanValidate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:CanValidate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanValidate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanValidate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDataValidationUsecase>.ToNative(IntPtr.Add(intPtr, CanValidate_InUsecase_Offset), 0, CanValidate_InUsecase_PropertyAddress.Address, InUsecase);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanValidate_FunctionAddress, intPtr, CanValidate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanValidate_ReturnValue_Offset), 0, CanValidate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:AssetWarning")]
	public unsafe void AssetWarning(UObject InAsset, FText InMessage)
	{
		CheckDestroyed();
		if (!AssetWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:AssetWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssetWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssetWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssetWarning_InAsset_Offset), 0, AssetWarning_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InitializeValue_InContainer(AssetWarning_InMessage_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AssetWarning_InMessage_Offset), 0, AssetWarning_InMessage_PropertyAddress.Address, InMessage);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssetWarning_FunctionAddress, intPtr, AssetWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssetWarning_InMessage_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:AssetPasses")]
	public unsafe void AssetPasses(UObject InAsset)
	{
		CheckDestroyed();
		if (!AssetPasses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:AssetPasses");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssetPasses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssetPasses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssetPasses_InAsset_Offset), 0, AssetPasses_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssetPasses_FunctionAddress, intPtr, AssetPasses_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DataValidation.EditorValidatorBase:AssetFails")]
	public unsafe void AssetFails(UObject InAsset, FText InMessage, ref List<FText> ValidationErrors)
	{
		CheckDestroyed();
		if (!AssetFails_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataValidation.EditorValidatorBase:AssetFails");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssetFails_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssetFails_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssetFails_InAsset_Offset), 0, AssetFails_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InitializeValue_InContainer(AssetFails_InMessage_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AssetFails_InMessage_Offset), 0, AssetFails_InMessage_PropertyAddress.Address, InMessage);
		TArrayCopyMarshaler<FText> tArrayCopyMarshaler = new TArrayCopyMarshaler<FText>(1, AssetFails_ValidationErrors_PropertyAddress, CachedMarshalingDelegates<FText, FTextMarshaler>.FromNative, CachedMarshalingDelegates<FText, FTextMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, AssetFails_ValidationErrors_Offset), ValidationErrors);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssetFails_FunctionAddress, intPtr, AssetFails_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssetFails_InMessage_PropertyAddress.Address, intPtr);
		ValidationErrors = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, AssetFails_ValidationErrors_Offset));
		NativeReflection.DestroyValue_InContainer(AssetFails_ValidationErrors_PropertyAddress.Address, intPtr);
	}

	static UEditorValidatorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorValidatorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorValidatorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DataValidation.EditorValidatorBase");
		ValidateLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ValidateLoadedAsset");
		ValidateLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ValidateLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ValidateLoadedAsset_InAsset_PropertyAddress, ValidateLoadedAsset_FunctionAddress, "InAsset");
		ValidateLoadedAsset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(ValidateLoadedAsset_FunctionAddress, "InAsset");
		ValidateLoadedAsset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateLoadedAsset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidateLoadedAsset_ValidationErrors_PropertyAddress, ValidateLoadedAsset_FunctionAddress, "ValidationErrors");
		ValidateLoadedAsset_ValidationErrors_Offset = NativeReflectionCached.GetPropertyOffset(ValidateLoadedAsset_FunctionAddress, "ValidationErrors");
		ValidateLoadedAsset_ValidationErrors_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateLoadedAsset_FunctionAddress, "ValidationErrors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidateLoadedAsset_ReturnValue_PropertyAddress, ValidateLoadedAsset_FunctionAddress, "ReturnValue");
		ValidateLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ValidateLoadedAsset_FunctionAddress, "ReturnValue");
		ValidateLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidateLoadedAsset_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		ValidateLoadedAsset_IsValid = ValidateLoadedAsset_FunctionAddress != IntPtr.Zero && ValidateLoadedAsset_InAsset_IsValid && ValidateLoadedAsset_ValidationErrors_IsValid && ValidateLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:ValidateLoadedAsset", ValidateLoadedAsset_IsValid);
		GetValidationResult_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValidationResult");
		GetValidationResult_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValidationResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValidationResult_ReturnValue_PropertyAddress, GetValidationResult_FunctionAddress, "ReturnValue");
		GetValidationResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValidationResult_FunctionAddress, "ReturnValue");
		GetValidationResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValidationResult_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetValidationResult_IsValid = GetValidationResult_FunctionAddress != IntPtr.Zero && GetValidationResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:GetValidationResult", GetValidationResult_IsValid);
		CanValidateAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanValidateAsset");
		CanValidateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CanValidateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanValidateAsset_InAsset_PropertyAddress, CanValidateAsset_FunctionAddress, "InAsset");
		CanValidateAsset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(CanValidateAsset_FunctionAddress, "InAsset");
		CanValidateAsset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CanValidateAsset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanValidateAsset_ReturnValue_PropertyAddress, CanValidateAsset_FunctionAddress, "ReturnValue");
		CanValidateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanValidateAsset_FunctionAddress, "ReturnValue");
		CanValidateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanValidateAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanValidateAsset_IsValid = CanValidateAsset_FunctionAddress != IntPtr.Zero && CanValidateAsset_InAsset_IsValid && CanValidateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:CanValidateAsset", CanValidateAsset_IsValid);
		CanValidate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanValidate");
		CanValidate_ParamsSize = NativeReflection.GetFunctionParamsSize(CanValidate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanValidate_InUsecase_PropertyAddress, CanValidate_FunctionAddress, "InUsecase");
		CanValidate_InUsecase_Offset = NativeReflectionCached.GetPropertyOffset(CanValidate_FunctionAddress, "InUsecase");
		CanValidate_InUsecase_IsValid = NativeReflectionCached.ValidatePropertyClass(CanValidate_FunctionAddress, "InUsecase", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CanValidate_ReturnValue_PropertyAddress, CanValidate_FunctionAddress, "ReturnValue");
		CanValidate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanValidate_FunctionAddress, "ReturnValue");
		CanValidate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanValidate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanValidate_IsValid = CanValidate_FunctionAddress != IntPtr.Zero && CanValidate_InUsecase_IsValid && CanValidate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:CanValidate", CanValidate_IsValid);
		AssetWarning_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AssetWarning");
		AssetWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(AssetWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssetWarning_InAsset_PropertyAddress, AssetWarning_FunctionAddress, "InAsset");
		AssetWarning_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(AssetWarning_FunctionAddress, "InAsset");
		AssetWarning_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetWarning_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssetWarning_InMessage_PropertyAddress, AssetWarning_FunctionAddress, "InMessage");
		AssetWarning_InMessage_Offset = NativeReflectionCached.GetPropertyOffset(AssetWarning_FunctionAddress, "InMessage");
		AssetWarning_InMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetWarning_FunctionAddress, "InMessage", Classes.FTextProperty);
		AssetWarning_IsValid = AssetWarning_FunctionAddress != IntPtr.Zero && AssetWarning_InAsset_IsValid && AssetWarning_InMessage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:AssetWarning", AssetWarning_IsValid);
		AssetPasses_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AssetPasses");
		AssetPasses_ParamsSize = NativeReflection.GetFunctionParamsSize(AssetPasses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssetPasses_InAsset_PropertyAddress, AssetPasses_FunctionAddress, "InAsset");
		AssetPasses_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(AssetPasses_FunctionAddress, "InAsset");
		AssetPasses_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetPasses_FunctionAddress, "InAsset", Classes.FObjectProperty);
		AssetPasses_IsValid = AssetPasses_FunctionAddress != IntPtr.Zero && AssetPasses_InAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:AssetPasses", AssetPasses_IsValid);
		AssetFails_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AssetFails");
		AssetFails_ParamsSize = NativeReflection.GetFunctionParamsSize(AssetFails_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssetFails_InAsset_PropertyAddress, AssetFails_FunctionAddress, "InAsset");
		AssetFails_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(AssetFails_FunctionAddress, "InAsset");
		AssetFails_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetFails_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssetFails_InMessage_PropertyAddress, AssetFails_FunctionAddress, "InMessage");
		AssetFails_InMessage_Offset = NativeReflectionCached.GetPropertyOffset(AssetFails_FunctionAddress, "InMessage");
		AssetFails_InMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetFails_FunctionAddress, "InMessage", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AssetFails_ValidationErrors_PropertyAddress, AssetFails_FunctionAddress, "ValidationErrors");
		AssetFails_ValidationErrors_Offset = NativeReflectionCached.GetPropertyOffset(AssetFails_FunctionAddress, "ValidationErrors");
		AssetFails_ValidationErrors_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetFails_FunctionAddress, "ValidationErrors", Classes.FArrayProperty);
		AssetFails_IsValid = AssetFails_FunctionAddress != IntPtr.Zero && AssetFails_InAsset_IsValid && AssetFails_InMessage_IsValid && AssetFails_ValidationErrors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataValidation.EditorValidatorBase:AssetFails", AssetFails_IsValid);
	}
}
