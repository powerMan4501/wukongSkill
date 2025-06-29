using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetType")]
internal class BAID_CheckCurTargetType : BAID_Base
{
	private static bool UnitIDList_IsValid;

	private static int UnitIDList_Offset;

	private static FFieldAddress UnitIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> UnitIDList_Marshaler;

	private static bool UsePlayerForTarget_IsValid;

	private static int UsePlayerForTarget_Offset;

	private static FFieldAddress UsePlayerForTarget_PropertyAddress;

	[DisplayName("UnitID列表")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetType:UnitIDList")]
	public TArrayReadWrite<int> UnitIDList
	{
		get
		{
			CheckDestroyed();
			if (!UnitIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetType:UnitIDList");
				return null;
			}
			if (UnitIDList_Marshaler == null)
			{
				UnitIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, UnitIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return UnitIDList_Marshaler.FromNative(IntPtr.Add(base.Address, UnitIDList_Offset));
		}
	}

	[EditAnywhere]
	[DisplayName("选择最近的玩家作为目标")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("选择的玩家是距离最近的玩家")]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurTargetType:UsePlayerForTarget")]
	public bool UsePlayerForTarget
	{
		get
		{
			CheckDestroyed();
			if (!UsePlayerForTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetType:UsePlayerForTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePlayerForTarget_Offset), 0, UsePlayerForTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePlayerForTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurTargetType:UsePlayerForTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePlayerForTarget_Offset), 0, UsePlayerForTarget_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS bGUCharacterCS)
		{
			AActor aActor = null;
			aActor = ((!UsePlayerForTarget) ? BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS) : BGU_UnrealWorldUtil.GetNearestPlayerActor(bGUCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS)));
			BGUCharacterCS bGUCharacterCS2 = aActor as BGUCharacterCS;
			if (bGUCharacterCS2 != null && UnitIDList.Contains(bGUCharacterCS2.GetResID()))
			{
				return true;
			}
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCurTargetType");
		NativeReflection.GetPropertyRef(ref UnitIDList_PropertyAddress, unrealStruct, "UnitIDList");
		UnitIDList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitIDList");
		UnitIDList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UsePlayerForTarget_PropertyAddress, unrealStruct, "UsePlayerForTarget");
		UsePlayerForTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UsePlayerForTarget");
		UsePlayerForTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UsePlayerForTarget", Classes.FBoolProperty);
	}

	static BAID_CheckCurTargetType()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCurTargetType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCurTargetType));
	}
}
