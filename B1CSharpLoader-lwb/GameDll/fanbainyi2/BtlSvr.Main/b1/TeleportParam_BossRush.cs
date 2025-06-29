using System;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_BossRush")]
public struct TeleportParam_BossRush
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_BossRush:LevelId")]
	public int LevelId;

	public Action TeleportFinishCallback;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_BossRush:LoadingScreenType")]
	public EGSLoadingScreenType LoadingScreenType;

	private static int TeleportParam_BossRush_StructSize;

	private static int TeleportParam_BossRush_IsValid;

	private static bool LevelId_IsValid;

	private static int LevelId_Offset;

	private static bool LoadingScreenType_IsValid;

	private static int LoadingScreenType_Offset;

	private static FFieldAddress LoadingScreenType_PropertyAddress;

	public TeleportParam_BossRush Copy()
	{
		return this;
	}

	public static TeleportParam_BossRush FromNative(IntPtr nativeBuffer)
	{
		return new TeleportParam_BossRush(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TeleportParam_BossRush value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TeleportParam_BossRush FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TeleportParam_BossRush(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_BossRush_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TeleportParam_BossRush value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_BossRush_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TeleportParam_BossRush_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_BossRush");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelId_Offset), LevelId);
		EnumMarshaler<EGSLoadingScreenType>.ToNative(IntPtr.Add(nativeStruct, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address, LoadingScreenType);
	}

	public TeleportParam_BossRush(IntPtr nativeStruct)
	{
		if (TeleportParam_BossRush_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_BossRush");
			LevelId = 0;
			LoadingScreenType = EGSLoadingScreenType.Unknown;
		}
		else
		{
			LevelId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelId_Offset));
			LoadingScreenType = EnumMarshaler<EGSLoadingScreenType>.FromNative(IntPtr.Add(nativeStruct, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_BossRush");
		TeleportParam_BossRush_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelId_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelId");
		LevelId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref LoadingScreenType_PropertyAddress, intPtr, "LoadingScreenType");
		LoadingScreenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoadingScreenType");
		LoadingScreenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoadingScreenType", Classes.FEnumProperty);
		TeleportParam_BossRush_IsValid = ((intPtr != IntPtr.Zero && LevelId_IsValid && LoadingScreenType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TeleportParam_BossRush", (byte)TeleportParam_BossRush_IsValid != 0);
	}

	static TeleportParam_BossRush()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_BossRush)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_BossRush));
	}
}
