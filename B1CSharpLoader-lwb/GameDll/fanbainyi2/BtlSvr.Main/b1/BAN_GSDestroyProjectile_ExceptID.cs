using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN DestroyProjectile_ExceptID")]
[USharpPath("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID")]
internal class BAN_GSDestroyProjectile_ExceptID : BAN_GSBase
{
	private static bool ProjetcileIDList_IsValid;

	private static int ProjetcileIDList_Offset;

	private static FFieldAddress ProjetcileIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ProjetcileIDList_Marshaler;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("需要排除抛射物IDList")]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:ProjetcileIDList")]
	public TArrayReadWrite<int> ProjetcileIDList
	{
		get
		{
			CheckDestroyed();
			if (!ProjetcileIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:ProjetcileIDList");
				return null;
			}
			if (ProjetcileIDList_Marshaler == null)
			{
				ProjetcileIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, ProjetcileIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ProjetcileIDList_Marshaler.FromNative(IntPtr.Add(base.Address, ProjetcileIDList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DestroyProjectile_ExceptID.Invoke(ProjetcileIDList.ToList());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSDestroyProjectile_ExceptID bAN_GSDestroyProjectile_ExceptID = GCHelper.Find<b1.BAN_GSDestroyProjectile_ExceptID>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSDestroyProjectile_ExceptID.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSDestroyProjectile_ExceptID bAN_GSDestroyProjectile_ExceptID = GCHelper.Find<b1.BAN_GSDestroyProjectile_ExceptID>(obj);
		bool value = bAN_GSDestroyProjectile_ExceptID.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID");
		NativeReflection.GetPropertyRef(ref ProjetcileIDList_PropertyAddress, intPtr, "ProjetcileIDList");
		ProjetcileIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjetcileIDList");
		ProjetcileIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjetcileIDList", Classes.FArrayProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSDestroyProjectile_ExceptID:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSDestroyProjectile_ExceptID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSDestroyProjectile_ExceptID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSDestroyProjectile_ExceptID));
	}
}
