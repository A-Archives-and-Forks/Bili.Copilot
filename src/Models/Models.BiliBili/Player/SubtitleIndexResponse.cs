// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ļ������Ӧ���.
/// </summary>
public class SubtitleIndexResponse
{
    /// <summary>
    /// ֧���ύ.
    /// </summary>
    [JsonPropertyName("allow_submit")]
    public bool AllowSubmit { get; set; }

    /// <summary>
    /// ��Ļ�����б�.
    /// </summary>
    [JsonPropertyName("subtitles")]
    public List<SubtitleIndexItem> Subtitles { get; set; }
}

/// <summary>
/// ��Ļ������Ŀ.
/// </summary>
public class SubtitleIndexItem
{
    /// <summary>
    /// ��ĻId.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// ���Դ���.
    /// </summary>
    [JsonPropertyName("lan")]
    public string Language { get; set; }

    /// <summary>
    /// ��ʾ����.
    /// </summary>
    [JsonPropertyName("lan_doc")]
    public string DisplayLanguage { get; set; }

    /// <summary>
    /// ��Ļ��ַ.
    /// </summary>
    [JsonPropertyName("subtitle_url")]
    public string Url { get; set; }
}

