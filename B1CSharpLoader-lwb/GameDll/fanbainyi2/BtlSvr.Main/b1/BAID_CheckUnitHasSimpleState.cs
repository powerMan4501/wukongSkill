using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckUnitHasSimpleState")]
internal class BAID_CheckUnitHasSimpleState : BAID_Base
{
	private static bool UnitSimpleState_IsValid;

	private static int UnitSimpleState_Offset;

	private static FFieldAddress UnitSimpleState_PropertyAddress;

	private static bool IsCheckTarget_IsValid;

	private static int IsCheckTarget_Offset;

	private static FFieldAddress IsCheckTarget_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitHasSimpleState:UnitSimpleState")]
	public EBGUSimpleState UnitSimpleState
	{
		get
		{
			CheckDestroyed();
			if (!UnitSimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasSimpleState:UnitSimpleState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, UnitSimpleState_Offset), 0, UnitSimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitSimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasSimpleState:UnitSimpleState");
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
	[USharpPath("/Script/b1-Managed.BAID_CheckUnitHasSimpleState:IsCheckTarget")]
	public bool IsCheckTarget
	{
		get
		{
			CheckDestroyed();
			if (!IsCheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasSimpleState:IsCheckTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCheckTarget_Offset), 0, IsCheckTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCheckTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckUnitHasSimpleState:IsCheckTarget");
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
			if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(aActor, UnitSimpleState))
			{
				return true;
			}
		}
		else if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, UnitSimpleState))
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckUnitHasSimpleState");
		NativeReflection.GetPropertyRef(ref UnitSimpleState_PropertyAddress, unrealStruct, "UnitSimpleState");
		UnitSimpleState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitSimpleState");
		UnitSimpleState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitSimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsCheckTarget_PropertyAddress, unrealStruct, "IsCheckTarget");
		IsCheckTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsCheckTarget");
		IsCheckTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsCheckTarget", Classes.FBoolProperty);
	}

	static BAID_CheckUnitHasSimpleState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckUnitHasSimpleState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckUnitHasSimpleState));
	}
}
