using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.FunctionalAITest", "FunctionalTesting", UnrealModuleType.Engine)]
public class AFunctionalAITest : AFunctionalAITestBase
{
	private static bool SpawnSets_IsValid;

	private static FFieldAddress SpawnSets_PropertyAddress;

	private static int SpawnSets_Offset;

	private TArrayReadOnlyMarshaler<FAITestSpawnSet> SpawnSets_MarshalerCached;

	[UProperty(Flags = (PropFlags)9015995347763733uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalAITest:SpawnSets")]
	protected TArrayReadOnly<FAITestSpawnSet> SpawnSets
	{
		get
		{
			CheckDestroyed();
			if (!SpawnSets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalAITest:SpawnSets");
				return null;
			}
			if (SpawnSets_MarshalerCached == null)
			{
				SpawnSets_MarshalerCached = new TArrayReadOnlyMarshaler<FAITestSpawnSet>(1, SpawnSets_PropertyAddress, CachedMarshalingDelegates<FAITestSpawnSet, FAITestSpawnSet>.FromNative, CachedMarshalingDelegates<FAITestSpawnSet, FAITestSpawnSet>.ToNative);
			}
			return SpawnSets_MarshalerCached.FromNative(IntPtr.Add(base.Address, SpawnSets_Offset));
		}
	}

	static AFunctionalAITest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AFunctionalAITest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFunctionalAITest));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/FunctionalTesting.FunctionalAITest");
		NativeReflectionCached.GetPropertyRef(ref SpawnSets_PropertyAddress, unrealStruct, "SpawnSets");
		SpawnSets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpawnSets");
		SpawnSets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpawnSets", Classes.FArrayProperty);
	}
}
