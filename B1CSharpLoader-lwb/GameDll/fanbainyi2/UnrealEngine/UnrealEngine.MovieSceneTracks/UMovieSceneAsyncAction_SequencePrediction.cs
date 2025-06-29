using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneAsyncAction_SequencePrediction : UBlueprintAsyncActionBase
{
	private static IntPtr classAddress;

	private static bool Result_IsValid;

	private static int Result_Offset;

	private FMovieSceneActorPredictionResult Result_DelegateCached;

	private static bool Failure_IsValid;

	private static int Failure_Offset;

	private FMovieSceneActorPredictionFailure Failure_DelegateCached;

	private static bool PredictWorldTransformAtTime_IsValid;

	private static IntPtr PredictWorldTransformAtTime_FunctionAddress;

	private static int PredictWorldTransformAtTime_ParamsSize;

	private static bool PredictWorldTransformAtTime_Player_IsValid;

	private static FFieldAddress PredictWorldTransformAtTime_Player_PropertyAddress;

	private static int PredictWorldTransformAtTime_Player_Offset;

	private static bool PredictWorldTransformAtTime_TargetComponent_IsValid;

	private static FFieldAddress PredictWorldTransformAtTime_TargetComponent_PropertyAddress;

	private static int PredictWorldTransformAtTime_TargetComponent_Offset;

	private static bool PredictWorldTransformAtTime_TimeInSeconds_IsValid;

	private static FFieldAddress PredictWorldTransformAtTime_TimeInSeconds_PropertyAddress;

	private static int PredictWorldTransformAtTime_TimeInSeconds_Offset;

	private static bool PredictWorldTransformAtTime_ReturnValue_IsValid;

	private static FFieldAddress PredictWorldTransformAtTime_ReturnValue_PropertyAddress;

	private static int PredictWorldTransformAtTime_ReturnValue_Offset;

	private static bool PredictWorldTransformAtFrame_IsValid;

	private static IntPtr PredictWorldTransformAtFrame_FunctionAddress;

	private static int PredictWorldTransformAtFrame_ParamsSize;

	private static bool PredictWorldTransformAtFrame_Player_IsValid;

	private static FFieldAddress PredictWorldTransformAtFrame_Player_PropertyAddress;

	private static int PredictWorldTransformAtFrame_Player_Offset;

	private static bool PredictWorldTransformAtFrame_TargetComponent_IsValid;

	private static FFieldAddress PredictWorldTransformAtFrame_TargetComponent_PropertyAddress;

	private static int PredictWorldTransformAtFrame_TargetComponent_Offset;

	private static bool PredictWorldTransformAtFrame_FrameTime_IsValid;

	private static FFieldAddress PredictWorldTransformAtFrame_FrameTime_PropertyAddress;

	private static int PredictWorldTransformAtFrame_FrameTime_Offset;

	private static bool PredictWorldTransformAtFrame_ReturnValue_IsValid;

	private static FFieldAddress PredictWorldTransformAtFrame_ReturnValue_PropertyAddress;

	private static int PredictWorldTransformAtFrame_ReturnValue_Offset;

	private static bool PredictLocalTransformAtTime_IsValid;

	private static IntPtr PredictLocalTransformAtTime_FunctionAddress;

	private static int PredictLocalTransformAtTime_ParamsSize;

	private static bool PredictLocalTransformAtTime_Player_IsValid;

	private static FFieldAddress PredictLocalTransformAtTime_Player_PropertyAddress;

	private static int PredictLocalTransformAtTime_Player_Offset;

	private static bool PredictLocalTransformAtTime_TargetComponent_IsValid;

	private static FFieldAddress PredictLocalTransformAtTime_TargetComponent_PropertyAddress;

	private static int PredictLocalTransformAtTime_TargetComponent_Offset;

	private static bool PredictLocalTransformAtTime_TimeInSeconds_IsValid;

	private static FFieldAddress PredictLocalTransformAtTime_TimeInSeconds_PropertyAddress;

	private static int PredictLocalTransformAtTime_TimeInSeconds_Offset;

	private static bool PredictLocalTransformAtTime_ReturnValue_IsValid;

	private static FFieldAddress PredictLocalTransformAtTime_ReturnValue_PropertyAddress;

	private static int PredictLocalTransformAtTime_ReturnValue_Offset;

	private static bool PredictLocalTransformAtFrame_IsValid;

	private static IntPtr PredictLocalTransformAtFrame_FunctionAddress;

	private static int PredictLocalTransformAtFrame_ParamsSize;

	private static bool PredictLocalTransformAtFrame_Player_IsValid;

	private static FFieldAddress PredictLocalTransformAtFrame_Player_PropertyAddress;

	private static int PredictLocalTransformAtFrame_Player_Offset;

	private static bool PredictLocalTransformAtFrame_TargetComponent_IsValid;

	private static FFieldAddress PredictLocalTransformAtFrame_TargetComponent_PropertyAddress;

	private static int PredictLocalTransformAtFrame_TargetComponent_Offset;

	private static bool PredictLocalTransformAtFrame_FrameTime_IsValid;

	private static FFieldAddress PredictLocalTransformAtFrame_FrameTime_PropertyAddress;

	private static int PredictLocalTransformAtFrame_FrameTime_Offset;

	private static bool PredictLocalTransformAtFrame_ReturnValue_IsValid;

	private static FFieldAddress PredictLocalTransformAtFrame_ReturnValue_PropertyAddress;

	private static int PredictLocalTransformAtFrame_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:Result")]
	public FMovieSceneActorPredictionResult Result
	{
		get
		{
			CheckDestroyed();
			if (!Result_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:Result");
				return new FMovieSceneActorPredictionResult();
			}
			if (Result_DelegateCached == null)
			{
				Result_DelegateCached = new FMovieSceneActorPredictionResult();
				Result_DelegateCached.SetAddress(IntPtr.Add(base.Address, Result_Offset));
			}
			return Result_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:Failure")]
	public FMovieSceneActorPredictionFailure Failure
	{
		get
		{
			CheckDestroyed();
			if (!Failure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:Failure");
				return new FMovieSceneActorPredictionFailure();
			}
			if (Failure_DelegateCached == null)
			{
				Failure_DelegateCached = new FMovieSceneActorPredictionFailure();
				Failure_DelegateCached.SetAddress(IntPtr.Add(base.Address, Failure_Offset));
			}
			return Failure_DelegateCached;
		}
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictWorldTransformAtTime")]
	public unsafe static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtTime(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, float TimeInSeconds)
	{
		if (!PredictWorldTransformAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictWorldTransformAtTime");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PredictWorldTransformAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PredictWorldTransformAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequencePlayer>.ToNative(IntPtr.Add(intPtr, PredictWorldTransformAtTime_Player_Offset), 0, PredictWorldTransformAtTime_Player_PropertyAddress.Address, Player);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, PredictWorldTransformAtTime_TargetComponent_Offset), 0, PredictWorldTransformAtTime_TargetComponent_PropertyAddress.Address, TargetComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PredictWorldTransformAtTime_TimeInSeconds_Offset), 0, PredictWorldTransformAtTime_TimeInSeconds_PropertyAddress.Address, TimeInSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PredictWorldTransformAtTime_FunctionAddress, intPtr, PredictWorldTransformAtTime_ParamsSize);
		return UObjectMarshaler<UMovieSceneAsyncAction_SequencePrediction>.FromNative(IntPtr.Add(intPtr, PredictWorldTransformAtTime_ReturnValue_Offset), 0, PredictWorldTransformAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictWorldTransformAtFrame")]
	public unsafe static UMovieSceneAsyncAction_SequencePrediction PredictWorldTransformAtFrame(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, FFrameTime FrameTime)
	{
		if (!PredictWorldTransformAtFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictWorldTransformAtFrame");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PredictWorldTransformAtFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PredictWorldTransformAtFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequencePlayer>.ToNative(IntPtr.Add(intPtr, PredictWorldTransformAtFrame_Player_Offset), 0, PredictWorldTransformAtFrame_Player_PropertyAddress.Address, Player);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, PredictWorldTransformAtFrame_TargetComponent_Offset), 0, PredictWorldTransformAtFrame_TargetComponent_PropertyAddress.Address, TargetComponent);
		NativeReflection.InitializeValue_InContainer(PredictWorldTransformAtFrame_FrameTime_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, PredictWorldTransformAtFrame_FrameTime_Offset), 0, PredictWorldTransformAtFrame_FrameTime_PropertyAddress.Address, FrameTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PredictWorldTransformAtFrame_FunctionAddress, intPtr, PredictWorldTransformAtFrame_ParamsSize);
		return UObjectMarshaler<UMovieSceneAsyncAction_SequencePrediction>.FromNative(IntPtr.Add(intPtr, PredictWorldTransformAtFrame_ReturnValue_Offset), 0, PredictWorldTransformAtFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictLocalTransformAtTime")]
	public unsafe static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtTime(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, float TimeInSeconds)
	{
		if (!PredictLocalTransformAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictLocalTransformAtTime");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PredictLocalTransformAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PredictLocalTransformAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequencePlayer>.ToNative(IntPtr.Add(intPtr, PredictLocalTransformAtTime_Player_Offset), 0, PredictLocalTransformAtTime_Player_PropertyAddress.Address, Player);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, PredictLocalTransformAtTime_TargetComponent_Offset), 0, PredictLocalTransformAtTime_TargetComponent_PropertyAddress.Address, TargetComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PredictLocalTransformAtTime_TimeInSeconds_Offset), 0, PredictLocalTransformAtTime_TimeInSeconds_PropertyAddress.Address, TimeInSeconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PredictLocalTransformAtTime_FunctionAddress, intPtr, PredictLocalTransformAtTime_ParamsSize);
		return UObjectMarshaler<UMovieSceneAsyncAction_SequencePrediction>.FromNative(IntPtr.Add(intPtr, PredictLocalTransformAtTime_ReturnValue_Offset), 0, PredictLocalTransformAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictLocalTransformAtFrame")]
	public unsafe static UMovieSceneAsyncAction_SequencePrediction PredictLocalTransformAtFrame(UMovieSceneSequencePlayer Player, USceneComponent TargetComponent, FFrameTime FrameTime)
	{
		if (!PredictLocalTransformAtFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictLocalTransformAtFrame");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PredictLocalTransformAtFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PredictLocalTransformAtFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequencePlayer>.ToNative(IntPtr.Add(intPtr, PredictLocalTransformAtFrame_Player_Offset), 0, PredictLocalTransformAtFrame_Player_PropertyAddress.Address, Player);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, PredictLocalTransformAtFrame_TargetComponent_Offset), 0, PredictLocalTransformAtFrame_TargetComponent_PropertyAddress.Address, TargetComponent);
		NativeReflection.InitializeValue_InContainer(PredictLocalTransformAtFrame_FrameTime_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, PredictLocalTransformAtFrame_FrameTime_Offset), 0, PredictLocalTransformAtFrame_FrameTime_PropertyAddress.Address, FrameTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PredictLocalTransformAtFrame_FunctionAddress, intPtr, PredictLocalTransformAtFrame_ParamsSize);
		return UObjectMarshaler<UMovieSceneAsyncAction_SequencePrediction>.FromNative(IntPtr.Add(intPtr, PredictLocalTransformAtFrame_ReturnValue_Offset), 0, PredictLocalTransformAtFrame_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneAsyncAction_SequencePrediction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneAsyncAction_SequencePrediction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneAsyncAction_SequencePrediction));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction");
		Result_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Result", Classes.FMulticastDelegateProperty);
		Failure_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Failure");
		Failure_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Failure", Classes.FMulticastDelegateProperty);
		PredictWorldTransformAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PredictWorldTransformAtTime");
		PredictWorldTransformAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(PredictWorldTransformAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtTime_Player_PropertyAddress, PredictWorldTransformAtTime_FunctionAddress, "Player");
		PredictWorldTransformAtTime_Player_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtTime_FunctionAddress, "Player");
		PredictWorldTransformAtTime_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtTime_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtTime_TargetComponent_PropertyAddress, PredictWorldTransformAtTime_FunctionAddress, "TargetComponent");
		PredictWorldTransformAtTime_TargetComponent_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtTime_FunctionAddress, "TargetComponent");
		PredictWorldTransformAtTime_TargetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtTime_FunctionAddress, "TargetComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtTime_TimeInSeconds_PropertyAddress, PredictWorldTransformAtTime_FunctionAddress, "TimeInSeconds");
		PredictWorldTransformAtTime_TimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtTime_FunctionAddress, "TimeInSeconds");
		PredictWorldTransformAtTime_TimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtTime_FunctionAddress, "TimeInSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtTime_ReturnValue_PropertyAddress, PredictWorldTransformAtTime_FunctionAddress, "ReturnValue");
		PredictWorldTransformAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtTime_FunctionAddress, "ReturnValue");
		PredictWorldTransformAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtTime_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PredictWorldTransformAtTime_IsValid = PredictWorldTransformAtTime_FunctionAddress != IntPtr.Zero && PredictWorldTransformAtTime_Player_IsValid && PredictWorldTransformAtTime_TargetComponent_IsValid && PredictWorldTransformAtTime_TimeInSeconds_IsValid && PredictWorldTransformAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictWorldTransformAtTime", PredictWorldTransformAtTime_IsValid);
		PredictWorldTransformAtFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PredictWorldTransformAtFrame");
		PredictWorldTransformAtFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(PredictWorldTransformAtFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtFrame_Player_PropertyAddress, PredictWorldTransformAtFrame_FunctionAddress, "Player");
		PredictWorldTransformAtFrame_Player_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtFrame_FunctionAddress, "Player");
		PredictWorldTransformAtFrame_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtFrame_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtFrame_TargetComponent_PropertyAddress, PredictWorldTransformAtFrame_FunctionAddress, "TargetComponent");
		PredictWorldTransformAtFrame_TargetComponent_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtFrame_FunctionAddress, "TargetComponent");
		PredictWorldTransformAtFrame_TargetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtFrame_FunctionAddress, "TargetComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtFrame_FrameTime_PropertyAddress, PredictWorldTransformAtFrame_FunctionAddress, "FrameTime");
		PredictWorldTransformAtFrame_FrameTime_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtFrame_FunctionAddress, "FrameTime");
		PredictWorldTransformAtFrame_FrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtFrame_FunctionAddress, "FrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictWorldTransformAtFrame_ReturnValue_PropertyAddress, PredictWorldTransformAtFrame_FunctionAddress, "ReturnValue");
		PredictWorldTransformAtFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PredictWorldTransformAtFrame_FunctionAddress, "ReturnValue");
		PredictWorldTransformAtFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictWorldTransformAtFrame_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PredictWorldTransformAtFrame_IsValid = PredictWorldTransformAtFrame_FunctionAddress != IntPtr.Zero && PredictWorldTransformAtFrame_Player_IsValid && PredictWorldTransformAtFrame_TargetComponent_IsValid && PredictWorldTransformAtFrame_FrameTime_IsValid && PredictWorldTransformAtFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictWorldTransformAtFrame", PredictWorldTransformAtFrame_IsValid);
		PredictLocalTransformAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PredictLocalTransformAtTime");
		PredictLocalTransformAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(PredictLocalTransformAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtTime_Player_PropertyAddress, PredictLocalTransformAtTime_FunctionAddress, "Player");
		PredictLocalTransformAtTime_Player_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtTime_FunctionAddress, "Player");
		PredictLocalTransformAtTime_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtTime_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtTime_TargetComponent_PropertyAddress, PredictLocalTransformAtTime_FunctionAddress, "TargetComponent");
		PredictLocalTransformAtTime_TargetComponent_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtTime_FunctionAddress, "TargetComponent");
		PredictLocalTransformAtTime_TargetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtTime_FunctionAddress, "TargetComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtTime_TimeInSeconds_PropertyAddress, PredictLocalTransformAtTime_FunctionAddress, "TimeInSeconds");
		PredictLocalTransformAtTime_TimeInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtTime_FunctionAddress, "TimeInSeconds");
		PredictLocalTransformAtTime_TimeInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtTime_FunctionAddress, "TimeInSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtTime_ReturnValue_PropertyAddress, PredictLocalTransformAtTime_FunctionAddress, "ReturnValue");
		PredictLocalTransformAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtTime_FunctionAddress, "ReturnValue");
		PredictLocalTransformAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtTime_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PredictLocalTransformAtTime_IsValid = PredictLocalTransformAtTime_FunctionAddress != IntPtr.Zero && PredictLocalTransformAtTime_Player_IsValid && PredictLocalTransformAtTime_TargetComponent_IsValid && PredictLocalTransformAtTime_TimeInSeconds_IsValid && PredictLocalTransformAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictLocalTransformAtTime", PredictLocalTransformAtTime_IsValid);
		PredictLocalTransformAtFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PredictLocalTransformAtFrame");
		PredictLocalTransformAtFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(PredictLocalTransformAtFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtFrame_Player_PropertyAddress, PredictLocalTransformAtFrame_FunctionAddress, "Player");
		PredictLocalTransformAtFrame_Player_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtFrame_FunctionAddress, "Player");
		PredictLocalTransformAtFrame_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtFrame_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtFrame_TargetComponent_PropertyAddress, PredictLocalTransformAtFrame_FunctionAddress, "TargetComponent");
		PredictLocalTransformAtFrame_TargetComponent_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtFrame_FunctionAddress, "TargetComponent");
		PredictLocalTransformAtFrame_TargetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtFrame_FunctionAddress, "TargetComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtFrame_FrameTime_PropertyAddress, PredictLocalTransformAtFrame_FunctionAddress, "FrameTime");
		PredictLocalTransformAtFrame_FrameTime_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtFrame_FunctionAddress, "FrameTime");
		PredictLocalTransformAtFrame_FrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtFrame_FunctionAddress, "FrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PredictLocalTransformAtFrame_ReturnValue_PropertyAddress, PredictLocalTransformAtFrame_FunctionAddress, "ReturnValue");
		PredictLocalTransformAtFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PredictLocalTransformAtFrame_FunctionAddress, "ReturnValue");
		PredictLocalTransformAtFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PredictLocalTransformAtFrame_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PredictLocalTransformAtFrame_IsValid = PredictLocalTransformAtFrame_FunctionAddress != IntPtr.Zero && PredictLocalTransformAtFrame_Player_IsValid && PredictLocalTransformAtFrame_TargetComponent_IsValid && PredictLocalTransformAtFrame_FrameTime_IsValid && PredictLocalTransformAtFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAsyncAction_SequencePrediction:PredictLocalTransformAtFrame", PredictLocalTransformAtFrame_IsValid);
	}
}
