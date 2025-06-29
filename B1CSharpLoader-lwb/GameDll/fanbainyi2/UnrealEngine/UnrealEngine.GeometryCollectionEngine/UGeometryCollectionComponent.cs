using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.ChaosSolverEngine;
using UnrealEngine.Engine;
using UnrealEngine.FieldSystemEngine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public class UGeometryCollectionComponent : UMeshComponent, IChaosNotifyHandlerInterface, IInterface
{
	[UDelegate]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange__DelegateSignature")]
	public class FNotifyGeometryCollectionPhysicsStateChange : FMulticastDelegate<FNotifyGeometryCollectionPhysicsStateChange.Signature>
	{
		public delegate void Signature(UGeometryCollectionComponent FracturedComponent);

		private static bool NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_IsValid;

		private static IntPtr NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress;

		private static int NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_ParamsSize;

		private static bool NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_IsValid;

		private static FFieldAddress NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_PropertyAddress;

		private static int NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FNotifyGeometryCollectionPhysicsStateChange()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange__DelegateSignature");
			NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_PropertyAddress, NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress, "FracturedComponent");
			NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_Offset = NativeReflectionCached.GetPropertyOffset(NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress, "FracturedComponent");
			NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress, "FracturedComponent", Classes.FObjectProperty);
			NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_IsValid = NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FunctionAddress != IntPtr.Zero && NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange__DelegateSignature", NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UGeometryCollectionComponent FracturedComponent)
		{
			if (!NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UGeometryCollectionComponent>.ToNative(IntPtr.Add(intPtr, NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_Offset), 0, NotifyGeometryCollectionPhysicsStateChange__DelegateSignature_FracturedComponent_PropertyAddress.Address, FracturedComponent);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature")]
	public class FNotifyGeometryCollectionPhysicsLoadingStateChange : FMulticastDelegate<FNotifyGeometryCollectionPhysicsLoadingStateChange.Signature>
	{
		public delegate void Signature(UGeometryCollectionComponent FracturedComponent);

		private static bool NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_IsValid;

		private static IntPtr NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress;

		private static int NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_ParamsSize;

		private static bool NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_IsValid;

		private static FFieldAddress NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_PropertyAddress;

		private static int NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FNotifyGeometryCollectionPhysicsLoadingStateChange()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature");
			NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_PropertyAddress, NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress, "FracturedComponent");
			NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_Offset = NativeReflectionCached.GetPropertyOffset(NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress, "FracturedComponent");
			NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress, "FracturedComponent", Classes.FObjectProperty);
			NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_IsValid = NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FunctionAddress != IntPtr.Zero && NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature", NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UGeometryCollectionComponent FracturedComponent)
		{
			if (!NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UGeometryCollectionComponent>.ToNative(IntPtr.Add(intPtr, NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_Offset), 0, NotifyGeometryCollectionPhysicsLoadingStateChange__DelegateSignature_FracturedComponent_PropertyAddress.Address, FracturedComponent);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool RestCollection_IsValid;

	private static int RestCollection_Offset;

	private static bool InitializationFields_IsValid;

	private static FFieldAddress InitializationFields_PropertyAddress;

	private static int InitializationFields_Offset;

	private TArrayReadWriteMarshaler<AFieldSystemActor> InitializationFields_MarshalerCached;

	private static bool ObjectType_IsValid;

	private static FFieldAddress ObjectType_PropertyAddress;

	private static int ObjectType_Offset;

	private static bool ForceMotionBlur_IsValid;

	private static FFieldAddress ForceMotionBlur_PropertyAddress;

	private static int ForceMotionBlur_Offset;

	private static bool EnableClustering_IsValid;

	private static FFieldAddress EnableClustering_PropertyAddress;

	private static int EnableClustering_Offset;

	private static bool ClusterGroupIndex_IsValid;

	private static int ClusterGroupIndex_Offset;

	private static bool MaxClusterLevel_IsValid;

	private static int MaxClusterLevel_Offset;

	private static bool DamageThreshold_IsValid;

	private static FFieldAddress DamageThreshold_PropertyAddress;

	private static int DamageThreshold_Offset;

	private TArrayReadWriteMarshaler<float> DamageThreshold_MarshalerCached;

	private static bool UseSizeSpecificDamageThreshold_IsValid;

	private static FFieldAddress UseSizeSpecificDamageThreshold_PropertyAddress;

	private static int UseSizeSpecificDamageThreshold_Offset;

	private static bool CollisionGroup_IsValid;

	private static int CollisionGroup_Offset;

	private static bool CollisionSampleFraction_IsValid;

	private static int CollisionSampleFraction_Offset;

	private static bool InitialVelocityType_IsValid;

	private static FFieldAddress InitialVelocityType_PropertyAddress;

	private static int InitialVelocityType_Offset;

	private static bool InitialLinearVelocity_IsValid;

	private static int InitialLinearVelocity_Offset;

	private static bool InitialAngularVelocity_IsValid;

	private static int InitialAngularVelocity_Offset;

	private static bool NotifyGeometryCollectionPhysicsStateChange_IsValid;

	private static int NotifyGeometryCollectionPhysicsStateChange_Offset;

	private FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange_DelegateCached;

	private static bool NotifyGeometryCollectionPhysicsLoadingStateChange_IsValid;

	private static int NotifyGeometryCollectionPhysicsLoadingStateChange_Offset;

	private FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange_DelegateCached;

	private static bool OnChaosBreakEvent_IsValid;

	private static int OnChaosBreakEvent_Offset;

	private FOnChaosBreakEvent OnChaosBreakEvent_DelegateCached;

	private static bool OnChaosRemovalEvent_IsValid;

	private static int OnChaosRemovalEvent_Offset;

	private FOnChaosRemovalEvent OnChaosRemovalEvent_DelegateCached;

	private static bool DesiredCacheTime_IsValid;

	private static int DesiredCacheTime_Offset;

	private static bool CachePlayback_IsValid;

	private static FFieldAddress CachePlayback_PropertyAddress;

	private static int CachePlayback_Offset;

	private static bool OnChaosPhysicsCollision_IsValid;

	private static int OnChaosPhysicsCollision_Offset;

	private FOnChaosPhysicsCollision OnChaosPhysicsCollision_DelegateCached;

	private static bool NotifyBreaks_IsValid;

	private static FFieldAddress NotifyBreaks_PropertyAddress;

	private static int NotifyBreaks_Offset;

	private static bool NotifyCollisions_IsValid;

	private static FFieldAddress NotifyCollisions_PropertyAddress;

	private static int NotifyCollisions_Offset;

	private static bool NotifyTrailing_IsValid;

	private static FFieldAddress NotifyTrailing_PropertyAddress;

	private static int NotifyTrailing_Offset;

	private static bool NotifyRemovals_IsValid;

	private static FFieldAddress NotifyRemovals_PropertyAddress;

	private static int NotifyRemovals_Offset;

	private static bool StoreVelocities_IsValid;

	private static FFieldAddress StoreVelocities_PropertyAddress;

	private static int StoreVelocities_Offset;

	private static bool ShowBoneColors_IsValid;

	private static FFieldAddress ShowBoneColors_PropertyAddress;

	private static int ShowBoneColors_Offset;

	private static bool EnableReplication_IsValid;

	private static FFieldAddress EnableReplication_PropertyAddress;

	private static int EnableReplication_Offset;

	private static bool EnableAbandonAfterLevel_IsValid;

	private static FFieldAddress EnableAbandonAfterLevel_PropertyAddress;

	private static int EnableAbandonAfterLevel_Offset;

	private static bool ReplicationAbandonClusterLevel_IsValid;

	private static int ReplicationAbandonClusterLevel_Offset;

	private static bool SetNotifyRemovals_IsValid;

	private static IntPtr SetNotifyRemovals_FunctionAddress;

	private static int SetNotifyRemovals_ParamsSize;

	private static bool SetNotifyRemovals_bNewNotifyRemovals_IsValid;

	private static FFieldAddress SetNotifyRemovals_bNewNotifyRemovals_PropertyAddress;

	private static int SetNotifyRemovals_bNewNotifyRemovals_Offset;

	private static bool SetNotifyBreaks_IsValid;

	private static IntPtr SetNotifyBreaks_FunctionAddress;

	private static int SetNotifyBreaks_ParamsSize;

	private static bool SetNotifyBreaks_bNewNotifyBreaks_IsValid;

	private static FFieldAddress SetNotifyBreaks_bNewNotifyBreaks_PropertyAddress;

	private static int SetNotifyBreaks_bNewNotifyBreaks_Offset;

	private static bool ReceivePhysicsCollision_IsValid;

	private IntPtr ReceivePhysicsCollision_InstanceFunctionAddress;

	private static IntPtr ReceivePhysicsCollision_FunctionAddress;

	private static int ReceivePhysicsCollision_ParamsSize;

	private static bool ReceivePhysicsCollision_CollisionInfo_IsValid;

	private static FFieldAddress ReceivePhysicsCollision_CollisionInfo_PropertyAddress;

	private static int ReceivePhysicsCollision_CollisionInfo_Offset;

	private static bool ApplyPhysicsField_IsValid;

	private static IntPtr ApplyPhysicsField_FunctionAddress;

	private static int ApplyPhysicsField_ParamsSize;

	private static bool ApplyPhysicsField_Enabled_IsValid;

	private static FFieldAddress ApplyPhysicsField_Enabled_PropertyAddress;

	private static int ApplyPhysicsField_Enabled_Offset;

	private static bool ApplyPhysicsField_Target_IsValid;

	private static FFieldAddress ApplyPhysicsField_Target_PropertyAddress;

	private static int ApplyPhysicsField_Target_Offset;

	private static bool ApplyPhysicsField_MetaData_IsValid;

	private static FFieldAddress ApplyPhysicsField_MetaData_PropertyAddress;

	private static int ApplyPhysicsField_MetaData_Offset;

	private static bool ApplyPhysicsField_Field_IsValid;

	private static FFieldAddress ApplyPhysicsField_Field_PropertyAddress;

	private static int ApplyPhysicsField_Field_Offset;

	private static bool ApplyKinematicField_IsValid;

	private static IntPtr ApplyKinematicField_FunctionAddress;

	private static int ApplyKinematicField_ParamsSize;

	private static bool ApplyKinematicField_Radius_IsValid;

	private static FFieldAddress ApplyKinematicField_Radius_PropertyAddress;

	private static int ApplyKinematicField_Radius_Offset;

	private static bool ApplyKinematicField_Position_IsValid;

	private static FFieldAddress ApplyKinematicField_Position_PropertyAddress;

	private static int ApplyKinematicField_Position_Offset;

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:RestCollection")]
	public UGeometryCollection RestCollection
	{
		get
		{
			CheckDestroyed();
			if (!RestCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:RestCollection");
				return null;
			}
			return UObjectMarshaler<UGeometryCollection>.FromNative(IntPtr.Add(base.Address, RestCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RestCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:RestCollection");
			}
			else
			{
				UObjectMarshaler<UGeometryCollection>.ToNative(IntPtr.Add(base.Address, RestCollection_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499567768069uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitializationFields")]
	public TArrayReadWrite<AFieldSystemActor> InitializationFields
	{
		get
		{
			CheckDestroyed();
			if (!InitializationFields_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitializationFields");
				return null;
			}
			if (InitializationFields_MarshalerCached == null)
			{
				InitializationFields_MarshalerCached = new TArrayReadWriteMarshaler<AFieldSystemActor>(1, InitializationFields_PropertyAddress, CachedMarshalingDelegates<AFieldSystemActor, UObjectMarshaler<AFieldSystemActor>>.FromNative, CachedMarshalingDelegates<AFieldSystemActor, UObjectMarshaler<AFieldSystemActor>>.ToNative);
			}
			return InitializationFields_MarshalerCached.FromNative(IntPtr.Add(base.Address, InitializationFields_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ObjectType")]
	public EObjectStateTypeEnum ObjectType
	{
		get
		{
			CheckDestroyed();
			if (!ObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ObjectType");
				return EObjectStateTypeEnum.Chaos_NONE;
			}
			return EnumMarshaler<EObjectStateTypeEnum>.FromNative(IntPtr.Add(base.Address, ObjectType_Offset), 0, ObjectType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ObjectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ObjectType");
			}
			else
			{
				EnumMarshaler<EObjectStateTypeEnum>.ToNative(IntPtr.Add(base.Address, ObjectType_Offset), 0, ObjectType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bForceMotionBlur")]
	public bool ForceMotionBlur
	{
		get
		{
			CheckDestroyed();
			if (!ForceMotionBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bForceMotionBlur");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceMotionBlur_Offset), 0, ForceMotionBlur_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceMotionBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bForceMotionBlur");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceMotionBlur_Offset), 0, ForceMotionBlur_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:EnableClustering")]
	public bool EnableClustering
	{
		get
		{
			CheckDestroyed();
			if (!EnableClustering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:EnableClustering");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableClustering_Offset), 0, EnableClustering_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableClustering_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:EnableClustering");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableClustering_Offset), 0, EnableClustering_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ClusterGroupIndex")]
	public int ClusterGroupIndex
	{
		get
		{
			CheckDestroyed();
			if (!ClusterGroupIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ClusterGroupIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ClusterGroupIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClusterGroupIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ClusterGroupIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ClusterGroupIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:MaxClusterLevel")]
	public int MaxClusterLevel
	{
		get
		{
			CheckDestroyed();
			if (!MaxClusterLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:MaxClusterLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxClusterLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxClusterLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:MaxClusterLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxClusterLevel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:DamageThreshold")]
	public TArrayReadWrite<float> DamageThreshold
	{
		get
		{
			CheckDestroyed();
			if (!DamageThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:DamageThreshold");
				return null;
			}
			if (DamageThreshold_MarshalerCached == null)
			{
				DamageThreshold_MarshalerCached = new TArrayReadWriteMarshaler<float>(1, DamageThreshold_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return DamageThreshold_MarshalerCached.FromNative(IntPtr.Add(base.Address, DamageThreshold_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bUseSizeSpecificDamageThreshold")]
	public bool UseSizeSpecificDamageThreshold
	{
		get
		{
			CheckDestroyed();
			if (!UseSizeSpecificDamageThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bUseSizeSpecificDamageThreshold");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSizeSpecificDamageThreshold_Offset), 0, UseSizeSpecificDamageThreshold_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSizeSpecificDamageThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bUseSizeSpecificDamageThreshold");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSizeSpecificDamageThreshold_Offset), 0, UseSizeSpecificDamageThreshold_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CollisionGroup")]
	public int CollisionGroup
	{
		get
		{
			CheckDestroyed();
			if (!CollisionGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CollisionGroup");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CollisionGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CollisionGroup");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CollisionGroup_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CollisionSampleFraction")]
	public float CollisionSampleFraction
	{
		get
		{
			CheckDestroyed();
			if (!CollisionSampleFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CollisionSampleFraction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CollisionSampleFraction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionSampleFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CollisionSampleFraction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CollisionSampleFraction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialVelocityType")]
	public EInitialVelocityTypeEnum InitialVelocityType
	{
		get
		{
			CheckDestroyed();
			if (!InitialVelocityType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialVelocityType");
				return EInitialVelocityTypeEnum.Chaos_Initial_Velocity_User_Defined;
			}
			return EnumMarshaler<EInitialVelocityTypeEnum>.FromNative(IntPtr.Add(base.Address, InitialVelocityType_Offset), 0, InitialVelocityType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InitialVelocityType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialVelocityType");
			}
			else
			{
				EnumMarshaler<EInitialVelocityTypeEnum>.ToNative(IntPtr.Add(base.Address, InitialVelocityType_Offset), 0, InitialVelocityType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialLinearVelocity")]
	public FVector InitialLinearVelocity
	{
		get
		{
			CheckDestroyed();
			if (!InitialLinearVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialLinearVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, InitialLinearVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialLinearVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialLinearVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, InitialLinearVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialAngularVelocity")]
	public FVector InitialAngularVelocity
	{
		get
		{
			CheckDestroyed();
			if (!InitialAngularVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialAngularVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, InitialAngularVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialAngularVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:InitialAngularVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, InitialAngularVelocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange")]
	public FNotifyGeometryCollectionPhysicsStateChange NotifyGeometryCollectionPhysicsStateChange
	{
		get
		{
			CheckDestroyed();
			if (!NotifyGeometryCollectionPhysicsStateChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsStateChange");
				return new FNotifyGeometryCollectionPhysicsStateChange();
			}
			if (NotifyGeometryCollectionPhysicsStateChange_DelegateCached == null)
			{
				NotifyGeometryCollectionPhysicsStateChange_DelegateCached = new FNotifyGeometryCollectionPhysicsStateChange();
				NotifyGeometryCollectionPhysicsStateChange_DelegateCached.SetAddress(IntPtr.Add(base.Address, NotifyGeometryCollectionPhysicsStateChange_Offset));
			}
			return NotifyGeometryCollectionPhysicsStateChange_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange")]
	public FNotifyGeometryCollectionPhysicsLoadingStateChange NotifyGeometryCollectionPhysicsLoadingStateChange
	{
		get
		{
			CheckDestroyed();
			if (!NotifyGeometryCollectionPhysicsLoadingStateChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:NotifyGeometryCollectionPhysicsLoadingStateChange");
				return new FNotifyGeometryCollectionPhysicsLoadingStateChange();
			}
			if (NotifyGeometryCollectionPhysicsLoadingStateChange_DelegateCached == null)
			{
				NotifyGeometryCollectionPhysicsLoadingStateChange_DelegateCached = new FNotifyGeometryCollectionPhysicsLoadingStateChange();
				NotifyGeometryCollectionPhysicsLoadingStateChange_DelegateCached.SetAddress(IntPtr.Add(base.Address, NotifyGeometryCollectionPhysicsLoadingStateChange_Offset));
			}
			return NotifyGeometryCollectionPhysicsLoadingStateChange_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:OnChaosBreakEvent")]
	public FOnChaosBreakEvent OnChaosBreakEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnChaosBreakEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:OnChaosBreakEvent");
				return new FOnChaosBreakEvent();
			}
			if (OnChaosBreakEvent_DelegateCached == null)
			{
				OnChaosBreakEvent_DelegateCached = new FOnChaosBreakEvent();
				OnChaosBreakEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnChaosBreakEvent_Offset));
			}
			return OnChaosBreakEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:OnChaosRemovalEvent")]
	public FOnChaosRemovalEvent OnChaosRemovalEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnChaosRemovalEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:OnChaosRemovalEvent");
				return new FOnChaosRemovalEvent();
			}
			if (OnChaosRemovalEvent_DelegateCached == null)
			{
				OnChaosRemovalEvent_DelegateCached = new FOnChaosRemovalEvent();
				OnChaosRemovalEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnChaosRemovalEvent_Offset));
			}
			return OnChaosRemovalEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755477824348677uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:DesiredCacheTime")]
	public float DesiredCacheTime
	{
		get
		{
			CheckDestroyed();
			if (!DesiredCacheTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:DesiredCacheTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DesiredCacheTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DesiredCacheTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:DesiredCacheTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DesiredCacheTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234414085uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CachePlayback")]
	public bool CachePlayback
	{
		get
		{
			CheckDestroyed();
			if (!CachePlayback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CachePlayback");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CachePlayback_Offset), 0, CachePlayback_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CachePlayback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:CachePlayback");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CachePlayback_Offset), 0, CachePlayback_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:OnChaosPhysicsCollision")]
	public FOnChaosPhysicsCollision OnChaosPhysicsCollision
	{
		get
		{
			CheckDestroyed();
			if (!OnChaosPhysicsCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:OnChaosPhysicsCollision");
				return new FOnChaosPhysicsCollision();
			}
			if (OnChaosPhysicsCollision_DelegateCached == null)
			{
				OnChaosPhysicsCollision_DelegateCached = new FOnChaosPhysicsCollision();
				OnChaosPhysicsCollision_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnChaosPhysicsCollision_Offset));
			}
			return OnChaosPhysicsCollision_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyBreaks")]
	public bool NotifyBreaks
	{
		get
		{
			CheckDestroyed();
			if (!NotifyBreaks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyBreaks");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotifyBreaks_Offset), 0, NotifyBreaks_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyBreaks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyBreaks");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotifyBreaks_Offset), 0, NotifyBreaks_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyCollisions")]
	public bool NotifyCollisions
	{
		get
		{
			CheckDestroyed();
			if (!NotifyCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyCollisions");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotifyCollisions_Offset), 0, NotifyCollisions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyCollisions");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotifyCollisions_Offset), 0, NotifyCollisions_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyTrailing")]
	public bool NotifyTrailing
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTrailing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyTrailing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotifyTrailing_Offset), 0, NotifyTrailing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTrailing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyTrailing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotifyTrailing_Offset), 0, NotifyTrailing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyRemovals")]
	public bool NotifyRemovals
	{
		get
		{
			CheckDestroyed();
			if (!NotifyRemovals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyRemovals");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotifyRemovals_Offset), 0, NotifyRemovals_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyRemovals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bNotifyRemovals");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotifyRemovals_Offset), 0, NotifyRemovals_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bStoreVelocities")]
	public bool StoreVelocities
	{
		get
		{
			CheckDestroyed();
			if (!StoreVelocities_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bStoreVelocities");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StoreVelocities_Offset), 0, StoreVelocities_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StoreVelocities_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bStoreVelocities");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StoreVelocities_Offset), 0, StoreVelocities_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bShowBoneColors")]
	protected bool ShowBoneColors
	{
		get
		{
			CheckDestroyed();
			if (!ShowBoneColors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bShowBoneColors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowBoneColors_Offset), 0, ShowBoneColors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowBoneColors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bShowBoneColors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowBoneColors_Offset), 0, ShowBoneColors_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954669589uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bEnableReplication")]
	protected bool EnableReplication
	{
		get
		{
			CheckDestroyed();
			if (!EnableReplication_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bEnableReplication");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableReplication_Offset), 0, EnableReplication_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableReplication_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bEnableReplication");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableReplication_Offset), 0, EnableReplication_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954669589uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bEnableAbandonAfterLevel")]
	protected bool EnableAbandonAfterLevel
	{
		get
		{
			CheckDestroyed();
			if (!EnableAbandonAfterLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bEnableAbandonAfterLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableAbandonAfterLevel_Offset), 0, EnableAbandonAfterLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableAbandonAfterLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:bEnableAbandonAfterLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableAbandonAfterLevel_Offset), 0, EnableAbandonAfterLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954669589uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReplicationAbandonClusterLevel")]
	protected int ReplicationAbandonClusterLevel
	{
		get
		{
			CheckDestroyed();
			if (!ReplicationAbandonClusterLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReplicationAbandonClusterLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ReplicationAbandonClusterLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReplicationAbandonClusterLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReplicationAbandonClusterLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ReplicationAbandonClusterLevel_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:SetNotifyRemovals")]
	public unsafe void SetNotifyRemovals(bool bNewNotifyRemovals)
	{
		CheckDestroyed();
		if (!SetNotifyRemovals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:SetNotifyRemovals");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNotifyRemovals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNotifyRemovals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNotifyRemovals_bNewNotifyRemovals_Offset), 0, SetNotifyRemovals_bNewNotifyRemovals_PropertyAddress.Address, bNewNotifyRemovals);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNotifyRemovals_FunctionAddress, intPtr, SetNotifyRemovals_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:SetNotifyBreaks")]
	public unsafe void SetNotifyBreaks(bool bNewNotifyBreaks)
	{
		CheckDestroyed();
		if (!SetNotifyBreaks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:SetNotifyBreaks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNotifyBreaks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNotifyBreaks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNotifyBreaks_bNewNotifyBreaks_Offset), 0, SetNotifyBreaks_bNewNotifyBreaks_PropertyAddress.Address, bNewNotifyBreaks);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNotifyBreaks_FunctionAddress, intPtr, SetNotifyBreaks_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReceivePhysicsCollision")]
	public unsafe void ReceivePhysicsCollision(FChaosPhysicsCollisionInfo CollisionInfo)
	{
		CheckDestroyed();
		if (!ReceivePhysicsCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReceivePhysicsCollision");
			return;
		}
		if (ReceivePhysicsCollision_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceivePhysicsCollision_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceivePhysicsCollision");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePhysicsCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePhysicsCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceivePhysicsCollision_CollisionInfo_PropertyAddress.Address, intPtr);
		FChaosPhysicsCollisionInfo.ToNative(IntPtr.Add(intPtr, ReceivePhysicsCollision_CollisionInfo_Offset), 0, ReceivePhysicsCollision_CollisionInfo_PropertyAddress.Address, CollisionInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePhysicsCollision_InstanceFunctionAddress, intPtr, ReceivePhysicsCollision_ParamsSize);
	}

	protected unsafe virtual void ReceivePhysicsCollision_Implementation(FChaosPhysicsCollisionInfo CollisionInfo)
	{
		CheckDestroyed();
		if (!ReceivePhysicsCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReceivePhysicsCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePhysicsCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePhysicsCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceivePhysicsCollision_CollisionInfo_PropertyAddress.Address, intPtr);
		FChaosPhysicsCollisionInfo.ToNative(IntPtr.Add(intPtr, ReceivePhysicsCollision_CollisionInfo_Offset), 0, ReceivePhysicsCollision_CollisionInfo_PropertyAddress.Address, CollisionInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePhysicsCollision_FunctionAddress, intPtr, ReceivePhysicsCollision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ApplyPhysicsField")]
	public unsafe void ApplyPhysicsField(bool Enabled, EGeometryCollectionPhysicsTypeEnum Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
	{
		CheckDestroyed();
		if (!ApplyPhysicsField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ApplyPhysicsField");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPhysicsField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPhysicsField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_Enabled_Offset), 0, ApplyPhysicsField_Enabled_PropertyAddress.Address, Enabled);
		EnumMarshaler<EGeometryCollectionPhysicsTypeEnum>.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_Target_Offset), 0, ApplyPhysicsField_Target_PropertyAddress.Address, Target);
		UObjectMarshaler<UFieldSystemMetaData>.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_MetaData_Offset), 0, ApplyPhysicsField_MetaData_PropertyAddress.Address, MetaData);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_Field_Offset), 0, ApplyPhysicsField_Field_PropertyAddress.Address, Field);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPhysicsField_FunctionAddress, intPtr, ApplyPhysicsField_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ApplyKinematicField")]
	public unsafe void ApplyKinematicField(float Radius, FVector Position)
	{
		CheckDestroyed();
		if (!ApplyKinematicField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ApplyKinematicField");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyKinematicField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyKinematicField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyKinematicField_Radius_Offset), 0, ApplyKinematicField_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyKinematicField_Position_Offset), 0, ApplyKinematicField_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyKinematicField_FunctionAddress, intPtr, ApplyKinematicField_ParamsSize);
	}

	static UGeometryCollectionComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryCollectionComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryCollectionComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryCollectionEngine.GeometryCollectionComponent");
		RestCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RestCollection");
		RestCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RestCollection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializationFields_PropertyAddress, intPtr, "InitializationFields");
		InitializationFields_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitializationFields");
		InitializationFields_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitializationFields", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectType_PropertyAddress, intPtr, "ObjectType");
		ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectType");
		ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceMotionBlur_PropertyAddress, intPtr, "bForceMotionBlur");
		ForceMotionBlur_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceMotionBlur");
		ForceMotionBlur_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceMotionBlur", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableClustering_PropertyAddress, intPtr, "EnableClustering");
		EnableClustering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableClustering");
		EnableClustering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableClustering", Classes.FBoolProperty);
		ClusterGroupIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClusterGroupIndex");
		ClusterGroupIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClusterGroupIndex", Classes.FIntProperty);
		MaxClusterLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxClusterLevel");
		MaxClusterLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxClusterLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DamageThreshold_PropertyAddress, intPtr, "DamageThreshold");
		DamageThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DamageThreshold");
		DamageThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DamageThreshold", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSizeSpecificDamageThreshold_PropertyAddress, intPtr, "bUseSizeSpecificDamageThreshold");
		UseSizeSpecificDamageThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSizeSpecificDamageThreshold");
		UseSizeSpecificDamageThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSizeSpecificDamageThreshold", Classes.FBoolProperty);
		CollisionGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionGroup");
		CollisionGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionGroup", Classes.FIntProperty);
		CollisionSampleFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionSampleFraction");
		CollisionSampleFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionSampleFraction", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitialVelocityType_PropertyAddress, intPtr, "InitialVelocityType");
		InitialVelocityType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialVelocityType");
		InitialVelocityType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialVelocityType", Classes.FEnumProperty);
		InitialLinearVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialLinearVelocity");
		InitialLinearVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialLinearVelocity", Classes.FStructProperty);
		InitialAngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialAngularVelocity");
		InitialAngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialAngularVelocity", Classes.FStructProperty);
		NotifyGeometryCollectionPhysicsStateChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyGeometryCollectionPhysicsStateChange");
		NotifyGeometryCollectionPhysicsStateChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyGeometryCollectionPhysicsStateChange", Classes.FMulticastDelegateProperty);
		NotifyGeometryCollectionPhysicsLoadingStateChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyGeometryCollectionPhysicsLoadingStateChange");
		NotifyGeometryCollectionPhysicsLoadingStateChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyGeometryCollectionPhysicsLoadingStateChange", Classes.FMulticastDelegateProperty);
		OnChaosBreakEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnChaosBreakEvent");
		OnChaosBreakEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnChaosBreakEvent", Classes.FMulticastDelegateProperty);
		OnChaosRemovalEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnChaosRemovalEvent");
		OnChaosRemovalEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnChaosRemovalEvent", Classes.FMulticastDelegateProperty);
		DesiredCacheTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DesiredCacheTime");
		DesiredCacheTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DesiredCacheTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CachePlayback_PropertyAddress, intPtr, "CachePlayback");
		CachePlayback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachePlayback");
		CachePlayback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachePlayback", Classes.FBoolProperty);
		OnChaosPhysicsCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnChaosPhysicsCollision");
		OnChaosPhysicsCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnChaosPhysicsCollision", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyBreaks_PropertyAddress, intPtr, "bNotifyBreaks");
		NotifyBreaks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotifyBreaks");
		NotifyBreaks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotifyBreaks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyCollisions_PropertyAddress, intPtr, "bNotifyCollisions");
		NotifyCollisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotifyCollisions");
		NotifyCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotifyCollisions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyTrailing_PropertyAddress, intPtr, "bNotifyTrailing");
		NotifyTrailing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotifyTrailing");
		NotifyTrailing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotifyTrailing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyRemovals_PropertyAddress, intPtr, "bNotifyRemovals");
		NotifyRemovals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotifyRemovals");
		NotifyRemovals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotifyRemovals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StoreVelocities_PropertyAddress, intPtr, "bStoreVelocities");
		StoreVelocities_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStoreVelocities");
		StoreVelocities_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStoreVelocities", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowBoneColors_PropertyAddress, intPtr, "bShowBoneColors");
		ShowBoneColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowBoneColors");
		ShowBoneColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowBoneColors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableReplication_PropertyAddress, intPtr, "bEnableReplication");
		EnableReplication_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableReplication");
		EnableReplication_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableReplication", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableAbandonAfterLevel_PropertyAddress, intPtr, "bEnableAbandonAfterLevel");
		EnableAbandonAfterLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableAbandonAfterLevel");
		EnableAbandonAfterLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableAbandonAfterLevel", Classes.FBoolProperty);
		ReplicationAbandonClusterLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReplicationAbandonClusterLevel");
		ReplicationAbandonClusterLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReplicationAbandonClusterLevel", Classes.FIntProperty);
		SetNotifyRemovals_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNotifyRemovals");
		SetNotifyRemovals_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNotifyRemovals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNotifyRemovals_bNewNotifyRemovals_PropertyAddress, SetNotifyRemovals_FunctionAddress, "bNewNotifyRemovals");
		SetNotifyRemovals_bNewNotifyRemovals_Offset = NativeReflectionCached.GetPropertyOffset(SetNotifyRemovals_FunctionAddress, "bNewNotifyRemovals");
		SetNotifyRemovals_bNewNotifyRemovals_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNotifyRemovals_FunctionAddress, "bNewNotifyRemovals", Classes.FBoolProperty);
		SetNotifyRemovals_IsValid = SetNotifyRemovals_FunctionAddress != IntPtr.Zero && SetNotifyRemovals_bNewNotifyRemovals_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:SetNotifyRemovals", SetNotifyRemovals_IsValid);
		SetNotifyBreaks_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNotifyBreaks");
		SetNotifyBreaks_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNotifyBreaks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNotifyBreaks_bNewNotifyBreaks_PropertyAddress, SetNotifyBreaks_FunctionAddress, "bNewNotifyBreaks");
		SetNotifyBreaks_bNewNotifyBreaks_Offset = NativeReflectionCached.GetPropertyOffset(SetNotifyBreaks_FunctionAddress, "bNewNotifyBreaks");
		SetNotifyBreaks_bNewNotifyBreaks_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNotifyBreaks_FunctionAddress, "bNewNotifyBreaks", Classes.FBoolProperty);
		SetNotifyBreaks_IsValid = SetNotifyBreaks_FunctionAddress != IntPtr.Zero && SetNotifyBreaks_bNewNotifyBreaks_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:SetNotifyBreaks", SetNotifyBreaks_IsValid);
		ReceivePhysicsCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceivePhysicsCollision");
		ReceivePhysicsCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceivePhysicsCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceivePhysicsCollision_CollisionInfo_PropertyAddress, ReceivePhysicsCollision_FunctionAddress, "CollisionInfo");
		ReceivePhysicsCollision_CollisionInfo_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePhysicsCollision_FunctionAddress, "CollisionInfo");
		ReceivePhysicsCollision_CollisionInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePhysicsCollision_FunctionAddress, "CollisionInfo", Classes.FStructProperty);
		ReceivePhysicsCollision_IsValid = ReceivePhysicsCollision_FunctionAddress != IntPtr.Zero && ReceivePhysicsCollision_CollisionInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ReceivePhysicsCollision", ReceivePhysicsCollision_IsValid);
		ApplyPhysicsField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyPhysicsField");
		ApplyPhysicsField_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPhysicsField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_Enabled_PropertyAddress, ApplyPhysicsField_FunctionAddress, "Enabled");
		ApplyPhysicsField_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "Enabled");
		ApplyPhysicsField_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_Target_PropertyAddress, ApplyPhysicsField_FunctionAddress, "Target");
		ApplyPhysicsField_Target_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "Target");
		ApplyPhysicsField_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "Target", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_MetaData_PropertyAddress, ApplyPhysicsField_FunctionAddress, "MetaData");
		ApplyPhysicsField_MetaData_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "MetaData");
		ApplyPhysicsField_MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "MetaData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_Field_PropertyAddress, ApplyPhysicsField_FunctionAddress, "Field");
		ApplyPhysicsField_Field_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "Field");
		ApplyPhysicsField_Field_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "Field", Classes.FObjectProperty);
		ApplyPhysicsField_IsValid = ApplyPhysicsField_FunctionAddress != IntPtr.Zero && ApplyPhysicsField_Enabled_IsValid && ApplyPhysicsField_Target_IsValid && ApplyPhysicsField_MetaData_IsValid && ApplyPhysicsField_Field_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ApplyPhysicsField", ApplyPhysicsField_IsValid);
		ApplyKinematicField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyKinematicField");
		ApplyKinematicField_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyKinematicField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyKinematicField_Radius_PropertyAddress, ApplyKinematicField_FunctionAddress, "Radius");
		ApplyKinematicField_Radius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyKinematicField_FunctionAddress, "Radius");
		ApplyKinematicField_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyKinematicField_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyKinematicField_Position_PropertyAddress, ApplyKinematicField_FunctionAddress, "Position");
		ApplyKinematicField_Position_Offset = NativeReflectionCached.GetPropertyOffset(ApplyKinematicField_FunctionAddress, "Position");
		ApplyKinematicField_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyKinematicField_FunctionAddress, "Position", Classes.FStructProperty);
		ApplyKinematicField_IsValid = ApplyKinematicField_FunctionAddress != IntPtr.Zero && ApplyKinematicField_Radius_IsValid && ApplyKinematicField_Position_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.GeometryCollectionComponent:ApplyKinematicField", ApplyKinematicField_IsValid);
	}
}
