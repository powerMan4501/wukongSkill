using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PawnMovementComponent", "Engine", UnrealModuleType.Engine)]
public class UPawnMovementComponent : UNavMovementComponent
{
	private static bool IsMoveInputIgnored_IsValid;

	private static IntPtr IsMoveInputIgnored_FunctionAddress;

	private static int IsMoveInputIgnored_ParamsSize;

	private static bool IsMoveInputIgnored_ReturnValue_IsValid;

	private static FFieldAddress IsMoveInputIgnored_ReturnValue_PropertyAddress;

	private static int IsMoveInputIgnored_ReturnValue_Offset;

	private static bool GetPendingInputVector_IsValid;

	private static IntPtr GetPendingInputVector_FunctionAddress;

	private static int GetPendingInputVector_ParamsSize;

	private static bool GetPendingInputVector_ReturnValue_IsValid;

	private static FFieldAddress GetPendingInputVector_ReturnValue_PropertyAddress;

	private static int GetPendingInputVector_ReturnValue_Offset;

	private static bool GetPawnOwner_IsValid;

	private static IntPtr GetPawnOwner_FunctionAddress;

	private static int GetPawnOwner_ParamsSize;

	private static bool GetPawnOwner_ReturnValue_IsValid;

	private static FFieldAddress GetPawnOwner_ReturnValue_PropertyAddress;

	private static int GetPawnOwner_ReturnValue_Offset;

	private static bool GetLastInputVector_IsValid;

	private static IntPtr GetLastInputVector_FunctionAddress;

	private static int GetLastInputVector_ParamsSize;

	private static bool GetLastInputVector_ReturnValue_IsValid;

	private static FFieldAddress GetLastInputVector_ReturnValue_PropertyAddress;

	private static int GetLastInputVector_ReturnValue_Offset;

	private static bool ConsumeInputVector_IsValid;

	private static IntPtr ConsumeInputVector_FunctionAddress;

	private static int ConsumeInputVector_ParamsSize;

	private static bool ConsumeInputVector_ReturnValue_IsValid;

	private static FFieldAddress ConsumeInputVector_ReturnValue_PropertyAddress;

	private static int ConsumeInputVector_ReturnValue_Offset;

	private static bool AddInputVector_IsValid;

	private static IntPtr AddInputVector_FunctionAddress;

	private static int AddInputVector_ParamsSize;

	private static bool AddInputVector_WorldVector_IsValid;

	private static FFieldAddress AddInputVector_WorldVector_PropertyAddress;

	private static int AddInputVector_WorldVector_Offset;

	private static bool AddInputVector_bForce_IsValid;

	private static FFieldAddress AddInputVector_bForce_PropertyAddress;

	private static int AddInputVector_bForce_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PawnMovementComponent:IsMoveInputIgnored")]
	public unsafe bool IsMoveInputIgnored()
	{
		CheckDestroyed();
		if (!IsMoveInputIgnored_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnMovementComponent:IsMoveInputIgnored");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMoveInputIgnored_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMoveInputIgnored_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMoveInputIgnored_FunctionAddress, intPtr, IsMoveInputIgnored_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMoveInputIgnored_ReturnValue_Offset), 0, IsMoveInputIgnored_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PawnMovementComponent:GetPendingInputVector")]
	public unsafe FVector GetPendingInputVector()
	{
		CheckDestroyed();
		if (!GetPendingInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnMovementComponent:GetPendingInputVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPendingInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPendingInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPendingInputVector_FunctionAddress, intPtr, GetPendingInputVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPendingInputVector_ReturnValue_Offset), 0, GetPendingInputVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PawnMovementComponent:GetPawnOwner")]
	public unsafe APawn GetPawnOwner()
	{
		CheckDestroyed();
		if (!GetPawnOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnMovementComponent:GetPawnOwner");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPawnOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPawnOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPawnOwner_FunctionAddress, intPtr, GetPawnOwner_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, GetPawnOwner_ReturnValue_Offset), 0, GetPawnOwner_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PawnMovementComponent:GetLastInputVector")]
	public unsafe FVector GetLastInputVector()
	{
		CheckDestroyed();
		if (!GetLastInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnMovementComponent:GetLastInputVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastInputVector_FunctionAddress, intPtr, GetLastInputVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastInputVector_ReturnValue_Offset), 0, GetLastInputVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PawnMovementComponent:ConsumeInputVector")]
	public unsafe FVector ConsumeInputVector()
	{
		CheckDestroyed();
		if (!ConsumeInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnMovementComponent:ConsumeInputVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsumeInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsumeInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConsumeInputVector_FunctionAddress, intPtr, ConsumeInputVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ConsumeInputVector_ReturnValue_Offset), 0, ConsumeInputVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PawnMovementComponent:AddInputVector")]
	public unsafe void AddInputVector(FVector WorldVector, bool bForce = false)
	{
		CheckDestroyed();
		if (!AddInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PawnMovementComponent:AddInputVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddInputVector_WorldVector_Offset), 0, AddInputVector_WorldVector_PropertyAddress.Address, WorldVector);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInputVector_bForce_Offset), 0, AddInputVector_bForce_PropertyAddress.Address, bForce);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInputVector_FunctionAddress, intPtr, AddInputVector_ParamsSize);
	}

	static UPawnMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPawnMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPawnMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.PawnMovementComponent");
		IsMoveInputIgnored_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsMoveInputIgnored");
		IsMoveInputIgnored_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMoveInputIgnored_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMoveInputIgnored_ReturnValue_PropertyAddress, IsMoveInputIgnored_FunctionAddress, "ReturnValue");
		IsMoveInputIgnored_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMoveInputIgnored_FunctionAddress, "ReturnValue");
		IsMoveInputIgnored_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMoveInputIgnored_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMoveInputIgnored_IsValid = IsMoveInputIgnored_FunctionAddress != IntPtr.Zero && IsMoveInputIgnored_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnMovementComponent:IsMoveInputIgnored", IsMoveInputIgnored_IsValid);
		GetPendingInputVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPendingInputVector");
		GetPendingInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPendingInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPendingInputVector_ReturnValue_PropertyAddress, GetPendingInputVector_FunctionAddress, "ReturnValue");
		GetPendingInputVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPendingInputVector_FunctionAddress, "ReturnValue");
		GetPendingInputVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPendingInputVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPendingInputVector_IsValid = GetPendingInputVector_FunctionAddress != IntPtr.Zero && GetPendingInputVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnMovementComponent:GetPendingInputVector", GetPendingInputVector_IsValid);
		GetPawnOwner_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPawnOwner");
		GetPawnOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPawnOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPawnOwner_ReturnValue_PropertyAddress, GetPawnOwner_FunctionAddress, "ReturnValue");
		GetPawnOwner_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPawnOwner_FunctionAddress, "ReturnValue");
		GetPawnOwner_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPawnOwner_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPawnOwner_IsValid = GetPawnOwner_FunctionAddress != IntPtr.Zero && GetPawnOwner_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnMovementComponent:GetPawnOwner", GetPawnOwner_IsValid);
		GetLastInputVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLastInputVector");
		GetLastInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastInputVector_ReturnValue_PropertyAddress, GetLastInputVector_FunctionAddress, "ReturnValue");
		GetLastInputVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastInputVector_FunctionAddress, "ReturnValue");
		GetLastInputVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastInputVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastInputVector_IsValid = GetLastInputVector_FunctionAddress != IntPtr.Zero && GetLastInputVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnMovementComponent:GetLastInputVector", GetLastInputVector_IsValid);
		ConsumeInputVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ConsumeInputVector");
		ConsumeInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsumeInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsumeInputVector_ReturnValue_PropertyAddress, ConsumeInputVector_FunctionAddress, "ReturnValue");
		ConsumeInputVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConsumeInputVector_FunctionAddress, "ReturnValue");
		ConsumeInputVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsumeInputVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConsumeInputVector_IsValid = ConsumeInputVector_FunctionAddress != IntPtr.Zero && ConsumeInputVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnMovementComponent:ConsumeInputVector", ConsumeInputVector_IsValid);
		AddInputVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddInputVector");
		AddInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInputVector_WorldVector_PropertyAddress, AddInputVector_FunctionAddress, "WorldVector");
		AddInputVector_WorldVector_Offset = NativeReflectionCached.GetPropertyOffset(AddInputVector_FunctionAddress, "WorldVector");
		AddInputVector_WorldVector_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputVector_FunctionAddress, "WorldVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInputVector_bForce_PropertyAddress, AddInputVector_FunctionAddress, "bForce");
		AddInputVector_bForce_Offset = NativeReflectionCached.GetPropertyOffset(AddInputVector_FunctionAddress, "bForce");
		AddInputVector_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputVector_FunctionAddress, "bForce", Classes.FBoolProperty);
		AddInputVector_IsValid = AddInputVector_FunctionAddress != IntPtr.Zero && AddInputVector_WorldVector_IsValid && AddInputVector_bForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PawnMovementComponent:AddInputVector", AddInputVector_IsValid);
	}
}
