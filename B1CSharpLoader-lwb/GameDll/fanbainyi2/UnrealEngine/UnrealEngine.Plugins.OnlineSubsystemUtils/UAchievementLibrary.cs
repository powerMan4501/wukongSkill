using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public class UAchievementLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetCachedAchievementProgress_IsValid;

	private static IntPtr GetCachedAchievementProgress_FunctionAddress;

	private static int GetCachedAchievementProgress_ParamsSize;

	private static bool GetCachedAchievementProgress_WorldContextObject_IsValid;

	private static FFieldAddress GetCachedAchievementProgress_WorldContextObject_PropertyAddress;

	private static int GetCachedAchievementProgress_WorldContextObject_Offset;

	private static bool GetCachedAchievementProgress_PlayerController_IsValid;

	private static FFieldAddress GetCachedAchievementProgress_PlayerController_PropertyAddress;

	private static int GetCachedAchievementProgress_PlayerController_Offset;

	private static bool GetCachedAchievementProgress_AchievementID_IsValid;

	private static FFieldAddress GetCachedAchievementProgress_AchievementID_PropertyAddress;

	private static int GetCachedAchievementProgress_AchievementID_Offset;

	private static bool GetCachedAchievementProgress_bFoundID_IsValid;

	private static FFieldAddress GetCachedAchievementProgress_bFoundID_PropertyAddress;

	private static int GetCachedAchievementProgress_bFoundID_Offset;

	private static bool GetCachedAchievementProgress_Progress_IsValid;

	private static FFieldAddress GetCachedAchievementProgress_Progress_PropertyAddress;

	private static int GetCachedAchievementProgress_Progress_Offset;

	private static bool GetCachedAchievementDescription_IsValid;

	private static IntPtr GetCachedAchievementDescription_FunctionAddress;

	private static int GetCachedAchievementDescription_ParamsSize;

	private static bool GetCachedAchievementDescription_WorldContextObject_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_WorldContextObject_PropertyAddress;

	private static int GetCachedAchievementDescription_WorldContextObject_Offset;

	private static bool GetCachedAchievementDescription_PlayerController_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_PlayerController_PropertyAddress;

	private static int GetCachedAchievementDescription_PlayerController_Offset;

	private static bool GetCachedAchievementDescription_AchievementID_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_AchievementID_PropertyAddress;

	private static int GetCachedAchievementDescription_AchievementID_Offset;

	private static bool GetCachedAchievementDescription_bFoundID_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_bFoundID_PropertyAddress;

	private static int GetCachedAchievementDescription_bFoundID_Offset;

	private static bool GetCachedAchievementDescription_Title_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_Title_PropertyAddress;

	private static int GetCachedAchievementDescription_Title_Offset;

	private static bool GetCachedAchievementDescription_LockedDescription_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_LockedDescription_PropertyAddress;

	private static int GetCachedAchievementDescription_LockedDescription_Offset;

	private static bool GetCachedAchievementDescription_UnlockedDescription_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_UnlockedDescription_PropertyAddress;

	private static int GetCachedAchievementDescription_UnlockedDescription_Offset;

	private static bool GetCachedAchievementDescription_bHidden_IsValid;

	private static FFieldAddress GetCachedAchievementDescription_bHidden_PropertyAddress;

	private static int GetCachedAchievementDescription_bHidden_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary:GetCachedAchievementProgress")]
	public unsafe static void GetCachedAchievementProgress(UObject WorldContextObject, APlayerController PlayerController, FName AchievementID, out bool bFoundID, out float Progress)
	{
		if (!GetCachedAchievementProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary:GetCachedAchievementProgress");
			bFoundID = false;
			Progress = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCachedAchievementProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCachedAchievementProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCachedAchievementProgress_WorldContextObject_Offset), 0, GetCachedAchievementProgress_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetCachedAchievementProgress_PlayerController_Offset), 0, GetCachedAchievementProgress_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCachedAchievementProgress_AchievementID_Offset), 0, GetCachedAchievementProgress_AchievementID_PropertyAddress.Address, AchievementID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCachedAchievementProgress_FunctionAddress, intPtr, GetCachedAchievementProgress_ParamsSize);
		bFoundID = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedAchievementProgress_bFoundID_Offset), 0, GetCachedAchievementProgress_bFoundID_PropertyAddress.Address);
		Progress = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCachedAchievementProgress_Progress_Offset), 0, GetCachedAchievementProgress_Progress_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary:GetCachedAchievementDescription")]
	public unsafe static void GetCachedAchievementDescription(UObject WorldContextObject, APlayerController PlayerController, FName AchievementID, out bool bFoundID, out FText Title, out FText LockedDescription, out FText UnlockedDescription, out bool bHidden)
	{
		if (!GetCachedAchievementDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary:GetCachedAchievementDescription");
			bFoundID = false;
			Title = null;
			LockedDescription = null;
			UnlockedDescription = null;
			bHidden = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCachedAchievementDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCachedAchievementDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_WorldContextObject_Offset), 0, GetCachedAchievementDescription_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_PlayerController_Offset), 0, GetCachedAchievementDescription_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_AchievementID_Offset), 0, GetCachedAchievementDescription_AchievementID_PropertyAddress.Address, AchievementID);
		NativeReflection.InitializeValue_InContainer(GetCachedAchievementDescription_Title_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(GetCachedAchievementDescription_LockedDescription_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(GetCachedAchievementDescription_UnlockedDescription_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCachedAchievementDescription_FunctionAddress, intPtr, GetCachedAchievementDescription_ParamsSize);
		bFoundID = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_bFoundID_Offset), 0, GetCachedAchievementDescription_bFoundID_PropertyAddress.Address);
		Title = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_Title_Offset), 0, GetCachedAchievementDescription_Title_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCachedAchievementDescription_Title_PropertyAddress.Address, intPtr);
		LockedDescription = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_LockedDescription_Offset), 0, GetCachedAchievementDescription_LockedDescription_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCachedAchievementDescription_LockedDescription_PropertyAddress.Address, intPtr);
		UnlockedDescription = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_UnlockedDescription_Offset), 0, GetCachedAchievementDescription_UnlockedDescription_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCachedAchievementDescription_UnlockedDescription_PropertyAddress.Address, intPtr);
		bHidden = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedAchievementDescription_bHidden_Offset), 0, GetCachedAchievementDescription_bHidden_PropertyAddress.Address);
	}

	static UAchievementLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAchievementLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAchievementLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary");
		GetCachedAchievementProgress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCachedAchievementProgress");
		GetCachedAchievementProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCachedAchievementProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementProgress_WorldContextObject_PropertyAddress, GetCachedAchievementProgress_FunctionAddress, "WorldContextObject");
		GetCachedAchievementProgress_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementProgress_FunctionAddress, "WorldContextObject");
		GetCachedAchievementProgress_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementProgress_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementProgress_PlayerController_PropertyAddress, GetCachedAchievementProgress_FunctionAddress, "PlayerController");
		GetCachedAchievementProgress_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementProgress_FunctionAddress, "PlayerController");
		GetCachedAchievementProgress_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementProgress_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementProgress_AchievementID_PropertyAddress, GetCachedAchievementProgress_FunctionAddress, "AchievementID");
		GetCachedAchievementProgress_AchievementID_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementProgress_FunctionAddress, "AchievementID");
		GetCachedAchievementProgress_AchievementID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementProgress_FunctionAddress, "AchievementID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementProgress_bFoundID_PropertyAddress, GetCachedAchievementProgress_FunctionAddress, "bFoundID");
		GetCachedAchievementProgress_bFoundID_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementProgress_FunctionAddress, "bFoundID");
		GetCachedAchievementProgress_bFoundID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementProgress_FunctionAddress, "bFoundID", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementProgress_Progress_PropertyAddress, GetCachedAchievementProgress_FunctionAddress, "Progress");
		GetCachedAchievementProgress_Progress_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementProgress_FunctionAddress, "Progress");
		GetCachedAchievementProgress_Progress_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementProgress_FunctionAddress, "Progress", Classes.FFloatProperty);
		GetCachedAchievementProgress_IsValid = GetCachedAchievementProgress_FunctionAddress != IntPtr.Zero && GetCachedAchievementProgress_WorldContextObject_IsValid && GetCachedAchievementProgress_PlayerController_IsValid && GetCachedAchievementProgress_AchievementID_IsValid && GetCachedAchievementProgress_bFoundID_IsValid && GetCachedAchievementProgress_Progress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary:GetCachedAchievementProgress", GetCachedAchievementProgress_IsValid);
		GetCachedAchievementDescription_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCachedAchievementDescription");
		GetCachedAchievementDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCachedAchievementDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_WorldContextObject_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "WorldContextObject");
		GetCachedAchievementDescription_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "WorldContextObject");
		GetCachedAchievementDescription_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_PlayerController_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "PlayerController");
		GetCachedAchievementDescription_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "PlayerController");
		GetCachedAchievementDescription_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_AchievementID_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "AchievementID");
		GetCachedAchievementDescription_AchievementID_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "AchievementID");
		GetCachedAchievementDescription_AchievementID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "AchievementID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_bFoundID_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "bFoundID");
		GetCachedAchievementDescription_bFoundID_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "bFoundID");
		GetCachedAchievementDescription_bFoundID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "bFoundID", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_Title_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "Title");
		GetCachedAchievementDescription_Title_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "Title");
		GetCachedAchievementDescription_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_LockedDescription_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "LockedDescription");
		GetCachedAchievementDescription_LockedDescription_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "LockedDescription");
		GetCachedAchievementDescription_LockedDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "LockedDescription", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_UnlockedDescription_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "UnlockedDescription");
		GetCachedAchievementDescription_UnlockedDescription_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "UnlockedDescription");
		GetCachedAchievementDescription_UnlockedDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "UnlockedDescription", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedAchievementDescription_bHidden_PropertyAddress, GetCachedAchievementDescription_FunctionAddress, "bHidden");
		GetCachedAchievementDescription_bHidden_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedAchievementDescription_FunctionAddress, "bHidden");
		GetCachedAchievementDescription_bHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedAchievementDescription_FunctionAddress, "bHidden", Classes.FBoolProperty);
		GetCachedAchievementDescription_IsValid = GetCachedAchievementDescription_FunctionAddress != IntPtr.Zero && GetCachedAchievementDescription_WorldContextObject_IsValid && GetCachedAchievementDescription_PlayerController_IsValid && GetCachedAchievementDescription_AchievementID_IsValid && GetCachedAchievementDescription_bFoundID_IsValid && GetCachedAchievementDescription_Title_IsValid && GetCachedAchievementDescription_LockedDescription_IsValid && GetCachedAchievementDescription_UnlockedDescription_IsValid && GetCachedAchievementDescription_bHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.AchievementBlueprintLibrary:GetCachedAchievementDescription", GetCachedAchievementDescription_IsValid);
	}
}
