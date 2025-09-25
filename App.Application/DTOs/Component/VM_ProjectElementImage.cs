// Decompiled with JetBrains decompiler
// Type: App.Application.Component.VM_ProjectElementImage
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

public class VM_ProjectElementImage
{
    public int Id { get; set; }

    public int ProjectElementId { get; set; }

    public string ProjectElementTitle { get; set; }

    public string ProjectElementImageUrl { get; set; }

    public string UserId { get; set; }
}
