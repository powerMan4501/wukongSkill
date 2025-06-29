using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Apply ScenePhysicalInteractor DataAsset")]
[USharpPath("/Script/b1-Managed.BAN_DispLibApplySceneInteractor")]
public class BAN_DispLibApplySceneInteractor : BAN_GSBase
{
	private static bool DataAsset_IsValid;

	private static int DataAsset_Offset;

	private static bool ConfigInfo_IsValid;

	private static int ConfigInfo_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:DataAsset")]
	public BUC_DispLibSceneInteractorData DataAsset
	{
		get
		{
			CheckDestroyed();
			if (!DataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:DataAsset");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibSceneInteractorData>.FromNative(IntPtr.Add(base.Address, DataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:DataAsset");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibSceneInteractorData>.ToNative(IntPtr.Add(base.Address, DataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:ConfigInfo")]
	public BUC_DispLibDBC_ScenePhysicalInteractor ConfigInfo
	{
		get
		{
			CheckDestroyed();
			if (!ConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:ConfigInfo");
				return default(BUC_DispLibDBC_ScenePhysicalInteractor);
			}
			return BUC_DispLibDBC_ScenePhysicalInteractor.FromNative(IntPtr.Add(base.Address, ConfigInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:ConfigInfo");
			}
			else
			{
				BUC_DispLibDBC_ScenePhysicalInteractor.ToNative(IntPtr.Add(base.Address, ConfigInfo_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	protected virtual bool ValidateParameters(USkeletalMeshComponent MeshComp)
	{
		if (DataAsset == null)
		{
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (ValidateParameters(meshComp))
		{
			BUS_DispLibEventCollection.Get(meshComp.GetOwner())?.Evt_RequestApplyOneScenePhysicalInteractorDataAsset(DataAsset, out var _, meshComp, meshComp.GetSocketLocation(B1GlobalFNames.root));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_DispLibApplySceneInteractor bAN_DispLibApplySceneInteractor = GCHelper.Find<BAN_DispLibApplySceneInteractor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibApplySceneInteractor.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibApplySceneInteractor");
		DataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataAsset");
		DataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataAsset", Classes.FObjectProperty);
		ConfigInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigInfo");
		ConfigInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigInfo", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibApplySceneInteractor:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibApplySceneInteractor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_DispLibApplySceneInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_DispLibApplySceneInteractor));
	}
}
