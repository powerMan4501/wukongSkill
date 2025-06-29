using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckHPIsLow")]
internal class BAID_CheckHPIsLow : BAID_Base
{
	private bool bDoOnceFlag = true;

	private static bool HPLowPercent_IsValid;

	private static int HPLowPercent_Offset;

	private static bool bDoOnce_IsValid;

	private static int bDoOnce_Offset;

	private static FFieldAddress bDoOnce_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckHPIsLow:HPLowPercent")]
	public float HPLowPercent
	{
		get
		{
			CheckDestroyed();
			if (!HPLowPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHPIsLow:HPLowPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HPLowPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HPLowPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHPIsLow:HPLowPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HPLowPercent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("若勾选，则当低血量条件满足时，只会执行一次子节点")]
	[USharpPath("/Script/b1-Managed.BAID_CheckHPIsLow:bDoOnce")]
	public bool bDoOnce
	{
		get
		{
			CheckDestroyed();
			if (!bDoOnce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHPIsLow:bDoOnce");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDoOnce_Offset), 0, bDoOnce_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDoOnce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHPIsLow:bDoOnce");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDoOnce_Offset), 0, bDoOnce_PropertyAddress.Address, value);
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
		float num = BGUFunctionLibraryCS.BGUGetFloatAttr(bGUCharacterCS, EBGUAttrFloat.Hp);
		float num2 = BGUFunctionLibraryCS.BGUGetFloatAttr(bGUCharacterCS, EBGUAttrFloat.HpMax);
		if (bDoOnceFlag && num * 100f / num2 <= HPLowPercent)
		{
			if (bDoOnce)
			{
				if (!bDoOnceFlag)
				{
					return false;
				}
				bDoOnceFlag = false;
			}
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckHPIsLow");
		HPLowPercent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HPLowPercent");
		HPLowPercent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HPLowPercent", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bDoOnce_PropertyAddress, unrealStruct, "bDoOnce");
		bDoOnce_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDoOnce");
		bDoOnce_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDoOnce", Classes.FBoolProperty);
	}

	static BAID_CheckHPIsLow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckHPIsLow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckHPIsLow));
	}
}
