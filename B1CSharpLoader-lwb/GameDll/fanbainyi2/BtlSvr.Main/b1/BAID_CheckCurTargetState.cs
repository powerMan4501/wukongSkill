using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetState")]
internal class BAID_CheckCurTargetState : BAID_Base
{
	private static bool UnitStateCheckList_IsValid;

	private static int UnitStateCheckList_Offset;

	private static FFieldAddress UnitStateCheckList_PropertyAddress;

	private TArrayReadWriteMarshaler<EBGUUnitState> UnitStateCheckList_Marshaler;

	private static bool SimpleStateCheckList_IsValid;

	private static int SimpleStateCheckList_Offset;

	private static FFieldAddress SimpleStateCheckList_PropertyAddress;

	private TArrayReadWriteMarshaler<EBGUSimpleState> SimpleStateCheckList_Marshaler;

	private static bool UsePlayerForTarget_IsValid;

	private static int UsePlayerForTarget_Offset;

	private static FFieldAddress UsePlayerForTarget_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetState:UnitStateCheckList")]
	public TArrayReadWrite<EBGUUnitState> UnitStateCheckList
	{
		get
		{
			CheckDestroyed();
			if (!UnitStateCheckList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetState:UnitStateCheckList");
				return null;
			}
			if (UnitStateCheckList_Marshaler == null)
			{
				UnitStateCheckList_Marshaler = new TArrayReadWriteMarshaler<EBGUUnitState>(1, UnitStateCheckList_PropertyAddress, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.FromNative, CachedMarshalingDelegates<EBGUUnitState, EnumMarshaler<EBGUUnitState>>.ToNative);
			}
			return UnitStateCheckList_Marshaler.FromNative(IntPtr.Add(base.Address, UnitStateCheckList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetState:SimpleStateCheckList")]
	public TArrayReadWrite<EBGUSimpleState> SimpleStateCheckList
	{
		get
		{
			CheckDestroyed();
			if (!SimpleStateCheckList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetState:SimpleStateCheckList");
				return null;
			}
			if (SimpleStateCheckList_Marshaler == null)
			{
				SimpleStateCheckList_Marshaler = new TArrayReadWriteMarshaler<EBGUSimpleState>(1, SimpleStateCheckList_PropertyAddress, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.FromNative, CachedMarshalingDelegates<EBGUSimpleState, EnumMarshaler<EBGUSimpleState>>.ToNative);
			}
			return SimpleStateCheckList_Marshaler.FromNative(IntPtr.Add(base.Address, SimpleStateCheckList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("选择最近的玩家作为目标")]
	[Tooltip("选择的玩家是距离最近的玩家")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetState:UsePlayerForTarget")]
	public bool UsePlayerForTarget
	{
		get
		{
			CheckDestroyed();
			if (!UsePlayerForTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetState:UsePlayerForTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePlayerForTarget_Offset), 0, UsePlayerForTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePlayerForTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetState:UsePlayerForTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePlayerForTarget_Offset), 0, UsePlayerForTarget_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		bool result = false;
		if (OwnerActor is BGUCharacterCS bGUCharacterCS)
		{
			AActor aActor = null;
			aActor = ((!UsePlayerForTarget) ? BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS) : BGU_UnrealWorldUtil.GetNearestPlayerActor(bGUCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS)));
			if (aActor != null)
			{
				BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(aActor);
				BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(aActor);
				if (readOnlyData != null)
				{
					foreach (EBGUUnitState unitStateCheck in UnitStateCheckList)
					{
						if (unitStateCheck != EBGUUnitState.EnumMax && readOnlyData.HasState(unitStateCheck))
						{
							result = true;
						}
					}
				}
				if (readOnlyData2 != null)
				{
					foreach (EBGUSimpleState simpleStateCheck in SimpleStateCheckList)
					{
						if (simpleStateCheck != EBGUSimpleState.EnumMax && readOnlyData2.HasSimpleState(simpleStateCheck))
						{
							result = true;
						}
					}
				}
			}
		}
		return result;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCurTargetState");
		NativeReflection.GetPropertyRef(ref UnitStateCheckList_PropertyAddress, unrealStruct, "UnitStateCheckList");
		UnitStateCheckList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitStateCheckList");
		UnitStateCheckList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitStateCheckList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SimpleStateCheckList_PropertyAddress, unrealStruct, "SimpleStateCheckList");
		SimpleStateCheckList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimpleStateCheckList");
		SimpleStateCheckList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimpleStateCheckList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UsePlayerForTarget_PropertyAddress, unrealStruct, "UsePlayerForTarget");
		UsePlayerForTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UsePlayerForTarget");
		UsePlayerForTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UsePlayerForTarget", Classes.FBoolProperty);
	}

	static BAID_CheckCurTargetState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCurTargetState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCurTargetState));
	}
}
