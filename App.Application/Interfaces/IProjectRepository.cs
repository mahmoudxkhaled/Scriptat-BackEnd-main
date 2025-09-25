// Decompiled with JetBrains decompiler
// Type: App.Application.IProjectRepository
// Assembly: Scriptat.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0767F460-F976-434F-8FE7-B3A515E17ECC
// Assembly location: H:\Scriptat\API\Scriptat.Core.dll


#nullable enable
using App.Domain;

namespace App.Application
{
    public interface IProjectRepository
    {
        Task<List<ScriptType>> GetScriptTypeList();

        Task<List<VM_ProjectCard>> GetProjectList(string _userid);

        Task<bool> SaveProject(VM_ProjectNew _projectvm);

        Task<bool> UpdateProject(VM_ProjectUpdate _project);

        Task<bool> DeleteProject(int _projectId, string _userId);
    }
}
