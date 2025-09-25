// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectNavigator
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectNavigator
{
    public int ProjectTypeId { get; set; }

    public string ProjectTypeTitle { get; set; }

    public int ProjectId { get; set; }

    public string ProjectTitle { get; set; }

    public int ProjectPartCount { get; set; }

    public string? ProjectSummary { get; set; }

    public string? ProjectDescription { get; set; }

    public List<VM_ProjectNavigatorPartCard> ProjectParts { get; set; }

    public List<VM_ProjectNavigatorSideElement> ProjectLocations { get; set; }

    public List<VM_ProjectNavigatorSideElement> ProjectCharacters { get; set; }
}
