// Decompiled with JetBrains decompiler
// Type: App.Infrastructure.ProjectRepository
// Assembly: Scriptat.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0767F460-F976-434F-8FE7-B3A515E17ECC
// Assembly location: H:\Scriptat\API\Scriptat.Core.dll

using App.Application;
using App.Domain;
using Microsoft.EntityFrameworkCore;


#nullable enable
namespace App.Infrastructure
{
    public class ProjectRepository : Application.IProjectRepository
    {
        private readonly ScriptatDBContext context;

        public ProjectRepository(ScriptatDBContext _context) => this.context = _context;

        public async Task<List<ScriptType>> GetScriptTypeList()
        {
            // Explicitly cast DbSet<ScriptType> to IQueryable<ScriptType> to resolve the issue
            return await this.context.ScriptType.AsQueryable().ToListAsync();
        }
        public async Task<List<VM_ProjectCard>> GetProjectList(string _userid)
        {
            VM_ProjectCard _card;
            List<VM_ProjectCard> _ProjectCards;
            List<ProjectElement> _ProjectCharacters;
            List<Project> _Projects = context.Project.Where(x => !x.IsDelete && x.UserId == _userid).ToList();
            if (_Projects.Count > 0)
            {
                _ProjectCards = new List<VM_ProjectCard>();
                for (int i = 0; i < _Projects.Count; i++)
                {
                    _card = new VM_ProjectCard();
                    _card.ProjectId = _Projects[i].Id;
                    _card.ProjectTypeId = _Projects[i].ProjectTypeId;
                    _card.ProjectTypeTitle = "";//_Projects[i].ProjectType.ProjectTypeTitle;
                    _card.ProjectTitle = _Projects[i].ProjectTitle;
                    _card.ProjectDescription = _Projects[i].ProjectDescription;
                    _card.ProjectPartCount = 0;// _Projects[i].ProjectParts.Count();
                    _card.ProjectPartProgressMin = 0;// _Projects[i].Id;
                    _card.ProjectPartProgressMax = 0;// _Projects[i].Id;
                    _card.ProjectPartProgressShow = false;// _Projects[i].Id;
                    _card.ProjectBreakdownProgressMin = 0;// _Projects[i].Id;
                    _card.ProjectBreakdownProgressMax = 0;// _Projects[i].Id;
                    _card.ProjectBreakdownProgressShow = false;// _Projects[i].Id;
                    _card.ProjectPageCount = 0;// _Projects[i].Id;
                    _card.ProjectSceneCount = 0;// _Projects[i].Id;
                    _card.ProjectWordCount = 0;// _Projects[i].Id;
                    _card.ProjectDocumentShow = false;// _Projects[i].Id;
                    _ProjectCharacters = _Projects[i].ProjectElements != null ? _Projects[i].ProjectElements.Where(x => !x.IsDelete && x.ComponentTypeId == (int)Application.ComponentTypeEnum.Character).ToList() : new List<ProjectElement>();
                    if (_ProjectCharacters.Count > 0)
                    {
                        for (int c = 0; c < _ProjectCharacters.Count; c++)
                        {
                            _card.ProjectCharacters.Add(new VM_ProjectCardCharacter()
                            {
                                CharacterId = _ProjectCharacters[c].Id,
                                CharacterName = _ProjectCharacters[c].ElementName
                            });
                        }
                    }
                    _ProjectCards.Add(_card);
                }
                return _ProjectCards;
            }
            else return new List<VM_ProjectCard>();


        }
        //public async Task<List<VM_ProjectCard>> GetProjectList(string _userid)
        //{


        //  List<Project> _projects = await ((IIncludableQueryable<Project, IEnumerable<ProjectPart>>) this.context.Project.Where<Project>((Expression<Func<Project, bool>>) (p => p.UserId == _userid && !p.IsDelete)).Include<Project, ProjectType>((Expression<Func<Project, ProjectType>>) (p => p.ProjectType)).Include<Project, List<ProjectPart>>((Expression<Func<Project, List<ProjectPart>>>) (p => p.ProjectParts))).ThenInclude<Project, ProjectPart, List<Scene>>((Expression<Func<ProjectPart, List<Scene>>>) (p => p.Scenes)).OrderByDescending<Project, int>((Expression<Func<Project, int>>) (p => p.Id)).ToListAsync<Project>();
        //  List<VM_ProjectCard> projectList = new List<VM_ProjectCard>();
        //  if (_projects.Count > 0)
        //  {
        //    for (int i = 0; i < _projects.Count; i++)
        //    {
        //      VM_ProjectCard vmProjectCard = new VM_ProjectCard();
        //      vmProjectCard.ProjectTypeId = _projects[i].ProjectTypeId;
        //      vmProjectCard.ProjectTypeTitle = _projects[i].ProjectType.ProjectTypeTitle;
        //      vmProjectCard.ProjectId = _projects[i].Id;
        //      vmProjectCard.ProjectTitle = _projects[i].ProjectTitle;
        //      vmProjectCard.ProjectDescription = _projects[i].ProjectDescription;
        //      vmProjectCard.ProjectPartCount = _projects[i].ProjectPartCount;
        //      vmProjectCard.ProjectPartProgressMin = _projects[i].ProjectParts.Count<ProjectPart>();
        //      vmProjectCard.ProjectPartProgressMax = _projects[i].ProjectPartCount;
        //      vmProjectCard.ProjectPartProgressShow = _projects[i].ProjectTypeId == 2;
        //      List<ProjectPart> list1 = _projects[i].ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>) (x => x.ProjectPartSceneCount.HasValue)).ToList<ProjectPart>();
        //      vmProjectCard.ProjectBreakdownProgressMin = _projects[i].ProjectParts.Count<ProjectPart>((Func<ProjectPart, bool>) (x => x.Scenes.Any<Scene>((Func<Scene, bool>) (s => s.SceneBreakdownEndTime.HasValue))));
        //      vmProjectCard.ProjectBreakdownProgressMax = list1.Sum<ProjectPart>((Func<ProjectPart, int>) (x => x.ProjectPartSceneCount.Value));
        //      vmProjectCard.ProjectBreakdownProgressShow = true;
        //      List<ProjectPart> list2 = _projects[i].ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>) (x => x.ProjectPartPageCount.HasValue)).ToList<ProjectPart>();
        //      vmProjectCard.ProjectPageCount = list2.Sum<ProjectPart>((Func<ProjectPart, int>) (x => x.ProjectPartPageCount.Value));
        //      List<ProjectPart> list3 = _projects[i].ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>) (x => x.Scenes != null)).ToList<ProjectPart>();
        //      vmProjectCard.ProjectSceneCount = list3.Sum<ProjectPart>((Func<ProjectPart, int>) (x => x.Scenes.Count<Scene>()));
        //      List<ProjectPart> list4 = _projects[i].ProjectParts.Where<ProjectPart>((Func<ProjectPart, bool>) (x => x.ProjectPartWordCount.HasValue)).ToList<ProjectPart>();
        //      vmProjectCard.ProjectWordCount = list4.Sum<ProjectPart>((Func<ProjectPart, int>) (x => x.ProjectPartWordCount.Value));
        //      vmProjectCard.ProjectDocumentShow = _projects[i].ProjectTypeId != 2;
        //      List<ProjectElement> list5 = this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>) (x => x.ProjectId == _projects[i].Id && x.ComponentTypeId == 1 && !x.IsDelete)).Include<ProjectElement, IEnumerable<ProjectElementLink>>((Expression<Func<ProjectElement, IEnumerable<ProjectElementLink>>>) (x => x.ProjectElementLinks.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (s => !s.IsDelete && (s.ElementLinkType == 1 || s.ElementLinkType == 3))))).Include<ProjectElement, List<ProjectElementImage>>((Expression<Func<ProjectElement, List<ProjectElementImage>>>) (x => x.ProjectElementImages)).ToList<ProjectElement>();
        //      List<ProjectElementLink> list6 = list5.SelectMany<ProjectElement, ProjectElementLink>((Func<ProjectElement, IEnumerable<ProjectElementLink>>) (x => (IEnumerable<ProjectElementLink>) x.ProjectElementLinks)).ToList<ProjectElementLink>();
        //      int[] array1 = list6.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ElementLinkType == 1)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
        //      int[] array2 = list6.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ElementLinkType == 3)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
        //                int[] _characterMainArray;
        //                _characterMainArray = ((IEnumerable<int>) list5.Select<ProjectElement, int>((Func<ProjectElement, int>) (x => x.Id)).ToArray<int>()).Except<int>((IEnumerable<int>) array1).Except<int>((IEnumerable<int>) array2).Distinct<int>().ToArray<int>();

        //      List<ProjectElement> list7 = list5.Where<ProjectElement>(closure_2 ?? (closure_2 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _characterMainArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
        //      if (list7.Count > 0)
        //      {
        //        vmProjectCard.ProjectCharacters = new List<VM_ProjectCardCharacter>();
        //        for (int index1 = 0; index1 < list7.Count; ++index1)
        //        {
        //          VM_ProjectCardCharacter projectCardCharacter = new VM_ProjectCardCharacter();
        //          projectCardCharacter.CharacterId = list7[index1].Id;
        //          projectCardCharacter.CharacterName = list7[index1].ElementName;
        //          projectCardCharacter.CandidateImageUrl = "https://scriptat.org/images/icons/User.png";
        //          projectCardCharacter.SceneCount = list7[index1].Id;
        //          if (list7[index1].ProjectElementLinks != null && list7[index1].ProjectElementLinks.Count > 0)
        //          {
        //            _currentCharacterArray = list7[index1].ProjectElementLinks.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ElementLinkType == 1 && !x.IsDelete)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).ToArray<int>();
        //            int[] _currentCharacterArray;
        //            List<ProjectElement> list8 = list5.Where<ProjectElement>(closure_3 ?? (closure_3 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _currentCharacterArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
        //            if (list8 != null && list8.Count > 0)
        //            {
        //              projectCardCharacter.ProjectCharacterAliases = new List<VM_ProjectCardCharacterAlias>();
        //              for (int index2 = 0; index2 < list8.Count; ++index2)
        //                projectCardCharacter.ProjectCharacterAliases.Add(new VM_ProjectCardCharacterAlias()
        //                {
        //                  CharacterId = list8[index2].Id,
        //                  CharacterName = list8[index2].ElementName
        //                });
        //            }
        //            _currentCharacterArray = list7[index1].ProjectElementLinks.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ElementLinkType == 3 && !x.IsDelete)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).ToArray<int>();
        //            List<ProjectElement> list9 = list5.Where<ProjectElement>(closure_4 ?? (closure_4 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _currentCharacterArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
        //            if (list9 != null && list9.Count > 0)
        //            {
        //              projectCardCharacter.ProjectCharacterCandidates = new List<VM_ProjectCardCharacterCandidate>();
        //              for (int index3 = 0; index3 < list9.Count; ++index3)
        //              {
        //                VM_ProjectCardCharacterCandidate characterCandidate = new VM_ProjectCardCharacterCandidate();
        //                characterCandidate.CharacterId = list9[index3].Id;
        //                characterCandidate.CharacterName = list9[index3].ElementName;
        //                if (list9[index3].ProjectElementImages != null && list9[index3].ProjectElementImages.Count > 0)
        //                {
        //                  ProjectElementImage projectElementImage = list9[index3].ProjectElementImages.AsEnumerable<ProjectElementImage>().Where<ProjectElementImage>((Func<ProjectElementImage, bool>) (x => x.IsApprove)).LastOrDefault<ProjectElementImage>();
        //                  if (projectElementImage != null)
        //                  {
        //                    characterCandidate.CandidateImageUrl = projectElementImage.ElementImageUrl;
        //                    if (list9[index3].IsApprove)
        //                    {
        //                      projectCardCharacter.CandidateName = list9[index3].ElementName;
        //                      projectCardCharacter.CandidateImageUrl = projectElementImage.ElementImageUrl;
        //                    }
        //                  }
        //                }
        //                projectCardCharacter.ProjectCharacterCandidates.Add(characterCandidate);
        //              }
        //            }
        //          }
        //          vmProjectCard.ProjectCharacters.Add(projectCardCharacter);
        //        }
        //      }
        //      projectList.Add(vmProjectCard);
        //    }
        //  }
        //  return projectList;
        //}

        public async Task<bool> SaveProject(VM_ProjectNew _projectvm)
        {
            Project entity = new Project()
            {
                ProjectCode = "P-1",
                ProjectTitle = _projectvm.ProjectTitle,
                ProjectTypeId = _projectvm.ProjectTypeId,
                ProjectPartCount = _projectvm.ProjectPartCount,
                ProjectDescription = _projectvm.ProjectDescription,
                InsertionDate = DateTime.Now,
                UserId = _projectvm.UserId,
                IsDelete = false,
                ProjectParts = new List<ProjectPart>()
            };
            entity.ProjectParts.Add(new ProjectPart()
            {
                PartNo = 1,
                ProjectPartTitle = _projectvm.ProjectPartTitle,
                ProjectPartFileUrl = _projectvm.ProjectPartFileUrl,
                ScriptTypeId = _projectvm.ScriptTypeId,
                InsertionDate = DateTime.Now,
                UserId = entity.UserId,
                IsDelete = false
            });
            this.context.Add<Project>(entity);
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateProject(VM_ProjectUpdate _projectvm)
        {
            Project async = await this.context.Project.FindAsync((object)_projectvm.ProjectId);
            if (async != null)
            {
                async.ProjectTitle = _projectvm.ProjectTitle;
                async.ProjectCode = _projectvm.ProjectCode;
                async.ProjectSummary = _projectvm.ProjectSummary;
                async.ProjectSummaryFileUrl = _projectvm.ProjectSummaryFileUrl;
                async.ProjectDescription = _projectvm.ProjectDescription;
                async.ProjectPartCount = _projectvm.ProjectPartCount;
                async.ProjectTypeId = _projectvm.ProjectTypeId;
            }
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteProject(int _projectId, string _userId)
        {
            int _result = 0;
            Project async = await this.context.Project.FindAsync((object)_projectId);
            if (async != null)
            {
                async.IsDelete = true;
                async.DeleteUserId = _userId;
                async.DeleteTime = new DateTime?(DateTime.Now);
                _result = await this.context.SaveChangesAsync();
            }
            return _result > 0;
        }
    }
}
