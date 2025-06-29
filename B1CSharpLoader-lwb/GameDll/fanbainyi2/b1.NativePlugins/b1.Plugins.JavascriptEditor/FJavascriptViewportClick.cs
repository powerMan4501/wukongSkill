using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptViewportClick", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptViewportClick
{
	private static int FJavascriptViewportClick_StructSize;

	public FJavascriptViewportClick Copy()
	{
		return this;
	}

	static FJavascriptViewportClick()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptViewportClick)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptViewportClick));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptViewportClick");
		FJavascriptViewportClick_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptViewportClick));
	}
}
