using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ScaleBox", "UMG", UnrealModuleType.Engine)]
public class UScaleBox : UContentWidget
{
	private static bool Stretch_IsValid;

	private static FFieldAddress Stretch_PropertyAddress;

	private static int Stretch_Offset;

	private static bool StretchDirection_IsValid;

	private static FFieldAddress StretchDirection_PropertyAddress;

	private static int StretchDirection_Offset;

	private static bool UserSpecifiedScale_IsValid;

	private static int UserSpecifiedScale_Offset;

	private static bool IgnoreInheritedScale_IsValid;

	private static FFieldAddress IgnoreInheritedScale_PropertyAddress;

	private static int IgnoreInheritedScale_Offset;

	private static bool SetUserSpecifiedScale_IsValid;

	private static IntPtr SetUserSpecifiedScale_FunctionAddress;

	private static int SetUserSpecifiedScale_ParamsSize;

	private static bool SetUserSpecifiedScale_InUserSpecifiedScale_IsValid;

	private static FFieldAddress SetUserSpecifiedScale_InUserSpecifiedScale_PropertyAddress;

	private static int SetUserSpecifiedScale_InUserSpecifiedScale_Offset;

	private static bool SetStretchDirection_IsValid;

	private static IntPtr SetStretchDirection_FunctionAddress;

	private static int SetStretchDirection_ParamsSize;

	private static bool SetStretchDirection_InStretchDirection_IsValid;

	private static FFieldAddress SetStretchDirection_InStretchDirection_PropertyAddress;

	private static int SetStretchDirection_InStretchDirection_Offset;

	private static bool SetStretch_IsValid;

	private static IntPtr SetStretch_FunctionAddress;

	private static int SetStretch_ParamsSize;

	private static bool SetStretch_InStretch_IsValid;

	private static FFieldAddress SetStretch_InStretch_PropertyAddress;

	private static int SetStretch_InStretch_Offset;

	private static bool SetIgnoreInheritedScale_IsValid;

	private static IntPtr SetIgnoreInheritedScale_FunctionAddress;

	private static int SetIgnoreInheritedScale_ParamsSize;

	private static bool SetIgnoreInheritedScale_bInIgnoreInheritedScale_IsValid;

	private static FFieldAddress SetIgnoreInheritedScale_bInIgnoreInheritedScale_PropertyAddress;

	private static int SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScaleBox:Stretch")]
	public EStretch Stretch
	{
		get
		{
			CheckDestroyed();
			if (!Stretch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:Stretch");
				return EStretch.None;
			}
			return EnumMarshaler<EStretch>.FromNative(IntPtr.Add(base.Address, Stretch_Offset), 0, Stretch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Stretch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:Stretch");
			}
			else
			{
				EnumMarshaler<EStretch>.ToNative(IntPtr.Add(base.Address, Stretch_Offset), 0, Stretch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScaleBox:StretchDirection")]
	public EStretchDirection StretchDirection
	{
		get
		{
			CheckDestroyed();
			if (!StretchDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:StretchDirection");
				return EStretchDirection.Both;
			}
			return EnumMarshaler<EStretchDirection>.FromNative(IntPtr.Add(base.Address, StretchDirection_Offset), 0, StretchDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StretchDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:StretchDirection");
			}
			else
			{
				EnumMarshaler<EStretchDirection>.ToNative(IntPtr.Add(base.Address, StretchDirection_Offset), 0, StretchDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScaleBox:UserSpecifiedScale")]
	public float UserSpecifiedScale
	{
		get
		{
			CheckDestroyed();
			if (!UserSpecifiedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:UserSpecifiedScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UserSpecifiedScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserSpecifiedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:UserSpecifiedScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UserSpecifiedScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ScaleBox:IgnoreInheritedScale")]
	public bool IgnoreInheritedScale
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreInheritedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:IgnoreInheritedScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreInheritedScale_Offset), 0, IgnoreInheritedScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreInheritedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScaleBox:IgnoreInheritedScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreInheritedScale_Offset), 0, IgnoreInheritedScale_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScaleBox:SetUserSpecifiedScale")]
	public unsafe void SetUserSpecifiedScale(float InUserSpecifiedScale)
	{
		CheckDestroyed();
		if (!SetUserSpecifiedScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScaleBox:SetUserSpecifiedScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUserSpecifiedScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUserSpecifiedScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetUserSpecifiedScale_InUserSpecifiedScale_Offset), 0, SetUserSpecifiedScale_InUserSpecifiedScale_PropertyAddress.Address, InUserSpecifiedScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUserSpecifiedScale_FunctionAddress, intPtr, SetUserSpecifiedScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScaleBox:SetStretchDirection")]
	public unsafe void SetStretchDirection(EStretchDirection InStretchDirection)
	{
		CheckDestroyed();
		if (!SetStretchDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScaleBox:SetStretchDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStretchDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStretchDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EStretchDirection>.ToNative(IntPtr.Add(intPtr, SetStretchDirection_InStretchDirection_Offset), 0, SetStretchDirection_InStretchDirection_PropertyAddress.Address, InStretchDirection);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStretchDirection_FunctionAddress, intPtr, SetStretchDirection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScaleBox:SetStretch")]
	public unsafe void SetStretch(EStretch InStretch)
	{
		CheckDestroyed();
		if (!SetStretch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScaleBox:SetStretch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStretch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStretch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EStretch>.ToNative(IntPtr.Add(intPtr, SetStretch_InStretch_Offset), 0, SetStretch_InStretch_PropertyAddress.Address, InStretch);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStretch_FunctionAddress, intPtr, SetStretch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScaleBox:SetIgnoreInheritedScale")]
	public unsafe void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
	{
		CheckDestroyed();
		if (!SetIgnoreInheritedScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScaleBox:SetIgnoreInheritedScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIgnoreInheritedScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIgnoreInheritedScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset), 0, SetIgnoreInheritedScale_bInIgnoreInheritedScale_PropertyAddress.Address, bInIgnoreInheritedScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIgnoreInheritedScale_FunctionAddress, intPtr, SetIgnoreInheritedScale_ParamsSize);
	}

	static UScaleBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UScaleBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UScaleBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ScaleBox");
		NativeReflectionCached.GetPropertyRef(ref Stretch_PropertyAddress, intPtr, "Stretch");
		Stretch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Stretch");
		Stretch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Stretch", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref StretchDirection_PropertyAddress, intPtr, "StretchDirection");
		StretchDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StretchDirection");
		StretchDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StretchDirection", Classes.FByteProperty);
		UserSpecifiedScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserSpecifiedScale");
		UserSpecifiedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserSpecifiedScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreInheritedScale_PropertyAddress, intPtr, "IgnoreInheritedScale");
		IgnoreInheritedScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IgnoreInheritedScale");
		IgnoreInheritedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IgnoreInheritedScale", Classes.FBoolProperty);
		SetUserSpecifiedScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUserSpecifiedScale");
		SetUserSpecifiedScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUserSpecifiedScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUserSpecifiedScale_InUserSpecifiedScale_PropertyAddress, SetUserSpecifiedScale_FunctionAddress, "InUserSpecifiedScale");
		SetUserSpecifiedScale_InUserSpecifiedScale_Offset = NativeReflectionCached.GetPropertyOffset(SetUserSpecifiedScale_FunctionAddress, "InUserSpecifiedScale");
		SetUserSpecifiedScale_InUserSpecifiedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserSpecifiedScale_FunctionAddress, "InUserSpecifiedScale", Classes.FFloatProperty);
		SetUserSpecifiedScale_IsValid = SetUserSpecifiedScale_FunctionAddress != IntPtr.Zero && SetUserSpecifiedScale_InUserSpecifiedScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScaleBox:SetUserSpecifiedScale", SetUserSpecifiedScale_IsValid);
		SetStretchDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStretchDirection");
		SetStretchDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStretchDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStretchDirection_InStretchDirection_PropertyAddress, SetStretchDirection_FunctionAddress, "InStretchDirection");
		SetStretchDirection_InStretchDirection_Offset = NativeReflectionCached.GetPropertyOffset(SetStretchDirection_FunctionAddress, "InStretchDirection");
		SetStretchDirection_InStretchDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStretchDirection_FunctionAddress, "InStretchDirection", Classes.FByteProperty);
		SetStretchDirection_IsValid = SetStretchDirection_FunctionAddress != IntPtr.Zero && SetStretchDirection_InStretchDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScaleBox:SetStretchDirection", SetStretchDirection_IsValid);
		SetStretch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStretch");
		SetStretch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStretch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStretch_InStretch_PropertyAddress, SetStretch_FunctionAddress, "InStretch");
		SetStretch_InStretch_Offset = NativeReflectionCached.GetPropertyOffset(SetStretch_FunctionAddress, "InStretch");
		SetStretch_InStretch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStretch_FunctionAddress, "InStretch", Classes.FByteProperty);
		SetStretch_IsValid = SetStretch_FunctionAddress != IntPtr.Zero && SetStretch_InStretch_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScaleBox:SetStretch", SetStretch_IsValid);
		SetIgnoreInheritedScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIgnoreInheritedScale");
		SetIgnoreInheritedScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIgnoreInheritedScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreInheritedScale_bInIgnoreInheritedScale_PropertyAddress, SetIgnoreInheritedScale_FunctionAddress, "bInIgnoreInheritedScale");
		SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreInheritedScale_FunctionAddress, "bInIgnoreInheritedScale");
		SetIgnoreInheritedScale_bInIgnoreInheritedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreInheritedScale_FunctionAddress, "bInIgnoreInheritedScale", Classes.FBoolProperty);
		SetIgnoreInheritedScale_IsValid = SetIgnoreInheritedScale_FunctionAddress != IntPtr.Zero && SetIgnoreInheritedScale_bInIgnoreInheritedScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScaleBox:SetIgnoreInheritedScale", SetIgnoreInheritedScale_IsValid);
	}
}
