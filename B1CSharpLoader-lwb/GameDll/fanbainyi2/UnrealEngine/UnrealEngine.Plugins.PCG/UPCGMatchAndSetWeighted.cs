using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGMatchAndSetWeighted", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMatchAndSetWeighted : UPCGMatchAndSetBase
{
	private static bool Entries_IsValid;

	private static FFieldAddress Entries_PropertyAddress;

	private static int Entries_Offset;

	private TArrayReadWriteMarshaler<FPCGMatchAndSetWeightedEntry> Entries_MarshalerCached;

	private static bool ShouldMutateSeed_IsValid;

	private static FFieldAddress ShouldMutateSeed_PropertyAddress;

	private static int ShouldMutateSeed_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeighted:Entries")]
	public TArrayReadWrite<FPCGMatchAndSetWeightedEntry> Entries
	{
		get
		{
			CheckDestroyed();
			if (!Entries_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeighted:Entries");
				return null;
			}
			if (Entries_MarshalerCached == null)
			{
				Entries_MarshalerCached = new TArrayReadWriteMarshaler<FPCGMatchAndSetWeightedEntry>(1, Entries_PropertyAddress, CachedMarshalingDelegates<FPCGMatchAndSetWeightedEntry, FPCGMatchAndSetWeightedEntry>.FromNative, CachedMarshalingDelegates<FPCGMatchAndSetWeightedEntry, FPCGMatchAndSetWeightedEntry>.ToNative);
			}
			return Entries_MarshalerCached.FromNative(IntPtr.Add(base.Address, Entries_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeighted:bShouldMutateSeed")]
	public bool ShouldMutateSeed
	{
		get
		{
			CheckDestroyed();
			if (!ShouldMutateSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeighted:bShouldMutateSeed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldMutateSeed_Offset), 0, ShouldMutateSeed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldMutateSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMatchAndSetWeighted:bShouldMutateSeed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldMutateSeed_Offset), 0, ShouldMutateSeed_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGMatchAndSetWeighted()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMatchAndSetWeighted)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMatchAndSetWeighted));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMatchAndSetWeighted");
		NativeReflectionCached.GetPropertyRef(ref Entries_PropertyAddress, unrealStruct, "Entries");
		Entries_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Entries");
		Entries_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Entries", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldMutateSeed_PropertyAddress, unrealStruct, "bShouldMutateSeed");
		ShouldMutateSeed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bShouldMutateSeed");
		ShouldMutateSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bShouldMutateSeed", Classes.FBoolProperty);
	}
}
