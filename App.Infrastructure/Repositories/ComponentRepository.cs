// Decompiled with JetBrains decompiler
// Type: App.Infrastructure.ComponentRepository
// Assembly: Scriptat.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0767F460-F976-434F-8FE7-B3A515E17ECC
// Assembly location: H:\Scriptat\API\Scriptat.Core.dll

using App.Application;
using App.Domain;
using System.Linq.Expressions;


#nullable enable
namespace App.Infrastructure
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ScriptatDBContext context;

        public ComponentRepository(ScriptatDBContext _context) => this.context = _context;

        public async Task<bool> AddElementImage(VM_ProjectElementImage _elementImage)
        {
            this.context.ProjectElementImage.Add(new ProjectElementImage()
            {
                ProjectElementId = _elementImage.ProjectElementId,
                ElementImageTitle = _elementImage.ProjectElementTitle,
                ElementImageUrl = _elementImage.ProjectElementImageUrl,
                IsApprove = false,
                InsertionDate = DateTime.Now,
                UserId = _elementImage.UserId,
                IsDelete = false
            });
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<List<VM_ComponentDropDownItem>> GetComponentDropDownList(int _projectId)
        {
            ParameterExpression parameterExpression;
            // ISSUE: method reference
            // ISSUE: method reference
            // ISSUE: method reference
            // ISSUE: method reference
            return new List<VM_ComponentDropDownItem>(); //this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>) (x => !x.ProjectId.HasValue || x.ProjectId.Value == _projectId)).Select<ComponentType, VM_ComponentDropDownItem>(Expression.Lambda<Func<ComponentType, VM_ComponentDropDownItem>>((Expression) Expression.MemberInit(Expression.New(typeof (VM_ComponentDropDownItem)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (VM_ComponentDropDownItem.set_ComponentTypeId)), )))); //unable to render the statement
        }

        public async Task<VM_ComponentDropDownLinkedList> GetComponentLinkedDropDownList(
          int _projectId,
          int _sceneId,
          int _componentId)
        {
            //List<VM_ComponentOption> _options = new List<VM_ComponentOption>();
            //_options.Add(new VM_ComponentOption()
            //{
            //  ComponentId = new int?(_componentId),
            //  IsParentElementImageExists = true,
            //  IsParentElementAliasExists = false,
            //  IsParentElementNestedExists = false,
            //  IsParentElementLinkedExists = false,
            //  IsParentElementCandidateExists = false,
            //  IsParentElementSceneArrayExists = false,
            //  IsParentElementProjectPartArrayExists = false,
            //  IsChildElementImageExists = false,
            //  IsChildElementAliasExists = false,
            //  IsChildElementNestedExists = false,
            //  IsChildElementLinkedExists = false,
            //  IsChildElementCandidateExists = false,
            //  IsChildElementSceneArrayExists = false,
            //  IsChildElementProjectPartArrayExists = false
            //});
            //VM_ComponentDropDownLinkedList _package = new VM_ComponentDropDownLinkedList();
            //List<ComponentTypeLink> _componentLinks = this.context.ComponentTypeLink.Where<ComponentTypeLink>((Expression<Func<ComponentTypeLink, bool>>) (x => x.ComponentTypeId == _componentId)).ToList<ComponentTypeLink>();
            //if (_componentLinks != null && _componentLinks.Count > 0)
            //{
            //  for (int i = 0; i < _componentLinks.Count; i++)
            //  {
            //    ComponentType componentType = this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>) (x => x.Id == _componentLinks[i].LinkedComponentTypeId)).SingleOrDefault<ComponentType>();
            //    VM_ComponentOption vmComponentOption = new VM_ComponentOption()
            //    {
            //      ComponentId = new int?(componentType.Id),
            //      IsParentElementImageExists = true,
            //      IsParentElementAliasExists = false,
            //      IsParentElementNestedExists = false,
            //      IsParentElementLinkedExists = false,
            //      IsParentElementCandidateExists = false,
            //      IsParentElementSceneArrayExists = false,
            //      IsParentElementProjectPartArrayExists = false,
            //      IsChildElementImageExists = false,
            //      IsChildElementAliasExists = false,
            //      IsChildElementNestedExists = false,
            //      IsChildElementLinkedExists = false,
            //      IsChildElementCandidateExists = false,
            //      IsChildElementSceneArrayExists = false,
            //      IsChildElementProjectPartArrayExists = false
            //    };
            //    _options.Add(vmComponentOption);
            //  }
            //}
            //List<VM_Component> componentList = await this.GetComponentList(_projectId, (int[]) null, _options);
            //if (componentList.Count > 0)
            //{
            //  for (int index1 = 0; index1 < componentList.Count; ++index1)
            //  {
            //    if (componentList[index1].ComponentTypeId == _componentId)
            //    {
            //      _package.SelectedComponentTypeId = _componentId;
            //      _package.SelectedComponentTitle = componentList[index1].ComponentTitle;
            //      if (componentList[index1].ComponentElements.Count > 0)
            //      {
            //        _package.SelectedComponentListItems = new List<VM_ComponentDropDownLinkedListItem>();
            //        for (int index2 = 0; index2 < componentList[index1].ComponentElements.Count; ++index2)
            //          _package.SelectedComponentListItems.Add(new VM_ComponentDropDownLinkedListItem()
            //          {
            //            ComponentId = componentList[index1].ComponentTypeId,
            //            ProjectElementId = componentList[index1].ComponentElements[index2].ProjectElementId,
            //            ProjectElementName = componentList[index1].ComponentElements[index2].ProjectElementName,
            //            ProjectElementImageUrl = componentList[index1].ComponentElements[index2].ProjectElementImageUrl
            //          });
            //      }
            //    }
            //    else
            //    {
            //      _package.LinkedComponentTypeId = _componentId;
            //      _package.LinkedComponentTitle = componentList[index1].ComponentTitle;
            //      if (componentList[index1].ComponentElements.Count > 0)
            //      {
            //        _package.LinkedComponentListItems = new List<VM_ComponentDropDownLinkedListItem>();
            //        for (int index3 = 0; index3 < componentList[index1].ComponentElements.Count; ++index3)
            //          _package.LinkedComponentListItems.Add(new VM_ComponentDropDownLinkedListItem()
            //          {
            //            ComponentId = componentList[index1].ComponentTypeId,
            //            ProjectElementId = componentList[index1].ComponentElements[index3].ProjectElementId,
            //            ProjectElementName = componentList[index1].ComponentElements[index3].ProjectElementName,
            //            ProjectElementImageUrl = componentList[index1].ComponentElements[index3].ProjectElementImageUrl
            //          });
            //      }
            //    }
            //  }
            //}
            //VM_ComponentDropDownLinkedList linkedDropDownList = _package;
            //_package = (VM_ComponentDropDownLinkedList) null;
            return new VM_ComponentDropDownLinkedList();//linkedDropDownList;
        }

        public async Task<List<VM_Component>> GetComponentList(
          int _projectId,
          int[]? _projectElementArray,
          List<VM_ComponentOption>? _options)
        {
            //int[] _elementArray;
            //if (_projectElementArray != null)
            //  _elementArray = _projectElementArray;
            //else
            //  _elementArray = this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>) (x => !x.IsDelete && x.ProjectId == _projectId)).Select<ProjectElement, int>((Expression<Func<ProjectElement, int>>) (x => x.Id)).ToArray<int>();
            //int[] _componentArray;
            //if (_options != null)
            //  _componentArray = _options.Select<VM_ComponentOption, int>((Func<VM_ComponentOption, int>) (x => x.ComponentId.Value)).ToArray<int>();
            //else
            //  _componentArray = this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>) (x => !x.ProjectId.HasValue || x.ProjectId == (int?) _projectId)).Select<ComponentType, int>((Expression<Func<ComponentType, int>>) (x => x.Id)).ToArray<int>();
            //bool _IsParentElementAliasExists = false;
            //bool _IsParentElementNestedExists = false;
            //bool _IsParentElementLinkedExists = false;
            //bool _IsParentElementImageExists = false;
            //bool _IsParentElementCandidateExists = false;
            //bool _IsParentElementSceneArrayExists = false;
            //bool _IsParentElementProjectPartArrayExists = false;
            //if (_options == null)
            //{
            //  _options = new List<VM_ComponentOption>();
            //  _options.Add(new VM_ComponentOption()
            //  {
            //    ComponentId = new int?(),
            //    IsParentElementImageExists = true,
            //    IsParentElementAliasExists = true,
            //    IsParentElementNestedExists = true,
            //    IsParentElementLinkedExists = true,
            //    IsParentElementCandidateExists = true,
            //    IsParentElementSceneArrayExists = true,
            //    IsParentElementProjectPartArrayExists = true,
            //    IsChildElementImageExists = true,
            //    IsChildElementAliasExists = true,
            //    IsChildElementNestedExists = true,
            //    IsChildElementLinkedExists = true,
            //    IsChildElementCandidateExists = true,
            //    IsChildElementSceneArrayExists = true,
            //    IsChildElementProjectPartArrayExists = true
            //  });
            //}
            //bool _generalComponentOption = _options != null && _options.Count<VM_ComponentOption>() == 1 && !_options[0].ComponentId.HasValue;
            //if (_generalComponentOption)
            //{
            //  _IsParentElementAliasExists = _options[0].IsParentElementAliasExists;
            //  int num1 = _options[0].IsChildElementAliasExists ? 1 : 0;
            //  _IsParentElementNestedExists = _options[0].IsParentElementNestedExists;
            //  int num2 = _options[0].IsChildElementNestedExists ? 1 : 0;
            //  _IsParentElementLinkedExists = _options[0].IsParentElementLinkedExists;
            //  int num3 = _options[0].IsChildElementLinkedExists ? 1 : 0;
            //  _IsParentElementImageExists = _options[0].IsParentElementImageExists;
            //  int num4 = _options[0].IsChildElementImageExists ? 1 : 0;
            //  _IsParentElementCandidateExists = _options[0].IsParentElementCandidateExists;
            //  int num5 = _options[0].IsChildElementCandidateExists ? 1 : 0;
            //  _IsParentElementSceneArrayExists = _options[0].IsParentElementSceneArrayExists;
            //  int num6 = _options[0].IsChildElementSceneArrayExists ? 1 : 0;
            //  _IsParentElementProjectPartArrayExists = _options[0].IsParentElementProjectPartArrayExists;
            //  int num7 = _options[0].IsChildElementProjectPartArrayExists ? 1 : 0;
            //}
            //List<ComponentType> _componentTypes = await this.context.ComponentType.Where<ComponentType>((Expression<Func<ComponentType, bool>>) (x => _componentArray.Contains<int>(x.Id))).OrderBy<ComponentType, int>((Expression<Func<ComponentType, int>>) (x => x.Id)).ToListAsync<ComponentType>();
            //List<VM_Component> _components = new List<VM_Component>();
            //if (_componentTypes.Count > 0)
            //{
            //  Project project = await this.context.Project.Where<Project>((Expression<Func<Project, bool>>) (p => p.Id == _projectId)).SingleOrDefaultAsync<Project>();
            //  List<ProjectElement> listAsync = await this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>) (x => _elementArray.Contains<int>(x.Id) && x.ProjectId == _projectId && _componentArray.Contains<int>(x.ComponentTypeId))).ToListAsync<ProjectElement>();
            //  for (int i = 0; i < _componentTypes.Count; i++)
            //  {
            //    VM_Component vmComponent = new VM_Component();
            //    vmComponent.ProjectId = _projectId;
            //    vmComponent.ComponentTypeId = _componentTypes[i].Id;
            //    vmComponent.ComponentTitle = _componentTypes[i].ComponentTitle;
            //    vmComponent.ComponentDescription = _componentTypes[i].ComponentDescription;
            //    vmComponent.OrderNo = _componentTypes[i].OrderNo;
            //    if (!_generalComponentOption && _options.LastOrDefault<VM_ComponentOption>((Func<VM_ComponentOption, bool>) (x =>
            //    {
            //      int? componentId = x.ComponentId;
            //      int id = _componentTypes[i].Id;
            //      return componentId.GetValueOrDefault() == id & componentId.HasValue;
            //    })) != null)
            //    {
            //      _IsParentElementImageExists = _options[0].IsParentElementImageExists;
            //      int num8 = _options[0].IsChildElementImageExists ? 1 : 0;
            //      _IsParentElementAliasExists = _options[0].IsParentElementAliasExists;
            //      int num9 = _options[0].IsChildElementAliasExists ? 1 : 0;
            //      _IsParentElementNestedExists = _options[0].IsParentElementNestedExists;
            //      int num10 = _options[0].IsChildElementNestedExists ? 1 : 0;
            //      _IsParentElementLinkedExists = _options[0].IsParentElementLinkedExists;
            //      int num11 = _options[0].IsChildElementLinkedExists ? 1 : 0;
            //      _IsParentElementCandidateExists = _options[0].IsParentElementCandidateExists;
            //      int num12 = _options[0].IsChildElementCandidateExists ? 1 : 0;
            //      _IsParentElementSceneArrayExists = _options[0].IsParentElementSceneArrayExists;
            //      int num13 = _options[0].IsChildElementSceneArrayExists ? 1 : 0;
            //      _IsParentElementProjectPartArrayExists = _options[0].IsParentElementProjectPartArrayExists;
            //      int num14 = _options[0].IsChildElementProjectPartArrayExists ? 1 : 0;
            //    }
            //    List<ProjectElement> list1 = this.context.ProjectElement.Where<ProjectElement>((Expression<Func<ProjectElement, bool>>) (x => x.ProjectId == _projectId && x.ComponentTypeId == _componentTypes[i].Id)).Include<ProjectElement, IEnumerable<ProjectElementImage>>((Expression<Func<ProjectElement, IEnumerable<ProjectElementImage>>>) (x => x.ProjectElementImages.Where<ProjectElementImage>((Func<ProjectElementImage, bool>) (s => !s.IsDelete)))).Include<ProjectElement, IEnumerable<ProjectElementLink>>((Expression<Func<ProjectElement, IEnumerable<ProjectElementLink>>>) (x => x.ProjectElementLinks.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (s => !s.IsDelete)))).ToList<ProjectElement>();
            //    int[] array1 = list1.Select<ProjectElement, int>((Func<ProjectElement, int>) (x => x.Id)).ToArray<int>();
            //    List<ProjectElementLink> list2 = list1.SelectMany<ProjectElement, ProjectElementLink>((Func<ProjectElement, IEnumerable<ProjectElementLink>>) (x => (IEnumerable<ProjectElementLink>) x.ProjectElementLinks)).Distinct<ProjectElementLink>().ToList<ProjectElementLink>();
            //    _elementAliasArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ElementLinkType == 1)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //    _elementCandidateArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ElementLinkType == 3)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //    int[] array2 = list2.Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.ProjectElementId)).Distinct<int>().ToArray<int>();
            //    int[] second = _elementAliasArray;
            //    int[] array3 = ((IEnumerable<int>) array1).Except<int>((IEnumerable<int>) second).Except<int>((IEnumerable<int>) _elementCandidateArray).ToArray<int>();
            //    _elementMainArray = new int[array2.Length + array3.Length];
            //    array2.CopyTo((Array) _elementMainArray, 0);
            //    array3.CopyTo((Array) _elementMainArray, array2.Length);
            //    if (_elementMainArray.Length != 0)
            //    {
            //      int[] _elementMainArray;
            //      _elementMainList = list1.Where<ProjectElement>(closure_13 ?? (closure_13 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementMainArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //      for (int c = 0; c < _elementMainList.Count; c++)
            //      {
            //        _elementAliasArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 1)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //        _elementNestedArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 2)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //        _elementLinkedArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 4)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //        _elementCandidateArray = list2.Where<ProjectElementLink>((Func<ProjectElementLink, bool>) (x => x.ProjectElementId == _elementMainList[c].Id && x.ElementLinkType == 3)).Select<ProjectElementLink, int>((Func<ProjectElementLink, int>) (x => x.LinkedProjectElementId)).Distinct<int>().ToArray<int>();
            //        VM_ComponentElement componentElement = new VM_ComponentElement();
            //        componentElement.ProjectId = _elementMainList[c].ProjectId;
            //        componentElement.ComponentId = _elementMainList[c].ComponentTypeId;
            //        componentElement.ProjectElementId = _elementMainList[c].Id;
            //        componentElement.ProjectElementName = _elementMainList[c].ElementName;
            //        componentElement.ProjectElementDescription = _elementMainList[c].ElementDescription;
            //        if (_IsParentElementImageExists && _elementMainList[c].ProjectElementImages != null)
            //        {
            //          List<ProjectElementImage> projectElementImages = _elementMainList[c].ProjectElementImages;
            //          componentElement.ProjectElementImages = new List<VM_ComponentElementImage>();
            //          componentElement.ProjectElementImages.AddRange(_elementMainList[c].ProjectElementImages.Select<ProjectElementImage, VM_ComponentElementImage>((Func<ProjectElementImage, VM_ComponentElementImage>) (x => new VM_ComponentElementImage()
            //          {
            //            Id = x.Id,
            //            ProjectElementId = x.ProjectElementId,
            //            ElementImageTitle = x.ElementImageTitle,
            //            ElementImageUrl = x.ElementImageUrl,
            //            IsApprove = x.IsApprove
            //          })));
            //        }
            //        int[] _elementAliasArray;
            //        if (_IsParentElementAliasExists && listAsync.Any<ProjectElement>(closure_5 ?? (closure_5 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementAliasArray).Contains<int>(x.Id)))))
            //        {
            //          List<ProjectElement> list3 = listAsync.Where<ProjectElement>(closure_6 ?? (closure_6 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementAliasArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //          componentElement.ProjectElementAliases = new List<VM_ComponentElementChild>();
            //          componentElement.ProjectElementAliases.AddRange(list3.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>) (x => new VM_ComponentElementChild()
            //          {
            //            ProjectElementId = x.Id,
            //            ProjectId = x.ProjectId,
            //            IsApprove = x.IsApprove,
            //            ComponentId = x.ComponentTypeId,
            //            ProjectElementName = x.ElementName,
            //            ProjectElementDescription = x.ElementDescription
            //          })));
            //        }
            //        int[] _elementNestedArray;
            //        if (_IsParentElementNestedExists && listAsync.Any<ProjectElement>(closure_7 ?? (closure_7 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementNestedArray).Contains<int>(x.Id)))))
            //        {
            //          List<ProjectElement> list4 = listAsync.Where<ProjectElement>(closure_8 ?? (closure_8 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementNestedArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //          componentElement.ProjectElementNestedElements = new List<VM_ComponentElementChild>();
            //          componentElement.ProjectElementNestedElements.AddRange(list4.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>) (x => new VM_ComponentElementChild()
            //          {
            //            ProjectElementId = x.Id,
            //            ProjectId = x.ProjectId,
            //            IsApprove = x.IsApprove,
            //            ComponentId = x.ComponentTypeId,
            //            ProjectElementName = x.ElementName,
            //            ProjectElementDescription = x.ElementDescription
            //          })));
            //        }
            //        int[] _elementLinkedArray;
            //        if (_IsParentElementLinkedExists && listAsync.Any<ProjectElement>(closure_9 ?? (closure_9 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementLinkedArray).Contains<int>(x.Id)))))
            //        {
            //          List<ProjectElement> list5 = listAsync.Where<ProjectElement>(closure_10 ?? (closure_10 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementLinkedArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //          componentElement.ProjectElementLinkedElements = new List<VM_ComponentElementChild>();
            //          componentElement.ProjectElementLinkedElements.AddRange(list5.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>) (x => new VM_ComponentElementChild()
            //          {
            //            ProjectElementId = x.Id,
            //            ProjectId = x.ProjectId,
            //            IsApprove = x.IsApprove,
            //            ComponentId = x.ComponentTypeId,
            //            ProjectElementName = x.ElementName,
            //            ProjectElementDescription = x.ElementDescription
            //          })));
            //        }
            //        int[] _elementCandidateArray;
            //        if (_IsParentElementCandidateExists && listAsync.Any<ProjectElement>(closure_11 ?? (closure_11 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementCandidateArray).Contains<int>(x.Id)))))
            //        {
            //          List<ProjectElement> list6 = listAsync.Where<ProjectElement>(closure_12 ?? (closure_12 = (Func<ProjectElement, bool>) (x => ((IEnumerable<int>) _elementCandidateArray).Contains<int>(x.Id)))).ToList<ProjectElement>();
            //          componentElement.ProjectElementCandidates = new List<VM_ComponentElementChild>();
            //          componentElement.ProjectElementCandidates.AddRange(list6.Select<ProjectElement, VM_ComponentElementChild>((Func<ProjectElement, VM_ComponentElementChild>) (x => new VM_ComponentElementChild()
            //          {
            //            ProjectElementId = x.Id,
            //            ProjectId = x.ProjectId,
            //            IsApprove = x.IsApprove,
            //            ComponentId = x.ComponentTypeId,
            //            ProjectElementName = x.ElementName,
            //            ProjectElementDescription = x.ElementDescription
            //          })));
            //          ProjectElement projectElement = list6.Where<ProjectElement>((Func<ProjectElement, bool>) (x => x.IsApprove)).LastOrDefault<ProjectElement>();
            //          if (projectElement != null)
            //          {
            //            componentElement.ProjectElementCandidateName = projectElement.ElementName;
            //            if (projectElement.ProjectElementImages != null)
            //            {
            //              ProjectElementImage projectElementImage = projectElement.ProjectElementImages.Where<ProjectElementImage>((Func<ProjectElementImage, bool>) (x => x.IsApprove)).LastOrDefault<ProjectElementImage>();
            //              if (projectElementImage != null)
            //                componentElement.ProjectElementImageUrl = projectElementImage.ElementImageUrl;
            //            }
            //          }
            //        }
            //        if (_IsParentElementSceneArrayExists)
            //          componentElement.SceneArray = _elementMainArray;
            //        if (_IsParentElementProjectPartArrayExists)
            //          componentElement.ProjectPartArray = _elementMainArray;
            //        if (componentElement.ProjectElementImageUrl == null && componentElement.ProjectElementImages != null && componentElement.ProjectElementImages.Count > 0)
            //          componentElement.ProjectElementImageUrl = !componentElement.ProjectElementImages.Any<VM_ComponentElementImage>((Func<VM_ComponentElementImage, bool>) (x => x.IsApprove)) ? componentElement.ProjectElementImages.FirstOrDefault<VM_ComponentElementImage>().ElementImageUrl : componentElement.ProjectElementImages.Where<VM_ComponentElementImage>((Func<VM_ComponentElementImage, bool>) (x => x.IsApprove)).LastOrDefault<VM_ComponentElementImage>().ElementImageUrl;
            //        if (vmComponent.ComponentElements == null)
            //          vmComponent.ComponentElements = new List<VM_ComponentElement>();
            //        vmComponent.ComponentElements.Add(componentElement);
            //      }
            //    }
            //    vmComponent.ProjectPartArray = _elementMainArray;
            //    vmComponent.SceneArray = _elementMainArray;
            //    _components.Add(vmComponent);
            //  }
            //}
            //List<VM_Component> componentList = _components;
            //_components = (List<VM_Component>) null;
            return new List<VM_Component>(); //componentList;
        }
    }
}
