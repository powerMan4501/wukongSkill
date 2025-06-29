using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckSpeed")]
internal class BAID_CheckSpeed : BAID_Base
{
	private static bool CompareType_IsValid;

	private static int CompareType_Offset;

	private static FFieldAddress CompareType_PropertyAddress;

	private static bool BasedSpeed_IsValid;

	private static int BasedSpeed_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckSpeed:CompareType")]
	public EValueCompareType CompareType
	{
		get
		{
			CheckDestroyed();
			if (!CompareType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSpeed:CompareType");
				return EValueCompareType.IsEqualTo;
			}
			return EnumMarshaler<EValueCompareType>.FromNative(IntPtr.Add(base.Address, CompareType_Offset), 0, CompareType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSpeed:CompareType");
			}
			else
			{
				EnumMarshaler<EValueCompareType>.ToNative(IntPtr.Add(base.Address, CompareType_Offset), 0, CompareType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckSpeed:BasedSpeed")]
	public float BasedSpeed
	{
		get
		{
			CheckDestroyed();
			if (!BasedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSpeed:BasedSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BasedSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BasedSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSpeed:BasedSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BasedSpeed_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		float ori = OwnerActor.GetVelocity().Size();
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(OwnerActor);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
		{
			b1.IBUC_PhysicalMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysicalMoveData, b1.BUC_PhysicalMoveData>(OwnerActor);
			if (unPersistentReadOnlyData != null)
			{
				ori = unPersistentReadOnlyData.PhysicalMoveVelocity.Size();
			}
		}
		return AIFuncLibForCS.CompareValue(ori, BasedSpeed, CompareType);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckSpeed");
		NativeReflection.GetPropertyRef(ref CompareType_PropertyAddress, unrealStruct, "CompareType");
		CompareType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CompareType");
		CompareType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CompareType", Classes.FEnumProperty);
		BasedSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BasedSpeed");
		BasedSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BasedSpeed", Classes.FFloatProperty);
	}

	static BAID_CheckSpeed()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckSpeed)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckSpeed));
	}
}
