using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Close Collision Comp Hit Move")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove")]
internal class BANS_GSCloseCollisionCompHitMove : BANS_GSBase
{
	private static bool CollisionCompNames_IsValid;

	private static int CollisionCompNames_Offset;

	private static FFieldAddress CollisionCompNames_PropertyAddress;

	private TArrayReadWriteMarshaler<string> CollisionCompNames_Marshaler;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:CollisionCompNames")]
	public TArrayReadWrite<string> CollisionCompNames
	{
		get
		{
			CheckDestroyed();
			if (!CollisionCompNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:CollisionCompNames");
				return null;
			}
			if (CollisionCompNames_Marshaler == null)
			{
				CollisionCompNames_Marshaler = new TArrayReadWriteMarshaler<string>(1, CollisionCompNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return CollisionCompNames_Marshaler.FromNative(IntPtr.Add(base.Address, CollisionCompNames_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (!(bUS_GSEventCollection == null))
		{
			uint uniqueID = GetUniqueID();
			bUS_GSEventCollection.Evt_RequestSetEnableHitMoveCollision.Invoke(CollisionCompNames.ToList(), Enable: false, uniqueID);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (!(bUS_GSEventCollection == null))
		{
			uint uniqueID = GetUniqueID();
			bUS_GSEventCollection.Evt_PopRequestSetEnableHitMoveCollision.Invoke(uniqueID);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCloseCollisionCompHitMove bANS_GSCloseCollisionCompHitMove = GCHelper.Find<b1.BANS_GSCloseCollisionCompHitMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSCloseCollisionCompHitMove.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCloseCollisionCompHitMove bANS_GSCloseCollisionCompHitMove = GCHelper.Find<b1.BANS_GSCloseCollisionCompHitMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCloseCollisionCompHitMove.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove");
		NativeReflection.GetPropertyRef(ref CollisionCompNames_PropertyAddress, intPtr, "CollisionCompNames");
		CollisionCompNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "CollisionCompNames");
		CollisionCompNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CollisionCompNames", Classes.FArrayProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCloseCollisionCompHitMove:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCloseCollisionCompHitMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCloseCollisionCompHitMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCloseCollisionCompHitMove));
	}
}
