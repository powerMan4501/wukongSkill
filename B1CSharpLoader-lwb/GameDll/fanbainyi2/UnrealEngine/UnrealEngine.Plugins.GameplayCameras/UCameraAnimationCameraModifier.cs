using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.TemplateSequence;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Camera")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public class UCameraAnimationCameraModifier : UCameraModifier
{
	private static IntPtr classAddress;

	private static bool StopCameraAnimation_IsValid;

	private static IntPtr StopCameraAnimation_FunctionAddress;

	private static int StopCameraAnimation_ParamsSize;

	private static bool StopCameraAnimation_Handle_IsValid;

	private static FFieldAddress StopCameraAnimation_Handle_PropertyAddress;

	private static int StopCameraAnimation_Handle_Offset;

	private static bool StopCameraAnimation_bImmediate_IsValid;

	private static FFieldAddress StopCameraAnimation_bImmediate_PropertyAddress;

	private static int StopCameraAnimation_bImmediate_Offset;

	private static bool StopAllCameraAnimationsOf_IsValid;

	private static IntPtr StopAllCameraAnimationsOf_FunctionAddress;

	private static int StopAllCameraAnimationsOf_ParamsSize;

	private static bool StopAllCameraAnimationsOf_Sequence_IsValid;

	private static FFieldAddress StopAllCameraAnimationsOf_Sequence_PropertyAddress;

	private static int StopAllCameraAnimationsOf_Sequence_Offset;

	private static bool StopAllCameraAnimationsOf_bImmediate_IsValid;

	private static FFieldAddress StopAllCameraAnimationsOf_bImmediate_PropertyAddress;

	private static int StopAllCameraAnimationsOf_bImmediate_Offset;

	private static bool StopAllCameraAnimations_IsValid;

	private static IntPtr StopAllCameraAnimations_FunctionAddress;

	private static int StopAllCameraAnimations_ParamsSize;

	private static bool StopAllCameraAnimations_bImmediate_IsValid;

	private static FFieldAddress StopAllCameraAnimations_bImmediate_PropertyAddress;

	private static int StopAllCameraAnimations_bImmediate_Offset;

	private static bool PlayCameraAnimation_IsValid;

	private static IntPtr PlayCameraAnimation_FunctionAddress;

	private static int PlayCameraAnimation_ParamsSize;

	private static bool PlayCameraAnimation_Sequence_IsValid;

	private static FFieldAddress PlayCameraAnimation_Sequence_PropertyAddress;

	private static int PlayCameraAnimation_Sequence_Offset;

	private static bool PlayCameraAnimation_Params_IsValid;

	private static FFieldAddress PlayCameraAnimation_Params_PropertyAddress;

	private static int PlayCameraAnimation_Params_Offset;

	private static bool PlayCameraAnimation_ReturnValue_IsValid;

	private static FFieldAddress PlayCameraAnimation_ReturnValue_PropertyAddress;

	private static int PlayCameraAnimation_ReturnValue_Offset;

	private static bool IsCameraAnimationActive_IsValid;

	private static IntPtr IsCameraAnimationActive_FunctionAddress;

	private static int IsCameraAnimationActive_ParamsSize;

	private static bool IsCameraAnimationActive_Handle_IsValid;

	private static FFieldAddress IsCameraAnimationActive_Handle_PropertyAddress;

	private static int IsCameraAnimationActive_Handle_Offset;

	private static bool IsCameraAnimationActive_ReturnValue_IsValid;

	private static FFieldAddress IsCameraAnimationActive_ReturnValue_PropertyAddress;

	private static int IsCameraAnimationActive_ReturnValue_Offset;

	private static bool GetCameraAnimationCameraModifierFromPlayerController_IsValid;

	private static IntPtr GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress;

	private static int GetCameraAnimationCameraModifierFromPlayerController_ParamsSize;

	private static bool GetCameraAnimationCameraModifierFromPlayerController_PlayerController_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifierFromPlayerController_PlayerController_PropertyAddress;

	private static int GetCameraAnimationCameraModifierFromPlayerController_PlayerController_Offset;

	private static bool GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_PropertyAddress;

	private static int GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_Offset;

	private static bool GetCameraAnimationCameraModifierFromID_IsValid;

	private static IntPtr GetCameraAnimationCameraModifierFromID_FunctionAddress;

	private static int GetCameraAnimationCameraModifierFromID_ParamsSize;

	private static bool GetCameraAnimationCameraModifierFromID_WorldContextObject_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifierFromID_WorldContextObject_PropertyAddress;

	private static int GetCameraAnimationCameraModifierFromID_WorldContextObject_Offset;

	private static bool GetCameraAnimationCameraModifierFromID_ControllerID_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifierFromID_ControllerID_PropertyAddress;

	private static int GetCameraAnimationCameraModifierFromID_ControllerID_Offset;

	private static bool GetCameraAnimationCameraModifierFromID_ReturnValue_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifierFromID_ReturnValue_PropertyAddress;

	private static int GetCameraAnimationCameraModifierFromID_ReturnValue_Offset;

	private static bool GetCameraAnimationCameraModifier_IsValid;

	private static IntPtr GetCameraAnimationCameraModifier_FunctionAddress;

	private static int GetCameraAnimationCameraModifier_ParamsSize;

	private static bool GetCameraAnimationCameraModifier_WorldContextObject_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifier_WorldContextObject_PropertyAddress;

	private static int GetCameraAnimationCameraModifier_WorldContextObject_Offset;

	private static bool GetCameraAnimationCameraModifier_PlayerIndex_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifier_PlayerIndex_PropertyAddress;

	private static int GetCameraAnimationCameraModifier_PlayerIndex_Offset;

	private static bool GetCameraAnimationCameraModifier_ReturnValue_IsValid;

	private static FFieldAddress GetCameraAnimationCameraModifier_ReturnValue_PropertyAddress;

	private static int GetCameraAnimationCameraModifier_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:StopCameraAnimation")]
	public unsafe void StopCameraAnimation(FCameraAnimationHandle Handle, bool bImmediate = false)
	{
		CheckDestroyed();
		if (!StopCameraAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:StopCameraAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCameraAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCameraAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StopCameraAnimation_Handle_PropertyAddress.Address, intPtr);
		FCameraAnimationHandle.ToNative(IntPtr.Add(intPtr, StopCameraAnimation_Handle_Offset), 0, StopCameraAnimation_Handle_PropertyAddress.Address, Handle);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopCameraAnimation_bImmediate_Offset), 0, StopCameraAnimation_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopCameraAnimation_FunctionAddress, intPtr, StopCameraAnimation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:StopAllCameraAnimationsOf")]
	public unsafe void StopAllCameraAnimationsOf(UCameraAnimationSequence Sequence, bool bImmediate = false)
	{
		CheckDestroyed();
		if (!StopAllCameraAnimationsOf_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:StopAllCameraAnimationsOf");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraAnimationsOf_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraAnimationsOf_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraAnimationSequence>.ToNative(IntPtr.Add(intPtr, StopAllCameraAnimationsOf_Sequence_Offset), 0, StopAllCameraAnimationsOf_Sequence_PropertyAddress.Address, Sequence);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraAnimationsOf_bImmediate_Offset), 0, StopAllCameraAnimationsOf_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraAnimationsOf_FunctionAddress, intPtr, StopAllCameraAnimationsOf_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:StopAllCameraAnimations")]
	public unsafe void StopAllCameraAnimations(bool bImmediate = false)
	{
		CheckDestroyed();
		if (!StopAllCameraAnimations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:StopAllCameraAnimations");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraAnimations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraAnimations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraAnimations_bImmediate_Offset), 0, StopAllCameraAnimations_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraAnimations_FunctionAddress, intPtr, StopAllCameraAnimations_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:PlayCameraAnimation")]
	public unsafe FCameraAnimationHandle PlayCameraAnimation(UCameraAnimationSequence Sequence, FCameraAnimationParams Params)
	{
		CheckDestroyed();
		if (!PlayCameraAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:PlayCameraAnimation");
			return default(FCameraAnimationHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayCameraAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayCameraAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraAnimationSequence>.ToNative(IntPtr.Add(intPtr, PlayCameraAnimation_Sequence_Offset), 0, PlayCameraAnimation_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InitializeValue_InContainer(PlayCameraAnimation_Params_PropertyAddress.Address, intPtr);
		FCameraAnimationParams.ToNative(IntPtr.Add(intPtr, PlayCameraAnimation_Params_Offset), 0, PlayCameraAnimation_Params_PropertyAddress.Address, Params);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayCameraAnimation_FunctionAddress, intPtr, PlayCameraAnimation_ParamsSize);
		return FCameraAnimationHandle.FromNative(IntPtr.Add(intPtr, PlayCameraAnimation_ReturnValue_Offset), 0, PlayCameraAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:IsCameraAnimationActive")]
	public unsafe bool IsCameraAnimationActive(FCameraAnimationHandle Handle)
	{
		CheckDestroyed();
		if (!IsCameraAnimationActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:IsCameraAnimationActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCameraAnimationActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCameraAnimationActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsCameraAnimationActive_Handle_PropertyAddress.Address, intPtr);
		FCameraAnimationHandle.ToNative(IntPtr.Add(intPtr, IsCameraAnimationActive_Handle_Offset), 0, IsCameraAnimationActive_Handle_PropertyAddress.Address, Handle);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCameraAnimationActive_FunctionAddress, intPtr, IsCameraAnimationActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCameraAnimationActive_ReturnValue_Offset), 0, IsCameraAnimationActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifierFromPlayerController")]
	public unsafe static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromPlayerController(APlayerController PlayerController)
	{
		if (!GetCameraAnimationCameraModifierFromPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifierFromPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraAnimationCameraModifierFromPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraAnimationCameraModifierFromPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifierFromPlayerController_PlayerController_Offset), 0, GetCameraAnimationCameraModifierFromPlayerController_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, intPtr, GetCameraAnimationCameraModifierFromPlayerController_ParamsSize);
		return UObjectMarshaler<UCameraAnimationCameraModifier>.FromNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_Offset), 0, GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifierFromID")]
	public unsafe static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromID(UObject WorldContextObject, int ControllerID)
	{
		if (!GetCameraAnimationCameraModifierFromID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifierFromID");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraAnimationCameraModifierFromID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraAnimationCameraModifierFromID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifierFromID_WorldContextObject_Offset), 0, GetCameraAnimationCameraModifierFromID_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifierFromID_ControllerID_Offset), 0, GetCameraAnimationCameraModifierFromID_ControllerID_PropertyAddress.Address, ControllerID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCameraAnimationCameraModifierFromID_FunctionAddress, intPtr, GetCameraAnimationCameraModifierFromID_ParamsSize);
		return UObjectMarshaler<UCameraAnimationCameraModifier>.FromNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifierFromID_ReturnValue_Offset), 0, GetCameraAnimationCameraModifierFromID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifier")]
	public unsafe static UCameraAnimationCameraModifier GetCameraAnimationCameraModifier(UObject WorldContextObject, int PlayerIndex)
	{
		if (!GetCameraAnimationCameraModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifier");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraAnimationCameraModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraAnimationCameraModifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifier_WorldContextObject_Offset), 0, GetCameraAnimationCameraModifier_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifier_PlayerIndex_Offset), 0, GetCameraAnimationCameraModifier_PlayerIndex_PropertyAddress.Address, PlayerIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCameraAnimationCameraModifier_FunctionAddress, intPtr, GetCameraAnimationCameraModifier_ParamsSize);
		return UObjectMarshaler<UCameraAnimationCameraModifier>.FromNative(IntPtr.Add(intPtr, GetCameraAnimationCameraModifier_ReturnValue_Offset), 0, GetCameraAnimationCameraModifier_ReturnValue_PropertyAddress.Address);
	}

	static UCameraAnimationCameraModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraAnimationCameraModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraAnimationCameraModifier));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GameplayCameras.CameraAnimationCameraModifier");
		StopCameraAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopCameraAnimation");
		StopCameraAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCameraAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopCameraAnimation_Handle_PropertyAddress, StopCameraAnimation_FunctionAddress, "Handle");
		StopCameraAnimation_Handle_Offset = NativeReflectionCached.GetPropertyOffset(StopCameraAnimation_FunctionAddress, "Handle");
		StopCameraAnimation_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCameraAnimation_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StopCameraAnimation_bImmediate_PropertyAddress, StopCameraAnimation_FunctionAddress, "bImmediate");
		StopCameraAnimation_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(StopCameraAnimation_FunctionAddress, "bImmediate");
		StopCameraAnimation_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCameraAnimation_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		StopCameraAnimation_IsValid = StopCameraAnimation_FunctionAddress != IntPtr.Zero && StopCameraAnimation_Handle_IsValid && StopCameraAnimation_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:StopCameraAnimation", StopCameraAnimation_IsValid);
		StopAllCameraAnimationsOf_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAllCameraAnimationsOf");
		StopAllCameraAnimationsOf_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraAnimationsOf_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraAnimationsOf_Sequence_PropertyAddress, StopAllCameraAnimationsOf_FunctionAddress, "Sequence");
		StopAllCameraAnimationsOf_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraAnimationsOf_FunctionAddress, "Sequence");
		StopAllCameraAnimationsOf_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraAnimationsOf_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraAnimationsOf_bImmediate_PropertyAddress, StopAllCameraAnimationsOf_FunctionAddress, "bImmediate");
		StopAllCameraAnimationsOf_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraAnimationsOf_FunctionAddress, "bImmediate");
		StopAllCameraAnimationsOf_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraAnimationsOf_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		StopAllCameraAnimationsOf_IsValid = StopAllCameraAnimationsOf_FunctionAddress != IntPtr.Zero && StopAllCameraAnimationsOf_Sequence_IsValid && StopAllCameraAnimationsOf_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:StopAllCameraAnimationsOf", StopAllCameraAnimationsOf_IsValid);
		StopAllCameraAnimations_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAllCameraAnimations");
		StopAllCameraAnimations_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraAnimations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraAnimations_bImmediate_PropertyAddress, StopAllCameraAnimations_FunctionAddress, "bImmediate");
		StopAllCameraAnimations_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraAnimations_FunctionAddress, "bImmediate");
		StopAllCameraAnimations_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraAnimations_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		StopAllCameraAnimations_IsValid = StopAllCameraAnimations_FunctionAddress != IntPtr.Zero && StopAllCameraAnimations_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:StopAllCameraAnimations", StopAllCameraAnimations_IsValid);
		PlayCameraAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayCameraAnimation");
		PlayCameraAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayCameraAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnimation_Sequence_PropertyAddress, PlayCameraAnimation_FunctionAddress, "Sequence");
		PlayCameraAnimation_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnimation_FunctionAddress, "Sequence");
		PlayCameraAnimation_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnimation_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnimation_Params_PropertyAddress, PlayCameraAnimation_FunctionAddress, "Params");
		PlayCameraAnimation_Params_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnimation_FunctionAddress, "Params");
		PlayCameraAnimation_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnimation_FunctionAddress, "Params", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnimation_ReturnValue_PropertyAddress, PlayCameraAnimation_FunctionAddress, "ReturnValue");
		PlayCameraAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnimation_FunctionAddress, "ReturnValue");
		PlayCameraAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnimation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PlayCameraAnimation_IsValid = PlayCameraAnimation_FunctionAddress != IntPtr.Zero && PlayCameraAnimation_Sequence_IsValid && PlayCameraAnimation_Params_IsValid && PlayCameraAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:PlayCameraAnimation", PlayCameraAnimation_IsValid);
		IsCameraAnimationActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCameraAnimationActive");
		IsCameraAnimationActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCameraAnimationActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCameraAnimationActive_Handle_PropertyAddress, IsCameraAnimationActive_FunctionAddress, "Handle");
		IsCameraAnimationActive_Handle_Offset = NativeReflectionCached.GetPropertyOffset(IsCameraAnimationActive_FunctionAddress, "Handle");
		IsCameraAnimationActive_Handle_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCameraAnimationActive_FunctionAddress, "Handle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCameraAnimationActive_ReturnValue_PropertyAddress, IsCameraAnimationActive_FunctionAddress, "ReturnValue");
		IsCameraAnimationActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCameraAnimationActive_FunctionAddress, "ReturnValue");
		IsCameraAnimationActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCameraAnimationActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCameraAnimationActive_IsValid = IsCameraAnimationActive_FunctionAddress != IntPtr.Zero && IsCameraAnimationActive_Handle_IsValid && IsCameraAnimationActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:IsCameraAnimationActive", IsCameraAnimationActive_IsValid);
		GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraAnimationCameraModifierFromPlayerController");
		GetCameraAnimationCameraModifierFromPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifierFromPlayerController_PlayerController_PropertyAddress, GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, "PlayerController");
		GetCameraAnimationCameraModifierFromPlayerController_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, "PlayerController");
		GetCameraAnimationCameraModifierFromPlayerController_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_PropertyAddress, GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, "ReturnValue");
		GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, "ReturnValue");
		GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCameraAnimationCameraModifierFromPlayerController_IsValid = GetCameraAnimationCameraModifierFromPlayerController_FunctionAddress != IntPtr.Zero && GetCameraAnimationCameraModifierFromPlayerController_PlayerController_IsValid && GetCameraAnimationCameraModifierFromPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifierFromPlayerController", GetCameraAnimationCameraModifierFromPlayerController_IsValid);
		GetCameraAnimationCameraModifierFromID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraAnimationCameraModifierFromID");
		GetCameraAnimationCameraModifierFromID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraAnimationCameraModifierFromID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifierFromID_WorldContextObject_PropertyAddress, GetCameraAnimationCameraModifierFromID_FunctionAddress, "WorldContextObject");
		GetCameraAnimationCameraModifierFromID_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifierFromID_FunctionAddress, "WorldContextObject");
		GetCameraAnimationCameraModifierFromID_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifierFromID_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifierFromID_ControllerID_PropertyAddress, GetCameraAnimationCameraModifierFromID_FunctionAddress, "ControllerID");
		GetCameraAnimationCameraModifierFromID_ControllerID_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifierFromID_FunctionAddress, "ControllerID");
		GetCameraAnimationCameraModifierFromID_ControllerID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifierFromID_FunctionAddress, "ControllerID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifierFromID_ReturnValue_PropertyAddress, GetCameraAnimationCameraModifierFromID_FunctionAddress, "ReturnValue");
		GetCameraAnimationCameraModifierFromID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifierFromID_FunctionAddress, "ReturnValue");
		GetCameraAnimationCameraModifierFromID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifierFromID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCameraAnimationCameraModifierFromID_IsValid = GetCameraAnimationCameraModifierFromID_FunctionAddress != IntPtr.Zero && GetCameraAnimationCameraModifierFromID_WorldContextObject_IsValid && GetCameraAnimationCameraModifierFromID_ControllerID_IsValid && GetCameraAnimationCameraModifierFromID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifierFromID", GetCameraAnimationCameraModifierFromID_IsValid);
		GetCameraAnimationCameraModifier_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraAnimationCameraModifier");
		GetCameraAnimationCameraModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraAnimationCameraModifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifier_WorldContextObject_PropertyAddress, GetCameraAnimationCameraModifier_FunctionAddress, "WorldContextObject");
		GetCameraAnimationCameraModifier_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifier_FunctionAddress, "WorldContextObject");
		GetCameraAnimationCameraModifier_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifier_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifier_PlayerIndex_PropertyAddress, GetCameraAnimationCameraModifier_FunctionAddress, "PlayerIndex");
		GetCameraAnimationCameraModifier_PlayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifier_FunctionAddress, "PlayerIndex");
		GetCameraAnimationCameraModifier_PlayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifier_FunctionAddress, "PlayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraAnimationCameraModifier_ReturnValue_PropertyAddress, GetCameraAnimationCameraModifier_FunctionAddress, "ReturnValue");
		GetCameraAnimationCameraModifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraAnimationCameraModifier_FunctionAddress, "ReturnValue");
		GetCameraAnimationCameraModifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraAnimationCameraModifier_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCameraAnimationCameraModifier_IsValid = GetCameraAnimationCameraModifier_FunctionAddress != IntPtr.Zero && GetCameraAnimationCameraModifier_WorldContextObject_IsValid && GetCameraAnimationCameraModifier_PlayerIndex_IsValid && GetCameraAnimationCameraModifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayCameras.CameraAnimationCameraModifier:GetCameraAnimationCameraModifier", GetCameraAnimationCameraModifier_IsValid);
	}
}
