using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889956uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGPPlayerState", "b1", UnrealModuleType.Game)]
public class ABGPPlayerState : APlayerState
{
	private static bool BGPDataComp_IsValid;

	private static int BGPDataComp_Offset;

	private static bool PostInitializeComponentsCS_IsValid;

	private IntPtr PostInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGPPlayerState:BGPDataComp")]
	protected UActorDataContainer BGPDataComp
	{
		get
		{
			CheckDestroyed();
			if (!BGPDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGPPlayerState:BGPDataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, BGPDataComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGPDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGPPlayerState:BGPDataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, BGPDataComp_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerState:PostInitializeComponentsCS")]
	public unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerState:PostInitializeComponentsCS");
			return;
		}
		if (PostInitializeComponentsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitializeComponentsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitializeComponentsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_InstanceFunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	protected unsafe virtual void PostInitializeComponentsCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerState:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerState:BeginPlayCS")]
	public unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerState:BeginPlayCS");
			return;
		}
		if (BeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_InstanceFunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerState:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	static ABGPPlayerState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGPPlayerState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGPPlayerState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGPPlayerState");
		BGPDataComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BGPDataComp");
		BGPDataComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BGPDataComp", Classes.FObjectProperty);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerState:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerState:BeginPlayCS", BeginPlayCS_IsValid);
	}
}
