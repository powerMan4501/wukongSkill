using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810025121uL, Config = "Engine")]
[UMetaPath("/Script/Engine.StreamableRenderAsset", "Engine", UnrealModuleType.Engine)]
public class UStreamableRenderAsset : UObject
{
	private static bool NumCinematicMipLevels_IsValid;

	private static int NumCinematicMipLevels_Offset;

	private static bool NeverStream_IsValid;

	private static FFieldAddress NeverStream_PropertyAddress;

	private static int NeverStream_Offset;

	private static bool GlobalForceMipLevelsToBeResident_IsValid;

	private static FFieldAddress GlobalForceMipLevelsToBeResident_PropertyAddress;

	private static int GlobalForceMipLevelsToBeResident_Offset;

	private static bool SetForceMipLevelsToBeResident_IsValid;

	private static IntPtr SetForceMipLevelsToBeResident_FunctionAddress;

	private static int SetForceMipLevelsToBeResident_ParamsSize;

	private static bool SetForceMipLevelsToBeResident_Seconds_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_Seconds_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_Seconds_Offset;

	private static bool SetForceMipLevelsToBeResident_CinematicLODGroupMask_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_CinematicLODGroupMask_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_CinematicLODGroupMask_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.StreamableRenderAsset:NumCinematicMipLevels")]
	public int NumCinematicMipLevels
	{
		get
		{
			CheckDestroyed();
			if (!NumCinematicMipLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableRenderAsset:NumCinematicMipLevels");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumCinematicMipLevels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumCinematicMipLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableRenderAsset:NumCinematicMipLevels");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumCinematicMipLevels_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760965718671365uL)]
	[UMetaPath("/Script/Engine.StreamableRenderAsset:NeverStream")]
	public bool NeverStream
	{
		get
		{
			CheckDestroyed();
			if (!NeverStream_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableRenderAsset:NeverStream");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeverStream_Offset), 0, NeverStream_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeverStream_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableRenderAsset:NeverStream");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeverStream_Offset), 0, NeverStream_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.StreamableRenderAsset:bGlobalForceMipLevelsToBeResident")]
	public bool GlobalForceMipLevelsToBeResident
	{
		get
		{
			CheckDestroyed();
			if (!GlobalForceMipLevelsToBeResident_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableRenderAsset:bGlobalForceMipLevelsToBeResident");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GlobalForceMipLevelsToBeResident_Offset), 0, GlobalForceMipLevelsToBeResident_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GlobalForceMipLevelsToBeResident_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StreamableRenderAsset:bGlobalForceMipLevelsToBeResident");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GlobalForceMipLevelsToBeResident_Offset), 0, GlobalForceMipLevelsToBeResident_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.StreamableRenderAsset:SetForceMipLevelsToBeResident")]
	public unsafe void SetForceMipLevelsToBeResident(float Seconds, int CinematicLODGroupMask = 0)
	{
		CheckDestroyed();
		if (!SetForceMipLevelsToBeResident_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StreamableRenderAsset:SetForceMipLevelsToBeResident");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceMipLevelsToBeResident_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceMipLevelsToBeResident_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_Seconds_Offset), 0, SetForceMipLevelsToBeResident_Seconds_PropertyAddress.Address, Seconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_CinematicLODGroupMask_Offset), 0, SetForceMipLevelsToBeResident_CinematicLODGroupMask_PropertyAddress.Address, CinematicLODGroupMask);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceMipLevelsToBeResident_FunctionAddress, intPtr, SetForceMipLevelsToBeResident_ParamsSize);
	}

	static UStreamableRenderAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStreamableRenderAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStreamableRenderAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.StreamableRenderAsset");
		NumCinematicMipLevels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumCinematicMipLevels");
		NumCinematicMipLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumCinematicMipLevels", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NeverStream_PropertyAddress, intPtr, "NeverStream");
		NeverStream_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NeverStream");
		NeverStream_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NeverStream", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GlobalForceMipLevelsToBeResident_PropertyAddress, intPtr, "bGlobalForceMipLevelsToBeResident");
		GlobalForceMipLevelsToBeResident_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGlobalForceMipLevelsToBeResident");
		GlobalForceMipLevelsToBeResident_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGlobalForceMipLevelsToBeResident", Classes.FBoolProperty);
		SetForceMipLevelsToBeResident_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceMipLevelsToBeResident");
		SetForceMipLevelsToBeResident_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceMipLevelsToBeResident_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_Seconds_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "Seconds");
		SetForceMipLevelsToBeResident_Seconds_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "Seconds");
		SetForceMipLevelsToBeResident_Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "Seconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_CinematicLODGroupMask_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "CinematicLODGroupMask");
		SetForceMipLevelsToBeResident_CinematicLODGroupMask_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "CinematicLODGroupMask");
		SetForceMipLevelsToBeResident_CinematicLODGroupMask_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "CinematicLODGroupMask", Classes.FIntProperty);
		SetForceMipLevelsToBeResident_IsValid = SetForceMipLevelsToBeResident_FunctionAddress != IntPtr.Zero && SetForceMipLevelsToBeResident_Seconds_IsValid && SetForceMipLevelsToBeResident_CinematicLODGroupMask_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StreamableRenderAsset:SetForceMipLevelsToBeResident", SetForceMipLevelsToBeResident_IsValid);
	}
}
