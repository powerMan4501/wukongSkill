using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN CallMultiPointsRegister")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSCallMultiPointsRegister")]
internal class BAN_GSCallMultiPointsRegister : BAN_GSBase
{
	private static bool ReqList_IsValid;

	private static int ReqList_Offset;

	private static FFieldAddress ReqList_PropertyAddress;

	private TArrayReadWriteMarshaler<FPointsRegisterReq> ReqList_Marshaler;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSCallMultiPointsRegister:ReqList")]
	public TArrayReadWrite<FPointsRegisterReq> ReqList
	{
		get
		{
			CheckDestroyed();
			if (!ReqList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallMultiPointsRegister:ReqList");
				return null;
			}
			if (ReqList_Marshaler == null)
			{
				ReqList_Marshaler = new TArrayReadWriteMarshaler<FPointsRegisterReq>(1, ReqList_PropertyAddress, CachedMarshalingDelegates<FPointsRegisterReq, FPointsRegisterReq>.FromNative, CachedMarshalingDelegates<FPointsRegisterReq, FPointsRegisterReq>.ToNative);
			}
			return ReqList_Marshaler.FromNative(IntPtr.Add(base.Address, ReqList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCallMultiPointsRegister:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		foreach (FPointsRegisterReq req in ReqList)
		{
			bUS_GSEventCollection.Evt_CallPointsRegister.Invoke(req.RegistID, req.GenType, req.ExtParam);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCallMultiPointsRegister:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCallMultiPointsRegister bAN_GSCallMultiPointsRegister = GCHelper.Find<b1.BAN_GSCallMultiPointsRegister>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSCallMultiPointsRegister.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSCallMultiPointsRegister");
		NativeReflection.GetPropertyRef(ref ReqList_PropertyAddress, intPtr, "ReqList");
		ReqList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReqList");
		ReqList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReqList", Classes.FArrayProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCallMultiPointsRegister:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSCallMultiPointsRegister()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSCallMultiPointsRegister)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSCallMultiPointsRegister));
	}
}
