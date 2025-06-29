using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

public sealed class ITypedElementSelectionInterfaceImpl : IInterfaceImpl, ITypedElementSelectionInterface, IInterface
{
	private static bool SelectElement_IsValid;

	private IntPtr SelectElement_InstanceFunctionAddress;

	private static IntPtr SelectElement_FunctionAddress;

	private static int SelectElement_ParamsSize;

	private static bool SelectElement_InElementHandle_IsValid;

	private static FFieldAddress SelectElement_InElementHandle_PropertyAddress;

	private static int SelectElement_InElementHandle_Offset;

	private static bool SelectElement_InSelectionSet_IsValid;

	private static FFieldAddress SelectElement_InSelectionSet_PropertyAddress;

	private static int SelectElement_InSelectionSet_Offset;

	private static bool SelectElement_InSelectionOptions_IsValid;

	private static FFieldAddress SelectElement_InSelectionOptions_PropertyAddress;

	private static int SelectElement_InSelectionOptions_Offset;

	private static bool SelectElement_ReturnValue_IsValid;

	private static FFieldAddress SelectElement_ReturnValue_PropertyAddress;

	private static int SelectElement_ReturnValue_Offset;

	private static bool IsElementSelected_IsValid;

	private IntPtr IsElementSelected_InstanceFunctionAddress;

	private static IntPtr IsElementSelected_FunctionAddress;

	private static int IsElementSelected_ParamsSize;

	private static bool IsElementSelected_InElementHandle_IsValid;

	private static FFieldAddress IsElementSelected_InElementHandle_PropertyAddress;

	private static int IsElementSelected_InElementHandle_Offset;

	private static bool IsElementSelected_InSelectionSet_IsValid;

	private static FFieldAddress IsElementSelected_InSelectionSet_PropertyAddress;

	private static int IsElementSelected_InSelectionSet_Offset;

	private static bool IsElementSelected_InSelectionOptions_IsValid;

	private static FFieldAddress IsElementSelected_InSelectionOptions_PropertyAddress;

	private static int IsElementSelected_InSelectionOptions_Offset;

	private static bool IsElementSelected_ReturnValue_IsValid;

	private static FFieldAddress IsElementSelected_ReturnValue_PropertyAddress;

	private static int IsElementSelected_ReturnValue_Offset;

	private static bool GetSelectionElement_IsValid;

	private IntPtr GetSelectionElement_InstanceFunctionAddress;

	private static IntPtr GetSelectionElement_FunctionAddress;

	private static int GetSelectionElement_ParamsSize;

	private static bool GetSelectionElement_InElementHandle_IsValid;

	private static FFieldAddress GetSelectionElement_InElementHandle_PropertyAddress;

	private static int GetSelectionElement_InElementHandle_Offset;

	private static bool GetSelectionElement_InCurrentSelection_IsValid;

	private static FFieldAddress GetSelectionElement_InCurrentSelection_PropertyAddress;

	private static int GetSelectionElement_InCurrentSelection_Offset;

	private static bool GetSelectionElement_InSelectionMethod_IsValid;

	private static FFieldAddress GetSelectionElement_InSelectionMethod_PropertyAddress;

	private static int GetSelectionElement_InSelectionMethod_Offset;

	private static bool GetSelectionElement_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionElement_ReturnValue_PropertyAddress;

	private static int GetSelectionElement_ReturnValue_Offset;

	private static bool DeselectElement_IsValid;

	private IntPtr DeselectElement_InstanceFunctionAddress;

	private static IntPtr DeselectElement_FunctionAddress;

	private static int DeselectElement_ParamsSize;

	private static bool DeselectElement_InElementHandle_IsValid;

	private static FFieldAddress DeselectElement_InElementHandle_PropertyAddress;

	private static int DeselectElement_InElementHandle_Offset;

	private static bool DeselectElement_InSelectionSet_IsValid;

	private static FFieldAddress DeselectElement_InSelectionSet_PropertyAddress;

	private static int DeselectElement_InSelectionSet_Offset;

	private static bool DeselectElement_InSelectionOptions_IsValid;

	private static FFieldAddress DeselectElement_InSelectionOptions_PropertyAddress;

	private static int DeselectElement_InSelectionOptions_Offset;

	private static bool DeselectElement_ReturnValue_IsValid;

	private static FFieldAddress DeselectElement_ReturnValue_PropertyAddress;

	private static int DeselectElement_ReturnValue_Offset;

	private static bool CanSelectElement_IsValid;

	private IntPtr CanSelectElement_InstanceFunctionAddress;

	private static IntPtr CanSelectElement_FunctionAddress;

	private static int CanSelectElement_ParamsSize;

	private static bool CanSelectElement_InElementHandle_IsValid;

	private static FFieldAddress CanSelectElement_InElementHandle_PropertyAddress;

	private static int CanSelectElement_InElementHandle_Offset;

	private static bool CanSelectElement_InSelectionOptions_IsValid;

	private static FFieldAddress CanSelectElement_InSelectionOptions_PropertyAddress;

	private static int CanSelectElement_InSelectionOptions_Offset;

	private static bool CanSelectElement_ReturnValue_IsValid;

	private static FFieldAddress CanSelectElement_ReturnValue_PropertyAddress;

	private static int CanSelectElement_ReturnValue_Offset;

	private static bool CanDeselectElement_IsValid;

	private IntPtr CanDeselectElement_InstanceFunctionAddress;

	private static IntPtr CanDeselectElement_FunctionAddress;

	private static int CanDeselectElement_ParamsSize;

	private static bool CanDeselectElement_InElementHandle_IsValid;

	private static FFieldAddress CanDeselectElement_InElementHandle_PropertyAddress;

	private static int CanDeselectElement_InElementHandle_Offset;

	private static bool CanDeselectElement_InSelectionOptions_IsValid;

	private static FFieldAddress CanDeselectElement_InSelectionOptions_PropertyAddress;

	private static int CanDeselectElement_InSelectionOptions_Offset;

	private static bool CanDeselectElement_ReturnValue_IsValid;

	private static FFieldAddress CanDeselectElement_ReturnValue_PropertyAddress;

	private static int CanDeselectElement_ReturnValue_Offset;

	private static bool AllowSelectionModifiers_IsValid;

	private IntPtr AllowSelectionModifiers_InstanceFunctionAddress;

	private static IntPtr AllowSelectionModifiers_FunctionAddress;

	private static int AllowSelectionModifiers_ParamsSize;

	private static bool AllowSelectionModifiers_InElementHandle_IsValid;

	private static FFieldAddress AllowSelectionModifiers_InElementHandle_PropertyAddress;

	private static int AllowSelectionModifiers_InElementHandle_Offset;

	private static bool AllowSelectionModifiers_InSelectionSet_IsValid;

	private static FFieldAddress AllowSelectionModifiers_InSelectionSet_PropertyAddress;

	private static int AllowSelectionModifiers_InSelectionSet_Offset;

	private static bool AllowSelectionModifiers_ReturnValue_IsValid;

	private static FFieldAddress AllowSelectionModifiers_ReturnValue_PropertyAddress;

	private static int AllowSelectionModifiers_ReturnValue_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:SelectElement")]
	public unsafe bool SelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!SelectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:SelectElement");
			return false;
		}
		if (SelectElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			SelectElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SelectElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, SelectElement_InElementHandle_Offset), 0, SelectElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(SelectElement_InSelectionSet_PropertyAddress.Address, intPtr);
		FTypedElementList.ToNative(IntPtr.Add(intPtr, SelectElement_InSelectionSet_Offset), 0, SelectElement_InSelectionSet_PropertyAddress.Address, InSelectionSet);
		NativeReflection.InitializeValue_InContainer(SelectElement_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, SelectElement_InSelectionOptions_Offset), 0, SelectElement_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectElement_InstanceFunctionAddress, intPtr, SelectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SelectElement_InSelectionSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectElement_ReturnValue_Offset), 0, SelectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:IsElementSelected")]
	public unsafe bool IsElementSelected(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet, FTypedElementIsSelectedOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!IsElementSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:IsElementSelected");
			return false;
		}
		if (IsElementSelected_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsElementSelected_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsElementSelected");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsElementSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsElementSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsElementSelected_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, IsElementSelected_InElementHandle_Offset), 0, IsElementSelected_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(IsElementSelected_InSelectionSet_PropertyAddress.Address, intPtr);
		FTypedElementList.ToNative(IntPtr.Add(intPtr, IsElementSelected_InSelectionSet_Offset), 0, IsElementSelected_InSelectionSet_PropertyAddress.Address, InSelectionSet);
		NativeReflection.InitializeValue_InContainer(IsElementSelected_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementIsSelectedOptions.ToNative(IntPtr.Add(intPtr, IsElementSelected_InSelectionOptions_Offset), 0, IsElementSelected_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsElementSelected_InstanceFunctionAddress, intPtr, IsElementSelected_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsElementSelected_InElementHandle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsElementSelected_InSelectionSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsElementSelected_ReturnValue_Offset), 0, IsElementSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:GetSelectionElement")]
	public unsafe FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle, FTypedElementList InCurrentSelection, ETypedElementSelectionMethod InSelectionMethod)
	{
		CheckDestroyed();
		if (!GetSelectionElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:GetSelectionElement");
			return default(FScriptTypedElementHandle);
		}
		if (GetSelectionElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSelectionElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSelectionElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSelectionElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetSelectionElement_InElementHandle_Offset), 0, GetSelectionElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(GetSelectionElement_InCurrentSelection_PropertyAddress.Address, intPtr);
		FTypedElementList.ToNative(IntPtr.Add(intPtr, GetSelectionElement_InCurrentSelection_Offset), 0, GetSelectionElement_InCurrentSelection_PropertyAddress.Address, InCurrentSelection);
		EnumMarshaler<ETypedElementSelectionMethod>.ToNative(IntPtr.Add(intPtr, GetSelectionElement_InSelectionMethod_Offset), 0, GetSelectionElement_InSelectionMethod_PropertyAddress.Address, InSelectionMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectionElement_InstanceFunctionAddress, intPtr, GetSelectionElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSelectionElement_InElementHandle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetSelectionElement_InCurrentSelection_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, GetSelectionElement_ReturnValue_Offset), 0, GetSelectionElement_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSelectionElement_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:DeselectElement")]
	public unsafe bool DeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!DeselectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:DeselectElement");
			return false;
		}
		if (DeselectElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			DeselectElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DeselectElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeselectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeselectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, DeselectElement_InElementHandle_Offset), 0, DeselectElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(DeselectElement_InSelectionSet_PropertyAddress.Address, intPtr);
		FTypedElementList.ToNative(IntPtr.Add(intPtr, DeselectElement_InSelectionSet_Offset), 0, DeselectElement_InSelectionSet_PropertyAddress.Address, InSelectionSet);
		NativeReflection.InitializeValue_InContainer(DeselectElement_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, DeselectElement_InSelectionOptions_Offset), 0, DeselectElement_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeselectElement_InstanceFunctionAddress, intPtr, DeselectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DeselectElement_InSelectionSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeselectElement_ReturnValue_Offset), 0, DeselectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanSelectElement")]
	public unsafe bool CanSelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!CanSelectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanSelectElement");
			return false;
		}
		if (CanSelectElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanSelectElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanSelectElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanSelectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanSelectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanSelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, CanSelectElement_InElementHandle_Offset), 0, CanSelectElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(CanSelectElement_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, CanSelectElement_InSelectionOptions_Offset), 0, CanSelectElement_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanSelectElement_InstanceFunctionAddress, intPtr, CanSelectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanSelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanSelectElement_ReturnValue_Offset), 0, CanSelectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanDeselectElement")]
	public unsafe bool CanDeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!CanDeselectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanDeselectElement");
			return false;
		}
		if (CanDeselectElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanDeselectElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanDeselectElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanDeselectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanDeselectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanDeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, CanDeselectElement_InElementHandle_Offset), 0, CanDeselectElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(CanDeselectElement_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, CanDeselectElement_InSelectionOptions_Offset), 0, CanDeselectElement_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanDeselectElement_InstanceFunctionAddress, intPtr, CanDeselectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanDeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDeselectElement_ReturnValue_Offset), 0, CanDeselectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionInterface:AllowSelectionModifiers")]
	public unsafe bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle, FTypedElementList InSelectionSet)
	{
		CheckDestroyed();
		if (!AllowSelectionModifiers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionInterface:AllowSelectionModifiers");
			return false;
		}
		if (AllowSelectionModifiers_InstanceFunctionAddress == IntPtr.Zero)
		{
			AllowSelectionModifiers_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "AllowSelectionModifiers");
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllowSelectionModifiers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllowSelectionModifiers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AllowSelectionModifiers_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, AllowSelectionModifiers_InElementHandle_Offset), 0, AllowSelectionModifiers_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(AllowSelectionModifiers_InSelectionSet_PropertyAddress.Address, intPtr);
		FTypedElementList.ToNative(IntPtr.Add(intPtr, AllowSelectionModifiers_InSelectionSet_Offset), 0, AllowSelectionModifiers_InSelectionSet_PropertyAddress.Address, InSelectionSet);
		NativeReflection.InvokeFunctionOptimized(base.Address, AllowSelectionModifiers_InstanceFunctionAddress, intPtr, AllowSelectionModifiers_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AllowSelectionModifiers_InElementHandle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AllowSelectionModifiers_InSelectionSet_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AllowSelectionModifiers_ReturnValue_Offset), 0, AllowSelectionModifiers_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		SelectElement_InstanceFunctionAddress = IntPtr.Zero;
		IsElementSelected_InstanceFunctionAddress = IntPtr.Zero;
		GetSelectionElement_InstanceFunctionAddress = IntPtr.Zero;
		DeselectElement_InstanceFunctionAddress = IntPtr.Zero;
		CanSelectElement_InstanceFunctionAddress = IntPtr.Zero;
		CanDeselectElement_InstanceFunctionAddress = IntPtr.Zero;
		AllowSelectionModifiers_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITypedElementSelectionInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITypedElementSelectionInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITypedElementSelectionInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/TypedElementRuntime.TypedElementSelectionInterface");
		SelectElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SelectElement");
		SelectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_InElementHandle_PropertyAddress, SelectElement_FunctionAddress, "InElementHandle");
		SelectElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "InElementHandle");
		SelectElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_InSelectionSet_PropertyAddress, SelectElement_FunctionAddress, "InSelectionSet");
		SelectElement_InSelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "InSelectionSet");
		SelectElement_InSelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "InSelectionSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_InSelectionOptions_PropertyAddress, SelectElement_FunctionAddress, "InSelectionOptions");
		SelectElement_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "InSelectionOptions");
		SelectElement_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_ReturnValue_PropertyAddress, SelectElement_FunctionAddress, "ReturnValue");
		SelectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "ReturnValue");
		SelectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectElement_IsValid = SelectElement_FunctionAddress != IntPtr.Zero && SelectElement_InElementHandle_IsValid && SelectElement_InSelectionSet_IsValid && SelectElement_InSelectionOptions_IsValid && SelectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:SelectElement", SelectElement_IsValid);
		IsElementSelected_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsElementSelected");
		IsElementSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsElementSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_InElementHandle_PropertyAddress, IsElementSelected_FunctionAddress, "InElementHandle");
		IsElementSelected_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "InElementHandle");
		IsElementSelected_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_InSelectionSet_PropertyAddress, IsElementSelected_FunctionAddress, "InSelectionSet");
		IsElementSelected_InSelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "InSelectionSet");
		IsElementSelected_InSelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "InSelectionSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_InSelectionOptions_PropertyAddress, IsElementSelected_FunctionAddress, "InSelectionOptions");
		IsElementSelected_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "InSelectionOptions");
		IsElementSelected_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_ReturnValue_PropertyAddress, IsElementSelected_FunctionAddress, "ReturnValue");
		IsElementSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "ReturnValue");
		IsElementSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsElementSelected_IsValid = IsElementSelected_FunctionAddress != IntPtr.Zero && IsElementSelected_InElementHandle_IsValid && IsElementSelected_InSelectionSet_IsValid && IsElementSelected_InSelectionOptions_IsValid && IsElementSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:IsElementSelected", IsElementSelected_IsValid);
		GetSelectionElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSelectionElement");
		GetSelectionElement_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_InElementHandle_PropertyAddress, GetSelectionElement_FunctionAddress, "InElementHandle");
		GetSelectionElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "InElementHandle");
		GetSelectionElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_InCurrentSelection_PropertyAddress, GetSelectionElement_FunctionAddress, "InCurrentSelection");
		GetSelectionElement_InCurrentSelection_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "InCurrentSelection");
		GetSelectionElement_InCurrentSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "InCurrentSelection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_InSelectionMethod_PropertyAddress, GetSelectionElement_FunctionAddress, "InSelectionMethod");
		GetSelectionElement_InSelectionMethod_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "InSelectionMethod");
		GetSelectionElement_InSelectionMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "InSelectionMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_ReturnValue_PropertyAddress, GetSelectionElement_FunctionAddress, "ReturnValue");
		GetSelectionElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "ReturnValue");
		GetSelectionElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSelectionElement_IsValid = GetSelectionElement_FunctionAddress != IntPtr.Zero && GetSelectionElement_InElementHandle_IsValid && GetSelectionElement_InCurrentSelection_IsValid && GetSelectionElement_InSelectionMethod_IsValid && GetSelectionElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:GetSelectionElement", GetSelectionElement_IsValid);
		DeselectElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeselectElement");
		DeselectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(DeselectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_InElementHandle_PropertyAddress, DeselectElement_FunctionAddress, "InElementHandle");
		DeselectElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "InElementHandle");
		DeselectElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_InSelectionSet_PropertyAddress, DeselectElement_FunctionAddress, "InSelectionSet");
		DeselectElement_InSelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "InSelectionSet");
		DeselectElement_InSelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "InSelectionSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_InSelectionOptions_PropertyAddress, DeselectElement_FunctionAddress, "InSelectionOptions");
		DeselectElement_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "InSelectionOptions");
		DeselectElement_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_ReturnValue_PropertyAddress, DeselectElement_FunctionAddress, "ReturnValue");
		DeselectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "ReturnValue");
		DeselectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeselectElement_IsValid = DeselectElement_FunctionAddress != IntPtr.Zero && DeselectElement_InElementHandle_IsValid && DeselectElement_InSelectionSet_IsValid && DeselectElement_InSelectionOptions_IsValid && DeselectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:DeselectElement", DeselectElement_IsValid);
		CanSelectElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanSelectElement");
		CanSelectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanSelectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanSelectElement_InElementHandle_PropertyAddress, CanSelectElement_FunctionAddress, "InElementHandle");
		CanSelectElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectElement_FunctionAddress, "InElementHandle");
		CanSelectElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectElement_InSelectionOptions_PropertyAddress, CanSelectElement_FunctionAddress, "InSelectionOptions");
		CanSelectElement_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectElement_FunctionAddress, "InSelectionOptions");
		CanSelectElement_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectElement_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectElement_ReturnValue_PropertyAddress, CanSelectElement_FunctionAddress, "ReturnValue");
		CanSelectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectElement_FunctionAddress, "ReturnValue");
		CanSelectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanSelectElement_IsValid = CanSelectElement_FunctionAddress != IntPtr.Zero && CanSelectElement_InElementHandle_IsValid && CanSelectElement_InSelectionOptions_IsValid && CanSelectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanSelectElement", CanSelectElement_IsValid);
		CanDeselectElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanDeselectElement");
		CanDeselectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanDeselectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanDeselectElement_InElementHandle_PropertyAddress, CanDeselectElement_FunctionAddress, "InElementHandle");
		CanDeselectElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(CanDeselectElement_FunctionAddress, "InElementHandle");
		CanDeselectElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDeselectElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDeselectElement_InSelectionOptions_PropertyAddress, CanDeselectElement_FunctionAddress, "InSelectionOptions");
		CanDeselectElement_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(CanDeselectElement_FunctionAddress, "InSelectionOptions");
		CanDeselectElement_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDeselectElement_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDeselectElement_ReturnValue_PropertyAddress, CanDeselectElement_FunctionAddress, "ReturnValue");
		CanDeselectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanDeselectElement_FunctionAddress, "ReturnValue");
		CanDeselectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDeselectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanDeselectElement_IsValid = CanDeselectElement_FunctionAddress != IntPtr.Zero && CanDeselectElement_InElementHandle_IsValid && CanDeselectElement_InSelectionOptions_IsValid && CanDeselectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:CanDeselectElement", CanDeselectElement_IsValid);
		AllowSelectionModifiers_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AllowSelectionModifiers");
		AllowSelectionModifiers_ParamsSize = NativeReflection.GetFunctionParamsSize(AllowSelectionModifiers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AllowSelectionModifiers_InElementHandle_PropertyAddress, AllowSelectionModifiers_FunctionAddress, "InElementHandle");
		AllowSelectionModifiers_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(AllowSelectionModifiers_FunctionAddress, "InElementHandle");
		AllowSelectionModifiers_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(AllowSelectionModifiers_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSelectionModifiers_InSelectionSet_PropertyAddress, AllowSelectionModifiers_FunctionAddress, "InSelectionSet");
		AllowSelectionModifiers_InSelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(AllowSelectionModifiers_FunctionAddress, "InSelectionSet");
		AllowSelectionModifiers_InSelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(AllowSelectionModifiers_FunctionAddress, "InSelectionSet", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSelectionModifiers_ReturnValue_PropertyAddress, AllowSelectionModifiers_FunctionAddress, "ReturnValue");
		AllowSelectionModifiers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AllowSelectionModifiers_FunctionAddress, "ReturnValue");
		AllowSelectionModifiers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AllowSelectionModifiers_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AllowSelectionModifiers_IsValid = AllowSelectionModifiers_FunctionAddress != IntPtr.Zero && AllowSelectionModifiers_InElementHandle_IsValid && AllowSelectionModifiers_InSelectionSet_IsValid && AllowSelectionModifiers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionInterface:AllowSelectionModifiers", AllowSelectionModifiers_IsValid);
	}
}
