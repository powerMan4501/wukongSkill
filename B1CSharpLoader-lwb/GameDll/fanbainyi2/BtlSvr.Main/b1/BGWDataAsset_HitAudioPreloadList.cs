using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList")]
public class BGWDataAsset_HitAudioPreloadList : UBGWDataAsset
{
	private static bool ObjMapping_IsValid;

	private static int ObjMapping_Offset;

	private static FFieldAddress ObjMapping_PropertyAddress;

	private TMapReadWriteMarshaler<string, UObject> ObjMapping_Marshaler;

	private static bool UpdateConfig_IsValid;

	private static IntPtr UpdateConfig_FunctionAddress;

	private static int UpdateConfig_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList:ObjMapping")]
	public TMapReadWrite<string, UObject> ObjMapping
	{
		get
		{
			CheckDestroyed();
			if (!ObjMapping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList:ObjMapping");
				return null;
			}
			if (ObjMapping_Marshaler == null)
			{
				ObjMapping_Marshaler = new TMapReadWriteMarshaler<string, UObject>(1, ObjMapping_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return ObjMapping_Marshaler.FromNative(IntPtr.Add(base.Address, ObjMapping_Offset));
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList:UpdateConfig")]
	public void UpdateConfig()
	{
		BGUFuncLibNonRuntime.UpdateHitAudioPreloadList(out var PathList_Exist);
		if (PathList_Exist.Count <= 0)
		{
			return;
		}
		ObjMapping.Clear();
		foreach (string item in PathList_Exist)
		{
			UObject uObject = UObject.LoadObject<UObject>(null, item);
			if (uObject != null)
			{
				ObjMapping[item] = uObject;
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList:UpdateConfig")]
	private static void UpdateConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_HitAudioPreloadList bGWDataAsset_HitAudioPreloadList = GCHelper.Find<BGWDataAsset_HitAudioPreloadList>(obj);
		bGWDataAsset_HitAudioPreloadList.UpdateConfig();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList");
		NativeReflection.GetPropertyRef(ref ObjMapping_PropertyAddress, intPtr, "ObjMapping");
		ObjMapping_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObjMapping");
		ObjMapping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObjMapping", Classes.FMapProperty);
		UpdateConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateConfig");
		UpdateConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateConfig_FunctionAddress);
		UpdateConfig_IsValid = UpdateConfig_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_HitAudioPreloadList:UpdateConfig", UpdateConfig_IsValid);
	}

	static BGWDataAsset_HitAudioPreloadList()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_HitAudioPreloadList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_HitAudioPreloadList));
	}
}
