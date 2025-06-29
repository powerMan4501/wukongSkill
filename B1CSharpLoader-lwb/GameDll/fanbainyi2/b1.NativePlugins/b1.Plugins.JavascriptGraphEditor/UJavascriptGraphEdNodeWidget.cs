using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptGraphEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEdNodeWidget", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptGraphEdNodeWidget : UWidget
{
	private static bool SetNode_IsValid;

	private static IntPtr SetNode_FunctionAddress;

	private static int SetNode_ParamsSize;

	private static bool SetNode_InEdNode_IsValid;

	private static FFieldAddress SetNode_InEdNode_PropertyAddress;

	private static int SetNode_InEdNode_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEdNodeWidget:SetNode")]
	public unsafe void SetNode(UJavascriptGraphEdNode InEdNode)
	{
		CheckDestroyed();
		if (!SetNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEdNodeWidget:SetNode");
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

	static UJavascriptGraphEdNodeWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptGraphEdNodeWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptGraphEdNodeWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/JavascriptGraphEditor.JavascriptGraphEdNodeWidget");
		SetNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNode");
		SetNode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNode_InEdNode_PropertyAddress, SetNode_FunctionAddress, "InEdNode");
		SetNode_InEdNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNode_FunctionAddress, "InEdNode");
		SetNode_InEdNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNode_FunctionAddress, "InEdNode", Classes.FObjectProperty);
		SetNode_IsValid = SetNode_FunctionAddress != IntPtr.Zero && SetNode_InEdNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEdNodeWidget:SetNode", SetNode_IsValid);
	}
}
