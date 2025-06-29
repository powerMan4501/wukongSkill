using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.ImageWriteQueue;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[Abstract]
[UClass(Flags = (ClassFlags)810550437uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol", "MovieSceneCapture", UnrealModuleType.Engine)]
public class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol
{
	private static bool Format_IsValid;

	private static FFieldAddress Format_PropertyAddress;

	private static int Format_Offset;

	private static bool EnableCompression_IsValid;

	private static FFieldAddress EnableCompression_PropertyAddress;

	private static int EnableCompression_Offset;

	private static bool CompressionQuality_IsValid;

	private static int CompressionQuality_Offset;

	private static bool WriteImageToDisk_IsValid;

	private static IntPtr WriteImageToDisk_FunctionAddress;

	private static int WriteImageToDisk_ParamsSize;

	private static bool WriteImageToDisk_PixelData_IsValid;

	private static FFieldAddress WriteImageToDisk_PixelData_PropertyAddress;

	private static int WriteImageToDisk_PixelData_Offset;

	private static bool WriteImageToDisk_StreamID_IsValid;

	private static FFieldAddress WriteImageToDisk_StreamID_PropertyAddress;

	private static int WriteImageToDisk_StreamID_Offset;

	private static bool WriteImageToDisk_FrameMetrics_IsValid;

	private static FFieldAddress WriteImageToDisk_FrameMetrics_PropertyAddress;

	private static int WriteImageToDisk_FrameMetrics_Offset;

	private static bool WriteImageToDisk_bCopyImageData_IsValid;

	private static FFieldAddress WriteImageToDisk_bCopyImageData_PropertyAddress;

	private static int WriteImageToDisk_bCopyImageData_Offset;

	private static bool GenerateFilenameForCurrentFrame_IsValid;

	private static IntPtr GenerateFilenameForCurrentFrame_FunctionAddress;

	private static int GenerateFilenameForCurrentFrame_ParamsSize;

	private static bool GenerateFilenameForCurrentFrame_ReturnValue_IsValid;

	private static FFieldAddress GenerateFilenameForCurrentFrame_ReturnValue_PropertyAddress;

	private static int GenerateFilenameForCurrentFrame_ReturnValue_Offset;

	private static bool GenerateFilenameForBuffer_IsValid;

	private static IntPtr GenerateFilenameForBuffer_FunctionAddress;

	private static int GenerateFilenameForBuffer_ParamsSize;

	private static bool GenerateFilenameForBuffer_Buffer_IsValid;

	private static FFieldAddress GenerateFilenameForBuffer_Buffer_PropertyAddress;

	private static int GenerateFilenameForBuffer_Buffer_Offset;

	private static bool GenerateFilenameForBuffer_StreamID_IsValid;

	private static FFieldAddress GenerateFilenameForBuffer_StreamID_PropertyAddress;

	private static int GenerateFilenameForBuffer_StreamID_Offset;

	private static bool GenerateFilenameForBuffer_ReturnValue_IsValid;

	private static FFieldAddress GenerateFilenameForBuffer_ReturnValue_PropertyAddress;

	private static int GenerateFilenameForBuffer_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:Format")]
	public EDesiredImageFormat Format
	{
		get
		{
			CheckDestroyed();
			if (!Format_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:Format");
				return EDesiredImageFormat.PNG;
			}
			return EnumMarshaler<EDesiredImageFormat>.FromNative(IntPtr.Add(base.Address, Format_Offset), 0, Format_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Format_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:Format");
			}
			else
			{
				EnumMarshaler<EDesiredImageFormat>.ToNative(IntPtr.Add(base.Address, Format_Offset), 0, Format_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:bEnableCompression")]
	public bool EnableCompression
	{
		get
		{
			CheckDestroyed();
			if (!EnableCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:bEnableCompression");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableCompression_Offset), 0, EnableCompression_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:bEnableCompression");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableCompression_Offset), 0, EnableCompression_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:CompressionQuality")]
	public int CompressionQuality
	{
		get
		{
			CheckDestroyed();
			if (!CompressionQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:CompressionQuality");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CompressionQuality_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompressionQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:CompressionQuality");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CompressionQuality_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:WriteImageToDisk")]
	public unsafe void WriteImageToDisk(FCapturedPixels PixelData, FCapturedPixelsID StreamID, FFrameMetrics FrameMetrics, bool bCopyImageData = false)
	{
		CheckDestroyed();
		if (!WriteImageToDisk_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:WriteImageToDisk");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteImageToDisk_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteImageToDisk_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(WriteImageToDisk_PixelData_PropertyAddress.Address, intPtr);
		FCapturedPixels.ToNative(IntPtr.Add(intPtr, WriteImageToDisk_PixelData_Offset), 0, WriteImageToDisk_PixelData_PropertyAddress.Address, PixelData);
		NativeReflection.InitializeValue_InContainer(WriteImageToDisk_StreamID_PropertyAddress.Address, intPtr);
		FCapturedPixelsID.ToNative(IntPtr.Add(intPtr, WriteImageToDisk_StreamID_Offset), 0, WriteImageToDisk_StreamID_PropertyAddress.Address, StreamID);
		NativeReflection.InitializeValue_InContainer(WriteImageToDisk_FrameMetrics_PropertyAddress.Address, intPtr);
		FFrameMetrics.ToNative(IntPtr.Add(intPtr, WriteImageToDisk_FrameMetrics_Offset), 0, WriteImageToDisk_FrameMetrics_PropertyAddress.Address, FrameMetrics);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, WriteImageToDisk_bCopyImageData_Offset), 0, WriteImageToDisk_bCopyImageData_PropertyAddress.Address, bCopyImageData);
		NativeReflection.InvokeFunctionOptimized(base.Address, WriteImageToDisk_FunctionAddress, intPtr, WriteImageToDisk_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteImageToDisk_PixelData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(WriteImageToDisk_StreamID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:GenerateFilenameForCurrentFrame")]
	public unsafe string GenerateFilenameForCurrentFrame()
	{
		CheckDestroyed();
		if (!GenerateFilenameForCurrentFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:GenerateFilenameForCurrentFrame");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateFilenameForCurrentFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateFilenameForCurrentFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateFilenameForCurrentFrame_FunctionAddress, intPtr, GenerateFilenameForCurrentFrame_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GenerateFilenameForCurrentFrame_ReturnValue_Offset), 0, GenerateFilenameForCurrentFrame_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GenerateFilenameForCurrentFrame_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:GenerateFilenameForBuffer")]
	public unsafe string GenerateFilenameForBuffer(UTexture Buffer, FCapturedPixelsID StreamID)
	{
		CheckDestroyed();
		if (!GenerateFilenameForBuffer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:GenerateFilenameForBuffer");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateFilenameForBuffer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateFilenameForBuffer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, GenerateFilenameForBuffer_Buffer_Offset), 0, GenerateFilenameForBuffer_Buffer_PropertyAddress.Address, Buffer);
		NativeReflection.InitializeValue_InContainer(GenerateFilenameForBuffer_StreamID_PropertyAddress.Address, intPtr);
		FCapturedPixelsID.ToNative(IntPtr.Add(intPtr, GenerateFilenameForBuffer_StreamID_Offset), 0, GenerateFilenameForBuffer_StreamID_PropertyAddress.Address, StreamID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateFilenameForBuffer_FunctionAddress, intPtr, GenerateFilenameForBuffer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenerateFilenameForBuffer_StreamID_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GenerateFilenameForBuffer_ReturnValue_Offset), 0, GenerateFilenameForBuffer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GenerateFilenameForBuffer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UUserDefinedImageCaptureProtocol()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUserDefinedImageCaptureProtocol)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUserDefinedImageCaptureProtocol));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol");
		NativeReflectionCached.GetPropertyRef(ref Format_PropertyAddress, intPtr, "Format");
		Format_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Format");
		Format_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Format", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCompression_PropertyAddress, intPtr, "bEnableCompression");
		EnableCompression_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCompression");
		EnableCompression_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCompression", Classes.FBoolProperty);
		CompressionQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompressionQuality");
		CompressionQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompressionQuality", Classes.FIntProperty);
		WriteImageToDisk_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WriteImageToDisk");
		WriteImageToDisk_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteImageToDisk_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteImageToDisk_PixelData_PropertyAddress, WriteImageToDisk_FunctionAddress, "PixelData");
		WriteImageToDisk_PixelData_Offset = NativeReflectionCached.GetPropertyOffset(WriteImageToDisk_FunctionAddress, "PixelData");
		WriteImageToDisk_PixelData_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteImageToDisk_FunctionAddress, "PixelData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteImageToDisk_StreamID_PropertyAddress, WriteImageToDisk_FunctionAddress, "StreamID");
		WriteImageToDisk_StreamID_Offset = NativeReflectionCached.GetPropertyOffset(WriteImageToDisk_FunctionAddress, "StreamID");
		WriteImageToDisk_StreamID_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteImageToDisk_FunctionAddress, "StreamID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteImageToDisk_FrameMetrics_PropertyAddress, WriteImageToDisk_FunctionAddress, "FrameMetrics");
		WriteImageToDisk_FrameMetrics_Offset = NativeReflectionCached.GetPropertyOffset(WriteImageToDisk_FunctionAddress, "FrameMetrics");
		WriteImageToDisk_FrameMetrics_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteImageToDisk_FunctionAddress, "FrameMetrics", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteImageToDisk_bCopyImageData_PropertyAddress, WriteImageToDisk_FunctionAddress, "bCopyImageData");
		WriteImageToDisk_bCopyImageData_Offset = NativeReflectionCached.GetPropertyOffset(WriteImageToDisk_FunctionAddress, "bCopyImageData");
		WriteImageToDisk_bCopyImageData_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteImageToDisk_FunctionAddress, "bCopyImageData", Classes.FBoolProperty);
		WriteImageToDisk_IsValid = WriteImageToDisk_FunctionAddress != IntPtr.Zero && WriteImageToDisk_PixelData_IsValid && WriteImageToDisk_StreamID_IsValid && WriteImageToDisk_FrameMetrics_IsValid && WriteImageToDisk_bCopyImageData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:WriteImageToDisk", WriteImageToDisk_IsValid);
		GenerateFilenameForCurrentFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateFilenameForCurrentFrame");
		GenerateFilenameForCurrentFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateFilenameForCurrentFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateFilenameForCurrentFrame_ReturnValue_PropertyAddress, GenerateFilenameForCurrentFrame_FunctionAddress, "ReturnValue");
		GenerateFilenameForCurrentFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateFilenameForCurrentFrame_FunctionAddress, "ReturnValue");
		GenerateFilenameForCurrentFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateFilenameForCurrentFrame_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GenerateFilenameForCurrentFrame_IsValid = GenerateFilenameForCurrentFrame_FunctionAddress != IntPtr.Zero && GenerateFilenameForCurrentFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:GenerateFilenameForCurrentFrame", GenerateFilenameForCurrentFrame_IsValid);
		GenerateFilenameForBuffer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateFilenameForBuffer");
		GenerateFilenameForBuffer_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateFilenameForBuffer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateFilenameForBuffer_Buffer_PropertyAddress, GenerateFilenameForBuffer_FunctionAddress, "Buffer");
		GenerateFilenameForBuffer_Buffer_Offset = NativeReflectionCached.GetPropertyOffset(GenerateFilenameForBuffer_FunctionAddress, "Buffer");
		GenerateFilenameForBuffer_Buffer_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateFilenameForBuffer_FunctionAddress, "Buffer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateFilenameForBuffer_StreamID_PropertyAddress, GenerateFilenameForBuffer_FunctionAddress, "StreamID");
		GenerateFilenameForBuffer_StreamID_Offset = NativeReflectionCached.GetPropertyOffset(GenerateFilenameForBuffer_FunctionAddress, "StreamID");
		GenerateFilenameForBuffer_StreamID_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateFilenameForBuffer_FunctionAddress, "StreamID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateFilenameForBuffer_ReturnValue_PropertyAddress, GenerateFilenameForBuffer_FunctionAddress, "ReturnValue");
		GenerateFilenameForBuffer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateFilenameForBuffer_FunctionAddress, "ReturnValue");
		GenerateFilenameForBuffer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateFilenameForBuffer_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GenerateFilenameForBuffer_IsValid = GenerateFilenameForBuffer_FunctionAddress != IntPtr.Zero && GenerateFilenameForBuffer_Buffer_IsValid && GenerateFilenameForBuffer_StreamID_IsValid && GenerateFilenameForBuffer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol:GenerateFilenameForBuffer", GenerateFilenameForBuffer_IsValid);
	}
}
