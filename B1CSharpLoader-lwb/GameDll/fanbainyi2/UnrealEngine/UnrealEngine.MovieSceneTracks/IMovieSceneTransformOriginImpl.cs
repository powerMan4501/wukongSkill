using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

public sealed class IMovieSceneTransformOriginImpl : IInterfaceImpl, IMovieSceneTransformOrigin, IInterface
{
	private static bool BP_GetTransformOrigin_IsValid;

	private IntPtr BP_GetTransformOrigin_InstanceFunctionAddress;

	private static IntPtr BP_GetTransformOrigin_FunctionAddress;

	private static int BP_GetTransformOrigin_ParamsSize;

	private static bool BP_GetTransformOrigin_ReturnValue_IsValid;

	private static FFieldAddress BP_GetTransformOrigin_ReturnValue_PropertyAddress;

	private static int BP_GetTransformOrigin_ReturnValue_Offset;

	[UFunction(Flags = 1552418816u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin")]
	public unsafe FTransform BP_GetTransformOrigin()
	{
		CheckDestroyed();
		if (!BP_GetTransformOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin");
			return default(FTransform);
		}
		if (BP_GetTransformOrigin_InstanceFunctionAddress == IntPtr.Zero)
		{
			BP_GetTransformOrigin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BP_GetTransformOrigin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetTransformOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetTransformOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetTransformOrigin_InstanceFunctionAddress, intPtr, BP_GetTransformOrigin_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, BP_GetTransformOrigin_ReturnValue_Offset), 0, BP_GetTransformOrigin_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		BP_GetTransformOrigin_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IMovieSceneTransformOriginImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IMovieSceneTransformOriginImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IMovieSceneTransformOriginImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneTransformOrigin");
		BP_GetTransformOrigin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BP_GetTransformOrigin");
		BP_GetTransformOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_GetTransformOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_GetTransformOrigin_ReturnValue_PropertyAddress, BP_GetTransformOrigin_FunctionAddress, "ReturnValue");
		BP_GetTransformOrigin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetTransformOrigin_FunctionAddress, "ReturnValue");
		BP_GetTransformOrigin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetTransformOrigin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BP_GetTransformOrigin_IsValid = BP_GetTransformOrigin_FunctionAddress != IntPtr.Zero && BP_GetTransformOrigin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin", BP_GetTransformOrigin_IsValid);
	}
}
