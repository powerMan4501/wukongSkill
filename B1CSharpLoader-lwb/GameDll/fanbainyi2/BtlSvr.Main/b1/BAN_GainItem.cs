using System;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("GainItemDisplay")]
[UClass]
[Tooltip("仅UI表演")]
[USharpPath("/Script/b1-Managed.BAN_GainItem")]
internal class BAN_GainItem : BAN_GSBase
{
	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GainItem:ItemId")]
	public int ItemId
	{
		get
		{
			CheckDestroyed();
			if (!ItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GainItem:ItemId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GainItem:ItemId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemId_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GainItem:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(NotifyParam.owner);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_ShowDropMainSpacial(new ItemOne
			{
				Id = ItemId,
				Num = 1
			});
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GainItem:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GainItem bAN_GainItem = GCHelper.Find<b1.BAN_GainItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GainItem.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GainItem");
		ItemId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemId", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GainItem:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GainItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GainItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GainItem));
	}
}
