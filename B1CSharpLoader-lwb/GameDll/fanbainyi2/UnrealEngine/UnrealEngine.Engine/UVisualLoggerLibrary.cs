using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary", "Engine", UnrealModuleType.Engine)]
public class UVisualLoggerLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RedirectVislog_IsValid;

	private static IntPtr RedirectVislog_FunctionAddress;

	private static int RedirectVislog_ParamsSize;

	private static bool RedirectVislog_SourceOwner_IsValid;

	private static FFieldAddress RedirectVislog_SourceOwner_PropertyAddress;

	private static int RedirectVislog_SourceOwner_Offset;

	private static bool RedirectVislog_DestinationOwner_IsValid;

	private static FFieldAddress RedirectVislog_DestinationOwner_PropertyAddress;

	private static int RedirectVislog_DestinationOwner_Offset;

	private static bool LogText_IsValid;

	private static IntPtr LogText_FunctionAddress;

	private static int LogText_ParamsSize;

	private static bool LogText_WorldContextObject_IsValid;

	private static FFieldAddress LogText_WorldContextObject_PropertyAddress;

	private static int LogText_WorldContextObject_Offset;

	private static bool LogText_Text_IsValid;

	private static FFieldAddress LogText_Text_PropertyAddress;

	private static int LogText_Text_Offset;

	private static bool LogText_LogCategory_IsValid;

	private static FFieldAddress LogText_LogCategory_PropertyAddress;

	private static int LogText_LogCategory_Offset;

	private static bool LogText_bAddToMessageLog_IsValid;

	private static FFieldAddress LogText_bAddToMessageLog_PropertyAddress;

	private static int LogText_bAddToMessageLog_Offset;

	private static bool LogSegment_IsValid;

	private static IntPtr LogSegment_FunctionAddress;

	private static int LogSegment_ParamsSize;

	private static bool LogSegment_WorldContextObject_IsValid;

	private static FFieldAddress LogSegment_WorldContextObject_PropertyAddress;

	private static int LogSegment_WorldContextObject_Offset;

	private static bool LogSegment_SegmentStart_IsValid;

	private static FFieldAddress LogSegment_SegmentStart_PropertyAddress;

	private static int LogSegment_SegmentStart_Offset;

	private static bool LogSegment_SegmentEnd_IsValid;

	private static FFieldAddress LogSegment_SegmentEnd_PropertyAddress;

	private static int LogSegment_SegmentEnd_Offset;

	private static bool LogSegment_Text_IsValid;

	private static FFieldAddress LogSegment_Text_PropertyAddress;

	private static int LogSegment_Text_Offset;

	private static bool LogSegment_ObjectColor_IsValid;

	private static FFieldAddress LogSegment_ObjectColor_PropertyAddress;

	private static int LogSegment_ObjectColor_Offset;

	private static bool LogSegment_Thickness_IsValid;

	private static FFieldAddress LogSegment_Thickness_PropertyAddress;

	private static int LogSegment_Thickness_Offset;

	private static bool LogSegment_CategoryName_IsValid;

	private static FFieldAddress LogSegment_CategoryName_PropertyAddress;

	private static int LogSegment_CategoryName_Offset;

	private static bool LogSegment_bAddToMessageLog_IsValid;

	private static FFieldAddress LogSegment_bAddToMessageLog_PropertyAddress;

	private static int LogSegment_bAddToMessageLog_Offset;

	private static bool LogLocation_IsValid;

	private static IntPtr LogLocation_FunctionAddress;

	private static int LogLocation_ParamsSize;

	private static bool LogLocation_WorldContextObject_IsValid;

	private static FFieldAddress LogLocation_WorldContextObject_PropertyAddress;

	private static int LogLocation_WorldContextObject_Offset;

	private static bool LogLocation_Location_IsValid;

	private static FFieldAddress LogLocation_Location_PropertyAddress;

	private static int LogLocation_Location_Offset;

	private static bool LogLocation_Text_IsValid;

	private static FFieldAddress LogLocation_Text_PropertyAddress;

	private static int LogLocation_Text_Offset;

	private static bool LogLocation_ObjectColor_IsValid;

	private static FFieldAddress LogLocation_ObjectColor_PropertyAddress;

	private static int LogLocation_ObjectColor_Offset;

	private static bool LogLocation_Radius_IsValid;

	private static FFieldAddress LogLocation_Radius_PropertyAddress;

	private static int LogLocation_Radius_Offset;

	private static bool LogLocation_LogCategory_IsValid;

	private static FFieldAddress LogLocation_LogCategory_PropertyAddress;

	private static int LogLocation_LogCategory_Offset;

	private static bool LogLocation_bAddToMessageLog_IsValid;

	private static FFieldAddress LogLocation_bAddToMessageLog_PropertyAddress;

	private static int LogLocation_bAddToMessageLog_Offset;

	private static bool LogBox_IsValid;

	private static IntPtr LogBox_FunctionAddress;

	private static int LogBox_ParamsSize;

	private static bool LogBox_WorldContextObject_IsValid;

	private static FFieldAddress LogBox_WorldContextObject_PropertyAddress;

	private static int LogBox_WorldContextObject_Offset;

	private static bool LogBox_BoxShape_IsValid;

	private static FFieldAddress LogBox_BoxShape_PropertyAddress;

	private static int LogBox_BoxShape_Offset;

	private static bool LogBox_Text_IsValid;

	private static FFieldAddress LogBox_Text_PropertyAddress;

	private static int LogBox_Text_Offset;

	private static bool LogBox_ObjectColor_IsValid;

	private static FFieldAddress LogBox_ObjectColor_PropertyAddress;

	private static int LogBox_ObjectColor_Offset;

	private static bool LogBox_LogCategory_IsValid;

	private static FFieldAddress LogBox_LogCategory_PropertyAddress;

	private static int LogBox_LogCategory_Offset;

	private static bool LogBox_bAddToMessageLog_IsValid;

	private static FFieldAddress LogBox_bAddToMessageLog_PropertyAddress;

	private static int LogBox_bAddToMessageLog_Offset;

	private static bool EnableRecording_IsValid;

	private static IntPtr EnableRecording_FunctionAddress;

	private static int EnableRecording_ParamsSize;

	private static bool EnableRecording_bEnabled_IsValid;

	private static FFieldAddress EnableRecording_bEnabled_PropertyAddress;

	private static int EnableRecording_bEnabled_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary:RedirectVislog")]
	public unsafe static void RedirectVislog(UObject SourceOwner, UObject DestinationOwner)
	{
		if (!RedirectVislog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VisualLoggerKismetLibrary:RedirectVislog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RedirectVislog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RedirectVislog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RedirectVislog_SourceOwner_Offset), 0, RedirectVislog_SourceOwner_PropertyAddress.Address, SourceOwner);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RedirectVislog_DestinationOwner_Offset), 0, RedirectVislog_DestinationOwner_PropertyAddress.Address, DestinationOwner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RedirectVislog_FunctionAddress, intPtr, RedirectVislog_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary:LogText")]
	public unsafe static void LogText(UObject WorldContextObject, string Text, FName LogCategory, bool bAddToMessageLog)
	{
		if (!LogText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VisualLoggerKismetLibrary:LogText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LogText_WorldContextObject_Offset), 0, LogText_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogText_Text_Offset), 0, LogText_Text_PropertyAddress.Address, Text);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, LogText_LogCategory_Offset), 0, LogText_LogCategory_PropertyAddress.Address, LogCategory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogText_bAddToMessageLog_Offset), 0, LogText_bAddToMessageLog_PropertyAddress.Address, bAddToMessageLog);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogText_FunctionAddress, intPtr, LogText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogText_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary:LogSegment")]
	public unsafe static void LogSegment(UObject WorldContextObject, FVector SegmentStart, FVector SegmentEnd, string Text, FLinearColor ObjectColor, float Thickness, FName CategoryName, bool bAddToMessageLog)
	{
		if (!LogSegment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VisualLoggerKismetLibrary:LogSegment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogSegment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogSegment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LogSegment_WorldContextObject_Offset), 0, LogSegment_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LogSegment_SegmentStart_Offset), 0, LogSegment_SegmentStart_PropertyAddress.Address, SegmentStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LogSegment_SegmentEnd_Offset), 0, LogSegment_SegmentEnd_PropertyAddress.Address, SegmentEnd);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogSegment_Text_Offset), 0, LogSegment_Text_PropertyAddress.Address, Text);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, LogSegment_ObjectColor_Offset), 0, LogSegment_ObjectColor_PropertyAddress.Address, ObjectColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LogSegment_Thickness_Offset), 0, LogSegment_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, LogSegment_CategoryName_Offset), 0, LogSegment_CategoryName_PropertyAddress.Address, CategoryName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogSegment_bAddToMessageLog_Offset), 0, LogSegment_bAddToMessageLog_PropertyAddress.Address, bAddToMessageLog);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogSegment_FunctionAddress, intPtr, LogSegment_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogSegment_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary:LogLocation")]
	public unsafe static void LogLocation(UObject WorldContextObject, FVector Location, string Text, FLinearColor ObjectColor, float Radius, FName LogCategory, bool bAddToMessageLog)
	{
		if (!LogLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VisualLoggerKismetLibrary:LogLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LogLocation_WorldContextObject_Offset), 0, LogLocation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LogLocation_Location_Offset), 0, LogLocation_Location_PropertyAddress.Address, Location);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogLocation_Text_Offset), 0, LogLocation_Text_PropertyAddress.Address, Text);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, LogLocation_ObjectColor_Offset), 0, LogLocation_ObjectColor_PropertyAddress.Address, ObjectColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LogLocation_Radius_Offset), 0, LogLocation_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, LogLocation_LogCategory_Offset), 0, LogLocation_LogCategory_PropertyAddress.Address, LogCategory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogLocation_bAddToMessageLog_Offset), 0, LogLocation_bAddToMessageLog_PropertyAddress.Address, bAddToMessageLog);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogLocation_FunctionAddress, intPtr, LogLocation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogLocation_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary:LogBox")]
	public unsafe static void LogBox(UObject WorldContextObject, FBox BoxShape, string Text, FLinearColor ObjectColor, FName LogCategory, bool bAddToMessageLog)
	{
		if (!LogBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VisualLoggerKismetLibrary:LogBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LogBox_WorldContextObject_Offset), 0, LogBox_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, LogBox_BoxShape_Offset), 0, LogBox_BoxShape_PropertyAddress.Address, BoxShape);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogBox_Text_Offset), 0, LogBox_Text_PropertyAddress.Address, Text);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, LogBox_ObjectColor_Offset), 0, LogBox_ObjectColor_PropertyAddress.Address, ObjectColor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, LogBox_LogCategory_Offset), 0, LogBox_LogCategory_PropertyAddress.Address, LogCategory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogBox_bAddToMessageLog_Offset), 0, LogBox_bAddToMessageLog_PropertyAddress.Address, bAddToMessageLog);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogBox_FunctionAddress, intPtr, LogBox_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogBox_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.VisualLoggerKismetLibrary:EnableRecording")]
	public unsafe static void EnableRecording(bool bEnabled)
	{
		if (!EnableRecording_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VisualLoggerKismetLibrary:EnableRecording");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableRecording_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableRecording_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableRecording_bEnabled_Offset), 0, EnableRecording_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableRecording_FunctionAddress, intPtr, EnableRecording_ParamsSize);
	}

	static UVisualLoggerLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVisualLoggerLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVisualLoggerLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.VisualLoggerKismetLibrary");
		RedirectVislog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RedirectVislog");
		RedirectVislog_ParamsSize = NativeReflection.GetFunctionParamsSize(RedirectVislog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RedirectVislog_SourceOwner_PropertyAddress, RedirectVislog_FunctionAddress, "SourceOwner");
		RedirectVislog_SourceOwner_Offset = NativeReflectionCached.GetPropertyOffset(RedirectVislog_FunctionAddress, "SourceOwner");
		RedirectVislog_SourceOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(RedirectVislog_FunctionAddress, "SourceOwner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RedirectVislog_DestinationOwner_PropertyAddress, RedirectVislog_FunctionAddress, "DestinationOwner");
		RedirectVislog_DestinationOwner_Offset = NativeReflectionCached.GetPropertyOffset(RedirectVislog_FunctionAddress, "DestinationOwner");
		RedirectVislog_DestinationOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(RedirectVislog_FunctionAddress, "DestinationOwner", Classes.FObjectProperty);
		RedirectVislog_IsValid = RedirectVislog_FunctionAddress != IntPtr.Zero && RedirectVislog_SourceOwner_IsValid && RedirectVislog_DestinationOwner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VisualLoggerKismetLibrary:RedirectVislog", RedirectVislog_IsValid);
		LogText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogText");
		LogText_ParamsSize = NativeReflection.GetFunctionParamsSize(LogText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogText_WorldContextObject_PropertyAddress, LogText_FunctionAddress, "WorldContextObject");
		LogText_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LogText_FunctionAddress, "WorldContextObject");
		LogText_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LogText_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LogText_Text_PropertyAddress, LogText_FunctionAddress, "Text");
		LogText_Text_Offset = NativeReflectionCached.GetPropertyOffset(LogText_FunctionAddress, "Text");
		LogText_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(LogText_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogText_LogCategory_PropertyAddress, LogText_FunctionAddress, "LogCategory");
		LogText_LogCategory_Offset = NativeReflectionCached.GetPropertyOffset(LogText_FunctionAddress, "LogCategory");
		LogText_LogCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(LogText_FunctionAddress, "LogCategory", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LogText_bAddToMessageLog_PropertyAddress, LogText_FunctionAddress, "bAddToMessageLog");
		LogText_bAddToMessageLog_Offset = NativeReflectionCached.GetPropertyOffset(LogText_FunctionAddress, "bAddToMessageLog");
		LogText_bAddToMessageLog_IsValid = NativeReflectionCached.ValidatePropertyClass(LogText_FunctionAddress, "bAddToMessageLog", Classes.FBoolProperty);
		LogText_IsValid = LogText_FunctionAddress != IntPtr.Zero && LogText_WorldContextObject_IsValid && LogText_Text_IsValid && LogText_LogCategory_IsValid && LogText_bAddToMessageLog_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VisualLoggerKismetLibrary:LogText", LogText_IsValid);
		LogSegment_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogSegment");
		LogSegment_ParamsSize = NativeReflection.GetFunctionParamsSize(LogSegment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_WorldContextObject_PropertyAddress, LogSegment_FunctionAddress, "WorldContextObject");
		LogSegment_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "WorldContextObject");
		LogSegment_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_SegmentStart_PropertyAddress, LogSegment_FunctionAddress, "SegmentStart");
		LogSegment_SegmentStart_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "SegmentStart");
		LogSegment_SegmentStart_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "SegmentStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_SegmentEnd_PropertyAddress, LogSegment_FunctionAddress, "SegmentEnd");
		LogSegment_SegmentEnd_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "SegmentEnd");
		LogSegment_SegmentEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "SegmentEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_Text_PropertyAddress, LogSegment_FunctionAddress, "Text");
		LogSegment_Text_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "Text");
		LogSegment_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_ObjectColor_PropertyAddress, LogSegment_FunctionAddress, "ObjectColor");
		LogSegment_ObjectColor_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "ObjectColor");
		LogSegment_ObjectColor_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "ObjectColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_Thickness_PropertyAddress, LogSegment_FunctionAddress, "Thickness");
		LogSegment_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "Thickness");
		LogSegment_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_CategoryName_PropertyAddress, LogSegment_FunctionAddress, "CategoryName");
		LogSegment_CategoryName_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "CategoryName");
		LogSegment_CategoryName_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "CategoryName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LogSegment_bAddToMessageLog_PropertyAddress, LogSegment_FunctionAddress, "bAddToMessageLog");
		LogSegment_bAddToMessageLog_Offset = NativeReflectionCached.GetPropertyOffset(LogSegment_FunctionAddress, "bAddToMessageLog");
		LogSegment_bAddToMessageLog_IsValid = NativeReflectionCached.ValidatePropertyClass(LogSegment_FunctionAddress, "bAddToMessageLog", Classes.FBoolProperty);
		LogSegment_IsValid = LogSegment_FunctionAddress != IntPtr.Zero && LogSegment_WorldContextObject_IsValid && LogSegment_SegmentStart_IsValid && LogSegment_SegmentEnd_IsValid && LogSegment_Text_IsValid && LogSegment_ObjectColor_IsValid && LogSegment_Thickness_IsValid && LogSegment_CategoryName_IsValid && LogSegment_bAddToMessageLog_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VisualLoggerKismetLibrary:LogSegment", LogSegment_IsValid);
		LogLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogLocation");
		LogLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(LogLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_WorldContextObject_PropertyAddress, LogLocation_FunctionAddress, "WorldContextObject");
		LogLocation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "WorldContextObject");
		LogLocation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_Location_PropertyAddress, LogLocation_FunctionAddress, "Location");
		LogLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "Location");
		LogLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_Text_PropertyAddress, LogLocation_FunctionAddress, "Text");
		LogLocation_Text_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "Text");
		LogLocation_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_ObjectColor_PropertyAddress, LogLocation_FunctionAddress, "ObjectColor");
		LogLocation_ObjectColor_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "ObjectColor");
		LogLocation_ObjectColor_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "ObjectColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_Radius_PropertyAddress, LogLocation_FunctionAddress, "Radius");
		LogLocation_Radius_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "Radius");
		LogLocation_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_LogCategory_PropertyAddress, LogLocation_FunctionAddress, "LogCategory");
		LogLocation_LogCategory_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "LogCategory");
		LogLocation_LogCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "LogCategory", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LogLocation_bAddToMessageLog_PropertyAddress, LogLocation_FunctionAddress, "bAddToMessageLog");
		LogLocation_bAddToMessageLog_Offset = NativeReflectionCached.GetPropertyOffset(LogLocation_FunctionAddress, "bAddToMessageLog");
		LogLocation_bAddToMessageLog_IsValid = NativeReflectionCached.ValidatePropertyClass(LogLocation_FunctionAddress, "bAddToMessageLog", Classes.FBoolProperty);
		LogLocation_IsValid = LogLocation_FunctionAddress != IntPtr.Zero && LogLocation_WorldContextObject_IsValid && LogLocation_Location_IsValid && LogLocation_Text_IsValid && LogLocation_ObjectColor_IsValid && LogLocation_Radius_IsValid && LogLocation_LogCategory_IsValid && LogLocation_bAddToMessageLog_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VisualLoggerKismetLibrary:LogLocation", LogLocation_IsValid);
		LogBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogBox");
		LogBox_ParamsSize = NativeReflection.GetFunctionParamsSize(LogBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogBox_WorldContextObject_PropertyAddress, LogBox_FunctionAddress, "WorldContextObject");
		LogBox_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LogBox_FunctionAddress, "WorldContextObject");
		LogBox_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LogBox_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LogBox_BoxShape_PropertyAddress, LogBox_FunctionAddress, "BoxShape");
		LogBox_BoxShape_Offset = NativeReflectionCached.GetPropertyOffset(LogBox_FunctionAddress, "BoxShape");
		LogBox_BoxShape_IsValid = NativeReflectionCached.ValidatePropertyClass(LogBox_FunctionAddress, "BoxShape", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogBox_Text_PropertyAddress, LogBox_FunctionAddress, "Text");
		LogBox_Text_Offset = NativeReflectionCached.GetPropertyOffset(LogBox_FunctionAddress, "Text");
		LogBox_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(LogBox_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogBox_ObjectColor_PropertyAddress, LogBox_FunctionAddress, "ObjectColor");
		LogBox_ObjectColor_Offset = NativeReflectionCached.GetPropertyOffset(LogBox_FunctionAddress, "ObjectColor");
		LogBox_ObjectColor_IsValid = NativeReflectionCached.ValidatePropertyClass(LogBox_FunctionAddress, "ObjectColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogBox_LogCategory_PropertyAddress, LogBox_FunctionAddress, "LogCategory");
		LogBox_LogCategory_Offset = NativeReflectionCached.GetPropertyOffset(LogBox_FunctionAddress, "LogCategory");
		LogBox_LogCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(LogBox_FunctionAddress, "LogCategory", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LogBox_bAddToMessageLog_PropertyAddress, LogBox_FunctionAddress, "bAddToMessageLog");
		LogBox_bAddToMessageLog_Offset = NativeReflectionCached.GetPropertyOffset(LogBox_FunctionAddress, "bAddToMessageLog");
		LogBox_bAddToMessageLog_IsValid = NativeReflectionCached.ValidatePropertyClass(LogBox_FunctionAddress, "bAddToMessageLog", Classes.FBoolProperty);
		LogBox_IsValid = LogBox_FunctionAddress != IntPtr.Zero && LogBox_WorldContextObject_IsValid && LogBox_BoxShape_IsValid && LogBox_Text_IsValid && LogBox_ObjectColor_IsValid && LogBox_LogCategory_IsValid && LogBox_bAddToMessageLog_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VisualLoggerKismetLibrary:LogBox", LogBox_IsValid);
		EnableRecording_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableRecording");
		EnableRecording_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableRecording_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableRecording_bEnabled_PropertyAddress, EnableRecording_FunctionAddress, "bEnabled");
		EnableRecording_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(EnableRecording_FunctionAddress, "bEnabled");
		EnableRecording_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableRecording_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		EnableRecording_IsValid = EnableRecording_FunctionAddress != IntPtr.Zero && EnableRecording_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VisualLoggerKismetLibrary:EnableRecording", EnableRecording_IsValid);
	}
}
