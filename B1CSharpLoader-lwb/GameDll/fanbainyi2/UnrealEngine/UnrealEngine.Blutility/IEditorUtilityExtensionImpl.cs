using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

public sealed class IEditorUtilityExtensionImpl : IInterfaceImpl, IEditorUtilityExtension, IInterface
{
	static IEditorUtilityExtensionImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IEditorUtilityExtensionImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IEditorUtilityExtensionImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Blutility.EditorUtilityExtension");
	}
}
