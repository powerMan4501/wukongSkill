using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Collision Response To Channel")]
[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel")]
internal class BANS_GSCollisionResponseToChannel : BANS_GSBase
{
	private static bool ApplyToCapsule_IsValid;

	private static int ApplyToCapsule_Offset;

	private static FFieldAddress ApplyToCapsule_PropertyAddress;

	private static bool ChannelResponseType_IsValid;

	private static int ChannelResponseType_Offset;

	private static FFieldAddress ChannelResponseType_PropertyAddress;

	private TMapReadWriteMarshaler<ECollisionChannel, ECollisionResponseType> ChannelResponseType_Marshaler;

	private static bool ApplyToMesh_IsValid;

	private static int ApplyToMesh_Offset;

	private static FFieldAddress ApplyToMesh_PropertyAddress;

	private static bool MeshChannelResponseType_IsValid;

	private static int MeshChannelResponseType_Offset;

	private static FFieldAddress MeshChannelResponseType_PropertyAddress;

	private TMapReadWriteMarshaler<ECollisionChannel, ECollisionResponseType> MeshChannelResponseType_Marshaler;

	private static bool bNotReset_IsValid;

	private static int bNotReset_Offset;

	private static FFieldAddress bNotReset_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GetCollisionChannelIndex_Mesh_IsValid;

	private static IntPtr GetCollisionChannelIndex_Mesh_FunctionAddress;

	private static int GetCollisionChannelIndex_Mesh_ParamsSize;

	private static bool GetCollisionChannelIndex_Mesh_ReturnValue_IsValid;

	private static int GetCollisionChannelIndex_Mesh_ReturnValue_Offset;

	private static FFieldAddress GetCollisionChannelIndex_Mesh_ReturnValue_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GetCollisionChannelIndex_Capsule_IsValid;

	private static IntPtr GetCollisionChannelIndex_Capsule_FunctionAddress;

	private static int GetCollisionChannelIndex_Capsule_ParamsSize;

	private static bool GetCollisionChannelIndex_Capsule_ReturnValue_IsValid;

	private static int GetCollisionChannelIndex_Capsule_ReturnValue_Offset;

	private static FFieldAddress GetCollisionChannelIndex_Capsule_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ApplyToCapsule")]
	public bool ApplyToCapsule
	{
		get
		{
			CheckDestroyed();
			if (!ApplyToCapsule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ApplyToCapsule");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyToCapsule_Offset), 0, ApplyToCapsule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyToCapsule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ApplyToCapsule");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyToCapsule_Offset), 0, ApplyToCapsule_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[UMeta(MDProp.EditCondition, "ApplyToCapsule")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ChannelResponseType")]
	public TMapReadWrite<ECollisionChannel, ECollisionResponseType> ChannelResponseType
	{
		get
		{
			CheckDestroyed();
			if (!ChannelResponseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ChannelResponseType");
				return null;
			}
			if (ChannelResponseType_Marshaler == null)
			{
				ChannelResponseType_Marshaler = new TMapReadWriteMarshaler<ECollisionChannel, ECollisionResponseType>(1, ChannelResponseType_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.FromNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.ToNative);
			}
			return ChannelResponseType_Marshaler.FromNative(IntPtr.Add(base.Address, ChannelResponseType_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ApplyToMesh")]
	public bool ApplyToMesh
	{
		get
		{
			CheckDestroyed();
			if (!ApplyToMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ApplyToMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyToMesh_Offset), 0, ApplyToMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyToMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:ApplyToMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyToMesh_Offset), 0, ApplyToMesh_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[UMeta(MDProp.EditCondition, "ApplyToMesh")]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:MeshChannelResponseType")]
	public TMapReadWrite<ECollisionChannel, ECollisionResponseType> MeshChannelResponseType
	{
		get
		{
			CheckDestroyed();
			if (!MeshChannelResponseType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:MeshChannelResponseType");
				return null;
			}
			if (MeshChannelResponseType_Marshaler == null)
			{
				MeshChannelResponseType_Marshaler = new TMapReadWriteMarshaler<ECollisionChannel, ECollisionResponseType>(1, MeshChannelResponseType_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.FromNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.ToNative);
			}
			return MeshChannelResponseType_Marshaler.FromNative(IntPtr.Add(base.Address, MeshChannelResponseType_Offset));
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:bNotReset")]
	public bool bNotReset
	{
		get
		{
			CheckDestroyed();
			if (!bNotReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:bNotReset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNotReset_Offset), 0, bNotReset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNotReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:bNotReset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNotReset_Offset), 0, bNotReset_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		ApplyToCapsule = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World) && !bNotReset)
		{
			uint uniqueID = GetUniqueID();
			BUS_EventCollectionCS.Get(NotifyParam.owner).Evt_ResetProperty.Invoke(0u, uniqueID);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World) && BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(NotifyParam.owner) != null)
		{
			uint uniqueID = GetUniqueID();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
			if (ApplyToCapsule)
			{
				bUS_GSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, ChannelResponseType.ToDictionary(), 0u, uniqueID);
			}
			if (ApplyToMesh)
			{
				bUS_GSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Mesh_CollisionResponseToChannels, MeshChannelResponseType.ToDictionary(), 0u, uniqueID);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GetCollisionChannelIndex_Capsule")]
	public List<int> GetCollisionChannelIndex_Capsule()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item in ChannelResponseType)
		{
			list.Add((int)item.Key);
		}
		return list;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GetCollisionChannelIndex_Mesh")]
	public List<int> GetCollisionChannelIndex_Mesh()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item in MeshChannelResponseType)
		{
			list.Add((int)item.Key);
		}
		return list;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCollisionResponseToChannel bANS_GSCollisionResponseToChannel = GCHelper.Find<b1.BANS_GSCollisionResponseToChannel>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSCollisionResponseToChannel.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GetCollisionChannelIndex_Mesh")]
	private static void GetCollisionChannelIndex_Mesh__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCollisionResponseToChannel bANS_GSCollisionResponseToChannel = GCHelper.Find<b1.BANS_GSCollisionResponseToChannel>(obj);
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, GetCollisionChannelIndex_Mesh_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		List<int> collisionChannelIndex_Mesh = bANS_GSCollisionResponseToChannel.GetCollisionChannelIndex_Mesh();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetCollisionChannelIndex_Mesh_ReturnValue_Offset), collisionChannelIndex_Mesh);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCollisionResponseToChannel bANS_GSCollisionResponseToChannel = GCHelper.Find<b1.BANS_GSCollisionResponseToChannel>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCollisionResponseToChannel.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GetCollisionChannelIndex_Capsule")]
	private static void GetCollisionChannelIndex_Capsule__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCollisionResponseToChannel bANS_GSCollisionResponseToChannel = GCHelper.Find<b1.BANS_GSCollisionResponseToChannel>(obj);
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, GetCollisionChannelIndex_Capsule_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		List<int> collisionChannelIndex_Capsule = bANS_GSCollisionResponseToChannel.GetCollisionChannelIndex_Capsule();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetCollisionChannelIndex_Capsule_ReturnValue_Offset), collisionChannelIndex_Capsule);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCollisionResponseToChannel");
		NativeReflection.GetPropertyRef(ref ApplyToCapsule_PropertyAddress, intPtr, "ApplyToCapsule");
		ApplyToCapsule_Offset = NativeReflection.GetPropertyOffset(intPtr, "ApplyToCapsule");
		ApplyToCapsule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ApplyToCapsule", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ChannelResponseType_PropertyAddress, intPtr, "ChannelResponseType");
		ChannelResponseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChannelResponseType");
		ChannelResponseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChannelResponseType", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref ApplyToMesh_PropertyAddress, intPtr, "ApplyToMesh");
		ApplyToMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "ApplyToMesh");
		ApplyToMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ApplyToMesh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MeshChannelResponseType_PropertyAddress, intPtr, "MeshChannelResponseType");
		MeshChannelResponseType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MeshChannelResponseType");
		MeshChannelResponseType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MeshChannelResponseType", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref bNotReset_PropertyAddress, intPtr, "bNotReset");
		bNotReset_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNotReset");
		bNotReset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNotReset", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GetCollisionChannelIndex_Mesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionChannelIndex_Mesh");
		GetCollisionChannelIndex_Mesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionChannelIndex_Mesh_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCollisionChannelIndex_Mesh_ReturnValue_PropertyAddress, GetCollisionChannelIndex_Mesh_FunctionAddress, "ReturnValue");
		GetCollisionChannelIndex_Mesh_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCollisionChannelIndex_Mesh_FunctionAddress, "ReturnValue");
		GetCollisionChannelIndex_Mesh_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCollisionChannelIndex_Mesh_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCollisionChannelIndex_Mesh_IsValid = GetCollisionChannelIndex_Mesh_FunctionAddress != IntPtr.Zero && GetCollisionChannelIndex_Mesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GetCollisionChannelIndex_Mesh", GetCollisionChannelIndex_Mesh_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GetCollisionChannelIndex_Capsule_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionChannelIndex_Capsule");
		GetCollisionChannelIndex_Capsule_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionChannelIndex_Capsule_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCollisionChannelIndex_Capsule_ReturnValue_PropertyAddress, GetCollisionChannelIndex_Capsule_FunctionAddress, "ReturnValue");
		GetCollisionChannelIndex_Capsule_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCollisionChannelIndex_Capsule_FunctionAddress, "ReturnValue");
		GetCollisionChannelIndex_Capsule_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCollisionChannelIndex_Capsule_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCollisionChannelIndex_Capsule_IsValid = GetCollisionChannelIndex_Capsule_FunctionAddress != IntPtr.Zero && GetCollisionChannelIndex_Capsule_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCollisionResponseToChannel:GetCollisionChannelIndex_Capsule", GetCollisionChannelIndex_Capsule_IsValid);
	}

	static BANS_GSCollisionResponseToChannel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCollisionResponseToChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCollisionResponseToChannel));
	}
}
