using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDebugMessage", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptDebugMessage
{
	private static bool MessageType_IsValid;

	private static FFieldAddress MessageType_PropertyAddress;

	private static int MessageType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDebugMessage:MessageType")]
	public EGeometryScriptDebugMessageType MessageType;

	private static bool ErrorType_IsValid;

	private static FFieldAddress ErrorType_PropertyAddress;

	private static int ErrorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDebugMessage:ErrorType")]
	public EGeometryScriptErrorType ErrorType;

	private static bool Message_IsValid;

	private static int Message_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptDebugMessage:Message")]
	public FText Message;

	private static bool FGeometryScriptDebugMessage_IsValid;

	private static int FGeometryScriptDebugMessage_StructSize;

	public FGeometryScriptDebugMessage Copy()
	{
		return this;
	}

	public static FGeometryScriptDebugMessage FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptDebugMessage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptDebugMessage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptDebugMessage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptDebugMessage(nativeBuffer + arrayIndex * FGeometryScriptDebugMessage_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptDebugMessage value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptDebugMessage_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptDebugMessage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptDebugMessage");
			return;
		}
		EnumMarshaler<EGeometryScriptDebugMessageType>.ToNative(IntPtr.Add(nativeStruct, MessageType_Offset), 0, MessageType_PropertyAddress.Address, MessageType);
		EnumMarshaler<EGeometryScriptErrorType>.ToNative(IntPtr.Add(nativeStruct, ErrorType_Offset), 0, ErrorType_PropertyAddress.Address, ErrorType);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Message_Offset), Message);
	}

	public FGeometryScriptDebugMessage(IntPtr nativeStruct)
	{
		if (!FGeometryScriptDebugMessage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptDebugMessage");
			MessageType = EGeometryScriptDebugMessageType.ErrorMessage;
			ErrorType = EGeometryScriptErrorType.NoError;
			Message = null;
		}
		else
		{
			MessageType = EnumMarshaler<EGeometryScriptDebugMessageType>.FromNative(IntPtr.Add(nativeStruct, MessageType_Offset), 0, MessageType_PropertyAddress.Address);
			ErrorType = EnumMarshaler<EGeometryScriptErrorType>.FromNative(IntPtr.Add(nativeStruct, ErrorType_Offset), 0, ErrorType_PropertyAddress.Address);
			Message = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Message_Offset));
		}
	}

	static FGeometryScriptDebugMessage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptDebugMessage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptDebugMessage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptDebugMessage");
		FGeometryScriptDebugMessage_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MessageType_PropertyAddress, intPtr, "MessageType");
		MessageType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MessageType");
		MessageType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MessageType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ErrorType_PropertyAddress, intPtr, "ErrorType");
		ErrorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ErrorType");
		ErrorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ErrorType", Classes.FEnumProperty);
		Message_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Message");
		Message_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Message", Classes.FTextProperty);
		FGeometryScriptDebugMessage_IsValid = intPtr != IntPtr.Zero && MessageType_IsValid && ErrorType_IsValid && Message_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptDebugMessage", FGeometryScriptDebugMessage_IsValid);
	}
}
