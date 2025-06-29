using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("检查当前设置好的连招（打多少次Combo）")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckMaxComboValue")]
internal class BAID_CheckMaxComboValue : BAID_Base
{
	private static bool CompareType_IsValid;

	private static int CompareType_Offset;

	private static FFieldAddress CompareType_PropertyAddress;

	private static bool KeyValue_IsValid;

	private static int KeyValue_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckMaxComboValue:CompareType")]
	public EValueCompareType CompareType
	{
		get
		{
			CheckDestroyed();
			if (!CompareType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMaxComboValue:CompareType");
				return EValueCompareType.IsEqualTo;
			}
			return EnumMarshaler<EValueCompareType>.FromNative(IntPtr.Add(base.Address, CompareType_Offset), 0, CompareType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompareType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMaxComboValue:CompareType");
			}
			else
			{
				EnumMarshaler<EValueCompareType>.ToNative(IntPtr.Add(base.Address, CompareType_Offset), 0, CompareType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckMaxComboValue:KeyValue")]
	public int KeyValue
	{
		get
		{
			CheckDestroyed();
			if (!KeyValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMaxComboValue:KeyValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, KeyValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KeyValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMaxComboValue:KeyValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, KeyValue_Offset), value);
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
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(bGUCharacterCS);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		return AIFuncLibForCS.CompareValue(unPersistentReadOnlyData.GetMaxComboNum(), KeyValue, CompareType);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckMaxComboValue");
		NativeReflection.GetPropertyRef(ref CompareType_PropertyAddress, unrealStruct, "CompareType");
		CompareType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CompareType");
		CompareType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CompareType", Classes.FEnumProperty);
		KeyValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KeyValue");
		KeyValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KeyValue", Classes.FIntProperty);
	}

	static BAID_CheckMaxComboValue()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckMaxComboValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckMaxComboValue));
	}
}
