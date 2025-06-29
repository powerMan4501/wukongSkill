using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.NavMovementComponent", "Engine", UnrealModuleType.Engine)]
public class UNavMovementComponent : UMovementComponent
{
	private static bool NavAgentProps_IsValid;

	private static int NavAgentProps_Offset;

	private static bool StopMovementKeepPathing_IsValid;

	private static IntPtr StopMovementKeepPathing_FunctionAddress;

	private static int StopMovementKeepPathing_ParamsSize;

	private static bool StopActiveMovement_IsValid;

	private static IntPtr StopActiveMovement_FunctionAddress;

	private static int StopActiveMovement_ParamsSize;

	private static bool IsSwimming_IsValid;

	private static IntPtr IsSwimming_FunctionAddress;

	private static int IsSwimming_ParamsSize;

	private static bool IsSwimming_ReturnValue_IsValid;

	private static FFieldAddress IsSwimming_ReturnValue_PropertyAddress;

	private static int IsSwimming_ReturnValue_Offset;

	private static bool IsMovingOnGround_IsValid;

	private static IntPtr IsMovingOnGround_FunctionAddress;

	private static int IsMovingOnGround_ParamsSize;

	private static bool IsMovingOnGround_ReturnValue_IsValid;

	private static FFieldAddress IsMovingOnGround_ReturnValue_PropertyAddress;

	private static int IsMovingOnGround_ReturnValue_Offset;

	private static bool IsFlying_IsValid;

	private static IntPtr IsFlying_FunctionAddress;

	private static int IsFlying_ParamsSize;

	private static bool IsFlying_ReturnValue_IsValid;

	private static FFieldAddress IsFlying_ReturnValue_PropertyAddress;

	private static int IsFlying_ReturnValue_Offset;

	private static bool IsFalling_IsValid;

	private static IntPtr IsFalling_FunctionAddress;

	private static int IsFalling_ParamsSize;

	private static bool IsFalling_ReturnValue_IsValid;

	private static FFieldAddress IsFalling_ReturnValue_PropertyAddress;

	private static int IsFalling_ReturnValue_Offset;

	private static bool IsCrouching_IsValid;

	private static IntPtr IsCrouching_FunctionAddress;

	private static int IsCrouching_ParamsSize;

	private static bool IsCrouching_ReturnValue_IsValid;

	private static FFieldAddress IsCrouching_ReturnValue_PropertyAddress;

	private static int IsCrouching_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/Engine.NavMovementComponent:NavAgentProps")]
	public FNavAgentProperties NavAgentProps
	{
		get
		{
			CheckDestroyed();
			if (!NavAgentProps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.NavMovementComponent:NavAgentProps");
				return default(FNavAgentProperties);
			}
			return FNavAgentProperties.FromNative(IntPtr.Add(base.Address, NavAgentProps_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NavAgentProps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.NavMovementComponent:NavAgentProps");
			}
			else
			{
				FNavAgentProperties.ToNative(IntPtr.Add(base.Address, NavAgentProps_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:StopMovementKeepPathing")]
	public unsafe void StopMovementKeepPathing()
	{
		CheckDestroyed();
		if (!StopMovementKeepPathing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:StopMovementKeepPathing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopMovementKeepPathing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopMovementKeepPathing_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopMovementKeepPathing_FunctionAddress, argsSize: StopMovementKeepPathing_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:StopActiveMovement")]
	public unsafe void StopActiveMovement()
	{
		CheckDestroyed();
		if (!StopActiveMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:StopActiveMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopActiveMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopActiveMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopActiveMovement_FunctionAddress, argsSize: StopActiveMovement_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:IsSwimming")]
	public unsafe bool IsSwimming()
	{
		CheckDestroyed();
		if (!IsSwimming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:IsSwimming");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSwimming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSwimming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSwimming_FunctionAddress, intPtr, IsSwimming_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSwimming_ReturnValue_Offset), 0, IsSwimming_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:IsMovingOnGround")]
	public unsafe bool IsMovingOnGround()
	{
		CheckDestroyed();
		if (!IsMovingOnGround_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:IsMovingOnGround");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMovingOnGround_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMovingOnGround_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMovingOnGround_FunctionAddress, intPtr, IsMovingOnGround_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMovingOnGround_ReturnValue_Offset), 0, IsMovingOnGround_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:IsFlying")]
	public unsafe bool IsFlying()
	{
		CheckDestroyed();
		if (!IsFlying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:IsFlying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsFlying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsFlying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsFlying_FunctionAddress, intPtr, IsFlying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsFlying_ReturnValue_Offset), 0, IsFlying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:IsFalling")]
	public unsafe bool IsFalling()
	{
		CheckDestroyed();
		if (!IsFalling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:IsFalling");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsFalling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsFalling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsFalling_FunctionAddress, intPtr, IsFalling_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsFalling_ReturnValue_Offset), 0, IsFalling_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.NavMovementComponent:IsCrouching")]
	public unsafe bool IsCrouching()
	{
		CheckDestroyed();
		if (!IsCrouching_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.NavMovementComponent:IsCrouching");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCrouching_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCrouching_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCrouching_FunctionAddress, intPtr, IsCrouching_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCrouching_ReturnValue_Offset), 0, IsCrouching_ReturnValue_PropertyAddress.Address);
	}

	static UNavMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNavMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNavMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.NavMovementComponent");
		NavAgentProps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavAgentProps");
		NavAgentProps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavAgentProps", Classes.FStructProperty);
		StopMovementKeepPathing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopMovementKeepPathing");
		StopMovementKeepPathing_ParamsSize = NativeReflection.GetFunctionParamsSize(StopMovementKeepPathing_FunctionAddress);
		StopMovementKeepPathing_IsValid = StopMovementKeepPathing_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:StopMovementKeepPathing", StopMovementKeepPathing_IsValid);
		StopActiveMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopActiveMovement");
		StopActiveMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(StopActiveMovement_FunctionAddress);
		StopActiveMovement_IsValid = StopActiveMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:StopActiveMovement", StopActiveMovement_IsValid);
		IsSwimming_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSwimming");
		IsSwimming_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSwimming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSwimming_ReturnValue_PropertyAddress, IsSwimming_FunctionAddress, "ReturnValue");
		IsSwimming_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSwimming_FunctionAddress, "ReturnValue");
		IsSwimming_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSwimming_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSwimming_IsValid = IsSwimming_FunctionAddress != IntPtr.Zero && IsSwimming_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:IsSwimming", IsSwimming_IsValid);
		IsMovingOnGround_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMovingOnGround");
		IsMovingOnGround_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMovingOnGround_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMovingOnGround_ReturnValue_PropertyAddress, IsMovingOnGround_FunctionAddress, "ReturnValue");
		IsMovingOnGround_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMovingOnGround_FunctionAddress, "ReturnValue");
		IsMovingOnGround_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMovingOnGround_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMovingOnGround_IsValid = IsMovingOnGround_FunctionAddress != IntPtr.Zero && IsMovingOnGround_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:IsMovingOnGround", IsMovingOnGround_IsValid);
		IsFlying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsFlying");
		IsFlying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsFlying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsFlying_ReturnValue_PropertyAddress, IsFlying_FunctionAddress, "ReturnValue");
		IsFlying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsFlying_FunctionAddress, "ReturnValue");
		IsFlying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFlying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsFlying_IsValid = IsFlying_FunctionAddress != IntPtr.Zero && IsFlying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:IsFlying", IsFlying_IsValid);
		IsFalling_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsFalling");
		IsFalling_ParamsSize = NativeReflection.GetFunctionParamsSize(IsFalling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsFalling_ReturnValue_PropertyAddress, IsFalling_FunctionAddress, "ReturnValue");
		IsFalling_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsFalling_FunctionAddress, "ReturnValue");
		IsFalling_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFalling_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsFalling_IsValid = IsFalling_FunctionAddress != IntPtr.Zero && IsFalling_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:IsFalling", IsFalling_IsValid);
		IsCrouching_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsCrouching");
		IsCrouching_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCrouching_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCrouching_ReturnValue_PropertyAddress, IsCrouching_FunctionAddress, "ReturnValue");
		IsCrouching_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCrouching_FunctionAddress, "ReturnValue");
		IsCrouching_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCrouching_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCrouching_IsValid = IsCrouching_FunctionAddress != IntPtr.Zero && IsCrouching_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.NavMovementComponent:IsCrouching", IsCrouching_IsValid);
	}
}
