using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)819990688uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSInput.GSInputWidget", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputWidget : UUserWidget
{
	private static bool OnFocusChanging_IsValid;

	private IntPtr OnFocusChanging_InstanceFunctionAddress;

	private static IntPtr OnFocusChanging_FunctionAddress;

	private static int OnFocusChanging_ParamsSize;

	private static bool OnFocusChanging_InFocusEvent_IsValid;

	private static FFieldAddress OnFocusChanging_InFocusEvent_PropertyAddress;

	private static int OnFocusChanging_InFocusEvent_Offset;

	private static bool IsChildGSWidgetOf_IsValid;

	private static IntPtr IsChildGSWidgetOf_FunctionAddress;

	private static int IsChildGSWidgetOf_ParamsSize;

	private static bool IsChildGSWidgetOf_PossibleParent_IsValid;

	private static FFieldAddress IsChildGSWidgetOf_PossibleParent_PropertyAddress;

	private static int IsChildGSWidgetOf_PossibleParent_Offset;

	private static bool IsChildGSWidgetOf_ReturnValue_IsValid;

	private static FFieldAddress IsChildGSWidgetOf_ReturnValue_PropertyAddress;

	private static int IsChildGSWidgetOf_ReturnValue_Offset;

	private static bool EditorTickActionsAndAnimation_IsValid;

	private static IntPtr EditorTickActionsAndAnimation_FunctionAddress;

	private static int EditorTickActionsAndAnimation_ParamsSize;

	private static bool EditorTickActionsAndAnimation_InDeltaTime_IsValid;

	private static FFieldAddress EditorTickActionsAndAnimation_InDeltaTime_PropertyAddress;

	private static int EditorTickActionsAndAnimation_InDeltaTime_Offset;

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/GSInput.GSInputWidget:OnFocusChanging")]
	public unsafe void OnFocusChanging(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnFocusChanging_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputWidget:OnFocusChanging");
			return;
		}
		if (OnFocusChanging_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFocusChanging_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFocusChanging");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFocusChanging_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFocusChanging_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnFocusChanging_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnFocusChanging_InFocusEvent_Offset), 0, OnFocusChanging_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFocusChanging_InstanceFunctionAddress, intPtr, OnFocusChanging_ParamsSize);
	}

	protected unsafe virtual void OnFocusChanging_Implementation(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnFocusChanging_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputWidget:OnFocusChanging");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFocusChanging_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFocusChanging_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnFocusChanging_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnFocusChanging_InFocusEvent_Offset), 0, OnFocusChanging_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFocusChanging_FunctionAddress, intPtr, OnFocusChanging_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputWidget:IsChildGSWidgetOf")]
	public unsafe bool IsChildGSWidgetOf(UWidget PossibleParent)
	{
		CheckDestroyed();
		if (!IsChildGSWidgetOf_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputWidget:IsChildGSWidgetOf");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsChildGSWidgetOf_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsChildGSWidgetOf_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, IsChildGSWidgetOf_PossibleParent_Offset), 0, IsChildGSWidgetOf_PossibleParent_PropertyAddress.Address, PossibleParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsChildGSWidgetOf_FunctionAddress, intPtr, IsChildGSWidgetOf_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsChildGSWidgetOf_ReturnValue_Offset), 0, IsChildGSWidgetOf_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/GSInput.GSInputWidget:EditorTickActionsAndAnimation")]
	public unsafe void EditorTickActionsAndAnimation(float InDeltaTime)
	{
		CheckDestroyed();
		if (!EditorTickActionsAndAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputWidget:EditorTickActionsAndAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorTickActionsAndAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorTickActionsAndAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorTickActionsAndAnimation_InDeltaTime_Offset), 0, EditorTickActionsAndAnimation_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorTickActionsAndAnimation_FunctionAddress, intPtr, EditorTickActionsAndAnimation_ParamsSize);
	}

	static UGSInputWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSInput.GSInputWidget");
		OnFocusChanging_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnFocusChanging");
		OnFocusChanging_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFocusChanging_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFocusChanging_InFocusEvent_PropertyAddress, OnFocusChanging_FunctionAddress, "InFocusEvent");
		OnFocusChanging_InFocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnFocusChanging_FunctionAddress, "InFocusEvent");
		OnFocusChanging_InFocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFocusChanging_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnFocusChanging_IsValid = OnFocusChanging_FunctionAddress != IntPtr.Zero && OnFocusChanging_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputWidget:OnFocusChanging", OnFocusChanging_IsValid);
		IsChildGSWidgetOf_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsChildGSWidgetOf");
		IsChildGSWidgetOf_ParamsSize = NativeReflection.GetFunctionParamsSize(IsChildGSWidgetOf_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsChildGSWidgetOf_PossibleParent_PropertyAddress, IsChildGSWidgetOf_FunctionAddress, "PossibleParent");
		IsChildGSWidgetOf_PossibleParent_Offset = NativeReflectionCached.GetPropertyOffset(IsChildGSWidgetOf_FunctionAddress, "PossibleParent");
		IsChildGSWidgetOf_PossibleParent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChildGSWidgetOf_FunctionAddress, "PossibleParent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsChildGSWidgetOf_ReturnValue_PropertyAddress, IsChildGSWidgetOf_FunctionAddress, "ReturnValue");
		IsChildGSWidgetOf_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsChildGSWidgetOf_FunctionAddress, "ReturnValue");
		IsChildGSWidgetOf_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChildGSWidgetOf_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsChildGSWidgetOf_IsValid = IsChildGSWidgetOf_FunctionAddress != IntPtr.Zero && IsChildGSWidgetOf_PossibleParent_IsValid && IsChildGSWidgetOf_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputWidget:IsChildGSWidgetOf", IsChildGSWidgetOf_IsValid);
		EditorTickActionsAndAnimation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EditorTickActionsAndAnimation");
		EditorTickActionsAndAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorTickActionsAndAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorTickActionsAndAnimation_InDeltaTime_PropertyAddress, EditorTickActionsAndAnimation_FunctionAddress, "InDeltaTime");
		EditorTickActionsAndAnimation_InDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(EditorTickActionsAndAnimation_FunctionAddress, "InDeltaTime");
		EditorTickActionsAndAnimation_InDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorTickActionsAndAnimation_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		EditorTickActionsAndAnimation_IsValid = EditorTickActionsAndAnimation_FunctionAddress != IntPtr.Zero && EditorTickActionsAndAnimation_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputWidget:EditorTickActionsAndAnimation", EditorTickActionsAndAnimation_IsValid);
	}
}
