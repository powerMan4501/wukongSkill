using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/VariantManagerContent.PropertyValue", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public class UPropertyValue : UObject
{
	private static bool HasRecordedData_IsValid;

	private static IntPtr HasRecordedData_FunctionAddress;

	private static int HasRecordedData_ParamsSize;

	private static bool HasRecordedData_ReturnValue_IsValid;

	private static FFieldAddress HasRecordedData_ReturnValue_PropertyAddress;

	private static int HasRecordedData_ReturnValue_Offset;

	private static bool GetPropertyTooltip_IsValid;

	private static IntPtr GetPropertyTooltip_FunctionAddress;

	private static int GetPropertyTooltip_ParamsSize;

	private static bool GetPropertyTooltip_ReturnValue_IsValid;

	private static FFieldAddress GetPropertyTooltip_ReturnValue_PropertyAddress;

	private static int GetPropertyTooltip_ReturnValue_Offset;

	private static bool GetFullDisplayString_IsValid;

	private static IntPtr GetFullDisplayString_FunctionAddress;

	private static int GetFullDisplayString_ParamsSize;

	private static bool GetFullDisplayString_ReturnValue_IsValid;

	private static FFieldAddress GetFullDisplayString_ReturnValue_PropertyAddress;

	private static int GetFullDisplayString_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.PropertyValue:HasRecordedData")]
	public unsafe bool HasRecordedData()
	{
		CheckDestroyed();
		if (!HasRecordedData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.PropertyValue:HasRecordedData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasRecordedData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasRecordedData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasRecordedData_FunctionAddress, intPtr, HasRecordedData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasRecordedData_ReturnValue_Offset), 0, HasRecordedData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.PropertyValue:GetPropertyTooltip")]
	public unsafe string GetPropertyTooltip()
	{
		CheckDestroyed();
		if (!GetPropertyTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.PropertyValue:GetPropertyTooltip");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPropertyTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPropertyTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPropertyTooltip_FunctionAddress, intPtr, GetPropertyTooltip_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetPropertyTooltip_ReturnValue_Offset), 0, GetPropertyTooltip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetPropertyTooltip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.PropertyValue:GetFullDisplayString")]
	public unsafe string GetFullDisplayString()
	{
		CheckDestroyed();
		if (!GetFullDisplayString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.PropertyValue:GetFullDisplayString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFullDisplayString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFullDisplayString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFullDisplayString_FunctionAddress, intPtr, GetFullDisplayString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFullDisplayString_ReturnValue_Offset), 0, GetFullDisplayString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFullDisplayString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UPropertyValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPropertyValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPropertyValue));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/VariantManagerContent.PropertyValue");
		HasRecordedData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasRecordedData");
		HasRecordedData_ParamsSize = NativeReflection.GetFunctionParamsSize(HasRecordedData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasRecordedData_ReturnValue_PropertyAddress, HasRecordedData_FunctionAddress, "ReturnValue");
		HasRecordedData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasRecordedData_FunctionAddress, "ReturnValue");
		HasRecordedData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasRecordedData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasRecordedData_IsValid = HasRecordedData_FunctionAddress != IntPtr.Zero && HasRecordedData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.PropertyValue:HasRecordedData", HasRecordedData_IsValid);
		GetPropertyTooltip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPropertyTooltip");
		GetPropertyTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPropertyTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyTooltip_ReturnValue_PropertyAddress, GetPropertyTooltip_FunctionAddress, "ReturnValue");
		GetPropertyTooltip_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyTooltip_FunctionAddress, "ReturnValue");
		GetPropertyTooltip_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyTooltip_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetPropertyTooltip_IsValid = GetPropertyTooltip_FunctionAddress != IntPtr.Zero && GetPropertyTooltip_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.PropertyValue:GetPropertyTooltip", GetPropertyTooltip_IsValid);
		GetFullDisplayString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFullDisplayString");
		GetFullDisplayString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFullDisplayString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFullDisplayString_ReturnValue_PropertyAddress, GetFullDisplayString_FunctionAddress, "ReturnValue");
		GetFullDisplayString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFullDisplayString_FunctionAddress, "ReturnValue");
		GetFullDisplayString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFullDisplayString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFullDisplayString_IsValid = GetFullDisplayString_FunctionAddress != IntPtr.Zero && GetFullDisplayString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.PropertyValue:GetFullDisplayString", GetFullDisplayString_IsValid);
	}
}
