using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Physics Force")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce")]
internal class BANS_GSPhysicsForce : BANS_GSBase
{
	private static bool PhysicsForceType_IsValid;

	private static int PhysicsForceType_Offset;

	private static FFieldAddress PhysicsForceType_PropertyAddress;

	private static bool ForceFieldSize_IsValid;

	private static int ForceFieldSize_Offset;

	private static bool ForceFieldOffset_IsValid;

	private static int ForceFieldOffset_Offset;

	private static bool DestructibleDamage_IsValid;

	private static int DestructibleDamage_Offset;

	private static bool ImpulseStrength_IsValid;

	private static int ImpulseStrength_Offset;

	private static bool QueryObjectTypes_IsValid;

	private static int QueryObjectTypes_Offset;

	private static FFieldAddress QueryObjectTypes_PropertyAddress;

	private TArrayReadWriteMarshaler<EObjectTypeQuery> QueryObjectTypes_Marshaler;

	private static bool IsDrawDebugShape_IsValid;

	private static int IsDrawDebugShape_Offset;

	private static FFieldAddress IsDrawDebugShape_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[DisplayName("物理力方向类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:PhysicsForceType")]
	public EPhysicsForceType PhysicsForceType
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsForceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:PhysicsForceType");
				return EPhysicsForceType.DirectionalForce;
			}
			return EnumMarshaler<EPhysicsForceType>.FromNative(IntPtr.Add(base.Address, PhysicsForceType_Offset), 0, PhysicsForceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsForceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:PhysicsForceType");
			}
			else
			{
				EnumMarshaler<EPhysicsForceType>.ToNative(IntPtr.Add(base.Address, PhysicsForceType_Offset), 0, PhysicsForceType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[DisplayName("物理力触发半径")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:ForceFieldSize")]
	public float ForceFieldSize
	{
		get
		{
			CheckDestroyed();
			if (!ForceFieldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:ForceFieldSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForceFieldSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceFieldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:ForceFieldSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForceFieldSize_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("物理力触发Postion偏移")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:ForceFieldOffset")]
	public FVector ForceFieldOffset
	{
		get
		{
			CheckDestroyed();
			if (!ForceFieldOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:ForceFieldOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ForceFieldOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceFieldOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:ForceFieldOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ForceFieldOffset_Offset), value);
			}
		}
	}

	[DisplayName("物理力对破碎物伤害值")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:DestructibleDamage")]
	public float DestructibleDamage
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:DestructibleDamage");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestructibleDamage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:DestructibleDamage");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestructibleDamage_Offset), value);
			}
		}
	}

	[DisplayName("物理力方向大小")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:ImpulseStrength")]
	public float ImpulseStrength
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:ImpulseStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImpulseStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:ImpulseStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImpulseStrength_Offset), value);
			}
		}
	}

	[DisplayName("接收物理力物体类型")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:QueryObjectTypes")]
	public TArrayReadWrite<EObjectTypeQuery> QueryObjectTypes
	{
		get
		{
			CheckDestroyed();
			if (!QueryObjectTypes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:QueryObjectTypes");
				return null;
			}
			if (QueryObjectTypes_Marshaler == null)
			{
				QueryObjectTypes_Marshaler = new TArrayReadWriteMarshaler<EObjectTypeQuery>(1, QueryObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative);
			}
			return QueryObjectTypes_Marshaler.FromNative(IntPtr.Add(base.Address, QueryObjectTypes_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:IsDrawDebugShape")]
	public bool IsDrawDebugShape
	{
		get
		{
			CheckDestroyed();
			if (!IsDrawDebugShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:IsDrawDebugShape");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDrawDebugShape_Offset), 0, IsDrawDebugShape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDrawDebugShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPhysicsForce:IsDrawDebugShape");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDrawDebugShape_Offset), 0, IsDrawDebugShape_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null && owner.World != null)
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_FireImpulseLikeRadialForceComp.Invoke(owner, PhysicsForceType, ForceFieldSize, ForceFieldOffset, DestructibleDamage, ImpulseStrength, QueryObjectTypes.ToList(), TotalDuration, IsDrawDebugShape);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPhysicsForce bANS_GSPhysicsForce = GCHelper.Find<b1.BANS_GSPhysicsForce>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSPhysicsForce.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPhysicsForce bANS_GSPhysicsForce = GCHelper.Find<b1.BANS_GSPhysicsForce>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSPhysicsForce.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPhysicsForce bANS_GSPhysicsForce = GCHelper.Find<b1.BANS_GSPhysicsForce>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSPhysicsForce.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPhysicsForce");
		NativeReflection.GetPropertyRef(ref PhysicsForceType_PropertyAddress, intPtr, "PhysicsForceType");
		PhysicsForceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicsForceType");
		PhysicsForceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicsForceType", Classes.FEnumProperty);
		ForceFieldSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceFieldSize");
		ForceFieldSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceFieldSize", Classes.FFloatProperty);
		ForceFieldOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceFieldOffset");
		ForceFieldOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceFieldOffset", Classes.FStructProperty);
		DestructibleDamage_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestructibleDamage");
		DestructibleDamage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestructibleDamage", Classes.FFloatProperty);
		ImpulseStrength_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImpulseStrength");
		ImpulseStrength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImpulseStrength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref QueryObjectTypes_PropertyAddress, intPtr, "QueryObjectTypes");
		QueryObjectTypes_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryObjectTypes");
		QueryObjectTypes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryObjectTypes", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsDrawDebugShape_PropertyAddress, intPtr, "IsDrawDebugShape");
		IsDrawDebugShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsDrawDebugShape");
		IsDrawDebugShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsDrawDebugShape", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPhysicsForce:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSPhysicsForce()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSPhysicsForce)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSPhysicsForce));
	}
}
