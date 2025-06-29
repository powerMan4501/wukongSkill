using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BIS_AssociationUniMgr")]
public class BIS_AssociationUniMgr : GameInstanceSystemBaseUObj
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BIS_AssociationUniMgr");
	}

	static BIS_AssociationUniMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BIS_AssociationUniMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BIS_AssociationUniMgr));
	}
}
