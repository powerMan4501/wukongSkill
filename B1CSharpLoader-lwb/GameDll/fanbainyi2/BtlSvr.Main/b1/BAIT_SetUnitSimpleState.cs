using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SetUnitSimpleState")]
internal class BAIT_SetUnitSimpleState : BAIT_Base
{
	private static bool UnitSimpleState_IsValid;

	private static int UnitSimpleState_Offset;

	private static FFieldAddress UnitSimpleState_PropertyAddress;

	private static bool IsRemove_IsValid;

	private static int IsRemove_Offset;

	private static FFieldAddress IsRemove_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SetUnitSimpleState:UnitSimpleState")]
	public EBGUSimpleState UnitSimpleState
	{
		get
		{
			CheckDestroyed();
			if (!UnitSimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetUnitSimpleState:UnitSimpleState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, UnitSimpleState_Offset), 0, UnitSimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitSimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetUnitSimpleState:UnitSimpleState");
			}
			else
			{
				EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(base.Address, UnitSimpleState_Offset), 0, UnitSimpleState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SetUnitSimpleState:IsRemove")]
	public bool IsRemove
	{
		get
		{
			CheckDestroyed();
			if (!IsRemove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetUnitSimpleState:IsRemove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRemove_Offset), 0, IsRemove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRemove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetUnitSimpleState:IsRemove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRemove_Offset), 0, IsRemove_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(bGUCharacterCS, UnitSimpleState, IsRemove);
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SetUnitSimpleState");
		NativeReflection.GetPropertyRef(ref UnitSimpleState_PropertyAddress, unrealStruct, "UnitSimpleState");
		UnitSimpleState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitSimpleState");
		UnitSimpleState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitSimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsRemove_PropertyAddress, unrealStruct, "IsRemove");
		IsRemove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsRemove");
		IsRemove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsRemove", Classes.FBoolProperty);
	}

	static BAIT_SetUnitSimpleState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SetUnitSimpleState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SetUnitSimpleState));
	}
}
