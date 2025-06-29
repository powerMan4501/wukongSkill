using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.ImportanceSamplingLibrary", "Engine", UnrealModuleType.Engine)]
public class UImportanceSamplingLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RandomSobolFloat_IsValid;

	private static IntPtr RandomSobolFloat_FunctionAddress;

	private static int RandomSobolFloat_ParamsSize;

	private static bool RandomSobolFloat_Index_IsValid;

	private static FFieldAddress RandomSobolFloat_Index_PropertyAddress;

	private static int RandomSobolFloat_Index_Offset;

	private static bool RandomSobolFloat_Dimension_IsValid;

	private static FFieldAddress RandomSobolFloat_Dimension_PropertyAddress;

	private static int RandomSobolFloat_Dimension_Offset;

	private static bool RandomSobolFloat_Seed_IsValid;

	private static FFieldAddress RandomSobolFloat_Seed_PropertyAddress;

	private static int RandomSobolFloat_Seed_Offset;

	private static bool RandomSobolFloat_ReturnValue_IsValid;

	private static FFieldAddress RandomSobolFloat_ReturnValue_PropertyAddress;

	private static int RandomSobolFloat_ReturnValue_Offset;

	private static bool RandomSobolCell3D_IsValid;

	private static IntPtr RandomSobolCell3D_FunctionAddress;

	private static int RandomSobolCell3D_ParamsSize;

	private static bool RandomSobolCell3D_Index_IsValid;

	private static FFieldAddress RandomSobolCell3D_Index_PropertyAddress;

	private static int RandomSobolCell3D_Index_Offset;

	private static bool RandomSobolCell3D_NumCells_IsValid;

	private static FFieldAddress RandomSobolCell3D_NumCells_PropertyAddress;

	private static int RandomSobolCell3D_NumCells_Offset;

	private static bool RandomSobolCell3D_Cell_IsValid;

	private static FFieldAddress RandomSobolCell3D_Cell_PropertyAddress;

	private static int RandomSobolCell3D_Cell_Offset;

	private static bool RandomSobolCell3D_Seed_IsValid;

	private static FFieldAddress RandomSobolCell3D_Seed_PropertyAddress;

	private static int RandomSobolCell3D_Seed_Offset;

	private static bool RandomSobolCell3D_ReturnValue_IsValid;

	private static FFieldAddress RandomSobolCell3D_ReturnValue_PropertyAddress;

	private static int RandomSobolCell3D_ReturnValue_Offset;

	private static bool RandomSobolCell2D_IsValid;

	private static IntPtr RandomSobolCell2D_FunctionAddress;

	private static int RandomSobolCell2D_ParamsSize;

	private static bool RandomSobolCell2D_Index_IsValid;

	private static FFieldAddress RandomSobolCell2D_Index_PropertyAddress;

	private static int RandomSobolCell2D_Index_Offset;

	private static bool RandomSobolCell2D_NumCells_IsValid;

	private static FFieldAddress RandomSobolCell2D_NumCells_PropertyAddress;

	private static int RandomSobolCell2D_NumCells_Offset;

	private static bool RandomSobolCell2D_Cell_IsValid;

	private static FFieldAddress RandomSobolCell2D_Cell_PropertyAddress;

	private static int RandomSobolCell2D_Cell_Offset;

	private static bool RandomSobolCell2D_Seed_IsValid;

	private static FFieldAddress RandomSobolCell2D_Seed_PropertyAddress;

	private static int RandomSobolCell2D_Seed_Offset;

	private static bool RandomSobolCell2D_ReturnValue_IsValid;

	private static FFieldAddress RandomSobolCell2D_ReturnValue_PropertyAddress;

	private static int RandomSobolCell2D_ReturnValue_Offset;

	private static bool NextSobolFloat_IsValid;

	private static IntPtr NextSobolFloat_FunctionAddress;

	private static int NextSobolFloat_ParamsSize;

	private static bool NextSobolFloat_Index_IsValid;

	private static FFieldAddress NextSobolFloat_Index_PropertyAddress;

	private static int NextSobolFloat_Index_Offset;

	private static bool NextSobolFloat_Dimension_IsValid;

	private static FFieldAddress NextSobolFloat_Dimension_PropertyAddress;

	private static int NextSobolFloat_Dimension_Offset;

	private static bool NextSobolFloat_PreviousValue_IsValid;

	private static FFieldAddress NextSobolFloat_PreviousValue_PropertyAddress;

	private static int NextSobolFloat_PreviousValue_Offset;

	private static bool NextSobolFloat_ReturnValue_IsValid;

	private static FFieldAddress NextSobolFloat_ReturnValue_PropertyAddress;

	private static int NextSobolFloat_ReturnValue_Offset;

	private static bool NextSobolCell3D_IsValid;

	private static IntPtr NextSobolCell3D_FunctionAddress;

	private static int NextSobolCell3D_ParamsSize;

	private static bool NextSobolCell3D_Index_IsValid;

	private static FFieldAddress NextSobolCell3D_Index_PropertyAddress;

	private static int NextSobolCell3D_Index_Offset;

	private static bool NextSobolCell3D_NumCells_IsValid;

	private static FFieldAddress NextSobolCell3D_NumCells_PropertyAddress;

	private static int NextSobolCell3D_NumCells_Offset;

	private static bool NextSobolCell3D_PreviousValue_IsValid;

	private static FFieldAddress NextSobolCell3D_PreviousValue_PropertyAddress;

	private static int NextSobolCell3D_PreviousValue_Offset;

	private static bool NextSobolCell3D_ReturnValue_IsValid;

	private static FFieldAddress NextSobolCell3D_ReturnValue_PropertyAddress;

	private static int NextSobolCell3D_ReturnValue_Offset;

	private static bool NextSobolCell2D_IsValid;

	private static IntPtr NextSobolCell2D_FunctionAddress;

	private static int NextSobolCell2D_ParamsSize;

	private static bool NextSobolCell2D_Index_IsValid;

	private static FFieldAddress NextSobolCell2D_Index_PropertyAddress;

	private static int NextSobolCell2D_Index_Offset;

	private static bool NextSobolCell2D_NumCells_IsValid;

	private static FFieldAddress NextSobolCell2D_NumCells_PropertyAddress;

	private static int NextSobolCell2D_NumCells_Offset;

	private static bool NextSobolCell2D_PreviousValue_IsValid;

	private static FFieldAddress NextSobolCell2D_PreviousValue_PropertyAddress;

	private static int NextSobolCell2D_PreviousValue_Offset;

	private static bool NextSobolCell2D_ReturnValue_IsValid;

	private static FFieldAddress NextSobolCell2D_ReturnValue_PropertyAddress;

	private static int NextSobolCell2D_ReturnValue_Offset;

	private static bool MakeImportanceTexture_IsValid;

	private static IntPtr MakeImportanceTexture_FunctionAddress;

	private static int MakeImportanceTexture_ParamsSize;

	private static bool MakeImportanceTexture_Texture_IsValid;

	private static FFieldAddress MakeImportanceTexture_Texture_PropertyAddress;

	private static int MakeImportanceTexture_Texture_Offset;

	private static bool MakeImportanceTexture_WeightingFunc_IsValid;

	private static FFieldAddress MakeImportanceTexture_WeightingFunc_PropertyAddress;

	private static int MakeImportanceTexture_WeightingFunc_Offset;

	private static bool MakeImportanceTexture_ReturnValue_IsValid;

	private static FFieldAddress MakeImportanceTexture_ReturnValue_PropertyAddress;

	private static int MakeImportanceTexture_ReturnValue_Offset;

	private static bool ImportanceSample_IsValid;

	private static IntPtr ImportanceSample_FunctionAddress;

	private static int ImportanceSample_ParamsSize;

	private static bool ImportanceSample_Texture_IsValid;

	private static FFieldAddress ImportanceSample_Texture_PropertyAddress;

	private static int ImportanceSample_Texture_Offset;

	private static bool ImportanceSample_Rand_IsValid;

	private static FFieldAddress ImportanceSample_Rand_PropertyAddress;

	private static int ImportanceSample_Rand_Offset;

	private static bool ImportanceSample_Samples_IsValid;

	private static FFieldAddress ImportanceSample_Samples_PropertyAddress;

	private static int ImportanceSample_Samples_Offset;

	private static bool ImportanceSample_Intensity_IsValid;

	private static FFieldAddress ImportanceSample_Intensity_PropertyAddress;

	private static int ImportanceSample_Intensity_Offset;

	private static bool ImportanceSample_SamplePosition_IsValid;

	private static FFieldAddress ImportanceSample_SamplePosition_PropertyAddress;

	private static int ImportanceSample_SamplePosition_Offset;

	private static bool ImportanceSample_SampleColor_IsValid;

	private static FFieldAddress ImportanceSample_SampleColor_PropertyAddress;

	private static int ImportanceSample_SampleColor_Offset;

	private static bool ImportanceSample_SampleIntensity_IsValid;

	private static FFieldAddress ImportanceSample_SampleIntensity_PropertyAddress;

	private static int ImportanceSample_SampleIntensity_Offset;

	private static bool ImportanceSample_SampleSize_IsValid;

	private static FFieldAddress ImportanceSample_SampleSize_PropertyAddress;

	private static int ImportanceSample_SampleSize_Offset;

	private static bool BreakImportanceTexture_IsValid;

	private static IntPtr BreakImportanceTexture_FunctionAddress;

	private static int BreakImportanceTexture_ParamsSize;

	private static bool BreakImportanceTexture_ImportanceTexture_IsValid;

	private static FFieldAddress BreakImportanceTexture_ImportanceTexture_PropertyAddress;

	private static int BreakImportanceTexture_ImportanceTexture_Offset;

	private static bool BreakImportanceTexture_Texture_IsValid;

	private static FFieldAddress BreakImportanceTexture_Texture_PropertyAddress;

	private static int BreakImportanceTexture_Texture_Offset;

	private static bool BreakImportanceTexture_WeightingFunc_IsValid;

	private static FFieldAddress BreakImportanceTexture_WeightingFunc_PropertyAddress;

	private static int BreakImportanceTexture_WeightingFunc_Offset;

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:RandomSobolFloat")]
	public unsafe static float RandomSobolFloat(int Index, int Dimension, float Seed)
	{
		if (!RandomSobolFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:RandomSobolFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RandomSobolFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RandomSobolFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RandomSobolFloat_Index_Offset), 0, RandomSobolFloat_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RandomSobolFloat_Dimension_Offset), 0, RandomSobolFloat_Dimension_PropertyAddress.Address, Dimension);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RandomSobolFloat_Seed_Offset), 0, RandomSobolFloat_Seed_PropertyAddress.Address, Seed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RandomSobolFloat_FunctionAddress, intPtr, RandomSobolFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, RandomSobolFloat_ReturnValue_Offset), 0, RandomSobolFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073219u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:RandomSobolCell3D")]
	public unsafe static FVector RandomSobolCell3D(int Index, int NumCells, FVector Cell, FVector Seed)
	{
		if (!RandomSobolCell3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:RandomSobolCell3D");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(RandomSobolCell3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RandomSobolCell3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RandomSobolCell3D_Index_Offset), 0, RandomSobolCell3D_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RandomSobolCell3D_NumCells_Offset), 0, RandomSobolCell3D_NumCells_PropertyAddress.Address, NumCells);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RandomSobolCell3D_Cell_Offset), 0, RandomSobolCell3D_Cell_PropertyAddress.Address, Cell);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RandomSobolCell3D_Seed_Offset), 0, RandomSobolCell3D_Seed_PropertyAddress.Address, Seed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RandomSobolCell3D_FunctionAddress, intPtr, RandomSobolCell3D_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, RandomSobolCell3D_ReturnValue_Offset), 0, RandomSobolCell3D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073219u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:RandomSobolCell2D")]
	public unsafe static FVector2D RandomSobolCell2D(int Index, int NumCells, FVector2D Cell, FVector2D Seed)
	{
		if (!RandomSobolCell2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:RandomSobolCell2D");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(RandomSobolCell2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RandomSobolCell2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RandomSobolCell2D_Index_Offset), 0, RandomSobolCell2D_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RandomSobolCell2D_NumCells_Offset), 0, RandomSobolCell2D_NumCells_PropertyAddress.Address, NumCells);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, RandomSobolCell2D_Cell_Offset), 0, RandomSobolCell2D_Cell_PropertyAddress.Address, Cell);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, RandomSobolCell2D_Seed_Offset), 0, RandomSobolCell2D_Seed_PropertyAddress.Address, Seed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RandomSobolCell2D_FunctionAddress, intPtr, RandomSobolCell2D_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, RandomSobolCell2D_ReturnValue_Offset), 0, RandomSobolCell2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:NextSobolFloat")]
	public unsafe static float NextSobolFloat(int Index, int Dimension, float PreviousValue)
	{
		if (!NextSobolFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:NextSobolFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NextSobolFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NextSobolFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NextSobolFloat_Index_Offset), 0, NextSobolFloat_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NextSobolFloat_Dimension_Offset), 0, NextSobolFloat_Dimension_PropertyAddress.Address, Dimension);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NextSobolFloat_PreviousValue_Offset), 0, NextSobolFloat_PreviousValue_PropertyAddress.Address, PreviousValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NextSobolFloat_FunctionAddress, intPtr, NextSobolFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, NextSobolFloat_ReturnValue_Offset), 0, NextSobolFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073219u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:NextSobolCell3D")]
	public unsafe static FVector NextSobolCell3D(int Index, int NumCells, FVector PreviousValue)
	{
		if (!NextSobolCell3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:NextSobolCell3D");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NextSobolCell3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NextSobolCell3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NextSobolCell3D_Index_Offset), 0, NextSobolCell3D_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NextSobolCell3D_NumCells_Offset), 0, NextSobolCell3D_NumCells_PropertyAddress.Address, NumCells);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, NextSobolCell3D_PreviousValue_Offset), 0, NextSobolCell3D_PreviousValue_PropertyAddress.Address, PreviousValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NextSobolCell3D_FunctionAddress, intPtr, NextSobolCell3D_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, NextSobolCell3D_ReturnValue_Offset), 0, NextSobolCell3D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073219u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:NextSobolCell2D")]
	public unsafe static FVector2D NextSobolCell2D(int Index, int NumCells, FVector2D PreviousValue)
	{
		if (!NextSobolCell2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:NextSobolCell2D");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NextSobolCell2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NextSobolCell2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NextSobolCell2D_Index_Offset), 0, NextSobolCell2D_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NextSobolCell2D_NumCells_Offset), 0, NextSobolCell2D_NumCells_PropertyAddress.Address, NumCells);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, NextSobolCell2D_PreviousValue_Offset), 0, NextSobolCell2D_PreviousValue_PropertyAddress.Address, PreviousValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NextSobolCell2D_FunctionAddress, intPtr, NextSobolCell2D_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, NextSobolCell2D_ReturnValue_Offset), 0, NextSobolCell2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:MakeImportanceTexture")]
	public unsafe static FImportanceTexture MakeImportanceTexture(UTexture2D Texture, EImportanceWeight WeightingFunc)
	{
		if (!MakeImportanceTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:MakeImportanceTexture");
			return default(FImportanceTexture);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeImportanceTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeImportanceTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, MakeImportanceTexture_Texture_Offset), 0, MakeImportanceTexture_Texture_PropertyAddress.Address, Texture);
		EnumMarshaler<EImportanceWeight>.ToNative(IntPtr.Add(intPtr, MakeImportanceTexture_WeightingFunc_Offset), 0, MakeImportanceTexture_WeightingFunc_PropertyAddress.Address, WeightingFunc);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeImportanceTexture_FunctionAddress, intPtr, MakeImportanceTexture_ParamsSize);
		FImportanceTexture result = FImportanceTexture.FromNative(IntPtr.Add(intPtr, MakeImportanceTexture_ReturnValue_Offset), 0, MakeImportanceTexture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeImportanceTexture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267523u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:ImportanceSample")]
	public unsafe static void ImportanceSample(FImportanceTexture Texture, FVector2D Rand, int Samples, float Intensity, out FVector2D SamplePosition, out FLinearColor SampleColor, out float SampleIntensity, out float SampleSize)
	{
		if (!ImportanceSample_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:ImportanceSample");
			SamplePosition = default(FVector2D);
			SampleColor = default(FLinearColor);
			SampleIntensity = 0f;
			SampleSize = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportanceSample_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportanceSample_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ImportanceSample_Texture_PropertyAddress.Address, intPtr);
		FImportanceTexture.ToNative(IntPtr.Add(intPtr, ImportanceSample_Texture_Offset), 0, ImportanceSample_Texture_PropertyAddress.Address, Texture);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ImportanceSample_Rand_Offset), 0, ImportanceSample_Rand_PropertyAddress.Address, Rand);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ImportanceSample_Samples_Offset), 0, ImportanceSample_Samples_PropertyAddress.Address, Samples);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ImportanceSample_Intensity_Offset), 0, ImportanceSample_Intensity_PropertyAddress.Address, Intensity);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportanceSample_FunctionAddress, intPtr, ImportanceSample_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportanceSample_Texture_PropertyAddress.Address, intPtr);
		SamplePosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ImportanceSample_SamplePosition_Offset), 0, ImportanceSample_SamplePosition_PropertyAddress.Address);
		SampleColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, ImportanceSample_SampleColor_Offset), 0, ImportanceSample_SampleColor_PropertyAddress.Address);
		SampleIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, ImportanceSample_SampleIntensity_Offset), 0, ImportanceSample_SampleIntensity_PropertyAddress.Address);
		SampleSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, ImportanceSample_SampleSize_Offset), 0, ImportanceSample_SampleSize_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/Engine.ImportanceSamplingLibrary:BreakImportanceTexture")]
	public unsafe static void BreakImportanceTexture(FImportanceTexture ImportanceTexture, out UTexture2D Texture, out EImportanceWeight WeightingFunc)
	{
		if (!BreakImportanceTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ImportanceSamplingLibrary:BreakImportanceTexture");
			Texture = null;
			WeightingFunc = EImportanceWeight.Luminance;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakImportanceTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakImportanceTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakImportanceTexture_ImportanceTexture_PropertyAddress.Address, intPtr);
		FImportanceTexture.ToNative(IntPtr.Add(intPtr, BreakImportanceTexture_ImportanceTexture_Offset), 0, BreakImportanceTexture_ImportanceTexture_PropertyAddress.Address, ImportanceTexture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakImportanceTexture_FunctionAddress, intPtr, BreakImportanceTexture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BreakImportanceTexture_ImportanceTexture_PropertyAddress.Address, intPtr);
		Texture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, BreakImportanceTexture_Texture_Offset), 0, BreakImportanceTexture_Texture_PropertyAddress.Address);
		WeightingFunc = EnumMarshaler<EImportanceWeight>.FromNative(IntPtr.Add(intPtr, BreakImportanceTexture_WeightingFunc_Offset), 0, BreakImportanceTexture_WeightingFunc_PropertyAddress.Address);
	}

	static UImportanceSamplingLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UImportanceSamplingLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UImportanceSamplingLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.ImportanceSamplingLibrary");
		RandomSobolFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RandomSobolFloat");
		RandomSobolFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(RandomSobolFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolFloat_Index_PropertyAddress, RandomSobolFloat_FunctionAddress, "Index");
		RandomSobolFloat_Index_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolFloat_FunctionAddress, "Index");
		RandomSobolFloat_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolFloat_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolFloat_Dimension_PropertyAddress, RandomSobolFloat_FunctionAddress, "Dimension");
		RandomSobolFloat_Dimension_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolFloat_FunctionAddress, "Dimension");
		RandomSobolFloat_Dimension_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolFloat_FunctionAddress, "Dimension", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolFloat_Seed_PropertyAddress, RandomSobolFloat_FunctionAddress, "Seed");
		RandomSobolFloat_Seed_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolFloat_FunctionAddress, "Seed");
		RandomSobolFloat_Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolFloat_FunctionAddress, "Seed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolFloat_ReturnValue_PropertyAddress, RandomSobolFloat_FunctionAddress, "ReturnValue");
		RandomSobolFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolFloat_FunctionAddress, "ReturnValue");
		RandomSobolFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		RandomSobolFloat_IsValid = RandomSobolFloat_FunctionAddress != IntPtr.Zero && RandomSobolFloat_Index_IsValid && RandomSobolFloat_Dimension_IsValid && RandomSobolFloat_Seed_IsValid && RandomSobolFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:RandomSobolFloat", RandomSobolFloat_IsValid);
		RandomSobolCell3D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RandomSobolCell3D");
		RandomSobolCell3D_ParamsSize = NativeReflection.GetFunctionParamsSize(RandomSobolCell3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell3D_Index_PropertyAddress, RandomSobolCell3D_FunctionAddress, "Index");
		RandomSobolCell3D_Index_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell3D_FunctionAddress, "Index");
		RandomSobolCell3D_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell3D_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell3D_NumCells_PropertyAddress, RandomSobolCell3D_FunctionAddress, "NumCells");
		RandomSobolCell3D_NumCells_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell3D_FunctionAddress, "NumCells");
		RandomSobolCell3D_NumCells_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell3D_FunctionAddress, "NumCells", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell3D_Cell_PropertyAddress, RandomSobolCell3D_FunctionAddress, "Cell");
		RandomSobolCell3D_Cell_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell3D_FunctionAddress, "Cell");
		RandomSobolCell3D_Cell_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell3D_FunctionAddress, "Cell", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell3D_Seed_PropertyAddress, RandomSobolCell3D_FunctionAddress, "Seed");
		RandomSobolCell3D_Seed_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell3D_FunctionAddress, "Seed");
		RandomSobolCell3D_Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell3D_FunctionAddress, "Seed", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell3D_ReturnValue_PropertyAddress, RandomSobolCell3D_FunctionAddress, "ReturnValue");
		RandomSobolCell3D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell3D_FunctionAddress, "ReturnValue");
		RandomSobolCell3D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell3D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		RandomSobolCell3D_IsValid = RandomSobolCell3D_FunctionAddress != IntPtr.Zero && RandomSobolCell3D_Index_IsValid && RandomSobolCell3D_NumCells_IsValid && RandomSobolCell3D_Cell_IsValid && RandomSobolCell3D_Seed_IsValid && RandomSobolCell3D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:RandomSobolCell3D", RandomSobolCell3D_IsValid);
		RandomSobolCell2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RandomSobolCell2D");
		RandomSobolCell2D_ParamsSize = NativeReflection.GetFunctionParamsSize(RandomSobolCell2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell2D_Index_PropertyAddress, RandomSobolCell2D_FunctionAddress, "Index");
		RandomSobolCell2D_Index_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell2D_FunctionAddress, "Index");
		RandomSobolCell2D_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell2D_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell2D_NumCells_PropertyAddress, RandomSobolCell2D_FunctionAddress, "NumCells");
		RandomSobolCell2D_NumCells_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell2D_FunctionAddress, "NumCells");
		RandomSobolCell2D_NumCells_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell2D_FunctionAddress, "NumCells", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell2D_Cell_PropertyAddress, RandomSobolCell2D_FunctionAddress, "Cell");
		RandomSobolCell2D_Cell_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell2D_FunctionAddress, "Cell");
		RandomSobolCell2D_Cell_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell2D_FunctionAddress, "Cell", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell2D_Seed_PropertyAddress, RandomSobolCell2D_FunctionAddress, "Seed");
		RandomSobolCell2D_Seed_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell2D_FunctionAddress, "Seed");
		RandomSobolCell2D_Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell2D_FunctionAddress, "Seed", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomSobolCell2D_ReturnValue_PropertyAddress, RandomSobolCell2D_FunctionAddress, "ReturnValue");
		RandomSobolCell2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RandomSobolCell2D_FunctionAddress, "ReturnValue");
		RandomSobolCell2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomSobolCell2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		RandomSobolCell2D_IsValid = RandomSobolCell2D_FunctionAddress != IntPtr.Zero && RandomSobolCell2D_Index_IsValid && RandomSobolCell2D_NumCells_IsValid && RandomSobolCell2D_Cell_IsValid && RandomSobolCell2D_Seed_IsValid && RandomSobolCell2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:RandomSobolCell2D", RandomSobolCell2D_IsValid);
		NextSobolFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NextSobolFloat");
		NextSobolFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(NextSobolFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NextSobolFloat_Index_PropertyAddress, NextSobolFloat_FunctionAddress, "Index");
		NextSobolFloat_Index_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolFloat_FunctionAddress, "Index");
		NextSobolFloat_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolFloat_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolFloat_Dimension_PropertyAddress, NextSobolFloat_FunctionAddress, "Dimension");
		NextSobolFloat_Dimension_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolFloat_FunctionAddress, "Dimension");
		NextSobolFloat_Dimension_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolFloat_FunctionAddress, "Dimension", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolFloat_PreviousValue_PropertyAddress, NextSobolFloat_FunctionAddress, "PreviousValue");
		NextSobolFloat_PreviousValue_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolFloat_FunctionAddress, "PreviousValue");
		NextSobolFloat_PreviousValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolFloat_FunctionAddress, "PreviousValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolFloat_ReturnValue_PropertyAddress, NextSobolFloat_FunctionAddress, "ReturnValue");
		NextSobolFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolFloat_FunctionAddress, "ReturnValue");
		NextSobolFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		NextSobolFloat_IsValid = NextSobolFloat_FunctionAddress != IntPtr.Zero && NextSobolFloat_Index_IsValid && NextSobolFloat_Dimension_IsValid && NextSobolFloat_PreviousValue_IsValid && NextSobolFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:NextSobolFloat", NextSobolFloat_IsValid);
		NextSobolCell3D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NextSobolCell3D");
		NextSobolCell3D_ParamsSize = NativeReflection.GetFunctionParamsSize(NextSobolCell3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell3D_Index_PropertyAddress, NextSobolCell3D_FunctionAddress, "Index");
		NextSobolCell3D_Index_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell3D_FunctionAddress, "Index");
		NextSobolCell3D_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell3D_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell3D_NumCells_PropertyAddress, NextSobolCell3D_FunctionAddress, "NumCells");
		NextSobolCell3D_NumCells_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell3D_FunctionAddress, "NumCells");
		NextSobolCell3D_NumCells_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell3D_FunctionAddress, "NumCells", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell3D_PreviousValue_PropertyAddress, NextSobolCell3D_FunctionAddress, "PreviousValue");
		NextSobolCell3D_PreviousValue_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell3D_FunctionAddress, "PreviousValue");
		NextSobolCell3D_PreviousValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell3D_FunctionAddress, "PreviousValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell3D_ReturnValue_PropertyAddress, NextSobolCell3D_FunctionAddress, "ReturnValue");
		NextSobolCell3D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell3D_FunctionAddress, "ReturnValue");
		NextSobolCell3D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell3D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NextSobolCell3D_IsValid = NextSobolCell3D_FunctionAddress != IntPtr.Zero && NextSobolCell3D_Index_IsValid && NextSobolCell3D_NumCells_IsValid && NextSobolCell3D_PreviousValue_IsValid && NextSobolCell3D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:NextSobolCell3D", NextSobolCell3D_IsValid);
		NextSobolCell2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NextSobolCell2D");
		NextSobolCell2D_ParamsSize = NativeReflection.GetFunctionParamsSize(NextSobolCell2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell2D_Index_PropertyAddress, NextSobolCell2D_FunctionAddress, "Index");
		NextSobolCell2D_Index_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell2D_FunctionAddress, "Index");
		NextSobolCell2D_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell2D_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell2D_NumCells_PropertyAddress, NextSobolCell2D_FunctionAddress, "NumCells");
		NextSobolCell2D_NumCells_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell2D_FunctionAddress, "NumCells");
		NextSobolCell2D_NumCells_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell2D_FunctionAddress, "NumCells", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell2D_PreviousValue_PropertyAddress, NextSobolCell2D_FunctionAddress, "PreviousValue");
		NextSobolCell2D_PreviousValue_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell2D_FunctionAddress, "PreviousValue");
		NextSobolCell2D_PreviousValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell2D_FunctionAddress, "PreviousValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NextSobolCell2D_ReturnValue_PropertyAddress, NextSobolCell2D_FunctionAddress, "ReturnValue");
		NextSobolCell2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NextSobolCell2D_FunctionAddress, "ReturnValue");
		NextSobolCell2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NextSobolCell2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NextSobolCell2D_IsValid = NextSobolCell2D_FunctionAddress != IntPtr.Zero && NextSobolCell2D_Index_IsValid && NextSobolCell2D_NumCells_IsValid && NextSobolCell2D_PreviousValue_IsValid && NextSobolCell2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:NextSobolCell2D", NextSobolCell2D_IsValid);
		MakeImportanceTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeImportanceTexture");
		MakeImportanceTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeImportanceTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeImportanceTexture_Texture_PropertyAddress, MakeImportanceTexture_FunctionAddress, "Texture");
		MakeImportanceTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(MakeImportanceTexture_FunctionAddress, "Texture");
		MakeImportanceTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeImportanceTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeImportanceTexture_WeightingFunc_PropertyAddress, MakeImportanceTexture_FunctionAddress, "WeightingFunc");
		MakeImportanceTexture_WeightingFunc_Offset = NativeReflectionCached.GetPropertyOffset(MakeImportanceTexture_FunctionAddress, "WeightingFunc");
		MakeImportanceTexture_WeightingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeImportanceTexture_FunctionAddress, "WeightingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeImportanceTexture_ReturnValue_PropertyAddress, MakeImportanceTexture_FunctionAddress, "ReturnValue");
		MakeImportanceTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeImportanceTexture_FunctionAddress, "ReturnValue");
		MakeImportanceTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeImportanceTexture_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeImportanceTexture_IsValid = MakeImportanceTexture_FunctionAddress != IntPtr.Zero && MakeImportanceTexture_Texture_IsValid && MakeImportanceTexture_WeightingFunc_IsValid && MakeImportanceTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:MakeImportanceTexture", MakeImportanceTexture_IsValid);
		ImportanceSample_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportanceSample");
		ImportanceSample_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportanceSample_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_Texture_PropertyAddress, ImportanceSample_FunctionAddress, "Texture");
		ImportanceSample_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "Texture");
		ImportanceSample_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "Texture", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_Rand_PropertyAddress, ImportanceSample_FunctionAddress, "Rand");
		ImportanceSample_Rand_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "Rand");
		ImportanceSample_Rand_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "Rand", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_Samples_PropertyAddress, ImportanceSample_FunctionAddress, "Samples");
		ImportanceSample_Samples_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "Samples");
		ImportanceSample_Samples_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "Samples", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_Intensity_PropertyAddress, ImportanceSample_FunctionAddress, "Intensity");
		ImportanceSample_Intensity_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "Intensity");
		ImportanceSample_Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "Intensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_SamplePosition_PropertyAddress, ImportanceSample_FunctionAddress, "SamplePosition");
		ImportanceSample_SamplePosition_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "SamplePosition");
		ImportanceSample_SamplePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "SamplePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_SampleColor_PropertyAddress, ImportanceSample_FunctionAddress, "SampleColor");
		ImportanceSample_SampleColor_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "SampleColor");
		ImportanceSample_SampleColor_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "SampleColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_SampleIntensity_PropertyAddress, ImportanceSample_FunctionAddress, "SampleIntensity");
		ImportanceSample_SampleIntensity_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "SampleIntensity");
		ImportanceSample_SampleIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "SampleIntensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportanceSample_SampleSize_PropertyAddress, ImportanceSample_FunctionAddress, "SampleSize");
		ImportanceSample_SampleSize_Offset = NativeReflectionCached.GetPropertyOffset(ImportanceSample_FunctionAddress, "SampleSize");
		ImportanceSample_SampleSize_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportanceSample_FunctionAddress, "SampleSize", Classes.FFloatProperty);
		ImportanceSample_IsValid = ImportanceSample_FunctionAddress != IntPtr.Zero && ImportanceSample_Texture_IsValid && ImportanceSample_Rand_IsValid && ImportanceSample_Samples_IsValid && ImportanceSample_Intensity_IsValid && ImportanceSample_SamplePosition_IsValid && ImportanceSample_SampleColor_IsValid && ImportanceSample_SampleIntensity_IsValid && ImportanceSample_SampleSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:ImportanceSample", ImportanceSample_IsValid);
		BreakImportanceTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakImportanceTexture");
		BreakImportanceTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakImportanceTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakImportanceTexture_ImportanceTexture_PropertyAddress, BreakImportanceTexture_FunctionAddress, "ImportanceTexture");
		BreakImportanceTexture_ImportanceTexture_Offset = NativeReflectionCached.GetPropertyOffset(BreakImportanceTexture_FunctionAddress, "ImportanceTexture");
		BreakImportanceTexture_ImportanceTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakImportanceTexture_FunctionAddress, "ImportanceTexture", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakImportanceTexture_Texture_PropertyAddress, BreakImportanceTexture_FunctionAddress, "Texture");
		BreakImportanceTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(BreakImportanceTexture_FunctionAddress, "Texture");
		BreakImportanceTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakImportanceTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakImportanceTexture_WeightingFunc_PropertyAddress, BreakImportanceTexture_FunctionAddress, "WeightingFunc");
		BreakImportanceTexture_WeightingFunc_Offset = NativeReflectionCached.GetPropertyOffset(BreakImportanceTexture_FunctionAddress, "WeightingFunc");
		BreakImportanceTexture_WeightingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakImportanceTexture_FunctionAddress, "WeightingFunc", Classes.FByteProperty);
		BreakImportanceTexture_IsValid = BreakImportanceTexture_FunctionAddress != IntPtr.Zero && BreakImportanceTexture_ImportanceTexture_IsValid && BreakImportanceTexture_Texture_IsValid && BreakImportanceTexture_WeightingFunc_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ImportanceSamplingLibrary:BreakImportanceTexture", BreakImportanceTexture_IsValid);
	}
}
