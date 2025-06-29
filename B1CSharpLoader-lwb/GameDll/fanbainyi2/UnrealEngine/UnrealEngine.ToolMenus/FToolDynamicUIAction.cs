using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolDynamicUIAction", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolDynamicUIAction
{
	private static bool ExecuteAction_IsValid;

	private static int ExecuteAction_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/ToolMenus.ToolDynamicUIAction:ExecuteAction")]
	public FToolMenuDynamicExecuteAction ExecuteAction;

	private static bool CanExecuteAction_IsValid;

	private static int CanExecuteAction_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/ToolMenus.ToolDynamicUIAction:CanExecuteAction")]
	public FToolMenuDynamicCanExecuteAction CanExecuteAction;

	private static bool GetActionCheckState_IsValid;

	private static int GetActionCheckState_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/ToolMenus.ToolDynamicUIAction:GetActionCheckState")]
	public FToolMenuDynamicGetActionCheckState GetActionCheckState;

	private static bool IsActionVisibleDelegate_IsValid;

	private static int IsActionVisibleDelegate_Offset;

	[UProperty(Flags = (PropFlags)4503668347372037uL)]
	[UMetaPath("/Script/ToolMenus.ToolDynamicUIAction:IsActionVisibleDelegate")]
	public FToolMenuDynamicIsActionButtonVisible IsActionVisibleDelegate;

	private static bool FToolDynamicUIAction_IsValid;

	private static int FToolDynamicUIAction_StructSize;

	public FToolDynamicUIAction Copy()
	{
		return this;
	}

	public static FToolDynamicUIAction FromNative(IntPtr nativeBuffer)
	{
		return new FToolDynamicUIAction(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolDynamicUIAction value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolDynamicUIAction FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolDynamicUIAction(nativeBuffer + arrayIndex * FToolDynamicUIAction_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolDynamicUIAction value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolDynamicUIAction_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolDynamicUIAction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolDynamicUIAction");
			return;
		}
		FDelegateMarshaler<FToolMenuDynamicExecuteAction>.ToNative(IntPtr.Add(nativeStruct, ExecuteAction_Offset), ExecuteAction);
		FDelegateMarshaler<FToolMenuDynamicCanExecuteAction>.ToNative(IntPtr.Add(nativeStruct, CanExecuteAction_Offset), CanExecuteAction);
		FDelegateMarshaler<FToolMenuDynamicGetActionCheckState>.ToNative(IntPtr.Add(nativeStruct, GetActionCheckState_Offset), GetActionCheckState);
		FDelegateMarshaler<FToolMenuDynamicIsActionButtonVisible>.ToNative(IntPtr.Add(nativeStruct, IsActionVisibleDelegate_Offset), IsActionVisibleDelegate);
	}

	public FToolDynamicUIAction(IntPtr nativeStruct)
	{
		if (!FToolDynamicUIAction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolDynamicUIAction");
			ExecuteAction = new FToolMenuDynamicExecuteAction();
			CanExecuteAction = new FToolMenuDynamicCanExecuteAction();
			GetActionCheckState = new FToolMenuDynamicGetActionCheckState();
			IsActionVisibleDelegate = new FToolMenuDynamicIsActionButtonVisible();
		}
		else
		{
			ExecuteAction = FDelegateMarshaler<FToolMenuDynamicExecuteAction>.FromNative(IntPtr.Add(nativeStruct, ExecuteAction_Offset));
			CanExecuteAction = FDelegateMarshaler<FToolMenuDynamicCanExecuteAction>.FromNative(IntPtr.Add(nativeStruct, CanExecuteAction_Offset));
			GetActionCheckState = FDelegateMarshaler<FToolMenuDynamicGetActionCheckState>.FromNative(IntPtr.Add(nativeStruct, GetActionCheckState_Offset));
			IsActionVisibleDelegate = FDelegateMarshaler<FToolMenuDynamicIsActionButtonVisible>.FromNative(IntPtr.Add(nativeStruct, IsActionVisibleDelegate_Offset));
		}
	}

	static FToolDynamicUIAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolDynamicUIAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolDynamicUIAction));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolDynamicUIAction");
		FToolDynamicUIAction_StructSize = NativeReflection.GetStructSize(intPtr);
		ExecuteAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExecuteAction");
		ExecuteAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExecuteAction", Classes.FDelegateProperty);
		CanExecuteAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanExecuteAction");
		CanExecuteAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanExecuteAction", Classes.FDelegateProperty);
		GetActionCheckState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GetActionCheckState");
		GetActionCheckState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GetActionCheckState", Classes.FDelegateProperty);
		IsActionVisibleDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsActionVisibleDelegate");
		IsActionVisibleDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsActionVisibleDelegate", Classes.FDelegateProperty);
		FToolDynamicUIAction_IsValid = intPtr != IntPtr.Zero && ExecuteAction_IsValid && CanExecuteAction_IsValid && GetActionCheckState_IsValid && IsActionVisibleDelegate_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolDynamicUIAction", FToolDynamicUIAction_IsValid);
	}
}
