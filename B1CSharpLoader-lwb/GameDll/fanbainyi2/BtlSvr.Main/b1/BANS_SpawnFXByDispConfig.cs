using System;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Spawn FX By DispConfig")]
[USharpPath("/Script/b1-Managed.BANS_SpawnFXByDispConfig")]
internal class BANS_SpawnFXByDispConfig : BANS_GSBase
{
	private int RequestID;

	private static bool DispConfigDA_IsValid;

	private static int DispConfigDA_Offset;

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
	[USharpPath("/Script/b1-Managed.BANS_SpawnFXByDispConfig:DispConfigDA")]
	public BUC_DispLibDispBaseConfigDataAsset DispConfigDA
	{
		get
		{
			CheckDestroyed();
			if (!DispConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SpawnFXByDispConfig:DispConfigDA");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(base.Address, DispConfigDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DispConfigDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SpawnFXByDispConfig:DispConfigDA");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.ToNative(IntPtr.Add(base.Address, DispConfigDA_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_SpawnFXByDispConfig:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_RequestSpawnFXByDispConfig.Invoke(DispConfigDA.GetPathName(), out RequestID);
	}

	[USharpPath("/Script/b1-Managed.BANS_SpawnFXByDispConfig:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_RequestDestroyByFXRequestID.Invoke(RequestID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SpawnFXByDispConfig:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SpawnFXByDispConfig bANS_SpawnFXByDispConfig = GCHelper.Find<b1.BANS_SpawnFXByDispConfig>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_SpawnFXByDispConfig.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SpawnFXByDispConfig:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SpawnFXByDispConfig bANS_SpawnFXByDispConfig = GCHelper.Find<b1.BANS_SpawnFXByDispConfig>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_SpawnFXByDispConfig.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_SpawnFXByDispConfig");
		DispConfigDA_Offset = NativeReflection.GetPropertyOffset(intPtr, "DispConfigDA");
		DispConfigDA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DispConfigDA", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SpawnFXByDispConfig:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SpawnFXByDispConfig:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_SpawnFXByDispConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_SpawnFXByDispConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_SpawnFXByDispConfig));
	}
}
