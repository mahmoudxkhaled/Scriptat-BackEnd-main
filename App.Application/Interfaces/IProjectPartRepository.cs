// Decompiled with JetBrains decompiler
// Type: App.Application.IProjectPartRepository
// Assembly: Scriptat.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0767F460-F976-434F-8FE7-B3A515E17ECC
// Assembly location: H:\Scriptat\API\Scriptat.Core.dll

using App.Application;
using App.Application;
using App.Application;
using System.Threading.Tasks;


#nullable enable
namespace App.Application
{
  public interface IProjectPartRepository
  {
    Task<VM_ProjectDetail> GetProjectDetailDataVeiw(int id);

    Task<VM_ProjectNavigator> GetProjectDetailCardVeiw(int projectid);

    Task<VM_ProjectNavigator> GetProjectDetailCardVeiwByPartId(int projectpartid);

    Task<bool> SaveProjectPart(VM_ProjectPartNew _projectPartvm);

    Task<bool> UpdateProjectPart(VM_ProjectPartUpdate _projectPartvm);

    Task<bool> DeleteProjectPart(int _projectPartId, string _userId);
  }
}
