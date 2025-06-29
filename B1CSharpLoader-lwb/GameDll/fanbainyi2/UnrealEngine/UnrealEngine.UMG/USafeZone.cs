using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.SafeZone", "UMG", UnrealModuleType.Engine)]
public class USafeZone : UContentWidget
{
	private static bool PadLeft_IsValid;

	private static FFieldAddress PadLeft_PropertyAddress;

	private static int PadLeft_Offset;

	private static bool PadRight_IsValid;

	private static FFieldAddress PadRight_PropertyAddress;

	private static int PadRight_Offset;

	private static bool PadTop_IsValid;

	private static FFieldAddress PadTop_PropertyAddress;

	private static int PadTop_Offset;

	private static bool PadBottom_IsValid;

	private static FFieldAddress PadBottom_PropertyAddress;

	private static int PadBottom_Offset;

	private static bool SetSidesToPad_IsValid;

	private static IntPtr SetSidesToPad_FunctionAddress;

	private static int SetSidesToPad_ParamsSize;

	private static bool SetSidesToPad_InPadLeft_IsValid;

	private static FFieldAddress SetSidesToPad_InPadLeft_PropertyAddress;

	private static int SetSidesToPad_InPadLeft_Offset;

	private static bool SetSidesToPad_InPadRight_IsValid;

	private static FFieldAddress SetSidesToPad_InPadRight_PropertyAddress;

	private static int SetSidesToPad_InPadRight_Offset;

	private static bool SetSidesToPad_InPadTop_IsValid;

	private static FFieldAddress SetSidesToPad_InPadTop_PropertyAddress;

	private static int SetSidesToPad_InPadTop_Offset;

	private static bool SetSidesToPad_InPadBottom_IsValid;

	private static FFieldAddress SetSidesToPad_InPadBottom_PropertyAddress;

	private static int SetSidesToPad_InPadBottom_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZone:PadLeft")]
	public bool PadLeft
	{
		get
		{
			CheckDestroyed();
			if (!PadLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadLeft");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PadLeft_Offset), 0, PadLeft_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PadLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadLeft");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PadLeft_Offset), 0, PadLeft_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZone:PadRight")]
	public bool PadRight
	{
		get
		{
			CheckDestroyed();
			if (!PadRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadRight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PadRight_Offset), 0, PadRight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PadRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadRight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PadRight_Offset), 0, PadRight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZone:PadTop")]
	public bool PadTop
	{
		get
		{
			CheckDestroyed();
			if (!PadTop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadTop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PadTop_Offset), 0, PadTop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PadTop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadTop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PadTop_Offset), 0, PadTop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZone:PadBottom")]
	public bool PadBottom
	{
		get
		{
			CheckDestroyed();
			if (!PadBottom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadBottom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PadBottom_Offset), 0, PadBottom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PadBottom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZone:PadBottom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PadBottom_Offset), 0, PadBottom_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SafeZone:SetSidesToPad")]
	public unsafe void SetSidesToPad(bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom)
	{
		CheckDestroyed();
		if (!SetSidesToPad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SafeZone:SetSidesToPad");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSidesToPad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSidesToPad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSidesToPad_InPadLeft_Offset), 0, SetSidesToPad_InPadLeft_PropertyAddress.Address, InPadLeft);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSidesToPad_InPadRight_Offset), 0, SetSidesToPad_InPadRight_PropertyAddress.Address, InPadRight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSidesToPad_InPadTop_Offset), 0, SetSidesToPad_InPadTop_PropertyAddress.Address, InPadTop);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSidesToPad_InPadBottom_Offset), 0, SetSidesToPad_InPadBottom_PropertyAddress.Address, InPadBottom);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSidesToPad_FunctionAddress, intPtr, SetSidesToPad_ParamsSize);
	}

	static USafeZone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USafeZone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USafeZone));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.SafeZone");
		NativeReflectionCached.GetPropertyRef(ref PadLeft_PropertyAddress, intPtr, "PadLeft");
		PadLeft_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PadLeft");
		PadLeft_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PadLeft", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PadRight_PropertyAddress, intPtr, "PadRight");
		PadRight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PadRight");
		PadRight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PadRight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PadTop_PropertyAddress, intPtr, "PadTop");
		PadTop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PadTop");
		PadTop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PadTop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PadBottom_PropertyAddress, intPtr, "PadBottom");
		PadBottom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PadBottom");
		PadBottom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PadBottom", Classes.FBoolProperty);
		SetSidesToPad_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSidesToPad");
		SetSidesToPad_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSidesToPad_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSidesToPad_InPadLeft_PropertyAddress, SetSidesToPad_FunctionAddress, "InPadLeft");
		SetSidesToPad_InPadLeft_Offset = NativeReflectionCached.GetPropertyOffset(SetSidesToPad_FunctionAddress, "InPadLeft");
		SetSidesToPad_InPadLeft_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSidesToPad_FunctionAddress, "InPadLeft", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSidesToPad_InPadRight_PropertyAddress, SetSidesToPad_FunctionAddress, "InPadRight");
		SetSidesToPad_InPadRight_Offset = NativeReflectionCached.GetPropertyOffset(SetSidesToPad_FunctionAddress, "InPadRight");
		SetSidesToPad_InPadRight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSidesToPad_FunctionAddress, "InPadRight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSidesToPad_InPadTop_PropertyAddress, SetSidesToPad_FunctionAddress, "InPadTop");
		SetSidesToPad_InPadTop_Offset = NativeReflectionCached.GetPropertyOffset(SetSidesToPad_FunctionAddress, "InPadTop");
		SetSidesToPad_InPadTop_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSidesToPad_FunctionAddress, "InPadTop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSidesToPad_InPadBottom_PropertyAddress, SetSidesToPad_FunctionAddress, "InPadBottom");
		SetSidesToPad_InPadBottom_Offset = NativeReflectionCached.GetPropertyOffset(SetSidesToPad_FunctionAddress, "InPadBottom");
		SetSidesToPad_InPadBottom_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSidesToPad_FunctionAddress, "InPadBottom", Classes.FBoolProperty);
		SetSidesToPad_IsValid = SetSidesToPad_FunctionAddress != IntPtr.Zero && SetSidesToPad_InPadLeft_IsValid && SetSidesToPad_InPadRight_IsValid && SetSidesToPad_InPadTop_IsValid && SetSidesToPad_InPadBottom_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SafeZone:SetSidesToPad", SetSidesToPad_IsValid);
	}
}
