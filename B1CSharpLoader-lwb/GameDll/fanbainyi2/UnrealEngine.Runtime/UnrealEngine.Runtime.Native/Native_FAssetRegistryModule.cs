using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FAssetRegistryModule
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetAssets(IntPtr filter);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DeleteAssetsArray(IntPtr assetsArray);

	public static Del_GetAssets GetAssets;

	public static Del_DeleteAssetsArray DeleteAssetsArray;
}
