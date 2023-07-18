// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ�������������Ӧ���.
/// </summary>
public class LiveAreaDetailResponse
{
    /// <summary>
    /// �ӱ�ǩ.
    /// </summary>
    [JsonPropertyName("new_tags")]
    public List<LiveAreaDetailTag> Tags { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// ֱ�����б�.
    /// </summary>
    [JsonPropertyName("list")]
    public List<LiveFeedRoom> List { get; set; }
}

/// <summary>
/// ֱ����������ӱ�ǩ.
/// </summary>
public class LiveAreaDetailTag
{
    /// <summary>
    /// ��ǩId.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ǩ��.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ����ʽ.
    /// </summary>
    [JsonPropertyName("sort_type")]
    public string SortType { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object obj) => obj is LiveAreaDetailTag tag && Id == tag.Id;

    /// <inheritdoc/>
    public override int GetHashCode() => 2108858624 + Id.GetHashCode();
}

