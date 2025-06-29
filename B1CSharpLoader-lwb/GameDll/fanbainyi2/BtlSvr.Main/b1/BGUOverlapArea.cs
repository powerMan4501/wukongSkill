using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUOverlapArea")]
public class BGUOverlapArea : BGUAreaBase
{
	protected override FName GetRootCompName()
	{
		return B1GlobalFNames.DefaultSceneRoot;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUOverlapArea");
	}

	static BGUOverlapArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUOverlapArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUOverlapArea));
	}
}
