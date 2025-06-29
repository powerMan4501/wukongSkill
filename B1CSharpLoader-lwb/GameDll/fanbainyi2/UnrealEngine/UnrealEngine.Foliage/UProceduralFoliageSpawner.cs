using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Foliage.ProceduralFoliageSpawner", "Foliage", UnrealModuleType.Engine)]
public class UProceduralFoliageSpawner : UObject
{
	private static bool RandomSeed_IsValid;

	private static int RandomSeed_Offset;

	private static bool TileSize_IsValid;

	private static int TileSize_Offset;

	private static bool NumUniqueTiles_IsValid;

	private static int NumUniqueTiles_Offset;

	private static bool MinimumQuadTreeSize_IsValid;

	private static int MinimumQuadTreeSize_Offset;

	private static bool Simulate_IsValid;

	private static IntPtr Simulate_FunctionAddress;

	private static int Simulate_ParamsSize;

	private static bool Simulate_NumSteps_IsValid;

	private static FFieldAddress Simulate_NumSteps_PropertyAddress;

	private static int Simulate_NumSteps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageSpawner:RandomSeed")]
	public int RandomSeed
	{
		get
		{
			CheckDestroyed();
			if (!RandomSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:RandomSeed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RandomSeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomSeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:RandomSeed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RandomSeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageSpawner:TileSize")]
	public float TileSize
	{
		get
		{
			CheckDestroyed();
			if (!TileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:TileSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TileSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TileSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:TileSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TileSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageSpawner:NumUniqueTiles")]
	public int NumUniqueTiles
	{
		get
		{
			CheckDestroyed();
			if (!NumUniqueTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:NumUniqueTiles");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumUniqueTiles_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumUniqueTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:NumUniqueTiles");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumUniqueTiles_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageSpawner:MinimumQuadTreeSize")]
	public float MinimumQuadTreeSize
	{
		get
		{
			CheckDestroyed();
			if (!MinimumQuadTreeSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:MinimumQuadTreeSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinimumQuadTreeSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinimumQuadTreeSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Foliage.ProceduralFoliageSpawner:MinimumQuadTreeSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinimumQuadTreeSize_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Foliage.ProceduralFoliageSpawner:Simulate")]
	public unsafe void Simulate(int NumSteps = -1)
	{
		CheckDestroyed();
		if (!Simulate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Foliage.ProceduralFoliageSpawner:Simulate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Simulate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Simulate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Simulate_NumSteps_Offset), 0, Simulate_NumSteps_PropertyAddress.Address, NumSteps);
		NativeReflection.InvokeFunctionOptimized(base.Address, Simulate_FunctionAddress, intPtr, Simulate_ParamsSize);
	}

	static UProceduralFoliageSpawner()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProceduralFoliageSpawner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProceduralFoliageSpawner));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Foliage.ProceduralFoliageSpawner");
		RandomSeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RandomSeed");
		RandomSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RandomSeed", Classes.FIntProperty);
		TileSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileSize");
		TileSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileSize", Classes.FFloatProperty);
		NumUniqueTiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumUniqueTiles");
		NumUniqueTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumUniqueTiles", Classes.FIntProperty);
		MinimumQuadTreeSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumQuadTreeSize");
		MinimumQuadTreeSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumQuadTreeSize", Classes.FFloatProperty);
		Simulate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Simulate");
		Simulate_ParamsSize = NativeReflection.GetFunctionParamsSize(Simulate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Simulate_NumSteps_PropertyAddress, Simulate_FunctionAddress, "NumSteps");
		Simulate_NumSteps_Offset = NativeReflectionCached.GetPropertyOffset(Simulate_FunctionAddress, "NumSteps");
		Simulate_NumSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(Simulate_FunctionAddress, "NumSteps", Classes.FIntProperty);
		Simulate_IsValid = Simulate_FunctionAddress != IntPtr.Zero && Simulate_NumSteps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Foliage.ProceduralFoliageSpawner:Simulate", Simulate_IsValid);
	}
}
