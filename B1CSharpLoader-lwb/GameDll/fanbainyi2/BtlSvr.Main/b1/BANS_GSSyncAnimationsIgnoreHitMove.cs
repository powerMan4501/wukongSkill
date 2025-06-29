using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Sync Animations Ignore Hit Move")]
[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove")]
internal class BANS_GSSyncAnimationsIgnoreHitMove : BANS_GSBase
{
	private BGUCharacterCS GuestChar;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	public override void Initialize(FObjectInitializer initializer)
	{
		GuestChar = null;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			IgnoreHitMoveIfHasGuestChar(NotifyParam);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World) && !(GuestChar != null))
		{
			IgnoreHitMoveIfHasGuestChar(NotifyParam);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (bGUCharacterCS != null && !GuestChar.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetHitMoveIgnoreActor.Invoke(GuestChar, NeedIgnore: false);
				BUS_EventCollectionCS.Get(GuestChar)?.Evt_SetHitMoveIgnoreActor.Invoke(bGUCharacterCS, NeedIgnore: false);
			}
		}
	}

	private void IgnoreHitMoveIfHasGuestChar(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		IBUC_MontageSectionCtrlData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MontageSectionCtrlData, BUC_MontageSectionCtrlData>(bGUCharacterCS);
		if (unPersistentReadOnlyData != null)
		{
			GuestChar = unPersistentReadOnlyData.TargetChar;
			if (!GuestChar.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetHitMoveIgnoreActor.Invoke(GuestChar, NeedIgnore: true);
				BUS_EventCollectionCS.Get(GuestChar)?.Evt_SetHitMoveIgnoreActor.Invoke(bGUCharacterCS, NeedIgnore: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimationsIgnoreHitMove bANS_GSSyncAnimationsIgnoreHitMove = GCHelper.Find<b1.BANS_GSSyncAnimationsIgnoreHitMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSyncAnimationsIgnoreHitMove.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimationsIgnoreHitMove bANS_GSSyncAnimationsIgnoreHitMove = GCHelper.Find<b1.BANS_GSSyncAnimationsIgnoreHitMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSSyncAnimationsIgnoreHitMove.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSyncAnimationsIgnoreHitMove bANS_GSSyncAnimationsIgnoreHitMove = GCHelper.Find<b1.BANS_GSSyncAnimationsIgnoreHitMove>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSyncAnimationsIgnoreHitMove.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove");
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSyncAnimationsIgnoreHitMove:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSyncAnimationsIgnoreHitMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSyncAnimationsIgnoreHitMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSyncAnimationsIgnoreHitMove));
	}
}
