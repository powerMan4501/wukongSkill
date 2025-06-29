using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UClass(Flags = (ClassFlags)812646564uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSubSection", "MovieScene", UnrealModuleType.Engine)]
public class UMovieSceneSubSection : UMovieSceneSection
{
	private static bool Parameters_IsValid;

	private static int Parameters_Offset;

	private static bool SetSequence_IsValid;

	private static IntPtr SetSequence_FunctionAddress;

	private static int SetSequence_ParamsSize;

	private static bool SetSequence_Sequence_IsValid;

	private static FFieldAddress SetSequence_Sequence_PropertyAddress;

	private static int SetSequence_Sequence_Offset;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346863621uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSubSection:Parameters")]
	public FMovieSceneSectionParameters Parameters
	{
		get
		{
			CheckDestroyed();
			if (!Parameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSubSection:Parameters");
				return default(FMovieSceneSectionParameters);
			}
			return FMovieSceneSectionParameters.FromNative(IntPtr.Add(base.Address, Parameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Parameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSubSection:Parameters");
			}
			else
			{
				FMovieSceneSectionParameters.ToNative(IntPtr.Add(base.Address, Parameters_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSubSection:SetSequence")]
	public unsafe void SetSequence(UMovieSceneSequence Sequence)
	{
		CheckDestroyed();
		if (!SetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSubSection:SetSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequence>.ToNative(IntPtr.Add(intPtr, SetSequence_Sequence_Offset), 0, SetSequence_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSequence_FunctionAddress, intPtr, SetSequence_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSubSection:GetSequence")]
	public unsafe UMovieSceneSequence GetSequence()
	{
		CheckDestroyed();
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSubSection:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<UMovieSceneSequence>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneSubSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSubSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSubSection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneSubSection");
		Parameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Parameters");
		Parameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Parameters", Classes.FStructProperty);
		SetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSequence");
		SetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_Sequence_PropertyAddress, SetSequence_FunctionAddress, "Sequence");
		SetSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "Sequence");
		SetSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		SetSequence_IsValid = SetSequence_FunctionAddress != IntPtr.Zero && SetSequence_Sequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSubSection:SetSequence", SetSequence_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSubSection:GetSequence", GetSequence_IsValid);
	}
}
