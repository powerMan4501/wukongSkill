using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BoneUseForDispMap")]
public struct FBoneUseForDispMap
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("-1 is Body")]
	[USharpPath("/Script/b1-Managed.BoneUseForDispMap:WeaponIndex")]
	public int WeaponIndex;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BoneUseForDispMap:FirstBoneName")]
	public FName FirstBoneName;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BoneUseForDispMap:FirstRadius")]
	public float FirstRadius;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BoneUseForDispMap:NextBoneName")]
	public FName NextBoneName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BoneUseForDispMap:NextRadius")]
	public float NextRadius;

	private static int BoneUseForDispMap_StructSize;

	public FBoneUseForDispMap(int _WeaponIndex, FName _FirstBoneName, float _FirstRadius, FName _NextBoneName, float _NextRadius)
	{
		WeaponIndex = _WeaponIndex;
		FirstBoneName = _FirstBoneName;
		FirstRadius = _FirstRadius;
		NextBoneName = _NextBoneName;
		NextRadius = _NextRadius;
	}

	public FBoneUseForDispMap Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.BoneUseForDispMap");
		BoneUseForDispMap_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FBoneUseForDispMap));
	}

	static FBoneUseForDispMap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBoneUseForDispMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBoneUseForDispMap));
	}
}
