// Decompiled with JetBrains decompiler
// Type: App.Application.ProjectList.VM_ScriptTypeInstruction
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ScriptTypeInstruction
{
    public int ScriptTypeId { get; set; }

    public string ScriptTypeName { get; set; }

    public string? InstructionImageUrl { get; set; }

    public string? ScriptTypeInstructionHtml { get; set; }
}
