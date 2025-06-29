using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("怪物交还操作")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_GiveBackControlRightForMonster")]
internal class BED_MovieNode_GiveBackControlRightForMonster : BED_MovieNode
{
	private static bool MonsterGuid_IsValid;

	private static int MonsterGuid_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Movie")]
	[DisplayName("怪物")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_GiveBackControlRightForMonster:MonsterGuid")]
	public FGameplayTag MonsterGuid
	{
		get
		{
			CheckDestroyed();
			if (!MonsterGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRightForMonster:MonsterGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, MonsterGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MonsterGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_GiveBackControlRightForMonster:MonsterGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, MonsterGuid_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.GiveBackControlRightForMonster;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_GiveBackControlRightForMonster
		{
			MonsterGuid = MonsterGuid.TagName.PlainName
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_GiveBackControlRightForMonster");
		MonsterGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MonsterGuid");
		MonsterGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MonsterGuid", Classes.FStructProperty);
	}

	static BED_MovieNode_GiveBackControlRightForMonster()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_GiveBackControlRightForMonster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_GiveBackControlRightForMonster));
	}
}
