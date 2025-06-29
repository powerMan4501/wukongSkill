using System;
using b1.Plugins.AsyncLoadingScreen;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_Dream")]
public struct TeleportParam_Dream
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_Dream:LevelId")]
	public int LevelId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_Dream:TeleportPointName")]
	public FName TeleportPointName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_Dream:RebirthPointId")]
	public int RebirthPointId;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_Dream:DontResetPlayerState")]
	public bool DontResetPlayerState;

	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_Dream:LoadingScreenType")]
	public EGSLoadingScreenType LoadingScreenType;

	private static int TeleportParam_Dream_StructSize;

	private static int TeleportParam_Dream_IsValid;

	private static bool LevelId_IsValid;

	private static int LevelId_Offset;

	private static bool TeleportPointName_IsValid;

	private static int TeleportPointName_Offset;

	private static bool RebirthPointId_IsValid;

	private static int RebirthPointId_Offset;

	private static bool DontResetPlayerState_IsValid;

	private static int DontResetPlayerState_Offset;

	private static FFieldAddress DontResetPlayerState_PropertyAddress;

	private static bool LoadingScreenType_IsValid;

	private static int LoadingScreenType_Offset;

	private static FFieldAddress LoadingScreenType_PropertyAddress;

	public TeleportParam_Dream Copy()
	{
		return this;
	}

	public static TeleportParam_Dream FromNative(IntPtr nativeBuffer)
	{
		return new TeleportParam_Dream(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TeleportParam_Dream value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TeleportParam_Dream FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TeleportParam_Dream(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_Dream_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TeleportParam_Dream value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_Dream_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TeleportParam_Dream_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_Dream");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelId_Offset), LevelId);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TeleportPointName_Offset), TeleportPointName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RebirthPointId_Offset), RebirthPointId);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DontResetPlayerState_Offset), 0, DontResetPlayerState_PropertyAddress.Address, DontResetPlayerState);
		EnumMarshaler<EGSLoadingScreenType>.ToNative(IntPtr.Add(nativeStruct, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address, LoadingScreenType);
	}

	public TeleportParam_Dream(IntPtr nativeStruct)
	{
		if (TeleportParam_Dream_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_Dream");
			LevelId = 0;
			TeleportPointName = default(FName);
			RebirthPointId = 0;
			DontResetPlayerState = false;
			LoadingScreenType = EGSLoadingScreenType.Unknown;
		}
		else
		{
			LevelId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelId_Offset));
			TeleportPointName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TeleportPointName_Offset));
			RebirthPointId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RebirthPointId_Offset));
			DontResetPlayerState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DontResetPlayerState_Offset), 0, DontResetPlayerState_PropertyAddress.Address);
			LoadingScreenType = EnumMarshaler<EGSLoadingScreenType>.FromNative(IntPtr.Add(nativeStruct, LoadingScreenType_Offset), 0, LoadingScreenType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_Dream");
		TeleportParam_Dream_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelId_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelId");
		LevelId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelId", Classes.FIntProperty);
		TeleportPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportPointName");
		TeleportPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportPointName", Classes.FNameProperty);
		RebirthPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthPointId");
		RebirthPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthPointId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DontResetPlayerState_PropertyAddress, intPtr, "DontResetPlayerState");
		DontResetPlayerState_Offset = NativeReflection.GetPropertyOffset(intPtr, "DontResetPlayerState");
		DontResetPlayerState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DontResetPlayerState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LoadingScreenType_PropertyAddress, intPtr, "LoadingScreenType");
		LoadingScreenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoadingScreenType");
		LoadingScreenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoadingScreenType", Classes.FEnumProperty);
		TeleportParam_Dream_IsValid = ((intPtr != IntPtr.Zero && LevelId_IsValid && TeleportPointName_IsValid && RebirthPointId_IsValid && DontResetPlayerState_IsValid && LoadingScreenType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TeleportParam_Dream", (byte)TeleportParam_Dream_IsValid != 0);
	}

	static TeleportParam_Dream()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_Dream)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_Dream));
	}
}
