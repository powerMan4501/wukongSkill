using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckUnitInRange")]
internal class BAID_CheckUnitInRange : BAID_Base
{
	private static bool UnitResID_IsValid;

	private static int UnitResID_Offset;

	private static bool CheckRange_IsValid;

	private static int CheckRange_Offset;

	private static bool CheckCount_IsValid;

	private static int CheckCount_Offset;

	private static bool bLessOrEqual_IsValid;

	private static int bLessOrEqual_Offset;

	private static FFieldAddress bLessOrEqual_PropertyAddress;

	private static bool bCheckUnitAlive_IsValid;

	private static int bCheckUnitAlive_Offset;

	private static FFieldAddress bCheckUnitAlive_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitInRange:UnitResID")]
	public int UnitResID
	{
		get
		{
			CheckDestroyed();
			if (!UnitResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:UnitResID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UnitResID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:UnitResID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UnitResID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitInRange:CheckRange")]
	public float CheckRange
	{
		get
		{
			CheckDestroyed();
			if (!CheckRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:CheckRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CheckRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:CheckRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CheckRange_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitInRange:CheckCount")]
	public int CheckCount
	{
		get
		{
			CheckDestroyed();
			if (!CheckCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:CheckCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CheckCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:CheckCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CheckCount_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("若勾选，在范围内的单位数量需小于等于CheckCount才返回真；不勾选，则判断条件为大于")]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitInRange:bLessOrEqual")]
	public bool bLessOrEqual
	{
		get
		{
			CheckDestroyed();
			if (!bLessOrEqual_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:bLessOrEqual");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLessOrEqual_Offset), 0, bLessOrEqual_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLessOrEqual_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:bLessOrEqual");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLessOrEqual_Offset), 0, bLessOrEqual_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("若勾选，会筛选掉已死亡的单位")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitInRange:bCheckUnitAlive")]
	public bool bCheckUnitAlive
	{
		get
		{
			CheckDestroyed();
			if (!bCheckUnitAlive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:bCheckUnitAlive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheckUnitAlive_Offset), 0, bCheckUnitAlive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheckUnitAlive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitInRange:bCheckUnitAlive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheckUnitAlive_Offset), 0, bCheckUnitAlive_PropertyAddress.Address, value);
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
		int num = 0;
		IBIC_GlobalActorData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(bGUCharacterCS);
		if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.GetActorsByResID(UnitResID, out var OutActors))
		{
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			foreach (AActor item in OutActors)
			{
				BGUCharacterCS bGUCharacterCS2 = item as BGUCharacterCS;
				if (bGUCharacterCS2 != null && !(FVector.Dist(v, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS2)) > CheckRange) && (!bCheckUnitAlive || (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS2, EBGUSimpleState.PendingDeathInAnimationSyncing) && !BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS2, EBGUUnitState.Dead))))
				{
					num++;
				}
			}
		}
		if (bLessOrEqual)
		{
			return num <= CheckCount;
		}
		return num > CheckCount;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckUnitInRange");
		UnitResID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitResID");
		UnitResID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitResID", Classes.FIntProperty);
		CheckRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckRange");
		CheckRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckRange", Classes.FFloatProperty);
		CheckCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckCount");
		CheckCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckCount", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bLessOrEqual_PropertyAddress, unrealStruct, "bLessOrEqual");
		bLessOrEqual_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bLessOrEqual");
		bLessOrEqual_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bLessOrEqual", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheckUnitAlive_PropertyAddress, unrealStruct, "bCheckUnitAlive");
		bCheckUnitAlive_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCheckUnitAlive");
		bCheckUnitAlive_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCheckUnitAlive", Classes.FBoolProperty);
	}

	static BAID_CheckUnitInRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckUnitInRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckUnitInRange));
	}
}
