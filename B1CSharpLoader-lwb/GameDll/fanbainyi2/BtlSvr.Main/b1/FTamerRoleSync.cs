using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TamerRoleSync")]
public struct FTamerRoleSync
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerRoleSync:Guid")]
	public string Guid;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerRoleSync:SyncState")]
	public EClientTamerInitNetState SyncState;

	private static int TamerRoleSync_StructSize;

	private static int TamerRoleSync_IsValid;

	private static bool Guid_IsValid;

	private static int Guid_Offset;

	private static bool SyncState_IsValid;

	private static int SyncState_Offset;

	private static FFieldAddress SyncState_PropertyAddress;

	public FTamerRoleSync Copy()
	{
		return this;
	}

	public static FTamerRoleSync FromNative(IntPtr nativeBuffer)
	{
		return new FTamerRoleSync(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTamerRoleSync value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTamerRoleSync FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTamerRoleSync(IntPtr.Add(nativeBuffer, arrayIndex * TamerRoleSync_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTamerRoleSync value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TamerRoleSync_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TamerRoleSync_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerRoleSync");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Guid_Offset), Guid);
		EnumMarshaler<EClientTamerInitNetState>.ToNative(IntPtr.Add(nativeStruct, SyncState_Offset), 0, SyncState_PropertyAddress.Address, SyncState);
	}

	public FTamerRoleSync(IntPtr nativeStruct)
	{
		if (TamerRoleSync_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerRoleSync");
			Guid = null;
			SyncState = EClientTamerInitNetState.Dead;
		}
		else
		{
			Guid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Guid_Offset));
			SyncState = EnumMarshaler<EClientTamerInitNetState>.FromNative(IntPtr.Add(nativeStruct, SyncState_Offset), 0, SyncState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TamerRoleSync");
		TamerRoleSync_StructSize = NativeReflection.GetStructSize(intPtr);
		Guid_Offset = NativeReflection.GetPropertyOffset(intPtr, "Guid");
		Guid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Guid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref SyncState_PropertyAddress, intPtr, "SyncState");
		SyncState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SyncState");
		SyncState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SyncState", Classes.FEnumProperty);
		TamerRoleSync_IsValid = ((intPtr != IntPtr.Zero && Guid_IsValid && SyncState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TamerRoleSync", (byte)TamerRoleSync_IsValid != 0);
	}

	static FTamerRoleSync()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTamerRoleSync)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerRoleSync));
	}
}
