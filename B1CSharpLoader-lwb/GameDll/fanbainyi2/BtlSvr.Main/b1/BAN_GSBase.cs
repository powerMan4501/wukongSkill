using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Blueprintable]
[EditInlineNew]
[DisplayName("GS Base In CSharp, DO NOT USE!!")]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BAN_GSBase")]
public class BAN_GSBase : UAnimNotify_GSBase
{
	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	private static bool GSPreNotifyDebugCS_IsValid;

	private static IntPtr GSPreNotifyDebugCS_FunctionAddress;

	private static int GSPreNotifyDebugCS_ParamsSize;

	private static bool GSPreNotifyDebugCS_NotifyParam_IsValid;

	private static int GSPreNotifyDebugCS_NotifyParam_Offset;

	private static FFieldAddress GSPreNotifyDebugCS_NotifyParam_PropertyAddress;

	private static bool GSPreNotifyDebugCS_ReturnValue_IsValid;

	private static int GSPreNotifyDebugCS_ReturnValue_Offset;

	private static bool GSPostNotifyDebugCS_IsValid;

	private static IntPtr GSPostNotifyDebugCS_FunctionAddress;

	private static int GSPostNotifyDebugCS_ParamsSize;

	private static bool GSPostNotifyDebugCS_NotifyParam_IsValid;

	private static int GSPostNotifyDebugCS_NotifyParam_Offset;

	private static FFieldAddress GSPostNotifyDebugCS_NotifyParam_PropertyAddress;

	private static bool GSPostNotifyDebugCS_ReturnValue_IsValid;

	private static int GSPostNotifyDebugCS_ReturnValue_Offset;

	[USharpPath("/Script/b1-Managed.BAN_GSBase:GSPreNotifyDebugCS")]
	protected override int GSPreNotifyDebugCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSBase:GSPostNotifyDebugCS")]
	protected override int GSPostNotifyDebugCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSBase:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		GSValidateInputInCS(actor);
	}

	protected virtual void GSValidateInputInCS(AActor actor)
	{
	}

	[USharpPath("/Script/b1-Managed.BAN_GSBase:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		return new List<FSoftObjectPath>();
	}

	protected T SyncLoadSoftPathObjAndAddPreloadedAsset<T>(string Path) where T : UObject
	{
		UObject uObject = null;
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
		uObject = ((!(bGW_PreloadAssetMgr == null)) ? bGW_PreloadAssetMgr.TryGetCachedResourceObj<T>(Path, ELoadResourceType.SyncLoadAndCache) : BGW_PreloadAssetMgr.RequestSyncLoadObjectInEditor<T>(Path));
		if (uObject != null)
		{
			AddPreloadedAsset(uObject);
		}
		return (T)uObject;
	}

	protected T GetValidResource<T>(TSoftObject<T> TemplateResource, bool ForceLoad = false) where T : UObject
	{
		bool flag = true;
		T val = null;
		if (!TemplateResource.IsNull)
		{
			val = TemplateResource.Value;
			if (val == null && (ForceLoad || flag || !base.isPreload))
			{
				val = SyncLoadSoftPathObjAndAddPreloadedAsset<T>(TemplateResource.Path);
			}
		}
		return val;
	}

	public virtual void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSBase:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSBase bAN_GSBase = GCHelper.Find<BAN_GSBase>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bAN_GSBase.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSBase:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSBase bAN_GSBase = GCHelper.Find<BAN_GSBase>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_GSBase.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSBase:GSPreNotifyDebugCS")]
	private static void GSPreNotifyDebugCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSBase bAN_GSBase = GCHelper.Find<BAN_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSPreNotifyDebugCS_NotifyParam_Offset));
		int value = bAN_GSBase.GSPreNotifyDebugCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSPreNotifyDebugCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSBase:GSPostNotifyDebugCS")]
	private static void GSPostNotifyDebugCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSBase bAN_GSBase = GCHelper.Find<BAN_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSPostNotifyDebugCS_NotifyParam_Offset));
		int value = bAN_GSBase.GSPostNotifyDebugCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSPostNotifyDebugCS_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSBase");
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSBase:GSValidateInputCS", GSValidateInputCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSBase:GetSoftReferences", GetSoftReferences_IsValid);
		GSPreNotifyDebugCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSPreNotifyDebugCS");
		GSPreNotifyDebugCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSPreNotifyDebugCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSPreNotifyDebugCS_NotifyParam_PropertyAddress, GSPreNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPreNotifyDebugCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSPreNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPreNotifyDebugCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSPreNotifyDebugCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSPreNotifyDebugCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSPreNotifyDebugCS_FunctionAddress, "ReturnValue");
		GSPreNotifyDebugCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSPreNotifyDebugCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSPreNotifyDebugCS_IsValid = GSPreNotifyDebugCS_FunctionAddress != IntPtr.Zero && GSPreNotifyDebugCS_NotifyParam_IsValid && GSPreNotifyDebugCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSBase:GSPreNotifyDebugCS", GSPreNotifyDebugCS_IsValid);
		GSPostNotifyDebugCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSPostNotifyDebugCS");
		GSPostNotifyDebugCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSPostNotifyDebugCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSPostNotifyDebugCS_NotifyParam_PropertyAddress, GSPostNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPostNotifyDebugCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSPostNotifyDebugCS_FunctionAddress, "NotifyParam");
		GSPostNotifyDebugCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSPostNotifyDebugCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSPostNotifyDebugCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSPostNotifyDebugCS_FunctionAddress, "ReturnValue");
		GSPostNotifyDebugCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSPostNotifyDebugCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSPostNotifyDebugCS_IsValid = GSPostNotifyDebugCS_FunctionAddress != IntPtr.Zero && GSPostNotifyDebugCS_NotifyParam_IsValid && GSPostNotifyDebugCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSBase:GSPostNotifyDebugCS", GSPostNotifyDebugCS_IsValid);
	}

	static BAN_GSBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSBase));
	}
}
