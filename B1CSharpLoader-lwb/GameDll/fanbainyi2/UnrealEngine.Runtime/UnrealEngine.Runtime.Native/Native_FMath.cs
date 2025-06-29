using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FMath
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_Rand();

	[MonoNativeFunctionWrapper]
	public delegate void Del_RandInit(int seed);

	[MonoNativeFunctionWrapper]
	public delegate float Del_FRand();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SRandInit(int seed);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetRandSeed();

	[MonoNativeFunctionWrapper]
	public delegate float Del_SRand();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_MemoryTest(IntPtr baseAddress, uint numBytes);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Eval(ref FScriptArray str, out float outValue);

	public static Del_Rand Rand;

	public static Del_RandInit RandInit;

	public static Del_FRand FRand;

	public static Del_SRandInit SRandInit;

	public static Del_GetRandSeed GetRandSeed;

	public static Del_SRand SRand;

	public static Del_MemoryTest MemoryTest;

	public static Del_Eval Eval;
}
