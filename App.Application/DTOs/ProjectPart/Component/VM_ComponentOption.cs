// Decompiled with JetBrains decompiler
// Type: App.Application.Component.VM_ComponentOption
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll

namespace App.Application;

public class VM_ComponentOption
{
    public int? ComponentId { get; set; }

    public bool IsParentElementAliasExists { get; set; }

    public bool IsChildElementAliasExists { get; set; }

    public bool IsParentElementNestedExists { get; set; }

    public bool IsChildElementNestedExists { get; set; }

    public bool IsParentElementLinkedExists { get; set; }

    public bool IsChildElementLinkedExists { get; set; }

    public bool IsParentElementImageExists { get; set; }

    public bool IsChildElementImageExists { get; set; }

    public bool IsParentElementCandidateExists { get; set; }

    public bool IsChildElementCandidateExists { get; set; }

    public bool IsParentElementSceneArrayExists { get; set; }

    public bool IsChildElementSceneArrayExists { get; set; }

    public bool IsParentElementProjectPartArrayExists { get; set; }

    public bool IsChildElementProjectPartArrayExists { get; set; }
}
