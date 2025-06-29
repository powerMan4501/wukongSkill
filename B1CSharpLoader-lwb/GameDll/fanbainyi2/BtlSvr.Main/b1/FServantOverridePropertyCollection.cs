using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ServantOverridePropertyCollection")]
public struct FServantOverridePropertyCollection
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ServantOverridePropertyCollection:SummonID")]
	public int SummonID;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ServantOverridePropertyCollection:BattleExtendID")]
	public int BattleExtendID;

	private static int ServantOverridePropertyCollection_StructSize;

	public FServantOverridePropertyCollection Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ServantOverridePropertyCollection");
		ServantOverridePropertyCollection_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FServantOverridePropertyCollection));
	}

	static FServantOverridePropertyCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FServantOverridePropertyCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FServantOverridePropertyCollection));
	}
}
