using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSInput.GSInputActionIcon", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputActionIcon : UImage
{
	private static bool SpeedRatioOnStopHold_IsValid;

	private static int SpeedRatioOnStopHold_Offset;

	private static bool InputIconTexture_IsValid;

	private static int InputIconTexture_Offset;

	private static bool PlatformInputIconTextures_IsValid;

	private static FFieldAddress PlatformInputIconTextures_PropertyAddress;

	private static int PlatformInputIconTextures_Offset;

	private TMapReadOnlyMarshaler<EGSInputActionIconSupportedPlatform, UTexture2D> PlatformInputIconTextures_MarshalerCached;

	private static bool InputAction_IsValid;

	private static int InputAction_Offset;

	private static bool ExtraInputActions_IsValid;

	private static FFieldAddress ExtraInputActions_PropertyAddress;

	private static int ExtraInputActions_Offset;

	private TArrayReadOnlyMarshaler<UInputAction> ExtraInputActions_MarshalerCached;

	private static bool IconShowType_IsValid;

	private static FFieldAddress IconShowType_PropertyAddress;

	private static int IconShowType_Offset;

	private static bool ShouldApplyOffset_IsValid;

	private static FFieldAddress ShouldApplyOffset_PropertyAddress;

	private static int ShouldApplyOffset_Offset;

	private static bool IconScale_IsValid;

	private static int IconScale_Offset;

	private static bool ComboIconOnlyShowOneType_IsValid;

	private static FFieldAddress ComboIconOnlyShowOneType_PropertyAddress;

	private static int ComboIconOnlyShowOneType_Offset;

	private static bool StopHold_IsValid;

	private static IntPtr StopHold_FunctionAddress;

	private static int StopHold_ParamsSize;

	private static bool SetPercent_IsValid;

	private static IntPtr SetPercent_FunctionAddress;

	private static int SetPercent_ParamsSize;

	private static bool SetPercent_InPercent_IsValid;

	private static FFieldAddress SetPercent_InPercent_PropertyAddress;

	private static int SetPercent_InPercent_Offset;

	private static bool SetInputAction_IsValid;

	private static IntPtr SetInputAction_FunctionAddress;

	private static int SetInputAction_ParamsSize;

	private static bool SetInputAction_InputAction_IsValid;

	private static FFieldAddress SetInputAction_InputAction_PropertyAddress;

	private static int SetInputAction_InputAction_Offset;

	private static bool Reset_IsValid;

	private static IntPtr Reset_FunctionAddress;

	private static int Reset_ParamsSize;

	private static bool OpenPercentBg_IsValid;

	private static IntPtr OpenPercentBg_FunctionAddress;

	private static int OpenPercentBg_ParamsSize;

	private static bool OpenPercentBg_bOpen_IsValid;

	private static FFieldAddress OpenPercentBg_bOpen_PropertyAddress;

	private static int OpenPercentBg_bOpen_Offset;

	private static bool BeginHold_IsValid;

	private static IntPtr BeginHold_FunctionAddress;

	private static int BeginHold_ParamsSize;

	private static bool BeginHold_InTotalTime_IsValid;

	private static FFieldAddress BeginHold_InTotalTime_PropertyAddress;

	private static int BeginHold_InTotalTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:SpeedRatioOnStopHold")]
	public float SpeedRatioOnStopHold
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRatioOnStopHold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:SpeedRatioOnStopHold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedRatioOnStopHold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRatioOnStopHold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:SpeedRatioOnStopHold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedRatioOnStopHold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:InputIconTexture")]
	protected UTexture2D InputIconTexture
	{
		get
		{
			CheckDestroyed();
			if (!InputIconTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:InputIconTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, InputIconTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputIconTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:InputIconTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, InputIconTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763221uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:PlatformInputIconTextures")]
	protected TMapReadOnly<EGSInputActionIconSupportedPlatform, UTexture2D> PlatformInputIconTextures
	{
		get
		{
			CheckDestroyed();
			if (!PlatformInputIconTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:PlatformInputIconTextures");
				return null;
			}
			if (PlatformInputIconTextures_MarshalerCached == null)
			{
				PlatformInputIconTextures_MarshalerCached = new TMapReadOnlyMarshaler<EGSInputActionIconSupportedPlatform, UTexture2D>(1, PlatformInputIconTextures_PropertyAddress, CachedMarshalingDelegates<EGSInputActionIconSupportedPlatform, EnumMarshaler<EGSInputActionIconSupportedPlatform>>.FromNative, CachedMarshalingDelegates<EGSInputActionIconSupportedPlatform, EnumMarshaler<EGSInputActionIconSupportedPlatform>>.ToNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.FromNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.ToNative);
			}
			return PlatformInputIconTextures_MarshalerCached.FromNative(IntPtr.Add(base.Address, PlatformInputIconTextures_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:InputAction")]
	protected UInputAction InputAction
	{
		get
		{
			CheckDestroyed();
			if (!InputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:InputAction");
				return null;
			}
			return UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(base.Address, InputAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:InputAction");
			}
			else
			{
				UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(base.Address, InputAction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763733uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:ExtraInputActions")]
	protected TArrayReadOnly<UInputAction> ExtraInputActions
	{
		get
		{
			CheckDestroyed();
			if (!ExtraInputActions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:ExtraInputActions");
				return null;
			}
			if (ExtraInputActions_MarshalerCached == null)
			{
				ExtraInputActions_MarshalerCached = new TArrayReadOnlyMarshaler<UInputAction>(1, ExtraInputActions_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative);
			}
			return ExtraInputActions_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExtraInputActions_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:IconShowType")]
	protected EGSInputIconShowType IconShowType
	{
		get
		{
			CheckDestroyed();
			if (!IconShowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:IconShowType");
				return EGSInputIconShowType.KeyboardMouse;
			}
			return EnumMarshaler<EGSInputIconShowType>.FromNative(IntPtr.Add(base.Address, IconShowType_Offset), 0, IconShowType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IconShowType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:IconShowType");
			}
			else
			{
				EnumMarshaler<EGSInputIconShowType>.ToNative(IntPtr.Add(base.Address, IconShowType_Offset), 0, IconShowType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:bShouldApplyOffset")]
	protected bool ShouldApplyOffset
	{
		get
		{
			CheckDestroyed();
			if (!ShouldApplyOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:bShouldApplyOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldApplyOffset_Offset), 0, ShouldApplyOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldApplyOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:bShouldApplyOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldApplyOffset_Offset), 0, ShouldApplyOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:IconScale")]
	protected float IconScale
	{
		get
		{
			CheckDestroyed();
			if (!IconScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:IconScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IconScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IconScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:IconScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IconScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:ComboIconOnlyShowOneType")]
	protected EGSComboOnlyShowOneType ComboIconOnlyShowOneType
	{
		get
		{
			CheckDestroyed();
			if (!ComboIconOnlyShowOneType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:ComboIconOnlyShowOneType");
				return EGSComboOnlyShowOneType.First;
			}
			return EnumMarshaler<EGSComboOnlyShowOneType>.FromNative(IntPtr.Add(base.Address, ComboIconOnlyShowOneType_Offset), 0, ComboIconOnlyShowOneType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComboIconOnlyShowOneType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputActionIcon:ComboIconOnlyShowOneType");
			}
			else
			{
				EnumMarshaler<EGSComboOnlyShowOneType>.ToNative(IntPtr.Add(base.Address, ComboIconOnlyShowOneType_Offset), 0, ComboIconOnlyShowOneType_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:StopHold")]
	public unsafe void StopHold()
	{
		CheckDestroyed();
		if (!StopHold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputActionIcon:StopHold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopHold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopHold_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopHold_FunctionAddress, argsSize: StopHold_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:SetPercent")]
	public unsafe void SetPercent(float InPercent)
	{
		CheckDestroyed();
		if (!SetPercent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputActionIcon:SetPercent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPercent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPercent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPercent_InPercent_Offset), 0, SetPercent_InPercent_PropertyAddress.Address, InPercent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPercent_FunctionAddress, intPtr, SetPercent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:SetInputAction")]
	public unsafe void SetInputAction(UInputAction InputAction)
	{
		CheckDestroyed();
		if (!SetInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputActionIcon:SetInputAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, SetInputAction_InputAction_Offset), 0, SetInputAction_InputAction_PropertyAddress.Address, InputAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInputAction_FunctionAddress, intPtr, SetInputAction_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:Reset")]
	public unsafe void Reset()
	{
		CheckDestroyed();
		if (!Reset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputActionIcon:Reset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Reset_FunctionAddress, argsSize: Reset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:OpenPercentBg")]
	public unsafe void OpenPercentBg(bool bOpen = true)
	{
		CheckDestroyed();
		if (!OpenPercentBg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputActionIcon:OpenPercentBg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenPercentBg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenPercentBg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OpenPercentBg_bOpen_Offset), 0, OpenPercentBg_bOpen_PropertyAddress.Address, bOpen);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenPercentBg_FunctionAddress, intPtr, OpenPercentBg_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSInput.GSInputActionIcon:BeginHold")]
	public unsafe void BeginHold(float InTotalTime)
	{
		CheckDestroyed();
		if (!BeginHold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSInputActionIcon:BeginHold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginHold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginHold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BeginHold_InTotalTime_Offset), 0, BeginHold_InTotalTime_PropertyAddress.Address, InTotalTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginHold_FunctionAddress, intPtr, BeginHold_ParamsSize);
	}

	static UGSInputActionIcon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputActionIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputActionIcon));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSInput.GSInputActionIcon");
		SpeedRatioOnStopHold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedRatioOnStopHold");
		SpeedRatioOnStopHold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedRatioOnStopHold", Classes.FFloatProperty);
		InputIconTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputIconTexture");
		InputIconTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputIconTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlatformInputIconTextures_PropertyAddress, intPtr, "PlatformInputIconTextures");
		PlatformInputIconTextures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlatformInputIconTextures");
		PlatformInputIconTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlatformInputIconTextures", Classes.FMapProperty);
		InputAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputAction");
		InputAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtraInputActions_PropertyAddress, intPtr, "ExtraInputActions");
		ExtraInputActions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExtraInputActions");
		ExtraInputActions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExtraInputActions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IconShowType_PropertyAddress, intPtr, "IconShowType");
		IconShowType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IconShowType");
		IconShowType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IconShowType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldApplyOffset_PropertyAddress, intPtr, "bShouldApplyOffset");
		ShouldApplyOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldApplyOffset");
		ShouldApplyOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldApplyOffset", Classes.FBoolProperty);
		IconScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IconScale");
		IconScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IconScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ComboIconOnlyShowOneType_PropertyAddress, intPtr, "ComboIconOnlyShowOneType");
		ComboIconOnlyShowOneType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComboIconOnlyShowOneType");
		ComboIconOnlyShowOneType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComboIconOnlyShowOneType", Classes.FEnumProperty);
		StopHold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopHold");
		StopHold_ParamsSize = NativeReflection.GetFunctionParamsSize(StopHold_FunctionAddress);
		StopHold_IsValid = StopHold_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputActionIcon:StopHold", StopHold_IsValid);
		SetPercent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPercent");
		SetPercent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPercent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPercent_InPercent_PropertyAddress, SetPercent_FunctionAddress, "InPercent");
		SetPercent_InPercent_Offset = NativeReflectionCached.GetPropertyOffset(SetPercent_FunctionAddress, "InPercent");
		SetPercent_InPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPercent_FunctionAddress, "InPercent", Classes.FFloatProperty);
		SetPercent_IsValid = SetPercent_FunctionAddress != IntPtr.Zero && SetPercent_InPercent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputActionIcon:SetPercent", SetPercent_IsValid);
		SetInputAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInputAction");
		SetInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputAction_InputAction_PropertyAddress, SetInputAction_FunctionAddress, "InputAction");
		SetInputAction_InputAction_Offset = NativeReflectionCached.GetPropertyOffset(SetInputAction_FunctionAddress, "InputAction");
		SetInputAction_InputAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputAction_FunctionAddress, "InputAction", Classes.FObjectProperty);
		SetInputAction_IsValid = SetInputAction_FunctionAddress != IntPtr.Zero && SetInputAction_InputAction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputActionIcon:SetInputAction", SetInputAction_IsValid);
		Reset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reset");
		Reset_ParamsSize = NativeReflection.GetFunctionParamsSize(Reset_FunctionAddress);
		Reset_IsValid = Reset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputActionIcon:Reset", Reset_IsValid);
		OpenPercentBg_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenPercentBg");
		OpenPercentBg_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenPercentBg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenPercentBg_bOpen_PropertyAddress, OpenPercentBg_FunctionAddress, "bOpen");
		OpenPercentBg_bOpen_Offset = NativeReflectionCached.GetPropertyOffset(OpenPercentBg_FunctionAddress, "bOpen");
		OpenPercentBg_bOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPercentBg_FunctionAddress, "bOpen", Classes.FBoolProperty);
		OpenPercentBg_IsValid = OpenPercentBg_FunctionAddress != IntPtr.Zero && OpenPercentBg_bOpen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputActionIcon:OpenPercentBg", OpenPercentBg_IsValid);
		BeginHold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginHold");
		BeginHold_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginHold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginHold_InTotalTime_PropertyAddress, BeginHold_FunctionAddress, "InTotalTime");
		BeginHold_InTotalTime_Offset = NativeReflectionCached.GetPropertyOffset(BeginHold_FunctionAddress, "InTotalTime");
		BeginHold_InTotalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginHold_FunctionAddress, "InTotalTime", Classes.FFloatProperty);
		BeginHold_IsValid = BeginHold_FunctionAddress != IntPtr.Zero && BeginHold_InTotalTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSInputActionIcon:BeginHold", BeginHold_IsValid);
	}
}
