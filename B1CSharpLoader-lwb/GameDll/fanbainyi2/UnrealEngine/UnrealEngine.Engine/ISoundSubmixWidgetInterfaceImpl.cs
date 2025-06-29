using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class ISoundSubmixWidgetInterfaceImpl : IInterfaceImpl, ISoundSubmixWidgetInterface, IInterface
{
	private static bool OnConstructed_IsValid;

	private IntPtr OnConstructed_InstanceFunctionAddress;

	private static IntPtr OnConstructed_FunctionAddress;

	private static int OnConstructed_ParamsSize;

	private static bool OnConstructed_SoundSubmix_IsValid;

	private static FFieldAddress OnConstructed_SoundSubmix_PropertyAddress;

	private static int OnConstructed_SoundSubmix_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.SoundSubmixWidgetInterface:OnConstructed")]
	public unsafe void OnConstructed(USoundSubmixBase SoundSubmix)
	{
		CheckDestroyed();
		if (!OnConstructed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmixWidgetInterface:OnConstructed");
			return;
		}
		if (OnConstructed_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnConstructed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnConstructed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundSubmixBase>.ToNative(IntPtr.Add(intPtr, OnConstructed_SoundSubmix_Offset), 0, OnConstructed_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnConstructed_InstanceFunctionAddress, intPtr, OnConstructed_ParamsSize);
	}

	public override void ResetInterface()
	{
		OnConstructed_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ISoundSubmixWidgetInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ISoundSubmixWidgetInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ISoundSubmixWidgetInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.SoundSubmixWidgetInterface");
		OnConstructed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnConstructed");
		OnConstructed_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnConstructed_SoundSubmix_PropertyAddress, OnConstructed_FunctionAddress, "SoundSubmix");
		OnConstructed_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(OnConstructed_FunctionAddress, "SoundSubmix");
		OnConstructed_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(OnConstructed_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		OnConstructed_IsValid = OnConstructed_FunctionAddress != IntPtr.Zero && OnConstructed_SoundSubmix_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmixWidgetInterface:OnConstructed", OnConstructed_IsValid);
	}
}
