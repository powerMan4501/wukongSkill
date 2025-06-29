using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSSetCachePoint")]
internal class BAN_GSSetCachePoint : BAN_GSBase
{
	private static bool Forward_IsValid;

	private static int Forward_Offset;

	private static bool TempDataID_IsValid;

	private static int TempDataID_Offset;

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
	[Tooltip("缓存正前方N米的点")]
	[Category("SetCachePoint")]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCachePoint:Forward")]
	public int Forward
	{
		get
		{
			CheckDestroyed();
			if (!Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCachePoint:Forward");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Forward_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Forward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCachePoint:Forward");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Forward_Offset), value);
			}
		}
	}

	[Category("SetCachePoint")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("缓存ID")]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCachePoint:TempDataID")]
	public int TempDataID
	{
		get
		{
			CheckDestroyed();
			if (!TempDataID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCachePoint:TempDataID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TempDataID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TempDataID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCachePoint:TempDataID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TempDataID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSetCachePoint:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSetCachePoint:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!(NotifyParam.owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
			if (!(bUS_GSEventCollection == null))
			{
				FVector actorForwardVector = NotifyParam.owner.GetActorForwardVector();
				actorForwardVector.Normalize();
				FVector item = BGUFuncLibActorTransformCS.BGUGetActorLocation(NotifyParam.owner) + Forward * actorForwardVector;
				List<FVector> list = new List<FVector>();
				list.Add(item);
				bUS_GSEventCollection.Evt_AddPointsToQuene.Invoke(TempDataID, list, bClearTheReqQuene: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSetCachePoint:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSetCachePoint bAN_GSSetCachePoint = GCHelper.Find<b1.BAN_GSSetCachePoint>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSetCachePoint.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSetCachePoint:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSetCachePoint bAN_GSSetCachePoint = GCHelper.Find<b1.BAN_GSSetCachePoint>(obj);
		bool value = bAN_GSSetCachePoint.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSetCachePoint");
		Forward_Offset = NativeReflection.GetPropertyOffset(intPtr, "Forward");
		Forward_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Forward", Classes.FIntProperty);
		TempDataID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TempDataID");
		TempDataID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TempDataID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSetCachePoint:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSetCachePoint:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSSetCachePoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSSetCachePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSSetCachePoint));
	}
}
