// Decompiled with JetBrains decompiler
// Type: App.Application.ProjectList.VM_ProjectCardCharacter
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectCardCharacter
{
    public int SceneCount { get; set; }

    public int CharacterId { get; set; }

    public string CharacterName { get; set; }

    public string CandidateName { get; set; }

    public string CandidateImageUrl { get; set; }

    public List<VM_ProjectCardCharacterAlias> ProjectCharacterAliases { get; set; }

    public List<VM_ProjectCardCharacterCandidate> ProjectCharacterCandidates { get; set; }
}
