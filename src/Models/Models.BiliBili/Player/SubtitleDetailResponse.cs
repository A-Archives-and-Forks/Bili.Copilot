// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ļ������Ӧ���.
/// </summary>
public class SubtitleDetailResponse
{
    /// <summary>
    /// ��Ļ�б�.
    /// </summary>
    [JsonPropertyName("body")]
    public List<SubtitleItem> Body { get; set; }
}

/// <summary>
/// ��Ļ��Ŀ.
/// </summary>
public class SubtitleItem
{
    /// <summary>
    /// ��ʼʱ��.
    /// </summary>
    [JsonPropertyName("from")]
    public double From { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("to")]
    public double To { get; set; }

    /// <summary>
    /// ��Ļ����.
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; }
}

