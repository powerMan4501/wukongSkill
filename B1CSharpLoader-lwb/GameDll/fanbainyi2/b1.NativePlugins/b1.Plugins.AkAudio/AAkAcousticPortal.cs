using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkAcousticPortal", "AkAudio", UnrealModuleType.GamePlugin)]
public class AAkAcousticPortal : AVolume
{
	private static bool Portal_IsValid;

	private static int Portal_Offset;

	private static bool OpenPortal_IsValid;

	private static IntPtr OpenPortal_FunctionAddress;

	private static int OpenPortal_ParamsSize;

	private static bool GetCurrentState_IsValid;

	private static IntPtr GetCurrentState_FunctionAddress;

	private static int GetCurrentState_ParamsSize;

	private static bool GetCurrentState_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentState_ReturnValue_PropertyAddress;

	private static int GetCurrentState_ReturnValue_Offset;

	private static bool GetCollisionChannel_IsValid;

	private static IntPtr GetCollisionChannel_FunctionAddress;

	private static int GetCollisionChannel_ParamsSize;

	private static bool GetCollisionChannel_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionChannel_ReturnValue_PropertyAddress;

	private static int GetCollisionChannel_ReturnValue_Offset;

	private static bool ClosePortal_IsValid;

	private static IntPtr ClosePortal_FunctionAddress;

	private static int ClosePortal_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/AkAudio.AkAcousticPortal:Portal")]
	public UAkPortalComponent Portal
	{
		get
		{
			CheckDestroyed();
			if (!Portal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAcousticPortal:Portal");
				return null;
			}
			return UObjectMarshaler<UAkPortalComponent>.FromNative(IntPtr.Add(base.Address, Portal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Portal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAcousticPortal:Portal");
			}
			else
			{
				UObjectMarshaler<UAkPortalComponent>.ToNative(IntPtr.Add(base.Address, Portal_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkAcousticPortal:OpenPortal")]
	public unsafe void OpenPortal()
	{
		CheckDestroyed();
		if (!OpenPortal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAcousticPortal:OpenPortal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenPortal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenPortal_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OpenPortal_FunctionAddress, argsSize: OpenPortal_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AkAudio.AkAcousticPortal:GetCurrentState")]
	public unsafe EAkAcousticPortalState GetCurrentState()
	{
		CheckDestroyed();
		if (!GetCurrentState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAcousticPortal:GetCurrentState");
			return EAkAcousticPortalState.Closed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentState_FunctionAddress, intPtr, GetCurrentState_ParamsSize);
		return EnumMarshaler<EAkAcousticPortalState>.FromNative(IntPtr.Add(intPtr, GetCurrentState_ReturnValue_Offset), 0, GetCurrentState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604505089u)]
	[UMetaPath("/Script/AkAudio.AkAcousticPortal:GetCollisionChannel")]
	protected unsafe ECollisionChannel GetCollisionChannel()
	{
		CheckDestroyed();
		if (!GetCollisionChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAcousticPortal:GetCollisionChannel");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionChannel_FunctionAddress, intPtr, GetCollisionChannel_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, GetCollisionChannel_ReturnValue_Offset), 0, GetCollisionChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AkAudio.AkAcousticPortal:ClosePortal")]
	public unsafe void ClosePortal()
	{
		CheckDestroyed();
		if (!ClosePortal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkAcousticPortal:ClosePortal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClosePortal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClosePortal_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClosePortal_FunctionAddress, argsSize: ClosePortal_ParamsSize);
	}

	static AAkAcousticPortal()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAkAcousticPortal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAkAcousticPortal));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AkAudio.AkAcousticPortal");
		Portal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Portal");
		Portal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Portal", Classes.FObjectProperty);
		OpenPortal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenPortal");
		OpenPortal_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenPortal_FunctionAddress);
		OpenPortal_IsValid = OpenPortal_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAcousticPortal:OpenPortal", OpenPortal_IsValid);
		GetCurrentState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentState");
		GetCurrentState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentState_ReturnValue_PropertyAddress, GetCurrentState_FunctionAddress, "ReturnValue");
		GetCurrentState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentState_FunctionAddress, "ReturnValue");
		GetCurrentState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCurrentState_IsValid = GetCurrentState_FunctionAddress != IntPtr.Zero && GetCurrentState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAcousticPortal:GetCurrentState", GetCurrentState_IsValid);
		GetCollisionChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionChannel");
		GetCollisionChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionChannel_ReturnValue_PropertyAddress, GetCollisionChannel_FunctionAddress, "ReturnValue");
		GetCollisionChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionChannel_FunctionAddress, "ReturnValue");
		GetCollisionChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionChannel_IsValid = GetCollisionChannel_FunctionAddress != IntPtr.Zero && GetCollisionChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAcousticPortal:GetCollisionChannel", GetCollisionChannel_IsValid);
		ClosePortal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClosePortal");
		ClosePortal_ParamsSize = NativeReflection.GetFunctionParamsSize(ClosePortal_FunctionAddress);
		ClosePortal_IsValid = ClosePortal_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkAcousticPortal:ClosePortal", ClosePortal_IsValid);
	}
}
