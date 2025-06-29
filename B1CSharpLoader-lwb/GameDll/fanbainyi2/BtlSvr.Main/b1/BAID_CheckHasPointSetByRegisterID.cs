using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID")]
public class BAID_CheckHasPointSetByRegisterID : BAID_Base
{
	private static bool RegisterID_IsValid;

	private static int RegisterID_Offset;

	private static bool PointMinNum_IsValid;

	private static int PointMinNum_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID:RegisterID")]
	public int RegisterID
	{
		get
		{
			CheckDestroyed();
			if (!RegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID:RegisterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RegisterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID:RegisterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RegisterID_Offset), value);
			}
		}
	}

	[DisplayName("点的数量大于等于")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID:PointMinNum")]
	public int PointMinNum
	{
		get
		{
			CheckDestroyed();
			if (!PointMinNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID:PointMinNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointMinNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointMinNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID:PointMinNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointMinNum_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		List<FVector> list = BGUFunctionLibraryCS.BGUGetCachedPointSet(OwnerActor, RegisterID);
		if (list != null && list.Count >= PointMinNum)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckHasPointSetByRegisterID");
		RegisterID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RegisterID");
		RegisterID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RegisterID", Classes.FIntProperty);
		PointMinNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PointMinNum");
		PointMinNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PointMinNum", Classes.FIntProperty);
	}

	static BAID_CheckHasPointSetByRegisterID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckHasPointSetByRegisterID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckHasPointSetByRegisterID));
	}
}
