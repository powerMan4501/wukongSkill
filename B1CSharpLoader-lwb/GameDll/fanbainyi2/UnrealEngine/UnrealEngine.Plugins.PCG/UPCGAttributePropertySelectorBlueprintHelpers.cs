using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGAttributePropertySelectorBlueprintHelpers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetPointProperty_IsValid;

	private static IntPtr SetPointProperty_FunctionAddress;

	private static int SetPointProperty_ParamsSize;

	private static bool SetPointProperty_Selector_IsValid;

	private static FFieldAddress SetPointProperty_Selector_PropertyAddress;

	private static int SetPointProperty_Selector_Offset;

	private static bool SetPointProperty_InPointProperty_IsValid;

	private static FFieldAddress SetPointProperty_InPointProperty_PropertyAddress;

	private static int SetPointProperty_InPointProperty_Offset;

	private static bool SetPointProperty_ReturnValue_IsValid;

	private static FFieldAddress SetPointProperty_ReturnValue_PropertyAddress;

	private static int SetPointProperty_ReturnValue_Offset;

	private static bool SetExtraProperty_IsValid;

	private static IntPtr SetExtraProperty_FunctionAddress;

	private static int SetExtraProperty_ParamsSize;

	private static bool SetExtraProperty_Selector_IsValid;

	private static FFieldAddress SetExtraProperty_Selector_PropertyAddress;

	private static int SetExtraProperty_Selector_Offset;

	private static bool SetExtraProperty_InExtraProperty_IsValid;

	private static FFieldAddress SetExtraProperty_InExtraProperty_PropertyAddress;

	private static int SetExtraProperty_InExtraProperty_Offset;

	private static bool SetExtraProperty_ReturnValue_IsValid;

	private static FFieldAddress SetExtraProperty_ReturnValue_PropertyAddress;

	private static int SetExtraProperty_ReturnValue_Offset;

	private static bool SetAttributeName_IsValid;

	private static IntPtr SetAttributeName_FunctionAddress;

	private static int SetAttributeName_ParamsSize;

	private static bool SetAttributeName_Selector_IsValid;

	private static FFieldAddress SetAttributeName_Selector_PropertyAddress;

	private static int SetAttributeName_Selector_Offset;

	private static bool SetAttributeName_InAttributeName_IsValid;

	private static FFieldAddress SetAttributeName_InAttributeName_PropertyAddress;

	private static int SetAttributeName_InAttributeName_Offset;

	private static bool SetAttributeName_ReturnValue_IsValid;

	private static FFieldAddress SetAttributeName_ReturnValue_PropertyAddress;

	private static int SetAttributeName_ReturnValue_Offset;

	private static bool GetSelection_IsValid;

	private static IntPtr GetSelection_FunctionAddress;

	private static int GetSelection_ParamsSize;

	private static bool GetSelection_Selector_IsValid;

	private static FFieldAddress GetSelection_Selector_PropertyAddress;

	private static int GetSelection_Selector_Offset;

	private static bool GetSelection_ReturnValue_IsValid;

	private static FFieldAddress GetSelection_ReturnValue_PropertyAddress;

	private static int GetSelection_ReturnValue_Offset;

	private static bool GetPointProperty_IsValid;

	private static IntPtr GetPointProperty_FunctionAddress;

	private static int GetPointProperty_ParamsSize;

	private static bool GetPointProperty_Selector_IsValid;

	private static FFieldAddress GetPointProperty_Selector_PropertyAddress;

	private static int GetPointProperty_Selector_Offset;

	private static bool GetPointProperty_ReturnValue_IsValid;

	private static FFieldAddress GetPointProperty_ReturnValue_PropertyAddress;

	private static int GetPointProperty_ReturnValue_Offset;

	private static bool GetName_IsValid;

	private static IntPtr GetName_FunctionAddress;

	private static int GetName_ParamsSize;

	private static bool GetName_Selector_IsValid;

	private static FFieldAddress GetName_Selector_PropertyAddress;

	private static int GetName_Selector_Offset;

	private static bool GetName_ReturnValue_IsValid;

	private static FFieldAddress GetName_ReturnValue_PropertyAddress;

	private static int GetName_ReturnValue_Offset;

	private static bool GetExtraProperty_IsValid;

	private static IntPtr GetExtraProperty_FunctionAddress;

	private static int GetExtraProperty_ParamsSize;

	private static bool GetExtraProperty_Selector_IsValid;

	private static FFieldAddress GetExtraProperty_Selector_PropertyAddress;

	private static int GetExtraProperty_Selector_Offset;

	private static bool GetExtraProperty_ReturnValue_IsValid;

	private static FFieldAddress GetExtraProperty_ReturnValue_PropertyAddress;

	private static int GetExtraProperty_ReturnValue_Offset;

	private static bool GetExtraNames_IsValid;

	private static IntPtr GetExtraNames_FunctionAddress;

	private static int GetExtraNames_ParamsSize;

	private static bool GetExtraNames_Selector_IsValid;

	private static FFieldAddress GetExtraNames_Selector_PropertyAddress;

	private static int GetExtraNames_Selector_Offset;

	private static bool GetExtraNames_ReturnValue_IsValid;

	private static FFieldAddress GetExtraNames_ReturnValue_PropertyAddress;

	private static int GetExtraNames_ReturnValue_Offset;

	private static bool GetAttributeName_IsValid;

	private static IntPtr GetAttributeName_FunctionAddress;

	private static int GetAttributeName_ParamsSize;

	private static bool GetAttributeName_Selector_IsValid;

	private static FFieldAddress GetAttributeName_Selector_PropertyAddress;

	private static int GetAttributeName_Selector_Offset;

	private static bool GetAttributeName_ReturnValue_IsValid;

	private static FFieldAddress GetAttributeName_ReturnValue_PropertyAddress;

	private static int GetAttributeName_ReturnValue_Offset;

	private static bool CopyAndFixSource_IsValid;

	private static IntPtr CopyAndFixSource_FunctionAddress;

	private static int CopyAndFixSource_ParamsSize;

	private static bool CopyAndFixSource_Selector_IsValid;

	private static FFieldAddress CopyAndFixSource_Selector_PropertyAddress;

	private static int CopyAndFixSource_Selector_Offset;

	private static bool CopyAndFixSource_InSelector_IsValid;

	private static FFieldAddress CopyAndFixSource_InSelector_PropertyAddress;

	private static int CopyAndFixSource_InSelector_Offset;

	private static bool CopyAndFixSource_ReturnValue_IsValid;

	private static FFieldAddress CopyAndFixSource_ReturnValue_PropertyAddress;

	private static int CopyAndFixSource_ReturnValue_Offset;

	private static bool CopyAndFixLast_IsValid;

	private static IntPtr CopyAndFixLast_FunctionAddress;

	private static int CopyAndFixLast_ParamsSize;

	private static bool CopyAndFixLast_Selector_IsValid;

	private static FFieldAddress CopyAndFixLast_Selector_PropertyAddress;

	private static int CopyAndFixLast_Selector_Offset;

	private static bool CopyAndFixLast_InData_IsValid;

	private static FFieldAddress CopyAndFixLast_InData_PropertyAddress;

	private static int CopyAndFixLast_InData_Offset;

	private static bool CopyAndFixLast_ReturnValue_IsValid;

	private static FFieldAddress CopyAndFixLast_ReturnValue_PropertyAddress;

	private static int CopyAndFixLast_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetPointProperty")]
	public unsafe static bool SetPointProperty(ref FPCGAttributePropertySelector Selector, EPCGPointProperties InPointProperty)
	{
		if (!SetPointProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetPointProperty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPointProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPointProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPointProperty_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, SetPointProperty_Selector_Offset), 0, SetPointProperty_Selector_PropertyAddress.Address, Selector);
		EnumMarshaler<EPCGPointProperties>.ToNative(IntPtr.Add(intPtr, SetPointProperty_InPointProperty_Offset), 0, SetPointProperty_InPointProperty_PropertyAddress.Address, InPointProperty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPointProperty_FunctionAddress, intPtr, SetPointProperty_ParamsSize);
		Selector = FPCGAttributePropertySelector.FromNative(IntPtr.Add(intPtr, SetPointProperty_Selector_Offset), 0, SetPointProperty_Selector_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetPointProperty_Selector_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetPointProperty_ReturnValue_Offset), 0, SetPointProperty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetExtraProperty")]
	public unsafe static bool SetExtraProperty(ref FPCGAttributePropertySelector Selector, EPCGExtraProperties InExtraProperty)
	{
		if (!SetExtraProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetExtraProperty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExtraProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExtraProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetExtraProperty_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, SetExtraProperty_Selector_Offset), 0, SetExtraProperty_Selector_PropertyAddress.Address, Selector);
		EnumMarshaler<EPCGExtraProperties>.ToNative(IntPtr.Add(intPtr, SetExtraProperty_InExtraProperty_Offset), 0, SetExtraProperty_InExtraProperty_PropertyAddress.Address, InExtraProperty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetExtraProperty_FunctionAddress, intPtr, SetExtraProperty_ParamsSize);
		Selector = FPCGAttributePropertySelector.FromNative(IntPtr.Add(intPtr, SetExtraProperty_Selector_Offset), 0, SetExtraProperty_Selector_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetExtraProperty_Selector_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetExtraProperty_ReturnValue_Offset), 0, SetExtraProperty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetAttributeName")]
	public unsafe static bool SetAttributeName(ref FPCGAttributePropertySelector Selector, FName InAttributeName)
	{
		if (!SetAttributeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetAttributeName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttributeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttributeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAttributeName_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, SetAttributeName_Selector_Offset), 0, SetAttributeName_Selector_PropertyAddress.Address, Selector);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAttributeName_InAttributeName_Offset), 0, SetAttributeName_InAttributeName_PropertyAddress.Address, InAttributeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAttributeName_FunctionAddress, intPtr, SetAttributeName_ParamsSize);
		Selector = FPCGAttributePropertySelector.FromNative(IntPtr.Add(intPtr, SetAttributeName_Selector_Offset), 0, SetAttributeName_Selector_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAttributeName_Selector_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAttributeName_ReturnValue_Offset), 0, SetAttributeName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetSelection")]
	public unsafe static EPCGAttributePropertySelection GetSelection(FPCGAttributePropertySelector Selector)
	{
		if (!GetSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetSelection");
			return EPCGAttributePropertySelection.Attribute;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSelection_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, GetSelection_Selector_Offset), 0, GetSelection_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelection_FunctionAddress, intPtr, GetSelection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSelection_Selector_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPCGAttributePropertySelection>.FromNative(IntPtr.Add(intPtr, GetSelection_ReturnValue_Offset), 0, GetSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetPointProperty")]
	public unsafe static EPCGPointProperties GetPointProperty(FPCGAttributePropertySelector Selector)
	{
		if (!GetPointProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetPointProperty");
			return EPCGPointProperties.Density;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPointProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPointProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPointProperty_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, GetPointProperty_Selector_Offset), 0, GetPointProperty_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPointProperty_FunctionAddress, intPtr, GetPointProperty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPointProperty_Selector_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPCGPointProperties>.FromNative(IntPtr.Add(intPtr, GetPointProperty_ReturnValue_Offset), 0, GetPointProperty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetName")]
	public unsafe static FName GetName(FPCGAttributePropertySelector Selector)
	{
		if (!GetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetName_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, GetName_Selector_Offset), 0, GetName_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetName_FunctionAddress, intPtr, GetName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetName_Selector_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetName_ReturnValue_Offset), 0, GetName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetExtraProperty")]
	public unsafe static EPCGExtraProperties GetExtraProperty(FPCGAttributePropertySelector Selector)
	{
		if (!GetExtraProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetExtraProperty");
			return EPCGExtraProperties.Index;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetExtraProperty_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, GetExtraProperty_Selector_Offset), 0, GetExtraProperty_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetExtraProperty_FunctionAddress, intPtr, GetExtraProperty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetExtraProperty_Selector_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPCGExtraProperties>.FromNative(IntPtr.Add(intPtr, GetExtraProperty_ReturnValue_Offset), 0, GetExtraProperty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetExtraNames")]
	public unsafe static List<string> GetExtraNames(FPCGAttributePropertySelector Selector)
	{
		if (!GetExtraNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetExtraNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetExtraNames_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, GetExtraNames_Selector_Offset), 0, GetExtraNames_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetExtraNames_FunctionAddress, intPtr, GetExtraNames_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetExtraNames_Selector_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetExtraNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetAttributeName")]
	public unsafe static FName GetAttributeName(FPCGAttributePropertySelector Selector)
	{
		if (!GetAttributeName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetAttributeName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttributeName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttributeName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAttributeName_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertySelector.ToNative(IntPtr.Add(intPtr, GetAttributeName_Selector_Offset), 0, GetAttributeName_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAttributeName_FunctionAddress, intPtr, GetAttributeName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAttributeName_Selector_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAttributeName_ReturnValue_Offset), 0, GetAttributeName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:CopyAndFixSource")]
	public unsafe static FPCGAttributePropertyOutputSelector CopyAndFixSource(FPCGAttributePropertyOutputSelector Selector, FPCGAttributePropertyInputSelector InSelector)
	{
		if (!CopyAndFixSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:CopyAndFixSource");
			return default(FPCGAttributePropertyOutputSelector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAndFixSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAndFixSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CopyAndFixSource_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertyOutputSelector.ToNative(IntPtr.Add(intPtr, CopyAndFixSource_Selector_Offset), 0, CopyAndFixSource_Selector_PropertyAddress.Address, Selector);
		NativeReflection.InitializeValue_InContainer(CopyAndFixSource_InSelector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(intPtr, CopyAndFixSource_InSelector_Offset), 0, CopyAndFixSource_InSelector_PropertyAddress.Address, InSelector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAndFixSource_FunctionAddress, intPtr, CopyAndFixSource_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyAndFixSource_Selector_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CopyAndFixSource_InSelector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertyOutputSelector result = FPCGAttributePropertyOutputSelector.FromNative(IntPtr.Add(intPtr, CopyAndFixSource_ReturnValue_Offset), 0, CopyAndFixSource_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CopyAndFixSource_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:CopyAndFixLast")]
	public unsafe static FPCGAttributePropertyInputSelector CopyAndFixLast(FPCGAttributePropertyInputSelector Selector, UPCGData InData)
	{
		if (!CopyAndFixLast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:CopyAndFixLast");
			return default(FPCGAttributePropertyInputSelector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAndFixLast_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAndFixLast_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CopyAndFixLast_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(intPtr, CopyAndFixLast_Selector_Offset), 0, CopyAndFixLast_Selector_PropertyAddress.Address, Selector);
		UObjectMarshaler<UPCGData>.ToNative(IntPtr.Add(intPtr, CopyAndFixLast_InData_Offset), 0, CopyAndFixLast_InData_PropertyAddress.Address, InData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAndFixLast_FunctionAddress, intPtr, CopyAndFixLast_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyAndFixLast_Selector_PropertyAddress.Address, intPtr);
		FPCGAttributePropertyInputSelector result = FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(intPtr, CopyAndFixLast_ReturnValue_Offset), 0, CopyAndFixLast_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CopyAndFixLast_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UPCGAttributePropertySelectorBlueprintHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGAttributePropertySelectorBlueprintHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGAttributePropertySelectorBlueprintHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers");
		SetPointProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPointProperty");
		SetPointProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPointProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPointProperty_Selector_PropertyAddress, SetPointProperty_FunctionAddress, "Selector");
		SetPointProperty_Selector_Offset = NativeReflectionCached.GetPropertyOffset(SetPointProperty_FunctionAddress, "Selector");
		SetPointProperty_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPointProperty_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPointProperty_InPointProperty_PropertyAddress, SetPointProperty_FunctionAddress, "InPointProperty");
		SetPointProperty_InPointProperty_Offset = NativeReflectionCached.GetPropertyOffset(SetPointProperty_FunctionAddress, "InPointProperty");
		SetPointProperty_InPointProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPointProperty_FunctionAddress, "InPointProperty", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPointProperty_ReturnValue_PropertyAddress, SetPointProperty_FunctionAddress, "ReturnValue");
		SetPointProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPointProperty_FunctionAddress, "ReturnValue");
		SetPointProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPointProperty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetPointProperty_IsValid = SetPointProperty_FunctionAddress != IntPtr.Zero && SetPointProperty_Selector_IsValid && SetPointProperty_InPointProperty_IsValid && SetPointProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetPointProperty", SetPointProperty_IsValid);
		SetExtraProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetExtraProperty");
		SetExtraProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExtraProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExtraProperty_Selector_PropertyAddress, SetExtraProperty_FunctionAddress, "Selector");
		SetExtraProperty_Selector_Offset = NativeReflectionCached.GetPropertyOffset(SetExtraProperty_FunctionAddress, "Selector");
		SetExtraProperty_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtraProperty_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExtraProperty_InExtraProperty_PropertyAddress, SetExtraProperty_FunctionAddress, "InExtraProperty");
		SetExtraProperty_InExtraProperty_Offset = NativeReflectionCached.GetPropertyOffset(SetExtraProperty_FunctionAddress, "InExtraProperty");
		SetExtraProperty_InExtraProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtraProperty_FunctionAddress, "InExtraProperty", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExtraProperty_ReturnValue_PropertyAddress, SetExtraProperty_FunctionAddress, "ReturnValue");
		SetExtraProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetExtraProperty_FunctionAddress, "ReturnValue");
		SetExtraProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtraProperty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetExtraProperty_IsValid = SetExtraProperty_FunctionAddress != IntPtr.Zero && SetExtraProperty_Selector_IsValid && SetExtraProperty_InExtraProperty_IsValid && SetExtraProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetExtraProperty", SetExtraProperty_IsValid);
		SetAttributeName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAttributeName");
		SetAttributeName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttributeName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeName_Selector_PropertyAddress, SetAttributeName_FunctionAddress, "Selector");
		SetAttributeName_Selector_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeName_FunctionAddress, "Selector");
		SetAttributeName_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeName_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeName_InAttributeName_PropertyAddress, SetAttributeName_FunctionAddress, "InAttributeName");
		SetAttributeName_InAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeName_FunctionAddress, "InAttributeName");
		SetAttributeName_InAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeName_FunctionAddress, "InAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAttributeName_ReturnValue_PropertyAddress, SetAttributeName_FunctionAddress, "ReturnValue");
		SetAttributeName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAttributeName_FunctionAddress, "ReturnValue");
		SetAttributeName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttributeName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAttributeName_IsValid = SetAttributeName_FunctionAddress != IntPtr.Zero && SetAttributeName_Selector_IsValid && SetAttributeName_InAttributeName_IsValid && SetAttributeName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:SetAttributeName", SetAttributeName_IsValid);
		GetSelection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelection");
		GetSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelection_Selector_PropertyAddress, GetSelection_FunctionAddress, "Selector");
		GetSelection_Selector_Offset = NativeReflectionCached.GetPropertyOffset(GetSelection_FunctionAddress, "Selector");
		GetSelection_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelection_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelection_ReturnValue_PropertyAddress, GetSelection_FunctionAddress, "ReturnValue");
		GetSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelection_FunctionAddress, "ReturnValue");
		GetSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelection_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetSelection_IsValid = GetSelection_FunctionAddress != IntPtr.Zero && GetSelection_Selector_IsValid && GetSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetSelection", GetSelection_IsValid);
		GetPointProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPointProperty");
		GetPointProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPointProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPointProperty_Selector_PropertyAddress, GetPointProperty_FunctionAddress, "Selector");
		GetPointProperty_Selector_Offset = NativeReflectionCached.GetPropertyOffset(GetPointProperty_FunctionAddress, "Selector");
		GetPointProperty_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointProperty_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPointProperty_ReturnValue_PropertyAddress, GetPointProperty_FunctionAddress, "ReturnValue");
		GetPointProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPointProperty_FunctionAddress, "ReturnValue");
		GetPointProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointProperty_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPointProperty_IsValid = GetPointProperty_FunctionAddress != IntPtr.Zero && GetPointProperty_Selector_IsValid && GetPointProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetPointProperty", GetPointProperty_IsValid);
		GetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetName");
		GetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetName_Selector_PropertyAddress, GetName_FunctionAddress, "Selector");
		GetName_Selector_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "Selector");
		GetName_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetName_ReturnValue_PropertyAddress, GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetName_IsValid = GetName_FunctionAddress != IntPtr.Zero && GetName_Selector_IsValid && GetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetName", GetName_IsValid);
		GetExtraProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtraProperty");
		GetExtraProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtraProperty_Selector_PropertyAddress, GetExtraProperty_FunctionAddress, "Selector");
		GetExtraProperty_Selector_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraProperty_FunctionAddress, "Selector");
		GetExtraProperty_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraProperty_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtraProperty_ReturnValue_PropertyAddress, GetExtraProperty_FunctionAddress, "ReturnValue");
		GetExtraProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraProperty_FunctionAddress, "ReturnValue");
		GetExtraProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraProperty_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetExtraProperty_IsValid = GetExtraProperty_FunctionAddress != IntPtr.Zero && GetExtraProperty_Selector_IsValid && GetExtraProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetExtraProperty", GetExtraProperty_IsValid);
		GetExtraNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtraNames");
		GetExtraNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtraNames_Selector_PropertyAddress, GetExtraNames_FunctionAddress, "Selector");
		GetExtraNames_Selector_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraNames_FunctionAddress, "Selector");
		GetExtraNames_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraNames_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtraNames_ReturnValue_PropertyAddress, GetExtraNames_FunctionAddress, "ReturnValue");
		GetExtraNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraNames_FunctionAddress, "ReturnValue");
		GetExtraNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetExtraNames_IsValid = GetExtraNames_FunctionAddress != IntPtr.Zero && GetExtraNames_Selector_IsValid && GetExtraNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetExtraNames", GetExtraNames_IsValid);
		GetAttributeName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAttributeName");
		GetAttributeName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttributeName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttributeName_Selector_PropertyAddress, GetAttributeName_FunctionAddress, "Selector");
		GetAttributeName_Selector_Offset = NativeReflectionCached.GetPropertyOffset(GetAttributeName_FunctionAddress, "Selector");
		GetAttributeName_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttributeName_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttributeName_ReturnValue_PropertyAddress, GetAttributeName_FunctionAddress, "ReturnValue");
		GetAttributeName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttributeName_FunctionAddress, "ReturnValue");
		GetAttributeName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttributeName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetAttributeName_IsValid = GetAttributeName_FunctionAddress != IntPtr.Zero && GetAttributeName_Selector_IsValid && GetAttributeName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:GetAttributeName", GetAttributeName_IsValid);
		CopyAndFixSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAndFixSource");
		CopyAndFixSource_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAndFixSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAndFixSource_Selector_PropertyAddress, CopyAndFixSource_FunctionAddress, "Selector");
		CopyAndFixSource_Selector_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndFixSource_FunctionAddress, "Selector");
		CopyAndFixSource_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndFixSource_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAndFixSource_InSelector_PropertyAddress, CopyAndFixSource_FunctionAddress, "InSelector");
		CopyAndFixSource_InSelector_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndFixSource_FunctionAddress, "InSelector");
		CopyAndFixSource_InSelector_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndFixSource_FunctionAddress, "InSelector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAndFixSource_ReturnValue_PropertyAddress, CopyAndFixSource_FunctionAddress, "ReturnValue");
		CopyAndFixSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndFixSource_FunctionAddress, "ReturnValue");
		CopyAndFixSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndFixSource_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CopyAndFixSource_IsValid = CopyAndFixSource_FunctionAddress != IntPtr.Zero && CopyAndFixSource_Selector_IsValid && CopyAndFixSource_InSelector_IsValid && CopyAndFixSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:CopyAndFixSource", CopyAndFixSource_IsValid);
		CopyAndFixLast_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAndFixLast");
		CopyAndFixLast_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAndFixLast_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAndFixLast_Selector_PropertyAddress, CopyAndFixLast_FunctionAddress, "Selector");
		CopyAndFixLast_Selector_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndFixLast_FunctionAddress, "Selector");
		CopyAndFixLast_Selector_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndFixLast_FunctionAddress, "Selector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAndFixLast_InData_PropertyAddress, CopyAndFixLast_FunctionAddress, "InData");
		CopyAndFixLast_InData_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndFixLast_FunctionAddress, "InData");
		CopyAndFixLast_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndFixLast_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAndFixLast_ReturnValue_PropertyAddress, CopyAndFixLast_FunctionAddress, "ReturnValue");
		CopyAndFixLast_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndFixLast_FunctionAddress, "ReturnValue");
		CopyAndFixLast_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndFixLast_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CopyAndFixLast_IsValid = CopyAndFixLast_FunctionAddress != IntPtr.Zero && CopyAndFixLast_Selector_IsValid && CopyAndFixLast_InData_IsValid && CopyAndFixLast_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGAttributePropertySelectorBlueprintHelpers:CopyAndFixLast", CopyAndFixLast_IsValid);
	}
}
