using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AFNearestEnemy")]
public class AFNearestEnemy : AttentionFeatureBase
{
	public FVector EnemyLoc;

	private static bool EnemyCharacter_IsValid;

	private static int EnemyCharacter_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AFNearestEnemy:EnemyCharacter")]
	public ACharacter EnemyCharacter
	{
		get
		{
			CheckDestroyed();
			if (!EnemyCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AFNearestEnemy:EnemyCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, EnemyCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnemyCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AFNearestEnemy:EnemyCharacter");
			}
			else
			{
				UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(base.Address, EnemyCharacter_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.FeatureType = EAIAttentionFeatureType.NearestEnemy;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AFNearestEnemy");
		EnemyCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnemyCharacter");
		EnemyCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnemyCharacter", Classes.FObjectProperty);
	}

	static AFNearestEnemy()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AFNearestEnemy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFNearestEnemy));
	}
}
