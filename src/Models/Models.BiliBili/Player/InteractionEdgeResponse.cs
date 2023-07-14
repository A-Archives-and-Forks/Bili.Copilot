// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ������Ƶѡ����Ӧ.
/// </summary>
public class InteractionEdgeResponse
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ѡ���б�.
    /// </summary>
    [JsonPropertyName("edges")]
    public InteractionEdge Edges { get; set; }

    /// <summary>
    /// ���ر���.
    /// </summary>
    [JsonPropertyName("hidden_vars")]
    public List<InteractionHiddenVariable> HiddenVariables { get; set; }
}

/// <summary>
/// ������Ƶѡȡ.
/// </summary>
public class InteractionEdge
{
    /// <summary>
    /// ������Ƶ����.
    /// </summary>
    [JsonPropertyName("questions")]
    public List<InteractionQuestion> Questions { get; set; }
}

/// <summary>
/// ������Ƶ����.
/// </summary>
public class InteractionQuestion
{
    /// <summary>
    /// ѡ���б�.
    /// </summary>
    [JsonPropertyName("choices")]
    public List<InteractionChoice> Choices { get; set; }
}

/// <summary>
/// ������Ƶѡ��.
/// </summary>
public class InteractionChoice
{
    /// <summary>
    /// ѡ��Id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// �������.
    /// </summary>
    [JsonPropertyName("condition")]
    public string Condition { get; set; }

    /// <summary>
    /// ��Ӧ��P Id.
    /// </summary>
    [JsonPropertyName("cid")]
    public int PartId { get; set; }

    /// <summary>
    /// ѡ��.
    /// </summary>
    [JsonPropertyName("option")]
    public string Option { get; set; }
}

/// <summary>
/// ���ر���.
/// </summary>
public class InteractionHiddenVariable
{
    /// <summary>
    /// ֵ.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }

    /// <summary>
    /// ��ʶ.
    /// </summary>
    [JsonPropertyName("id_v2")]
    public string Id { get; set; }
}

