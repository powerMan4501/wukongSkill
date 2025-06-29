using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptPDI", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptPDI
{
	private static int FJavascriptPDI_StructSize;

	public FJavascriptPDI Copy()
	{
		return this;
	}

	static FJavascriptPDI()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptPDI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptPDI));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptPDI");
		FJavascriptPDI_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptPDI));
	}
}
