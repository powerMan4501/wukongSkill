using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Apply Environment Mask")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSApplyEnvironmentMask")]
internal class BAN_GSApplyEnvironmentMask : BAN_GSBase
{
	private static bool EnvironmentMaskDataList_IsValid;

	private static int EnvironmentMaskDataList_Offset;

	private static FFieldAddress EnvironmentMaskDataList_PropertyAddress;

	private TArrayReadWriteMarshaler<EnvironmentMaskData> EnvironmentMaskDataList_Marshaler;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSApplyEnvironmentMask:EnvironmentMaskDataList")]
	public TArrayReadWrite<EnvironmentMaskData> EnvironmentMaskDataList
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentMaskDataList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSApplyEnvironmentMask:EnvironmentMaskDataList");
				return null;
			}
			if (EnvironmentMaskDataList_Marshaler == null)
			{
				EnvironmentMaskDataList_Marshaler = new TArrayReadWriteMarshaler<EnvironmentMaskData>(1, EnvironmentMaskDataList_PropertyAddress, CachedMarshalingDelegates<EnvironmentMaskData, EnvironmentMaskData>.FromNative, CachedMarshalingDelegates<EnvironmentMaskData, EnvironmentMaskData>.ToNative);
			}
			return EnvironmentMaskDataList_Marshaler.FromNative(IntPtr.Add(base.Address, EnvironmentMaskDataList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSApplyEnvironmentMask:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!owner.IsNullOrDestroyed() && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_ApplyEnvironmentMask.Invoke(EnvironmentMaskDataList.ToList());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSApplyEnvironmentMask:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSApplyEnvironmentMask bAN_GSApplyEnvironmentMask = GCHelper.Find<b1.BAN_GSApplyEnvironmentMask>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSApplyEnvironmentMask.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSApplyEnvironmentMask");
		NativeReflection.GetPropertyRef(ref EnvironmentMaskDataList_PropertyAddress, intPtr, "EnvironmentMaskDataList");
		EnvironmentMaskDataList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnvironmentMaskDataList");
		EnvironmentMaskDataList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnvironmentMaskDataList", Classes.FArrayProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSApplyEnvironmentMask:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSApplyEnvironmentMask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSApplyEnvironmentMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSApplyEnvironmentMask));
	}
}
