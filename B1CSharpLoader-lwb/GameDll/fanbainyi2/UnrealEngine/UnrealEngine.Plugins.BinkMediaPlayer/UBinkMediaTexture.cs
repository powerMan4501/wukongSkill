using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public class UBinkMediaTexture : UTexture
{
	private static bool AddressX_IsValid;

	private static FFieldAddress AddressX_PropertyAddress;

	private static int AddressX_Offset;

	private static bool AddressY_IsValid;

	private static FFieldAddress AddressY_PropertyAddress;

	private static int AddressY_Offset;

	private static bool MediaPlayer_IsValid;

	private static int MediaPlayer_Offset;

	private static bool PixelFormat_IsValid;

	private static FFieldAddress PixelFormat_PropertyAddress;

	private static int PixelFormat_Offset;

	private static bool Tonemap_IsValid;

	private static FFieldAddress Tonemap_PropertyAddress;

	private static int Tonemap_Offset;

	private static bool OutputNits_IsValid;

	private static int OutputNits_Offset;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	private static bool DecodeSRGB_IsValid;

	private static FFieldAddress DecodeSRGB_PropertyAddress;

	private static int DecodeSRGB_Offset;

	private static bool SetMediaPlayer_IsValid;

	private static IntPtr SetMediaPlayer_FunctionAddress;

	private static int SetMediaPlayer_ParamsSize;

	private static bool SetMediaPlayer_InMediaPlayer_IsValid;

	private static FFieldAddress SetMediaPlayer_InMediaPlayer_PropertyAddress;

	private static int SetMediaPlayer_InMediaPlayer_Offset;

	private static bool Clear_IsValid;

	private static IntPtr Clear_FunctionAddress;

	private static int Clear_ParamsSize;

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:AddressX")]
	public ETextureAddress AddressX
	{
		get
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:AddressX");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:AddressX");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902597uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:AddressY")]
	public ETextureAddress AddressY
	{
		get
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:AddressY");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:AddressY");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:MediaPlayer")]
	public UBinkMediaPlayer MediaPlayer
	{
		get
		{
			CheckDestroyed();
			if (!MediaPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:MediaPlayer");
				return null;
			}
			return UObjectMarshaler<UBinkMediaPlayer>.FromNative(IntPtr.Add(base.Address, MediaPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:MediaPlayer");
			}
			else
			{
				UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(base.Address, MediaPlayer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:PixelFormat")]
	public EPixelFormat PixelFormat
	{
		get
		{
			CheckDestroyed();
			if (!PixelFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:PixelFormat");
				return EPixelFormat.PF_Unknown;
			}
			return EnumMarshaler<EPixelFormat>.FromNative(IntPtr.Add(base.Address, PixelFormat_Offset), 0, PixelFormat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PixelFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:PixelFormat");
			}
			else
			{
				EnumMarshaler<EPixelFormat>.ToNative(IntPtr.Add(base.Address, PixelFormat_Offset), 0, PixelFormat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:Tonemap")]
	public bool Tonemap
	{
		get
		{
			CheckDestroyed();
			if (!Tonemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:Tonemap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Tonemap_Offset), 0, Tonemap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Tonemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:Tonemap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Tonemap_Offset), 0, Tonemap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:OutputNits")]
	public float OutputNits
	{
		get
		{
			CheckDestroyed();
			if (!OutputNits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:OutputNits");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OutputNits_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputNits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:OutputNits");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OutputNits_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:Alpha")]
	public float Alpha
	{
		get
		{
			CheckDestroyed();
			if (!Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:Alpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Alpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:Alpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Alpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:DecodeSRGB")]
	public bool DecodeSRGB
	{
		get
		{
			CheckDestroyed();
			if (!DecodeSRGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:DecodeSRGB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DecodeSRGB_Offset), 0, DecodeSRGB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DecodeSRGB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:DecodeSRGB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DecodeSRGB_Offset), 0, DecodeSRGB_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:SetMediaPlayer")]
	public unsafe void SetMediaPlayer(UBinkMediaPlayer InMediaPlayer)
	{
		CheckDestroyed();
		if (!SetMediaPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:SetMediaPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, SetMediaPlayer_InMediaPlayer_Offset), 0, SetMediaPlayer_InMediaPlayer_PropertyAddress.Address, InMediaPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaPlayer_FunctionAddress, intPtr, SetMediaPlayer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaTexture:Clear")]
	public unsafe void Clear()
	{
		CheckDestroyed();
		if (!Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaTexture:Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Clear_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Clear_FunctionAddress, argsSize: Clear_ParamsSize);
	}

	static UBinkMediaTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBinkMediaTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBinkMediaTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/BinkMediaPlayer.BinkMediaTexture");
		NativeReflectionCached.GetPropertyRef(ref AddressX_PropertyAddress, intPtr, "AddressX");
		AddressX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AddressX");
		AddressX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AddressX", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressY_PropertyAddress, intPtr, "AddressY");
		AddressY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AddressY");
		AddressY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AddressY", Classes.FByteProperty);
		MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MediaPlayer");
		MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PixelFormat_PropertyAddress, intPtr, "PixelFormat");
		PixelFormat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PixelFormat");
		PixelFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PixelFormat", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Tonemap_PropertyAddress, intPtr, "Tonemap");
		Tonemap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tonemap");
		Tonemap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tonemap", Classes.FBoolProperty);
		OutputNits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputNits");
		OutputNits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputNits", Classes.FFloatProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DecodeSRGB_PropertyAddress, intPtr, "DecodeSRGB");
		DecodeSRGB_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecodeSRGB");
		DecodeSRGB_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecodeSRGB", Classes.FBoolProperty);
		SetMediaPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMediaPlayer");
		SetMediaPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaPlayer_InMediaPlayer_PropertyAddress, SetMediaPlayer_FunctionAddress, "InMediaPlayer");
		SetMediaPlayer_InMediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaPlayer_FunctionAddress, "InMediaPlayer");
		SetMediaPlayer_InMediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaPlayer_FunctionAddress, "InMediaPlayer", Classes.FObjectProperty);
		SetMediaPlayer_IsValid = SetMediaPlayer_FunctionAddress != IntPtr.Zero && SetMediaPlayer_InMediaPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaTexture:SetMediaPlayer", SetMediaPlayer_IsValid);
		Clear_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Clear");
		Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Clear_FunctionAddress);
		Clear_IsValid = Clear_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaTexture:Clear", Clear_IsValid);
	}
}
