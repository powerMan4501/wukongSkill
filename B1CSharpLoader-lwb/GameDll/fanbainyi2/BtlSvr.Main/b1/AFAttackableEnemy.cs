using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AFAttackableEnemy")]
public class AFAttackableEnemy : AttentionFeatureBase
{
	private static bool EnemyActors_IsValid;

	private static int EnemyActors_Offset;

	private static FFieldAddress EnemyActors_PropertyAddress;

	private TArrayReadWriteMarshaler<BGUCharacterCS> EnemyActors_Marshaler;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AFAttackableEnemy:EnemyActors")]
	public TArrayReadWrite<BGUCharacterCS> EnemyActors
	{
		get
		{
			CheckDestroyed();
			if (!EnemyActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AFAttackableEnemy:EnemyActors");
				return null;
			}
			if (EnemyActors_Marshaler == null)
			{
				EnemyActors_Marshaler = new TArrayReadWriteMarshaler<BGUCharacterCS>(1, EnemyActors_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative);
			}
			return EnemyActors_Marshaler.FromNative(IntPtr.Add(base.Address, EnemyActors_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.FeatureType = EAIAttentionFeatureType.AttackableEnemy;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AFAttackableEnemy");
		NativeReflection.GetPropertyRef(ref EnemyActors_PropertyAddress, unrealStruct, "EnemyActors");
		EnemyActors_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnemyActors");
		EnemyActors_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnemyActors", Classes.FArrayProperty);
	}

	static AFAttackableEnemy()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AFAttackableEnemy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFAttackableEnemy));
	}
}
