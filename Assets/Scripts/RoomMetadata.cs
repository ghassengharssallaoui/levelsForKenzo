using UnityEngine;

public enum TemplateRoomType
{
    Indoor,
    Outdoor
}

public enum TemplateDifficulty
{
    Easy,
    Hard
}

public enum TemplateDoorCount
{
    TwoHorizontal,
    TwoVertical,
    ThreeUp,
    ThreeDown,
    Four
}

public class RoomMetadata : MonoBehaviour
{
    public string TemplateId;
    public TemplateRoomType roomType;
    public TemplateDifficulty difficulty;
    public TemplateDoorCount doorCount;
}
