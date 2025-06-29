using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioLinkEngine;

public sealed class IAudioLinkBlueprintInterfaceImpl : IInterfaceImpl, IAudioLinkBlueprintInterface, IInterface
{
	private static bool StopLink_IsValid;

	private IntPtr StopLink_InstanceFunctionAddress;

	private static IntPtr StopLink_FunctionAddress;

	private static int StopLink_ParamsSize;

	private static bool SetLinkSound_IsValid;

	private IntPtr SetLinkSound_InstanceFunctionAddress;

	private static IntPtr SetLinkSound_FunctionAddress;

	private static int SetLinkSound_ParamsSize;

	private static bool SetLinkSound_NewSound_IsValid;

	private static FFieldAddress SetLinkSound_NewSound_PropertyAddress;

	private static int SetLinkSound_NewSound_Offset;

	private static bool PlayLink_IsValid;

	private IntPtr PlayLink_InstanceFunctionAddress;

	private static IntPtr PlayLink_FunctionAddress;

	private static int PlayLink_ParamsSize;

	private static bool PlayLink_StartTime_IsValid;

	private static FFieldAddress PlayLink_StartTime_PropertyAddress;

	private static int PlayLink_StartTime_Offset;

	private static bool IsLinkPlaying_IsValid;

	private IntPtr IsLinkPlaying_InstanceFunctionAddress;

	private static IntPtr IsLinkPlaying_FunctionAddress;

	private static int IsLinkPlaying_ParamsSize;

	private static bool IsLinkPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsLinkPlaying_ReturnValue_PropertyAddress;

	private static int IsLinkPlaying_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:StopLink")]
	public unsafe void StopLink()
	{
		CheckDestroyed();
		if (!StopLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:StopLink");
			return;
		}
		if (StopLink_InstanceFunctionAddress == IntPtr.Zero)
		{
			StopLink_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "StopLink");
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopLink_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopLink_InstanceFunctionAddress, argsSize: StopLink_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:SetLinkSound")]
	public unsafe void SetLinkSound(USoundBase NewSound)
	{
		CheckDestroyed();
		if (!SetLinkSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:SetLinkSound");
			return;
		}
		if (SetLinkSound_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetLinkSound_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetLinkSound");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinkSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinkSound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(intPtr, SetLinkSound_NewSound_Offset), 0, SetLinkSound_NewSound_PropertyAddress.Address, NewSound);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinkSound_InstanceFunctionAddress, intPtr, SetLinkSound_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:PlayLink")]
	public unsafe void PlayLink(float StartTime = 0f)
	{
		CheckDestroyed();
		if (!PlayLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:PlayLink");
			return;
		}
		if (PlayLink_InstanceFunctionAddress == IntPtr.Zero)
		{
			PlayLink_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PlayLink");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayLink_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayLink_StartTime_Offset), 0, PlayLink_StartTime_PropertyAddress.Address, StartTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayLink_InstanceFunctionAddress, intPtr, PlayLink_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:IsLinkPlaying")]
	public unsafe bool IsLinkPlaying()
	{
		CheckDestroyed();
		if (!IsLinkPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:IsLinkPlaying");
			return false;
		}
		if (IsLinkPlaying_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsLinkPlaying_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsLinkPlaying");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLinkPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLinkPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLinkPlaying_InstanceFunctionAddress, intPtr, IsLinkPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLinkPlaying_ReturnValue_Offset), 0, IsLinkPlaying_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		StopLink_InstanceFunctionAddress = IntPtr.Zero;
		SetLinkSound_InstanceFunctionAddress = IntPtr.Zero;
		PlayLink_InstanceFunctionAddress = IntPtr.Zero;
		IsLinkPlaying_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IAudioLinkBlueprintInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAudioLinkBlueprintInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAudioLinkBlueprintInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AudioLinkEngine.AudioLinkBlueprintInterface");
		StopLink_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopLink");
		StopLink_ParamsSize = NativeReflection.GetFunctionParamsSize(StopLink_FunctionAddress);
		StopLink_IsValid = StopLink_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:StopLink", StopLink_IsValid);
		SetLinkSound_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLinkSound");
		SetLinkSound_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinkSound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinkSound_NewSound_PropertyAddress, SetLinkSound_FunctionAddress, "NewSound");
		SetLinkSound_NewSound_Offset = NativeReflectionCached.GetPropertyOffset(SetLinkSound_FunctionAddress, "NewSound");
		SetLinkSound_NewSound_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinkSound_FunctionAddress, "NewSound", Classes.FObjectProperty);
		SetLinkSound_IsValid = SetLinkSound_FunctionAddress != IntPtr.Zero && SetLinkSound_NewSound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:SetLinkSound", SetLinkSound_IsValid);
		PlayLink_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayLink");
		PlayLink_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayLink_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayLink_StartTime_PropertyAddress, PlayLink_FunctionAddress, "StartTime");
		PlayLink_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayLink_FunctionAddress, "StartTime");
		PlayLink_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayLink_FunctionAddress, "StartTime", Classes.FFloatProperty);
		PlayLink_IsValid = PlayLink_FunctionAddress != IntPtr.Zero && PlayLink_StartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:PlayLink", PlayLink_IsValid);
		IsLinkPlaying_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLinkPlaying");
		IsLinkPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLinkPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLinkPlaying_ReturnValue_PropertyAddress, IsLinkPlaying_FunctionAddress, "ReturnValue");
		IsLinkPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLinkPlaying_FunctionAddress, "ReturnValue");
		IsLinkPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLinkPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLinkPlaying_IsValid = IsLinkPlaying_FunctionAddress != IntPtr.Zero && IsLinkPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioLinkEngine.AudioLinkBlueprintInterface:IsLinkPlaying", IsLinkPlaying_IsValid);
	}
}
