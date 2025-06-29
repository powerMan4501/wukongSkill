using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGW_DispLibDBCEditorDebugConfigDataAsset")]
public class BGW_DispLibDBCEditorDebugConfigDataAsset : UBGWDataAsset
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibDBCEditorDebugConfigDataAsset");
	}

	static BGW_DispLibDBCEditorDebugConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibDBCEditorDebugConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibDBCEditorDebugConfigDataAsset));
	}
}
