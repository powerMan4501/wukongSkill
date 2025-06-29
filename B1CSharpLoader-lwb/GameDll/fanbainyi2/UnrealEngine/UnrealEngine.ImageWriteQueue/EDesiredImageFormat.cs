using UnrealEngine.Runtime;

namespace UnrealEngine.ImageWriteQueue;

[UEnum]
[UMetaPath("/Script/ImageWriteQueue.EDesiredImageFormat", "ImageWriteQueue", UnrealModuleType.Engine)]
public enum EDesiredImageFormat
{
	PNG,
	JPG,
	BMP,
	EXR
}
