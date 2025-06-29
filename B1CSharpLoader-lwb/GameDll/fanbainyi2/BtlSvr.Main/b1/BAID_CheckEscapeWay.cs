using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckEscapeWay")]
public class BAID_CheckEscapeWay : BAID_Base
{
	private static bool EscapeWay_IsValid;

	private static int EscapeWay_Offset;

	private static FFieldAddress EscapeWay_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("脱困方式")]
	[Tooltip("脱困方式与当前相等时返回true")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckEscapeWay:EscapeWay")]
	public EEscapeWay EscapeWay
	{
		get
		{
			CheckDestroyed();
			if (!EscapeWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckEscapeWay:EscapeWay");
				return EEscapeWay.None;
			}
			return EnumMarshaler<EEscapeWay>.FromNative(IntPtr.Add(base.Address, EscapeWay_Offset), 0, EscapeWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EscapeWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckEscapeWay:EscapeWay");
			}
			else
			{
				EnumMarshaler<EEscapeWay>.ToNative(IntPtr.Add(base.Address, EscapeWay_Offset), 0, EscapeWay_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		EscapeWay = EEscapeWay.CastSkill;
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			return false;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(aBGUCharacter);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		AIData_Memory memory = unPersistentReadOnlyData.Memory;
		if (memory == null)
		{
			return false;
		}
		return memory.EscapeWay == EscapeWay;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckEscapeWay");
		NativeReflection.GetPropertyRef(ref EscapeWay_PropertyAddress, unrealStruct, "EscapeWay");
		EscapeWay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EscapeWay");
		EscapeWay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EscapeWay", Classes.FEnumProperty);
	}

	static BAID_CheckEscapeWay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckEscapeWay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckEscapeWay));
	}
}
