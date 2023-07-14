// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �����Ƽ���Ŀ.
/// </summary>
public class SearchSquareItem
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ��Ӧ����.
    /// </summary>
    [JsonPropertyName("data")]
    public SearchSquareData Data { get; set; }
}

/// <summary>
/// �����Ƽ��ľ�����Ŀ����.
/// </summary>
public class SearchSquareData
{
    /// <summary>
    /// ��Ӧ����.
    /// </summary>
    [JsonPropertyName("trackid")]
    public string TrackId { get; set; }

    /// <summary>
    /// ����������Ŀ.
    /// </summary>
    [JsonPropertyName("list")]
    public List<SearchRecommendItem> List { get; set; }

    /// <summary>
    /// ������ʾ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

/// <summary>
/// ����������Ŀ.
/// </summary>
public class SearchRecommendItem
{
    /// <summary>
    /// �����ؼ���.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string Keyword { get; set; }

    /// <summary>
    /// ��ʾ����.
    /// </summary>
    [JsonPropertyName("show_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Ҫ��ʾ��ͼ��.
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("position")]
    public int Position { get; set; }

    /// <summary>
    /// ���⣨�������Ƽ�����Ч��.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// �������ͣ��������Ƽ�����Ч��ͨ��Ϊguess��.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// �����Id���������Ƽ�����Ч��ͨ��Ϊ��ǩId��.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

