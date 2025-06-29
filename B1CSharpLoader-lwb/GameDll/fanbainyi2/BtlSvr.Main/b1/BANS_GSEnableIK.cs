using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Enable IK")]
[USharpPath("/Script/b1-Managed.BANS_GSEnableIK")]
internal class BANS_GSEnableIK : BANS_GSBase
{
	private static bool bEnableIK_IsValid;

	private static int bEnableIK_Offset;

	private static FFieldAddress bEnableIK_PropertyAddress;

	private static bool bEnableForefootIK_IsValid;

	private static int bEnableForefootIK_Offset;

	private static FFieldAddress bEnableForefootIK_PropertyAddress;

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

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSEnableIK:bEnableIK")]
	private bool bEnableIK
	{
		get
		{
			CheckDestroyed();
			if (!bEnableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableIK:bEnableIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableIK:bEnableIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableIK_Offset), 0, bEnableIK_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSEnableIK:bEnableForefootIK")]
	private bool bEnableForefootIK
	{
		get
		{
			CheckDestroyed();
			if (!bEnableForefootIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableIK:bEnableForefootIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableForefootIK_Offset), 0, bEnableForefootIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableForefootIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableIK:bEnableForefootIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableForefootIK_Offset), 0, bEnableForefootIK_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSEnableIK:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!(NotifyParam.owner as BGUCharacterCS == null))
		{
			BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, bEnableIK, bEnableForefootIK, 0u, GetUniqueID());
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSEnableIK:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!(NotifyParam.owner as BGUCharacterCS == null))
		{
			BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_ResetProperty.Invoke(0u, GetUniqueID());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSEnableIK:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSEnableIK bANS_GSEnableIK = GCHelper.Find<b1.BANS_GSEnableIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSEnableIK.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSEnableIK:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSEnableIK bANS_GSEnableIK = GCHelper.Find<b1.BANS_GSEnableIK>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSEnableIK.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSEnableIK");
		NativeReflection.GetPropertyRef(ref bEnableIK_PropertyAddress, intPtr, "bEnableIK");
		bEnableIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableIK");
		bEnableIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableForefootIK_PropertyAddress, intPtr, "bEnableForefootIK");
		bEnableForefootIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableForefootIK");
		bEnableForefootIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableForefootIK", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSEnableIK:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSEnableIK:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSEnableIK()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSEnableIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSEnableIK));
	}
}
