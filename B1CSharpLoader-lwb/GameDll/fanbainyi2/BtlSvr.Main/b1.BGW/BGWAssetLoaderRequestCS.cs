using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BGWAssetLoaderRequestCS")]
public class BGWAssetLoaderRequestCS : UBGWAssetLoaderRequest
{
	public delegate void LoadCompletedCallback(List<FSoftObjectPath> requests, List<UObject> loaded);

	public int RequestID;

	public TWeakObject<UObject> Owner;

	private LoadCompletedCallback callback;

	private static bool loadedObjHolder_IsValid;

	private static int loadedObjHolder_Offset;

	private static FFieldAddress loadedObjHolder_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> loadedObjHolder_Marshaler;

	private static bool ExecuteCS_IsValid;

	private static IntPtr ExecuteCS_FunctionAddress;

	private static int ExecuteCS_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWAssetLoaderRequestCS:loadedObjHolder")]
	private TArrayReadWrite<UObject> loadedObjHolder
	{
		get
		{
			CheckDestroyed();
			if (!loadedObjHolder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWAssetLoaderRequestCS:loadedObjHolder");
				return null;
			}
			if (loadedObjHolder_Marshaler == null)
			{
				loadedObjHolder_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, loadedObjHolder_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return loadedObjHolder_Marshaler.FromNative(IntPtr.Add(base.Address, loadedObjHolder_Offset));
		}
	}

	public void BindCallback(LoadCompletedCallback callback)
	{
		this.callback = (LoadCompletedCallback)Delegate.Combine(this.callback, callback);
	}

	[USharpPath("/Script/b1-Managed.BGWAssetLoaderRequestCS:ExecuteCS")]
	protected override void ExecuteCS_Implementation()
	{
		if (callback == null)
		{
			return;
		}
		List<FSoftObjectPath> AssetList = new List<FSoftObjectPath>();
		GetRequestedAssets(out AssetList);
		List<UObject> LoadedAssets = new List<UObject>();
		GetLoadedAssets(out LoadedAssets);
		foreach (UObject item in LoadedAssets)
		{
			if (item != null)
			{
				loadedObjHolder.Add(item);
			}
		}
		callback(AssetList, LoadedAssets);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWAssetLoaderRequestCS:ExecuteCS")]
	private static void ExecuteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWAssetLoaderRequestCS bGWAssetLoaderRequestCS = GCHelper.Find<BGWAssetLoaderRequestCS>(obj);
		bGWAssetLoaderRequestCS.ExecuteCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWAssetLoaderRequestCS");
		NativeReflection.GetPropertyRef(ref loadedObjHolder_PropertyAddress, intPtr, "loadedObjHolder");
		loadedObjHolder_Offset = NativeReflection.GetPropertyOffset(intPtr, "loadedObjHolder");
		loadedObjHolder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "loadedObjHolder", Classes.FArrayProperty);
		ExecuteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteCS");
		ExecuteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteCS_FunctionAddress);
		ExecuteCS_IsValid = ExecuteCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWAssetLoaderRequestCS:ExecuteCS", ExecuteCS_IsValid);
	}

	static BGWAssetLoaderRequestCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWAssetLoaderRequestCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWAssetLoaderRequestCS));
	}
}
