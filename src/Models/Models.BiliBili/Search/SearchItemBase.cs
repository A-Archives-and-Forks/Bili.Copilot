// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ������Ŀ����.
/// </summary>
public class SearchItemBase
{
    /// <summary>
    /// ׷��Id.
    /// </summary>
    [JsonPropertyName("trackid")]
    public string TrackId { get; set; }

    /// <summary>
    /// ��������. bgm_mediaָ�����������ݣ�app_userָ�û���videoָ��Ƶ.
    /// </summary>
    [JsonPropertyName("linktype")]
    public string LinkType { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("position")]
    public int Position { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }

    /// <summary>
    /// ������ͨ��ָId.
    /// </summary>
    [JsonPropertyName("param")]
    public string Parameter { get; set; }

    /// <summary>
    /// Ŀ��ָ������.
    /// </summary>
    [JsonPropertyName("goto")]
    public string Goto { get; set; }
}

