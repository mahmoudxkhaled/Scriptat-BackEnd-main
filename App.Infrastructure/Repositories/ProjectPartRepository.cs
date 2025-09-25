// Decompiled with JetBrains decompiler
// Type: App.Infrastructure.ProjectPartRepository
// Assembly: Scriptat.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0767F460-F976-434F-8FE7-B3A515E17ECC
// Assembly location: H:\Scriptat\API\Scriptat.Core.dll

using App.Application;
using App.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace App.Infrastructure
{
    public class ProjectPartRepository : IProjectPartRepository
    {
        private readonly ScriptatDBContext context;

        public ProjectPartRepository(ScriptatDBContext _context) => this.context = _context;

        public async Task<VM_ProjectDetail> GetProjectDetailDataVeiw(int id)
        {
            //Project _project = await this.context.Project.Where<Project>((Expression<Func<Project, bool>>)(p => p.Id == id)).Include<Project, ProjectType>((Expression<Func<Project, ProjectType>>)(p => p.ProjectType)).Include<Project, IEnumerable<ProjectElement>>((Expression<Func<Project, IEnumerable<ProjectElement>>>)(p => p.ProjectElements.Where<ProjectElement>((Func<ProjectElement, bool>)(s => !s.IsDelete)))).ThenInclude<Project, ProjectElement, IEnumerable<ProjectElementLink>>((Expression<Func<ProjectElement, IEnumerable<ProjectElementLink>>>)(p => p.ProjectElementLinks.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(s => !s.IsDelete)))).Include<Project, IEnumerable<ProjectPart>>((Expression<Func<Project, IEnumerable<ProjectPart>>>)(p => p.ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>)(s => !s.IsDelete)))).ThenInclude<Project, ProjectPart, ScriptType>((Expression<Func<ProjectPart, ScriptType>>)(p => p.ScriptType)).SingleOrDefaultAsync<Project>();
            //VM_ProjectDetail _projectVM = new VM_ProjectDetail();
            //_projectVM.ProjectTypeId = _project.ProjectTypeId;
            //_projectVM.ProjectTypeTitle = _project.ProjectType.ProjectTypeTitle;
            //_projectVM.ProjectId = _project.Id;
            //_projectVM.ProjectTitle = _project.ProjectTitle;
            //_projectVM.ProjectPartCount = _project.ProjectPartCount;
            //_projectVM.ProjectSummary = _project.ProjectSummary;
            //_projectVM.ProjectDescription = _project.ProjectDescription;
            //List<VM_ProjectPartScene> projectPartSceneList = new List<VM_ProjectPartScene>();
            //List<VM_SceneParagraphItem> sceneParagraphItemList = new List<VM_SceneParagraphItem>();
            //if (_project.ProjectParts.Count > 0)
            //{
            //    _projectVM.ProjectParts = new List<VM_ProjectDetailPart>();
            //    for (int i = 0; i < _project.ProjectParts.Count; i++)
            //    {
            //        VM_ProjectDetailPart projectDetailPart = new VM_ProjectDetailPart();
            //        projectDetailPart.ProjectId = _project.ProjectParts[i].ScriptTypeId;
            //        projectDetailPart.ScriptTypeId = _project.ProjectParts[i].ScriptTypeId;
            //        projectDetailPart.ScriptTypeTitle = _project.ProjectParts[i].ScriptType.Title;
            //        projectDetailPart.OrderNo = _project.ProjectParts[i].PartNo;
            //        projectDetailPart.ProjectPartId = _project.ProjectParts[i].Id;
            //        projectDetailPart.ProjectPartTitle = _project.ProjectParts[i].ProjectPartTitle;
            //        projectDetailPart.ProjectPartIntroduction = _project.ProjectParts[i].ProjectPartIntroduction;
            //        projectDetailPart.ProjectPartPageCount = _project.ProjectParts[i].ProjectPartPageCount;
            //        projectDetailPart.ProjectPartSceneCount = _project.ProjectParts[i].ProjectPartSceneCount;
            //        projectDetailPart.ProjectPartWordCount = _project.ProjectParts[i].ProjectPartWordCount;
            //        List<Scene> list = this.context.Scene.Where<Scene>((Expression<Func<Scene, bool>>)(s => s.ProjectPartId == _project.ProjectParts[i].Id && !s.IsDelete)).Include<Scene, IEnumerable<SceneParagraph>>((Expression<Func<Scene, IEnumerable<SceneParagraph>>>)(p => p.SceneParagraphs.Where<SceneParagraph>((Func<SceneParagraph, bool>)(s => !s.IsDelete)))).ThenInclude<Scene, SceneParagraph, IEnumerable<SceneParagraphLink>>((Expression<Func<SceneParagraph, IEnumerable<SceneParagraphLink>>>)(p => p.SceneParagraphLinks.Where<SceneParagraphLink>((Func<SceneParagraphLink, bool>)(s => !s.IsDelete)))).ToList<Scene>();
            //        if (list.Count > 0)
            //        {
            //            projectDetailPart.ProjectPartScenes = new List<VM_ProjectDetailPartScene>();
            //            for (int index1 = 0; index1 < list.Count; ++index1)
            //            {
            //                projectPartSceneList.Add(new VM_ProjectPartScene()
            //                {
            //                    SceneId = list[index1].Id,
            //                    ProjectPartId = list[index1].ProjectPartId
            //                });
            //                VM_ProjectDetailPartScene projectDetailPartScene = new VM_ProjectDetailPartScene();
            //                projectDetailPartScene.ProjectPartId = _project.ProjectParts[i].Id;
            //                projectDetailPartScene.SceneId = list[index1].Id;
            //                projectDetailPartScene.OrderNo = list[index1].OrderNo;
            //                projectDetailPartScene.SceneNo = list[index1].SceneNo;
            //                projectDetailPartScene.SceneTitle = string.Format("{0}", (object)list[index1].SceneNoText);
            //                projectDetailPartScene.SceneNoText = list[index1].SceneNoText;
            //                projectDetailPartScene.SceneDescription = list[index1].SceneDescription;
            //                projectDetailPartScene.SceneTimeMode = list[index1].SceneTime;
            //                projectDetailPartScene.LocationTypeMode = list[index1].LocationType;
            //                projectDetailPartScene.SceneTransitionTypeText = list[index1].TransitionType == null ? "قطع!" : list[index1].TransitionType.TitleEn;
            //                if (list[index1].SceneParagraphs.Count > 0)
            //                {
            //                    projectDetailPartScene.SceneParagraphs = new List<VM_ProjectDetailPartSceneParagraph>();
            //                    for (int index2 = 0; index2 < list[index1].SceneParagraphs.Count; ++index2)
            //                    {
            //                        VM_ProjectDetailPartSceneParagraph partSceneParagraph1 = new VM_ProjectDetailPartSceneParagraph();
            //                        partSceneParagraph1.ParagraphId = list[index1].SceneParagraphs[index2].Id;
            //                        partSceneParagraph1.OrderNo = list[index1].SceneParagraphs[index2].OrderNo;
            //                        partSceneParagraph1.SceneId = list[index1].Id;
            //                        VM_ProjectDetailPartSceneParagraph partSceneParagraph2 = partSceneParagraph1;
            //                        int? sceneParagraphTypeId = list[index1].SceneParagraphs[index2].SceneParagraphTypeId;
            //                        int num1 = sceneParagraphTypeId.Value;
            //                        partSceneParagraph2.SceneParagraphTypeId = num1;
            //                        partSceneParagraph1.ParagraphText = list[index1].SceneParagraphs[index2].ParagraphText;
            //                        VM_ProjectDetailPartSceneParagraph partSceneParagraph3 = partSceneParagraph1;
            //                        sceneParagraphTypeId = list[index1].SceneParagraphs[index2].SceneParagraphTypeId;
            //                        int num2 = 6;
            //                        int num3 = sceneParagraphTypeId.GetValueOrDefault() < num2 & sceneParagraphTypeId.HasValue ? 1 : 0;
            //                        partSceneParagraph3.IsShowAllowed = num3 != 0;
            //                        sceneParagraphTypeId = list[index1].SceneParagraphs[index2].SceneParagraphTypeId;
            //                        SceneParagraphTypeEnum paragraphTypeEnum;
            //                        if (sceneParagraphTypeId.HasValue)
            //                        {
            //                            sceneParagraphTypeId = list[index1].SceneParagraphs[index2].SceneParagraphTypeId;
            //                            paragraphTypeEnum = (SceneParagraphTypeEnum)sceneParagraphTypeId.Value;
            //                        }
            //                        else
            //                            paragraphTypeEnum = SceneParagraphTypeEnum.Scenario;
            //                        switch (paragraphTypeEnum)
            //                        {
            //                            case SceneParagraphTypeEnum.Scenario:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 1;
            //                                break;
            //                            case SceneParagraphTypeEnum.Character:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 2;
            //                                break;
            //                            case SceneParagraphTypeEnum.Dialog:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 3;
            //                                break;
            //                            case SceneParagraphTypeEnum.Location:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 1;
            //                                break;
            //                            case SceneParagraphTypeEnum.Paragraph:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 1;
            //                                break;
            //                            case SceneParagraphTypeEnum.SceneNoText:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 1;
            //                                break;
            //                            case SceneParagraphTypeEnum.TimeModeText:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 1;
            //                                break;
            //                            case SceneParagraphTypeEnum.SceneHeader:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 1;
            //                                break;
            //                            case SceneParagraphTypeEnum.Transition:
            //                                partSceneParagraph1.SceneParagraphFormatKey = 2;
            //                                break;
            //                        }
            //                        projectDetailPartScene.SceneParagraphs.Add(partSceneParagraph1);
            //                        sceneParagraphItemList.AddRange(list[index1].SceneParagraphs[index2].SceneParagraphLinks.Where<SceneParagraphLink>((Func<SceneParagraphLink, bool>)(s => s.ProjectElement.ComponentTypeId == 1)).ToList<SceneParagraphLink>().Select<SceneParagraphLink, VM_SceneParagraphItem>((Func<SceneParagraphLink, VM_SceneParagraphItem>)(s => new VM_SceneParagraphItem()
            //                        {
            //                            Id = s.Id,
            //                            CharacterId = new int?(s.ProjectElementId),
            //                            SceneId = s.SceneParagraph.SceneId
            //                        })));
            //                        sceneParagraphItemList.AddRange(list[index1].SceneParagraphs[index2].SceneParagraphLinks.Where<SceneParagraphLink>((Func<SceneParagraphLink, bool>)(s => s.ProjectElement.ComponentTypeId == 2)).ToList<SceneParagraphLink>().Select<SceneParagraphLink, VM_SceneParagraphItem>((Func<SceneParagraphLink, VM_SceneParagraphItem>)(s => new VM_SceneParagraphItem()
            //                        {
            //                            Id = s.Id,
            //                            LocationId = new int?(s.ProjectElementId),
            //                            SceneId = s.SceneParagraph.SceneId
            //                        })));
            //                    }
            //                }
            //                projectDetailPart.ProjectPartScenes.Add(projectDetailPartScene);
            //            }
            //        }
            //        _projectVM.ProjectParts.Add(projectDetailPart);
            //    }
            //}
            //ParameterExpression parameterExpression;
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //// ISSUE: method reference
            //List<VM_ComponentOption> list1 = this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>)(x => !x.IsDelete && !x.ProjectId.HasValue)).Select<ComponentType, VM_ComponentOption>(Expression.Lambda<Func<ComponentType, VM_ComponentOption>>((Expression)Expression.MemberInit(Expression.New(typeof(VM_ComponentOption)), (MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle(__methodref(VM_ComponentOption.set_ComponentId)), "")))); //unable to render the statement
            //List<VM_Component> componentList = await this.GetComponentList(id, (int[])null, list1);
            //if (componentList.Count > 0)
            //{
            //    _projectVM.ProjectComponents = new List<VM_ProjectDetailComponent>();
            //    for (int index3 = 0; index3 < componentList.Count; ++index3)
            //    {
            //        VM_ProjectDetailComponent projectDetailComponent = new VM_ProjectDetailComponent();
            //        projectDetailComponent.ComponentId = componentList[index3].ComponentTypeId;
            //        projectDetailComponent.ComponentTitle = componentList[index3].ComponentTitle;
            //        projectDetailComponent.ComponentDescription = componentList[index3].ComponentDescription;
            //        projectDetailComponent.OrderNo = componentList[index3].OrderNo;
            //        projectDetailComponent.SceneArray = componentList[index3].SceneArray;
            //        projectDetailComponent.ProjectPartArray = componentList[index3].ProjectPartArray;
            //        if (componentList[index3].ComponentElements != null && componentList[index3].ComponentElements.Count > 0)
            //        {
            //            projectDetailComponent.ProjectElements = new List<VM_ProjectDetailElement>();
            //            for (int index4 = 0; index4 < componentList[index3].ComponentElements.Count; ++index4)
            //            {
            //                VM_ProjectDetailElement projectDetailElement = new VM_ProjectDetailElement();
            //                projectDetailElement.ProjectId = componentList[index3].ComponentElements[index4].ProjectId;
            //                projectDetailElement.ProjectElementId = componentList[index3].ComponentElements[index4].ProjectElementId;
            //                projectDetailElement.ProjectComponentId = componentList[index3].ComponentElements[index4].ComponentId;
            //                projectDetailElement.ProjectElementName = componentList[index3].ComponentElements[index4].ProjectElementName;
            //                projectDetailElement.ProjectElementDescription = componentList[index3].ComponentElements[index4].ProjectElementDescription;
            //                projectDetailElement.ProjectElementImageUrl = componentList[index3].ComponentElements[index4].ProjectElementImageUrl;
            //                projectDetailElement.SceneArray = componentList[index3].ComponentElements[index4].SceneArray;
            //                projectDetailElement.ProjectPartArray = componentList[index3].ComponentElements[index4].ProjectPartArray;
            //                if (componentList[index3].ComponentElements[index4].ProjectElementAliases != null && componentList[index3].ComponentElements[index4].ProjectElementAliases.Count > 0)
            //                {
            //                    projectDetailElement.ProjectElementAliases = new List<VM_ProjectDetailElementChild>();
            //                    for (int index5 = 0; index5 < componentList[index3].ComponentElements[index4].ProjectElementAliases.Count; ++index5)
            //                        projectDetailElement.ProjectElementAliases.Add(new VM_ProjectDetailElementChild()
            //                        {
            //                            ProjectId = componentList[index3].ComponentElements[index4].ProjectId,
            //                            ProjectElementId = componentList[index3].ComponentElements[index4].ProjectElementAliases[index5].ProjectElementId,
            //                            ProjectComponentId = componentList[index3].ComponentElements[index4].ProjectElementAliases[index5].ComponentId,
            //                            ProjectElementName = componentList[index3].ComponentElements[index4].ProjectElementAliases[index5].ProjectElementName,
            //                            ProjectElementDescription = componentList[index3].ComponentElements[index4].ProjectElementAliases[index5].ProjectElementDescription,
            //                            ProjectElementImageUrl = componentList[index3].ComponentElements[index4].ProjectElementAliases[index5].ProjectElementImageUrl
            //                        });
            //                }
            //                if (componentList[index3].ComponentElements[index4].ProjectElementImages != null && componentList[index3].ComponentElements[index4].ProjectElementImages.Count > 0)
            //                {
            //                    projectDetailElement.ProjectElementImages = new List<VM_ProjectDetailElementImage>();
            //                    for (int index6 = 0; index6 < componentList[index3].ComponentElements[index4].ProjectElementImages.Count; ++index6)
            //                        projectDetailElement.ProjectElementImages.Add(new VM_ProjectDetailElementImage()
            //                        {
            //                            Id = componentList[index3].ComponentElements[index4].ProjectElementImages[index6].Id,
            //                            ProjectElementId = componentList[index3].ComponentElements[index4].ProjectElementImages[index6].ProjectElementId,
            //                            ElementImageTitle = componentList[index3].ComponentElements[index4].ProjectElementImages[index6].ElementImageTitle,
            //                            ElementImageUrl = componentList[index3].ComponentElements[index4].ProjectElementImages[index6].ElementImageUrl,
            //                            IsApprove = componentList[index3].ComponentElements[index4].ProjectElementImages[index6].IsApprove
            //                        });
            //                }
            //                projectDetailComponent.ProjectElements.Add(projectDetailElement);
            //            }
            //        }
            //        _projectVM.ProjectComponents.Add(projectDetailComponent);
            //    }
            //}
            //VM_ProjectDetail projectDetailDataVeiw = _projectVM;
            //_projectVM = (VM_ProjectDetail)null;
            return new VM_ProjectDetail(); //projectDetailDataVeiw;
        }

        public async Task<VM_ProjectNavigator> GetProjectDetailCardVeiw(int projectid)
        {
            Project project = await this.context.Project.Where<Project>((Expression<Func<Project, bool>>)(p => p.Id == projectid)).Include<Project, ProjectType>((Expression<Func<Project, ProjectType>>)(p => p.ProjectType)).Include<Project, IEnumerable<ProjectElement>>((Expression<Func<Project, IEnumerable<ProjectElement>>>)(p => p.ProjectElements.Where<ProjectElement>((Func<ProjectElement, bool>)(s => !s.IsDelete && (s.ComponentTypeId == 1 || s.ComponentTypeId == 2))))).ThenInclude<Project, ProjectElement, List<ProjectElementLink>>((Expression<Func<ProjectElement, List<ProjectElementLink>>>)(p => p.ProjectElementLinks)).Include<Project, IEnumerable<ProjectPart>>((Expression<Func<Project, IEnumerable<ProjectPart>>>)(p => p.ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>)(s => !s.IsDelete)))).ThenInclude<Project, ProjectPart, ScriptType>((Expression<Func<ProjectPart, ScriptType>>)(p => p.ScriptType)).SingleOrDefaultAsync<Project>();
            VM_ProjectNavigator _projectVM = new VM_ProjectNavigator();
            _projectVM.ProjectTypeId = project.ProjectTypeId;
            _projectVM.ProjectTypeTitle = project.ProjectType.ProjectTypeTitle;
            _projectVM.ProjectId = project.Id;
            _projectVM.ProjectTitle = project.ProjectTitle;
            _projectVM.ProjectPartCount = project.ProjectPartCount;
            _projectVM.ProjectSummary = project.ProjectSummary;
            _projectVM.ProjectDescription = project.ProjectDescription;
            List<VM_SceneParagraphItem> sceneParagraphItemList = new List<VM_SceneParagraphItem>();
            if (project.ProjectParts.Count > 0)
            {
                _projectVM.ProjectParts = new List<VM_ProjectNavigatorPartCard>();
                for (int index = 0; index < project.ProjectParts.Count; ++index)
                    _projectVM.ProjectParts.Add(new VM_ProjectNavigatorPartCard()
                    {
                        ProjectId = project.ProjectParts[index].ProjectId,
                        ScriptTypeId = project.ProjectParts[index].ScriptTypeId,
                        ScriptTypeTitle = project.ProjectParts[index].ScriptType.Title,
                        OrderNo = project.ProjectParts[index].PartNo,
                        ProjectPartId = project.ProjectParts[index].Id,
                        ProjectPartTitle = project.ProjectParts[index].ProjectPartTitle,
                        ProjectPartSummary = project.ProjectParts[index].ProjectPartSummary,
                        ProjectPartPageCount = project.ProjectParts[index].ProjectPartPageCount,
                        ProjectPartSceneCount = project.ProjectParts[index].ProjectPartSceneCount,
                        ProjectPartWordCount = project.ProjectParts[index].ProjectPartWordCount
                    });
            }
            List<VM_Component> componentList = await this.GetComponentList(projectid, (int[])null, new List<VM_ComponentOption>()
      {
        new VM_ComponentOption()
        {
          ComponentId = new int?(1),
          IsParentElementImageExists = true,
          IsParentElementAliasExists = true,
          IsParentElementNestedExists = false,
          IsParentElementLinkedExists = false,
          IsParentElementCandidateExists = false,
          IsParentElementSceneArrayExists = true,
          IsParentElementProjectPartArrayExists = true,
          IsChildElementImageExists = true,
          IsChildElementAliasExists = true,
          IsChildElementNestedExists = false,
          IsChildElementLinkedExists = false,
          IsChildElementCandidateExists = false,
          IsChildElementSceneArrayExists = false,
          IsChildElementProjectPartArrayExists = false
        },
        new VM_ComponentOption()
        {
          ComponentId = new int?(2),
          IsParentElementImageExists = true,
          IsParentElementAliasExists = true,
          IsParentElementNestedExists = false,
          IsParentElementLinkedExists = false,
          IsParentElementCandidateExists = false,
          IsParentElementSceneArrayExists = true,
          IsParentElementProjectPartArrayExists = false,
          IsChildElementImageExists = false,
          IsChildElementAliasExists = true,
          IsChildElementNestedExists = false,
          IsChildElementLinkedExists = false,
          IsChildElementCandidateExists = false,
          IsChildElementSceneArrayExists = false,
          IsChildElementProjectPartArrayExists = false
        }
      });
            for (int index1 = 0; index1 < componentList.Count; ++index1)
            {
                if (componentList[index1].ComponentTypeId == 1)
                {
                    if (componentList[index1].ComponentElements != null && componentList[index1].ComponentElements.Count > 0)
                    {
                        List<VM_ProjectNavigatorSideElement> navigatorSideElementList = new List<VM_ProjectNavigatorSideElement>();
                        for (int index2 = 0; index2 < componentList[index1].ComponentElements.Count; ++index2)
                        {
                            VM_ProjectNavigatorSideElement navigatorSideElement = new VM_ProjectNavigatorSideElement();
                            navigatorSideElement.ProjectId = componentList[index1].ComponentElements[index2].ProjectId;
                            navigatorSideElement.ProjectElementId = componentList[index1].ComponentElements[index2].ProjectElementId;
                            navigatorSideElement.ProjectElementName = componentList[index1].ComponentElements[index2].ProjectElementName;
                            navigatorSideElement.ProjectElementImageUrl = componentList[index1].ComponentElements[index2].ProjectElementImageUrl;
                            navigatorSideElement.ProjectPartArray = componentList[index1].ComponentElements[index2].ProjectPartArray;
                            navigatorSideElement.SceneArray = componentList[index1].ComponentElements[index2].SceneArray;
                            if (componentList[index1].ComponentElements[index2].ProjectElementAliases != null && componentList[index1].ComponentElements[index2].ProjectElementAliases.Count > 0)
                            {
                                List<VM_ProjectNavigatorSideElementChild> sideElementChildList = new List<VM_ProjectNavigatorSideElementChild>();
                                for (int index3 = 0; index3 < componentList[index1].ComponentElements[index2].ProjectElementAliases.Count; ++index3)
                                    sideElementChildList.Add(new VM_ProjectNavigatorSideElementChild()
                                    {
                                        ParentProjectElementId = componentList[index1].ComponentElements[index2].ProjectElementId,
                                        ProjectId = componentList[index1].ComponentElements[index2].ProjectElementAliases[index3].ProjectId,
                                        ProjectElementId = componentList[index1].ComponentElements[index2].ProjectElementAliases[index3].ProjectElementId,
                                        ProjectElementName = componentList[index1].ComponentElements[index2].ProjectElementAliases[index3].ProjectElementName,
                                        ProjectElementImageUrl = componentList[index1].ComponentElements[index2].ProjectElementAliases[index3].ProjectElementImageUrl
                                    });
                                navigatorSideElement.ProjectAliasElements = sideElementChildList;
                            }
                            if (componentList[index1].ComponentElements[index2].ProjectElementImages != null && componentList[index1].ComponentElements[index2].ProjectElementImages.Count > 0)
                            {
                                List<VM_ComponentElementImage> componentElementImageList = new List<VM_ComponentElementImage>();
                                for (int index4 = 0; index4 < componentList[index1].ComponentElements[index2].ProjectElementImages.Count; ++index4)
                                    componentElementImageList.Add(new VM_ComponentElementImage()
                                    {
                                        Id = componentList[index1].ComponentElements[index2].ProjectElementImages[index4].Id,
                                        ProjectElementId = componentList[index1].ComponentElements[index2].ProjectElementImages[index4].ProjectElementId,
                                        ElementImageTitle = componentList[index1].ComponentElements[index2].ProjectElementImages[index4].ElementImageTitle,
                                        ElementImageUrl = componentList[index1].ComponentElements[index2].ProjectElementImages[index4].ElementImageUrl,
                                        IsApprove = componentList[index1].ComponentElements[index2].ProjectElementImages[index4].IsApprove
                                    });
                                navigatorSideElement.ProjectElementImages = componentElementImageList;
                            }
                            navigatorSideElementList.Add(navigatorSideElement);
                        }
                        _projectVM.ProjectCharacters = navigatorSideElementList;
                    }
                }
                else if (componentList[index1].ComponentTypeId == 2 && componentList[index1].ComponentElements != null && componentList[index1].ComponentElements.Count > 0)
                {
                    List<VM_ProjectNavigatorSideElement> navigatorSideElementList = new List<VM_ProjectNavigatorSideElement>();
                    for (int index5 = 0; index5 < componentList[index1].ComponentElements.Count; ++index5)
                    {
                        VM_ProjectNavigatorSideElement navigatorSideElement = new VM_ProjectNavigatorSideElement();
                        navigatorSideElement.ProjectId = componentList[index1].ComponentElements[index5].ProjectId;
                        navigatorSideElement.ProjectElementId = componentList[index1].ComponentElements[index5].ProjectElementId;
                        navigatorSideElement.ProjectElementName = componentList[index1].ComponentElements[index5].ProjectElementName;
                        navigatorSideElement.ProjectElementImageUrl = componentList[index1].ComponentElements[index5].ProjectElementImageUrl;
                        navigatorSideElement.ProjectPartArray = componentList[index1].ComponentElements[index5].ProjectPartArray;
                        navigatorSideElement.SceneArray = componentList[index1].ComponentElements[index5].SceneArray;
                        if (componentList[index1].ComponentElements[index5].ProjectElementAliases != null && componentList[index1].ComponentElements[index5].ProjectElementAliases.Count > 0)
                        {
                            List<VM_ProjectNavigatorSideElementChild> sideElementChildList = new List<VM_ProjectNavigatorSideElementChild>();
                            for (int index6 = 0; index6 < componentList[index1].ComponentElements[index5].ProjectElementAliases.Count; ++index6)
                                sideElementChildList.Add(new VM_ProjectNavigatorSideElementChild()
                                {
                                    ParentProjectElementId = componentList[index1].ComponentElements[index5].ProjectElementId,
                                    ProjectId = componentList[index1].ComponentElements[index5].ProjectElementAliases[index6].ProjectId,
                                    ProjectElementId = componentList[index1].ComponentElements[index5].ProjectElementAliases[index6].ProjectElementId,
                                    ProjectElementName = componentList[index1].ComponentElements[index5].ProjectElementAliases[index6].ProjectElementName,
                                    ProjectElementImageUrl = componentList[index1].ComponentElements[index5].ProjectElementAliases[index6].ProjectElementImageUrl
                                });
                            navigatorSideElement.ProjectAliasElements = sideElementChildList;
                        }
                        if (componentList[index1].ComponentElements[index5].ProjectElementImages != null && componentList[index1].ComponentElements[index5].ProjectElementImages.Count > 0)
                        {
                            List<VM_ComponentElementImage> componentElementImageList = new List<VM_ComponentElementImage>();
                            for (int index7 = 0; index7 < componentList[index1].ComponentElements[index5].ProjectElementImages.Count; ++index7)
                                componentElementImageList.Add(new VM_ComponentElementImage()
                                {
                                    Id = componentList[index1].ComponentElements[index5].ProjectElementImages[index7].Id,
                                    ProjectElementId = componentList[index1].ComponentElements[index5].ProjectElementImages[index7].ProjectElementId,
                                    ElementImageTitle = componentList[index1].ComponentElements[index5].ProjectElementImages[index7].ElementImageTitle,
                                    ElementImageUrl = componentList[index1].ComponentElements[index5].ProjectElementImages[index7].ElementImageUrl,
                                    IsApprove = componentList[index1].ComponentElements[index5].ProjectElementImages[index7].IsApprove
                                });
                            navigatorSideElement.ProjectElementImages = componentElementImageList;
                        }
                        navigatorSideElementList.Add(navigatorSideElement);
                    }
                    _projectVM.ProjectLocations = navigatorSideElementList;
                }
            }
            VM_ProjectNavigator projectDetailCardVeiw = _projectVM;
            _projectVM = (VM_ProjectNavigator)null;
            return projectDetailCardVeiw;
        }

        public async Task<VM_ProjectNavigator> GetProjectDetailCardVeiwByPartId(int projectpartid)
        {
            ProjectPart _part = await this.context.ProjectPart.FindAsync((object)projectpartid);
            Project project = await this.context.Project.Where<Project>((Expression<Func<Project, bool>>)(p => p.Id == _part.ProjectId)).Include<Project, ProjectType>((Expression<Func<Project, ProjectType>>)(p => p.ProjectType)).Include<Project, IEnumerable<ProjectElement>>((Expression<Func<Project, IEnumerable<ProjectElement>>>)(p => p.ProjectElements.Where<ProjectElement>((Func<ProjectElement, bool>)(s => !s.IsDelete && (s.ComponentTypeId == 1 || s.ComponentTypeId == 2))))).ThenInclude<Project, ProjectElement, List<ProjectElementLink>>((Expression<Func<ProjectElement, List<ProjectElementLink>>>)(p => p.ProjectElementLinks)).Include<Project, IEnumerable<ProjectPart>>((Expression<Func<Project, IEnumerable<ProjectPart>>>)(p => p.ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>)(s => !s.IsDelete)))).ThenInclude<Project, ProjectPart, ScriptType>((Expression<Func<ProjectPart, ScriptType>>)(p => p.ScriptType)).SingleOrDefaultAsync<Project>();
            VM_ProjectNavigator _projectVM = new VM_ProjectNavigator();
            _projectVM.ProjectTypeId = project.ProjectTypeId;
            _projectVM.ProjectTypeTitle = project.ProjectType.ProjectTypeTitle;
            _projectVM.ProjectId = project.Id;
            _projectVM.ProjectTitle = project.ProjectTitle;
            _projectVM.ProjectPartCount = project.ProjectPartCount;
            _projectVM.ProjectSummary = project.ProjectSummary;
            _projectVM.ProjectDescription = project.ProjectDescription;
            List<VM_SceneParagraphItem> sceneParagraphItemList = new List<VM_SceneParagraphItem>();
            if (project.ProjectParts.Count > 0)
            {
                _projectVM.ProjectParts = new List<VM_ProjectNavigatorPartCard>();
                for (int index = 0; index < project.ProjectParts.Count; ++index)
                    _projectVM.ProjectParts.Add(new VM_ProjectNavigatorPartCard()
                    {
                        ProjectId = project.ProjectParts[index].ProjectId,
                        ScriptTypeId = project.ProjectParts[index].ScriptTypeId,
                        ScriptTypeTitle = project.ProjectParts[index].ScriptType.Title,
                        OrderNo = project.ProjectParts[index].PartNo,
                        ProjectPartId = project.ProjectParts[index].Id,
                        ProjectPartTitle = project.ProjectParts[index].ProjectPartTitle,
                        ProjectPartSummary = project.ProjectParts[index].ProjectPartSummary,
                        ProjectPartPageCount = project.ProjectParts[index].ProjectPartPageCount,
                        ProjectPartSceneCount = project.ProjectParts[index].ProjectPartSceneCount,
                        ProjectPartWordCount = project.ProjectParts[index].ProjectPartWordCount
                    });
            }
            List<VM_Component> componentList = await this.GetComponentList(_part.ProjectId, (int[])null, new List<VM_ComponentOption>()
      {
        new VM_ComponentOption()
        {
          ComponentId = new int?(1),
          IsParentElementImageExists = false,
          IsParentElementAliasExists = false,
          IsParentElementNestedExists = false,
          IsParentElementLinkedExists = false,
          IsParentElementCandidateExists = false,
          IsParentElementSceneArrayExists = true,
          IsParentElementProjectPartArrayExists = true,
          IsChildElementImageExists = false,
          IsChildElementAliasExists = false,
          IsChildElementNestedExists = false,
          IsChildElementLinkedExists = false,
          IsChildElementCandidateExists = false,
          IsChildElementSceneArrayExists = false,
          IsChildElementProjectPartArrayExists = false
        },
        new VM_ComponentOption()
        {
          ComponentId = new int?(2),
          IsParentElementImageExists = false,
          IsParentElementAliasExists = false,
          IsParentElementNestedExists = false,
          IsParentElementLinkedExists = false,
          IsParentElementCandidateExists = false,
          IsParentElementSceneArrayExists = true,
          IsParentElementProjectPartArrayExists = false,
          IsChildElementImageExists = false,
          IsChildElementAliasExists = false,
          IsChildElementNestedExists = false,
          IsChildElementLinkedExists = false,
          IsChildElementCandidateExists = false,
          IsChildElementSceneArrayExists = false,
          IsChildElementProjectPartArrayExists = false
        }
      });
            for (int index1 = 0; index1 < componentList.Count; ++index1)
            {
                if (componentList[index1].ComponentTypeId == 1)
                {
                    if (componentList[index1].ComponentElements != null && componentList[index1].ComponentElements.Count > 0)
                    {
                        List<VM_ProjectNavigatorSideElement> navigatorSideElementList = new List<VM_ProjectNavigatorSideElement>();
                        for (int index2 = 0; index2 < componentList[index1].ComponentElements.Count; ++index2)
                            navigatorSideElementList.Add(new VM_ProjectNavigatorSideElement()
                            {
                                ProjectId = componentList[index1].ComponentElements[index2].ProjectId,
                                ProjectElementId = componentList[index1].ComponentElements[index2].ProjectElementId,
                                ProjectElementName = componentList[index1].ComponentElements[index2].ProjectElementName,
                                ProjectElementImageUrl = componentList[index1].ComponentElements[index2].ProjectElementImageUrl,
                                ProjectPartArray = componentList[index1].ComponentElements[index2].ProjectPartArray,
                                SceneArray = componentList[index1].ComponentElements[index2].SceneArray
                            });
                        _projectVM.ProjectCharacters = navigatorSideElementList;
                    }
                }
                else if (componentList[index1].ComponentTypeId == 2 && componentList[index1].ComponentElements != null && componentList[index1].ComponentElements.Count > 0)
                {
                    List<VM_ProjectNavigatorSideElement> navigatorSideElementList = new List<VM_ProjectNavigatorSideElement>();
                    for (int index3 = 0; index3 < componentList[index1].ComponentElements.Count; ++index3)
                        navigatorSideElementList.Add(new VM_ProjectNavigatorSideElement()
                        {
                            ProjectId = componentList[index1].ComponentElements[index3].ProjectId,
                            ProjectElementId = componentList[index1].ComponentElements[index3].ProjectElementId,
                            ProjectElementName = componentList[index1].ComponentElements[index3].ProjectElementName,
                            ProjectElementImageUrl = componentList[index1].ComponentElements[index3].ProjectElementImageUrl,
                            ProjectPartArray = componentList[index1].ComponentElements[index3].ProjectPartArray,
                            SceneArray = componentList[index1].ComponentElements[index3].SceneArray
                        });
                    _projectVM.ProjectLocations = navigatorSideElementList;
                }
            }
            VM_ProjectNavigator cardVeiwByPartId = _projectVM;
            _projectVM = (VM_ProjectNavigator)null;
            return cardVeiwByPartId;
        }

        public async Task<bool> SaveProjectPart(VM_ProjectPartNew _projectPartvm)
        {
            ProjectPart entity = new ProjectPart();
            int num = this.context.ProjectPart.Max<ProjectPart, int>((Expression<Func<ProjectPart, int>>)(x => x.PartNo));
            entity.PartNo = num + 1;
            entity.ProjectId = _projectPartvm.ProjectId;
            entity.ProjectPartTitle = _projectPartvm.ProjectPartTitle;
            entity.ProjectPartFileUrl = _projectPartvm.ProjectPartFileUrl;
            entity.ScriptTypeId = _projectPartvm.ScriptTypeId;
            entity.InsertionDate = DateTime.Now;
            entity.UserId = _projectPartvm.UserId;
            entity.IsDelete = false;
            this.context.ProjectPart.Add(entity);
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateProjectPart(VM_ProjectPartUpdate _projectPartvm)
        {
            ProjectPart async = await this.context.ProjectPart.FindAsync((object)_projectPartvm.ProjectPartId);
            if (async != null)
            {
                async.ProjectPartTitle = _projectPartvm.ProjectPartTitle;
                async.ProjectPartSummary = _projectPartvm.ProjectPartSummary;
                async.ProjectPartSummaryFileUrl = _projectPartvm.ProjectPartSummaryFileUrl;
            }
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteProjectPart(int _projectPartId, string _userId)
        {
            int _result = 0;
            ProjectPart async = await this.context.ProjectPart.FindAsync((object)_projectPartId);
            if (async != null)
            {
                async.IsDelete = true;
                async.DeleteUserId = _userId;
                async.DeleteTime = new DateTime?(DateTime.Now);
                _result = await this.context.SaveChangesAsync();
            }
            return _result > 0;
        }

        public async Task<List<VM_Component>> GetComponentList(
          int _projectId,
          int[]? _projectElementArray,
          List<VM_ComponentOption>? _options)
        {
            //int[] _elementArray;
            //if (_projectElementArray != null)
            //    _elementArray = _projectElementArray;
            //else
            //    _elementArray = this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>)(x => !x.IsDelete && x.ProjectId == _projectId)).Select<ProjectElement, int>((Expression<Func<ProjectElement, int>>)(x => x.Id)).ToArray<int>();
            //int[] _componentArray;
            //if (_options != null)
            //    _componentArray = _options.Select<VM_ComponentOption, int>((Func<VM_ComponentOption, int>)(x => x.ComponentId.Value)).ToArray<int>();
            //else
            //    _componentArray = this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>)(x => !x.ProjectId.HasValue || x.ProjectId == (int?)_projectId)).Select<ComponentType, int>((Expression<Func<ComponentType, int>>)(x => x.Id)).ToArray<int>();
            //bool _IsParentElementAliasExists = false;
            //bool _IsParentElementNestedExists = false;
            //bool _IsParentElementLinkedExists = false;
            //bool _IsParentElementImageExists = false;
            //bool _IsParentElementCandidateExists = false;
            //bool _IsParentElementSceneArrayExists = false;
            //bool _IsParentElementProjectPartArrayExists = false;
            //if (_options == null)
            //{
            //    _options = new List<VM_ComponentOption>();
            //    _options.Add(new VM_ComponentOption()
            //    {
            //        ComponentId = new int?(),
            //        IsParentElementImageExists = true,
            //        IsParentElementAliasExists = true,
            //        IsParentElementNestedExists = true,
            //        IsParentElementLinkedExists = true,
            //        IsParentElementCandidateExists = true,
            //        IsParentElementSceneArrayExists = true,
            //        IsParentElementProjectPartArrayExists = true,
            //        IsChildElementImageExists = true,
            //        IsChildElementAliasExists = true,
            //        IsChildElementNestedExists = true,
            //        IsChildElementLinkedExists = true,
            //        IsChildElementCandidateExists = true,
            //        IsChildElementSceneArrayExists = true,
            //        IsChildElementProjectPartArrayExists = true
            //    });
            //}
            //bool _generalComponentOption = _options != null && _options.Count<VM_ComponentOption>() == 1 && !_options[0].ComponentId.HasValue;
            //if (_generalComponentOption)
            //{
            //    _IsParentElementAliasExists = _options[0].IsParentElementAliasExists;
            //    int num1 = _options[0].IsChildElementAliasExists ? 1 : 0;
            //    _IsParentElementNestedExists = _options[0].IsParentElementNestedExists;
            //    int num2 = _options[0].IsChildElementNestedExists ? 1 : 0;
            //    _IsParentElementLinkedExists = _options[0].IsParentElementLinkedExists;
            //    int num3 = _options[0].IsChildElementLinkedExists ? 1 : 0;
            //    _IsParentElementImageExists = _options[0].IsParentElementImageExists;
            //    int num4 = _options[0].IsChildElementImageExists ? 1 : 0;
            //    _IsParentElementCandidateExists = _options[0].IsParentElementCandidateExists;
            //    int num5 = _options[0].IsChildElementCandidateExists ? 1 : 0;
            //    _IsParentElementSceneArrayExists = _options[0].IsParentElementSceneArrayExists;
            //    int num6 = _options[0].IsChildElementSceneArrayExists ? 1 : 0;
            //    _IsParentElementProjectPartArrayExists = _options[0].IsParentElementProjectPartArrayExists;
            //    int num7 = _options[0].IsChildElementProjectPartArrayExists ? 1 : 0;
            //}
            //List<ComponentType> _componentTypes = await this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>)(x => _componentArray.Contains<int>(x.Id))).OrderBy<ComponentType, int>((Expression<Func<ComponentType, int>>)(x => x.Id)).ToListAsync<ComponentType>();
            //List<VM_Component> _components = new List<VM_Component>();
            //if (_componentTypes.Count > 0)
            //{
            //    Project project = await this.context.Project.Where<Project>((Expression<Func<Project, bool>>)(p => p.Id == _projectId)).SingleOrDefaultAsync<Project>();
            //    List<ProjectElement> listAsync = await this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>)(x => _elementArray.Contains<int>(x.Id) && x.ProjectId == _projectId && _componentArray.Contains<int>(x.ComponentTypeId))).ToListAsync<ProjectElement>();
            //    for (int i = 0; i < _componentTypes.Count; i++)
            //    {
            //        VM_Component vmComponent = new VM_Component();
            //        vmComponent.ProjectId = _projectId;
            //        vmComponent.ComponentTypeId = _componentTypes[i].Id;
            //        vmComponent.ComponentTitle = _componentTypes[i].ComponentTitle;
            //        vmComponent.ComponentDescription = _componentTypes[i].ComponentDescription;
            //        vmComponent.OrderNo = _componentTypes[i].OrderNo;
            //        if (!_generalComponentOption && _options.SingleOrDefault<VM_ComponentOption>((Func<VM_ComponentOption, bool>)(x =>
            //        {
            //            int? componentId = x.ComponentId;
            //            int id = _componentTypes[i].Id;
            //            return componentId.GetValueOrDefault() == id & componentId.HasValue;
            //        })) != null)
            //        {
            //            _IsParentElementImageExists = _options[0].IsParentElementImageExists;
            //            int num8 = _options[0].IsChildElementImageExists ? 1 : 0;
            //            _IsParentElementAliasExists = _options[0].IsParentElementAliasExists;
            //            int num9 = _options[0].IsChildElementAliasExists ? 1 : 0;
            //            _IsParentElementNestedExists = _options[0].IsParentElementNestedExists;
            //            int num10 = _options[0].IsChildElementNestedExists ? 1 : 0;
            //            _IsParentElementLinkedExists = _options[0].IsParentElementLinkedExists;
            //            int num11 = _options[0].IsChildElementLinkedExists ? 1 : 0;
            //            _IsParentElementCandidateExists = _options[0].IsParentElementCandidateExists;
            //            int num12 = _options[0].IsChildElementCandidateExists ? 1 : 0;
            //            _IsParentElementSceneArrayExists = _options[0].IsParentElementSceneArrayExists;
            //            int num13 = _options[0].IsChildElementSceneArrayExists ? 1 : 0;
            //            _IsParentElementProjectPartArrayExists = _options[0].IsParentElementProjectPartArrayExists;
            //            int num14 = _options[0].IsChildElementProjectPartArrayExists ? 1 : 0;
            //        }
            //        List<ProjectElement> list1 = this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>)(x => x.ProjectId == _projectId && x.ComponentTypeId == _componentTypes[i].Id)).Include<ProjectElement, IEnumerable<ProjectElementImage>>((Expression<Func<ProjectElement, IEnumerable<ProjectElementImage>>>)(x => x.ProjectElementImages.Where<ProjectElementImage>((Func<ProjectElementImage, bool>)(s => !s.IsDelete)))).Include<ProjectElement, IEnumerable<ProjectElementLink>>((Expression<Func<ProjectElement, IEnumerable<ProjectElementLink>>>)(x => x.ProjectElementLinks.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(s => !s.IsDelete)))).ToList<ProjectElement>();
            //        int[] array1 = list1.Select<ProjectElement, int>((Func<ProjectElement, int>)(x => x.Id)).ToArray<int>();
            //        List<ProjectElementLink> list2 = list1.SelectMany<ProjectElement, ProjectElementLink>((Func<ProjectElement, IEnumerable<ProjectElementLink>>)(x => (IEnumerable<ProjectElementLink>)x.ProjectElementLinks)).Distinct<ProjectElementLink>().ToList<ProjectElementLink>();
            //        _elementAliasArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(x => x.ElementLinkType == 1)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //        _elementCandidateArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(x => x.ElementLinkType == 3)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //        int[] array2 = list2.Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.ProjectElementId)).Distinct<int>().ToArray<int>();
            //        int[] second = _elementAliasArray;
            //        int[] array3 = ((IEnumerable<int>)array1).Except<int>((IEnumerable<int>)second).Except<int>((IEnumerable<int>)_elementCandidateArray).ToArray<int>();
            //        _elementMainArray = new int[array2.Length + array3.Length];
            //        array2.CopyTo((Array)_elementMainArray, 0);
            //        array3.CopyTo((Array)_elementMainArray, array2.Length);
            //        if (_elementMainArray.Length != 0)
            //        {
            //            int[] _elementMainArray;
            //            _elementMainList = list1.Where<ProjectElement>(closure_13 ?? (closure_13 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementMainArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //            for (int c = 0; c < _elementMainList.Count; c++)
            //            {
            //                _elementAliasArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 1)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //                _elementNestedArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 2)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //                _elementLinkedArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 4)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //                _elementCandidateArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>)(x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 3)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>)(x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //                VM_ComponentElement componentElement = new VM_ComponentElement();
            //                componentElement.ProjectId = _elementMainList[c].ProjectId;
            //                componentElement.ComponentId = _elementMainList[c].ComponentTypeId;
            //                componentElement.ProjectElementId = _elementMainList[c].Id;
            //                componentElement.ProjectElementName = _elementMainList[c].ElementName;
            //                componentElement.ProjectElementDescription = _elementMainList[c].ElementDescription;
            //                if (_IsParentElementImageExists && _elementMainList[c].ProjectElementImages != null)
            //                {
            //                    List<ProjectElementImage> projectElementImages = _elementMainList[c].ProjectElementImages;
            //                    componentElement.ProjectElementImages = new List<VM_ComponentElementImage>();
            //                    componentElement.ProjectElementImages.AddRange(_elementMainList[c].ProjectElementImages.Select<ProjectElementImage, VM_ComponentElementImage>((Func<ProjectElementImage, VM_ComponentElementImage>)(x => new VM_ComponentElementImage()
            //                    {
            //                        Id = x.Id,
            //                        ProjectElementId = x.ProjectElementId,
            //                        ElementImageTitle = x.ElementImageTitle,
            //                        ElementImageUrl = x.ElementImageUrl,
            //                        IsApprove = x.IsApprove
            //                    })));
            //                }
            //                int[] _elementAliasArray;
            //                if (_IsParentElementAliasExists && listAsync.Any<ProjectElement>(closure_5 ?? (closure_5 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementAliasArray).Contains<int>(x.Id)))))
            //                {
            //                    List<ProjectElement> list3 = listAsync.Where<ProjectElement>(closure_6 ?? (closure_6 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementAliasArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //                    componentElement.ProjectElementAliases = new List<VM_ComponentElementChild>();
            //                    componentElement.ProjectElementAliases.AddRange(list3.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>)(x => new VM_ComponentElementChild()
            //                    {
            //                        ProjectElementId = x.Id,
            //                        ProjectId = x.ProjectId,
            //                        IsApprove = x.IsApprove,
            //                        ComponentId = x.ComponentTypeId,
            //                        ProjectElementName = x.ElementName,
            //                        ProjectElementDescription = x.ElementDescription
            //                    })));
            //                }
            //                int[] _elementNestedArray;
            //                if (_IsParentElementNestedExists && listAsync.Any<ProjectElement>(closure_7 ?? (closure_7 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementNestedArray).Contains<int>(x.Id)))))
            //                {
            //                    List<ProjectElement> list4 = listAsync.Where<ProjectElement>(closure_8 ?? (closure_8 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementNestedArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //                    componentElement.ProjectElementNestedElements = new List<VM_ComponentElementChild>();
            //                    componentElement.ProjectElementNestedElements.AddRange(list4.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>)(x => new VM_ComponentElementChild()
            //                    {
            //                        ProjectElementId = x.Id,
            //                        ProjectId = x.ProjectId,
            //                        IsApprove = x.IsApprove,
            //                        ComponentId = x.ComponentTypeId,
            //                        ProjectElementName = x.ElementName,
            //                        ProjectElementDescription = x.ElementDescription
            //                    })));
            //                }
            //                int[] _elementLinkedArray;
            //                if (_IsParentElementLinkedExists && listAsync.Any<ProjectElement>(closure_9 ?? (closure_9 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementLinkedArray).Contains<int>(x.Id)))))
            //                {
            //                    List<ProjectElement> list5 = listAsync.Where<ProjectElement>(closure_10 ?? (closure_10 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementLinkedArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //                    componentElement.ProjectElementLinkedElements = new List<VM_ComponentElementChild>();
            //                    componentElement.ProjectElementLinkedElements.AddRange(list5.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>)(x => new VM_ComponentElementChild()
            //                    {
            //                        ProjectElementId = x.Id,
            //                        ProjectId = x.ProjectId,
            //                        IsApprove = x.IsApprove,
            //                        ComponentId = x.ComponentTypeId,
            //                        ProjectElementName = x.ElementName,
            //                        ProjectElementDescription = x.ElementDescription
            //                    })));
            //                }
            //                int[] _elementCandidateArray;
            //                if (_IsParentElementCandidateExists && listAsync.Any<ProjectElement>(closure_11 ?? (closure_11 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementCandidateArray).Contains<int>(x.Id)))))
            //                {
            //                    List<ProjectElement> list6 = listAsync.Where<ProjectElement>(closure_12 ?? (closure_12 = (Func<ProjectElement, bool>)(x => ((IEnumerable<int>)_elementCandidateArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //                    componentElement.ProjectElementCandidates = new List<VM_ComponentElementChild>();
            //                    componentElement.ProjectElementCandidates.AddRange(list6.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>)(x => new VM_ComponentElementChild()
            //                    {
            //                        ProjectElementId = x.Id,
            //                        ProjectId = x.ProjectId,
            //                        IsApprove = x.IsApprove,
            //                        ComponentId = x.ComponentTypeId,
            //                        ProjectElementName = x.ElementName,
            //                        ProjectElementDescription = x.ElementDescription
            //                    })));
            //                    ProjectElement projectElement = list6.Where<ProjectElement>((Func<ProjectElement, bool>)(x => x.IsApprove)).LastOrDefault<ProjectElement>();
            //                    if (projectElement != null)
            //                    {
            //                        componentElement.ProjectElementCandidateName = projectElement.ElementName;
            //                        if (projectElement.ProjectElementImages != null)
            //                        {
            //                            ProjectElementImage projectElementImage = projectElement.ProjectElementImages.Where<ProjectElementImage>((Func<ProjectElementImage, bool>)(x => x.IsApprove)).LastOrDefault<ProjectElementImage>();
            //                            if (projectElementImage != null)
            //                                componentElement.ProjectElementImageUrl = projectElementImage.ElementImageUrl;
            //                        }
            //                    }
            //                }
            //                if (_IsParentElementSceneArrayExists)
            //                    componentElement.SceneArray = _elementMainArray;
            //                if (_IsParentElementProjectPartArrayExists)
            //                    componentElement.ProjectPartArray = _elementMainArray;
            //                if (componentElement.ProjectElementImageUrl == null && componentElement.ProjectElementImages != null && componentElement.ProjectElementImages.Count > 0)
            //                    componentElement.ProjectElementImageUrl = !componentElement.ProjectElementImages.Any<VM_ComponentElementImage>((Func<VM_ComponentElementImage, bool>)(x => x.IsApprove)) ? componentElement.ProjectElementImages.FirstOrDefault<VM_ComponentElementImage>().ElementImageUrl : componentElement.ProjectElementImages.Where<VM_ComponentElementImage>((Func<VM_ComponentElementImage, bool>)(x => x.IsApprove)).LastOrDefault<VM_ComponentElementImage>().ElementImageUrl;
            //                if (vmComponent.ComponentElements == null)
            //                    vmComponent.ComponentElements = new List<VM_ComponentElement>();
            //                vmComponent.ComponentElements.Add(componentElement);
            //            }
            //        }
            //        vmComponent.ProjectPartArray = _elementMainArray;
            //        vmComponent.SceneArray = _elementMainArray;
            //        _components.Add(vmComponent);
            //    }
            //}
            //List<VM_Component> componentList = _components;
            //_components = (List<VM_Component>)null;
            return new List<VM_Component>(); //componentList;
        }
    }
}
