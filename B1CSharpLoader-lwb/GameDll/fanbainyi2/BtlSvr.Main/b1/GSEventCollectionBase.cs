using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSEventCollectionBase")]
public class GSEventCollectionBase : UBaseActorComp
{
	public Dictionary<int, EventRegCacheContainer> _EntityComponentEventRegCache = new Dictionary<int, EventRegCacheContainer>();

	protected Dictionary<int, IFreshAbleGSEvent> _EventObjCache = new Dictionary<int, IFreshAbleGSEvent>();

	protected string OwnerName;

	protected int EntityMgrIdx;

	protected UActorCompContainerCS ActorCompContainerCSCache;

	private AActor _owner;

	public static List<WeakReference<GSEventCollectionBase>> s_weakReferences;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool InitializeCS_IsValid;

	private static IntPtr InitializeCS_FunctionAddress;

	private static int InitializeCS_ParamsSize;

	public bool HasBeginPlay
	{
		get
		{
			if ((object)ActorCompContainerCSCache != null)
			{
				return ActorCompContainerCSCache.HasBeginPlay;
			}
			return false;
		}
	}

	protected AActor Owner
	{
		get
		{
			if (_owner == null)
			{
				_owner = GetOwner();
			}
			return _owner;
		}
	}

	protected bool HasAuthority => BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner);

	protected bool IsServer => UGSE_OnlineFuncLib.InServerReal(Owner);

	[USharpPath("/Script/b1-Managed.GSEventCollectionBase:InitializeCS")]
	protected override void InitializeCS_Implementation()
	{
		base.InitializeCS_Implementation();
		ActorCompContainerCSCache = (Owner as IECSWorldObj)?.ActorCompContainerCS;
		if (DebugConfig.EventMemoryLeakTest)
		{
			s_weakReferences.Add(new WeakReference<GSEventCollectionBase>(this));
		}
	}

	public List<EventRegCache> GetOrAllocEventRegCache(IEntityComponent EntityComponent)
	{
		if (!HasBeginPlay)
		{
			return new List<EventRegCache>();
		}
		int hashCode = EntityComponent.GetHashCode();
		if (!_EntityComponentEventRegCache.TryGetValue(hashCode, out var value))
		{
			value = new EventRegCacheContainer();
			value.EntityComponent = EntityComponent;
			_EntityComponentEventRegCache[hashCode] = value;
			if (EntityComponent.GetOwnerEntity() != ECSExtension.ToEntity(Owner))
			{
				EntityComponent.AddRelativeEventCollection(this);
			}
		}
		return value.CacheData;
	}

	public void DeAllocEventRegCache(IEntityComponent EntityComponent)
	{
		int hashCode = EntityComponent.GetHashCode();
		if (_EntityComponentEventRegCache.TryGetValue(hashCode, out var value))
		{
			_EntityComponentEventRegCache.Remove(hashCode);
			foreach (EventRegCache cacheDatum in value.CacheData)
			{
				EventRegCache.DeAllocEventRegCache(cacheDatum);
			}
		}
		else
		{
			BGW_LogUtil.LogError("DeAllocEventRegCache Cache Not Found");
		}
		if (EntityComponent.GetOwnerEntity() != ECSExtension.ToEntity(Owner))
		{
			EntityComponent.RemoveRelativeEventCollection(this);
		}
	}

	public void RefreshEntityComponentEventReg(IEntityComponent EntityComponent)
	{
		if (!_EntityComponentEventRegCache.TryGetValue(EntityComponent.GetHashCode(), out var value))
		{
			return;
		}
		bool flag = EntityComponent.IsNetActive();
		foreach (EventRegCache cacheDatum in value.CacheData)
		{
			if (flag != cacheDatum.IsNetActive)
			{
				cacheDatum.IsNetActive = flag;
				_EventObjCache[cacheDatum.EventId].RefreshEntityComponentEventReg(flag, cacheDatum.Del);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSEventCollectionBase:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		base.EndPlayInCS_Implementation(EndPlayReason);
		while (_EntityComponentEventRegCache.Count > 0)
		{
			DeAllocEventRegCache(_EntityComponentEventRegCache.ElementAt(0).Value.EntityComponent);
		}
		_EventObjCache.Clear();
	}

	public override string ToString()
	{
		return $"{OwnerName}.{GetType()}";
	}

	static GSEventCollectionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEventCollectionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEventCollectionBase));
		s_weakReferences = new List<WeakReference<GSEventCollectionBase>>();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEventCollectionBase:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEventCollectionBase gSEventCollectionBase = GCHelper.Find<GSEventCollectionBase>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		gSEventCollectionBase.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEventCollectionBase:InitializeCS")]
	private static void InitializeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEventCollectionBase gSEventCollectionBase = GCHelper.Find<GSEventCollectionBase>(obj);
		gSEventCollectionBase.InitializeCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSEventCollectionBase");
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEventCollectionBase:EndPlayInCS", EndPlayInCS_IsValid);
		InitializeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeCS");
		InitializeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeCS_FunctionAddress);
		InitializeCS_IsValid = InitializeCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEventCollectionBase:InitializeCS", InitializeCS_IsValid);
	}
}
