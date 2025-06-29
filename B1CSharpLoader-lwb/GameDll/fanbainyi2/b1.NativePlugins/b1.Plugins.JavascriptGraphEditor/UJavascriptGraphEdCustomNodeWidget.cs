using System;
using System.Runtime.CompilerServices;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptGraphEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptGraphEdCustomNodeWidget : UWidget
{
	private static bool SetNode_IsValid;

	private static IntPtr SetNode_FunctionAddress;

	private static int SetNode_ParamsSize;

	private static bool SetNode_InEdNode_IsValid;

	private static FFieldAddress SetNode_InEdNode_PropertyAddress;

	private static int SetNode_InEdNode_Offset;

	private static bool SetGraphPanel_IsValid;

	private static IntPtr SetGraphPanel_FunctionAddress;

	private static int SetGraphPanel_ParamsSize;

	private static bool SetGraphPanel_InGraphPanel_IsValid;

	private static FFieldAddress SetGraphPanel_InGraphPanel_PropertyAddress;

	private static int SetGraphPanel_InGraphPanel_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget:SetNode")]
	public unsafe void SetNode(UJavascriptGraphEdNode InEdNode)
	{
		CheckDestroyed();
		if (!SetNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget:SetNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptGraphEdNode>.ToNative(IntPtr.Add(intPtr, SetNode_InEdNode_Offset), 0, SetNode_InEdNode_PropertyAddress.Address, InEdNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNode_FunctionAddress, intPtr, SetNode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget:SetGraphPanel")]
	public unsafe void SetGraphPanel(FJavascriptSlateWidget InGraphPanel)
	{
		CheckDestroyed();
		if (!SetGraphPanel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget:SetGraphPanel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGraphPanel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGraphPanel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGraphPanel_InGraphPanel_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, SetGraphPanel_InGraphPanel_Offset), 0, SetGraphPanel_InGraphPanel_PropertyAddress.Address, InGraphPanel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGraphPanel_FunctionAddress, intPtr, SetGraphPanel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetGraphPanel_InGraphPanel_PropertyAddress.Address, intPtr);
	}

	static UJavascriptGraphEdCustomNodeWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptGraphEdCustomNodeWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptGraphEdCustomNodeWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget");
		SetNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNode");
		SetNode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNode_InEdNode_PropertyAddress, SetNode_FunctionAddress, "InEdNode");
		SetNode_InEdNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNode_FunctionAddress, "InEdNode");
		SetNode_InEdNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNode_FunctionAddress, "InEdNode", Classes.FObjectProperty);
		SetNode_IsValid = SetNode_FunctionAddress != IntPtr.Zero && SetNode_InEdNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget:SetNode", SetNode_IsValid);
		SetGraphPanel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGraphPanel");
		SetGraphPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGraphPanel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGraphPanel_InGraphPanel_PropertyAddress, SetGraphPanel_FunctionAddress, "InGraphPanel");
		SetGraphPanel_InGraphPanel_Offset = NativeReflectionCached.GetPropertyOffset(SetGraphPanel_FunctionAddress, "InGraphPanel");
		SetGraphPanel_InGraphPanel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGraphPanel_FunctionAddress, "InGraphPanel", Classes.FStructProperty);
		SetGraphPanel_IsValid = SetGraphPanel_FunctionAddress != IntPtr.Zero && SetGraphPanel_InGraphPanel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEdCustomNodeWidget:SetGraphPanel", SetGraphPanel_IsValid);
	}
}
