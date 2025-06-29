using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.WrapBox", "UMG", UnrealModuleType.Engine)]
public class UWrapBox : UPanelWidget
{
	private static bool InnerSlotPadding_IsValid;

	private static int InnerSlotPadding_Offset;

	private static bool WrapSize_IsValid;

	private static int WrapSize_Offset;

	private static bool ExplicitWrapSize_IsValid;

	private static FFieldAddress ExplicitWrapSize_PropertyAddress;

	private static int ExplicitWrapSize_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool Orientation_IsValid;

	private static FFieldAddress Orientation_PropertyAddress;

	private static int Orientation_Offset;

	private static bool SetInnerSlotPadding_IsValid;

	private static IntPtr SetInnerSlotPadding_FunctionAddress;

	private static int SetInnerSlotPadding_ParamsSize;

	private static bool SetInnerSlotPadding_InPadding_IsValid;

	private static FFieldAddress SetInnerSlotPadding_InPadding_PropertyAddress;

	private static int SetInnerSlotPadding_InPadding_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool AddChildToWrapBox_IsValid;

	private static IntPtr AddChildToWrapBox_FunctionAddress;

	private static int AddChildToWrapBox_ParamsSize;

	private static bool AddChildToWrapBox_Content_IsValid;

	private static FFieldAddress AddChildToWrapBox_Content_PropertyAddress;

	private static int AddChildToWrapBox_Content_Offset;

	private static bool AddChildToWrapBox_ReturnValue_IsValid;

	private static FFieldAddress AddChildToWrapBox_ReturnValue_PropertyAddress;

	private static int AddChildToWrapBox_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBox:InnerSlotPadding")]
	public FVector2D InnerSlotPadding
	{
		get
		{
			CheckDestroyed();
			if (!InnerSlotPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:InnerSlotPadding");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, InnerSlotPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InnerSlotPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:InnerSlotPadding");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, InnerSlotPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBox:WrapSize")]
	public float WrapSize
	{
		get
		{
			CheckDestroyed();
			if (!WrapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:WrapSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WrapSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WrapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:WrapSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WrapSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBox:bExplicitWrapSize")]
	public bool ExplicitWrapSize
	{
		get
		{
			CheckDestroyed();
			if (!ExplicitWrapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:bExplicitWrapSize");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExplicitWrapSize_Offset), 0, ExplicitWrapSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExplicitWrapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:bExplicitWrapSize");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExplicitWrapSize_Offset), 0, ExplicitWrapSize_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBox:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBox:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBox:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.WrapBox:SetInnerSlotPadding")]
	public unsafe void SetInnerSlotPadding(FVector2D InPadding)
	{
		CheckDestroyed();
		if (!SetInnerSlotPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBox:SetInnerSlotPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInnerSlotPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInnerSlotPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetInnerSlotPadding_InPadding_Offset), 0, SetInnerSlotPadding_InPadding_PropertyAddress.Address, InPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInnerSlotPadding_FunctionAddress, intPtr, SetInnerSlotPadding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WrapBox:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBox:SetHorizontalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizontalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizontalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(intPtr, SetHorizontalAlignment_InHorizontalAlignment_Offset), 0, SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress.Address, InHorizontalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizontalAlignment_FunctionAddress, intPtr, SetHorizontalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WrapBox:AddChildToWrapBox")]
	public unsafe UWrapBoxSlot AddChildToWrapBox(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChildToWrapBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBox:AddChildToWrapBox");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToWrapBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToWrapBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToWrapBox_Content_Offset), 0, AddChildToWrapBox_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToWrapBox_FunctionAddress, intPtr, AddChildToWrapBox_ParamsSize);
		return UObjectMarshaler<UWrapBoxSlot>.FromNative(IntPtr.Add(intPtr, AddChildToWrapBox_ReturnValue_Offset), 0, AddChildToWrapBox_ReturnValue_PropertyAddress.Address);
	}

	static UWrapBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWrapBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWrapBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.WrapBox");
		InnerSlotPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerSlotPadding");
		InnerSlotPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerSlotPadding", Classes.FStructProperty);
		WrapSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WrapSize");
		WrapSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WrapSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ExplicitWrapSize_PropertyAddress, intPtr, "bExplicitWrapSize");
		ExplicitWrapSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExplicitWrapSize");
		ExplicitWrapSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExplicitWrapSize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Orientation", Classes.FByteProperty);
		SetInnerSlotPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInnerSlotPadding");
		SetInnerSlotPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInnerSlotPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInnerSlotPadding_InPadding_PropertyAddress, SetInnerSlotPadding_FunctionAddress, "InPadding");
		SetInnerSlotPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetInnerSlotPadding_FunctionAddress, "InPadding");
		SetInnerSlotPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInnerSlotPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetInnerSlotPadding_IsValid = SetInnerSlotPadding_FunctionAddress != IntPtr.Zero && SetInnerSlotPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBox:SetInnerSlotPadding", SetInnerSlotPadding_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBox:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		AddChildToWrapBox_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddChildToWrapBox");
		AddChildToWrapBox_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToWrapBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToWrapBox_Content_PropertyAddress, AddChildToWrapBox_FunctionAddress, "Content");
		AddChildToWrapBox_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToWrapBox_FunctionAddress, "Content");
		AddChildToWrapBox_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToWrapBox_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToWrapBox_ReturnValue_PropertyAddress, AddChildToWrapBox_FunctionAddress, "ReturnValue");
		AddChildToWrapBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToWrapBox_FunctionAddress, "ReturnValue");
		AddChildToWrapBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToWrapBox_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToWrapBox_IsValid = AddChildToWrapBox_FunctionAddress != IntPtr.Zero && AddChildToWrapBox_Content_IsValid && AddChildToWrapBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBox:AddChildToWrapBox", AddChildToWrapBox_IsValid);
	}
}
