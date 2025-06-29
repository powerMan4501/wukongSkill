using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PairSkillIDBeginEnd")]
public struct PairSkillIDBeginEnd
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PairSkillIDBeginEnd:SkillIDBegin")]
	public int SkillIDBegin;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PairSkillIDBeginEnd:SkillIDEnd")]
	public int SkillIDEnd;

	private static int PairSkillIDBeginEnd_StructSize;

	public PairSkillIDBeginEnd Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.PairSkillIDBeginEnd");
		PairSkillIDBeginEnd_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(PairSkillIDBeginEnd));
	}

	static PairSkillIDBeginEnd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PairSkillIDBeginEnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PairSkillIDBeginEnd));
	}
}
