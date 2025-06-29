using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ControlRig.ControlRigShapeActor", "ControlRig", UnrealModuleType.EnginePlugin)]
public class AControlRigShapeActor : AActor
{
	private static bool StaticMeshComponent_IsValid;

	private static int StaticMeshComponent_Offset;

	private static bool SetSelected_IsValid;

	private static IntPtr SetSelected_FunctionAddress;

	private static int SetSelected_ParamsSize;

	private static bool SetSelected_bInSelected_IsValid;

	private static FFieldAddress SetSelected_bInSelected_PropertyAddress;

	private static int SetSelected_bInSelected_Offset;

	private static bool SetSelectable_IsValid;

	private static IntPtr SetSelectable_FunctionAddress;

	private static int SetSelectable_ParamsSize;

	private static bool SetSelectable_bInSelectable_IsValid;

	private static FFieldAddress SetSelectable_bInSelectable_PropertyAddress;

	private static int SetSelectable_bInSelectable_Offset;

	private static bool SetHovered_IsValid;

	private static IntPtr SetHovered_FunctionAddress;

	private static int SetHovered_ParamsSize;

	private static bool SetHovered_bInHovered_IsValid;

	private static FFieldAddress SetHovered_bInHovered_PropertyAddress;

	private static int SetHovered_bInHovered_Offset;

	private static bool SetGlobalTransform_IsValid;

	private static IntPtr SetGlobalTransform_FunctionAddress;

	private static int SetGlobalTransform_ParamsSize;

	private static bool SetGlobalTransform_InTransform_IsValid;

	private static FFieldAddress SetGlobalTransform_InTransform_PropertyAddress;

	private static int SetGlobalTransform_InTransform_Offset;

	private static bool SetEnabled_IsValid;

	private static IntPtr SetEnabled_FunctionAddress;

	private static int SetEnabled_ParamsSize;

	private static bool SetEnabled_bInEnabled_IsValid;

	private static FFieldAddress SetEnabled_bInEnabled_PropertyAddress;

	private static int SetEnabled_bInEnabled_Offset;

	private static bool OnTransformChanged_IsValid;

	private IntPtr OnTransformChanged_InstanceFunctionAddress;

	private static IntPtr OnTransformChanged_FunctionAddress;

	private static int OnTransformChanged_ParamsSize;

	private static bool OnTransformChanged_NewTransform_IsValid;

	private static FFieldAddress OnTransformChanged_NewTransform_PropertyAddress;

	private static int OnTransformChanged_NewTransform_Offset;

	private static bool OnSelectionChanged_IsValid;

	private IntPtr OnSelectionChanged_InstanceFunctionAddress;

	private static IntPtr OnSelectionChanged_FunctionAddress;

	private static int OnSelectionChanged_ParamsSize;

	private static bool OnSelectionChanged_bIsSelected_IsValid;

	private static FFieldAddress OnSelectionChanged_bIsSelected_PropertyAddress;

	private static int OnSelectionChanged_bIsSelected_Offset;

	private static bool OnManipulatingChanged_IsValid;

	private IntPtr OnManipulatingChanged_InstanceFunctionAddress;

	private static IntPtr OnManipulatingChanged_FunctionAddress;

	private static int OnManipulatingChanged_ParamsSize;

	private static bool OnManipulatingChanged_bIsManipulating_IsValid;

	private static FFieldAddress OnManipulatingChanged_bIsManipulating_PropertyAddress;

	private static int OnManipulatingChanged_bIsManipulating_Offset;

	private static bool OnHoveredChanged_IsValid;

	private IntPtr OnHoveredChanged_InstanceFunctionAddress;

	private static IntPtr OnHoveredChanged_FunctionAddress;

	private static int OnHoveredChanged_ParamsSize;

	private static bool OnHoveredChanged_bIsSelected_IsValid;

	private static FFieldAddress OnHoveredChanged_bIsSelected_PropertyAddress;

	private static int OnHoveredChanged_bIsSelected_Offset;

	private static bool OnEnabledChanged_IsValid;

	private IntPtr OnEnabledChanged_InstanceFunctionAddress;

	private static IntPtr OnEnabledChanged_FunctionAddress;

	private static int OnEnabledChanged_ParamsSize;

	private static bool OnEnabledChanged_bIsEnabled_IsValid;

	private static FFieldAddress OnEnabledChanged_bIsEnabled_PropertyAddress;

	private static int OnEnabledChanged_bIsEnabled_Offset;

	private static bool IsSelectedInEditor_IsValid;

	private static IntPtr IsSelectedInEditor_FunctionAddress;

	private static int IsSelectedInEditor_ParamsSize;

	private static bool IsSelectedInEditor_ReturnValue_IsValid;

	private static FFieldAddress IsSelectedInEditor_ReturnValue_PropertyAddress;

	private static int IsSelectedInEditor_ReturnValue_Offset;

	private static bool IsHovered_IsValid;

	private static IntPtr IsHovered_FunctionAddress;

	private static int IsHovered_ParamsSize;

	private static bool IsHovered_ReturnValue_IsValid;

	private static FFieldAddress IsHovered_ReturnValue_PropertyAddress;

	private static int IsHovered_ReturnValue_Offset;

	private static bool IsEnabled_IsValid;

	private static IntPtr IsEnabled_FunctionAddress;

	private static int IsEnabled_ParamsSize;

	private static bool IsEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsEnabled_ReturnValue_PropertyAddress;

	private static int IsEnabled_ReturnValue_Offset;

	private static bool GetGlobalTransform_IsValid;

	private static IntPtr GetGlobalTransform_FunctionAddress;

	private static int GetGlobalTransform_ParamsSize;

	private static bool GetGlobalTransform_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalTransform_ReturnValue_PropertyAddress;

	private static int GetGlobalTransform_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:StaticMeshComponent")]
	public UStaticMeshComponent StaticMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigShapeActor:StaticMeshComponent");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, StaticMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigShapeActor:StaticMeshComponent");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, StaticMeshComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:SetSelected")]
	public unsafe void SetSelected(bool bInSelected)
	{
		CheckDestroyed();
		if (!SetSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:SetSelected");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSelected_bInSelected_Offset), 0, SetSelected_bInSelected_PropertyAddress.Address, bInSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelected_FunctionAddress, intPtr, SetSelected_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:SetSelectable")]
	public unsafe void SetSelectable(bool bInSelectable)
	{
		CheckDestroyed();
		if (!SetSelectable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:SetSelectable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSelectable_bInSelectable_Offset), 0, SetSelectable_bInSelectable_PropertyAddress.Address, bInSelectable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectable_FunctionAddress, intPtr, SetSelectable_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:SetHovered")]
	public unsafe void SetHovered(bool bInHovered)
	{
		CheckDestroyed();
		if (!SetHovered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:SetHovered");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHovered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHovered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHovered_bInHovered_Offset), 0, SetHovered_bInHovered_PropertyAddress.Address, bInHovered);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHovered_FunctionAddress, intPtr, SetHovered_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:SetGlobalTransform")]
	public unsafe void SetGlobalTransform(FTransform InTransform)
	{
		CheckDestroyed();
		if (!SetGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:SetGlobalTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGlobalTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetGlobalTransform_InTransform_Offset), 0, SetGlobalTransform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGlobalTransform_FunctionAddress, intPtr, SetGlobalTransform_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:SetEnabled")]
	public unsafe void SetEnabled(bool bInEnabled)
	{
		CheckDestroyed();
		if (!SetEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:SetEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnabled_bInEnabled_Offset), 0, SetEnabled_bInEnabled_PropertyAddress.Address, bInEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnabled_FunctionAddress, intPtr, SetEnabled_ParamsSize);
	}

	[UFunction(Flags = 146933760u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:OnTransformChanged")]
	public unsafe void OnTransformChanged(FTransform NewTransform)
	{
		CheckDestroyed();
		if (!OnTransformChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnTransformChanged");
			return;
		}
		if (OnTransformChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTransformChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTransformChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTransformChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTransformChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTransformChanged_NewTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnTransformChanged_NewTransform_Offset), 0, OnTransformChanged_NewTransform_PropertyAddress.Address, NewTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTransformChanged_InstanceFunctionAddress, intPtr, OnTransformChanged_ParamsSize);
	}

	protected unsafe virtual void OnTransformChanged_Implementation(FTransform NewTransform)
	{
		CheckDestroyed();
		if (!OnTransformChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnTransformChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTransformChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTransformChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTransformChanged_NewTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnTransformChanged_NewTransform_Offset), 0, OnTransformChanged_NewTransform_PropertyAddress.Address, NewTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTransformChanged_FunctionAddress, intPtr, OnTransformChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:OnSelectionChanged")]
	public unsafe void OnSelectionChanged(bool bIsSelected)
	{
		CheckDestroyed();
		if (!OnSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnSelectionChanged");
			return;
		}
		if (OnSelectionChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSelectionChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSelectionChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_bIsSelected_Offset), 0, OnSelectionChanged_bIsSelected_PropertyAddress.Address, bIsSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSelectionChanged_InstanceFunctionAddress, intPtr, OnSelectionChanged_ParamsSize);
	}

	protected unsafe virtual void OnSelectionChanged_Implementation(bool bIsSelected)
	{
		CheckDestroyed();
		if (!OnSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnSelectionChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSelectionChanged_bIsSelected_Offset), 0, OnSelectionChanged_bIsSelected_PropertyAddress.Address, bIsSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSelectionChanged_FunctionAddress, intPtr, OnSelectionChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:OnManipulatingChanged")]
	public unsafe void OnManipulatingChanged(bool bIsManipulating)
	{
		CheckDestroyed();
		if (!OnManipulatingChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnManipulatingChanged");
			return;
		}
		if (OnManipulatingChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnManipulatingChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnManipulatingChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnManipulatingChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnManipulatingChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnManipulatingChanged_bIsManipulating_Offset), 0, OnManipulatingChanged_bIsManipulating_PropertyAddress.Address, bIsManipulating);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnManipulatingChanged_InstanceFunctionAddress, intPtr, OnManipulatingChanged_ParamsSize);
	}

	protected unsafe virtual void OnManipulatingChanged_Implementation(bool bIsManipulating)
	{
		CheckDestroyed();
		if (!OnManipulatingChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnManipulatingChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnManipulatingChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnManipulatingChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnManipulatingChanged_bIsManipulating_Offset), 0, OnManipulatingChanged_bIsManipulating_PropertyAddress.Address, bIsManipulating);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnManipulatingChanged_FunctionAddress, intPtr, OnManipulatingChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:OnHoveredChanged")]
	public unsafe void OnHoveredChanged(bool bIsSelected)
	{
		CheckDestroyed();
		if (!OnHoveredChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnHoveredChanged");
			return;
		}
		if (OnHoveredChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnHoveredChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnHoveredChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnHoveredChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnHoveredChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnHoveredChanged_bIsSelected_Offset), 0, OnHoveredChanged_bIsSelected_PropertyAddress.Address, bIsSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnHoveredChanged_InstanceFunctionAddress, intPtr, OnHoveredChanged_ParamsSize);
	}

	protected unsafe virtual void OnHoveredChanged_Implementation(bool bIsSelected)
	{
		CheckDestroyed();
		if (!OnHoveredChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnHoveredChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnHoveredChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnHoveredChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnHoveredChanged_bIsSelected_Offset), 0, OnHoveredChanged_bIsSelected_PropertyAddress.Address, bIsSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnHoveredChanged_FunctionAddress, intPtr, OnHoveredChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:OnEnabledChanged")]
	public unsafe void OnEnabledChanged(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!OnEnabledChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnEnabledChanged");
			return;
		}
		if (OnEnabledChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEnabledChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnabledChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEnabledChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEnabledChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEnabledChanged_bIsEnabled_Offset), 0, OnEnabledChanged_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEnabledChanged_InstanceFunctionAddress, intPtr, OnEnabledChanged_ParamsSize);
	}

	protected unsafe virtual void OnEnabledChanged_Implementation(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!OnEnabledChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:OnEnabledChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEnabledChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEnabledChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnEnabledChanged_bIsEnabled_Offset), 0, OnEnabledChanged_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEnabledChanged_FunctionAddress, intPtr, OnEnabledChanged_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:IsSelectedInEditor")]
	public unsafe bool IsSelectedInEditor()
	{
		CheckDestroyed();
		if (!IsSelectedInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:IsSelectedInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSelectedInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSelectedInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSelectedInEditor_FunctionAddress, intPtr, IsSelectedInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSelectedInEditor_ReturnValue_Offset), 0, IsSelectedInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:IsHovered")]
	public unsafe bool IsHovered()
	{
		CheckDestroyed();
		if (!IsHovered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:IsHovered");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHovered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHovered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsHovered_FunctionAddress, intPtr, IsHovered_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHovered_ReturnValue_Offset), 0, IsHovered_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:IsEnabled")]
	public unsafe bool IsEnabled()
	{
		CheckDestroyed();
		if (!IsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:IsEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEnabled_FunctionAddress, intPtr, IsEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEnabled_ReturnValue_Offset), 0, IsEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.ControlRigShapeActor:GetGlobalTransform")]
	public unsafe FTransform GetGlobalTransform()
	{
		CheckDestroyed();
		if (!GetGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigShapeActor:GetGlobalTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalTransform_FunctionAddress, intPtr, GetGlobalTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalTransform_ReturnValue_Offset), 0, GetGlobalTransform_ReturnValue_PropertyAddress.Address);
	}

	static AControlRigShapeActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AControlRigShapeActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AControlRigShapeActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ControlRig.ControlRigShapeActor");
		StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMeshComponent");
		StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMeshComponent", Classes.FObjectProperty);
		SetSelected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelected");
		SetSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelected_bInSelected_PropertyAddress, SetSelected_FunctionAddress, "bInSelected");
		SetSelected_bInSelected_Offset = NativeReflectionCached.GetPropertyOffset(SetSelected_FunctionAddress, "bInSelected");
		SetSelected_bInSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelected_FunctionAddress, "bInSelected", Classes.FBoolProperty);
		SetSelected_IsValid = SetSelected_FunctionAddress != IntPtr.Zero && SetSelected_bInSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:SetSelected", SetSelected_IsValid);
		SetSelectable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectable");
		SetSelectable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectable_bInSelectable_PropertyAddress, SetSelectable_FunctionAddress, "bInSelectable");
		SetSelectable_bInSelectable_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectable_FunctionAddress, "bInSelectable");
		SetSelectable_bInSelectable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectable_FunctionAddress, "bInSelectable", Classes.FBoolProperty);
		SetSelectable_IsValid = SetSelectable_FunctionAddress != IntPtr.Zero && SetSelectable_bInSelectable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:SetSelectable", SetSelectable_IsValid);
		SetHovered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHovered");
		SetHovered_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHovered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHovered_bInHovered_PropertyAddress, SetHovered_FunctionAddress, "bInHovered");
		SetHovered_bInHovered_Offset = NativeReflectionCached.GetPropertyOffset(SetHovered_FunctionAddress, "bInHovered");
		SetHovered_bInHovered_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHovered_FunctionAddress, "bInHovered", Classes.FBoolProperty);
		SetHovered_IsValid = SetHovered_FunctionAddress != IntPtr.Zero && SetHovered_bInHovered_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:SetHovered", SetHovered_IsValid);
		SetGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGlobalTransform");
		SetGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransform_InTransform_PropertyAddress, SetGlobalTransform_FunctionAddress, "InTransform");
		SetGlobalTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransform_FunctionAddress, "InTransform");
		SetGlobalTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		SetGlobalTransform_IsValid = SetGlobalTransform_FunctionAddress != IntPtr.Zero && SetGlobalTransform_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:SetGlobalTransform", SetGlobalTransform_IsValid);
		SetEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnabled");
		SetEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnabled_bInEnabled_PropertyAddress, SetEnabled_FunctionAddress, "bInEnabled");
		SetEnabled_bInEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnabled_FunctionAddress, "bInEnabled");
		SetEnabled_bInEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnabled_FunctionAddress, "bInEnabled", Classes.FBoolProperty);
		SetEnabled_IsValid = SetEnabled_FunctionAddress != IntPtr.Zero && SetEnabled_bInEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:SetEnabled", SetEnabled_IsValid);
		OnTransformChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTransformChanged");
		OnTransformChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTransformChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTransformChanged_NewTransform_PropertyAddress, OnTransformChanged_FunctionAddress, "NewTransform");
		OnTransformChanged_NewTransform_Offset = NativeReflectionCached.GetPropertyOffset(OnTransformChanged_FunctionAddress, "NewTransform");
		OnTransformChanged_NewTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTransformChanged_FunctionAddress, "NewTransform", Classes.FStructProperty);
		OnTransformChanged_IsValid = OnTransformChanged_FunctionAddress != IntPtr.Zero && OnTransformChanged_NewTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:OnTransformChanged", OnTransformChanged_IsValid);
		OnSelectionChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSelectionChanged");
		OnSelectionChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectionChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSelectionChanged_bIsSelected_PropertyAddress, OnSelectionChanged_FunctionAddress, "bIsSelected");
		OnSelectionChanged_bIsSelected_Offset = NativeReflectionCached.GetPropertyOffset(OnSelectionChanged_FunctionAddress, "bIsSelected");
		OnSelectionChanged_bIsSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSelectionChanged_FunctionAddress, "bIsSelected", Classes.FBoolProperty);
		OnSelectionChanged_IsValid = OnSelectionChanged_FunctionAddress != IntPtr.Zero && OnSelectionChanged_bIsSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:OnSelectionChanged", OnSelectionChanged_IsValid);
		OnManipulatingChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnManipulatingChanged");
		OnManipulatingChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnManipulatingChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnManipulatingChanged_bIsManipulating_PropertyAddress, OnManipulatingChanged_FunctionAddress, "bIsManipulating");
		OnManipulatingChanged_bIsManipulating_Offset = NativeReflectionCached.GetPropertyOffset(OnManipulatingChanged_FunctionAddress, "bIsManipulating");
		OnManipulatingChanged_bIsManipulating_IsValid = NativeReflectionCached.ValidatePropertyClass(OnManipulatingChanged_FunctionAddress, "bIsManipulating", Classes.FBoolProperty);
		OnManipulatingChanged_IsValid = OnManipulatingChanged_FunctionAddress != IntPtr.Zero && OnManipulatingChanged_bIsManipulating_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:OnManipulatingChanged", OnManipulatingChanged_IsValid);
		OnHoveredChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnHoveredChanged");
		OnHoveredChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnHoveredChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnHoveredChanged_bIsSelected_PropertyAddress, OnHoveredChanged_FunctionAddress, "bIsSelected");
		OnHoveredChanged_bIsSelected_Offset = NativeReflectionCached.GetPropertyOffset(OnHoveredChanged_FunctionAddress, "bIsSelected");
		OnHoveredChanged_bIsSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(OnHoveredChanged_FunctionAddress, "bIsSelected", Classes.FBoolProperty);
		OnHoveredChanged_IsValid = OnHoveredChanged_FunctionAddress != IntPtr.Zero && OnHoveredChanged_bIsSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:OnHoveredChanged", OnHoveredChanged_IsValid);
		OnEnabledChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnabledChanged");
		OnEnabledChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnabledChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEnabledChanged_bIsEnabled_PropertyAddress, OnEnabledChanged_FunctionAddress, "bIsEnabled");
		OnEnabledChanged_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(OnEnabledChanged_FunctionAddress, "bIsEnabled");
		OnEnabledChanged_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEnabledChanged_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		OnEnabledChanged_IsValid = OnEnabledChanged_FunctionAddress != IntPtr.Zero && OnEnabledChanged_bIsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:OnEnabledChanged", OnEnabledChanged_IsValid);
		IsSelectedInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSelectedInEditor");
		IsSelectedInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSelectedInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSelectedInEditor_ReturnValue_PropertyAddress, IsSelectedInEditor_FunctionAddress, "ReturnValue");
		IsSelectedInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSelectedInEditor_FunctionAddress, "ReturnValue");
		IsSelectedInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelectedInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSelectedInEditor_IsValid = IsSelectedInEditor_FunctionAddress != IntPtr.Zero && IsSelectedInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:IsSelectedInEditor", IsSelectedInEditor_IsValid);
		IsHovered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsHovered");
		IsHovered_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHovered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHovered_ReturnValue_PropertyAddress, IsHovered_FunctionAddress, "ReturnValue");
		IsHovered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHovered_FunctionAddress, "ReturnValue");
		IsHovered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHovered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHovered_IsValid = IsHovered_FunctionAddress != IntPtr.Zero && IsHovered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:IsHovered", IsHovered_IsValid);
		IsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEnabled");
		IsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEnabled_ReturnValue_PropertyAddress, IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEnabled_IsValid = IsEnabled_FunctionAddress != IntPtr.Zero && IsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:IsEnabled", IsEnabled_IsValid);
		GetGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGlobalTransform");
		GetGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransform_ReturnValue_PropertyAddress, GetGlobalTransform_FunctionAddress, "ReturnValue");
		GetGlobalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransform_FunctionAddress, "ReturnValue");
		GetGlobalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalTransform_IsValid = GetGlobalTransform_FunctionAddress != IntPtr.Zero && GetGlobalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigShapeActor:GetGlobalTransform", GetGlobalTransform_IsValid);
	}
}
