using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyChapterStageList : ReadOnlyPrimitiveList<ChapterStage>
{
	public ReadOnlyChapterStageList(RepeatedField<ChapterStage> pbData)
		: base(pbData)
	{
	}
}
