using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Show CommTips")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_ShowCommTips")]
internal class BAN_ShowCommTips : BAN_GSBase
{
	private static bool UIWordId_IsValid;

	private static int UIWordId_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Settings")]
	[USharpPath("/Script/b1-Managed.BAN_ShowCommTips:UIWordId")]
	public int UIWordId
	{
		get
		{
			CheckDestroyed();
			if (!UIWordId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_ShowCommTips:UIWordId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UIWordId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UIWordId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_ShowCommTips:UIWordId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UIWordId_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_ShowCommTips:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(NotifyParam.owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_UICommTips(UIWordId);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_ShowCommTips:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_ShowCommTips bAN_ShowCommTips = GCHelper.Find<b1.BAN_ShowCommTips>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_ShowCommTips.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_ShowCommTips");
		UIWordId_Offset = NativeReflection.GetPropertyOffset(intPtr, "UIWordId");
		UIWordId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UIWordId", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_ShowCommTips:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_ShowCommTips()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_ShowCommTips)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_ShowCommTips));
	}
}
