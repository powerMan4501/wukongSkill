using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("检查当前设置好的连招长度（一次Combo打多少招）")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckCurRamdomComboLength")]
internal class BAID_CheckCurRamdomComboLength : BAID_Base
{
	private static bool ComboLengthYouWant_IsValid;

	private static int ComboLengthYouWant_Offset;

	private static bool PreferCloser_IsValid;

	private static int PreferCloser_Offset;

	private static FFieldAddress PreferCloser_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurRamdomComboLength:ComboLengthYouWant")]
	public int ComboLengthYouWant
	{
		get
		{
			CheckDestroyed();
			if (!ComboLengthYouWant_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurRamdomComboLength:ComboLengthYouWant");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ComboLengthYouWant_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ComboLengthYouWant_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurRamdomComboLength:ComboLengthYouWant");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ComboLengthYouWant_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurRamdomComboLength:PreferCloser")]
	public bool PreferCloser
	{
		get
		{
			CheckDestroyed();
			if (!PreferCloser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurRamdomComboLength:PreferCloser");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreferCloser_Offset), 0, PreferCloser_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreferCloser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurRamdomComboLength:PreferCloser");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreferCloser_Offset), 0, PreferCloser_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(actor);
			if (unPersistentReadOnlyData == null)
			{
				return false;
			}
			int curComboLength = unPersistentReadOnlyData.GetCurComboLength();
			if (PreferCloser)
			{
				return curComboLength <= ComboLengthYouWant;
			}
			return curComboLength >= ComboLengthYouWant;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCurRamdomComboLength");
		ComboLengthYouWant_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ComboLengthYouWant");
		ComboLengthYouWant_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ComboLengthYouWant", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref PreferCloser_PropertyAddress, unrealStruct, "PreferCloser");
		PreferCloser_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreferCloser");
		PreferCloser_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreferCloser", Classes.FBoolProperty);
	}

	static BAID_CheckCurRamdomComboLength()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCurRamdomComboLength)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCurRamdomComboLength));
	}
}
