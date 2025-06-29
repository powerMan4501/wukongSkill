using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CinematicCamera.CineCameraComponent", "CinematicCamera", UnrealModuleType.Engine)]
public class UCineCameraComponent : UCameraComponent
{
	private static IntPtr classAddress;

	private static bool Filmback_IsValid;

	private static int Filmback_Offset;

	private static bool LensSettings_IsValid;

	private static int LensSettings_Offset;

	private static bool FocusSettings_IsValid;

	private static int FocusSettings_Offset;

	private static bool CurrentFocalLength_IsValid;

	private static int CurrentFocalLength_Offset;

	private static bool CurrentAperture_IsValid;

	private static int CurrentAperture_Offset;

	private static bool CurrentFocusDistance_IsValid;

	private static int CurrentFocusDistance_Offset;

	private static bool SetLensPresetByName_IsValid;

	private static IntPtr SetLensPresetByName_FunctionAddress;

	private static int SetLensPresetByName_ParamsSize;

	private static bool SetLensPresetByName_InPresetName_IsValid;

	private static FFieldAddress SetLensPresetByName_InPresetName_PropertyAddress;

	private static int SetLensPresetByName_InPresetName_Offset;

	private static bool SetFilmbackPresetByName_IsValid;

	private static IntPtr SetFilmbackPresetByName_FunctionAddress;

	private static int SetFilmbackPresetByName_ParamsSize;

	private static bool SetFilmbackPresetByName_InPresetName_IsValid;

	private static FFieldAddress SetFilmbackPresetByName_InPresetName_PropertyAddress;

	private static int SetFilmbackPresetByName_InPresetName_Offset;

	private static bool SetCurrentFocalLength_IsValid;

	private static IntPtr SetCurrentFocalLength_FunctionAddress;

	private static int SetCurrentFocalLength_ParamsSize;

	private static bool SetCurrentFocalLength_InFocalLength_IsValid;

	private static FFieldAddress SetCurrentFocalLength_InFocalLength_PropertyAddress;

	private static int SetCurrentFocalLength_InFocalLength_Offset;

	private static bool GetVerticalFieldOfView_IsValid;

	private static IntPtr GetVerticalFieldOfView_FunctionAddress;

	private static int GetVerticalFieldOfView_ParamsSize;

	private static bool GetVerticalFieldOfView_ReturnValue_IsValid;

	private static FFieldAddress GetVerticalFieldOfView_ReturnValue_PropertyAddress;

	private static int GetVerticalFieldOfView_ReturnValue_Offset;

	private static bool GetLensPresetsCopy_IsValid;

	private static IntPtr GetLensPresetsCopy_FunctionAddress;

	private static int GetLensPresetsCopy_ParamsSize;

	private static bool GetLensPresetsCopy_ReturnValue_IsValid;

	private static FFieldAddress GetLensPresetsCopy_ReturnValue_PropertyAddress;

	private static int GetLensPresetsCopy_ReturnValue_Offset;

	private static bool GetLensPresetName_IsValid;

	private static IntPtr GetLensPresetName_FunctionAddress;

	private static int GetLensPresetName_ParamsSize;

	private static bool GetLensPresetName_ReturnValue_IsValid;

	private static FFieldAddress GetLensPresetName_ReturnValue_PropertyAddress;

	private static int GetLensPresetName_ReturnValue_Offset;

	private static bool GetHorizontalFieldOfView_IsValid;

	private static IntPtr GetHorizontalFieldOfView_FunctionAddress;

	private static int GetHorizontalFieldOfView_ParamsSize;

	private static bool GetHorizontalFieldOfView_ReturnValue_IsValid;

	private static FFieldAddress GetHorizontalFieldOfView_ReturnValue_PropertyAddress;

	private static int GetHorizontalFieldOfView_ReturnValue_Offset;

	private static bool GetFilmbackPresetsCopy_IsValid;

	private static IntPtr GetFilmbackPresetsCopy_FunctionAddress;

	private static int GetFilmbackPresetsCopy_ParamsSize;

	private static bool GetFilmbackPresetsCopy_ReturnValue_IsValid;

	private static FFieldAddress GetFilmbackPresetsCopy_ReturnValue_PropertyAddress;

	private static int GetFilmbackPresetsCopy_ReturnValue_Offset;

	private static bool GetFilmbackPresetName_IsValid;

	private static IntPtr GetFilmbackPresetName_FunctionAddress;

	private static int GetFilmbackPresetName_ParamsSize;

	private static bool GetFilmbackPresetName_ReturnValue_IsValid;

	private static FFieldAddress GetFilmbackPresetName_ReturnValue_PropertyAddress;

	private static int GetFilmbackPresetName_ReturnValue_Offset;

	private static bool GetDefaultFilmbackPresetName_IsValid;

	private static IntPtr GetDefaultFilmbackPresetName_FunctionAddress;

	private static int GetDefaultFilmbackPresetName_ParamsSize;

	private static bool GetDefaultFilmbackPresetName_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultFilmbackPresetName_ReturnValue_PropertyAddress;

	private static int GetDefaultFilmbackPresetName_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:Filmback")]
	public FCameraFilmbackSettings Filmback
	{
		get
		{
			CheckDestroyed();
			if (!Filmback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:Filmback");
				return default(FCameraFilmbackSettings);
			}
			return FCameraFilmbackSettings.FromNative(IntPtr.Add(base.Address, Filmback_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Filmback_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:Filmback");
			}
			else
			{
				FCameraFilmbackSettings.ToNative(IntPtr.Add(base.Address, Filmback_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:LensSettings")]
	public FCameraLensSettings LensSettings
	{
		get
		{
			CheckDestroyed();
			if (!LensSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:LensSettings");
				return default(FCameraLensSettings);
			}
			return FCameraLensSettings.FromNative(IntPtr.Add(base.Address, LensSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LensSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:LensSettings");
			}
			else
			{
				FCameraLensSettings.ToNative(IntPtr.Add(base.Address, LensSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:FocusSettings")]
	public FCameraFocusSettings FocusSettings
	{
		get
		{
			CheckDestroyed();
			if (!FocusSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:FocusSettings");
				return default(FCameraFocusSettings);
			}
			return FCameraFocusSettings.FromNative(IntPtr.Add(base.Address, FocusSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FocusSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:FocusSettings");
			}
			else
			{
				FCameraFocusSettings.ToNative(IntPtr.Add(base.Address, FocusSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:CurrentFocalLength")]
	public float CurrentFocalLength
	{
		get
		{
			CheckDestroyed();
			if (!CurrentFocalLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:CurrentFocalLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurrentFocalLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentFocalLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:CurrentFocalLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurrentFocalLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:CurrentAperture")]
	public float CurrentAperture
	{
		get
		{
			CheckDestroyed();
			if (!CurrentAperture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:CurrentAperture");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurrentAperture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentAperture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:CurrentAperture");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurrentAperture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:CurrentFocusDistance")]
	public float CurrentFocusDistance
	{
		get
		{
			CheckDestroyed();
			if (!CurrentFocusDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:CurrentFocusDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurrentFocusDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentFocusDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicCamera.CineCameraComponent:CurrentFocusDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurrentFocusDistance_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:SetLensPresetByName")]
	public unsafe void SetLensPresetByName(string InPresetName)
	{
		CheckDestroyed();
		if (!SetLensPresetByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:SetLensPresetByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLensPresetByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLensPresetByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLensPresetByName_InPresetName_Offset), 0, SetLensPresetByName_InPresetName_PropertyAddress.Address, InPresetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLensPresetByName_FunctionAddress, intPtr, SetLensPresetByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLensPresetByName_InPresetName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:SetFilmbackPresetByName")]
	public unsafe void SetFilmbackPresetByName(string InPresetName)
	{
		CheckDestroyed();
		if (!SetFilmbackPresetByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:SetFilmbackPresetByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilmbackPresetByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilmbackPresetByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFilmbackPresetByName_InPresetName_Offset), 0, SetFilmbackPresetByName_InPresetName_PropertyAddress.Address, InPresetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilmbackPresetByName_FunctionAddress, intPtr, SetFilmbackPresetByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFilmbackPresetByName_InPresetName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:SetCurrentFocalLength")]
	public unsafe void SetCurrentFocalLength(float InFocalLength)
	{
		CheckDestroyed();
		if (!SetCurrentFocalLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:SetCurrentFocalLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentFocalLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentFocalLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCurrentFocalLength_InFocalLength_Offset), 0, SetCurrentFocalLength_InFocalLength_PropertyAddress.Address, InFocalLength);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurrentFocalLength_FunctionAddress, intPtr, SetCurrentFocalLength_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetVerticalFieldOfView")]
	public unsafe float GetVerticalFieldOfView()
	{
		CheckDestroyed();
		if (!GetVerticalFieldOfView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetVerticalFieldOfView");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVerticalFieldOfView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVerticalFieldOfView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVerticalFieldOfView_FunctionAddress, intPtr, GetVerticalFieldOfView_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetVerticalFieldOfView_ReturnValue_Offset), 0, GetVerticalFieldOfView_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetLensPresetsCopy")]
	public unsafe static List<FNamedLensPreset> GetLensPresetsCopy()
	{
		if (!GetLensPresetsCopy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetLensPresetsCopy");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLensPresetsCopy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLensPresetsCopy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLensPresetsCopy_FunctionAddress, intPtr, GetLensPresetsCopy_ParamsSize);
		List<FNamedLensPreset> result = new TArrayCopyMarshaler<FNamedLensPreset>(1, GetLensPresetsCopy_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FNamedLensPreset, FNamedLensPreset>.FromNative, CachedMarshalingDelegates<FNamedLensPreset, FNamedLensPreset>.ToNative).FromNative(IntPtr.Add(intPtr, GetLensPresetsCopy_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLensPresetsCopy_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetLensPresetName")]
	public unsafe string GetLensPresetName()
	{
		CheckDestroyed();
		if (!GetLensPresetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetLensPresetName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLensPresetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLensPresetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLensPresetName_FunctionAddress, intPtr, GetLensPresetName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLensPresetName_ReturnValue_Offset), 0, GetLensPresetName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLensPresetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetHorizontalFieldOfView")]
	public unsafe float GetHorizontalFieldOfView()
	{
		CheckDestroyed();
		if (!GetHorizontalFieldOfView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetHorizontalFieldOfView");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHorizontalFieldOfView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHorizontalFieldOfView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHorizontalFieldOfView_FunctionAddress, intPtr, GetHorizontalFieldOfView_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetHorizontalFieldOfView_ReturnValue_Offset), 0, GetHorizontalFieldOfView_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetFilmbackPresetsCopy")]
	public unsafe static List<FNamedFilmbackPreset> GetFilmbackPresetsCopy()
	{
		if (!GetFilmbackPresetsCopy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetFilmbackPresetsCopy");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFilmbackPresetsCopy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFilmbackPresetsCopy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFilmbackPresetsCopy_FunctionAddress, intPtr, GetFilmbackPresetsCopy_ParamsSize);
		List<FNamedFilmbackPreset> result = new TArrayCopyMarshaler<FNamedFilmbackPreset>(1, GetFilmbackPresetsCopy_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FNamedFilmbackPreset, FNamedFilmbackPreset>.FromNative, CachedMarshalingDelegates<FNamedFilmbackPreset, FNamedFilmbackPreset>.ToNative).FromNative(IntPtr.Add(intPtr, GetFilmbackPresetsCopy_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetFilmbackPresetsCopy_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetFilmbackPresetName")]
	public unsafe string GetFilmbackPresetName()
	{
		CheckDestroyed();
		if (!GetFilmbackPresetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetFilmbackPresetName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFilmbackPresetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFilmbackPresetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFilmbackPresetName_FunctionAddress, intPtr, GetFilmbackPresetName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFilmbackPresetName_ReturnValue_Offset), 0, GetFilmbackPresetName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFilmbackPresetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicCamera.CineCameraComponent:GetDefaultFilmbackPresetName")]
	public unsafe string GetDefaultFilmbackPresetName()
	{
		CheckDestroyed();
		if (!GetDefaultFilmbackPresetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicCamera.CineCameraComponent:GetDefaultFilmbackPresetName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultFilmbackPresetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultFilmbackPresetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultFilmbackPresetName_FunctionAddress, intPtr, GetDefaultFilmbackPresetName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDefaultFilmbackPresetName_ReturnValue_Offset), 0, GetDefaultFilmbackPresetName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultFilmbackPresetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UCineCameraComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCineCameraComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCineCameraComponent));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/CinematicCamera.CineCameraComponent");
		Filmback_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Filmback");
		Filmback_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Filmback", Classes.FStructProperty);
		LensSettings_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "LensSettings");
		LensSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "LensSettings", Classes.FStructProperty);
		FocusSettings_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "FocusSettings");
		FocusSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "FocusSettings", Classes.FStructProperty);
		CurrentFocalLength_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CurrentFocalLength");
		CurrentFocalLength_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CurrentFocalLength", Classes.FFloatProperty);
		CurrentAperture_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CurrentAperture");
		CurrentAperture_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CurrentAperture", Classes.FFloatProperty);
		CurrentFocusDistance_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CurrentFocusDistance");
		CurrentFocusDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CurrentFocusDistance", Classes.FFloatProperty);
		SetLensPresetByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLensPresetByName");
		SetLensPresetByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLensPresetByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLensPresetByName_InPresetName_PropertyAddress, SetLensPresetByName_FunctionAddress, "InPresetName");
		SetLensPresetByName_InPresetName_Offset = NativeReflectionCached.GetPropertyOffset(SetLensPresetByName_FunctionAddress, "InPresetName");
		SetLensPresetByName_InPresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLensPresetByName_FunctionAddress, "InPresetName", Classes.FStrProperty);
		SetLensPresetByName_IsValid = SetLensPresetByName_FunctionAddress != IntPtr.Zero && SetLensPresetByName_InPresetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:SetLensPresetByName", SetLensPresetByName_IsValid);
		SetFilmbackPresetByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFilmbackPresetByName");
		SetFilmbackPresetByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilmbackPresetByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilmbackPresetByName_InPresetName_PropertyAddress, SetFilmbackPresetByName_FunctionAddress, "InPresetName");
		SetFilmbackPresetByName_InPresetName_Offset = NativeReflectionCached.GetPropertyOffset(SetFilmbackPresetByName_FunctionAddress, "InPresetName");
		SetFilmbackPresetByName_InPresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilmbackPresetByName_FunctionAddress, "InPresetName", Classes.FStrProperty);
		SetFilmbackPresetByName_IsValid = SetFilmbackPresetByName_FunctionAddress != IntPtr.Zero && SetFilmbackPresetByName_InPresetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:SetFilmbackPresetByName", SetFilmbackPresetByName_IsValid);
		SetCurrentFocalLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentFocalLength");
		SetCurrentFocalLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentFocalLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentFocalLength_InFocalLength_PropertyAddress, SetCurrentFocalLength_FunctionAddress, "InFocalLength");
		SetCurrentFocalLength_InFocalLength_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentFocalLength_FunctionAddress, "InFocalLength");
		SetCurrentFocalLength_InFocalLength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentFocalLength_FunctionAddress, "InFocalLength", Classes.FFloatProperty);
		SetCurrentFocalLength_IsValid = SetCurrentFocalLength_FunctionAddress != IntPtr.Zero && SetCurrentFocalLength_InFocalLength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:SetCurrentFocalLength", SetCurrentFocalLength_IsValid);
		GetVerticalFieldOfView_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVerticalFieldOfView");
		GetVerticalFieldOfView_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVerticalFieldOfView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVerticalFieldOfView_ReturnValue_PropertyAddress, GetVerticalFieldOfView_FunctionAddress, "ReturnValue");
		GetVerticalFieldOfView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVerticalFieldOfView_FunctionAddress, "ReturnValue");
		GetVerticalFieldOfView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVerticalFieldOfView_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetVerticalFieldOfView_IsValid = GetVerticalFieldOfView_FunctionAddress != IntPtr.Zero && GetVerticalFieldOfView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetVerticalFieldOfView", GetVerticalFieldOfView_IsValid);
		GetLensPresetsCopy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLensPresetsCopy");
		GetLensPresetsCopy_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLensPresetsCopy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLensPresetsCopy_ReturnValue_PropertyAddress, GetLensPresetsCopy_FunctionAddress, "ReturnValue");
		GetLensPresetsCopy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLensPresetsCopy_FunctionAddress, "ReturnValue");
		GetLensPresetsCopy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLensPresetsCopy_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLensPresetsCopy_IsValid = GetLensPresetsCopy_FunctionAddress != IntPtr.Zero && GetLensPresetsCopy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetLensPresetsCopy", GetLensPresetsCopy_IsValid);
		GetLensPresetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLensPresetName");
		GetLensPresetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLensPresetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLensPresetName_ReturnValue_PropertyAddress, GetLensPresetName_FunctionAddress, "ReturnValue");
		GetLensPresetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLensPresetName_FunctionAddress, "ReturnValue");
		GetLensPresetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLensPresetName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLensPresetName_IsValid = GetLensPresetName_FunctionAddress != IntPtr.Zero && GetLensPresetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetLensPresetName", GetLensPresetName_IsValid);
		GetHorizontalFieldOfView_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHorizontalFieldOfView");
		GetHorizontalFieldOfView_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHorizontalFieldOfView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHorizontalFieldOfView_ReturnValue_PropertyAddress, GetHorizontalFieldOfView_FunctionAddress, "ReturnValue");
		GetHorizontalFieldOfView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHorizontalFieldOfView_FunctionAddress, "ReturnValue");
		GetHorizontalFieldOfView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorizontalFieldOfView_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetHorizontalFieldOfView_IsValid = GetHorizontalFieldOfView_FunctionAddress != IntPtr.Zero && GetHorizontalFieldOfView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetHorizontalFieldOfView", GetHorizontalFieldOfView_IsValid);
		GetFilmbackPresetsCopy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFilmbackPresetsCopy");
		GetFilmbackPresetsCopy_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFilmbackPresetsCopy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFilmbackPresetsCopy_ReturnValue_PropertyAddress, GetFilmbackPresetsCopy_FunctionAddress, "ReturnValue");
		GetFilmbackPresetsCopy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFilmbackPresetsCopy_FunctionAddress, "ReturnValue");
		GetFilmbackPresetsCopy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFilmbackPresetsCopy_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetFilmbackPresetsCopy_IsValid = GetFilmbackPresetsCopy_FunctionAddress != IntPtr.Zero && GetFilmbackPresetsCopy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetFilmbackPresetsCopy", GetFilmbackPresetsCopy_IsValid);
		GetFilmbackPresetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFilmbackPresetName");
		GetFilmbackPresetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFilmbackPresetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFilmbackPresetName_ReturnValue_PropertyAddress, GetFilmbackPresetName_FunctionAddress, "ReturnValue");
		GetFilmbackPresetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFilmbackPresetName_FunctionAddress, "ReturnValue");
		GetFilmbackPresetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFilmbackPresetName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFilmbackPresetName_IsValid = GetFilmbackPresetName_FunctionAddress != IntPtr.Zero && GetFilmbackPresetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetFilmbackPresetName", GetFilmbackPresetName_IsValid);
		GetDefaultFilmbackPresetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultFilmbackPresetName");
		GetDefaultFilmbackPresetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultFilmbackPresetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultFilmbackPresetName_ReturnValue_PropertyAddress, GetDefaultFilmbackPresetName_FunctionAddress, "ReturnValue");
		GetDefaultFilmbackPresetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultFilmbackPresetName_FunctionAddress, "ReturnValue");
		GetDefaultFilmbackPresetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultFilmbackPresetName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDefaultFilmbackPresetName_IsValid = GetDefaultFilmbackPresetName_FunctionAddress != IntPtr.Zero && GetDefaultFilmbackPresetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicCamera.CineCameraComponent:GetDefaultFilmbackPresetName", GetDefaultFilmbackPresetName_IsValid);
	}
}
