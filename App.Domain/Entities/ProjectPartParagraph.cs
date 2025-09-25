using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain
{
    public class ProjectPartParagraph
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int GroupCount { get; set; }

        [Required]
        public string GroupKey { get; set; }

        [Required]
        public bool IsParagraph { get; set; }

        [Required]
        public int ParagraphIndex { get; set; }

        [Required]
        public int ParagraphLenght { get; set; }

        [Required]
        public string ParagraphText { get; set; }

        public bool CheckSceneHeader { get; set; }

        public bool CheckSceneNo { get; set; }

        public bool CheckSceneTime { get; set; }

        public bool CheckSceneLocation { get; set; }

        public bool CheckSceneTransition { get; set; }

        public bool CheckSceneCharacterList { get; set; }

        public bool CheckSceneCharacterFormat { get; set; }

        public bool CheckSceneCharacterMergedFormat { get; set; }

        public bool CheckSceneDialog { get; set; }

        public bool CheckSceneScenario { get; set; }

        public double PageWidth { get; set; }

        public double PageHeight { get; set; }

        public int? Alignment { get; set; }

        public bool RightToLeft { get; set; }

        public double LeftMargin { get; set; }

        public double LeftIndentation { get; set; }

        public double ParagraphStartPoint { get; set; }

        public double SpecialIndentation { get; set; }

        public double ParagraphEndPoint { get; set; }

        public double RightIndentation { get; set; }

        public double RightMargin { get; set; }

        public int ParagraphStartPointBlock { get; set; }

        public int ParagraphEndPointBlock { get; set; }

        public bool IsBoldParagraph { get; set; }

        public bool IsItalicParagraph { get; set; }

        public string? HighlightColor { get; set; }

        public string? UnderlineStyle { get; set; }

        public string? FontColor { get; set; }

        public string? FontName { get; set; }

        public double FontSize { get; set; }

        public int? SimilarSceneHeaderFormatCount { get; set; }

        public int? SimilarTransitionFormatCount { get; set; }

        public int? SimilarScenarioFormatCount { get; set; }

        public int? SimilarCharacterFormatCount { get; set; }

        public int? SimilarDialogFormatCount { get; set; }

        public int? SceneParagraphTypeId { get; set; }

        public int? NextSceneParagraphTypeId { get; set; }

        public int? PreviousSceneParagraphTypeId { get; set; }

        [Required]
        public virtual int ProjectPartId { get; set; }

        [Required]
        [ForeignKey("ProjectPartId")]
        public virtual ProjectPart ProjectPart { get; set; }
    }
}
