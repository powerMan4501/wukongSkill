using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptEdViewport", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptEdViewport
{
	private static int FJavascriptEdViewport_StructSize;

	public FJavascriptEdViewport Copy()
	{
		return this;
	}

	static FJavascriptEdViewport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptEdViewport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptEdViewport));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptEdViewport");
		FJavascriptEdViewport_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptEdViewport));
	}
}
