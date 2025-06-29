using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptPinWidget", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptPinWidget
{
	private static int FJavascriptPinWidget_StructSize;

	public FJavascriptPinWidget Copy()
	{
		return this;
	}

	static FJavascriptPinWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptPinWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptPinWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptPinWidget");
		FJavascriptPinWidget_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptPinWidget));
	}
}
