using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.TypedElementRuntime;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet", "TypedElementRuntime", UnrealModuleType.Engine)]
public class UTypedElementSelectionSet : UObject
{
	[UDelegate]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:OnPreChangeDynamic__DelegateSignature")]
	public class FOnPreChangeDynamic : FMulticastDelegate<FOnPreChangeDynamic.Signature>
	{
		public delegate void Signature(UTypedElementSelectionSet SelectionSet);

		private static bool OnPreChangeDynamic__DelegateSignature_IsValid;

		private static IntPtr OnPreChangeDynamic__DelegateSignature_FunctionAddress;

		private static int OnPreChangeDynamic__DelegateSignature_ParamsSize;

		private static bool OnPreChangeDynamic__DelegateSignature_SelectionSet_IsValid;

		private static FFieldAddress OnPreChangeDynamic__DelegateSignature_SelectionSet_PropertyAddress;

		private static int OnPreChangeDynamic__DelegateSignature_SelectionSet_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnPreChangeDynamic()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnPreChangeDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/TypedElementRuntime.TypedElementSelectionSet:OnPreChangeDynamic__DelegateSignature");
			OnPreChangeDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreChangeDynamic__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnPreChangeDynamic__DelegateSignature_SelectionSet_PropertyAddress, OnPreChangeDynamic__DelegateSignature_FunctionAddress, "SelectionSet");
			OnPreChangeDynamic__DelegateSignature_SelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(OnPreChangeDynamic__DelegateSignature_FunctionAddress, "SelectionSet");
			OnPreChangeDynamic__DelegateSignature_SelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreChangeDynamic__DelegateSignature_FunctionAddress, "SelectionSet", Classes.FObjectProperty);
			OnPreChangeDynamic__DelegateSignature_IsValid = OnPreChangeDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPreChangeDynamic__DelegateSignature_SelectionSet_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:OnPreChangeDynamic__DelegateSignature", OnPreChangeDynamic__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UTypedElementSelectionSet SelectionSet)
		{
			if (!OnPreChangeDynamic__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:OnPreChangeDynamic__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnPreChangeDynamic__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreChangeDynamic__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UTypedElementSelectionSet>.ToNative(IntPtr.Add(intPtr, OnPreChangeDynamic__DelegateSignature_SelectionSet_Offset), 0, OnPreChangeDynamic__DelegateSignature_SelectionSet_PropertyAddress.Address, SelectionSet);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:OnChangeDynamic__DelegateSignature")]
	public class FOnChangeDynamic : FMulticastDelegate<FOnChangeDynamic.Signature>
	{
		public delegate void Signature(UTypedElementSelectionSet SelectionSet);

		private static bool OnChangeDynamic__DelegateSignature_IsValid;

		private static IntPtr OnChangeDynamic__DelegateSignature_FunctionAddress;

		private static int OnChangeDynamic__DelegateSignature_ParamsSize;

		private static bool OnChangeDynamic__DelegateSignature_SelectionSet_IsValid;

		private static FFieldAddress OnChangeDynamic__DelegateSignature_SelectionSet_PropertyAddress;

		private static int OnChangeDynamic__DelegateSignature_SelectionSet_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnChangeDynamic()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnChangeDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/TypedElementRuntime.TypedElementSelectionSet:OnChangeDynamic__DelegateSignature");
			OnChangeDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChangeDynamic__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnChangeDynamic__DelegateSignature_SelectionSet_PropertyAddress, OnChangeDynamic__DelegateSignature_FunctionAddress, "SelectionSet");
			OnChangeDynamic__DelegateSignature_SelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(OnChangeDynamic__DelegateSignature_FunctionAddress, "SelectionSet");
			OnChangeDynamic__DelegateSignature_SelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(OnChangeDynamic__DelegateSignature_FunctionAddress, "SelectionSet", Classes.FObjectProperty);
			OnChangeDynamic__DelegateSignature_IsValid = OnChangeDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnChangeDynamic__DelegateSignature_SelectionSet_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:OnChangeDynamic__DelegateSignature", OnChangeDynamic__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UTypedElementSelectionSet SelectionSet)
		{
			if (!OnChangeDynamic__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:OnChangeDynamic__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnChangeDynamic__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnChangeDynamic__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UTypedElementSelectionSet>.ToNative(IntPtr.Add(intPtr, OnChangeDynamic__DelegateSignature_SelectionSet_Offset), 0, OnChangeDynamic__DelegateSignature_SelectionSet_PropertyAddress.Address, SelectionSet);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool OnPreSelectionChange_IsValid;

	private static int OnPreSelectionChange_Offset;

	private FOnPreChangeDynamic OnPreSelectionChange_DelegateCached;

	private static bool OnSelectionChange_IsValid;

	private static int OnSelectionChange_Offset;

	private FOnChangeDynamic OnSelectionChange_DelegateCached;

	private static bool SetSelection_IsValid;

	private static IntPtr SetSelection_FunctionAddress;

	private static int SetSelection_ParamsSize;

	private static bool SetSelection_InElementHandles_IsValid;

	private static FFieldAddress SetSelection_InElementHandles_PropertyAddress;

	private static int SetSelection_InElementHandles_Offset;

	private static bool SetSelection_InSelectionOptions_IsValid;

	private static FFieldAddress SetSelection_InSelectionOptions_PropertyAddress;

	private static int SetSelection_InSelectionOptions_Offset;

	private static bool SetSelection_ReturnValue_IsValid;

	private static FFieldAddress SetSelection_ReturnValue_PropertyAddress;

	private static int SetSelection_ReturnValue_Offset;

	private static bool SelectElements_IsValid;

	private static IntPtr SelectElements_FunctionAddress;

	private static int SelectElements_ParamsSize;

	private static bool SelectElements_InElementHandles_IsValid;

	private static FFieldAddress SelectElements_InElementHandles_PropertyAddress;

	private static int SelectElements_InElementHandles_Offset;

	private static bool SelectElements_InSelectionOptions_IsValid;

	private static FFieldAddress SelectElements_InSelectionOptions_PropertyAddress;

	private static int SelectElements_InSelectionOptions_Offset;

	private static bool SelectElements_ReturnValue_IsValid;

	private static FFieldAddress SelectElements_ReturnValue_PropertyAddress;

	private static int SelectElements_ReturnValue_Offset;

	private static bool SelectElement_IsValid;

	private static IntPtr SelectElement_FunctionAddress;

	private static int SelectElement_ParamsSize;

	private static bool SelectElement_InElementHandle_IsValid;

	private static FFieldAddress SelectElement_InElementHandle_PropertyAddress;

	private static int SelectElement_InElementHandle_Offset;

	private static bool SelectElement_InSelectionOptions_IsValid;

	private static FFieldAddress SelectElement_InSelectionOptions_PropertyAddress;

	private static int SelectElement_InSelectionOptions_Offset;

	private static bool SelectElement_ReturnValue_IsValid;

	private static FFieldAddress SelectElement_ReturnValue_PropertyAddress;

	private static int SelectElement_ReturnValue_Offset;

	private static bool RestoreSelectionState_IsValid;

	private static IntPtr RestoreSelectionState_FunctionAddress;

	private static int RestoreSelectionState_ParamsSize;

	private static bool RestoreSelectionState_InSelectionState_IsValid;

	private static FFieldAddress RestoreSelectionState_InSelectionState_PropertyAddress;

	private static int RestoreSelectionState_InSelectionState_Offset;

	private static bool GetSelectedElementHandles_IsValid;

	private static IntPtr GetSelectedElementHandles_FunctionAddress;

	private static int GetSelectedElementHandles_ParamsSize;

	private static bool GetSelectedElementHandles_InBaseInterfaceType_IsValid;

	private static FFieldAddress GetSelectedElementHandles_InBaseInterfaceType_PropertyAddress;

	private static int GetSelectedElementHandles_InBaseInterfaceType_Offset;

	private static bool GetSelectedElementHandles_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedElementHandles_ReturnValue_PropertyAddress;

	private static int GetSelectedElementHandles_ReturnValue_Offset;

	private static bool IsElementSelected_IsValid;

	private static IntPtr IsElementSelected_FunctionAddress;

	private static int IsElementSelected_ParamsSize;

	private static bool IsElementSelected_InElementHandle_IsValid;

	private static FFieldAddress IsElementSelected_InElementHandle_PropertyAddress;

	private static int IsElementSelected_InElementHandle_Offset;

	private static bool IsElementSelected_InSelectionOptions_IsValid;

	private static FFieldAddress IsElementSelected_InSelectionOptions_PropertyAddress;

	private static int IsElementSelected_InSelectionOptions_Offset;

	private static bool IsElementSelected_ReturnValue_IsValid;

	private static FFieldAddress IsElementSelected_ReturnValue_PropertyAddress;

	private static int IsElementSelected_ReturnValue_Offset;

	private static bool HasSelectedObjects_IsValid;

	private static IntPtr HasSelectedObjects_FunctionAddress;

	private static int HasSelectedObjects_ParamsSize;

	private static bool HasSelectedObjects_InRequiredClass_IsValid;

	private static FFieldAddress HasSelectedObjects_InRequiredClass_PropertyAddress;

	private static int HasSelectedObjects_InRequiredClass_Offset;

	private static bool HasSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress HasSelectedObjects_ReturnValue_PropertyAddress;

	private static int HasSelectedObjects_ReturnValue_Offset;

	private static bool HasSelectedElements_IsValid;

	private static IntPtr HasSelectedElements_FunctionAddress;

	private static int HasSelectedElements_ParamsSize;

	private static bool HasSelectedElements_InBaseInterfaceType_IsValid;

	private static FFieldAddress HasSelectedElements_InBaseInterfaceType_PropertyAddress;

	private static int HasSelectedElements_InBaseInterfaceType_Offset;

	private static bool HasSelectedElements_ReturnValue_IsValid;

	private static FFieldAddress HasSelectedElements_ReturnValue_PropertyAddress;

	private static int HasSelectedElements_ReturnValue_Offset;

	private static bool GetTopSelectedObject_IsValid;

	private static IntPtr GetTopSelectedObject_FunctionAddress;

	private static int GetTopSelectedObject_ParamsSize;

	private static bool GetTopSelectedObject_InRequiredClass_IsValid;

	private static FFieldAddress GetTopSelectedObject_InRequiredClass_PropertyAddress;

	private static int GetTopSelectedObject_InRequiredClass_Offset;

	private static bool GetTopSelectedObject_ReturnValue_IsValid;

	private static FFieldAddress GetTopSelectedObject_ReturnValue_PropertyAddress;

	private static int GetTopSelectedObject_ReturnValue_Offset;

	private static bool GetSelectionElement_IsValid;

	private static IntPtr GetSelectionElement_FunctionAddress;

	private static int GetSelectionElement_ParamsSize;

	private static bool GetSelectionElement_InElementHandle_IsValid;

	private static FFieldAddress GetSelectionElement_InElementHandle_PropertyAddress;

	private static int GetSelectionElement_InElementHandle_Offset;

	private static bool GetSelectionElement_InSelectionMethod_IsValid;

	private static FFieldAddress GetSelectionElement_InSelectionMethod_PropertyAddress;

	private static int GetSelectionElement_InSelectionMethod_Offset;

	private static bool GetSelectionElement_ReturnValue_IsValid;

	private static FFieldAddress GetSelectionElement_ReturnValue_PropertyAddress;

	private static int GetSelectionElement_ReturnValue_Offset;

	private static bool GetSelectedObjects_IsValid;

	private static IntPtr GetSelectedObjects_FunctionAddress;

	private static int GetSelectedObjects_ParamsSize;

	private static bool GetSelectedObjects_InRequiredClass_IsValid;

	private static FFieldAddress GetSelectedObjects_InRequiredClass_PropertyAddress;

	private static int GetSelectedObjects_InRequiredClass_Offset;

	private static bool GetSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedObjects_ReturnValue_PropertyAddress;

	private static int GetSelectedObjects_ReturnValue_Offset;

	private static bool GetNumSelectedElements_IsValid;

	private static IntPtr GetNumSelectedElements_FunctionAddress;

	private static int GetNumSelectedElements_ParamsSize;

	private static bool GetNumSelectedElements_ReturnValue_IsValid;

	private static FFieldAddress GetNumSelectedElements_ReturnValue_PropertyAddress;

	private static int GetNumSelectedElements_ReturnValue_Offset;

	private static bool GetCurrentSelectionState_IsValid;

	private static IntPtr GetCurrentSelectionState_FunctionAddress;

	private static int GetCurrentSelectionState_ParamsSize;

	private static bool GetCurrentSelectionState_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSelectionState_ReturnValue_PropertyAddress;

	private static int GetCurrentSelectionState_ReturnValue_Offset;

	private static bool GetBottomSelectedObject_IsValid;

	private static IntPtr GetBottomSelectedObject_FunctionAddress;

	private static int GetBottomSelectedObject_ParamsSize;

	private static bool GetBottomSelectedObject_InRequiredClass_IsValid;

	private static FFieldAddress GetBottomSelectedObject_InRequiredClass_PropertyAddress;

	private static int GetBottomSelectedObject_InRequiredClass_Offset;

	private static bool GetBottomSelectedObject_ReturnValue_IsValid;

	private static FFieldAddress GetBottomSelectedObject_ReturnValue_PropertyAddress;

	private static int GetBottomSelectedObject_ReturnValue_Offset;

	private static bool DeselectElements_IsValid;

	private static IntPtr DeselectElements_FunctionAddress;

	private static int DeselectElements_ParamsSize;

	private static bool DeselectElements_InElementHandles_IsValid;

	private static FFieldAddress DeselectElements_InElementHandles_PropertyAddress;

	private static int DeselectElements_InElementHandles_Offset;

	private static bool DeselectElements_InSelectionOptions_IsValid;

	private static FFieldAddress DeselectElements_InSelectionOptions_PropertyAddress;

	private static int DeselectElements_InSelectionOptions_Offset;

	private static bool DeselectElements_ReturnValue_IsValid;

	private static FFieldAddress DeselectElements_ReturnValue_PropertyAddress;

	private static int DeselectElements_ReturnValue_Offset;

	private static bool DeselectElement_IsValid;

	private static IntPtr DeselectElement_FunctionAddress;

	private static int DeselectElement_ParamsSize;

	private static bool DeselectElement_InElementHandle_IsValid;

	private static FFieldAddress DeselectElement_InElementHandle_PropertyAddress;

	private static int DeselectElement_InElementHandle_Offset;

	private static bool DeselectElement_InSelectionOptions_IsValid;

	private static FFieldAddress DeselectElement_InSelectionOptions_PropertyAddress;

	private static int DeselectElement_InSelectionOptions_Offset;

	private static bool DeselectElement_ReturnValue_IsValid;

	private static FFieldAddress DeselectElement_ReturnValue_PropertyAddress;

	private static int DeselectElement_ReturnValue_Offset;

	private static bool CountSelectedObjects_IsValid;

	private static IntPtr CountSelectedObjects_FunctionAddress;

	private static int CountSelectedObjects_ParamsSize;

	private static bool CountSelectedObjects_InRequiredClass_IsValid;

	private static FFieldAddress CountSelectedObjects_InRequiredClass_PropertyAddress;

	private static int CountSelectedObjects_InRequiredClass_Offset;

	private static bool CountSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress CountSelectedObjects_ReturnValue_PropertyAddress;

	private static int CountSelectedObjects_ReturnValue_Offset;

	private static bool CountSelectedElements_IsValid;

	private static IntPtr CountSelectedElements_FunctionAddress;

	private static int CountSelectedElements_ParamsSize;

	private static bool CountSelectedElements_InBaseInterfaceType_IsValid;

	private static FFieldAddress CountSelectedElements_InBaseInterfaceType_PropertyAddress;

	private static int CountSelectedElements_InBaseInterfaceType_Offset;

	private static bool CountSelectedElements_ReturnValue_IsValid;

	private static FFieldAddress CountSelectedElements_ReturnValue_PropertyAddress;

	private static int CountSelectedElements_ReturnValue_Offset;

	private static bool ClearSelection_IsValid;

	private static IntPtr ClearSelection_FunctionAddress;

	private static int ClearSelection_ParamsSize;

	private static bool ClearSelection_InSelectionOptions_IsValid;

	private static FFieldAddress ClearSelection_InSelectionOptions_PropertyAddress;

	private static int ClearSelection_InSelectionOptions_Offset;

	private static bool ClearSelection_ReturnValue_IsValid;

	private static FFieldAddress ClearSelection_ReturnValue_PropertyAddress;

	private static int ClearSelection_ReturnValue_Offset;

	private static bool CanSelectElement_IsValid;

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

	private static IntPtr AllowSelectionModifiers_FunctionAddress;

	private static int AllowSelectionModifiers_ParamsSize;

	private static bool AllowSelectionModifiers_InElementHandle_IsValid;

	private static FFieldAddress AllowSelectionModifiers_InElementHandle_PropertyAddress;

	private static int AllowSelectionModifiers_InElementHandle_Offset;

	private static bool AllowSelectionModifiers_ReturnValue_IsValid;

	private static FFieldAddress AllowSelectionModifiers_ReturnValue_PropertyAddress;

	private static int AllowSelectionModifiers_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:OnPreSelectionChange")]
	public FOnPreChangeDynamic OnPreSelectionChange
	{
		get
		{
			CheckDestroyed();
			if (!OnPreSelectionChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:OnPreSelectionChange");
				return new FOnPreChangeDynamic();
			}
			if (OnPreSelectionChange_DelegateCached == null)
			{
				OnPreSelectionChange_DelegateCached = new FOnPreChangeDynamic();
				OnPreSelectionChange_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPreSelectionChange_Offset));
			}
			return OnPreSelectionChange_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:OnSelectionChange")]
	public FOnChangeDynamic OnSelectionChange
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectionChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:OnSelectionChange");
				return new FOnChangeDynamic();
			}
			if (OnSelectionChange_DelegateCached == null)
			{
				OnSelectionChange_DelegateCached = new FOnChangeDynamic();
				OnSelectionChange_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSelectionChange_Offset));
			}
			return OnSelectionChange_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:SetSelection")]
	public unsafe bool SetSelection(List<FScriptTypedElementHandle> InElementHandles, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!SetSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:SetSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FScriptTypedElementHandle>(1, SetSelection_InElementHandles_PropertyAddress, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.FromNative, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.ToNative).ToNative(IntPtr.Add(intPtr, SetSelection_InElementHandles_Offset), InElementHandles);
		NativeReflection.InitializeValue_InContainer(SetSelection_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, SetSelection_InSelectionOptions_Offset), 0, SetSelection_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelection_FunctionAddress, intPtr, SetSelection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSelection_InElementHandles_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSelection_ReturnValue_Offset), 0, SetSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:SelectElements")]
	public unsafe bool SelectElements(List<FScriptTypedElementHandle> InElementHandles, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!SelectElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:SelectElements");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FScriptTypedElementHandle>(1, SelectElements_InElementHandles_PropertyAddress, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.FromNative, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.ToNative).ToNative(IntPtr.Add(intPtr, SelectElements_InElementHandles_Offset), InElementHandles);
		NativeReflection.InitializeValue_InContainer(SelectElements_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, SelectElements_InSelectionOptions_Offset), 0, SelectElements_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectElements_FunctionAddress, intPtr, SelectElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectElements_InElementHandles_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectElements_ReturnValue_Offset), 0, SelectElements_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:SelectElement")]
	public unsafe bool SelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!SelectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:SelectElement");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, SelectElement_InElementHandle_Offset), 0, SelectElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(SelectElement_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, SelectElement_InSelectionOptions_Offset), 0, SelectElement_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectElement_FunctionAddress, intPtr, SelectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectElement_ReturnValue_Offset), 0, SelectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:RestoreSelectionState")]
	public unsafe void RestoreSelectionState(FTypedElementSelectionSetState InSelectionState)
	{
		CheckDestroyed();
		if (!RestoreSelectionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:RestoreSelectionState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestoreSelectionState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestoreSelectionState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RestoreSelectionState_InSelectionState_PropertyAddress.Address, intPtr);
		FTypedElementSelectionSetState.ToNative(IntPtr.Add(intPtr, RestoreSelectionState_InSelectionState_Offset), 0, RestoreSelectionState_InSelectionState_PropertyAddress.Address, InSelectionState);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestoreSelectionState_FunctionAddress, intPtr, RestoreSelectionState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RestoreSelectionState_InSelectionState_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1140982785u, OriginalName = "K2_GetSelectedElementHandles")]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:K2_GetSelectedElementHandles")]
	public unsafe List<FScriptTypedElementHandle> GetSelectedElementHandles(TSubclassOfInterface<IInterface> InBaseInterfaceType)
	{
		CheckDestroyed();
		if (!GetSelectedElementHandles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:K2_GetSelectedElementHandles");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedElementHandles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedElementHandles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfInterfaceMarshaler<IInterface>.ToNative(IntPtr.Add(intPtr, GetSelectedElementHandles_InBaseInterfaceType_Offset), 0, GetSelectedElementHandles_InBaseInterfaceType_PropertyAddress.Address, InBaseInterfaceType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedElementHandles_FunctionAddress, intPtr, GetSelectedElementHandles_ParamsSize);
		List<FScriptTypedElementHandle> result = new TArrayCopyMarshaler<FScriptTypedElementHandle>(1, GetSelectedElementHandles_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.FromNative, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedElementHandles_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedElementHandles_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:IsElementSelected")]
	public unsafe bool IsElementSelected(FScriptTypedElementHandle InElementHandle, FTypedElementIsSelectedOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!IsElementSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:IsElementSelected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsElementSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsElementSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsElementSelected_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, IsElementSelected_InElementHandle_Offset), 0, IsElementSelected_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(IsElementSelected_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementIsSelectedOptions.ToNative(IntPtr.Add(intPtr, IsElementSelected_InSelectionOptions_Offset), 0, IsElementSelected_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsElementSelected_FunctionAddress, intPtr, IsElementSelected_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsElementSelected_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsElementSelected_ReturnValue_Offset), 0, IsElementSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:HasSelectedObjects")]
	public unsafe bool HasSelectedObjects(TSubclassOf<UObject> InRequiredClass)
	{
		CheckDestroyed();
		if (!HasSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:HasSelectedObjects");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, HasSelectedObjects_InRequiredClass_Offset), 0, HasSelectedObjects_InRequiredClass_PropertyAddress.Address, InRequiredClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasSelectedObjects_FunctionAddress, intPtr, HasSelectedObjects_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasSelectedObjects_ReturnValue_Offset), 0, HasSelectedObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:HasSelectedElements")]
	public unsafe bool HasSelectedElements(TSubclassOfInterface<IInterface> InBaseInterfaceType)
	{
		CheckDestroyed();
		if (!HasSelectedElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:HasSelectedElements");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasSelectedElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasSelectedElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfInterfaceMarshaler<IInterface>.ToNative(IntPtr.Add(intPtr, HasSelectedElements_InBaseInterfaceType_Offset), 0, HasSelectedElements_InBaseInterfaceType_PropertyAddress.Address, InBaseInterfaceType);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasSelectedElements_FunctionAddress, intPtr, HasSelectedElements_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasSelectedElements_ReturnValue_Offset), 0, HasSelectedElements_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:GetTopSelectedObject")]
	public unsafe UObject GetTopSelectedObject(TSubclassOf<UObject> InRequiredClass)
	{
		CheckDestroyed();
		if (!GetTopSelectedObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:GetTopSelectedObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTopSelectedObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTopSelectedObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetTopSelectedObject_InRequiredClass_Offset), 0, GetTopSelectedObject_InRequiredClass_PropertyAddress.Address, InRequiredClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTopSelectedObject_FunctionAddress, intPtr, GetTopSelectedObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetTopSelectedObject_ReturnValue_Offset), 0, GetTopSelectedObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:GetSelectionElement")]
	public unsafe FScriptTypedElementHandle GetSelectionElement(FScriptTypedElementHandle InElementHandle, ETypedElementSelectionMethod InSelectionMethod)
	{
		CheckDestroyed();
		if (!GetSelectionElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:GetSelectionElement");
			return default(FScriptTypedElementHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectionElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectionElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSelectionElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetSelectionElement_InElementHandle_Offset), 0, GetSelectionElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		EnumMarshaler<ETypedElementSelectionMethod>.ToNative(IntPtr.Add(intPtr, GetSelectionElement_InSelectionMethod_Offset), 0, GetSelectionElement_InSelectionMethod_PropertyAddress.Address, InSelectionMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectionElement_FunctionAddress, intPtr, GetSelectionElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSelectionElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, GetSelectionElement_ReturnValue_Offset), 0, GetSelectionElement_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSelectionElement_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:GetSelectedObjects")]
	public unsafe List<UObject> GetSelectedObjects(TSubclassOf<UObject> InRequiredClass)
	{
		CheckDestroyed();
		if (!GetSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:GetSelectedObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetSelectedObjects_InRequiredClass_Offset), 0, GetSelectedObjects_InRequiredClass_PropertyAddress.Address, InRequiredClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedObjects_FunctionAddress, intPtr, GetSelectedObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetSelectedObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:GetNumSelectedElements")]
	public unsafe int GetNumSelectedElements()
	{
		CheckDestroyed();
		if (!GetNumSelectedElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:GetNumSelectedElements");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumSelectedElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumSelectedElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumSelectedElements_FunctionAddress, intPtr, GetNumSelectedElements_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumSelectedElements_ReturnValue_Offset), 0, GetNumSelectedElements_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:GetCurrentSelectionState")]
	public unsafe FTypedElementSelectionSetState GetCurrentSelectionState()
	{
		CheckDestroyed();
		if (!GetCurrentSelectionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:GetCurrentSelectionState");
			return default(FTypedElementSelectionSetState);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSelectionState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSelectionState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentSelectionState_FunctionAddress, intPtr, GetCurrentSelectionState_ParamsSize);
		FTypedElementSelectionSetState result = FTypedElementSelectionSetState.FromNative(IntPtr.Add(intPtr, GetCurrentSelectionState_ReturnValue_Offset), 0, GetCurrentSelectionState_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentSelectionState_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:GetBottomSelectedObject")]
	public unsafe UObject GetBottomSelectedObject(TSubclassOf<UObject> InRequiredClass)
	{
		CheckDestroyed();
		if (!GetBottomSelectedObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:GetBottomSelectedObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBottomSelectedObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBottomSelectedObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetBottomSelectedObject_InRequiredClass_Offset), 0, GetBottomSelectedObject_InRequiredClass_PropertyAddress.Address, InRequiredClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBottomSelectedObject_FunctionAddress, intPtr, GetBottomSelectedObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetBottomSelectedObject_ReturnValue_Offset), 0, GetBottomSelectedObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:DeselectElements")]
	public unsafe bool DeselectElements(List<FScriptTypedElementHandle> InElementHandles, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!DeselectElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:DeselectElements");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeselectElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeselectElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FScriptTypedElementHandle>(1, DeselectElements_InElementHandles_PropertyAddress, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.FromNative, CachedMarshalingDelegates<FScriptTypedElementHandle, FScriptTypedElementHandle>.ToNative).ToNative(IntPtr.Add(intPtr, DeselectElements_InElementHandles_Offset), InElementHandles);
		NativeReflection.InitializeValue_InContainer(DeselectElements_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, DeselectElements_InSelectionOptions_Offset), 0, DeselectElements_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeselectElements_FunctionAddress, intPtr, DeselectElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeselectElements_InElementHandles_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeselectElements_ReturnValue_Offset), 0, DeselectElements_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:DeselectElement")]
	public unsafe bool DeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!DeselectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:DeselectElement");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeselectElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeselectElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, DeselectElement_InElementHandle_Offset), 0, DeselectElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(DeselectElement_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, DeselectElement_InSelectionOptions_Offset), 0, DeselectElement_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeselectElement_FunctionAddress, intPtr, DeselectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeselectElement_ReturnValue_Offset), 0, DeselectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:CountSelectedObjects")]
	public unsafe int CountSelectedObjects(TSubclassOf<UObject> InRequiredClass)
	{
		CheckDestroyed();
		if (!CountSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:CountSelectedObjects");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CountSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CountSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CountSelectedObjects_InRequiredClass_Offset), 0, CountSelectedObjects_InRequiredClass_PropertyAddress.Address, InRequiredClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, CountSelectedObjects_FunctionAddress, intPtr, CountSelectedObjects_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CountSelectedObjects_ReturnValue_Offset), 0, CountSelectedObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:CountSelectedElements")]
	public unsafe int CountSelectedElements(TSubclassOfInterface<IInterface> InBaseInterfaceType)
	{
		CheckDestroyed();
		if (!CountSelectedElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:CountSelectedElements");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CountSelectedElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CountSelectedElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfInterfaceMarshaler<IInterface>.ToNative(IntPtr.Add(intPtr, CountSelectedElements_InBaseInterfaceType_Offset), 0, CountSelectedElements_InBaseInterfaceType_PropertyAddress.Address, InBaseInterfaceType);
		NativeReflection.InvokeFunctionOptimized(base.Address, CountSelectedElements_FunctionAddress, intPtr, CountSelectedElements_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CountSelectedElements_ReturnValue_Offset), 0, CountSelectedElements_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:ClearSelection")]
	public unsafe bool ClearSelection(FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!ClearSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:ClearSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearSelection_InSelectionOptions_PropertyAddress.Address, intPtr);
		FTypedElementSelectionOptions.ToNative(IntPtr.Add(intPtr, ClearSelection_InSelectionOptions_Offset), 0, ClearSelection_InSelectionOptions_PropertyAddress.Address, InSelectionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearSelection_FunctionAddress, intPtr, ClearSelection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ClearSelection_ReturnValue_Offset), 0, ClearSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:CanSelectElement")]
	public unsafe bool CanSelectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!CanSelectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:CanSelectElement");
			return false;
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
		NativeReflection.InvokeFunctionOptimized(base.Address, CanSelectElement_FunctionAddress, intPtr, CanSelectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanSelectElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanSelectElement_ReturnValue_Offset), 0, CanSelectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:CanDeselectElement")]
	public unsafe bool CanDeselectElement(FScriptTypedElementHandle InElementHandle, FTypedElementSelectionOptions InSelectionOptions)
	{
		CheckDestroyed();
		if (!CanDeselectElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:CanDeselectElement");
			return false;
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
		NativeReflection.InvokeFunctionOptimized(base.Address, CanDeselectElement_FunctionAddress, intPtr, CanDeselectElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanDeselectElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDeselectElement_ReturnValue_Offset), 0, CanDeselectElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/TypedElementRuntime.TypedElementSelectionSet:AllowSelectionModifiers")]
	public unsafe bool AllowSelectionModifiers(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!AllowSelectionModifiers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TypedElementRuntime.TypedElementSelectionSet:AllowSelectionModifiers");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllowSelectionModifiers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllowSelectionModifiers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AllowSelectionModifiers_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, AllowSelectionModifiers_InElementHandle_Offset), 0, AllowSelectionModifiers_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, AllowSelectionModifiers_FunctionAddress, intPtr, AllowSelectionModifiers_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AllowSelectionModifiers_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AllowSelectionModifiers_ReturnValue_Offset), 0, AllowSelectionModifiers_ReturnValue_PropertyAddress.Address);
	}

	static UTypedElementSelectionSet()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTypedElementSelectionSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTypedElementSelectionSet));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/TypedElementRuntime.TypedElementSelectionSet");
		OnPreSelectionChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPreSelectionChange");
		OnPreSelectionChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPreSelectionChange", Classes.FMulticastDelegateProperty);
		OnSelectionChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSelectionChange");
		OnSelectionChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSelectionChange", Classes.FMulticastDelegateProperty);
		SetSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelection");
		SetSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_InElementHandles_PropertyAddress, SetSelection_FunctionAddress, "InElementHandles");
		SetSelection_InElementHandles_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "InElementHandles");
		SetSelection_InElementHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "InElementHandles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_InSelectionOptions_PropertyAddress, SetSelection_FunctionAddress, "InSelectionOptions");
		SetSelection_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "InSelectionOptions");
		SetSelection_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSelection_ReturnValue_PropertyAddress, SetSelection_FunctionAddress, "ReturnValue");
		SetSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSelection_FunctionAddress, "ReturnValue");
		SetSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSelection_IsValid = SetSelection_FunctionAddress != IntPtr.Zero && SetSelection_InElementHandles_IsValid && SetSelection_InSelectionOptions_IsValid && SetSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:SetSelection", SetSelection_IsValid);
		SelectElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectElements");
		SelectElements_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectElements_InElementHandles_PropertyAddress, SelectElements_FunctionAddress, "InElementHandles");
		SelectElements_InElementHandles_Offset = NativeReflectionCached.GetPropertyOffset(SelectElements_FunctionAddress, "InElementHandles");
		SelectElements_InElementHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElements_FunctionAddress, "InElementHandles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElements_InSelectionOptions_PropertyAddress, SelectElements_FunctionAddress, "InSelectionOptions");
		SelectElements_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SelectElements_FunctionAddress, "InSelectionOptions");
		SelectElements_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElements_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElements_ReturnValue_PropertyAddress, SelectElements_FunctionAddress, "ReturnValue");
		SelectElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectElements_FunctionAddress, "ReturnValue");
		SelectElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElements_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectElements_IsValid = SelectElements_FunctionAddress != IntPtr.Zero && SelectElements_InElementHandles_IsValid && SelectElements_InSelectionOptions_IsValid && SelectElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:SelectElements", SelectElements_IsValid);
		SelectElement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectElement");
		SelectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_InElementHandle_PropertyAddress, SelectElement_FunctionAddress, "InElementHandle");
		SelectElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "InElementHandle");
		SelectElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_InSelectionOptions_PropertyAddress, SelectElement_FunctionAddress, "InSelectionOptions");
		SelectElement_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "InSelectionOptions");
		SelectElement_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectElement_ReturnValue_PropertyAddress, SelectElement_FunctionAddress, "ReturnValue");
		SelectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectElement_FunctionAddress, "ReturnValue");
		SelectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectElement_IsValid = SelectElement_FunctionAddress != IntPtr.Zero && SelectElement_InElementHandle_IsValid && SelectElement_InSelectionOptions_IsValid && SelectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:SelectElement", SelectElement_IsValid);
		RestoreSelectionState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestoreSelectionState");
		RestoreSelectionState_ParamsSize = NativeReflection.GetFunctionParamsSize(RestoreSelectionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestoreSelectionState_InSelectionState_PropertyAddress, RestoreSelectionState_FunctionAddress, "InSelectionState");
		RestoreSelectionState_InSelectionState_Offset = NativeReflectionCached.GetPropertyOffset(RestoreSelectionState_FunctionAddress, "InSelectionState");
		RestoreSelectionState_InSelectionState_IsValid = NativeReflectionCached.ValidatePropertyClass(RestoreSelectionState_FunctionAddress, "InSelectionState", Classes.FStructProperty);
		RestoreSelectionState_IsValid = RestoreSelectionState_FunctionAddress != IntPtr.Zero && RestoreSelectionState_InSelectionState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:RestoreSelectionState", RestoreSelectionState_IsValid);
		GetSelectedElementHandles_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetSelectedElementHandles");
		GetSelectedElementHandles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedElementHandles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedElementHandles_InBaseInterfaceType_PropertyAddress, GetSelectedElementHandles_FunctionAddress, "InBaseInterfaceType");
		GetSelectedElementHandles_InBaseInterfaceType_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedElementHandles_FunctionAddress, "InBaseInterfaceType");
		GetSelectedElementHandles_InBaseInterfaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedElementHandles_FunctionAddress, "InBaseInterfaceType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedElementHandles_ReturnValue_PropertyAddress, GetSelectedElementHandles_FunctionAddress, "ReturnValue");
		GetSelectedElementHandles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedElementHandles_FunctionAddress, "ReturnValue");
		GetSelectedElementHandles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedElementHandles_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedElementHandles_IsValid = GetSelectedElementHandles_FunctionAddress != IntPtr.Zero && GetSelectedElementHandles_InBaseInterfaceType_IsValid && GetSelectedElementHandles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:K2_GetSelectedElementHandles", GetSelectedElementHandles_IsValid);
		IsElementSelected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsElementSelected");
		IsElementSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsElementSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_InElementHandle_PropertyAddress, IsElementSelected_FunctionAddress, "InElementHandle");
		IsElementSelected_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "InElementHandle");
		IsElementSelected_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_InSelectionOptions_PropertyAddress, IsElementSelected_FunctionAddress, "InSelectionOptions");
		IsElementSelected_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "InSelectionOptions");
		IsElementSelected_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsElementSelected_ReturnValue_PropertyAddress, IsElementSelected_FunctionAddress, "ReturnValue");
		IsElementSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsElementSelected_FunctionAddress, "ReturnValue");
		IsElementSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsElementSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsElementSelected_IsValid = IsElementSelected_FunctionAddress != IntPtr.Zero && IsElementSelected_InElementHandle_IsValid && IsElementSelected_InSelectionOptions_IsValid && IsElementSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:IsElementSelected", IsElementSelected_IsValid);
		HasSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasSelectedObjects");
		HasSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(HasSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasSelectedObjects_InRequiredClass_PropertyAddress, HasSelectedObjects_FunctionAddress, "InRequiredClass");
		HasSelectedObjects_InRequiredClass_Offset = NativeReflectionCached.GetPropertyOffset(HasSelectedObjects_FunctionAddress, "InRequiredClass");
		HasSelectedObjects_InRequiredClass_IsValid = NativeReflectionCached.ValidatePropertyClass(HasSelectedObjects_FunctionAddress, "InRequiredClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref HasSelectedObjects_ReturnValue_PropertyAddress, HasSelectedObjects_FunctionAddress, "ReturnValue");
		HasSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasSelectedObjects_FunctionAddress, "ReturnValue");
		HasSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasSelectedObjects_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasSelectedObjects_IsValid = HasSelectedObjects_FunctionAddress != IntPtr.Zero && HasSelectedObjects_InRequiredClass_IsValid && HasSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:HasSelectedObjects", HasSelectedObjects_IsValid);
		HasSelectedElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasSelectedElements");
		HasSelectedElements_ParamsSize = NativeReflection.GetFunctionParamsSize(HasSelectedElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasSelectedElements_InBaseInterfaceType_PropertyAddress, HasSelectedElements_FunctionAddress, "InBaseInterfaceType");
		HasSelectedElements_InBaseInterfaceType_Offset = NativeReflectionCached.GetPropertyOffset(HasSelectedElements_FunctionAddress, "InBaseInterfaceType");
		HasSelectedElements_InBaseInterfaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(HasSelectedElements_FunctionAddress, "InBaseInterfaceType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref HasSelectedElements_ReturnValue_PropertyAddress, HasSelectedElements_FunctionAddress, "ReturnValue");
		HasSelectedElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasSelectedElements_FunctionAddress, "ReturnValue");
		HasSelectedElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasSelectedElements_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasSelectedElements_IsValid = HasSelectedElements_FunctionAddress != IntPtr.Zero && HasSelectedElements_InBaseInterfaceType_IsValid && HasSelectedElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:HasSelectedElements", HasSelectedElements_IsValid);
		GetTopSelectedObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTopSelectedObject");
		GetTopSelectedObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTopSelectedObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTopSelectedObject_InRequiredClass_PropertyAddress, GetTopSelectedObject_FunctionAddress, "InRequiredClass");
		GetTopSelectedObject_InRequiredClass_Offset = NativeReflectionCached.GetPropertyOffset(GetTopSelectedObject_FunctionAddress, "InRequiredClass");
		GetTopSelectedObject_InRequiredClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopSelectedObject_FunctionAddress, "InRequiredClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTopSelectedObject_ReturnValue_PropertyAddress, GetTopSelectedObject_FunctionAddress, "ReturnValue");
		GetTopSelectedObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTopSelectedObject_FunctionAddress, "ReturnValue");
		GetTopSelectedObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopSelectedObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTopSelectedObject_IsValid = GetTopSelectedObject_FunctionAddress != IntPtr.Zero && GetTopSelectedObject_InRequiredClass_IsValid && GetTopSelectedObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:GetTopSelectedObject", GetTopSelectedObject_IsValid);
		GetSelectionElement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectionElement");
		GetSelectionElement_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectionElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_InElementHandle_PropertyAddress, GetSelectionElement_FunctionAddress, "InElementHandle");
		GetSelectionElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "InElementHandle");
		GetSelectionElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_InSelectionMethod_PropertyAddress, GetSelectionElement_FunctionAddress, "InSelectionMethod");
		GetSelectionElement_InSelectionMethod_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "InSelectionMethod");
		GetSelectionElement_InSelectionMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "InSelectionMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectionElement_ReturnValue_PropertyAddress, GetSelectionElement_FunctionAddress, "ReturnValue");
		GetSelectionElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectionElement_FunctionAddress, "ReturnValue");
		GetSelectionElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectionElement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSelectionElement_IsValid = GetSelectionElement_FunctionAddress != IntPtr.Zero && GetSelectionElement_InElementHandle_IsValid && GetSelectionElement_InSelectionMethod_IsValid && GetSelectionElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:GetSelectionElement", GetSelectionElement_IsValid);
		GetSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedObjects");
		GetSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_InRequiredClass_PropertyAddress, GetSelectedObjects_FunctionAddress, "InRequiredClass");
		GetSelectedObjects_InRequiredClass_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "InRequiredClass");
		GetSelectedObjects_InRequiredClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "InRequiredClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_ReturnValue_PropertyAddress, GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedObjects_IsValid = GetSelectedObjects_FunctionAddress != IntPtr.Zero && GetSelectedObjects_InRequiredClass_IsValid && GetSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:GetSelectedObjects", GetSelectedObjects_IsValid);
		GetNumSelectedElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumSelectedElements");
		GetNumSelectedElements_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumSelectedElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumSelectedElements_ReturnValue_PropertyAddress, GetNumSelectedElements_FunctionAddress, "ReturnValue");
		GetNumSelectedElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumSelectedElements_FunctionAddress, "ReturnValue");
		GetNumSelectedElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumSelectedElements_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumSelectedElements_IsValid = GetNumSelectedElements_FunctionAddress != IntPtr.Zero && GetNumSelectedElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:GetNumSelectedElements", GetNumSelectedElements_IsValid);
		GetCurrentSelectionState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentSelectionState");
		GetCurrentSelectionState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSelectionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSelectionState_ReturnValue_PropertyAddress, GetCurrentSelectionState_FunctionAddress, "ReturnValue");
		GetCurrentSelectionState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSelectionState_FunctionAddress, "ReturnValue");
		GetCurrentSelectionState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSelectionState_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentSelectionState_IsValid = GetCurrentSelectionState_FunctionAddress != IntPtr.Zero && GetCurrentSelectionState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:GetCurrentSelectionState", GetCurrentSelectionState_IsValid);
		GetBottomSelectedObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBottomSelectedObject");
		GetBottomSelectedObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBottomSelectedObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBottomSelectedObject_InRequiredClass_PropertyAddress, GetBottomSelectedObject_FunctionAddress, "InRequiredClass");
		GetBottomSelectedObject_InRequiredClass_Offset = NativeReflectionCached.GetPropertyOffset(GetBottomSelectedObject_FunctionAddress, "InRequiredClass");
		GetBottomSelectedObject_InRequiredClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBottomSelectedObject_FunctionAddress, "InRequiredClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBottomSelectedObject_ReturnValue_PropertyAddress, GetBottomSelectedObject_FunctionAddress, "ReturnValue");
		GetBottomSelectedObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBottomSelectedObject_FunctionAddress, "ReturnValue");
		GetBottomSelectedObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBottomSelectedObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBottomSelectedObject_IsValid = GetBottomSelectedObject_FunctionAddress != IntPtr.Zero && GetBottomSelectedObject_InRequiredClass_IsValid && GetBottomSelectedObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:GetBottomSelectedObject", GetBottomSelectedObject_IsValid);
		DeselectElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeselectElements");
		DeselectElements_ParamsSize = NativeReflection.GetFunctionParamsSize(DeselectElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeselectElements_InElementHandles_PropertyAddress, DeselectElements_FunctionAddress, "InElementHandles");
		DeselectElements_InElementHandles_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElements_FunctionAddress, "InElementHandles");
		DeselectElements_InElementHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElements_FunctionAddress, "InElementHandles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElements_InSelectionOptions_PropertyAddress, DeselectElements_FunctionAddress, "InSelectionOptions");
		DeselectElements_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElements_FunctionAddress, "InSelectionOptions");
		DeselectElements_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElements_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElements_ReturnValue_PropertyAddress, DeselectElements_FunctionAddress, "ReturnValue");
		DeselectElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElements_FunctionAddress, "ReturnValue");
		DeselectElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElements_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeselectElements_IsValid = DeselectElements_FunctionAddress != IntPtr.Zero && DeselectElements_InElementHandles_IsValid && DeselectElements_InSelectionOptions_IsValid && DeselectElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:DeselectElements", DeselectElements_IsValid);
		DeselectElement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeselectElement");
		DeselectElement_ParamsSize = NativeReflection.GetFunctionParamsSize(DeselectElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_InElementHandle_PropertyAddress, DeselectElement_FunctionAddress, "InElementHandle");
		DeselectElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "InElementHandle");
		DeselectElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_InSelectionOptions_PropertyAddress, DeselectElement_FunctionAddress, "InSelectionOptions");
		DeselectElement_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "InSelectionOptions");
		DeselectElement_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectElement_ReturnValue_PropertyAddress, DeselectElement_FunctionAddress, "ReturnValue");
		DeselectElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeselectElement_FunctionAddress, "ReturnValue");
		DeselectElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeselectElement_IsValid = DeselectElement_FunctionAddress != IntPtr.Zero && DeselectElement_InElementHandle_IsValid && DeselectElement_InSelectionOptions_IsValid && DeselectElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:DeselectElement", DeselectElement_IsValid);
		CountSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CountSelectedObjects");
		CountSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(CountSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CountSelectedObjects_InRequiredClass_PropertyAddress, CountSelectedObjects_FunctionAddress, "InRequiredClass");
		CountSelectedObjects_InRequiredClass_Offset = NativeReflectionCached.GetPropertyOffset(CountSelectedObjects_FunctionAddress, "InRequiredClass");
		CountSelectedObjects_InRequiredClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CountSelectedObjects_FunctionAddress, "InRequiredClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CountSelectedObjects_ReturnValue_PropertyAddress, CountSelectedObjects_FunctionAddress, "ReturnValue");
		CountSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CountSelectedObjects_FunctionAddress, "ReturnValue");
		CountSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CountSelectedObjects_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CountSelectedObjects_IsValid = CountSelectedObjects_FunctionAddress != IntPtr.Zero && CountSelectedObjects_InRequiredClass_IsValid && CountSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:CountSelectedObjects", CountSelectedObjects_IsValid);
		CountSelectedElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CountSelectedElements");
		CountSelectedElements_ParamsSize = NativeReflection.GetFunctionParamsSize(CountSelectedElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CountSelectedElements_InBaseInterfaceType_PropertyAddress, CountSelectedElements_FunctionAddress, "InBaseInterfaceType");
		CountSelectedElements_InBaseInterfaceType_Offset = NativeReflectionCached.GetPropertyOffset(CountSelectedElements_FunctionAddress, "InBaseInterfaceType");
		CountSelectedElements_InBaseInterfaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(CountSelectedElements_FunctionAddress, "InBaseInterfaceType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CountSelectedElements_ReturnValue_PropertyAddress, CountSelectedElements_FunctionAddress, "ReturnValue");
		CountSelectedElements_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CountSelectedElements_FunctionAddress, "ReturnValue");
		CountSelectedElements_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CountSelectedElements_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CountSelectedElements_IsValid = CountSelectedElements_FunctionAddress != IntPtr.Zero && CountSelectedElements_InBaseInterfaceType_IsValid && CountSelectedElements_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:CountSelectedElements", CountSelectedElements_IsValid);
		ClearSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSelection");
		ClearSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearSelection_InSelectionOptions_PropertyAddress, ClearSelection_FunctionAddress, "InSelectionOptions");
		ClearSelection_InSelectionOptions_Offset = NativeReflectionCached.GetPropertyOffset(ClearSelection_FunctionAddress, "InSelectionOptions");
		ClearSelection_InSelectionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSelection_FunctionAddress, "InSelectionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearSelection_ReturnValue_PropertyAddress, ClearSelection_FunctionAddress, "ReturnValue");
		ClearSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearSelection_FunctionAddress, "ReturnValue");
		ClearSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ClearSelection_IsValid = ClearSelection_FunctionAddress != IntPtr.Zero && ClearSelection_InSelectionOptions_IsValid && ClearSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:ClearSelection", ClearSelection_IsValid);
		CanSelectElement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanSelectElement");
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
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:CanSelectElement", CanSelectElement_IsValid);
		CanDeselectElement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanDeselectElement");
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
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:CanDeselectElement", CanDeselectElement_IsValid);
		AllowSelectionModifiers_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AllowSelectionModifiers");
		AllowSelectionModifiers_ParamsSize = NativeReflection.GetFunctionParamsSize(AllowSelectionModifiers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AllowSelectionModifiers_InElementHandle_PropertyAddress, AllowSelectionModifiers_FunctionAddress, "InElementHandle");
		AllowSelectionModifiers_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(AllowSelectionModifiers_FunctionAddress, "InElementHandle");
		AllowSelectionModifiers_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(AllowSelectionModifiers_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSelectionModifiers_ReturnValue_PropertyAddress, AllowSelectionModifiers_FunctionAddress, "ReturnValue");
		AllowSelectionModifiers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AllowSelectionModifiers_FunctionAddress, "ReturnValue");
		AllowSelectionModifiers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AllowSelectionModifiers_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AllowSelectionModifiers_IsValid = AllowSelectionModifiers_FunctionAddress != IntPtr.Zero && AllowSelectionModifiers_InElementHandle_IsValid && AllowSelectionModifiers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TypedElementRuntime.TypedElementSelectionSet:AllowSelectionModifiers", AllowSelectionModifiers_IsValid);
	}
}
