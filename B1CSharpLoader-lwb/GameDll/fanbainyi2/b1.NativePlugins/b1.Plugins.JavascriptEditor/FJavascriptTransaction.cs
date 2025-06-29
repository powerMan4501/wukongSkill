using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptTransaction", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptTransaction
{
	private static int FJavascriptTransaction_StructSize;

	public FJavascriptTransaction Copy()
	{
		return this;
	}

	static FJavascriptTransaction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptTransaction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptTransaction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptTransaction");
		FJavascriptTransaction_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptTransaction));
	}
}
