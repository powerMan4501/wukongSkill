using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.TemplateSequence;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor", "TemplateSequence", UnrealModuleType.EnginePlugin)]
public class ATemplateSequenceActor : AActor, IMovieSceneSequenceActor, IInterface, IMovieScenePlaybackClient
{
	private static bool PlaybackSettings_IsValid;

	private static int PlaybackSettings_Offset;

	private static bool SequencePlayer_IsValid;

	private static int SequencePlayer_Offset;

	private static bool TemplateSequence_IsValid;

	private static int TemplateSequence_Offset;

	private static bool BindingOverride_IsValid;

	private static int BindingOverride_Offset;

	private static bool SetSequence_IsValid;

	private static IntPtr SetSequence_FunctionAddress;

	private static int SetSequence_ParamsSize;

	private static bool SetSequence_InSequence_IsValid;

	private static FFieldAddress SetSequence_InSequence_PropertyAddress;

	private static int SetSequence_InSequence_Offset;

	private static bool SetBinding_IsValid;

	private static IntPtr SetBinding_FunctionAddress;

	private static int SetBinding_ParamsSize;

	private static bool SetBinding_Actor_IsValid;

	private static FFieldAddress SetBinding_Actor_PropertyAddress;

	private static int SetBinding_Actor_Offset;

	private static bool SetBinding_bOverridesDefault_IsValid;

	private static FFieldAddress SetBinding_bOverridesDefault_PropertyAddress;

	private static int SetBinding_bOverridesDefault_Offset;

	private static bool LoadSequence_IsValid;

	private static IntPtr LoadSequence_FunctionAddress;

	private static int LoadSequence_ParamsSize;

	private static bool LoadSequence_ReturnValue_IsValid;

	private static FFieldAddress LoadSequence_ReturnValue_PropertyAddress;

	private static int LoadSequence_ReturnValue_Offset;

	private static bool GetSequencePlayer_IsValid;

	private static IntPtr GetSequencePlayer_FunctionAddress;

	private static int GetSequencePlayer_ParamsSize;

	private static bool GetSequencePlayer_ReturnValue_IsValid;

	private static FFieldAddress GetSequencePlayer_ReturnValue_PropertyAddress;

	private static int GetSequencePlayer_ReturnValue_Offset;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:PlaybackSettings")]
	public FMovieSceneSequencePlaybackSettings PlaybackSettings
	{
		get
		{
			CheckDestroyed();
			if (!PlaybackSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:PlaybackSettings");
				return default(FMovieSceneSequencePlaybackSettings);
			}
			return FMovieSceneSequencePlaybackSettings.FromNative(IntPtr.Add(base.Address, PlaybackSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaybackSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:PlaybackSettings");
			}
			else
			{
				FMovieSceneSequencePlaybackSettings.ToNative(IntPtr.Add(base.Address, PlaybackSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095071292uL)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:SequencePlayer")]
	public UTemplateSequencePlayer SequencePlayer
	{
		get
		{
			CheckDestroyed();
			if (!SequencePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:SequencePlayer");
				return null;
			}
			return UObjectMarshaler<UTemplateSequencePlayer>.FromNative(IntPtr.Add(base.Address, SequencePlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequencePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:SequencePlayer");
			}
			else
			{
				UObjectMarshaler<UTemplateSequencePlayer>.ToNative(IntPtr.Add(base.Address, SequencePlayer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:TemplateSequence")]
	public FSoftObjectPath TemplateSequence
	{
		get
		{
			CheckDestroyed();
			if (!TemplateSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:TemplateSequence");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, TemplateSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TemplateSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:TemplateSequence");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, TemplateSequence_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:BindingOverride")]
	public FTemplateSequenceBindingOverrideData BindingOverride
	{
		get
		{
			CheckDestroyed();
			if (!BindingOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:BindingOverride");
				return default(FTemplateSequenceBindingOverrideData);
			}
			return FTemplateSequenceBindingOverrideData.FromNative(IntPtr.Add(base.Address, BindingOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindingOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TemplateSequence.TemplateSequenceActor:BindingOverride");
			}
			else
			{
				FTemplateSequenceBindingOverrideData.ToNative(IntPtr.Add(base.Address, BindingOverride_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:SetSequence")]
	public unsafe void SetSequence(UTemplateSequence InSequence)
	{
		CheckDestroyed();
		if (!SetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.TemplateSequenceActor:SetSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTemplateSequence>.ToNative(IntPtr.Add(intPtr, SetSequence_InSequence_Offset), 0, SetSequence_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSequence_FunctionAddress, intPtr, SetSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:SetBinding")]
	public unsafe void SetBinding(AActor Actor, bool bOverridesDefault = true)
	{
		CheckDestroyed();
		if (!SetBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.TemplateSequenceActor:SetBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetBinding_Actor_Offset), 0, SetBinding_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBinding_bOverridesDefault_Offset), 0, SetBinding_bOverridesDefault_PropertyAddress.Address, bOverridesDefault);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBinding_FunctionAddress, intPtr, SetBinding_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:LoadSequence")]
	public unsafe UTemplateSequence LoadSequence()
	{
		CheckDestroyed();
		if (!LoadSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.TemplateSequenceActor:LoadSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadSequence_FunctionAddress, intPtr, LoadSequence_ParamsSize);
		return UObjectMarshaler<UTemplateSequence>.FromNative(IntPtr.Add(intPtr, LoadSequence_ReturnValue_Offset), 0, LoadSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:GetSequencePlayer")]
	public unsafe UTemplateSequencePlayer GetSequencePlayer()
	{
		CheckDestroyed();
		if (!GetSequencePlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.TemplateSequenceActor:GetSequencePlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequencePlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequencePlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequencePlayer_FunctionAddress, intPtr, GetSequencePlayer_ParamsSize);
		return UObjectMarshaler<UTemplateSequencePlayer>.FromNative(IntPtr.Add(intPtr, GetSequencePlayer_ReturnValue_Offset), 0, GetSequencePlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/TemplateSequence.TemplateSequenceActor:GetSequence")]
	public unsafe UTemplateSequence GetSequence()
	{
		CheckDestroyed();
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TemplateSequence.TemplateSequenceActor:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<UTemplateSequence>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	static ATemplateSequenceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ATemplateSequenceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ATemplateSequenceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/TemplateSequence.TemplateSequenceActor");
		PlaybackSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaybackSettings");
		PlaybackSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaybackSettings", Classes.FStructProperty);
		SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequencePlayer");
		SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequencePlayer", Classes.FObjectProperty);
		TemplateSequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TemplateSequence");
		TemplateSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TemplateSequence", Classes.FStructProperty);
		BindingOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BindingOverride");
		BindingOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BindingOverride", Classes.FStructProperty);
		SetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSequence");
		SetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_InSequence_PropertyAddress, SetSequence_FunctionAddress, "InSequence");
		SetSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "InSequence");
		SetSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "InSequence", Classes.FObjectProperty);
		SetSequence_IsValid = SetSequence_FunctionAddress != IntPtr.Zero && SetSequence_InSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.TemplateSequenceActor:SetSequence", SetSequence_IsValid);
		SetBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBinding");
		SetBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBinding_Actor_PropertyAddress, SetBinding_FunctionAddress, "Actor");
		SetBinding_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetBinding_FunctionAddress, "Actor");
		SetBinding_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBinding_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBinding_bOverridesDefault_PropertyAddress, SetBinding_FunctionAddress, "bOverridesDefault");
		SetBinding_bOverridesDefault_Offset = NativeReflectionCached.GetPropertyOffset(SetBinding_FunctionAddress, "bOverridesDefault");
		SetBinding_bOverridesDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBinding_FunctionAddress, "bOverridesDefault", Classes.FBoolProperty);
		SetBinding_IsValid = SetBinding_FunctionAddress != IntPtr.Zero && SetBinding_Actor_IsValid && SetBinding_bOverridesDefault_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.TemplateSequenceActor:SetBinding", SetBinding_IsValid);
		LoadSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoadSequence");
		LoadSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadSequence_ReturnValue_PropertyAddress, LoadSequence_FunctionAddress, "ReturnValue");
		LoadSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadSequence_FunctionAddress, "ReturnValue");
		LoadSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadSequence_IsValid = LoadSequence_FunctionAddress != IntPtr.Zero && LoadSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.TemplateSequenceActor:LoadSequence", LoadSequence_IsValid);
		GetSequencePlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequencePlayer");
		GetSequencePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequencePlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequencePlayer_ReturnValue_PropertyAddress, GetSequencePlayer_FunctionAddress, "ReturnValue");
		GetSequencePlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequencePlayer_FunctionAddress, "ReturnValue");
		GetSequencePlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequencePlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequencePlayer_IsValid = GetSequencePlayer_FunctionAddress != IntPtr.Zero && GetSequencePlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.TemplateSequenceActor:GetSequencePlayer", GetSequencePlayer_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/TemplateSequence.TemplateSequenceActor:GetSequence", GetSequence_IsValid);
	}
}
