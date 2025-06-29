using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckUnitHasState")]
internal class BAID_CheckUnitHasState : BAID_Base
{
	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	private static bool IsCheckTarget_IsValid;

	private static int IsCheckTarget_Offset;

	private static FFieldAddress IsCheckTarget_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitHasState:UnitState")]
	public EBGUUnitState UnitState
	{
		get
		{
			CheckDestroyed();
			if (!UnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasState:UnitState");
				return EBGUUnitState.None;
			}
			return EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(base.Address, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasState:UnitState");
			}
			else
			{
				EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(base.Address, UnitState_Offset), 0, UnitState_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitHasState:IsCheckTarget")]
	public bool IsCheckTarget
	{
		get
		{
			CheckDestroyed();
			if (!IsCheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasState:IsCheckTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCheckTarget_Offset), 0, IsCheckTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasState:IsCheckTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCheckTarget_Offset), 0, IsCheckTarget_PropertyAddress.Address, value);
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
		if (IsCheckTarget)
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS);
			if (aActor.IsNullOrDestroyed())
			{
				return false;
			}
			if (BGUFunctionLibraryCS.BGUHasUnitState(aActor, UnitState))
			{
				return true;
			}
		}
		else if (BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, UnitState))
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckUnitHasState");
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, unrealStruct, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsCheckTarget_PropertyAddress, unrealStruct, "IsCheckTarget");
		IsCheckTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsCheckTarget");
		IsCheckTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsCheckTarget", Classes.FBoolProperty);
	}

	static BAID_CheckUnitHasState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckUnitHasState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckUnitHasState));
	}
}
