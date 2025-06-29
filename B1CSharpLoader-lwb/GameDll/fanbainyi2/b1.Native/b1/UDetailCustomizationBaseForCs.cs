using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs", "FuncLibEditor", UnrealModuleType.Game)]
public class UDetailCustomizationBaseForCs : UObject
{
	private static bool SetPropertyVisibility_IsValid;

	private static IntPtr SetPropertyVisibility_FunctionAddress;

	private static int SetPropertyVisibility_ParamsSize;

	private static bool SetPropertyVisibility_PropertyPath_IsValid;

	private static FFieldAddress SetPropertyVisibility_PropertyPath_PropertyAddress;

	private static int SetPropertyVisibility_PropertyPath_Offset;

	private static bool SetPropertyVisibility_InVisibility_IsValid;

	private static FFieldAddress SetPropertyVisibility_InVisibility_PropertyAddress;

	private static int SetPropertyVisibility_InVisibility_Offset;

	private static bool SetCategoryVisibility_IsValid;

	private static IntPtr SetCategoryVisibility_FunctionAddress;

	private static int SetCategoryVisibility_ParamsSize;

	private static bool SetCategoryVisibility_CategoryName_IsValid;

	private static FFieldAddress SetCategoryVisibility_CategoryName_PropertyAddress;

	private static int SetCategoryVisibility_CategoryName_Offset;

	private static bool SetCategoryVisibility_InVisibility_IsValid;

	private static FFieldAddress SetCategoryVisibility_InVisibility_PropertyAddress;

	private static int SetCategoryVisibility_InVisibility_Offset;

	private static bool ResetPropertyTooltip_IsValid;

	private static IntPtr ResetPropertyTooltip_FunctionAddress;

	private static int ResetPropertyTooltip_ParamsSize;

	private static bool ResetPropertyTooltip_PropertyPath_IsValid;

	private static FFieldAddress ResetPropertyTooltip_PropertyPath_PropertyAddress;

	private static int ResetPropertyTooltip_PropertyPath_Offset;

	private static bool ResetPropertyDisplayName_IsValid;

	private static IntPtr ResetPropertyDisplayName_FunctionAddress;

	private static int ResetPropertyDisplayName_ParamsSize;

	private static bool ResetPropertyDisplayName_PropertyPath_IsValid;

	private static FFieldAddress ResetPropertyDisplayName_PropertyPath_PropertyAddress;

	private static int ResetPropertyDisplayName_PropertyPath_Offset;

	private static bool ModifyPropertyTooltipCondition_IsValid;

	private static IntPtr ModifyPropertyTooltipCondition_FunctionAddress;

	private static int ModifyPropertyTooltipCondition_ParamsSize;

	private static bool ModifyPropertyTooltipCondition_PropertyPath_IsValid;

	private static FFieldAddress ModifyPropertyTooltipCondition_PropertyPath_PropertyAddress;

	private static int ModifyPropertyTooltipCondition_PropertyPath_Offset;

	private static bool ModifyPropertyTooltipCondition_Tooltip_IsValid;

	private static FFieldAddress ModifyPropertyTooltipCondition_Tooltip_PropertyAddress;

	private static int ModifyPropertyTooltipCondition_Tooltip_Offset;

	private static bool ModifyPropertyTooltipCondition_bCondition_IsValid;

	private static FFieldAddress ModifyPropertyTooltipCondition_bCondition_PropertyAddress;

	private static int ModifyPropertyTooltipCondition_bCondition_Offset;

	private static bool ModifyPropertyTooltip_IsValid;

	private static IntPtr ModifyPropertyTooltip_FunctionAddress;

	private static int ModifyPropertyTooltip_ParamsSize;

	private static bool ModifyPropertyTooltip_PropertyPath_IsValid;

	private static FFieldAddress ModifyPropertyTooltip_PropertyPath_PropertyAddress;

	private static int ModifyPropertyTooltip_PropertyPath_Offset;

	private static bool ModifyPropertyTooltip_Tooltip_IsValid;

	private static FFieldAddress ModifyPropertyTooltip_Tooltip_PropertyAddress;

	private static int ModifyPropertyTooltip_Tooltip_Offset;

	private static bool ModifyPropertyDisplayNameCondition_IsValid;

	private static IntPtr ModifyPropertyDisplayNameCondition_FunctionAddress;

	private static int ModifyPropertyDisplayNameCondition_ParamsSize;

	private static bool ModifyPropertyDisplayNameCondition_PropertyPath_IsValid;

	private static FFieldAddress ModifyPropertyDisplayNameCondition_PropertyPath_PropertyAddress;

	private static int ModifyPropertyDisplayNameCondition_PropertyPath_Offset;

	private static bool ModifyPropertyDisplayNameCondition_DisplayName_IsValid;

	private static FFieldAddress ModifyPropertyDisplayNameCondition_DisplayName_PropertyAddress;

	private static int ModifyPropertyDisplayNameCondition_DisplayName_Offset;

	private static bool ModifyPropertyDisplayNameCondition_bCondition_IsValid;

	private static FFieldAddress ModifyPropertyDisplayNameCondition_bCondition_PropertyAddress;

	private static int ModifyPropertyDisplayNameCondition_bCondition_Offset;

	private static bool ModifyPropertyDisplayName_IsValid;

	private static IntPtr ModifyPropertyDisplayName_FunctionAddress;

	private static int ModifyPropertyDisplayName_ParamsSize;

	private static bool ModifyPropertyDisplayName_PropertyPath_IsValid;

	private static FFieldAddress ModifyPropertyDisplayName_PropertyPath_PropertyAddress;

	private static int ModifyPropertyDisplayName_PropertyPath_Offset;

	private static bool ModifyPropertyDisplayName_DisplayName_IsValid;

	private static FFieldAddress ModifyPropertyDisplayName_DisplayName_PropertyAddress;

	private static int ModifyPropertyDisplayName_DisplayName_Offset;

	private static bool CustomizeDetails_IsValid;

	private IntPtr CustomizeDetails_InstanceFunctionAddress;

	private static IntPtr CustomizeDetails_FunctionAddress;

	private static int CustomizeDetails_ParamsSize;

	private static bool CustomizeDetails_InSelectedObjects_IsValid;

	private static FFieldAddress CustomizeDetails_InSelectedObjects_PropertyAddress;

	private static int CustomizeDetails_InSelectedObjects_Offset;

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:SetPropertyVisibility")]
	protected unsafe void SetPropertyVisibility(string PropertyPath, bool InVisibility)
	{
		CheckDestroyed();
		if (!SetPropertyVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:SetPropertyVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPropertyVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPropertyVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPropertyVisibility_PropertyPath_Offset), 0, SetPropertyVisibility_PropertyPath_PropertyAddress.Address, PropertyPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPropertyVisibility_InVisibility_Offset), 0, SetPropertyVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPropertyVisibility_FunctionAddress, intPtr, SetPropertyVisibility_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPropertyVisibility_PropertyPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:SetCategoryVisibility")]
	protected unsafe void SetCategoryVisibility(string CategoryName, bool InVisibility)
	{
		CheckDestroyed();
		if (!SetCategoryVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:SetCategoryVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCategoryVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCategoryVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCategoryVisibility_CategoryName_Offset), 0, SetCategoryVisibility_CategoryName_PropertyAddress.Address, CategoryName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCategoryVisibility_InVisibility_Offset), 0, SetCategoryVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCategoryVisibility_FunctionAddress, intPtr, SetCategoryVisibility_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCategoryVisibility_CategoryName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ResetPropertyTooltip")]
	protected unsafe void ResetPropertyTooltip(string PropertyPath)
	{
		CheckDestroyed();
		if (!ResetPropertyTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ResetPropertyTooltip");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPropertyTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPropertyTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ResetPropertyTooltip_PropertyPath_Offset), 0, ResetPropertyTooltip_PropertyPath_PropertyAddress.Address, PropertyPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetPropertyTooltip_FunctionAddress, intPtr, ResetPropertyTooltip_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResetPropertyTooltip_PropertyPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ResetPropertyDisplayName")]
	protected unsafe void ResetPropertyDisplayName(string PropertyPath)
	{
		CheckDestroyed();
		if (!ResetPropertyDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ResetPropertyDisplayName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPropertyDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPropertyDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ResetPropertyDisplayName_PropertyPath_Offset), 0, ResetPropertyDisplayName_PropertyPath_PropertyAddress.Address, PropertyPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetPropertyDisplayName_FunctionAddress, intPtr, ResetPropertyDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResetPropertyDisplayName_PropertyPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyTooltipCondition")]
	protected unsafe void ModifyPropertyTooltipCondition(string PropertyPath, string Tooltip, bool bCondition)
	{
		CheckDestroyed();
		if (!ModifyPropertyTooltipCondition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyTooltipCondition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyPropertyTooltipCondition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyPropertyTooltipCondition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyTooltipCondition_PropertyPath_Offset), 0, ModifyPropertyTooltipCondition_PropertyPath_PropertyAddress.Address, PropertyPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyTooltipCondition_Tooltip_Offset), 0, ModifyPropertyTooltipCondition_Tooltip_PropertyAddress.Address, Tooltip);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyTooltipCondition_bCondition_Offset), 0, ModifyPropertyTooltipCondition_bCondition_PropertyAddress.Address, bCondition);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyPropertyTooltipCondition_FunctionAddress, intPtr, ModifyPropertyTooltipCondition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyTooltipCondition_PropertyPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyTooltipCondition_Tooltip_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyTooltip")]
	protected unsafe void ModifyPropertyTooltip(string PropertyPath, string Tooltip)
	{
		CheckDestroyed();
		if (!ModifyPropertyTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyTooltip");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyPropertyTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyPropertyTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyTooltip_PropertyPath_Offset), 0, ModifyPropertyTooltip_PropertyPath_PropertyAddress.Address, PropertyPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyTooltip_Tooltip_Offset), 0, ModifyPropertyTooltip_Tooltip_PropertyAddress.Address, Tooltip);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyPropertyTooltip_FunctionAddress, intPtr, ModifyPropertyTooltip_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyTooltip_PropertyPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyTooltip_Tooltip_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyDisplayNameCondition")]
	protected unsafe void ModifyPropertyDisplayNameCondition(string PropertyPath, string DisplayName, bool bCondition)
	{
		CheckDestroyed();
		if (!ModifyPropertyDisplayNameCondition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyDisplayNameCondition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyPropertyDisplayNameCondition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyPropertyDisplayNameCondition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyDisplayNameCondition_PropertyPath_Offset), 0, ModifyPropertyDisplayNameCondition_PropertyPath_PropertyAddress.Address, PropertyPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyDisplayNameCondition_DisplayName_Offset), 0, ModifyPropertyDisplayNameCondition_DisplayName_PropertyAddress.Address, DisplayName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyDisplayNameCondition_bCondition_Offset), 0, ModifyPropertyDisplayNameCondition_bCondition_PropertyAddress.Address, bCondition);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyPropertyDisplayNameCondition_FunctionAddress, intPtr, ModifyPropertyDisplayNameCondition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyDisplayNameCondition_PropertyPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyDisplayNameCondition_DisplayName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyDisplayName")]
	protected unsafe void ModifyPropertyDisplayName(string PropertyPath, string DisplayName)
	{
		CheckDestroyed();
		if (!ModifyPropertyDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyDisplayName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyPropertyDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyPropertyDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyDisplayName_PropertyPath_Offset), 0, ModifyPropertyDisplayName_PropertyPath_PropertyAddress.Address, PropertyPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyPropertyDisplayName_DisplayName_Offset), 0, ModifyPropertyDisplayName_DisplayName_PropertyAddress.Address, DisplayName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyPropertyDisplayName_FunctionAddress, intPtr, ModifyPropertyDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyDisplayName_PropertyPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ModifyPropertyDisplayName_DisplayName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/FuncLibEditor.DetailCustomizationBaseForCs:CustomizeDetails")]
	public unsafe void CustomizeDetails(List<UObject> InSelectedObjects)
	{
		CheckDestroyed();
		if (!CustomizeDetails_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:CustomizeDetails");
			return;
		}
		if (CustomizeDetails_InstanceFunctionAddress == IntPtr.Zero)
		{
			CustomizeDetails_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CustomizeDetails");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomizeDetails_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomizeDetails_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, CustomizeDetails_InSelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, CustomizeDetails_InSelectedObjects_Offset), InSelectedObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, CustomizeDetails_InstanceFunctionAddress, intPtr, CustomizeDetails_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CustomizeDetails_InSelectedObjects_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void CustomizeDetails_Implementation(List<UObject> InSelectedObjects)
	{
		CheckDestroyed();
		if (!CustomizeDetails_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.DetailCustomizationBaseForCs:CustomizeDetails");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomizeDetails_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomizeDetails_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, CustomizeDetails_InSelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, CustomizeDetails_InSelectedObjects_Offset), InSelectedObjects);
		NativeReflection.InvokeFunctionOptimized(base.Address, CustomizeDetails_FunctionAddress, intPtr, CustomizeDetails_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CustomizeDetails_InSelectedObjects_PropertyAddress.Address, intPtr);
	}

	static UDetailCustomizationBaseForCs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDetailCustomizationBaseForCs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDetailCustomizationBaseForCs));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FuncLibEditor.DetailCustomizationBaseForCs");
		SetPropertyVisibility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPropertyVisibility");
		SetPropertyVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPropertyVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPropertyVisibility_PropertyPath_PropertyAddress, SetPropertyVisibility_FunctionAddress, "PropertyPath");
		SetPropertyVisibility_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(SetPropertyVisibility_FunctionAddress, "PropertyPath");
		SetPropertyVisibility_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPropertyVisibility_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPropertyVisibility_InVisibility_PropertyAddress, SetPropertyVisibility_FunctionAddress, "InVisibility");
		SetPropertyVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetPropertyVisibility_FunctionAddress, "InVisibility");
		SetPropertyVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPropertyVisibility_FunctionAddress, "InVisibility", Classes.FBoolProperty);
		SetPropertyVisibility_IsValid = SetPropertyVisibility_FunctionAddress != IntPtr.Zero && SetPropertyVisibility_PropertyPath_IsValid && SetPropertyVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:SetPropertyVisibility", SetPropertyVisibility_IsValid);
		SetCategoryVisibility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCategoryVisibility");
		SetCategoryVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCategoryVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCategoryVisibility_CategoryName_PropertyAddress, SetCategoryVisibility_FunctionAddress, "CategoryName");
		SetCategoryVisibility_CategoryName_Offset = NativeReflectionCached.GetPropertyOffset(SetCategoryVisibility_FunctionAddress, "CategoryName");
		SetCategoryVisibility_CategoryName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCategoryVisibility_FunctionAddress, "CategoryName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCategoryVisibility_InVisibility_PropertyAddress, SetCategoryVisibility_FunctionAddress, "InVisibility");
		SetCategoryVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetCategoryVisibility_FunctionAddress, "InVisibility");
		SetCategoryVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCategoryVisibility_FunctionAddress, "InVisibility", Classes.FBoolProperty);
		SetCategoryVisibility_IsValid = SetCategoryVisibility_FunctionAddress != IntPtr.Zero && SetCategoryVisibility_CategoryName_IsValid && SetCategoryVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:SetCategoryVisibility", SetCategoryVisibility_IsValid);
		ResetPropertyTooltip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetPropertyTooltip");
		ResetPropertyTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPropertyTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetPropertyTooltip_PropertyPath_PropertyAddress, ResetPropertyTooltip_FunctionAddress, "PropertyPath");
		ResetPropertyTooltip_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(ResetPropertyTooltip_FunctionAddress, "PropertyPath");
		ResetPropertyTooltip_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPropertyTooltip_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		ResetPropertyTooltip_IsValid = ResetPropertyTooltip_FunctionAddress != IntPtr.Zero && ResetPropertyTooltip_PropertyPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ResetPropertyTooltip", ResetPropertyTooltip_IsValid);
		ResetPropertyDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetPropertyDisplayName");
		ResetPropertyDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPropertyDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetPropertyDisplayName_PropertyPath_PropertyAddress, ResetPropertyDisplayName_FunctionAddress, "PropertyPath");
		ResetPropertyDisplayName_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(ResetPropertyDisplayName_FunctionAddress, "PropertyPath");
		ResetPropertyDisplayName_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPropertyDisplayName_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		ResetPropertyDisplayName_IsValid = ResetPropertyDisplayName_FunctionAddress != IntPtr.Zero && ResetPropertyDisplayName_PropertyPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ResetPropertyDisplayName", ResetPropertyDisplayName_IsValid);
		ModifyPropertyTooltipCondition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyPropertyTooltipCondition");
		ModifyPropertyTooltipCondition_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyPropertyTooltipCondition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyTooltipCondition_PropertyPath_PropertyAddress, ModifyPropertyTooltipCondition_FunctionAddress, "PropertyPath");
		ModifyPropertyTooltipCondition_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyTooltipCondition_FunctionAddress, "PropertyPath");
		ModifyPropertyTooltipCondition_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyTooltipCondition_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyTooltipCondition_Tooltip_PropertyAddress, ModifyPropertyTooltipCondition_FunctionAddress, "Tooltip");
		ModifyPropertyTooltipCondition_Tooltip_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyTooltipCondition_FunctionAddress, "Tooltip");
		ModifyPropertyTooltipCondition_Tooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyTooltipCondition_FunctionAddress, "Tooltip", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyTooltipCondition_bCondition_PropertyAddress, ModifyPropertyTooltipCondition_FunctionAddress, "bCondition");
		ModifyPropertyTooltipCondition_bCondition_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyTooltipCondition_FunctionAddress, "bCondition");
		ModifyPropertyTooltipCondition_bCondition_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyTooltipCondition_FunctionAddress, "bCondition", Classes.FBoolProperty);
		ModifyPropertyTooltipCondition_IsValid = ModifyPropertyTooltipCondition_FunctionAddress != IntPtr.Zero && ModifyPropertyTooltipCondition_PropertyPath_IsValid && ModifyPropertyTooltipCondition_Tooltip_IsValid && ModifyPropertyTooltipCondition_bCondition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyTooltipCondition", ModifyPropertyTooltipCondition_IsValid);
		ModifyPropertyTooltip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyPropertyTooltip");
		ModifyPropertyTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyPropertyTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyTooltip_PropertyPath_PropertyAddress, ModifyPropertyTooltip_FunctionAddress, "PropertyPath");
		ModifyPropertyTooltip_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyTooltip_FunctionAddress, "PropertyPath");
		ModifyPropertyTooltip_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyTooltip_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyTooltip_Tooltip_PropertyAddress, ModifyPropertyTooltip_FunctionAddress, "Tooltip");
		ModifyPropertyTooltip_Tooltip_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyTooltip_FunctionAddress, "Tooltip");
		ModifyPropertyTooltip_Tooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyTooltip_FunctionAddress, "Tooltip", Classes.FStrProperty);
		ModifyPropertyTooltip_IsValid = ModifyPropertyTooltip_FunctionAddress != IntPtr.Zero && ModifyPropertyTooltip_PropertyPath_IsValid && ModifyPropertyTooltip_Tooltip_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyTooltip", ModifyPropertyTooltip_IsValid);
		ModifyPropertyDisplayNameCondition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyPropertyDisplayNameCondition");
		ModifyPropertyDisplayNameCondition_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyPropertyDisplayNameCondition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyDisplayNameCondition_PropertyPath_PropertyAddress, ModifyPropertyDisplayNameCondition_FunctionAddress, "PropertyPath");
		ModifyPropertyDisplayNameCondition_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyDisplayNameCondition_FunctionAddress, "PropertyPath");
		ModifyPropertyDisplayNameCondition_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyDisplayNameCondition_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyDisplayNameCondition_DisplayName_PropertyAddress, ModifyPropertyDisplayNameCondition_FunctionAddress, "DisplayName");
		ModifyPropertyDisplayNameCondition_DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyDisplayNameCondition_FunctionAddress, "DisplayName");
		ModifyPropertyDisplayNameCondition_DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyDisplayNameCondition_FunctionAddress, "DisplayName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyDisplayNameCondition_bCondition_PropertyAddress, ModifyPropertyDisplayNameCondition_FunctionAddress, "bCondition");
		ModifyPropertyDisplayNameCondition_bCondition_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyDisplayNameCondition_FunctionAddress, "bCondition");
		ModifyPropertyDisplayNameCondition_bCondition_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyDisplayNameCondition_FunctionAddress, "bCondition", Classes.FBoolProperty);
		ModifyPropertyDisplayNameCondition_IsValid = ModifyPropertyDisplayNameCondition_FunctionAddress != IntPtr.Zero && ModifyPropertyDisplayNameCondition_PropertyPath_IsValid && ModifyPropertyDisplayNameCondition_DisplayName_IsValid && ModifyPropertyDisplayNameCondition_bCondition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyDisplayNameCondition", ModifyPropertyDisplayNameCondition_IsValid);
		ModifyPropertyDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyPropertyDisplayName");
		ModifyPropertyDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyPropertyDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyDisplayName_PropertyPath_PropertyAddress, ModifyPropertyDisplayName_FunctionAddress, "PropertyPath");
		ModifyPropertyDisplayName_PropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyDisplayName_FunctionAddress, "PropertyPath");
		ModifyPropertyDisplayName_PropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyDisplayName_FunctionAddress, "PropertyPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyPropertyDisplayName_DisplayName_PropertyAddress, ModifyPropertyDisplayName_FunctionAddress, "DisplayName");
		ModifyPropertyDisplayName_DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(ModifyPropertyDisplayName_FunctionAddress, "DisplayName");
		ModifyPropertyDisplayName_DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyPropertyDisplayName_FunctionAddress, "DisplayName", Classes.FStrProperty);
		ModifyPropertyDisplayName_IsValid = ModifyPropertyDisplayName_FunctionAddress != IntPtr.Zero && ModifyPropertyDisplayName_PropertyPath_IsValid && ModifyPropertyDisplayName_DisplayName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:ModifyPropertyDisplayName", ModifyPropertyDisplayName_IsValid);
		CustomizeDetails_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CustomizeDetails");
		CustomizeDetails_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomizeDetails_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomizeDetails_InSelectedObjects_PropertyAddress, CustomizeDetails_FunctionAddress, "InSelectedObjects");
		CustomizeDetails_InSelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(CustomizeDetails_FunctionAddress, "InSelectedObjects");
		CustomizeDetails_InSelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomizeDetails_FunctionAddress, "InSelectedObjects", Classes.FArrayProperty);
		CustomizeDetails_IsValid = CustomizeDetails_FunctionAddress != IntPtr.Zero && CustomizeDetails_InSelectedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.DetailCustomizationBaseForCs:CustomizeDetails", CustomizeDetails_IsValid);
	}
}
