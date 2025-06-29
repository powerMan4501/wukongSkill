using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase", "FunctionalTesting", UnrealModuleType.Engine)]
public class AFunctionalAITestBase : AFunctionalTest
{
	private static bool SpawnLocationRandomizationRange_IsValid;

	private static int SpawnLocationRandomizationRange_Offset;

	private static bool SpawnedPawns_IsValid;

	private static FFieldAddress SpawnedPawns_PropertyAddress;

	private static int SpawnedPawns_Offset;

	private TArrayReadOnlyMarshaler<APawn> SpawnedPawns_MarshalerCached;

	private static bool PendingDelayedSpawns_IsValid;

	private static FFieldAddress PendingDelayedSpawns_PropertyAddress;

	private static int PendingDelayedSpawns_Offset;

	private TArrayReadOnlyMarshaler<FPendingDelayedSpawn> PendingDelayedSpawns_MarshalerCached;

	private static bool CurrentSpawnSetIndex_IsValid;

	private static int CurrentSpawnSetIndex_Offset;

	private static bool CurrentSpawnSetName_IsValid;

	private static int CurrentSpawnSetName_Offset;

	private static bool OnAISpawned_IsValid;

	private static int OnAISpawned_Offset;

	private FFunctionalTestAISpawned OnAISpawned_DelegateCached;

	private static bool OnAllAISPawned_IsValid;

	private static int OnAllAISPawned_Offset;

	private FFunctionalTestEventSignature OnAllAISPawned_DelegateCached;

	private static bool WaitForNavMesh_IsValid;

	private static FFieldAddress WaitForNavMesh_PropertyAddress;

	private static int WaitForNavMesh_Offset;

	private static bool IsOneOfSpawnedPawns_IsValid;

	private static IntPtr IsOneOfSpawnedPawns_FunctionAddress;

	private static int IsOneOfSpawnedPawns_ParamsSize;

	private static bool IsOneOfSpawnedPawns_Actor_IsValid;

	private static FFieldAddress IsOneOfSpawnedPawns_Actor_PropertyAddress;

	private static int IsOneOfSpawnedPawns_Actor_Offset;

	private static bool IsOneOfSpawnedPawns_ReturnValue_IsValid;

	private static FFieldAddress IsOneOfSpawnedPawns_ReturnValue_PropertyAddress;

	private static int IsOneOfSpawnedPawns_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:SpawnLocationRandomizationRange")]
	protected float SpawnLocationRandomizationRange
	{
		get
		{
			CheckDestroyed();
			if (!SpawnLocationRandomizationRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:SpawnLocationRandomizationRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpawnLocationRandomizationRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnLocationRandomizationRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:SpawnLocationRandomizationRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpawnLocationRandomizationRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)10141895254606356uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:SpawnedPawns")]
	protected TArrayReadOnly<APawn> SpawnedPawns
	{
		get
		{
			CheckDestroyed();
			if (!SpawnedPawns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:SpawnedPawns");
				return null;
			}
			if (SpawnedPawns_MarshalerCached == null)
			{
				SpawnedPawns_MarshalerCached = new TArrayReadOnlyMarshaler<APawn>(1, SpawnedPawns_PropertyAddress, CachedMarshalingDelegates<APawn, UObjectMarshaler<APawn>>.FromNative, CachedMarshalingDelegates<APawn, UObjectMarshaler<APawn>>.ToNative);
			}
			return SpawnedPawns_MarshalerCached.FromNative(IntPtr.Add(base.Address, SpawnedPawns_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763732uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:PendingDelayedSpawns")]
	protected TArrayReadOnly<FPendingDelayedSpawn> PendingDelayedSpawns
	{
		get
		{
			CheckDestroyed();
			if (!PendingDelayedSpawns_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:PendingDelayedSpawns");
				return null;
			}
			if (PendingDelayedSpawns_MarshalerCached == null)
			{
				PendingDelayedSpawns_MarshalerCached = new TArrayReadOnlyMarshaler<FPendingDelayedSpawn>(1, PendingDelayedSpawns_PropertyAddress, CachedMarshalingDelegates<FPendingDelayedSpawn, FPendingDelayedSpawn>.FromNative, CachedMarshalingDelegates<FPendingDelayedSpawn, FPendingDelayedSpawn>.ToNative);
			}
			return PendingDelayedSpawns_MarshalerCached.FromNative(IntPtr.Add(base.Address, PendingDelayedSpawns_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:CurrentSpawnSetIndex")]
	protected int CurrentSpawnSetIndex
	{
		get
		{
			CheckDestroyed();
			if (!CurrentSpawnSetIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:CurrentSpawnSetIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurrentSpawnSetIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentSpawnSetIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:CurrentSpawnSetIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurrentSpawnSetIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267795161448980uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:CurrentSpawnSetName")]
	protected string CurrentSpawnSetName
	{
		get
		{
			CheckDestroyed();
			if (!CurrentSpawnSetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:CurrentSpawnSetName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CurrentSpawnSetName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentSpawnSetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:CurrentSpawnSetName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CurrentSpawnSetName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:OnAISpawned")]
	protected FFunctionalTestAISpawned OnAISpawned
	{
		get
		{
			CheckDestroyed();
			if (!OnAISpawned_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:OnAISpawned");
				return new FFunctionalTestAISpawned();
			}
			if (OnAISpawned_DelegateCached == null)
			{
				OnAISpawned_DelegateCached = new FFunctionalTestAISpawned();
				OnAISpawned_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAISpawned_Offset));
			}
			return OnAISpawned_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:OnAllAISPawned")]
	protected FFunctionalTestEventSignature OnAllAISPawned
	{
		get
		{
			CheckDestroyed();
			if (!OnAllAISPawned_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:OnAllAISPawned");
				return new FFunctionalTestEventSignature();
			}
			if (OnAllAISPawned_DelegateCached == null)
			{
				OnAllAISPawned_DelegateCached = new FFunctionalTestEventSignature();
				OnAllAISPawned_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAllAISPawned_Offset));
			}
			return OnAllAISPawned_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:bWaitForNavMesh")]
	protected bool WaitForNavMesh
	{
		get
		{
			CheckDestroyed();
			if (!WaitForNavMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:bWaitForNavMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WaitForNavMesh_Offset), 0, WaitForNavMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WaitForNavMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITestBase:bWaitForNavMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WaitForNavMesh_Offset), 0, WaitForNavMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITestBase:IsOneOfSpawnedPawns")]
	public unsafe bool IsOneOfSpawnedPawns(AActor Actor)
	{
		CheckDestroyed();
		if (!IsOneOfSpawnedPawns_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalAITestBase:IsOneOfSpawnedPawns");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOneOfSpawnedPawns_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOneOfSpawnedPawns_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsOneOfSpawnedPawns_Actor_Offset), 0, IsOneOfSpawnedPawns_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOneOfSpawnedPawns_FunctionAddress, intPtr, IsOneOfSpawnedPawns_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOneOfSpawnedPawns_ReturnValue_Offset), 0, IsOneOfSpawnedPawns_ReturnValue_PropertyAddress.Address);
	}

	static AFunctionalAITestBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AFunctionalAITestBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFunctionalAITestBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FunctionalTesting.FunctionalAITestBase");
		SpawnLocationRandomizationRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnLocationRandomizationRange");
		SpawnLocationRandomizationRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnLocationRandomizationRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnedPawns_PropertyAddress, intPtr, "SpawnedPawns");
		SpawnedPawns_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnedPawns");
		SpawnedPawns_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnedPawns", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PendingDelayedSpawns_PropertyAddress, intPtr, "PendingDelayedSpawns");
		PendingDelayedSpawns_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PendingDelayedSpawns");
		PendingDelayedSpawns_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PendingDelayedSpawns", Classes.FArrayProperty);
		CurrentSpawnSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentSpawnSetIndex");
		CurrentSpawnSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentSpawnSetIndex", Classes.FIntProperty);
		CurrentSpawnSetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentSpawnSetName");
		CurrentSpawnSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentSpawnSetName", Classes.FStrProperty);
		OnAISpawned_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAISpawned");
		OnAISpawned_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAISpawned", Classes.FMulticastDelegateProperty);
		OnAllAISPawned_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAllAISPawned");
		OnAllAISPawned_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAllAISPawned", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref WaitForNavMesh_PropertyAddress, intPtr, "bWaitForNavMesh");
		WaitForNavMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWaitForNavMesh");
		WaitForNavMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWaitForNavMesh", Classes.FBoolProperty);
		IsOneOfSpawnedPawns_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOneOfSpawnedPawns");
		IsOneOfSpawnedPawns_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOneOfSpawnedPawns_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOneOfSpawnedPawns_Actor_PropertyAddress, IsOneOfSpawnedPawns_FunctionAddress, "Actor");
		IsOneOfSpawnedPawns_Actor_Offset = NativeReflectionCached.GetPropertyOffset(IsOneOfSpawnedPawns_FunctionAddress, "Actor");
		IsOneOfSpawnedPawns_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOneOfSpawnedPawns_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOneOfSpawnedPawns_ReturnValue_PropertyAddress, IsOneOfSpawnedPawns_FunctionAddress, "ReturnValue");
		IsOneOfSpawnedPawns_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOneOfSpawnedPawns_FunctionAddress, "ReturnValue");
		IsOneOfSpawnedPawns_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOneOfSpawnedPawns_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOneOfSpawnedPawns_IsValid = IsOneOfSpawnedPawns_FunctionAddress != IntPtr.Zero && IsOneOfSpawnedPawns_Actor_IsValid && IsOneOfSpawnedPawns_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalAITestBase:IsOneOfSpawnedPawns", IsOneOfSpawnedPawns_IsValid);
	}
}
