using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.ChaosSolverEngine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public class UChaosDestructionListener : USceneComponent
{
	private static bool IsCollisionEventListeningEnabled_IsValid;

	private static FFieldAddress IsCollisionEventListeningEnabled_PropertyAddress;

	private static int IsCollisionEventListeningEnabled_Offset;

	private static bool IsBreakingEventListeningEnabled_IsValid;

	private static FFieldAddress IsBreakingEventListeningEnabled_PropertyAddress;

	private static int IsBreakingEventListeningEnabled_Offset;

	private static bool IsTrailingEventListeningEnabled_IsValid;

	private static FFieldAddress IsTrailingEventListeningEnabled_PropertyAddress;

	private static int IsTrailingEventListeningEnabled_Offset;

	private static bool IsRemovalEventListeningEnabled_IsValid;

	private static FFieldAddress IsRemovalEventListeningEnabled_PropertyAddress;

	private static int IsRemovalEventListeningEnabled_Offset;

	private static bool CollisionEventRequestSettings_IsValid;

	private static int CollisionEventRequestSettings_Offset;

	private static bool BreakingEventRequestSettings_IsValid;

	private static int BreakingEventRequestSettings_Offset;

	private static bool TrailingEventRequestSettings_IsValid;

	private static int TrailingEventRequestSettings_Offset;

	private static bool RemovalEventRequestSettings_IsValid;

	private static int RemovalEventRequestSettings_Offset;

	private static bool ChaosSolverActors_IsValid;

	private static FFieldAddress ChaosSolverActors_PropertyAddress;

	private static int ChaosSolverActors_Offset;

	private TSetReadOnlyMarshaler<AChaosSolverActor> ChaosSolverActors_MarshalerCached;

	private static bool GeometryCollectionActors_IsValid;

	private static FFieldAddress GeometryCollectionActors_PropertyAddress;

	private static int GeometryCollectionActors_Offset;

	private TSetReadOnlyMarshaler<AGeometryCollectionActor> GeometryCollectionActors_MarshalerCached;

	private static bool OnCollisionEvents_IsValid;

	private static int OnCollisionEvents_Offset;

	private FOnChaosCollisionEvents OnCollisionEvents_DelegateCached;

	private static bool OnBreakingEvents_IsValid;

	private static int OnBreakingEvents_Offset;

	private FOnChaosBreakingEvents OnBreakingEvents_DelegateCached;

	private static bool OnTrailingEvents_IsValid;

	private static int OnTrailingEvents_Offset;

	private FOnChaosTrailingEvents OnTrailingEvents_DelegateCached;

	private static bool OnRemovalEvents_IsValid;

	private static int OnRemovalEvents_Offset;

	private FOnChaosRemovalEvents OnRemovalEvents_DelegateCached;

	private static bool SortTrailingEvents_IsValid;

	private static IntPtr SortTrailingEvents_FunctionAddress;

	private static int SortTrailingEvents_ParamsSize;

	private static bool SortTrailingEvents_TrailingEvents_IsValid;

	private static FFieldAddress SortTrailingEvents_TrailingEvents_PropertyAddress;

	private static int SortTrailingEvents_TrailingEvents_Offset;

	private static bool SortTrailingEvents_SortMethod_IsValid;

	private static FFieldAddress SortTrailingEvents_SortMethod_PropertyAddress;

	private static int SortTrailingEvents_SortMethod_Offset;

	private static bool SortRemovalEvents_IsValid;

	private static IntPtr SortRemovalEvents_FunctionAddress;

	private static int SortRemovalEvents_ParamsSize;

	private static bool SortRemovalEvents_RemovalEvents_IsValid;

	private static FFieldAddress SortRemovalEvents_RemovalEvents_PropertyAddress;

	private static int SortRemovalEvents_RemovalEvents_Offset;

	private static bool SortRemovalEvents_SortMethod_IsValid;

	private static FFieldAddress SortRemovalEvents_SortMethod_PropertyAddress;

	private static int SortRemovalEvents_SortMethod_Offset;

	private static bool SortCollisionEvents_IsValid;

	private static IntPtr SortCollisionEvents_FunctionAddress;

	private static int SortCollisionEvents_ParamsSize;

	private static bool SortCollisionEvents_CollisionEvents_IsValid;

	private static FFieldAddress SortCollisionEvents_CollisionEvents_PropertyAddress;

	private static int SortCollisionEvents_CollisionEvents_Offset;

	private static bool SortCollisionEvents_SortMethod_IsValid;

	private static FFieldAddress SortCollisionEvents_SortMethod_PropertyAddress;

	private static int SortCollisionEvents_SortMethod_Offset;

	private static bool SortBreakingEvents_IsValid;

	private static IntPtr SortBreakingEvents_FunctionAddress;

	private static int SortBreakingEvents_ParamsSize;

	private static bool SortBreakingEvents_BreakingEvents_IsValid;

	private static FFieldAddress SortBreakingEvents_BreakingEvents_PropertyAddress;

	private static int SortBreakingEvents_BreakingEvents_Offset;

	private static bool SortBreakingEvents_SortMethod_IsValid;

	private static FFieldAddress SortBreakingEvents_SortMethod_PropertyAddress;

	private static int SortBreakingEvents_SortMethod_Offset;

	private static bool SetTrailingEventRequestSettings_IsValid;

	private static IntPtr SetTrailingEventRequestSettings_FunctionAddress;

	private static int SetTrailingEventRequestSettings_ParamsSize;

	private static bool SetTrailingEventRequestSettings_InSettings_IsValid;

	private static FFieldAddress SetTrailingEventRequestSettings_InSettings_PropertyAddress;

	private static int SetTrailingEventRequestSettings_InSettings_Offset;

	private static bool SetTrailingEventEnabled_IsValid;

	private static IntPtr SetTrailingEventEnabled_FunctionAddress;

	private static int SetTrailingEventEnabled_ParamsSize;

	private static bool SetTrailingEventEnabled_bIsEnabled_IsValid;

	private static FFieldAddress SetTrailingEventEnabled_bIsEnabled_PropertyAddress;

	private static int SetTrailingEventEnabled_bIsEnabled_Offset;

	private static bool SetRemovalEventRequestSettings_IsValid;

	private static IntPtr SetRemovalEventRequestSettings_FunctionAddress;

	private static int SetRemovalEventRequestSettings_ParamsSize;

	private static bool SetRemovalEventRequestSettings_InSettings_IsValid;

	private static FFieldAddress SetRemovalEventRequestSettings_InSettings_PropertyAddress;

	private static int SetRemovalEventRequestSettings_InSettings_Offset;

	private static bool SetRemovalEventEnabled_IsValid;

	private static IntPtr SetRemovalEventEnabled_FunctionAddress;

	private static int SetRemovalEventEnabled_ParamsSize;

	private static bool SetRemovalEventEnabled_bIsEnabled_IsValid;

	private static FFieldAddress SetRemovalEventEnabled_bIsEnabled_PropertyAddress;

	private static int SetRemovalEventEnabled_bIsEnabled_Offset;

	private static bool SetCollisionEventRequestSettings_IsValid;

	private static IntPtr SetCollisionEventRequestSettings_FunctionAddress;

	private static int SetCollisionEventRequestSettings_ParamsSize;

	private static bool SetCollisionEventRequestSettings_InSettings_IsValid;

	private static FFieldAddress SetCollisionEventRequestSettings_InSettings_PropertyAddress;

	private static int SetCollisionEventRequestSettings_InSettings_Offset;

	private static bool SetCollisionEventEnabled_IsValid;

	private static IntPtr SetCollisionEventEnabled_FunctionAddress;

	private static int SetCollisionEventEnabled_ParamsSize;

	private static bool SetCollisionEventEnabled_bIsEnabled_IsValid;

	private static FFieldAddress SetCollisionEventEnabled_bIsEnabled_PropertyAddress;

	private static int SetCollisionEventEnabled_bIsEnabled_Offset;

	private static bool SetBreakingEventRequestSettings_IsValid;

	private static IntPtr SetBreakingEventRequestSettings_FunctionAddress;

	private static int SetBreakingEventRequestSettings_ParamsSize;

	private static bool SetBreakingEventRequestSettings_InSettings_IsValid;

	private static FFieldAddress SetBreakingEventRequestSettings_InSettings_PropertyAddress;

	private static int SetBreakingEventRequestSettings_InSettings_Offset;

	private static bool SetBreakingEventEnabled_IsValid;

	private static IntPtr SetBreakingEventEnabled_FunctionAddress;

	private static int SetBreakingEventEnabled_ParamsSize;

	private static bool SetBreakingEventEnabled_bIsEnabled_IsValid;

	private static FFieldAddress SetBreakingEventEnabled_bIsEnabled_PropertyAddress;

	private static int SetBreakingEventEnabled_bIsEnabled_Offset;

	private static bool RemoveGeometryCollectionActor_IsValid;

	private static IntPtr RemoveGeometryCollectionActor_FunctionAddress;

	private static int RemoveGeometryCollectionActor_ParamsSize;

	private static bool RemoveGeometryCollectionActor_GeometryCollectionActor_IsValid;

	private static FFieldAddress RemoveGeometryCollectionActor_GeometryCollectionActor_PropertyAddress;

	private static int RemoveGeometryCollectionActor_GeometryCollectionActor_Offset;

	private static bool RemoveChaosSolverActor_IsValid;

	private static IntPtr RemoveChaosSolverActor_FunctionAddress;

	private static int RemoveChaosSolverActor_ParamsSize;

	private static bool RemoveChaosSolverActor_ChaosSolverActor_IsValid;

	private static FFieldAddress RemoveChaosSolverActor_ChaosSolverActor_PropertyAddress;

	private static int RemoveChaosSolverActor_ChaosSolverActor_Offset;

	private static bool IsEventListening_IsValid;

	private static IntPtr IsEventListening_FunctionAddress;

	private static int IsEventListening_ParamsSize;

	private static bool IsEventListening_ReturnValue_IsValid;

	private static FFieldAddress IsEventListening_ReturnValue_PropertyAddress;

	private static int IsEventListening_ReturnValue_Offset;

	private static bool AddGeometryCollectionActor_IsValid;

	private static IntPtr AddGeometryCollectionActor_FunctionAddress;

	private static int AddGeometryCollectionActor_ParamsSize;

	private static bool AddGeometryCollectionActor_GeometryCollectionActor_IsValid;

	private static FFieldAddress AddGeometryCollectionActor_GeometryCollectionActor_PropertyAddress;

	private static int AddGeometryCollectionActor_GeometryCollectionActor_Offset;

	private static bool AddChaosSolverActor_IsValid;

	private static IntPtr AddChaosSolverActor_FunctionAddress;

	private static int AddChaosSolverActor_ParamsSize;

	private static bool AddChaosSolverActor_ChaosSolverActor_IsValid;

	private static FFieldAddress AddChaosSolverActor_ChaosSolverActor_PropertyAddress;

	private static int AddChaosSolverActor_ChaosSolverActor_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsCollisionEventListeningEnabled")]
	public bool IsCollisionEventListeningEnabled
	{
		get
		{
			CheckDestroyed();
			if (!IsCollisionEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsCollisionEventListeningEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCollisionEventListeningEnabled_Offset), 0, IsCollisionEventListeningEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCollisionEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsCollisionEventListeningEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCollisionEventListeningEnabled_Offset), 0, IsCollisionEventListeningEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsBreakingEventListeningEnabled")]
	public bool IsBreakingEventListeningEnabled
	{
		get
		{
			CheckDestroyed();
			if (!IsBreakingEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsBreakingEventListeningEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsBreakingEventListeningEnabled_Offset), 0, IsBreakingEventListeningEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsBreakingEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsBreakingEventListeningEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsBreakingEventListeningEnabled_Offset), 0, IsBreakingEventListeningEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsTrailingEventListeningEnabled")]
	public bool IsTrailingEventListeningEnabled
	{
		get
		{
			CheckDestroyed();
			if (!IsTrailingEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsTrailingEventListeningEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTrailingEventListeningEnabled_Offset), 0, IsTrailingEventListeningEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTrailingEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsTrailingEventListeningEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTrailingEventListeningEnabled_Offset), 0, IsTrailingEventListeningEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsRemovalEventListeningEnabled")]
	public bool IsRemovalEventListeningEnabled
	{
		get
		{
			CheckDestroyed();
			if (!IsRemovalEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsRemovalEventListeningEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRemovalEventListeningEnabled_Offset), 0, IsRemovalEventListeningEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRemovalEventListeningEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:bIsRemovalEventListeningEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRemovalEventListeningEnabled_Offset), 0, IsRemovalEventListeningEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:CollisionEventRequestSettings")]
	public FChaosCollisionEventRequestSettings CollisionEventRequestSettings
	{
		get
		{
			CheckDestroyed();
			if (!CollisionEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:CollisionEventRequestSettings");
				return default(FChaosCollisionEventRequestSettings);
			}
			return FChaosCollisionEventRequestSettings.FromNative(IntPtr.Add(base.Address, CollisionEventRequestSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:CollisionEventRequestSettings");
			}
			else
			{
				FChaosCollisionEventRequestSettings.ToNative(IntPtr.Add(base.Address, CollisionEventRequestSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:BreakingEventRequestSettings")]
	public FChaosBreakingEventRequestSettings BreakingEventRequestSettings
	{
		get
		{
			CheckDestroyed();
			if (!BreakingEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:BreakingEventRequestSettings");
				return default(FChaosBreakingEventRequestSettings);
			}
			return FChaosBreakingEventRequestSettings.FromNative(IntPtr.Add(base.Address, BreakingEventRequestSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BreakingEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:BreakingEventRequestSettings");
			}
			else
			{
				FChaosBreakingEventRequestSettings.ToNative(IntPtr.Add(base.Address, BreakingEventRequestSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:TrailingEventRequestSettings")]
	public FChaosTrailingEventRequestSettings TrailingEventRequestSettings
	{
		get
		{
			CheckDestroyed();
			if (!TrailingEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:TrailingEventRequestSettings");
				return default(FChaosTrailingEventRequestSettings);
			}
			return FChaosTrailingEventRequestSettings.FromNative(IntPtr.Add(base.Address, TrailingEventRequestSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrailingEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:TrailingEventRequestSettings");
			}
			else
			{
				FChaosTrailingEventRequestSettings.ToNative(IntPtr.Add(base.Address, TrailingEventRequestSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemovalEventRequestSettings")]
	public FChaosRemovalEventRequestSettings RemovalEventRequestSettings
	{
		get
		{
			CheckDestroyed();
			if (!RemovalEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemovalEventRequestSettings");
				return default(FChaosRemovalEventRequestSettings);
			}
			return FChaosRemovalEventRequestSettings.FromNative(IntPtr.Add(base.Address, RemovalEventRequestSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RemovalEventRequestSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemovalEventRequestSettings");
			}
			else
			{
				FChaosRemovalEventRequestSettings.ToNative(IntPtr.Add(base.Address, RemovalEventRequestSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213141uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:ChaosSolverActors")]
	public TSetReadOnly<AChaosSolverActor> ChaosSolverActors
	{
		get
		{
			CheckDestroyed();
			if (!ChaosSolverActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:ChaosSolverActors");
				return null;
			}
			if (ChaosSolverActors_MarshalerCached == null)
			{
				ChaosSolverActors_MarshalerCached = new TSetReadOnlyMarshaler<AChaosSolverActor>(1, ChaosSolverActors_PropertyAddress, CachedMarshalingDelegates<AChaosSolverActor, UObjectMarshaler<AChaosSolverActor>>.FromNative, CachedMarshalingDelegates<AChaosSolverActor, UObjectMarshaler<AChaosSolverActor>>.ToNative);
			}
			return ChaosSolverActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, ChaosSolverActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213141uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:GeometryCollectionActors")]
	public TSetReadOnly<AGeometryCollectionActor> GeometryCollectionActors
	{
		get
		{
			CheckDestroyed();
			if (!GeometryCollectionActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:GeometryCollectionActors");
				return null;
			}
			if (GeometryCollectionActors_MarshalerCached == null)
			{
				GeometryCollectionActors_MarshalerCached = new TSetReadOnlyMarshaler<AGeometryCollectionActor>(1, GeometryCollectionActors_PropertyAddress, CachedMarshalingDelegates<AGeometryCollectionActor, UObjectMarshaler<AGeometryCollectionActor>>.FromNative, CachedMarshalingDelegates<AGeometryCollectionActor, UObjectMarshaler<AGeometryCollectionActor>>.ToNative);
			}
			return GeometryCollectionActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, GeometryCollectionActors_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnCollisionEvents")]
	public FOnChaosCollisionEvents OnCollisionEvents
	{
		get
		{
			CheckDestroyed();
			if (!OnCollisionEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnCollisionEvents");
				return new FOnChaosCollisionEvents();
			}
			if (OnCollisionEvents_DelegateCached == null)
			{
				OnCollisionEvents_DelegateCached = new FOnChaosCollisionEvents();
				OnCollisionEvents_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCollisionEvents_Offset));
			}
			return OnCollisionEvents_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnBreakingEvents")]
	public FOnChaosBreakingEvents OnBreakingEvents
	{
		get
		{
			CheckDestroyed();
			if (!OnBreakingEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnBreakingEvents");
				return new FOnChaosBreakingEvents();
			}
			if (OnBreakingEvents_DelegateCached == null)
			{
				OnBreakingEvents_DelegateCached = new FOnChaosBreakingEvents();
				OnBreakingEvents_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBreakingEvents_Offset));
			}
			return OnBreakingEvents_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnTrailingEvents")]
	public FOnChaosTrailingEvents OnTrailingEvents
	{
		get
		{
			CheckDestroyed();
			if (!OnTrailingEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnTrailingEvents");
				return new FOnChaosTrailingEvents();
			}
			if (OnTrailingEvents_DelegateCached == null)
			{
				OnTrailingEvents_DelegateCached = new FOnChaosTrailingEvents();
				OnTrailingEvents_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTrailingEvents_Offset));
			}
			return OnTrailingEvents_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnRemovalEvents")]
	public FOnChaosRemovalEvents OnRemovalEvents
	{
		get
		{
			CheckDestroyed();
			if (!OnRemovalEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:OnRemovalEvents");
				return new FOnChaosRemovalEvents();
			}
			if (OnRemovalEvents_DelegateCached == null)
			{
				OnRemovalEvents_DelegateCached = new FOnChaosRemovalEvents();
				OnRemovalEvents_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnRemovalEvents_Offset));
			}
			return OnRemovalEvents_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortTrailingEvents")]
	public unsafe void SortTrailingEvents(ref List<FChaosTrailingEventData> TrailingEvents, EChaosTrailingSortMethod SortMethod)
	{
		CheckDestroyed();
		if (!SortTrailingEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortTrailingEvents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortTrailingEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortTrailingEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FChaosTrailingEventData> tArrayCopyMarshaler = new TArrayCopyMarshaler<FChaosTrailingEventData>(1, SortTrailingEvents_TrailingEvents_PropertyAddress, CachedMarshalingDelegates<FChaosTrailingEventData, FChaosTrailingEventData>.FromNative, CachedMarshalingDelegates<FChaosTrailingEventData, FChaosTrailingEventData>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, SortTrailingEvents_TrailingEvents_Offset), TrailingEvents);
		EnumMarshaler<EChaosTrailingSortMethod>.ToNative(IntPtr.Add(intPtr, SortTrailingEvents_SortMethod_Offset), 0, SortTrailingEvents_SortMethod_PropertyAddress.Address, SortMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortTrailingEvents_FunctionAddress, intPtr, SortTrailingEvents_ParamsSize);
		TrailingEvents = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, SortTrailingEvents_TrailingEvents_Offset));
		NativeReflection.DestroyValue_InContainer(SortTrailingEvents_TrailingEvents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortRemovalEvents")]
	public unsafe void SortRemovalEvents(ref List<FChaosRemovalEventData> RemovalEvents, EChaosRemovalSortMethod SortMethod)
	{
		CheckDestroyed();
		if (!SortRemovalEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortRemovalEvents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortRemovalEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortRemovalEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FChaosRemovalEventData> tArrayCopyMarshaler = new TArrayCopyMarshaler<FChaosRemovalEventData>(1, SortRemovalEvents_RemovalEvents_PropertyAddress, CachedMarshalingDelegates<FChaosRemovalEventData, FChaosRemovalEventData>.FromNative, CachedMarshalingDelegates<FChaosRemovalEventData, FChaosRemovalEventData>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, SortRemovalEvents_RemovalEvents_Offset), RemovalEvents);
		EnumMarshaler<EChaosRemovalSortMethod>.ToNative(IntPtr.Add(intPtr, SortRemovalEvents_SortMethod_Offset), 0, SortRemovalEvents_SortMethod_PropertyAddress.Address, SortMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortRemovalEvents_FunctionAddress, intPtr, SortRemovalEvents_ParamsSize);
		RemovalEvents = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, SortRemovalEvents_RemovalEvents_Offset));
		NativeReflection.DestroyValue_InContainer(SortRemovalEvents_RemovalEvents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortCollisionEvents")]
	public unsafe void SortCollisionEvents(ref List<FChaosCollisionEventData> CollisionEvents, EChaosCollisionSortMethod SortMethod)
	{
		CheckDestroyed();
		if (!SortCollisionEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortCollisionEvents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortCollisionEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortCollisionEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FChaosCollisionEventData> tArrayCopyMarshaler = new TArrayCopyMarshaler<FChaosCollisionEventData>(1, SortCollisionEvents_CollisionEvents_PropertyAddress, CachedMarshalingDelegates<FChaosCollisionEventData, FChaosCollisionEventData>.FromNative, CachedMarshalingDelegates<FChaosCollisionEventData, FChaosCollisionEventData>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, SortCollisionEvents_CollisionEvents_Offset), CollisionEvents);
		EnumMarshaler<EChaosCollisionSortMethod>.ToNative(IntPtr.Add(intPtr, SortCollisionEvents_SortMethod_Offset), 0, SortCollisionEvents_SortMethod_PropertyAddress.Address, SortMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortCollisionEvents_FunctionAddress, intPtr, SortCollisionEvents_ParamsSize);
		CollisionEvents = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, SortCollisionEvents_CollisionEvents_Offset));
		NativeReflection.DestroyValue_InContainer(SortCollisionEvents_CollisionEvents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortBreakingEvents")]
	public unsafe void SortBreakingEvents(ref List<FChaosBreakingEventData> BreakingEvents, EChaosBreakingSortMethod SortMethod)
	{
		CheckDestroyed();
		if (!SortBreakingEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortBreakingEvents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortBreakingEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortBreakingEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FChaosBreakingEventData> tArrayCopyMarshaler = new TArrayCopyMarshaler<FChaosBreakingEventData>(1, SortBreakingEvents_BreakingEvents_PropertyAddress, CachedMarshalingDelegates<FChaosBreakingEventData, FChaosBreakingEventData>.FromNative, CachedMarshalingDelegates<FChaosBreakingEventData, FChaosBreakingEventData>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, SortBreakingEvents_BreakingEvents_Offset), BreakingEvents);
		EnumMarshaler<EChaosBreakingSortMethod>.ToNative(IntPtr.Add(intPtr, SortBreakingEvents_SortMethod_Offset), 0, SortBreakingEvents_SortMethod_PropertyAddress.Address, SortMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortBreakingEvents_FunctionAddress, intPtr, SortBreakingEvents_ParamsSize);
		BreakingEvents = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, SortBreakingEvents_BreakingEvents_Offset));
		NativeReflection.DestroyValue_InContainer(SortBreakingEvents_BreakingEvents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventRequestSettings")]
	public unsafe void SetTrailingEventRequestSettings(FChaosTrailingEventRequestSettings InSettings)
	{
		CheckDestroyed();
		if (!SetTrailingEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventRequestSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTrailingEventRequestSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTrailingEventRequestSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTrailingEventRequestSettings_InSettings_PropertyAddress.Address, intPtr);
		FChaosTrailingEventRequestSettings.ToNative(IntPtr.Add(intPtr, SetTrailingEventRequestSettings_InSettings_Offset), 0, SetTrailingEventRequestSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTrailingEventRequestSettings_FunctionAddress, intPtr, SetTrailingEventRequestSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventEnabled")]
	public unsafe void SetTrailingEventEnabled(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!SetTrailingEventEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTrailingEventEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTrailingEventEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTrailingEventEnabled_bIsEnabled_Offset), 0, SetTrailingEventEnabled_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTrailingEventEnabled_FunctionAddress, intPtr, SetTrailingEventEnabled_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventRequestSettings")]
	public unsafe void SetRemovalEventRequestSettings(FChaosRemovalEventRequestSettings InSettings)
	{
		CheckDestroyed();
		if (!SetRemovalEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventRequestSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRemovalEventRequestSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRemovalEventRequestSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRemovalEventRequestSettings_InSettings_PropertyAddress.Address, intPtr);
		FChaosRemovalEventRequestSettings.ToNative(IntPtr.Add(intPtr, SetRemovalEventRequestSettings_InSettings_Offset), 0, SetRemovalEventRequestSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRemovalEventRequestSettings_FunctionAddress, intPtr, SetRemovalEventRequestSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventEnabled")]
	public unsafe void SetRemovalEventEnabled(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!SetRemovalEventEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRemovalEventEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRemovalEventEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRemovalEventEnabled_bIsEnabled_Offset), 0, SetRemovalEventEnabled_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRemovalEventEnabled_FunctionAddress, intPtr, SetRemovalEventEnabled_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventRequestSettings")]
	public unsafe void SetCollisionEventRequestSettings(FChaosCollisionEventRequestSettings InSettings)
	{
		CheckDestroyed();
		if (!SetCollisionEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventRequestSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionEventRequestSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionEventRequestSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCollisionEventRequestSettings_InSettings_PropertyAddress.Address, intPtr);
		FChaosCollisionEventRequestSettings.ToNative(IntPtr.Add(intPtr, SetCollisionEventRequestSettings_InSettings_Offset), 0, SetCollisionEventRequestSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionEventRequestSettings_FunctionAddress, intPtr, SetCollisionEventRequestSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventEnabled")]
	public unsafe void SetCollisionEventEnabled(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!SetCollisionEventEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionEventEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionEventEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionEventEnabled_bIsEnabled_Offset), 0, SetCollisionEventEnabled_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionEventEnabled_FunctionAddress, intPtr, SetCollisionEventEnabled_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventRequestSettings")]
	public unsafe void SetBreakingEventRequestSettings(FChaosBreakingEventRequestSettings InSettings)
	{
		CheckDestroyed();
		if (!SetBreakingEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventRequestSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBreakingEventRequestSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBreakingEventRequestSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBreakingEventRequestSettings_InSettings_PropertyAddress.Address, intPtr);
		FChaosBreakingEventRequestSettings.ToNative(IntPtr.Add(intPtr, SetBreakingEventRequestSettings_InSettings_Offset), 0, SetBreakingEventRequestSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBreakingEventRequestSettings_FunctionAddress, intPtr, SetBreakingEventRequestSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventEnabled")]
	public unsafe void SetBreakingEventEnabled(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!SetBreakingEventEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBreakingEventEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBreakingEventEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBreakingEventEnabled_bIsEnabled_Offset), 0, SetBreakingEventEnabled_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBreakingEventEnabled_FunctionAddress, intPtr, SetBreakingEventEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveGeometryCollectionActor")]
	public unsafe void RemoveGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor)
	{
		CheckDestroyed();
		if (!RemoveGeometryCollectionActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveGeometryCollectionActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveGeometryCollectionActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveGeometryCollectionActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AGeometryCollectionActor>.ToNative(IntPtr.Add(intPtr, RemoveGeometryCollectionActor_GeometryCollectionActor_Offset), 0, RemoveGeometryCollectionActor_GeometryCollectionActor_PropertyAddress.Address, GeometryCollectionActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveGeometryCollectionActor_FunctionAddress, intPtr, RemoveGeometryCollectionActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveChaosSolverActor")]
	public unsafe void RemoveChaosSolverActor(AChaosSolverActor ChaosSolverActor)
	{
		CheckDestroyed();
		if (!RemoveChaosSolverActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveChaosSolverActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChaosSolverActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChaosSolverActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AChaosSolverActor>.ToNative(IntPtr.Add(intPtr, RemoveChaosSolverActor_ChaosSolverActor_Offset), 0, RemoveChaosSolverActor_ChaosSolverActor_PropertyAddress.Address, ChaosSolverActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveChaosSolverActor_FunctionAddress, intPtr, RemoveChaosSolverActor_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:IsEventListening")]
	public unsafe bool IsEventListening()
	{
		CheckDestroyed();
		if (!IsEventListening_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:IsEventListening");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEventListening_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEventListening_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEventListening_FunctionAddress, intPtr, IsEventListening_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEventListening_ReturnValue_Offset), 0, IsEventListening_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:AddGeometryCollectionActor")]
	public unsafe void AddGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor)
	{
		CheckDestroyed();
		if (!AddGeometryCollectionActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:AddGeometryCollectionActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGeometryCollectionActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGeometryCollectionActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AGeometryCollectionActor>.ToNative(IntPtr.Add(intPtr, AddGeometryCollectionActor_GeometryCollectionActor_Offset), 0, AddGeometryCollectionActor_GeometryCollectionActor_PropertyAddress.Address, GeometryCollectionActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGeometryCollectionActor_FunctionAddress, intPtr, AddGeometryCollectionActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosDestructionListener:AddChaosSolverActor")]
	public unsafe void AddChaosSolverActor(AChaosSolverActor ChaosSolverActor)
	{
		CheckDestroyed();
		if (!AddChaosSolverActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCollectionEngine.ChaosDestructionListener:AddChaosSolverActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChaosSolverActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChaosSolverActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AChaosSolverActor>.ToNative(IntPtr.Add(intPtr, AddChaosSolverActor_ChaosSolverActor_Offset), 0, AddChaosSolverActor_ChaosSolverActor_PropertyAddress.Address, ChaosSolverActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChaosSolverActor_FunctionAddress, intPtr, AddChaosSolverActor_ParamsSize);
	}

	static UChaosDestructionListener()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UChaosDestructionListener)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UChaosDestructionListener));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryCollectionEngine.ChaosDestructionListener");
		NativeReflectionCached.GetPropertyRef(ref IsCollisionEventListeningEnabled_PropertyAddress, intPtr, "bIsCollisionEventListeningEnabled");
		IsCollisionEventListeningEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCollisionEventListeningEnabled");
		IsCollisionEventListeningEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCollisionEventListeningEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBreakingEventListeningEnabled_PropertyAddress, intPtr, "bIsBreakingEventListeningEnabled");
		IsBreakingEventListeningEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsBreakingEventListeningEnabled");
		IsBreakingEventListeningEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsBreakingEventListeningEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTrailingEventListeningEnabled_PropertyAddress, intPtr, "bIsTrailingEventListeningEnabled");
		IsTrailingEventListeningEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsTrailingEventListeningEnabled");
		IsTrailingEventListeningEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsTrailingEventListeningEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRemovalEventListeningEnabled_PropertyAddress, intPtr, "bIsRemovalEventListeningEnabled");
		IsRemovalEventListeningEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsRemovalEventListeningEnabled");
		IsRemovalEventListeningEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsRemovalEventListeningEnabled", Classes.FBoolProperty);
		CollisionEventRequestSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionEventRequestSettings");
		CollisionEventRequestSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionEventRequestSettings", Classes.FStructProperty);
		BreakingEventRequestSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BreakingEventRequestSettings");
		BreakingEventRequestSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BreakingEventRequestSettings", Classes.FStructProperty);
		TrailingEventRequestSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrailingEventRequestSettings");
		TrailingEventRequestSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrailingEventRequestSettings", Classes.FStructProperty);
		RemovalEventRequestSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RemovalEventRequestSettings");
		RemovalEventRequestSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RemovalEventRequestSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ChaosSolverActors_PropertyAddress, intPtr, "ChaosSolverActors");
		ChaosSolverActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChaosSolverActors");
		ChaosSolverActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChaosSolverActors", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref GeometryCollectionActors_PropertyAddress, intPtr, "GeometryCollectionActors");
		GeometryCollectionActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GeometryCollectionActors");
		GeometryCollectionActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GeometryCollectionActors", Classes.FSetProperty);
		OnCollisionEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnCollisionEvents");
		OnCollisionEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnCollisionEvents", Classes.FMulticastDelegateProperty);
		OnBreakingEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnBreakingEvents");
		OnBreakingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnBreakingEvents", Classes.FMulticastDelegateProperty);
		OnTrailingEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTrailingEvents");
		OnTrailingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTrailingEvents", Classes.FMulticastDelegateProperty);
		OnRemovalEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnRemovalEvents");
		OnRemovalEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnRemovalEvents", Classes.FMulticastDelegateProperty);
		SortTrailingEvents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortTrailingEvents");
		SortTrailingEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(SortTrailingEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortTrailingEvents_TrailingEvents_PropertyAddress, SortTrailingEvents_FunctionAddress, "TrailingEvents");
		SortTrailingEvents_TrailingEvents_Offset = NativeReflectionCached.GetPropertyOffset(SortTrailingEvents_FunctionAddress, "TrailingEvents");
		SortTrailingEvents_TrailingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SortTrailingEvents_FunctionAddress, "TrailingEvents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortTrailingEvents_SortMethod_PropertyAddress, SortTrailingEvents_FunctionAddress, "SortMethod");
		SortTrailingEvents_SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(SortTrailingEvents_FunctionAddress, "SortMethod");
		SortTrailingEvents_SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SortTrailingEvents_FunctionAddress, "SortMethod", Classes.FEnumProperty);
		SortTrailingEvents_IsValid = SortTrailingEvents_FunctionAddress != IntPtr.Zero && SortTrailingEvents_TrailingEvents_IsValid && SortTrailingEvents_SortMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortTrailingEvents", SortTrailingEvents_IsValid);
		SortRemovalEvents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortRemovalEvents");
		SortRemovalEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(SortRemovalEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortRemovalEvents_RemovalEvents_PropertyAddress, SortRemovalEvents_FunctionAddress, "RemovalEvents");
		SortRemovalEvents_RemovalEvents_Offset = NativeReflectionCached.GetPropertyOffset(SortRemovalEvents_FunctionAddress, "RemovalEvents");
		SortRemovalEvents_RemovalEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SortRemovalEvents_FunctionAddress, "RemovalEvents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortRemovalEvents_SortMethod_PropertyAddress, SortRemovalEvents_FunctionAddress, "SortMethod");
		SortRemovalEvents_SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(SortRemovalEvents_FunctionAddress, "SortMethod");
		SortRemovalEvents_SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SortRemovalEvents_FunctionAddress, "SortMethod", Classes.FEnumProperty);
		SortRemovalEvents_IsValid = SortRemovalEvents_FunctionAddress != IntPtr.Zero && SortRemovalEvents_RemovalEvents_IsValid && SortRemovalEvents_SortMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortRemovalEvents", SortRemovalEvents_IsValid);
		SortCollisionEvents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortCollisionEvents");
		SortCollisionEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(SortCollisionEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortCollisionEvents_CollisionEvents_PropertyAddress, SortCollisionEvents_FunctionAddress, "CollisionEvents");
		SortCollisionEvents_CollisionEvents_Offset = NativeReflectionCached.GetPropertyOffset(SortCollisionEvents_FunctionAddress, "CollisionEvents");
		SortCollisionEvents_CollisionEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SortCollisionEvents_FunctionAddress, "CollisionEvents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortCollisionEvents_SortMethod_PropertyAddress, SortCollisionEvents_FunctionAddress, "SortMethod");
		SortCollisionEvents_SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(SortCollisionEvents_FunctionAddress, "SortMethod");
		SortCollisionEvents_SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SortCollisionEvents_FunctionAddress, "SortMethod", Classes.FEnumProperty);
		SortCollisionEvents_IsValid = SortCollisionEvents_FunctionAddress != IntPtr.Zero && SortCollisionEvents_CollisionEvents_IsValid && SortCollisionEvents_SortMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortCollisionEvents", SortCollisionEvents_IsValid);
		SortBreakingEvents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortBreakingEvents");
		SortBreakingEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(SortBreakingEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortBreakingEvents_BreakingEvents_PropertyAddress, SortBreakingEvents_FunctionAddress, "BreakingEvents");
		SortBreakingEvents_BreakingEvents_Offset = NativeReflectionCached.GetPropertyOffset(SortBreakingEvents_FunctionAddress, "BreakingEvents");
		SortBreakingEvents_BreakingEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SortBreakingEvents_FunctionAddress, "BreakingEvents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortBreakingEvents_SortMethod_PropertyAddress, SortBreakingEvents_FunctionAddress, "SortMethod");
		SortBreakingEvents_SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(SortBreakingEvents_FunctionAddress, "SortMethod");
		SortBreakingEvents_SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SortBreakingEvents_FunctionAddress, "SortMethod", Classes.FEnumProperty);
		SortBreakingEvents_IsValid = SortBreakingEvents_FunctionAddress != IntPtr.Zero && SortBreakingEvents_BreakingEvents_IsValid && SortBreakingEvents_SortMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SortBreakingEvents", SortBreakingEvents_IsValid);
		SetTrailingEventRequestSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTrailingEventRequestSettings");
		SetTrailingEventRequestSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrailingEventRequestSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTrailingEventRequestSettings_InSettings_PropertyAddress, SetTrailingEventRequestSettings_FunctionAddress, "InSettings");
		SetTrailingEventRequestSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetTrailingEventRequestSettings_FunctionAddress, "InSettings");
		SetTrailingEventRequestSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrailingEventRequestSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetTrailingEventRequestSettings_IsValid = SetTrailingEventRequestSettings_FunctionAddress != IntPtr.Zero && SetTrailingEventRequestSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventRequestSettings", SetTrailingEventRequestSettings_IsValid);
		SetTrailingEventEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTrailingEventEnabled");
		SetTrailingEventEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrailingEventEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTrailingEventEnabled_bIsEnabled_PropertyAddress, SetTrailingEventEnabled_FunctionAddress, "bIsEnabled");
		SetTrailingEventEnabled_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetTrailingEventEnabled_FunctionAddress, "bIsEnabled");
		SetTrailingEventEnabled_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrailingEventEnabled_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		SetTrailingEventEnabled_IsValid = SetTrailingEventEnabled_FunctionAddress != IntPtr.Zero && SetTrailingEventEnabled_bIsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetTrailingEventEnabled", SetTrailingEventEnabled_IsValid);
		SetRemovalEventRequestSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRemovalEventRequestSettings");
		SetRemovalEventRequestSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRemovalEventRequestSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRemovalEventRequestSettings_InSettings_PropertyAddress, SetRemovalEventRequestSettings_FunctionAddress, "InSettings");
		SetRemovalEventRequestSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetRemovalEventRequestSettings_FunctionAddress, "InSettings");
		SetRemovalEventRequestSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemovalEventRequestSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetRemovalEventRequestSettings_IsValid = SetRemovalEventRequestSettings_FunctionAddress != IntPtr.Zero && SetRemovalEventRequestSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventRequestSettings", SetRemovalEventRequestSettings_IsValid);
		SetRemovalEventEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRemovalEventEnabled");
		SetRemovalEventEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRemovalEventEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRemovalEventEnabled_bIsEnabled_PropertyAddress, SetRemovalEventEnabled_FunctionAddress, "bIsEnabled");
		SetRemovalEventEnabled_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetRemovalEventEnabled_FunctionAddress, "bIsEnabled");
		SetRemovalEventEnabled_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemovalEventEnabled_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		SetRemovalEventEnabled_IsValid = SetRemovalEventEnabled_FunctionAddress != IntPtr.Zero && SetRemovalEventEnabled_bIsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetRemovalEventEnabled", SetRemovalEventEnabled_IsValid);
		SetCollisionEventRequestSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionEventRequestSettings");
		SetCollisionEventRequestSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionEventRequestSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEventRequestSettings_InSettings_PropertyAddress, SetCollisionEventRequestSettings_FunctionAddress, "InSettings");
		SetCollisionEventRequestSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEventRequestSettings_FunctionAddress, "InSettings");
		SetCollisionEventRequestSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEventRequestSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetCollisionEventRequestSettings_IsValid = SetCollisionEventRequestSettings_FunctionAddress != IntPtr.Zero && SetCollisionEventRequestSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventRequestSettings", SetCollisionEventRequestSettings_IsValid);
		SetCollisionEventEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionEventEnabled");
		SetCollisionEventEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionEventEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEventEnabled_bIsEnabled_PropertyAddress, SetCollisionEventEnabled_FunctionAddress, "bIsEnabled");
		SetCollisionEventEnabled_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEventEnabled_FunctionAddress, "bIsEnabled");
		SetCollisionEventEnabled_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEventEnabled_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		SetCollisionEventEnabled_IsValid = SetCollisionEventEnabled_FunctionAddress != IntPtr.Zero && SetCollisionEventEnabled_bIsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetCollisionEventEnabled", SetCollisionEventEnabled_IsValid);
		SetBreakingEventRequestSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBreakingEventRequestSettings");
		SetBreakingEventRequestSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBreakingEventRequestSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBreakingEventRequestSettings_InSettings_PropertyAddress, SetBreakingEventRequestSettings_FunctionAddress, "InSettings");
		SetBreakingEventRequestSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetBreakingEventRequestSettings_FunctionAddress, "InSettings");
		SetBreakingEventRequestSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBreakingEventRequestSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetBreakingEventRequestSettings_IsValid = SetBreakingEventRequestSettings_FunctionAddress != IntPtr.Zero && SetBreakingEventRequestSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventRequestSettings", SetBreakingEventRequestSettings_IsValid);
		SetBreakingEventEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBreakingEventEnabled");
		SetBreakingEventEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBreakingEventEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBreakingEventEnabled_bIsEnabled_PropertyAddress, SetBreakingEventEnabled_FunctionAddress, "bIsEnabled");
		SetBreakingEventEnabled_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetBreakingEventEnabled_FunctionAddress, "bIsEnabled");
		SetBreakingEventEnabled_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBreakingEventEnabled_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		SetBreakingEventEnabled_IsValid = SetBreakingEventEnabled_FunctionAddress != IntPtr.Zero && SetBreakingEventEnabled_bIsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:SetBreakingEventEnabled", SetBreakingEventEnabled_IsValid);
		RemoveGeometryCollectionActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveGeometryCollectionActor");
		RemoveGeometryCollectionActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGeometryCollectionActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveGeometryCollectionActor_GeometryCollectionActor_PropertyAddress, RemoveGeometryCollectionActor_FunctionAddress, "GeometryCollectionActor");
		RemoveGeometryCollectionActor_GeometryCollectionActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGeometryCollectionActor_FunctionAddress, "GeometryCollectionActor");
		RemoveGeometryCollectionActor_GeometryCollectionActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGeometryCollectionActor_FunctionAddress, "GeometryCollectionActor", Classes.FObjectProperty);
		RemoveGeometryCollectionActor_IsValid = RemoveGeometryCollectionActor_FunctionAddress != IntPtr.Zero && RemoveGeometryCollectionActor_GeometryCollectionActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveGeometryCollectionActor", RemoveGeometryCollectionActor_IsValid);
		RemoveChaosSolverActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveChaosSolverActor");
		RemoveChaosSolverActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChaosSolverActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChaosSolverActor_ChaosSolverActor_PropertyAddress, RemoveChaosSolverActor_FunctionAddress, "ChaosSolverActor");
		RemoveChaosSolverActor_ChaosSolverActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChaosSolverActor_FunctionAddress, "ChaosSolverActor");
		RemoveChaosSolverActor_ChaosSolverActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChaosSolverActor_FunctionAddress, "ChaosSolverActor", Classes.FObjectProperty);
		RemoveChaosSolverActor_IsValid = RemoveChaosSolverActor_FunctionAddress != IntPtr.Zero && RemoveChaosSolverActor_ChaosSolverActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:RemoveChaosSolverActor", RemoveChaosSolverActor_IsValid);
		IsEventListening_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEventListening");
		IsEventListening_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEventListening_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEventListening_ReturnValue_PropertyAddress, IsEventListening_FunctionAddress, "ReturnValue");
		IsEventListening_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEventListening_FunctionAddress, "ReturnValue");
		IsEventListening_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEventListening_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEventListening_IsValid = IsEventListening_FunctionAddress != IntPtr.Zero && IsEventListening_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:IsEventListening", IsEventListening_IsValid);
		AddGeometryCollectionActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddGeometryCollectionActor");
		AddGeometryCollectionActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGeometryCollectionActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGeometryCollectionActor_GeometryCollectionActor_PropertyAddress, AddGeometryCollectionActor_FunctionAddress, "GeometryCollectionActor");
		AddGeometryCollectionActor_GeometryCollectionActor_Offset = NativeReflectionCached.GetPropertyOffset(AddGeometryCollectionActor_FunctionAddress, "GeometryCollectionActor");
		AddGeometryCollectionActor_GeometryCollectionActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGeometryCollectionActor_FunctionAddress, "GeometryCollectionActor", Classes.FObjectProperty);
		AddGeometryCollectionActor_IsValid = AddGeometryCollectionActor_FunctionAddress != IntPtr.Zero && AddGeometryCollectionActor_GeometryCollectionActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:AddGeometryCollectionActor", AddGeometryCollectionActor_IsValid);
		AddChaosSolverActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddChaosSolverActor");
		AddChaosSolverActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChaosSolverActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChaosSolverActor_ChaosSolverActor_PropertyAddress, AddChaosSolverActor_FunctionAddress, "ChaosSolverActor");
		AddChaosSolverActor_ChaosSolverActor_Offset = NativeReflectionCached.GetPropertyOffset(AddChaosSolverActor_FunctionAddress, "ChaosSolverActor");
		AddChaosSolverActor_ChaosSolverActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChaosSolverActor_FunctionAddress, "ChaosSolverActor", Classes.FObjectProperty);
		AddChaosSolverActor_IsValid = AddChaosSolverActor_FunctionAddress != IntPtr.Zero && AddChaosSolverActor_ChaosSolverActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCollectionEngine.ChaosDestructionListener:AddChaosSolverActor", AddChaosSolverActor_IsValid);
	}
}
