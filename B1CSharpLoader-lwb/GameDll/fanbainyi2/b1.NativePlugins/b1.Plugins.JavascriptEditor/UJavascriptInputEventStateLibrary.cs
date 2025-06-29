using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptInputEventStateLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsSpaceBarPressed_IsValid;

	private static IntPtr IsSpaceBarPressed_FunctionAddress;

	private static int IsSpaceBarPressed_ParamsSize;

	private static bool IsSpaceBarPressed_InputEvent_IsValid;

	private static FFieldAddress IsSpaceBarPressed_InputEvent_PropertyAddress;

	private static int IsSpaceBarPressed_InputEvent_Offset;

	private static bool IsSpaceBarPressed_ReturnValue_IsValid;

	private static FFieldAddress IsSpaceBarPressed_ReturnValue_PropertyAddress;

	private static int IsSpaceBarPressed_ReturnValue_Offset;

	private static bool IsShiftButtonPressed_IsValid;

	private static IntPtr IsShiftButtonPressed_FunctionAddress;

	private static int IsShiftButtonPressed_ParamsSize;

	private static bool IsShiftButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsShiftButtonPressed_InputEvent_PropertyAddress;

	private static int IsShiftButtonPressed_InputEvent_Offset;

	private static bool IsShiftButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsShiftButtonPressed_ReturnValue_PropertyAddress;

	private static int IsShiftButtonPressed_ReturnValue_Offset;

	private static bool IsShiftButtonEvent_IsValid;

	private static IntPtr IsShiftButtonEvent_FunctionAddress;

	private static int IsShiftButtonEvent_ParamsSize;

	private static bool IsShiftButtonEvent_InputEvent_IsValid;

	private static FFieldAddress IsShiftButtonEvent_InputEvent_PropertyAddress;

	private static int IsShiftButtonEvent_InputEvent_Offset;

	private static bool IsShiftButtonEvent_ReturnValue_IsValid;

	private static FFieldAddress IsShiftButtonEvent_ReturnValue_PropertyAddress;

	private static int IsShiftButtonEvent_ReturnValue_Offset;

	private static bool IsRightMouseButtonPressed_IsValid;

	private static IntPtr IsRightMouseButtonPressed_FunctionAddress;

	private static int IsRightMouseButtonPressed_ParamsSize;

	private static bool IsRightMouseButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsRightMouseButtonPressed_InputEvent_PropertyAddress;

	private static int IsRightMouseButtonPressed_InputEvent_Offset;

	private static bool IsRightMouseButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsRightMouseButtonPressed_ReturnValue_PropertyAddress;

	private static int IsRightMouseButtonPressed_ReturnValue_Offset;

	private static bool IsMouseButtonEvent_IsValid;

	private static IntPtr IsMouseButtonEvent_FunctionAddress;

	private static int IsMouseButtonEvent_ParamsSize;

	private static bool IsMouseButtonEvent_InputEvent_IsValid;

	private static FFieldAddress IsMouseButtonEvent_InputEvent_PropertyAddress;

	private static int IsMouseButtonEvent_InputEvent_Offset;

	private static bool IsMouseButtonEvent_ReturnValue_IsValid;

	private static FFieldAddress IsMouseButtonEvent_ReturnValue_PropertyAddress;

	private static int IsMouseButtonEvent_ReturnValue_Offset;

	private static bool IsMiddleMouseButtonPressed_IsValid;

	private static IntPtr IsMiddleMouseButtonPressed_FunctionAddress;

	private static int IsMiddleMouseButtonPressed_ParamsSize;

	private static bool IsMiddleMouseButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsMiddleMouseButtonPressed_InputEvent_PropertyAddress;

	private static int IsMiddleMouseButtonPressed_InputEvent_Offset;

	private static bool IsMiddleMouseButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsMiddleMouseButtonPressed_ReturnValue_PropertyAddress;

	private static int IsMiddleMouseButtonPressed_ReturnValue_Offset;

	private static bool IsLeftMouseButtonPressed_IsValid;

	private static IntPtr IsLeftMouseButtonPressed_FunctionAddress;

	private static int IsLeftMouseButtonPressed_ParamsSize;

	private static bool IsLeftMouseButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsLeftMouseButtonPressed_InputEvent_PropertyAddress;

	private static int IsLeftMouseButtonPressed_InputEvent_Offset;

	private static bool IsLeftMouseButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsLeftMouseButtonPressed_ReturnValue_PropertyAddress;

	private static int IsLeftMouseButtonPressed_ReturnValue_Offset;

	private static bool IsCtrlButtonPressed_IsValid;

	private static IntPtr IsCtrlButtonPressed_FunctionAddress;

	private static int IsCtrlButtonPressed_ParamsSize;

	private static bool IsCtrlButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsCtrlButtonPressed_InputEvent_PropertyAddress;

	private static int IsCtrlButtonPressed_InputEvent_Offset;

	private static bool IsCtrlButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsCtrlButtonPressed_ReturnValue_PropertyAddress;

	private static int IsCtrlButtonPressed_ReturnValue_Offset;

	private static bool IsCtrlButtonEvent_IsValid;

	private static IntPtr IsCtrlButtonEvent_FunctionAddress;

	private static int IsCtrlButtonEvent_ParamsSize;

	private static bool IsCtrlButtonEvent_InputEvent_IsValid;

	private static FFieldAddress IsCtrlButtonEvent_InputEvent_PropertyAddress;

	private static int IsCtrlButtonEvent_InputEvent_Offset;

	private static bool IsCtrlButtonEvent_ReturnValue_IsValid;

	private static FFieldAddress IsCtrlButtonEvent_ReturnValue_PropertyAddress;

	private static int IsCtrlButtonEvent_ReturnValue_Offset;

	private static bool IsButtonPressed_IsValid;

	private static IntPtr IsButtonPressed_FunctionAddress;

	private static int IsButtonPressed_ParamsSize;

	private static bool IsButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsButtonPressed_InputEvent_PropertyAddress;

	private static int IsButtonPressed_InputEvent_Offset;

	private static bool IsButtonPressed_InKey_IsValid;

	private static FFieldAddress IsButtonPressed_InKey_PropertyAddress;

	private static int IsButtonPressed_InKey_Offset;

	private static bool IsButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsButtonPressed_ReturnValue_PropertyAddress;

	private static int IsButtonPressed_ReturnValue_Offset;

	private static bool IsAnyMouseButtonDown_IsValid;

	private static IntPtr IsAnyMouseButtonDown_FunctionAddress;

	private static int IsAnyMouseButtonDown_ParamsSize;

	private static bool IsAnyMouseButtonDown_InputEvent_IsValid;

	private static FFieldAddress IsAnyMouseButtonDown_InputEvent_PropertyAddress;

	private static int IsAnyMouseButtonDown_InputEvent_Offset;

	private static bool IsAnyMouseButtonDown_ReturnValue_IsValid;

	private static FFieldAddress IsAnyMouseButtonDown_ReturnValue_PropertyAddress;

	private static int IsAnyMouseButtonDown_ReturnValue_Offset;

	private static bool IsAltButtonPressed_IsValid;

	private static IntPtr IsAltButtonPressed_FunctionAddress;

	private static int IsAltButtonPressed_ParamsSize;

	private static bool IsAltButtonPressed_InputEvent_IsValid;

	private static FFieldAddress IsAltButtonPressed_InputEvent_PropertyAddress;

	private static int IsAltButtonPressed_InputEvent_Offset;

	private static bool IsAltButtonPressed_ReturnValue_IsValid;

	private static FFieldAddress IsAltButtonPressed_ReturnValue_PropertyAddress;

	private static int IsAltButtonPressed_ReturnValue_Offset;

	private static bool IsAltButtonEvent_IsValid;

	private static IntPtr IsAltButtonEvent_FunctionAddress;

	private static int IsAltButtonEvent_ParamsSize;

	private static bool IsAltButtonEvent_InputEvent_IsValid;

	private static FFieldAddress IsAltButtonEvent_InputEvent_PropertyAddress;

	private static int IsAltButtonEvent_InputEvent_Offset;

	private static bool IsAltButtonEvent_ReturnValue_IsValid;

	private static FFieldAddress IsAltButtonEvent_ReturnValue_PropertyAddress;

	private static int IsAltButtonEvent_ReturnValue_Offset;

	private static bool GetKey_IsValid;

	private static IntPtr GetKey_FunctionAddress;

	private static int GetKey_ParamsSize;

	private static bool GetKey_InputEvent_IsValid;

	private static FFieldAddress GetKey_InputEvent_PropertyAddress;

	private static int GetKey_InputEvent_Offset;

	private static bool GetKey_ReturnValue_IsValid;

	private static FFieldAddress GetKey_ReturnValue_PropertyAddress;

	private static int GetKey_ReturnValue_Offset;

	private static bool GetInputEvent_IsValid;

	private static IntPtr GetInputEvent_FunctionAddress;

	private static int GetInputEvent_ParamsSize;

	private static bool GetInputEvent_InputEvent_IsValid;

	private static FFieldAddress GetInputEvent_InputEvent_PropertyAddress;

	private static int GetInputEvent_InputEvent_Offset;

	private static bool GetInputEvent_ReturnValue_IsValid;

	private static FFieldAddress GetInputEvent_ReturnValue_PropertyAddress;

	private static int GetInputEvent_ReturnValue_Offset;

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsSpaceBarPressed")]
	public unsafe static bool IsSpaceBarPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsSpaceBarPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsSpaceBarPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSpaceBarPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSpaceBarPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsSpaceBarPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsSpaceBarPressed_InputEvent_Offset), 0, IsSpaceBarPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSpaceBarPressed_FunctionAddress, intPtr, IsSpaceBarPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSpaceBarPressed_ReturnValue_Offset), 0, IsSpaceBarPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsShiftButtonPressed")]
	public unsafe static bool IsShiftButtonPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsShiftButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsShiftButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsShiftButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsShiftButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsShiftButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsShiftButtonPressed_InputEvent_Offset), 0, IsShiftButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsShiftButtonPressed_FunctionAddress, intPtr, IsShiftButtonPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsShiftButtonPressed_ReturnValue_Offset), 0, IsShiftButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsShiftButtonEvent")]
	public unsafe static bool IsShiftButtonEvent(FJavascriptInputEventState InputEvent)
	{
		if (!IsShiftButtonEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsShiftButtonEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsShiftButtonEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsShiftButtonEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsShiftButtonEvent_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsShiftButtonEvent_InputEvent_Offset), 0, IsShiftButtonEvent_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsShiftButtonEvent_FunctionAddress, intPtr, IsShiftButtonEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsShiftButtonEvent_ReturnValue_Offset), 0, IsShiftButtonEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsRightMouseButtonPressed")]
	public unsafe static bool IsRightMouseButtonPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsRightMouseButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsRightMouseButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRightMouseButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRightMouseButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsRightMouseButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsRightMouseButtonPressed_InputEvent_Offset), 0, IsRightMouseButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRightMouseButtonPressed_FunctionAddress, intPtr, IsRightMouseButtonPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRightMouseButtonPressed_ReturnValue_Offset), 0, IsRightMouseButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsMouseButtonEvent")]
	public unsafe static bool IsMouseButtonEvent(FJavascriptInputEventState InputEvent)
	{
		if (!IsMouseButtonEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsMouseButtonEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMouseButtonEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMouseButtonEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsMouseButtonEvent_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsMouseButtonEvent_InputEvent_Offset), 0, IsMouseButtonEvent_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsMouseButtonEvent_FunctionAddress, intPtr, IsMouseButtonEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMouseButtonEvent_ReturnValue_Offset), 0, IsMouseButtonEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsMiddleMouseButtonPressed")]
	public unsafe static bool IsMiddleMouseButtonPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsMiddleMouseButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsMiddleMouseButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMiddleMouseButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMiddleMouseButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsMiddleMouseButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsMiddleMouseButtonPressed_InputEvent_Offset), 0, IsMiddleMouseButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsMiddleMouseButtonPressed_FunctionAddress, intPtr, IsMiddleMouseButtonPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMiddleMouseButtonPressed_ReturnValue_Offset), 0, IsMiddleMouseButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsLeftMouseButtonPressed")]
	public unsafe static bool IsLeftMouseButtonPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsLeftMouseButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsLeftMouseButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLeftMouseButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLeftMouseButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsLeftMouseButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsLeftMouseButtonPressed_InputEvent_Offset), 0, IsLeftMouseButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsLeftMouseButtonPressed_FunctionAddress, intPtr, IsLeftMouseButtonPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLeftMouseButtonPressed_ReturnValue_Offset), 0, IsLeftMouseButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsCtrlButtonPressed")]
	public unsafe static bool IsCtrlButtonPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsCtrlButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsCtrlButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCtrlButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCtrlButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsCtrlButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsCtrlButtonPressed_InputEvent_Offset), 0, IsCtrlButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCtrlButtonPressed_FunctionAddress, intPtr, IsCtrlButtonPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCtrlButtonPressed_ReturnValue_Offset), 0, IsCtrlButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsCtrlButtonEvent")]
	public unsafe static bool IsCtrlButtonEvent(FJavascriptInputEventState InputEvent)
	{
		if (!IsCtrlButtonEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsCtrlButtonEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCtrlButtonEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCtrlButtonEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsCtrlButtonEvent_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsCtrlButtonEvent_InputEvent_Offset), 0, IsCtrlButtonEvent_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCtrlButtonEvent_FunctionAddress, intPtr, IsCtrlButtonEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCtrlButtonEvent_ReturnValue_Offset), 0, IsCtrlButtonEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsButtonPressed")]
	public unsafe static bool IsButtonPressed(FJavascriptInputEventState InputEvent, FKey InKey)
	{
		if (!IsButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsButtonPressed_InputEvent_Offset), 0, IsButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InitializeValue_InContainer(IsButtonPressed_InKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, IsButtonPressed_InKey_Offset), 0, IsButtonPressed_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsButtonPressed_FunctionAddress, intPtr, IsButtonPressed_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsButtonPressed_InKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsButtonPressed_ReturnValue_Offset), 0, IsButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAnyMouseButtonDown")]
	public unsafe static bool IsAnyMouseButtonDown(FJavascriptInputEventState InputEvent)
	{
		if (!IsAnyMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAnyMouseButtonDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnyMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnyMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsAnyMouseButtonDown_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsAnyMouseButtonDown_InputEvent_Offset), 0, IsAnyMouseButtonDown_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAnyMouseButtonDown_FunctionAddress, intPtr, IsAnyMouseButtonDown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnyMouseButtonDown_ReturnValue_Offset), 0, IsAnyMouseButtonDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAltButtonPressed")]
	public unsafe static bool IsAltButtonPressed(FJavascriptInputEventState InputEvent)
	{
		if (!IsAltButtonPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAltButtonPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAltButtonPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAltButtonPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsAltButtonPressed_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsAltButtonPressed_InputEvent_Offset), 0, IsAltButtonPressed_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAltButtonPressed_FunctionAddress, intPtr, IsAltButtonPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAltButtonPressed_ReturnValue_Offset), 0, IsAltButtonPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAltButtonEvent")]
	public unsafe static bool IsAltButtonEvent(FJavascriptInputEventState InputEvent)
	{
		if (!IsAltButtonEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAltButtonEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAltButtonEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAltButtonEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsAltButtonEvent_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, IsAltButtonEvent_InputEvent_Offset), 0, IsAltButtonEvent_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAltButtonEvent_FunctionAddress, intPtr, IsAltButtonEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAltButtonEvent_ReturnValue_Offset), 0, IsAltButtonEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:GetKey")]
	public unsafe static FKey GetKey(FJavascriptInputEventState InputEvent)
	{
		if (!GetKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:GetKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKey_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, GetKey_InputEvent_Offset), 0, GetKey_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKey_FunctionAddress, intPtr, GetKey_ParamsSize);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetKey_ReturnValue_Offset), 0, GetKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:GetInputEvent")]
	public unsafe static EInputEventType GetInputEvent(FJavascriptInputEventState InputEvent)
	{
		if (!GetInputEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:GetInputEvent");
			return EInputEventType.IE_Pressed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputEvent_InputEvent_PropertyAddress.Address, intPtr);
		FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, GetInputEvent_InputEvent_Offset), 0, GetInputEvent_InputEvent_PropertyAddress.Address, InputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputEvent_FunctionAddress, intPtr, GetInputEvent_ParamsSize);
		return EnumMarshaler<EInputEventType>.FromNative(IntPtr.Add(intPtr, GetInputEvent_ReturnValue_Offset), 0, GetInputEvent_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptInputEventStateLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptInputEventStateLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptInputEventStateLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptInputEventStateLibrary");
		IsSpaceBarPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSpaceBarPressed");
		IsSpaceBarPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSpaceBarPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSpaceBarPressed_InputEvent_PropertyAddress, IsSpaceBarPressed_FunctionAddress, "InputEvent");
		IsSpaceBarPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsSpaceBarPressed_FunctionAddress, "InputEvent");
		IsSpaceBarPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSpaceBarPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSpaceBarPressed_ReturnValue_PropertyAddress, IsSpaceBarPressed_FunctionAddress, "ReturnValue");
		IsSpaceBarPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSpaceBarPressed_FunctionAddress, "ReturnValue");
		IsSpaceBarPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSpaceBarPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSpaceBarPressed_IsValid = IsSpaceBarPressed_FunctionAddress != IntPtr.Zero && IsSpaceBarPressed_InputEvent_IsValid && IsSpaceBarPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsSpaceBarPressed", IsSpaceBarPressed_IsValid);
		IsShiftButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsShiftButtonPressed");
		IsShiftButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShiftButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsShiftButtonPressed_InputEvent_PropertyAddress, IsShiftButtonPressed_FunctionAddress, "InputEvent");
		IsShiftButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsShiftButtonPressed_FunctionAddress, "InputEvent");
		IsShiftButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShiftButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsShiftButtonPressed_ReturnValue_PropertyAddress, IsShiftButtonPressed_FunctionAddress, "ReturnValue");
		IsShiftButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsShiftButtonPressed_FunctionAddress, "ReturnValue");
		IsShiftButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShiftButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShiftButtonPressed_IsValid = IsShiftButtonPressed_FunctionAddress != IntPtr.Zero && IsShiftButtonPressed_InputEvent_IsValid && IsShiftButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsShiftButtonPressed", IsShiftButtonPressed_IsValid);
		IsShiftButtonEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsShiftButtonEvent");
		IsShiftButtonEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShiftButtonEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsShiftButtonEvent_InputEvent_PropertyAddress, IsShiftButtonEvent_FunctionAddress, "InputEvent");
		IsShiftButtonEvent_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsShiftButtonEvent_FunctionAddress, "InputEvent");
		IsShiftButtonEvent_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShiftButtonEvent_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsShiftButtonEvent_ReturnValue_PropertyAddress, IsShiftButtonEvent_FunctionAddress, "ReturnValue");
		IsShiftButtonEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsShiftButtonEvent_FunctionAddress, "ReturnValue");
		IsShiftButtonEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShiftButtonEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShiftButtonEvent_IsValid = IsShiftButtonEvent_FunctionAddress != IntPtr.Zero && IsShiftButtonEvent_InputEvent_IsValid && IsShiftButtonEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsShiftButtonEvent", IsShiftButtonEvent_IsValid);
		IsRightMouseButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRightMouseButtonPressed");
		IsRightMouseButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRightMouseButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRightMouseButtonPressed_InputEvent_PropertyAddress, IsRightMouseButtonPressed_FunctionAddress, "InputEvent");
		IsRightMouseButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsRightMouseButtonPressed_FunctionAddress, "InputEvent");
		IsRightMouseButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRightMouseButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRightMouseButtonPressed_ReturnValue_PropertyAddress, IsRightMouseButtonPressed_FunctionAddress, "ReturnValue");
		IsRightMouseButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRightMouseButtonPressed_FunctionAddress, "ReturnValue");
		IsRightMouseButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRightMouseButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRightMouseButtonPressed_IsValid = IsRightMouseButtonPressed_FunctionAddress != IntPtr.Zero && IsRightMouseButtonPressed_InputEvent_IsValid && IsRightMouseButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsRightMouseButtonPressed", IsRightMouseButtonPressed_IsValid);
		IsMouseButtonEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsMouseButtonEvent");
		IsMouseButtonEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMouseButtonEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMouseButtonEvent_InputEvent_PropertyAddress, IsMouseButtonEvent_FunctionAddress, "InputEvent");
		IsMouseButtonEvent_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsMouseButtonEvent_FunctionAddress, "InputEvent");
		IsMouseButtonEvent_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMouseButtonEvent_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMouseButtonEvent_ReturnValue_PropertyAddress, IsMouseButtonEvent_FunctionAddress, "ReturnValue");
		IsMouseButtonEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMouseButtonEvent_FunctionAddress, "ReturnValue");
		IsMouseButtonEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMouseButtonEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMouseButtonEvent_IsValid = IsMouseButtonEvent_FunctionAddress != IntPtr.Zero && IsMouseButtonEvent_InputEvent_IsValid && IsMouseButtonEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsMouseButtonEvent", IsMouseButtonEvent_IsValid);
		IsMiddleMouseButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsMiddleMouseButtonPressed");
		IsMiddleMouseButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMiddleMouseButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMiddleMouseButtonPressed_InputEvent_PropertyAddress, IsMiddleMouseButtonPressed_FunctionAddress, "InputEvent");
		IsMiddleMouseButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsMiddleMouseButtonPressed_FunctionAddress, "InputEvent");
		IsMiddleMouseButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMiddleMouseButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMiddleMouseButtonPressed_ReturnValue_PropertyAddress, IsMiddleMouseButtonPressed_FunctionAddress, "ReturnValue");
		IsMiddleMouseButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMiddleMouseButtonPressed_FunctionAddress, "ReturnValue");
		IsMiddleMouseButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMiddleMouseButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMiddleMouseButtonPressed_IsValid = IsMiddleMouseButtonPressed_FunctionAddress != IntPtr.Zero && IsMiddleMouseButtonPressed_InputEvent_IsValid && IsMiddleMouseButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsMiddleMouseButtonPressed", IsMiddleMouseButtonPressed_IsValid);
		IsLeftMouseButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLeftMouseButtonPressed");
		IsLeftMouseButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLeftMouseButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLeftMouseButtonPressed_InputEvent_PropertyAddress, IsLeftMouseButtonPressed_FunctionAddress, "InputEvent");
		IsLeftMouseButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsLeftMouseButtonPressed_FunctionAddress, "InputEvent");
		IsLeftMouseButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLeftMouseButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLeftMouseButtonPressed_ReturnValue_PropertyAddress, IsLeftMouseButtonPressed_FunctionAddress, "ReturnValue");
		IsLeftMouseButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLeftMouseButtonPressed_FunctionAddress, "ReturnValue");
		IsLeftMouseButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLeftMouseButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLeftMouseButtonPressed_IsValid = IsLeftMouseButtonPressed_FunctionAddress != IntPtr.Zero && IsLeftMouseButtonPressed_InputEvent_IsValid && IsLeftMouseButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsLeftMouseButtonPressed", IsLeftMouseButtonPressed_IsValid);
		IsCtrlButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCtrlButtonPressed");
		IsCtrlButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCtrlButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCtrlButtonPressed_InputEvent_PropertyAddress, IsCtrlButtonPressed_FunctionAddress, "InputEvent");
		IsCtrlButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsCtrlButtonPressed_FunctionAddress, "InputEvent");
		IsCtrlButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCtrlButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCtrlButtonPressed_ReturnValue_PropertyAddress, IsCtrlButtonPressed_FunctionAddress, "ReturnValue");
		IsCtrlButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCtrlButtonPressed_FunctionAddress, "ReturnValue");
		IsCtrlButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCtrlButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCtrlButtonPressed_IsValid = IsCtrlButtonPressed_FunctionAddress != IntPtr.Zero && IsCtrlButtonPressed_InputEvent_IsValid && IsCtrlButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsCtrlButtonPressed", IsCtrlButtonPressed_IsValid);
		IsCtrlButtonEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCtrlButtonEvent");
		IsCtrlButtonEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCtrlButtonEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCtrlButtonEvent_InputEvent_PropertyAddress, IsCtrlButtonEvent_FunctionAddress, "InputEvent");
		IsCtrlButtonEvent_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsCtrlButtonEvent_FunctionAddress, "InputEvent");
		IsCtrlButtonEvent_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCtrlButtonEvent_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCtrlButtonEvent_ReturnValue_PropertyAddress, IsCtrlButtonEvent_FunctionAddress, "ReturnValue");
		IsCtrlButtonEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCtrlButtonEvent_FunctionAddress, "ReturnValue");
		IsCtrlButtonEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCtrlButtonEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCtrlButtonEvent_IsValid = IsCtrlButtonEvent_FunctionAddress != IntPtr.Zero && IsCtrlButtonEvent_InputEvent_IsValid && IsCtrlButtonEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsCtrlButtonEvent", IsCtrlButtonEvent_IsValid);
		IsButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsButtonPressed");
		IsButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsButtonPressed_InputEvent_PropertyAddress, IsButtonPressed_FunctionAddress, "InputEvent");
		IsButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsButtonPressed_FunctionAddress, "InputEvent");
		IsButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsButtonPressed_InKey_PropertyAddress, IsButtonPressed_FunctionAddress, "InKey");
		IsButtonPressed_InKey_Offset = NativeReflectionCached.GetPropertyOffset(IsButtonPressed_FunctionAddress, "InKey");
		IsButtonPressed_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(IsButtonPressed_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsButtonPressed_ReturnValue_PropertyAddress, IsButtonPressed_FunctionAddress, "ReturnValue");
		IsButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsButtonPressed_FunctionAddress, "ReturnValue");
		IsButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsButtonPressed_IsValid = IsButtonPressed_FunctionAddress != IntPtr.Zero && IsButtonPressed_InputEvent_IsValid && IsButtonPressed_InKey_IsValid && IsButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsButtonPressed", IsButtonPressed_IsValid);
		IsAnyMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAnyMouseButtonDown");
		IsAnyMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnyMouseButtonDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnyMouseButtonDown_InputEvent_PropertyAddress, IsAnyMouseButtonDown_FunctionAddress, "InputEvent");
		IsAnyMouseButtonDown_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsAnyMouseButtonDown_FunctionAddress, "InputEvent");
		IsAnyMouseButtonDown_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnyMouseButtonDown_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAnyMouseButtonDown_ReturnValue_PropertyAddress, IsAnyMouseButtonDown_FunctionAddress, "ReturnValue");
		IsAnyMouseButtonDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnyMouseButtonDown_FunctionAddress, "ReturnValue");
		IsAnyMouseButtonDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnyMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnyMouseButtonDown_IsValid = IsAnyMouseButtonDown_FunctionAddress != IntPtr.Zero && IsAnyMouseButtonDown_InputEvent_IsValid && IsAnyMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAnyMouseButtonDown", IsAnyMouseButtonDown_IsValid);
		IsAltButtonPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAltButtonPressed");
		IsAltButtonPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAltButtonPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAltButtonPressed_InputEvent_PropertyAddress, IsAltButtonPressed_FunctionAddress, "InputEvent");
		IsAltButtonPressed_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsAltButtonPressed_FunctionAddress, "InputEvent");
		IsAltButtonPressed_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltButtonPressed_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAltButtonPressed_ReturnValue_PropertyAddress, IsAltButtonPressed_FunctionAddress, "ReturnValue");
		IsAltButtonPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAltButtonPressed_FunctionAddress, "ReturnValue");
		IsAltButtonPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltButtonPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAltButtonPressed_IsValid = IsAltButtonPressed_FunctionAddress != IntPtr.Zero && IsAltButtonPressed_InputEvent_IsValid && IsAltButtonPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAltButtonPressed", IsAltButtonPressed_IsValid);
		IsAltButtonEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAltButtonEvent");
		IsAltButtonEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAltButtonEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAltButtonEvent_InputEvent_PropertyAddress, IsAltButtonEvent_FunctionAddress, "InputEvent");
		IsAltButtonEvent_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsAltButtonEvent_FunctionAddress, "InputEvent");
		IsAltButtonEvent_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltButtonEvent_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAltButtonEvent_ReturnValue_PropertyAddress, IsAltButtonEvent_FunctionAddress, "ReturnValue");
		IsAltButtonEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAltButtonEvent_FunctionAddress, "ReturnValue");
		IsAltButtonEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltButtonEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAltButtonEvent_IsValid = IsAltButtonEvent_FunctionAddress != IntPtr.Zero && IsAltButtonEvent_InputEvent_IsValid && IsAltButtonEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:IsAltButtonEvent", IsAltButtonEvent_IsValid);
		GetKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKey");
		GetKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKey_InputEvent_PropertyAddress, GetKey_FunctionAddress, "InputEvent");
		GetKey_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "InputEvent");
		GetKey_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKey_ReturnValue_PropertyAddress, GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetKey_IsValid = GetKey_FunctionAddress != IntPtr.Zero && GetKey_InputEvent_IsValid && GetKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:GetKey", GetKey_IsValid);
		GetInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputEvent");
		GetInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputEvent_InputEvent_PropertyAddress, GetInputEvent_FunctionAddress, "InputEvent");
		GetInputEvent_InputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEvent_FunctionAddress, "InputEvent");
		GetInputEvent_InputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEvent_FunctionAddress, "InputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputEvent_ReturnValue_PropertyAddress, GetInputEvent_FunctionAddress, "ReturnValue");
		GetInputEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEvent_FunctionAddress, "ReturnValue");
		GetInputEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEvent_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetInputEvent_IsValid = GetInputEvent_FunctionAddress != IntPtr.Zero && GetInputEvent_InputEvent_IsValid && GetInputEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptInputEventStateLibrary:GetInputEvent", GetInputEvent_IsValid);
	}
}
