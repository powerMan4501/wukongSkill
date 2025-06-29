using System;
using System.Runtime.CompilerServices;
using b1.Plugins.V8;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptUMG;

[UClass(Flags = (ClassFlags)821039264uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptUMG.JavascriptWidget", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public class UJavascriptWidget : UUserWidget
{
	private static IntPtr classAddress;

	private static bool JavascriptContext_IsValid;

	private static int JavascriptContext_Offset;

	private static bool OnInputActionEvent_IsValid;

	private static int OnInputActionEvent_Offset;

	private FOnInputActionEvent OnInputActionEvent_DelegateCached;

	private static bool OnReleaseActionEvent_IsValid;

	private static int OnReleaseActionEvent_Offset;

	private FOnInputActionEvent OnReleaseActionEvent_DelegateCached;

	private static bool OnInputAxisEvent_IsValid;

	private static int OnInputAxisEvent_Offset;

	private FOnInputAxisEvent OnInputAxisEvent_DelegateCached;

	private static bool SetRootWidget_IsValid;

	private static IntPtr SetRootWidget_FunctionAddress;

	private static int SetRootWidget_ParamsSize;

	private static bool SetRootWidget_Widget_IsValid;

	private static FFieldAddress SetRootWidget_Widget_PropertyAddress;

	private static int SetRootWidget_Widget_Offset;

	private static bool RemoveChild_IsValid;

	private static IntPtr RemoveChild_FunctionAddress;

	private static int RemoveChild_ParamsSize;

	private static bool RemoveChild_ReturnValue_IsValid;

	private static FFieldAddress RemoveChild_ReturnValue_PropertyAddress;

	private static int RemoveChild_ReturnValue_Offset;

	private static bool OnReleaseInputActionByName_IsValid;

	private IntPtr OnReleaseInputActionByName_InstanceFunctionAddress;

	private static IntPtr OnReleaseInputActionByName_FunctionAddress;

	private static int OnReleaseInputActionByName_ParamsSize;

	private static bool OnReleaseInputActionByName_ActionName_IsValid;

	private static FFieldAddress OnReleaseInputActionByName_ActionName_PropertyAddress;

	private static int OnReleaseInputActionByName_ActionName_Offset;

	private static bool OnListenForInputAxis_IsValid;

	private static IntPtr OnListenForInputAxis_FunctionAddress;

	private static int OnListenForInputAxis_ParamsSize;

	private static bool OnListenForInputAxis_AxisName_IsValid;

	private static FFieldAddress OnListenForInputAxis_AxisName_PropertyAddress;

	private static int OnListenForInputAxis_AxisName_Offset;

	private static bool OnListenForInputAxis_EventType_IsValid;

	private static FFieldAddress OnListenForInputAxis_EventType_PropertyAddress;

	private static int OnListenForInputAxis_EventType_Offset;

	private static bool OnListenForInputAxis_bConsume_IsValid;

	private static FFieldAddress OnListenForInputAxis_bConsume_PropertyAddress;

	private static int OnListenForInputAxis_bConsume_Offset;

	private static bool OnListenForInputAction_IsValid;

	private static IntPtr OnListenForInputAction_FunctionAddress;

	private static int OnListenForInputAction_ParamsSize;

	private static bool OnListenForInputAction_ActionName_IsValid;

	private static FFieldAddress OnListenForInputAction_ActionName_PropertyAddress;

	private static int OnListenForInputAction_ActionName_Offset;

	private static bool OnListenForInputAction_EventType_IsValid;

	private static FFieldAddress OnListenForInputAction_EventType_PropertyAddress;

	private static int OnListenForInputAction_EventType_Offset;

	private static bool OnListenForInputAction_bConsume_IsValid;

	private static FFieldAddress OnListenForInputAction_bConsume_PropertyAddress;

	private static int OnListenForInputAction_bConsume_Offset;

	private static bool OnInputAxisByName_IsValid;

	private IntPtr OnInputAxisByName_InstanceFunctionAddress;

	private static IntPtr OnInputAxisByName_FunctionAddress;

	private static int OnInputAxisByName_ParamsSize;

	private static bool OnInputAxisByName_Axis_IsValid;

	private static FFieldAddress OnInputAxisByName_Axis_PropertyAddress;

	private static int OnInputAxisByName_Axis_Offset;

	private static bool OnInputAxisByName_ActionName_IsValid;

	private static FFieldAddress OnInputAxisByName_ActionName_PropertyAddress;

	private static int OnInputAxisByName_ActionName_Offset;

	private static bool OnInputActionByName_IsValid;

	private IntPtr OnInputActionByName_InstanceFunctionAddress;

	private static IntPtr OnInputActionByName_FunctionAddress;

	private static int OnInputActionByName_ParamsSize;

	private static bool OnInputActionByName_ActionName_IsValid;

	private static FFieldAddress OnInputActionByName_ActionName_PropertyAddress;

	private static int OnInputActionByName_ActionName_Offset;

	private static bool OnDestroy_IsValid;

	private IntPtr OnDestroy_InstanceFunctionAddress;

	private static IntPtr OnDestroy_FunctionAddress;

	private static int OnDestroy_ParamsSize;

	private static bool OnDestroy_bReleaseChildren_IsValid;

	private static FFieldAddress OnDestroy_bReleaseChildren_PropertyAddress;

	private static int OnDestroy_bReleaseChildren_Offset;

	private static bool HasValidCachedWidget_IsValid;

	private static IntPtr HasValidCachedWidget_FunctionAddress;

	private static int HasValidCachedWidget_ParamsSize;

	private static bool HasValidCachedWidget_Widget_IsValid;

	private static FFieldAddress HasValidCachedWidget_Widget_PropertyAddress;

	private static int HasValidCachedWidget_Widget_Offset;

	private static bool HasValidCachedWidget_ReturnValue_IsValid;

	private static FFieldAddress HasValidCachedWidget_ReturnValue_PropertyAddress;

	private static int HasValidCachedWidget_ReturnValue_Offset;

	private static bool CallSynchronizeProperties_IsValid;

	private static IntPtr CallSynchronizeProperties_FunctionAddress;

	private static int CallSynchronizeProperties_ParamsSize;

	private static bool CallSynchronizeProperties_WidgetOrSlot_IsValid;

	private static FFieldAddress CallSynchronizeProperties_WidgetOrSlot_PropertyAddress;

	private static int CallSynchronizeProperties_WidgetOrSlot_Offset;

	private static bool AddChild_IsValid;

	private static IntPtr AddChild_FunctionAddress;

	private static int AddChild_ParamsSize;

	private static bool AddChild_Content_IsValid;

	private static FFieldAddress AddChild_Content_PropertyAddress;

	private static int AddChild_Content_Offset;

	private static bool AddChild_ReturnValue_IsValid;

	private static FFieldAddress AddChild_ReturnValue_PropertyAddress;

	private static int AddChild_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:JavascriptContext")]
	public UJavascriptContext JavascriptContext
	{
		get
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptWidget:JavascriptContext");
				return null;
			}
			return UObjectMarshaler<UJavascriptContext>.FromNative(IntPtr.Add(base.Address, JavascriptContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JavascriptContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptWidget:JavascriptContext");
			}
			else
			{
				UObjectMarshaler<UJavascriptContext>.ToNative(IntPtr.Add(base.Address, JavascriptContext_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnInputActionEvent")]
	public FOnInputActionEvent OnInputActionEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnInputActionEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptWidget:OnInputActionEvent");
				return new FOnInputActionEvent();
			}
			if (OnInputActionEvent_DelegateCached == null)
			{
				OnInputActionEvent_DelegateCached = new FOnInputActionEvent();
				OnInputActionEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputActionEvent_Offset));
			}
			return OnInputActionEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnReleaseActionEvent")]
	public FOnInputActionEvent OnReleaseActionEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnReleaseActionEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptWidget:OnReleaseActionEvent");
				return new FOnInputActionEvent();
			}
			if (OnReleaseActionEvent_DelegateCached == null)
			{
				OnReleaseActionEvent_DelegateCached = new FOnInputActionEvent();
				OnReleaseActionEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnReleaseActionEvent_Offset));
			}
			return OnReleaseActionEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnInputAxisEvent")]
	public FOnInputAxisEvent OnInputAxisEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnInputAxisEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptUMG.JavascriptWidget:OnInputAxisEvent");
				return new FOnInputAxisEvent();
			}
			if (OnInputAxisEvent_DelegateCached == null)
			{
				OnInputAxisEvent_DelegateCached = new FOnInputAxisEvent();
				OnInputAxisEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputAxisEvent_Offset));
			}
			return OnInputAxisEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:SetRootWidget")]
	public unsafe void SetRootWidget(UWidget Widget)
	{
		CheckDestroyed();
		if (!SetRootWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:SetRootWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRootWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRootWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetRootWidget_Widget_Offset), 0, SetRootWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRootWidget_FunctionAddress, intPtr, SetRootWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:RemoveChild")]
	public unsafe bool RemoveChild()
	{
		CheckDestroyed();
		if (!RemoveChild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:RemoveChild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveChild_FunctionAddress, intPtr, RemoveChild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveChild_ReturnValue_Offset), 0, RemoveChild_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnReleaseInputActionByName")]
	public unsafe void OnReleaseInputActionByName(FName ActionName)
	{
		CheckDestroyed();
		if (!OnReleaseInputActionByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnReleaseInputActionByName");
			return;
		}
		if (OnReleaseInputActionByName_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReleaseInputActionByName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnReleaseInputActionByName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReleaseInputActionByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReleaseInputActionByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnReleaseInputActionByName_ActionName_Offset), 0, OnReleaseInputActionByName_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReleaseInputActionByName_InstanceFunctionAddress, intPtr, OnReleaseInputActionByName_ParamsSize);
	}

	protected unsafe virtual void OnReleaseInputActionByName_Implementation(FName ActionName)
	{
		CheckDestroyed();
		if (!OnReleaseInputActionByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnReleaseInputActionByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReleaseInputActionByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReleaseInputActionByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnReleaseInputActionByName_ActionName_Offset), 0, OnReleaseInputActionByName_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnReleaseInputActionByName_FunctionAddress, intPtr, OnReleaseInputActionByName_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnListenForInputAxis")]
	public unsafe void OnListenForInputAxis(FName AxisName, EInputEventType EventType, bool bConsume)
	{
		CheckDestroyed();
		if (!OnListenForInputAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnListenForInputAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenForInputAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenForInputAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnListenForInputAxis_AxisName_Offset), 0, OnListenForInputAxis_AxisName_PropertyAddress.Address, AxisName);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, OnListenForInputAxis_EventType_Offset), 0, OnListenForInputAxis_EventType_PropertyAddress.Address, EventType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnListenForInputAxis_bConsume_Offset), 0, OnListenForInputAxis_bConsume_PropertyAddress.Address, bConsume);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenForInputAxis_FunctionAddress, intPtr, OnListenForInputAxis_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnListenForInputAction")]
	public unsafe void OnListenForInputAction(FName ActionName, EInputEventType EventType, bool bConsume)
	{
		CheckDestroyed();
		if (!OnListenForInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnListenForInputAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnListenForInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListenForInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnListenForInputAction_ActionName_Offset), 0, OnListenForInputAction_ActionName_PropertyAddress.Address, ActionName);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, OnListenForInputAction_EventType_Offset), 0, OnListenForInputAction_EventType_PropertyAddress.Address, EventType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnListenForInputAction_bConsume_Offset), 0, OnListenForInputAction_bConsume_PropertyAddress.Address, bConsume);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnListenForInputAction_FunctionAddress, intPtr, OnListenForInputAction_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnInputAxisByName")]
	public unsafe void OnInputAxisByName(float Axis, FName ActionName)
	{
		CheckDestroyed();
		if (!OnInputAxisByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnInputAxisByName");
			return;
		}
		if (OnInputAxisByName_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputAxisByName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputAxisByName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputAxisByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAxisByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxisByName_Axis_Offset), 0, OnInputAxisByName_Axis_PropertyAddress.Address, Axis);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnInputAxisByName_ActionName_Offset), 0, OnInputAxisByName_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputAxisByName_InstanceFunctionAddress, intPtr, OnInputAxisByName_ParamsSize);
	}

	protected unsafe virtual void OnInputAxisByName_Implementation(float Axis, FName ActionName)
	{
		CheckDestroyed();
		if (!OnInputAxisByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnInputAxisByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputAxisByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAxisByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxisByName_Axis_Offset), 0, OnInputAxisByName_Axis_PropertyAddress.Address, Axis);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnInputAxisByName_ActionName_Offset), 0, OnInputAxisByName_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputAxisByName_FunctionAddress, intPtr, OnInputAxisByName_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnInputActionByName")]
	public unsafe void OnInputActionByName(FName ActionName)
	{
		CheckDestroyed();
		if (!OnInputActionByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnInputActionByName");
			return;
		}
		if (OnInputActionByName_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInputActionByName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInputActionByName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputActionByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputActionByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnInputActionByName_ActionName_Offset), 0, OnInputActionByName_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputActionByName_InstanceFunctionAddress, intPtr, OnInputActionByName_ParamsSize);
	}

	protected unsafe virtual void OnInputActionByName_Implementation(FName ActionName)
	{
		CheckDestroyed();
		if (!OnInputActionByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnInputActionByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInputActionByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputActionByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnInputActionByName_ActionName_Offset), 0, OnInputActionByName_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInputActionByName_FunctionAddress, intPtr, OnInputActionByName_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:OnDestroy")]
	public unsafe void OnDestroy(bool bReleaseChildren)
	{
		CheckDestroyed();
		if (!OnDestroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnDestroy");
			return;
		}
		if (OnDestroy_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDestroy_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDestroy");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestroy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDestroy_bReleaseChildren_Offset), 0, OnDestroy_bReleaseChildren_PropertyAddress.Address, bReleaseChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDestroy_InstanceFunctionAddress, intPtr, OnDestroy_ParamsSize);
	}

	protected unsafe virtual void OnDestroy_Implementation(bool bReleaseChildren)
	{
		CheckDestroyed();
		if (!OnDestroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:OnDestroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestroy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDestroy_bReleaseChildren_Offset), 0, OnDestroy_bReleaseChildren_PropertyAddress.Address, bReleaseChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDestroy_FunctionAddress, intPtr, OnDestroy_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:HasValidCachedWidget")]
	public unsafe static bool HasValidCachedWidget(UWidget Widget)
	{
		if (!HasValidCachedWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:HasValidCachedWidget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasValidCachedWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasValidCachedWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, HasValidCachedWidget_Widget_Offset), 0, HasValidCachedWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasValidCachedWidget_FunctionAddress, intPtr, HasValidCachedWidget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasValidCachedWidget_ReturnValue_Offset), 0, HasValidCachedWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:CallSynchronizeProperties")]
	public unsafe static void CallSynchronizeProperties(UVisual WidgetOrSlot)
	{
		if (!CallSynchronizeProperties_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:CallSynchronizeProperties");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CallSynchronizeProperties_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CallSynchronizeProperties_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UVisual>.ToNative(IntPtr.Add(intPtr, CallSynchronizeProperties_WidgetOrSlot_Offset), 0, CallSynchronizeProperties_WidgetOrSlot_PropertyAddress.Address, WidgetOrSlot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CallSynchronizeProperties_FunctionAddress, intPtr, CallSynchronizeProperties_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptUMG.JavascriptWidget:AddChild")]
	public unsafe UPanelSlot AddChild(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptUMG.JavascriptWidget:AddChild");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChild_Content_Offset), 0, AddChild_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChild_FunctionAddress, intPtr, AddChild_ParamsSize);
		return UObjectMarshaler<UPanelSlot>.FromNative(IntPtr.Add(intPtr, AddChild_ReturnValue_Offset), 0, AddChild_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptWidget));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptUMG.JavascriptWidget");
		JavascriptContext_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "JavascriptContext");
		JavascriptContext_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "JavascriptContext", Classes.FObjectProperty);
		OnInputActionEvent_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnInputActionEvent");
		OnInputActionEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnInputActionEvent", Classes.FMulticastDelegateProperty);
		OnReleaseActionEvent_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnReleaseActionEvent");
		OnReleaseActionEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnReleaseActionEvent", Classes.FMulticastDelegateProperty);
		OnInputAxisEvent_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnInputAxisEvent");
		OnInputAxisEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnInputAxisEvent", Classes.FMulticastDelegateProperty);
		SetRootWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRootWidget");
		SetRootWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRootWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRootWidget_Widget_PropertyAddress, SetRootWidget_FunctionAddress, "Widget");
		SetRootWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetRootWidget_FunctionAddress, "Widget");
		SetRootWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		SetRootWidget_IsValid = SetRootWidget_FunctionAddress != IntPtr.Zero && SetRootWidget_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:SetRootWidget", SetRootWidget_IsValid);
		RemoveChild_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveChild");
		RemoveChild_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChild_ReturnValue_PropertyAddress, RemoveChild_FunctionAddress, "ReturnValue");
		RemoveChild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChild_FunctionAddress, "ReturnValue");
		RemoveChild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveChild_IsValid = RemoveChild_FunctionAddress != IntPtr.Zero && RemoveChild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:RemoveChild", RemoveChild_IsValid);
		OnReleaseInputActionByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnReleaseInputActionByName");
		OnReleaseInputActionByName_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReleaseInputActionByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnReleaseInputActionByName_ActionName_PropertyAddress, OnReleaseInputActionByName_FunctionAddress, "ActionName");
		OnReleaseInputActionByName_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(OnReleaseInputActionByName_FunctionAddress, "ActionName");
		OnReleaseInputActionByName_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReleaseInputActionByName_FunctionAddress, "ActionName", Classes.FNameProperty);
		OnReleaseInputActionByName_IsValid = OnReleaseInputActionByName_FunctionAddress != IntPtr.Zero && OnReleaseInputActionByName_ActionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:OnReleaseInputActionByName", OnReleaseInputActionByName_IsValid);
		OnListenForInputAxis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnListenForInputAxis");
		OnListenForInputAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListenForInputAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListenForInputAxis_AxisName_PropertyAddress, OnListenForInputAxis_FunctionAddress, "AxisName");
		OnListenForInputAxis_AxisName_Offset = NativeReflectionCached.GetPropertyOffset(OnListenForInputAxis_FunctionAddress, "AxisName");
		OnListenForInputAxis_AxisName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenForInputAxis_FunctionAddress, "AxisName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenForInputAxis_EventType_PropertyAddress, OnListenForInputAxis_FunctionAddress, "EventType");
		OnListenForInputAxis_EventType_Offset = NativeReflectionCached.GetPropertyOffset(OnListenForInputAxis_FunctionAddress, "EventType");
		OnListenForInputAxis_EventType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenForInputAxis_FunctionAddress, "EventType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenForInputAxis_bConsume_PropertyAddress, OnListenForInputAxis_FunctionAddress, "bConsume");
		OnListenForInputAxis_bConsume_Offset = NativeReflectionCached.GetPropertyOffset(OnListenForInputAxis_FunctionAddress, "bConsume");
		OnListenForInputAxis_bConsume_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenForInputAxis_FunctionAddress, "bConsume", Classes.FBoolProperty);
		OnListenForInputAxis_IsValid = OnListenForInputAxis_FunctionAddress != IntPtr.Zero && OnListenForInputAxis_AxisName_IsValid && OnListenForInputAxis_EventType_IsValid && OnListenForInputAxis_bConsume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:OnListenForInputAxis", OnListenForInputAxis_IsValid);
		OnListenForInputAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnListenForInputAction");
		OnListenForInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListenForInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListenForInputAction_ActionName_PropertyAddress, OnListenForInputAction_FunctionAddress, "ActionName");
		OnListenForInputAction_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(OnListenForInputAction_FunctionAddress, "ActionName");
		OnListenForInputAction_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenForInputAction_FunctionAddress, "ActionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenForInputAction_EventType_PropertyAddress, OnListenForInputAction_FunctionAddress, "EventType");
		OnListenForInputAction_EventType_Offset = NativeReflectionCached.GetPropertyOffset(OnListenForInputAction_FunctionAddress, "EventType");
		OnListenForInputAction_EventType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenForInputAction_FunctionAddress, "EventType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListenForInputAction_bConsume_PropertyAddress, OnListenForInputAction_FunctionAddress, "bConsume");
		OnListenForInputAction_bConsume_Offset = NativeReflectionCached.GetPropertyOffset(OnListenForInputAction_FunctionAddress, "bConsume");
		OnListenForInputAction_bConsume_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListenForInputAction_FunctionAddress, "bConsume", Classes.FBoolProperty);
		OnListenForInputAction_IsValid = OnListenForInputAction_FunctionAddress != IntPtr.Zero && OnListenForInputAction_ActionName_IsValid && OnListenForInputAction_EventType_IsValid && OnListenForInputAction_bConsume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:OnListenForInputAction", OnListenForInputAction_IsValid);
		OnInputAxisByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnInputAxisByName");
		OnInputAxisByName_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputAxisByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputAxisByName_Axis_PropertyAddress, OnInputAxisByName_FunctionAddress, "Axis");
		OnInputAxisByName_Axis_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxisByName_FunctionAddress, "Axis");
		OnInputAxisByName_Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxisByName_FunctionAddress, "Axis", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnInputAxisByName_ActionName_PropertyAddress, OnInputAxisByName_FunctionAddress, "ActionName");
		OnInputAxisByName_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxisByName_FunctionAddress, "ActionName");
		OnInputAxisByName_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxisByName_FunctionAddress, "ActionName", Classes.FNameProperty);
		OnInputAxisByName_IsValid = OnInputAxisByName_FunctionAddress != IntPtr.Zero && OnInputAxisByName_Axis_IsValid && OnInputAxisByName_ActionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:OnInputAxisByName", OnInputAxisByName_IsValid);
		OnInputActionByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnInputActionByName");
		OnInputActionByName_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputActionByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInputActionByName_ActionName_PropertyAddress, OnInputActionByName_FunctionAddress, "ActionName");
		OnInputActionByName_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(OnInputActionByName_FunctionAddress, "ActionName");
		OnInputActionByName_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputActionByName_FunctionAddress, "ActionName", Classes.FNameProperty);
		OnInputActionByName_IsValid = OnInputActionByName_FunctionAddress != IntPtr.Zero && OnInputActionByName_ActionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:OnInputActionByName", OnInputActionByName_IsValid);
		OnDestroy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnDestroy");
		OnDestroy_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestroy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDestroy_bReleaseChildren_PropertyAddress, OnDestroy_FunctionAddress, "bReleaseChildren");
		OnDestroy_bReleaseChildren_Offset = NativeReflectionCached.GetPropertyOffset(OnDestroy_FunctionAddress, "bReleaseChildren");
		OnDestroy_bReleaseChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDestroy_FunctionAddress, "bReleaseChildren", Classes.FBoolProperty);
		OnDestroy_IsValid = OnDestroy_FunctionAddress != IntPtr.Zero && OnDestroy_bReleaseChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:OnDestroy", OnDestroy_IsValid);
		HasValidCachedWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasValidCachedWidget");
		HasValidCachedWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(HasValidCachedWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasValidCachedWidget_Widget_PropertyAddress, HasValidCachedWidget_FunctionAddress, "Widget");
		HasValidCachedWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(HasValidCachedWidget_FunctionAddress, "Widget");
		HasValidCachedWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(HasValidCachedWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasValidCachedWidget_ReturnValue_PropertyAddress, HasValidCachedWidget_FunctionAddress, "ReturnValue");
		HasValidCachedWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasValidCachedWidget_FunctionAddress, "ReturnValue");
		HasValidCachedWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasValidCachedWidget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasValidCachedWidget_IsValid = HasValidCachedWidget_FunctionAddress != IntPtr.Zero && HasValidCachedWidget_Widget_IsValid && HasValidCachedWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:HasValidCachedWidget", HasValidCachedWidget_IsValid);
		CallSynchronizeProperties_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CallSynchronizeProperties");
		CallSynchronizeProperties_ParamsSize = NativeReflection.GetFunctionParamsSize(CallSynchronizeProperties_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CallSynchronizeProperties_WidgetOrSlot_PropertyAddress, CallSynchronizeProperties_FunctionAddress, "WidgetOrSlot");
		CallSynchronizeProperties_WidgetOrSlot_Offset = NativeReflectionCached.GetPropertyOffset(CallSynchronizeProperties_FunctionAddress, "WidgetOrSlot");
		CallSynchronizeProperties_WidgetOrSlot_IsValid = NativeReflectionCached.ValidatePropertyClass(CallSynchronizeProperties_FunctionAddress, "WidgetOrSlot", Classes.FObjectProperty);
		CallSynchronizeProperties_IsValid = CallSynchronizeProperties_FunctionAddress != IntPtr.Zero && CallSynchronizeProperties_WidgetOrSlot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:CallSynchronizeProperties", CallSynchronizeProperties_IsValid);
		AddChild_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddChild");
		AddChild_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChild_Content_PropertyAddress, AddChild_FunctionAddress, "Content");
		AddChild_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChild_FunctionAddress, "Content");
		AddChild_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChild_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChild_ReturnValue_PropertyAddress, AddChild_FunctionAddress, "ReturnValue");
		AddChild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChild_FunctionAddress, "ReturnValue");
		AddChild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChild_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChild_IsValid = AddChild_FunctionAddress != IntPtr.Zero && AddChild_Content_IsValid && AddChild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptUMG.JavascriptWidget:AddChild", AddChild_IsValid);
	}
}
