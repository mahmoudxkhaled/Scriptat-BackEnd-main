namespace App.Domain
{
    public class GeneralEnum
    {

    }
    public enum CharacterTypeEnum
    {
        Main,
        Alias,
        Mixed,
    }
    public enum ComponentTypeEnum
    {
        Character = 1,
        Location = 2,
        Other = 3,
    }
    public enum ElementLinkTypeEnum
    {
        Alias = 1,
        Nested = 2,
        Candidate = 3,
        Linked = 4,
    }
    public enum LocationSideEnum
    {
        Inside,
        Outside,
        InOutSide,
    }
    public enum LocationTypeEnum
    {
        Main,
        Alias,
        Nested,
        Mixed,
    }
    public enum ProjectExtractionTypeEnum
    {
        Character = 1,
        Location = 2,
        Component = 3,
    }
    public enum ProjectTypeEnum
    {
        Film = 1,
        Series = 2,
        VideoClip = 3,
        Advertise = 4,
    }
    public enum SceneParagraphTypeEnum
    {
        Scenario = 1,
        Character = 2,
        Dialog = 3,
        Location = 4,
        Paragraph = 5,
        SceneNoText = 6,
        TimeModeText = 7,
        SceneHeader = 8,
        Transition = 9,
    }
    public enum SceneTimeEnum
    {
        Morning,
        Night,
        MorningNight,
    }
    public enum ScriptTypeEnum
    {
        AmericanScript = 1,
        TabularScript = 2,
        FrenchScript = 3,
    }
    public enum TransitionTypeEnum
    {
        Cut = 1,
        Mixing = 2,
        FadeIn = 3,
        Transition = 4,
        Dark = 5,
    }

}
