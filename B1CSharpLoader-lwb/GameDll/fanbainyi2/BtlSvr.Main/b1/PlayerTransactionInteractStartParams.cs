using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PlayerTransactionInteractStartParams")]
public struct PlayerTransactionInteractStartParams
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.PlayerTransactionInteractStartParams:InteractTarget")]
	public AActor InteractTarget;

	private static int PlayerTransactionInteractStartParams_StructSize;

	private static int PlayerTransactionInteractStartParams_IsValid;

	private static bool InteractTarget_IsValid;

	private static int InteractTarget_Offset;

	public PlayerTransactionInteractStartParams Copy()
	{
		return this;
	}

	public static PlayerTransactionInteractStartParams FromNative(IntPtr nativeBuffer)
	{
		return new PlayerTransactionInteractStartParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, PlayerTransactionInteractStartParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static PlayerTransactionInteractStartParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new PlayerTransactionInteractStartParams(IntPtr.Add(nativeBuffer, arrayIndex * PlayerTransactionInteractStartParams_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, PlayerTransactionInteractStartParams value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PlayerTransactionInteractStartParams_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PlayerTransactionInteractStartParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PlayerTransactionInteractStartParams");
		}
		else
		{
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, InteractTarget_Offset), InteractTarget);
		}
	}

	public PlayerTransactionInteractStartParams(IntPtr nativeStruct)
	{
		if (PlayerTransactionInteractStartParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PlayerTransactionInteractStartParams");
			InteractTarget = null;
		}
		else
		{
			InteractTarget = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, InteractTarget_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PlayerTransactionInteractStartParams");
		PlayerTransactionInteractStartParams_StructSize = NativeReflection.GetStructSize(intPtr);
		InteractTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractTarget");
		InteractTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractTarget", Classes.FObjectProperty);
		PlayerTransactionInteractStartParams_IsValid = ((intPtr != IntPtr.Zero && InteractTarget_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PlayerTransactionInteractStartParams", (byte)PlayerTransactionInteractStartParams_IsValid != 0);
	}

	static PlayerTransactionInteractStartParams()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PlayerTransactionInteractStartParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PlayerTransactionInteractStartParams));
	}
}
