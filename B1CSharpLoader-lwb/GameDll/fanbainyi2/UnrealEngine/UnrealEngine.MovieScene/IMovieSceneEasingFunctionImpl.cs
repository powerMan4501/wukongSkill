using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

public sealed class IMovieSceneEasingFunctionImpl : IInterfaceImpl, IMovieSceneEasingFunction, IInterface
{
	private static bool OnEvaluate_IsValid;

	private IntPtr OnEvaluate_InstanceFunctionAddress;

	private static IntPtr OnEvaluate_FunctionAddress;

	private static int OnEvaluate_ParamsSize;

	private static bool OnEvaluate_Interp_IsValid;

	private static FFieldAddress OnEvaluate_Interp_PropertyAddress;

	private static int OnEvaluate_Interp_Offset;

	private static bool OnEvaluate_ReturnValue_IsValid;

	private static FFieldAddress OnEvaluate_ReturnValue_PropertyAddress;

	private static int OnEvaluate_ReturnValue_Offset;

	[UFunction(Flags = 1544030208u)]
	[UMetaPath("/Script/MovieScene.MovieSceneEasingFunction:OnEvaluate")]
	public unsafe float OnEvaluate(float Interp)
	{
		CheckDestroyed();
		if (!OnEvaluate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneEasingFunction:OnEvaluate");
			return 0f;
		}
		if (OnEvaluate_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEvaluate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEvaluate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEvaluate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEvaluate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEvaluate_Interp_Offset), 0, OnEvaluate_Interp_PropertyAddress.Address, Interp);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEvaluate_InstanceFunctionAddress, intPtr, OnEvaluate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, OnEvaluate_ReturnValue_Offset), 0, OnEvaluate_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		OnEvaluate_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IMovieSceneEasingFunctionImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneEasingFunctionImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneEasingFunctionImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieScene.MovieSceneEasingFunction");
		OnEvaluate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEvaluate");
		OnEvaluate_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEvaluate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEvaluate_Interp_PropertyAddress, OnEvaluate_FunctionAddress, "Interp");
		OnEvaluate_Interp_Offset = NativeReflectionCached.GetPropertyOffset(OnEvaluate_FunctionAddress, "Interp");
		OnEvaluate_Interp_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEvaluate_FunctionAddress, "Interp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnEvaluate_ReturnValue_PropertyAddress, OnEvaluate_FunctionAddress, "ReturnValue");
		OnEvaluate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnEvaluate_FunctionAddress, "ReturnValue");
		OnEvaluate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEvaluate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		OnEvaluate_IsValid = OnEvaluate_FunctionAddress != IntPtr.Zero && OnEvaluate_Interp_IsValid && OnEvaluate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneEasingFunction:OnEvaluate", OnEvaluate_IsValid);
	}
}
