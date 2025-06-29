using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ActorAttachConfig")]
public struct FActorAttachConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ActorAttachConfig:AttachBone")]
	public string AttachBone;

	private static int ActorAttachConfig_StructSize;

	private static int ActorAttachConfig_IsValid;

	private static bool AttachBone_IsValid;

	private static int AttachBone_Offset;

	public FActorAttachConfig Copy()
	{
		return this;
	}

	public static FActorAttachConfig FromNative(IntPtr nativeBuffer)
	{
		return new FActorAttachConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorAttachConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorAttachConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorAttachConfig(IntPtr.Add(nativeBuffer, arrayIndex * ActorAttachConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorAttachConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ActorAttachConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ActorAttachConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ActorAttachConfig");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachBone_Offset), AttachBone);
		}
	}

	public FActorAttachConfig(IntPtr nativeStruct)
	{
		if (ActorAttachConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ActorAttachConfig");
			AttachBone = null;
		}
		else
		{
			AttachBone = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachBone_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ActorAttachConfig");
		ActorAttachConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AttachBone_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachBone");
		AttachBone_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachBone", Classes.FStrProperty);
		ActorAttachConfig_IsValid = ((intPtr != IntPtr.Zero && AttachBone_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ActorAttachConfig", (byte)ActorAttachConfig_IsValid != 0);
	}

	static FActorAttachConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FActorAttachConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorAttachConfig));
	}
}
