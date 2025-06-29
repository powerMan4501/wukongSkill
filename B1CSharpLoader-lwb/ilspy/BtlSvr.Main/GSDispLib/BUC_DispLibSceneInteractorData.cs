using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibSceneInteractorData")]
public class BUC_DispLibSceneInteractorData : UBGWDataAsset
{
	private static bool ScenePhysicalInteractor_IsValid;

	private static int ScenePhysicalInteractor_Offset;

	private static FFieldAddress ScenePhysicalInteractor_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_ScenePhysicalInteractor> ScenePhysicalInteractor_Marshaler;

	[DisplayName("Scene Physical Interactor")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Scene Physical Interactor")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibSceneInteractorData:ScenePhysicalInteractor")]
	public TArrayReadWrite<BUC_DispLibDBC_ScenePhysicalInteractor> ScenePhysicalInteractor
	{
		get
		{
			CheckDestroyed();
			if (!ScenePhysicalInteractor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibSceneInteractorData:ScenePhysicalInteractor");
				return null;
			}
			if (ScenePhysicalInteractor_Marshaler == null)
			{
				ScenePhysicalInteractor_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_ScenePhysicalInteractor>(1, ScenePhysicalInteractor_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_ScenePhysicalInteractor, BUC_DispLibDBC_ScenePhysicalInteractor>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_ScenePhysicalInteractor, BUC_DispLibDBC_ScenePhysicalInteractor>.ToNative);
			}
			return ScenePhysicalInteractor_Marshaler.FromNative(IntPtr.Add(base.Address, ScenePhysicalInteractor_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_DispLibSceneInteractorData");
		NativeReflection.GetPropertyRef(ref ScenePhysicalInteractor_PropertyAddress, unrealStruct, "ScenePhysicalInteractor");
		ScenePhysicalInteractor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScenePhysicalInteractor");
		ScenePhysicalInteractor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScenePhysicalInteractor", Classes.FArrayProperty);
	}

	static BUC_DispLibSceneInteractorData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibSceneInteractorData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibSceneInteractorData));
	}
}
