// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// רҵ����������Ӧ�����������������Ӱ�����Ӿ磬��¼Ƭ�ȷ��û��������ݣ�.
/// </summary>
public class PgcResponse
{
    /// <summary>
    /// ����Դ��ʶ.
    /// </summary>
    [JsonPropertyName("feed")]
    public PgcFeedIdentifier FeedIdentifier { get; set; }

    /// <summary>
    /// ģ��.
    /// </summary>
    [JsonPropertyName("modules")]
    public List<PgcModule> Modules { get; set; }

    /// <summary>
    /// �´������ָ��.
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public string NextCursor { get; set; }
}

/// <summary>
/// PGC����Դ��ʶ.
/// </summary>
public class PgcFeedIdentifier
{
    /// <summary>
    /// ��������Id.
    /// </summary>
    [JsonPropertyName("fall_wid")]
    public List<int> PartitionIds { get; set; }

    /// <summary>
    /// ����Դ����.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

