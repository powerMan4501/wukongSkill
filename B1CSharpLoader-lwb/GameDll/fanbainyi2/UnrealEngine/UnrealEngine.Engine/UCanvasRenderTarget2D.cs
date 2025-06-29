using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CanvasRenderTarget2D", "Engine", UnrealModuleType.Engine)]
public class UCanvasRenderTarget2D : UTextureRenderTarget2D
{
	private static IntPtr classAddress;

	private static bool OnCanvasRenderTargetUpdate_IsValid;

	private static int OnCanvasRenderTargetUpdate_Offset;

	private FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate_DelegateCached;

	private static bool UpdateResource_IsValid;

	private static IntPtr UpdateResource_FunctionAddress;

	private static int UpdateResource_ParamsSize;

	private static bool ReceiveUpdate_IsValid;

	private IntPtr ReceiveUpdate_InstanceFunctionAddress;

	private static IntPtr ReceiveUpdate_FunctionAddress;

	private static int ReceiveUpdate_ParamsSize;

	private static bool ReceiveUpdate_Canvas_IsValid;

	private static FFieldAddress ReceiveUpdate_Canvas_PropertyAddress;

	private static int ReceiveUpdate_Canvas_Offset;

	private static bool ReceiveUpdate_Width_IsValid;

	private static FFieldAddress ReceiveUpdate_Width_PropertyAddress;

	private static int ReceiveUpdate_Width_Offset;

	private static bool ReceiveUpdate_Height_IsValid;

	private static FFieldAddress ReceiveUpdate_Height_PropertyAddress;

	private static int ReceiveUpdate_Height_Offset;

	private static bool GetSize_IsValid;

	private static IntPtr GetSize_FunctionAddress;

	private static int GetSize_ParamsSize;

	private static bool GetSize_Width_IsValid;

	private static FFieldAddress GetSize_Width_PropertyAddress;

	private static int GetSize_Width_Offset;

	private static bool GetSize_Height_IsValid;

	private static FFieldAddress GetSize_Height_PropertyAddress;

	private static int GetSize_Height_Offset;

	private static bool CreateCanvasRenderTarget2D_IsValid;

	private static IntPtr CreateCanvasRenderTarget2D_FunctionAddress;

	private static int CreateCanvasRenderTarget2D_ParamsSize;

	private static bool CreateCanvasRenderTarget2D_WorldContextObject_IsValid;

	private static FFieldAddress CreateCanvasRenderTarget2D_WorldContextObject_PropertyAddress;

	private static int CreateCanvasRenderTarget2D_WorldContextObject_Offset;

	private static bool CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_IsValid;

	private static FFieldAddress CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_PropertyAddress;

	private static int CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_Offset;

	private static bool CreateCanvasRenderTarget2D_Width_IsValid;

	private static FFieldAddress CreateCanvasRenderTarget2D_Width_PropertyAddress;

	private static int CreateCanvasRenderTarget2D_Width_Offset;

	private static bool CreateCanvasRenderTarget2D_Height_IsValid;

	private static FFieldAddress CreateCanvasRenderTarget2D_Height_PropertyAddress;

	private static int CreateCanvasRenderTarget2D_Height_Offset;

	private static bool CreateCanvasRenderTarget2D_ReturnValue_IsValid;

	private static FFieldAddress CreateCanvasRenderTarget2D_ReturnValue_PropertyAddress;

	private static int CreateCanvasRenderTarget2D_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.CanvasRenderTarget2D:OnCanvasRenderTargetUpdate")]
	public FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate
	{
		get
		{
			CheckDestroyed();
			if (!OnCanvasRenderTargetUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CanvasRenderTarget2D:OnCanvasRenderTargetUpdate");
				return new FOnCanvasRenderTargetUpdate();
			}
			if (OnCanvasRenderTargetUpdate_DelegateCached == null)
			{
				OnCanvasRenderTargetUpdate_DelegateCached = new FOnCanvasRenderTargetUpdate();
				OnCanvasRenderTargetUpdate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCanvasRenderTargetUpdate_Offset));
			}
			return OnCanvasRenderTargetUpdate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CanvasRenderTarget2D:UpdateResource")]
	public unsafe void UpdateResource()
	{
		CheckDestroyed();
		if (!UpdateResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CanvasRenderTarget2D:UpdateResource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateResource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateResource_FunctionAddress, argsSize: UpdateResource_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.CanvasRenderTarget2D:ReceiveUpdate")]
	public unsafe void ReceiveUpdate(UCanvas Canvas, int Width, int Height)
	{
		CheckDestroyed();
		if (!ReceiveUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CanvasRenderTarget2D:ReceiveUpdate");
			return;
		}
		if (ReceiveUpdate_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveUpdate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveUpdate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveUpdate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, ReceiveUpdate_Canvas_Offset), 0, ReceiveUpdate_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveUpdate_Width_Offset), 0, ReceiveUpdate_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveUpdate_Height_Offset), 0, ReceiveUpdate_Height_PropertyAddress.Address, Height);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveUpdate_InstanceFunctionAddress, intPtr, ReceiveUpdate_ParamsSize);
	}

	protected unsafe virtual void ReceiveUpdate_Implementation(UCanvas Canvas, int Width, int Height)
	{
		CheckDestroyed();
		if (!ReceiveUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CanvasRenderTarget2D:ReceiveUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveUpdate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, ReceiveUpdate_Canvas_Offset), 0, ReceiveUpdate_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveUpdate_Width_Offset), 0, ReceiveUpdate_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReceiveUpdate_Height_Offset), 0, ReceiveUpdate_Height_PropertyAddress.Address, Height);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveUpdate_FunctionAddress, intPtr, ReceiveUpdate_ParamsSize);
	}

	[UFunction(Flags = 339870721u)]
	[UMetaPath("/Script/Engine.CanvasRenderTarget2D:GetSize")]
	public unsafe void GetSize(out int Width, out int Height)
	{
		CheckDestroyed();
		if (!GetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CanvasRenderTarget2D:GetSize");
			Width = 0;
			Height = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSize_FunctionAddress, intPtr, GetSize_ParamsSize);
		Width = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSize_Width_Offset), 0, GetSize_Width_PropertyAddress.Address);
		Height = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSize_Height_Offset), 0, GetSize_Height_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.CanvasRenderTarget2D:CreateCanvasRenderTarget2D")]
	public unsafe static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject, TSubclassOf<UCanvasRenderTarget2D> CanvasRenderTarget2DClass, int Width = 1024, int Height = 1024)
	{
		if (!CreateCanvasRenderTarget2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CanvasRenderTarget2D:CreateCanvasRenderTarget2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateCanvasRenderTarget2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateCanvasRenderTarget2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateCanvasRenderTarget2D_WorldContextObject_Offset), 0, CreateCanvasRenderTarget2D_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<UCanvasRenderTarget2D>.ToNative(IntPtr.Add(intPtr, CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_Offset), 0, CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_PropertyAddress.Address, CanvasRenderTarget2DClass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateCanvasRenderTarget2D_Width_Offset), 0, CreateCanvasRenderTarget2D_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateCanvasRenderTarget2D_Height_Offset), 0, CreateCanvasRenderTarget2D_Height_PropertyAddress.Address, Height);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateCanvasRenderTarget2D_FunctionAddress, intPtr, CreateCanvasRenderTarget2D_ParamsSize);
		return UObjectMarshaler<UCanvasRenderTarget2D>.FromNative(IntPtr.Add(intPtr, CreateCanvasRenderTarget2D_ReturnValue_Offset), 0, CreateCanvasRenderTarget2D_ReturnValue_PropertyAddress.Address);
	}

	static UCanvasRenderTarget2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCanvasRenderTarget2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCanvasRenderTarget2D));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.CanvasRenderTarget2D");
		OnCanvasRenderTargetUpdate_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnCanvasRenderTargetUpdate");
		OnCanvasRenderTargetUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnCanvasRenderTargetUpdate", Classes.FMulticastDelegateProperty);
		UpdateResource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateResource");
		UpdateResource_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateResource_FunctionAddress);
		UpdateResource_IsValid = UpdateResource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CanvasRenderTarget2D:UpdateResource", UpdateResource_IsValid);
		ReceiveUpdate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceiveUpdate");
		ReceiveUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveUpdate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveUpdate_Canvas_PropertyAddress, ReceiveUpdate_FunctionAddress, "Canvas");
		ReceiveUpdate_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveUpdate_FunctionAddress, "Canvas");
		ReceiveUpdate_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveUpdate_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveUpdate_Width_PropertyAddress, ReceiveUpdate_FunctionAddress, "Width");
		ReceiveUpdate_Width_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveUpdate_FunctionAddress, "Width");
		ReceiveUpdate_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveUpdate_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveUpdate_Height_PropertyAddress, ReceiveUpdate_FunctionAddress, "Height");
		ReceiveUpdate_Height_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveUpdate_FunctionAddress, "Height");
		ReceiveUpdate_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveUpdate_FunctionAddress, "Height", Classes.FIntProperty);
		ReceiveUpdate_IsValid = ReceiveUpdate_FunctionAddress != IntPtr.Zero && ReceiveUpdate_Canvas_IsValid && ReceiveUpdate_Width_IsValid && ReceiveUpdate_Height_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CanvasRenderTarget2D:ReceiveUpdate", ReceiveUpdate_IsValid);
		GetSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSize");
		GetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSize_Width_PropertyAddress, GetSize_FunctionAddress, "Width");
		GetSize_Width_Offset = NativeReflectionCached.GetPropertyOffset(GetSize_FunctionAddress, "Width");
		GetSize_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSize_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSize_Height_PropertyAddress, GetSize_FunctionAddress, "Height");
		GetSize_Height_Offset = NativeReflectionCached.GetPropertyOffset(GetSize_FunctionAddress, "Height");
		GetSize_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSize_FunctionAddress, "Height", Classes.FIntProperty);
		GetSize_IsValid = GetSize_FunctionAddress != IntPtr.Zero && GetSize_Width_IsValid && GetSize_Height_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CanvasRenderTarget2D:GetSize", GetSize_IsValid);
		CreateCanvasRenderTarget2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateCanvasRenderTarget2D");
		CreateCanvasRenderTarget2D_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateCanvasRenderTarget2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateCanvasRenderTarget2D_WorldContextObject_PropertyAddress, CreateCanvasRenderTarget2D_FunctionAddress, "WorldContextObject");
		CreateCanvasRenderTarget2D_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateCanvasRenderTarget2D_FunctionAddress, "WorldContextObject");
		CreateCanvasRenderTarget2D_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCanvasRenderTarget2D_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_PropertyAddress, CreateCanvasRenderTarget2D_FunctionAddress, "CanvasRenderTarget2DClass");
		CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateCanvasRenderTarget2D_FunctionAddress, "CanvasRenderTarget2DClass");
		CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCanvasRenderTarget2D_FunctionAddress, "CanvasRenderTarget2DClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCanvasRenderTarget2D_Width_PropertyAddress, CreateCanvasRenderTarget2D_FunctionAddress, "Width");
		CreateCanvasRenderTarget2D_Width_Offset = NativeReflectionCached.GetPropertyOffset(CreateCanvasRenderTarget2D_FunctionAddress, "Width");
		CreateCanvasRenderTarget2D_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCanvasRenderTarget2D_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCanvasRenderTarget2D_Height_PropertyAddress, CreateCanvasRenderTarget2D_FunctionAddress, "Height");
		CreateCanvasRenderTarget2D_Height_Offset = NativeReflectionCached.GetPropertyOffset(CreateCanvasRenderTarget2D_FunctionAddress, "Height");
		CreateCanvasRenderTarget2D_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCanvasRenderTarget2D_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateCanvasRenderTarget2D_ReturnValue_PropertyAddress, CreateCanvasRenderTarget2D_FunctionAddress, "ReturnValue");
		CreateCanvasRenderTarget2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateCanvasRenderTarget2D_FunctionAddress, "ReturnValue");
		CreateCanvasRenderTarget2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateCanvasRenderTarget2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateCanvasRenderTarget2D_IsValid = CreateCanvasRenderTarget2D_FunctionAddress != IntPtr.Zero && CreateCanvasRenderTarget2D_WorldContextObject_IsValid && CreateCanvasRenderTarget2D_CanvasRenderTarget2DClass_IsValid && CreateCanvasRenderTarget2D_Width_IsValid && CreateCanvasRenderTarget2D_Height_IsValid && CreateCanvasRenderTarget2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CanvasRenderTarget2D:CreateCanvasRenderTarget2D", CreateCanvasRenderTarget2D_IsValid);
	}
}
