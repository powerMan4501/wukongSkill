using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWWorldSubSystem", "b1", UnrealModuleType.Game)]
public class UBGWWorldSubSystem : UWorldSubsystem
{
	private static bool PostInitializeCS_IsValid;

	private IntPtr PostInitializeCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeCS_FunctionAddress;

	private static int PostInitializeCS_ParamsSize;

	private static bool OnWorldComponentsUpdatedCS_IsValid;

	private IntPtr OnWorldComponentsUpdatedCS_InstanceFunctionAddress;

	private static IntPtr OnWorldComponentsUpdatedCS_FunctionAddress;

	private static int OnWorldComponentsUpdatedCS_ParamsSize;

	private static bool OnWorldComponentsUpdatedCS_World_IsValid;

	private static FFieldAddress OnWorldComponentsUpdatedCS_World_PropertyAddress;

	private static int OnWorldComponentsUpdatedCS_World_Offset;

	private static bool OnWorldBeginPlayCS_IsValid;

	private IntPtr OnWorldBeginPlayCS_InstanceFunctionAddress;

	private static IntPtr OnWorldBeginPlayCS_FunctionAddress;

	private static int OnWorldBeginPlayCS_ParamsSize;

	private static bool OnWorldBeginPlayCS_InWorld_IsValid;

	private static FFieldAddress OnWorldBeginPlayCS_InWorld_PropertyAddress;

	private static int OnWorldBeginPlayCS_InWorld_Offset;

	private static bool GetWorldRefCS_IsValid;

	private static IntPtr GetWorldRefCS_FunctionAddress;

	private static int GetWorldRefCS_ParamsSize;

	private static bool GetWorldRefCS_ReturnValue_IsValid;

	private static FFieldAddress GetWorldRefCS_ReturnValue_PropertyAddress;

	private static int GetWorldRefCS_ReturnValue_Offset;

	private static bool DoesSupportWorldTypeCS_IsValid;

	private IntPtr DoesSupportWorldTypeCS_InstanceFunctionAddress;

	private static IntPtr DoesSupportWorldTypeCS_FunctionAddress;

	private static int DoesSupportWorldTypeCS_ParamsSize;

	private static bool DoesSupportWorldTypeCS_WorldType_IsValid;

	private static FFieldAddress DoesSupportWorldTypeCS_WorldType_PropertyAddress;

	private static int DoesSupportWorldTypeCS_WorldType_Offset;

	private static bool DoesSupportWorldTypeCS_ReturnValue_IsValid;

	private static FFieldAddress DoesSupportWorldTypeCS_ReturnValue_PropertyAddress;

	private static int DoesSupportWorldTypeCS_ReturnValue_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWWorldSubSystem:PostInitializeCS")]
	public unsafe void PostInitializeCS()
	{
		CheckDestroyed();
		if (!PostInitializeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:PostInitializeCS");
			return;
		}
		if (PostInitializeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitializeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitializeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeCS_InstanceFunctionAddress, argsSize: PostInitializeCS_ParamsSize);
	}

	protected unsafe virtual void PostInitializeCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitializeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:PostInitializeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeCS_FunctionAddress, argsSize: PostInitializeCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWWorldSubSystem:OnWorldComponentsUpdatedCS")]
	public unsafe void OnWorldComponentsUpdatedCS(UWorld World)
	{
		CheckDestroyed();
		if (!OnWorldComponentsUpdatedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:OnWorldComponentsUpdatedCS");
			return;
		}
		if (OnWorldComponentsUpdatedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWorldComponentsUpdatedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWorldComponentsUpdatedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldComponentsUpdatedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldComponentsUpdatedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldComponentsUpdatedCS_World_Offset), 0, OnWorldComponentsUpdatedCS_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldComponentsUpdatedCS_InstanceFunctionAddress, intPtr, OnWorldComponentsUpdatedCS_ParamsSize);
	}

	protected unsafe virtual void OnWorldComponentsUpdatedCS_Implementation(UWorld World)
	{
		CheckDestroyed();
		if (!OnWorldComponentsUpdatedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:OnWorldComponentsUpdatedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldComponentsUpdatedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldComponentsUpdatedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldComponentsUpdatedCS_World_Offset), 0, OnWorldComponentsUpdatedCS_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldComponentsUpdatedCS_FunctionAddress, intPtr, OnWorldComponentsUpdatedCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWWorldSubSystem:OnWorldBeginPlayCS")]
	public unsafe void OnWorldBeginPlayCS(UWorld InWorld)
	{
		CheckDestroyed();
		if (!OnWorldBeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:OnWorldBeginPlayCS");
			return;
		}
		if (OnWorldBeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWorldBeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWorldBeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldBeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldBeginPlayCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldBeginPlayCS_InWorld_Offset), 0, OnWorldBeginPlayCS_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldBeginPlayCS_InstanceFunctionAddress, intPtr, OnWorldBeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void OnWorldBeginPlayCS_Implementation(UWorld InWorld)
	{
		CheckDestroyed();
		if (!OnWorldBeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:OnWorldBeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWorldBeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWorldBeginPlayCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnWorldBeginPlayCS_InWorld_Offset), 0, OnWorldBeginPlayCS_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWorldBeginPlayCS_FunctionAddress, intPtr, OnWorldBeginPlayCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWWorldSubSystem:GetWorldRefCS")]
	public unsafe UWorld GetWorldRefCS()
	{
		CheckDestroyed();
		if (!GetWorldRefCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:GetWorldRefCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldRefCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldRefCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldRefCS_FunctionAddress, intPtr, GetWorldRefCS_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetWorldRefCS_ReturnValue_Offset), 0, GetWorldRefCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.BGWWorldSubSystem:DoesSupportWorldTypeCS")]
	public unsafe bool DoesSupportWorldTypeCS(int WorldType)
	{
		CheckDestroyed();
		if (!DoesSupportWorldTypeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:DoesSupportWorldTypeCS");
			return false;
		}
		if (DoesSupportWorldTypeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			DoesSupportWorldTypeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DoesSupportWorldTypeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesSupportWorldTypeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesSupportWorldTypeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DoesSupportWorldTypeCS_WorldType_Offset), 0, DoesSupportWorldTypeCS_WorldType_PropertyAddress.Address, WorldType);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoesSupportWorldTypeCS_InstanceFunctionAddress, intPtr, DoesSupportWorldTypeCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesSupportWorldTypeCS_ReturnValue_Offset), 0, DoesSupportWorldTypeCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool DoesSupportWorldTypeCS_Implementation(int WorldType)
	{
		CheckDestroyed();
		if (!DoesSupportWorldTypeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWWorldSubSystem:DoesSupportWorldTypeCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesSupportWorldTypeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesSupportWorldTypeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DoesSupportWorldTypeCS_WorldType_Offset), 0, DoesSupportWorldTypeCS_WorldType_PropertyAddress.Address, WorldType);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoesSupportWorldTypeCS_FunctionAddress, intPtr, DoesSupportWorldTypeCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesSupportWorldTypeCS_ReturnValue_Offset), 0, DoesSupportWorldTypeCS_ReturnValue_PropertyAddress.Address);
	}

	static UBGWWorldSubSystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWWorldSubSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWWorldSubSystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWWorldSubSystem");
		PostInitializeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostInitializeCS");
		PostInitializeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeCS_FunctionAddress);
		PostInitializeCS_IsValid = PostInitializeCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWWorldSubSystem:PostInitializeCS", PostInitializeCS_IsValid);
		OnWorldComponentsUpdatedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldComponentsUpdatedCS");
		OnWorldComponentsUpdatedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldComponentsUpdatedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWorldComponentsUpdatedCS_World_PropertyAddress, OnWorldComponentsUpdatedCS_FunctionAddress, "World");
		OnWorldComponentsUpdatedCS_World_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldComponentsUpdatedCS_FunctionAddress, "World");
		OnWorldComponentsUpdatedCS_World_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldComponentsUpdatedCS_FunctionAddress, "World", Classes.FObjectProperty);
		OnWorldComponentsUpdatedCS_IsValid = OnWorldComponentsUpdatedCS_FunctionAddress != IntPtr.Zero && OnWorldComponentsUpdatedCS_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWWorldSubSystem:OnWorldComponentsUpdatedCS", OnWorldComponentsUpdatedCS_IsValid);
		OnWorldBeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldBeginPlayCS");
		OnWorldBeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldBeginPlayCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWorldBeginPlayCS_InWorld_PropertyAddress, OnWorldBeginPlayCS_FunctionAddress, "InWorld");
		OnWorldBeginPlayCS_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(OnWorldBeginPlayCS_FunctionAddress, "InWorld");
		OnWorldBeginPlayCS_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWorldBeginPlayCS_FunctionAddress, "InWorld", Classes.FObjectProperty);
		OnWorldBeginPlayCS_IsValid = OnWorldBeginPlayCS_FunctionAddress != IntPtr.Zero && OnWorldBeginPlayCS_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWWorldSubSystem:OnWorldBeginPlayCS", OnWorldBeginPlayCS_IsValid);
		GetWorldRefCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorldRefCS");
		GetWorldRefCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldRefCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldRefCS_ReturnValue_PropertyAddress, GetWorldRefCS_FunctionAddress, "ReturnValue");
		GetWorldRefCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldRefCS_FunctionAddress, "ReturnValue");
		GetWorldRefCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldRefCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldRefCS_IsValid = GetWorldRefCS_FunctionAddress != IntPtr.Zero && GetWorldRefCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWWorldSubSystem:GetWorldRefCS", GetWorldRefCS_IsValid);
		DoesSupportWorldTypeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoesSupportWorldTypeCS");
		DoesSupportWorldTypeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesSupportWorldTypeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesSupportWorldTypeCS_WorldType_PropertyAddress, DoesSupportWorldTypeCS_FunctionAddress, "WorldType");
		DoesSupportWorldTypeCS_WorldType_Offset = NativeReflectionCached.GetPropertyOffset(DoesSupportWorldTypeCS_FunctionAddress, "WorldType");
		DoesSupportWorldTypeCS_WorldType_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesSupportWorldTypeCS_FunctionAddress, "WorldType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesSupportWorldTypeCS_ReturnValue_PropertyAddress, DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue");
		DoesSupportWorldTypeCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue");
		DoesSupportWorldTypeCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesSupportWorldTypeCS_IsValid = DoesSupportWorldTypeCS_FunctionAddress != IntPtr.Zero && DoesSupportWorldTypeCS_WorldType_IsValid && DoesSupportWorldTypeCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWWorldSubSystem:DoesSupportWorldTypeCS", DoesSupportWorldTypeCS_IsValid);
	}
}
