using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS CallMultiPointsRegister")]
[USharpPath("/Script/b1-Managed.BANS_GSCallMultiPointsRegister")]
internal class BANS_GSCallMultiPointsRegister : BANS_GSBase
{
	private static bool ReqList_IsValid;

	private static int ReqList_Offset;

	private static FFieldAddress ReqList_PropertyAddress;

	private TArrayReadWriteMarshaler<FPointsRegisterReq> ReqList_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSCallMultiPointsRegister:ReqList")]
	public TArrayReadWrite<FPointsRegisterReq> ReqList
	{
		get
		{
			CheckDestroyed();
			if (!ReqList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallMultiPointsRegister:ReqList");
				return null;
			}
			if (ReqList_Marshaler == null)
			{
				ReqList_Marshaler = new TArrayReadWriteMarshaler<FPointsRegisterReq>(1, ReqList_PropertyAddress, CachedMarshalingDelegates<FPointsRegisterReq, FPointsRegisterReq>.FromNative, CachedMarshalingDelegates<FPointsRegisterReq, FPointsRegisterReq>.ToNative);
			}
			return ReqList_Marshaler.FromNative(IntPtr.Add(base.Address, ReqList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCallMultiPointsRegister:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
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

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCallMultiPointsRegister:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCallMultiPointsRegister bANS_GSCallMultiPointsRegister = GCHelper.Find<b1.BANS_GSCallMultiPointsRegister>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCallMultiPointsRegister.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCallMultiPointsRegister");
		NativeReflection.GetPropertyRef(ref ReqList_PropertyAddress, intPtr, "ReqList");
		ReqList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReqList");
		ReqList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReqList", Classes.FArrayProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCallMultiPointsRegister:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCallMultiPointsRegister()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCallMultiPointsRegister)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCallMultiPointsRegister));
	}
}
