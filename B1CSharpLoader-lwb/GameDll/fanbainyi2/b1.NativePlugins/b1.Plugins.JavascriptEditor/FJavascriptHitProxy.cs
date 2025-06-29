using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptHitProxy", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptHitProxy
{
	private static int FJavascriptHitProxy_StructSize;

	public FJavascriptHitProxy Copy()
	{
		return this;
	}

	static FJavascriptHitProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptHitProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptHitProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptHitProxy");
		FJavascriptHitProxy_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptHitProxy));
	}
}
