using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.VOIPTalker", "Engine", UnrealModuleType.Engine)]
public class UVOIPTalker : UActorComponent
{
	private static IntPtr classAddress;

	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool RegisterWithPlayerState_IsValid;

	private static IntPtr RegisterWithPlayerState_FunctionAddress;

	private static int RegisterWithPlayerState_ParamsSize;

	private static bool RegisterWithPlayerState_OwningState_IsValid;

	private static FFieldAddress RegisterWithPlayerState_OwningState_PropertyAddress;

	private static int RegisterWithPlayerState_OwningState_Offset;

	private static bool GetVoiceLevel_IsValid;

	private static IntPtr GetVoiceLevel_FunctionAddress;

	private static int GetVoiceLevel_ParamsSize;

	private static bool GetVoiceLevel_ReturnValue_IsValid;

	private static FFieldAddress GetVoiceLevel_ReturnValue_PropertyAddress;

	private static int GetVoiceLevel_ReturnValue_Offset;

	private static bool CreateTalkerForPlayer_IsValid;

	private static IntPtr CreateTalkerForPlayer_FunctionAddress;

	private static int CreateTalkerForPlayer_ParamsSize;

	private static bool CreateTalkerForPlayer_OwningState_IsValid;

	private static FFieldAddress CreateTalkerForPlayer_OwningState_PropertyAddress;

	private static int CreateTalkerForPlayer_OwningState_Offset;

	private static bool CreateTalkerForPlayer_ReturnValue_IsValid;

	private static FFieldAddress CreateTalkerForPlayer_ReturnValue_PropertyAddress;

	private static int CreateTalkerForPlayer_ReturnValue_Offset;

	private static bool BPOnTalkingEnd_IsValid;

	private IntPtr BPOnTalkingEnd_InstanceFunctionAddress;

	private static IntPtr BPOnTalkingEnd_FunctionAddress;

	private static int BPOnTalkingEnd_ParamsSize;

	private static bool BPOnTalkingBegin_IsValid;

	private IntPtr BPOnTalkingBegin_InstanceFunctionAddress;

	private static IntPtr BPOnTalkingBegin_FunctionAddress;

	private static int BPOnTalkingBegin_ParamsSize;

	private static bool BPOnTalkingBegin_AudioComponent_IsValid;

	private static FFieldAddress BPOnTalkingBegin_AudioComponent_PropertyAddress;

	private static int BPOnTalkingBegin_AudioComponent_Offset;

	[UProperty(Flags = (PropFlags)4504218102661125uL)]
	[UMetaPath("/Script/Engine.VOIPTalker:Settings")]
	public FVoiceSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VOIPTalker:Settings");
				return default(FVoiceSettings);
			}
			return FVoiceSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.VOIPTalker:Settings");
			}
			else
			{
				FVoiceSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.VOIPTalker:RegisterWithPlayerState")]
	public unsafe void RegisterWithPlayerState(APlayerState OwningState)
	{
		CheckDestroyed();
		if (!RegisterWithPlayerState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:RegisterWithPlayerState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterWithPlayerState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterWithPlayerState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, RegisterWithPlayerState_OwningState_Offset), 0, RegisterWithPlayerState_OwningState_PropertyAddress.Address, OwningState);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterWithPlayerState_FunctionAddress, intPtr, RegisterWithPlayerState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.VOIPTalker:GetVoiceLevel")]
	public unsafe float GetVoiceLevel()
	{
		CheckDestroyed();
		if (!GetVoiceLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:GetVoiceLevel");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVoiceLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVoiceLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVoiceLevel_FunctionAddress, intPtr, GetVoiceLevel_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetVoiceLevel_ReturnValue_Offset), 0, GetVoiceLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.VOIPTalker:CreateTalkerForPlayer")]
	public unsafe static UVOIPTalker CreateTalkerForPlayer(APlayerState OwningState)
	{
		if (!CreateTalkerForPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:CreateTalkerForPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTalkerForPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTalkerForPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(intPtr, CreateTalkerForPlayer_OwningState_Offset), 0, CreateTalkerForPlayer_OwningState_PropertyAddress.Address, OwningState);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTalkerForPlayer_FunctionAddress, intPtr, CreateTalkerForPlayer_ParamsSize);
		return UObjectMarshaler<UVOIPTalker>.FromNative(IntPtr.Add(intPtr, CreateTalkerForPlayer_ReturnValue_Offset), 0, CreateTalkerForPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/Engine.VOIPTalker:BPOnTalkingEnd")]
	protected unsafe void BPOnTalkingEnd()
	{
		CheckDestroyed();
		if (!BPOnTalkingEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:BPOnTalkingEnd");
			return;
		}
		if (BPOnTalkingEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			BPOnTalkingEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BPOnTalkingEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPOnTalkingEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPOnTalkingEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BPOnTalkingEnd_InstanceFunctionAddress, argsSize: BPOnTalkingEnd_ParamsSize);
	}

	protected unsafe virtual void BPOnTalkingEnd_Implementation()
	{
		CheckDestroyed();
		if (!BPOnTalkingEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:BPOnTalkingEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPOnTalkingEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPOnTalkingEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BPOnTalkingEnd_FunctionAddress, argsSize: BPOnTalkingEnd_ParamsSize);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/Engine.VOIPTalker:BPOnTalkingBegin")]
	protected unsafe void BPOnTalkingBegin(UAudioComponent AudioComponent)
	{
		CheckDestroyed();
		if (!BPOnTalkingBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:BPOnTalkingBegin");
			return;
		}
		if (BPOnTalkingBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			BPOnTalkingBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BPOnTalkingBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPOnTalkingBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPOnTalkingBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAudioComponent>.ToNative(IntPtr.Add(intPtr, BPOnTalkingBegin_AudioComponent_Offset), 0, BPOnTalkingBegin_AudioComponent_PropertyAddress.Address, AudioComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, BPOnTalkingBegin_InstanceFunctionAddress, intPtr, BPOnTalkingBegin_ParamsSize);
	}

	protected unsafe virtual void BPOnTalkingBegin_Implementation(UAudioComponent AudioComponent)
	{
		CheckDestroyed();
		if (!BPOnTalkingBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPTalker:BPOnTalkingBegin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BPOnTalkingBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BPOnTalkingBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAudioComponent>.ToNative(IntPtr.Add(intPtr, BPOnTalkingBegin_AudioComponent_Offset), 0, BPOnTalkingBegin_AudioComponent_PropertyAddress.Address, AudioComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, BPOnTalkingBegin_FunctionAddress, intPtr, BPOnTalkingBegin_ParamsSize);
	}

	static UVOIPTalker()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVOIPTalker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVOIPTalker));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.VOIPTalker");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Settings", Classes.FStructProperty);
		RegisterWithPlayerState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterWithPlayerState");
		RegisterWithPlayerState_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterWithPlayerState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterWithPlayerState_OwningState_PropertyAddress, RegisterWithPlayerState_FunctionAddress, "OwningState");
		RegisterWithPlayerState_OwningState_Offset = NativeReflectionCached.GetPropertyOffset(RegisterWithPlayerState_FunctionAddress, "OwningState");
		RegisterWithPlayerState_OwningState_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterWithPlayerState_FunctionAddress, "OwningState", Classes.FObjectProperty);
		RegisterWithPlayerState_IsValid = RegisterWithPlayerState_FunctionAddress != IntPtr.Zero && RegisterWithPlayerState_OwningState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VOIPTalker:RegisterWithPlayerState", RegisterWithPlayerState_IsValid);
		GetVoiceLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVoiceLevel");
		GetVoiceLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVoiceLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVoiceLevel_ReturnValue_PropertyAddress, GetVoiceLevel_FunctionAddress, "ReturnValue");
		GetVoiceLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVoiceLevel_FunctionAddress, "ReturnValue");
		GetVoiceLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVoiceLevel_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetVoiceLevel_IsValid = GetVoiceLevel_FunctionAddress != IntPtr.Zero && GetVoiceLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VOIPTalker:GetVoiceLevel", GetVoiceLevel_IsValid);
		CreateTalkerForPlayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTalkerForPlayer");
		CreateTalkerForPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTalkerForPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTalkerForPlayer_OwningState_PropertyAddress, CreateTalkerForPlayer_FunctionAddress, "OwningState");
		CreateTalkerForPlayer_OwningState_Offset = NativeReflectionCached.GetPropertyOffset(CreateTalkerForPlayer_FunctionAddress, "OwningState");
		CreateTalkerForPlayer_OwningState_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTalkerForPlayer_FunctionAddress, "OwningState", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTalkerForPlayer_ReturnValue_PropertyAddress, CreateTalkerForPlayer_FunctionAddress, "ReturnValue");
		CreateTalkerForPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTalkerForPlayer_FunctionAddress, "ReturnValue");
		CreateTalkerForPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTalkerForPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateTalkerForPlayer_IsValid = CreateTalkerForPlayer_FunctionAddress != IntPtr.Zero && CreateTalkerForPlayer_OwningState_IsValid && CreateTalkerForPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VOIPTalker:CreateTalkerForPlayer", CreateTalkerForPlayer_IsValid);
		BPOnTalkingEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BPOnTalkingEnd");
		BPOnTalkingEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(BPOnTalkingEnd_FunctionAddress);
		BPOnTalkingEnd_IsValid = BPOnTalkingEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VOIPTalker:BPOnTalkingEnd", BPOnTalkingEnd_IsValid);
		BPOnTalkingBegin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BPOnTalkingBegin");
		BPOnTalkingBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(BPOnTalkingBegin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BPOnTalkingBegin_AudioComponent_PropertyAddress, BPOnTalkingBegin_FunctionAddress, "AudioComponent");
		BPOnTalkingBegin_AudioComponent_Offset = NativeReflectionCached.GetPropertyOffset(BPOnTalkingBegin_FunctionAddress, "AudioComponent");
		BPOnTalkingBegin_AudioComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(BPOnTalkingBegin_FunctionAddress, "AudioComponent", Classes.FObjectProperty);
		BPOnTalkingBegin_IsValid = BPOnTalkingBegin_FunctionAddress != IntPtr.Zero && BPOnTalkingBegin_AudioComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VOIPTalker:BPOnTalkingBegin", BPOnTalkingBegin_IsValid);
	}
}
