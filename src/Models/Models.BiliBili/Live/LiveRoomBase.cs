// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ�������.
/// </summary>
public class LiveRoomBase
{
    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("uid")]
    public long UserId { get; set; }

    /// <summary>
    /// ֱ�������.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ֱ�������.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// �����������б�.
    /// </summary>
    [JsonPropertyName("quality_description")]
    public List<LiveQualityDescription> QualityDescriptionList { get; set; }

    /// <summary>
    /// �Ự��ʶ��.
    /// </summary>
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }

    /// <summary>
    /// �����ʶ��.
    /// </summary>
    [JsonPropertyName("group_id")]
    public int GroupId { get; set; }

    /// <summary>
    /// ���߹ۿ�����.
    /// </summary>
    [JsonPropertyName("online")]
    public int ViewerCount { get; set; }

    /// <summary>
    /// ���ŵ�ַ.
    /// </summary>
    [JsonPropertyName("play_url")]
    public string PlayUrl { get; set; }

    /// <summary>
    /// H265���ŵ�ַ.
    /// </summary>
    [JsonPropertyName("play_url_h265")]
    public string H265PlayUrl { get; set; }

    /// <summary>
    /// ��ǰ������.
    /// </summary>
    [JsonPropertyName("current_quality")]
    public int CurrentQuality { get; set; }

    /// <summary>
    /// �Ծ���ֱ����Id.
    /// </summary>
    [JsonPropertyName("pk_id")]
    public int PkId { get; set; }

    /// <summary>
    /// ֱ�����ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }
}

/// <summary>
/// ֱ��������˵��.
/// </summary>
public class LiveQualityDescription
{
    /// <summary>
    /// �����ȱ�ʶ.
    /// </summary>
    [JsonPropertyName("qn")]
    public int Quality { get; set; }

    /// <summary>
    /// ������˵��.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object obj) => obj is LiveQualityDescription description && Quality == description.Quality;

    /// <inheritdoc/>
    public override int GetHashCode() => -141866058 + Quality.GetHashCode();
}

