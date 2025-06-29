using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Change AimOffset")]
[USharpPath("/Script/b1-Managed.BANS_ChangeAimOffset")]
internal class BANS_ChangeAimOffset : BANS_GSBase
{
	private static bool bIsDefaultAO_IsValid;

	private static int bIsDefaultAO_Offset;

	private static FFieldAddress bIsDefaultAO_PropertyAddress;

	private static bool AimOffset_IsValid;

	private static int AimOffset_Offset;

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
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("是替换默认AO还是攻击AO")]
	[USharpPath("/Script/b1-Managed.BANS_ChangeAimOffset:bIsDefaultAO")]
	public bool bIsDefaultAO
	{
		get
		{
			CheckDestroyed();
			if (!bIsDefaultAO_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ChangeAimOffset:bIsDefaultAO");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsDefaultAO_Offset), 0, bIsDefaultAO_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsDefaultAO_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ChangeAimOffset:bIsDefaultAO");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsDefaultAO_Offset), 0, bIsDefaultAO_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_ChangeAimOffset:AimOffset")]
	public UAimOffsetBlendSpace AimOffset
	{
		get
		{
			CheckDestroyed();
			if (!AimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ChangeAimOffset:AimOffset");
				return null;
			}
			return UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(base.Address, AimOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_ChangeAimOffset:AimOffset");
			}
			else
			{
				UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(base.Address, AimOffset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_ChangeAimOffset:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ChangeAimOffset.Invoke(bIsDefaultAO, AimOffset);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_ChangeAimOffset:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ResetAimOffset.Invoke(bIsDefaultAO);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_ChangeAimOffset:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_ChangeAimOffset bANS_ChangeAimOffset = GCHelper.Find<b1.BANS_ChangeAimOffset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_ChangeAimOffset.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_ChangeAimOffset:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_ChangeAimOffset bANS_ChangeAimOffset = GCHelper.Find<b1.BANS_ChangeAimOffset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_ChangeAimOffset.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_ChangeAimOffset");
		NativeReflection.GetPropertyRef(ref bIsDefaultAO_PropertyAddress, intPtr, "bIsDefaultAO");
		bIsDefaultAO_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsDefaultAO");
		bIsDefaultAO_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsDefaultAO", Classes.FBoolProperty);
		AimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimOffset");
		AimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimOffset", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_ChangeAimOffset:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_ChangeAimOffset:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_ChangeAimOffset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_ChangeAimOffset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_ChangeAimOffset));
	}
}
