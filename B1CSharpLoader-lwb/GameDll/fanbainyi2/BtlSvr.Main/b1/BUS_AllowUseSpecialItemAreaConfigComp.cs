using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AllowUseSpecialItemAreaConfigComp")]
public class BUS_AllowUseSpecialItemAreaConfigComp : UActorEditCompBase
{
	private static bool AllowUseSpecialItemID_IsValid;

	private static int AllowUseSpecialItemID_Offset;

	private static FFieldAddress AllowUseSpecialItemID_PropertyAddress;

	private TArrayReadWriteMarshaler<int> AllowUseSpecialItemID_Marshaler;

	[DisplayName("允许使用的特殊ItemID")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AllowUseSpecialItem config")]
	[USharpPath("/Script/b1-Managed.BUS_AllowUseSpecialItemAreaConfigComp:AllowUseSpecialItemID")]
	public TArrayReadWrite<int> AllowUseSpecialItemID
	{
		get
		{
			CheckDestroyed();
			if (!AllowUseSpecialItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AllowUseSpecialItemAreaConfigComp:AllowUseSpecialItemID");
				return null;
			}
			if (AllowUseSpecialItemID_Marshaler == null)
			{
				AllowUseSpecialItemID_Marshaler = new TArrayReadWriteMarshaler<int>(1, AllowUseSpecialItemID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AllowUseSpecialItemID_Marshaler.FromNative(IntPtr.Add(base.Address, AllowUseSpecialItemID_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_AllowUseSpecialItemAreaData bUC_AllowUseSpecialItemAreaData = RequireWritableData<b1.BUC_AllowUseSpecialItemAreaData>();
		foreach (int item in AllowUseSpecialItemID)
		{
			bUC_AllowUseSpecialItemAreaData.AllowUseSpecialItemMap.Add(item, value: true);
		}
		foreach (int item2 in AllowUseSpecialItemID)
		{
			bUC_AllowUseSpecialItemAreaData.AllowUseSpecialItemRemoveMap.Add(item2, value: false);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AllowUseSpecialItemAreaConfigComp");
		NativeReflection.GetPropertyRef(ref AllowUseSpecialItemID_PropertyAddress, unrealStruct, "AllowUseSpecialItemID");
		AllowUseSpecialItemID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AllowUseSpecialItemID");
		AllowUseSpecialItemID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AllowUseSpecialItemID", Classes.FArrayProperty);
	}

	static BUS_AllowUseSpecialItemAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AllowUseSpecialItemAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AllowUseSpecialItemAreaConfigComp));
	}
}
