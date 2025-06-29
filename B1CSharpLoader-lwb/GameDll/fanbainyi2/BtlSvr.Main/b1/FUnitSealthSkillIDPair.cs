using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.UnitSealthSkillIDPair")]
public struct FUnitSealthSkillIDPair
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitSealthSkillIDPair:BeginStealthSkillID")]
	public int BeginStealthSkillID;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitSealthSkillIDPair:EndStealthSkillID")]
	public int EndStealthSkillID;

	private static int UnitSealthSkillIDPair_StructSize;

	public FUnitSealthSkillIDPair Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.UnitSealthSkillIDPair");
		UnitSealthSkillIDPair_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FUnitSealthSkillIDPair));
	}

	static FUnitSealthSkillIDPair()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitSealthSkillIDPair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitSealthSkillIDPair));
	}
}
