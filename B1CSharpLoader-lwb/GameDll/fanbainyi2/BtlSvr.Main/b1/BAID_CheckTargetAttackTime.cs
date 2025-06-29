using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckTargetAttackTime")]
internal class BAID_CheckTargetAttackTime : BAID_Base
{
	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool ConsiSelfIsLastAttacker_IsValid;

	private static int ConsiSelfIsLastAttacker_Offset;

	private static FFieldAddress ConsiSelfIsLastAttacker_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetAttackTime:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetAttackTime:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetAttackTime:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckTargetAttackTime:ConsiSelfIsLastAttacker")]
	public bool ConsiSelfIsLastAttacker
	{
		get
		{
			CheckDestroyed();
			if (!ConsiSelfIsLastAttacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetAttackTime:ConsiSelfIsLastAttacker");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConsiSelfIsLastAttacker_Offset), 0, ConsiSelfIsLastAttacker_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConsiSelfIsLastAttacker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckTargetAttackTime:ConsiSelfIsLastAttacker");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConsiSelfIsLastAttacker_Offset), 0, ConsiSelfIsLastAttacker_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS);
		if (aActor != null)
		{
			BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(aActor);
			if (unPersistentReadOnlyData == null)
			{
				return false;
			}
			float lastBeHitTime = unPersistentReadOnlyData.GetLastBeHitTime();
			float timeSeconds = bGUCharacterCS.World.GetTimeSeconds();
			bool num = lastBeHitTime + Time <= timeSeconds;
			bool flag = false;
			if (ConsiSelfIsLastAttacker)
			{
				flag = bGUCharacterCS == unPersistentReadOnlyData.GetLastAttacker();
			}
			return num || flag;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckTargetAttackTime");
		Time_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ConsiSelfIsLastAttacker_PropertyAddress, unrealStruct, "ConsiSelfIsLastAttacker");
		ConsiSelfIsLastAttacker_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConsiSelfIsLastAttacker");
		ConsiSelfIsLastAttacker_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConsiSelfIsLastAttacker", Classes.FBoolProperty);
	}

	static BAID_CheckTargetAttackTime()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckTargetAttackTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckTargetAttackTime));
	}
}
