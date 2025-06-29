using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_PlayerRebirth")]
public struct TeleportParam_PlayerRebirth
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_PlayerRebirth:LevelId")]
	public int LevelId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_PlayerRebirth:TeleportPointName")]
	public FName TeleportPointName;

	private static int TeleportParam_PlayerRebirth_StructSize;

	public TeleportParam_PlayerRebirth Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_PlayerRebirth");
		TeleportParam_PlayerRebirth_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(TeleportParam_PlayerRebirth));
	}

	static TeleportParam_PlayerRebirth()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_PlayerRebirth)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_PlayerRebirth));
	}
}
