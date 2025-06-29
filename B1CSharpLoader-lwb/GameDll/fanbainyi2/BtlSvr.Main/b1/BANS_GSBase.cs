using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Blueprintable]
[EditInlineNew]
[Placeable(false)]
[DisplayName("GS Base In CSharp, DO NOT USE!!")]
[USharpPath("/Script/b1-Managed.BANS_GSBase")]
public class BANS_GSBase : UAnimNotifyState_GSBase
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

	private static bool GSNotifyDebugPreEndCS_IsValid;

	private static IntPtr GSNotifyDebugPreEndCS_FunctionAddress;

	private static int GSNotifyDebugPreEndCS_ParamsSize;

	private static bool GSNotifyDebugPreEndCS_NotifyParam_IsValid;

	private static int GSNotifyDebugPreEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyDebugPreEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyDebugPreEndCS_ReturnValue_IsValid;

	private static int GSNotifyDebugPreEndCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPostEndCS_IsValid;

	private static IntPtr GSNotifyDebugPostEndCS_FunctionAddress;

	private static int GSNotifyDebugPostEndCS_ParamsSize;

	private static bool GSNotifyDebugPostEndCS_NotifyParam_IsValid;

	private static int GSNotifyDebugPostEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyDebugPostEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyDebugPostEndCS_ReturnValue_IsValid;

	private static int GSNotifyDebugPostEndCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPreTickCS_IsValid;

	private static IntPtr GSNotifyDebugPreTickCS_FunctionAddress;

	private static int GSNotifyDebugPreTickCS_ParamsSize;

	private static bool GSNotifyDebugPreTickCS_NotifyParam_IsValid;

	private static int GSNotifyDebugPreTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyDebugPreTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyDebugPreTickCS_ReturnValue_IsValid;

	private static int GSNotifyDebugPreTickCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPreBeginCS_IsValid;

	private static IntPtr GSNotifyDebugPreBeginCS_FunctionAddress;

	private static int GSNotifyDebugPreBeginCS_ParamsSize;

	private static bool GSNotifyDebugPreBeginCS_NotifyParam_IsValid;

	private static int GSNotifyDebugPreBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyDebugPreBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyDebugPreBeginCS_ReturnValue_IsValid;

	private static int GSNotifyDebugPreBeginCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPostTickCS_IsValid;

	private static IntPtr GSNotifyDebugPostTickCS_FunctionAddress;

	private static int GSNotifyDebugPostTickCS_ParamsSize;

	private static bool GSNotifyDebugPostTickCS_NotifyParam_IsValid;

	private static int GSNotifyDebugPostTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyDebugPostTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyDebugPostTickCS_ReturnValue_IsValid;

	private static int GSNotifyDebugPostTickCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPostBeginCS_IsValid;

	private static IntPtr GSNotifyDebugPostBeginCS_FunctionAddress;

	private static int GSNotifyDebugPostBeginCS_ParamsSize;

	private static bool GSNotifyDebugPostBeginCS_NotifyParam_IsValid;

	private static int GSNotifyDebugPostBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyDebugPostBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyDebugPostBeginCS_ReturnValue_IsValid;

	private static int GSNotifyDebugPostBeginCS_ReturnValue_Offset;

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreBeginCS")]
	protected override int GSNotifyDebugPreBeginCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostBeginCS")]
	protected override int GSNotifyDebugPostBeginCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreEndCS")]
	protected override int GSNotifyDebugPreEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostEndCS")]
	protected override int GSNotifyDebugPostEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreTickCS")]
	protected override int GSNotifyDebugPreTickCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostTickCS")]
	protected override int GSNotifyDebugPostTickCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		GSValidateInputInCS(actor);
	}

	protected virtual void GSValidateInputInCS(AActor actor)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBase:GetSoftReferences")]
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

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bANS_GSBase.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bANS_GSBase.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreEndCS")]
	private static void GSNotifyDebugPreEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyDebugPreEndCS_NotifyParam_Offset));
		int value = bANS_GSBase.GSNotifyDebugPreEndCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSNotifyDebugPreEndCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostEndCS")]
	private static void GSNotifyDebugPostEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyDebugPostEndCS_NotifyParam_Offset));
		int value = bANS_GSBase.GSNotifyDebugPostEndCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSNotifyDebugPostEndCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreTickCS")]
	private static void GSNotifyDebugPreTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyDebugPreTickCS_NotifyParam_Offset));
		int value = bANS_GSBase.GSNotifyDebugPreTickCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSNotifyDebugPreTickCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreBeginCS")]
	private static void GSNotifyDebugPreBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyDebugPreBeginCS_NotifyParam_Offset));
		int value = bANS_GSBase.GSNotifyDebugPreBeginCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSNotifyDebugPreBeginCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostTickCS")]
	private static void GSNotifyDebugPostTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyDebugPostTickCS_NotifyParam_Offset));
		int value = bANS_GSBase.GSNotifyDebugPostTickCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSNotifyDebugPostTickCS_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostBeginCS")]
	private static void GSNotifyDebugPostBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSBase bANS_GSBase = GCHelper.Find<BANS_GSBase>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyDebugPostBeginCS_NotifyParam_Offset));
		int value = bANS_GSBase.GSNotifyDebugPostBeginCS_Implementation(notifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GSNotifyDebugPostBeginCS_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSBase");
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSValidateInputCS", GSValidateInputCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GetSoftReferences", GetSoftReferences_IsValid);
		GSNotifyDebugPreEndCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyDebugPreEndCS");
		GSNotifyDebugPreEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPreEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyDebugPreEndCS_NotifyParam_PropertyAddress, GSNotifyDebugPreEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPreEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPreEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyDebugPreEndCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPreEndCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreEndCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPreEndCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPreEndCS_IsValid = GSNotifyDebugPreEndCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPreEndCS_NotifyParam_IsValid && GSNotifyDebugPreEndCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreEndCS", GSNotifyDebugPreEndCS_IsValid);
		GSNotifyDebugPostEndCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyDebugPostEndCS");
		GSNotifyDebugPostEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPostEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyDebugPostEndCS_NotifyParam_PropertyAddress, GSNotifyDebugPostEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPostEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPostEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyDebugPostEndCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPostEndCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostEndCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPostEndCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPostEndCS_IsValid = GSNotifyDebugPostEndCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPostEndCS_NotifyParam_IsValid && GSNotifyDebugPostEndCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostEndCS", GSNotifyDebugPostEndCS_IsValid);
		GSNotifyDebugPreTickCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyDebugPreTickCS");
		GSNotifyDebugPreTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPreTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyDebugPreTickCS_NotifyParam_PropertyAddress, GSNotifyDebugPreTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPreTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPreTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyDebugPreTickCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPreTickCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreTickCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPreTickCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPreTickCS_IsValid = GSNotifyDebugPreTickCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPreTickCS_NotifyParam_IsValid && GSNotifyDebugPreTickCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreTickCS", GSNotifyDebugPreTickCS_IsValid);
		GSNotifyDebugPreBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyDebugPreBeginCS");
		GSNotifyDebugPreBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPreBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyDebugPreBeginCS_NotifyParam_PropertyAddress, GSNotifyDebugPreBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPreBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPreBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyDebugPreBeginCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPreBeginCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreBeginCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPreBeginCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPreBeginCS_IsValid = GSNotifyDebugPreBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPreBeginCS_NotifyParam_IsValid && GSNotifyDebugPreBeginCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPreBeginCS", GSNotifyDebugPreBeginCS_IsValid);
		GSNotifyDebugPostTickCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyDebugPostTickCS");
		GSNotifyDebugPostTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPostTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyDebugPostTickCS_NotifyParam_PropertyAddress, GSNotifyDebugPostTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPostTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPostTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyDebugPostTickCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPostTickCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostTickCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPostTickCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPostTickCS_IsValid = GSNotifyDebugPostTickCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPostTickCS_NotifyParam_IsValid && GSNotifyDebugPostTickCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostTickCS", GSNotifyDebugPostTickCS_IsValid);
		GSNotifyDebugPostBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyDebugPostBeginCS");
		GSNotifyDebugPostBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPostBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyDebugPostBeginCS_NotifyParam_PropertyAddress, GSNotifyDebugPostBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPostBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPostBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyDebugPostBeginCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSNotifyDebugPostBeginCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostBeginCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyDebugPostBeginCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPostBeginCS_IsValid = GSNotifyDebugPostBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPostBeginCS_NotifyParam_IsValid && GSNotifyDebugPostBeginCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBase:GSNotifyDebugPostBeginCS", GSNotifyDebugPostBeginCS_IsValid);
	}

	static BANS_GSBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSBase));
	}
}
