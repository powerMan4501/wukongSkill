using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LandmassEditor;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/LandmassEditor.LandmassActor", "LandmassEditor", UnrealModuleType.EnginePlugin)]
public class ALandmassActor : AActor
{
	private static bool SetEditorTickEnabled_IsValid;

	private static IntPtr SetEditorTickEnabled_FunctionAddress;

	private static int SetEditorTickEnabled_ParamsSize;

	private static bool SetEditorTickEnabled_bEnabled_IsValid;

	private static FFieldAddress SetEditorTickEnabled_bEnabled_PropertyAddress;

	private static int SetEditorTickEnabled_bEnabled_Offset;

	private static bool CustomTick_IsValid;

	private IntPtr CustomTick_InstanceFunctionAddress;

	private static IntPtr CustomTick_FunctionAddress;

	private static int CustomTick_ParamsSize;

	private static bool CustomTick_DeltaSeconds_IsValid;

	private static FFieldAddress CustomTick_DeltaSeconds_PropertyAddress;

	private static int CustomTick_DeltaSeconds_Offset;

	private static bool ActorSelectionChanged_IsValid;

	private IntPtr ActorSelectionChanged_InstanceFunctionAddress;

	private static IntPtr ActorSelectionChanged_FunctionAddress;

	private static int ActorSelectionChanged_ParamsSize;

	private static bool ActorSelectionChanged_bSelected_IsValid;

	private static FFieldAddress ActorSelectionChanged_bSelected_PropertyAddress;

	private static int ActorSelectionChanged_bSelected_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LandmassEditor.LandmassActor:SetEditorTickEnabled")]
	public unsafe void SetEditorTickEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetEditorTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LandmassEditor.LandmassActor:SetEditorTickEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEditorTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEditorTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEditorTickEnabled_bEnabled_Offset), 0, SetEditorTickEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEditorTickEnabled_FunctionAddress, intPtr, SetEditorTickEnabled_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/LandmassEditor.LandmassActor:CustomTick")]
	public unsafe void CustomTick(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!CustomTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LandmassEditor.LandmassActor:CustomTick");
			return;
		}
		if (CustomTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			CustomTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CustomTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CustomTick_DeltaSeconds_Offset), 0, CustomTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, CustomTick_InstanceFunctionAddress, intPtr, CustomTick_ParamsSize);
	}

	protected unsafe virtual void CustomTick_Implementation(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!CustomTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LandmassEditor.LandmassActor:CustomTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CustomTick_DeltaSeconds_Offset), 0, CustomTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, CustomTick_FunctionAddress, intPtr, CustomTick_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/LandmassEditor.LandmassActor:ActorSelectionChanged")]
	public unsafe void ActorSelectionChanged(bool bSelected)
	{
		CheckDestroyed();
		if (!ActorSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LandmassEditor.LandmassActor:ActorSelectionChanged");
			return;
		}
		if (ActorSelectionChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			ActorSelectionChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ActorSelectionChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActorSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActorSelectionChanged_bSelected_Offset), 0, ActorSelectionChanged_bSelected_PropertyAddress.Address, bSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActorSelectionChanged_InstanceFunctionAddress, intPtr, ActorSelectionChanged_ParamsSize);
	}

	protected unsafe virtual void ActorSelectionChanged_Implementation(bool bSelected)
	{
		CheckDestroyed();
		if (!ActorSelectionChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LandmassEditor.LandmassActor:ActorSelectionChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActorSelectionChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorSelectionChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActorSelectionChanged_bSelected_Offset), 0, ActorSelectionChanged_bSelected_PropertyAddress.Address, bSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActorSelectionChanged_FunctionAddress, intPtr, ActorSelectionChanged_ParamsSize);
	}

	static ALandmassActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandmassActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandmassActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/LandmassEditor.LandmassActor");
		SetEditorTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEditorTickEnabled");
		SetEditorTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEditorTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEditorTickEnabled_bEnabled_PropertyAddress, SetEditorTickEnabled_FunctionAddress, "bEnabled");
		SetEditorTickEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEditorTickEnabled_FunctionAddress, "bEnabled");
		SetEditorTickEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEditorTickEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetEditorTickEnabled_IsValid = SetEditorTickEnabled_FunctionAddress != IntPtr.Zero && SetEditorTickEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LandmassEditor.LandmassActor:SetEditorTickEnabled", SetEditorTickEnabled_IsValid);
		CustomTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CustomTick");
		CustomTick_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomTick_DeltaSeconds_PropertyAddress, CustomTick_FunctionAddress, "DeltaSeconds");
		CustomTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(CustomTick_FunctionAddress, "DeltaSeconds");
		CustomTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		CustomTick_IsValid = CustomTick_FunctionAddress != IntPtr.Zero && CustomTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LandmassEditor.LandmassActor:CustomTick", CustomTick_IsValid);
		ActorSelectionChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ActorSelectionChanged");
		ActorSelectionChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorSelectionChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorSelectionChanged_bSelected_PropertyAddress, ActorSelectionChanged_FunctionAddress, "bSelected");
		ActorSelectionChanged_bSelected_Offset = NativeReflectionCached.GetPropertyOffset(ActorSelectionChanged_FunctionAddress, "bSelected");
		ActorSelectionChanged_bSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorSelectionChanged_FunctionAddress, "bSelected", Classes.FBoolProperty);
		ActorSelectionChanged_IsValid = ActorSelectionChanged_FunctionAddress != IntPtr.Zero && ActorSelectionChanged_bSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LandmassEditor.LandmassActor:ActorSelectionChanged", ActorSelectionChanged_IsValid);
	}
}
