using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineSubsystem", "b1", UnrealModuleType.Game)]
public class UBGWOnlineSubsystem : UBGWOnlineInterface
{
	private static IntPtr classAddress;

	private static bool ShowStoreUI_IsValid;

	private static IntPtr ShowStoreUI_FunctionAddress;

	private static int ShowStoreUI_ParamsSize;

	private static bool ShowStoreUI_ProductId_IsValid;

	private static FFieldAddress ShowStoreUI_ProductId_PropertyAddress;

	private static int ShowStoreUI_ProductId_Offset;

	private static bool ShowStoreUI_AddToCard_IsValid;

	private static FFieldAddress ShowStoreUI_AddToCard_PropertyAddress;

	private static int ShowStoreUI_AddToCard_Offset;

	private static bool ShowStoreUI_ReturnValue_IsValid;

	private static FFieldAddress ShowStoreUI_ReturnValue_PropertyAddress;

	private static int ShowStoreUI_ReturnValue_Offset;

	private static bool QueryUserNATType_IsValid;

	private static IntPtr QueryUserNATType_FunctionAddress;

	private static int QueryUserNATType_ParamsSize;

	private static bool QueryIsOwnAdditionContentSync_IsValid;

	private static IntPtr QueryIsOwnAdditionContentSync_FunctionAddress;

	private static int QueryIsOwnAdditionContentSync_ParamsSize;

	private static bool QueryIsOwnAdditionContentSync_EntitlementId_IsValid;

	private static FFieldAddress QueryIsOwnAdditionContentSync_EntitlementId_PropertyAddress;

	private static int QueryIsOwnAdditionContentSync_EntitlementId_Offset;

	private static bool QueryIsOwnAdditionContentSync_ReturnValue_IsValid;

	private static FFieldAddress QueryIsOwnAdditionContentSync_ReturnValue_PropertyAddress;

	private static int QueryIsOwnAdditionContentSync_ReturnValue_Offset;

	private static bool QueryIsOwnAdditionContent_IsValid;

	private static IntPtr QueryIsOwnAdditionContent_FunctionAddress;

	private static int QueryIsOwnAdditionContent_ParamsSize;

	private static bool QueryIsOwnAdditionContent_EntitlementId_IsValid;

	private static FFieldAddress QueryIsOwnAdditionContent_EntitlementId_PropertyAddress;

	private static int QueryIsOwnAdditionContent_EntitlementId_Offset;

	private static bool OnShowStoreUIClosedCS_IsValid;

	private IntPtr OnShowStoreUIClosedCS_InstanceFunctionAddress;

	private static IntPtr OnShowStoreUIClosedCS_FunctionAddress;

	private static int OnShowStoreUIClosedCS_ParamsSize;

	private static bool OnShowStoreUIClosedCS_bPurchased_IsValid;

	private static FFieldAddress OnShowStoreUIClosedCS_bPurchased_PropertyAddress;

	private static int OnShowStoreUIClosedCS_bPurchased_Offset;

	private static bool OnQueryIsOwnAdditionContentCompleteCS_IsValid;

	private IntPtr OnQueryIsOwnAdditionContentCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress;

	private static int OnQueryIsOwnAdditionContentCompleteCS_ParamsSize;

	private static bool OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_IsValid;

	private static FFieldAddress OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress;

	private static int OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset;

	private static bool OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool GetSubsystemType_IsValid;

	private static IntPtr GetSubsystemType_FunctionAddress;

	private static int GetSubsystemType_ParamsSize;

	private static bool GetSubsystemType_ReturnValue_IsValid;

	private static FFieldAddress GetSubsystemType_ReturnValue_PropertyAddress;

	private static int GetSubsystemType_ReturnValue_Offset;

	private static bool GetSubsystemNameForDebug_IsValid;

	private static IntPtr GetSubsystemNameForDebug_FunctionAddress;

	private static int GetSubsystemNameForDebug_ParamsSize;

	private static bool GetSubsystemNameForDebug_ReturnValue_IsValid;

	private static FFieldAddress GetSubsystemNameForDebug_ReturnValue_PropertyAddress;

	private static int GetSubsystemNameForDebug_ReturnValue_Offset;

	private static bool GetLocalPlatformName_IsValid;

	private static IntPtr GetLocalPlatformName_FunctionAddress;

	private static int GetLocalPlatformName_ParamsSize;

	private static bool GetLocalPlatformName_ReturnValue_IsValid;

	private static FFieldAddress GetLocalPlatformName_ReturnValue_PropertyAddress;

	private static int GetLocalPlatformName_ReturnValue_Offset;

	private static bool GetInstanceName_IsValid;

	private static IntPtr GetInstanceName_FunctionAddress;

	private static int GetInstanceName_ParamsSize;

	private static bool GetInstanceName_ReturnValue_IsValid;

	private static FFieldAddress GetInstanceName_ReturnValue_PropertyAddress;

	private static int GetInstanceName_ReturnValue_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	private static bool AfterInit_IsValid;

	private static IntPtr AfterInit_FunctionAddress;

	private static int AfterInit_ParamsSize;

	private static bool AfterInit_ReturnValue_IsValid;

	private static FFieldAddress AfterInit_ReturnValue_PropertyAddress;

	private static int AfterInit_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:ShowStoreUI")]
	public unsafe bool ShowStoreUI(string ProductId, bool AddToCard)
	{
		CheckDestroyed();
		if (!ShowStoreUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:ShowStoreUI");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowStoreUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowStoreUI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ShowStoreUI_ProductId_Offset), 0, ShowStoreUI_ProductId_PropertyAddress.Address, ProductId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ShowStoreUI_AddToCard_Offset), 0, ShowStoreUI_AddToCard_PropertyAddress.Address, AddToCard);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShowStoreUI_FunctionAddress, intPtr, ShowStoreUI_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowStoreUI_ProductId_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShowStoreUI_ReturnValue_Offset), 0, ShowStoreUI_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:QueryUserNATType")]
	public unsafe void QueryUserNATType()
	{
		CheckDestroyed();
		if (!QueryUserNATType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:QueryUserNATType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryUserNATType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryUserNATType_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: QueryUserNATType_FunctionAddress, argsSize: QueryUserNATType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:QueryIsOwnAdditionContentSync")]
	public unsafe bool QueryIsOwnAdditionContentSync(string EntitlementId)
	{
		CheckDestroyed();
		if (!QueryIsOwnAdditionContentSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:QueryIsOwnAdditionContentSync");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryIsOwnAdditionContentSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryIsOwnAdditionContentSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, QueryIsOwnAdditionContentSync_EntitlementId_Offset), 0, QueryIsOwnAdditionContentSync_EntitlementId_PropertyAddress.Address, EntitlementId);
		NativeReflection.InvokeFunctionOptimized(base.Address, QueryIsOwnAdditionContentSync_FunctionAddress, intPtr, QueryIsOwnAdditionContentSync_ParamsSize);
		NativeReflection.DestroyValue_InContainer(QueryIsOwnAdditionContentSync_EntitlementId_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, QueryIsOwnAdditionContentSync_ReturnValue_Offset), 0, QueryIsOwnAdditionContentSync_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:QueryIsOwnAdditionContent")]
	public unsafe void QueryIsOwnAdditionContent(string EntitlementId)
	{
		CheckDestroyed();
		if (!QueryIsOwnAdditionContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:QueryIsOwnAdditionContent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryIsOwnAdditionContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryIsOwnAdditionContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, QueryIsOwnAdditionContent_EntitlementId_Offset), 0, QueryIsOwnAdditionContent_EntitlementId_PropertyAddress.Address, EntitlementId);
		NativeReflection.InvokeFunctionOptimized(base.Address, QueryIsOwnAdditionContent_FunctionAddress, intPtr, QueryIsOwnAdditionContent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(QueryIsOwnAdditionContent_EntitlementId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:OnShowStoreUIClosedCS")]
	protected unsafe void OnShowStoreUIClosedCS(bool bPurchased)
	{
		CheckDestroyed();
		if (!OnShowStoreUIClosedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:OnShowStoreUIClosedCS");
			return;
		}
		if (OnShowStoreUIClosedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnShowStoreUIClosedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnShowStoreUIClosedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnShowStoreUIClosedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnShowStoreUIClosedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnShowStoreUIClosedCS_bPurchased_Offset), 0, OnShowStoreUIClosedCS_bPurchased_PropertyAddress.Address, bPurchased);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnShowStoreUIClosedCS_InstanceFunctionAddress, intPtr, OnShowStoreUIClosedCS_ParamsSize);
	}

	protected unsafe virtual void OnShowStoreUIClosedCS_Implementation(bool bPurchased)
	{
		CheckDestroyed();
		if (!OnShowStoreUIClosedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:OnShowStoreUIClosedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnShowStoreUIClosedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnShowStoreUIClosedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnShowStoreUIClosedCS_bPurchased_Offset), 0, OnShowStoreUIClosedCS_bPurchased_PropertyAddress.Address, bPurchased);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnShowStoreUIClosedCS_FunctionAddress, intPtr, OnShowStoreUIClosedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS")]
	protected unsafe void OnQueryIsOwnAdditionContentCompleteCS(string EntitlementId, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnQueryIsOwnAdditionContentCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS");
			return;
		}
		if (OnQueryIsOwnAdditionContentCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnQueryIsOwnAdditionContentCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnQueryIsOwnAdditionContentCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnQueryIsOwnAdditionContentCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQueryIsOwnAdditionContentCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset), 0, OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress.Address, EntitlementId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset), 0, OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnQueryIsOwnAdditionContentCompleteCS_InstanceFunctionAddress, intPtr, OnQueryIsOwnAdditionContentCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnQueryIsOwnAdditionContentCompleteCS_Implementation(string EntitlementId, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnQueryIsOwnAdditionContentCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnQueryIsOwnAdditionContentCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnQueryIsOwnAdditionContentCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset), 0, OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress.Address, EntitlementId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset), 0, OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, intPtr, OnQueryIsOwnAdditionContentCompleteCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:Init")]
	public unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:Init");
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

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:GetSubsystemType")]
	public unsafe static EBGWSubsystemType GetSubsystemType()
	{
		if (!GetSubsystemType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:GetSubsystemType");
			return EBGWSubsystemType.Unknown;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubsystemType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubsystemType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSubsystemType_FunctionAddress, intPtr, GetSubsystemType_ParamsSize);
		return EnumMarshaler<EBGWSubsystemType>.FromNative(IntPtr.Add(intPtr, GetSubsystemType_ReturnValue_Offset), 0, GetSubsystemType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:GetSubsystemNameForDebug")]
	protected unsafe FName GetSubsystemNameForDebug()
	{
		CheckDestroyed();
		if (!GetSubsystemNameForDebug_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:GetSubsystemNameForDebug");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubsystemNameForDebug_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubsystemNameForDebug_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSubsystemNameForDebug_FunctionAddress, intPtr, GetSubsystemNameForDebug_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetSubsystemNameForDebug_ReturnValue_Offset), 0, GetSubsystemNameForDebug_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:GetLocalPlatformName")]
	public unsafe string GetLocalPlatformName()
	{
		CheckDestroyed();
		if (!GetLocalPlatformName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:GetLocalPlatformName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalPlatformName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalPlatformName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalPlatformName_FunctionAddress, intPtr, GetLocalPlatformName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLocalPlatformName_ReturnValue_Offset), 0, GetLocalPlatformName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLocalPlatformName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:GetInstanceName")]
	public unsafe FName GetInstanceName()
	{
		CheckDestroyed();
		if (!GetInstanceName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:GetInstanceName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstanceName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstanceName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstanceName_FunctionAddress, intPtr, GetInstanceName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetInstanceName_ReturnValue_Offset), 0, GetInstanceName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:Destroy")]
	public unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubsystem:AfterInit")]
	public unsafe int AfterInit()
	{
		CheckDestroyed();
		if (!AfterInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubsystem:AfterInit");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AfterInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AfterInit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AfterInit_FunctionAddress, intPtr, AfterInit_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AfterInit_ReturnValue_Offset), 0, AfterInit_ReturnValue_PropertyAddress.Address);
	}

	static UBGWOnlineSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineSubsystem));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWOnlineSubsystem");
		ShowStoreUI_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowStoreUI");
		ShowStoreUI_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowStoreUI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowStoreUI_ProductId_PropertyAddress, ShowStoreUI_FunctionAddress, "ProductId");
		ShowStoreUI_ProductId_Offset = NativeReflectionCached.GetPropertyOffset(ShowStoreUI_FunctionAddress, "ProductId");
		ShowStoreUI_ProductId_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowStoreUI_FunctionAddress, "ProductId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowStoreUI_AddToCard_PropertyAddress, ShowStoreUI_FunctionAddress, "AddToCard");
		ShowStoreUI_AddToCard_Offset = NativeReflectionCached.GetPropertyOffset(ShowStoreUI_FunctionAddress, "AddToCard");
		ShowStoreUI_AddToCard_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowStoreUI_FunctionAddress, "AddToCard", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowStoreUI_ReturnValue_PropertyAddress, ShowStoreUI_FunctionAddress, "ReturnValue");
		ShowStoreUI_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowStoreUI_FunctionAddress, "ReturnValue");
		ShowStoreUI_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowStoreUI_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShowStoreUI_IsValid = ShowStoreUI_FunctionAddress != IntPtr.Zero && ShowStoreUI_ProductId_IsValid && ShowStoreUI_AddToCard_IsValid && ShowStoreUI_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:ShowStoreUI", ShowStoreUI_IsValid);
		QueryUserNATType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryUserNATType");
		QueryUserNATType_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryUserNATType_FunctionAddress);
		QueryUserNATType_IsValid = QueryUserNATType_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:QueryUserNATType", QueryUserNATType_IsValid);
		QueryIsOwnAdditionContentSync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryIsOwnAdditionContentSync");
		QueryIsOwnAdditionContentSync_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryIsOwnAdditionContentSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryIsOwnAdditionContentSync_EntitlementId_PropertyAddress, QueryIsOwnAdditionContentSync_FunctionAddress, "EntitlementId");
		QueryIsOwnAdditionContentSync_EntitlementId_Offset = NativeReflectionCached.GetPropertyOffset(QueryIsOwnAdditionContentSync_FunctionAddress, "EntitlementId");
		QueryIsOwnAdditionContentSync_EntitlementId_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryIsOwnAdditionContentSync_FunctionAddress, "EntitlementId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryIsOwnAdditionContentSync_ReturnValue_PropertyAddress, QueryIsOwnAdditionContentSync_FunctionAddress, "ReturnValue");
		QueryIsOwnAdditionContentSync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryIsOwnAdditionContentSync_FunctionAddress, "ReturnValue");
		QueryIsOwnAdditionContentSync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryIsOwnAdditionContentSync_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		QueryIsOwnAdditionContentSync_IsValid = QueryIsOwnAdditionContentSync_FunctionAddress != IntPtr.Zero && QueryIsOwnAdditionContentSync_EntitlementId_IsValid && QueryIsOwnAdditionContentSync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:QueryIsOwnAdditionContentSync", QueryIsOwnAdditionContentSync_IsValid);
		QueryIsOwnAdditionContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryIsOwnAdditionContent");
		QueryIsOwnAdditionContent_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryIsOwnAdditionContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryIsOwnAdditionContent_EntitlementId_PropertyAddress, QueryIsOwnAdditionContent_FunctionAddress, "EntitlementId");
		QueryIsOwnAdditionContent_EntitlementId_Offset = NativeReflectionCached.GetPropertyOffset(QueryIsOwnAdditionContent_FunctionAddress, "EntitlementId");
		QueryIsOwnAdditionContent_EntitlementId_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryIsOwnAdditionContent_FunctionAddress, "EntitlementId", Classes.FStrProperty);
		QueryIsOwnAdditionContent_IsValid = QueryIsOwnAdditionContent_FunctionAddress != IntPtr.Zero && QueryIsOwnAdditionContent_EntitlementId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:QueryIsOwnAdditionContent", QueryIsOwnAdditionContent_IsValid);
		OnShowStoreUIClosedCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnShowStoreUIClosedCS");
		OnShowStoreUIClosedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnShowStoreUIClosedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnShowStoreUIClosedCS_bPurchased_PropertyAddress, OnShowStoreUIClosedCS_FunctionAddress, "bPurchased");
		OnShowStoreUIClosedCS_bPurchased_Offset = NativeReflectionCached.GetPropertyOffset(OnShowStoreUIClosedCS_FunctionAddress, "bPurchased");
		OnShowStoreUIClosedCS_bPurchased_IsValid = NativeReflectionCached.ValidatePropertyClass(OnShowStoreUIClosedCS_FunctionAddress, "bPurchased", Classes.FBoolProperty);
		OnShowStoreUIClosedCS_IsValid = OnShowStoreUIClosedCS_FunctionAddress != IntPtr.Zero && OnShowStoreUIClosedCS_bPurchased_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:OnShowStoreUIClosedCS", OnShowStoreUIClosedCS_IsValid);
		OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnQueryIsOwnAdditionContentCompleteCS");
		OnQueryIsOwnAdditionContentCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_PropertyAddress, OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "EntitlementId");
		OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_Offset = NativeReflectionCached.GetPropertyOffset(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "EntitlementId");
		OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "EntitlementId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_PropertyAddress, OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "bWasSuccessful");
		OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnQueryIsOwnAdditionContentCompleteCS_IsValid = OnQueryIsOwnAdditionContentCompleteCS_FunctionAddress != IntPtr.Zero && OnQueryIsOwnAdditionContentCompleteCS_EntitlementId_IsValid && OnQueryIsOwnAdditionContentCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:OnQueryIsOwnAdditionContentCompleteCS", OnQueryIsOwnAdditionContentCompleteCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:Init", Init_IsValid);
		GetSubsystemType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubsystemType");
		GetSubsystemType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubsystemType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubsystemType_ReturnValue_PropertyAddress, GetSubsystemType_FunctionAddress, "ReturnValue");
		GetSubsystemType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubsystemType_FunctionAddress, "ReturnValue");
		GetSubsystemType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubsystemType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetSubsystemType_IsValid = GetSubsystemType_FunctionAddress != IntPtr.Zero && GetSubsystemType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:GetSubsystemType", GetSubsystemType_IsValid);
		GetSubsystemNameForDebug_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubsystemNameForDebug");
		GetSubsystemNameForDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubsystemNameForDebug_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubsystemNameForDebug_ReturnValue_PropertyAddress, GetSubsystemNameForDebug_FunctionAddress, "ReturnValue");
		GetSubsystemNameForDebug_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubsystemNameForDebug_FunctionAddress, "ReturnValue");
		GetSubsystemNameForDebug_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubsystemNameForDebug_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetSubsystemNameForDebug_IsValid = GetSubsystemNameForDebug_FunctionAddress != IntPtr.Zero && GetSubsystemNameForDebug_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:GetSubsystemNameForDebug", GetSubsystemNameForDebug_IsValid);
		GetLocalPlatformName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalPlatformName");
		GetLocalPlatformName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalPlatformName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlatformName_ReturnValue_PropertyAddress, GetLocalPlatformName_FunctionAddress, "ReturnValue");
		GetLocalPlatformName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlatformName_FunctionAddress, "ReturnValue");
		GetLocalPlatformName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlatformName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLocalPlatformName_IsValid = GetLocalPlatformName_FunctionAddress != IntPtr.Zero && GetLocalPlatformName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:GetLocalPlatformName", GetLocalPlatformName_IsValid);
		GetInstanceName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInstanceName");
		GetInstanceName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstanceName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstanceName_ReturnValue_PropertyAddress, GetInstanceName_FunctionAddress, "ReturnValue");
		GetInstanceName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstanceName_FunctionAddress, "ReturnValue");
		GetInstanceName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstanceName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetInstanceName_IsValid = GetInstanceName_FunctionAddress != IntPtr.Zero && GetInstanceName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:GetInstanceName", GetInstanceName_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:Destroy", Destroy_IsValid);
		AfterInit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AfterInit");
		AfterInit_ParamsSize = NativeReflection.GetFunctionParamsSize(AfterInit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AfterInit_ReturnValue_PropertyAddress, AfterInit_FunctionAddress, "ReturnValue");
		AfterInit_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AfterInit_FunctionAddress, "ReturnValue");
		AfterInit_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AfterInit_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AfterInit_IsValid = AfterInit_FunctionAddress != IntPtr.Zero && AfterInit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubsystem:AfterInit", AfterInit_IsValid);
	}
}
