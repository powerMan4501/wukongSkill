using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaTexture", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaTexture : UTexture
{
	private static bool AddressX_IsValid;

	private static FFieldAddress AddressX_PropertyAddress;

	private static int AddressX_Offset;

	private static bool AddressY_IsValid;

	private static FFieldAddress AddressY_PropertyAddress;

	private static int AddressY_Offset;

	private static bool AutoClear_IsValid;

	private static FFieldAddress AutoClear_PropertyAddress;

	private static int AutoClear_Offset;

	private static bool ClearColor_IsValid;

	private static int ClearColor_Offset;

	private static bool EnableGenMips_IsValid;

	private static FFieldAddress EnableGenMips_PropertyAddress;

	private static int EnableGenMips_Offset;

	private static bool NumMips_IsValid;

	private static int NumMips_Offset;

	private static bool NewStyleOutput_IsValid;

	private static FFieldAddress NewStyleOutput_PropertyAddress;

	private static int NewStyleOutput_Offset;

	private static bool OutputFormat_IsValid;

	private static FFieldAddress OutputFormat_PropertyAddress;

	private static int OutputFormat_Offset;

	private static bool CurrentAspectRatio_IsValid;

	private static int CurrentAspectRatio_Offset;

	private static bool CurrentOrientation_IsValid;

	private static FFieldAddress CurrentOrientation_PropertyAddress;

	private static int CurrentOrientation_Offset;

	private static bool UpdateResource_IsValid;

	private static IntPtr UpdateResource_FunctionAddress;

	private static int UpdateResource_ParamsSize;

	private static bool SetMediaPlayer_IsValid;

	private static IntPtr SetMediaPlayer_FunctionAddress;

	private static int SetMediaPlayer_ParamsSize;

	private static bool SetMediaPlayer_NewMediaPlayer_IsValid;

	private static FFieldAddress SetMediaPlayer_NewMediaPlayer_PropertyAddress;

	private static int SetMediaPlayer_NewMediaPlayer_Offset;

	private static bool GetWidth_IsValid;

	private static IntPtr GetWidth_FunctionAddress;

	private static int GetWidth_ParamsSize;

	private static bool GetWidth_ReturnValue_IsValid;

	private static FFieldAddress GetWidth_ReturnValue_PropertyAddress;

	private static int GetWidth_ReturnValue_Offset;

	private static bool GetTextureNumMips_IsValid;

	private static IntPtr GetTextureNumMips_FunctionAddress;

	private static int GetTextureNumMips_ParamsSize;

	private static bool GetTextureNumMips_ReturnValue_IsValid;

	private static FFieldAddress GetTextureNumMips_ReturnValue_PropertyAddress;

	private static int GetTextureNumMips_ReturnValue_Offset;

	private static bool GetMediaPlayer_IsValid;

	private static IntPtr GetMediaPlayer_FunctionAddress;

	private static int GetMediaPlayer_ParamsSize;

	private static bool GetMediaPlayer_ReturnValue_IsValid;

	private static FFieldAddress GetMediaPlayer_ReturnValue_PropertyAddress;

	private static int GetMediaPlayer_ReturnValue_Offset;

	private static bool GetHeight_IsValid;

	private static IntPtr GetHeight_FunctionAddress;

	private static int GetHeight_ParamsSize;

	private static bool GetHeight_ReturnValue_IsValid;

	private static FFieldAddress GetHeight_ReturnValue_PropertyAddress;

	private static int GetHeight_ReturnValue_Offset;

	private static bool GetAspectRatio_IsValid;

	private static IntPtr GetAspectRatio_FunctionAddress;

	private static int GetAspectRatio_ParamsSize;

	private static bool GetAspectRatio_ReturnValue_IsValid;

	private static FFieldAddress GetAspectRatio_ReturnValue_PropertyAddress;

	private static int GetAspectRatio_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:AddressX")]
	public ETextureAddress AddressX
	{
		get
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:AddressX");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:AddressX");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressX_Offset), 0, AddressX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6760966792413701uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:AddressY")]
	public ETextureAddress AddressY
	{
		get
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:AddressY");
				return ETextureAddress.TA_Wrap;
			}
			return EnumMarshaler<ETextureAddress>.FromNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddressY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:AddressY");
			}
			else
			{
				EnumMarshaler<ETextureAddress>.ToNative(IntPtr.Add(base.Address, AddressY_Offset), 0, AddressY_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:AutoClear")]
	public bool AutoClear
	{
		get
		{
			CheckDestroyed();
			if (!AutoClear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:AutoClear");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoClear_Offset), 0, AutoClear_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoClear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:AutoClear");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoClear_Offset), 0, AutoClear_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:ClearColor")]
	public FLinearColor ClearColor
	{
		get
		{
			CheckDestroyed();
			if (!ClearColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:ClearColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ClearColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClearColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:ClearColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ClearColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:EnableGenMips")]
	public bool EnableGenMips
	{
		get
		{
			CheckDestroyed();
			if (!EnableGenMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:EnableGenMips");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableGenMips_Offset), 0, EnableGenMips_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableGenMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:EnableGenMips");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableGenMips_Offset), 0, EnableGenMips_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:NumMips")]
	public byte NumMips
	{
		get
		{
			CheckDestroyed();
			if (!NumMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:NumMips");
				return 0;
			}
			return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(base.Address, NumMips_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumMips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:NumMips");
			}
			else
			{
				BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(base.Address, NumMips_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:NewStyleOutput")]
	public bool NewStyleOutput
	{
		get
		{
			CheckDestroyed();
			if (!NewStyleOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:NewStyleOutput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NewStyleOutput_Offset), 0, NewStyleOutput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NewStyleOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:NewStyleOutput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NewStyleOutput_Offset), 0, NewStyleOutput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:OutputFormat")]
	public EMediaTextureOutputFormat OutputFormat
	{
		get
		{
			CheckDestroyed();
			if (!OutputFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:OutputFormat");
				return EMediaTextureOutputFormat.MTOF_Default;
			}
			return EnumMarshaler<EMediaTextureOutputFormat>.FromNative(IntPtr.Add(base.Address, OutputFormat_Offset), 0, OutputFormat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OutputFormat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:OutputFormat");
			}
			else
			{
				EnumMarshaler<EMediaTextureOutputFormat>.ToNative(IntPtr.Add(base.Address, OutputFormat_Offset), 0, OutputFormat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)42854634997424660uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:CurrentAspectRatio")]
	public float CurrentAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!CurrentAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:CurrentAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurrentAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:CurrentAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurrentAspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)42854634997424660uL)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:CurrentOrientation")]
	public EMediaTextureOrientation CurrentOrientation
	{
		get
		{
			CheckDestroyed();
			if (!CurrentOrientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:CurrentOrientation");
				return EMediaTextureOrientation.MTORI_Original;
			}
			return EnumMarshaler<EMediaTextureOrientation>.FromNative(IntPtr.Add(base.Address, CurrentOrientation_Offset), 0, CurrentOrientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurrentOrientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTexture:CurrentOrientation");
			}
			else
			{
				EnumMarshaler<EMediaTextureOrientation>.ToNative(IntPtr.Add(base.Address, CurrentOrientation_Offset), 0, CurrentOrientation_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:UpdateResource")]
	public unsafe void UpdateResource()
	{
		CheckDestroyed();
		if (!UpdateResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:UpdateResource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateResource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateResource_FunctionAddress, argsSize: UpdateResource_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:SetMediaPlayer")]
	public unsafe void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
	{
		CheckDestroyed();
		if (!SetMediaPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:SetMediaPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, SetMediaPlayer_NewMediaPlayer_Offset), 0, SetMediaPlayer_NewMediaPlayer_PropertyAddress.Address, NewMediaPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaPlayer_FunctionAddress, intPtr, SetMediaPlayer_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:GetWidth")]
	public unsafe int GetWidth()
	{
		CheckDestroyed();
		if (!GetWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:GetWidth");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWidth_FunctionAddress, intPtr, GetWidth_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetWidth_ReturnValue_Offset), 0, GetWidth_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:GetTextureNumMips")]
	public unsafe int GetTextureNumMips()
	{
		CheckDestroyed();
		if (!GetTextureNumMips_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:GetTextureNumMips");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureNumMips_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureNumMips_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureNumMips_FunctionAddress, intPtr, GetTextureNumMips_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureNumMips_ReturnValue_Offset), 0, GetTextureNumMips_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:GetMediaPlayer")]
	public unsafe UMediaPlayer GetMediaPlayer()
	{
		CheckDestroyed();
		if (!GetMediaPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:GetMediaPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMediaPlayer_FunctionAddress, intPtr, GetMediaPlayer_ParamsSize);
		return UObjectMarshaler<UMediaPlayer>.FromNative(IntPtr.Add(intPtr, GetMediaPlayer_ReturnValue_Offset), 0, GetMediaPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:GetHeight")]
	public unsafe int GetHeight()
	{
		CheckDestroyed();
		if (!GetHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:GetHeight");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHeight_FunctionAddress, intPtr, GetHeight_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetHeight_ReturnValue_Offset), 0, GetHeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MediaAssets.MediaTexture:GetAspectRatio")]
	public unsafe float GetAspectRatio()
	{
		CheckDestroyed();
		if (!GetAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaTexture:GetAspectRatio");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAspectRatio_FunctionAddress, intPtr, GetAspectRatio_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAspectRatio_ReturnValue_Offset), 0, GetAspectRatio_ReturnValue_PropertyAddress.Address);
	}

	static UMediaTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MediaAssets.MediaTexture");
		NativeReflectionCached.GetPropertyRef(ref AddressX_PropertyAddress, intPtr, "AddressX");
		AddressX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AddressX");
		AddressX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AddressX", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddressY_PropertyAddress, intPtr, "AddressY");
		AddressY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AddressY");
		AddressY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AddressY", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoClear_PropertyAddress, intPtr, "AutoClear");
		AutoClear_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoClear");
		AutoClear_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoClear", Classes.FBoolProperty);
		ClearColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClearColor");
		ClearColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClearColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGenMips_PropertyAddress, intPtr, "EnableGenMips");
		EnableGenMips_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableGenMips");
		EnableGenMips_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableGenMips", Classes.FBoolProperty);
		NumMips_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumMips");
		NumMips_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumMips", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref NewStyleOutput_PropertyAddress, intPtr, "NewStyleOutput");
		NewStyleOutput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewStyleOutput");
		NewStyleOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewStyleOutput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputFormat_PropertyAddress, intPtr, "OutputFormat");
		OutputFormat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputFormat");
		OutputFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputFormat", Classes.FByteProperty);
		CurrentAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentAspectRatio");
		CurrentAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentAspectRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CurrentOrientation_PropertyAddress, intPtr, "CurrentOrientation");
		CurrentOrientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentOrientation");
		CurrentOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentOrientation", Classes.FByteProperty);
		UpdateResource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateResource");
		UpdateResource_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateResource_FunctionAddress);
		UpdateResource_IsValid = UpdateResource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:UpdateResource", UpdateResource_IsValid);
		SetMediaPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMediaPlayer");
		SetMediaPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaPlayer_NewMediaPlayer_PropertyAddress, SetMediaPlayer_FunctionAddress, "NewMediaPlayer");
		SetMediaPlayer_NewMediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaPlayer_FunctionAddress, "NewMediaPlayer");
		SetMediaPlayer_NewMediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaPlayer_FunctionAddress, "NewMediaPlayer", Classes.FObjectProperty);
		SetMediaPlayer_IsValid = SetMediaPlayer_FunctionAddress != IntPtr.Zero && SetMediaPlayer_NewMediaPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:SetMediaPlayer", SetMediaPlayer_IsValid);
		GetWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWidth");
		GetWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidth_ReturnValue_PropertyAddress, GetWidth_FunctionAddress, "ReturnValue");
		GetWidth_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidth_FunctionAddress, "ReturnValue");
		GetWidth_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidth_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetWidth_IsValid = GetWidth_FunctionAddress != IntPtr.Zero && GetWidth_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:GetWidth", GetWidth_IsValid);
		GetTextureNumMips_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextureNumMips");
		GetTextureNumMips_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureNumMips_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureNumMips_ReturnValue_PropertyAddress, GetTextureNumMips_FunctionAddress, "ReturnValue");
		GetTextureNumMips_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureNumMips_FunctionAddress, "ReturnValue");
		GetTextureNumMips_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureNumMips_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTextureNumMips_IsValid = GetTextureNumMips_FunctionAddress != IntPtr.Zero && GetTextureNumMips_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:GetTextureNumMips", GetTextureNumMips_IsValid);
		GetMediaPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMediaPlayer");
		GetMediaPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayer_ReturnValue_PropertyAddress, GetMediaPlayer_FunctionAddress, "ReturnValue");
		GetMediaPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayer_FunctionAddress, "ReturnValue");
		GetMediaPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMediaPlayer_IsValid = GetMediaPlayer_FunctionAddress != IntPtr.Zero && GetMediaPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:GetMediaPlayer", GetMediaPlayer_IsValid);
		GetHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHeight");
		GetHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHeight_ReturnValue_PropertyAddress, GetHeight_FunctionAddress, "ReturnValue");
		GetHeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHeight_FunctionAddress, "ReturnValue");
		GetHeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeight_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetHeight_IsValid = GetHeight_FunctionAddress != IntPtr.Zero && GetHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:GetHeight", GetHeight_IsValid);
		GetAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAspectRatio");
		GetAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAspectRatio_ReturnValue_PropertyAddress, GetAspectRatio_FunctionAddress, "ReturnValue");
		GetAspectRatio_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAspectRatio_FunctionAddress, "ReturnValue");
		GetAspectRatio_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAspectRatio_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAspectRatio_IsValid = GetAspectRatio_FunctionAddress != IntPtr.Zero && GetAspectRatio_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaTexture:GetAspectRatio", GetAspectRatio_IsValid);
	}
}
