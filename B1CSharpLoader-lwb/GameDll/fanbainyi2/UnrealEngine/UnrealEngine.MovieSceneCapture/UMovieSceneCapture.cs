using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UClass(Flags = (ClassFlags)818939044uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture", "MovieSceneCapture", UnrealModuleType.Engine)]
public class UMovieSceneCapture : UObject, IMovieSceneCaptureInterface, IInterface
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool UseSeparateProcess_IsValid;

	private static FFieldAddress UseSeparateProcess_PropertyAddress;

	private static int UseSeparateProcess_Offset;

	private static bool CloseEditorWhenCaptureStarts_IsValid;

	private static FFieldAddress CloseEditorWhenCaptureStarts_PropertyAddress;

	private static int CloseEditorWhenCaptureStarts_Offset;

	private static bool AdditionalCommandLineArguments_IsValid;

	private static int AdditionalCommandLineArguments_Offset;

	private static bool InheritedCommandLineArguments_IsValid;

	private static int InheritedCommandLineArguments_Offset;

	private static bool SetImageCaptureProtocolType_IsValid;

	private static IntPtr SetImageCaptureProtocolType_FunctionAddress;

	private static int SetImageCaptureProtocolType_ParamsSize;

	private static bool SetImageCaptureProtocolType_ProtocolType_IsValid;

	private static FFieldAddress SetImageCaptureProtocolType_ProtocolType_PropertyAddress;

	private static int SetImageCaptureProtocolType_ProtocolType_Offset;

	private static bool SetAudioCaptureProtocolType_IsValid;

	private static IntPtr SetAudioCaptureProtocolType_FunctionAddress;

	private static int SetAudioCaptureProtocolType_ParamsSize;

	private static bool SetAudioCaptureProtocolType_ProtocolType_IsValid;

	private static FFieldAddress SetAudioCaptureProtocolType_ProtocolType_PropertyAddress;

	private static int SetAudioCaptureProtocolType_ProtocolType_Offset;

	private static bool GetImageCaptureProtocol_IsValid;

	private static IntPtr GetImageCaptureProtocol_FunctionAddress;

	private static int GetImageCaptureProtocol_ParamsSize;

	private static bool GetImageCaptureProtocol_ReturnValue_IsValid;

	private static FFieldAddress GetImageCaptureProtocol_ReturnValue_PropertyAddress;

	private static int GetImageCaptureProtocol_ReturnValue_Offset;

	private static bool GetAudioCaptureProtocol_IsValid;

	private static IntPtr GetAudioCaptureProtocol_FunctionAddress;

	private static int GetAudioCaptureProtocol_ParamsSize;

	private static bool GetAudioCaptureProtocol_ReturnValue_IsValid;

	private static FFieldAddress GetAudioCaptureProtocol_ReturnValue_PropertyAddress;

	private static int GetAudioCaptureProtocol_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627386885uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:Settings")]
	public FMovieSceneCaptureSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:Settings");
				return default(FMovieSceneCaptureSettings);
			}
			return FMovieSceneCaptureSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:Settings");
			}
			else
			{
				FMovieSceneCaptureSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:bUseSeparateProcess")]
	public bool UseSeparateProcess
	{
		get
		{
			CheckDestroyed();
			if (!UseSeparateProcess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:bUseSeparateProcess");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSeparateProcess_Offset), 0, UseSeparateProcess_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSeparateProcess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:bUseSeparateProcess");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSeparateProcess_Offset), 0, UseSeparateProcess_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280802309uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:bCloseEditorWhenCaptureStarts")]
	public bool CloseEditorWhenCaptureStarts
	{
		get
		{
			CheckDestroyed();
			if (!CloseEditorWhenCaptureStarts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:bCloseEditorWhenCaptureStarts");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CloseEditorWhenCaptureStarts_Offset), 0, CloseEditorWhenCaptureStarts_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CloseEditorWhenCaptureStarts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:bCloseEditorWhenCaptureStarts");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CloseEditorWhenCaptureStarts_Offset), 0, CloseEditorWhenCaptureStarts_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487583749uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:AdditionalCommandLineArguments")]
	public string AdditionalCommandLineArguments
	{
		get
		{
			CheckDestroyed();
			if (!AdditionalCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:AdditionalCommandLineArguments");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AdditionalCommandLineArguments_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditionalCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:AdditionalCommandLineArguments");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AdditionalCommandLineArguments_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487575557uL)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:InheritedCommandLineArguments")]
	public string InheritedCommandLineArguments
	{
		get
		{
			CheckDestroyed();
			if (!InheritedCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:InheritedCommandLineArguments");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, InheritedCommandLineArguments_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InheritedCommandLineArguments_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.MovieSceneCapture:InheritedCommandLineArguments");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, InheritedCommandLineArguments_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:SetImageCaptureProtocolType")]
	public unsafe void SetImageCaptureProtocolType(TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
	{
		CheckDestroyed();
		if (!SetImageCaptureProtocolType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.MovieSceneCapture:SetImageCaptureProtocolType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetImageCaptureProtocolType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetImageCaptureProtocolType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMovieSceneCaptureProtocolBase>.ToNative(IntPtr.Add(intPtr, SetImageCaptureProtocolType_ProtocolType_Offset), 0, SetImageCaptureProtocolType_ProtocolType_PropertyAddress.Address, ProtocolType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetImageCaptureProtocolType_FunctionAddress, intPtr, SetImageCaptureProtocolType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:SetAudioCaptureProtocolType")]
	public unsafe void SetAudioCaptureProtocolType(TSubclassOf<UMovieSceneCaptureProtocolBase> ProtocolType)
	{
		CheckDestroyed();
		if (!SetAudioCaptureProtocolType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.MovieSceneCapture:SetAudioCaptureProtocolType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioCaptureProtocolType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioCaptureProtocolType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMovieSceneCaptureProtocolBase>.ToNative(IntPtr.Add(intPtr, SetAudioCaptureProtocolType_ProtocolType_Offset), 0, SetAudioCaptureProtocolType_ProtocolType_PropertyAddress.Address, ProtocolType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioCaptureProtocolType_FunctionAddress, intPtr, SetAudioCaptureProtocolType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:GetImageCaptureProtocol")]
	public unsafe UMovieSceneCaptureProtocolBase GetImageCaptureProtocol()
	{
		CheckDestroyed();
		if (!GetImageCaptureProtocol_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.MovieSceneCapture:GetImageCaptureProtocol");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetImageCaptureProtocol_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetImageCaptureProtocol_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetImageCaptureProtocol_FunctionAddress, intPtr, GetImageCaptureProtocol_ParamsSize);
		return UObjectMarshaler<UMovieSceneCaptureProtocolBase>.FromNative(IntPtr.Add(intPtr, GetImageCaptureProtocol_ReturnValue_Offset), 0, GetImageCaptureProtocol_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneCapture.MovieSceneCapture:GetAudioCaptureProtocol")]
	public unsafe UMovieSceneCaptureProtocolBase GetAudioCaptureProtocol()
	{
		CheckDestroyed();
		if (!GetAudioCaptureProtocol_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.MovieSceneCapture:GetAudioCaptureProtocol");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioCaptureProtocol_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioCaptureProtocol_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioCaptureProtocol_FunctionAddress, intPtr, GetAudioCaptureProtocol_ParamsSize);
		return UObjectMarshaler<UMovieSceneCaptureProtocolBase>.FromNative(IntPtr.Add(intPtr, GetAudioCaptureProtocol_ReturnValue_Offset), 0, GetAudioCaptureProtocol_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneCapture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCapture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCapture));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieSceneCapture.MovieSceneCapture");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSeparateProcess_PropertyAddress, intPtr, "bUseSeparateProcess");
		UseSeparateProcess_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSeparateProcess");
		UseSeparateProcess_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSeparateProcess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseEditorWhenCaptureStarts_PropertyAddress, intPtr, "bCloseEditorWhenCaptureStarts");
		CloseEditorWhenCaptureStarts_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCloseEditorWhenCaptureStarts");
		CloseEditorWhenCaptureStarts_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCloseEditorWhenCaptureStarts", Classes.FBoolProperty);
		AdditionalCommandLineArguments_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdditionalCommandLineArguments");
		AdditionalCommandLineArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdditionalCommandLineArguments", Classes.FStrProperty);
		InheritedCommandLineArguments_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InheritedCommandLineArguments");
		InheritedCommandLineArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InheritedCommandLineArguments", Classes.FStrProperty);
		SetImageCaptureProtocolType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetImageCaptureProtocolType");
		SetImageCaptureProtocolType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetImageCaptureProtocolType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetImageCaptureProtocolType_ProtocolType_PropertyAddress, SetImageCaptureProtocolType_FunctionAddress, "ProtocolType");
		SetImageCaptureProtocolType_ProtocolType_Offset = NativeReflectionCached.GetPropertyOffset(SetImageCaptureProtocolType_FunctionAddress, "ProtocolType");
		SetImageCaptureProtocolType_ProtocolType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetImageCaptureProtocolType_FunctionAddress, "ProtocolType", Classes.FClassProperty);
		SetImageCaptureProtocolType_IsValid = SetImageCaptureProtocolType_FunctionAddress != IntPtr.Zero && SetImageCaptureProtocolType_ProtocolType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.MovieSceneCapture:SetImageCaptureProtocolType", SetImageCaptureProtocolType_IsValid);
		SetAudioCaptureProtocolType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioCaptureProtocolType");
		SetAudioCaptureProtocolType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioCaptureProtocolType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioCaptureProtocolType_ProtocolType_PropertyAddress, SetAudioCaptureProtocolType_FunctionAddress, "ProtocolType");
		SetAudioCaptureProtocolType_ProtocolType_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioCaptureProtocolType_FunctionAddress, "ProtocolType");
		SetAudioCaptureProtocolType_ProtocolType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioCaptureProtocolType_FunctionAddress, "ProtocolType", Classes.FClassProperty);
		SetAudioCaptureProtocolType_IsValid = SetAudioCaptureProtocolType_FunctionAddress != IntPtr.Zero && SetAudioCaptureProtocolType_ProtocolType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.MovieSceneCapture:SetAudioCaptureProtocolType", SetAudioCaptureProtocolType_IsValid);
		GetImageCaptureProtocol_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetImageCaptureProtocol");
		GetImageCaptureProtocol_ParamsSize = NativeReflection.GetFunctionParamsSize(GetImageCaptureProtocol_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetImageCaptureProtocol_ReturnValue_PropertyAddress, GetImageCaptureProtocol_FunctionAddress, "ReturnValue");
		GetImageCaptureProtocol_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetImageCaptureProtocol_FunctionAddress, "ReturnValue");
		GetImageCaptureProtocol_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetImageCaptureProtocol_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetImageCaptureProtocol_IsValid = GetImageCaptureProtocol_FunctionAddress != IntPtr.Zero && GetImageCaptureProtocol_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.MovieSceneCapture:GetImageCaptureProtocol", GetImageCaptureProtocol_IsValid);
		GetAudioCaptureProtocol_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAudioCaptureProtocol");
		GetAudioCaptureProtocol_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioCaptureProtocol_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioCaptureProtocol_ReturnValue_PropertyAddress, GetAudioCaptureProtocol_FunctionAddress, "ReturnValue");
		GetAudioCaptureProtocol_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioCaptureProtocol_FunctionAddress, "ReturnValue");
		GetAudioCaptureProtocol_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioCaptureProtocol_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAudioCaptureProtocol_IsValid = GetAudioCaptureProtocol_FunctionAddress != IntPtr.Zero && GetAudioCaptureProtocol_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.MovieSceneCapture:GetAudioCaptureProtocol", GetAudioCaptureProtocol_IsValid);
	}
}
