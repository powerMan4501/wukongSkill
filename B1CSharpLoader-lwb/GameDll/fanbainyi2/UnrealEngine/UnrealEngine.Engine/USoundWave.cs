using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundWave", "Engine", UnrealModuleType.Engine)]
public class USoundWave : USoundBase
{
	private static bool ModulationSettings_IsValid;

	private static int ModulationSettings_Offset;

	private static bool Mature_IsValid;

	private static FFieldAddress Mature_PropertyAddress;

	private static int Mature_Offset;

	private static bool ManualWordWrap_IsValid;

	private static FFieldAddress ManualWordWrap_PropertyAddress;

	private static int ManualWordWrap_Offset;

	private static bool SingleLine_IsValid;

	private static FFieldAddress SingleLine_PropertyAddress;

	private static int SingleLine_Offset;

	private static bool SubtitlePriority_IsValid;

	private static int SubtitlePriority_Offset;

	private static bool Subtitles_IsValid;

	private static FFieldAddress Subtitles_PropertyAddress;

	private static int Subtitles_Offset;

	private TArrayReadOnlyMarshaler<FSubtitleCue> Subtitles_MarshalerCached;

	private static bool SetSoundAssetCompressionType_IsValid;

	private static IntPtr SetSoundAssetCompressionType_FunctionAddress;

	private static int SetSoundAssetCompressionType_ParamsSize;

	private static bool SetSoundAssetCompressionType_InSoundAssetCompressionType_IsValid;

	private static FFieldAddress SetSoundAssetCompressionType_InSoundAssetCompressionType_PropertyAddress;

	private static int SetSoundAssetCompressionType_InSoundAssetCompressionType_Offset;

	private static bool GetSoundAssetCompressionType_IsValid;

	private static IntPtr GetSoundAssetCompressionType_FunctionAddress;

	private static int GetSoundAssetCompressionType_ParamsSize;

	private static bool GetSoundAssetCompressionType_ReturnValue_IsValid;

	private static FFieldAddress GetSoundAssetCompressionType_ReturnValue_PropertyAddress;

	private static int GetSoundAssetCompressionType_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundWave:ModulationSettings")]
	public FSoundModulationDefaultRoutingSettings ModulationSettings
	{
		get
		{
			CheckDestroyed();
			if (!ModulationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:ModulationSettings");
				return default(FSoundModulationDefaultRoutingSettings);
			}
			return FSoundModulationDefaultRoutingSettings.FromNative(IntPtr.Add(base.Address, ModulationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModulationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:ModulationSettings");
			}
			else
			{
				FSoundModulationDefaultRoutingSettings.ToNative(IntPtr.Add(base.Address, ModulationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756567672160277uL)]
	[UMetaPath("/Script/Engine.SoundWave:bMature")]
	public bool Mature
	{
		get
		{
			CheckDestroyed();
			if (!Mature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:bMature");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Mature_Offset), 0, Mature_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:bMature");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Mature_Offset), 0, Mature_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundWave:bManualWordWrap")]
	public bool ManualWordWrap
	{
		get
		{
			CheckDestroyed();
			if (!ManualWordWrap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:bManualWordWrap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ManualWordWrap_Offset), 0, ManualWordWrap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ManualWordWrap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:bManualWordWrap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ManualWordWrap_Offset), 0, ManualWordWrap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundWave:bSingleLine")]
	public bool SingleLine
	{
		get
		{
			CheckDestroyed();
			if (!SingleLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:bSingleLine");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SingleLine_Offset), 0, SingleLine_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SingleLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:bSingleLine");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SingleLine_Offset), 0, SingleLine_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundWave:SubtitlePriority")]
	public float SubtitlePriority
	{
		get
		{
			CheckDestroyed();
			if (!SubtitlePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:SubtitlePriority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SubtitlePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubtitlePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:SubtitlePriority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SubtitlePriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.SoundWave:Subtitles")]
	public TArrayReadOnly<FSubtitleCue> Subtitles
	{
		get
		{
			CheckDestroyed();
			if (!Subtitles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundWave:Subtitles");
				return null;
			}
			if (Subtitles_MarshalerCached == null)
			{
				Subtitles_MarshalerCached = new TArrayReadOnlyMarshaler<FSubtitleCue>(1, Subtitles_PropertyAddress, CachedMarshalingDelegates<FSubtitleCue, FSubtitleCue>.FromNative, CachedMarshalingDelegates<FSubtitleCue, FSubtitleCue>.ToNative);
			}
			return Subtitles_MarshalerCached.FromNative(IntPtr.Add(base.Address, Subtitles_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundWave:SetSoundAssetCompressionType")]
	public unsafe void SetSoundAssetCompressionType(ESoundAssetCompressionType InSoundAssetCompressionType)
	{
		CheckDestroyed();
		if (!SetSoundAssetCompressionType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundWave:SetSoundAssetCompressionType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoundAssetCompressionType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoundAssetCompressionType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESoundAssetCompressionType>.ToNative(IntPtr.Add(intPtr, SetSoundAssetCompressionType_InSoundAssetCompressionType_Offset), 0, SetSoundAssetCompressionType_InSoundAssetCompressionType_PropertyAddress.Address, InSoundAssetCompressionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSoundAssetCompressionType_FunctionAddress, intPtr, SetSoundAssetCompressionType_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SoundWave:GetSoundAssetCompressionType")]
	public unsafe ESoundAssetCompressionType GetSoundAssetCompressionType()
	{
		CheckDestroyed();
		if (!GetSoundAssetCompressionType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundWave:GetSoundAssetCompressionType");
			return ESoundAssetCompressionType.BinkAudio;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoundAssetCompressionType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoundAssetCompressionType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSoundAssetCompressionType_FunctionAddress, intPtr, GetSoundAssetCompressionType_ParamsSize);
		return EnumMarshaler<ESoundAssetCompressionType>.FromNative(IntPtr.Add(intPtr, GetSoundAssetCompressionType_ReturnValue_Offset), 0, GetSoundAssetCompressionType_ReturnValue_PropertyAddress.Address);
	}

	static USoundWave()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundWave)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundWave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SoundWave");
		ModulationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationSettings");
		ModulationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Mature_PropertyAddress, intPtr, "bMature");
		Mature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMature");
		Mature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMature", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ManualWordWrap_PropertyAddress, intPtr, "bManualWordWrap");
		ManualWordWrap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bManualWordWrap");
		ManualWordWrap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bManualWordWrap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SingleLine_PropertyAddress, intPtr, "bSingleLine");
		SingleLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSingleLine");
		SingleLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSingleLine", Classes.FBoolProperty);
		SubtitlePriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubtitlePriority");
		SubtitlePriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubtitlePriority", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Subtitles_PropertyAddress, intPtr, "Subtitles");
		Subtitles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Subtitles");
		Subtitles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Subtitles", Classes.FArrayProperty);
		SetSoundAssetCompressionType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSoundAssetCompressionType");
		SetSoundAssetCompressionType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoundAssetCompressionType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoundAssetCompressionType_InSoundAssetCompressionType_PropertyAddress, SetSoundAssetCompressionType_FunctionAddress, "InSoundAssetCompressionType");
		SetSoundAssetCompressionType_InSoundAssetCompressionType_Offset = NativeReflectionCached.GetPropertyOffset(SetSoundAssetCompressionType_FunctionAddress, "InSoundAssetCompressionType");
		SetSoundAssetCompressionType_InSoundAssetCompressionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoundAssetCompressionType_FunctionAddress, "InSoundAssetCompressionType", Classes.FEnumProperty);
		SetSoundAssetCompressionType_IsValid = SetSoundAssetCompressionType_FunctionAddress != IntPtr.Zero && SetSoundAssetCompressionType_InSoundAssetCompressionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundWave:SetSoundAssetCompressionType", SetSoundAssetCompressionType_IsValid);
		GetSoundAssetCompressionType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoundAssetCompressionType");
		GetSoundAssetCompressionType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoundAssetCompressionType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSoundAssetCompressionType_ReturnValue_PropertyAddress, GetSoundAssetCompressionType_FunctionAddress, "ReturnValue");
		GetSoundAssetCompressionType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSoundAssetCompressionType_FunctionAddress, "ReturnValue");
		GetSoundAssetCompressionType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoundAssetCompressionType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetSoundAssetCompressionType_IsValid = GetSoundAssetCompressionType_FunctionAddress != IntPtr.Zero && GetSoundAssetCompressionType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundWave:GetSoundAssetCompressionType", GetSoundAssetCompressionType_IsValid);
	}
}
