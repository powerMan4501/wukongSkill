using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938532uL, Config = "game")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWWorldSettings", "b1", UnrealModuleType.Game)]
public class ABGWWorldSettings : AWorldSettings
{
	private static bool FBGWOnWorldCleanup_IsValid;

	private static int FBGWOnWorldCleanup_Offset;

	private FBGWOnWorldCleanup FBGWOnWorldCleanup_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGWWorldSettings:FBGWOnWorldCleanup")]
	public FBGWOnWorldCleanup FBGWOnWorldCleanup
	{
		get
		{
			CheckDestroyed();
			if (!FBGWOnWorldCleanup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWWorldSettings:FBGWOnWorldCleanup");
				return new FBGWOnWorldCleanup();
			}
			if (FBGWOnWorldCleanup_DelegateCached == null)
			{
				FBGWOnWorldCleanup_DelegateCached = new FBGWOnWorldCleanup();
				FBGWOnWorldCleanup_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBGWOnWorldCleanup_Offset));
			}
			return FBGWOnWorldCleanup_DelegateCached;
		}
	}

	static ABGWWorldSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWWorldSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWWorldSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWWorldSettings");
		FBGWOnWorldCleanup_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBGWOnWorldCleanup");
		FBGWOnWorldCleanup_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBGWOnWorldCleanup", Classes.FMulticastDelegateProperty);
	}
}
