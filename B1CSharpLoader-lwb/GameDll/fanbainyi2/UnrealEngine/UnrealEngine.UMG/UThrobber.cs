using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Throbber", "UMG", UnrealModuleType.Engine)]
public class UThrobber : UWidget
{
	private static bool NumberOfPieces_IsValid;

	private static int NumberOfPieces_Offset;

	private static bool AnimateHorizontally_IsValid;

	private static FFieldAddress AnimateHorizontally_PropertyAddress;

	private static int AnimateHorizontally_Offset;

	private static bool AnimateVertically_IsValid;

	private static FFieldAddress AnimateVertically_PropertyAddress;

	private static int AnimateVertically_Offset;

	private static bool AnimateOpacity_IsValid;

	private static FFieldAddress AnimateOpacity_PropertyAddress;

	private static int AnimateOpacity_Offset;

	private static bool Image_IsValid;

	private static int Image_Offset;

	private static bool SetNumberOfPieces_IsValid;

	private static IntPtr SetNumberOfPieces_FunctionAddress;

	private static int SetNumberOfPieces_ParamsSize;

	private static bool SetNumberOfPieces_InNumberOfPieces_IsValid;

	private static FFieldAddress SetNumberOfPieces_InNumberOfPieces_PropertyAddress;

	private static int SetNumberOfPieces_InNumberOfPieces_Offset;

	private static bool SetAnimateVertically_IsValid;

	private static IntPtr SetAnimateVertically_FunctionAddress;

	private static int SetAnimateVertically_ParamsSize;

	private static bool SetAnimateVertically_bInAnimateVertically_IsValid;

	private static FFieldAddress SetAnimateVertically_bInAnimateVertically_PropertyAddress;

	private static int SetAnimateVertically_bInAnimateVertically_Offset;

	private static bool SetAnimateOpacity_IsValid;

	private static IntPtr SetAnimateOpacity_FunctionAddress;

	private static int SetAnimateOpacity_ParamsSize;

	private static bool SetAnimateOpacity_bInAnimateOpacity_IsValid;

	private static FFieldAddress SetAnimateOpacity_bInAnimateOpacity_PropertyAddress;

	private static int SetAnimateOpacity_bInAnimateOpacity_Offset;

	private static bool SetAnimateHorizontally_IsValid;

	private static IntPtr SetAnimateHorizontally_FunctionAddress;

	private static int SetAnimateHorizontally_ParamsSize;

	private static bool SetAnimateHorizontally_bInAnimateHorizontally_IsValid;

	private static FFieldAddress SetAnimateHorizontally_bInAnimateHorizontally_PropertyAddress;

	private static int SetAnimateHorizontally_bInAnimateHorizontally_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Throbber:NumberOfPieces")]
	public int NumberOfPieces
	{
		get
		{
			CheckDestroyed();
			if (!NumberOfPieces_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:NumberOfPieces");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumberOfPieces_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumberOfPieces_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:NumberOfPieces");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumberOfPieces_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Throbber:bAnimateHorizontally")]
	public bool AnimateHorizontally
	{
		get
		{
			CheckDestroyed();
			if (!AnimateHorizontally_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:bAnimateHorizontally");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AnimateHorizontally_Offset), 0, AnimateHorizontally_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AnimateHorizontally_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:bAnimateHorizontally");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AnimateHorizontally_Offset), 0, AnimateHorizontally_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Throbber:bAnimateVertically")]
	public bool AnimateVertically
	{
		get
		{
			CheckDestroyed();
			if (!AnimateVertically_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:bAnimateVertically");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AnimateVertically_Offset), 0, AnimateVertically_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AnimateVertically_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:bAnimateVertically");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AnimateVertically_Offset), 0, AnimateVertically_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Throbber:bAnimateOpacity")]
	public bool AnimateOpacity
	{
		get
		{
			CheckDestroyed();
			if (!AnimateOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:bAnimateOpacity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AnimateOpacity_Offset), 0, AnimateOpacity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AnimateOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:bAnimateOpacity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AnimateOpacity_Offset), 0, AnimateOpacity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.Throbber:Image")]
	public FSlateBrush Image
	{
		get
		{
			CheckDestroyed();
			if (!Image_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:Image");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, Image_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Image_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Throbber:Image");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, Image_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Throbber:SetNumberOfPieces")]
	public unsafe void SetNumberOfPieces(int InNumberOfPieces)
	{
		CheckDestroyed();
		if (!SetNumberOfPieces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Throbber:SetNumberOfPieces");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumberOfPieces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumberOfPieces_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumberOfPieces_InNumberOfPieces_Offset), 0, SetNumberOfPieces_InNumberOfPieces_PropertyAddress.Address, InNumberOfPieces);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumberOfPieces_FunctionAddress, intPtr, SetNumberOfPieces_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Throbber:SetAnimateVertically")]
	public unsafe void SetAnimateVertically(bool bInAnimateVertically)
	{
		CheckDestroyed();
		if (!SetAnimateVertically_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Throbber:SetAnimateVertically");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimateVertically_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimateVertically_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimateVertically_bInAnimateVertically_Offset), 0, SetAnimateVertically_bInAnimateVertically_PropertyAddress.Address, bInAnimateVertically);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimateVertically_FunctionAddress, intPtr, SetAnimateVertically_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Throbber:SetAnimateOpacity")]
	public unsafe void SetAnimateOpacity(bool bInAnimateOpacity)
	{
		CheckDestroyed();
		if (!SetAnimateOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Throbber:SetAnimateOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimateOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimateOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimateOpacity_bInAnimateOpacity_Offset), 0, SetAnimateOpacity_bInAnimateOpacity_PropertyAddress.Address, bInAnimateOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimateOpacity_FunctionAddress, intPtr, SetAnimateOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Throbber:SetAnimateHorizontally")]
	public unsafe void SetAnimateHorizontally(bool bInAnimateHorizontally)
	{
		CheckDestroyed();
		if (!SetAnimateHorizontally_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Throbber:SetAnimateHorizontally");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimateHorizontally_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimateHorizontally_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimateHorizontally_bInAnimateHorizontally_Offset), 0, SetAnimateHorizontally_bInAnimateHorizontally_PropertyAddress.Address, bInAnimateHorizontally);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimateHorizontally_FunctionAddress, intPtr, SetAnimateHorizontally_ParamsSize);
	}

	static UThrobber()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UThrobber)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UThrobber));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Throbber");
		NumberOfPieces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberOfPieces");
		NumberOfPieces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberOfPieces", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimateHorizontally_PropertyAddress, intPtr, "bAnimateHorizontally");
		AnimateHorizontally_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnimateHorizontally");
		AnimateHorizontally_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnimateHorizontally", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimateVertically_PropertyAddress, intPtr, "bAnimateVertically");
		AnimateVertically_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnimateVertically");
		AnimateVertically_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnimateVertically", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimateOpacity_PropertyAddress, intPtr, "bAnimateOpacity");
		AnimateOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnimateOpacity");
		AnimateOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnimateOpacity", Classes.FBoolProperty);
		Image_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Image");
		Image_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Image", Classes.FStructProperty);
		SetNumberOfPieces_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNumberOfPieces");
		SetNumberOfPieces_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumberOfPieces_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumberOfPieces_InNumberOfPieces_PropertyAddress, SetNumberOfPieces_FunctionAddress, "InNumberOfPieces");
		SetNumberOfPieces_InNumberOfPieces_Offset = NativeReflectionCached.GetPropertyOffset(SetNumberOfPieces_FunctionAddress, "InNumberOfPieces");
		SetNumberOfPieces_InNumberOfPieces_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumberOfPieces_FunctionAddress, "InNumberOfPieces", Classes.FIntProperty);
		SetNumberOfPieces_IsValid = SetNumberOfPieces_FunctionAddress != IntPtr.Zero && SetNumberOfPieces_InNumberOfPieces_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Throbber:SetNumberOfPieces", SetNumberOfPieces_IsValid);
		SetAnimateVertically_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnimateVertically");
		SetAnimateVertically_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimateVertically_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimateVertically_bInAnimateVertically_PropertyAddress, SetAnimateVertically_FunctionAddress, "bInAnimateVertically");
		SetAnimateVertically_bInAnimateVertically_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimateVertically_FunctionAddress, "bInAnimateVertically");
		SetAnimateVertically_bInAnimateVertically_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimateVertically_FunctionAddress, "bInAnimateVertically", Classes.FBoolProperty);
		SetAnimateVertically_IsValid = SetAnimateVertically_FunctionAddress != IntPtr.Zero && SetAnimateVertically_bInAnimateVertically_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Throbber:SetAnimateVertically", SetAnimateVertically_IsValid);
		SetAnimateOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnimateOpacity");
		SetAnimateOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimateOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimateOpacity_bInAnimateOpacity_PropertyAddress, SetAnimateOpacity_FunctionAddress, "bInAnimateOpacity");
		SetAnimateOpacity_bInAnimateOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimateOpacity_FunctionAddress, "bInAnimateOpacity");
		SetAnimateOpacity_bInAnimateOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimateOpacity_FunctionAddress, "bInAnimateOpacity", Classes.FBoolProperty);
		SetAnimateOpacity_IsValid = SetAnimateOpacity_FunctionAddress != IntPtr.Zero && SetAnimateOpacity_bInAnimateOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Throbber:SetAnimateOpacity", SetAnimateOpacity_IsValid);
		SetAnimateHorizontally_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnimateHorizontally");
		SetAnimateHorizontally_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimateHorizontally_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimateHorizontally_bInAnimateHorizontally_PropertyAddress, SetAnimateHorizontally_FunctionAddress, "bInAnimateHorizontally");
		SetAnimateHorizontally_bInAnimateHorizontally_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimateHorizontally_FunctionAddress, "bInAnimateHorizontally");
		SetAnimateHorizontally_bInAnimateHorizontally_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimateHorizontally_FunctionAddress, "bInAnimateHorizontally", Classes.FBoolProperty);
		SetAnimateHorizontally_IsValid = SetAnimateHorizontally_FunctionAddress != IntPtr.Zero && SetAnimateHorizontally_bInAnimateHorizontally_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Throbber:SetAnimateHorizontally", SetAnimateHorizontally_IsValid);
	}
}
