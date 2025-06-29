using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.DynamicEntryBox", "UMG", UnrealModuleType.Engine)]
public class UDynamicEntryBox : UDynamicEntryBoxBase
{
	private static bool EntryWidgetClass_IsValid;

	private static int EntryWidgetClass_Offset;

	private static bool Reset_IsValid;

	private static IntPtr Reset_FunctionAddress;

	private static int Reset_ParamsSize;

	private static bool Reset_bDeleteWidgets_IsValid;

	private static FFieldAddress Reset_bDeleteWidgets_PropertyAddress;

	private static int Reset_bDeleteWidgets_Offset;

	private static bool RemoveEntry_IsValid;

	private static IntPtr RemoveEntry_FunctionAddress;

	private static int RemoveEntry_ParamsSize;

	private static bool RemoveEntry_EntryWidget_IsValid;

	private static FFieldAddress RemoveEntry_EntryWidget_PropertyAddress;

	private static int RemoveEntry_EntryWidget_Offset;

	private static bool BP_CreateEntryOfClass_IsValid;

	private static IntPtr BP_CreateEntryOfClass_FunctionAddress;

	private static int BP_CreateEntryOfClass_ParamsSize;

	private static bool BP_CreateEntryOfClass_EntryClass_IsValid;

	private static FFieldAddress BP_CreateEntryOfClass_EntryClass_PropertyAddress;

	private static int BP_CreateEntryOfClass_EntryClass_Offset;

	private static bool BP_CreateEntryOfClass_ReturnValue_IsValid;

	private static FFieldAddress BP_CreateEntryOfClass_ReturnValue_PropertyAddress;

	private static int BP_CreateEntryOfClass_ReturnValue_Offset;

	private static bool BP_CreateEntry_IsValid;

	private static IntPtr BP_CreateEntry_FunctionAddress;

	private static int BP_CreateEntry_ParamsSize;

	private static bool BP_CreateEntry_ReturnValue_IsValid;

	private static FFieldAddress BP_CreateEntry_ReturnValue_PropertyAddress;

	private static int BP_CreateEntry_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)21392168023228949uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBox:EntryWidgetClass")]
	public TSubclassOf<UUserWidget> EntryWidgetClass
	{
		get
		{
			CheckDestroyed();
			if (!EntryWidgetClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBox:EntryWidgetClass");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, EntryWidgetClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntryWidgetClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBox:EntryWidgetClass");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, EntryWidgetClass_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.DynamicEntryBox:Reset")]
	public unsafe void Reset(bool bDeleteWidgets = false)
	{
		CheckDestroyed();
		if (!Reset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBox:Reset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Reset_bDeleteWidgets_Offset), 0, Reset_bDeleteWidgets_PropertyAddress.Address, bDeleteWidgets);
		NativeReflection.InvokeFunctionOptimized(base.Address, Reset_FunctionAddress, intPtr, Reset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.DynamicEntryBox:RemoveEntry")]
	public unsafe void RemoveEntry(UUserWidget EntryWidget)
	{
		CheckDestroyed();
		if (!RemoveEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBox:RemoveEntry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, RemoveEntry_EntryWidget_Offset), 0, RemoveEntry_EntryWidget_PropertyAddress.Address, EntryWidget);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveEntry_FunctionAddress, intPtr, RemoveEntry_ParamsSize);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.DynamicEntryBox:BP_CreateEntryOfClass")]
	public unsafe UUserWidget BP_CreateEntryOfClass(TSubclassOf<UUserWidget> EntryClass)
	{
		CheckDestroyed();
		if (!BP_CreateEntryOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBox:BP_CreateEntryOfClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_CreateEntryOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_CreateEntryOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, BP_CreateEntryOfClass_EntryClass_Offset), 0, BP_CreateEntryOfClass_EntryClass_PropertyAddress.Address, EntryClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_CreateEntryOfClass_FunctionAddress, intPtr, BP_CreateEntryOfClass_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, BP_CreateEntryOfClass_ReturnValue_Offset), 0, BP_CreateEntryOfClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/UMG.DynamicEntryBox:BP_CreateEntry")]
	public unsafe UUserWidget BP_CreateEntry()
	{
		CheckDestroyed();
		if (!BP_CreateEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBox:BP_CreateEntry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_CreateEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_CreateEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_CreateEntry_FunctionAddress, intPtr, BP_CreateEntry_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, BP_CreateEntry_ReturnValue_Offset), 0, BP_CreateEntry_ReturnValue_PropertyAddress.Address);
	}

	static UDynamicEntryBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDynamicEntryBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDynamicEntryBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.DynamicEntryBox");
		EntryWidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntryWidgetClass");
		EntryWidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntryWidgetClass", Classes.FClassProperty);
		Reset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reset");
		Reset_ParamsSize = NativeReflection.GetFunctionParamsSize(Reset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Reset_bDeleteWidgets_PropertyAddress, Reset_FunctionAddress, "bDeleteWidgets");
		Reset_bDeleteWidgets_Offset = NativeReflectionCached.GetPropertyOffset(Reset_FunctionAddress, "bDeleteWidgets");
		Reset_bDeleteWidgets_IsValid = NativeReflectionCached.ValidatePropertyClass(Reset_FunctionAddress, "bDeleteWidgets", Classes.FBoolProperty);
		Reset_IsValid = Reset_FunctionAddress != IntPtr.Zero && Reset_bDeleteWidgets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBox:Reset", Reset_IsValid);
		RemoveEntry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveEntry");
		RemoveEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveEntry_EntryWidget_PropertyAddress, RemoveEntry_FunctionAddress, "EntryWidget");
		RemoveEntry_EntryWidget_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEntry_FunctionAddress, "EntryWidget");
		RemoveEntry_EntryWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEntry_FunctionAddress, "EntryWidget", Classes.FObjectProperty);
		RemoveEntry_IsValid = RemoveEntry_FunctionAddress != IntPtr.Zero && RemoveEntry_EntryWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBox:RemoveEntry", RemoveEntry_IsValid);
		BP_CreateEntryOfClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_CreateEntryOfClass");
		BP_CreateEntryOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_CreateEntryOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_CreateEntryOfClass_EntryClass_PropertyAddress, BP_CreateEntryOfClass_FunctionAddress, "EntryClass");
		BP_CreateEntryOfClass_EntryClass_Offset = NativeReflectionCached.GetPropertyOffset(BP_CreateEntryOfClass_FunctionAddress, "EntryClass");
		BP_CreateEntryOfClass_EntryClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_CreateEntryOfClass_FunctionAddress, "EntryClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BP_CreateEntryOfClass_ReturnValue_PropertyAddress, BP_CreateEntryOfClass_FunctionAddress, "ReturnValue");
		BP_CreateEntryOfClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_CreateEntryOfClass_FunctionAddress, "ReturnValue");
		BP_CreateEntryOfClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_CreateEntryOfClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BP_CreateEntryOfClass_IsValid = BP_CreateEntryOfClass_FunctionAddress != IntPtr.Zero && BP_CreateEntryOfClass_EntryClass_IsValid && BP_CreateEntryOfClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBox:BP_CreateEntryOfClass", BP_CreateEntryOfClass_IsValid);
		BP_CreateEntry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_CreateEntry");
		BP_CreateEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_CreateEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_CreateEntry_ReturnValue_PropertyAddress, BP_CreateEntry_FunctionAddress, "ReturnValue");
		BP_CreateEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_CreateEntry_FunctionAddress, "ReturnValue");
		BP_CreateEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_CreateEntry_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BP_CreateEntry_IsValid = BP_CreateEntry_FunctionAddress != IntPtr.Zero && BP_CreateEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBox:BP_CreateEntry", BP_CreateEntry_IsValid);
	}
}
