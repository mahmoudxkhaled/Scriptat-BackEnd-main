using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scriptat.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialScriptatEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SceneParagraphType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowedForUser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneParagraphType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScriptType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstructionImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransitionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransitionValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransitionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSummaryFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPartCount = table.Column<int>(type: "int", nullable: false),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_ProjectType_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalTable: "ProjectType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComponentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsProjectElementLinkAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsProjectLocationLinkAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsProjectCharacterLinkAllowed = table.Column<bool>(type: "bit", nullable: false),
                    ElementCountALlowed = table.Column<bool>(type: "bit", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentType_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectPart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNo = table.Column<int>(type: "int", nullable: false),
                    ProjectPartTitle = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    ProjectPartSummary = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    ProjectPartSummaryFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPartIntroduction = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    ProjectPartFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPartPageCount = table.Column<int>(type: "int", nullable: true),
                    ProjectPartWordCount = table.Column<int>(type: "int", nullable: true),
                    ProjectPartSceneCount = table.Column<int>(type: "int", nullable: true),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ScriptTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPart_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectPart_ScriptType_ScriptTypeId",
                        column: x => x.ScriptTypeId,
                        principalTable: "ScriptType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentTypeLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComponentTypeId = table.Column<int>(type: "int", nullable: false),
                    LinkedComponentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTypeLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentTypeLink_ComponentType_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectElement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElementDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApprove = table.Column<bool>(type: "bit", nullable: false),
                    ApproveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ComponentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectElement_ComponentType_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectElement_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPartParagraph",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCount = table.Column<int>(type: "int", nullable: false),
                    GroupKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsParagraph = table.Column<bool>(type: "bit", nullable: false),
                    ParagraphIndex = table.Column<int>(type: "int", nullable: false),
                    ParagraphLenght = table.Column<int>(type: "int", nullable: false),
                    ParagraphText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckSceneHeader = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneNo = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneTime = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneLocation = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneTransition = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneCharacterList = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneCharacterFormat = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneCharacterMergedFormat = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneDialog = table.Column<bool>(type: "bit", nullable: false),
                    CheckSceneScenario = table.Column<bool>(type: "bit", nullable: false),
                    PageWidth = table.Column<double>(type: "float", nullable: false),
                    PageHeight = table.Column<double>(type: "float", nullable: false),
                    Alignment = table.Column<int>(type: "int", nullable: true),
                    RightToLeft = table.Column<bool>(type: "bit", nullable: false),
                    LeftMargin = table.Column<double>(type: "float", nullable: false),
                    LeftIndentation = table.Column<double>(type: "float", nullable: false),
                    ParagraphStartPoint = table.Column<double>(type: "float", nullable: false),
                    SpecialIndentation = table.Column<double>(type: "float", nullable: false),
                    ParagraphEndPoint = table.Column<double>(type: "float", nullable: false),
                    RightIndentation = table.Column<double>(type: "float", nullable: false),
                    RightMargin = table.Column<double>(type: "float", nullable: false),
                    ParagraphStartPointBlock = table.Column<int>(type: "int", nullable: false),
                    ParagraphEndPointBlock = table.Column<int>(type: "int", nullable: false),
                    IsBoldParagraph = table.Column<bool>(type: "bit", nullable: false),
                    IsItalicParagraph = table.Column<bool>(type: "bit", nullable: false),
                    HighlightColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnderlineStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontSize = table.Column<double>(type: "float", nullable: false),
                    SimilarSceneHeaderFormatCount = table.Column<int>(type: "int", nullable: true),
                    SimilarTransitionFormatCount = table.Column<int>(type: "int", nullable: true),
                    SimilarScenarioFormatCount = table.Column<int>(type: "int", nullable: true),
                    SimilarCharacterFormatCount = table.Column<int>(type: "int", nullable: true),
                    SimilarDialogFormatCount = table.Column<int>(type: "int", nullable: true),
                    SceneParagraphTypeId = table.Column<int>(type: "int", nullable: true),
                    NextSceneParagraphTypeId = table.Column<int>(type: "int", nullable: true),
                    PreviousSceneParagraphTypeId = table.Column<int>(type: "int", nullable: true),
                    ProjectPartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPartParagraph", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPartParagraph_ProjectPart_ProjectPartId",
                        column: x => x.ProjectPartId,
                        principalTable: "ProjectPart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scene",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    SceneNo = table.Column<int>(type: "int", nullable: false),
                    SceneNoText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SceneDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneTime = table.Column<int>(type: "int", nullable: true),
                    LocationType = table.Column<int>(type: "int", nullable: true),
                    SceneTimeText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneTransitionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneTransitionTypeText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingParagraphIndex = table.Column<int>(type: "int", nullable: false),
                    EndingParagraphIndex = table.Column<int>(type: "int", nullable: false),
                    SceneBreakdownStartUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneBreakdownStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SceneBreakdownEndUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneBreakdownEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransitionTypeId = table.Column<int>(type: "int", nullable: true),
                    ProjectPartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scene", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scene_ProjectPart_ProjectPartId",
                        column: x => x.ProjectPartId,
                        principalTable: "ProjectPart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scene_TransitionType_TransitionTypeId",
                        column: x => x.TransitionTypeId,
                        principalTable: "TransitionType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectElementImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElementImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectElementId = table.Column<int>(type: "int", nullable: false),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApprove = table.Column<bool>(type: "bit", nullable: false),
                    ApproveTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectElementImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectElementImage_ProjectElement_ProjectElementId",
                        column: x => x.ProjectElementId,
                        principalTable: "ProjectElement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectElementLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementLinkType = table.Column<int>(type: "int", nullable: false),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectElementId = table.Column<int>(type: "int", nullable: false),
                    LinkedProjectElementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectElementLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectElementLink_ProjectElement_ProjectElementId",
                        column: x => x.ProjectElementId,
                        principalTable: "ProjectElement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SceneParagraph",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    ParagraphText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneId = table.Column<int>(type: "int", nullable: false),
                    SceneParagraphTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneParagraph", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SceneParagraph_SceneParagraphType_SceneParagraphTypeId",
                        column: x => x.SceneParagraphTypeId,
                        principalTable: "SceneParagraphType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SceneParagraph_Scene_SceneId",
                        column: x => x.SceneId,
                        principalTable: "Scene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SceneParagraphLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequiredCount = table.Column<int>(type: "int", nullable: true),
                    ElementText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParagraphElementIndex = table.Column<int>(type: "int", nullable: true),
                    InsertionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneId = table.Column<int>(type: "int", nullable: false),
                    SceneParagraphId = table.Column<int>(type: "int", nullable: true),
                    ProjectElementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneParagraphLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SceneParagraphLink_ProjectElement_ProjectElementId",
                        column: x => x.ProjectElementId,
                        principalTable: "ProjectElement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SceneParagraphLink_SceneParagraph_SceneParagraphId",
                        column: x => x.SceneParagraphId,
                        principalTable: "SceneParagraph",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SceneParagraphLink_Scene_SceneId",
                        column: x => x.SceneId,
                        principalTable: "Scene",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComponentType_ProjectId",
                table: "ComponentType",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypeLink_ComponentTypeId",
                table: "ComponentTypeLink",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectTypeId",
                table: "Project",
                column: "ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectElement_ComponentTypeId",
                table: "ProjectElement",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectElement_ProjectId",
                table: "ProjectElement",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectElementImage_ProjectElementId",
                table: "ProjectElementImage",
                column: "ProjectElementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectElementLink_ProjectElementId",
                table: "ProjectElementLink",
                column: "ProjectElementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPart_ProjectId",
                table: "ProjectPart",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPart_ScriptTypeId",
                table: "ProjectPart",
                column: "ScriptTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPartParagraph_ProjectPartId",
                table: "ProjectPartParagraph",
                column: "ProjectPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_ProjectPartId",
                table: "Scene",
                column: "ProjectPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_TransitionTypeId",
                table: "Scene",
                column: "TransitionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneParagraph_SceneId",
                table: "SceneParagraph",
                column: "SceneId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneParagraph_SceneParagraphTypeId",
                table: "SceneParagraph",
                column: "SceneParagraphTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneParagraphLink_ProjectElementId",
                table: "SceneParagraphLink",
                column: "ProjectElementId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneParagraphLink_SceneId",
                table: "SceneParagraphLink",
                column: "SceneId");

            migrationBuilder.CreateIndex(
                name: "IX_SceneParagraphLink_SceneParagraphId",
                table: "SceneParagraphLink",
                column: "SceneParagraphId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentTypeLink");

            migrationBuilder.DropTable(
                name: "ProjectElementImage");

            migrationBuilder.DropTable(
                name: "ProjectElementLink");

            migrationBuilder.DropTable(
                name: "ProjectPartParagraph");

            migrationBuilder.DropTable(
                name: "SceneParagraphLink");

            migrationBuilder.DropTable(
                name: "ProjectElement");

            migrationBuilder.DropTable(
                name: "SceneParagraph");

            migrationBuilder.DropTable(
                name: "ComponentType");

            migrationBuilder.DropTable(
                name: "SceneParagraphType");

            migrationBuilder.DropTable(
                name: "Scene");

            migrationBuilder.DropTable(
                name: "ProjectPart");

            migrationBuilder.DropTable(
                name: "TransitionType");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "ScriptType");

            migrationBuilder.DropTable(
                name: "ProjectType");
        }
    }
}
