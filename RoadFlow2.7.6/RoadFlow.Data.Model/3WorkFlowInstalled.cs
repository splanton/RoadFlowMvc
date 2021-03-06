﻿// Decompiled with JetBrains decompiler
// Type: RoadFlow.Data.Model.WorkFlowInstalledSub.Step
// Assembly: RoadFlow.Data.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B924143B-AEC1-4AFA-B627-1D84458A850C
// Assembly location: C:\inetpub\wwwroot\RoadFlowMvc\bin\RoadFlow.Data.Model.dll

using RoadFlow.Data.Model.WorkFlowInstalledSub.StepSet;
using System;
using System.Collections.Generic;

namespace RoadFlow.Data.Model.WorkFlowInstalledSub
{
  [Serializable]
  public class Step
  {
    public Guid ID { get; set; }

    public string Type { get; set; }

    public string Name { get; set; }

    public int OpinionDisplay { get; set; }

    public int ExpiredPrompt { get; set; }

    public int SignatureType { get; set; }

    public Decimal WorkTime { get; set; }

    public Decimal LimitTime { get; set; }

    public Decimal OtherTime { get; set; }

    public int Archives { get; set; }

    public string ArchivesParams { get; set; }

    public int DataSaveType { get; set; }

    public string DataSaveTypeWhere { get; set; }

    public string Note { get; set; }

    public string SendShowMsg { get; set; }

    public string BackShowMsg { get; set; }

    public Behavior Behavior { get; set; }

    public IEnumerable<Form> Forms { get; set; }

    public IEnumerable<Button> Buttons { get; set; }

    public IEnumerable<RoadFlow.Data.Model.WorkFlowInstalledSub.StepSet.FieldStatus> FieldStatus { get; set; }

    public CopyFor CopyFor { get; set; }

    public Event Event { get; set; }

    public Decimal Position_x { get; set; }

    public Decimal Position_y { get; set; }

    public string SubFlowID { get; set; }

    public int SubFlowTaskType { get; set; }

    public int SendSetWorkTime { get; set; }

    public int TimeOutModel { get; set; }
  }
}
