using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.BlueprintPlatformLibrary", "Engine", UnrealModuleType.Engine)]
public class UPlatformLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ScheduleLocalNotificationFromNow_IsValid;

	private static IntPtr ScheduleLocalNotificationFromNow_FunctionAddress;

	private static int ScheduleLocalNotificationFromNow_ParamsSize;

	private static bool ScheduleLocalNotificationFromNow_inSecondsFromNow_IsValid;

	private static FFieldAddress ScheduleLocalNotificationFromNow_inSecondsFromNow_PropertyAddress;

	private static int ScheduleLocalNotificationFromNow_inSecondsFromNow_Offset;

	private static bool ScheduleLocalNotificationFromNow_Title_IsValid;

	private static FFieldAddress ScheduleLocalNotificationFromNow_Title_PropertyAddress;

	private static int ScheduleLocalNotificationFromNow_Title_Offset;

	private static bool ScheduleLocalNotificationFromNow_Body_IsValid;

	private static FFieldAddress ScheduleLocalNotificationFromNow_Body_PropertyAddress;

	private static int ScheduleLocalNotificationFromNow_Body_Offset;

	private static bool ScheduleLocalNotificationFromNow_Action_IsValid;

	private static FFieldAddress ScheduleLocalNotificationFromNow_Action_PropertyAddress;

	private static int ScheduleLocalNotificationFromNow_Action_Offset;

	private static bool ScheduleLocalNotificationFromNow_ActivationEvent_IsValid;

	private static FFieldAddress ScheduleLocalNotificationFromNow_ActivationEvent_PropertyAddress;

	private static int ScheduleLocalNotificationFromNow_ActivationEvent_Offset;

	private static bool ScheduleLocalNotificationFromNow_ReturnValue_IsValid;

	private static FFieldAddress ScheduleLocalNotificationFromNow_ReturnValue_PropertyAddress;

	private static int ScheduleLocalNotificationFromNow_ReturnValue_Offset;

	private static bool ScheduleLocalNotificationBadgeFromNow_IsValid;

	private static IntPtr ScheduleLocalNotificationBadgeFromNow_FunctionAddress;

	private static int ScheduleLocalNotificationBadgeFromNow_ParamsSize;

	private static bool ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_IsValid;

	private static FFieldAddress ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_PropertyAddress;

	private static int ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_Offset;

	private static bool ScheduleLocalNotificationBadgeFromNow_ActivationEvent_IsValid;

	private static FFieldAddress ScheduleLocalNotificationBadgeFromNow_ActivationEvent_PropertyAddress;

	private static int ScheduleLocalNotificationBadgeFromNow_ActivationEvent_Offset;

	private static bool ScheduleLocalNotificationBadgeAtTime_IsValid;

	private static IntPtr ScheduleLocalNotificationBadgeAtTime_FunctionAddress;

	private static int ScheduleLocalNotificationBadgeAtTime_ParamsSize;

	private static bool ScheduleLocalNotificationBadgeAtTime_FireDateTime_IsValid;

	private static FFieldAddress ScheduleLocalNotificationBadgeAtTime_FireDateTime_PropertyAddress;

	private static int ScheduleLocalNotificationBadgeAtTime_FireDateTime_Offset;

	private static bool ScheduleLocalNotificationBadgeAtTime_LocalTime_IsValid;

	private static FFieldAddress ScheduleLocalNotificationBadgeAtTime_LocalTime_PropertyAddress;

	private static int ScheduleLocalNotificationBadgeAtTime_LocalTime_Offset;

	private static bool ScheduleLocalNotificationBadgeAtTime_ActivationEvent_IsValid;

	private static FFieldAddress ScheduleLocalNotificationBadgeAtTime_ActivationEvent_PropertyAddress;

	private static int ScheduleLocalNotificationBadgeAtTime_ActivationEvent_Offset;

	private static bool ScheduleLocalNotificationBadgeAtTime_ReturnValue_IsValid;

	private static FFieldAddress ScheduleLocalNotificationBadgeAtTime_ReturnValue_PropertyAddress;

	private static int ScheduleLocalNotificationBadgeAtTime_ReturnValue_Offset;

	private static bool ScheduleLocalNotificationAtTime_IsValid;

	private static IntPtr ScheduleLocalNotificationAtTime_FunctionAddress;

	private static int ScheduleLocalNotificationAtTime_ParamsSize;

	private static bool ScheduleLocalNotificationAtTime_FireDateTime_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_FireDateTime_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_FireDateTime_Offset;

	private static bool ScheduleLocalNotificationAtTime_LocalTime_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_LocalTime_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_LocalTime_Offset;

	private static bool ScheduleLocalNotificationAtTime_Title_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_Title_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_Title_Offset;

	private static bool ScheduleLocalNotificationAtTime_Body_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_Body_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_Body_Offset;

	private static bool ScheduleLocalNotificationAtTime_Action_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_Action_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_Action_Offset;

	private static bool ScheduleLocalNotificationAtTime_ActivationEvent_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_ActivationEvent_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_ActivationEvent_Offset;

	private static bool ScheduleLocalNotificationAtTime_ReturnValue_IsValid;

	private static FFieldAddress ScheduleLocalNotificationAtTime_ReturnValue_PropertyAddress;

	private static int ScheduleLocalNotificationAtTime_ReturnValue_Offset;

	private static bool GetLaunchNotification_IsValid;

	private static IntPtr GetLaunchNotification_FunctionAddress;

	private static int GetLaunchNotification_ParamsSize;

	private static bool GetLaunchNotification_NotificationLaunchedApp_IsValid;

	private static FFieldAddress GetLaunchNotification_NotificationLaunchedApp_PropertyAddress;

	private static int GetLaunchNotification_NotificationLaunchedApp_Offset;

	private static bool GetLaunchNotification_ActivationEvent_IsValid;

	private static FFieldAddress GetLaunchNotification_ActivationEvent_PropertyAddress;

	private static int GetLaunchNotification_ActivationEvent_Offset;

	private static bool GetLaunchNotification_FireDate_IsValid;

	private static FFieldAddress GetLaunchNotification_FireDate_PropertyAddress;

	private static int GetLaunchNotification_FireDate_Offset;

	private static bool GetDeviceOrientation_IsValid;

	private static IntPtr GetDeviceOrientation_FunctionAddress;

	private static int GetDeviceOrientation_ParamsSize;

	private static bool GetDeviceOrientation_ReturnValue_IsValid;

	private static FFieldAddress GetDeviceOrientation_ReturnValue_PropertyAddress;

	private static int GetDeviceOrientation_ReturnValue_Offset;

	private static bool ClearAllLocalNotifications_IsValid;

	private static IntPtr ClearAllLocalNotifications_FunctionAddress;

	private static int ClearAllLocalNotifications_ParamsSize;

	private static bool CancelLocalNotificationById_IsValid;

	private static IntPtr CancelLocalNotificationById_FunctionAddress;

	private static int CancelLocalNotificationById_ParamsSize;

	private static bool CancelLocalNotificationById_NotificationId_IsValid;

	private static FFieldAddress CancelLocalNotificationById_NotificationId_PropertyAddress;

	private static int CancelLocalNotificationById_NotificationId_Offset;

	private static bool CancelLocalNotification_IsValid;

	private static IntPtr CancelLocalNotification_FunctionAddress;

	private static int CancelLocalNotification_ParamsSize;

	private static bool CancelLocalNotification_ActivationEvent_IsValid;

	private static FFieldAddress CancelLocalNotification_ActivationEvent_PropertyAddress;

	private static int CancelLocalNotification_ActivationEvent_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationFromNow")]
	public unsafe static int ScheduleLocalNotificationFromNow(int inSecondsFromNow, FText Title, FText Body, FText Action, string ActivationEvent)
	{
		if (!ScheduleLocalNotificationFromNow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationFromNow");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScheduleLocalNotificationFromNow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScheduleLocalNotificationFromNow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationFromNow_inSecondsFromNow_Offset), 0, ScheduleLocalNotificationFromNow_inSecondsFromNow_PropertyAddress.Address, inSecondsFromNow);
		NativeReflection.InitializeValue_InContainer(ScheduleLocalNotificationFromNow_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationFromNow_Title_Offset), 0, ScheduleLocalNotificationFromNow_Title_PropertyAddress.Address, Title);
		NativeReflection.InitializeValue_InContainer(ScheduleLocalNotificationFromNow_Body_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationFromNow_Body_Offset), 0, ScheduleLocalNotificationFromNow_Body_PropertyAddress.Address, Body);
		NativeReflection.InitializeValue_InContainer(ScheduleLocalNotificationFromNow_Action_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationFromNow_Action_Offset), 0, ScheduleLocalNotificationFromNow_Action_PropertyAddress.Address, Action);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationFromNow_ActivationEvent_Offset), 0, ScheduleLocalNotificationFromNow_ActivationEvent_PropertyAddress.Address, ActivationEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScheduleLocalNotificationFromNow_FunctionAddress, intPtr, ScheduleLocalNotificationFromNow_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationFromNow_Title_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationFromNow_Body_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationFromNow_Action_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationFromNow_ActivationEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ScheduleLocalNotificationFromNow_ReturnValue_Offset), 0, ScheduleLocalNotificationFromNow_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationBadgeFromNow")]
	public unsafe static void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow, string ActivationEvent)
	{
		if (!ScheduleLocalNotificationBadgeFromNow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationBadgeFromNow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScheduleLocalNotificationBadgeFromNow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScheduleLocalNotificationBadgeFromNow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_Offset), 0, ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_PropertyAddress.Address, inSecondsFromNow);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationBadgeFromNow_ActivationEvent_Offset), 0, ScheduleLocalNotificationBadgeFromNow_ActivationEvent_PropertyAddress.Address, ActivationEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScheduleLocalNotificationBadgeFromNow_FunctionAddress, intPtr, ScheduleLocalNotificationBadgeFromNow_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationBadgeFromNow_ActivationEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationBadgeAtTime")]
	public unsafe static int ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime, bool LocalTime, string ActivationEvent)
	{
		if (!ScheduleLocalNotificationBadgeAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationBadgeAtTime");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScheduleLocalNotificationBadgeAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScheduleLocalNotificationBadgeAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationBadgeAtTime_FireDateTime_Offset), 0, ScheduleLocalNotificationBadgeAtTime_FireDateTime_PropertyAddress.Address, FireDateTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationBadgeAtTime_LocalTime_Offset), 0, ScheduleLocalNotificationBadgeAtTime_LocalTime_PropertyAddress.Address, LocalTime);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationBadgeAtTime_ActivationEvent_Offset), 0, ScheduleLocalNotificationBadgeAtTime_ActivationEvent_PropertyAddress.Address, ActivationEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScheduleLocalNotificationBadgeAtTime_FunctionAddress, intPtr, ScheduleLocalNotificationBadgeAtTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationBadgeAtTime_ActivationEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ScheduleLocalNotificationBadgeAtTime_ReturnValue_Offset), 0, ScheduleLocalNotificationBadgeAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationAtTime")]
	public unsafe static int ScheduleLocalNotificationAtTime(FDateTime FireDateTime, bool LocalTime, FText Title, FText Body, FText Action, string ActivationEvent)
	{
		if (!ScheduleLocalNotificationAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationAtTime");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScheduleLocalNotificationAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScheduleLocalNotificationAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_FireDateTime_Offset), 0, ScheduleLocalNotificationAtTime_FireDateTime_PropertyAddress.Address, FireDateTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_LocalTime_Offset), 0, ScheduleLocalNotificationAtTime_LocalTime_PropertyAddress.Address, LocalTime);
		NativeReflection.InitializeValue_InContainer(ScheduleLocalNotificationAtTime_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_Title_Offset), 0, ScheduleLocalNotificationAtTime_Title_PropertyAddress.Address, Title);
		NativeReflection.InitializeValue_InContainer(ScheduleLocalNotificationAtTime_Body_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_Body_Offset), 0, ScheduleLocalNotificationAtTime_Body_PropertyAddress.Address, Body);
		NativeReflection.InitializeValue_InContainer(ScheduleLocalNotificationAtTime_Action_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_Action_Offset), 0, ScheduleLocalNotificationAtTime_Action_PropertyAddress.Address, Action);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_ActivationEvent_Offset), 0, ScheduleLocalNotificationAtTime_ActivationEvent_PropertyAddress.Address, ActivationEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScheduleLocalNotificationAtTime_FunctionAddress, intPtr, ScheduleLocalNotificationAtTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationAtTime_Title_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationAtTime_Body_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationAtTime_Action_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScheduleLocalNotificationAtTime_ActivationEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ScheduleLocalNotificationAtTime_ReturnValue_Offset), 0, ScheduleLocalNotificationAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:GetLaunchNotification")]
	public unsafe static void GetLaunchNotification(out bool NotificationLaunchedApp, out string ActivationEvent, out int FireDate)
	{
		if (!GetLaunchNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:GetLaunchNotification");
			NotificationLaunchedApp = false;
			ActivationEvent = FStringMarshaler.DefaultString;
			FireDate = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLaunchNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLaunchNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLaunchNotification_FunctionAddress, intPtr, GetLaunchNotification_ParamsSize);
		NotificationLaunchedApp = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLaunchNotification_NotificationLaunchedApp_Offset), 0, GetLaunchNotification_NotificationLaunchedApp_PropertyAddress.Address);
		ActivationEvent = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLaunchNotification_ActivationEvent_Offset), 0, GetLaunchNotification_ActivationEvent_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLaunchNotification_ActivationEvent_PropertyAddress.Address, intPtr);
		FireDate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLaunchNotification_FireDate_Offset), 0, GetLaunchNotification_FireDate_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:GetDeviceOrientation")]
	public unsafe static EScreenOrientation GetDeviceOrientation()
	{
		if (!GetDeviceOrientation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:GetDeviceOrientation");
			return EScreenOrientation.Unknown;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeviceOrientation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeviceOrientation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDeviceOrientation_FunctionAddress, intPtr, GetDeviceOrientation_ParamsSize);
		return EnumMarshaler<EScreenOrientation>.FromNative(IntPtr.Add(intPtr, GetDeviceOrientation_ReturnValue_Offset), 0, GetDeviceOrientation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:ClearAllLocalNotifications")]
	public unsafe static void ClearAllLocalNotifications()
	{
		if (!ClearAllLocalNotifications_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:ClearAllLocalNotifications");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllLocalNotifications_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllLocalNotifications_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ClearAllLocalNotifications_FunctionAddress, argsSize: ClearAllLocalNotifications_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:CancelLocalNotificationById")]
	public unsafe static void CancelLocalNotificationById(int NotificationId)
	{
		if (!CancelLocalNotificationById_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:CancelLocalNotificationById");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelLocalNotificationById_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelLocalNotificationById_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CancelLocalNotificationById_NotificationId_Offset), 0, CancelLocalNotificationById_NotificationId_PropertyAddress.Address, NotificationId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CancelLocalNotificationById_FunctionAddress, intPtr, CancelLocalNotificationById_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.BlueprintPlatformLibrary:CancelLocalNotification")]
	public unsafe static void CancelLocalNotification(string ActivationEvent)
	{
		if (!CancelLocalNotification_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.BlueprintPlatformLibrary:CancelLocalNotification");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelLocalNotification_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelLocalNotification_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CancelLocalNotification_ActivationEvent_Offset), 0, CancelLocalNotification_ActivationEvent_PropertyAddress.Address, ActivationEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CancelLocalNotification_FunctionAddress, intPtr, CancelLocalNotification_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CancelLocalNotification_ActivationEvent_PropertyAddress.Address, intPtr);
	}

	static UPlatformLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPlatformLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlatformLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.BlueprintPlatformLibrary");
		ScheduleLocalNotificationFromNow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScheduleLocalNotificationFromNow");
		ScheduleLocalNotificationFromNow_ParamsSize = NativeReflection.GetFunctionParamsSize(ScheduleLocalNotificationFromNow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationFromNow_inSecondsFromNow_PropertyAddress, ScheduleLocalNotificationFromNow_FunctionAddress, "inSecondsFromNow");
		ScheduleLocalNotificationFromNow_inSecondsFromNow_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationFromNow_FunctionAddress, "inSecondsFromNow");
		ScheduleLocalNotificationFromNow_inSecondsFromNow_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationFromNow_FunctionAddress, "inSecondsFromNow", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationFromNow_Title_PropertyAddress, ScheduleLocalNotificationFromNow_FunctionAddress, "Title");
		ScheduleLocalNotificationFromNow_Title_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationFromNow_FunctionAddress, "Title");
		ScheduleLocalNotificationFromNow_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationFromNow_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationFromNow_Body_PropertyAddress, ScheduleLocalNotificationFromNow_FunctionAddress, "Body");
		ScheduleLocalNotificationFromNow_Body_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationFromNow_FunctionAddress, "Body");
		ScheduleLocalNotificationFromNow_Body_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationFromNow_FunctionAddress, "Body", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationFromNow_Action_PropertyAddress, ScheduleLocalNotificationFromNow_FunctionAddress, "Action");
		ScheduleLocalNotificationFromNow_Action_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationFromNow_FunctionAddress, "Action");
		ScheduleLocalNotificationFromNow_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationFromNow_FunctionAddress, "Action", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationFromNow_ActivationEvent_PropertyAddress, ScheduleLocalNotificationFromNow_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationFromNow_ActivationEvent_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationFromNow_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationFromNow_ActivationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationFromNow_FunctionAddress, "ActivationEvent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationFromNow_ReturnValue_PropertyAddress, ScheduleLocalNotificationFromNow_FunctionAddress, "ReturnValue");
		ScheduleLocalNotificationFromNow_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationFromNow_FunctionAddress, "ReturnValue");
		ScheduleLocalNotificationFromNow_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationFromNow_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ScheduleLocalNotificationFromNow_IsValid = ScheduleLocalNotificationFromNow_FunctionAddress != IntPtr.Zero && ScheduleLocalNotificationFromNow_inSecondsFromNow_IsValid && ScheduleLocalNotificationFromNow_Title_IsValid && ScheduleLocalNotificationFromNow_Body_IsValid && ScheduleLocalNotificationFromNow_Action_IsValid && ScheduleLocalNotificationFromNow_ActivationEvent_IsValid && ScheduleLocalNotificationFromNow_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationFromNow", ScheduleLocalNotificationFromNow_IsValid);
		ScheduleLocalNotificationBadgeFromNow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScheduleLocalNotificationBadgeFromNow");
		ScheduleLocalNotificationBadgeFromNow_ParamsSize = NativeReflection.GetFunctionParamsSize(ScheduleLocalNotificationBadgeFromNow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_PropertyAddress, ScheduleLocalNotificationBadgeFromNow_FunctionAddress, "inSecondsFromNow");
		ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationBadgeFromNow_FunctionAddress, "inSecondsFromNow");
		ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationBadgeFromNow_FunctionAddress, "inSecondsFromNow", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationBadgeFromNow_ActivationEvent_PropertyAddress, ScheduleLocalNotificationBadgeFromNow_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationBadgeFromNow_ActivationEvent_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationBadgeFromNow_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationBadgeFromNow_ActivationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationBadgeFromNow_FunctionAddress, "ActivationEvent", Classes.FStrProperty);
		ScheduleLocalNotificationBadgeFromNow_IsValid = ScheduleLocalNotificationBadgeFromNow_FunctionAddress != IntPtr.Zero && ScheduleLocalNotificationBadgeFromNow_inSecondsFromNow_IsValid && ScheduleLocalNotificationBadgeFromNow_ActivationEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationBadgeFromNow", ScheduleLocalNotificationBadgeFromNow_IsValid);
		ScheduleLocalNotificationBadgeAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScheduleLocalNotificationBadgeAtTime");
		ScheduleLocalNotificationBadgeAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(ScheduleLocalNotificationBadgeAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationBadgeAtTime_FireDateTime_PropertyAddress, ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "FireDateTime");
		ScheduleLocalNotificationBadgeAtTime_FireDateTime_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "FireDateTime");
		ScheduleLocalNotificationBadgeAtTime_FireDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "FireDateTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationBadgeAtTime_LocalTime_PropertyAddress, ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "LocalTime");
		ScheduleLocalNotificationBadgeAtTime_LocalTime_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "LocalTime");
		ScheduleLocalNotificationBadgeAtTime_LocalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "LocalTime", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationBadgeAtTime_ActivationEvent_PropertyAddress, ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationBadgeAtTime_ActivationEvent_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationBadgeAtTime_ActivationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "ActivationEvent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationBadgeAtTime_ReturnValue_PropertyAddress, ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "ReturnValue");
		ScheduleLocalNotificationBadgeAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "ReturnValue");
		ScheduleLocalNotificationBadgeAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationBadgeAtTime_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ScheduleLocalNotificationBadgeAtTime_IsValid = ScheduleLocalNotificationBadgeAtTime_FunctionAddress != IntPtr.Zero && ScheduleLocalNotificationBadgeAtTime_FireDateTime_IsValid && ScheduleLocalNotificationBadgeAtTime_LocalTime_IsValid && ScheduleLocalNotificationBadgeAtTime_ActivationEvent_IsValid && ScheduleLocalNotificationBadgeAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationBadgeAtTime", ScheduleLocalNotificationBadgeAtTime_IsValid);
		ScheduleLocalNotificationAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScheduleLocalNotificationAtTime");
		ScheduleLocalNotificationAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(ScheduleLocalNotificationAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_FireDateTime_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "FireDateTime");
		ScheduleLocalNotificationAtTime_FireDateTime_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "FireDateTime");
		ScheduleLocalNotificationAtTime_FireDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "FireDateTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_LocalTime_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "LocalTime");
		ScheduleLocalNotificationAtTime_LocalTime_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "LocalTime");
		ScheduleLocalNotificationAtTime_LocalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "LocalTime", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_Title_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "Title");
		ScheduleLocalNotificationAtTime_Title_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "Title");
		ScheduleLocalNotificationAtTime_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_Body_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "Body");
		ScheduleLocalNotificationAtTime_Body_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "Body");
		ScheduleLocalNotificationAtTime_Body_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "Body", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_Action_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "Action");
		ScheduleLocalNotificationAtTime_Action_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "Action");
		ScheduleLocalNotificationAtTime_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "Action", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_ActivationEvent_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationAtTime_ActivationEvent_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "ActivationEvent");
		ScheduleLocalNotificationAtTime_ActivationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "ActivationEvent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleLocalNotificationAtTime_ReturnValue_PropertyAddress, ScheduleLocalNotificationAtTime_FunctionAddress, "ReturnValue");
		ScheduleLocalNotificationAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleLocalNotificationAtTime_FunctionAddress, "ReturnValue");
		ScheduleLocalNotificationAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleLocalNotificationAtTime_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ScheduleLocalNotificationAtTime_IsValid = ScheduleLocalNotificationAtTime_FunctionAddress != IntPtr.Zero && ScheduleLocalNotificationAtTime_FireDateTime_IsValid && ScheduleLocalNotificationAtTime_LocalTime_IsValid && ScheduleLocalNotificationAtTime_Title_IsValid && ScheduleLocalNotificationAtTime_Body_IsValid && ScheduleLocalNotificationAtTime_Action_IsValid && ScheduleLocalNotificationAtTime_ActivationEvent_IsValid && ScheduleLocalNotificationAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:ScheduleLocalNotificationAtTime", ScheduleLocalNotificationAtTime_IsValid);
		GetLaunchNotification_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLaunchNotification");
		GetLaunchNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLaunchNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLaunchNotification_NotificationLaunchedApp_PropertyAddress, GetLaunchNotification_FunctionAddress, "NotificationLaunchedApp");
		GetLaunchNotification_NotificationLaunchedApp_Offset = NativeReflectionCached.GetPropertyOffset(GetLaunchNotification_FunctionAddress, "NotificationLaunchedApp");
		GetLaunchNotification_NotificationLaunchedApp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaunchNotification_FunctionAddress, "NotificationLaunchedApp", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaunchNotification_ActivationEvent_PropertyAddress, GetLaunchNotification_FunctionAddress, "ActivationEvent");
		GetLaunchNotification_ActivationEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetLaunchNotification_FunctionAddress, "ActivationEvent");
		GetLaunchNotification_ActivationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaunchNotification_FunctionAddress, "ActivationEvent", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaunchNotification_FireDate_PropertyAddress, GetLaunchNotification_FunctionAddress, "FireDate");
		GetLaunchNotification_FireDate_Offset = NativeReflectionCached.GetPropertyOffset(GetLaunchNotification_FunctionAddress, "FireDate");
		GetLaunchNotification_FireDate_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaunchNotification_FunctionAddress, "FireDate", Classes.FIntProperty);
		GetLaunchNotification_IsValid = GetLaunchNotification_FunctionAddress != IntPtr.Zero && GetLaunchNotification_NotificationLaunchedApp_IsValid && GetLaunchNotification_ActivationEvent_IsValid && GetLaunchNotification_FireDate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:GetLaunchNotification", GetLaunchNotification_IsValid);
		GetDeviceOrientation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDeviceOrientation");
		GetDeviceOrientation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeviceOrientation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeviceOrientation_ReturnValue_PropertyAddress, GetDeviceOrientation_FunctionAddress, "ReturnValue");
		GetDeviceOrientation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeviceOrientation_FunctionAddress, "ReturnValue");
		GetDeviceOrientation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeviceOrientation_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetDeviceOrientation_IsValid = GetDeviceOrientation_FunctionAddress != IntPtr.Zero && GetDeviceOrientation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:GetDeviceOrientation", GetDeviceOrientation_IsValid);
		ClearAllLocalNotifications_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearAllLocalNotifications");
		ClearAllLocalNotifications_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllLocalNotifications_FunctionAddress);
		ClearAllLocalNotifications_IsValid = ClearAllLocalNotifications_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:ClearAllLocalNotifications", ClearAllLocalNotifications_IsValid);
		CancelLocalNotificationById_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelLocalNotificationById");
		CancelLocalNotificationById_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelLocalNotificationById_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CancelLocalNotificationById_NotificationId_PropertyAddress, CancelLocalNotificationById_FunctionAddress, "NotificationId");
		CancelLocalNotificationById_NotificationId_Offset = NativeReflectionCached.GetPropertyOffset(CancelLocalNotificationById_FunctionAddress, "NotificationId");
		CancelLocalNotificationById_NotificationId_IsValid = NativeReflectionCached.ValidatePropertyClass(CancelLocalNotificationById_FunctionAddress, "NotificationId", Classes.FIntProperty);
		CancelLocalNotificationById_IsValid = CancelLocalNotificationById_FunctionAddress != IntPtr.Zero && CancelLocalNotificationById_NotificationId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:CancelLocalNotificationById", CancelLocalNotificationById_IsValid);
		CancelLocalNotification_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelLocalNotification");
		CancelLocalNotification_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelLocalNotification_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CancelLocalNotification_ActivationEvent_PropertyAddress, CancelLocalNotification_FunctionAddress, "ActivationEvent");
		CancelLocalNotification_ActivationEvent_Offset = NativeReflectionCached.GetPropertyOffset(CancelLocalNotification_FunctionAddress, "ActivationEvent");
		CancelLocalNotification_ActivationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(CancelLocalNotification_FunctionAddress, "ActivationEvent", Classes.FStrProperty);
		CancelLocalNotification_IsValid = CancelLocalNotification_FunctionAddress != IntPtr.Zero && CancelLocalNotification_ActivationEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.BlueprintPlatformLibrary:CancelLocalNotification", CancelLocalNotification_IsValid);
	}
}
