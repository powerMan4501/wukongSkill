using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemEOS;

[UClass(Flags = (ClassFlags)810549414uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings", "OnlineSubsystemEOS", UnrealModuleType.EnginePlugin)]
public class UEOSSettings : URuntimeOptionsBase
{
	private static bool CacheDir_IsValid;

	private static int CacheDir_Offset;

	private static bool DefaultArtifactName_IsValid;

	private static int DefaultArtifactName_Offset;

	private static bool TickBudgetInMilliseconds_IsValid;

	private static int TickBudgetInMilliseconds_Offset;

	private static bool EnableOverlay_IsValid;

	private static FFieldAddress EnableOverlay_PropertyAddress;

	private static int EnableOverlay_Offset;

	private static bool EnableSocialOverlay_IsValid;

	private static FFieldAddress EnableSocialOverlay_PropertyAddress;

	private static int EnableSocialOverlay_Offset;

	private static bool ShouldEnforceBeingLaunchedByEGS_IsValid;

	private static FFieldAddress ShouldEnforceBeingLaunchedByEGS_PropertyAddress;

	private static int ShouldEnforceBeingLaunchedByEGS_Offset;

	private static bool TitleStorageTags_IsValid;

	private static FFieldAddress TitleStorageTags_PropertyAddress;

	private static int TitleStorageTags_Offset;

	private TArrayReadOnlyMarshaler<string> TitleStorageTags_MarshalerCached;

	private static bool TitleStorageReadChunkLength_IsValid;

	private static int TitleStorageReadChunkLength_Offset;

	private static bool Artifacts_IsValid;

	private static FFieldAddress Artifacts_PropertyAddress;

	private static int Artifacts_Offset;

	private TArrayReadOnlyMarshaler<FArtifactSettings> Artifacts_MarshalerCached;

	private static bool UseEAS_IsValid;

	private static FFieldAddress UseEAS_PropertyAddress;

	private static int UseEAS_Offset;

	private static bool UseEOSConnect_IsValid;

	private static FFieldAddress UseEOSConnect_PropertyAddress;

	private static int UseEOSConnect_Offset;

	private static bool MirrorStatsToEOS_IsValid;

	private static FFieldAddress MirrorStatsToEOS_PropertyAddress;

	private static int MirrorStatsToEOS_Offset;

	private static bool MirrorAchievementsToEOS_IsValid;

	private static FFieldAddress MirrorAchievementsToEOS_PropertyAddress;

	private static int MirrorAchievementsToEOS_Offset;

	private static bool UseEOSSessions_IsValid;

	private static FFieldAddress UseEOSSessions_PropertyAddress;

	private static int UseEOSSessions_Offset;

	private static bool MirrorPresenceToEAS_IsValid;

	private static FFieldAddress MirrorPresenceToEAS_PropertyAddress;

	private static int MirrorPresenceToEAS_Offset;

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:CacheDir")]
	public string CacheDir
	{
		get
		{
			CheckDestroyed();
			if (!CacheDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:CacheDir");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CacheDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:CacheDir");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CacheDir_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072661uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:DefaultArtifactName")]
	public string DefaultArtifactName
	{
		get
		{
			CheckDestroyed();
			if (!DefaultArtifactName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:DefaultArtifactName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DefaultArtifactName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultArtifactName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:DefaultArtifactName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DefaultArtifactName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:TickBudgetInMilliseconds")]
	public int TickBudgetInMilliseconds
	{
		get
		{
			CheckDestroyed();
			if (!TickBudgetInMilliseconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:TickBudgetInMilliseconds");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TickBudgetInMilliseconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickBudgetInMilliseconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:TickBudgetInMilliseconds");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TickBudgetInMilliseconds_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bEnableOverlay")]
	public bool EnableOverlay
	{
		get
		{
			CheckDestroyed();
			if (!EnableOverlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bEnableOverlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableOverlay_Offset), 0, EnableOverlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableOverlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bEnableOverlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableOverlay_Offset), 0, EnableOverlay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bEnableSocialOverlay")]
	public bool EnableSocialOverlay
	{
		get
		{
			CheckDestroyed();
			if (!EnableSocialOverlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bEnableSocialOverlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSocialOverlay_Offset), 0, EnableSocialOverlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSocialOverlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bEnableSocialOverlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSocialOverlay_Offset), 0, EnableSocialOverlay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bShouldEnforceBeingLaunchedByEGS")]
	public bool ShouldEnforceBeingLaunchedByEGS
	{
		get
		{
			CheckDestroyed();
			if (!ShouldEnforceBeingLaunchedByEGS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bShouldEnforceBeingLaunchedByEGS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldEnforceBeingLaunchedByEGS_Offset), 0, ShouldEnforceBeingLaunchedByEGS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldEnforceBeingLaunchedByEGS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bShouldEnforceBeingLaunchedByEGS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldEnforceBeingLaunchedByEGS_Offset), 0, ShouldEnforceBeingLaunchedByEGS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627387413uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:TitleStorageTags")]
	public TArrayReadOnly<string> TitleStorageTags
	{
		get
		{
			CheckDestroyed();
			if (!TitleStorageTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:TitleStorageTags");
				return null;
			}
			if (TitleStorageTags_MarshalerCached == null)
			{
				TitleStorageTags_MarshalerCached = new TArrayReadOnlyMarshaler<string>(1, TitleStorageTags_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return TitleStorageTags_MarshalerCached.FromNative(IntPtr.Add(base.Address, TitleStorageTags_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:TitleStorageReadChunkLength")]
	public int TitleStorageReadChunkLength
	{
		get
		{
			CheckDestroyed();
			if (!TitleStorageReadChunkLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:TitleStorageReadChunkLength");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TitleStorageReadChunkLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TitleStorageReadChunkLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:TitleStorageReadChunkLength");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TitleStorageReadChunkLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627387413uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:Artifacts")]
	public TArrayReadOnly<FArtifactSettings> Artifacts
	{
		get
		{
			CheckDestroyed();
			if (!Artifacts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:Artifacts");
				return null;
			}
			if (Artifacts_MarshalerCached == null)
			{
				Artifacts_MarshalerCached = new TArrayReadOnlyMarshaler<FArtifactSettings>(1, Artifacts_PropertyAddress, CachedMarshalingDelegates<FArtifactSettings, FArtifactSettings>.FromNative, CachedMarshalingDelegates<FArtifactSettings, FArtifactSettings>.ToNative);
			}
			return Artifacts_MarshalerCached.FromNative(IntPtr.Add(base.Address, Artifacts_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bUseEAS")]
	public bool UseEAS
	{
		get
		{
			CheckDestroyed();
			if (!UseEAS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bUseEAS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseEAS_Offset), 0, UseEAS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseEAS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bUseEAS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseEAS_Offset), 0, UseEAS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bUseEOSConnect")]
	public bool UseEOSConnect
	{
		get
		{
			CheckDestroyed();
			if (!UseEOSConnect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bUseEOSConnect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseEOSConnect_Offset), 0, UseEOSConnect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseEOSConnect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bUseEOSConnect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseEOSConnect_Offset), 0, UseEOSConnect_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorStatsToEOS")]
	public bool MirrorStatsToEOS
	{
		get
		{
			CheckDestroyed();
			if (!MirrorStatsToEOS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorStatsToEOS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MirrorStatsToEOS_Offset), 0, MirrorStatsToEOS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MirrorStatsToEOS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorStatsToEOS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MirrorStatsToEOS_Offset), 0, MirrorStatsToEOS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorAchievementsToEOS")]
	public bool MirrorAchievementsToEOS
	{
		get
		{
			CheckDestroyed();
			if (!MirrorAchievementsToEOS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorAchievementsToEOS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MirrorAchievementsToEOS_Offset), 0, MirrorAchievementsToEOS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MirrorAchievementsToEOS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorAchievementsToEOS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MirrorAchievementsToEOS_Offset), 0, MirrorAchievementsToEOS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bUseEOSSessions")]
	public bool UseEOSSessions
	{
		get
		{
			CheckDestroyed();
			if (!UseEOSSessions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bUseEOSSessions");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseEOSSessions_Offset), 0, UseEOSSessions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseEOSSessions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bUseEOSSessions");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseEOSSessions_Offset), 0, UseEOSSessions_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291221uL)]
	[UMetaPath("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorPresenceToEAS")]
	public bool MirrorPresenceToEAS
	{
		get
		{
			CheckDestroyed();
			if (!MirrorPresenceToEAS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorPresenceToEAS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MirrorPresenceToEAS_Offset), 0, MirrorPresenceToEAS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MirrorPresenceToEAS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OnlineSubsystemEOS.EOSSettings:bMirrorPresenceToEAS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MirrorPresenceToEAS_Offset), 0, MirrorPresenceToEAS_PropertyAddress.Address, value);
			}
		}
	}

	static UEOSSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEOSSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEOSSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/OnlineSubsystemEOS.EOSSettings");
		CacheDir_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CacheDir");
		CacheDir_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CacheDir", Classes.FStrProperty);
		DefaultArtifactName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultArtifactName");
		DefaultArtifactName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultArtifactName", Classes.FStrProperty);
		TickBudgetInMilliseconds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TickBudgetInMilliseconds");
		TickBudgetInMilliseconds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TickBudgetInMilliseconds", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableOverlay_PropertyAddress, unrealStruct, "bEnableOverlay");
		EnableOverlay_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableOverlay");
		EnableOverlay_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableOverlay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSocialOverlay_PropertyAddress, unrealStruct, "bEnableSocialOverlay");
		EnableSocialOverlay_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableSocialOverlay");
		EnableSocialOverlay_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableSocialOverlay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldEnforceBeingLaunchedByEGS_PropertyAddress, unrealStruct, "bShouldEnforceBeingLaunchedByEGS");
		ShouldEnforceBeingLaunchedByEGS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bShouldEnforceBeingLaunchedByEGS");
		ShouldEnforceBeingLaunchedByEGS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bShouldEnforceBeingLaunchedByEGS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TitleStorageTags_PropertyAddress, unrealStruct, "TitleStorageTags");
		TitleStorageTags_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TitleStorageTags");
		TitleStorageTags_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TitleStorageTags", Classes.FArrayProperty);
		TitleStorageReadChunkLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TitleStorageReadChunkLength");
		TitleStorageReadChunkLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TitleStorageReadChunkLength", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Artifacts_PropertyAddress, unrealStruct, "Artifacts");
		Artifacts_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Artifacts");
		Artifacts_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Artifacts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseEAS_PropertyAddress, unrealStruct, "bUseEAS");
		UseEAS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseEAS");
		UseEAS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseEAS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseEOSConnect_PropertyAddress, unrealStruct, "bUseEOSConnect");
		UseEOSConnect_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseEOSConnect");
		UseEOSConnect_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseEOSConnect", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorStatsToEOS_PropertyAddress, unrealStruct, "bMirrorStatsToEOS");
		MirrorStatsToEOS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMirrorStatsToEOS");
		MirrorStatsToEOS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMirrorStatsToEOS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorAchievementsToEOS_PropertyAddress, unrealStruct, "bMirrorAchievementsToEOS");
		MirrorAchievementsToEOS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMirrorAchievementsToEOS");
		MirrorAchievementsToEOS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMirrorAchievementsToEOS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseEOSSessions_PropertyAddress, unrealStruct, "bUseEOSSessions");
		UseEOSSessions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseEOSSessions");
		UseEOSSessions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseEOSSessions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorPresenceToEAS_PropertyAddress, unrealStruct, "bMirrorPresenceToEAS");
		MirrorPresenceToEAS_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMirrorPresenceToEAS");
		MirrorPresenceToEAS_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMirrorPresenceToEAS", Classes.FBoolProperty);
	}
}
