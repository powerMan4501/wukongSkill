using System;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.GSEQG_SimpleTeleport", "b1", UnrealModuleType.Game)]
public class UGSEQG_SimpleTeleport : UEnvQueryGenerator
{
	private static bool EnableNavigationTrace_IsValid;

	private static FFieldAddress EnableNavigationTrace_PropertyAddress;

	private static int EnableNavigationTrace_Offset;

	private static bool EnableCapsuleTrace_IsValid;

	private static FFieldAddress EnableCapsuleTrace_PropertyAddress;

	private static int EnableCapsuleTrace_Offset;

	private static bool EnableNavigationProjection_IsValid;

	private static FFieldAddress EnableNavigationProjection_PropertyAddress;

	private static int EnableNavigationProjection_Offset;

	private static bool CapsuleHalfHeightAsVerticalOffset_IsValid;

	private static FFieldAddress CapsuleHalfHeightAsVerticalOffset_PropertyAddress;

	private static int CapsuleHalfHeightAsVerticalOffset_Offset;

	private static bool EnableCapsuleProjection_IsValid;

	private static FFieldAddress EnableCapsuleProjection_PropertyAddress;

	private static int EnableCapsuleProjection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_SimpleTeleport:bEnableNavigationTrace")]
	public bool EnableNavigationTrace
	{
		get
		{
			CheckDestroyed();
			if (!EnableNavigationTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableNavigationTrace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableNavigationTrace_Offset), 0, EnableNavigationTrace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableNavigationTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableNavigationTrace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableNavigationTrace_Offset), 0, EnableNavigationTrace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_SimpleTeleport:bEnableCapsuleTrace")]
	public bool EnableCapsuleTrace
	{
		get
		{
			CheckDestroyed();
			if (!EnableCapsuleTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableCapsuleTrace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCapsuleTrace_Offset), 0, EnableCapsuleTrace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCapsuleTrace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableCapsuleTrace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCapsuleTrace_Offset), 0, EnableCapsuleTrace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_SimpleTeleport:bEnableNavigationProjection")]
	public bool EnableNavigationProjection
	{
		get
		{
			CheckDestroyed();
			if (!EnableNavigationProjection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableNavigationProjection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableNavigationProjection_Offset), 0, EnableNavigationProjection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableNavigationProjection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableNavigationProjection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableNavigationProjection_Offset), 0, EnableNavigationProjection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_SimpleTeleport:bCapsuleHalfHeightAsVerticalOffset")]
	public bool CapsuleHalfHeightAsVerticalOffset
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleHalfHeightAsVerticalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bCapsuleHalfHeightAsVerticalOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CapsuleHalfHeightAsVerticalOffset_Offset), 0, CapsuleHalfHeightAsVerticalOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleHalfHeightAsVerticalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bCapsuleHalfHeightAsVerticalOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CapsuleHalfHeightAsVerticalOffset_Offset), 0, CapsuleHalfHeightAsVerticalOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_SimpleTeleport:bEnableCapsuleProjection")]
	public bool EnableCapsuleProjection
	{
		get
		{
			CheckDestroyed();
			if (!EnableCapsuleProjection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableCapsuleProjection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCapsuleProjection_Offset), 0, EnableCapsuleProjection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCapsuleProjection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_SimpleTeleport:bEnableCapsuleProjection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCapsuleProjection_Offset), 0, EnableCapsuleProjection_PropertyAddress.Address, value);
			}
		}
	}

	static UGSEQG_SimpleTeleport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEQG_SimpleTeleport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEQG_SimpleTeleport));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.GSEQG_SimpleTeleport");
		NativeReflectionCached.GetPropertyRef(ref EnableNavigationTrace_PropertyAddress, unrealStruct, "bEnableNavigationTrace");
		EnableNavigationTrace_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableNavigationTrace");
		EnableNavigationTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableNavigationTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCapsuleTrace_PropertyAddress, unrealStruct, "bEnableCapsuleTrace");
		EnableCapsuleTrace_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableCapsuleTrace");
		EnableCapsuleTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableCapsuleTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNavigationProjection_PropertyAddress, unrealStruct, "bEnableNavigationProjection");
		EnableNavigationProjection_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableNavigationProjection");
		EnableNavigationProjection_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableNavigationProjection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CapsuleHalfHeightAsVerticalOffset_PropertyAddress, unrealStruct, "bCapsuleHalfHeightAsVerticalOffset");
		CapsuleHalfHeightAsVerticalOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCapsuleHalfHeightAsVerticalOffset");
		CapsuleHalfHeightAsVerticalOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCapsuleHalfHeightAsVerticalOffset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCapsuleProjection_PropertyAddress, unrealStruct, "bEnableCapsuleProjection");
		EnableCapsuleProjection_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableCapsuleProjection");
		EnableCapsuleProjection_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableCapsuleProjection", Classes.FBoolProperty);
	}
}
