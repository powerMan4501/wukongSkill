using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Set Cloud Move Enabled")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled")]
public class BANS_GSSetCloudMoveEnabled : BANS_GSBase
{
	private static bool bIsEnabled_IsValid;

	private static int bIsEnabled_Offset;

	private static FFieldAddress bIsEnabled_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled:bIsEnabled")]
	public bool bIsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!bIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled:bIsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsEnabled_Offset), 0, bIsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled:bIsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsEnabled_Offset), 0, bIsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(NotifyParam.owner.World))
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_SetCloudMoveEnabled.Invoke(bIsEnabled);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSetCloudMoveEnabled bANS_GSSetCloudMoveEnabled = GCHelper.Find<BANS_GSSetCloudMoveEnabled>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetCloudMoveEnabled.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled");
		NativeReflection.GetPropertyRef(ref bIsEnabled_PropertyAddress, intPtr, "bIsEnabled");
		bIsEnabled_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsEnabled");
		bIsEnabled_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsEnabled", Classes.FBoolProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCloudMoveEnabled:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetCloudMoveEnabled()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSSetCloudMoveEnabled)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSSetCloudMoveEnabled));
	}
}
