using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineIdentity", "b1", UnrealModuleType.Game)]
public class UBGWOnlineIdentity : UBGWOnlineInterface
{
	private static bool OnRecvAntiAddictionActionCS_IsValid;

	private IntPtr OnRecvAntiAddictionActionCS_InstanceFunctionAddress;

	private static IntPtr OnRecvAntiAddictionActionCS_FunctionAddress;

	private static int OnRecvAntiAddictionActionCS_ParamsSize;

	private static bool OnRecvAntiAddictionActionCS_RecvActionsJsonStr_IsValid;

	private static FFieldAddress OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress;

	private static int OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset;

	private static bool OnLoginCompletedCS_IsValid;

	private IntPtr OnLoginCompletedCS_InstanceFunctionAddress;

	private static IntPtr OnLoginCompletedCS_FunctionAddress;

	private static int OnLoginCompletedCS_ParamsSize;

	private static bool OnLoginCompletedCS_bSuccessful_IsValid;

	private static FFieldAddress OnLoginCompletedCS_bSuccessful_PropertyAddress;

	private static int OnLoginCompletedCS_bSuccessful_Offset;

	private static bool OnGetUserPrivilegeCompleteCS_IsValid;

	private IntPtr OnGetUserPrivilegeCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnGetUserPrivilegeCompleteCS_FunctionAddress;

	private static int OnGetUserPrivilegeCompleteCS_ParamsSize;

	private static bool OnGetUserPrivilegeCompleteCS_Privilege_IsValid;

	private static FFieldAddress OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress;

	private static int OnGetUserPrivilegeCompleteCS_Privilege_Offset;

	private static bool OnGetUserPrivilegeCompleteCS_PrivilegeResult_IsValid;

	private static FFieldAddress OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress;

	private static int OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset;

	private static bool Login_IsValid;

	private static IntPtr Login_FunctionAddress;

	private static int Login_ParamsSize;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool GetUserPrivilege_IsValid;

	private static IntPtr GetUserPrivilege_FunctionAddress;

	private static int GetUserPrivilege_ParamsSize;

	private static bool GetUserPrivilege_Privilege_IsValid;

	private static FFieldAddress GetUserPrivilege_Privilege_PropertyAddress;

	private static int GetUserPrivilege_Privilege_Offset;

	private static bool GetUniquePlayerId_IsValid;

	private static IntPtr GetUniquePlayerId_FunctionAddress;

	private static int GetUniquePlayerId_ParamsSize;

	private static bool GetUniquePlayerId_ReturnValue_IsValid;

	private static FFieldAddress GetUniquePlayerId_ReturnValue_PropertyAddress;

	private static int GetUniquePlayerId_ReturnValue_Offset;

	private static bool GetPlayerNickname_IsValid;

	private static IntPtr GetPlayerNickname_FunctionAddress;

	private static int GetPlayerNickname_ParamsSize;

	private static bool GetPlayerNickname_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerNickname_ReturnValue_PropertyAddress;

	private static int GetPlayerNickname_ReturnValue_Offset;

	private static bool GetLoginStatus_IsValid;

	private static IntPtr GetLoginStatus_FunctionAddress;

	private static int GetLoginStatus_ParamsSize;

	private static bool GetLoginStatus_ReturnValue_IsValid;

	private static FFieldAddress GetLoginStatus_ReturnValue_PropertyAddress;

	private static int GetLoginStatus_ReturnValue_Offset;

	private static bool GetLinkedAccountExternalToken_IsValid;

	private static IntPtr GetLinkedAccountExternalToken_FunctionAddress;

	private static int GetLinkedAccountExternalToken_ParamsSize;

	private static bool GetLinkedAccountExternalToken_ReturnValue_IsValid;

	private static FFieldAddress GetLinkedAccountExternalToken_ReturnValue_PropertyAddress;

	private static int GetLinkedAccountExternalToken_ReturnValue_Offset;

	private static bool GetAuthToken_IsValid;

	private static IntPtr GetAuthToken_FunctionAddress;

	private static int GetAuthToken_ParamsSize;

	private static bool GetAuthToken_ReturnValue_IsValid;

	private static FFieldAddress GetAuthToken_ReturnValue_PropertyAddress;

	private static int GetAuthToken_ReturnValue_Offset;

	private static bool GetAuthOnlineUserId_IsValid;

	private static IntPtr GetAuthOnlineUserId_FunctionAddress;

	private static int GetAuthOnlineUserId_ParamsSize;

	private static bool GetAuthOnlineUserId_ReturnValue_IsValid;

	private static FFieldAddress GetAuthOnlineUserId_ReturnValue_PropertyAddress;

	private static int GetAuthOnlineUserId_ReturnValue_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:OnRecvAntiAddictionActionCS")]
	protected unsafe void OnRecvAntiAddictionActionCS(string RecvActionsJsonStr)
	{
		CheckDestroyed();
		if (!OnRecvAntiAddictionActionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:OnRecvAntiAddictionActionCS");
			return;
		}
		if (OnRecvAntiAddictionActionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRecvAntiAddictionActionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRecvAntiAddictionActionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRecvAntiAddictionActionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRecvAntiAddictionActionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset), 0, OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress.Address, RecvActionsJsonStr);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRecvAntiAddictionActionCS_InstanceFunctionAddress, intPtr, OnRecvAntiAddictionActionCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnRecvAntiAddictionActionCS_Implementation(string RecvActionsJsonStr)
	{
		CheckDestroyed();
		if (!OnRecvAntiAddictionActionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:OnRecvAntiAddictionActionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRecvAntiAddictionActionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRecvAntiAddictionActionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset), 0, OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress.Address, RecvActionsJsonStr);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRecvAntiAddictionActionCS_FunctionAddress, intPtr, OnRecvAntiAddictionActionCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:OnLoginCompletedCS")]
	protected unsafe void OnLoginCompletedCS(bool bSuccessful)
	{
		CheckDestroyed();
		if (!OnLoginCompletedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:OnLoginCompletedCS");
			return;
		}
		if (OnLoginCompletedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLoginCompletedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLoginCompletedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLoginCompletedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLoginCompletedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLoginCompletedCS_bSuccessful_Offset), 0, OnLoginCompletedCS_bSuccessful_PropertyAddress.Address, bSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLoginCompletedCS_InstanceFunctionAddress, intPtr, OnLoginCompletedCS_ParamsSize);
	}

	protected unsafe virtual void OnLoginCompletedCS_Implementation(bool bSuccessful)
	{
		CheckDestroyed();
		if (!OnLoginCompletedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:OnLoginCompletedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLoginCompletedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLoginCompletedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLoginCompletedCS_bSuccessful_Offset), 0, OnLoginCompletedCS_bSuccessful_PropertyAddress.Address, bSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLoginCompletedCS_FunctionAddress, intPtr, OnLoginCompletedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:OnGetUserPrivilegeCompleteCS")]
	protected unsafe void OnGetUserPrivilegeCompleteCS(EBGWUserPrivileges Privilege, EBGWPrivilegeResult PrivilegeResult)
	{
		CheckDestroyed();
		if (!OnGetUserPrivilegeCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:OnGetUserPrivilegeCompleteCS");
			return;
		}
		if (OnGetUserPrivilegeCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnGetUserPrivilegeCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnGetUserPrivilegeCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGetUserPrivilegeCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetUserPrivilegeCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWUserPrivileges>.ToNative(IntPtr.Add(intPtr, OnGetUserPrivilegeCompleteCS_Privilege_Offset), 0, OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress.Address, Privilege);
		EnumMarshaler<EBGWPrivilegeResult>.ToNative(IntPtr.Add(intPtr, OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset), 0, OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress.Address, PrivilegeResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGetUserPrivilegeCompleteCS_InstanceFunctionAddress, intPtr, OnGetUserPrivilegeCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnGetUserPrivilegeCompleteCS_Implementation(EBGWUserPrivileges Privilege, EBGWPrivilegeResult PrivilegeResult)
	{
		CheckDestroyed();
		if (!OnGetUserPrivilegeCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:OnGetUserPrivilegeCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGetUserPrivilegeCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetUserPrivilegeCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWUserPrivileges>.ToNative(IntPtr.Add(intPtr, OnGetUserPrivilegeCompleteCS_Privilege_Offset), 0, OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress.Address, Privilege);
		EnumMarshaler<EBGWPrivilegeResult>.ToNative(IntPtr.Add(intPtr, OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset), 0, OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress.Address, PrivilegeResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGetUserPrivilegeCompleteCS_FunctionAddress, intPtr, OnGetUserPrivilegeCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:Login")]
	public unsafe void Login()
	{
		CheckDestroyed();
		if (!Login_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:Login");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Login_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Login_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Login_FunctionAddress, argsSize: Login_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:Init");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Init_ReturnValue_Offset), 0, Init_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetUserPrivilege")]
	protected unsafe void GetUserPrivilege(EBGWUserPrivileges Privilege)
	{
		CheckDestroyed();
		if (!GetUserPrivilege_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetUserPrivilege");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUserPrivilege_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserPrivilege_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWUserPrivileges>.ToNative(IntPtr.Add(intPtr, GetUserPrivilege_Privilege_Offset), 0, GetUserPrivilege_Privilege_PropertyAddress.Address, Privilege);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUserPrivilege_FunctionAddress, intPtr, GetUserPrivilege_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetUniquePlayerId")]
	public unsafe string GetUniquePlayerId()
	{
		CheckDestroyed();
		if (!GetUniquePlayerId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetUniquePlayerId");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniquePlayerId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniquePlayerId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUniquePlayerId_FunctionAddress, intPtr, GetUniquePlayerId_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUniquePlayerId_ReturnValue_Offset), 0, GetUniquePlayerId_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUniquePlayerId_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetPlayerNickname")]
	public unsafe string GetPlayerNickname()
	{
		CheckDestroyed();
		if (!GetPlayerNickname_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetPlayerNickname");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerNickname_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerNickname_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerNickname_FunctionAddress, intPtr, GetPlayerNickname_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPlayerNickname_ReturnValue_Offset), 0, GetPlayerNickname_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPlayerNickname_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetLoginStatus")]
	public unsafe EBGWLoginStatus GetLoginStatus()
	{
		CheckDestroyed();
		if (!GetLoginStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetLoginStatus");
			return EBGWLoginStatus.NotLoggedIn;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoginStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoginStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLoginStatus_FunctionAddress, intPtr, GetLoginStatus_ParamsSize);
		return EnumMarshaler<EBGWLoginStatus>.FromNative(IntPtr.Add(intPtr, GetLoginStatus_ReturnValue_Offset), 0, GetLoginStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetLinkedAccountExternalToken")]
	public unsafe string GetLinkedAccountExternalToken()
	{
		CheckDestroyed();
		if (!GetLinkedAccountExternalToken_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetLinkedAccountExternalToken");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkedAccountExternalToken_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkedAccountExternalToken_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinkedAccountExternalToken_FunctionAddress, intPtr, GetLinkedAccountExternalToken_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLinkedAccountExternalToken_ReturnValue_Offset), 0, GetLinkedAccountExternalToken_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLinkedAccountExternalToken_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetAuthToken")]
	public unsafe string GetAuthToken()
	{
		CheckDestroyed();
		if (!GetAuthToken_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetAuthToken");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAuthToken_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAuthToken_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAuthToken_FunctionAddress, intPtr, GetAuthToken_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAuthToken_ReturnValue_Offset), 0, GetAuthToken_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAuthToken_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:GetAuthOnlineUserId")]
	public unsafe string GetAuthOnlineUserId()
	{
		CheckDestroyed();
		if (!GetAuthOnlineUserId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:GetAuthOnlineUserId");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAuthOnlineUserId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAuthOnlineUserId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAuthOnlineUserId_FunctionAddress, intPtr, GetAuthOnlineUserId_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAuthOnlineUserId_ReturnValue_Offset), 0, GetAuthOnlineUserId_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAuthOnlineUserId_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineIdentity:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineIdentity:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	static UBGWOnlineIdentity()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineIdentity)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineIdentity));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWOnlineIdentity");
		OnRecvAntiAddictionActionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRecvAntiAddictionActionCS");
		OnRecvAntiAddictionActionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRecvAntiAddictionActionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress, OnRecvAntiAddictionActionCS_FunctionAddress, "RecvActionsJsonStr");
		OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset = NativeReflectionCached.GetPropertyOffset(OnRecvAntiAddictionActionCS_FunctionAddress, "RecvActionsJsonStr");
		OnRecvAntiAddictionActionCS_RecvActionsJsonStr_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRecvAntiAddictionActionCS_FunctionAddress, "RecvActionsJsonStr", Classes.FStrProperty);
		OnRecvAntiAddictionActionCS_IsValid = OnRecvAntiAddictionActionCS_FunctionAddress != IntPtr.Zero && OnRecvAntiAddictionActionCS_RecvActionsJsonStr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:OnRecvAntiAddictionActionCS", OnRecvAntiAddictionActionCS_IsValid);
		OnLoginCompletedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLoginCompletedCS");
		OnLoginCompletedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLoginCompletedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLoginCompletedCS_bSuccessful_PropertyAddress, OnLoginCompletedCS_FunctionAddress, "bSuccessful");
		OnLoginCompletedCS_bSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnLoginCompletedCS_FunctionAddress, "bSuccessful");
		OnLoginCompletedCS_bSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLoginCompletedCS_FunctionAddress, "bSuccessful", Classes.FBoolProperty);
		OnLoginCompletedCS_IsValid = OnLoginCompletedCS_FunctionAddress != IntPtr.Zero && OnLoginCompletedCS_bSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:OnLoginCompletedCS", OnLoginCompletedCS_IsValid);
		OnGetUserPrivilegeCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGetUserPrivilegeCompleteCS");
		OnGetUserPrivilegeCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetUserPrivilegeCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress, OnGetUserPrivilegeCompleteCS_FunctionAddress, "Privilege");
		OnGetUserPrivilegeCompleteCS_Privilege_Offset = NativeReflectionCached.GetPropertyOffset(OnGetUserPrivilegeCompleteCS_FunctionAddress, "Privilege");
		OnGetUserPrivilegeCompleteCS_Privilege_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetUserPrivilegeCompleteCS_FunctionAddress, "Privilege", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress, OnGetUserPrivilegeCompleteCS_FunctionAddress, "PrivilegeResult");
		OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset = NativeReflectionCached.GetPropertyOffset(OnGetUserPrivilegeCompleteCS_FunctionAddress, "PrivilegeResult");
		OnGetUserPrivilegeCompleteCS_PrivilegeResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetUserPrivilegeCompleteCS_FunctionAddress, "PrivilegeResult", Classes.FEnumProperty);
		OnGetUserPrivilegeCompleteCS_IsValid = OnGetUserPrivilegeCompleteCS_FunctionAddress != IntPtr.Zero && OnGetUserPrivilegeCompleteCS_Privilege_IsValid && OnGetUserPrivilegeCompleteCS_PrivilegeResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:OnGetUserPrivilegeCompleteCS", OnGetUserPrivilegeCompleteCS_IsValid);
		Login_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Login");
		Login_ParamsSize = NativeReflection.GetFunctionParamsSize(Login_FunctionAddress);
		Login_IsValid = Login_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:Login", Login_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:Init", Init_IsValid);
		GetUserPrivilege_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUserPrivilege");
		GetUserPrivilege_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserPrivilege_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUserPrivilege_Privilege_PropertyAddress, GetUserPrivilege_FunctionAddress, "Privilege");
		GetUserPrivilege_Privilege_Offset = NativeReflectionCached.GetPropertyOffset(GetUserPrivilege_FunctionAddress, "Privilege");
		GetUserPrivilege_Privilege_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserPrivilege_FunctionAddress, "Privilege", Classes.FByteProperty);
		GetUserPrivilege_IsValid = GetUserPrivilege_FunctionAddress != IntPtr.Zero && GetUserPrivilege_Privilege_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetUserPrivilege", GetUserPrivilege_IsValid);
		GetUniquePlayerId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUniquePlayerId");
		GetUniquePlayerId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniquePlayerId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniquePlayerId_ReturnValue_PropertyAddress, GetUniquePlayerId_FunctionAddress, "ReturnValue");
		GetUniquePlayerId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniquePlayerId_FunctionAddress, "ReturnValue");
		GetUniquePlayerId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniquePlayerId_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUniquePlayerId_IsValid = GetUniquePlayerId_FunctionAddress != IntPtr.Zero && GetUniquePlayerId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetUniquePlayerId", GetUniquePlayerId_IsValid);
		GetPlayerNickname_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayerNickname");
		GetPlayerNickname_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerNickname_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerNickname_ReturnValue_PropertyAddress, GetPlayerNickname_FunctionAddress, "ReturnValue");
		GetPlayerNickname_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerNickname_FunctionAddress, "ReturnValue");
		GetPlayerNickname_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerNickname_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPlayerNickname_IsValid = GetPlayerNickname_FunctionAddress != IntPtr.Zero && GetPlayerNickname_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetPlayerNickname", GetPlayerNickname_IsValid);
		GetLoginStatus_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLoginStatus");
		GetLoginStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoginStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoginStatus_ReturnValue_PropertyAddress, GetLoginStatus_FunctionAddress, "ReturnValue");
		GetLoginStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLoginStatus_FunctionAddress, "ReturnValue");
		GetLoginStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoginStatus_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetLoginStatus_IsValid = GetLoginStatus_FunctionAddress != IntPtr.Zero && GetLoginStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetLoginStatus", GetLoginStatus_IsValid);
		GetLinkedAccountExternalToken_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinkedAccountExternalToken");
		GetLinkedAccountExternalToken_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkedAccountExternalToken_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedAccountExternalToken_ReturnValue_PropertyAddress, GetLinkedAccountExternalToken_FunctionAddress, "ReturnValue");
		GetLinkedAccountExternalToken_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedAccountExternalToken_FunctionAddress, "ReturnValue");
		GetLinkedAccountExternalToken_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedAccountExternalToken_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLinkedAccountExternalToken_IsValid = GetLinkedAccountExternalToken_FunctionAddress != IntPtr.Zero && GetLinkedAccountExternalToken_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetLinkedAccountExternalToken", GetLinkedAccountExternalToken_IsValid);
		GetAuthToken_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAuthToken");
		GetAuthToken_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAuthToken_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAuthToken_ReturnValue_PropertyAddress, GetAuthToken_FunctionAddress, "ReturnValue");
		GetAuthToken_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAuthToken_FunctionAddress, "ReturnValue");
		GetAuthToken_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAuthToken_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAuthToken_IsValid = GetAuthToken_FunctionAddress != IntPtr.Zero && GetAuthToken_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetAuthToken", GetAuthToken_IsValid);
		GetAuthOnlineUserId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAuthOnlineUserId");
		GetAuthOnlineUserId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAuthOnlineUserId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAuthOnlineUserId_ReturnValue_PropertyAddress, GetAuthOnlineUserId_FunctionAddress, "ReturnValue");
		GetAuthOnlineUserId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAuthOnlineUserId_FunctionAddress, "ReturnValue");
		GetAuthOnlineUserId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAuthOnlineUserId_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAuthOnlineUserId_IsValid = GetAuthOnlineUserId_FunctionAddress != IntPtr.Zero && GetAuthOnlineUserId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:GetAuthOnlineUserId", GetAuthOnlineUserId_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineIdentity:Destroy", Destroy_IsValid);
	}
}
