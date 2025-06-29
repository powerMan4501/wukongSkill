using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSLevelBoundsVisualizer : AActor
{
	private static bool TargetSubLevelName_IsValid;

	private static int TargetSubLevelName_Offset;

	private static bool DrawingResolution_IsValid;

	private static int DrawingResolution_Offset;

	private static bool ActorBoundsPercentThreshold_IsValid;

	private static int ActorBoundsPercentThreshold_Offset;

	private static bool AngleThreshold_IsValid;

	private static int AngleThreshold_Offset;

	private static bool DrawActorBounds_IsValid;

	private static FFieldAddress DrawActorBounds_PropertyAddress;

	private static int DrawActorBounds_Offset;

	private static bool Visualize_IsValid;

	private static IntPtr Visualize_FunctionAddress;

	private static int Visualize_ParamsSize;

	private static bool TakeScreenshot_IsValid;

	private static IntPtr TakeScreenshot_FunctionAddress;

	private static int TakeScreenshot_ParamsSize;

	private static bool TakeScreenshot_InDelaySeconds_IsValid;

	private static FFieldAddress TakeScreenshot_InDelaySeconds_PropertyAddress;

	private static int TakeScreenshot_InDelaySeconds_Offset;

	private static bool Clear_IsValid;

	private static IntPtr Clear_FunctionAddress;

	private static int Clear_ParamsSize;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:TargetSubLevelName")]
	public string TargetSubLevelName
	{
		get
		{
			CheckDestroyed();
			if (!TargetSubLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:TargetSubLevelName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TargetSubLevelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetSubLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:TargetSubLevelName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TargetSubLevelName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:DrawingResolution")]
	public float DrawingResolution
	{
		get
		{
			CheckDestroyed();
			if (!DrawingResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:DrawingResolution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DrawingResolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DrawingResolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:DrawingResolution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DrawingResolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:ActorBoundsPercentThreshold")]
	public float ActorBoundsPercentThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ActorBoundsPercentThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:ActorBoundsPercentThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ActorBoundsPercentThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorBoundsPercentThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:ActorBoundsPercentThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ActorBoundsPercentThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:AngleThreshold")]
	public float AngleThreshold
	{
		get
		{
			CheckDestroyed();
			if (!AngleThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:AngleThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:AngleThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:bDrawActorBounds")]
	public bool DrawActorBounds
	{
		get
		{
			CheckDestroyed();
			if (!DrawActorBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:bDrawActorBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawActorBounds_Offset), 0, DrawActorBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawActorBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:bDrawActorBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawActorBounds_Offset), 0, DrawActorBounds_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:Visualize")]
	public unsafe void Visualize()
	{
		CheckDestroyed();
		if (!Visualize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:Visualize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Visualize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Visualize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Visualize_FunctionAddress, argsSize: Visualize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:TakeScreenshot")]
	public unsafe void TakeScreenshot(float InDelaySeconds)
	{
		CheckDestroyed();
		if (!TakeScreenshot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:TakeScreenshot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeScreenshot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeScreenshot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TakeScreenshot_InDelaySeconds_Offset), 0, TakeScreenshot_InDelaySeconds_PropertyAddress.Address, InDelaySeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, TakeScreenshot_FunctionAddress, intPtr, TakeScreenshot_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelBoundsVisualizer:Clear")]
	public unsafe void Clear()
	{
		CheckDestroyed();
		if (!Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLevelBoundsVisualizer:Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Clear_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Clear_FunctionAddress, argsSize: Clear_ParamsSize);
	}

	static AGSLevelBoundsVisualizer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSLevelBoundsVisualizer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSLevelBoundsVisualizer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSLevelBoundsVisualizer");
		TargetSubLevelName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetSubLevelName");
		TargetSubLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetSubLevelName", Classes.FStrProperty);
		DrawingResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawingResolution");
		DrawingResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawingResolution", Classes.FFloatProperty);
		ActorBoundsPercentThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorBoundsPercentThreshold");
		ActorBoundsPercentThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorBoundsPercentThreshold", Classes.FFloatProperty);
		AngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngleThreshold");
		AngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngleThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawActorBounds_PropertyAddress, intPtr, "bDrawActorBounds");
		DrawActorBounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawActorBounds");
		DrawActorBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawActorBounds", Classes.FBoolProperty);
		Visualize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Visualize");
		Visualize_ParamsSize = NativeReflection.GetFunctionParamsSize(Visualize_FunctionAddress);
		Visualize_IsValid = Visualize_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLevelBoundsVisualizer:Visualize", Visualize_IsValid);
		TakeScreenshot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TakeScreenshot");
		TakeScreenshot_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeScreenshot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeScreenshot_InDelaySeconds_PropertyAddress, TakeScreenshot_FunctionAddress, "InDelaySeconds");
		TakeScreenshot_InDelaySeconds_Offset = NativeReflectionCached.GetPropertyOffset(TakeScreenshot_FunctionAddress, "InDelaySeconds");
		TakeScreenshot_InDelaySeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeScreenshot_FunctionAddress, "InDelaySeconds", Classes.FFloatProperty);
		TakeScreenshot_IsValid = TakeScreenshot_FunctionAddress != IntPtr.Zero && TakeScreenshot_InDelaySeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLevelBoundsVisualizer:TakeScreenshot", TakeScreenshot_IsValid);
		Clear_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Clear");
		Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Clear_FunctionAddress);
		Clear_IsValid = Clear_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLevelBoundsVisualizer:Clear", Clear_IsValid);
	}
}
