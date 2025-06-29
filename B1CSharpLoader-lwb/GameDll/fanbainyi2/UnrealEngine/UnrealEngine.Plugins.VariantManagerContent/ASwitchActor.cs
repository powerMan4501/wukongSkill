using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/VariantManagerContent.SwitchActor", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public class ASwitchActor : AActor
{
	private static bool SelectOption_IsValid;

	private static IntPtr SelectOption_FunctionAddress;

	private static int SelectOption_ParamsSize;

	private static bool SelectOption_OptionIndex_IsValid;

	private static FFieldAddress SelectOption_OptionIndex_PropertyAddress;

	private static int SelectOption_OptionIndex_Offset;

	private static bool GetSelectedOption_IsValid;

	private static IntPtr GetSelectedOption_FunctionAddress;

	private static int GetSelectedOption_ParamsSize;

	private static bool GetSelectedOption_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedOption_ReturnValue_PropertyAddress;

	private static int GetSelectedOption_ReturnValue_Offset;

	private static bool GetOptions_IsValid;

	private static IntPtr GetOptions_FunctionAddress;

	private static int GetOptions_ParamsSize;

	private static bool GetOptions_ReturnValue_IsValid;

	private static FFieldAddress GetOptions_ReturnValue_PropertyAddress;

	private static int GetOptions_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.SwitchActor:SelectOption")]
	public unsafe void SelectOption(int OptionIndex)
	{
		CheckDestroyed();
		if (!SelectOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.SwitchActor:SelectOption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SelectOption_OptionIndex_Offset), 0, SelectOption_OptionIndex_PropertyAddress.Address, OptionIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectOption_FunctionAddress, intPtr, SelectOption_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.SwitchActor:GetSelectedOption")]
	public unsafe int GetSelectedOption()
	{
		CheckDestroyed();
		if (!GetSelectedOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.SwitchActor:GetSelectedOption");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedOption_FunctionAddress, intPtr, GetSelectedOption_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSelectedOption_ReturnValue_Offset), 0, GetSelectedOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.SwitchActor:GetOptions")]
	public unsafe List<AActor> GetOptions()
	{
		CheckDestroyed();
		if (!GetOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.SwitchActor:GetOptions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOptions_FunctionAddress, intPtr, GetOptions_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetOptions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOptions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOptions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static ASwitchActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASwitchActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASwitchActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/VariantManagerContent.SwitchActor");
		SelectOption_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SelectOption");
		SelectOption_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectOption_OptionIndex_PropertyAddress, SelectOption_FunctionAddress, "OptionIndex");
		SelectOption_OptionIndex_Offset = NativeReflectionCached.GetPropertyOffset(SelectOption_FunctionAddress, "OptionIndex");
		SelectOption_OptionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectOption_FunctionAddress, "OptionIndex", Classes.FIntProperty);
		SelectOption_IsValid = SelectOption_FunctionAddress != IntPtr.Zero && SelectOption_OptionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.SwitchActor:SelectOption", SelectOption_IsValid);
		GetSelectedOption_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSelectedOption");
		GetSelectedOption_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedOption_ReturnValue_PropertyAddress, GetSelectedOption_FunctionAddress, "ReturnValue");
		GetSelectedOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedOption_FunctionAddress, "ReturnValue");
		GetSelectedOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedOption_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSelectedOption_IsValid = GetSelectedOption_FunctionAddress != IntPtr.Zero && GetSelectedOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.SwitchActor:GetSelectedOption", GetSelectedOption_IsValid);
		GetOptions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOptions");
		GetOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOptions_ReturnValue_PropertyAddress, GetOptions_FunctionAddress, "ReturnValue");
		GetOptions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOptions_FunctionAddress, "ReturnValue");
		GetOptions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOptions_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOptions_IsValid = GetOptions_FunctionAddress != IntPtr.Zero && GetOptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.SwitchActor:GetOptions", GetOptions_IsValid);
	}
}
