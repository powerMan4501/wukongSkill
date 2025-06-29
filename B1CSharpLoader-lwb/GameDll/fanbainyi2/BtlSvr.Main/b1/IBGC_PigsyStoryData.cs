namespace b1;

public interface IBGC_PigsyStoryData
{
	int CurrentLevelID { get; }

	int CurrentAreaID { get; }

	int AiConversationStartID { get; }

	int LastAiConversationID { get; }

	EStoryConversationType StoryConversationType { get; }

	BindListInt FinishedStoryMemory { get; }

	bool IsSuccess_LastReqPlayStory();

	bool IsPlayingStory();

	bool IsPlayingResumeStory();

	bool HasStoryCanTalk_CurArea();
}
