using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_TeleportNamedPoint")]
public struct TeleportParam_TeleportNamedPoint
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_TeleportNamedPoint:LevelId")]
	public int LevelId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_TeleportNamedPoint:TeleportPointName")]
	public FName TeleportPointName;

	private static int TeleportParam_TeleportNamedPoint_StructSize;

	public TeleportParam_TeleportNamedPoint Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_TeleportNamedPoint");
		TeleportParam_TeleportNamedPoint_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(TeleportParam_TeleportNamedPoint));
	}

	static TeleportParam_TeleportNamedPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_TeleportNamedPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_TeleportNamedPoint));
	}
}
